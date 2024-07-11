Imports System.Data.SQLite
Public Class frmStudentUpdateData

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
    ' Properties to store the data
    Public Property StudID As Integer
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property StudentID As Integer
    Public Property ProgramLevel As String
    Public Property ProgramName As String
    Public Property Year As String

    ' Method to set the data
    Public Sub SetData(column1Value As String, column2Value As String, column3Value As String, column4Value As String, column5Value As String, column6Value As String, column7Value As String, column8Value As String)
        StudID = Integer.Parse(column1Value)
        FirstName = column2Value
        MiddleName = column3Value
        LastName = column4Value
        StudentID = Integer.Parse(column5Value)
        ProgramLevel = column6Value
        ProgramName = column7Value
        Year = column8Value
    End Sub

    Private Sub frmStudentUpdateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display the data in the labels, textboxes, etc. on the TargetForm
        txtID.Text = StudID
        txtFName.Text = FirstName
        txtMName.Text = MiddleName
        txtLName.Text = LastName
        txtStudentID.Text = StudentID
        cmbProgramLevel.SelectedItem = ProgramLevel
        cmbProgram.SelectedItem = ProgramName
        cmbYear.SelectedItem = Year

        ' To hide the textbox for Unique ID 
        txtID.Visible = False

        ' ...

    End Sub


    'Response Messages Starts
    Private Sub ShowSuccessMessage()
        MessageBox.Show("Student Data updated successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Student Data update unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As DataTable

        command.CommandText = "SELECT * FROM tblStudentData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()
        frmStudent.dgvStudentData.DataSource = GetData()
        incrementedVariable()

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = frmStudent.dgvStudentData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            frmStudent.dgvStudentData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Update Method

    Private Sub UpdateData(StudID As Integer, FirstName As String, MiddleName As String, LastName As String, StudentID As Integer, ProgramLevel As String, ProgramName As String, Year As String)
        command.CommandText = "UPDATE tblStudentData SET FirstName = @FirstName,  MiddleName = @MiddleName, LastName = @LastName, StudentID = @StudentID, ProgramLevel = @ProgramLevel, ProgramName = @ProgramName, Year = @Year WHERE StudID = @StudID"
        command.Parameters.AddWithValue("@StudID", StudID)
        command.Parameters.AddWithValue("@FirstName", FirstName)
        command.Parameters.AddWithValue("@MiddleName", MiddleName)
        command.Parameters.AddWithValue("@LastName", LastName)
        command.Parameters.AddWithValue("@StudentID", StudentID)
        command.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        command.Parameters.AddWithValue("@ProgramName", ProgramName)
        command.Parameters.AddWithValue("@Year", Year)

        If (command.ExecuteNonQuery() > 0) Then
            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If

    End Sub

    'Clear Data Method - STARTS
    Private Sub ClearData()

        txtFName.Text = " "
        txtMName.Text = " "
        txtLName.Text = " "
        txtStudentID.Text = " "
        cmbProgramLevel.SelectedItem = Nothing
        cmbProgram.SelectedItem = Nothing
        cmbYear.SelectedItem = Nothing

    End Sub

    'Clear Data Method - ENDS


    'Handling User Interactions
    Private Sub btnUpdateData_Click_1(sender As Object, e As EventArgs) Handles btnUpdateData.Click

        Dim StudID As Integer = txtID.Text
        Dim FirstName As String = txtFName.Text
        Dim MiddleName As String = txtMName.Text
        Dim LastName As String = txtLName.Text
        Dim StudentID As String = txtStudentID.Text
        Dim ProgramLevel As String = cmbProgramLevel.SelectedItem
        Dim ProgramName As String = cmbProgram.SelectedItem
        Dim Year As String = cmbYear.SelectedItem

        UpdateData(StudID, FirstName, MiddleName, LastName, StudentID, ProgramLevel, ProgramName, Year)
        ClearData()
        RefreshDataGridView()

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmStudent.Show()
        Me.Close()
    End Sub

End Class