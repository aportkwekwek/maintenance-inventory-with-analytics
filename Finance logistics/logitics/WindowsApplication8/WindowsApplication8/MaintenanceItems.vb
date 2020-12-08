Imports System.Data.SqlClient

Public Class MaintenanceItems
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As New SqlCommand
    Dim sqlda As New SqlDataAdapter
    Dim dt As New DataTable


    Private Sub MaintenanceItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlcon.ConnectionString = connString()
        sqlcon.Open()

        sqlcmd = New SqlCommand("getAllItemsinMaintenance", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon


        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt)

        dgvMaintenanceItems.DataSource = dt



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemdesc, model As String

        Try
            itemdesc = dgvMaintenanceItems.SelectedCells.Item(0).Value
            model = dgvMaintenanceItems.SelectedCells.Item(1).Value

        Catch ex As Exception
            MessageBox.Show("Please select at one item in the table", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End Try
        Dim itemid As String

        '1st to check if the supplier already has this item
        '--------------------------------------------
        sqlcmd = New SqlCommand("getifSupplierHasItem", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@sname", lblSname.Text)
        sqlcmd.Parameters.AddWithValue("@itemdesc", itemdesc)
        sqlcmd.Parameters.AddWithValue("@model", model)
        sqlcmd.Connection = sqlcon
        Using i = sqlcmd.ExecuteReader

            If i.Read Then

                MessageBox.Show("Item exist", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                Exit Sub

            End If
        End Using


        Dim suppid As String
        'get itemid of item based on description and model

        sqlcmd = New SqlCommand("getidofitem", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@itemdesc", itemdesc)
        sqlcmd.Parameters.AddWithValue("@model", model)
        sqlcmd.Connection = sqlcon
        Using x = sqlcmd.ExecuteReader

            If x.Read Then
                itemid = x.GetValue(0)
            Else
                itemid = "x"
               
            End If
        End Using

        '----getsupplier id 
        sqlcmd = New SqlCommand("getsupplierid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@sname", lblSname.Text)
        sqlcmd.Connection = sqlcon
        Using j = sqlcmd.ExecuteReader
            If j.Read Then
                suppid = j.GetValue(0)
            Else
                suppid = "x"
            End If
        End Using



        '----add this item to supplier's list
        Dim maxpsid As Integer
        maxpsid = getmaxpsid()

        sqlcmd = New SqlCommand("insertintoProductsupplier", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@psid", maxpsid)
        sqlcmd.Parameters.AddWithValue("@itemid", itemid)
        sqlcmd.Parameters.AddWithValue("@suppid", suppid)
        sqlcmd.Parameters.AddWithValue("@datetoday", Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss tt"))
        sqlcmd.Connection = sqlcon
        sqlcmd.ExecuteNonQuery()

        MessageBox.Show("Information successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub


    End Sub

    Public Function getmaxpsid()

        Dim psid As Integer
        psid = 0

        sqlcmd = New SqlCommand("getmaxpsid", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon
        Using k = sqlcmd.ExecuteReader
            If k.Read Then
                psid = k.GetValue(0) + 1

            End If
        End Using

        Return psid

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frmLogisticsMain.Focus()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            dt.Clear()


            sqlcmd = New SqlCommand("getItemsHavingThis", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@desc", txtSearch.Text)
            sqlcmd.Parameters.AddWithValue("@model", txtSearch.Text)
            sqlcmd.Connection = sqlcon

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt)

            dgvMaintenanceItems.DataSource = dt


        Catch ex As Exception
            Exit Sub

        End Try
    End Sub
End Class