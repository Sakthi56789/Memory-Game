﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "a" And TextBox2.Text = "a" Then
            Form2.Show()
        Else
            MsgBox("USERNAME OR PASSWORD IS INCORRECT")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If



    End Sub
End Class
