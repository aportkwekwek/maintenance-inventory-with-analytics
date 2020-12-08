Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class TruckReportWorth
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim dt As New DataTable
    Dim sqlda As New SqlDataAdapter

    Private Sub TruckReportWorth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'AcroDistributionNetworkIncDataSet.getTruckallAsset' table. You can move, or remove it, as needed.
        'Me.getTruckallAssetTableAdapter.Fill(Me.AcroDistributionNetworkIncDataSet.getTruckallAsset)

        'Dim query As String
        'query = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;Initial Catalog=AcroDistributionNetworkInc;User id=sa;Password=201311422;Integrated Security=False;MultipleActiveResultSets=True"
        'sqlcon.ConnectionString = query
        'sqlcon.Open()


        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        sqlcmd = New SqlCommand("getTruckAllAsset", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("TruckAsset", dt))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class