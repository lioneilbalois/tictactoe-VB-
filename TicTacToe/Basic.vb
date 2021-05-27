Public Class Basic
    Dim turn As Boolean = True 'serves as switch, from x to o
    Dim nround As Integer = 1 'current round no.
    Dim path As String = My.Application.Info.DirectoryPath

    Public Function Checker(btnName)

        If String.IsNullOrEmpty(btnName.Text) Then
            'can only be used if picked tile is empty

            ' check if whose turn is; true for X false for O
            If turn = True Then
                btnName.Text = "X"
                lbWho.Text = "O-TURN"
                turn = False
            Else
                btnName.Text = "O"
                lbWho.Text = "X-TURN"
                turn = True
            End If
        End If
        'check if draw
        draw()
        'Winning scenarios: 8
        If (((Button1.Text = Button2.Text) And (Button2.Text = Button3.Text)) And Button1.Text <> "") Then
            ender(Button1.Text)

        ElseIf ((Button4.Text = Button5.Text) And (Button5.Text = Button6.Text) And Button5.Text <> "") Then
            ender(Button4.Text)

        ElseIf ((Button7.Text = Button8.Text) And (Button8.Text = Button9.Text) And Button8.Text <> "") Then
            ender(Button7.Text)

        ElseIf ((Button1.Text = Button6.Text) And (Button6.Text = Button9.Text) And Button9.Text <> "") Then
            ender(Button1.Text)

        ElseIf ((Button2.Text = Button5.Text) And (Button5.Text = Button8.Text) And Button8.Text <> "") Then
            ender(Button2.Text)

        ElseIf ((Button4.Text = Button3.Text) And (Button4.Text = Button7.Text) And Button7.Text <> "") Then
            ender(Button4.Text)

        ElseIf ((Button1.Text = Button5.Text) And (Button5.Text = Button7.Text) And Button7.Text <> "") Then
            ender(Button1.Text)

        ElseIf ((Button3.Text = Button5.Text) And (Button5.Text = Button9.Text) And Button9.Text <> "") Then
            ender(Button3.Text)
        End If
    End Function
    Public Function draw()
        For i As Integer = 1 To 9
            If (DirectCast(Controls.Find("Button" & CStr(i), True)(0), Button).Text) = "" Then
                Exit Function
            End If
        Next
        lbWho.Text = ""
        winpop.mode = "B"
        winpop.roundLb.Text = String.Format("Round {0} Winner:", nround)
        winpop.winrLb.Text = "-- Draw --"
        winpop.ShowDialog()
    End Function
    Public Function ender(who)

        'Timer1.Stop()
        lbWho.Text = ""
        If who = "X" Then
            p1Lb.Text = CInt(p1Lb.Text) + 1
        ElseIf who = "O" Then
            p2LB.Text = CInt(p2LB.Text) + 1
        End If

        winpop.mode = "B"
        winpop.roundLb.Text = String.Format("Round {0} Winner:", nround)
        If (p1name.Text = "P1 -") Then
            winpop.winrLb.Text = If(who = "X", "Player 1", "Player 2")
        Else
            winpop.winrLb.Text = If(who = "X", p1name.Text, p2name.Text)
        End If
        winpop.ShowDialog()
    End Function

    Public Function reset()
        'clear tiles' values
        For Each txt In {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button9, Button8}
            txt.Text = ""
        Next

        'set first turn on the next round, even round for O-player
        If (nround Mod 2 = 0) Then
            turn = False
            lbWho.Text = "O-TURN"
        Else
            turn = True
            lbWho.Text = "X-TURN"
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Checker(Button1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Checker(Button2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Checker(Button3)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Checker(Button6)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Checker(Button5)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Checker(Button4)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Checker(Button9)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Checker(Button8)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Checker(Button7)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles homePb.Click
        Dim ask As DialogResult = MessageBox.Show("Current game progress will not be save, go to main menu?",
                            "Exit to Main Menu",
                            MessageBoxButtons.YesNo)

        If (ask = DialogResult.Yes) Then
            Me.Close()
            startForm.Show()
        End If
    End Sub

    Private Sub helpPb_Click(sender As Object, e As EventArgs) Handles helpPb.Click
        'show instruction
        basic_mec.ShowDialog()
    End Sub

    Private Sub resetPb_Click(sender As Object, e As EventArgs) Handles resetPb.Click
        'reset current round
        Dim ask As DialogResult = MessageBox.Show("Yo sure? Reset tiles?",
                            "Reset",
                            MessageBoxButtons.YesNo)

        If (ask = DialogResult.Yes) Then
            reset()
        End If
    End Sub

    Public Function incr()
        nround += 1 'to increment round, or winpop to access nround
    End Function

    Private Sub drawPb_Click(sender As Object, e As EventArgs) Handles drawPb.Click
        'draw, increment round to change first turn
        Dim ask As DialogResult = MessageBox.Show("Yo sure? Accept draw?",
                            "Draw",
                            MessageBoxButtons.YesNo)

        If (ask = DialogResult.Yes) Then
            nround += 1
            reset()
        End If
    End Sub
    Private Sub drawPb_MouseHover(sender As Object, e As EventArgs) Handles drawPb.MouseHover
        'when hover change
        drawPb.Load(IO.Path.Combine(path, "public/shake2hover.png"))
        'drawPb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\shake2hover.png")
        ToolTip1.Show("Draw", helpPb, New Point(40, 110), 2000)
    End Sub

    Private Sub drawPb_MouseLeave(sender As Object, e As EventArgs) Handles drawPb.MouseLeave
        'when hover change
        drawPb.Load(IO.Path.Combine(path, "public/shake2.png"))
        'drawPb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\shake2.png")
    End Sub
    Private Sub helpPb_MouseHover(sender As Object, e As EventArgs) Handles helpPb.MouseHover
        'when hover change
        helpPb.Load(IO.Path.Combine(path, "public/question-mark-hv.png"))
        'helpPb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\question-mark-hv.png")
        ToolTip1.Show("Help", helpPb, New Point(40, 30), 2000)
    End Sub
    Private Sub helpPb_MouseLeave(sender As Object, e As EventArgs) Handles helpPb.MouseLeave
        'when hover change
        helpPb.Load(IO.Path.Combine(path, "public/question-mark.png"))
        'helpPb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\question-mark.png")
    End Sub
    Private Sub resetPb_MouseHover(sender As Object, e As EventArgs) Handles resetPb.MouseHover
        'when hover change
        resetPb.Load(IO.Path.Combine(path, "public/update-arrow-hv.png"))
        'resetPb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\update-arrow-hv.png")
        ToolTip1.Show("Reset", helpPb, New Point(40, 70), 2000)
    End Sub
    Private Sub resetPb_MouseLeave(sender As Object, e As EventArgs) Handles resetPb.MouseLeave
        'when hover change
        resetPb.Load(IO.Path.Combine(path, "public/update-arrow.png"))
        'resetPb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\update-arrow.png")
    End Sub

    Private Sub homePb_MouseHover(sender As Object, e As EventArgs) Handles homePb.MouseHover
        'when hover change
        homePb.Load(IO.Path.Combine(path, "public/homepage-hv.png"))
        'homePb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\homepage-hv.png")
        ToolTip1.Show("Home", helpPb, New Point(-355, 30), 2000)
    End Sub
    Private Sub homePb_MouseLeave(sender As Object, e As EventArgs) Handles homePb.MouseLeave
        'when hover change
        homePb.Load(IO.Path.Combine(path, "public/homepage.png"))
        'homePb.Load("C:\Users\Lioneil\Documents\GitHub\tictactoe\icons\homepage.png")
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class
