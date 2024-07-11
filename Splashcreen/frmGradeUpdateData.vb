Imports System.Data.SQLite
Public Class frmGradeUpdateData

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
    Public Property GradeID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property StudentID As Integer
    Public Property CourseName As String
    Public Property Grade As String
    Public Property Semester As String
    Public Property Year As String
    Public Property ProgramLevel As String
    Public Property ProgramName As String

    ' Method to set the data
    Public Sub SetData(column1Value As String, column2Value As String, column3Value As String, column4Value As String, column5Value As String, column6Value As String, column7Value As String, column8Value As String, column9Value As String, column10Value As String)

        GradeID = Integer.Parse(column1Value)
        FirstName = column2Value
        LastName = column3Value
        StudentID = Integer.Parse(column4Value)
        CourseName = column5Value
        Grade = column6Value
        Year = column7Value
        Semester = column8Value
        ProgramLevel = column9Value
        ProgramName = column10Value
    End Sub

    Public Sub GetCourseData(Year As Integer, ProgramLevel As String, ProgramName As String)
        Dim query As String = "SELECT * FROM tblCourseData WHERE Year = @Year AND ProgramLevel = @ProgramLevel AND ProgramName = @ProgramName"
        Dim command As New SQLiteCommand(query, connection)

        ' Use parameterized query to avoid SQL injection
        command.Parameters.AddWithValue("@Year", Year)
        command.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        command.Parameters.AddWithValue("@ProgramName", ProgramName)
        Dim dataAdapter As New SQLiteDataAdapter

        dataAdapter.SelectCommand = command
        Dim DT As New DataTable()

        ' Fill DataTable with data
        dataAdapter.Fill(DT)

        ' Insert default row
        Dim row As DataRow = DT.NewRow
        row("CourseID") = 0
        row("CourseName") = "Select Course"
        DT.Rows.InsertAt(row, 0)

        cmbCourse.DataSource = DT
        cmbCourse.DisplayMember = "CourseName"
        cmbCourse.ValueMember = "CourseID"
    End Sub

    Private Sub frmGradeUpdateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetCourseData(Year, ProgramLevel, ProgramName)

        'Display the data in the labels, textboxes, etc. on the TargetForm

        txtGradeID.Text = GradeID

        txtFName.Text = FirstName
        txtLName.Text = LastName
        txtStudentID.Text = StudentID

        cmbCourse.SelectedItem = CourseName
        cmbSelectLetterGrade.SelectedItem = Grade
        cmbSemester.SelectedItem = Semester


        'To hide the textbox for all Unique IDs 
        txtGradeID.Visible = False

        ' ...

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Student Grades updated successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Student Grades update unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As Data.DataTable

        command.CommandText = "SELECT GradeID, Grade, tblGradeData.Semester, tblCourseData.CourseName, tblCourseData.Year, tblStudentData.FirstName, tblStudentData.LastName, tblStudentData.StudentID
        FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
        JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID"

        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()

        frmGradeModify.dgvViewStudentGradeData.DataSource = GetData()
        incrementedVariable()

        frmGradeModify.dgvViewStudentGradeData.Columns("No").DisplayIndex = 0
        frmGradeModify.dgvViewStudentGradeData.Columns("FirstName").DisplayIndex = 1
        frmGradeModify.dgvViewStudentGradeData.Columns("LastName").DisplayIndex = 2
        frmGradeModify.dgvViewStudentGradeData.Columns("StudentID").DisplayIndex = 3
        frmGradeModify.dgvViewStudentGradeData.Columns("CourseName").DisplayIndex = 4
        frmGradeModify.dgvViewStudentGradeData.Columns("Grade").DisplayIndex = 5
        frmGradeModify.dgvViewStudentGradeData.Columns("Semester").DisplayIndex = 6
        frmGradeModify.dgvViewStudentGradeData.Columns("Edit").DisplayIndex = 7
        frmGradeModify.dgvViewStudentGradeData.Columns("Delete").DisplayIndex = 8

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = frmGradeModify.dgvViewStudentGradeData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            frmGradeModify.dgvViewStudentGradeData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Update Method

    Private Sub UpdateData(CourseID As Integer, GradeID As Integer, Grade As String, Semester As String)

        command.CommandText = "UPDATE tblGradeData SET Grade = @Grade, CourseID = @CourseID, Semester = @Semester WHERE GradeID = @GradeID"
        command.Parameters.AddWithValue("@CourseID", CourseID)
        command.Parameters.AddWithValue("@GradeID", GradeID)
        command.Parameters.AddWithValue("@Grade", Grade)
        command.Parameters.AddWithValue("@Semester", Semester)


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
        txtStudentID.Text = " "
        cmbSelectLetterGrade.SelectedItem = Nothing
        cmbCourse.SelectedItem = Nothing
        cmbSemester.SelectedItem = Nothing

    End Sub

    'Clear Data Method - ENDS

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click

        Dim CourseID As Integer = cmbCourse.SelectedValue
        Dim GradeID As Integer = txtGradeID.Text
        Dim Grade As String = cmbSelectLetterGrade.SelectedItem
        Dim Semester As String = cmbSemester.SelectedItem

        UpdateData(CourseID, GradeID, Grade, Semester)
        ClearData()
        RefreshDataGridView()

    End Sub

    'Form Control
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmGradeModify.Show()
        Me.Close()

    End Sub

End Class