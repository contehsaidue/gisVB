﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseUpdateData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourseUpdateData))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCourseCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbCreditHour = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtCourseName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdateData = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtID = New Guna.UI.WinForms.GunaTextBox()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbProgram = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbProgramLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbSemester = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.cmbProgram)
        Me.GroupBox1.Controls.Add(Me.cmbProgramLevel)
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.txtCourseCode)
        Me.GroupBox1.Controls.Add(Me.cmbCreditHour)
        Me.GroupBox1.Controls.Add(Me.txtCourseName)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 184)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Course Details"
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourseCode.DefaultText = ""
        Me.txtCourseCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourseCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourseCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourseCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourseCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourseCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCourseCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourseCode.Location = New System.Drawing.Point(333, 33)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourseCode.PlaceholderText = "Course Code"
        Me.txtCourseCode.SelectedText = ""
        Me.txtCourseCode.Size = New System.Drawing.Size(104, 36)
        Me.txtCourseCode.TabIndex = 16
        '
        'cmbCreditHour
        '
        Me.cmbCreditHour.BackColor = System.Drawing.Color.Transparent
        Me.cmbCreditHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCreditHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCreditHour.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCreditHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCreditHour.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCreditHour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCreditHour.ItemHeight = 30
        Me.cmbCreditHour.Items.AddRange(New Object() {"Credit Hour", "3", "2"})
        Me.cmbCreditHour.Location = New System.Drawing.Point(448, 33)
        Me.cmbCreditHour.Name = "cmbCreditHour"
        Me.cmbCreditHour.Size = New System.Drawing.Size(150, 36)
        Me.cmbCreditHour.TabIndex = 12
        '
        'txtCourseName
        '
        Me.txtCourseName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCourseName.DefaultText = ""
        Me.txtCourseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCourseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCourseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCourseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourseName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCourseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCourseName.Location = New System.Drawing.Point(22, 33)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCourseName.PlaceholderText = "Course Name"
        Me.txtCourseName.SelectedText = ""
        Me.txtCourseName.Size = New System.Drawing.Size(274, 36)
        Me.txtCourseName.TabIndex = 11
        '
        'btnUpdateData
        '
        Me.btnUpdateData.AnimationHoverSpeed = 0.07!
        Me.btnUpdateData.AnimationSpeed = 0.03!
        Me.btnUpdateData.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateData.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdateData.BorderColor = System.Drawing.Color.Black
        Me.btnUpdateData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateData.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateData.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateData.ForeColor = System.Drawing.Color.White
        Me.btnUpdateData.Image = CType(resources.GetObject("btnUpdateData.Image"), System.Drawing.Image)
        Me.btnUpdateData.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdateData.Location = New System.Drawing.Point(489, 266)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateData.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdateData.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateData.OnHoverImage = Nothing
        Me.btnUpdateData.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdateData.Radius = 3
        Me.btnUpdateData.Size = New System.Drawing.Size(152, 31)
        Me.btnUpdateData.TabIndex = 8
        Me.btnUpdateData.Text = "Update Data"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Lavender
        Me.GunaLabel1.Location = New System.Drawing.Point(70, 16)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(170, 21)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Update  Course Data"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 53)
        Me.Panel1.TabIndex = 12
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.BaseColor = System.Drawing.Color.White
        Me.txtID.BorderColor = System.Drawing.Color.Silver
        Me.txtID.BorderSize = 1
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.FocusedBaseColor = System.Drawing.Color.White
        Me.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtID.Location = New System.Drawing.Point(259, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.Radius = 2
        Me.txtID.ReadOnly = True
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(234, 30)
        Me.txtID.TabIndex = 14
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
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.White
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(621, 12)
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
        Me.GunaControlBox2.Location = New System.Drawing.Point(580, 12)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 1
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'GunaElipse3
        '
        Me.GunaElipse3.TargetControl = Me
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
        Me.cmbYear.Location = New System.Drawing.Point(22, 130)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(277, 36)
        Me.cmbYear.TabIndex = 26
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
        Me.cmbProgram.Location = New System.Drawing.Point(328, 79)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(274, 36)
        Me.cmbProgram.TabIndex = 25
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
        Me.cmbProgramLevel.Location = New System.Drawing.Point(22, 79)
        Me.cmbProgramLevel.Name = "cmbProgramLevel"
        Me.cmbProgramLevel.Size = New System.Drawing.Size(274, 36)
        Me.cmbProgramLevel.TabIndex = 24
        '
        'cmbSemester
        '
        Me.cmbSemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSemester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSemester.ItemHeight = 30
        Me.cmbSemester.Items.AddRange(New Object() {"Semester", "First", "Second"})
        Me.cmbSemester.Location = New System.Drawing.Point(328, 130)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(274, 36)
        Me.cmbSemester.TabIndex = 23
        '
        'frmCourseUpdateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 317)
        Me.Controls.Add(Me.btnUpdateData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCourseUpdateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCourseUpdateData"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUpdateData As Guna.UI.WinForms.GunaButton
    Friend WithEvents cmbCreditHour As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtCourseName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtID As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtCourseCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbProgram As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbProgramLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbSemester As Guna.UI2.WinForms.Guna2ComboBox
End Class
