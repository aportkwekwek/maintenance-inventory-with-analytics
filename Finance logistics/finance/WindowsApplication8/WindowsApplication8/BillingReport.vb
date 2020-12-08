Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class BillingReport
    Dim sqlcmd As New SqlCommand
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlds As New DataSet
    Dim dt As New DataTable

    Private Sub BillingReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

        sqlcon.ConnectionString = connstring()

        sqlcon.Open()


        Me.ReportViewer1.RefreshReport()


        sqlcmd = New SqlCommand("ReportForSupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@FromDate", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@toDate", txtDateTo.Text)
        sqlcmd.Parameters.AddWithValue("@supplierName", txtSupplierName.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim totamt As String
        Dim sum(0), dF(0), dTo(0), s(0) As ReportParameter

        'Get Parameters

        '--------------------------------------------------------------------------------------
        sqlcmd = New SqlCommand("getTotalperSupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Parameters.AddWithValue("@sname", txtSupplierName.Text)
        sqlcmd.Connection = sqlcon
        Using j = sqlcmd.ExecuteReader
            If j.Read Then
                totamt = "P " & j.GetValue(0) & ".00"
                sum(0) = New ReportParameter("TotalAmt", totamt, True)
            End If
        End Using
        dF(0) = New ReportParameter("FromDate", txtDateFrom.Text, True)
        dTo(0) = New ReportParameter("ToDate", txtDateTo.Text, True)
        s(0) = New ReportParameter("SupplierName", txtSupplierName.Text, True)

        '--------------------------------------------------------------------------------------

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {dF(0)})
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {dTo(0)})
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {s(0)})
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {sum(0)})
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("BillingReportds", dt))

        Me.ReportViewer1.RefreshReport()


    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportforSupplierBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class