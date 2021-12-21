using CloudFlareDNSClient.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class HostForm : Form
    {
        private readonly CloudflareAPI cloudFlare;
        private readonly Setting setting;

        private readonly IDictionary<SelectDomain, bool> modifyDomain;

        public bool update
        {
            get;
            private set;
        }

        public HostForm(CloudflareAPI cloudFlare, Setting setting)
        {
            InitializeComponent();
            initToolTip();

            this.cloudFlare = cloudFlare;
            this.setting = setting;
            modifyDomain = new Dictionary<SelectDomain, bool>();
            updateList();
        }

        private void initToolTip()
        {
            ToolTip hostReset = new ToolTip();
            hostReset.SetToolTip(btnReset, Resources.HostResetToolTip);
        }

        private void finishLoading()
        {
            pbLoading.Visible = labelLoading.Visible = false;
        }

        private async void updateList()
        {
            string error = "無法取得域名列表";
            IList<DNSResult> allRecord = await Task.Run(() =>
            {
                try
                {
                    return cloudFlare.getAllDNSRecordByZone();
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder().Append(error);
                    if (setting.apiAccessMethod == APIAccessMethod.API_TOKEN && ex.Message.Contains("403 (Forbidden)"))
                    {
                        sb.Append(" (請確認您的 API 權杖是否授予讀取權限)");
                    }
                    sb.Append(" : ").Append(ex.Message);

                    error = sb.ToString();
                    LogUtil.appendLog(error);
                    return null;
                }
            });
            if (allRecord != null)
            {
                updateListView(allRecord);
                bindItemCheckEvent();
            }
            else
            {
                MessageBox.Show(error, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finishLoading();
        }

        private void updateListView(IList<DNSResult> record)
        {
            lvDNSRecord.Items.Clear();
            IEnumerable<string> zoneList = record.Select(data => data.zone_name).Distinct().OrderBy(name => name);
            foreach (string zone in zoneList)
            {
                ListViewGroup group = new ListViewGroup($"區域 : {zone}");
                lvDNSRecord.Groups.Add(group);

                IEnumerable<DNSResult> zoneRecord = record.Where(data => data.zone_name == zone);
                foreach (DNSResult dnsRecord in zoneRecord)
                {
                    ListViewItem row = new ListViewItem(group);
                    row.SubItems.Add(dnsRecord.name);
                    row.SubItems.Add(dnsRecord.content);
                    row.SubItems.Add(dnsRecord.proxied ? "是" : "否");
                    row.Tag = zone;

                    if (setting.selectDomain.Any(entry => entry.zoneName == dnsRecord.zone_name && entry.dnsName == dnsRecord.name))
                    {
                        row.Checked = true;
                    }
                    lvDNSRecord.Items.Add(row);
                }
            }
        }

        private void lvDNSRecord_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            modifyDomain[new SelectDomain()
            {
                zoneName = item.Tag.ToString(),
                dnsName = item.SubItems[1].Text
            }] = item.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindItemCheckEvent()
        {
            lvDNSRecord.ItemChecked += new ItemCheckedEventHandler(lvDNSRecord_ItemChecked);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (modifyDomain.Count > 0)
            {
                foreach (KeyValuePair<SelectDomain, bool> data in modifyDomain)
                {
                    if (!data.Value)
                    {
                        setting.selectDomain.Remove(data.Key);
                    }
                    else
                    {
                        setting.selectDomain.Add(data.Key);
                    }
                }
                setting.save();
                update = true;
            }
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定是否重設選取域名 ?", "詢問", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                setting.selectDomain.Clear();
                setting.save();
                update = true;
                Close();
            }
        }
    }
}