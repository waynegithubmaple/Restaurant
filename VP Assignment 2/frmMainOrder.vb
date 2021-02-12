Public Class frmMainOrder
    Public tableNo As String
    Public selectedChoice As String








    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMainOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddOrder.Select()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        frmAvailableTables.Show()
    End Sub
End Class