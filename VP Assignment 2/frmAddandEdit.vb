Imports System.Data.SqlClient
Imports System.IO
Public Class frmAddandEdit

    'Private con As New SqlConnection
    Private sqlquery As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private strImagelocation As String = "", strFileName As String = ""

    Private Sub frmAddandEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        Try

            Dim dlgPicture As New OpenFileDialog

            dlgPicture.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp"

            If (dlgPicture.ShowDialog = DialogResult.OK) Then

                strImagelocation = dlgPicture.FileName

                strFileName = Path.GetFileName(strImagelocation)

                picBox.ImageLocation = strImagelocation

            End If

        Catch ex As Exception

            MessageBox.Show("Error uploading picture")
            picBox.Image = Nothing
            strImagelocation = ""
            strFileName = ""

        End Try

    End Sub

    Private Sub frmAddandEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub Clearall()

        txtFoodName.Clear()
        mskPrice.Clear()
        picBox.Image = Nothing
        strImagelocation = ""
        txtFoodName.Select()
        radAppetizer.Checked = False
        radAvailable.Checked = False
        radBeverage.Checked = False
        radDessert.Checked = False
        radDrink.Checked = False
        radMaincourse.Checked = False
        radUnavailable.Checked = False


    End Sub

    Private Sub btnClearpic_Click(sender As Object, e As EventArgs) Handles btnClearpic.Click

        strImagelocation = ""
        strFileName = ""
        picBox.Image = Nothing


    End Sub

    Private Function GetFoodCategory() As String

        Dim strFoodCategory As String = ""

        If (radAppetizer.Checked = True) Then

            strFoodCategory = "Appetizers"

        ElseIf (radBeverage.Checked = True) Then

            strFoodCategory = "Beverage"

        ElseIf (radDrink.Checked = True) Then

            strFoodCategory = "Drinks"

        ElseIf (radDessert.Checked = True) Then

            strFoodCategory = "Desserts"

        Else

            strFoodCategory = "Main Meal"

        End If

        Return strFoodCategory

    End Function


    Private Function GetNewFoodID(strFood As String) As String

        Dim strFoodID As String = ""

        Try

            Dim intTotalFoodIDs As Integer = 0
            Dim cmd As SqlCommand = con.CreateCommand()

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select ItemId from Menu where ItemCategory = @FoodCategory"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@FoodCategory", strFood)
            cmd.ExecuteNonQuery()

            Using da As New SqlDataAdapter(cmd)

                ds.Clear()
                da.Fill(ds, "Total")
                intTotalFoodIDs = ds.Tables("Total").Rows.Count()

            End Using

            Select Case strFood
                Case "Appetizers"
                    strFood = "A"
                Case "Beverage"
                    strFood = "B"
                Case "Drinks"
                    strFood = "D"
                Case "Desserts"
                    strFood = "S"
                Case "Main Meal"
                    strFood = "M"
            End Select

            strFoodID = strFood + ((intTotalFoodIDs + 1).ToString)

        Catch ex As Exception

            MessageBox.Show("Error retrieving Food ID")

        End Try

        Return strFoodID

    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try

            Dim intErrorCount As Integer = 0
            Dim strErrorMessage As String = ""

            If (picBox.Image Is Nothing) Then
                intErrorCount += 1
                strErrorMessage += "Empty Picture" + vbCrLf
            End If

            If (txtFoodName.Text = "" Or mskPrice.Text = "") Then
                intErrorCount += 1
                strErrorMessage += "Empty Food Name or Price" + vbCrLf
            End If

            If (radAvailable.Checked = False And radUnavailable.Checked = False) Then
                intErrorCount += 1
                strErrorMessage += "Availability is not selected" + vbCrLf
            End If

            If (radAppetizer.Checked = False And radBeverage.Checked = False And radDessert.Checked = False And
                radDrink.Checked = False And
                radMaincourse.Checked = False
                ) Then
                intErrorCount += 1
                strErrorMessage += "Food Category is not selected" + vbCrLf
            End If

            If (intErrorCount > 0) Then

                MessageBox.Show("You have the following errors: " + vbCrLf + strErrorMessage, "Error Message", MessageBoxButtons.OK)

            Else

                If (Openconnection() = True) Then

                    Dim strFoodID As String = ""
                    Dim cmd As SqlCommand = con.CreateCommand()
                    Dim strFoodCategory As String = GetFoodCategory()
                    Dim strPrice As String = ""
                    Dim strAvailability As String = ""
                    Dim strSavePictureLocation As String = ""

                    If (radAvailable.Checked = True) Then
                        strAvailability = "Available"
                    Else
                        strAvailability = "Unavailable"
                    End If

                    Select Case strFoodCategory
                        Case "Appetizers"
                            strSavePictureLocation = "\Pictures\Appetizers\"
                        Case "Beverage"
                            strSavePictureLocation = "\Pictures\Beverages\"
                        Case "Drinks"
                            strSavePictureLocation = "\Pictures\Drinks\"
                        Case "Desserts"
                            strSavePictureLocation = "\Pictures\Desserts\"
                        Case "Main Meal"
                            strSavePictureLocation = "\Pictures\Main courses\"
                    End Select

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Insert into Menu (ItemId, ItemName, ItemPrice, ItemCategory, Status, Filepath) values (@FoodID,@FoodName,@FoodPrice,@FoodCategory,@Status,@Filepath)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@FoodID", GetNewFoodID(strFoodCategory))
                    cmd.Parameters.AddWithValue("@FoodName", txtFoodName.Text)
                    cmd.Parameters.AddWithValue("@FoodPrice", mskPrice.Text)
                    cmd.Parameters.AddWithValue("@FoodCategory", strFoodCategory)
                    cmd.Parameters.AddWithValue("@Status", strAvailability)
                    cmd.Parameters.AddWithValue("@Filepath", strSavePictureLocation + strFileName)
                    cmd.ExecuteNonQuery()

                    picBox.Image.Save(System.IO.Path.GetDirectoryName(Application.ExecutablePath).Replace("bin\Debug", strSavePictureLocation + strFileName))

                    MessageBox.Show("Added successfully", "Insertion Status")

                End If
            End If

        Catch ex As Exception

            MessageBox.Show("Error adding into database")

        Finally

            Clearall()
            Closeconnection()


        End Try



    End Sub

    Private Sub txtFoodName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFoodName.Validating

        'If (String.IsNullOrEmpty(txtFoodName.Text)) Then

        '    e.Cancel = True

        '    txtFoodName.Select()

        '    err.SetError(txtFoodName, "Please enter food name!")

        'Else

        '    e.Cancel = False

        '    err.SetError(txtFoodName, "")

        'End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Clearall()

    End Sub

    'Try

    'If (txtFoodName.Text = "" Or mskPrice.Text = "") Then

    '            MessageBox.Show("Please enter food name and food price", "Error Message", MessageBoxButtons.OK)

    '        Else

    'If (Openconnection() = True) Then

    'Dim strFoodID As String = ""
    'Dim cmd As SqlCommand = con.CreateCommand()
    'Dim strCategory As String = ""
    'Dim strPrice As String = ""
    'Dim strAvailability As String = ""
    'Dim strFilepath As String = ""

    '                strFoodID = frmFoodmanagement.strSelectedFoodID

    '                If (radAvailable.Checked = True) Then
    '                    strAvailability = "Available"
    '                Else
    '                    strAvailability = "Unavailable"
    '                End If

    '                ' strCategory = GetFoodCategory(strFoodID)

    '                cmd.CommandType = CommandType.Text
    '                cmd.CommandText = "Update Menu Set ItemName = @FoodName, ItemPrice = @FoodPrice, Status = @Availability, Filepath = @Imagelocation Where ItemID = @FoodID"
    '                Using da As New SqlDataAdapter(cmd)

    '                    cmd.Parameters.AddWithValue("@FoodID", strFoodID)
    '                    cmd.Parameters.AddWithValue("@FoodName", txtFoodName.Text)
    '                    cmd.Parameters.AddWithValue("@FoodPrice", mskPrice.Text)
    '                    cmd.Parameters.AddWithValue("@Availability", strAvailability)
    '                    cmd.Parameters.AddWithValue("@Imagelocation", strImagelocation)
    '                    cmd.ExecuteNonQuery()

    '                End Using

    '                Closeconnection()

    '                MessageBox.Show("Updated Successfully", "Update Status")

    '            End If

    'End If

    'Catch ex As Exception

    '        MessageBox.Show("Error reading & updating database")
    '        Closeconnection()
    '    Finally

    '        frmFoodmanagement.Keeplog("Edit", frmFoodmanagement.strSelectedFoodID)

    '    End Try

End Class