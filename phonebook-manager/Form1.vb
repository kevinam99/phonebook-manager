Public Class Phonebook
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Welcome.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHub.LinkClicked

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles AvailableGitHub.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            form2.show()
            Me.Hide()
        End If
    End Sub
End Class
