<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentAddData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentAddData))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.btnInsertData = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbProgram = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbProgramLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(637, 12)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 0
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.White
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(596, 12)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 48)
        Me.Panel1.TabIndex = 2
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
        Me.btnBack.Location = New System.Drawing.Point(17, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBack.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBack.OnHoverImage = Nothing
        Me.btnBack.OnPressedColor = System.Drawing.Color.Black
        Me.btnBack.Size = New System.Drawing.Size(51, 35)
        Me.btnBack.TabIndex = 15
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Lavender
        Me.GunaLabel1.Location = New System.Drawing.Point(74, 12)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(168, 21)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Create Student Data"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'btnInsertData
        '
        Me.btnInsertData.AnimationHoverSpeed = 0.07!
        Me.btnInsertData.AnimationSpeed = 0.03!
        Me.btnInsertData.BackColor = System.Drawing.Color.Transparent
        Me.btnInsertData.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInsertData.BorderColor = System.Drawing.Color.Black
        Me.btnInsertData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnInsertData.FocusedColor = System.Drawing.Color.Empty
        Me.btnInsertData.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertData.ForeColor = System.Drawing.Color.White
        Me.btnInsertData.Image = CType(resources.GetObject("btnInsertData.Image"), System.Drawing.Image)
        Me.btnInsertData.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnInsertData.Location = New System.Drawing.Point(498, 306)
        Me.btnInsertData.Name = "btnInsertData"
        Me.btnInsertData.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInsertData.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnInsertData.OnHoverForeColor = System.Drawing.Color.White
        Me.btnInsertData.OnHoverImage = Nothing
        Me.btnInsertData.OnPressedColor = System.Drawing.Color.Black
        Me.btnInsertData.Radius = 3
        Me.btnInsertData.Size = New System.Drawing.Size(150, 38)
        Me.btnInsertData.TabIndex = 8
        Me.btnInsertData.Text = "Insert Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.cmbProgram)
        Me.GroupBox1.Controls.Add(Me.cmbProgramLevel)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 231)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Details"
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYear.ItemHeight = 30
        Me.cmbYear.Items.AddRange(New Object() {"Select Year", "1", "2", "3", "4"})
        Me.cmbYear.Location = New System.Drawing.Point(19, 183)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(277, 36)
        Me.cmbYear.TabIndex = 19
        '
        'cmbProgram
        '
        Me.cmbProgram.BackColor = System.Drawing.Color.Transparent
        Me.cmbProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgram.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProgram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProgram.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbProgram.ItemHeight = 30
        Me.cmbProgram.Items.AddRange(New Object() {"Select Program ", "Computer Science", "Business and Information Technology", "Electronics and Telecommunication"})
        Me.cmbProgram.Location = New System.Drawing.Point(240, 135)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(354, 36)
        Me.cmbProgram.TabIndex = 18
        '
        'cmbProgramLevel
        '
        Me.cmbProgramLevel.BackColor = System.Drawing.Color.Transparent
        Me.cmbProgramLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProgramLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgramLevel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProgramLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProgramLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProgramLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbProgramLevel.ItemHeight = 30
        Me.cmbProgramLevel.Items.AddRange(New Object() {"Select Progam Level", "BSc", "HD"})
        Me.cmbProgramLevel.Location = New System.Drawing.Point(19, 135)
        Me.cmbProgramLevel.Name = "cmbProgramLevel"
        Me.cmbProgramLevel.Size = New System.Drawing.Size(215, 36)
        Me.cmbProgramLevel.TabIndex = 17
        '
        'txtStudentID
        '
        Me.txtStudentID.BorderThickness = 0
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentID.IconLeft = CType(resources.GetObject("txtStudentID.IconLeft"), System.Drawing.Image)
        Me.txtStudentID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtStudentID.Location = New System.Drawing.Point(317, 85)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = "Student ID Number"
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.Size = New System.Drawing.Size(277, 36)
        Me.txtStudentID.TabIndex = 14
        Me.txtStudentID.TextOffset = New System.Drawing.Point(5, 0)
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
        Me.txtLName.Location = New System.Drawing.Point(19, 85)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.PlaceholderText = "Last Name"
        Me.txtLName.SelectedText = ""
        Me.txtLName.Size = New System.Drawing.Size(277, 36)
        Me.txtLName.TabIndex = 13
        Me.txtLName.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txtMName
        '
        Me.txtMName.BorderThickness = 0
        Me.txtMName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMName.DefaultText = ""
        Me.txtMName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMName.IconLeft = CType(resources.GetObject("txtMName.IconLeft"), System.Drawing.Image)
        Me.txtMName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtMName.Location = New System.Drawing.Point(317, 33)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMName.PlaceholderText = "Middle Name"
        Me.txtMName.SelectedText = ""
        Me.txtMName.Size = New System.Drawing.Size(277, 36)
        Me.txtMName.TabIndex = 12
        Me.txtMName.TextOffset = New System.Drawing.Point(5, 0)
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
        Me.txtFName.Location = New System.Drawing.Point(19, 33)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFName.PlaceholderText = "First Name"
        Me.txtFName.SelectedText = ""
        Me.txtFName.Size = New System.Drawing.Size(280, 36)
        Me.txtFName.TabIndex = 11
        Me.txtFName.TextOffset = New System.Drawing.Point(5, 0)
        '
        'frmStudentAddData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 356)
        Me.Controls.Add(Me.btnInsertData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentAddData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnInsertData As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtFName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbProgram As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbProgramLevel As Guna.UI2.WinForms.Guna2ComboBox
End Class
