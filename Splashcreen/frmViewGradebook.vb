Imports System.Data.SQLite
Public Class frmViewGradebook

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

    Private Sub frmViewGradebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0

        'Reset the top description 
        lblProgram.Text = "All Students"
        lblSemester.Text = "First Semester"

    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Grade Data successful removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Failed to remove Grade Data unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method
    Private Function GetData() As Data.DataTable
        command.CommandText = "SELECT DISTINCT 
        sd.FirstName, 
        sd.LastName, 
        sd.StudentID, 
        sag.TotalCreditHours, 
        sag.SGPA, 
        sag.GradeComment, 
        gd1.Grade AS Grade1, 
        gd2.Grade AS Grade2, 
        gd3.Grade AS Grade3, 
        gd4.Grade AS Grade4, 
        gd5.Grade AS Grade5, 
        gd6.Grade AS Grade6, 
        gd7.Grade AS Grade7, 

        cd1.CourseCode AS CourseCode1, 
        cd2.CourseCode AS CourseCode2, 
        cd3.CourseCode AS CourseCode3, 
        cd4.CourseCode AS CourseCode4, 
        cd5.CourseCode AS CourseCode5, 
        cd6.CourseCode AS CourseCode6, 
        cd7.CourseCode AS CourseCode7

        FROM tblStoreAllGrades sag
        JOIN tblStudentData sd ON gd1.StudID = sd.StudID

        JOIN tblGradeData gd1 ON sag.Grade1 = gd1.GradeID
        JOIN tblGradeData gd2 ON sag.Grade2 = gd2.GradeID
        JOIN tblGradeData gd3 ON sag.Grade3 = gd3.GradeID
        JOIN tblGradeData gd4 ON sag.Grade4 = gd4.GradeID
        JOIN tblGradeData gd5 ON sag.Grade5 = gd5.GradeID
        JOIN tblGradeData gd6 ON sag.Grade6 = gd6.GradeID
        JOIN tblGradeData gd7 ON sag.Grade7 = gd7.GradeID

        JOIN tblCourseData cd1 ON gd1.CourseID = cd1.CourseID
        JOIN tblCourseData cd2 ON gd2.CourseID = cd2.CourseID
        JOIN tblCourseData cd3 ON gd3.CourseID = cd3.CourseID
        JOIN tblCourseData cd4 ON gd4.CourseID = cd4.CourseID
        JOIN tblCourseData cd5 ON gd5.CourseID = cd5.CourseID
        JOIN tblCourseData cd6 ON gd6.CourseID = cd6.CourseID
        JOIN tblCourseData cd7 ON gd7.CourseID = cd7.CourseID 
        LIMIT 7" '-- Added join condition for tblStudentData

        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable
    End Function


    'Auto Data Refresh Method - STARTS
    Private Sub RefreshDataGridView()
        dgvViewGradebook.DataSource = GetData()
        incrementedVariable()

        ' Set the initial columns you want at fixed display indices
        dgvViewGradebook.Columns("No").DisplayIndex = 0
        dgvViewGradebook.Columns("FirstName").DisplayIndex = 1
        dgvViewGradebook.Columns("LastName").DisplayIndex = 2
        dgvViewGradebook.Columns("StudentID").DisplayIndex = 3

        ' Set the course names as column headers and assign grades to specific courses
        For i As Integer = 1 To 7
            Dim columnName As String = "CourseCode" & i.ToString()
            Dim gradeColumnName As String = "Grade" & i.ToString()

            If dgvViewGradebook.Columns.Contains(columnName) Then
                dgvViewGradebook.Columns(columnName).HeaderText = dgvViewGradebook.Rows(0).Cells(columnName).Value.ToString()
                dgvViewGradebook.Columns(columnName).DataPropertyName = gradeColumnName
                dgvViewGradebook.Columns(columnName).DisplayIndex = i + 3 ' Adjust display index
            End If
        Next

        ' Set the indices for the remaining columns
        dgvViewGradebook.Columns("TCH").DisplayIndex = 18
        dgvViewGradebook.Columns("SGPA").DisplayIndex = 19
        dgvViewGradebook.Columns("Comment").DisplayIndex = 20
    End Sub


    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts

    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvViewGradebook.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvViewGradebook.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub


    'Search Button Logic Starts
    Public Sub ShowFilterResult(ProgramLevel As String, ProgramName As String, Year As Integer, Semester As String)

        If cmbSemester.SelectedIndex = 1 Then
            lblSemester.Text = "First Semester" 'Show semester indicator
            Dim searchQuery As String = "SELECT DISTINCT 
            sd.FirstName, 
            sd.LastName, 
            sd.StudentID, 
            sag.TotalCreditHours, 
            sag.SGPA, 
            sag.GradeComment, 
            gd1.Grade AS Grade1, 
            gd2.Grade AS Grade2, 
            gd3.Grade AS Grade3, 
            gd4.Grade AS Grade4, 
            gd5.Grade AS Grade5, 
            gd6.Grade AS Grade6, 
            gd7.Grade AS Grade7, 

            cd1.CourseCode AS CourseCode1, 
            cd2.CourseCode AS CourseCode2, 
            cd3.CourseCode AS CourseCode3, 
            cd4.CourseCode AS CourseCode4, 
            cd5.CourseCode AS CourseCode5, 
            cd6.CourseCode AS CourseCode6, 
            cd7.CourseCode AS CourseCode7
      
        FROM tblStoreAllGrades sag
        JOIN tblStudentData sd ON gd1.StudID = sd.StudID

        JOIN tblGradeData gd1 ON sag.Grade1 = gd1.GradeID
        JOIN tblGradeData gd2 ON sag.Grade2 = gd2.GradeID
        JOIN tblGradeData gd3 ON sag.Grade3 = gd3.GradeID
        JOIN tblGradeData gd4 ON sag.Grade4 = gd4.GradeID
        JOIN tblGradeData gd5 ON sag.Grade5 = gd5.GradeID
        JOIN tblGradeData gd6 ON sag.Grade6 = gd6.GradeID
        JOIN tblGradeData gd7 ON sag.Grade7 = gd7.GradeID

        JOIN tblCourseData cd1 ON gd1.CourseID = cd1.CourseID
        JOIN tblCourseData cd2 ON gd2.CourseID = cd2.CourseID
        JOIN tblCourseData cd3 ON gd3.CourseID = cd3.CourseID
        JOIN tblCourseData cd4 ON gd4.CourseID = cd4.CourseID
        JOIN tblCourseData cd5 ON gd5.CourseID = cd5.CourseID
        JOIN tblCourseData cd6 ON gd6.CourseID = cd6.CourseID
        JOIN tblCourseData cd7 ON gd7.CourseID = cd7.CourseID 
        LIMIT 7"

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
            dgvViewGradebook.DataSource = resultDataTable
            incrementedVariable()

            ' Set the initial columns you want at fixed display indices
            dgvViewGradebook.Columns("No").DisplayIndex = 0
            dgvViewGradebook.Columns("FirstName").DisplayIndex = 1
            dgvViewGradebook.Columns("LastName").DisplayIndex = 2
            dgvViewGradebook.Columns("StudentID").DisplayIndex = 3

            ' Set the course names as column headers and assign grades to specific courses
            For i As Integer = 1 To 7
                Dim columnName As String = "CourseCode" & i.ToString()
                Dim gradeColumnName As String = "Grade" & i.ToString()

                If dgvViewGradebook.Columns.Contains(columnName) Then
                    dgvViewGradebook.Columns(columnName).HeaderText = dgvViewGradebook.Rows(0).Cells(columnName).Value.ToString()
                End If

                dgvViewGradebook.Columns(columnName).DataPropertyName = gradeColumnName
                dgvViewGradebook.Columns(columnName).DisplayIndex = i + 3 ' Adjust display index

            Next

            ' Set the indices for the remaining columns
            dgvViewGradebook.Columns("TCH").DisplayIndex = 18
            dgvViewGradebook.Columns("SGPA").DisplayIndex = 19
            dgvViewGradebook.Columns("Comment").DisplayIndex = 20

        ElseIf cmbSemester.SelectedIndex = 2 Then

            lblSemester.Text = "Second Semester" 'Show semester indicator
            Dim searchQuery As String = "SELECT DISTINCT 
            sd.FirstName, 
            sd.LastName, 
            sd.StudentID, 
            sag.TotalCreditHours, 
            sag.SGPA, 
            sag.GradeComment,  
            gd8.Grade AS Grade8, 
            gd9.Grade AS Grade9, 
            gd10.Grade AS Grade10, 
            gd11.Grade AS Grade11, 
            gd12.Grade AS Grade12, 
            gd13.Grade AS Grade13, 
            gd14.Grade AS Grade14, 
      
            cd8.CourseCode AS CourseCode8, 
            cd9.CourseCode AS CourseCode9, 
            cd10.CourseCode AS CourseCode10, 
            cd11.CourseCode AS CourseCode11, 
            cd12.CourseCode AS CourseCode12, 
            cd13.CourseCode AS CourseCode13, 
            cd14.CourseCode AS CourseCode14

        FROM tblStoreAllGrades sag
        JOIN tblStudentData sd ON gd8.StudID = sd.StudID

        JOIN tblGradeData gd8 ON sag.Grade8 = gd8.GradeID
        JOIN tblGradeData gd9 ON sag.Grade9 = gd9.GradeID
        JOIN tblGradeData gd10 ON sag.Grade10 = gd10.GradeID
        JOIN tblGradeData gd11 ON sag.Grade11 = gd11.GradeID
        JOIN tblGradeData gd12 ON sag.Grade12 = gd12.GradeID
        JOIN tblGradeData gd13 ON sag.Grade13 = gd13.GradeID
        JOIN tblGradeData gd14 ON sag.Grade14 = gd14.GradeID

        JOIN tblCourseData cd8 ON gd8.CourseID = cd8.CourseID
        JOIN tblCourseData cd9 ON gd9.CourseID = cd9.CourseID
        JOIN tblCourseData cd10 ON gd10.CourseID = cd10.CourseID
        JOIN tblCourseData cd11 ON gd11.CourseID = cd11.CourseID
        JOIN tblCourseData cd12 ON gd12.CourseID = cd12.CourseID
        JOIN tblCourseData cd13 ON gd13.CourseID = cd13.CourseID
        JOIN tblCourseData cd14 ON gd14.CourseID = cd14.CourseID
        ORDER BY sag.AllGradesID DESC
        LIMIT 7"

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
            dgvViewGradebook.DataSource = resultDataTable
            incrementedVariable()

            ' Set the initial columns you want at fixed display indices
            dgvViewGradebook.Columns("No").DisplayIndex = 0
            dgvViewGradebook.Columns("FirstName").DisplayIndex = 1
            dgvViewGradebook.Columns("LastName").DisplayIndex = 2
            dgvViewGradebook.Columns("StudentID").DisplayIndex = 3

            ' Set the course names as column headers and assign grades to specific courses
            For i As Integer = 8 To 14
                Dim columnName As String = "CourseCode" & i.ToString()
                Dim gradeColumnName As String = "Grade" & i.ToString()

                If dgvViewGradebook.Columns.Contains(columnName) Then
                    dgvViewGradebook.Columns(columnName).HeaderText = dgvViewGradebook.Rows(0).Cells(columnName).Value.ToString()
                End If

                dgvViewGradebook.Columns(columnName).DataPropertyName = gradeColumnName
                dgvViewGradebook.Columns(columnName).DisplayIndex = i + 3 ' Adjust display index

            Next

            ' Set the indices for the remaining columns
            dgvViewGradebook.Columns("TCH").DisplayIndex = 18
            dgvViewGradebook.Columns("SGPA").DisplayIndex = 19
            dgvViewGradebook.Columns("Comment").DisplayIndex = 20

        Else
            ' Handle other cases (e.g., display an error message)
            MessageBox.Show("Invalid semester selection.")
        End If

    End Sub

    Private Sub btnFilterSearchF_Click(sender As Object, e As EventArgs) Handles btnFilterSearchF.Click

        Dim ProgramLevel As String = cmbSelectProgramLevel.SelectedItem
        Dim ProgramName As String = cmbSelectProgram.SelectedItem
        Dim Year As String = cmbSelectYear.SelectedItem
        Dim Semester As String = cmbSemester.SelectedItem

        'Change the top description to the selected Program and Year
        lblProgram.Text = ProgramLevel & " " & ProgramName & " " & Year

        ShowFilterResult(ProgramLevel, ProgramName, Year, Semester)

    End Sub

    Private Sub btnResetF_Click(sender As Object, e As EventArgs) Handles btnResetF.Click

        dgvViewGradebook.DataSource = GetData()
        incrementedVariable()

        ' Set the initial columns you want at fixed display indices
        dgvViewGradebook.Columns("No").DisplayIndex = 0
        dgvViewGradebook.Columns("FirstName").DisplayIndex = 1
        dgvViewGradebook.Columns("LastName").DisplayIndex = 2
        dgvViewGradebook.Columns("StudentID").DisplayIndex = 3

        ' Set the course names as column headers and assign grades to specific courses
        For i As Integer = 1 To 7
            Dim columnName As String = "CourseCode" & i.ToString()
            Dim gradeColumnName As String = "Grade" & i.ToString()

            If dgvViewGradebook.Rows.Count > 0 AndAlso dgvViewGradebook.Columns.Contains(columnName) Then
                Dim cellValue As Object = dgvViewGradebook.Rows(0).Cells(columnName).Value
                If cellValue IsNot Nothing Then
                    dgvViewGradebook.Columns(columnName).HeaderText = cellValue.ToString()
                    dgvViewGradebook.Columns(columnName).DataPropertyName = gradeColumnName
                    dgvViewGradebook.Columns(columnName).DisplayIndex = i + 3 ' Adjust display index
                End If
            End If

        Next

        ' Set the indices for the remaining columns
        dgvViewGradebook.Columns("TCH").DisplayIndex = 18
        dgvViewGradebook.Columns("SGPA").DisplayIndex = 19
        dgvViewGradebook.Columns("Comment").DisplayIndex = 20


        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0
        lblSemester.Text = "First Semester"

    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

End Class