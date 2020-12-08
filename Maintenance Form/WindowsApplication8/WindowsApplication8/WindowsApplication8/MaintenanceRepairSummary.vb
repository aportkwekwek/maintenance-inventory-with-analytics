Imports System.Data
Imports System.Data.SqlClient
Public Class MaintenanceRepairSummary
    Dim sqlda As New SqlDataAdapter
    Dim sqlcmd As New SqlCommand
    Dim sqlcon As New SqlConnection
    Dim sqlds As DataSet
    Dim lvItemsAdded As ListViewItem
    Dim numberstockz, newval As Integer
    Dim currPrice, oldTotPrice, truckworth As Double
    Dim itemidforNew As String

    Private Sub MaintenanceRepairSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()


        'Dim query As String
        'query = "Data Source=LAPTOP-FOHM0ANH,34458;Network Library=DBMSSOCN;Initial Catalog=AcroDistributionNetworkInc;User id=sa;Password=201311422;Integrated Security=False;MultipleActiveResultSets=True"
        'sqlcon.ConnectionString = query
        'sqlcon.Open()

        sqlcon.ConnectionString = connstring()
        sqlcon.Open()

        getitems()

    End Sub
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTimeToday.Text = Format(Date.Now, "yyyy-MM-dd hh:mm:ss tt")
    End Sub

    Public Function getitems()
        Dim dt4 As New DataTable
        sqlcmd = New SqlCommand("getStocksReady", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Connection = sqlcon

        sqlda = New SqlDataAdapter(sqlcmd)
        sqlda.Fill(dt4)

        Dim u As Integer
        Do While u <= dt4.Rows.Count - 1
            cboItemID.Items.Add(dt4.Rows(u).Item(0) & " - " & dt4.Rows(u).Item(1) & " - " & dt4.Rows(u).Item(2) & " - ")

            u += 1
        Loop



        Return dt4

    End Function
    Private Sub cboItemID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemID.SelectedIndexChanged
        cboItemIdentification.Items.Clear()

        Try

            sqlcmd = New SqlCommand("getIdentificationsAll", sqlcon)
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.Parameters.AddWithValue("@itemid", Format(Mid(cboItemID.Text, 1, 8)))
            sqlcmd.Connection = sqlcon

            Dim dt As New DataTable

            sqlda = New SqlDataAdapter(sqlcmd)
            sqlda.Fill(dt)

            Dim ctr As Integer

            Do While ctr <= dt.Rows.Count - 1

                cboItemIdentification.Items.Add(dt.Rows(ctr).Item(0) & " - " & dt.Rows(ctr).Item(1) & " - " & dt.Rows(ctr).Item(2) & " - " & dt.Rows(ctr).Item(3))
                ctr += 1

            Loop

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cboItemIdentification.Text = Nothing Then
            MessageBox.Show("Please select at least one item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End If

        Dim wrkID, itmid, desc As String
        wrkID = lblWorkOrder.Text
        itmid = Format(Mid(cboItemIdentification.Text, 1, 10))
        desc = Format(Mid(cboItemIdentification.Text, 14, 120))


        lvItemsAdded = lvItmAdd.Items.Add(wrkID)
        lvItemsAdded.SubItems.Add(itmid)
        lvItemsAdded.SubItems.Add(desc)

        cboItemIdentification.Items.RemoveAt(cboItemIdentification.SelectedIndex)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim added2, added3, compiled As String

            Dim room As ListViewItem

            For Each room In lvItmAdd.SelectedItems
                added2 = room.SubItems(1).Text
                added3 = room.SubItems(2).Text
                compiled = added2 & " - " & added3
                cboItemIdentification.Items.Add(compiled)

            Next

        Catch ex As Exception

            Exit Sub

        End Try

        Try

            lvItmAdd.Items.RemoveAt(lvItmAdd.SelectedIndices(0))
            MessageBox.Show("Item Removed!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            Exit Sub

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qq As Integer

        qq = MessageBox.Show("This information will be saved. Continue?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If qq = vbNo Then
            MessageBox.Show("Nothing Happened!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        Else

            If cboStatus.Text = Nothing Then
                MessageBox.Show("Please Select if the work is Major or Minor", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None)
                Exit Sub
            End If
            Dim dateStart, dateEnd As DateTime

            dateStart = lblDateStart.Text
            dateEnd = lblDateTimeToday.Text

            Dim days As Long

            days = DateDiff(DateInterval.Day, dateStart, dateEnd)
            Dim repairOrMaintenance As String

            If days >= 3 Then
                repairOrMaintenance = "M02"
            Else
                repairOrMaintenance = "M01"
            End If

            Try
                'updating maintenance status major or minor 
                '-------------------------------------------
                sqlcmd = New SqlCommand("updatingType", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@type", cboStatus.Text)
                sqlcmd.Parameters.AddWithValue("@id", lblWorkOrder.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                'update date ended of table maintenance
                '-----------------------------------------
                sqlcmd = New SqlCommand("updateTime", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@maintenanceid", lblWorkOrder.Text)
                sqlcmd.Parameters.AddWithValue("@dateend", lblDateTimeToday.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()


                'set repair or maintenance
                '---------------------------------------------
                sqlcmd = New SqlCommand("setRepairorMaintenance", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@RorM", repairOrMaintenance)
                sqlcmd.Parameters.AddWithValue("@id", lblWorkOrder.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                'set status to standby
                '-------------------------------------------------
                sqlcmd = New SqlCommand("setStatusStandBy", sqlcon)
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                sqlcmd.Connection = sqlcon
                sqlcmd.ExecuteNonQuery()

                'Item Saving

                ' Multiple Save into Maintenance Items if needed
                '-------------------------------------
                '-------------------------------------

                For Each kwe As ListViewItem In lvItmAdd.Items

                    sqlcmd = New SqlCommand("insertTomaintenanceItems", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@mainteid", kwe.SubItems(0).Text)
                    sqlcmd.Parameters.AddWithValue("@itemtaken", kwe.SubItems(1).Text)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                Next

                'Calling the price of the items from itemtable and itemidentification table 
                '---------------------------------------------------------------
                '---------------------------------------------------------------

                For Each kok As ListViewItem In lvItmAdd.Items
                    Dim itemTaken As String
                    itemTaken = kok.SubItems(1).Text
                    sqlcmd = New SqlCommand("updateNumberinStockMaintenance", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@itemid", itemTaken)
                    sqlcmd.Connection = sqlcon
                    Using l = sqlcmd.ExecuteReader
                        If l.Read Then
                            numberstockz = l.GetValue(1)
                            newval = numberstockz - 1
                            itemidforNew = l.GetValue(2)
                            currPrice = l.GetValue(3)
                            oldTotPrice = l.GetValue(4)

                        Else
                            Exit Sub
                        End If

                    End Using

                    Dim newTotPrice As Double
                    newTotPrice = oldTotPrice - currPrice

                    'updating number of stocks and total price of a certain item in the inventory 
                    '---------------------------------------------
                    '---------------------------------------------
                    sqlcmd = New SqlCommand("updatenumberofstocks", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@id", itemidforNew)
                    sqlcmd.Parameters.AddWithValue("@new", newval)
                    sqlcmd.Parameters.AddWithValue("@price", newTotPrice)
                    sqlcmd.Parameters.AddWithValue("@id2", itemidforNew)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                    'Get Current net Worth of truck
                    '-------------------------------------
                    '-------------------------------------
                    sqlcmd = New SqlCommand("getNetworthofTruck", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                    sqlcmd.Connection = sqlcon
                    Using f = sqlcmd.ExecuteReader
                        If f.Read Then
                            truckworth = f.GetValue(0)
                        End If
                    End Using

                    Dim newTworth As Double
                    newTworth = truckworth + currPrice

                    'Add net value of truck 
                    '------------------------
                    '------------------------
                    sqlcmd = New SqlCommand("updateNewWorth", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@newWorth", newTworth)
                    sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                Next


                For Each i As ListViewItem In lvItmAdd.Items
                    Dim itemIdentificationP As String
                    itemIdentificationP = i.SubItems(1).Text

                    'Updating item identification from inventory to truck
                    '---------------------------------------------------
                    '---------------------------------------------------
                    sqlcmd = New SqlCommand("MoveItemtoTruck", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                    sqlcmd.Parameters.AddWithValue("@id", itemIdentificationP)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                    'Inserting parts of truck
                    '-----------------------
                    '-----------------------
                    sqlcmd = New SqlCommand("insertPartsofTruckfromMaintenance", sqlcon)
                    sqlcmd.CommandType = CommandType.StoredProcedure
                    sqlcmd.Parameters.AddWithValue("@truckid", lblTruckID.Text)
                    sqlcmd.Parameters.AddWithValue("@dateinstalled", lblDateTimeToday.Text)
                    sqlcmd.Parameters.AddWithValue("@identification", itemIdentificationP)
                    sqlcmd.Connection = sqlcon
                    sqlcmd.ExecuteNonQuery()

                Next

                MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvItmAdd.Items.Clear()
                cboStatus.Text = Nothing
                cboItemID.Text = Nothing
                cboItemIdentification.Items.Clear()
                Me.Hide()

                frmMaintenanceMain.Show()
                frmMaintenanceMain.Focus()
                frmMaintenanceMain.btnRefreshSummary.PerformClick()

            Catch ex As Exception
                Exit Sub

            End Try
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cboStatus.Text = Nothing
        lvItmAdd.Items.Clear()
        Me.Hide()


    End Sub

End Class