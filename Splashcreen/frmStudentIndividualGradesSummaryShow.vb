Imports System.Data.SQLite
Public Class frmStudentIndividualGradesSummaryShow

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
    Public Property StudentID As Integer
    Public Property academicYear As Integer = DateTime.Now.Year 'Get the current year as Academic year
    Public Property joinYear As Integer = 2019

    ' Method to set the data
    Public Sub SetData(column1Value As String)
        StudentID = Integer.Parse(column1Value)
    End Sub

    Private Sub frmStudentIndividualGradesSummaryShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabaseTable()
        GetStudentPersonalData(StudentID)
        RefreshStudentGradesDataGridView()

        cmbSelectYear.SelectedIndex = 0

        'Peform student automatic update 
        UpdateStudentYear(StudentID, academicYear, joinYear)
    End Sub

    'Creating the CRUD METHODS - STARTS

    '01. Get Method
    Private Sub GetStudentPersonalData(StudentID As Integer)
        Dim query As String = "SELECT Grade, tblGradeData.Semester, tblCourseData.CourseName, tblCourseData.Year, tblStudentData.FirstName, tblStudentData.LastName, 
        tblStudentData.StudentID,tblStudentData.ProgramLevel, tblStudentData.ProgramName, tblStudentData.Year FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
        JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID WHERE tblStudentData.StudentID = @StudentID ORDER BY tblGradeData.Semester ASC"

        Dim command As New SQLiteCommand(query, connection)
        command.Parameters.AddWithValue("@StudentID", StudentID) ' Pass the StudentID parameter

        Dim reader As SQLiteDataReader = command.ExecuteReader()

        While reader.Read()
            Dim value1 As String = reader.GetString(4)
            Dim value2 As String = reader.GetString(5)
            Dim value3 As Integer = reader.GetInt32(6)
            Dim value4 As String = reader.GetString(7)
            Dim value5 As String = reader.GetString(8)
            Dim value6 As Integer = reader.GetInt32(9)

            grpbGradeData.Text = value1 & " " & value2
            lblProgram.Text = value4 & " " & value5 & " " & "Year " & " " & value6
            lblStudentID.Text = value3

        End While

        reader.Close()
    End Sub

    Private Function GetStudentGradeData(ByVal StudentID As Integer) As Data.DataTable
        command.CommandText = "SELECT DISTINCT GradeID, Grade, tblGradeData.Semester, tblCourseData.CourseName, tblCourseData.CreditHour
                       FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
                       JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID
                       WHERE tblStudentData.StudentID = @StudentID
                       ORDER BY CASE tblGradeData.Semester
                           WHEN 'First' THEN 1
                           WHEN 'Second' THEN 2
                           END"
        command.Parameters.AddWithValue("@StudentID", StudentID)
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshStudentGradesDataGridView()

        dgvViewStudentSingleGradeData.DataSource = GetStudentGradeData(StudentID)
        incrementedVariable()

        dgvViewStudentSingleGradeData.Columns("No").DisplayIndex = 0
        dgvViewStudentSingleGradeData.Columns("CourseName").DisplayIndex = 1
        dgvViewStudentSingleGradeData.Columns("Grade").DisplayIndex = 2
        dgvViewStudentSingleGradeData.Columns("Semester").DisplayIndex = 3
        dgvViewStudentSingleGradeData.Columns("GradeWeight").DisplayIndex = 4

        ' Calculate SGPA and display
        CalculateAndDisplaySGPA()

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts

    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvViewStudentSingleGradeData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvViewStudentSingleGradeData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Calculating the SGPA for the student Starts

    Private Sub CalculateAndDisplaySGPA()

        Dim totalCreditHours As Integer = 0
        Dim totalGW As Double = 0

        For Each row As DataGridViewRow In dgvViewStudentSingleGradeData.Rows
            Dim letterGrade As String = row.Cells("Grade").Value.ToString()
            Dim creditHours As Integer = Convert.ToInt32(row.Cells("CreditHour").Value)

            Dim numericalWeight As Double = GetNumericalWeight(letterGrade)
            Dim gradeWeight As Double = numericalWeight * creditHours

            row.Cells("GradeWeight").Value = gradeWeight

            totalGW += gradeWeight
            totalCreditHours += creditHours
        Next

        Dim finalSGPA As Double = totalGW / totalCreditHours

        ' Display the final Data in selected controls
        lblSGPA.Text = finalSGPA.ToString("N2")
        lblTotalCreditHour.Text = totalCreditHours

        If finalSGPA >= 3.0 Then
            lblCommentValue.Text = "Pass"
        ElseIf finalSGPA < 3.0 Then
            lblCommentValue.Text = "Fail"
        Else
            lblCommentValue.Text = "Student Status"
        End If

    End Sub

    ' Helper function to convert letter grades to numerical weight values
    Private Function GetNumericalWeight(letterGrade As String) As Double

        ' Defining mapping from letter grades to numerical values

        Select Case letterGrade.ToUpper()
            Case "A"
                Return 5.0
            Case "B"
                Return 4.0
            Case "C"
                Return 3.0
            Case "D"
                Return 2.0
            Case "E"
                Return 1.0
            Case "F"
                Return 0.0
            Case Else
                Return 0.0
        End Select

    End Function

    '02. Calculating the SGPA for the Student Ends

    'Create database table If Not exist
    Private Sub CreateDatabaseTable()
        command.CommandText = "CREATE TABLE IF NOT EXISTS tblStoreAllGrades (
  AllGradesID INTEGER PRIMARY KEY AUTOINCREMENT,
  Grade1 INTEGER,
  Grade2 INTEGER,
  Grade3 INTEGER,
  Grade4 INTEGER,
  Grade5 INTEGER,
  Grade6 INTEGER,
  Grade7 INTEGER,
  Grade8 INTEGER,
  Grade9 INTEGER,
  Grade10 INTEGER,
  Grade11 INTEGER,
  Grade12 INTEGER,
  Grade13 INTEGER,
  Grade14 INTEGER,
  TotalCreditHours INTEGER,
  SGPA REAL,
  GradeComment TEXT,
  FOREIGN KEY (Grade1) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade2) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade3) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade4) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade5) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade6) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade7) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade8) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade9) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade10) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade11) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade12) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade13) REFERENCES tblGradeData(GradeID),
  FOREIGN KEY (Grade14) REFERENCES tblGradeData(GradeID))"

        command.ExecuteNonQuery()
    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Student All Grades Data successful Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Fail to save student grades!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowUpdateSuccessMessage()
        MessageBox.Show("Student All Grades Data successful Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowUpdateFailureMessage()
        MessageBox.Show("Fail to update student grades!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    '01. CRUD METHODS Starts
    Public Sub insertStudentGrade(grade1 As String, grade2 As String, grade3 As String, grade4 As String, grade5 As String, grade6 As String, grade7 As String, grade8 As String, grade9 As String, grade10 As String, grade11 As String, grade12 As String, grade13 As String, grade14 As String, TotalCreditHours As String, SGPA As String, GradeComment As String)

        Dim insertQuery As String = "INSERT INTO tblStoreAllGrades (Grade1, Grade2, Grade3, Grade4, Grade5, Grade6, Grade7,Grade8, Grade9, Grade10, Grade11, Grade12, Grade13, Grade14, TotalCreditHours, SGPA, GradeComment) VALUES (@Grade1, @Grade2, @Grade3, @Grade4, @Grade5, @Grade6, @Grade7, @Grade8, @Grade9, @Grade10, @Grade11, @Grade12, @Grade13, @Grade14, @TotalCreditHours, @SGPA, @GradeComment)"
        Dim insertCommand As New SQLiteCommand(insertQuery, connection)
        insertCommand.Parameters.AddWithValue("@Grade1", grade1)
        insertCommand.Parameters.AddWithValue("@Grade2", grade2)
        insertCommand.Parameters.AddWithValue("@Grade3", grade3)
        insertCommand.Parameters.AddWithValue("@Grade4", grade4)
        insertCommand.Parameters.AddWithValue("@Grade5", grade5)
        insertCommand.Parameters.AddWithValue("@Grade6", grade6)
        insertCommand.Parameters.AddWithValue("@Grade7", grade7)
        insertCommand.Parameters.AddWithValue("@Grade8", grade8)
        insertCommand.Parameters.AddWithValue("@Grade9", grade9)
        insertCommand.Parameters.AddWithValue("@Grade10", grade10)
        insertCommand.Parameters.AddWithValue("@Grade11", grade11)
        insertCommand.Parameters.AddWithValue("@Grade12", grade12)
        insertCommand.Parameters.AddWithValue("@Grade13", grade13)
        insertCommand.Parameters.AddWithValue("@Grade14", grade14)

        insertCommand.Parameters.AddWithValue("@TotalCreditHours", TotalCreditHours)
        insertCommand.Parameters.AddWithValue("@SGPA", SGPA)
        insertCommand.Parameters.AddWithValue("@GradeComment", GradeComment)

        If (insertCommand.ExecuteNonQuery() > 0) Then
            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If

    End Sub

    Public Sub updateStudentGrade(grade1 As String, grade2 As String, grade3 As String, grade4 As String, grade5 As String, grade6 As String, grade7 As String, grade8 As String, grade9 As String, grade10 As String, grade11 As String, grade12 As String, grade13 As String, grade14 As String, TotalCreditHours As String, SGPA As String, GradeComment As String, AllGradesID As Integer)
        Dim insertQuery As String = "UPDATE tblStoreAllGrades SET Grade1 = @Grade1, Grade2 = @Grade2, Grade3 = @Grade3, Grade4 = @Grade4, Grade5 = @Grade5, Grade6 = @Grade6, Grade7 = @Grade7, Grade8 = @Grade8, Grade9 = @Grade9, Grade10 = @Grade10, Grade11 = @Grade11, Grade12 = @Grade12, Grade13 = @Grade13, Grade14 = @Grade14, TotalCreditHours = @TotalCreditHours, SGPA = @SGPA, GradeComment = @GradeComment WHERE AllGradesID = @AllGradesID"
        Dim insertCommand As New SQLiteCommand(insertQuery, connection)
        insertCommand.Parameters.AddWithValue("@Grade1", grade1)
        insertCommand.Parameters.AddWithValue("@Grade2", grade2)
        insertCommand.Parameters.AddWithValue("@Grade3", grade3)
        insertCommand.Parameters.AddWithValue("@Grade4", grade4)
        insertCommand.Parameters.AddWithValue("@Grade5", grade5)
        insertCommand.Parameters.AddWithValue("@Grade6", grade6)
        insertCommand.Parameters.AddWithValue("@Grade7", grade7)
        insertCommand.Parameters.AddWithValue("@Grade8", grade8)
        insertCommand.Parameters.AddWithValue("@Grade9", grade9)
        insertCommand.Parameters.AddWithValue("@Grade10", grade10)
        insertCommand.Parameters.AddWithValue("@Grade11", grade11)
        insertCommand.Parameters.AddWithValue("@Grade12", grade12)
        insertCommand.Parameters.AddWithValue("@Grade13", grade13)
        insertCommand.Parameters.AddWithValue("@Grade14", grade14)
        insertCommand.Parameters.AddWithValue("@TotalCreditHours", TotalCreditHours)
        insertCommand.Parameters.AddWithValue("@SGPA", SGPA)
        insertCommand.Parameters.AddWithValue("@GradeComment", GradeComment)
        insertCommand.Parameters.AddWithValue("@AllGradesID", AllGradesID)

        If (insertCommand.ExecuteNonQuery() > 0) Then
            ShowUpdateSuccessMessage()
        Else
            ShowUpdateFailureMessage()
        End If

    End Sub

    '01. CRUD METHODS Ends 

    Private Sub btnSaveGrade_Click(sender As Object, e As EventArgs) Handles btnSaveGrade.Click

        If dgvViewStudentSingleGradeData.RowCount >= 10 Then

            Dim grade1 As String = dgvViewStudentSingleGradeData.Rows(0).Cells("GradeID").Value.ToString()
            Dim grade2 As String = dgvViewStudentSingleGradeData.Rows(1).Cells("GradeID").Value.ToString()
            Dim grade3 As String = dgvViewStudentSingleGradeData.Rows(2).Cells("GradeID").Value.ToString()
            Dim grade4 As String = dgvViewStudentSingleGradeData.Rows(3).Cells("GradeID").Value.ToString()
            Dim grade5 As String = dgvViewStudentSingleGradeData.Rows(4).Cells("GradeID").Value.ToString()
            Dim grade6 As String = dgvViewStudentSingleGradeData.Rows(5).Cells("GradeID").Value.ToString()
            Dim grade7 As String = dgvViewStudentSingleGradeData.Rows(6).Cells("GradeID").Value.ToString()
            Dim grade8 As String = dgvViewStudentSingleGradeData.Rows(7).Cells("GradeID").Value.ToString()
            Dim grade9 As String = dgvViewStudentSingleGradeData.Rows(8).Cells("GradeID").Value.ToString()
            Dim grade10 As String = dgvViewStudentSingleGradeData.Rows(9).Cells("GradeID").Value.ToString()
            Dim grade11 As String = dgvViewStudentSingleGradeData.Rows(10).Cells("GradeID").Value.ToString()
            Dim grade12 As String = dgvViewStudentSingleGradeData.Rows(11).Cells("GradeID").Value.ToString()
            Dim grade13 As String = dgvViewStudentSingleGradeData.Rows(10).Cells("GradeID").Value.ToString()
            Dim grade14 As String = dgvViewStudentSingleGradeData.Rows(11).Cells("GradeID").Value.ToString()

            Dim totalCreditHours As Integer = Integer.Parse(lblTotalCreditHour.Text)
            Dim sgpa As Double = Double.Parse(lblSGPA.Text)
            Dim gradeComment As String = lblCommentValue.Text

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want to save the final grades for this Student?", "Insert Student Final Grades", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then
                ' Code to execute when user chooses Yes
                insertStudentGrade(grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, grade9, grade10, grade11, grade12, grade13, grade14, totalCreditHours, sgpa, gradeComment)

            End If
        Else
            ' There are fewer Grades available in the DataGridView
            MessageBox.Show("There are fewer Grades available at the moment and cannot be added into the database just yet!.")

        End If

    End Sub

    Private Sub btnUpdateGrade_Click(sender As Object, e As EventArgs) Handles btnUpdateGrade.Click

        If dgvViewStudentSingleGradeData.RowCount >= 10 Then

            Dim grade1 As String = dgvViewStudentSingleGradeData.Rows(0).Cells("GradeID").Value.ToString()
            Dim grade2 As String = dgvViewStudentSingleGradeData.Rows(1).Cells("GradeID").Value.ToString()
            Dim grade3 As String = dgvViewStudentSingleGradeData.Rows(2).Cells("GradeID").Value.ToString()
            Dim grade4 As String = dgvViewStudentSingleGradeData.Rows(3).Cells("GradeID").Value.ToString()
            Dim grade5 As String = dgvViewStudentSingleGradeData.Rows(4).Cells("GradeID").Value.ToString()
            Dim grade6 As String = dgvViewStudentSingleGradeData.Rows(5).Cells("GradeID").Value.ToString()
            Dim grade7 As String = dgvViewStudentSingleGradeData.Rows(6).Cells("GradeID").Value.ToString()
            Dim grade8 As String = dgvViewStudentSingleGradeData.Rows(7).Cells("GradeID").Value.ToString()
            Dim grade9 As String = dgvViewStudentSingleGradeData.Rows(8).Cells("GradeID").Value.ToString()
            Dim grade10 As String = dgvViewStudentSingleGradeData.Rows(9).Cells("GradeID").Value.ToString()
            Dim grade11 As String = dgvViewStudentSingleGradeData.Rows(10).Cells("GradeID").Value.ToString()
            Dim grade12 As String = dgvViewStudentSingleGradeData.Rows(11).Cells("GradeID").Value.ToString()
            Dim grade13 As String = dgvViewStudentSingleGradeData.Rows(12).Cells("GradeID").Value.ToString()
            Dim grade14 As String = dgvViewStudentSingleGradeData.Rows(13).Cells("GradeID").Value.ToString()

            Dim totalCreditHours As Integer = Integer.Parse(lblTotalCreditHour.Text)
            Dim sgpa As Double = Double.Parse(lblSGPA.Text)
            Dim gradeComment As String = lblCommentValue.Text
            Dim AllGradesID As Integer = dgvViewStudentSingleGradeData.Rows(13).Cells("GradeID").Value.ToString()

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want to update the final grades for this Student?", "Update Final Grades", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then
                ' Code to execute when user chooses Yes
                updateStudentGrade(grade1, grade2, grade3, grade4, grade5, grade6, grade7, grade8, grade9, grade10, grade11, grade12, grade13, grade14, totalCreditHours, sgpa, gradeComment, StudentID)

            End If

        Else
            ' There are fewer Grades available in the DataGridView
            MessageBox.Show("There are fewer Grades available at the moment and cannot be added into the database just yet!.")

        End If

    End Sub

    '03. Filter Button Logic Starts
    Public Sub ShowFilterResult(StudentID As Integer, Year As Integer)
        Dim searchQuery As String = "SELECT DISTINCT GradeID, Grade, tblGradeData.Semester, tblCourseData.CourseName, tblCourseData.CreditHour
                        FROM tblGradeData 
                        JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
                        JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID
                        WHERE tblStudentData.StudentID = @StudentID AND tblCourseData.Year = @Year 
                        ORDER BY CASE tblGradeData.Semester
                           WHEN 'First' THEN 1
                           WHEN 'Second' THEN 2
                           END"

        Dim filterCmd As New SQLiteCommand(searchQuery, connection)

        ' Use parameterized query to avoid SQL injection
        filterCmd.Parameters.AddWithValue("@StudentID", StudentID)
        filterCmd.Parameters.AddWithValue("@Year", Year)

        Dim resultAdapter As New SQLiteDataAdapter
        resultAdapter.SelectCommand = filterCmd

        ' Create an instance of the DataTable class
        Dim resultDataTable As New Data.DataTable()
        resultAdapter.Fill(resultDataTable)

        dgvViewStudentSingleGradeData.DataSource = resultDataTable
        incrementedVariable()

        ' Set the display index of the columns
        dgvViewStudentSingleGradeData.Columns("No").DisplayIndex = 0
        dgvViewStudentSingleGradeData.Columns("CourseName").DisplayIndex = 1
        dgvViewStudentSingleGradeData.Columns("Grade").DisplayIndex = 2
        dgvViewStudentSingleGradeData.Columns("Semester").DisplayIndex = 3
        dgvViewStudentSingleGradeData.Columns("GradeWeight").DisplayIndex = 4

        ' Calculate SGPA and display
        CalculateAndDisplaySGPA()

    End Sub

    Private Sub btnFilterSearchF_Click(sender As Object, e As EventArgs) Handles btnFilterSearchF.Click

        Dim StudentIDvalue As Integer = StudentID
        Dim Year As String = cmbSelectYear.SelectedItem

        ShowFilterResult(StudentIDvalue, Year)

    End Sub

    Private Sub btnResetF_Click(sender As Object, e As EventArgs) Handles btnResetF.Click
        RefreshStudentGradesDataGridView()
        '...
        cmbSelectYear.SelectedIndex = 0
    End Sub

    '03. Filter Button Logic Ends

    '... Student automatic year functions

    '04. Function to calculate the current level based on the academic year
    Private Sub UpdateData(StudentID As Integer, Year As Integer)
        command.CommandText = "UPDATE tblStudentData SET Year = @Year WHERE StudentID = @StudentID"
        command.Parameters.AddWithValue("@StudentID", StudentID)
        command.Parameters.AddWithValue("@Year", Year)
        command.ExecuteNonQuery()
    End Sub

    Function CalculateStudentYear(academicYear As Integer, joinYear As Integer) As Integer
        Dim currentYear As Integer = DateTime.Now.Year
        Dim studentYear As Integer = currentYear - joinYear

        ' Adjust the level if the academic year is ahead of the current year
        If academicYear > currentYear Then
            studentYear -= academicYear - currentYear
        End If

        Return studentYear

    End Function

    '05. Update the student's level (Year) in the database
    Sub UpdateStudentYear(StudentID As Integer, academicYear As Integer, joinYear As Integer)

        Dim studentYear As Integer = CalculateStudentYear(academicYear, joinYear)

        If lblCommentValue.Text = "Pass" AndAlso dgvViewStudentSingleGradeData.RowCount >= 10 Then

            UpdateData(StudentID, studentYear)

        Else
            'Do nothing
        End If
        ' ...
    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmViewAllStudentGrade.Show()
        Me.Close()
    End Sub

End Class