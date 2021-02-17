Public Class Form2

    Public Property idddd As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpResDate.MinDate = Today
        lblResId.Text = getnewid()
        dtpEndTime.MaxDate = DateTime.Parse("11:00 pm")
        dtpResTime.MinDate = DateTime.Parse("10:00 am")
        dtpEndTime.Value = dtpResTime.Value.AddHours(0)

        If dtpResTime.Value.ToShortDateString > dtpEndTime.MaxDate.ToShortTimeString Then
            dtpResTime.Enabled = False
            dtpEndTime.Enabled = False

        End If
    End Sub


    Private count As Integer




    Private Sub dtpResTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpResTime.ValueChanged

        Try
            ' Dim datee As Date = dtpResDate.Value
            Dim str_begin_time As String = "#" & dtpResDate.Value.ToString("dd/MM/yyyy") & " " & dtpResTime.Value.ToString("hh:mm:ss tt") & "#"
            Dim str_end_time As String = "#" & dtpResDate.Value.ToString("dd/MM/yyyy") & " " & dtpEndTime.Value.ToString("hh:mm:ss tt") & "#"
            dtpEndTime.Value = dtpResTime.Value.AddHours(0)
            ' Dim start As DateTime = Date.Parse(str_begin_time)
            ' Dim end_ As DateTime = Date.Parse(str_end_time)
            ' Dim db As New restaurantDataContext()
            btnAdd.Enabled = True






        Catch ex As Exception
            MessageBox.Show("The shop is closing and no accept any reservation!", "Warning", MessageBoxButtons.OK)
            'dtpResTime.Enabled = False
            'dtpEndTime.Enabled = False
            btnAdd.Enabled = False
        End Try


    End Sub

    Private Sub dtpEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndTime.ValueChanged

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        View_Reservation.Show()
    End Sub

    Private Sub lblResId_Click(sender As Object, e As EventArgs) Handles lblResId.Click

    End Sub

    Function getnewid() As String
        Dim db As New restaurantDataContext

        Dim lastRow = (From o In db.Reservations
                       Order By o.Reservation_ID Ascending
                       Select o.Reservation_ID).Max

        Dim running_number As Integer
        Dim newId As String = lastRow.ToString

        running_number = Integer.Parse(newId.Substring(1, newId.ToString.Length - 1))

        Return ("R" & (running_number + 1).ToString("0000"))

    End Function

    Private Sub grpTable_Enter(sender As Object, e As EventArgs) Handles grpTable.Enter

    End Sub

    Private Sub chkTable1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTable1.CheckedChanged, chkTable2.CheckedChanged, chkTable3.CheckedChanged, chkTable4.CheckedChanged, chkTable5.CheckedChanged, chkTable6.CheckedChanged

        If chkTable1.Checked = True Then
            chkTable1.BackColor = Color.CornflowerBlue

        Else

            chkTable1.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable2.Checked = True Then
            chkTable2.BackColor = Color.CornflowerBlue

        Else

            chkTable2.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable3.Checked = True Then
            chkTable3.BackColor = Color.CornflowerBlue

        Else

            chkTable3.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable4.Checked = True Then
            chkTable4.BackColor = Color.CornflowerBlue

        Else

            chkTable4.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable5.Checked = True Then
            chkTable5.BackColor = Color.CornflowerBlue

        Else

            chkTable5.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable6.Checked = True Then
            chkTable6.BackColor = Color.CornflowerBlue

        Else

            chkTable6.BackColor = Color.FromArgb(64, 64, 64)
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim db As New restaurantDataContext()
        Dim id As String = If(mskContactNo.MaskCompleted, mskContactNo.Text, "")
        Dim name As String = txtCustName.Text.Trim()
        Dim cboppl As String = cboNoPerson.Text.Trim()



        err.Tag = Nothing


        If id = "" Then
            err.SetError(mskContactNo, "Invalid [Contact Number] format")
            err.Tag = If(err.Tag, mskContactNo)

        End If

        If cboppl = "" Then
            err.SetError(cboNoPerson, "Pleas Enter Number of Person")
            err.Tag = If(err.Tag, cboNoPerson)

        End If

        If name = "" Then
            err.SetError(txtCustName, "Please enter [Name]")
            err.Tag = If(err.Tag, txtCustName)
        Else
            err.SetError(txtCustName, Nothing)
        End If




        If err.Tag IsNot Nothing Then
            CType(err.Tag, Control).Select()
            Return
        End If


        Dim r As New Reservation()
        r.Reservation_ID = lblResId.Text
        r.Customer_Name = txtCustName.Text

        'Dim begin_time As DateTime
        'Dim end_time As DateTime
        'begin_time = dtpResTime.Value
        'end_time = dtpEndTime.Value
        'begin_time.Date.ToShortDateString = dtpResDate.Value.Date.ToShortDateString
        'end_time.Date = dtpResDate.Value.Date
        Dim str As String = idddd
        Dim datee As Date = dtpResDate.Value
        Dim str_begin_time As String = "#" & dtpResDate.Value.ToString("dd/MM/yyyy") & " " & dtpResTime.Value.ToString("hh:mm:ss tt") & "#"
        Dim str_end_time As String = "#" & dtpResDate.Value.ToString("dd/MM/yyyy") & " " & dtpEndTime.Value.ToString("hh:mm:ss tt") & "#"
        'Dim time As DateTime = DateTime.Parse(str_begin_time)
        r.Reservation_DateTime_Start = DateTime.Parse(str_begin_time)
        r.Reservation_DateTime_End_ = DateTime.Parse(str_end_time)
        r.Number_of_People = Integer.Parse(cboNoPerson.Text)
        r.Contact_Number = mskContactNo.Text
        '    r.Staff_ID = FrmLogin.stffid.ToString
        r.Status = " "
        If chkTable1.Checked = True Then
            r.Table_No = 1
        ElseIf chkTable2.Checked = True Then
            r.Table_No = 2
        ElseIf chkTable3.Checked = True Then
            r.Table_No = 3
        ElseIf chkTable4.Checked = True Then
            r.Table_No = 4
        ElseIf chkTable5.Checked = True Then
            r.Table_No = 5
        ElseIf chkTable6.Checked = True Then
            r.Table_No = 6
        Else
            MessageBox.Show("Pls Select a Table", "Error Message", MessageBoxButtons.OK)
            Return
        End If

        db.Reservations.InsertOnSubmit(r)
        db.SubmitChanges()

        MessageBox.Show("Record inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Reset()


    End Sub

    Private Sub Reset()
        err.Clear()
        lblResId.Text = getnewid()
        dtpResDate.Value = Now
        dtpResTime.Value = Now
        txtCustName.Text = ""
        cboNoPerson.Text = ""
        mskContactNo.Clear()
        chkTable1.Checked = False
        chkTable2.Checked = False
        chkTable3.Checked = False
        chkTable4.Checked = False
        chkTable5.Checked = False
        chkTable6.Checked = False

        If chkTable1.Checked = True Then
            chkTable1.BackColor = Color.CornflowerBlue

        Else

            chkTable1.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable2.Checked = True Then
            chkTable2.BackColor = Color.CornflowerBlue

        Else

            chkTable2.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable3.Checked = True Then
            chkTable3.BackColor = Color.CornflowerBlue

        Else

            chkTable3.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable4.Checked = True Then
            chkTable4.BackColor = Color.CornflowerBlue

        Else

            chkTable4.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable5.Checked = True Then
            chkTable5.BackColor = Color.CornflowerBlue

        Else

            chkTable5.BackColor = Color.FromArgb(64, 64, 64)
        End If

        If chkTable6.Checked = True Then
            chkTable6.BackColor = Color.CornflowerBlue

        Else

            chkTable6.BackColor = Color.FromArgb(64, 64, 64)
        End If




    End Sub



    Private Sub Reservation_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub mskContactNo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskContactNo.MaskInputRejected

    End Sub

    Private Sub dtpResDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpResDate.ValueChanged

        chkTable1.Checked = False
        chkTable2.Checked = False
        chkTable3.Checked = False
        chkTable4.Checked = False
        chkTable5.Checked = False
        chkTable6.Checked = False

        If chkTable1.Checked = False Then
            With chkTable1
                .BackColor = Color.FromArgb(64, 64, 64)
                .Text = "Table 1"
                .ForeColor = Color.White
                .Enabled = True
            End With

        End If

        If chkTable2.Checked = False Then
            With chkTable2
                .BackColor = Color.FromArgb(64, 64, 64)
                .Text = "Table 2"
                .ForeColor = Color.White
                .Enabled = True
            End With

        End If

        If chkTable3.Checked = False Then
            With chkTable3
                .BackColor = Color.FromArgb(64, 64, 64)
                .Text = "Table 3"
                .ForeColor = Color.White
                .Enabled = True
            End With

        End If

        If chkTable4.Checked = False Then
            With chkTable4
                .BackColor = Color.FromArgb(64, 64, 64)
                .Text = "Table 4"
                .ForeColor = Color.White
                .Enabled = True
            End With

        End If

        If chkTable5.Checked = False Then
            With chkTable5
                .BackColor = Color.FromArgb(64, 64, 64)
                .Text = "Table 5"
                .ForeColor = Color.White
                .Enabled = True
            End With

        End If

        If chkTable6.Checked = False Then
            With chkTable6
                .BackColor = Color.FromArgb(64, 64, 64)
                .Text = "Table 6"
                .ForeColor = Color.White
                .Enabled = True
            End With

        End If

        Dim db As New restaurantDataContext
        lstvData.Items.Clear()

        For Each s In db.Reservations
            If (s.Reservation_DateTime_Start.Value.ToShortDateString = dtpResDate.Value.ToShortDateString) Then

                Dim item As New ListViewItem(s.Reservation_ID.ToString)
                item.SubItems.Add(s.Reservation_DateTime_Start.Value.ToShortTimeString)
                item.SubItems.Add(s.Reservation_DateTime_End_.Value.ToShortTimeString)
                item.SubItems.Add(s.Table_No.ToString)
                lstvData.Items.Add(item)


            End If

        Next
    End Sub

    Private Sub lstvData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvData.SelectedIndexChanged


    End Sub

    Private Sub lstvData_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles lstvData.ContextMenuStripChanged


    End Sub

    Private Sub lstvData_DoubleClick(sender As Object, e As EventArgs) Handles lstvData.DoubleClick

        Dim resid As String = lstvData.SelectedItems.Item(0).SubItems(3).Text


        If resid = "1" Then
            chkTable1.Enabled = False
            chkTable1.Text = "Booked"

        ElseIf resid = "2" Then
            chkTable2.Enabled = False
            chkTable2.Text = "Booked"

        ElseIf resid = "3" Then
            chkTable3.Enabled = False
            chkTable3.Text = "Booked"

        ElseIf resid = "4" Then
            chkTable4.Enabled = False
            chkTable4.Text = "Booked"

        ElseIf resid = "5" Then
            chkTable5.Enabled = False
            chkTable5.Text = "Booked"

        ElseIf resid = "6" Then
            chkTable6.Enabled = False
            chkTable6.Text = "Booked"

        Else

            chkTable6.Enabled = True
            chkTable6.Text = "Table 6"

            chkTable5.Enabled = True
            chkTable5.Text = "Table 5"

            chkTable4.Enabled = True
            chkTable4.Text = "Table 4"

            chkTable3.Enabled = True
            chkTable3.Text = "Table 3"

            chkTable2.Enabled = True
            chkTable2.Text = "Table 2"

            chkTable1.Enabled = True
            chkTable1.Text = "Table 1"


        End If
    End Sub
End Class