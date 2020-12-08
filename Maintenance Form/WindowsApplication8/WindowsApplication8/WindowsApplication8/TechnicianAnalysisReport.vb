Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class TechnicianAnalysisReport
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub TechnicianAnalysisReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.RefreshReport()

        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        sqlcmd = New SqlCommand("TechnicianAnalysisForReporting", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@jobdesc", txtJobDescription.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("technicianAnalysis", dt))

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class