Public Class frmManagerCRU

    Public Property name666 As String


    Private Sub btnOrder_Click(sender As Object, e As EventArgs)
        frmMainOrder.Show()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Form2.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs)
        frmOder.Show()
    End Sub


End Class