Imports System.Data
Imports System.Data.SqlClient
Public Class InventoryReport

    Private Sub InventoryReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class