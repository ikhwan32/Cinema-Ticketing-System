Public Class Receipt
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.Hide()
        Print.Show()
    End Sub
End Class