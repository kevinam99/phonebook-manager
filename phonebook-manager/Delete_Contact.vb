﻿Public Class Delete_Contact
    Private Sub Search_Button1_Click(sender As Object, e As EventArgs) Handles Search_Button1.Click

    End Sub

    Private Sub Exit_Button2_Click(sender As Object, e As EventArgs) Handles Exit_Button2.Click
        Me.Close()
        OptionsScreen.Show()
    End Sub

    Private Sub SourceCode_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SourceCode_LinkLabel1.LinkClicked
        Process.Start("https://github.com/kevinam99/phonebook-manager")

    End Sub
End Class