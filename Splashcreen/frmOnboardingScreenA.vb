Public Class frmOnboardingScreenA

    Private Sub frmOnboardingScreenA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmSplashScreen.Timer1.Stop()

    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click

        frmLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        frmOnboardingScreenB.Show()
        Me.Hide()

    End Sub

End Class