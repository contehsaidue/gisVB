Imports System.Data.SQLite
Public Class frmGradeAddData

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
    Public Property LastName As String
    Public Property StudentID As Integer
    Public Property Year As Integer
    Public Property ProgramLevel As String
    Public Property ProgramName As String

    Dim selectedValue As Integer

    ' Method to set the data
    Public Sub SetData(column1Value As String, column2Value As String, column3Value As String, column4Value As String, column5Value As String, column6Value As String, column7Value As String)
        StudID = Integer.Parse(column1Value)
        FirstName = column2Value
        LastName = column3Value
        StudentID = Integer.Parse(column4Value)
        Year = Integer.Parse(column5Value)
        ProgramLevel = column6Value
        ProgramName = column7Value
    End Sub

    Private Sub frmGradeAddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display the data in the labels, textboxes, etc. on the TargetForm
        txtStudID.Text = StudID
        txtFName.Text = FirstName
        txtLName.Text = LastName
        txtStudentID.Text = StudentID

        ' To hide the textbox for Unique ID 
        txtStudID.Visible = False
        txtYear.Visible = False
        ' ...

        cmbSelectLetterGrade.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0
        GetCourseData(Year, ProgramLevel, ProgramName)

    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Student Grade successful entered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Fail to enter student grade!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Public Sub GetCourseData(Year As Integer, ProgramLevel As String,  ProgramName As String)
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

    Private Function GetData() As Data.DataTable
        command.CommandText = "SELECT StudID, FirstName, LastName, StudentID, Year, ProgramLevel, ProgramName FROM tblStudentData ORDER BY RANDOM() LIMIT 100"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable
    End Function

    'Auto Data Refresh Method - STARTS
    Private Sub RefreshDataGridView()

        frmGrade.dgvStudentGradeData.DataSource = GetData()
        incrementedVariable()

        frmGrade.dgvStudentGradeData.Columns("No").DisplayIndex = 0
        frmGrade.dgvStudentGradeData.Columns("FirstName").DisplayIndex = 1
        frmGrade.dgvStudentGradeData.Columns("LastName").DisplayIndex = 2
        frmGrade.dgvStudentGradeData.Columns("StudentID").DisplayIndex = 3
        frmGrade.dgvStudentGradeData.Columns("Year").DisplayIndex = 4
        frmGrade.dgvStudentGradeData.Columns("btnAdd").DisplayIndex = 5

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = frmGrade.dgvStudentGradeData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            frmGrade.dgvStudentGradeData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends


    '02. Update Method

    Private Sub InsertData(StudID As Integer, CourseID As Integer, Grade As String, Semester As String)

        Dim insertQuery As String = "INSERT INTO tblGradeData (StudID, CourseID, Grade, Semester) VALUES (@StudID, @CourseID, @Grade, @Semester);"
        Using cmd As New SQLiteCommand(insertQuery, connection)
            cmd.Parameters.AddWithValue("@StudID", StudID)
            cmd.Parameters.AddWithValue("@CourseID", CourseID)
            cmd.Parameters.AddWithValue("@Grade", Grade)
            cmd.Parameters.AddWithValue("@Semester", Semester)

            If (cmd.ExecuteNonQuery() > 0) Then

                ShowSuccessMessage()
            Else
                ShowFailureMessage()
            End If

        End Using

    End Sub


    'Clear Data Method - STARTS

    Private Sub ClearData()

        txtFName.Text = " "
        txtLName.Text = " "
        txtStudentID.Text = " "
        cmbCourse.SelectedItem = Nothing
        cmbSelectLetterGrade.SelectedItem = Nothing
        cmbSemester.SelectedItem = Nothing

    End Sub

    'Clear Data Method - ENDS

    Private Sub ChangeRowBGColor()
        ' Check if a row is selected.
        If frmGrade.dgvStudentGradeData.SelectedRows.Count > 0 Then
            ' Get the selected row.
            Dim selectedRow As DataGridViewRow = frmGrade.dgvStudentGradeData.SelectedRows(0)

            ' Change the background color of the selected row.
            selectedRow.DefaultCellStyle.BackColor = Color.Yellow ' Change to your desired color.
        Else
            MessageBox.Show("Please select a row first.")
        End If
    End Sub


    'Handling User Interactions

    Private Sub btnInsertData_Click(sender As Object, e As EventArgs) Handles btnInsertData.Click

        Dim StudID As Integer = txtStudID.Text
        Dim CourseID As Integer = cmbCourse.SelectedValue
        Dim Grade As String = cmbSelectLetterGrade.SelectedItem
        Dim Semester As String = cmbSemester.SelectedItem


        InsertData(StudID, CourseID, Grade, Semester)

        RefreshDataGridView()
        ClearData()
        ChangeRowBGColor()

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmGrade.Show()
        Me.Close()
    End Sub

End Class