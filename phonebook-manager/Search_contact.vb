Public Class Search_contact
    Private Sub Search_contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Save_Button1_Click(sender As Object, e As EventArgs) Handles Search_Button1.Click

    End Sub

    Private Sub SearchHeading_Label1_Click(sender As Object, e As EventArgs) Handles SearchHeading_Label1.Click

    End Sub

    Private Sub Exit_Button2_Click(sender As Object, e As EventArgs) Handles Exit_Button2.Click
        If MsgBox("Do you really want to exit?", MsgBoxStyle.OkCancel) = MsgBoxStyle.OkCancel Then
            Me.Close()
            OptionsScreen.Show()
        Else
            Me.Show()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SourceCode_LinkLabel1.LinkClicked
        Process.Start("https://github.com/kevinam99/phonebook-manager")

    End Sub
End Class