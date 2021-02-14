Imports System.Data.SqlClient
Public Class frmAddandEdit

    'Private con As New SqlConnection
    Private sqlquery As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private strImagelocation As String = ""

    Private Sub frmAddandEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

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

            strFoodID = strFood.Substring(0, 2) + ((intTotalFoodIDs + 1).ToString)

        Catch ex As Exception

            MessageBox.Show("Error retrieving Food ID")

        End Try

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
                    Dim strFoodCategory As String = GetFoodCategory()
                    Dim strPrice As String = ""
                    Dim strAvailability As String = ""
                    Dim strFilepath As String = ""

                    If (radAvailable.Checked = True) Then
                        strAvailability = "Available"
                    Else
                        strAvailability = "Unavailable"
                    End If

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Insert into Menu (ItemId, ItemName, ItemPrice, ItemCategory, Status, Filepath) values (@FoodID,@FoodName,@FoodPrice,@FoodCategory,@Status,@Filepath)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@FoodID", GetNewFoodID(strFoodCategory))
                    cmd.Parameters.AddWithValue("@FoodName", txtFoodName.Text)
                    cmd.Parameters.AddWithValue("@FoodPrice", mskPrice.Text)
                    cmd.Parameters.AddWithValue("@FoodCategory", strFoodCategory)
                    cmd.Parameters.AddWithValue("@Status", strAvailability)
                    cmd.Parameters.AddWithValue("@Filepath", strImagelocation)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Added successfully", "Insertion Status")

                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error adding into database1")

        Finally

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
End Class