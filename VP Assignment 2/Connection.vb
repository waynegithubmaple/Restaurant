Imports System.Data.SqlClient
Module Connection

    Public con As New SqlConnection

    Public Function Openconnection() As Boolean

        Dim strsqlcon As String

        Dim strPath As String

        Dim strPath2 As String

        strPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath)

        strPath2 = strPath.Replace("bin\Debug", "restaurant.mdf")

        strsqlcon = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + strPath2 + ";Integrated Security=True;Connect Timeout=30"

        Try
            con.ConnectionString = strsqlcon
            con.Open()
            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Public Sub Closeconnection()

        con.Close()

    End Sub

End Module
