Public Class startForm

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles basicBt.Click
        nameAsk.modeLb.Text = "Basic"
        Me.Hide()
        nameAsk.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ultiBt.Click
        nameAsk.modeLb.Text = "Ultimate"
        Me.Hide()
        nameAsk.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles mechaBt.Click
        Me.Hide()
    End Sub

    Private Sub aboutBt_Click(sender As Object, e As EventArgs) Handles aboutBt.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub settingBt_Click(sender As Object, e As EventArgs) Handles settingBt.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class