Public Class Payment
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblBank_Click(sender As Object, e As EventArgs) Handles lblBank.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub txtCard_TextChanged(sender As Object, e As EventArgs) Handles txtCard.TextChanged

    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Me.Hide()
        Receipt.Show()
    End Sub
End Class