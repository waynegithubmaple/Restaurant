Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VP_Assignment_2
<TestClass()> Public Class UnitTest1
    Dim db As New restaurantDataContext

    <TestMethod()> Public Sub TestMethod1()

        ' find available orders
        Dim db As New restaurantDataContext
        Dim s = (From o In db.Seats Where o.TableStatus = "UnAvailable").ToArray
        Dim allTableNo(10) As Integer
        For i = 0 To s.Length - 1
            allTableNo(i) = s(i).TableNo

        Next

        Dim tableNo As Integer = Convert.ToInt32(allTableNo(0))

        ' delete order
        Dim deleteFormTest As New frmDeleteOrder
        Dim orderNo = deleteFormTest.deleteOrders(tableNo)

        ' Check if order exist after deleting it
        Dim d
        Try
            d = (From o In db.Orders, a In db.OrderItems Where o.OrderNo = a.OrderNo And a.tableNo = tableNo).ToArray
            orderNo = d(0).a.OrderNo
        Catch
            d = 0
        End Try
        Assert.AreNotEqual(orderNo, d)
    End Sub

End Class