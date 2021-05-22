﻿Public Class Mechanics
    Dim id As Integer = 1
    Dim grp As Char = "b"

    Private Sub basicBt_Click(sender As Object, e As EventArgs) Handles basicBt.Click
        id = 1
        grp = "b"
        basicBt.FillColor = Color.IndianRed
        basicBt.ForeColor = Color.White
        ultiBt.FillColor = Color.White
        ultiBt.ForeColor = Color.Black
        overLb.Text = "1"
        totalLb.Text = "of 4"
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
        id = 1
        grp = "u"
        ultiBt.FillColor = Color.IndianRed
        ultiBt.ForeColor = Color.White
        basicBt.FillColor = Color.White
        basicBt.ForeColor = Color.Black
        overLb.Text = "1"
        totalLb.Text = "of 7"
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
        leftBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\arrow-pointing-to-left.png")
    End Sub
    Private Sub leftBt_MouseHover(sender As Object, e As EventArgs) Handles leftBt.MouseHover
        'when hover change
        leftBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\left-hover.png")
    End Sub
    Private Sub rightBt_MouseLeave(sender As Object, e As EventArgs) Handles rightBt.MouseLeave
        'when hover change
        rightBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\arrow-pointing-to-right.png")
    End Sub
    Private Sub rightBt_MouseHover(sender As Object, e As EventArgs) Handles rightBt.MouseHover
        'when hover change
        rightBt.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\right-hover.png")
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.Hide()
        homePb.Visible = True
        Guna2ControlBox2.Visible = True
        id = 1
        grp = "b"
        Me.Close()
    End Sub
End Class