Imports System.Data
Imports System.Data.SqlClient


Public Class ErrorPage
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            sqlcon.ConnectionString = connString()
            sqlcon.Open()

            Panel3.BackColor = Color.Green
            Button1.Enabled = True


        Catch ex As Exception
            Panel3.BackColor = Color.Red
            Button1.Enabled = False

        Finally
            sqlcon.Close()

        End Try
    End Sub

    Private Sub ErrorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmLogisticsMain.Enabled = True
        frmLogisticsMain.Focus()
        frmLogisticsMain.Timer1.Start()
        frmLogisticsMain.btnLogOut.PerformClick()


    End Sub
End Class