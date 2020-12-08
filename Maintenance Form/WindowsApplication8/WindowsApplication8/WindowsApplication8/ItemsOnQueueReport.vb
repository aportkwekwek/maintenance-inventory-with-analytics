Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class ItemsOnQueueReport
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub ItemsOnQueueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.RefreshReport()
        sqlcon.ConnectionString = connstring()
        sqlcon.Open()


        sqlcmd = New SqlCommand("itemsOnQueueReport", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("itemsOnQueue", dt))
        Me.ReportViewer1.RefreshReport()


    End Sub

End Class