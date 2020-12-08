Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class TruckRepairItemHistory
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub TruckRepairItemHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'truckHistoryRepairItemsDS.truckHistoryRepairItems' table. You can move, or remove it, as needed.
        'Me.truckHistoryRepairItemsTableAdapter.Fill(Me.truckHistoryRepairItemsDS.truckHistoryRepairItems)


        sqlcon.ConnectionString = connstring()

        sqlcon.Open()


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.LocalReport.DataSources.Clear()



        sqlcmd = New SqlCommand("truckHistoryRepairItems",sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@platenumber", txtPlateNumber.Text)
        sqlcmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim r(0), q(0), o(0) As ReportParameter

        r(0) = New ReportParameter("platenumber", txtPlateNumber.Text, True)
        q(0) = New ReportParameter("datefrom", txtDateFrom.Text, True)
        o(0) = New ReportParameter("dateto", txtDateTo.Text, True)

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {q(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {o(0)})
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("truckRepairItemHistory", dt))
        Me.ReportViewer1.RefreshReport()


    End Sub
End Class