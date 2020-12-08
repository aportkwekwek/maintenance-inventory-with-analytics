Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class ReportforSuppliers
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim dt As New DataTable
    Private Sub ReportforSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'ReportForSupplierDs.ReportforSupplier' table. You can move, or remove it, as needed.
        'Me.ReportforSupplierTableAdapter.Fill(Me.ReportForSupplierDs.ReportforSupplier)

        Dim query As String
        query = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;Initial Catalog=AcroDistributionNetworkInc;User id=sa;Password=201311422;Integrated Security=False;MultipleActiveResultSets=True"
        sqlcon.ConnectionString = query
        sqlcon.Open()

        'sqlcon.ConnectionString = "Data Source=LAPTOP-KQ07UHHG;Initial Catalog=AcroDistributionNetworkInc;User ID=sa;Password=ronerick123;MultipleActiveResultSets=True"
        'sqlcon.Open()

        Me.ReportViewer1.RefreshReport()

        sqlcmd = New SqlCommand("ReportForSupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@FromDate", dtpDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@toDate", dtpDateTo.Text)
        sqlcmd.Parameters.AddWithValue("@supplierName", txtSupplierName.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        Dim k(0), i(0), j(0), l(0) As ReportParameter


        k(0) = New ReportParameter("CompanyName", txtSupplierName.Text)
        i(0) = New ReportParameter("FromDate", dtpDateFrom.Text)
        j(0) = New ReportParameter("toDate", dtpDateTo.Text)

        Dim totalamt As String
        sqlcmd = New SqlCommand("getTotalperSupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@datefrom", dtpDateFrom.Text)
        sqlcmd.Parameters.AddWithValue("@dateto", dtpDateTo.Text)
        sqlcmd.Parameters.AddWithValue("@sname", txtSupplierName.Text)
        sqlcmd.Connection = sqlcon
        Using p = sqlcmd.ExecuteReader
            If p.Read Then
                totalamt = "P " & p.GetValue(0)
                l(0) = New ReportParameter("totalAmt", totalamt, True)
            Else

            End If
        End Using

        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {k(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {i(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {j(0)})
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {l(0)})


        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))

        Me.ReportViewer1.RefreshReport()


    End Sub
End Class