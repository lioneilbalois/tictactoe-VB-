Public Class ulti_mec
    Dim id As Integer = 1
    Private Sub ultiBt_Click(sender As Object, e As EventArgs) Handles ultiBt.Click
        DirectCast(Controls.Find("u" & CStr(id), True)(0), PictureBox).Visible = False
        DirectCast(Controls.Find("u" & CStr(1), True)(0), PictureBox).Visible = True
        id = 1
        overLb.Text = "1"
        Me.Close()
    End Sub

    Private Sub leftBt_Click(sender As Object, e As EventArgs) Handles leftBt.Click
        If (id = 1) Then
            'do nothing
        Else
            DirectCast(Controls.Find("u" & CStr(id), True)(0), PictureBox).Visible = False
            id -= 1
            DirectCast(Controls.Find("u" & CStr(id), True)(0), PictureBox).Visible = True
            overLb.Text = id
        End If
    End Sub

    Private Sub rightBt_Click(sender As Object, e As EventArgs) Handles rightBt.Click
        If (id = 7) Then
            'do nothing
        Else
            DirectCast(Controls.Find("u" & CStr(id), True)(0), PictureBox).Visible = False
            id += 1
            DirectCast(Controls.Find("u" & CStr(id), True)(0), PictureBox).Visible = True
            overLb.Text = id
        End If
    End Sub
End Class