Public Class startForm

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles basicBt.Click
        nameAsk.modeLb.Text = "Basic"
        Me.Hide()
        Basic.Show()
        nameAsk.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ultiBt.Click
        nameAsk.modeLb.Text = "Ultimate"
        Me.Hide()
        Ulti.Show()
        nameAsk.ShowDialog()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles mechaBt.Click
        Me.Hide()
        Mechanics.basicBt.PerformClick()
        Mechanics.Show()
    End Sub

    Private Sub aboutBt_Click(sender As Object, e As EventArgs) Handles aboutBt.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub settingBt_Click(sender As Object, e As EventArgs) Handles settingBt.Click
        Me.Hide()
        setting.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim ask As DialogResult = MessageBox.Show("Yo sure, exit game?",
                            "Exit",
                            MessageBoxButtons.YesNo)

        If (ask = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class