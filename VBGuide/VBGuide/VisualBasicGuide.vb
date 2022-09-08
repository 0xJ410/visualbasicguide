Imports System.Data.OleDb
Public Class VisualBasicGuide
    Private Sub VBForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loading the sub loaddata()
        loaddata()
    End Sub
    'connecting combobox to the database
    Sub loaddata()
        Try

            reloadingdata("SELECT * FROM VBGuideDatabase ORDER BY WordName ASC", LOG)


            LOG.DataSource = dtable
            LOG.DisplayMember = "WordName"
            LOG.ValueMember = "WordName"

        Catch ex As Exception

        End Try
    End Sub
    'connecting the textboxes to the database and combobox
    Private Sub LOG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOG.SelectedIndexChanged
        Try

            Dim slct As String
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter

            msaccessconnection.Open()

            slct = "SELECT * FROM VBGuideDatabase WHERE WordName LIKE '%" & LOG.Text & "%'"
            cmd.Connection = mscon
            cmd.CommandText = slct
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DefinitionBox.Text = dt.Rows(0).Item("DefinitionField").ToString
                CodeBox.Text = dt.Rows(0).Item("SourceCodeField").ToString
                ExampleBox.Text = dt.Rows(0).Item("ExampleField").ToString
            End If

            If CodeBox.Text = "" Then
                CodeBox.Text = "No source code included."
            End If

            If DefinitionBox.Text = "" Then
                DefinitionBox.Text = "No definitions included."
            End If

            If ExampleBox.Text = "" Then
                ExampleBox.Text = "No examples included."
            End If


        Catch ex As Exception
        Finally
            mscon.Close()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'copying the text that are in a textbox.
        My.Computer.Clipboard.SetText(CodeBox.Text)
        MsgBox("Copied successfully.")

    End Sub
    Private Sub VBForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'stop running in background
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DarkModeButton.Click
        'Dark Mode Feature

        Me.BackColor = Color.Black
        DefinitionBox.BackColor = Color.DarkGray
        CodeBox.BackColor = Color.DarkGray
        ExampleBox.BackColor = Color.DarkGray
        LOGLabel.ForeColor = Color.White
        VisualBasicText.ForeColor = Color.White

        DarkModeButton.Hide()
        LightModeButton.Show()

    End Sub

    Private Sub LightModeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LightModeButton.Click
        'Light Mode Feature

        Me.BackColor = Color.White
        DefinitionBox.BackColor = Color.WhiteSmoke
        CodeBox.BackColor = Color.WhiteSmoke
        ExampleBox.BackColor = Color.WhiteSmoke
        LOGLabel.ForeColor = Color.Black
        VisualBasicText.ForeColor = Color.Black

        LightModeButton.Hide()
        DarkModeButton.Show()
    End Sub
End Class