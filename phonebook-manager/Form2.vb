Public Class OptionsScreen

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub OptionsScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SplashScreen.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/kevinam99/phonebook-manager")
    End Sub
End Class