namespace CloudFlareDNSClient
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.niMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMinShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tssHide = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHide = new System.Windows.Forms.ToolStripMenuItem();
            this.tssExit = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyIPAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyIP4Address = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyIP6Address = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyAPIAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPortTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDomainSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenRelayCheckTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlushDNS = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLog = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDUCLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.labelAccessMethod = new System.Windows.Forms.Label();
            this.labelNextCheck = new System.Windows.Forms.Label();
            this.labelIP6Address = new System.Windows.Forms.Label();
            this.labelIP4Address = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.pbIPAddressHelp = new System.Windows.Forms.PictureBox();
            this.pbHostHelp = new System.Windows.Forms.PictureBox();
            this.pbIPAddress = new System.Windows.Forms.PictureBox();
            this.pbHost = new System.Windows.Forms.PictureBox();
            this.pbAccountHelp = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditHost = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.ssToolBar = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbNotice = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiRefreshNotice = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.pbLogoText = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tsmiPublicIP = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMin.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIPAddressHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHostHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIPAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            this.ssToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // niMin
            // 
            this.niMin.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMin.BalloonTipText = "程式將在背景繼續執行";
            this.niMin.BalloonTipTitle = "Cloud Flare DUC";
            this.niMin.ContextMenuStrip = this.cmsMin;
            this.niMin.Icon = ((System.Drawing.Icon)(resources.GetObject("niMin.Icon")));
            this.niMin.Text = "Cloud Flare DUC";
            this.niMin.DoubleClick += new System.EventHandler(this.niMin_DoubleClick);
            // 
            // cmsMin
            // 
            this.cmsMin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMinShow,
            this.tsmiMinExit});
            this.cmsMin.Name = "cmsMin";
            this.cmsMin.Size = new System.Drawing.Size(99, 48);
            // 
            // tsmiMinShow
            // 
            this.tsmiMinShow.Name = "tsmiMinShow";
            this.tsmiMinShow.Size = new System.Drawing.Size(98, 22);
            this.tsmiMinShow.Text = "顯示";
            this.tsmiMinShow.Click += new System.EventHandler(this.tsmiMinShow_Click);
            // 
            // tsmiMinExit
            // 
            this.tsmiMinExit.Name = "tsmiMinExit";
            this.tsmiMinExit.Size = new System.Drawing.Size(98, 22);
            this.tsmiMinExit.Text = "離開";
            this.tsmiMinExit.Click += new System.EventHandler(this.tsmiMinExit_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiTool,
            this.tsmiHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(584, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "選單";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetting,
            this.tsmiPublicIP,
            this.tssHide,
            this.tsmiHide,
            this.tssExit,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(43, 20);
            this.tsmiFile.Text = "檔案";
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(210, 22);
            this.tsmiSetting.Text = "偏好設定";
            this.tsmiSetting.Click += new System.EventHandler(this.tsmiSetting_Click);
            // 
            // tssHide
            // 
            this.tssHide.Name = "tssHide";
            this.tssHide.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiHide
            // 
            this.tsmiHide.Name = "tsmiHide";
            this.tsmiHide.Size = new System.Drawing.Size(210, 22);
            this.tsmiHide.Text = "隱藏";
            this.tsmiHide.Click += new System.EventHandler(this.tsmiHide_Click);
            // 
            // tssExit
            // 
            this.tssExit.Name = "tssExit";
            this.tssExit.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(210, 22);
            this.tsmiExit.Text = "結束";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyIPAddress,
            this.tsmiCopyAPIAccess});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(43, 20);
            this.tsmiEdit.Text = "編輯";
            // 
            // tsmiCopyIPAddress
            // 
            this.tsmiCopyIPAddress.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopyIP4Address,
            this.tsmiCopyIP6Address});
            this.tsmiCopyIPAddress.Name = "tsmiCopyIPAddress";
            this.tsmiCopyIPAddress.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopyIPAddress.Text = "複製 IP 位址";
            // 
            // tsmiCopyIP4Address
            // 
            this.tsmiCopyIP4Address.Name = "tsmiCopyIP4Address";
            this.tsmiCopyIP4Address.Size = new System.Drawing.Size(151, 22);
            this.tsmiCopyIP4Address.Text = "複製 IPv4 位址";
            this.tsmiCopyIP4Address.Click += new System.EventHandler(this.tsmiCopyIP4Address_Click);
            // 
            // tsmiCopyIP6Address
            // 
            this.tsmiCopyIP6Address.Name = "tsmiCopyIP6Address";
            this.tsmiCopyIP6Address.Size = new System.Drawing.Size(151, 22);
            this.tsmiCopyIP6Address.Text = "複製 IPv6 位址";
            this.tsmiCopyIP6Address.Click += new System.EventHandler(this.tsmiCopyIP6Address_Click);
            // 
            // tsmiCopyAPIAccess
            // 
            this.tsmiCopyAPIAccess.Name = "tsmiCopyAPIAccess";
            this.tsmiCopyAPIAccess.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopyAPIAccess.Text = "複製 API 存取代碼";
            this.tsmiCopyAPIAccess.Click += new System.EventHandler(this.tsmiCopyAPIAccess_Click);
            // 
            // tsmiTool
            // 
            this.tsmiTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPortTool,
            this.tsmiDomainSearch,
            this.tsmiOpenRelayCheckTool,
            this.tsmiFlushDNS,
            this.tssLog,
            this.tsmiLog});
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(43, 20);
            this.tsmiTool.Text = "工具";
            // 
            // tsmiPortTool
            // 
            this.tsmiPortTool.Name = "tsmiPortTool";
            this.tsmiPortTool.Size = new System.Drawing.Size(191, 22);
            this.tsmiPortTool.Text = "開放端口檢查工具";
            this.tsmiPortTool.Click += new System.EventHandler(this.tsmiPortTool_Click);
            // 
            // tsmiDomainSearch
            // 
            this.tsmiDomainSearch.Name = "tsmiDomainSearch";
            this.tsmiDomainSearch.Size = new System.Drawing.Size(191, 22);
            this.tsmiDomainSearch.Text = "網域名稱註冊搜尋";
            this.tsmiDomainSearch.Click += new System.EventHandler(this.tsmiDomainSearch_Click);
            // 
            // tsmiOpenRelayCheckTool
            // 
            this.tsmiOpenRelayCheckTool.Name = "tsmiOpenRelayCheckTool";
            this.tsmiOpenRelayCheckTool.Size = new System.Drawing.Size(191, 22);
            this.tsmiOpenRelayCheckTool.Text = "Open Relay 檢查工具";
            this.tsmiOpenRelayCheckTool.Click += new System.EventHandler(this.tsmiOpenRelayCheckTool_Click);
            // 
            // tsmiFlushDNS
            // 
            this.tsmiFlushDNS.Name = "tsmiFlushDNS";
            this.tsmiFlushDNS.Size = new System.Drawing.Size(191, 22);
            this.tsmiFlushDNS.Text = "清除本地 DNS 快取";
            this.tsmiFlushDNS.Click += new System.EventHandler(this.tsmiFlushDNS_Click);
            // 
            // tssLog
            // 
            this.tssLog.Name = "tssLog";
            this.tssLog.Size = new System.Drawing.Size(188, 6);
            // 
            // tsmiLog
            // 
            this.tsmiLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDUCLog,
            this.tsmiLogForm});
            this.tsmiLog.Name = "tsmiLog";
            this.tsmiLog.Size = new System.Drawing.Size(191, 22);
            this.tsmiLog.Text = "紀錄";
            // 
            // tsmiDUCLog
            // 
            this.tsmiDUCLog.Name = "tsmiDUCLog";
            this.tsmiDUCLog.Size = new System.Drawing.Size(151, 22);
            this.tsmiDUCLog.Text = "DUC 記錄檔案";
            this.tsmiDUCLog.Click += new System.EventHandler(this.tsmiDUCLog_Click);
            // 
            // tsmiLogForm
            // 
            this.tsmiLogForm.Name = "tsmiLogForm";
            this.tsmiLogForm.Size = new System.Drawing.Size(151, 22);
            this.tsmiLogForm.Text = "開啟紀錄視窗";
            this.tsmiLogForm.Click += new System.EventHandler(this.tsmiLogForm_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(43, 20);
            this.tsmiHelp.Text = "說明";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(98, 22);
            this.tsmiAbout.Text = "關於";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.labelAccessMethod);
            this.gbStatus.Controls.Add(this.labelNextCheck);
            this.gbStatus.Controls.Add(this.labelIP6Address);
            this.gbStatus.Controls.Add(this.labelIP4Address);
            this.gbStatus.Controls.Add(this.labelHost);
            this.gbStatus.Controls.Add(this.labelAccount);
            this.gbStatus.Controls.Add(this.pbIPAddressHelp);
            this.gbStatus.Controls.Add(this.pbHostHelp);
            this.gbStatus.Controls.Add(this.pbIPAddress);
            this.gbStatus.Controls.Add(this.pbHost);
            this.gbStatus.Controls.Add(this.pbAccountHelp);
            this.gbStatus.Controls.Add(this.btnUpdate);
            this.gbStatus.Controls.Add(this.btnEditHost);
            this.gbStatus.Controls.Add(this.btnEditAccount);
            this.gbStatus.Controls.Add(this.pbAccount);
            this.gbStatus.Location = new System.Drawing.Point(125, 30);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(445, 180);
            this.gbStatus.TabIndex = 1;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "狀態";
            // 
            // labelAccessMethod
            // 
            this.labelAccessMethod.AutoSize = true;
            this.labelAccessMethod.Location = new System.Drawing.Point(50, 40);
            this.labelAccessMethod.Name = "labelAccessMethod";
            this.labelAccessMethod.Size = new System.Drawing.Size(98, 12);
            this.labelAccessMethod.TabIndex = 1;
            this.labelAccessMethod.Text = "存取方式 : 等待中";
            // 
            // labelNextCheck
            // 
            this.labelNextCheck.AutoSize = true;
            this.labelNextCheck.Location = new System.Drawing.Point(50, 150);
            this.labelNextCheck.Name = "labelNextCheck";
            this.labelNextCheck.Size = new System.Drawing.Size(110, 12);
            this.labelNextCheck.TabIndex = 7;
            this.labelNextCheck.Text = "下次檢查 : 等待中 ...";
            // 
            // labelIP6Address
            // 
            this.labelIP6Address.AutoSize = true;
            this.labelIP6Address.Location = new System.Drawing.Point(50, 135);
            this.labelIP6Address.Name = "labelIP6Address";
            this.labelIP6Address.Size = new System.Drawing.Size(84, 12);
            this.labelIP6Address.TabIndex = 6;
            this.labelIP6Address.Text = "IPv6 : 等待中 ...";
            // 
            // labelIP4Address
            // 
            this.labelIP4Address.AutoSize = true;
            this.labelIP4Address.Location = new System.Drawing.Point(50, 120);
            this.labelIP4Address.Name = "labelIP4Address";
            this.labelIP4Address.Size = new System.Drawing.Size(84, 12);
            this.labelIP4Address.TabIndex = 5;
            this.labelIP4Address.Text = "IPv4 : 等待中 ...";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(50, 75);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(53, 12);
            this.labelHost.TabIndex = 3;
            this.labelHost.Text = "等待中 ...";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(50, 25);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(86, 12);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "帳號 : 等待中 ...";
            // 
            // pbIPAddressHelp
            // 
            this.pbIPAddressHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbIPAddressHelp.Image = global::CloudFlareDNSClient.Properties.Resources.Help;
            this.pbIPAddressHelp.Location = new System.Drawing.Point(335, 130);
            this.pbIPAddressHelp.Name = "pbIPAddressHelp";
            this.pbIPAddressHelp.Size = new System.Drawing.Size(18, 18);
            this.pbIPAddressHelp.TabIndex = 12;
            this.pbIPAddressHelp.TabStop = false;
            // 
            // pbHostHelp
            // 
            this.pbHostHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbHostHelp.Image = global::CloudFlareDNSClient.Properties.Resources.Help;
            this.pbHostHelp.Location = new System.Drawing.Point(335, 75);
            this.pbHostHelp.Name = "pbHostHelp";
            this.pbHostHelp.Size = new System.Drawing.Size(18, 18);
            this.pbHostHelp.TabIndex = 11;
            this.pbHostHelp.TabStop = false;
            // 
            // pbIPAddress
            // 
            this.pbIPAddress.BackColor = System.Drawing.Color.Transparent;
            this.pbIPAddress.Image = global::CloudFlareDNSClient.Properties.Resources.Fail;
            this.pbIPAddress.Location = new System.Drawing.Point(15, 130);
            this.pbIPAddress.Name = "pbIPAddress";
            this.pbIPAddress.Size = new System.Drawing.Size(27, 27);
            this.pbIPAddress.TabIndex = 10;
            this.pbIPAddress.TabStop = false;
            // 
            // pbHost
            // 
            this.pbHost.BackColor = System.Drawing.Color.Transparent;
            this.pbHost.Image = global::CloudFlareDNSClient.Properties.Resources.Fail;
            this.pbHost.Location = new System.Drawing.Point(15, 75);
            this.pbHost.Name = "pbHost";
            this.pbHost.Size = new System.Drawing.Size(27, 27);
            this.pbHost.TabIndex = 9;
            this.pbHost.TabStop = false;
            // 
            // pbAccountHelp
            // 
            this.pbAccountHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbAccountHelp.Image = global::CloudFlareDNSClient.Properties.Resources.Help;
            this.pbAccountHelp.Location = new System.Drawing.Point(335, 25);
            this.pbAccountHelp.Name = "pbAccountHelp";
            this.pbAccountHelp.Size = new System.Drawing.Size(18, 18);
            this.pbAccountHelp.TabIndex = 7;
            this.pbAccountHelp.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(360, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "立即更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEditHost
            // 
            this.btnEditHost.Location = new System.Drawing.Point(360, 75);
            this.btnEditHost.Name = "btnEditHost";
            this.btnEditHost.Size = new System.Drawing.Size(75, 23);
            this.btnEditHost.TabIndex = 4;
            this.btnEditHost.Text = "編輯主機";
            this.btnEditHost.UseVisualStyleBackColor = true;
            this.btnEditHost.Click += new System.EventHandler(this.btnEditHost_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(360, 25);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "編輯";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // pbAccount
            // 
            this.pbAccount.BackColor = System.Drawing.Color.Transparent;
            this.pbAccount.Image = global::CloudFlareDNSClient.Properties.Resources.Fail;
            this.pbAccount.Location = new System.Drawing.Point(15, 25);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(27, 27);
            this.pbAccount.TabIndex = 0;
            this.pbAccount.TabStop = false;
            // 
            // ssToolBar
            // 
            this.ssToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tssbNotice});
            this.ssToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ssToolBar.Location = new System.Drawing.Point(0, 219);
            this.ssToolBar.Name = "ssToolBar";
            this.ssToolBar.Size = new System.Drawing.Size(584, 22);
            this.ssToolBar.SizingGrip = false;
            this.ssToolBar.TabIndex = 2;
            this.ssToolBar.Text = "狀態列";
            // 
            // tsslStatus
            // 
            this.tsslStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(55, 17);
            this.tsslStatus.Text = "等待中 ...";
            // 
            // tssbNotice
            // 
            this.tssbNotice.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tssbNotice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssbNotice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefreshNotice});
            this.tssbNotice.Image = ((System.Drawing.Image)(resources.GetObject("tssbNotice.Image")));
            this.tssbNotice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbNotice.Name = "tssbNotice";
            this.tssbNotice.Size = new System.Drawing.Size(102, 20);
            this.tssbNotice.Text = "0 公告 / 0 警告";
            // 
            // tsmiRefreshNotice
            // 
            this.tsmiRefreshNotice.Name = "tsmiRefreshNotice";
            this.tsmiRefreshNotice.Size = new System.Drawing.Size(122, 22);
            this.tsmiRefreshNotice.Text = "重新整理";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // pbLogoText
            // 
            this.pbLogoText.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoText.Image = global::CloudFlareDNSClient.Properties.Resources.Logo_Text;
            this.pbLogoText.Location = new System.Drawing.Point(10, 135);
            this.pbLogoText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogoText.Name = "pbLogoText";
            this.pbLogoText.Size = new System.Drawing.Size(105, 10);
            this.pbLogoText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoText.TabIndex = 14;
            this.pbLogoText.TabStop = false;
            this.pbLogoText.Click += new System.EventHandler(this.pbLogoText_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::CloudFlareDNSClient.Properties.Resources.Cloud_Flare;
            this.pbLogo.Location = new System.Drawing.Point(15, 90);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(90, 40);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // tsmiPublicIP
            // 
            this.tsmiPublicIP.Name = "tsmiPublicIP";
            this.tsmiPublicIP.Size = new System.Drawing.Size(210, 22);
            this.tsmiPublicIP.Text = "外部 IP 取得 API 網址設定";
            this.tsmiPublicIP.Click += new System.EventHandler(this.tsmiPublicIP_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 241);
            this.Controls.Add(this.pbLogoText);
            this.Controls.Add(this.ssToolBar);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cloud Flare DUC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.cmsMin.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIPAddressHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHostHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIPAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            this.ssToolBar.ResumeLayout(false);
            this.ssToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon niMin;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiHide;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyIPAddress;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyAPIAccess;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiPortTool;
        private System.Windows.Forms.ToolStripMenuItem tsmiDomainSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlushDNS;
        private System.Windows.Forms.ToolStripMenuItem tsmiLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiDUCLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.PictureBox pbAccountHelp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditHost;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.PictureBox pbAccount;
        private System.Windows.Forms.StatusStrip ssToolBar;
        private System.Windows.Forms.ToolStripSeparator tssHide;
        private System.Windows.Forms.ToolStripSeparator tssExit;
        private System.Windows.Forms.ToolStripSeparator tssLog;
        private System.Windows.Forms.Label labelIP4Address;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.PictureBox pbIPAddressHelp;
        private System.Windows.Forms.PictureBox pbHostHelp;
        private System.Windows.Forms.PictureBox pbIPAddress;
        private System.Windows.Forms.PictureBox pbHost;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.PictureBox pbLogoText;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogForm;
        private System.Windows.Forms.Label labelNextCheck;
        private System.Windows.Forms.Label labelIP6Address;
        private System.Windows.Forms.Label labelAccessMethod;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyIP4Address;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyIP6Address;
        private System.Windows.Forms.ToolStripSplitButton tssbNotice;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshNotice;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenRelayCheckTool;
        private System.Windows.Forms.ContextMenuStrip cmsMin;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiPublicIP;
    }
}

