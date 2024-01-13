Imports System.Data.OleDb
Imports System.Data

Public Class SignUp
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\myPC\Documents\CinemaDB.accdb")
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Or txtConfirmPassword.Text = Nothing Then
            MsgBox("Please fill up all fields!", MsgBoxStyle.Exclamation)
        Else
            If txtPassword.Text = txtConfirmPassword.Text Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd As New OleDbCommand("SELECT * FROM [user] WHERE username = '" & txtUsername.Text & "'", conn)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                If dr.HasRows Then
                    MsgBox("Username already exists!", MsgBoxStyle.Critical)
                Else
                    Dim cmd2 As New OleDbCommand("INSERT INTO [user] ([username], [password]) VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "')", conn)
                    cmd2.ExecuteNonQuery()
                    MsgBox("Registration Successful!", MsgBoxStyle.Information)
                    Me.Hide()
                    Login.Show()
                End If
            Else
                MsgBox("Password does not match!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

End Class