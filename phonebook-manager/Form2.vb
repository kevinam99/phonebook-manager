﻿Public Class OptionsScreen

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Search_contact.Show()
    End Sub

    Private Sub OptionsScreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SplashScreen.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://github.com/kevinam99/phonebook-manager")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Create_Contact.Show()
    End Sub

    Private Sub Exit_Button2_Click(sender As Object, e As EventArgs) Handles Exit_Button2.Click
        If MsgBox("Do you really want to exit?", MsgBoxStyle.OkCancel) = MsgBoxStyle.OkCancel Then
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Delete_Contact.Show()
    End Sub

    Private Sub OptionsScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class