Imports System.Data.SQLite
Imports Microsoft.Office.Interop.Excel

Public Class frmStudent

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

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabaseTable()
        RefreshDataGridView()

        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0

    End Sub

    'Create database table if not exist
    Private Sub CreateDatabaseTable()
        'command.CommandText = "DROP TABLE tblStudentData"
        command.CommandText = "CREATE TABLE IF NOT EXISTS tblStudentData (StudID INTEGER PRIMARY KEY AUTOINCREMENT, FirstName TEXT, MiddleName TEXT, LastName TEXT, StudentID INTEGER, ProgramLevel TEXT, ProgramName TEXT, Year INTEGER, joinYear INTEGER)"
        command.ExecuteNonQuery()

    End Sub

    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Student Data successful removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Failed to remove Student Data unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowSuccessMessageImport()
        MessageBox.Show("Student Data successful Imported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessageImport()
        MessageBox.Show("Failed to Import Student Data!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As Data.DataTable

        command.CommandText = "SELECT * FROM tblStudentData ORDER BY RANDOM()"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

    'Auto Data Refresh Method - STARTS
    Private Sub RefreshDataGridView()

        dgvStudentData.DataSource = GetData()
        incrementedVariable()

        dgvStudentData.Columns("No").DisplayIndex = 0
        dgvStudentData.Columns("FirstName").DisplayIndex = 1
        dgvStudentData.Columns("MiddleName").DisplayIndex = 2
        dgvStudentData.Columns("LastName").DisplayIndex = 3
        dgvStudentData.Columns("StudentID").DisplayIndex = 4
        dgvStudentData.Columns("programLevel").DisplayIndex = 5
        dgvStudentData.Columns("programName").DisplayIndex = 6
        dgvStudentData.Columns("year").DisplayIndex = 7
        dgvStudentData.Columns("Edit").DisplayIndex = 8
        dgvStudentData.Columns("Delete").DisplayIndex = 9

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvStudentData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvStudentData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Delete Method

    Private Sub DeleteData(StudID As Integer)
        command.CommandText = "DELETE FROM tblStudentData WHERE StudID = @StudID"
        command.Parameters.AddWithValue("@StudID", StudID)

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

        frmStudentAddData.Show()

    End Sub

    '01. Create Click : Ends

    '02. Excel Import Click : Starts
    Private Sub btnImportFromExcel_Click(sender As Object, e As EventArgs) Handles btnImportFromExcel.Click

        ' Display a question prompt and get user's choice
        Dim userChoice As DialogResult = MessageBox.Show("Do you want to Import New Data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice and perform actions accordingly
        If userChoice = DialogResult.Yes Then
            ' Code to execute when user chooses Yes

            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx"
            openFileDialog.Title = "Select an Excel File"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim excelApp As New Application()
                Dim workbook As Workbook = excelApp.Workbooks.Open(openFileDialog.FileName)
                Dim worksheet As Worksheet = workbook.Sheets(1) ' Assuming you want to read from the first sheet


                ' Loop through rows and columns to read data
                Dim row As Integer = 1
                While Not String.IsNullOrEmpty(worksheet.Cells(row, 1).Value)

                    Dim column1Value As String = worksheet.Cells(row, 2).Value
                    Dim column2Value As String = worksheet.Cells(row, 3).Value
                    Dim column3Value As String = worksheet.Cells(row, 4).Value
                    Dim column4Value As String = worksheet.Cells(row, 5).Value


                    ' Insert data into the database using appropriate methods
                    InsertDataIntoDatabase(column1Value, column2Value, column3Value, column4Value)

                    row += 1

                End While

                workbook.Close(False)
                excelApp.Quit()
                ReleaseObject(worksheet)
                ReleaseObject(workbook)
                ReleaseObject(excelApp)

            End If
        End If
    End Sub

    Private Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub InsertDataIntoDatabase(column1Value As String, column2Value As String, column3Value As String, column4Value As Integer)
        ' Code to insert data into the database

        Dim insertCommand As SQLiteCommand

        insertCommand = New SQLiteCommand("INSERT INTO tblStudentData (FirstName, MiddleName, LastName, StudentID) VALUES (@FName, @MName, @LName, @StudentID)", connection)
        insertCommand.Parameters.AddWithValue("@FName", column1Value)
        insertCommand.Parameters.AddWithValue("@MName", column2Value)
        insertCommand.Parameters.AddWithValue("@LName", column3Value)
        insertCommand.Parameters.AddWithValue("@StudentID", column4Value)

        If (insertCommand.ExecuteNonQuery() > 0) Then

            ShowSuccessMessageImport()
        Else
            ShowFailureMessageImport()
        End If

    End Sub

    '02. Excel Import Click : Ends

    'Datagrid view Cell Controls

    Private Sub dgvStudentData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentData.CellContentClick

        ' Check if the clicked cell is in the button column
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then

            ' Perform action when button is clicked

            Dim selectedRow As DataGridViewRow = dgvStudentData.Rows(e.RowIndex)

            'Get the data from the cells
            Dim column1Value As String = selectedRow.Cells("StudID").Value.ToString()
            Dim column2Value As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim column3Value As String = selectedRow.Cells("MiddleName").Value.ToString()
            Dim column4Value As String = selectedRow.Cells("LastName").Value.ToString()
            Dim column5Value As String = selectedRow.Cells("StudentID").Value.ToString()
            Dim column6Value As String = selectedRow.Cells("ProgramLevel").Value.ToString()
            Dim column7Value As String = selectedRow.Cells("ProgramName").Value.ToString()
            Dim column8Value As String = selectedRow.Cells("Year").Value.ToString()

            ' Create an instance of the target form
            Dim targetForm As New frmStudentUpdateData()

            ' Pass the data to the target form
            targetForm.SetData(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value, column8Value)

            ' Show the target form
            targetForm.Show()

        ElseIf e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then
            ' Perform action when button is clicked

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want to delete this particular Student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then
                ' Code to execute when user chooses Yes

                Dim selectedRow As DataGridViewRow = dgvStudentData.Rows(e.RowIndex)
                Dim dataFromRow As Integer = selectedRow.Cells("StudID").Value

                Dim id As Integer = dataFromRow
                ' ...
                DeleteData(id)
                RefreshDataGridView()

            End If
        End If

    End Sub

    'Search Button Logic Starts

    Public Sub ShowFilterResult(ProgramLevel As String, ProgramName As String, Year As Integer)

        Dim searchQuery As String = "SELECT * FROM tblStudentData WHERE ProgramLevel LIKE '%' || @ProgramLevel || '%' AND ProgramName LIKE '%' || @ProgramName || '%' AND Year LIKE '%' || @Year || '%'"
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
        dgvStudentData.DataSource = resultDataTable
        incrementedVariable()

    End Sub

    Private Sub btnFilterSearch_Click(sender As Object, e As EventArgs) Handles btnFilterSearch.Click

        Dim ProgramLevel As String = cmbSelectProgramLevel.SelectedItem
        Dim ProgramName As String = cmbSelectProgram.SelectedItem
        Dim Year As String = cmbSelectYear.SelectedItem

        ShowFilterResult(ProgramLevel, programName, year)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        RefreshDataGridView()
        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0

    End Sub

    'Search Button Logic Ends

    'Form Controls
    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click

        frmDashboard.Show()
        Me.Close()

    End Sub

End Class