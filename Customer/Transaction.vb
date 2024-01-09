Public Class Transaction
    Private Sub btnMovieShowing_Click(sender As Object, e As EventArgs) Handles btnMovieShowing.Click
        Me.Hide()
        MovieShowing.Show()
    End Sub

    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        Me.Hide()
        AddMovie.Show()
    End Sub
End Class