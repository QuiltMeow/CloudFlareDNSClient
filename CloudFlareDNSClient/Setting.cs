using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public class SettingData
    {
        private const int DEFAULT_INTERVAL = 5;

        public string mail
        {
            get;
            set;
        }

        public string apiAccess
        {
            get;
            set;
        }

        public int interval
        {
            get;
            set;
        }

        public ISet<SelectDomain> selectDomain
        {
            get;
            set;
        }

        public bool startMinimum
        {
            get;
            set;
        }

        public string zoneId
        {
            get;
            set;
        }

        public IPDetectMethod ipDetectMethod
        {
            get;
            set;
        }

        public APIAccessMethod apiAccessMethod
        {
            get;
            set;
        }

        public string adapter
        {
            get;
            set;
        }

        public bool forceUpdate
        {
            get;
            set;
        }

        public PublicIPAPIURL publicIPAPIURL
        {
            get;
            private set;
        }

        public SettingData()
        {
            loadDefault();
        }

        public void loadDefault()
        {
            mail = apiAccess = zoneId = adapter = string.Empty;
            interval = DEFAULT_INTERVAL;
            selectDomain = new HashSet<SelectDomain>();
            ipDetectMethod = IPDetectMethod.REMOTE;
            apiAccessMethod = APIAccessMethod.API_KEY;
            startMinimum = forceUpdate = false;
            publicIPAPIURL = new PublicIPAPIURL();
        }

        public bool validate()
        {
            return !(string.IsNullOrWhiteSpace(mail)
                || !mail.Contains("@")
                || string.IsNullOrWhiteSpace(apiAccess));
        }
    }

    public class IPData
    {
        public string ip4Address
        {
            get;
            set;
        }

        public string ip6Address
        {
            get;
            set;
        }

        public IPData()
        {
            resetLastIP();
        }

        public void resetLastIP()
        {
            ip4Address = ip6Address = string.Empty;
        }
    }

    public class PublicIPAPIURL
    {
        public string ip4APIURL
        {
            get;
            set;
        }

        public string ip6APIURL
        {
            get;
            set;
        }

        public PublicIPAPIURL()
        {
            reset();
        }

        public void reset()
        {
            ip4APIURL = ip6APIURL = string.Empty;
        }
    }

    public class Setting : SettingData, Akatsukible
    {
        private const int MIN_INTERVAL = 1;
        private const int MAX_INTERVAL = 1440;

        private const string DATA_DIRECTORY = "CloudFlareDUC";
        private const string CONFIG_FILE = "config.ew";

        private static readonly byte[] HEADER = new byte[] {
            0x41, 0x4A
        };

        private string settingFilePath;

        public IPData ip
        {
            get;
            private set;
        }

        public Setting()
        {
            ip = new IPData();
            if (!File.Exists(getSettingFilePath()))
            {
                save();
                return;
            }
            loadSetting();
        }

        private void loadSetting()
        {
            try
            {
                using (FileStream fs = new FileStream(getSettingFilePath(), FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        if (br.ReadByte() != HEADER[0] || br.ReadByte() != HEADER[1])
                        {
                            throw new Exception("無效的標頭");
                        }

                        mail = br.ReadString();
                        apiAccess = br.ReadString();

                        interval = br.ReadInt32();
                        if (interval < MIN_INTERVAL || interval > MAX_INTERVAL)
                        {
                            throw new Exception("無效的更新間隔");
                        }

                        selectDomain = new HashSet<SelectDomain>();
                        int domainCount = br.ReadInt32();
                        for (int i = 1; i <= domainCount; ++i)
                        {
                            SelectDomain domain = new SelectDomain()
                            {
                                zoneName = br.ReadString(),
                                dnsName = br.ReadString()
                            };
                            if (domain.zoneName == string.Empty || domain.dnsName == string.Empty)
                            {
                                throw new Exception("無效的選取域名");
                            }
                            selectDomain.Add(domain);
                        }
                        if (domainCount != selectDomain.Count)
                        {
                            throw new Exception("選取域名包含重複資料");
                        }

                        startMinimum = br.ReadBoolean();
                        zoneId = br.ReadString();

                        ipDetectMethod = br.ReadInt32() == 0 ? IPDetectMethod.LOCAL : IPDetectMethod.REMOTE;
                        apiAccessMethod = br.ReadInt32() == 0 ? APIAccessMethod.API_KEY : APIAccessMethod.API_TOKEN;
                        adapter = br.ReadString();
                        forceUpdate = br.ReadBoolean();

                        publicIPAPIURL.ip4APIURL = br.ReadString();
                        publicIPAPIURL.ip6APIURL = br.ReadString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"設定檔案讀取失敗 載入預設設定值 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadDefault();
                save();
            }
        }

        public void save()
        {
            try
            {
                using (FileStream fs = new FileStream(getSettingFilePath(), FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter bw = new BinaryWriter(fs))
                    {
                        bw.Write(HEADER[0]);
                        bw.Write(HEADER[1]);

                        bw.Write(mail);
                        bw.Write(apiAccess);
                        bw.Write(interval);

                        bw.Write(selectDomain.Count);
                        foreach (SelectDomain domain in selectDomain)
                        {
                            bw.Write(domain.zoneName);
                            bw.Write(domain.dnsName);
                        }

                        bw.Write(startMinimum);
                        bw.Write(zoneId);

                        bw.Write(ipDetectMethod == IPDetectMethod.LOCAL ? 0 : 1);
                        bw.Write(apiAccessMethod == APIAccessMethod.API_KEY ? 0 : 1);
                        bw.Write(adapter);
                        bw.Write(forceUpdate);

                        bw.Write(publicIPAPIURL.ip4APIURL);
                        bw.Write(publicIPAPIURL.ip6APIURL);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"設定檔案儲存失敗 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getSettingFilePath()
        {
            if (settingFilePath == null)
            {
                string localApplicationDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string directory = Path.Combine(localApplicationDataDirectory, DATA_DIRECTORY);
                Directory.CreateDirectory(directory);
                settingFilePath = Path.Combine(directory, CONFIG_FILE);
            }
            return settingFilePath;
        }
    }

    public class SelectDomain
    {
        public string zoneName
        {
            get;
            set;
        }

        public string dnsName
        {
            get;
            set;
        }

        public override bool Equals(object right)
        {
            SelectDomain target = right as SelectDomain;
            if (target == null)
            {
                return false;
            }
            return zoneName == target.zoneName && dnsName == target.dnsName;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (zoneName ?? string.Empty).GetHashCode();
                hash = hash * 23 + (dnsName ?? string.Empty).GetHashCode();
                return hash;
            }
        }
    }
}