Imports System.Data.OleDb
Imports System.Data
Imports System.IO

Public Class MovieShowing
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CinemaDB.accdb")
    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        Me.Hide()
        AddMovie.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Me.Hide()
        Transaction.Show()
    End Sub

    Private Sub MovieShowing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MainDataset.movie' table. You can move, or remove it, as needed.
        Me.MovieTableAdapter.Fill(Me.MainDataset.movie)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As New OleDbCommand("INSERT INTO [movie] (movieName, movieDesc, runningTime, movieCover,movieStatus) VALUES (@movie_name, @movie_desc, @movie_time, @movie_image, @movie_status)", conn)
        cmd.Parameters.AddWithValue("@movie_name", txtName.Text)
        cmd.Parameters.AddWithValue("@movie_desc", txtDesc.Text)
        cmd.Parameters.AddWithValue("@movie_time", txtTime.Text)
        cmd.Parameters.AddWithValue("@movie_image", Label5.Text)
        cmd.Parameters.AddWithValue("@movie_status", comboBoxStatus.SelectedItem)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.ExecuteNonQuery()
        MsgBox("Movie Added!", MsgBoxStyle.Information)
        Me.MovieTableAdapter.Fill(Me.MainDataset.movie)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As New OleDbCommand("DELETE FROM [movie] WHERE movieID = @movie_id", conn)
        cmd.Parameters.AddWithValue("@movie_id", DataGridView1.CurrentRow.Cells(0).Value.ToString)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.ExecuteNonQuery()
        MsgBox("Movie Deleted!", MsgBoxStyle.Information)
        Me.MovieTableAdapter.Fill(Me.MainDataset.movie)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As New OleDbCommand("UPDATE [movie] SET movieName = @movie_name, movieDesc = @movie_desc, runningTime = @movie_time, movieCover = @movie_image, movieStatus = @movie_status WHERE movieID = @movie_id", conn)
        cmd.Parameters.AddWithValue("@movie_name", txtName.Text)
        cmd.Parameters.AddWithValue("@movie_desc", txtDesc.Text)
        cmd.Parameters.AddWithValue("@movie_time", txtTime.Text)
        cmd.Parameters.AddWithValue("@movie_image", Label5.Text)
        cmd.Parameters.AddWithValue("@movie_status", comboBoxStatus.SelectedItem)
        cmd.Parameters.AddWithValue("@movie_id", DataGridView1.CurrentRow.Cells(0).Value.ToString)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.ExecuteNonQuery()
        MsgBox("Movie Updated!", MsgBoxStyle.Information)

        DataGridView1.Refresh()
        Me.MovieTableAdapter.Fill(Me.MainDataset.movie)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtDesc.Text = ""
        txtTime.Text = ""
        pcbMovie1.Image = Nothing
        Label5.Text = ""
        comboBoxStatus.SelectedItem = Nothing

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using OpenFileDialog1 As New OpenFileDialog
            OpenFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.png, *.jpeg)|*.bmp;*.jpg;*.png;*.jpeg"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                pcbMovie1.Image = Image.FromFile(OpenFileDialog1.FileName)
                Label5.Text = OpenFileDialog1.FileName
            End If

        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtDesc.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtTime.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        pcbMovie1.Image = Image.FromFile(DataGridView1.CurrentRow.Cells(4).Value.ToString)
        Label5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        comboBoxStatus.SelectedItem = DataGridView1.CurrentRow.Cells(5).Value.ToString

    End Sub
End Class