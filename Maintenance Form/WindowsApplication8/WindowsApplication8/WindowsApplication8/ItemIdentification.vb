Imports System.Data
Imports System.Data.SqlClient


Public Class ItemIdentification
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub ItemIdentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        sqlcmd = New SqlCommand("getIdentificationofItem", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@itemdesc", lblDescription.Text)
        sqlcmd.Parameters.AddWithValue("@model", lblModel.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        dgvItemidentification.DataSource = dt

        dgvItemidentification.Columns(3).DefaultCellStyle.Format = "MMMM dd,yyyy hh:mm:ss tt"

        dgvItemidentification.Columns(4).DefaultCellStyle.Format = "###,###.##"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class