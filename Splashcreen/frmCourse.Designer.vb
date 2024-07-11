<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourse))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.dgvCourseData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CourseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.btnCreate = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectProgramLevel = New Guna.UI.WinForms.GunaComboBox()
        Me.btnFilterSearchB = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectProgram = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbSelectYear = New Guna.UI.WinForms.GunaComboBox()
        Me.btnResetB = New Guna.UI.WinForms.GunaButton()
        Me.cmbSemester = New Guna.UI.WinForms.GunaComboBox()
        CType(Me.dgvCourseData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.GunaLabel1.Size = New System.Drawing.Size(105, 21)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "Course Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'dgvCourseData
        '
        Me.dgvCourseData.AllowUserToAddRows = False
        Me.dgvCourseData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCourseData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCourseData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCourseData.ColumnHeadersHeight = 45
        Me.dgvCourseData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseID, Me.No, Me.CourseName, Me.CourseCode, Me.CreditHour, Me.ProgramLevel, Me.ProgramName, Me.Year, Me.Semester, Me.Edit, Me.Delete})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCourseData.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCourseData.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvCourseData.Location = New System.Drawing.Point(54, 120)
        Me.dgvCourseData.Name = "dgvCourseData"
        Me.dgvCourseData.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourseData.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCourseData.RowHeadersVisible = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvCourseData.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCourseData.RowTemplate.Height = 30
        Me.dgvCourseData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCourseData.Size = New System.Drawing.Size(883, 278)
        Me.dgvCourseData.TabIndex = 19
        Me.dgvCourseData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.dgvCourseData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvCourseData.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCourseData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCourseData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvCourseData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCourseData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvCourseData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvCourseData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvCourseData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCourseData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCourseData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCourseData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCourseData.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvCourseData.ThemeStyle.ReadOnly = True
        Me.dgvCourseData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgvCourseData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCourseData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCourseData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvCourseData.ThemeStyle.RowsStyle.Height = 30
        Me.dgvCourseData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvCourseData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'CourseID
        '
        Me.CourseID.DataPropertyName = "CourseID"
        Me.CourseID.HeaderText = "CourseID"
        Me.CourseID.Name = "CourseID"
        Me.CourseID.ReadOnly = True
        Me.CourseID.Visible = False
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'CourseName
        '
        Me.CourseName.DataPropertyName = "CourseName"
        Me.CourseName.HeaderText = "Course Name"
        Me.CourseName.Name = "CourseName"
        Me.CourseName.ReadOnly = True
        '
        'CourseCode
        '
        Me.CourseCode.DataPropertyName = "CourseCode"
        Me.CourseCode.HeaderText = "Course Code"
        Me.CourseCode.Name = "CourseCode"
        Me.CourseCode.ReadOnly = True
        '
        'CreditHour
        '
        Me.CreditHour.DataPropertyName = "CreditHour"
        Me.CreditHour.HeaderText = "Credit Hour"
        Me.CreditHour.Name = "CreditHour"
        Me.CreditHour.ReadOnly = True
        '
        'ProgramLevel
        '
        Me.ProgramLevel.DataPropertyName = "ProgramLevel"
        Me.ProgramLevel.HeaderText = "Program Level"
        Me.ProgramLevel.Name = "ProgramLevel"
        Me.ProgramLevel.ReadOnly = True
        '
        'ProgramName
        '
        Me.ProgramName.DataPropertyName = "ProgramName"
        Me.ProgramName.HeaderText = "Program"
        Me.ProgramName.Name = "ProgramName"
        Me.ProgramName.ReadOnly = True
        '
        'Year
        '
        Me.Year.DataPropertyName = "Year"
        Me.Year.HeaderText = "Year"
        Me.Year.Name = "Year"
        Me.Year.ReadOnly = True
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle3
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        '
        'Delete
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle4
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
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
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
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
        Me.Panel1.TabIndex = 14
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
        'btnCreate
        '
        Me.btnCreate.AnimationHoverSpeed = 0.07!
        Me.btnCreate.AnimationSpeed = 0.03!
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCreate.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreate.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCreate.Location = New System.Drawing.Point(54, 411)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCreate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCreate.OnHoverImage = Nothing
        Me.btnCreate.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreate.Radius = 3
        Me.btnCreate.Size = New System.Drawing.Size(157, 42)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create Course"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.Maroon
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.ImageOffsetX = 5
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(812, 425)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 3
        Me.GunaButton2.Size = New System.Drawing.Size(125, 26)
        Me.GunaButton2.TabIndex = 20
        Me.GunaButton2.Text = "Bulk Delete"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.TextOffsetX = 5
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
        Me.cmbSelectProgramLevel.Location = New System.Drawing.Point(54, 84)
        Me.cmbSelectProgramLevel.Name = "cmbSelectProgramLevel"
        Me.cmbSelectProgramLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgramLevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgramLevel.Radius = 3
        Me.cmbSelectProgramLevel.Size = New System.Drawing.Size(157, 26)
        Me.cmbSelectProgramLevel.TabIndex = 25
        '
        'btnFilterSearchB
        '
        Me.btnFilterSearchB.AnimationHoverSpeed = 0.07!
        Me.btnFilterSearchB.AnimationSpeed = 0.03!
        Me.btnFilterSearchB.BackColor = System.Drawing.Color.Transparent
        Me.btnFilterSearchB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchB.BorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchB.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFilterSearchB.FocusedColor = System.Drawing.Color.Empty
        Me.btnFilterSearchB.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterSearchB.ForeColor = System.Drawing.Color.White
        Me.btnFilterSearchB.Image = CType(resources.GetObject("btnFilterSearchB.Image"), System.Drawing.Image)
        Me.btnFilterSearchB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFilterSearchB.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFilterSearchB.Location = New System.Drawing.Point(756, 84)
        Me.btnFilterSearchB.Name = "btnFilterSearchB"
        Me.btnFilterSearchB.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchB.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchB.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFilterSearchB.OnHoverImage = Nothing
        Me.btnFilterSearchB.OnPressedColor = System.Drawing.Color.Black
        Me.btnFilterSearchB.Radius = 3
        Me.btnFilterSearchB.Size = New System.Drawing.Size(82, 26)
        Me.btnFilterSearchB.TabIndex = 24
        Me.btnFilterSearchB.Text = "Filter"
        Me.btnFilterSearchB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmbSelectProgram.Location = New System.Drawing.Point(217, 84)
        Me.cmbSelectProgram.Name = "cmbSelectProgram"
        Me.cmbSelectProgram.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgram.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgram.Radius = 3
        Me.cmbSelectProgram.Size = New System.Drawing.Size(284, 26)
        Me.cmbSelectProgram.TabIndex = 23
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
        Me.cmbSelectYear.Location = New System.Drawing.Point(516, 84)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectYear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectYear.Radius = 3
        Me.cmbSelectYear.Size = New System.Drawing.Size(99, 26)
        Me.cmbSelectYear.TabIndex = 22
        '
        'btnResetB
        '
        Me.btnResetB.AnimationHoverSpeed = 0.07!
        Me.btnResetB.AnimationSpeed = 0.03!
        Me.btnResetB.BackColor = System.Drawing.Color.Transparent
        Me.btnResetB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetB.BorderColor = System.Drawing.Color.Black
        Me.btnResetB.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnResetB.FocusedColor = System.Drawing.Color.Empty
        Me.btnResetB.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetB.ForeColor = System.Drawing.Color.White
        Me.btnResetB.Image = CType(resources.GetObject("btnResetB.Image"), System.Drawing.Image)
        Me.btnResetB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnResetB.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnResetB.Location = New System.Drawing.Point(852, 84)
        Me.btnResetB.Name = "btnResetB"
        Me.btnResetB.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetB.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnResetB.OnHoverForeColor = System.Drawing.Color.White
        Me.btnResetB.OnHoverImage = Nothing
        Me.btnResetB.OnPressedColor = System.Drawing.Color.Black
        Me.btnResetB.Radius = 3
        Me.btnResetB.Size = New System.Drawing.Size(82, 26)
        Me.btnResetB.TabIndex = 21
        Me.btnResetB.Text = "Reset"
        Me.btnResetB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmbSemester.Location = New System.Drawing.Point(626, 84)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSemester.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSemester.Radius = 3
        Me.cmbSemester.Size = New System.Drawing.Size(113, 26)
        Me.cmbSemester.TabIndex = 26
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 463)
        Me.Controls.Add(Me.cmbSemester)
        Me.Controls.Add(Me.cmbSelectProgramLevel)
        Me.Controls.Add(Me.btnFilterSearchB)
        Me.Controls.Add(Me.cmbSelectProgram)
        Me.Controls.Add(Me.cmbSelectYear)
        Me.Controls.Add(Me.btnResetB)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgvCourseData)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCourse"
        CType(Me.dgvCourseData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnCreate As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvCourseData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents CourseID As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents CourseName As DataGridViewTextBoxColumn
    Friend WithEvents CourseCode As DataGridViewTextBoxColumn
    Friend WithEvents CreditHour As DataGridViewTextBoxColumn
    Friend WithEvents ProgramLevel As DataGridViewTextBoxColumn
    Friend WithEvents ProgramName As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents cmbSelectProgramLevel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnFilterSearchB As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectProgram As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbSelectYear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnResetB As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSemester As Guna.UI.WinForms.GunaComboBox
End Class
