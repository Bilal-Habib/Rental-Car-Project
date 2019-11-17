Public Class ExitMessage
    Private Sub cmdYes_Click(sender As Object, e As EventArgs) Handles cmdYes.Click
        Application.Exit()
    End Sub

    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        'Do Nothing
    End Sub
End Class