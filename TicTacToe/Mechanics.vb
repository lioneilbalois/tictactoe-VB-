Public Class Mechanics
    Dim id As Integer = 1
    Dim grp As Char = "b"
    Dim path As String = My.Application.Info.DirectoryPath

    Private Sub basicBt_Click(sender As Object, e As EventArgs) Handles basicBt.Click
        DirectCast(Controls.Find(grp & CStr(id), True)(0), PictureBox).Visible = False
        id = 1
        grp = "b"
        basicBt.FillColor = Color.IndianRed
        basicBt.ForeColor = Color.White
        ultiBt.FillColor = Color.White
        ultiBt.ForeColor = Color.Black
        overLb.Text = "1"
        totalLb.Text = "of 4"
        DirectCast(Controls.Find("b" & CStr(1), True)(0), PictureBox).Visible = True
        ultiPan.Visible = False
        basicPan.Visible = True
    End Sub

    Private Sub rightBt_Click(sender As Object, e As EventArgs) Handles rightBt.Click
        If (id = 4 And grp = "b") Or (id = 7 And grp = "u") Then
            'do nothing
        Else
            DirectCast(Controls.Find(grp & CStr(id), True)(0), PictureBox).Visible = False
            id += 1
            DirectCast(Controls.Find(grp & CStr(id), True)(0), PictureBox).Visible = True
            overLb.Text = id
        End If
    End Sub

    Private Sub ultiBt_Click(sender As Object, e As EventArgs) Handles ultiBt.Click
        DirectCast(Controls.Find(grp & CStr(id), True)(0), PictureBox).Visible = False
        id = 1
        grp = "u"
        ultiBt.FillColor = Color.IndianRed
        ultiBt.ForeColor = Color.White
        basicBt.FillColor = Color.White
        basicBt.ForeColor = Color.Black
        overLb.Text = "1"
        totalLb.Text = "of 7"
        DirectCast(Controls.Find("u" & CStr(1), True)(0), PictureBox).Visible = True
        basicPan.Visible = False
        ultiPan.Visible = True
        'u1.Visible = True
    End Sub

    Private Sub leftBt_Click(sender As Object, e As EventArgs) Handles leftBt.Click
        If (id = 1) Then
            'do nothing
        Else
            DirectCast(Controls.Find(grp & CStr(id), True)(0), PictureBox).Visible = False
            id -= 1
            DirectCast(Controls.Find(grp & CStr(id), True)(0), PictureBox).Visible = True
            overLb.Text = id
        End If
    End Sub
    Private Sub leftBt_MouseLeave(sender As Object, e As EventArgs) Handles leftBt.MouseLeave
        'when hover change
        'leftBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\arrow-pointing-to-left.png")
        leftBt.Load(IO.Path.Combine(path, "public/arrow-pointing-to-left.png"))
    End Sub
    Private Sub leftBt_MouseHover(sender As Object, e As EventArgs) Handles leftBt.MouseHover
        'when hover change
        'leftBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\left-hover.png")
        leftBt.Load(IO.Path.Combine(path, "public/left-hover.png"))
    End Sub
    Private Sub rightBt_MouseLeave(sender As Object, e As EventArgs) Handles rightBt.MouseLeave
        'when hover change
        'rightBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\arrow-pointing-to-right.png")
        rightBt.Load(IO.Path.Combine(path, "public/arrow-pointing-to-right.png"))
    End Sub
    Private Sub rightBt_MouseHover(sender As Object, e As EventArgs) Handles rightBt.MouseHover
        'when hover change
        'rightBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\right-hover.png")
        rightBt.Load(IO.Path.Combine(path, "public/right-hover.png"))
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class