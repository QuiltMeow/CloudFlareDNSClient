namespace CloudFlareDNSClient
{
    partial class PreferenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenceForm));
            this.gbNetwork = new System.Windows.Forms.GroupBox();
            this.gbIPDetect = new System.Windows.Forms.GroupBox();
            this.rbIPDetectLocal = new System.Windows.Forms.RadioButton();
            this.rbIPDetectRemote = new System.Windows.Forms.RadioButton();
            this.cbAdapter = new System.Windows.Forms.ComboBox();
            this.labelAdapter = new System.Windows.Forms.Label();
            this.gbUpdateInterval = new System.Windows.Forms.GroupBox();
            this.numUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.labelUpdateIntervalUnit = new System.Windows.Forms.Label();
            this.labelUpdateInterval = new System.Windows.Forms.Label();
            this.gbStartUp = new System.Windows.Forms.GroupBox();
            this.chkStartUpMin = new System.Windows.Forms.CheckBox();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.chkForceUpdate = new System.Windows.Forms.CheckBox();
            this.gbNetwork.SuspendLayout();
            this.gbIPDetect.SuspendLayout();
            this.gbUpdateInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateInterval)).BeginInit();
            this.gbStartUp.SuspendLayout();
            this.gbOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNetwork
            // 
            this.gbNetwork.Controls.Add(this.gbIPDetect);
            this.gbNetwork.Controls.Add(this.cbAdapter);
            this.gbNetwork.Controls.Add(this.labelAdapter);
            this.gbNetwork.Location = new System.Drawing.Point(12, 80);
            this.gbNetwork.Name = "gbNetwork";
            this.gbNetwork.Size = new System.Drawing.Size(405, 220);
            this.gbNetwork.TabIndex = 1;
            this.gbNetwork.TabStop = false;
            this.gbNetwork.Text = "網路設定";
            // 
            // gbIPDetect
            // 
            this.gbIPDetect.Controls.Add(this.rbIPDetectLocal);
            this.gbIPDetect.Controls.Add(this.rbIPDetectRemote);
            this.gbIPDetect.Location = new System.Drawing.Point(20, 85);
            this.gbIPDetect.Name = "gbIPDetect";
            this.gbIPDetect.Size = new System.Drawing.Size(370, 120);
            this.gbIPDetect.TabIndex = 2;
            this.gbIPDetect.TabStop = false;
            this.gbIPDetect.Text = "IP 偵測方式";
            // 
            // rbIPDetectLocal
            // 
            this.rbIPDetectLocal.AutoSize = true;
            this.rbIPDetectLocal.Location = new System.Drawing.Point(35, 75);
            this.rbIPDetectLocal.Name = "rbIPDetectLocal";
            this.rbIPDetectLocal.Size = new System.Drawing.Size(147, 16);
            this.rbIPDetectLocal.TabIndex = 1;
            this.rbIPDetectLocal.Text = "使用本地網路卡 IP 位址";
            this.rbIPDetectLocal.UseVisualStyleBackColor = true;
            this.rbIPDetectLocal.CheckedChanged += new System.EventHandler(this.rbIPDetectLocal_CheckedChanged);
            // 
            // rbIPDetectRemote
            // 
            this.rbIPDetectRemote.AutoSize = true;
            this.rbIPDetectRemote.Checked = true;
            this.rbIPDetectRemote.Location = new System.Drawing.Point(35, 35);
            this.rbIPDetectRemote.Name = "rbIPDetectRemote";
            this.rbIPDetectRemote.Size = new System.Drawing.Size(132, 16);
            this.rbIPDetectRemote.TabIndex = 0;
            this.rbIPDetectRemote.TabStop = true;
            this.rbIPDetectRemote.Text = "使用遠端方式偵測 IP";
            this.rbIPDetectRemote.UseVisualStyleBackColor = true;
            this.rbIPDetectRemote.CheckedChanged += new System.EventHandler(this.rbIPDetectRemote_CheckedChanged);
            // 
            // cbAdapter
            // 
            this.cbAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdapter.FormattingEnabled = true;
            this.cbAdapter.Location = new System.Drawing.Point(30, 50);
            this.cbAdapter.Name = "cbAdapter";
            this.cbAdapter.Size = new System.Drawing.Size(360, 20);
            this.cbAdapter.TabIndex = 1;
            this.cbAdapter.SelectedIndexChanged += new System.EventHandler(this.cbAdapter_SelectedIndexChanged);
            // 
            // labelAdapter
            // 
            this.labelAdapter.AutoSize = true;
            this.labelAdapter.Location = new System.Drawing.Point(20, 30);
            this.labelAdapter.Name = "labelAdapter";
            this.labelAdapter.Size = new System.Drawing.Size(41, 12);
            this.labelAdapter.TabIndex = 0;
            this.labelAdapter.Text = "網路卡";
            // 
            // gbUpdateInterval
            // 
            this.gbUpdateInterval.Controls.Add(this.numUpdateInterval);
            this.gbUpdateInterval.Controls.Add(this.labelUpdateIntervalUnit);
            this.gbUpdateInterval.Controls.Add(this.labelUpdateInterval);
            this.gbUpdateInterval.Location = new System.Drawing.Point(12, 315);
            this.gbUpdateInterval.Name = "gbUpdateInterval";
            this.gbUpdateInterval.Size = new System.Drawing.Size(405, 75);
            this.gbUpdateInterval.TabIndex = 2;
            this.gbUpdateInterval.TabStop = false;
            this.gbUpdateInterval.Text = "位址更新";
            // 
            // numUpdateInterval
            // 
            this.numUpdateInterval.Location = new System.Drawing.Point(85, 33);
            this.numUpdateInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numUpdateInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateInterval.Name = "numUpdateInterval";
            this.numUpdateInterval.Size = new System.Drawing.Size(120, 22);
            this.numUpdateInterval.TabIndex = 1;
            this.numUpdateInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpdateInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpdateInterval.ValueChanged += new System.EventHandler(this.numUpdateInterval_ValueChanged);
            // 
            // labelUpdateIntervalUnit
            // 
            this.labelUpdateIntervalUnit.AutoSize = true;
            this.labelUpdateIntervalUnit.Location = new System.Drawing.Point(220, 35);
            this.labelUpdateIntervalUnit.Name = "labelUpdateIntervalUnit";
            this.labelUpdateIntervalUnit.Size = new System.Drawing.Size(29, 12);
            this.labelUpdateIntervalUnit.TabIndex = 2;
            this.labelUpdateIntervalUnit.Text = "分鐘";
            // 
            // labelUpdateInterval
            // 
            this.labelUpdateInterval.AutoSize = true;
            this.labelUpdateInterval.Location = new System.Drawing.Point(20, 35);
            this.labelUpdateInterval.Name = "labelUpdateInterval";
            this.labelUpdateInterval.Size = new System.Drawing.Size(53, 12);
            this.labelUpdateInterval.TabIndex = 0;
            this.labelUpdateInterval.Text = "更新間隔";
            // 
            // gbStartUp
            // 
            this.gbStartUp.Controls.Add(this.chkStartUpMin);
            this.gbStartUp.Location = new System.Drawing.Point(12, 12);
            this.gbStartUp.Name = "gbStartUp";
            this.gbStartUp.Size = new System.Drawing.Size(405, 55);
            this.gbStartUp.TabIndex = 0;
            this.gbStartUp.TabStop = false;
            this.gbStartUp.Text = "啟動設定";
            // 
            // chkStartUpMin
            // 
            this.chkStartUpMin.AutoSize = true;
            this.chkStartUpMin.Location = new System.Drawing.Point(20, 25);
            this.chkStartUpMin.Name = "chkStartUpMin";
            this.chkStartUpMin.Size = new System.Drawing.Size(96, 16);
            this.chkStartUpMin.TabIndex = 0;
            this.chkStartUpMin.Text = "啟動時最小化";
            this.chkStartUpMin.UseVisualStyleBackColor = true;
            this.chkStartUpMin.CheckedChanged += new System.EventHandler(this.chkStartUpMin_CheckedChanged);
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.chkForceUpdate);
            this.gbOther.Location = new System.Drawing.Point(12, 405);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(405, 55);
            this.gbOther.TabIndex = 3;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "其他設定";
            // 
            // chkForceUpdate
            // 
            this.chkForceUpdate.AutoSize = true;
            this.chkForceUpdate.Location = new System.Drawing.Point(20, 25);
            this.chkForceUpdate.Name = "chkForceUpdate";
            this.chkForceUpdate.Size = new System.Drawing.Size(172, 16);
            this.chkForceUpdate.TabIndex = 0;
            this.chkForceUpdate.Text = "不論 IP 是否變更皆進行更新";
            this.chkForceUpdate.UseVisualStyleBackColor = true;
            this.chkForceUpdate.CheckedChanged += new System.EventHandler(this.chkForceUpdate_CheckedChanged);
            // 
            // PreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 476);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbStartUp);
            this.Controls.Add(this.gbUpdateInterval);
            this.Controls.Add(this.gbNetwork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferenceForm";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.PreferenceForm_Load);
            this.gbNetwork.ResumeLayout(false);
            this.gbNetwork.PerformLayout();
            this.gbIPDetect.ResumeLayout(false);
            this.gbIPDetect.PerformLayout();
            this.gbUpdateInterval.ResumeLayout(false);
            this.gbUpdateInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateInterval)).EndInit();
            this.gbStartUp.ResumeLayout(false);
            this.gbStartUp.PerformLayout();
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNetwork;
        private System.Windows.Forms.GroupBox gbIPDetect;
        private System.Windows.Forms.RadioButton rbIPDetectLocal;
        private System.Windows.Forms.RadioButton rbIPDetectRemote;
        private System.Windows.Forms.ComboBox cbAdapter;
        private System.Windows.Forms.Label labelAdapter;
        private System.Windows.Forms.GroupBox gbUpdateInterval;
        private System.Windows.Forms.Label labelUpdateIntervalUnit;
        private System.Windows.Forms.Label labelUpdateInterval;
        private System.Windows.Forms.GroupBox gbStartUp;
        private System.Windows.Forms.CheckBox chkStartUpMin;
        private System.Windows.Forms.NumericUpDown numUpdateInterval;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.CheckBox chkForceUpdate;
    }
}