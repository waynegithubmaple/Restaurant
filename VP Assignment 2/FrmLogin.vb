'Imports System.Data.OleDb
Imports System.ComponentModel
Imports System.Data.SqlClient


Public Class FrmLogin
    Public stffid As String

    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private currentRow As Integer = 0



    Dim position As String = ""
    Dim name111 As String
    Dim id111 As String


    'Private con As New SqlConnection

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IDShow()


    End Sub


    Private Sub Search2()
        Dim sql As String
        'Dim id As String = txtLoginID.Text


        If OpenConnection() = True Then
            sql = "Select * From Staff2 Where Id='" & txtLoginID.Text & "'"
            da = New SqlDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Staff2")

            If ds.Tables("Staff2").Rows.Count > 0 Then

                lblError.Text = ""
                'id = ds.Tables("Staff2").Rows(currentRow).Item(0)
                lblShowName.Text = ds.Tables("Staff2").Rows(currentRow).Item(1).ToString
                NameShow()


            Else
                lblError.Text = "Staff Not Found"
                'MessageBox.Show("Staff Not Found", "Not Found", MessageBoxButtons.OK)
            End If
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub IDShow()
        GroupBoxCorrect.Visible = False
        lblShowName.Visible = False
        radNo.Visible = False
        radYes.Visible = False

        '  stffid = txtLoginID.Text


        lblStaffID.Visible = True
        txtLoginID.Visible = True
        txtLoginID.Enabled = True
        txtLoginID.Text = ""

        lblPassword.Visible = False
        txtPassword.Visible = False

        'btnRegister.Visible = True
        btnLogin.Visible = False
        btnNext.Visible = True
    End Sub

    Private Sub NameShow()
        GroupBoxCorrect.Visible = True
        lblShowName.Visible = True
        radNo.Visible = True
        radYes.Visible = True
        radNo.Checked = False
        radYes.Checked = False


        lblStaffID.Visible = True
        txtLoginID.Visible = True
        txtLoginID.Enabled = False

        lblPassword.Visible = False
        txtPassword.Visible = False

        'btnRegister.Visible = True
        btnLogin.Visible = False
        btnNext.Visible = True
    End Sub

    Private Sub IfRadYes()
        GroupBoxCorrect.Visible = True
        lblShowName.Visible = True
        radNo.Visible = True
        radYes.Visible = True


        lblStaffID.Visible = True
        txtLoginID.Visible = True
        txtLoginID.Enabled = False

        lblPassword.Visible = True
        txtPassword.Visible = True
        txtPassword.Text = ""
        txtPassword.Focus()

        'btnRegister.Visible = True
        btnLogin.Visible = True
        btnNext.Visible = False

    End Sub

    Private Sub IfRadNo()
        GroupBoxCorrect.Visible = False
        lblShowName.Visible = False
        radNo.Visible = False
        radYes.Visible = False


        lblStaffID.Visible = True
        txtLoginID.Visible = True
        txtLoginID.Enabled = True

        lblPassword.Visible = False
        txtPassword.Visible = False
        'txtPassword.Focus()


        'btnRegister.Visible = True
        btnLogin.Visible = False
        btnNext.Visible = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If (txtPassword.Text = "") Then
            lblError.Text = "Password cannot be empty!"
            'MsgBox("Password cannot be empty", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Empty Found")
        Else
            lblError.Text = ""
            Login()
        End If




    End Sub


    Private Sub Login()

        Dim sql As String
        Dim MySqlCommand As New SqlCommand
        Dim position As String
        Dim name111 As String



        If OpenConnection() = True Then
            sql = "Select * From Staff2 Where Id ='" & txtLoginID.Text & "' And Password = '" & txtPassword.Text & "'"
            da = New SqlDataAdapter(sql, con)
            ds.Clear()
            da.Fill(ds, "Staff2")



            If ds.Tables("Staff2").Rows.Count > 0 Then


                id111 = ds.Tables("Staff2").Rows(currentRow).Item(0).ToString
                name111 = ds.Tables("Staff2").Rows(currentRow).Item(1).ToString
                position = ds.Tables("Staff2").Rows(currentRow).Item(8).ToString

                If (position = "Staff") Then


                    'pass string
                    Dim OBJ As New FrmStaffRU
                    OBJ.name666 = name111
                    OBJ.id666 = id111
                    OBJ.Show()
                    Me.Hide()



                    'Dim OBJ2 As New Form2
                    'OBJ2.idddd = id111


                    'Visible = False
                    'FrmStaffRU.ShowDialog()                

                End If

                'MessageBox.Show("Login Successfully! Welcomeback!")


            Else

                MessageBox.Show("Username Or Password Are Invalid")

            End If

            CloseConnection()

        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click


        If (txtLoginID.Text = "") Then
            lblError.Text = "ID cannot be empty!"
            'MsgBox("Id cannot be empty", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Empty Found")
        Else
            lblError.Text = ""
            Search2()
        End If



    End Sub

    Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
        IfRadYes()
    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        'IDShow()
        'IfRadNo()

        'txtLoginID.Enabled = True
        'txtLoginID.Focus()
        Application.Restart()
    End Sub


    Private Sub txtLoginID_TextChanged(sender As Object, e As EventArgs) Handles txtLoginID.TextChanged

    End Sub





End Class