Imports System.Data.SQLite
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Public Class frmGradeModify

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

    Private Sub frmViewGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshDataGridView()
        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0

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
        command.CommandText = "SELECT DISTINCT GradeID, Grade, tblGradeData.Semester,
    tblCourseData.CourseName, tblCourseData.Year, tblStudentData.FirstName, 
    tblStudentData.LastName, tblStudentData.StudentID, tblStudentData.ProgramLevel As ProgramLevel, tblStudentData.ProgramName As ProgramName 
    FROM tblGradeData 
    JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
    JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID 
    ORDER BY RANDOM()"

        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable
    End Function


    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()

        dgvViewStudentGradeData.DataSource = GetData()
        incrementedVariable()

        dgvViewStudentGradeData.Columns("No").DisplayIndex = 0
        dgvViewStudentGradeData.Columns("FirstName").DisplayIndex = 1
        dgvViewStudentGradeData.Columns("LastName").DisplayIndex = 2
        dgvViewStudentGradeData.Columns("StudentID").DisplayIndex = 3
        dgvViewStudentGradeData.Columns("CourseName").DisplayIndex = 4
        dgvViewStudentGradeData.Columns("Grade").DisplayIndex = 5
        dgvViewStudentGradeData.Columns("Semester").DisplayIndex = 6
        dgvViewStudentGradeData.Columns("Edit").DisplayIndex = 7
        dgvViewStudentGradeData.Columns("Delete").DisplayIndex = 8

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts

    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvViewStudentGradeData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvViewStudentGradeData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Delete Method

    Private Sub DeleteData(GradeID As Integer)
        command.CommandText = "DELETE FROM tblGradeData WHERE GradeID = @GradeID"
        command.Parameters.AddWithValue("@GradeID", GradeID)

        If (command.ExecuteNonQuery() > 0) Then

            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If
    End Sub

    'Creating the CRUD METHODS - ENDS


    'Handling User Interaction

    '01. Create Click : Starts with Datagrid Cellcontent click event

    Private Sub dgvViewStudentGradeData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewStudentGradeData.CellContentClick

        ' Check if the clicked cell is in the button column
        If e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then

            ' Perform action when button is clicked

            Dim selectedRow As DataGridViewRow = dgvViewStudentGradeData.Rows(e.RowIndex)

            'Get the data from the cells

            Dim column1Value As String = selectedRow.Cells("GradeID").Value.ToString()
            Dim column2Value As String = selectedRow.Cells("FirstName").Value.ToString()
            Dim column3Value As String = selectedRow.Cells("LastName").Value.ToString()
            Dim column4Value As String = selectedRow.Cells("StudentID").Value.ToString()
            Dim column5Value As String = selectedRow.Cells("CourseName").Value.ToString()
            Dim column6Value As String = selectedRow.Cells("Grade").Value.ToString()
            Dim column7Value As String = selectedRow.Cells("Year").Value.ToString()
            Dim column8Value As String = selectedRow.Cells("Semester").Value.ToString()
            Dim column9Value As String = selectedRow.Cells("ProgramLevel").Value.ToString()
            Dim column10Value As String = selectedRow.Cells("ProgramName").Value.ToString()
            ' Create an instance of the target form
            Dim targetForm As New frmGradeUpdateData()

            ' Pass the data to the target form

            targetForm.SetData(column1Value, column2Value, column3Value, column4Value, column5Value, column6Value, column7Value, column8Value, column9Value, column10Value)

            ' Show the target form
            targetForm.Show()

        ElseIf e.ColumnIndex = 3 AndAlso e.RowIndex >= 0 Then
            ' Perform action when button is clicked

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want To delete this particular Grade?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then
                ' Code to execute when user chooses Yes

                Dim selectedRow As DataGridViewRow = dgvViewStudentGradeData.Rows(e.RowIndex)
                Dim dataFromRow As Integer = selectedRow.Cells("GradeID").Value

                Dim id As Integer = dataFromRow
                ' ...
                DeleteData(id)
                RefreshDataGridView()

            End If

        End If

    End Sub

    '01. Create Click : Ends with Datagrid Cellcontent click event


    '02. Excel Export Click : Starts

    Private Sub btnExportGradeExcel_Click(sender As Object, e As EventArgs) Handles btnExportGradeExcel.Click

        ' Display a question prompt and get user's choice
        Dim userChoice As DialogResult = MessageBox.Show("Do you want To Export Student Grades?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice and perform actions accordingly
        If userChoice = DialogResult.Yes Then
            ' Code to execute when user chooses Yes


            ' Initialize Excel application
            Dim excelApp As New Application()
            Dim workbook As Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Worksheet = workbook.Sheets(1)

            Dim sqlQuery As String = "Select Grade, tblCourseData.CourseName, tblStudentData.FirstName, tblStudentData.LastName, tblStudentData.StudentID
                               FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
                               JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID"

            Using command As New SQLiteCommand(sqlQuery, connection)

                Dim reader As SQLiteDataReader = command.ExecuteReader()

                    'Write column headers to Excel

                    For colIndex As Integer = 0 To reader.FieldCount - 1
                        worksheet.Cells(1, colIndex + 1) = reader.GetName(colIndex)
                    Next

                    ' Write data to Excel
                    Dim rowIndex As Integer = 2
                    While reader.Read()
                        For colIndex As Integer = 0 To reader.FieldCount - 1
                            worksheet.Cells(rowIndex, colIndex + 1) = reader(colIndex).ToString()
                        Next
                        rowIndex += 1
                    End While

                reader.Close() 'pay close attention, when not properly closed, will result to database locked

            End Using

            ' Save Excel file
            Dim excelFilePath As String = "Grades.xlsx"
            workbook.SaveAs(excelFilePath)

            ' Clean up

            ' After saving and before quitting
            workbook.Close(False)
            Marshal.ReleaseComObject(workbook)

            excelApp.Quit()
            Marshal.ReleaseComObject(excelApp)

            ' Release COM objects
            ReleaseComObject(worksheet)

            MessageBox.Show("Student Grades succesfully exported!")
        Else
            ' Code to execute when user chooses No or closes the prompt
        End If

    End Sub

    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    '02. Excel Export Click : Ends


    '03. PDF Export Click : Starts
    Private Sub btnExportToPDF_Click(sender As Object, e As EventArgs) Handles btnExportToPDF.Click

        ' Display a question prompt and get user's choice
        Dim userChoice As DialogResult = MessageBox.Show("Do you want to Export Student Grades in PDF Format?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's choice and perform actions accordingly
        If userChoice = DialogResult.Yes Then
            ' Code to execute when user chooses Yes

            ExportToPDF()

        End If

    End Sub

    ' Define a function to export to PDF
    Sub ExportToPDF()

        ' Create a new document
        Dim doc As New Document()
        Dim pdfFilePath As String = "C:\Users\Saidu\Desktop\Grades.pdf"
        Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfFilePath, FileMode.Create))

        ' Open the document
        doc.Open()

        ' Query data from the database
        Dim query As String = "SELECT Grade, tblCourseData.CourseName, tblStudentData.FirstName, tblStudentData.LastName, tblStudentData.StudentID
                               FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
                               JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID"
        Dim command As New SQLiteCommand(query, connection)
        Dim reader As SQLiteDataReader = command.ExecuteReader()

        ' Create a table in the PDF document
        Dim table As New PdfPTable(reader.FieldCount)
        While reader.Read()
            For i As Integer = 0 To reader.FieldCount - 1
                table.AddCell(reader(i).ToString())
            Next
        End While

        ' Add the table to the document
        doc.Add(table)

        ' Close the document
        doc.Close()
        connection.Close() 'pay attention

    End Sub

    '03. PDF Export Click : Ends


    'Search Button Logic Starts

    Public Sub ShowFilterResult(ProgramLevel As String, ProgramName As String, Year As Integer, Semester As String)

        Dim searchQuery As String = "SELECT DISTINCT GradeID, Grade, tblGradeData.Semester,
        tblCourseData.CourseName, tblCourseData.Year, tblStudentData.FirstName, 
        tblStudentData.LastName, tblStudentData.StudentID, tblStudentData.ProgramLevel As ProgramLevel, tblStudentData.ProgramName As ProgramName 
        FROM tblGradeData JOIN tblCourseData ON tblGradeData.CourseID = tblCourseData.CourseID
        JOIN tblStudentData ON tblGradeData.StudID = tblStudentData.StudID
        WHERE tblStudentData.ProgramLevel LIKE '%' || @ProgramLevel || '%' AND tblStudentData.ProgramName LIKE '%' || @ProgramName || '%' AND tblStudentData.Year LIKE '%' || @Year || '%'  AND tblGradeData.Semester LIKE '%' || @Semester || '%'
        ORDER BY CASE tblGradeData.Semester
        WHEN 'First' THEN 1
        WHEN 'Second' THEN 2
        END"

        Dim filterCmd As New SQLiteCommand(searchQuery, connection)

        ' Use parameterized query to avoid SQL injection
        filterCmd.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        filterCmd.Parameters.AddWithValue("@ProgramName", ProgramName)
        filterCmd.Parameters.AddWithValue("@Year", Year)
        filterCmd.Parameters.AddWithValue("@Semester", Semester)

        Dim resultAdapter As New SQLiteDataAdapter

        resultAdapter.SelectCommand = filterCmd

        ' Create an instance of the DataTable class
        Dim resultDataTable As New Data.DataTable()

        resultAdapter.Fill(resultDataTable)
        dgvViewStudentGradeData.DataSource = resultDataTable
        incrementedVariable()

        '...

        dgvViewStudentGradeData.Columns("No").DisplayIndex = 0
        dgvViewStudentGradeData.Columns("FirstName").DisplayIndex = 1
        dgvViewStudentGradeData.Columns("LastName").DisplayIndex = 2
        dgvViewStudentGradeData.Columns("StudentID").DisplayIndex = 3
        dgvViewStudentGradeData.Columns("CourseName").DisplayIndex = 4
        dgvViewStudentGradeData.Columns("Grade").DisplayIndex = 5
        dgvViewStudentGradeData.Columns("Semester").DisplayIndex = 6
        dgvViewStudentGradeData.Columns("Edit").DisplayIndex = 7
        dgvViewStudentGradeData.Columns("Delete").DisplayIndex = 8

    End Sub

    Private Sub btnFilterSearchD_Click(sender As Object, e As EventArgs) Handles btnFilterSearchD.Click

        Dim ProgramLevel As String = cmbSelectProgramLevel.SelectedItem
        Dim ProgramName As String = cmbSelectProgram.SelectedItem
        Dim Year As String = cmbSelectYear.SelectedItem
        Dim Semester As String = cmbSemester.SelectedItem

        ShowFilterResult(ProgramLevel, ProgramName, Year, Semester)

    End Sub
    Private Sub btnResetD_Click(sender As Object, e As EventArgs) Handles btnResetD.Click

        RefreshDataGridView()
        '...
        cmbSelectProgramLevel.SelectedIndex = 0
        cmbSelectProgram.SelectedIndex = 0
        cmbSelectYear.SelectedIndex = 0
        cmbSemester.SelectedIndex = 0

    End Sub

    'Search Button Logic Ends

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

End Class