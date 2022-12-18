namespace CloudFlareDNSClient
{
    partial class PublicIPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicIPForm));
            this.gbIPv4 = new System.Windows.Forms.GroupBox();
            this.txtIPv4 = new System.Windows.Forms.TextBox();
            this.rbIPv4Custom = new System.Windows.Forms.RadioButton();
            this.rbIPv4Default = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbIPv6 = new System.Windows.Forms.GroupBox();
            this.txtIPv6 = new System.Windows.Forms.TextBox();
            this.rbIPv6Custom = new System.Windows.Forms.RadioButton();
            this.rbIPv6Default = new System.Windows.Forms.RadioButton();
            this.gbIPv4.SuspendLayout();
            this.gbIPv6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIPv4
            // 
            this.gbIPv4.Controls.Add(this.txtIPv4);
            this.gbIPv4.Controls.Add(this.rbIPv4Custom);
            this.gbIPv4.Controls.Add(this.rbIPv4Default);
            this.gbIPv4.Location = new System.Drawing.Point(15, 15);
            this.gbIPv4.Name = "gbIPv4";
            this.gbIPv4.Size = new System.Drawing.Size(345, 125);
            this.gbIPv4.TabIndex = 0;
            this.gbIPv4.TabStop = false;
            this.gbIPv4.Text = "IPv4 API";
            // 
            // txtIPv4
            // 
            this.txtIPv4.Enabled = false;
            this.txtIPv4.Location = new System.Drawing.Point(30, 75);
            this.txtIPv4.Name = "txtIPv4";
            this.txtIPv4.Size = new System.Drawing.Size(300, 22);
            this.txtIPv4.TabIndex = 2;
            // 
            // rbIPv4Custom
            // 
            this.rbIPv4Custom.AutoSize = true;
            this.rbIPv4Custom.Location = new System.Drawing.Point(15, 50);
            this.rbIPv4Custom.Name = "rbIPv4Custom";
            this.rbIPv4Custom.Size = new System.Drawing.Size(119, 16);
            this.rbIPv4Custom.TabIndex = 1;
            this.rbIPv4Custom.Text = "使用自訂 API 網址";
            this.rbIPv4Custom.UseVisualStyleBackColor = true;
            this.rbIPv4Custom.CheckedChanged += new System.EventHandler(this.rbIPv4Custom_CheckedChanged);
            // 
            // rbIPv4Default
            // 
            this.rbIPv4Default.AutoSize = true;
            this.rbIPv4Default.Checked = true;
            this.rbIPv4Default.Location = new System.Drawing.Point(15, 25);
            this.rbIPv4Default.Name = "rbIPv4Default";
            this.rbIPv4Default.Size = new System.Drawing.Size(119, 16);
            this.rbIPv4Default.TabIndex = 0;
            this.rbIPv4Default.Text = "使用預設 API 網址";
            this.rbIPv4Default.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(55, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbIPv6
            // 
            this.gbIPv6.Controls.Add(this.txtIPv6);
            this.gbIPv6.Controls.Add(this.rbIPv6Custom);
            this.gbIPv6.Controls.Add(this.rbIPv6Default);
            this.gbIPv6.Location = new System.Drawing.Point(15, 155);
            this.gbIPv6.Name = "gbIPv6";
            this.gbIPv6.Size = new System.Drawing.Size(345, 125);
            this.gbIPv6.TabIndex = 1;
            this.gbIPv6.TabStop = false;
            this.gbIPv6.Text = "IPv6 API";
            // 
            // txtIPv6
            // 
            this.txtIPv6.Enabled = false;
            this.txtIPv6.Location = new System.Drawing.Point(30, 75);
            this.txtIPv6.Name = "txtIPv6";
            this.txtIPv6.Size = new System.Drawing.Size(300, 22);
            this.txtIPv6.TabIndex = 2;
            // 
            // rbIPv6Custom
            // 
            this.rbIPv6Custom.AutoSize = true;
            this.rbIPv6Custom.Location = new System.Drawing.Point(15, 50);
            this.rbIPv6Custom.Name = "rbIPv6Custom";
            this.rbIPv6Custom.Size = new System.Drawing.Size(119, 16);
            this.rbIPv6Custom.TabIndex = 1;
            this.rbIPv6Custom.Text = "使用自訂 API 網址";
            this.rbIPv6Custom.UseVisualStyleBackColor = true;
            this.rbIPv6Custom.CheckedChanged += new System.EventHandler(this.rbIPv6Custom_CheckedChanged);
            // 
            // rbIPv6Default
            // 
            this.rbIPv6Default.AutoSize = true;
            this.rbIPv6Default.Checked = true;
            this.rbIPv6Default.Location = new System.Drawing.Point(15, 25);
            this.rbIPv6Default.Name = "rbIPv6Default";
            this.rbIPv6Default.Size = new System.Drawing.Size(119, 16);
            this.rbIPv6Default.TabIndex = 0;
            this.rbIPv6Default.Text = "使用預設 API 網址";
            this.rbIPv6Default.UseVisualStyleBackColor = true;
            // 
            // PublicIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.gbIPv6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbIPv4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PublicIPForm";
            this.Text = "外部 IP 取得 API 網址設定";
            this.gbIPv4.ResumeLayout(false);
            this.gbIPv4.PerformLayout();
            this.gbIPv6.ResumeLayout(false);
            this.gbIPv6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIPv4;
        private System.Windows.Forms.TextBox txtIPv4;
        private System.Windows.Forms.RadioButton rbIPv4Custom;
        private System.Windows.Forms.RadioButton rbIPv4Default;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbIPv6;
        private System.Windows.Forms.TextBox txtIPv6;
        private System.Windows.Forms.RadioButton rbIPv6Custom;
        private System.Windows.Forms.RadioButton rbIPv6Default;
    }
}