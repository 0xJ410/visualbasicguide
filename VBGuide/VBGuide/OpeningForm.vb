Public Class OpeningForm
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        Me.Hide()
        VisualBasicGuide.Show()
    End Sub
    Private Sub OpeningForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppVersionLabel.Text = System.Windows.Forms.Application.ProductVersion
    End Sub

    Private Sub HelpButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpButton2.Click
        MsgBox("This is an app dedicated for users that are trying to know the Visual Basic programming language but also has the basic knowledge of the programming, it includes the basic codes, definition and many more.")
    End Sub

    Private Sub HelpButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpButton1.Click
        MsgBox("The original Visual Basic is a third-generation event-driven programming language from Microsoft known for its Component Object Model programming model first released in 1991 and declared legacy during 2008. Microsoft intended Visual Basic to be relatively easy to learn and use.")
    End Sub
    Private Sub OpeningForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
