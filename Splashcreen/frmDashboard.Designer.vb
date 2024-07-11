<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnProgram = New Guna.UI.WinForms.GunaButton()
        Me.btnCourse = New Guna.UI.WinForms.GunaButton()
        Me.btnStudent = New Guna.UI.WinForms.GunaButton()
        Me.btnGrade = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnViewGradebook = New Guna.UI.WinForms.GunaButton()
        Me.btnViewAllStudentGrade = New Guna.UI.WinForms.GunaButton()
        Me.btnModifyStudentGrade = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbUserAccount = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserPictureBox = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblUserFullName = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.lblAcademicYear = New Guna.UI.WinForms.GunaLabel()
        Me.btnDBProgram = New Guna.UI.WinForms.GunaButton()
        Me.btnDBGrade = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.lblUserRole = New Guna.UI.WinForms.GunaLabel()
        Me.btnDBCourse = New Guna.UI.WinForms.GunaButton()
        Me.pnlPerformanceAnalysis = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btnDBStudent = New Guna.UI.WinForms.GunaButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(199, 235)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(181, 21)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "Performance Analysis"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(215, 69)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(95, 21)
        Me.GunaLabel2.TabIndex = 10
        Me.GunaLabel2.Text = "Dashboard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProgram)
        Me.GroupBox1.Controls.Add(Me.btnCourse)
        Me.GroupBox1.Controls.Add(Me.btnStudent)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 176)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'btnProgram
        '
        Me.btnProgram.AnimationHoverSpeed = 0.07!
        Me.btnProgram.AnimationSpeed = 0.03!
        Me.btnProgram.BackColor = System.Drawing.Color.Transparent
        Me.btnProgram.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnProgram.BorderColor = System.Drawing.Color.Black
        Me.btnProgram.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProgram.FocusedColor = System.Drawing.Color.Empty
        Me.btnProgram.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProgram.ForeColor = System.Drawing.Color.White
        Me.btnProgram.Image = CType(resources.GetObject("btnProgram.Image"), System.Drawing.Image)
        Me.btnProgram.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnProgram.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnProgram.Location = New System.Drawing.Point(19, 70)
        Me.btnProgram.Name = "btnProgram"
        Me.btnProgram.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProgram.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnProgram.OnHoverForeColor = System.Drawing.Color.White
        Me.btnProgram.OnHoverImage = Nothing
        Me.btnProgram.OnPressedColor = System.Drawing.Color.Black
        Me.btnProgram.Radius = 5
        Me.btnProgram.Size = New System.Drawing.Size(128, 41)
        Me.btnProgram.TabIndex = 14
        Me.btnProgram.Text = "Programs"
        Me.btnProgram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCourse
        '
        Me.btnCourse.AnimationHoverSpeed = 0.07!
        Me.btnCourse.AnimationSpeed = 0.03!
        Me.btnCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnCourse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCourse.BorderColor = System.Drawing.Color.Black
        Me.btnCourse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCourse.FocusedColor = System.Drawing.Color.Empty
        Me.btnCourse.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.Color.White
        Me.btnCourse.Image = CType(resources.GetObject("btnCourse.Image"), System.Drawing.Image)
        Me.btnCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCourse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCourse.Location = New System.Drawing.Point(19, 116)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCourse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCourse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCourse.OnHoverImage = Nothing
        Me.btnCourse.OnPressedColor = System.Drawing.Color.Black
        Me.btnCourse.Radius = 3
        Me.btnCourse.Size = New System.Drawing.Size(128, 38)
        Me.btnCourse.TabIndex = 12
        Me.btnCourse.Text = "Courses"
        Me.btnCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStudent
        '
        Me.btnStudent.AnimationHoverSpeed = 0.07!
        Me.btnStudent.AnimationSpeed = 0.03!
        Me.btnStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnStudent.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnStudent.BorderColor = System.Drawing.Color.Black
        Me.btnStudent.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStudent.FocusedColor = System.Drawing.Color.Empty
        Me.btnStudent.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.Image = CType(resources.GetObject("btnStudent.Image"), System.Drawing.Image)
        Me.btnStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnStudent.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStudent.Location = New System.Drawing.Point(19, 23)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudent.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStudent.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStudent.OnHoverImage = Nothing
        Me.btnStudent.OnPressedColor = System.Drawing.Color.Black
        Me.btnStudent.Radius = 3
        Me.btnStudent.Size = New System.Drawing.Size(128, 42)
        Me.btnStudent.TabIndex = 11
        Me.btnStudent.Text = "Students"
        Me.btnStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGrade
        '
        Me.btnGrade.AnimationHoverSpeed = 0.07!
        Me.btnGrade.AnimationSpeed = 0.03!
        Me.btnGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnGrade.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnGrade.BorderColor = System.Drawing.Color.Black
        Me.btnGrade.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGrade.FocusedColor = System.Drawing.Color.Empty
        Me.btnGrade.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrade.ForeColor = System.Drawing.Color.White
        Me.btnGrade.Image = CType(resources.GetObject("btnGrade.Image"), System.Drawing.Image)
        Me.btnGrade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnGrade.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGrade.Location = New System.Drawing.Point(19, 29)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrade.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGrade.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGrade.OnHoverImage = Nothing
        Me.btnGrade.OnPressedColor = System.Drawing.Color.Black
        Me.btnGrade.Radius = 5
        Me.btnGrade.Size = New System.Drawing.Size(128, 41)
        Me.btnGrade.TabIndex = 13
        Me.btnGrade.Text = "Add"
        Me.btnGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnViewGradebook)
        Me.GroupBox2.Controls.Add(Me.btnGrade)
        Me.GroupBox2.Controls.Add(Me.btnViewAllStudentGrade)
        Me.GroupBox2.Controls.Add(Me.btnModifyStudentGrade)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 217)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grades Workbook"
        '
        'btnViewGradebook
        '
        Me.btnViewGradebook.AnimationHoverSpeed = 0.07!
        Me.btnViewGradebook.AnimationSpeed = 0.03!
        Me.btnViewGradebook.BackColor = System.Drawing.Color.Transparent
        Me.btnViewGradebook.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnViewGradebook.BorderColor = System.Drawing.Color.Black
        Me.btnViewGradebook.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewGradebook.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewGradebook.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewGradebook.ForeColor = System.Drawing.Color.White
        Me.btnViewGradebook.Image = CType(resources.GetObject("btnViewGradebook.Image"), System.Drawing.Image)
        Me.btnViewGradebook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnViewGradebook.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnViewGradebook.Location = New System.Drawing.Point(19, 170)
        Me.btnViewGradebook.Name = "btnViewGradebook"
        Me.btnViewGradebook.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewGradebook.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewGradebook.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewGradebook.OnHoverImage = Nothing
        Me.btnViewGradebook.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewGradebook.Radius = 5
        Me.btnViewGradebook.Size = New System.Drawing.Size(128, 41)
        Me.btnViewGradebook.TabIndex = 16
        Me.btnViewGradebook.Text = "Summary"
        Me.btnViewGradebook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnViewAllStudentGrade
        '
        Me.btnViewAllStudentGrade.AnimationHoverSpeed = 0.07!
        Me.btnViewAllStudentGrade.AnimationSpeed = 0.03!
        Me.btnViewAllStudentGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAllStudentGrade.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnViewAllStudentGrade.BorderColor = System.Drawing.Color.Black
        Me.btnViewAllStudentGrade.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewAllStudentGrade.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewAllStudentGrade.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAllStudentGrade.ForeColor = System.Drawing.Color.White
        Me.btnViewAllStudentGrade.Image = CType(resources.GetObject("btnViewAllStudentGrade.Image"), System.Drawing.Image)
        Me.btnViewAllStudentGrade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnViewAllStudentGrade.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnViewAllStudentGrade.Location = New System.Drawing.Point(19, 123)
        Me.btnViewAllStudentGrade.Name = "btnViewAllStudentGrade"
        Me.btnViewAllStudentGrade.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAllStudentGrade.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewAllStudentGrade.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewAllStudentGrade.OnHoverImage = Nothing
        Me.btnViewAllStudentGrade.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewAllStudentGrade.Radius = 5
        Me.btnViewAllStudentGrade.Size = New System.Drawing.Size(128, 41)
        Me.btnViewAllStudentGrade.TabIndex = 15
        Me.btnViewAllStudentGrade.Text = "View All"
        Me.btnViewAllStudentGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModifyStudentGrade
        '
        Me.btnModifyStudentGrade.AnimationHoverSpeed = 0.07!
        Me.btnModifyStudentGrade.AnimationSpeed = 0.03!
        Me.btnModifyStudentGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnModifyStudentGrade.BaseColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnModifyStudentGrade.BorderColor = System.Drawing.Color.Black
        Me.btnModifyStudentGrade.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnModifyStudentGrade.FocusedColor = System.Drawing.Color.Empty
        Me.btnModifyStudentGrade.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifyStudentGrade.ForeColor = System.Drawing.Color.White
        Me.btnModifyStudentGrade.Image = CType(resources.GetObject("btnModifyStudentGrade.Image"), System.Drawing.Image)
        Me.btnModifyStudentGrade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnModifyStudentGrade.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnModifyStudentGrade.Location = New System.Drawing.Point(19, 76)
        Me.btnModifyStudentGrade.Name = "btnModifyStudentGrade"
        Me.btnModifyStudentGrade.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnModifyStudentGrade.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnModifyStudentGrade.OnHoverForeColor = System.Drawing.Color.White
        Me.btnModifyStudentGrade.OnHoverImage = Nothing
        Me.btnModifyStudentGrade.OnPressedColor = System.Drawing.Color.Black
        Me.btnModifyStudentGrade.Radius = 5
        Me.btnModifyStudentGrade.Size = New System.Drawing.Size(128, 41)
        Me.btnModifyStudentGrade.TabIndex = 14
        Me.btnModifyStudentGrade.Text = "Modify"
        Me.btnModifyStudentGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(193, 558)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbUserAccount)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 487)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(165, 60)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Settings"
        '
        'cmbUserAccount
        '
        Me.cmbUserAccount.BackColor = System.Drawing.Color.Transparent
        Me.cmbUserAccount.BaseColor = System.Drawing.Color.White
        Me.cmbUserAccount.BorderColor = System.Drawing.Color.Silver
        Me.cmbUserAccount.BorderSize = 0
        Me.cmbUserAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbUserAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserAccount.FocusedColor = System.Drawing.Color.Empty
        Me.cmbUserAccount.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserAccount.ForeColor = System.Drawing.Color.Black
        Me.cmbUserAccount.FormattingEnabled = True
        Me.cmbUserAccount.Items.AddRange(New Object() {"User Account", "User Profile", "Logout"})
        Me.cmbUserAccount.Location = New System.Drawing.Point(6, 23)
        Me.cmbUserAccount.Name = "cmbUserAccount"
        Me.cmbUserAccount.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbUserAccount.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbUserAccount.Radius = 3
        Me.cmbUserAccount.Size = New System.Drawing.Size(153, 26)
        Me.cmbUserAccount.TabIndex = 13
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton6.ForeColor = System.Drawing.Color.White
        Me.GunaButton6.Image = CType(resources.GetObject("GunaButton6.Image"), System.Drawing.Image)
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(813, 216)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Radius = 3
        Me.GunaButton6.Size = New System.Drawing.Size(160, 45)
        Me.GunaButton6.TabIndex = 8
        Me.GunaButton6.Text = "Analyze"
        Me.GunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.UserPictureBox)
        Me.Panel1.Controls.Add(Me.lblUserFullName)
        Me.Panel1.Controls.Add(Me.GunaButton12)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1006, 55)
        Me.Panel1.TabIndex = 3
        '
        'UserPictureBox
        '
        Me.UserPictureBox.BaseColor = System.Drawing.Color.White
        Me.UserPictureBox.Location = New System.Drawing.Point(732, 10)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(46, 40)
        Me.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPictureBox.TabIndex = 16
        Me.UserPictureBox.TabStop = False
        Me.UserPictureBox.UseTransfarantBackground = False
        '
        'lblUserFullName
        '
        Me.lblUserFullName.AutoSize = True
        Me.lblUserFullName.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserFullName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblUserFullName.Location = New System.Drawing.Point(782, 22)
        Me.lblUserFullName.Name = "lblUserFullName"
        Me.lblUserFullName.Size = New System.Drawing.Size(97, 17)
        Me.lblUserFullName.TabIndex = 14
        Me.lblUserFullName.Text = "UserFullName"
        '
        'GunaButton12
        '
        Me.GunaButton12.AnimationHoverSpeed = 0.07!
        Me.GunaButton12.AnimationSpeed = 0.03!
        Me.GunaButton12.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton12.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton12.BorderColor = System.Drawing.Color.Black
        Me.GunaButton12.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton12.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton12.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton12.ForeColor = System.Drawing.Color.White
        Me.GunaButton12.Image = CType(resources.GetObject("GunaButton12.Image"), System.Drawing.Image)
        Me.GunaButton12.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton12.Location = New System.Drawing.Point(19, 12)
        Me.GunaButton12.Name = "GunaButton12"
        Me.GunaButton12.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton12.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton12.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton12.OnHoverImage = Nothing
        Me.GunaButton12.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton12.Radius = 3
        Me.GunaButton12.Size = New System.Drawing.Size(37, 38)
        Me.GunaButton12.TabIndex = 11
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLabel1.Location = New System.Drawing.Point(51, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(238, 21)
        Me.GunaLabel1.TabIndex = 10
        Me.GunaLabel1.Text = " Grading Information System"
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(899, 12)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(950, 13)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 0
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaPanel1.Controls.Add(Me.lblAcademicYear)
        Me.GunaPanel1.Controls.Add(Me.btnDBProgram)
        Me.GunaPanel1.Controls.Add(Me.GunaButton6)
        Me.GunaPanel1.Controls.Add(Me.btnDBGrade)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaPanel1.Controls.Add(Me.lblUserRole)
        Me.GunaPanel1.Controls.Add(Me.btnDBCourse)
        Me.GunaPanel1.Controls.Add(Me.pnlPerformanceAnalysis)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel1.Controls.Add(Me.btnDBStudent)
        Me.GunaPanel1.Controls.Add(Me.Panel2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1006, 560)
        Me.GunaPanel1.TabIndex = 2
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel6.Location = New System.Drawing.Point(855, 69)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(114, 15)
        Me.GunaLabel6.TabIndex = 19
        Me.GunaLabel6.Text = "Academic Session"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(766, 69)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(54, 15)
        Me.GunaLabel5.TabIndex = 18
        Me.GunaLabel5.Text = "for the :"
        '
        'lblAcademicYear
        '
        Me.lblAcademicYear.AutoSize = True
        Me.lblAcademicYear.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcademicYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAcademicYear.Location = New System.Drawing.Point(819, 69)
        Me.lblAcademicYear.Name = "lblAcademicYear"
        Me.lblAcademicYear.Size = New System.Drawing.Size(41, 15)
        Me.lblAcademicYear.TabIndex = 17
        Me.lblAcademicYear.Text = "Value"
        '
        'btnDBProgram
        '
        Me.btnDBProgram.AnimationHoverSpeed = 0.07!
        Me.btnDBProgram.AnimationSpeed = 0.03!
        Me.btnDBProgram.BackColor = System.Drawing.Color.Transparent
        Me.btnDBProgram.BaseColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnDBProgram.BorderColor = System.Drawing.Color.Black
        Me.btnDBProgram.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDBProgram.FocusedColor = System.Drawing.Color.Empty
        Me.btnDBProgram.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBProgram.ForeColor = System.Drawing.Color.White
        Me.btnDBProgram.Image = CType(resources.GetObject("btnDBProgram.Image"), System.Drawing.Image)
        Me.btnDBProgram.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDBProgram.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDBProgram.Location = New System.Drawing.Point(404, 103)
        Me.btnDBProgram.Name = "btnDBProgram"
        Me.btnDBProgram.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDBProgram.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDBProgram.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDBProgram.OnHoverImage = Nothing
        Me.btnDBProgram.OnPressedColor = System.Drawing.Color.Black
        Me.btnDBProgram.Radius = 5
        Me.btnDBProgram.Size = New System.Drawing.Size(160, 102)
        Me.btnDBProgram.TabIndex = 6
        Me.btnDBProgram.Text = "Programs"
        Me.btnDBProgram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDBGrade
        '
        Me.btnDBGrade.AnimationHoverSpeed = 0.07!
        Me.btnDBGrade.AnimationSpeed = 0.03!
        Me.btnDBGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnDBGrade.BaseColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDBGrade.BorderColor = System.Drawing.Color.Black
        Me.btnDBGrade.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDBGrade.FocusedColor = System.Drawing.Color.Empty
        Me.btnDBGrade.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBGrade.ForeColor = System.Drawing.Color.White
        Me.btnDBGrade.Image = CType(resources.GetObject("btnDBGrade.Image"), System.Drawing.Image)
        Me.btnDBGrade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDBGrade.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDBGrade.Location = New System.Drawing.Point(813, 103)
        Me.btnDBGrade.Name = "btnDBGrade"
        Me.btnDBGrade.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDBGrade.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDBGrade.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDBGrade.OnHoverImage = Nothing
        Me.btnDBGrade.OnPressedColor = System.Drawing.Color.Black
        Me.btnDBGrade.Radius = 5
        Me.btnDBGrade.Size = New System.Drawing.Size(160, 102)
        Me.btnDBGrade.TabIndex = 7
        Me.btnDBGrade.Text = "Grades"
        Me.btnDBGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(315, 72)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(130, 15)
        Me.GunaLabel4.TabIndex = 15
        Me.GunaLabel4.Text = "you're logged in as :"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUserRole.Location = New System.Drawing.Point(442, 72)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(64, 15)
        Me.lblUserRole.TabIndex = 14
        Me.lblUserRole.Text = "User Role"
        '
        'btnDBCourse
        '
        Me.btnDBCourse.AnimationHoverSpeed = 0.07!
        Me.btnDBCourse.AnimationSpeed = 0.03!
        Me.btnDBCourse.BackColor = System.Drawing.Color.Transparent
        Me.btnDBCourse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDBCourse.BorderColor = System.Drawing.Color.Black
        Me.btnDBCourse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDBCourse.FocusedColor = System.Drawing.Color.Empty
        Me.btnDBCourse.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBCourse.ForeColor = System.Drawing.Color.White
        Me.btnDBCourse.Image = CType(resources.GetObject("btnDBCourse.Image"), System.Drawing.Image)
        Me.btnDBCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDBCourse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDBCourse.Location = New System.Drawing.Point(611, 103)
        Me.btnDBCourse.Name = "btnDBCourse"
        Me.btnDBCourse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDBCourse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDBCourse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDBCourse.OnHoverImage = Nothing
        Me.btnDBCourse.OnPressedColor = System.Drawing.Color.Black
        Me.btnDBCourse.Radius = 5
        Me.btnDBCourse.Size = New System.Drawing.Size(160, 102)
        Me.btnDBCourse.TabIndex = 5
        Me.btnDBCourse.Text = "Courses"
        Me.btnDBCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlPerformanceAnalysis
        '
        Me.pnlPerformanceAnalysis.BackColor = System.Drawing.Color.Transparent
        Me.pnlPerformanceAnalysis.BaseColor = System.Drawing.Color.White
        Me.pnlPerformanceAnalysis.Location = New System.Drawing.Point(199, 274)
        Me.pnlPerformanceAnalysis.Name = "pnlPerformanceAnalysis"
        Me.pnlPerformanceAnalysis.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlPerformanceAnalysis.Radius = 3
        Me.pnlPerformanceAnalysis.ShadowColor = System.Drawing.Color.Black
        Me.pnlPerformanceAnalysis.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.pnlPerformanceAnalysis.Size = New System.Drawing.Size(774, 269)
        Me.pnlPerformanceAnalysis.TabIndex = 13
        '
        'btnDBStudent
        '
        Me.btnDBStudent.AnimationHoverSpeed = 0.07!
        Me.btnDBStudent.AnimationSpeed = 0.03!
        Me.btnDBStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnDBStudent.BaseColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnDBStudent.BorderColor = System.Drawing.Color.Black
        Me.btnDBStudent.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDBStudent.FocusedColor = System.Drawing.Color.Empty
        Me.btnDBStudent.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBStudent.ForeColor = System.Drawing.Color.White
        Me.btnDBStudent.Image = CType(resources.GetObject("btnDBStudent.Image"), System.Drawing.Image)
        Me.btnDBStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDBStudent.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDBStudent.Location = New System.Drawing.Point(199, 103)
        Me.btnDBStudent.Name = "btnDBStudent"
        Me.btnDBStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDBStudent.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDBStudent.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDBStudent.OnHoverImage = Nothing
        Me.btnDBStudent.OnPressedColor = System.Drawing.Color.Black
        Me.btnDBStudent.Radius = 5
        Me.btnDBStudent.Size = New System.Drawing.Size(160, 102)
        Me.btnDBStudent.TabIndex = 4
        Me.btnDBStudent.Text = "Students"
        Me.btnDBStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnDBGrade As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDBProgram As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDBCourse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDBStudent As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGrade As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCourse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStudent As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents pnlPerformanceAnalysis As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnModifyStudentGrade As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbUserAccount As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblUserFullName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUserRole As Guna.UI.WinForms.GunaLabel
    Friend WithEvents UserPictureBox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnProgram As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnViewAllStudentGrade As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAcademicYear As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnViewGradebook As Guna.UI.WinForms.GunaButton
End Class
