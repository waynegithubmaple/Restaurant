Public Class frmDeleteOrder
    Dim tableNo As Integer
    Dim total As Integer
    Dim orderNo As Integer
    Dim db As New restaurantDataContext
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmDeleteOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        total = 0
        lstViewOrderDetails.Items.Clear()
        tableNo = Integer.Parse(cboTableNo.SelectedItem.ToString)
        Dim b = (From i In db.Orders, k In db.OrderItems Where i.OrderNo = k.OrderNo And i.OrderStatus = "Unpaid" And k.tableNo = tableNo).ToArray
        Dim currentItem As Integer = 0
        For i = 0 To b.Length - 1

            lstViewOrderDetails.Items.Add(b(i).k.ItemName)
            lstViewOrderDetails.Items(currentItem).SubItems.Add(b(i).k.ItemPrice.ToString("C"))
            lstViewOrderDetails.Items(currentItem).SubItems.Add(b(i).k.quantity.ToString)
            lstViewOrderDetails.Items(currentItem).SubItems.Add((b(i).k.ItemPrice * b(i).k.quantity).ToString("C"))
            total += b(i).k.ItemPrice * b(i).k.quantity
            currentItem += 1
        Next
        lblTotal.Text = total.ToString("C")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult
        tableNo = Integer.Parse(cboTableNo.SelectedItem.ToString)
        result = MessageBox.Show("Are you sure you want to delete this order?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim d = (From o In db.Orders, a In db.OrderItems Where o.OrderNo = a.OrderNo And a.tableNo = tableNo).ToArray
            orderNo = d(0).a.OrderNo
            For i = 0 To d.Length - 1
                db.OrderItems.DeleteOnSubmit(d(i).a)
                db.SubmitChanges()
            Next
            ' delete the order record from order table
            Dim deleteOrder = (From i In db.Orders Where i.OrderNo = orderNo).FirstOrDefault
            db.Orders.DeleteOnSubmit(deleteOrder)
            db.SubmitChanges()
            Dim t = (From u In db.Seats Where u.TableNo = tableNo).FirstOrDefault
            'update the status of the table
            t.TableStatus = "Available"
            db.SubmitChanges()
            MessageBox.Show("Order is deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'hello
            Me.Close()




        Else
            frmDeleteOrder_Load(Nothing, Nothing)
        End If


    End Sub
End Class