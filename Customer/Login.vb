Imports System.Data.OleDb
Imports System.Data
Public Class Login
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CinemaDB.accdb")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MsgBox("Enter Username or Password!", MsgBoxStyle.Exclamation)

        Else

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDbCommand("SELECT * FROM [admin] WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Login Successful!", MsgBoxStyle.Information)
                Me.Hide()
                MovieShowing.Show()
            Else
                Dim cmd2 As New OleDbCommand("SELECT * FROM [user] WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'", conn)
                Dim dr2 As OleDbDataReader = cmd2.ExecuteReader
                If dr2.HasRows Then
                    MsgBox("Login Successful!", MsgBoxStyle.Information)
                    Me.Hide()
                    Movie.Show()
                Else
                    MsgBox("Invalid Username or Password!", MsgBoxStyle.Critical)
                End If
            End If



        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub


End Class
