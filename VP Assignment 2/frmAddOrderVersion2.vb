Public Class frmAddOrderVersion2
    Public category As String
    Public length As Integer
    Dim selectedItem As String
    Dim currentItem As Integer = 0
    Dim index As Integer
    ' order details
    Dim quantity As Integer
    Dim itemNo As String
    Dim itemName As String
    Dim itemPrice As Integer
    Public orderNo As Integer
    Dim entry As Integer
    Public available As Boolean
    Dim itemSet() As String
    Dim prices() As Integer
    Dim quantities() As Integer
    Dim intCounter As Integer = 0
    Dim db As New restaurantDataContext
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub showRecords()
        Dim db As New restaurantDataContext()
        Dim s = (From o In db.Menus Where o.ItemName = selectedItem).FirstOrDefault

        'lblItemNo.Text = s.ItemId
        lblItem.Text = s.ItemName
        lblItemPrice.Text = s.ItemPrice.ToString()
    End Sub
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        lstItems.Items.Clear()
        Dim index As Integer = cboCategory.SelectedIndex

        Select Case index
            Case 0 : category = "Main Meal"
                length = 10
            Case 1 : category = "Appetizers"
                length = 5
            Case 2 : category = "Drinks"
                length = 10
            Case 3 : category = "Desserts"
                length = 5
            Case 4 : category = "Beverage"
                length = 5
        End Select

        Dim food As New restaurantDataContext
        Dim foods = (From o In food.Menus Where o.ItemCategory = category).ToArray
        For i = 0 To foods.Length - 1
            lstItems.Items.Add(foods(i).ItemName)
        Next


    End Sub

    Private Sub frmAddOrderVersion2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstItems.Items.Clear()
        'lstOrderDetails.Items.Clear()
    End Sub

    Private Sub lstItems_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedValueChanged
        txtQuantity.Text = ""
        txtQuantity.Focus()
        selectedItem = lstItems.SelectedItem.ToString
        '   selectedItem = lstItems.GetItemText(lstItems.SelectedItem)
        'MessageBox.Show(selectedItem)
        Dim db As New restaurantDataContext()
        Dim s = (From o In db.Menus Where o.ItemName = selectedItem).FirstOrDefault()
        '  Dim s = (From o In db.Menus Where o.ItemCategory = category).FirstOrDefault()
        'lblItemNo.Text = s.ItemId
        lblItem.Text = s.ItemName
        lblItemPrice.Text = s.ItemPrice.ToString()
        ' MessageBox.Show(selectedItem)
        showRecords()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Integer = 0
        If txtQuantity Is Nothing Then
            MessageBox.Show("Please enter a value for quantity", "Error")
        ElseIf Integer.TryParse(txtQuantity.Text, quantity) = False Then
            MessageBox.Show("Enter a numeric value only", "ERROR")
        ElseIf quantity <= 0 Then
            MessageBox.Show("Enter a valid quantity", "ERROR")
        Else

            itemName = lblItem.Text
            Dim db As New restaurantDataContext
            Dim u = (From o In db.Menus Where o.ItemName = itemName).FirstOrDefault
            '
            itemNo = u.ItemId

            itemPrice = Integer.Parse(lblItemPrice.Text)
            quantity = Integer.Parse(txtQuantity.Text)
            If lstViewOrderDetails.Items.Count > 0 Then

                For i = 0 To lstViewOrderDetails.Items.Count - 1
                    If itemName = lstViewOrderDetails.Items(i).Text Then
                        quantity += Integer.Parse(lstViewOrderDetails.Items(i).SubItems(2).Text)
                        lstViewOrderDetails.Items(i).Text = itemName
                        lstViewOrderDetails.Items(i).SubItems(1).Text = itemPrice.ToString
                        lstViewOrderDetails.Items(i).SubItems(2).Text = (quantity.ToString)
                        lstViewOrderDetails.Items(i).SubItems(3).Text = ((quantity * itemPrice).ToString)
                    Else
                        check += 1

                    End If
                Next
                If check = lstViewOrderDetails.Items.Count Then
                    lstViewOrderDetails.Items.Add(itemName)
                    lstViewOrderDetails.Items(currentItem).SubItems.Add(itemPrice.ToString)
                    lstViewOrderDetails.Items(currentItem).SubItems.Add(quantity.ToString)
                    lstViewOrderDetails.Items(currentItem).SubItems.Add((quantity * itemPrice).ToString)

                    currentItem += 1
                End If
            Else
                lstViewOrderDetails.Items.Add(itemName)
                lstViewOrderDetails.Items(currentItem).SubItems.Add(itemPrice.ToString)
                lstViewOrderDetails.Items(currentItem).SubItems.Add(quantity.ToString)
                lstViewOrderDetails.Items(currentItem).SubItems.Add((quantity * itemPrice).ToString)

                currentItem += 1
            End If
        End If

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If lstViewOrderDetails.Items.Count = 0 Then

            MessageBox.Show("There are no items selected, please add items to create the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim db As New restaurantDataContext

            'orderNo = db.Orders.Count + 1

            Dim q = (From i In db.Orders.AsEnumerable Select i.OrderNo).Max()




            orderNo = q + 1
            entry = db.OrderItems.Count + 1

            Dim placeOrder As New Order
            placeOrder.OrderNo = orderNo
            placeOrder.OrderDate = Now.Date
            placeOrder.OrderStatus = "Unpaid"

            Dim s As New restaurantDataContext
            s.Orders.InsertOnSubmit(placeOrder)
            s.SubmitChanges()
            ' MessageBox.Show("Order" + orderNo.ToString + " is created ")


            Dim j As Integer = 0
            For i = 0 To lstViewOrderDetails.Items.Count - 1

                Dim order As New OrderItem
                Dim d As New restaurantDataContext
                Dim find = (From o In d.Menus
                            Where o.ItemName = lstViewOrderDetails.Items(j).Text).FirstOrDefault()
                Dim z = (From t In d.OrderItems.AsEnumerable() Select t.entry).Max()
                order.entry = z + 1
                order.ItemId = find.ItemId
                order.ItemName = find.ItemName
                order.ItemPrice = find.ItemPrice
                order.quantity = Integer.Parse(lstViewOrderDetails.Items(j).SubItems(2).Text)
                order.tableNo = Integer.Parse(frmMainOrder.tableNo)

                order.OrderNo = orderNo
                d.OrderItems.InsertOnSubmit(order)
                d.SubmitChanges()
                j += 1
                entry += 1

            Next

            Dim table As New restaurantDataContext
            Dim available = (From o In table.Seats Where o.TableNo = Integer.Parse(frmMainOrder.tableNo)).FirstOrDefault()


            available.TableStatus = "Unavailable"
            table.SubmitChanges()



            MessageBox.Show("Order Added Successfuly", "Information")
            Me.Close()
            frmMainOrder.Show()
        End If

        ' MessageBox.Show(orderNo.ToString)
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click

        If lstViewOrderDetails.FocusedItem.Index = -1 Then
            MessageBox.Show("Please select an item to delete", "Error")
            lstViewOrderDetails.Select()
        Else
            lstViewOrderDetails.Items.RemoveAt(lstViewOrderDetails.FocusedItem.Index)
        End If
        currentItem -= 1
        resetForm()
        btnSave.Focus()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        index = lstViewOrderDetails.FocusedItem.Index

        If txtQuantity Is Nothing Then
            MessageBox.Show("Please enter a value for quantity", "Error")
        ElseIf Integer.TryParse(txtQuantity.Text, quantity) = False Then
            MessageBox.Show("Enter a numeric value only", "ERROR")
        ElseIf quantity <= 0 Then
            MessageBox.Show("Enter a valid quantity", "ERROR")
        Else
            itemName = lblItem.Text
            Dim s = (From o In db.Menus Where o.ItemName = itemName).FirstOrDefault
            itemNo = s.ItemId
            'itemName = lblItem.Text
            itemPrice = Integer.Parse(lblItemPrice.Text)

            lstViewOrderDetails.Items(index).Text = itemName
            lstViewOrderDetails.Items(index).SubItems(1).Text = itemPrice.ToString
            lstViewOrderDetails.Items(index).SubItems(2).Text = quantity.ToString
            lstViewOrderDetails.Items(index).SubItems(3).Text = (quantity * itemPrice).ToString

        End If

        resetForm()
            btnSave.Focus()

    End Sub

    Private Sub resetForm()
        ' lblItemNo.Text = Nothing
        lblItem.Text = Nothing
        lblItemPrice.Text = Nothing
        txtQuantity.Clear()
    End Sub
    Private Sub lstViewOrderDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewOrderDetails.SelectedIndexChanged
        index = lstViewOrderDetails.FocusedItem.Index
        'MessageBox.Show(index.ToString)
        If index >= 0 Then
            lblItem.Text = lstViewOrderDetails.Items(index).Text
            lblItemPrice.Text = lstViewOrderDetails.Items(index).SubItems(1).Text
            txtQuantity.Text = lstViewOrderDetails.Items(index).SubItems(2).Text
        End If

    End Sub


End Class