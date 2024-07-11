Imports System.Data.SQLite
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.WinForms
Public Class frmDashboard

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
    Public Property userId As Integer

    Public Sub SetData(column1Value As String)
        userId = Integer.Parse(column1Value)
    End Sub
    Private Sub frmDashboardLecturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CaptureUniqueUserData(userId)
        InitializeChart()
        StartUpdatingChart()

        'Dashboard Shortcut rowCount Values Starts 
        Dim tableName1 As String = "tblStudentData"
        'btnDBStudent.Text = "Students " & " " & GetRowCount(tableName1)

        Dim tableName2 As String = "tblProgramData"
        'btnDBProgram.Text = "Programs " & " " & GetRowCount(tableName2)

        Dim tableName3 As String = "tblCourseData"
        'btnDBCourse.Text = "Courses " & " " & GetRowCount(tableName3)

        Dim tableName4 As String = "tblGradeData"
        'btnDBGrade.Text = "Grades " & " " & GetRowCount(tableName4)

        'Dashboard Shortcut rowCount Values Ends

        cmbUserAccount.SelectedIndex = 0

        Dim currentYear As Integer = DateTime.Now.Year
        lblAcademicYear.Text = currentYear

    End Sub

    Public Sub CaptureUniqueUserData(userId As Integer)
        Dim query As String = "SELECT * FROM tblUserData WHERE UserID = @userID"

        Using command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@userID", userId)

            Dim reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim fname As String = reader.GetString(1)
                Dim lname As String = reader.GetString(2)
                Dim userrole As String = reader.GetString(6)
                Dim imgPath As String = Convert.ToString(reader.GetValue(7))

                lblUserFullName.Text = $"{fname} {lname}"
                lblUserRole.Text = userrole

                If Not String.IsNullOrEmpty(imgPath) AndAlso IO.File.Exists(imgPath) Then
                    UserPictureBox.Image = Image.FromFile(imgPath)
                Else
                    ' Handle the case where the image path is empty or invalid
                    UserPictureBox.Image = Nothing
                End If
            End If
            reader.Close()
        End Using
    End Sub



    Private WithEvents timer As New Timer() ' Timer for generating random data
    Private chartValues As New ChartValues(Of Double)()

    'Data Charts Values Starts 
    Private Sub InitializeChart()

        ' Create a cartesian chart and add it to the panel
        Dim cartesianChart As New WinForms.CartesianChart()
        pnlPerformanceAnalysis.Controls.Add(cartesianChart)

        ' Customize chart appearance (optional)
        cartesianChart.Dock = DockStyle.Fill
        cartesianChart.Series = New SeriesCollection From {New LineSeries With {
            .Values = chartValues
        }}
    End Sub

    Private Sub StartUpdatingChart()
        timer.Interval = 1000 ' Update every second
        timer.Start()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Add random data point to the chart
        Dim randomValue As Double = New Random().NextDouble() * 100
        chartValues.Add(randomValue)

        ' Keep a fixed number of data points (optional)
        If chartValues.Count > 10 Then
            chartValues.RemoveAt(0)
        End If
    End Sub


    'Data Charts Values Ends 

    'Form button Controls Starts
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

        frmStudent.Show()
        Me.Close()

    End Sub
    Private Sub btnProgram_Click(sender As Object, e As EventArgs) Handles btnProgram.Click
        frmProgram.Show()
        Me.Close()
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click

        frmCourse.Show()
        Me.Close()

    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        frmGrade.Show()
        Me.Close()

    End Sub

    Private Sub btnViewStudentGrade_Click(sender As Object, e As EventArgs) Handles btnModifyStudentGrade.Click

        frmGradeModify.Show()
        Me.Close()

    End Sub

    Private Sub btnStudentGradeSummary_Click(sender As Object, e As EventArgs) Handles btnViewAllStudentGrade.Click
        frmViewAllStudentGrade.Show()
        Me.Close()

    End Sub

    Private Sub btnViewGradebook_Click(sender As Object, e As EventArgs) Handles btnViewGradebook.Click
        frmViewGradebook.Show()
        Me.Close()
    End Sub

    'Form button Controls Ends


    'Dashboard Shortcut Links Starts
    'Public Function GetRowCount(tableName As String) As Integer
    'Dim query As String = $"SELECT COUNT(*) FROM {tableName};"
    'Using command As New SQLiteCommand(query, connection)
    'Dim RowCountValue As Integer = CInt(command.ExecuteScalar())
    'Return RowCountValue
    'End Using
    'End Function

    Private Sub btnDBStudent_Click(sender As Object, e As EventArgs) Handles btnDBStudent.Click
        frmStudent.Show()
        Me.Close()
    End Sub
    Private Sub btnDBReport_Click(sender As Object, e As EventArgs) Handles btnDBProgram.Click
        frmProgram.Show()
        Me.Close()
    End Sub

    Private Sub btnDBCourse_Click(sender As Object, e As EventArgs) Handles btnDBCourse.Click
        frmCourse.Show()
        Me.Close()
    End Sub

    Private Sub btnDBGrade_Click(sender As Object, e As EventArgs) Handles btnDBGrade.Click
        frmViewAllStudentGrade.Show()
        Me.Close()
    End Sub

    'Dashboard Shortcut Links Ends

    'User Utility Settings Starts : Account
    Private Sub cmbUserAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserAccount.SelectedIndexChanged

        Dim selectedOption As String = cmbUserAccount.SelectedItem.ToString()

        If selectedOption = "User Profile" Then

            Dim targertForm As New frmUpdateUserProfile(userId)
            targertForm.Show()

        ElseIf selectedOption = "Logout" Then

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want to continue with logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then

                ' Code to execute when user chooses Yes
                frmLogin.Show()
                Me.Close()

            End If

        End If

    End Sub

    'User Utility Settings Ends

End Class