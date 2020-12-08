Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms

Public Class SupplierItemAnalysisReport
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub SupplierItemAnalysisReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        Me.ReportViewer1.LocalReport.DataSources.Clear()


        sqlcmd = New SqlCommand("SupplierItemAnalysis", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@desc", lbldesc.Text)
        sqlcmd.Parameters.AddWithValue("@model", lblModel.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim k(0) As ReportParameter

        Dim j As String

        j = "Report for the average lifespan of the item " & lbldesc.Text & " - " & lblModel.Text & " based on supplier"
        k(0) = New ReportParameter("desc", j, True)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {k(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("SupplierItemAnalysis1", dt))
        Me.ReportViewer1.RefreshReport()


    End Sub

End Class