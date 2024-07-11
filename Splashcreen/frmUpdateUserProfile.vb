Imports System.Data.SQLite
Public Class frmUpdateUserProfile

    'Database Connections
    Private connection As SQLiteConnection
    Private command As SQLiteCommand

    Private getUserID As Integer

    'Initializing SQLite Database connections

    Public Sub New(userid As Integer)
        InitializeComponent()
        getUserID = userid

        Try
            connection = New SQLiteConnection("Data Source=gis.db;Version=3;Pooling=true;")
            connection.Open()
            command = connection.CreateCommand()

        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private imagePath As String

    Private Sub frmUpdateUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAdminData(getUserID)
    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("User data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Fail to update user data!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Sub LoadAdminData(getUserID As Integer)
        Dim query As String = "SELECT * FROM tblUserData WHERE UserID = @getUserID"

        Dim command As New SQLiteCommand(query, connection)
        command.Parameters.AddWithValue("@getUserID", getUserID)

        Dim reader As SQLiteDataReader = command.ExecuteReader()

        While reader.Read()
                Dim value1 As String = reader.GetString(1)
                Dim value2 As String = reader.GetString(2)
                Dim value3 As String = reader.GetString(3)
                Dim value4 As String = reader.GetString(4)
                Dim value5 As String = reader.GetString(5)
                Dim value7 As String = Convert.ToString(reader.GetValue(7))

                txtFName.Text = value1
                txtLName.Text = value2
                txtSecretRestorePin.Text = value3
                txtUsername.Text = value4
                txtPassword.Text = value5

                Dim ImagePath As String = value7

                If Not String.IsNullOrEmpty(ImagePath) AndAlso IO.File.Exists(ImagePath) Then
                    pctUserImage.Image = Image.FromFile(ImagePath)
                Else
                    ' Handle the case where the image path is empty or invalid
                    pctUserImage.Image = Nothing
                End If
        End While

        reader.Close()
    End Sub


    '02. Update Method

    Private Sub UpdateData(UserID As Integer, firstname As String, lastname As String, secretpin As String, username As String, password As String, userrole As String, imagePath As String)
        command.CommandText = "UPDATE tblUserData SET FirstName = @FirstName,  LastName = @LastName, SecretPin = @SecretPin, Username = @Username, Password = @Password, 
        UserRole = @UserRole, ImagePath = @ImagePath WHERE UserID = @UserID"

        command.Parameters.AddWithValue("@UserID", UserID)
        command.Parameters.AddWithValue("@FirstName", firstname)
        command.Parameters.AddWithValue("@LastName", lastname)
        command.Parameters.AddWithValue("@SecretPin", secretpin)
        command.Parameters.AddWithValue("@Username", username)
        command.Parameters.AddWithValue("@Password", password)
        command.Parameters.AddWithValue("@UserRole", userrole)
        command.Parameters.AddWithValue("@ImagePath", imagePath)

        If (command.ExecuteNonQuery() > 0) Then

            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If

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
    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click

        Dim UserID As Integer = getUserID
        Dim firstname As String = txtFName.Text
        Dim lastname As String = txtLName.Text
        Dim secretpin As String = txtSecretRestorePin.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim confirmpassword As String = txtConfirmPassword.Text
        Dim userrole As String = "Admin"

        If (confirmpassword = password) Then

            UpdateData(UserID, firstname, lastname, secretpin, username, password, userrole, imagePath)
            ClearData()

        Else
            ' Invalid credentials
            MessageBox.Show("Passwords do not match.")

        End If

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

    Private Sub frmUpdateUserProfile_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose() ' Dispose the form to ensure it is recreated when reopened
    End Sub

End Class