
Imports System.Data.SqlClient
Public Class FrmStaffRUProfile

    Public Property id777 As String
    Public Property name777 As String
    Dim id As String = id777

    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private currentRow As Integer = 0

    'Private con As New SqlConnection



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FrmStaffRU.Show()
        Me.Hide()

    End Sub
    Private Sub FrmStaffRUProfile_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtID.Text = id777
        profile()
        viewOnly()

    End Sub

    Private Sub profile()
        Dim sql As String
        Dim MySqlCommand As New SqlCommand


        Dim id111 As String = txtID.Text


        If OpenConnection() = True Then
            sql = "Select * From Staff2 Where Id ='" & txtID.Text & "'"
            da = New SqlDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Staff2")



            If ds.Tables("Staff2").Rows.Count > 0 Then


                'id111 = ds.Tables("Staff2").Rows(currentRow).Item(0)
                txtName.Text = ds.Tables("Staff2").Rows(currentRow).Item(1).ToString
                lblIC.Text = ds.Tables("Staff2").Rows(currentRow).Item(2).ToString
                lblGender.Text = ds.Tables("Staff2").Rows(currentRow).Item(3).ToString
                txtContact.Text = ds.Tables("Staff2").Rows(currentRow).Item(4).ToString
                txtEmail.Text = ds.Tables("Staff2").Rows(currentRow).Item(5).ToString
                RichTextBoxAddress.Text = ds.Tables("Staff2").Rows(currentRow).Item(6).ToString


            End If

            CloseConnection()

        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (btnUpdate.Text = "E&dit") Then


            openTxt()
        Else

            update()

        End If
    End Sub


    Private Sub update()

        Dim MySqlCommand As New SqlCommand
        Dim sql As String

        If OpenConnection() = True Then

            sql = "Update Staff2 set Name=@name, Ic=@ic, Gender=@gender, Contact=@contact, Email=@email, Address=@address Where Id=@id"
            MySqlCommand = New SqlCommand(sql, con)
            MySqlCommand.Parameters.AddWithValue("@id", txtID.Text)
            MySqlCommand.Parameters.AddWithValue("@name", txtName.Text)
            MySqlCommand.Parameters.AddWithValue("@ic", lblIC.Text)
            MySqlCommand.Parameters.AddWithValue("@gender", lblGender.Text)
            MySqlCommand.Parameters.AddWithValue("@contact", txtContact.Text)
            MySqlCommand.Parameters.AddWithValue("@email", txtEmail.Text)
            MySqlCommand.Parameters.AddWithValue("@address", RichTextBoxAddress.Text)
            MySqlCommand.ExecuteNonQuery()
            MessageBox.Show("Record updated.", "Update Record")
            viewOnly()

        End If

        CloseConnection()



    End Sub


    Private Sub viewOnly()
        txtName.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False
        RichTextBoxAddress.Enabled = False
        btnUpdate.Text = "E&dit"

    End Sub

    Private Sub openTxt()
        txtName.Enabled = True
        txtContact.Enabled = True
        txtEmail.Enabled = True
        RichTextBoxAddress.Enabled = True
        btnUpdate.Text = "&Update"
    End Sub
End Class