using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public partial class LogUtil : Form
    {
        private const string LOG_FILE = "LogFile.log";

        public LogUtil()
        {
            InitializeComponent();
            loadLog();
        }

        public static string getCurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy - MM - dd tt hh : mm : ss");
        }

        public static string getCurrentTime()
        {
            return DateTime.Now.ToString("tt hh : mm : ss");
        }

        public static bool appendLog(string message)
        {
            try
            {
                File.AppendAllLines(LOG_FILE, new string[] {
                    new StringBuilder().Append("[").Append(getCurrentDateTime()).Append("] ").Append(message).ToString()
                });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void openLogFile()
        {
            try
            {
                using (StreamWriter sw = File.AppendText(LOG_FILE))
                {
                }
                Process.Start(LOG_FILE);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"開啟紀錄檔案時發生例外狀況 : {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool clearLog()
        {
            try
            {
                File.Delete(LOG_FILE);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void loadLog()
        {
            try
            {
                txtLog.Text = File.ReadAllText(LOG_FILE);
            }
            catch
            {
                txtLog.Text = string.Empty;
            }
            txtLog.SelectionStart = txtLog.Text.Length;
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            loadLog();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLog.Text);
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            clearLog();
            txtLog.Text = string.Empty;
        }

        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            openLogFile();
        }
    }
}