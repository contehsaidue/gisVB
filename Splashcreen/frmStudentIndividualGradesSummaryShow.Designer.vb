<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentIndividualGradesSummaryShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentIndividualGradesSummaryShow))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdateGrade = New Guna.UI.WinForms.GunaButton()
        Me.btnSaveGrade = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.lblProgram = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.dgvViewStudentSingleGradeData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSGPA = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.TCH = New Guna.UI.WinForms.GunaLabel()
        Me.lblTotalCreditHour = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.lblCommentValue = New Guna.UI.WinForms.GunaLabel()
        Me.btnFilterSearchF = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectYear = New Guna.UI.WinForms.GunaComboBox()
        Me.btnResetF = New Guna.UI.WinForms.GunaButton()
        Me.lblStudentID = New Guna.UI.WinForms.GunaLabel()
        Me.grpbGradeData = New Guna.UI.WinForms.GunaGroupBox()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvViewStudentSingleGradeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbGradeData.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnBack.Location = New System.Drawing.Point(23, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBack.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBack.OnHoverImage = Nothing
        Me.btnBack.OnPressedColor = System.Drawing.Color.Black
        Me.btnBack.Size = New System.Drawing.Size(51, 33)
        Me.btnBack.TabIndex = 14
        '
        'btnUpdateGrade
        '
        Me.btnUpdateGrade.AnimationHoverSpeed = 0.07!
        Me.btnUpdateGrade.AnimationSpeed = 0.03!
        Me.btnUpdateGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateGrade.BaseColor = System.Drawing.Color.Maroon
        Me.btnUpdateGrade.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateGrade.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateGrade.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateGrade.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateGrade.ForeColor = System.Drawing.Color.White
        Me.btnUpdateGrade.Image = CType(resources.GetObject("btnUpdateGrade.Image"), System.Drawing.Image)
        Me.btnUpdateGrade.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdateGrade.Location = New System.Drawing.Point(136, 37)
        Me.btnUpdateGrade.Name = "btnUpdateGrade"
        Me.btnUpdateGrade.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateGrade.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdateGrade.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateGrade.OnHoverImage = Nothing
        Me.btnUpdateGrade.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdateGrade.Radius = 3
        Me.btnUpdateGrade.Size = New System.Drawing.Size(106, 36)
        Me.btnUpdateGrade.TabIndex = 56
        Me.btnUpdateGrade.Text = "Update"
        '
        'btnSaveGrade
        '
        Me.btnSaveGrade.AnimationHoverSpeed = 0.07!
        Me.btnSaveGrade.AnimationSpeed = 0.03!
        Me.btnSaveGrade.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveGrade.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveGrade.BorderColor = System.Drawing.Color.Black
        Me.btnSaveGrade.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSaveGrade.FocusedColor = System.Drawing.Color.Empty
        Me.btnSaveGrade.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveGrade.ForeColor = System.Drawing.Color.White
        Me.btnSaveGrade.Image = CType(resources.GetObject("btnSaveGrade.Image"), System.Drawing.Image)
        Me.btnSaveGrade.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSaveGrade.Location = New System.Drawing.Point(13, 37)
        Me.btnSaveGrade.Name = "btnSaveGrade"
        Me.btnSaveGrade.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSaveGrade.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSaveGrade.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaveGrade.OnHoverImage = Nothing
        Me.btnSaveGrade.OnPressedColor = System.Drawing.Color.Black
        Me.btnSaveGrade.Radius = 3
        Me.btnSaveGrade.Size = New System.Drawing.Size(115, 36)
        Me.btnSaveGrade.TabIndex = 55
        Me.btnSaveGrade.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.GunaButton12)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.lblProgram)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 63)
        Me.Panel1.TabIndex = 53
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(387, 19)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(36, 27)
        Me.GunaLabel3.TabIndex = 69
        Me.GunaLabel3.Text = "for"
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
        Me.GunaButton12.Location = New System.Drawing.Point(80, 12)
        Me.GunaButton12.Name = "GunaButton12"
        Me.GunaButton12.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaButton12.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton12.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton12.OnHoverImage = Nothing
        Me.GunaButton12.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton12.Radius = 3
        Me.GunaButton12.Size = New System.Drawing.Size(37, 38)
        Me.GunaButton12.TabIndex = 12
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLabel2.Location = New System.Drawing.Point(121, 20)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(46, 21)
        Me.GunaLabel2.TabIndex = 11
        Me.GunaLabel2.Text = "GIS :"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLabel1.Location = New System.Drawing.Point(164, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(213, 21)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "Student Grades Summary "
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(882, 12)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(920, 13)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 0
        '
        'lblProgram
        '
        Me.lblProgram.AutoSize = True
        Me.lblProgram.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.ForeColor = System.Drawing.Color.White
        Me.lblProgram.Location = New System.Drawing.Point(431, 21)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(78, 21)
        Me.lblProgram.TabIndex = 64
        Me.lblProgram.Text = "Program"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'dgvViewStudentSingleGradeData
        '
        Me.dgvViewStudentSingleGradeData.AllowUserToAddRows = False
        Me.dgvViewStudentSingleGradeData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvViewStudentSingleGradeData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewStudentSingleGradeData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewStudentSingleGradeData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvViewStudentSingleGradeData.ColumnHeadersHeight = 45
        Me.dgvViewStudentSingleGradeData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.CourseName, Me.CreditHour, Me.Grade, Me.Semester, Me.GradeWeight, Me.GradeID})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewStudentSingleGradeData.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvViewStudentSingleGradeData.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvViewStudentSingleGradeData.Location = New System.Drawing.Point(52, 104)
        Me.dgvViewStudentSingleGradeData.Name = "dgvViewStudentSingleGradeData"
        Me.dgvViewStudentSingleGradeData.ReadOnly = True
        Me.dgvViewStudentSingleGradeData.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        Me.dgvViewStudentSingleGradeData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvViewStudentSingleGradeData.RowTemplate.Height = 40
        Me.dgvViewStudentSingleGradeData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewStudentSingleGradeData.Size = New System.Drawing.Size(883, 256)
        Me.dgvViewStudentSingleGradeData.TabIndex = 57
        Me.dgvViewStudentSingleGradeData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.dgvViewStudentSingleGradeData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvViewStudentSingleGradeData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvViewStudentSingleGradeData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvViewStudentSingleGradeData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvViewStudentSingleGradeData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvViewStudentSingleGradeData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvViewStudentSingleGradeData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvViewStudentSingleGradeData.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvViewStudentSingleGradeData.ThemeStyle.ReadOnly = True
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.Height = 40
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvViewStudentSingleGradeData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'CourseName
        '
        Me.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CourseName.DataPropertyName = "CourseName"
        Me.CourseName.HeaderText = "Course Name"
        Me.CourseName.Name = "CourseName"
        Me.CourseName.ReadOnly = True
        '
        'CreditHour
        '
        Me.CreditHour.DataPropertyName = "CreditHour"
        Me.CreditHour.HeaderText = "Credit Hour"
        Me.CreditHour.Name = "CreditHour"
        Me.CreditHour.ReadOnly = True
        Me.CreditHour.Visible = False
        '
        'Grade
        '
        Me.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Grade.DataPropertyName = "Grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        '
        'GradeWeight
        '
        Me.GradeWeight.HeaderText = "Grade Weight"
        Me.GradeWeight.Name = "GradeWeight"
        Me.GradeWeight.ReadOnly = True
        '
        'GradeID
        '
        Me.GradeID.DataPropertyName = "GradeID"
        Me.GradeID.HeaderText = "GradeID"
        Me.GradeID.Name = "GradeID"
        Me.GradeID.ReadOnly = True
        Me.GradeID.Visible = False
        '
        'lblSGPA
        '
        Me.lblSGPA.AutoSize = True
        Me.lblSGPA.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSGPA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSGPA.Location = New System.Drawing.Point(282, 40)
        Me.lblSGPA.Name = "lblSGPA"
        Me.lblSGPA.Size = New System.Drawing.Size(24, 27)
        Me.lblSGPA.TabIndex = 65
        Me.lblSGPA.Text = "V"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(224, 42)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(58, 21)
        Me.GunaLabel4.TabIndex = 66
        Me.GunaLabel4.Text = "SGPA:"
        '
        'TCH
        '
        Me.TCH.AutoSize = True
        Me.TCH.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TCH.Location = New System.Drawing.Point(17, 42)
        Me.TCH.Name = "TCH"
        Me.TCH.Size = New System.Drawing.Size(160, 21)
        Me.TCH.TabIndex = 68
        Me.TCH.Text = "Total Credit Hours:"
        '
        'lblTotalCreditHour
        '
        Me.lblTotalCreditHour.AutoSize = True
        Me.lblTotalCreditHour.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCreditHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalCreditHour.Location = New System.Drawing.Point(177, 40)
        Me.lblTotalCreditHour.Name = "lblTotalCreditHour"
        Me.lblTotalCreditHour.Size = New System.Drawing.Size(24, 27)
        Me.lblTotalCreditHour.TabIndex = 67
        Me.lblTotalCreditHour.Text = "V"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel5.Location = New System.Drawing.Point(335, 43)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(91, 21)
        Me.GunaLabel5.TabIndex = 70
        Me.GunaLabel5.Text = "Comment:"
        '
        'lblCommentValue
        '
        Me.lblCommentValue.AutoSize = True
        Me.lblCommentValue.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommentValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCommentValue.Location = New System.Drawing.Point(426, 40)
        Me.lblCommentValue.Name = "lblCommentValue"
        Me.lblCommentValue.Size = New System.Drawing.Size(24, 27)
        Me.lblCommentValue.TabIndex = 69
        Me.lblCommentValue.Text = "V"
        '
        'btnFilterSearchF
        '
        Me.btnFilterSearchF.AnimationHoverSpeed = 0.07!
        Me.btnFilterSearchF.AnimationSpeed = 0.03!
        Me.btnFilterSearchF.BackColor = System.Drawing.Color.Transparent
        Me.btnFilterSearchF.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchF.BorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchF.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFilterSearchF.FocusedColor = System.Drawing.Color.Empty
        Me.btnFilterSearchF.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterSearchF.ForeColor = System.Drawing.Color.White
        Me.btnFilterSearchF.Image = CType(resources.GetObject("btnFilterSearchF.Image"), System.Drawing.Image)
        Me.btnFilterSearchF.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFilterSearchF.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFilterSearchF.Location = New System.Drawing.Point(753, 69)
        Me.btnFilterSearchF.Name = "btnFilterSearchF"
        Me.btnFilterSearchF.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchF.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchF.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFilterSearchF.OnHoverImage = Nothing
        Me.btnFilterSearchF.OnPressedColor = System.Drawing.Color.Black
        Me.btnFilterSearchF.Radius = 3
        Me.btnFilterSearchF.Size = New System.Drawing.Size(82, 26)
        Me.btnFilterSearchF.TabIndex = 73
        Me.btnFilterSearchF.Text = "Filter"
        Me.btnFilterSearchF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSelectYear
        '
        Me.cmbSelectYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbSelectYear.BaseColor = System.Drawing.Color.White
        Me.cmbSelectYear.BorderColor = System.Drawing.Color.Silver
        Me.cmbSelectYear.BorderSize = 1
        Me.cmbSelectYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSelectYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectYear.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSelectYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSelectYear.ForeColor = System.Drawing.Color.Black
        Me.cmbSelectYear.FormattingEnabled = True
        Me.cmbSelectYear.Items.AddRange(New Object() {"Year", "1", "2", "3", "4"})
        Me.cmbSelectYear.Location = New System.Drawing.Point(629, 69)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectYear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectYear.Radius = 3
        Me.cmbSelectYear.Size = New System.Drawing.Size(112, 26)
        Me.cmbSelectYear.TabIndex = 72
        '
        'btnResetF
        '
        Me.btnResetF.AnimationHoverSpeed = 0.07!
        Me.btnResetF.AnimationSpeed = 0.03!
        Me.btnResetF.BackColor = System.Drawing.Color.Transparent
        Me.btnResetF.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetF.BorderColor = System.Drawing.Color.Black
        Me.btnResetF.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnResetF.FocusedColor = System.Drawing.Color.Empty
        Me.btnResetF.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetF.ForeColor = System.Drawing.Color.White
        Me.btnResetF.Image = CType(resources.GetObject("btnResetF.Image"), System.Drawing.Image)
        Me.btnResetF.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnResetF.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnResetF.Location = New System.Drawing.Point(849, 69)
        Me.btnResetF.Name = "btnResetF"
        Me.btnResetF.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetF.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnResetF.OnHoverForeColor = System.Drawing.Color.White
        Me.btnResetF.OnHoverImage = Nothing
        Me.btnResetF.OnPressedColor = System.Drawing.Color.Black
        Me.btnResetF.Radius = 3
        Me.btnResetF.Size = New System.Drawing.Size(82, 26)
        Me.btnResetF.TabIndex = 71
        Me.btnResetF.Text = "Reset"
        Me.btnResetF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.BackColor = System.Drawing.Color.Maroon
        Me.lblStudentID.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.White
        Me.lblStudentID.Location = New System.Drawing.Point(508, 0)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Padding = New System.Windows.Forms.Padding(2)
        Me.lblStudentID.Size = New System.Drawing.Size(116, 29)
        Me.lblStudentID.TabIndex = 66
        Me.lblStudentID.Text = "Student ID"
        Me.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpbGradeData
        '
        Me.grpbGradeData.BackColor = System.Drawing.Color.Transparent
        Me.grpbGradeData.BaseColor = System.Drawing.Color.White
        Me.grpbGradeData.BorderColor = System.Drawing.Color.Gainsboro
        Me.grpbGradeData.Controls.Add(Me.lblCommentValue)
        Me.grpbGradeData.Controls.Add(Me.lblStudentID)
        Me.grpbGradeData.Controls.Add(Me.lblSGPA)
        Me.grpbGradeData.Controls.Add(Me.GunaLabel4)
        Me.grpbGradeData.Controls.Add(Me.lblTotalCreditHour)
        Me.grpbGradeData.Controls.Add(Me.TCH)
        Me.grpbGradeData.Controls.Add(Me.GunaLabel5)
        Me.grpbGradeData.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbGradeData.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpbGradeData.Location = New System.Drawing.Point(54, 368)
        Me.grpbGradeData.Name = "grpbGradeData"
        Me.grpbGradeData.Size = New System.Drawing.Size(624, 83)
        Me.grpbGradeData.TabIndex = 75
        Me.grpbGradeData.Text = "Grade Data"
        Me.grpbGradeData.TextLocation = New System.Drawing.Point(10, 5)
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.btnUpdateGrade)
        Me.GunaGroupBox1.Controls.Add(Me.btnSaveGrade)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(684, 368)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(251, 83)
        Me.GunaGroupBox1.TabIndex = 76
        Me.GunaGroupBox1.Text = "Controls"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 5)
        '
        'frmStudentIndividualGradesSummaryShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 463)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.grpbGradeData)
        Me.Controls.Add(Me.btnFilterSearchF)
        Me.Controls.Add(Me.cmbSelectYear)
        Me.Controls.Add(Me.btnResetF)
        Me.Controls.Add(Me.dgvViewStudentSingleGradeData)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentIndividualGradesSummaryShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentIndividualGradesSummaryShow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvViewStudentSingleGradeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbGradeData.ResumeLayout(False)
        Me.grpbGradeData.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdateGrade As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSaveGrade As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents dgvViewStudentSingleGradeData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblProgram As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblSGPA As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TCH As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTotalCreditHour As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCommentValue As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnFilterSearchF As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectYear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnResetF As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblStudentID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grpbGradeData As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents CourseName As DataGridViewTextBoxColumn
    Friend WithEvents CreditHour As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents GradeWeight As DataGridViewTextBoxColumn
    Friend WithEvents GradeID As DataGridViewTextBoxColumn
End Class
