Imports System.Data.SQLite
Public Class frmLogin

    'Database Connections
    Private connection As SQLiteConnection
    Private command As SQLiteCommand

    'Initializing SQLite Database connections
    Public Sub New()
        InitializeComponent()
        Try
            connection = New SQLiteConnection("Data Source=gis.db;Version=3;Pooling=true;")
            connection.Open()
            command = connection.CreateCommand()

        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Handling User Interaction

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Retrieve the entered username and password
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "SELECT UserRole FROM tblUserData WHERE Username = @Username AND Password = @Password"
        Using command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Dim reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then

                Dim role As String = reader.GetString(0)

                ' Perform actions based on user role
                Select Case role
                            ' ...
                    Case "Admin"

                        ' Create an instance of the target form
                        Dim targetForm As New frmDashboard()

                        Dim column1Value As String = GetUserId(username)
                        ' Pass the data to the target form
                        targetForm.SetData(column1Value)

                        ' Show the target form
                        targetForm.Show()
                        Me.Close()

                        ' ...
                    Case Else
                        ' Code for other roles
                        ' ...
                End Select
            Else
                MessageBox.Show("Invalid username or password!")
            End If

            reader.Close() 'Closes the reader stream... possible bug solved!

        End Using

    End Sub

    Private Function GetUserId(username As String) As Integer
        ' Retrieve the user ID from the SQLite database

        Dim query As String = "SELECT UserID FROM tblUserData WHERE Username = @username"
        Using command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)

            Dim userId As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return userId

        End Using

    End Function

    'Create new user account
    Private Sub linkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkCreateAccount.LinkClicked

        frmCreateAccount.Show()
        Me.Close()

    End Sub

    'Restore user login details
    Private Sub linkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgotPassword.LinkClicked

        frmForgotPassword.Show()
        Me.Close()

    End Sub
End Class