Public Class frmViewOrder
    Dim tableNo As Integer
    Dim total As Integer
    Dim db As New restaurantDataContext
    Private Sub frmViewOrder_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim s = (From o In db.Seats Where o.TableStatus = "Unavailable").ToArray
        If s.Length > 0 Then
            For i = 0 To s.Length - 1
                cboTableNo.Items.Add(s(i).TableNo)
            Next
        Else
            MessageBox.Show("There are no orders", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub



    Private Sub cboTableNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTableNo.SelectedIndexChanged
        lstViewOrderDetails.Items.Clear()
        Dim currentItem As Integer = 0
        tableNo = Integer.Parse(cboTableNo.SelectedItem.ToString)
        Dim order = (From i In db.Orders, a In db.OrderItems Where i.OrderNo = a.OrderNo And a.tableNo = tableNo And i.OrderStatus = "Unpaid").ToArray

        For i = 0 To order.Length - 1
            lstViewOrderDetails.Items.Add(order(i).a.ItemName)
            lstViewOrderDetails.Items(currentItem).SubItems.Add(order(i).a.ItemPrice.ToString("C"))
            lstViewOrderDetails.Items(currentItem).SubItems.Add(order(i).a.quantity.ToString)
            lstViewOrderDetails.Items(currentItem).SubItems.Add((order(i).a.ItemPrice * order(i).a.quantity).ToString("C"))
            total += order(i).a.ItemPrice * order(i).a.quantity
            currentItem += 1
        Next
        lblTotal.Text = total.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class