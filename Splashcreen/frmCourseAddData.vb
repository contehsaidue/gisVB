Imports System.Data.SQLite
Public Class frmCourseAddData

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

    Private Sub frmCourseAddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbCreditHour.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0
        cmbProgramLevel.SelectedIndex = 0
        cmbProgram.SelectedIndex = 0
        cmbYear.SelectedIndex = 0

    End Sub

    'Response Messages Starts
    Private Sub ShowSuccessMessage()
        MessageBox.Show("Course created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Course creation unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Insert Method

    Private Sub InsertData(ByVal coursename As String, ByVal coursecode As String, ByVal credithour As String, ByVal programLevel As String, ByVal programName As String, ByVal year As String, ByVal semester As String)
        Dim insertQuery As String = "INSERT INTO tblCourseData (CourseName, CourseCode, CreditHour, ProgramLevel, ProgramName, Year, Semester) VALUES (@CourseName, @CourseCode, @CreditHour, @ProgramLevel, @ProgramName, @Year, @Semester);"
        Using cmd As New SQLiteCommand(insertQuery, connection)
            cmd.Parameters.AddWithValue("@CourseName", coursename)
            cmd.Parameters.AddWithValue("@CourseCode", coursecode)
            cmd.Parameters.AddWithValue("@CreditHour", credithour)
            cmd.Parameters.AddWithValue("@ProgramLevel", programLevel)
            cmd.Parameters.AddWithValue("@ProgramName", programName)
            cmd.Parameters.AddWithValue("@Year", year)
            cmd.Parameters.AddWithValue("@Semester", semester)


            If (cmd.ExecuteNonQuery() > 0) Then

                ShowSuccessMessage()
            Else
                ShowFailureMessage()
            End If

        End Using
    End Sub

    '02. Get Data Method

    Private Function GetData() As DataTable

        command.CommandText = "SELECT * FROM tblCourseData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function


    'Creating the CRUD METHODS - ENDS

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()
        frmCourse.dgvCourseData.DataSource = GetData()
        incrementedVariable()
    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = frmCourse.dgvCourseData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            frmCourse.dgvCourseData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    'Clear Data Method - STARTS

    Private Sub ClearData()

        txtCourseName.Text = " "
        txtCourseCode.Text = " "
        cmbCreditHour.SelectedItem = Nothing
        cmbSemester.SelectedItem = Nothing
        cmbProgramLevel.SelectedItem = Nothing
        cmbProgram.SelectedItem = Nothing
        cmbYear.SelectedItem = Nothing

    End Sub

    'Clear Data Method - ENDS

    'Handling User Interactions

    Private Sub btnInsertData_Click(sender As Object, e As EventArgs) Handles btnInsertData.Click

        Dim coursename As String = txtCourseName.Text
        Dim coursecode As String = txtCourseCode.Text
        Dim credithour As String = cmbCreditHour.SelectedItem
        Dim Programlevel As String = cmbProgramLevel.SelectedItem
        Dim ProgramName As String = cmbProgram.SelectedItem
        Dim Year As String = cmbYear.SelectedItem
        Dim semester As String = cmbSemester.SelectedItem

        InsertData(coursename, coursecode, credithour, Programlevel, ProgramName, Year, semester)
        ClearData()
        RefreshDataGridView()

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmCourse.Show()
        Me.Hide()
    End Sub


End Class