using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CloudFlareDNSClient
{
    public static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string name = Process.GetCurrentProcess().ProcessName;
            if (Process.GetProcessesByName(name).Length > 1)
            {
                MessageBox.Show("已經有其他程式實例正在執行", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AppDomain.CurrentDomain.UnhandledException += (sender, arg) =>
            {
                Exception exception = (Exception)arg.ExceptionObject;
                LogUtil.appendLog($"發生未處理例外狀況 : {exception}");
            };
            Application.Run(new MainForm());
        }
    }
}