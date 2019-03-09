Public Class Update_Contact
    Private Sub SearchHeading_Label1_Click(sender As Object, e As EventArgs) Handles SearchHeading_Label1.Click

    End Sub

    Private Sub SourceCode_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SourceCode_LinkLabel1.LinkClicked
        Process.Start("https://github.com/kevinam99/phonebook-manager")
    End Sub

    Private Sub Exit_Button2_Click(sender As Object, e As EventArgs) Handles Exit_Button2.Click
        Me.Close()
        Search_contact.Show()
    End Sub

    Private Sub Save_Button1_Click(sender As Object, e As EventArgs) Handles Save_Button1.Click
        Me.Close()
        OptionsScreen.Show()
    End Sub
End Class