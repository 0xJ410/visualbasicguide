Imports System.Data.OleDb
Module DatabaseConnectionModule
    Public Function msaccessconnection() As OleDbConnection
        'locating the pathfile of the database.
        Return New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\VBDatabase.accdb")
    End Function
    'getting things ready...
    Public mscon As OleDbConnection = msaccessconnection()
    Public cmd As New OleDbCommand
    Public conadapter As New OleDbDataAdapter
    Public dtable As New DataTable
    Public result As String

    'reloading the data that has been connected to the database.
    Public Sub reloadingdata(ByVal oledb As String, ByVal datagridview As Object)
        Try
            mscon.Open()
            dtable = New DataTable
            With cmd
                .Connection = mscon
                .CommandText = oledb
            End With
            conadapter.SelectCommand = cmd
            conadapter.Fill(dtable)
            datagridview.DataSource = dtable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mscon.Close()
            conadapter.Dispose()
        End Try
    End Sub
End Module
