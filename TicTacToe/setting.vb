Public Class setting
    Private Sub homePb_Click(sender As Object, e As EventArgs) Handles homePb.Click
        Me.Close()
        startForm.Show()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class