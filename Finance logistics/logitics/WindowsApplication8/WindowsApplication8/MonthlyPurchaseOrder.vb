Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class MonthlyPurchaseOrder
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub MonthlyPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        sqlcon.ConnectionString = connString()

        sqlcon.Open()


        Me.ReportViewer1.LocalReport.DataSources.Clear()


        sqlcmd = New SqlCommand("MonthlyReport", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDatefrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateto.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim r(0) As ReportParameter
        Dim reportparam As String

        reportparam = "Purchase order from " & txtDatefrom.Text & " to " & txtDateto.Text
        r(0) = New ReportParameter("MonthParam", reportparam, True)


        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("MonthlyPurchaseOrder", dt))

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class