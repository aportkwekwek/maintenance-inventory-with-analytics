Imports System.Data
Imports System.Data.SqlClient


Public Class frmLogin
    Dim sqlcon As New SqlConnection
    Dim sqlcmd As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqlcon.ConnectionString = connstring()

        sqlcon.Open()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        

        sqlcmd = New SqlCommand("login", sqlcon)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@userid", txtUsername.Text)
        sqlcmd.Parameters.AddWithValue("@userpass", txtPassword.Text)
        sqlcmd.Parameters.AddWithValue("@dept", lblDepartment.Text)
        sqlcmd.Connection = sqlcon
        Using i = sqlcmd.ExecuteReader
            If i.Read Then

                txtUsername.Clear()
                txtPassword.Clear()
                Me.Hide()
                If i.GetValue(5) = "USER" Then
                    frmMaintenanceMain.btnMyAccount.Enabled = False
                    frmMaintenanceMain.btnMyAccount.Visible = False
                    frmMaintenanceMain.btnLogOut.Location = frmMaintenanceMain.btnMyAccount.Location


                Else
                    frmMaintenanceMain.btnMyAccount.Enabled = True

                End If

                frmMaintenanceMain.Show()
                frmMaintenanceMain.lblWelcome.Text = "Welcome " & i.GetValue(2) & " " & i.GetValue(3)
                MessageBox.Show("Welcome " & i.GetValue(2) & " " & i.GetValue(3))
                frmMaintenanceMain.txtUsername.Text = txtUsername.Text

            Else
                MessageBox.Show("Invalid Username or Password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                txtUsername.SelectAll()
                txtUsername.Focus()
                txtPassword.Clear()

            End If
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUsername.Clear()
        txtPassword.Clear()
        Me.Close()


    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If txtPassword.TextLength < 1 Or txtUsername.TextLength < 1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub
  
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class