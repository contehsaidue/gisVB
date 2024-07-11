Imports System.Data.SQLite
Public Class frmCreateAccount

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

    Private imagePath As String

    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabaseTable()
        btnLoginFormShow.Visible = False

    End Sub


    'Create database table if not exist
    Private Sub CreateDatabaseTable()

        command.CommandText = "CREATE TABLE IF NOT EXISTS tblUserData (UserID INTEGER PRIMARY KEY AUTOINCREMENT, FirstName TEXT, LastName TEXT, SecretPin TEXT, Username TEXT, Password TEXT, UserRole TEXT, ImagePath TEXT)"
        command.ExecuteNonQuery()

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Fail to create new user!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Insert Method

    Private Sub InsertData(ByVal firstname As String, ByVal lastname As String, ByVal secretpin As String, ByVal username As String, ByVal password As String, ByVal userrole As String, ByVal imagePath As String)

        Dim insertQuery As String = "INSERT INTO tblUserData (FirstName, LastName, SecretPin, Username, Password, UserRole, ImagePath) VALUES (@FirstName, @LastName, @SecretPin, @Username, @Password, @UserRole, @ImagePath);"
        Using cmd As New SQLiteCommand(insertQuery, connection)
            cmd.Parameters.AddWithValue("@FirstName", firstname)
            cmd.Parameters.AddWithValue("@LastName", lastname)
            cmd.Parameters.AddWithValue("@SecretPin", secretpin)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)
            cmd.Parameters.AddWithValue("@UserRole", userrole)
            cmd.Parameters.AddWithValue("@ImagePath", imagePath)

            If (cmd.ExecuteNonQuery() > 0) Then

                ShowSuccessMessage()

                btnLoginFormShow.Visible = True ' Shows the login button after successful signup
            Else
                ShowFailureMessage()
            End If

        End Using

    End Sub


    'Clear Data Method - STARTS

    Private Sub ClearData()

        txtFName.Text = " "
        txtLName.Text = " "
        txtSecretRestorePin.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        pctUserImage.Image = Nothing

    End Sub

    'Clear Data Method - ENDS

    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pctUserImage.Image = Image.FromFile(openFileDialog.FileName)
            ' Store the image path for later use when saving to the database
            imagePath = openFileDialog.FileName
        End If

    End Sub

    'Handling User Interactions
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        Dim firstname As String = txtFName.Text
        Dim lastname As String = txtLName.Text
        Dim secretpin As String = txtSecretRestorePin.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim confirmpassword As String = txtConfirmPassword.Text
        Dim userrole As String = "Admin"

        If (confirmpassword = password) Then

            InsertData(firstname, lastname, secretpin, username, password, userrole, imagePath)
            ClearData()

        Else
            ' Invalid credentials
            MessageBox.Show("Passwords do not match.")
        End If

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnLoginFormShow_Click(sender As Object, e As EventArgs) Handles btnLoginFormShow.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class