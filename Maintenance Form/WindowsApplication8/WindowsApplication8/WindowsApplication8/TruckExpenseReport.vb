Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class TruckExpenseReport
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim dt As New DataTable

    Private Sub TruckExpenseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'truckExpenseDS.truckexpense' table. You can move, or remove it, as needed.
        'Me.truckexpenseTableAdapter.Fill(Me.truckExpenseDS.truckexpense)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()



        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

        sqlcmd = New SqlCommand("truckexpense", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDatefrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateto.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim r(0), i(0) As ReportParameter
        r(0) = New ReportParameter("DateFrom", txtDatefrom.Text, True)
        i(0) = New ReportParameter("DateTo", txtDateto.Text, True)

        Dim dt2 As New DataTable

        sqlcmd = New SqlCommand("getadditionalinfoExpense", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@dateFrom", txtDatefrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateTo", txtDateto.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt2)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("truckexpensesum", dt2))
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("TruckExpenseReport", dt))
        Me.ReportViewer1.RefreshReport()


    End Sub

End Class