namespace CloudFlareDNSClient
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.labelMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.labelAPIAccess = new System.Windows.Forms.Label();
            this.txtAPIAccess = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.llRegister = new System.Windows.Forms.LinkLabel();
            this.rbUseAPIKey = new System.Windows.Forms.RadioButton();
            this.rbUseAPIToken = new System.Windows.Forms.RadioButton();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.labelZone = new System.Windows.Forms.Label();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.pbAlert = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.labelAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(12, 105);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(59, 15);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "電子郵件";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(95, 102);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(255, 23);
            this.txtMail.TabIndex = 5;
            // 
            // labelAPIAccess
            // 
            this.labelAPIAccess.AutoSize = true;
            this.labelAPIAccess.Location = new System.Drawing.Point(12, 180);
            this.labelAPIAccess.Name = "labelAPIAccess";
            this.labelAPIAccess.Size = new System.Drawing.Size(54, 15);
            this.labelAPIAccess.TabIndex = 9;
            this.labelAPIAccess.Text = "API 金鑰";
            // 
            // txtAPIAccess
            // 
            this.txtAPIAccess.Location = new System.Drawing.Point(95, 177);
            this.txtAPIAccess.Name = "txtAPIAccess";
            this.txtAPIAccess.Size = new System.Drawing.Size(255, 23);
            this.txtAPIAccess.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llRegister
            // 
            this.llRegister.AutoSize = true;
            this.llRegister.Location = new System.Drawing.Point(12, 315);
            this.llRegister.Name = "llRegister";
            this.llRegister.Size = new System.Drawing.Size(83, 15);
            this.llRegister.TabIndex = 14;
            this.llRegister.TabStop = true;
            this.llRegister.Text = "設定 API 資訊";
            this.llRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegister_LinkClicked);
            // 
            // rbUseAPIKey
            // 
            this.rbUseAPIKey.AutoSize = true;
            this.rbUseAPIKey.Checked = true;
            this.rbUseAPIKey.Location = new System.Drawing.Point(110, 143);
            this.rbUseAPIKey.Name = "rbUseAPIKey";
            this.rbUseAPIKey.Size = new System.Drawing.Size(94, 19);
            this.rbUseAPIKey.TabIndex = 7;
            this.rbUseAPIKey.TabStop = true;
            this.rbUseAPIKey.Text = "使用 API Key";
            this.rbUseAPIKey.UseVisualStyleBackColor = true;
            // 
            // rbUseAPIToken
            // 
            this.rbUseAPIToken.AutoSize = true;
            this.rbUseAPIToken.Location = new System.Drawing.Point(220, 143);
            this.rbUseAPIToken.Name = "rbUseAPIToken";
            this.rbUseAPIToken.Size = new System.Drawing.Size(106, 19);
            this.rbUseAPIToken.TabIndex = 8;
            this.rbUseAPIToken.Text = "使用 API Token";
            this.rbUseAPIToken.UseVisualStyleBackColor = true;
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(95, 222);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(255, 23);
            this.txtZone.TabIndex = 12;
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(12, 225);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(54, 30);
            this.labelZone.TabIndex = 11;
            this.labelZone.Text = "區域 ID\r\n(可省略)";
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Location = new System.Drawing.Point(12, 145);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(59, 15);
            this.labelAuthorization.TabIndex = 6;
            this.labelAuthorization.Text = "認證方式";
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Location = new System.Drawing.Point(195, 40);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(54, 15);
            this.labelDynamic.TabIndex = 1;
            this.labelDynamic.Text = "Dynamic";
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.ForeColor = System.Drawing.Color.Green;
            this.labelUpdate.Location = new System.Drawing.Point(255, 40);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(45, 15);
            this.labelUpdate.TabIndex = 2;
            this.labelUpdate.Text = "Update";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(306, 40);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(38, 15);
            this.labelClient.TabIndex = 3;
            this.labelClient.Text = "Client";
            // 
            // labelSeparator
            // 
            this.labelSeparator.AutoSize = true;
            this.labelSeparator.ForeColor = System.Drawing.Color.Green;
            this.labelSeparator.Location = new System.Drawing.Point(175, 40);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(10, 15);
            this.labelSeparator.TabIndex = 0;
            this.labelSeparator.Text = "|";
            // 
            // pbAlert
            // 
            this.pbAlert.Image = global::CloudFlareDNSClient.Properties.Resources.Alert;
            this.pbAlert.Location = new System.Drawing.Point(165, 365);
            this.pbAlert.Name = "pbAlert";
            this.pbAlert.Size = new System.Drawing.Size(30, 28);
            this.pbAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlert.TabIndex = 16;
            this.pbAlert.TabStop = false;
            this.pbAlert.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CloudFlareDNSClient.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(25, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(140, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // labelAlert
            // 
            this.labelAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAlert.Location = new System.Drawing.Point(55, 405);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(250, 15);
            this.labelAlert.TabIndex = 15;
            this.labelAlert.Text = "錯誤訊息";
            this.labelAlert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAlert.Visible = false;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(374, 441);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.pbAlert);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.labelAuthorization);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.rbUseAPIToken);
            this.Controls.Add(this.rbUseAPIKey);
            this.Controls.Add(this.llRegister);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAPIAccess);
            this.Controls.Add(this.labelAPIAccess);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelMail);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.Text = "帳號";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label labelAPIAccess;
        private System.Windows.Forms.TextBox txtAPIAccess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel llRegister;
        private System.Windows.Forms.RadioButton rbUseAPIKey;
        private System.Windows.Forms.RadioButton rbUseAPIToken;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.PictureBox pbAlert;
        private System.Windows.Forms.Label labelAlert;
    }
}