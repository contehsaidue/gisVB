Public Class frmOnboardingScreenB
    Private Sub frmOnboardingScreenB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnPrevious_Click_1(sender As Object, e As EventArgs) Handles btnPrevious.Click

        frmOnboardingScreenA.Show()
        Me.Hide()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        frmLogin.Show()
        Me.Hide()

    End Sub
End Class