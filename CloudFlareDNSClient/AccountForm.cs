using CloudFlareDNSClient.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class AccountForm : Form
    {
        private readonly Setting setting;

        public bool update
        {
            get;
            private set;
        }

        public AccountForm(Setting setting)
        {
            InitializeComponent();
            initToolTip();

            this.setting = setting;
        }

        private void initToolTip()
        {
            ToolTip apiToken = new ToolTip();
            apiToken.SetToolTip(rbUseAPIToken, Resources.APITokenToolTip);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string apiAccess = txtAPIAccess.Text;
            string zone = txtZone.Text;
            APIAccessMethod apiAccessMethod = rbUseAPIKey.Checked ? APIAccessMethod.API_KEY : APIAccessMethod.API_TOKEN;

            if (string.IsNullOrWhiteSpace(mail))
            {
                showAlert("請輸入電子郵件");
                return;
            }
            if (!mail.Contains("@"))
            {
                showAlert("請輸入有效電子郵件格式");
                return;
            }
            if (string.IsNullOrEmpty(apiAccess))
            {
                showAlert("請輸入 API 存取金鑰");
                return;
            }

            if (setting.mail != mail || setting.apiAccess != apiAccess || setting.zoneId != zone || setting.apiAccessMethod != apiAccessMethod)
            {
                setting.selectDomain.Clear();
                setting.mail = mail;
                setting.apiAccess = apiAccess;
                setting.zoneId = zone;
                setting.apiAccessMethod = rbUseAPIKey.Checked ? APIAccessMethod.API_KEY : APIAccessMethod.API_TOKEN;
                setting.save();
                update = true;
            }
            Close();
        }

        private void showAlert(string message)
        {
            labelAlert.Text = message;
            pbAlert.Visible = labelAlert.Visible = true;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            txtMail.Text = setting.mail;
            txtAPIAccess.Text = setting.apiAccess;
            txtZone.Text = setting.zoneId;

            switch (setting.apiAccessMethod)
            {
                case APIAccessMethod.API_KEY:
                    {
                        rbUseAPIKey.Checked = true;
                        break;
                    }
                case APIAccessMethod.API_TOKEN:
                    {
                        rbUseAPIToken.Checked = true;
                        break;
                    }
            }
            txtMail.SelectionStart = txtMail.Text.Length;
        }

        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://dash.cloudflare.com/profile/api-tokens");
        }
    }
}