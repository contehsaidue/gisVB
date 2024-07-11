<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeModify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradeModify))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.btnExportToPDF = New Guna.UI.WinForms.GunaButton()
        Me.btnExportGradeExcel = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.dgvViewStudentGradeData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CourseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.cmbSelectProgramLevel = New Guna.UI.WinForms.GunaComboBox()
        Me.btnFilterSearchD = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectProgram = New Guna.UI.WinForms.GunaComboBox()
        Me.btnResetD = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectYear = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbSemester = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvViewStudentGradeData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnExportToPDF
        '
        Me.btnExportToPDF.AnimationHoverSpeed = 0.07!
        Me.btnExportToPDF.AnimationSpeed = 0.03!
        Me.btnExportToPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnExportToPDF.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportToPDF.BorderColor = System.Drawing.Color.Black
        Me.btnExportToPDF.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExportToPDF.FocusedColor = System.Drawing.Color.Empty
        Me.btnExportToPDF.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportToPDF.Image = CType(resources.GetObject("btnExportToPDF.Image"), System.Drawing.Image)
        Me.btnExportToPDF.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExportToPDF.Location = New System.Drawing.Point(283, 401)
        Me.btnExportToPDF.Name = "btnExportToPDF"
        Me.btnExportToPDF.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExportToPDF.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExportToPDF.OnHoverForeColor = System.Drawing.Color.White
        Me.btnExportToPDF.OnHoverImage = Nothing
        Me.btnExportToPDF.OnPressedColor = System.Drawing.Color.Black
        Me.btnExportToPDF.Radius = 3
        Me.btnExportToPDF.Size = New System.Drawing.Size(201, 36)
        Me.btnExportToPDF.TabIndex = 36
        Me.btnExportToPDF.Text = "Export PDF Grade"
        '
        'btnExportGradeExcel
        '
        Me.btnExportGradeExcel.AnimationHoverSpeed = 0.07!
        Me.btnExportGradeExcel.AnimationSpeed = 0.03!
        Me.btnExportGradeExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportGradeExcel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportGradeExcel.BorderColor = System.Drawing.Color.Black
        Me.btnExportGradeExcel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExportGradeExcel.FocusedColor = System.Drawing.Color.Empty
        Me.btnExportGradeExcel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportGradeExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportGradeExcel.Image = CType(resources.GetObject("btnExportGradeExcel.Image"), System.Drawing.Image)
        Me.btnExportGradeExcel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExportGradeExcel.Location = New System.Drawing.Point(54, 401)
        Me.btnExportGradeExcel.Name = "btnExportGradeExcel"
        Me.btnExportGradeExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExportGradeExcel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExportGradeExcel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnExportGradeExcel.OnHoverImage = Nothing
        Me.btnExportGradeExcel.OnPressedColor = System.Drawing.Color.Black
        Me.btnExportGradeExcel.Radius = 3
        Me.btnExportGradeExcel.Size = New System.Drawing.Size(210, 36)
        Me.btnExportGradeExcel.TabIndex = 35
        Me.btnExportGradeExcel.Text = "Export Excel Grade"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaButton12)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(978, 63)
        Me.Panel1.TabIndex = 31
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
        Me.GunaLabel1.Size = New System.Drawing.Size(192, 21)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "Modify Student Grades"
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(892, 12)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(930, 13)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 0
        '
        'dgvViewStudentGradeData
        '
        Me.dgvViewStudentGradeData.AllowUserToAddRows = False
        Me.dgvViewStudentGradeData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvViewStudentGradeData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewStudentGradeData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewStudentGradeData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvViewStudentGradeData.ColumnHeadersHeight = 45
        Me.dgvViewStudentGradeData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseID, Me.GradeID, Me.No, Me.FirstName, Me.LastName, Me.StudentID, Me.CourseName, Me.Grade, Me.Semester, Me.Edit, Me.Delete, Me.Year, Me.ProgramLevel, Me.ProgramName})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewStudentGradeData.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvViewStudentGradeData.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvViewStudentGradeData.Location = New System.Drawing.Point(54, 109)
        Me.dgvViewStudentGradeData.Name = "dgvViewStudentGradeData"
        Me.dgvViewStudentGradeData.ReadOnly = True
        Me.dgvViewStudentGradeData.RowHeadersVisible = False
        Me.dgvViewStudentGradeData.RowTemplate.Height = 40
        Me.dgvViewStudentGradeData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewStudentGradeData.Size = New System.Drawing.Size(883, 278)
        Me.dgvViewStudentGradeData.TabIndex = 33
        Me.dgvViewStudentGradeData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.dgvViewStudentGradeData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvViewStudentGradeData.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewStudentGradeData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvViewStudentGradeData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvViewStudentGradeData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvViewStudentGradeData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvViewStudentGradeData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvViewStudentGradeData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvViewStudentGradeData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvViewStudentGradeData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewStudentGradeData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvViewStudentGradeData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvViewStudentGradeData.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvViewStudentGradeData.ThemeStyle.ReadOnly = True
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.Height = 40
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvViewStudentGradeData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'CourseID
        '
        Me.CourseID.DataPropertyName = "CourseID"
        Me.CourseID.HeaderText = "CourseID"
        Me.CourseID.Name = "CourseID"
        Me.CourseID.ReadOnly = True
        Me.CourseID.Visible = False
        '
        'GradeID
        '
        Me.GradeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GradeID.DataPropertyName = "GradeID"
        Me.GradeID.HeaderText = "GradeID"
        Me.GradeID.Name = "GradeID"
        Me.GradeID.ReadOnly = True
        Me.GradeID.Visible = False
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'StudentID
        '
        Me.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StudentID.DataPropertyName = "StudentID"
        Me.StudentID.HeaderText = "Student ID.NO"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        '
        'CourseName
        '
        Me.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CourseName.DataPropertyName = "CourseName"
        Me.CourseName.HeaderText = "Course Name"
        Me.CourseName.Name = "CourseName"
        Me.CourseName.ReadOnly = True
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
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle3
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle4
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'Year
        '
        Me.Year.DataPropertyName = "Year"
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        Me.Year.ReadOnly = True
        Me.Year.Visible = False
        '
        'ProgramLevel
        '
        Me.ProgramLevel.DataPropertyName = "ProgramLevel"
        Me.ProgramLevel.HeaderText = "ProgramLevel"
        Me.ProgramLevel.Name = "ProgramLevel"
        Me.ProgramLevel.ReadOnly = True
        Me.ProgramLevel.Visible = False
        '
        'ProgramName
        '
        Me.ProgramName.DataPropertyName = "ProgramName"
        Me.ProgramName.HeaderText = "ProgramName"
        Me.ProgramName.Name = "ProgramName"
        Me.ProgramName.ReadOnly = True
        Me.ProgramName.Visible = False
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'cmbSelectProgramLevel
        '
        Me.cmbSelectProgramLevel.BackColor = System.Drawing.Color.Transparent
        Me.cmbSelectProgramLevel.BaseColor = System.Drawing.Color.White
        Me.cmbSelectProgramLevel.BorderColor = System.Drawing.Color.Silver
        Me.cmbSelectProgramLevel.BorderSize = 1
        Me.cmbSelectProgramLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSelectProgramLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectProgramLevel.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSelectProgramLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSelectProgramLevel.ForeColor = System.Drawing.Color.Black
        Me.cmbSelectProgramLevel.FormattingEnabled = True
        Me.cmbSelectProgramLevel.Items.AddRange(New Object() {"Select Program Level", "BSc", "HD"})
        Me.cmbSelectProgramLevel.Location = New System.Drawing.Point(54, 77)
        Me.cmbSelectProgramLevel.Name = "cmbSelectProgramLevel"
        Me.cmbSelectProgramLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgramLevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgramLevel.Radius = 3
        Me.cmbSelectProgramLevel.Size = New System.Drawing.Size(157, 26)
        Me.cmbSelectProgramLevel.TabIndex = 41
        '
        'btnFilterSearchD
        '
        Me.btnFilterSearchD.AnimationHoverSpeed = 0.07!
        Me.btnFilterSearchD.AnimationSpeed = 0.03!
        Me.btnFilterSearchD.BackColor = System.Drawing.Color.Transparent
        Me.btnFilterSearchD.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchD.BorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchD.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFilterSearchD.FocusedColor = System.Drawing.Color.Empty
        Me.btnFilterSearchD.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterSearchD.ForeColor = System.Drawing.Color.White
        Me.btnFilterSearchD.Image = CType(resources.GetObject("btnFilterSearchD.Image"), System.Drawing.Image)
        Me.btnFilterSearchD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFilterSearchD.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFilterSearchD.Location = New System.Drawing.Point(762, 77)
        Me.btnFilterSearchD.Name = "btnFilterSearchD"
        Me.btnFilterSearchD.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchD.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchD.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFilterSearchD.OnHoverImage = Nothing
        Me.btnFilterSearchD.OnPressedColor = System.Drawing.Color.Black
        Me.btnFilterSearchD.Radius = 3
        Me.btnFilterSearchD.Size = New System.Drawing.Size(82, 26)
        Me.btnFilterSearchD.TabIndex = 40
        Me.btnFilterSearchD.Text = "Filter"
        Me.btnFilterSearchD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbSelectProgram
        '
        Me.cmbSelectProgram.BackColor = System.Drawing.Color.Transparent
        Me.cmbSelectProgram.BaseColor = System.Drawing.Color.White
        Me.cmbSelectProgram.BorderColor = System.Drawing.Color.Silver
        Me.cmbSelectProgram.BorderSize = 1
        Me.cmbSelectProgram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSelectProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectProgram.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSelectProgram.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSelectProgram.ForeColor = System.Drawing.Color.Black
        Me.cmbSelectProgram.FormattingEnabled = True
        Me.cmbSelectProgram.Items.AddRange(New Object() {"Select Progam ", "Computer Science", "Business and Information Technology", "Electronics and Telecommunication"})
        Me.cmbSelectProgram.Location = New System.Drawing.Point(217, 77)
        Me.cmbSelectProgram.Name = "cmbSelectProgram"
        Me.cmbSelectProgram.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgram.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgram.Radius = 3
        Me.cmbSelectProgram.Size = New System.Drawing.Size(267, 26)
        Me.cmbSelectProgram.TabIndex = 39
        '
        'btnResetD
        '
        Me.btnResetD.AnimationHoverSpeed = 0.07!
        Me.btnResetD.AnimationSpeed = 0.03!
        Me.btnResetD.BackColor = System.Drawing.Color.Transparent
        Me.btnResetD.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetD.BorderColor = System.Drawing.Color.Black
        Me.btnResetD.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnResetD.FocusedColor = System.Drawing.Color.Empty
        Me.btnResetD.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetD.ForeColor = System.Drawing.Color.White
        Me.btnResetD.Image = CType(resources.GetObject("btnResetD.Image"), System.Drawing.Image)
        Me.btnResetD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnResetD.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnResetD.Location = New System.Drawing.Point(849, 77)
        Me.btnResetD.Name = "btnResetD"
        Me.btnResetD.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetD.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnResetD.OnHoverForeColor = System.Drawing.Color.White
        Me.btnResetD.OnHoverImage = Nothing
        Me.btnResetD.OnPressedColor = System.Drawing.Color.Black
        Me.btnResetD.Radius = 3
        Me.btnResetD.Size = New System.Drawing.Size(82, 26)
        Me.btnResetD.TabIndex = 37
        Me.btnResetD.Text = "Reset"
        Me.btnResetD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmbSelectYear.Location = New System.Drawing.Point(489, 77)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectYear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectYear.Radius = 3
        Me.cmbSelectYear.Size = New System.Drawing.Size(132, 26)
        Me.cmbSelectYear.TabIndex = 38
        '
        'cmbSemester
        '
        Me.cmbSemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbSemester.BaseColor = System.Drawing.Color.White
        Me.cmbSemester.BorderColor = System.Drawing.Color.Silver
        Me.cmbSemester.BorderSize = 1
        Me.cmbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSemester.ForeColor = System.Drawing.Color.Black
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"Semester", "First", "Second"})
        Me.cmbSemester.Location = New System.Drawing.Point(627, 77)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSemester.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSemester.Radius = 3
        Me.cmbSemester.Size = New System.Drawing.Size(132, 26)
        Me.cmbSemester.TabIndex = 42
        '
        'frmGradeModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 463)
        Me.Controls.Add(Me.cmbSemester)
        Me.Controls.Add(Me.cmbSelectProgramLevel)
        Me.Controls.Add(Me.btnFilterSearchD)
        Me.Controls.Add(Me.cmbSelectProgram)
        Me.Controls.Add(Me.btnResetD)
        Me.Controls.Add(Me.cmbSelectYear)
        Me.Controls.Add(Me.btnExportToPDF)
        Me.Controls.Add(Me.btnExportGradeExcel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvViewStudentGradeData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGradeModify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmViewGrade"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvViewStudentGradeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnExportToPDF As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnExportGradeExcel As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents dgvViewStudentGradeData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents cmbSelectProgramLevel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnFilterSearchD As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectProgram As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnResetD As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectYear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbSemester As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents CourseID As DataGridViewTextBoxColumn
    Friend WithEvents GradeID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents StudentID As DataGridViewTextBoxColumn
    Friend WithEvents CourseName As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents ProgramLevel As DataGridViewTextBoxColumn
    Friend WithEvents ProgramName As DataGridViewTextBoxColumn
End Class
