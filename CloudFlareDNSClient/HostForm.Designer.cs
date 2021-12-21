namespace CloudFlareDNSClient
{
    partial class HostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            this.labelTip = new System.Windows.Forms.Label();
            this.lvDNSRecord = new System.Windows.Forms.ListView();
            this.chUpdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProxy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(12, 20);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(221, 12);
            this.labelTip.TabIndex = 0;
            this.labelTip.Text = "請選擇與本機關聯的域名以進行自動更新";
            // 
            // lvDNSRecord
            // 
            this.lvDNSRecord.CheckBoxes = true;
            this.lvDNSRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUpdate,
            this.chName,
            this.chIPAddress,
            this.chProxy});
            this.lvDNSRecord.HideSelection = false;
            this.lvDNSRecord.Location = new System.Drawing.Point(12, 55);
            this.lvDNSRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDNSRecord.Name = "lvDNSRecord";
            this.lvDNSRecord.Size = new System.Drawing.Size(450, 430);
            this.lvDNSRecord.TabIndex = 1;
            this.lvDNSRecord.UseCompatibleStateImageBehavior = false;
            this.lvDNSRecord.View = System.Windows.Forms.View.Details;
            // 
            // chUpdate
            // 
            this.chUpdate.Text = "更新";
            this.chUpdate.Width = 50;
            // 
            // chName
            // 
            this.chName.Text = "名稱";
            this.chName.Width = 160;
            // 
            // chIPAddress
            // 
            this.chIPAddress.Text = "位址";
            this.chIPAddress.Width = 160;
            // 
            // chProxy
            // 
            this.chProxy.Text = "使用代理";
            this.chProxy.Width = 65;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(75, 500);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(195, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Location = new System.Drawing.Point(385, 20);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(77, 12);
            this.labelLoading.TabIndex = 5;
            this.labelLoading.Text = "正在讀取中 ...";
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = global::CloudFlareDNSClient.Properties.Resources.Spin;
            this.pbLoading.Location = new System.Drawing.Point(352, 12);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(27, 27);
            this.pbLoading.TabIndex = 12;
            this.pbLoading.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(315, 500);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重設";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 546);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lvDNSRecord);
            this.Controls.Add(this.labelTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostForm";
            this.Text = "主機編輯";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ListView lvDNSRecord;
        private System.Windows.Forms.ColumnHeader chUpdate;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chIPAddress;
        private System.Windows.Forms.ColumnHeader chProxy;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Button btnReset;
    }
}