﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGradeUpdateData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradeUpdateData))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtGradeID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBack = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.cmbCourse = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbSelectLetterGrade = New Guna.UI.WinForms.GunaComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnUpdateData = New Guna.UI.WinForms.GunaButton()
        Me.cmbSemester = New Guna.UI.WinForms.GunaComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtGradeID)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 48)
        Me.Panel1.TabIndex = 13
        '
        'txtGradeID
        '
        Me.txtGradeID.BorderThickness = 0
        Me.txtGradeID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGradeID.DefaultText = ""
        Me.txtGradeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGradeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGradeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGradeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGradeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGradeID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGradeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGradeID.IconLeft = CType(resources.GetObject("txtGradeID.IconLeft"), System.Drawing.Image)
        Me.txtGradeID.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtGradeID.Location = New System.Drawing.Point(359, 8)
        Me.txtGradeID.Name = "txtGradeID"
        Me.txtGradeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGradeID.PlaceholderText = "GID"
        Me.txtGradeID.SelectedText = ""
        Me.txtGradeID.Size = New System.Drawing.Size(87, 36)
        Me.txtGradeID.TabIndex = 20
        Me.txtGradeID.TextOffset = New System.Drawing.Point(5, 0)
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
        Me.GunaLabel1.Size = New System.Drawing.Size(184, 21)
        Me.GunaLabel1.TabIndex = 9
        Me.GunaLabel1.Text = "Update Student Grade"
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
        'cmbCourse
        '
        Me.cmbCourse.BackColor = System.Drawing.Color.Transparent
        Me.cmbCourse.BaseColor = System.Drawing.Color.White
        Me.cmbCourse.BorderColor = System.Drawing.Color.Silver
        Me.cmbCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FocusedColor = System.Drawing.Color.Empty
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCourse.ForeColor = System.Drawing.Color.Black
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(314, 104)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCourse.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbCourse.Size = New System.Drawing.Size(280, 26)
        Me.cmbCourse.TabIndex = 18
        '
        'cmbSelectLetterGrade
        '
        Me.cmbSelectLetterGrade.BackColor = System.Drawing.Color.Transparent
        Me.cmbSelectLetterGrade.BaseColor = System.Drawing.Color.White
        Me.cmbSelectLetterGrade.BorderColor = System.Drawing.Color.Silver
        Me.cmbSelectLetterGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSelectLetterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectLetterGrade.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSelectLetterGrade.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSelectLetterGrade.ForeColor = System.Drawing.Color.Black
        Me.cmbSelectLetterGrade.FormattingEnabled = True
        Me.cmbSelectLetterGrade.Items.AddRange(New Object() {"Select Letter Grade", "A", "B", "C", "D", "E", "F"})
        Me.cmbSelectLetterGrade.Location = New System.Drawing.Point(19, 162)
        Me.cmbSelectLetterGrade.Name = "cmbSelectLetterGrade"
        Me.cmbSelectLetterGrade.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSelectLetterGrade.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSelectLetterGrade.Size = New System.Drawing.Size(277, 26)
        Me.cmbSelectLetterGrade.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.cmbCourse)
        Me.GroupBox1.Controls.Add(Me.cmbSelectLetterGrade)
        Me.GroupBox1.Controls.Add(Me.txtStudentID)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 233)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Student Grade Details"
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
        Me.txtStudentID.Location = New System.Drawing.Point(19, 94)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = "Student ID Number"
        Me.txtStudentID.ReadOnly = True
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
        Me.txtLName.Location = New System.Drawing.Point(317, 38)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.PlaceholderText = "Last Name"
        Me.txtLName.ReadOnly = True
        Me.txtLName.SelectedText = ""
        Me.txtLName.Size = New System.Drawing.Size(277, 36)
        Me.txtLName.TabIndex = 13
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
        Me.txtFName.Location = New System.Drawing.Point(19, 38)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFName.PlaceholderText = "First Name"
        Me.txtFName.ReadOnly = True
        Me.txtFName.SelectedText = ""
        Me.txtFName.Size = New System.Drawing.Size(280, 36)
        Me.txtFName.TabIndex = 11
        Me.txtFName.TextOffset = New System.Drawing.Point(5, 0)
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.btnUpdateData.Location = New System.Drawing.Point(478, 306)
        Me.btnUpdateData.Name = "btnUpdateData"
        Me.btnUpdateData.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdateData.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdateData.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateData.OnHoverImage = Nothing
        Me.btnUpdateData.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdateData.Radius = 3
        Me.btnUpdateData.Size = New System.Drawing.Size(173, 38)
        Me.btnUpdateData.TabIndex = 14
        Me.btnUpdateData.Text = "Update Grade"
        '
        'cmbSemester
        '
        Me.cmbSemester.BackColor = System.Drawing.Color.Transparent
        Me.cmbSemester.BaseColor = System.Drawing.Color.White
        Me.cmbSemester.BorderColor = System.Drawing.Color.Silver
        Me.cmbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSemester.ForeColor = System.Drawing.Color.Black
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"Select Semester", "First", "Second"})
        Me.cmbSemester.Location = New System.Drawing.Point(317, 162)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSemester.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbSemester.Size = New System.Drawing.Size(280, 26)
        Me.cmbSemester.TabIndex = 20
        '
        'frmGradeUpdateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 356)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdateData)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGradeUpdateData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents cmbCourse As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbSelectLetterGrade As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents btnUpdateData As Guna.UI.WinForms.GunaButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents txtGradeID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSemester As Guna.UI.WinForms.GunaComboBox
End Class