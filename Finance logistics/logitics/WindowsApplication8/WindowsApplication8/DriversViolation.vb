Imports System.Data
Imports System.Data.SqlClient

Public Class DriversViolation
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim dt29 As New DataTable
    Public Function getviolations()
        

        sqlcmd = New SqlCommand("getdriverViolation", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@driverid", lblDriverID.Text)
        sqlcmd.Connection = sqlcon


        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt29)

        dgvDriverViolation.DataSource = dt29

        Return dt29
    End Function
    Private Sub DriversViolation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlcon.ConnectionString = connString()
        sqlcon.Open()

        getviolations()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sqlcmd = New SqlCommand("insertViolation", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@driverid", lblDriverID.Text)
            sqlcmd.Parameters.AddWithValue("@violation", TextBox1.Text)
            sqlcmd.Parameters.AddWithValue("@dateencountered", dtpDateEncountered.Text)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information successfully uploaded", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            getviolations()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub

        End Try

        

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        DriverViolationReport.txtDriverId.Text = lblDriverID.Text
        DriverViolationReport.txtDriverName.Text = lblDriverName.Text
        DriverViolationReport.Show()
        DriverViolationReport.Focus()

    End Sub
End Class