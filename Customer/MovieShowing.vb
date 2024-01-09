Public Class MovieShowing
    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        Me.Hide()
        AddMovie.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Me.Hide()
        Transaction.Show()
    End Sub
End Class