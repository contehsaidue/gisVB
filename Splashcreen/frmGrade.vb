Imports System.Data.SQLite
Public Class frmGrade

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

    Private Sub frmGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabaseTable()
        RefreshDataGridView()

        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0

    End Sub

    'Create database table If Not exist
    Private Sub CreateDatabaseTable()

        command.CommandText = "CREATE TABLE IF NOT EXISTS tblGradeData 
        (GradeID INTEGER PRIMARY KEY AUTOINCREMENT,
        StudID INTEGER,
        CourseID INTEGER,
        Grade TEXT,
        Semester TEXT,
        FOREIGN KEY (StudID) REFERENCES tblStudentData(StudID),
        FOREIGN KEY (CourseID) REFERENCES tblCourseData(CourseID))"
        command.ExecuteNonQuery()

    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Grade Data successful removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Grade Data removal unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As Data.DataTable
        command.CommandText = "SELECT StudID, FirstName, LastName, StudentID, Year, ProgramLevel, ProgramName FROM tblStudentData ORDER BY RANDOM() LIMIT 100"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable
    End Function


    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()

        dgvStudentGradeData.DataSource = GetData()
        incrementedVariable()

        dgvStudentGradeData.Columns("No").DisplayIndex = 0
        dgvStudentGradeData.Columns("FirstName").DisplayIndex = 1
        dgvStudentGradeData.Columns("LastName").DisplayIndex = 2
        dgvStudentGradeData.Columns("StudentID").DisplayIndex = 3
        dgvStudentGradeData.Columns("Year").DisplayIndex = 4
        dgvStudentGradeData.Columns("btnAdd").DisplayIndex = 5

    End Sub

    'Auto Data Refresh Method - ENDS


    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvStudentGradeData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvStudentGradeData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    'User Interaction

    '01. Create Click : Starts with Datagrid Cellcontent click event
    Private Sub dgvStudentGradeData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentGradeData.CellContentClick

        ' Check if the clicked cell is in the button column
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then

            ' Perform action when button is clicked

            Dim selectedRow As DataGridViewRow = dgvStudentGradeData.Rows(e.RowIndex)

            'Get the data from the cells
            Dim column1Value As String = selectedRow.Cells("StudID").Value.ToString()
            Dim column2Value As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim column3Value As String = selectedRow.Cells("LastName").Value.ToString()
            Dim column4Value As String = selectedRow.Cells("StudentID").Value.ToString()
            Dim column5Value As String = selectedRow.Cells("Year").Value.ToString()
            Dim column6Value As String = selectedRow.Cells("ProgramLevel").Value.ToString()
            Dim column7Value As String = selectedRow.Cells("ProgramName").Value.ToString()

            ' Create an instance of the target form
            Dim targetForm As New frmGradeAddData()

            ' Pass the data to the target form

            targetForm.SetData(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value)

            ' Show the target form
            targetForm.Show()

        End If

    End Sub

    '01. Create Click : Ends with Datagrid Cellcontent click event

    'Search Button Logic Starts

    Public Sub ShowFilterResult(ProgramLevel As String, ProgramName As String, Year As Integer)

        Dim searchQuery As String = "SELECT StudID, FirstName, LastName, StudentID, Year, ProgramLevel, ProgramName FROM tblStudentData WHERE ProgramLevel LIKE '%' || @ProgramLevel || '%' AND ProgramName LIKE '%' || @ProgramName || '%' AND Year LIKE '%' || @Year || '%'"
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
        dgvStudentGradeData.DataSource = resultDataTable
        incrementedVariable()

        dgvStudentGradeData.Columns("No").DisplayIndex = 0
        dgvStudentGradeData.Columns("FirstName").DisplayIndex = 1
        dgvStudentGradeData.Columns("LastName").DisplayIndex = 2
        dgvStudentGradeData.Columns("StudentID").DisplayIndex = 3
        dgvStudentGradeData.Columns("Year").DisplayIndex = 4
        dgvStudentGradeData.Columns("btnAdd").DisplayIndex = 5

    End Sub

    Private Sub btnFilterSearchC_Click(sender As Object, e As EventArgs) Handles btnFilterSearchC.Click

        Dim ProgramLevel As String = cmbSelectProgramLevel.SelectedItem
        Dim ProgramName As String = cmbSelectProgram.SelectedItem
        Dim Year As String = cmbSelectYear.SelectedItem

        ShowFilterResult(ProgramLevel, ProgramName, Year)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        RefreshDataGridView()

        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0

    End Sub

    'Search Button Logic Ends

    'Form Control
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

End Class