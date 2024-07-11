<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnboardingScreenA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOnboardingScreenA))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnSkip = New Guna.UI.WinForms.GunaButton()
        Me.btnNext = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(50, 37)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(474, 30)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Welcome to the Grading Information System"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(43, 148)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(643, 90)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = resources.GetString("GunaLabel2.Text")
        '
        'btnSkip
        '
        Me.btnSkip.AnimationHoverSpeed = 0.07!
        Me.btnSkip.AnimationSpeed = 0.03!
        Me.btnSkip.BackColor = System.Drawing.Color.Transparent
        Me.btnSkip.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSkip.BorderColor = System.Drawing.Color.Transparent
        Me.btnSkip.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSkip.FocusedColor = System.Drawing.Color.Empty
        Me.btnSkip.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkip.ForeColor = System.Drawing.Color.White
        Me.btnSkip.Image = CType(resources.GetObject("btnSkip.Image"), System.Drawing.Image)
        Me.btnSkip.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSkip.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSkip.Location = New System.Drawing.Point(699, 303)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnSkip.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSkip.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSkip.OnHoverImage = Nothing
        Me.btnSkip.OnPressedColor = System.Drawing.Color.Black
        Me.btnSkip.Radius = 3
        Me.btnSkip.Size = New System.Drawing.Size(75, 42)
        Me.btnSkip.TabIndex = 1
        Me.btnSkip.Text = "Skip"
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
        Me.btnNext.Location = New System.Drawing.Point(780, 303)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnNext.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNext.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNext.OnHoverImage = Nothing
        Me.btnNext.OnPressedColor = System.Drawing.Color.Black
        Me.btnNext.Radius = 3
        Me.btnNext.Size = New System.Drawing.Size(75, 42)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(758, 12)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(97, 89)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 16
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(36, 70)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(519, 43)
        Me.GunaPanel2.TabIndex = 17
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(15, 9)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(481, 21)
        Me.GunaLabel3.TabIndex = 2
        Me.GunaLabel3.Text = "Department of Computer Science && Information Technology"
        '
        'frmOnboardingScreenA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 357)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOnboardingScreenA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOnboardingScreenA"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnNext As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSkip As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
