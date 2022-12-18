using System;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class PublicIPForm : Form
    {
        private readonly Setting setting;

        public PublicIPForm(Setting setting)
        {
            InitializeComponent();
            this.setting = setting;
            loadSetting();
        }

        public static bool isHTTPPrefix(string url)
        {
            return url.StartsWith("http://") || url.StartsWith("https://");
        }

        private void loadSetting()
        {
            PublicIPAPIURL publicIPAPIURL = setting.publicIPAPIURL;
            string ip4 = publicIPAPIURL.ip4APIURL;
            string ip6 = publicIPAPIURL.ip6APIURL;

            if (!string.IsNullOrWhiteSpace(ip4))
            {
                rbIPv4Custom.Checked = true;
                txtIPv4.Text = ip4;
            }

            if (!string.IsNullOrWhiteSpace(ip6))
            {
                rbIPv6Custom.Checked = true;
                txtIPv6.Text = ip6;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string ip4 = txtIPv4.Text;
            if (rbIPv4Custom.Checked && (string.IsNullOrWhiteSpace(ip4) || !isHTTPPrefix(ip4)))
            {
                MessageBox.Show("IPv4 API 網址輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ip6 = txtIPv6.Text;
            if (rbIPv6Custom.Checked && (string.IsNullOrWhiteSpace(ip6) || !isHTTPPrefix(ip6)))
            {
                MessageBox.Show("IPv6 API 網址輸入錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PublicIPAPIURL publicIPAPIURL = setting.publicIPAPIURL;
            publicIPAPIURL.ip4APIURL = rbIPv4Default.Checked ? string.Empty : ip4;
            publicIPAPIURL.ip6APIURL = rbIPv6Default.Checked ? string.Empty : ip6;
            setting.save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbIPv4Custom_CheckedChanged(object sender, EventArgs e)
        {
            txtIPv4.Enabled = rbIPv4Custom.Checked;
        }

        private void rbIPv6Custom_CheckedChanged(object sender, EventArgs e)
        {
            txtIPv6.Enabled = rbIPv6Custom.Checked;
        }
    }
}