Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class AnnualReport
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable
    Dim sqlds As New SqlDataAdapter

    Private Sub AnnualReport_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMaintenanceMain.Focus()
        ReportViewer.Focus()

    End Sub
    Private Sub AnnualReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0

        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        ' ''TODO: This line of code loads data into the 'AnnualReportDataSet.AnnualReport' table. You can move, or remove it, as needed.
        ''Me.AnnualReportTableAdapter.Fill(Me.AnnualReportDataSet.AnnualReport)
        dt.Reset()

        
        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

        sqlcmd = New SqlCommand("AnnualReport", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim p(0) As ReportParameter
        Dim fromD, toD, allD As String

        fromD = txtDateFrom.Text
        toD = txtDateTo.Text
        allD = "Purchase order report from " & fromD & " to " & toD

        p(0) = New ReportParameter("YearReport", allD, True)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("AnnualReport", dt))

        Me.ReportViewer1.RefreshReport()

    End Sub


End Class