Public Class frmOder

    Public SelectedOrderNo As String

    Private Sub cboOrderNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrderNo.SelectedIndexChanged
        SelectedOrderNo = cboOrderNo.SelectedText
    End Sub

    Private Sub frmOder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim db As New restaurantDataContext()
        Dim rs = From o In db.OrderItems
                 Select o.tableNo Distinct

        cboOrderNo.DataSource = rs


    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        SelectedOrderNo = cboOrderNo.SelectedItem.ToString
    End Sub




End Class