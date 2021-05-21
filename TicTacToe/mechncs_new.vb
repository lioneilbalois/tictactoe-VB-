Public Class mechncs_new
    Private Sub GunaBscBttn_Click(sender As Object, e As EventArgs) Handles GunaBscBttn.Click
        GrpBx1.Show()


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If GrpBx1.Visible = True Then
            'GrpBx1.SendToBack()
            GrpBx2.BringToFront()
        End If

        If GrpBx2.Visible = True Then
            'GrpBx2.SendToBack()
            GrpBx3.BringToFront()
        End If

        If GrpBx3.Visible = True Then
            'GrpBx3.SendToBack()
            GrpBx4.BringToFront()
        End If

        If GrpBx4.Visible = True Then
            MessageBox.Show("This is the last page", "Admin")
        End If
    End Sub

    Private Sub homePb_Click(sender As Object, e As EventArgs) Handles homePb.Click
        Me.Close()
        startForm.Show()
    End Sub
End Class