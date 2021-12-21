using CloudFlareDNSClient.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class MainForm : Form
    {
        private const int NOTICE_DURATION = 3000;
        private const int TOOL_TIP_SHOW_DURATION = 32000;
        private int tick;

        private HttpClient client;
        private CloudflareAPI cloudFlare;
        private readonly Setting setting;

        public MainForm()
        {
            InitializeComponent();
            initToolTip();

            setting = new Setting();
            processFirstRun();
            if (setting.startMinimum)
            {
                hideWindow();
            }
        }

        private void initToolTip()
        {
            ToolTip account = new ToolTip()
            {
                AutoPopDelay = TOOL_TIP_SHOW_DURATION
            };
            account.SetToolTip(pbAccountHelp, Resources.AccountToolTip);

            ToolTip host = new ToolTip()
            {
                AutoPopDelay = TOOL_TIP_SHOW_DURATION
            };
            host.SetToolTip(pbHostHelp, Resources.HostToolTip);

            ToolTip ip = new ToolTip()
            {
                AutoPopDelay = TOOL_TIP_SHOW_DURATION
            };
            ip.SetToolTip(pbIPAddressHelp, Resources.IPToolTip);
        }

        private void processFirstRun()
        {
            if (!setting.validate())
            {
                openAccountForm();
                if (!setting.validate())
                {
                    exit();
                }
            }
        }

        public static void openForm(Type type)
        {
            using (Form form = (Form)Activator.CreateInstance(type))
            {
                form.ShowDialog();
            }
        }

        private static void exit()
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void openAccountForm()
        {
            timerUpdate.Stop();
            using (AccountForm form = new AccountForm(setting))
            {
                form.ShowDialog();
                if (form.update)
                {
                    setting.ip.resetLastIP();
                    updateAll();
                }
                else
                {
                    timerUpdate.Start();
                }
            }
        }

        private void resetTick()
        {
            tick = setting.interval * 60;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            cloudFlare = new CloudflareAPI(client, setting);
            updateStatusBar("就緒");
            updateAll();
        }

        private void updateAll()
        {
            updateAccountStatus();
            updateHostStatus();
            updateCloudFlareDNS();
        }

        private void updateIPAddressUI(IPProtocol protocol, string ip)
        {
            switch (protocol)
            {
                case IPProtocol.IPv4:
                    {
                        labelIP4Address.Text = $"IPv4 : {ip}";
                        break;
                    }
                case IPProtocol.IPv6:
                    {
                        labelIP6Address.Text = $"IPv6 : {ip}";
                        break;
                    }
            }
        }

        private static void setResultIcon(PictureBox control, ResultIcon icon)
        {
            switch (icon)
            {
                case ResultIcon.SUCCESS:
                    {
                        control.Image = Resources.Success;
                        break;
                    }
                case ResultIcon.FAIL:
                    {
                        control.Image = Resources.Fail;
                        break;
                    }
                case ResultIcon.LOADING:
                    {
                        control.Image = Resources.Spin;
                        break;
                    }
            }
        }

        private void enableUpdateControl(bool enable)
        {
            tsmiSetting.Enabled = btnEditAccount.Enabled = btnEditHost.Enabled
                = btnUpdate.Enabled = enable;
        }

        private void resetUpdate()
        {
            resetTick();
            updateNextCheckUI(getReadableTick());
            timerUpdate.Start();
        }

        private async void updateCloudFlareDNS()
        {
            timerUpdate.Stop();
            if (setting.selectDomain.Count <= 0)
            {
                setResultIcon(pbIPAddress, ResultIcon.FAIL);
                resetUpdate();
                return;
            }

            enableUpdateControl(false);
            setResultIcon(pbIPAddress, ResultIcon.LOADING);
            updateNextCheckUI("執行中");

            // Fire And Wait
            Task<bool> ip4UpdateTask = updateCloudFlareDNS(IPProtocol.IPv4);
            Task<bool> ip6UpdateTask = updateCloudFlareDNS(IPProtocol.IPv6);

            // 很粗糙的 UI 狀態 ... 主要是為了減少請求次數而省略部分狀態檢查
            bool success = false;
            if (await ip4UpdateTask || await ip6UpdateTask)
            {
                success = true;
            }

            if (success)
            {
                setResultIcon(pbIPAddress, ResultIcon.SUCCESS);
                updateStatusBar($"[{LogUtil.getCurrentTime()}] 已更新域名位址");
            }
            else
            {
                setResultIcon(pbIPAddress, ResultIcon.FAIL);
            }

            enableUpdateControl(true);
            resetUpdate();
        }

        private string getReadableTick()
        {
            int minute = tick / 60;
            int second = tick % 60;
            if (minute <= 0)
            {
                return $"{second} 秒";
            }
            return $"{minute} 分 {second} 秒";
        }

        private static void logIPChange(IPProtocol protocol, string last, string ip)
        {
            if (last != string.Empty && ip != last)
            {
                LogUtil.appendLog($"{protocol} 位址已變更 : {last} -> {ip}");
            }
        }

        private async Task<bool> updateCloudFlareDNS(IPProtocol protocol)
        {
            string ip = null;
            switch (setting.ipDetectMethod)
            {
                case IPDetectMethod.LOCAL:
                    {
                        ip = Util.queryAdapterIP(setting.adapter, protocol);
                        break;
                    }
                case IPDetectMethod.REMOTE:
                    {
                        ip = await Task.Run(() => getPublicIPAddress(protocol));
                        break;
                    }
            }

            if (ip == null)
            {
                updateIPAddressUI(protocol, "無法取得");
                return false;
            }

            string last = protocol == IPProtocol.IPv4 ? setting.ip.ip4Address : setting.ip.ip6Address;
            if (ip != last || setting.forceUpdate)
            {
                logIPChange(protocol, last, ip);
                updateIPAddressUI(protocol, ip);

                string dnsRecordType = protocol == IPProtocol.IPv4 ? "A" : "AAAA";
                IList<DNSResult> updateEntry = await Task.Run(() =>
                {
                    IList<DNSResult> allRecord = null;
                    try
                    {
                        switch (protocol)
                        {
                            case IPProtocol.IPv4:
                                {
                                    allRecord = cloudFlare.getAllDNSRecordByZone(true, false);
                                    break;
                                }
                            case IPProtocol.IPv6:
                                {
                                    allRecord = cloudFlare.getAllDNSRecordByZone(false);
                                    break;
                                }
                        }

                        return allRecord.Where(record => setting.selectDomain.Any(select => select.zoneName == record.zone_name && select.dnsName == record.name)
                            && record.content != ip
                            && record.type == dnsRecordType).ToList();
                    }
                    catch (Exception ex)
                    {
                        LogUtil.appendLog($"無法取得 DNS 紀錄 : {ex.Message}");
                        return null;
                    }
                });
                if (updateEntry == null)
                {
                    return false;
                }

                bool updateIP = true;
                IList<Task<bool>> taskList = new List<Task<bool>>();
                foreach (DNSResult entry in updateEntry)
                {
                    Task<bool> task = updateSingleDNS(entry, protocol, ip);
                    taskList.Add(task);
                }
                foreach (Task<bool> task in taskList)
                {
                    if (!await task)
                    {
                        updateIP = false;
                        break;
                    }
                }

                if (updateIP)
                {
                    updateLastIP(protocol, ip);
                }
            }
            return true;
        }

        private async Task<bool> updateSingleDNS(DNSResult target, IPProtocol protocol, string ip)
        {
            return await Task.Run(() =>
            {
                try
                {
                    cloudFlare.updateDNS(protocol, target.zone_id, target.id, target.name, ip, target.proxied);
                    LogUtil.appendLog($"[域名更新] 區域 [{target.zone_name}] 名稱 [{target.name}] 已更新 IP {ip}");
                    return true;
                }
                catch (Exception ex)
                {
                    LogUtil.appendLog($"更新域名時發生例外狀況 區域 [{target.zone_name}] 名稱 [{target.name}] : {ex.Message}");
                    return false;
                }
            });
        }

        private void updateLastIP(IPProtocol protocol, string ip)
        {
            switch (protocol)
            {
                case IPProtocol.IPv4:
                    {
                        setting.ip.ip4Address = ip;
                        break;
                    }
                case IPProtocol.IPv6:
                    {
                        setting.ip.ip6Address = ip;
                        break;
                    }
            }
        }

        private string getPublicIPAddress(IPProtocol protocol)
        {
            string errorMesssage;
            string ret = Util.getPublicIPAddress(protocol, client, out errorMesssage);

            if (ret == null)
            {
                LogUtil.appendLog($"無法取得外部 {protocol} 位址 : {errorMesssage}");
            }
            return ret;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                hideWindow();
                niMin.Visible = true;
                niMin.ShowBalloonTip(NOTICE_DURATION);
            }
        }

        private void tsmiPortTool_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.portchecktool.com/");
        }

        private async void tsmiFlushDNS_Click(object sender, EventArgs e)
        {
            tsmiFlushDNS.Enabled = false;
            await Task.Run(() =>
            {
                try
                {
                    Util.runCommand("ipconfig /flushdns");
                    string message = "DNS 快取清除完成";
                    LogUtil.appendLog(message);
                    MessageBox.Show(message, "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string message = $"DNS 快取清除時發生例外狀況 : {ex.Message}";
                    LogUtil.appendLog(message);
                    MessageBox.Show(message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            tsmiFlushDNS.Enabled = true;
        }

        private void updateStatusBar(string message)
        {
            tsslStatus.Text = message;
        }

        private void updateNextCheckUI(string message)
        {
            labelNextCheck.Text = $"下次檢查 : {message}";
        }

        private void timerUpdate_Tick(object sender, EventArgs e) // OK : Single Thread
        {
            if (--tick <= 0)
            {
                try
                {
                    updateCloudFlareDNS();
                }
                catch (Exception ex)
                {
                    LogUtil.appendLog($"更新 DNS 時發生例外狀況 : {ex.Message}");
                }
            }
            else
            {
                updateNextCheckUI(getReadableTick());
            }
        }

        private void tsmiCopyIP4Address_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(setting.ip.ip4Address);
        }

        private void tsmiCopyIP6Address_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(setting.ip.ip6Address);
        }

        private void updateAccountStatus()
        {
            labelAccount.Text = $"帳號 : {setting.mail}";
            labelAccessMethod.Text = "存取方式 : " + (setting.apiAccessMethod == APIAccessMethod.API_KEY ? "API 金鑰" : "API 權杖");
            setResultIcon(pbAccount, ResultIcon.SUCCESS);
        }

        private void updateHostStatus()
        {
            int count = setting.selectDomain.Count;
            if (count <= 0)
            {
                labelHost.Text = "沒有選取關聯的域名";
                setResultIcon(pbHost, ResultIcon.FAIL);
            }
            else
            {
                labelHost.Text = $"正在更新 : {count} 域名";
                setResultIcon(pbHost, ResultIcon.SUCCESS);
            }
        }

        private void tsmiSetting_Click(object sender, EventArgs e)
        {
            timerUpdate.Stop();
            using (PreferenceForm form = new PreferenceForm(setting))
            {
                form.ShowDialog();
            }
            timerUpdate.Start();
        }

        private void hideWindow()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void tsmiHide_Click(object sender, EventArgs e)
        {
            hideWindow();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void tsmiCopyAPIAccess_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(setting.apiAccess);
        }

        private void tsmiDomainSearch_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.whois365.com/tw");
        }

        private void tsmiDUCLog_Click(object sender, EventArgs e)
        {
            LogUtil.openLogFile();
        }

        private void tsmiLogForm_Click(object sender, EventArgs e)
        {
            openForm(typeof(LogUtil));
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            openForm(typeof(AboutForm));
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            openAccountForm();
        }

        private void btnEditHost_Click(object sender, EventArgs e)
        {
            openHostForm();
        }

        private void openHostForm()
        {
            timerUpdate.Stop();
            using (HostForm form = new HostForm(cloudFlare, setting))
            {
                form.ShowDialog();
                if (form.update)
                {
                    setting.ip.resetLastIP();
                    updateHostStatus();
                    updateCloudFlareDNS();
                }
                else
                {
                    timerUpdate.Start();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateCloudFlareDNS();
        }

        public static void openCloudFlarePage()
        {
            Process.Start("https://www.cloudflare.com/");
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            openCloudFlarePage();
        }

        private void pbLogoText_Click(object sender, EventArgs e)
        {
            openCloudFlarePage();
        }

        private void tsmiOpenRelayCheckTool_Click(object sender, EventArgs e)
        {
            Process.Start("https://mxtoolbox.com/diagnostic.aspx");
        }

        private void minShowWindow()
        {
            niMin.Visible = false;
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void niMin_DoubleClick(object sender, EventArgs e)
        {
            minShowWindow();
        }

        private void tsmiMinShow_Click(object sender, EventArgs e)
        {
            minShowWindow();
        }

        private void tsmiMinExit_Click(object sender, EventArgs e)
        {
            niMin.Visible = false;
            exit();
        }
    }
}