Public Class nameAsk
    Private Sub playBt_Click(sender As Object, e As EventArgs) Handles playBt.Click
        If (p1Tb.Text = "" And p2Tb.Text = "") Then
            'dont play without getting the names
            MessageBox.Show("Please enter names or press skip..", "Play Error")
            Exit Sub
        End If
        skipBt_Click(sender, e)
    End Sub

    Private Sub nameAsk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Console.WriteLine(modeLb.Text) 'record moves
    End Sub
    Private Sub skipBt_Click(sender As Object, e As EventArgs) Handles skipBt.Click
        Me.Hide()
        p1Tb.Text = ""
        p2Tb.Text = ""
        If (modeLb.Text = "Basic") Then
            Basic.Show()
        Else
            Ulti.Show()
        End If
    End Sub

    Private Sub backBt_Click(sender As Object, e As EventArgs) Handles backBt.Click
        Me.Close()
        startForm.Show()
    End Sub
End Class