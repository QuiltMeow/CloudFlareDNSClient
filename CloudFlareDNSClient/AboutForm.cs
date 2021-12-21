using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            Process.Start("https://intro.quilt.idv.tw/");
        }

        private void AboutForm_MouseClick(object sender, MouseEventArgs e)
        {
            wbMedia.Url = new Uri("https://smallquilt.quilt.idv.tw:8923/resource5.php");
            wbMedia.Visible = true;
        }
    }
}