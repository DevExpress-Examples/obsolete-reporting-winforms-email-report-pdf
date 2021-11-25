Namespace SendReportAsEMail
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
            Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
            Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
            Me.edtHost = New DevExpress.XtraEditors.TextEdit()
            Me.edtPort = New DevExpress.XtraEditors.TextEdit()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.btnSend = New System.Windows.Forms.Button()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.edtUsername = New DevExpress.XtraEditors.TextEdit()
            Me.edtPassword = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.lblProgress = New DevExpress.XtraEditors.LabelControl()
            CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.edtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dxValidationProvider1
            '
            Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
            '
            'edtHost
            '
            Me.edtHost.EditValue = ""
            Me.edtHost.Location = New System.Drawing.Point(87, 28)
            Me.edtHost.Name = "edtHost"
            Me.edtHost.Size = New System.Drawing.Size(169, 20)
            Me.edtHost.TabIndex = 1
            ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
            ConditionValidationRule1.ErrorText = "Required"
            Me.dxValidationProvider1.SetValidationRule(Me.edtHost, ConditionValidationRule1)
            '
            'edtPort
            '
            Me.edtPort.EditValue = "25"
            Me.edtPort.Location = New System.Drawing.Point(272, 28)
            Me.edtPort.Name = "edtPort"
            Me.edtPort.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
            Me.edtPort.Properties.MaskSettings.Set("mask", "d")
            Me.edtPort.Size = New System.Drawing.Size(48, 20)
            Me.edtPort.TabIndex = 3
            ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
            ConditionValidationRule2.ErrorText = "Required"
            ConditionValidationRule2.Values.Add("0")
            Me.dxValidationProvider1.SetValidationRule(Me.edtPort, ConditionValidationRule2)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(209, 120)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(10, 262)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'btnSend
            '
            Me.btnSend.Location = New System.Drawing.Point(25, 350)
            Me.btnSend.Name = "btnSend"
            Me.btnSend.Size = New System.Drawing.Size(295, 28)
            Me.btnSend.TabIndex = 0
            Me.btnSend.Text = "SEND"
            Me.btnSend.UseVisualStyleBackColor = True
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(20, 31)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(56, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "SMTP HOST"
            '
            'labelControl2
            '
            Me.labelControl2.Location = New System.Drawing.Point(262, 31)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(4, 13)
            Me.labelControl2.TabIndex = 4
            Me.labelControl2.Text = ":"
            '
            'labelControl3
            '
            Me.labelControl3.Location = New System.Drawing.Point(20, 70)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(48, 13)
            Me.labelControl3.TabIndex = 5
            Me.labelControl3.Text = "Username"
            '
            'edtUsername
            '
            Me.edtUsername.EditValue = ""
            Me.edtUsername.Location = New System.Drawing.Point(87, 67)
            Me.edtUsername.Name = "edtUsername"
            Me.edtUsername.Size = New System.Drawing.Size(233, 20)
            Me.edtUsername.TabIndex = 6
            '
            'edtPassword
            '
            Me.edtPassword.EditValue = ""
            Me.edtPassword.Location = New System.Drawing.Point(87, 106)
            Me.edtPassword.Name = "edtPassword"
            Me.edtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.edtPassword.Properties.UseSystemPasswordChar = True
            Me.edtPassword.Size = New System.Drawing.Size(233, 20)
            Me.edtPassword.TabIndex = 8
            '
            'labelControl4
            '
            Me.labelControl4.Location = New System.Drawing.Point(20, 109)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(46, 13)
            Me.labelControl4.TabIndex = 7
            Me.labelControl4.Text = "Password"
            '
            'lblProgress
            '
            Me.lblProgress.Appearance.Options.UseTextOptions = True
            Me.lblProgress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblProgress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.lblProgress.Location = New System.Drawing.Point(25, 213)
            Me.lblProgress.Name = "lblProgress"
            Me.lblProgress.Size = New System.Drawing.Size(295, 0)
            Me.lblProgress.TabIndex = 9
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(351, 402)
            Me.Controls.Add(Me.lblProgress)
            Me.Controls.Add(Me.edtPassword)
            Me.Controls.Add(Me.labelControl4)
            Me.Controls.Add(Me.edtUsername)
            Me.Controls.Add(Me.labelControl3)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.edtPort)
            Me.Controls.Add(Me.btnSend)
            Me.Controls.Add(Me.edtHost)
            Me.Controls.Add(Me.labelControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.Text = "Email Report Example"
            CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.edtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
		Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
		Private WithEvents btnSend As System.Windows.Forms.Button
		Private edtHost As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private edtPort As DevExpress.XtraEditors.TextEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private edtUsername As DevExpress.XtraEditors.TextEdit
		Private edtPassword As DevExpress.XtraEditors.TextEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private lblProgress As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

