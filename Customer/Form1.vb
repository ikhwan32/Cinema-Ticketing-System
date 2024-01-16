Public Class movieList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CinemaDataSet.movie' table. You can move, or remove it, as needed.
        Me.MovieTableAdapter.Fill(Me.CinemaDataSet.movie)

    End Sub
End Class