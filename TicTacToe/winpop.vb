Public Class winpop
    Public mode As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.PerformStep()
        If ProgressBar1.Value = 100 Then
            'System.Threading.Thread.Sleep(15000)
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ask As DialogResult = MessageBox.Show("Yo sure? Return to main menu?",
                            "Back to Main Menu",
                            MessageBoxButtons.YesNo)

        If (ask = DialogResult.Yes) Then
            Me.Close()
            If (mode = "B") Then
                Basic.Close()
            Else
                Ulti.Close()
            End If
            startForm.Show()
            End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        If (mode = "B") Then
            Basic.incr()
            Basic.reset()
        Else
            'for ultimate
            Ulti.reset()
        End If
        Me.Close()
    End Sub

    Private Sub winpop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if timer is off, it is off after the previous round
        If (Timer1.Enabled = False) Then
            Timer1.Start()
        End If
    End Sub
End Class