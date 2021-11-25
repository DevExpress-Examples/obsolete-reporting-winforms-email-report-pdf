namespace SendReportAsEMail
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.edtHost = new DevExpress.XtraEditors.TextEdit();
            this.edtPort = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.edtUsername = new DevExpress.XtraEditors.TextEdit();
            this.edtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblProgress = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // edtHost
            // 
            this.edtHost.EditValue = "";
            this.edtHost.Location = new System.Drawing.Point(87, 28);
            this.edtHost.Name = "edtHost";
            this.edtHost.Size = new System.Drawing.Size(169, 20);
            this.edtHost.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Required";
            this.dxValidationProvider1.SetValidationRule(this.edtHost, conditionValidationRule1);
            // 
            // edtPort
            // 
            this.edtPort.EditValue = "25";
            this.edtPort.Location = new System.Drawing.Point(272, 28);
            this.edtPort.Name = "edtPort";
            this.edtPort.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.edtPort.Properties.MaskSettings.Set("mask", "d");
            this.edtPort.Size = new System.Drawing.Size(48, 20);
            this.edtPort.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Required";
            conditionValidationRule2.Values.Add("0");
            this.dxValidationProvider1.SetValidationRule(this.edtPort, conditionValidationRule2);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(209, 120);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 262);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(25, 350);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(295, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "SMTP HOST";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(262, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = ":";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Username";
            // 
            // edtUsername
            // 
            this.edtUsername.EditValue = "";
            this.edtUsername.Location = new System.Drawing.Point(87, 67);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(233, 20);
            this.edtUsername.TabIndex = 6;
            // 
            // edtPassword
            // 
            this.edtPassword.EditValue = "";
            this.edtPassword.Location = new System.Drawing.Point(87, 106);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Properties.PasswordChar = '*';
            this.edtPassword.Properties.UseSystemPasswordChar = true;
            this.edtPassword.Size = new System.Drawing.Size(233, 20);
            this.edtPassword.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Password";
            // 
            // lblProgress
            // 
            this.lblProgress.Appearance.Options.UseTextOptions = true;
            this.lblProgress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblProgress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblProgress.Location = new System.Drawing.Point(25, 213);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(295, 0);
            this.lblProgress.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 402);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.edtPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.edtHost);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Email Report Example";
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.Button btnSend;
        private DevExpress.XtraEditors.TextEdit edtHost;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit edtPort;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit edtUsername;
        private DevExpress.XtraEditors.TextEdit edtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblProgress;
    }
}

