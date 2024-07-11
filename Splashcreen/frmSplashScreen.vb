Public Class frmSplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Loader.Width += 8

        If Loader.Width >= 472 Then

            frmOnboardingScreenA.Show()
            Me.Hide()

        End If
    End Sub
End Class
