Public Class Create_Contact
    Private Sub SourceCode_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SourceCode_LinkLabel1.LinkClicked
        Process.Start("https://github.com/kevinam99/phonebook-manager")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CreatName_Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Create_Contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save_Button1.Click
        Me.Close()
        OptionsScreen.Show()
    End Sub

    Private Sub Exit_Button2_Click(sender As Object, e As EventArgs) Handles Exit_Button2.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxStyle.OkCancel Then
            Me.Close()
            OptionsScreen.Show()
        Else
            Me.Show()
        End If
    End Sub
End Class