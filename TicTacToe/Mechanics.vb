Public Class NextBttn
    Private Sub BscBttn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaBscBttn_CheckedChanged(sender As Object, e As EventArgs) Handles GunaBscBttn.Click
        If GunaBscBttn.Checked Then
            'UltPanel.Hide()
            BscPanel.BringToFront()

        End If

    End Sub

    Private Sub GunaUltBttn_CheckedChanged(sender As Object, e As EventArgs) Handles GunaUltBttn.Click
        If GunaUltBttn.Checked Then
            'UltPanel.BringToFront()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If BscPanel.Visible = True Then
            BscPanel.Hide()
            BscPanel2.BringToFront()
        End If

        If BscPanel2.Visible = True Then
            BscPanel2.Hide()
            BscPanel3.BringToFront()
        End If

        If BscPanel3.Visible = True Then
            BscPanel3.Hide()
            BscPanel4.BringToFront()
        End If

        If BscPanel4.Visible = True Then
            MessageBox.Show("This is the last page", "Admin")
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles PrvsBttn.Click
        If BscPanel.Visible = True Then
            MessageBox.Show("This is the first page", "Admin")
        End If

        If BscPanel2.Visible = True Then
            BscPanel2.Hide()
            BscPanel.BringToFront()
        End If

        If BscPanel3.Visible = True Then
            BscPanel3.Hide()
            BscPanel2.BringToFront()
        End If

        If BscPanel4.Visible = True Then
            BscPanel4.Hide()
            BscPanel3.BringToFront()
        End If
    End Sub
End Class