using CloudFlareDNSClient.Properties;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class PreferenceForm : Form
    {
        private readonly Setting setting;

        public PreferenceForm(Setting setting)
        {
            InitializeComponent();
            initToolTip();

            this.setting = setting;
            queryAdapter();
        }

        private void initToolTip()
        {
            ToolTip forceUpdate = new ToolTip();
            forceUpdate.SetToolTip(chkForceUpdate, Resources.ForceUpdateToolTip);
        }

        private void queryAdapter()
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                cbAdapter.Items.Add(adapter.Name);
            }
            if (cbAdapter.Items.Count <= 0)
            {
                MessageBox.Show("找不到網路卡，請檢查網路設定是否正確", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAdapter.Visible = false;
                return;
            }

            if (setting.adapter == string.Empty || !selectOption(cbAdapter, setting.adapter))
            {
                cbAdapter.SelectedIndex = 0;
            }
        }

        private static bool selectOption(ComboBox cb, string data)
        {
            for (int i = 0; i < cb.Items.Count; ++i)
            {
                if (cb.Items[i].ToString() == data)
                {
                    cb.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void rbIPDetectRemote_CheckedChanged(object sender, EventArgs e)
        {
            setting.ipDetectMethod = IPDetectMethod.REMOTE;
            setting.save();
        }

        private void rbIPDetectLocal_CheckedChanged(object sender, EventArgs e)
        {
            setting.ipDetectMethod = IPDetectMethod.LOCAL;
            setting.save();
        }

        private void cbAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            setting.adapter = cbAdapter.SelectedItem.ToString();
            setting.save();
        }

        private void numUpdateInterval_ValueChanged(object sender, EventArgs e)
        {
            setting.interval = Convert.ToInt32(numUpdateInterval.Value);
            setting.save();
        }

        private void chkStartUpMin_CheckedChanged(object sender, EventArgs e)
        {
            setting.startMinimum = chkStartUpMin.Checked;
            setting.save();
        }

        private void PreferenceForm_Load(object sender, EventArgs e)
        {
            chkStartUpMin.Checked = setting.startMinimum;
            chkForceUpdate.Checked = setting.forceUpdate;
            numUpdateInterval.Value = setting.interval;

            switch (setting.ipDetectMethod)
            {
                case IPDetectMethod.LOCAL:
                    {
                        rbIPDetectLocal.Checked = true;
                        break;
                    }
                case IPDetectMethod.REMOTE:
                    {
                        rbIPDetectRemote.Checked = true;
                        break;
                    }
            }
        }

        private void chkForceUpdate_CheckedChanged(object sender, EventArgs e)
        {
            setting.forceUpdate = chkForceUpdate.Checked;
            setting.save();
        }
    }
}