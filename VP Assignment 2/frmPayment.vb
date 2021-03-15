Imports System.Data.SqlClient
Imports NUnit.Framework


Public Class frmPayment

    Private sqlquery As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private dblTotalPrice As Double = 0.0
    Private strOrderNumber As String = ""

    Private Sub lstPendingOrders_Click(sender As Object, e As EventArgs) Handles lstPendingOrders.Click

        Dim intIndex As Integer = 0
        Dim strOrderID As String = ""
        dblTotalPrice = 0.0

        Try

            intIndex = lstPendingOrders.SelectedIndex
            strOrderID = lstPendingOrders.Items(intIndex).ToString

            Dim strSelectedOrder As String = lstPendingOrders.SelectedItem.ToString()
            strOrderNumber = strSelectedOrder.Substring(strSelectedOrder.IndexOf("(") + 1, 1)

            If (Openconnection() = True) Then

                Dim cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * from OrderItems Where OrderNo = @OrderNo"
                Using da As New SqlDataAdapter(cmd)

                    cmd.Parameters.AddWithValue("@OrderNo", Integer.Parse(strOrderNumber.Trim()))
                    cmd.ExecuteNonQuery()
                    ds.Clear()
                    da.Fill(ds, "OrderItems")

                End Using


                Dim blnLoadOnce As Boolean = False

                Dim Reader = cmd.ExecuteReader
                While Reader.Read()

                    If (blnLoadOnce = False) Then
                        lblOrderNumber.Text = Reader("OrderNo").ToString()
                        lblTableNumber.Text = Reader("tableNo").ToString()
                        blnLoadOnce = True
                    End If

                    dblTotalPrice += Convert.ToDecimal(Reader("ItemPrice")) * Convert.ToInt32(Reader("quantity"))

                End While

                lblTotalDue.Text = "RM " + dblTotalPrice.ToString()

                Closeconnection()

            Else


            End If

        Catch ex As Exception

            'MessageBox.Show("You have not clicked anything")

        Finally

        End Try

    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadPendingOrders()

    End Sub

    Private Sub clearAll()

        lstPendingOrders.Items.Clear()
        loadPendingOrders()
        lblTotalDue.Text = ""
        lblOrderNumber.Text = ""
        lblTableNumber.Text = ""
        txtPayment.Text = ""

    End Sub


    Private Sub loadPendingOrders()

        Try
            If Openconnection() = True Then

                Dim cmd As SqlCommand = con.CreateCommand()
                Dim intRowCount As Integer = 0

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * from Orders where OrderStatus = @OrderStatus"
                Using da As New SqlDataAdapter(cmd)

                    cmd.Parameters.AddWithValue("@OrderStatus", "Unpaid")
                    cmd.ExecuteNonQuery()
                    ds.Clear()
                    da.Fill(ds, "Order")

                End Using

                If ds.Tables("Order").Rows.Count > 0 Then

                    Dim strOrderNumber As String = ""
                    Dim strOrderDate As String = ""

                    intRowCount = ds.Tables("Order").Rows.Count

                    For Start As Integer = 0 To intRowCount - 1

                        strOrderNumber = ds.Tables("Order").Rows(Start).Item(0).ToString()
                        strOrderDate = ds.Tables("Order").Rows(Start).Item(1).ToString()
                        lstPendingOrders.Items.Add("Order Number (" + strOrderNumber + ") , Date: " + strOrderDate)

                    Next

                End If

                lblNumberOfOrders.Text = intRowCount.ToString() & " orders loaded"
                Closeconnection()

            End If

        Catch ex As Exception

            MessageBox.Show("There are no pending orders at the moment")

        End Try

    End Sub


    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        If (lstPendingOrders.SelectedIndex = -1) Then

            MessageBox.Show("You have not selected on any orders")

        Else

            If (checkErrors() > 0) Then
                txtPayment.Text = ""
                txtPayment.Focus()
            Else
                Try
                    If (Openconnection() = True) Then

                        Dim cmd As SqlCommand = con.CreateCommand()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "Update Orders Set OrderStatus = @OrderStatus Where OrderNo = @OrderNo"
                        Using da As New SqlDataAdapter(cmd)
                            cmd.Parameters.AddWithValue("@OrderStatus", "Paid")
                            cmd.Parameters.AddWithValue("@OrderNo", Integer.Parse(strOrderNumber))
                            cmd.ExecuteNonQuery()
                        End Using

                        Dim dblAmount As Double = Convert.ToDouble(txtPayment.Text)
                        Dim dblChange As Double = dblAmount - dblTotalPrice
                        MessageBox.Show("Paid Successfully" + vbCrLf + "Balance to customer: RM " +
                                            dblChange.ToString(), "Payment Status")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error updating orders")
                Finally
                    Closeconnection()
                    clearAll()
                End Try
            End If
        End If

    End Sub

    'Public Function testcheckErrors(ByRef strInput As String, ByRef dblTotalDue As Double) As String

    '    Dim dblInput As Double = 0.0
    '    Dim strError As String = ""

    '    If (String.IsNullOrWhiteSpace(strInput)) Then
    '        strError = "Empty"
    '    Else
    '        Try
    '            If (Convert.ToDouble(strInput) > 0) Then
    '                If (Convert.ToDouble(strInput) < dblTotalDue) Then
    '                    strError = "Insufficient"
    '                Else
    '                    strError = "Paid"
    '                End If
    '            ElseIf (Convert.ToDouble(strInput) < 0) Then
    '                strError = "Negative"
    '            Else
    '                strError = "Zero"
    '            End If
    '        Catch ex As Exception
    '            strError = "Characters"
    '        End Try
    '    End If

    '    Return strError
    'End Function



    Private Function checkErrors() As Integer

        Dim intErrorCount As Integer = 0
        Dim strErrorMsg As String = "You have the following errors: " + vbCrLf

        If (String.IsNullOrWhiteSpace(txtPayment.Text.Trim())) Then
            intErrorCount += 1
            strErrorMsg += intErrorCount.ToString() + ". Nothing is entered" + vbCrLf
        Else
            Try
                If (Convert.ToDouble(txtPayment.Text.Trim()) > 0) Then
                    If (Convert.ToDouble(txtPayment.Text.Trim()) < dblTotalPrice) Then
                        Dim dblAmount As Double = Convert.ToDouble(txtPayment.Text)
                        Dim dblLackedAmount As Double = dblTotalPrice - dblAmount
                        intErrorCount += 1
                        strErrorMsg += "The value entered is insufficient" + vbCrLf +
                                       "You will need to add another: RM " + dblLackedAmount.ToString()
                        txtPayment.Text = ""
                        txtPayment.Focus()
                    End If

                ElseIf (Convert.ToDouble(txtPayment.Text.Trim()) < 0) Then
                        intErrorCount += 1
                        strErrorMsg += intErrorCount.ToString() + ". Cannot enter negative value" + vbCrLf
                    Else
                        intErrorCount += 1
                    strErrorMsg += intErrorCount.ToString() + ". Cannot enter 0" + vbCrLf
                End If
            Catch ex As Exception
                intErrorCount += 1
                strErrorMsg += intErrorCount.ToString() + ". Cannot enter any characters" + vbCrLf
            End Try
        End If

        If (intErrorCount > 0) Then
            MessageBox.Show(strErrorMsg, "Error Message")
        End If

        Return intErrorCount

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class