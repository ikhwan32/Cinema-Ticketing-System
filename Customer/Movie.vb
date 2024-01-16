Public Class Movie

    Private Sub movie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataset.movie' table. You can move, or remove it, as needed.
        Me.MovieTableAdapter.Fill(Me.MainDataset.movie)


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBook1.Click
        Me.Hide()
        DateTicket.Show()
    End Sub

    Private Sub btnBook2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DateTicket.Show()
    End Sub

    Private Sub btnBook3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DateTicket.Show()
    End Sub

    Private Sub btnBook4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DateTicket.Show()
    End Sub

    Private Sub btnBook5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DateTicket.Show()
    End Sub

    Private Sub btnBook6_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DateTicket.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        lblMovieName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        lblDesc.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        lblTime.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        pcbMovie1.ImageLocation = DataGridView1.CurrentRow.Cells(4).Value.ToString
    End Sub


End Class