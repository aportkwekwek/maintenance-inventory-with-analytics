Imports System.Data.SqlClient
Imports System.Data


Public Class EditPriceofItem
    Dim sqlcon As New SqlConnection
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand

    Private Sub EditPriceofItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlcon.ConnectionString = connString()
        sqlcon.Open()
      
        refreshdgv()

    End Sub

    Public Function refreshdgv()

        Dim dt As New DataTable
        dt.Clear()


        sqlcmd = New SqlCommand("getPreviousPricesOfSupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@desc", lblDescription.Text)
        sqlcmd.Parameters.AddWithValue("@model", lblModel.Text)
        sqlcmd.Parameters.AddWithValue("@sname", SupplierName.Text)
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        dgvPreviousPrice.DataSource = dt
        dgvPreviousPrice.Columns(3).DefaultCellStyle.Format = "MMMM dd, yyyy hh:mm:ss tt"
        dgvPreviousPrice.Columns(2).DefaultCellStyle.Format = "###,###.##"
        dgvPreviousPrice.Columns(3).Width = 200

        Return dt

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim psid As Integer
            psid = 0

            sqlcmd = New SqlCommand("getpsid", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@sname", SupplierName.Text)
            sqlcmd.Parameters.AddWithValue("@desc", lblDescription.Text)
            sqlcmd.Parameters.AddWithValue("@model", lblModel.Text)
            sqlcmd.Connection = sqlcon
            Using f = sqlcmd.ExecuteReader
                If f.Read Then
                    psid = f.GetValue(0)
                
                End If
            End Using

            Dim last, curr As Double
            last = 0
            curr = 0

            sqlcmd = New SqlCommand("getLastPricefrompsid", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@psid", psid)
            sqlcmd.Connection = sqlcon
            Using i = sqlcmd.ExecuteReader
                If i.Read Then
                    last = i.GetValue(1)

                End If
            End Using


            Dim dtnow As String
            dtnow = Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss tt")

            '----------
            'updating new price and update current and last price from the table 

            sqlcmd = New SqlCommand("updateNewPrice", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@psid", psid)
            sqlcmd.Parameters.AddWithValue("@dateupdate", dtnow)
            sqlcmd.Parameters.AddWithValue("@price", txtNewPrice.Text)
            sqlcmd.Parameters.AddWithValue("@lastprice", last)
            sqlcmd.Connection = sqlcon
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information updated succcessfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshdgv()

            Exit Sub


        Catch ex As Exception

            MessageBox.Show("Please check your inputs", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show(ex.Message)
            Exit Sub

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNewPrice.Text = Nothing
        Me.Hide()
        frmLogisticsMain.Focus()

    End Sub

    Private Sub txtNewPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else

                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtNewPrice_TextChanged(sender As Object, e As EventArgs) Handles txtNewPrice.TextChanged

    End Sub
End Class