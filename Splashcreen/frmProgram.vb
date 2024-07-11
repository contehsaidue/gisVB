Imports System.Data.SQLite
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices

Public Class frmProgram

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

    Private Sub frmProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabaseTable()
        RefreshDataGridView()

    End Sub


    'Create database table if not exist
    Private Sub CreateDatabaseTable()

        command.CommandText = "CREATE TABLE IF NOT EXISTS tblProgramData (ProgramID INTEGER PRIMARY KEY AUTOINCREMENT, ProgramLevel TEXT, ProgramName TEXT)"
        command.ExecuteNonQuery()

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Course Data successful removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Failed to remove Course Data unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        command.CommandText = "SELECT ProgramID, ProgramLevel, ProgramName FROM tblProgramData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New Data.DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()

        dgvProgramData.DataSource = GetData()
        incrementedVariable()

        dgvProgramData.Columns("No").DisplayIndex = 0
        dgvProgramData.Columns("ProgramLevel").DisplayIndex = 1
        dgvProgramData.Columns("ProgramName").DisplayIndex = 2
        dgvProgramData.Columns("Edit").DisplayIndex = 3
        dgvProgramData.Columns("Delete").DisplayIndex = 4

    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = dgvProgramData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            dgvProgramData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    '02. Delete Method

    Private Sub DeleteData(ProgramID As Integer)
        command.CommandText = "DELETE FROM tblProgramData WHERE ProgramID = @ProgramID"
        command.Parameters.AddWithValue("@ProgramID", ProgramID)

        If (command.ExecuteNonQuery()) Then

            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If
    End Sub

    'Creating the CRUD METHODS - ENDS


    'User Interaction

    '01. Create Click : Starts

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmProgramAddData.Show()
    End Sub

    '01. Create Click : Ends

    'Datagridview Cell Controls
    Private Sub dgvProgramData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProgramData.CellContentClick


        ' Check if the clicked cell is in the button column
        If e.ColumnIndex = 1 AndAlso e.RowIndex >= 0 Then

            ' Perform action when button is clicked

            Dim selectedRow As DataGridViewRow = dgvProgramData.Rows(e.RowIndex)

            'Get the data from the cells
            Dim column1Value As String = selectedRow.Cells("ProgramID").Value.ToString()
            Dim column2Value As String = selectedRow.Cells("ProgramLevel").Value.ToString()
            Dim column3Value As String = selectedRow.Cells("ProgramName").Value.ToString()

            ' Create an instance of the target form
            Dim targetForm As New frmProgramUpdateData()

            ' Pass the data to the target form
            targetForm.SetData(column1Value, column2Value, column3Value)

            ' Show the target form
            targetForm.Show()

        ElseIf e.ColumnIndex = 2 AndAlso e.RowIndex >= 0 Then
            ' Perform action when button is clicked

            ' Display a question prompt and get user's choice
            Dim userChoice As DialogResult = MessageBox.Show("Do you want to delete this particular Program?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Check the user's choice and perform actions accordingly
            If userChoice = DialogResult.Yes Then
                ' Code to execute when user chooses Yes

                Dim selectedRow As DataGridViewRow = dgvProgramData.Rows(e.RowIndex)
                Dim dataFromRow As Integer = selectedRow.Cells("ProgramID").Value

                Dim id As Integer = dataFromRow
                ' ...
                DeleteData(id)
                RefreshDataGridView()

            End If
        End If


    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmDashboard.Show()
        Me.Close()
    End Sub

End Class