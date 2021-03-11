Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class FrmStaffRUProfile

    Public Property id777 As String
    Public Property name777 As String
    Dim id As String = id777

    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private currentRow As Integer = 0

    'Private con As New SqlConnection



    Private Sub btnBack_Click(sender As Object, e As EventArgs)

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


        If Openconnection() = True Then
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

            Closeconnection()

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
        Dim formatEmail As String
        Dim formatName As String
        formatEmail = "^([0-9a-zA-z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        formatName = "^[a-zA-Z ]*$"
        If txtName.Text = String.Empty Then
            MessageBox.Show("Name field cannot be empty. Please fill in your name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Regex.IsMatch(txtName.Text, formatName) = False Then
            MessageBox.Show("Format of the name is incorrect. The name should not contain any number or symbol. Please fill in your name again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtContact.MaskCompleted = False Then
            MessageBox.Show("Contact field cannot be empty. Please fill in your contact number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtEmail.Text = String.Empty Then
            MessageBox.Show("Email field cannot be empty. Please fill in your Email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Regex.IsMatch(txtEmail.Text, formatEmail) = False Then
            MessageBox.Show("Format of the email is incorrect. Please fill in your email again.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf RichTextBoxAddress.Text = String.Empty Then
            MessageBox.Show("Address field cannot be empty. Please fill in your address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Openconnection() = True Then

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
            MessageBox.Show("Record updated.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            viewOnly()

        End If

        Closeconnection()



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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Restart()
    End Sub


End Class