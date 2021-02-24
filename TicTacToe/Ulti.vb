Public Class Ulti
    Dim turn As Boolean = True 'serves as switch, from x to o
    Dim i As Integer ' for blinking text 
    Public Function Checker(btnName)

        If String.IsNullOrEmpty(btnName.Text) Then
            ' "Contains Empty value or Null Value"

            ' check if whose turn is; true for X false for O
            If turn = True Then
                btnName.Text = "X"
                turn = False
            Else
                btnName.Text = "O"
                turn = True
            End If
        End If

        'Winning scenarios: 8
        If (((Button1.Text = Button2.Text) And (Button2.Text = Button3.Text)) And Button1.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button1.Text + " wins")

        ElseIf ((Button4.Text = Button5.Text) And (Button5.Text = Button6.Text) And Button5.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button4.Text + " wins")

        ElseIf ((Button7.Text = Button8.Text) And (Button8.Text = Button9.Text) And Button8.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button7.Text + " wins")

        ElseIf ((Button1.Text = Button6.Text) And (Button6.Text = Button9.Text) And Button9.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button1.Text + " wins")

        ElseIf ((Button2.Text = Button5.Text) And (Button5.Text = Button8.Text) And Button8.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button2.Text + " wins")

        ElseIf ((Button4.Text = Button3.Text) And (Button4.Text = Button7.Text) And Button7.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button4.Text + " wins")

        ElseIf ((Button1.Text = Button5.Text) And (Button5.Text = Button7.Text) And Button7.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button1.Text + " wins")

        ElseIf ((Button3.Text = Button5.Text) And (Button5.Text = Button9.Text) And Button9.Text <> "") Then
            Label2.Visible = True
            Label2.Text = Button1.Text
            MessageBox.Show(Button3.Text + " wins")
        End If

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'For blinking text, or on or off with the help of timer
        i += 1

        If i = 2 Then
            If turn = True Then
                lbWho.Text = "X-TURN"
            Else
                lbWho.Text = "O-TURN"
            End If

        ElseIf i = 9 Then
            lbWho.Text = ""
            i = 0

        End If
    End Sub
End Class
