<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaButton12 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.btnImportFromExcel = New Guna.UI.WinForms.GunaButton()
        Me.btnCreate = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.dgvStudentData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.btnReset = New Guna.UI.WinForms.GunaButton()
        Me.btnFilterSearch = New Guna.UI.WinForms.GunaButton()
        Me.cmbSelectProgramLevel = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbSelectYear = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbSelectProgram = New Guna.UI.WinForms.GunaComboBox()
        Me.StudID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.joinYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.programName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStudentData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.Panel1.Size = New System.Drawing.Size(994, 55)
        Me.Panel1.TabIndex = 3
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
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLabel1.Location = New System.Drawing.Point(164, 20)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(113, 21)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "Student Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(908, 12)
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
        Me.GunaControlBox1.Location = New System.Drawing.Point(946, 13)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 0
        '
        'btnImportFromExcel
        '
        Me.btnImportFromExcel.AnimationHoverSpeed = 0.07!
        Me.btnImportFromExcel.AnimationSpeed = 0.03!
        Me.btnImportFromExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnImportFromExcel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnImportFromExcel.BorderColor = System.Drawing.Color.Black
        Me.btnImportFromExcel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImportFromExcel.FocusedColor = System.Drawing.Color.Empty
        Me.btnImportFromExcel.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportFromExcel.ForeColor = System.Drawing.Color.White
        Me.btnImportFromExcel.Image = CType(resources.GetObject("btnImportFromExcel.Image"), System.Drawing.Image)
        Me.btnImportFromExcel.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImportFromExcel.Location = New System.Drawing.Point(242, 449)
        Me.btnImportFromExcel.Name = "btnImportFromExcel"
        Me.btnImportFromExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImportFromExcel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnImportFromExcel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImportFromExcel.OnHoverImage = Nothing
        Me.btnImportFromExcel.OnPressedColor = System.Drawing.Color.Black
        Me.btnImportFromExcel.Radius = 3
        Me.btnImportFromExcel.Size = New System.Drawing.Size(143, 36)
        Me.btnImportFromExcel.TabIndex = 5
        Me.btnImportFromExcel.Text = "Import Data"
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
        Me.btnCreate.Location = New System.Drawing.Point(56, 449)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCreate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCreate.OnHoverImage = Nothing
        Me.btnCreate.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreate.Radius = 3
        Me.btnCreate.Size = New System.Drawing.Size(172, 36)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.Text = "Create Student"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'dgvStudentData
        '
        Me.dgvStudentData.AllowUserToAddRows = False
        Me.dgvStudentData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStudentData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudentData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStudentData.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudentData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudentData.ColumnHeadersHeight = 45
        Me.dgvStudentData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudID, Me.joinYear, Me.No, Me.FirstName, Me.MiddleName, Me.LastName, Me.StudentID, Me.programLevel, Me.programName, Me.year, Me.Edit, Me.Delete})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudentData.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvStudentData.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvStudentData.Location = New System.Drawing.Point(58, 115)
        Me.dgvStudentData.Name = "dgvStudentData"
        Me.dgvStudentData.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudentData.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvStudentData.RowHeadersVisible = False
        Me.dgvStudentData.RowTemplate.Height = 30
        Me.dgvStudentData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStudentData.Size = New System.Drawing.Size(883, 308)
        Me.dgvStudentData.TabIndex = 11
        Me.dgvStudentData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt
        Me.dgvStudentData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dgvStudentData.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStudentData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStudentData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Black
        Me.dgvStudentData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStudentData.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.dgvStudentData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.dgvStudentData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvStudentData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStudentData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStudentData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStudentData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudentData.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvStudentData.ThemeStyle.ReadOnly = True
        Me.dgvStudentData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dgvStudentData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudentData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStudentData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvStudentData.ThemeStyle.RowsStyle.Height = 30
        Me.dgvStudentData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvStudentData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.GunaButton2.Location = New System.Drawing.Point(816, 438)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 3
        Me.GunaButton2.Size = New System.Drawing.Size(125, 26)
        Me.GunaButton2.TabIndex = 12
        Me.GunaButton2.Text = "Bulk Delete"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.TextOffsetX = 5
        '
        'btnReset
        '
        Me.btnReset.AnimationHoverSpeed = 0.07!
        Me.btnReset.AnimationSpeed = 0.03!
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.BorderColor = System.Drawing.Color.Black
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReset.FocusedColor = System.Drawing.Color.Empty
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnReset.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnReset.Location = New System.Drawing.Point(859, 74)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReset.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReset.OnHoverImage = Nothing
        Me.btnReset.OnPressedColor = System.Drawing.Color.Black
        Me.btnReset.Radius = 3
        Me.btnReset.Size = New System.Drawing.Size(82, 26)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFilterSearch
        '
        Me.btnFilterSearch.AnimationHoverSpeed = 0.07!
        Me.btnFilterSearch.AnimationSpeed = 0.03!
        Me.btnFilterSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnFilterSearch.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearch.BorderColor = System.Drawing.Color.Black
        Me.btnFilterSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFilterSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnFilterSearch.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilterSearch.ForeColor = System.Drawing.Color.White
        Me.btnFilterSearch.Image = CType(resources.GetObject("btnFilterSearch.Image"), System.Drawing.Image)
        Me.btnFilterSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnFilterSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFilterSearch.Location = New System.Drawing.Point(763, 74)
        Me.btnFilterSearch.Name = "btnFilterSearch"
        Me.btnFilterSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFilterSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFilterSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFilterSearch.OnHoverImage = Nothing
        Me.btnFilterSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnFilterSearch.Radius = 3
        Me.btnFilterSearch.Size = New System.Drawing.Size(82, 26)
        Me.btnFilterSearch.TabIndex = 14
        Me.btnFilterSearch.Text = "Filter"
        Me.btnFilterSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.cmbSelectProgramLevel.Location = New System.Drawing.Point(56, 74)
        Me.cmbSelectProgramLevel.Name = "cmbSelectProgramLevel"
        Me.cmbSelectProgramLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgramLevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgramLevel.Radius = 3
        Me.cmbSelectProgramLevel.Size = New System.Drawing.Size(172, 26)
        Me.cmbSelectProgramLevel.TabIndex = 15
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
        Me.cmbSelectYear.Items.AddRange(New Object() {"Select Year", "1", "2", "3", "4"})
        Me.cmbSelectYear.Location = New System.Drawing.Point(565, 74)
        Me.cmbSelectYear.Name = "cmbSelectYear"
        Me.cmbSelectYear.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectYear.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectYear.Radius = 3
        Me.cmbSelectYear.Size = New System.Drawing.Size(184, 26)
        Me.cmbSelectYear.TabIndex = 10
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
        Me.cmbSelectProgram.Location = New System.Drawing.Point(248, 74)
        Me.cmbSelectProgram.Name = "cmbSelectProgram"
        Me.cmbSelectProgram.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectProgram.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectProgram.Radius = 3
        Me.cmbSelectProgram.Size = New System.Drawing.Size(297, 26)
        Me.cmbSelectProgram.TabIndex = 13
        '
        'StudID
        '
        Me.StudID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StudID.DataPropertyName = "StudID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.StudID.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudID.HeaderText = "StudID"
        Me.StudID.Name = "StudID"
        Me.StudID.ReadOnly = True
        Me.StudID.Visible = False
        '
        'joinYear
        '
        Me.joinYear.DataPropertyName = "joinYear"
        Me.joinYear.HeaderText = "joinYear"
        Me.joinYear.Name = "joinYear"
        Me.joinYear.ReadOnly = True
        Me.joinYear.Visible = False
        '
        'No
        '
        Me.No.HeaderText = "NO."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FirstName.DataPropertyName = "FirstName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.DefaultCellStyle = DataGridViewCellStyle4
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Width = 88
        '
        'MiddleName
        '
        Me.MiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MiddleName.DataPropertyName = "MiddleName"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MiddleName.DefaultCellStyle = DataGridViewCellStyle5
        Me.MiddleName.HeaderText = "Middle Name"
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.ReadOnly = True
        Me.MiddleName.Visible = False
        '
        'LastName
        '
        Me.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastName.DataPropertyName = "LastName"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LastName.DefaultCellStyle = DataGridViewCellStyle6
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'StudentID
        '
        Me.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StudentID.DataPropertyName = "StudentID"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.StudentID.DefaultCellStyle = DataGridViewCellStyle7
        Me.StudentID.HeaderText = "Student ID.NO"
        Me.StudentID.Name = "StudentID"
        Me.StudentID.ReadOnly = True
        '
        'programLevel
        '
        Me.programLevel.DataPropertyName = "programLevel"
        Me.programLevel.HeaderText = "Program Level"
        Me.programLevel.Name = "programLevel"
        Me.programLevel.ReadOnly = True
        '
        'programName
        '
        Me.programName.DataPropertyName = "programName"
        Me.programName.HeaderText = "Program"
        Me.programName.Name = "programName"
        Me.programName.ReadOnly = True
        '
        'year
        '
        Me.year.DataPropertyName = "year"
        Me.year.HeaderText = "Year"
        Me.year.Name = "year"
        Me.year.ReadOnly = True
        '
        'Edit
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5)
        Me.Edit.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkRed
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle9
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 502)
        Me.Controls.Add(Me.cmbSelectProgramLevel)
        Me.Controls.Add(Me.btnFilterSearch)
        Me.Controls.Add(Me.cmbSelectProgram)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.btnImportFromExcel)
        Me.Controls.Add(Me.dgvStudentData)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.cmbSelectYear)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvStudentData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btnReset As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnCreate As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton12 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnImportFromExcel As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvStudentData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnFilterSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbSelectProgramLevel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbSelectProgram As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbSelectYear As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents StudID As DataGridViewTextBoxColumn
    Friend WithEvents joinYear As DataGridViewTextBoxColumn
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents MiddleName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents StudentID As DataGridViewTextBoxColumn
    Friend WithEvents programLevel As DataGridViewTextBoxColumn
    Friend WithEvents programName As DataGridViewTextBoxColumn
    Friend WithEvents year As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
