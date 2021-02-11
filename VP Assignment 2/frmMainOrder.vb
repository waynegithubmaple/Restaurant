Public Class frmMainOrder
    Public tableNo As String
    Public selectedChoice As String


    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        selectedChoice = "Update"

    End Sub

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        selectedChoice = "Delete"
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim db As New restaurantDataContext
        Dim s = (From o In db.Seats Where o.TableStatus = "Unavailable").ToArray
        If s.Length > 0 Then
            frmViewOrder.Show()
        Else
            MessageBox.Show("There are no orders", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMainOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnViewOrders.Select()
    End Sub


End Class