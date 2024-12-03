﻿Imports System.Windows.Forms
Imports System.Data.Odbc
Public Class client_info

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        Dim cid As Integer
        Dim cmd As New OdbcCommand("Select ifnull(max(client_id),0) vet_no from client_info", con)
        cid = cmd.ExecuteScalar

        If cid > 0 Then
            Call get_client_id()
        Else
            txt_cid.Text = 1
        End If
    End Sub
    Private Sub get_client_id()
        Dim da As New OdbcDataAdapter("select max(client_id) client_no from client_info", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)


        txt_cid.Text = ds.Tables(0).Rows(0).Item("client_no") + 1

    End Sub

    Private Sub txt_fname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_fname.KeyDown
        If e.KeyCode = 13 Then
            If Txt_fname.Text = "" Then
                MessageBox.Show("enter first name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_fname.Focus()
            Else
                Txt_fullname.Text = Txt_fname.Text.ToUpper.Trim & "" & txt_lname.Text.ToUpper.Trim
                txt_lname.Focus()




            End If
        End If
    End Sub

    Private Sub txt_lname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lname.KeyDown

        If e.KeyCode = 13 Then
            If txt_lname.Text = "" Then
                MessageBox.Show("enter last name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_lname.Focus()
            Else
                Txt_fullname.Text = Txt_fname.Text.ToUpper.Trim & "" & txt_lname.Text.ToUpper.Trim
                Txt_contactnum.Focus()

            End If
        End If


    End Sub

    Private Sub txt_contactnum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_contactnum.KeyDown
        If e.KeyCode = 13 Then
            If Txt_contactnum.Text = "" Then
                MessageBox.Show("enter contact number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_contactnum.Focus()
            Else

                Txt_address.Focus()

            End If
        End If
    End Sub

    Private Sub Txt_address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_address.KeyDown
        If e.KeyCode = 13 Then
            If Txt_address.Text = "" Then
                MessageBox.Show("enter address", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_address.Focus()
            Else
                btn_add.Focus()

            End If
        End If
    End Sub



    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim cid As String
        Dim ln As String
        Dim f As String
        Dim a As String
        Dim em As String


        Dim c As String
        'Dim cn As Integer

      
        cid = txt_cid.Text
        f = Txt_fname.Text.ToUpper.Trim
        ln = txt_lname.Text.ToUpper.Trim
        a = Txt_address.Text.Trim
        em = Txt_fullname.Text.Trim
        c = Txt_contactnum.Text.Trim
       
       
        ' Integer.TryParse(Txt_contactnum.Text, cn)

        con.Close()

        Try
            con.Open()
            With mycmd
                .Connection = con
                .CommandText = "insert client_info values ('" & cid & "' ,'" & f & "','" & ln & "','" & c & "','" & a & "','" & em & "' )"
                .ExecuteNonQuery()
            End With
            MessageBox.Show(" informationadded", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Txt_fname.Clear()
            txt_lname.Clear()
            Txt_contactnum.Clear()
            Txt_address.Clear()
            Txt_fullname.Clear()



            Txt_fname.Focus()


            Call get_client_id()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Txtfull_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_fullname.KeyDown
        If e.KeyCode = 13 Then
            If Txt_fullname.Text = "" Then
                MessageBox.Show("fill in fullname", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_fullname.Focus()
            Else
                Txt_contactnum.Focus()

            End If
            Me.Enabled = True
        End If
    End Sub

    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        client_data.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        client_data.Show()
    End Sub
    

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

  
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_lname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_lname.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class