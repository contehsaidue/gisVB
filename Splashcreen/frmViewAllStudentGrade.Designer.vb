<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewAllStudentGrade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAllStudentGrade))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectProgramLevel = New Guna.UI.WinForms.GunaComboBox()
        Me.btnFilterSearchE = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectProgram = New Guna.UI.WinForms.GunaComboBox()
        Me.btnResetE = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectYear = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.dgvViewAllGrades = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgramName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewGrades = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvViewAllGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.cmbSelectProgramLevel.Location = New System.Drawing.Point(54, 71)
        Me.cmbSelectProgramLevel.Name = "cmbSelectProgramLevel"
        Me.cmbSelectProgramLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgramLevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgramLevel.Radius = 3
        Me.cmbSelectProgramLevel.Size = New System.Drawing.Size(157, 26)
        Me.cmbSelectProgramLevel.TabIndex = 51
        '
        'btnFilterSearchE
        '
        Me.btnFilterSearchE.AnimationHoverSpeed = 0.07!
        Me.btnFilterSearchE.AnimationSpeed = 0.03!
        Me.btnFilterSearchE.BackColor = System.Drawing.Color.Transparent
        Me.btnFilterSearchE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchE.BorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFilterSearchE.FocusedColor = System.Drawing.Color.Empty
        Me.btnFilterSearchE.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterSearchE.ForeColor = System.Drawing.Color.White
        Me.btnFilterSearchE.Image = CType(resources.GetObject("btnFilterSearchE.Image"), System.Drawing.Image)
        Me.btnFilterSearchE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFilterSearchE.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFilterSearchE.Location = New System.Drawing.Point(632, 71)
        Me.btnFilterSearchE.Name = "btnFilterSearchE"
        Me.btnFilterSearchE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearchE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFilterSearchE.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFilterSearchE.OnHoverImage = Nothing
        Me.btnFilterSearchE.OnPressedColor = System.Drawing.Color.Black
        Me.btnFilterSearchE.Radius = 3
        Me.btnFilterSearchE.Size = New System.Drawing.Size(82, 26)
        Me.btnFilterSearchE.TabIndex = 50
        Me.btnFilterSearchE.Text = "Filter"
        Me.btnFilterSearchE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmbSelectProgram.Location = New System.Drawing.Point(217, 71)
        Me.cmbSelectProgram.Name = "cmbSelectProgram"
        Me.cmbSelectProgram.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgram.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgram.Radius = 3
        Me.cmbSelectProgram.Size = New System.Drawing.Size(267, 26)
        Me.cmbSelectProgram.TabIndex = 49
        '
        'btnResetE
        '
        Me.btnResetE.AnimationHoverSpeed = 0.07!
        Me.btnResetE.AnimationSpeed = 0.03!
        Me.btnResetE.BackColor = System.Drawing.Color.Transparent
        Me.btnResetE.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetE.BorderColor = System.Drawing.Color.Black
        Me.btnResetE.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnResetE.FocusedColor = System.Drawing.Color.Empty
        Me.btnResetE.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetE.ForeColor = System.Drawing.Color.White
        Me.btnResetE.Image = CType(resources.GetObject("btnResetE.Image"), System.Drawing.Image)
        Me.btnResetE.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnResetE.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnResetE.Location = New System.Drawing.Point(719, 71)
        Me.btnResetE.Name = "btnResetE"
        Me.btnResetE.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResetE.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnResetE.OnHoverForeColor = System.Drawing.Color.White
        Me.btnResetE.OnHoverImage = Nothing
        Me.btnResetE.OnPressedColor = System.Drawing.Color.Black
        Me.btnResetE.Radius = 3
        Me.btnResetE.Size = New System.Drawing.Size(82, 26)
        Me.btnResetE.TabIndex = 47
        Me.btnResetE.Text = "Reset"
        Me.btnResetE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmbSelectYear.Location = New System.Drawing.Point(489, 71)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectYear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectYear.Radius = 3
        Me.cmbSelectYear.Size = New System.Drawing.Size(132, 26)
        Me.cmbSelectYear.TabIndex = 48
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'dgvViewAllGrades
        '
        Me.dgvViewAllGrades.AllowUserToAddRows = False
        Me.dgvViewAllGrades.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvViewAllGrades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewAllGrades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewAllGrades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvViewAllGrades.ColumnHeadersHeight = 45
        Me.dgvViewAllGrades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.FirstName, Me.LastName, Me.StudentID, Me.ProgramLevel, Me.ProgramName, Me.Year, Me.btnViewGrades})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewAllGrades.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvViewAllGrades.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvViewAllGrades.Location = New System.Drawing.Point(54, 103)
        Me.dgvViewAllGrades.Name = "dgvViewAllGrades"
        Me.dgvViewAllGrades.ReadOnly = True
        Me.dgvViewAllGrades.RowHeadersVisible = False
        Me.dgvViewAllGrades.RowTemplate.Height = 40
        Me.dgvViewAllGrades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvViewAllGrades.Size = New System.Drawing.Size(883, 278)
        Me.dgvViewAllGrades.TabIndex = 44
        Me.dgvViewAllGrades.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.dgvViewAllGrades.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvViewAllGrades.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewAllGrades.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvViewAllGrades.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvViewAllGrades.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvViewAllGrades.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvViewAllGrades.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvViewAllGrades.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvViewAllGrades.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvViewAllGrades.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewAllGrades.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvViewAllGrades.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvViewAllGrades.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvViewAllGrades.ThemeStyle.ReadOnly = True
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.Height = 40
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvViewAllGrades.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.StudentID.HeaderText = "Student ID"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
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
        'btnViewGrades
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        Me.btnViewGrades.DefaultCellStyle = DataGridViewCellStyle3
        Me.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewGrades.HeaderText = ""
        Me.btnViewGrades.Name = "btnViewGrades"
        Me.btnViewGrades.ReadOnly = True
        Me.btnViewGrades.Text = "View Grades"
        Me.btnViewGrades.UseColumnTextForButtonValue = True
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
        Me.GunaLabel1.Size = New System.Drawing.Size(275, 21)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "View all Student Grades Summary"
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
        Me.Panel1.TabIndex = 43
        '
        'frmViewAllStudentGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 463)
        Me.Controls.Add(Me.cmbSelectProgramLevel)
        Me.Controls.Add(Me.btnFilterSearchE)
        Me.Controls.Add(Me.cmbSelectProgram)
        Me.Controls.Add(Me.btnResetE)
        Me.Controls.Add(Me.cmbSelectYear)
        Me.Controls.Add(Me.dgvViewAllGrades)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmViewAllStudentGrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentGradeSummary"
        CType(Me.dgvViewAllGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectProgramLevel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnFilterSearchE As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectProgram As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnResetE As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectYear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents dgvViewAllGrades As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents StudentID As DataGridViewTextBoxColumn
    Friend WithEvents ProgramLevel As DataGridViewTextBoxColumn
    Friend WithEvents ProgramName As DataGridViewTextBoxColumn
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents btnViewGrades As DataGridViewButtonColumn
End Class
