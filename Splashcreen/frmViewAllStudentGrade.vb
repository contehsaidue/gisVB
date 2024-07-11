Imports System.Data.SQLite
Public Class frmViewAllStudentGrade

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

    Private Sub frmStudentGradeSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Grade Data successful removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Failed to remove Grade Data unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowSuccessMessageImport()
        MessageBox.Show("Course Data successful Imported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessageImport()
        MessageBox.Show("Failed to Import Course Data!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method
    Private Function GetData() As Data.DataTable
        command.CommandText = "SELECT DISTINCT tblStudentData.FirstName, tblStudentData.LastName, tblStudentData.StudentID, tblStudentData.ProgramLevel, tblStudentData.ProgramName, tblStudentData.Year FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID"

        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()

        dgvViewAllGrades.DataSource = GetData()
        incrementedVariable()

        dgvViewAllGrades.Columns("No").DisplayIndex = 0
        dgvViewAllGrades.Columns("FirstName").DisplayIndex = 1
        dgvViewAllGrades.Columns("LastName").DisplayIndex = 2
        dgvViewAllGrades.Columns("StudentID").DisplayIndex = 3
        dgvViewAllGrades.Columns("ProgramLevel").DisplayIndex = 4
        dgvViewAllGrades.Columns("ProgramName").DisplayIndex = 5
        dgvViewAllGrades.Columns("Year").DisplayIndex = 6
        dgvViewAllGrades.Columns("btnViewGrades").DisplayIndex = 7

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts

    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvViewAllGrades.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvViewAllGrades.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Search Button Logic Starts

    Public Sub ShowFilterResult(ProgramLevel As String, ProgramName As String, Year As Integer)

        Dim searchQuery As String = "SELECT DISTINCT tblStudentData.FirstName, tblStudentData.LastName, tblStudentData.StudentID,
        tblStudentData.ProgramLevel, tblStudentData.ProgramName, tblStudentData.Year FROM tblGradeData JOIN tblCourseData 
        ON tblGradeData.CourseID = tblCourseData.CourseID
        JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID
        WHERE tblStudentData.ProgramLevel LIKE '%' || @ProgramLevel || '%' AND tblStudentData.ProgramName LIKE '%' || @ProgramName || '%' AND tblStudentData.Year LIKE '%' || @Year || '%'"
        Dim filterCmd As New SQLiteCommand(searchQuery, connection)

        ' Use parameterized query to avoid SQL injection
        filterCmd.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        filterCmd.Parameters.AddWithValue("@ProgramName", ProgramName)
        filterCmd.Parameters.AddWithValue("@Year", Year)


        Dim resultAdapter As New SQLiteDataAdapter

        resultAdapter.SelectCommand = filterCmd

        ' Create an instance of the DataTable class
        Dim resultDataTable As New Data.DataTable()

        resultAdapter.Fill(resultDataTable)
        dgvViewAllGrades.DataSource = resultDataTable
        incrementedVariable()

    End Sub
    Private Sub btnFilterSearchE_Click(sender As Object, e As EventArgs) Handles btnFilterSearchE.Click

        Dim ProgramLevel As String = cmbSelectProgramLevel.SelectedItem
        Dim ProgramName As String = cmbSelectProgram.SelectedItem
        Dim Year As String = cmbSelectYear.SelectedItem

        ShowFilterResult(ProgramLevel, ProgramName, Year)

    End Sub

    Private Sub btnResetE_Click(sender As Object, e As EventArgs) Handles btnResetE.Click

        RefreshDataGridView()

        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0

    End Sub
    'Filter functionality ends here

    'Creating the CRUD METHODS - ENDS


    'Handling User Interaction

    '01. Create Click : Starts with Datagrid Cellcontent click event

    Private Sub dgvStudentGradeSummary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewAllGrades.CellContentClick

        ' Check if the clicked cell is in the button column
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then

            ' Perform action when button is clicked

            Dim selectedRow As DataGridViewRow = dgvViewAllGrades.Rows(e.RowIndex)

            'Get the data from the cells

            Dim column1Value As String = selectedRow.Cells("StudentID").Value.ToString()

            ' Create an instance of the target form
            Dim targetForm As New frmStudentIndividualGradesSummaryShow()

            ' Pass the data to the target form

            targetForm.SetData(column1Value)

            ' Show the target form
            targetForm.Show()

        End If

    End Sub

    '01. Create Click : Ends with Datagrid Cellcontent click event

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

End Class