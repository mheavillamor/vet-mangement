Imports System.Data.Odbc

Public Class Frm_vet
    Dim iscollapsed As Boolean = True
    Dim con As New OdbcConnection("driver=MYSQL ODBC 5.3 ANSI Driver;server=localhost;port=3308;uid=root;pwd=;database=vet_db")

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigureDataGridView()

    End Sub

    ' Open the Daily Sales form in full-screen mode
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PetShopForm.Show()
        Me.Hide()
        'dailysales.Show()
    End Sub

    '
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        client_info.Show()
    End Sub

    ' Open the Pet Info form in full-screen mode
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pet_info.Show() ' Show the form
    End Sub




   

    ' Refresh  DataGridView with client info
    Private Sub Refreshme()
      


        con.Close()
        Try


            con.Open()
            Dim query As String = "SELECT * FROM vet_info"
            Using cmd As New OdbcCommand(query, con)
                Dim da As New OdbcDataAdapter(cmd)
                Dim ds As New DataSet()
                da.Fill(ds, "vet_info")

                dgv_pets.DataSource = ds.Tables("vet_info").DefaultView
                ConfigureDataGridView()

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


    End Sub

    ' Configure  DataGridView appearance
    Private Sub ConfigureDataGridView()


        dgv_pets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Set the default font style and color for the DataGridView
        dgv_pets.DefaultCellStyle.Font = New Font("Verdana", 8, FontStyle.Regular) ' Set font to Verdana, size 12
        dgv_pets.DefaultCellStyle.ForeColor = Color.Black ' Set font color to black
        dgv_pets.DefaultCellStyle.BackColor = Color.Gray ' Set background color to bisque

        ' Set alternate row color for better readability
        Dim alternatingStyle As New DataGridViewCellStyle()
        alternatingStyle.BackColor = Color.WhiteSmoke ' Set alternating row color to light salmon
        dgv_pets.AlternatingRowsDefaultCellStyle = alternatingStyle

        ' Set header style
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.Font = New Font("Verdana", 8, FontStyle.Bold) ' Bold font size 14
        headerStyle.ForeColor = Color.White ' Header font color
        headerStyle.BackColor = Color.Black ' Header background color

        ' Apply header style to the DataGridView
        dgv_pets.ColumnHeadersDefaultCellStyle = headerStyle




    End Sub

  



    Private Sub PETMAMGEMENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pet_info.Show() ' Show the form
    End Sub



    


    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click

        Dim fullname As String = Txt_search.Text
        Dim query As String
        Dim da As New OdbcDataAdapter
        Dim dt As New DataTable

        con.Close()


        If String.IsNullOrEmpty(fullname) Then
            MessageBox.Show("Please enter a valid Service ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            con.Open()

            query = "SELECT * FROM vet_info WHERE fullname = '" & fullname & "'"

            da = New OdbcDataAdapter(query, con)
            da.Fill(dt)


            If dt.Rows.Count > 0 Then
                dt.Rows(0).Item("pet_id").ToString()
                dt.Rows(0).Item("pet_name").ToString()
                dt.Rows(0).Item("pet_color").ToString()
                dt.Rows(0).Item("animal_species").ToString()
                dt.Rows(0).Item("pet_breed").ToString()
                dt.Rows(0).Item("pet_gender").ToString()
                dt.Rows(0).Item("pet_birthday").ToString()
                dt.Rows(0).Item("fullname").ToString()
                dt.Rows(0).Item("lname").ToString()
                dt.Rows(0).Item("fname").ToString()





                dgv_pets.DataSource = dt

            Else
                MessageBox.Show("Service ID not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgv_pets.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim dialog As Integer
        dialog = MessageBox.Show("are you sure you want to exit the application?.", " Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = vbYes Then
            Me.Close()
        End If
    End Sub
End Class





