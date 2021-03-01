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

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        Dim db As New restaurantDataContext
        Dim s = (From o In db.Seats Where o.TableStatus = "Unavailable").ToArray
        If s.Length > 0 Then
            frmViewOrder.Show()
        Else
            MessageBox.Show("There are no orders", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        selectedChoice = "Update"
        frmUnavailableTables.Show()
    End Sub
End Class