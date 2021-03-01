Public Class frmUnavailableTables

    Private Sub frmUnavailableTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New restaurantDataContext
        Dim s = (From o In db.Seats Where o.TableStatus = "Unavailable").ToArray

        If s.Length > 0 Then
            For i = 0 To s.Length - 1
                cboUnavailableTables.Items.Add(s(i).TableNo)
            Next
        Else
            MessageBox.Show("There are no orders", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub

    Private Sub cboUnavailableTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnavailableTables.SelectedIndexChanged
        frmMainOrder.tableNo = cboUnavailableTables.SelectedItem.ToString
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If frmMainOrder.selectedChoice = "Update" Then
            frmUpdateOrder.Show()

        ElseIf frmMainOrder.selectedChoice = "Delete" Then
            '   frmDeleteOrder.Show
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class