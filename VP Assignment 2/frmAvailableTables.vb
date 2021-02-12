Public Class frmAvailableTables
    'Public tableNo As String
    Private Sub cboAvailableTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvailableTables.SelectedIndexChanged
        frmMainOrder.tableNo = cboAvailableTables.SelectedItem.ToString
        ' MessageBox.Show(tableNo.ToString)
    End Sub

    Private Sub frmAvailableTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New restaurantDataContext
        Dim s = (From o In db.Seats Where o.TableStatus = "Available").ToArray

        For i = 0 To s.Length - 1
            cboAvailableTables.Items.Add(s(i).TableNo)
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' frmMainOrder.tableNo = cboAvailableTables.SelectedItem.ToString

        frmAddOrderVersion2.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class