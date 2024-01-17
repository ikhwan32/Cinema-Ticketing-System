Public Class Seat
    Dim availableIcon As System.Drawing.Bitmap = My.Resources.available
    Dim takenIcon As System.Drawing.Bitmap = My.Resources.taken
    Dim selectedIcon As System.Drawing.Bitmap = My.Resources.selected
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub Seat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon
                AddHandler c.Click, AddressOf PictureBox1_Click
            End If

        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = selectedIcon
        ElseIf CType(sender, PictureBox).Image Is selectedIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If

    End Sub
End Class