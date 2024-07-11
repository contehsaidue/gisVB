Imports System.Data.SQLite
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Public Class frmCourse

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

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabaseTable()
        RefreshDataGridView()

        '...

        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0

    End Sub


    'Create database table if not exist
    Private Sub CreateDatabaseTable()

        command.CommandText = "CREATE TABLE IF NOT EXISTS tblCourseData (CourseID INTEGER PRIMARY KEY AUTOINCREMENT, CourseName TEXT, CourseCode TEXT, CreditHour TEXT, ProgramLevel TEXT, ProgramName TEXT, Year TEXT, Semester TEXT)"
        command.ExecuteNonQuery()

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Course Data successful removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Failed to remove Course Data unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As Data.DataTable

        command.CommandText = "SELECT * FROM tblCourseData ORDER BY RANDOM()"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return DataTable

    End Function

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()

        dgvCourseData.DataSource = GetData()
        incrementedVariable()

        dgvCourseData.Columns("No").DisplayIndex = 0
        dgvCourseData.Columns("CourseName").DisplayIndex = 1
        dgvCourseData.Columns("CourseCode").DisplayIndex = 2
        dgvCourseData.Columns("CreditHour").DisplayIndex = 3
        dgvCourseData.Columns("ProgramLevel").DisplayIndex = 4
        dgvCourseData.Columns("ProgramName").DisplayIndex = 5
        dgvCourseData.Columns("Year").DisplayIndex = 6
        dgvCourseData.Columns("Semester").DisplayIndex = 7
        dgvCourseData.Columns("Edit").DisplayIndex = 8
        dgvCourseData.Columns("Delete").DisplayIndex = 9


    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvCourseData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvCourseData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Delete Method

    Private Sub DeleteData(CourseID As Integer)
        command.CommandText = "DELETE FROM tblCourseData WHERE CourseID = @CourseID"
        command.Parameters.AddWithValue("@CourseID", CourseID)

        If (command.ExecuteNonQuery() > 0) Then

            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If
    End Sub

    'Creating the CRUD METHODS - ENDS


    'User Interaction

    '01. Create Click : Starts
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCourseAddData.Show()
    End Sub

    '01. Create Click : Ends

    'Datagridview Cell Controls

    Private Sub dgvCourseData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourseData.CellContentClick

        ' Check if the clicked cell is in the button column
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then

            ' Perform action when button is clicked

            Dim selectedRow As DataGridViewRow = dgvCourseData.Rows(e.RowIndex)

            'Get the data from the cells
            Dim column1Value As String = selectedRow.Cells("CourseID").Value.ToString()
            Dim column2Value As String = selectedRow.Cells("CourseName").Value.ToString()
            Dim column3Value As String = selectedRow.Cells("CourseCode").Value.ToString()
            Dim column4Value As String = selectedRow.Cells("CreditHour").Value.ToString()
            Dim column5Value As String = selectedRow.Cells("ProgramLevel").Value.ToString()
            Dim column6Value As String = selectedRow.Cells("ProgramName").Value.ToString()
            Dim column7Value As String = selectedRow.Cells("Year").Value.ToString()
            Dim column8Value As String = selectedRow.Cells("Semester").Value.ToString()

            ' Create an instance of the target form
            Dim targetForm As New frmCourseUpdateData()

            ' Pass the data to the target form
            targetForm.SetData(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value, column8Value)

            ' Show the target form
            targetForm.Show()

        ElseIf e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want to delete this particular Course?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then
                ' Code to execute when user chooses Yes

                Dim selectedRow As DataGridViewRow = dgvCourseData.Rows(e.RowIndex)
                Dim dataFromRow As Integer = selectedRow.Cells("CourseID").Value

                Dim id As Integer = dataFromRow
                ' ...
                DeleteData(id)
                RefreshDataGridView()

            End If
        End If

    End Sub


    'Filter Button Logic Starts

    Public Sub ShowFilterResult(ProgramLevel As String, ProgramName As String, Year As Integer, Semester As String)

        Dim searchQuery As String = "SELECT * FROM tblCourseData WHERE ProgramLevel LIKE '%' || @ProgramLevel || '%' AND ProgramName LIKE '%' || @ProgramName || '%' AND Year LIKE '%' || @Year || '%'  AND Semester LIKE '%' || @Semester || '%'"
        Dim filterCmd As New SQLiteCommand(searchQuery, connection)

        ' Use parameterized query to avoid SQL injection
        filterCmd.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        filterCmd.Parameters.AddWithValue("@ProgramName", ProgramName)
        filterCmd.Parameters.AddWithValue("@Year", Year)
        filterCmd.Parameters.AddWithValue("@Semester", Semester)

        Dim resultAdapter As New SQLiteDataAdapter

        resultAdapter.SelectCommand = filterCmd

        ' Create an instance of the DataTable class
        Dim resultDataTable As New Data.DataTable()

        resultAdapter.Fill(resultDataTable)
        dgvCourseData.DataSource = resultDataTable
        incrementedVariable()

    End Sub

    Private Sub btnFilterSearchB_Click(sender As Object, e As EventArgs) Handles btnFilterSearchB.Click

        Dim ProgramLevel As String = cmbSelectProgramLevel.SelectedItem
        Dim ProgramName As String = cmbSelectProgram.SelectedItem
        Dim Year As String = cmbSelectYear.SelectedItem
        Dim Semester As String = cmbSemester.SelectedItem

        ShowFilterResult(ProgramLevel, ProgramName, Year, Semester)

    End Sub

    Private Sub btnResetB_Click(sender As Object, e As EventArgs) Handles btnResetB.Click
        RefreshDataGridView()

        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0

    End Sub

    'Filter Button Logic Ends


    'Form Controls
    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
End Class


