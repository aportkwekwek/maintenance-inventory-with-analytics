Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class PurchaseOrderReport
    Dim sqlcmd As New SqlCommand
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Private Sub PurchaseOrderReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Update()

        ''TODO: This line of code loads data into the 'AcroDistributionNetworkIncDataSet.samplesss' table. You can move, or remove it, as needed.
        'Me.samplesssTableAdapter.Fill(Me.AcroDistributionNetworkIncDataSet.samplesss)
        Me.ReportViewer1.RefreshReport()

        sqlcon.ConnectionString = connstring()
        sqlcon.Open()




        Dim dt As New DataTable

        sqlcmd = New SqlCommand("samplesss", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim k(0), o(0) As ReportParameter

        sqlcmd = New SqlCommand("dateWord", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@date1", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@date2", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        Using s = sqlcmd.ExecuteReader

            If s.Read Then

                lblMonth.Text = s.GetValue(0) & " Purchase Order"
                o(0) = New ReportParameter("Month", lblMonth.Text)


            End If

        End Using

        k(0) = New ReportParameter("Total", lbltot.Text)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {o(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {k(0)})
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
        Me.ReportViewer1.RefreshReport()

    End Sub

End Class