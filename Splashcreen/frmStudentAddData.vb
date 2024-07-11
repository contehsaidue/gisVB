Imports System.Data.SQLite
Public Class frmStudentAddData

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

    Private Sub frmStudentAddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProgramLevel.SelectedIndex = 0
        cmbProgram.SelectedIndex = 0
        cmbYear.SelectedIndex = 0

    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Student Data input successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Data input unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Insert Method

    Private Sub InsertData(ByVal fname As String, ByVal mname As String, ByVal lname As String, ByVal studentID As Integer, ByVal programLevel As String, ByVal programName As String, ByVal year As Integer, joinYear As Integer)

        Dim insertQuery As String = "INSERT INTO tblStudentData (FirstName, MiddleName, LastName, StudentID, ProgramLevel, ProgramName, Year, joinYear) VALUES (@FName, @MName, @LName, @StudentID, @ProgramLevel, @ProgramName, @Year, @joinYear);"
        Using cmd As New SQLiteCommand(insertQuery, connection)
            cmd.Parameters.AddWithValue("@FName", fname)
            cmd.Parameters.AddWithValue("@MName", mname)
            cmd.Parameters.AddWithValue("@LName", lname)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            cmd.Parameters.AddWithValue("@ProgramLevel", programLevel)
            cmd.Parameters.AddWithValue("@ProgramName", programName)
            cmd.Parameters.AddWithValue("@Year", year)
            cmd.Parameters.AddWithValue("@joinYear", joinYear)

            If (cmd.ExecuteNonQuery() > 0) Then

                ShowSuccessMessage()
            Else
                ShowFailureMessage()
            End If
        End Using

    End Sub

    '02. Get Data Method

    Private Function GetData() As DataTable

        command.CommandText = "SELECT * FROM tblStudentData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function


    'Creating the CRUD METHODS - ENDS

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
    Private Sub btnInsertData_Click(sender As Object, e As EventArgs) Handles btnInsertData.Click

        Dim fname As String = txtFName.Text
        Dim mname As String = txtMName.Text
        Dim lname As String = txtLName.Text
        Dim studentID As String = txtStudentID.Text
        Dim programLevel As String = cmbProgramLevel.SelectedItem
        Dim programName As String = cmbProgram.SelectedItem
        Dim year As String = cmbYear.SelectedItem
        Dim joinYear As Integer = DateTime.Now.Year

        InsertData(fname, mname, lname, studentID, programLevel, programName, year, joinYear)
        ClearData()
        RefreshDataGridView()

    End Sub


    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmStudent.Show()
        Me.Hide()

    End Sub

End Class