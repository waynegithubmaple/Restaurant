Public Class frmUpdateOrder
    Dim selectedItem As String
    Dim orderNo As Integer

    Dim quantity As Integer
    Dim index As Integer
    Dim category As String
    Dim length As Integer
    Dim itemName As String
    Dim itemPrice As Integer
    Dim currentItem As Integer = 0
    Private Sub frmUpdateOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstItems.Items.Clear()
        lblTableNo.Text = frmMainOrder.tableNo
        Dim o As New restaurantDataContext
        'multitable query?
        ' Dim order = (From q In o.OrderItems Join s In o.Orders On  )
        ' the orderNo is stored in the current 
        Dim order = (From q In o.OrderItems, a In o.Orders Where q.OrderNo = a.OrderNo And q.tableNo = Integer.Parse(frmMainOrder.tableNo) And a.OrderStatus = "Unpaid").ToArray
        orderNo = order(0).q.OrderNo
        'MessageBox.Show(orderNo.ToString)

        For i = 0 To order.Length - 1
                lstViewOrderDetails.Items.Add(order(i).q.ItemName)
                lstViewOrderDetails.Items(i).SubItems.Add(order(i).q.ItemPrice.ToString)
                lstViewOrderDetails.Items(i).SubItems.Add(order(i).q.quantity.ToString)
                lstViewOrderDetails.Items(i).SubItems.Add((order(i).q.ItemPrice * order(i).q.quantity).ToString)

            Next


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lstViewOrderDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstViewOrderDetails.SelectedIndexChanged
        index = lstViewOrderDetails.FocusedItem.Index
        selectedItem = lstViewOrderDetails.FocusedItem.Text

        If index >= 0 Then

            lblItem.Text = lstViewOrderDetails.Items(index).Text
            lblPrice.Text = lstViewOrderDetails.Items(index).SubItems(1).Text
            txtQuantity.Text = lstViewOrderDetails.Items(index).SubItems(2).Text
        End If


        ' Dim db As New restaurantDataContext()
        ' 
        'Dim s = (From q In db.OrderItems, a In db.Orders Where q.OrderNo = a.OrderNo And q.tableNo = Integer.Parse(frmMainOrder.tableNo) And q.ItemName = selectedItem).FirstOrDefault

        'lblItemNo.Text = s.ItemId
        'lblItem.Text = s.ItemName
        'lblPrice.Text = s.ItemPrice.ToString()
        'orderNo = s.OrderNo
        'txtQuantity.Text = s.quantity.ToString

        'lstItems.SelectedItem = selectedItem
    End Sub

    'Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
    '    If Integer.TryParse(txtQuantity.Text, quantity) Then
    '        If quantity > 0 Then
    '            quantity = Integer.Parse(txtQuantity.Text)
    '        Else
    '            MessageBox.Show("Please enter a numeric value only", "Error")
    '        End If



    '    Else
    '        MessageBox.Show("Please enter a numeric value only", "Error")
    '    End If
    'End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstViewOrderDetails.FocusedItem.Index = -1 Then
            MessageBox.Show("Please select an item to delete", "Error")
            lstViewOrderDetails.Select()
        Else
            lstViewOrderDetails.Items.RemoveAt(lstViewOrderDetails.FocusedItem.Index)


        End If
        currentItem -= 1
        resetForm()

        'Me.Close()

    End Sub
    Private Sub resetForm()
        lblItem.Text = ""
        lblPrice.Text = ""
        txtQuantity.Text = ""
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
    Private Sub showRecords()
        Dim db As New restaurantDataContext()
        Dim s = (From o In db.Menus Where o.ItemName = selectedItem).FirstOrDefault


        lblItem.Text = s.ItemName
        lblPrice.Text = s.ItemPrice.ToString()
    End Sub
    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged
        selectedItem = lstItems.SelectedItem.ToString
        txtQuantity.Text = ""
        txtQuantity.Focus()
        selectedItem = lstItems.SelectedItem.ToString
        '   selectedItem = lstItems.GetItemText(lstItems.SelectedItem)
        'MessageBox.Show(selectedItem)
        Dim db As New restaurantDataContext()
        Dim s = (From o In db.Menus Where o.ItemName = selectedItem).FirstOrDefault()
        'lblItemNo.Text = s.ItemId.ToString()
        lblItem.Text = s.ItemName
        lblPrice.Text = s.ItemPrice.ToString()

        showRecords()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If lstViewOrderDetails.FocusedItem.Index = -1 Then
            MessageBox.Show("Please select an item to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtQuantity Is Nothing Then
                MessageBox.Show("Please enter a value for quantity", "Error")
            ElseIf Integer.TryParse(txtQuantity.Text, quantity) = False Then
                MessageBox.Show("Enter a numeric value only", "ERROR")
            ElseIf quantity <= 0 Then
                MessageBox.Show("Enter a valid quantity", "ERROR")
            Else
                ' itemNo = lblItemNo.Text
                quantity = Integer.Parse(txtQuantity.Text)

                lstViewOrderDetails.Items(index).Text = lblItem.Text
                lstViewOrderDetails.Items(index).SubItems(1).Text = lblPrice.Text.ToString
                lstViewOrderDetails.Items(index).SubItems(2).Text = quantity.ToString
                lstViewOrderDetails.Items(index).SubItems(3).Text = (quantity * Integer.Parse(lblPrice.Text)).ToString

            End If


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Integer = 0
        currentItem = lstViewOrderDetails.Items.Count
        If txtQuantity Is Nothing Then
            MessageBox.Show("Please enter a value for quantity", "Error")
        ElseIf Integer.TryParse(txtQuantity.Text, quantity) = False Then
            MessageBox.Show("Enter a numeric value only", "ERROR")
        ElseIf quantity <= 0 Then
            MessageBox.Show("Enter a valid quantity", "ERROR")
        Else

            'itemNo = lblItemNo.Text
            itemName = lblItem.Text
            itemPrice = Integer.Parse(lblPrice.Text)
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
        btnSave.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim result As DialogResult
        Dim del As New restaurantDataContext


        'in case the user deletes all the items of the order, delete the order
        If lstViewOrderDetails.Items.Count = 0 Then
            result = MessageBox.Show("This will delete the current order. Press Ok if you confirm to continue", "information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            ' if the user confirms deleteing the order
            If result = DialogResult.OK Then

                Dim dl = (From q In del.OrderItems, a In del.Orders Where q.OrderNo = a.OrderNo And q.tableNo = Integer.Parse(frmMainOrder.tableNo) And a.OrderStatus = "Unpaid").ToArray
                'delete items records from orderItem table
                For i = 0 To dl.Length - 1
                    del.OrderItems.DeleteOnSubmit(dl(i).q)
                    del.SubmitChanges()
                Next
                ' delete the order record from order table
                Dim deleteOrder = (From i In del.Orders Where i.OrderNo = orderNo).FirstOrDefault
                del.Orders.DeleteOnSubmit(deleteOrder)
                del.SubmitChanges()
                Dim t = (From u In del.Seats Where u.TableNo = Integer.Parse(frmMainOrder.tableNo)).FirstOrDefault
                'update the status of the table
                t.TableStatus = "Available"
                del.SubmitChanges()
                MessageBox.Show("Order is deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'if the user does not want to delete the order
            Else
                'retrieve the original order
                frmUpdateOrder_Load(Nothing, Nothing)
            End If 'end of messagebox result

            'if the user did not delete all the order items 
        Else
            'retrieving the original order details
            Dim dif = (From p In del.OrderItems Where p.OrderNo = orderNo).ToArray

            '------------------------TESTING PURPOSE--------------------
            'checking the retrieved order details, correct
            'For i = 0 To dif.Length - 1
            '    MessageBox.Show(dif(i).ItemName)
            'Next
            '-----------------------------------------------------------


            'if items were deleted
            If dif.Length > lstViewOrderDetails.Items.Count Then

                'check the items from the original order items
                For i = 0 To dif.Length - 1
                    'count is a checkng counter
                    Dim count As Integer = 0
                    'check the items in the list view
                    For j = 0 To lstViewOrderDetails.Items.Count - 1
                        'if the item does not match, increment count
                        If dif(i).ItemName <> lstViewOrderDetails.Items(j).Text Then
                            count += 1
                        Else
                            'if the item matches, check if it is modified
                            If dif(i).quantity <> Integer.Parse(lstViewOrderDetails.Items(j).SubItems(2).Text) Then
                                dif(i).quantity = Integer.Parse(lstViewOrderDetails.Items(j).SubItems(2).Text)
                                del.SubmitChanges()
                                MessageBox.Show("Order is updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End If
                        End If
                        'if the item was not matched, it means it was deleted

                    Next
                    If count = lstViewOrderDetails.Items.Count Then
                        'delete the item from orderItem table
                        del.OrderItems.DeleteOnSubmit(dif(i))
                        del.SubmitChanges()
                        MessageBox.Show("Order is updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                Next

                'if items were not deleted , check if they were modified
            ElseIf dif.Length = lstViewOrderDetails.Items.Count Or lstViewOrderDetails.Items.Count > dif.Length Then
                For i = 0 To lstViewOrderDetails.Items.Count - 1
                    Dim count As Integer = 0
                    For j = 0 To dif.Length - 1
                        'check if the quantity changed
                        If dif(j).ItemName = lstViewOrderDetails.Items(i).Text Then
                            If dif(j).quantity <> Integer.Parse(lstViewOrderDetails.Items(i).SubItems(2).Text) Then
                                dif(j).quantity = Integer.Parse(lstViewOrderDetails.Items(i).SubItems(2).Text)
                                del.SubmitChanges()
                                MessageBox.Show("Order is updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End If
                        Else
                            'increase the counter that checks if the item already exists in the database records
                            count += 1

                        End If
                    Next
                    If count = dif.Length Then
                        'add the item
                        Dim newItem As New OrderItem
                        Dim food = (From n In del.Menus Where n.ItemName = lstViewOrderDetails.Items(i).Text).FirstOrDefault
                        newItem.ItemId = food.ItemId
                        newItem.ItemName = lstViewOrderDetails.Items(i).Text
                        newItem.ItemPrice = Integer.Parse(lstViewOrderDetails.Items(i).SubItems(1).Text)
                        newItem.quantity = Integer.Parse(lstViewOrderDetails.Items(i).SubItems(2).Text)
                        newItem.OrderNo = orderNo
                        newItem.tableNo = Integer.Parse(frmMainOrder.tableNo)
                        Dim z = (From t In del.OrderItems.AsEnumerable() Select t.entry).Max()
                        newItem.entry = z + 1

                        del.OrderItems.InsertOnSubmit(newItem)
                        del.SubmitChanges()
                        MessageBox.Show("Order is updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                Next

                '-----------------------------------------------
                'if an item was deleted and replaced by another
                '-----------------------------------------------

                For i = 0 To dif.Length - 1
                    'count is a checkng counter
                    Dim count As Integer = 0
                    'check the items in the list view
                    For j = 0 To lstViewOrderDetails.Items.Count - 1
                        'if the item does not match, increment count
                        If dif(i).ItemName <> lstViewOrderDetails.Items(j).Text Then
                            count += 1
                        Else
                            'if the item matches, check if it is modified
                            If dif(i).quantity <> Integer.Parse(lstViewOrderDetails.Items(j).SubItems(2).Text) Then
                                dif(i).quantity = Integer.Parse(lstViewOrderDetails.Items(j).SubItems(2).Text)
                                del.SubmitChanges()
                                MessageBox.Show("Order is updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            End If
                        End If
                        'if the item was not matched, it means it was deleted

                    Next
                    If count = lstViewOrderDetails.Items.Count Then
                        'delete the item from orderItem table
                        del.OrderItems.DeleteOnSubmit(dif(i))
                        del.SubmitChanges()
                        MessageBox.Show("Order is updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                Next


            End If

        End If


        'Else
        '    Dim index As Integer = 0
        '    Dim found = (From b In del.OrderItems Where b.OrderNo = orderNo).ToArray
        '    'do as save job in addOrder - save changes - do not add again just modify
        '    For i = 0 To found.Length - 1
        '        ' Dim f = (From s In del.OrderItems Where s.ItemName = lstViewOrderDetails.Items(index).Text And s.OrderNo = orderNo).FirstOrDefault

        '        'if the item does not exist, add it to the database
        '        If found(index).ItemName <> lstViewOrderDetails.Items(i).Text Then

        '        End If
        '        MessageBox.Show(f.ItemName)
        '        '  If f Is Nothing Then
        '        Dim create As New OrderItem
        '            Dim food = (From k In del.Menus Where k.ItemName = lstViewOrderDetails.Items(i).Text).FirstOrDefault
        '            create.OrderNo = orderNo
        '            create.ItemId = food.ItemId
        '            create.ItemName = lstViewOrderDetails.Items(i).Text
        '            create.ItemPrice = Integer.Parse(lstViewOrderDetails.Items(i).SubItems(1).Text)
        '            create.quantity = Integer.Parse(lstViewOrderDetails.Items(i).SubItems(2).Text)
        '            create.tableNo = Integer.Parse(lblTableNo.Text)
        '            create.entry = del.OrderItems.Count + 1

        '            del.OrderItems.InsertOnSubmit(create)
        '            del.SubmitChanges()
        '        Else
        '            If f.quantity <> Integer.Parse(lstViewOrderDetails.Items(i).SubItems(2).Text) Then
        '                f.quantity = Integer.Parse(lstViewOrderDetails.Items(i).SubItems(3).Text)
        '                del.SubmitChanges()
        '            End If
        '            'if the items exists but has been modified, update the database

        '        End If
        '        index += 1
        '    Next
        'End If

        Me.Close()
        frmUnavailableTables.Close()

        'Else
        'MessageBox.Show("you chose cancel")
        ' End If


    End Sub
End Class