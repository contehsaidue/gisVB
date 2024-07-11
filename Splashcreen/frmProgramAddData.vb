Imports System.Data.SQLite
Public Class frmProgramAddData

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

    Private Sub frmProgramAddData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProgramLevel.SelectedIndex = 0
        cmbProgram.SelectedIndex = 0

    End Sub


    'Response Messages Starts
    Private Sub ShowSuccessMessage()
        MessageBox.Show("Program created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Program creation unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Insert Method

    Private Sub InsertData(ByVal programlevel As String, ByVal programname As String)
        Dim insertQuery As String = "INSERT INTO tblProgramData (ProgramLevel, ProgramName) VALUES (@ProgramLevel, @ProgramName);"
        Using cmd As New SQLiteCommand(insertQuery, connection)
            cmd.Parameters.AddWithValue("@ProgramLevel", programlevel)
            cmd.Parameters.AddWithValue("@ProgramName", programname)

            If (cmd.ExecuteNonQuery() > 0) Then

                ShowSuccessMessage()
            Else
                ShowFailureMessage()
            End If

        End Using
    End Sub

    '02. Get Data Method

    Private Function GetData() As DataTable

        command.CommandText = "SELECT * FROM tblProgramData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function


    'Creating the CRUD METHODS - ENDS

    'Auto Data Refresh Method - STARTS

    Private Sub RefreshDataGridView()
        frmProgram.dgvProgramData.DataSource = GetData()
        incrementedVariable()
    End Sub

    'Auto Data Refresh Method - ENDS

    'Incremented Variable Starts
    Public Sub incrementedVariable()

        ' Get the number of rows in the DataGridView
        Dim rowCount As Integer = frmProgram.dgvProgramData.Rows.Count

        ' Loop through each row and assign incremented values to the "Number" column
        For i As Integer = 0 To rowCount - 1
            frmProgram.dgvProgramData.Rows(i).Cells("No").Value = i + 1
        Next

    End Sub

    'Incremented Variable Ends

    'Clear Data Method - STARTS

    Private Sub ClearData()

        cmbProgramLevel.SelectedItem = Nothing
        cmbProgram.SelectedItem = Nothing

    End Sub
    'Clear Data Method - ENDS

    'Handling User Interactions

    Private Sub btnInsertData_Click(sender As Object, e As EventArgs) Handles btnInsertData.Click

        Dim programlevel As String = cmbProgramLevel.SelectedItem
        Dim programname As String = cmbProgram.SelectedItem

        InsertData(programlevel, programname)
        ClearData()
        RefreshDataGridView()


    End Sub

    'Form Controls
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmProgram.Show()
        Me.Hide()
    End Sub

End Class