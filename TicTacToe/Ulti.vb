Public Class Ulti
    Dim turn As Boolean = True 'serves as switch, from x to o
    Dim i As Integer ' for blinking text 
    Dim val(9, 9) As Char 'holds the value of the smallest box (group, specific box)
    Public Function director(place)

        'reset color of current grp
        Me.Controls("GroupBox" & place(0)).BorderColor = Color.Transparent

        'highlight which block where the next player will move
        Me.Controls("GroupBox" & place(1)).BorderColor = Color.Black

        'RESTRICT: turn off other buttons/groupbox
        'dont turn off destination:
        Dim grp As Integer = CInt(place) Mod 10

        For gid As Integer = 1 To 9
            If (gid = grp) Then
                'Continue For
                'enable
                Me.Controls("GroupBox" & gid.ToString).Controls.OfType(Of Button).All(Function(b)

                                                                                          b.Enabled = True
                                                                                          Return True

                                                                                      End Function)
            Else
                'disable all buttons under a groupbox aside from the gid - var that holds block destination
                Me.Controls("GroupBox" & gid.ToString).Controls.OfType(Of Button).All(Function(b)

                                                                                          b.Enabled = False
                                                                                          Return True

                                                                                      End Function)
            End If
        Next
    End Function
    Public Function getVal(loc)
        Return DirectCast(Controls.Find("bt" & loc, True)(0), Button).Text
    End Function

    Public Function MiniChecker(grp)

        Dim pb As String = "pb" + CStr(grp) 'picture box name for winned grp

        'check if the group Is won, Winning scenarios: 8
        If ((val(grp, 1) = val(grp, 2)) And (val(grp, 2) = val(grp, 3)) And val(grp, 1) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 1)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 6) = val(grp, 5)) And (val(grp, 5) = val(grp, 4)) And val(grp, 6) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 6)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 9) = val(grp, 8)) And (val(grp, 8) = val(grp, 7)) And val(grp, 9) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 9)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 1) = val(grp, 6)) And (val(grp, 6) = val(grp, 9)) And val(grp, 6) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 6)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 2) = val(grp, 5)) And (val(grp, 5) = val(grp, 8)) And val(grp, 8) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 8)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 3) = val(grp, 4)) And (val(grp, 4) = val(grp, 7)) And val(grp, 3) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 3)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 1) = val(grp, 5)) And (val(grp, 5) = val(grp, 7)) And val(grp, 7) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 7)), True)(0), PictureBox).Visible = True

        ElseIf ((val(grp, 3) = val(grp, 5)) And (val(grp, 5) = val(grp, 9)) And val(grp, 9) <> "") Then
            DirectCast(Controls.Find(pb & LCase(val(grp, 9)), True)(0), PictureBox).Visible = True
        End If

    End Function

    Public Function Checker(btnName, ind)
        'get button address
        Dim grp As Integer = Integer.Parse(ind(0).ToString)
        Dim id As Integer = Integer.Parse(ind(1).ToString)

        'check if button is still empty
        If String.IsNullOrEmpty(btnName.Text) Then

            'check whose turn it is; true for X false for O
            If turn = True Then
                btnName.Text = "X"
                lbWho.Text = "O-TURN"
                turn = False
                val(grp, id) = "X" 'store to val array
            Else
                btnName.Text = "O"
                lbWho.Text = "X-TURN"
                turn = True
                val(grp, id) = "0" 'store to val array
            End If
        End If

        'check if certain 3x3 box is won
        MiniChecker(grp)

        'REWORK THIS
        'Winning scenarios as a whole: 8
        'If (((lb1.Text = lb2.Text) And (lb2.Text = lb3.Text)) And lb1.Text <> "") Then
        '    MessageBox.Show(lb1.Text + " wins")

        'ElseIf (((lb6.Text = lb5.Text) And (lb5.Text = lb4.Text)) And lb6.Text <> "") Then
        '    MessageBox.Show(lb6.Text + " wins")

        'ElseIf (((lb7.Text = lb8.Text) And (lb8.Text = lb9.Text)) And lb7.Text <> "") Then
        '    MessageBox.Show(lb7.Text + " wins")

        'ElseIf (((lb1.Text = lb6.Text) And (lb6.Text = lb9.Text)) And lb1.Text <> "") Then
        '    MessageBox.Show(lb1.Text + " wins")

        'ElseIf (((lb2.Text = lb5.Text) And (lb5.Text = lb8.Text)) And lb2.Text <> "") Then
        '    MessageBox.Show(lb2.Text + " wins")

        'ElseIf (((lb3.Text = lb4.Text) And (lb4.Text = lb7.Text)) And lb3.Text <> "") Then
        '    MessageBox.Show(lb3.Text + " wins")

        'ElseIf (((lb1.Text = lb5.Text) And (lb5.Text = lb7.Text)) And lb1.Text <> "") Then
        '    MessageBox.Show(lb1.Text + " wins")

        'ElseIf (((lb3.Text = lb5.Text) And (lb5.Text = lb9.Text)) And lb3.Text <> "") Then
        '    MessageBox.Show(lb3.Text + " wins")
        'End If

        director(ind)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt11.Click
        Checker(bt11, "11")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bt12.Click
        Checker(bt12, "12")
        GroupBox1.BorderColor = Color.Transparent
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bt13.Click
        Checker(bt13, "13")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles bt16.Click
        Checker(bt16, "16")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles bt15.Click
        Checker(bt15, "15")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bt14.Click
        Checker(bt14, "14")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles bt19.Click
        Checker(bt19, "19")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles bt18.Click
        Checker(bt18, "18")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles bt17.Click
        Checker(bt17, "17")
    End Sub

    Private Sub bt21_Click(sender As Object, e As EventArgs) Handles bt21.Click
        Checker(bt21, "21")
    End Sub
    Private Sub bt22_Click(sender As Object, e As EventArgs) Handles bt22.Click
        Checker(bt22, "22")
    End Sub
    Private Sub bt23_Click(sender As Object, e As EventArgs) Handles bt23.Click
        Checker(bt23, "23")
    End Sub
    Private Sub bt24_Click(sender As Object, e As EventArgs) Handles bt24.Click
        Checker(bt24, "24")
    End Sub
    Private Sub bt25_Click(sender As Object, e As EventArgs) Handles bt25.Click
        Checker(bt25, "25")
    End Sub
    Private Sub bt26_Click(sender As Object, e As EventArgs) Handles bt26.Click
        Checker(bt26, "26")
    End Sub
    Private Sub bt27_Click(sender As Object, e As EventArgs) Handles bt27.Click
        Checker(bt27, "27")
    End Sub
    Private Sub bt28_Click(sender As Object, e As EventArgs) Handles bt28.Click
        Checker(bt28, "28")
    End Sub
    Private Sub bt29_Click(sender As Object, e As EventArgs) Handles bt29.Click
        Checker(bt29, "29")
    End Sub
    Private Sub bt31_Click(sender As Object, e As EventArgs) Handles bt31.Click
        Checker(bt31, "31")
    End Sub
    Private Sub bt32_Click(sender As Object, e As EventArgs) Handles bt32.Click
        Checker(bt32, "32")
    End Sub
    Private Sub bt33_Click(sender As Object, e As EventArgs) Handles bt33.Click
        Checker(bt33, "33")
    End Sub
    Private Sub bt34_Click(sender As Object, e As EventArgs) Handles bt34.Click
        Checker(bt34, "34")
    End Sub
    Private Sub bt35_Click(sender As Object, e As EventArgs) Handles bt35.Click
        Checker(bt35, "35")
    End Sub
    Private Sub bt36_Click(sender As Object, e As EventArgs) Handles bt36.Click
        Checker(bt36, "36")
    End Sub
    Private Sub bt37_Click(sender As Object, e As EventArgs) Handles bt37.Click
        Checker(bt37, "37")
    End Sub
    Private Sub bt38_Click(sender As Object, e As EventArgs) Handles bt38.Click
        Checker(bt38, "38")
    End Sub
    Private Sub bt39_Click(sender As Object, e As EventArgs) Handles bt39.Click
        Checker(bt39, "39")
    End Sub
    Private Sub bt41_Click(sender As Object, e As EventArgs) Handles bt41.Click
        Checker(bt41, "41")
    End Sub
    Private Sub bt42_Click(sender As Object, e As EventArgs) Handles bt42.Click
        Checker(bt42, "42")
    End Sub
    Private Sub bt43_Click(sender As Object, e As EventArgs) Handles bt43.Click
        Checker(bt43, "43")
    End Sub
    Private Sub bt44_Click(sender As Object, e As EventArgs) Handles bt44.Click
        Checker(bt44, "44")
    End Sub
    Private Sub bt45_Click(sender As Object, e As EventArgs) Handles bt45.Click
        Checker(bt45, "45")
    End Sub
    Private Sub bt46_Click(sender As Object, e As EventArgs) Handles bt46.Click
        Checker(bt46, "46")
    End Sub
    Private Sub bt47_Click(sender As Object, e As EventArgs) Handles bt47.Click
        Checker(bt47, "47")
    End Sub
    Private Sub bt48_Click(sender As Object, e As EventArgs) Handles bt48.Click
        Checker(bt48, "48")
    End Sub
    Private Sub bt49_Click(sender As Object, e As EventArgs) Handles bt49.Click
        Checker(bt49, "49")
    End Sub
    Private Sub bt51_Click(sender As Object, e As EventArgs) Handles bt51.Click
        Checker(bt51, "51")
    End Sub
    Private Sub bt52_Click(sender As Object, e As EventArgs) Handles bt52.Click
        Checker(bt52, "52")
    End Sub
    Private Sub bt53_Click(sender As Object, e As EventArgs) Handles bt53.Click
        Checker(bt53, "53")
    End Sub
    Private Sub bt54_Click(sender As Object, e As EventArgs) Handles bt54.Click
        Checker(bt54, "54")
    End Sub
    Private Sub bt55_Click(sender As Object, e As EventArgs) Handles bt55.Click
        Checker(bt55, "55")
    End Sub
    Private Sub bt56_Click(sender As Object, e As EventArgs) Handles bt56.Click
        Checker(bt56, "56")
    End Sub
    Private Sub bt57_Click(sender As Object, e As EventArgs) Handles bt57.Click
        Checker(bt57, "57")
    End Sub
    Private Sub bt58_Click(sender As Object, e As EventArgs) Handles bt58.Click
        Checker(bt58, "58")
    End Sub
    Private Sub bt59_Click(sender As Object, e As EventArgs) Handles bt59.Click
        Checker(bt59, "59")
    End Sub
    Private Sub bt61_Click(sender As Object, e As EventArgs) Handles bt61.Click
        Checker(bt61, "61")
    End Sub
    Private Sub bt62_Click(sender As Object, e As EventArgs) Handles bt62.Click
        Checker(bt62, "62")
    End Sub
    Private Sub bt63_Click(sender As Object, e As EventArgs) Handles bt63.Click
        Checker(bt63, "63")
    End Sub
    Private Sub bt64_Click(sender As Object, e As EventArgs) Handles bt64.Click
        Checker(bt64, "64")
    End Sub
    Private Sub bt65_Click(sender As Object, e As EventArgs) Handles bt65.Click
        Checker(bt65, "65")
    End Sub
    Private Sub bt66_Click(sender As Object, e As EventArgs) Handles bt66.Click
        Checker(bt66, "66")
    End Sub
    Private Sub bt67_Click(sender As Object, e As EventArgs) Handles bt67.Click
        Checker(bt67, "67")
    End Sub
    Private Sub bt68_Click(sender As Object, e As EventArgs) Handles bt68.Click
        Checker(bt68, "68")
    End Sub
    Private Sub bt69_Click(sender As Object, e As EventArgs) Handles bt69.Click
        Checker(bt69, "69")
    End Sub
    Private Sub bt71_Click(sender As Object, e As EventArgs) Handles bt71.Click
        Checker(bt71, "71")
    End Sub
    Private Sub bt72_Click(sender As Object, e As EventArgs) Handles bt72.Click
        Checker(bt72, "72")
    End Sub
    Private Sub bt73_Click(sender As Object, e As EventArgs) Handles bt73.Click
        Checker(bt73, "73")
    End Sub
    Private Sub bt74_Click(sender As Object, e As EventArgs) Handles bt74.Click
        Checker(bt74, "74")
    End Sub
    Private Sub bt75_Click(sender As Object, e As EventArgs) Handles bt75.Click
        Checker(bt75, "75")
    End Sub
    Private Sub bt76_Click(sender As Object, e As EventArgs) Handles bt76.Click
        Checker(bt76, "76")
    End Sub
    Private Sub bt77_Click(sender As Object, e As EventArgs) Handles bt77.Click
        Checker(bt77, "77")
    End Sub
    Private Sub bt78_Click(sender As Object, e As EventArgs) Handles bt78.Click
        Checker(bt78, "78")
    End Sub
    Private Sub bt79_Click(sender As Object, e As EventArgs) Handles bt79.Click
        Checker(bt79, "79")
    End Sub
    Private Sub bt81_Click(sender As Object, e As EventArgs) Handles bt81.Click
        Checker(bt81, "81")
    End Sub
    Private Sub bt82_Click(sender As Object, e As EventArgs) Handles bt82.Click
        Checker(bt82, "82")
    End Sub
    Private Sub bt83_Click(sender As Object, e As EventArgs) Handles bt83.Click
        Checker(bt83, "83")
    End Sub
    Private Sub bt84_Click(sender As Object, e As EventArgs) Handles bt84.Click
        Checker(bt84, "84")
    End Sub
    Private Sub bt85_Click(sender As Object, e As EventArgs) Handles bt85.Click
        Checker(bt85, "85")
    End Sub
    Private Sub bt86_Click(sender As Object, e As EventArgs) Handles bt86.Click
        Checker(bt86, "86")
    End Sub
    Private Sub bt87_Click(sender As Object, e As EventArgs) Handles bt87.Click
        Checker(bt87, "87")
    End Sub
    Private Sub bt88_Click(sender As Object, e As EventArgs) Handles bt88.Click
        Checker(bt88, "88")
    End Sub
    Private Sub bt89_Click(sender As Object, e As EventArgs) Handles bt89.Click
        Checker(bt89, "89")
    End Sub
    Private Sub bt91_Click(sender As Object, e As EventArgs) Handles bt91.Click
        Checker(bt91, "91")
    End Sub
    Private Sub bt92_Click(sender As Object, e As EventArgs) Handles bt92.Click
        Checker(bt92, "92")
    End Sub
    Private Sub bt93_Click(sender As Object, e As EventArgs) Handles bt93.Click
        Checker(bt93, "93")
    End Sub
    Private Sub bt94_Click(sender As Object, e As EventArgs) Handles bt94.Click
        Checker(bt94, "94")
    End Sub
    Private Sub bt95_Click(sender As Object, e As EventArgs) Handles bt95.Click
        Checker(bt95, "95")
    End Sub
    Private Sub bt96_Click(sender As Object, e As EventArgs) Handles bt96.Click
        Checker(bt96, "96")
    End Sub
    Private Sub bt97_Click(sender As Object, e As EventArgs) Handles bt97.Click
        Checker(bt97, "97")
    End Sub
    Private Sub bt98_Click(sender As Object, e As EventArgs) Handles bt98.Click
        Checker(bt98, "98")
    End Sub
    Private Sub bt99_Click(sender As Object, e As EventArgs) Handles bt99.Click
        Checker(bt99, "99")
    End Sub
End Class
