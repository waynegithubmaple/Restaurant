Public Class FrmStaffRU


    Public Property name666 As String
    Public Property id666 As String





    Private Sub FrmStaffRU_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblName.Text = name666
    End Sub






    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        'FrmStaffRUProfile.Show()
        'Me.Hide()

        Dim id222 As String = id666
        Dim name222 As String = name666

        Dim OBJ As New FrmStaffRUProfile
        OBJ.name777 = name222
        OBJ.id777 = id222
        OBJ.Show()
        Me.Hide()


    End Sub







    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Application.Restart()

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) 
        frmOder.Show()
    End Sub
End Class