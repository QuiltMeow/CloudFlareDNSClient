using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace CloudFlareDNSClient
{
    public static class Util
    {
        private const int MAX_ATTEMPT = 3;

        public static string getPublicIPAddress(IPProtocol protocol, HttpClient client, out string errorMesssage)
        {
            string ret = null;
            errorMesssage = null;

            int attempt = 0;
            string url = protocol == IPProtocol.IPv4 ? "https://ip4.seeip.org/" : "http://v6.ipv6-test.com/api/myip.php";
            while (ret == null && attempt < MAX_ATTEMPT)
            {
                ++attempt;
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.ConnectionClose = true;

                    string response = client.SendAsync(request).Result.Content.ReadAsStringAsync().Result;
                    string candidatePublicIPAddress = response.Replace("\n", string.Empty);

                    if (!isValidIPAddress(protocol, candidatePublicIPAddress))
                    {
                        throw new Exception($"無效的回應格式 : {response}");
                    }
                    ret = candidatePublicIPAddress;
                }
                catch (Exception ex)
                {
                    if (attempt >= MAX_ATTEMPT)
                    {
                        errorMesssage = ex.Message;
                    }
                }
            }
            return ret;
        }

        public static bool isValidIPAddress(IPProtocol protocol, string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
            {
                return false;
            }

            switch (protocol)
            {
                case IPProtocol.IPv4:
                    {
                        string[] splitValue = ip.Split('.');
                        if (splitValue.Length != 4)
                        {
                            return false;
                        }
                        byte parse;
                        return splitValue.All(value => byte.TryParse(value, out parse));
                    }
                case IPProtocol.IPv6:
                    {
                        Regex expression = new Regex(@"(?:^|(?<=\s))(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))(?=\s|$)");
                        Match match = expression.Match(ip);
                        return match.Success;
                    }
            }
            return false;
        }

        public static string queryAdapterIP(string name, IPProtocol protocol)
        {
            try
            {
                foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (adapter.Name == name)
                    {
                        foreach (UnicastIPAddressInformation ip in adapter.GetIPProperties().UnicastAddresses)
                        {
                            switch (protocol)
                            {
                                case IPProtocol.IPv4:
                                    {
                                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                                        {
                                            return ip.Address.ToString();
                                        }
                                        break;
                                    }
                                case IPProtocol.IPv6:
                                    {
                                        if (ip.Address.AddressFamily == AddressFamily.InterNetworkV6)
                                        {
                                            return ip.Address.ToString();
                                        }
                                        break;
                                    }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogUtil.appendLog($"取得網路卡 IP 時發生例外狀況 : {ex.Message}");
            }
            return null;
        }

        public static string runCommand(string command)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                string stdOut;
                try
                {
                    process.Start();
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");

                    stdOut = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    stdOut = ex.Message;
                }
                return stdOut;
            }
        }
    }
}