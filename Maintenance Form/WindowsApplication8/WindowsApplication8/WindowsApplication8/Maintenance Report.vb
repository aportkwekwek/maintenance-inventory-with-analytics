Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class Maintenance_Report
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub Maintenance_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        Me.ReportViewer1.LocalReport.Refresh()

        ' Me.truckNumberofMaintenanceTableAdapter.Fill(Me.AcroDistributionNetworkIncDataSet3.truckNumberofMaintenance)
        'Me.samplesssTableAdapter.Fill(Me.AcroDistributionNetworkIncDataSet.samplesss)

        
        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

        sqlcmd = New SqlCommand("truckNumberofMaintenance", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim i(0) As ReportParameter


        lblMonth.Text = "Maintenance/Repair Frequency from " & txtDateFrom.Text & " to " & txtDateTo.Text
        i(0) = New ReportParameter("Month", lblMonth.Text, True)

        ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("MaintenanceReport", dt))
        Me.ReportViewer1.RefreshReport()
       
    End Sub

End Class