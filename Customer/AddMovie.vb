Public Class AddMovie
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMovie.Clear()
        txtGenre.Clear()
        txtDuration.Clear()
    End Sub

    Private Sub btnMovieShowing_Click(sender As Object, e As EventArgs) Handles btnMovieShowing.Click
        Me.Hide()
        MovieShowing.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Me.Hide()
        Transaction.Show()
    End Sub
End Class