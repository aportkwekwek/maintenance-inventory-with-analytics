Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class AnnualPurchaseOrder
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub AnnualPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        sqlcon.ConnectionString = connString()
        sqlcon.Open()

        Me.ReportViewer1.LocalReport.DataSources.Clear()

        sqlcmd = New SqlCommand("AnnualReport", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDatefrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateto.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim f(0) As ReportParameter
        Dim reportParameter As String

        reportParameter = "Annual Report from year" & txtDatefrom.Text & " to year " & txtDateto.Text
        f(0) = New ReportParameter("year", reportParameter, True)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {f(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("AnnualPOReport", dt))
        Me.ReportViewer1.RefreshReport()



    End Sub
End Class