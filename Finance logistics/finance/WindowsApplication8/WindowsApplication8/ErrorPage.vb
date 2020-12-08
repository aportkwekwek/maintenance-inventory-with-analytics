Imports System.Data.SqlClient
Imports System.Data


Public Class ErrorPage

    Dim sqlcon As New SqlConnection


    Private Sub ErrorPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmFinance.Show()
        frmFinance.Focus()
        frmFinance.Timer1.Start()
        frmFinance.btnLogOut.PerformClick()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            sqlcon.ConnectionString = connstring()
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
End Class