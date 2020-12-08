Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Data

Public Class TruckNetWorth
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub TruckNetWorth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'getTruckAsset.getTruckallAsset' table. You can move, or remove it, as needed.
        'Me.getTruckallAssetTableAdapter.Fill(Me.getTruckAsset.getTruckallAsset)

      sqlcon.ConnectionString = connstring()

        sqlcon.Open()
        Try
            Me.ReportViewer1.LocalReport.DataSources.Clear()

            sqlcmd = New SqlCommand("getTruckAllAsset", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt)

            Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("getTruckWorth", dt))

            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
       
    End Sub
End Class