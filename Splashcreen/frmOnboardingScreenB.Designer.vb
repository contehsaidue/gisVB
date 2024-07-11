<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnboardingScreenB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnboardingScreenB))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnPrevious = New Guna.UI.WinForms.GunaButton()
        Me.btnNext = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(29, 68)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(548, 30)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "the Grading Information System - Core Components"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(31, 126)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(643, 90)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = resources.GetString("GunaLabel2.Text")
        '
        'btnPrevious
        '
        Me.btnPrevious.AnimationHoverSpeed = 0.07!
        Me.btnPrevious.AnimationSpeed = 0.03!
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrevious.BorderColor = System.Drawing.Color.Transparent
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrevious.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrevious.Location = New System.Drawing.Point(682, 304)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnPrevious.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrevious.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrevious.OnHoverImage = Nothing
        Me.btnPrevious.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrevious.Radius = 3
        Me.btnPrevious.Size = New System.Drawing.Size(92, 42)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNext
        '
        Me.btnNext.AnimationHoverSpeed = 0.07!
        Me.btnNext.AnimationSpeed = 0.03!
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNext.BorderColor = System.Drawing.Color.Transparent
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNext.FocusedColor = System.Drawing.Color.Empty
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnNext.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNext.Location = New System.Drawing.Point(780, 304)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnNext.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNext.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNext.OnHoverImage = Nothing
        Me.btnNext.OnPressedColor = System.Drawing.Color.Black
        Me.btnNext.Radius = 3
        Me.btnNext.Size = New System.Drawing.Size(75, 42)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(758, 12)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(97, 89)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 17
        Me.GunaPictureBox2.TabStop = False
        '
        'frmOnboardingScreenB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 357)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOnboardingScreenB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOnboardingScreenB"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnPrevious As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
