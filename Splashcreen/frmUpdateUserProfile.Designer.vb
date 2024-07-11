<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateUserProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateUserProfile))
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.txtSecretRestorePin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.btnSelectImage = New Guna.UI2.WinForms.Guna2Button()
        Me.pctUserImage = New System.Windows.Forms.PictureBox()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdateAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.pctUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(742, 11)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 2
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(88, 19)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(164, 21)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "Update User Profile"
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(793, 11)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 0
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel1.Controls.Add(Me.txtSecretRestorePin)
        Me.GunaPanel1.Controls.Add(Me.btnBack)
        Me.GunaPanel1.Controls.Add(Me.btnSelectImage)
        Me.GunaPanel1.Controls.Add(Me.pctUserImage)
        Me.GunaPanel1.Controls.Add(Me.txtConfirmPassword)
        Me.GunaPanel1.Controls.Add(Me.txtLName)
        Me.GunaPanel1.Controls.Add(Me.txtFName)
        Me.GunaPanel1.Controls.Add(Me.btnUpdateAccount)
        Me.GunaPanel1.Controls.Add(Me.txtPassword)
        Me.GunaPanel1.Controls.Add(Me.txtUsername)
        Me.GunaPanel1.Controls.Add(Me.GunaControlBox2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.GunaControlBox1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(851, 318)
        Me.GunaPanel1.TabIndex = 2
        '
        'txtSecretRestorePin
        '
        Me.txtSecretRestorePin.BorderThickness = 0
        Me.txtSecretRestorePin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecretRestorePin.DefaultText = ""
        Me.txtSecretRestorePin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecretRestorePin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecretRestorePin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecretRestorePin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecretRestorePin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecretRestorePin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSecretRestorePin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecretRestorePin.IconLeft = CType(resources.GetObject("txtSecretRestorePin.IconLeft"), System.Drawing.Image)
        Me.txtSecretRestorePin.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtSecretRestorePin.Location = New System.Drawing.Point(51, 177)
        Me.txtSecretRestorePin.Name = "txtSecretRestorePin"
        Me.txtSecretRestorePin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecretRestorePin.PlaceholderText = "Secret Restore Pin"
        Me.txtSecretRestorePin.SelectedText = ""
        Me.txtSecretRestorePin.Size = New System.Drawing.Size(249, 36)
        Me.txtSecretRestorePin.TabIndex = 24
        Me.txtSecretRestorePin.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnBack
        '
        Me.btnBack.AnimationHoverSpeed = 0.07!
        Me.btnBack.AnimationSpeed = 0.03!
        Me.btnBack.BaseColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.Black
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBack.FocusedColor = System.Drawing.Color.Empty
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBack.Location = New System.Drawing.Point(17, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBack.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBack.OnHoverImage = Nothing
        Me.btnBack.OnPressedColor = System.Drawing.Color.Black
        Me.btnBack.Size = New System.Drawing.Size(51, 35)
        Me.btnBack.TabIndex = 23
        '
        'btnSelectImage
        '
        Me.btnSelectImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSelectImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSelectImage.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectImage.ForeColor = System.Drawing.Color.White
        Me.btnSelectImage.Image = CType(resources.GetObject("btnSelectImage.Image"), System.Drawing.Image)
        Me.btnSelectImage.Location = New System.Drawing.Point(638, 177)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(149, 35)
        Me.btnSelectImage.TabIndex = 22
        Me.btnSelectImage.Text = "Update Image"
        '
        'pctUserImage
        '
        Me.pctUserImage.Location = New System.Drawing.Point(638, 65)
        Me.pctUserImage.Name = "pctUserImage"
        Me.pctUserImage.Size = New System.Drawing.Size(149, 106)
        Me.pctUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctUserImage.TabIndex = 21
        Me.pctUserImage.TabStop = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderThickness = 0
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.IconLeft = CType(resources.GetObject("txtConfirmPassword.IconLeft"), System.Drawing.Image)
        Me.txtConfirmPassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(341, 176)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPassword.PlaceholderText = "Confirm Password"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(249, 36)
        Me.txtConfirmPassword.TabIndex = 19
        Me.txtConfirmPassword.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtLName
        '
        Me.txtLName.BorderThickness = 0
        Me.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLName.DefaultText = ""
        Me.txtLName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLName.IconLeft = CType(resources.GetObject("txtLName.IconLeft"), System.Drawing.Image)
        Me.txtLName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtLName.Location = New System.Drawing.Point(51, 122)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.PlaceholderText = "Last Name"
        Me.txtLName.SelectedText = ""
        Me.txtLName.Size = New System.Drawing.Size(249, 36)
        Me.txtLName.TabIndex = 18
        Me.txtLName.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtFName
        '
        Me.txtFName.BorderThickness = 0
        Me.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFName.DefaultText = ""
        Me.txtFName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFName.IconLeft = CType(resources.GetObject("txtFName.IconLeft"), System.Drawing.Image)
        Me.txtFName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFName.Location = New System.Drawing.Point(51, 65)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFName.PlaceholderText = "First Name"
        Me.txtFName.SelectedText = ""
        Me.txtFName.Size = New System.Drawing.Size(249, 36)
        Me.txtFName.TabIndex = 17
        Me.txtFName.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdateAccount.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAccount.ForeColor = System.Drawing.Color.White
        Me.btnUpdateAccount.Image = CType(resources.GetObject("btnUpdateAccount.Image"), System.Drawing.Image)
        Me.btnUpdateAccount.Location = New System.Drawing.Point(51, 240)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Size = New System.Drawing.Size(249, 36)
        Me.btnUpdateAccount.TabIndex = 16
        Me.btnUpdateAccount.Text = "Update Account"
        '
        'txtPassword
        '
        Me.txtPassword.BorderThickness = 0
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconLeft = CType(resources.GetObject("txtPassword.IconLeft"), System.Drawing.Image)
        Me.txtPassword.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPassword.Location = New System.Drawing.Point(341, 119)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(249, 36)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtUsername
        '
        Me.txtUsername.BorderThickness = 0
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconLeft = CType(resources.GetObject("txtUsername.IconLeft"), System.Drawing.Image)
        Me.txtUsername.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtUsername.Location = New System.Drawing.Point(341, 65)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(249, 36)
        Me.txtUsername.TabIndex = 12
        Me.txtUsername.TextOffset = New System.Drawing.Point(5, 0)
        '
        'frmUpdateUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 318)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateUserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserProfile"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.pctUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents txtSecretRestorePin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSelectImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pctUserImage As PictureBox
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdateAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
End Class
