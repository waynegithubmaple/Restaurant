Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class frmFoodmanagement

    'Private con As New SqlConnection
    Private sqlquery As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private strStoresearch As String
    Private strStoresearch2 As String
    Private blnSearchmode As Boolean = False
    Private strImageLocation As String = ""
    Friend strSelectedFoodID As String
    Friend NewMaincourseFoodID, NewAppetizerFoodID, NewBeverageFoodID, NewDessertFoodID, NewDrinkFoodID As String
    Friend charAddorEdit As Char

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If (txtSearch.Text = "") Then

            MessageBox.Show("You need to type something into the search box", "Error Message", MessageBoxButtons.OK)

        Else

            strStoresearch = txtSearch.Text

            Normalclear()

            Try

                If Openconnection() = True Then

                    Dim cmd As SqlCommand = con.CreateCommand()
                    Dim intRowCount As Integer = 0

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Select * from Menu Where ItemName LIKE '%' + @Foodname + '%'"
                    Using da As New SqlDataAdapter(cmd)

                        cmd.Parameters.AddWithValue("@Foodname", txtSearch.Text)
                        cmd.ExecuteNonQuery()
                        ds.Clear()
                        da.Fill(ds, "Menu")

                    End Using

                    If ds.Tables("Menu").Rows.Count > 0 Then

                        Dim strReadFoodID As String
                        Dim strReadFoodName As String

                        intRowCount = ds.Tables("Menu").Rows.Count

                        For Start As Integer = 0 To intRowCount - 1

                            strReadFoodID = ds.Tables("Menu").Rows(Start).Item(0).ToString()
                            strReadFoodName = ds.Tables("Menu").Rows(Start).Item(1).ToString()
                            lstFoodname.Items.Add(strReadFoodID + " , " + strReadFoodName)

                        Next


                    End If

                    lblLoadcount.Text = intRowCount.ToString() & " items loaded"
                    blnSearchmode = True
                    txtSearch.Clear()
                    Closeconnection()

                End If

            Catch ex As Exception

                MessageBox.Show("Please insert texts into Search textbox")

            Finally

                Keeplog("Search", strStoresearch)

            End Try

        End If

    End Sub

    Friend Sub Keeplog(Type As String, Data As String)

        Dim strType As String = Type
        Dim strData As String = Data
        Dim strActivity As String = Type + " - " + Data
        Dim strIDgen As String
        Dim strID As String

        strIDgen = System.Guid.NewGuid.ToString()
        strID = Microsoft.VisualBasic.Mid(strIDgen, 27)
        Dim strDay As String = DateTime.Now.ToString("dd")
        Dim strMonth As String = DateTime.Now.ToString("MMMM")
        Dim strYear As String = DateTime.Now.ToString("yyyy")
        Dim strTime As String = DateTime.Now.ToString("hh:mm:ss tt")

        If (Openconnection() = True) Then

            Dim cmd As SqlCommand = con.CreateCommand()

            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into Foodlog (ID, ActivityType , Day, Month, Year, Time) values (@ID,@Activity,@Day,@Month,@Year,@Time)"
            Using da As New SqlDataAdapter(cmd)

                cmd.Parameters.AddWithValue("@ID", strID)
                cmd.Parameters.AddWithValue("@Activity", strActivity)
                cmd.Parameters.AddWithValue("@Day", strDay)
                cmd.Parameters.AddWithValue("@Month", strMonth)
                cmd.Parameters.AddWithValue("@Year", strYear)
                cmd.Parameters.AddWithValue("@Time", strTime)
                cmd.ExecuteNonQuery()

            End Using

            Closeconnection()

        End If

    End Sub

    Private Sub Refreshaftersearchdelete(Searchtext As String)

        Normalclear()

        Try

            If Openconnection() = True Then

                Dim cmd As SqlCommand = con.CreateCommand()
                Dim intRowCount As Integer = 0

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * from Menu Where ItemName LIKE '%' + @Foodname + '%'"
                Using da As New SqlDataAdapter(cmd)

                    cmd.Parameters.AddWithValue("@Foodname", Searchtext)
                    cmd.ExecuteNonQuery()
                    ds.Clear()
                    da.Fill(ds, "Menu")

                End Using

                If ds.Tables("Menu").Rows.Count > 0 Then

                    Dim strReadFoodID As String
                    Dim strReadFoodName As String

                    intRowCount = ds.Tables("Menu").Rows.Count

                    For Start As Integer = 0 To intRowCount - 1

                        strReadFoodID = ds.Tables("Menu").Rows(Start).Item(0).ToString()
                        strReadFoodName = ds.Tables("Menu").Rows(Start).Item(1).ToString()
                        lstFoodname.Items.Add(strReadFoodID + " , " + strReadFoodName)

                    Next


                End If

                lblLoadcount.Text = intRowCount.ToString() & " items loaded"
                blnSearchmode = True
                txtSearch.Clear()
                Closeconnection()

            End If

        Catch ex As Exception

            MessageBox.Show("Please insert texts into Search textbox")

        End Try


    End Sub

    Private Sub Normalclear()

        lstFoodname.Items.Clear()
        lblFoodname.Text = ""
        lblCategory.Text = ""
        picAvailability.Image = Nothing
        lblPrice.Text = ""
        lblLoadcount.Text = "0 Items loaded"

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        picBox.Image = Nothing
        Normalclear()

        If Openconnection() = True Then

            Dim intRowCount As Integer = 0

            sqlquery = "Select * from Menu"
            da = New SqlDataAdapter(sqlquery, con)
            ds.Clear()
            da.Fill(ds, "Menu")

            If ds.Tables("Menu").Rows.Count > 0 Then

                Dim strReadFoodID As String
                Dim strReadFoodName As String

                intRowCount = ds.Tables("Menu").Rows.Count

                For Start As Integer = 0 To intRowCount - 1

                    strReadFoodID = ds.Tables("Menu").Rows(Start).Item(0).ToString()
                    strReadFoodName = ds.Tables("Menu").Rows(Start).Item(1).ToString()
                    lstFoodname.Items.Add(strReadFoodID + " , " + strReadFoodName)

                Next

            End If

            lblLoadcount.Text = intRowCount.ToString() & " Items loaded"

            blnSearchmode = False
            Closeconnection()

        Else

            MessageBox.Show("Error reading database")

        End If

    End Sub

    Private Sub lstFoodname_Click(sender As Object, e As EventArgs) Handles lstFoodname.Click

        Dim intIndex As Integer
        Dim strFoodstring As String
        Dim strFoodID As String = ""
        Dim charFoodID As Char

        Try

            intIndex = lstFoodname.SelectedIndex
            strFoodstring = lstFoodname.Items(intIndex).ToString

            For Start = 0 To 3

                charFoodID = strFoodstring.ElementAt(Start)
                strFoodID += charFoodID

            Next

            If (Openconnection() = True) Then

                Dim cmd As SqlCommand = con.CreateCommand()
                Dim strFoodName As String = ""
                Dim strFoodCategory As String = ""
                Dim decPrice As Decimal
                Dim strAvailability As String = ""
                Dim strFilepath As String = ""

                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Select * from Menu Where ItemID = @FoodID"
                Using da As New SqlDataAdapter(cmd)

                    cmd.Parameters.AddWithValue("@FoodID", strFoodID)
                    cmd.ExecuteNonQuery()
                    ds.Clear()
                    da.Fill(ds, "Menu")

                End Using

                Dim Reader = cmd.ExecuteReader
                While Reader.Read()

                    strFoodName = Reader("ItemName").ToString()
                    strFoodCategory = Reader("ItemCategory").ToString()
                    decPrice = Convert.ToDecimal(Reader("ItemPrice"))
                    strAvailability = Reader("Status").ToString()
                    strFilepath = Reader("Filepath").ToString()

                End While

                Closeconnection()

                Dim strPicPath As String = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Replace("bin\Debug", "\Pictures\Available.png")

                lblFoodname.Text = strFoodName
                lblCategory.Text = strFoodCategory
                lblPrice.Text = decPrice.ToString()
                If (strAvailability = "Available") Then

                    picAvailability.ImageLocation = strPicPath

                Else

                    picAvailability.ImageLocation = strPicPath.Replace("Available.png", "Unavailable.png")

                End If

                strImageLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath).Replace("bin\Debug", strFilepath)

                picBox.ImageLocation = strImageLocation

            Else


            End If

        Catch ex As Exception

            MessageBox.Show("You have not clicked anything")
        Finally

            strSelectedFoodID = strFoodID

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

        charAddorEdit = Convert.ToChar("A")

        frmAddandEdit.ShowDialog()

    End Sub

    'Private Sub btnEdit_Click(sender As Object, e As EventArgs)

    '    Dim intIndex As Integer

    '    Try

    '        intIndex = lstFoodname.SelectedIndex

    '        If (intIndex = -1) Then

    '            MessageBox.Show("You have not selected any items in the list")

    '        Else

    '            charAddorEdit = Convert.ToChar("E")

    '            frmAddandEdit.ShowDialog()

    '        End If

    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub btnExit_Click(sender As Object, e As EventArgs)

    '    Closeconnection()

    '    Me.Close()

    'End Sub

    Private Sub frmFoodmanagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try

            Closeconnection()

        Catch ex As Exception

            MessageBox.Show("Connection has been closed already")

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim intIndex As Integer
        Dim strFoodstring As String
        Dim strFoodID As String = ""
        strStoresearch2 = strStoresearch

        Try
            intIndex = lstFoodname.SelectedIndex

            If (intIndex = -1) Then

                MessageBox.Show("You have not clicked on any food item yet")

            Else

                strFoodstring = lstFoodname.Items(intIndex).ToString

                strFoodID = (strFoodstring.Substring(0, strFoodstring.IndexOf(","))).Trim()

                Dim dlgResponse As DialogResult

                dlgResponse = MessageBox.Show("You are going to delete " + strFoodstring + " , Confirm to delete?", "Item Deletion", MessageBoxButtons.OKCancel)

                If (dlgResponse = DialogResult.OK) Then

                    If (Openconnection() = True) Then

                        Dim cmd As SqlCommand = con.CreateCommand()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "Delete from Menu Where ItemID = @FoodID"

                        Using da As New SqlDataAdapter(cmd)

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@FoodID", strFoodID)
                            cmd.ExecuteNonQuery()

                        End Using

                        File.Delete(strImageLocation)

                        Closeconnection()

                        Keeplog("Delete", strFoodID)

                        If blnSearchmode = True Then

                            Refreshaftersearchdelete(strStoresearch2)

                        Else

                            btnLoad_Click(sender, e)

                        End If

                    Else

                        MessageBox.Show("Error connecting to database")
                        Closeconnection()

                    End If
                End If
            End If

        Catch ex As Exception

            Closeconnection()
            Keeplog("Failed Deletion", strFoodID)
            ShowOrderNoToDelete(strFoodID)

        Finally

            picBox.Image = Nothing
            strImageLocation = ""

        End Try

    End Sub

    Private Sub ShowOrderNoToDelete(strFoodID As String)

        If Openconnection() = True Then

            Dim intRowCount As Integer = 0

            Dim cmd As SqlCommand = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select DISTINCT o.OrderNo from Menu m JOIN Orderitems o ON m.Itemid = o.Itemid Where o.Itemid = @FoodID"

            Using da As New SqlDataAdapter(cmd)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@FoodID", strFoodID)
                cmd.ExecuteNonQuery()
                ds.Clear()
                da.Fill(ds, "Orderitems")

            End Using

            If ds.Tables("Orderitems").Rows.Count > 0 Then

                Dim strReadOrderID As String
                Dim strReadOrderIDspace As String
                Dim strFullMessage As String = "Receipts under these order numbers must be deleted to remove " + strFoodID + vbCrLf + vbCrLf

                intRowCount = ds.Tables("Orderitems").Rows.Count

                For Start As Integer = 0 To intRowCount - 1

                    strReadOrderID = ds.Tables("Orderitems").Rows(Start).Item(0).ToString()
                    strReadOrderIDspace = "Order Number: " & strReadOrderID & vbCrLf
                    strFullMessage += strReadOrderIDspace
                Next

                MessageBox.Show(strFullMessage, "Guide to delete " + strFoodID)

            End If

            Closeconnection()

        Else

            MessageBox.Show("Error reading database")
            Closeconnection()

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        'strSearchtext = txtSearch.Text

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        blnSearchmode = False
        txtSearch.Clear()
        lstFoodname.Items.Clear()
        lblFoodname.Text = ""
        lblCategory.Text = ""
        picAvailability.Image = Nothing
        picBox.Image = Nothing
        lblPrice.Text = ""
        lblLoadcount.Text = "0 Items loaded"


    End Sub

    Private Sub btnGeneratereport_Click(sender As Object, e As EventArgs)

        'frmFoodManagementlog.ShowDialog()

    End Sub

    Private Sub txtSearch_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSearch.Validating

        'If (String.IsNullOrEmpty(txtSearch.Text)) Then

        '    e.Cancel = True

        '    txtSearch.Select()

        '    err.SetError(txtSearch, "Please enter text into search box!")

        'Else

        '    e.Cancel = False

        '    err.SetError(txtSearch, "")

        'End If


    End Sub



    Private Sub frmFoodmanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSearch.Select()

    End Sub
End Class