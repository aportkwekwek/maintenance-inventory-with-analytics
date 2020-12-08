Imports System.Data.SqlClient
Imports System.Data


Public Class viewTruckHistory
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub viewTruckHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlcon.ConnectionString = connString()

        sqlcon.Open()

        dt.Reset()

        sqlcmd = New SqlCommand("truckDeliveryHistory", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@truckid", lblTruckid.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        dgvTruckHistory.DataSource = dt


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmLogisticsMain.Focus()

    End Sub
End Class