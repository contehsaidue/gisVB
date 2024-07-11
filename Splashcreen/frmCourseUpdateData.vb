Imports System.Data.SQLite
Public Class frmCourseUpdateData

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
    Public Property CourseID As Integer
    Public Property CourseName As String
    Public Property CourseCode As String
    Public Property CreditHour As String
    Public Property ProgramLevel As String
    Public Property ProgramName As String
    Public Property Year As String
    Public Property Semester As String

    ' Method to set the data
    Public Sub SetData(column1Value As String, column2Value As String, column3Value As String, column4Value As String, column5Value As String, column6Value As String, column7Value As String, column8Value As String)
        CourseID = Integer.Parse(column1Value)
        CourseName = column2Value
        CourseCode = column3Value
        CreditHour = column4Value
        ProgramLevel = column5Value
        ProgramName = column6Value
        Year = column7Value
        Semester = column8Value
    End Sub

    Private Sub frmCourseUpdateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display the data in the labels, textboxes, etc. on the TargetForm
        txtID.Text = CourseID
        txtCourseName.Text = CourseName
        txtCourseCode.Text = CourseCode
        cmbCreditHour.SelectedItem = CreditHour
        cmbProgramLevel.SelectedItem = ProgramLevel
        cmbProgram.SelectedItem = ProgramName
        cmbYear.SelectedItem = Year
        cmbSemester.SelectedItem = Semester


        ' To hide the textbox for Unique ID 
        txtID.Visible = False

        ' ...

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Course Data updated successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Course Data update unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As DataTable

        command.CommandText = "SELECT * FROM tblCourseData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

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

    '02. Update Method

    Private Sub UpdateData(CourseID As Integer, CourseName As String, CourseCode As String, CreditHour As String, ProgramLevel As String, ProgramName As String, Year As String, Semester As String)
        command.CommandText = "UPDATE tblCourseData SET CourseName = @CourseName,  CourseCode = @CourseCode, CreditHour = @CreditHour, ProgramLevel = @ProgramLevel, ProgramName = @ProgramName, Year = @Year, Semester = @Semester WHERE CourseID = @CourseID"
        command.Parameters.AddWithValue("@CourseID", CourseID)
        command.Parameters.AddWithValue("@CourseName", CourseName)
        command.Parameters.AddWithValue("@CourseCode", CourseCode)
        command.Parameters.AddWithValue("@CreditHour", CreditHour)
        command.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        command.Parameters.AddWithValue("@ProgramName", ProgramName)
        command.Parameters.AddWithValue("@Year", Year)
        command.Parameters.AddWithValue("@Semester", Semester)

        If (command.ExecuteNonQuery() > 0) Then
            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If
    End Sub



    'Clear Data Method - STARTS

    Private Sub ClearData()
        txtCourseName.Text = ""
        txtCourseCode.Text = ""
        cmbCreditHour.SelectedIndex = Nothing
        cmbProgramLevel.SelectedItem = Nothing
        cmbProgram.SelectedItem = Nothing
        cmbYear.SelectedItem = Nothing
        cmbSemester.SelectedIndex = Nothing
    End Sub


    'Clear Data Method - ENDS


    'Handling User Interactions

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click

        Dim CourseID As Integer = txtID.Text
        Dim CourseName As String = txtCourseName.Text
        Dim CourseCode As String = txtCourseCode.Text
        Dim MreditHour As String = cmbCreditHour.SelectedItem
        Dim ProgramLevel As String = cmbProgramLevel.SelectedItem
        Dim ProgramName As String = cmbProgram.SelectedItem
        Dim Year As String = cmbYear.SelectedItem
        Dim Semester As String = cmbSemester.SelectedItem

        UpdateData(CourseID, CourseName, CourseCode, CreditHour, ProgramLevel, ProgramName, Year, Semester)
        ClearData()
        RefreshDataGridView()

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmCourse.Show()
        Me.Close()
    End Sub

End Class