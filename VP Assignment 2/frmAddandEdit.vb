Imports System.Data.SqlClient
Public Class frmAddandEdit

    'Private con As New SqlConnection
    Private sqlquery As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private strImagelocation As String = ""

    Private Sub frmAddandEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If frmFoodmanagement.charAddorEdit = "A" Then

        '    btnAdd.Enabled = True
        '    btnSubmit.Enabled = False
        '    radAppetizer.Enabled = True
        '    radBeverage.Enabled = True
        '    radMaincourse.Enabled = True
        '    radDrink.Enabled = True
        '    radDessert.Enabled = True
        '    Clearall()

        'Else

        '    btnSubmit.Enabled = True
        '    btnAdd.Enabled = False
        '    radAppetizer.Enabled = False
        '    radBeverage.Enabled = False
        '    radMaincourse.Enabled = False
        '    radDrink.Enabled = False
        '    radDessert.Enabled = False

        '    Try

        '        If (Openconnection() = True) Then

        '            Dim strFoodID As String = ""
        '            Dim strFoodName As String = ""
        '            Dim charCategory As Char = Nothing
        '            Dim decPrice As Decimal
        '            Dim strAvailability As String = ""
        '            Dim cmd As SqlCommand = con.CreateCommand()

        '            strFoodID = frmFoodmanagement.strSelectedFoodID

        '            cmd.CommandType = CommandType.Text
        '            cmd.CommandText = "Select * from Menu Where ItemID = @FoodID"
        '            Using da As New SqlDataAdapter(cmd)

        '                cmd.Parameters.AddWithValue("@FoodID", strFoodID)
        '                cmd.ExecuteNonQuery()
        '                ds.Clear()
        '                da.Fill(ds, "Menu")

        '            End Using

        '            Dim Reader = cmd.ExecuteReader
        '            While Reader.Read()

        '                strFoodName = Reader("ItemName").ToString()
        '                decPrice = Convert.ToDecimal(Reader("ItemPrice"))
        '                strAvailability = Reader("Status").ToString()
        '                strImagelocation = Reader("Filepath").ToString()

        '            End While

        '            txtFoodName.Text = strFoodName

        '            mskPrice.Text = decPrice.ToString()

        '            If (strAvailability = "Available") Then

        '                radAvailable.Checked = True

        '            Else

        '                radUnavailable.Checked = True

        '            End If

        '            charCategory = strFoodID.ElementAt(0)

        '            Select Case (charCategory)
        '                Case Convert.ToChar("A")
        '                    radAppetizer.Checked = True
        '                    Exit Select
        '                Case Convert.ToChar("B")
        '                    radBeverage.Checked = True
        '                    Exit Select
        '                Case Convert.ToChar("D")
        '                    radDrink.Checked = True
        '                    Exit Select
        '                Case Convert.ToChar("M")
        '                    radMaincourse.Checked = True
        '                    Exit Select
        '                Case Convert.ToChar("S")
        '                    radDessert.Checked = True
        '                    Exit Select
        '            End Select

        '            picBox.ImageLocation = strImagelocation

        '            Closeconnection()

        '        Else

        '        End If

        '    Catch ex As Exception

        '        MessageBox.Show("Error reading database")
        '        Closeconnection()

        '    End Try

        'End If


    End Sub

    Private Function GetFoodCategory(strFoodID As String) As String

        Dim charCategory As Char
        Dim strFoodCategory As String
        strFoodCategory = strFoodID

        charCategory = strFoodCategory.ElementAt(0)

        Select Case (charCategory)
            Case Convert.ToChar("A")
                strFoodCategory = "Appetizers"
                Exit Select
            Case Convert.ToChar("B")
                strFoodCategory = "Beverages"
                Exit Select
            Case Convert.ToChar("D")
                strFoodCategory = "Drinks"
                Exit Select
            Case Convert.ToChar("M")
                strFoodCategory = "Main Meal"
                Exit Select
            Case Convert.ToChar("S")
                strFoodCategory = "Desserts"
                Exit Select
        End Select

        Return strFoodCategory

    End Function

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Try

            Dim dlgPicture As New OpenFileDialog

            dlgPicture.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp"

            If (dlgPicture.ShowDialog = DialogResult.OK) Then

                strImagelocation = dlgPicture.FileName

                picBox.ImageLocation = strImagelocation

            End If

        Catch ex As Exception

            MessageBox.Show("Error uploading picture")
            picBox.Image = Nothing
            strImagelocation = ""

        End Try

    End Sub

    Private Sub frmAddandEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'frmFoodmanagement.GetNewFoodID()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'If (frmFoodmanagement.charAddorEdit = "A") Then

        '    txtFoodName.Clear()
        '    radMaincourse.Checked = True
        '    mskPrice.Clear()
        '    radAvailable.Checked = True

        'Else

        '    txtFoodName.Clear()
        '    mskPrice.Clear()
        '    radAvailable.Checked = True

        'End If

    End Sub

    Private Sub Clearall()

        txtFoodName.Clear()
        radMaincourse.Checked = True
        mskPrice.Clear()
        radAvailable.Checked = True
        picBox.Image = Nothing
        strImagelocation = ""
        txtFoodName.Select()

    End Sub

    Private Sub btnClearpic_Click(sender As Object, e As EventArgs) Handles btnClearpic.Click

        strImagelocation = ""
        picBox.Image = Nothing

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try

            If (txtFoodName.Text = "" Or mskPrice.Text = "") Then

                MessageBox.Show("Please enter food name and food price", "Error Message", MessageBoxButtons.OK)

            Else

                'If (Openconnection() = True) Then

                '    Dim strFoodID As String = ""
                '    Dim cmd As SqlCommand = con.CreateCommand()
                '    Dim strCategory As String = ""
                '    Dim strPrice As String = ""
                '    Dim strAvailability As String = ""
                '    Dim strFilepath As String = ""

                '    strFoodID = frmFoodmanagement.strSelectedFoodID

                '    If (radAvailable.Checked = True) Then
                '        strAvailability = "Available"
                '    Else
                '        strAvailability = "Unavailable"
                '    End If

                '    ' strCategory = GetFoodCategory(strFoodID)

                '    cmd.CommandType = CommandType.Text
                '    cmd.CommandText = "Update Menu Set ItemName = @FoodName, ItemPrice = @FoodPrice, Status = @Availability, Filepath = @Imagelocation Where ItemID = @FoodID"
                '    Using da As New SqlDataAdapter(cmd)

                '        cmd.Parameters.AddWithValue("@FoodID", strFoodID)
                '        cmd.Parameters.AddWithValue("@FoodName", txtFoodName.Text)
                '        cmd.Parameters.AddWithValue("@FoodPrice", mskPrice.Text)
                '        cmd.Parameters.AddWithValue("@Availability", strAvailability)
                '        cmd.Parameters.AddWithValue("@Imagelocation", strImagelocation)
                '        cmd.ExecuteNonQuery()

                '    End Using

                '    Closeconnection()

                '    MessageBox.Show("Updated Successfully", "Update Status")

                'End If

            End If

        Catch ex As Exception

            MessageBox.Show("Error reading & updating database")
            Closeconnection()
        Finally

            'frmFoodmanagement.Keeplog("Edit", frmFoodmanagement.strSelectedFoodID)

        End Try

    End Sub

    Friend Function GetFoodID() As String

        Dim strFoodID As String = ""

        'If (radAppetizer.Checked = True) Then

        '    strFoodID = frmFoodmanagement.NewAppetizerFoodID

        'ElseIf (radBeverage.Checked = True) Then

        '    strFoodID = frmFoodmanagement.NewBeverageFoodID

        'ElseIf (radDrink.Checked = True) Then

        '    strFoodID = frmFoodmanagement.NewDrinkFoodID

        'ElseIf (radDessert.Checked = True) Then

        '    strFoodID = frmFoodmanagement.NewDessertFoodID

        'Else

        '    strFoodID = frmFoodmanagement.NewMaincourseFoodID

        'End If

        Return strFoodID

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            If (txtFoodName.Text = "" Or mskPrice.Text = "") Then

                MessageBox.Show("Please enter food name and food price", "Error Message", MessageBoxButtons.OK)

            Else

                If (Openconnection() = True) Then

                    Dim strFoodID As String = ""
                    Dim cmd As SqlCommand = con.CreateCommand()
                    Dim strCategory As String = ""
                    Dim strPrice As String = ""
                    Dim strAvailability As String = ""
                    Dim strFilepath As String = ""

                    strFoodID = GetFoodID()

                    strCategory = GetFoodCategory(strFoodID)

                    If (radAvailable.Checked = True) Then
                        strAvailability = "Available"
                    Else
                        strAvailability = "Unavailable"
                    End If

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Insert into Menu (ItemId, ItemName, ItemPrice, ItemCategory, Status, Filepath) values (@FoodID,@FoodName,@FoodPrice,@FoodCategory,@Status,@Filepath)"
                    Using da As New SqlDataAdapter(cmd)

                        cmd.Parameters.AddWithValue("@FoodID", strFoodID)
                        cmd.Parameters.AddWithValue("@FoodName", txtFoodName.Text)
                        cmd.Parameters.AddWithValue("@FoodPrice", mskPrice.Text)
                        cmd.Parameters.AddWithValue("@FoodCategory", strCategory)
                        cmd.Parameters.AddWithValue("@Status", strAvailability)
                        cmd.Parameters.AddWithValue("@Filepath", strImagelocation)
                        cmd.ExecuteNonQuery()

                    End Using

                    Closeconnection()

                    MessageBox.Show("Added successfully", "Insertion Status")

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error adding into database")

        Finally

            'frmFoodmanagement.Keeplog("Insert", txtFoodName.Text)
            'frmFoodmanagement.GetNewFoodID()
            'Clearall()

        End Try



    End Sub

    Private Sub txtFoodName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFoodName.Validating

        If (String.IsNullOrEmpty(txtFoodName.Text)) Then

            e.Cancel = True

            txtFoodName.Select()

            err.SetError(txtFoodName, "Please enter food name!")

        Else

            e.Cancel = False

            err.SetError(txtFoodName, "")

        End If

    End Sub
End Class