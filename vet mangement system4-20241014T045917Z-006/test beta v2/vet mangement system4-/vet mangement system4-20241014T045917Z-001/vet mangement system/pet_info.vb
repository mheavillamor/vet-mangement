Imports System.Windows.Forms
Imports System.Data.Odbc
Public Class pet_info
    Dim gender As String
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        connectMe()

        Dim vid As Integer
        Dim cmd As New OdbcCommand("Select ifnull(max(pet_id),0) vet_no from vet_info", con)
        vid = cmd.ExecuteScalar

        If vid > 0 Then
            Call get_vet_id()
        Else
            txt_vid.Text = 1
        End If
    End Sub
    Private Sub get_vet_id()
        Dim da As New OdbcDataAdapter("select max(pet_id) vet_no from vet_info", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)


        Txt_vid.Text = ds.Tables(0).Rows(0).Item("vet_no") + 1

    End Sub




    Private Sub Txt_petname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_petname.KeyDown

        If e.KeyCode = 13 Then
            If txt_petname.Text = "" Then
                MessageBox.Show("enter petname", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_petname.Focus()
            Else
                txt_fname.Focus()

            End If
        End If
    End Sub

    Private Sub Txtfull_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_fullname.KeyDown
        If e.KeyCode = 13 Then
            If Txt_fullname.Text = "" Then
                MessageBox.Show("fill in fullname", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_fullname.Focus()
            Else
                txt_color.Focus()

            End If
        End If
    End Sub



    Private Sub Txt_color_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_color.KeyDown

        If e.KeyCode = 13 Then
            If Txt_color.Text = "" Then
                MessageBox.Show("enter animal color", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_color.Focus()
            Else
                RadioButton1.Focus()
                RadioButton2.Focus()

            End If
        End If
    End Sub

    Private Sub cmb_species_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            If cmb_species.Text = "" Then
                MessageBox.Show("enter pet species", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmb_species.Focus()
            Else
                cmb_breed.Focus()

            End If
        End If
    End Sub

    Private Sub cmb_breed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            If cmb_breed.Text = "" Then
                MessageBox.Show("enter pet breed", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmb_breed.Focus()
            Else
                dtpbd.Focus()

            End If
        End If
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim vid As String
        Dim s As String
        Dim f As String
        Dim ln As String
        Dim fn As String
        Dim c As String
        Dim p As String
        Dim br As String
        Dim bd As String

        Dim gender As String

        gender = ""

        vid = txt_vid.Text
        p = txt_petname.Text.ToUpper.Trim
        f = Txt_fullname.Text.ToUpper.Trim
        ln = txt_lname.Text.ToUpper.Trim
        fn = txt_fname.Text.ToUpper.Trim
        br = cmb_breed.Text.ToUpper.Trim
        c = txt_color.Text.ToUpper.Trim
        s = cmb_species.Text.ToUpper.Trim

        If RadioButton1.Checked Then
            gender = "FEMALE"
        ElseIf RadioButton2.Checked Then
            gender = "MALE"
        End If


        bd = dtpbd.Text.Trim


        'MessageBox.Show(gender)

        con.Close()

        Try
            con.Open()
            With mycmd
                .Connection = con
                .CommandText = "insert into vet_info values('" & vid & "','" & p & "','" & c & "','" & s & "','" & br & "','" & gender & "','" & bd & "','" & f & "','" & ln & "', '" & fn & "')"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("your information  added", "add database", MessageBoxButtons.OK, MessageBoxIcon.Information)



            txt_petname.Focus()
            Call get_vet_id()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()

        End Try




        txt_color.Clear()
        txt_petname.Clear()
        Txt_fullname.Clear()
        txt_vid.Clear()


    End Sub




    Private Sub RadioButton1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadioButton1.KeyDown

        gender = "female"


    End Sub

    Private Sub RadioButton2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadioButton2.KeyDown

        gender = "male"

    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpbd.KeyDown
        If e.KeyCode = 13 Then
            If dtpbd.Text = "" Then
                MessageBox.Show("enter pet brithday", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpbd.Focus()
            Else


            End If
        End If
    End Sub



    Private Sub Btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_view.Click
        Me.Hide()
        pet_view.Show()

    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
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
                Txt_fullname.Focus()

            End If
        End If


    End Sub

    Private Sub txt_petname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_petname.TextChanged

    End Sub

    Private Sub txt_fname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fname.TextChanged

    End Sub
End Class