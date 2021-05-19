Public Class BscBttn
    Private Sub BscBttn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaBscBttn_CheckedChanged(sender As Object, e As EventArgs) Handles GunaBscBttn.Click
        If GunaBscBttn.Checked Then
            BscPanel.BringToFront()
        End If

    End Sub

    Private Sub GunaUltBttn_CheckedChanged(sender As Object, e As EventArgs) Handles GunaUltBttn.Click
        If GunaUltBttn.Checked Then
            UltPanel.BringToFront()
        End If
    End Sub
End Class