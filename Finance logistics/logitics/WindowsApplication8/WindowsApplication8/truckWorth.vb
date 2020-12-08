Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class truckWorth
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub truckWorth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height


        'TODO: This line of code loads data into the 'truckAssetDS.getTruckallAsset' table. You can move, or remove it, as needed.
        Me.getTruckallAssetTableAdapter.Fill(Me.truckAssetDS.getTruckallAsset)

        Me.ReportViewer1.RefreshReport()

        sqlcon.ConnectionString = connString()
        sqlcon.Open()


        sqlcmd = New SqlCommand("getTruckallAsset", sqlcon)


    End Sub
End Class