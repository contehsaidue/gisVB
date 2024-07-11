Imports System.Data.SQLite
Public Class frmProgramUpdateData

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
    Public Property ProgramID As Integer
    Public Property ProgramLevel As String
    Public Property ProgramName As String


    ' Method to set the data
    Public Sub SetData(column1Value As String, column2Value As String, column3Value As String)
        ProgramID = Integer.Parse(column1Value)
        ProgramLevel = column2Value
        ProgramName = column3Value
    End Sub

    Private Sub frmProgramUpdateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display the data in the labels, textboxes, etc. on the TargetForm
        txtID.Text = ProgramID
        cmbProgramLevel.SelectedItem = ProgramLevel
        cmbProgram.SelectedItem = ProgramName

        ' To hide the textbox for Unique ID 
        txtID.Visible = False

        ' ...

    End Sub


    'Response Messages Starts

    Private Sub ShowSuccessMessage()
        MessageBox.Show("Program Data updated successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowFailureMessage()
        MessageBox.Show("Course Data update unsuccessful!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'Response Messages Ends

    'Creating the CRUD METHODS - STARTS

    '01. Get Method

    Private Function GetData() As DataTable

        command.CommandText = "SELECT * FROM tblProgramData"
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)
        Return dataTable

    End Function

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


    '02. Update Method

    Private Sub UpdateData(ProgramID As Integer, ProgramLevel As String, ProgramName As String)
        command.CommandText = "UPDATE tblProgramData SET ProgramLevel = @ProgramLevel,  ProgramName = @ProgramName WHERE ProgramID = @ProgramID"
        command.Parameters.AddWithValue("@ProgramID", ProgramID)
        command.Parameters.AddWithValue("@ProgramLevel", ProgramLevel)
        command.Parameters.AddWithValue("@ProgramName", ProgramName)

        If (command.ExecuteNonQuery() > 0) Then

            ShowSuccessMessage()
        Else
            ShowFailureMessage()
        End If

    End Sub


    'Clear Data Method - STARTS

    Private Sub ClearData()
        cmbProgramLevel.SelectedItem = Nothing
        cmbProgram.SelectedItem = Nothing
    End Sub

    'Clear Data Method - ENDS

    'Handling User Interactions

    Private Sub btnUpdateData_Click(sender As Object, e As EventArgs) Handles btnUpdateData.Click

        Dim ProgramID As Integer = txtID.Text
        Dim ProgramLevel As String = cmbProgramLevel.SelectedItem
        Dim ProgramName As String = cmbProgram.SelectedItem

        UpdateData(ProgramID, ProgramLevel, ProgramName)
        ClearData()
        RefreshDataGridView()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmProgram.Show()
        Me.Close()
    End Sub
End Class