Imports System.Data.Odbc
Imports System.Windows.Forms


Public Class inventory

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtItemName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescription.Focus()
        End If
    End Sub

    Private Sub txtDescription_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrice.Focus()
        End If
    End Sub

    Private Sub txtPrice_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStock.Focus()
        End If
    End Sub

    Private Sub txtStock_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtStock.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddItem.Focus()
        End If
    End Sub



    Private Sub frm_inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectMe()

        Dim service_id As Integer
        Dim cmd As New OdbcCommand("SELECT IFNULL(MAX(service_id), 0) FROM service_items", con)
        service_id = cmd.ExecuteScalar

        If service_id > 0 Then
            Call get_service_id()
        Else
            txtItemID.Text = 1
        End If

        refreshMe()
    End Sub

    Private Sub get_service_id()
        Dim da As New OdbcDataAdapter("SELECT MAX(service_id) AS service_no FROM service_items", con)
        Dim ds As New System.Data.DataSet
        da.Fill(ds)

        txtItemID.Text = ds.Tables(0).Rows(0).Item("service_no") + 1
    End Sub
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvInventory.DataSource = Nothing
        isDataVisible = False
    End Sub
    Dim isDataVisible As Boolean = False

    Private Sub btnLoadInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInventory.Click
        If isDataVisible Then
            dgvInventory.DataSource = Nothing
            isDataVisible = False
        Else
            refreshMe()
            isDataVisible = True
        End If
    End Sub

    Private Sub refreshMe()
        Try

            If con.State = ConnectionState.Open Then con.Close()


            con.Open()

            Dim query As String = "SELECT service_id, service_name, service_description, price, stocked, created_at, updated_at FROM service_items"
            Dim myCmd1 As New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(myCmd1)
            Dim ds As New DataSet


            da.Fill(ds, "service_items")


            dgvInventory.DataSource = ds.Tables("service_items")

            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvInventory.RowsDefaultCellStyle.BackColor = Drawing.Color.Azure
            dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Crimson


            dgvInventory.Columns("service_id").HeaderText = "Service/Item ID"
            dgvInventory.Columns("service_name").HeaderText = "Service/Item Name"
            dgvInventory.Columns("service_description").HeaderText = "Description"
            dgvInventory.Columns("price").HeaderText = "Price"
            dgvInventory.Columns("stocked").HeaderText = "Stock"
            dgvInventory.Columns("created_at").HeaderText = "Created At"
            dgvInventory.Columns("updated_at").HeaderText = "Last Updated"


            dgvInventory.Refresh()

        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub




    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        Dim service_name As String
        Dim service_description As String
        Dim price As String
        Dim stocked As String
        Dim priceValue As Decimal
        Dim stockedValue As Integer

        service_name = txtItemName.Text.ToUpper.Trim
        service_description = txtDescription.Text.ToUpper.Trim
        price = txtPrice.Text.Trim
        stocked = txtStock.Text.Trim

        txtItemName.BackColor = Color.White
        txtDescription.BackColor = Color.White
        txtPrice.BackColor = Color.White
        txtStock.BackColor = Color.White

        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(service_name) Then
            txtItemName.BackColor = Color.Red
            isValid = False
        End If

        If String.IsNullOrEmpty(service_description) Then
            txtDescription.BackColor = Color.Red
            isValid = False
        End If

        If String.IsNullOrEmpty(price) Then
            txtPrice.BackColor = Color.Red
            isValid = False
        End If

        If String.IsNullOrEmpty(stocked) Then
            txtStock.BackColor = Color.Red
            isValid = False
        End If

        If Not isValid Then
            MessageBox.Show("Please fill all the fields (Name, Description, Price, and Stock).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Decimal.TryParse(price, priceValue) AndAlso Integer.TryParse(stocked, stockedValue) Then
            con.Close()

            Try
                con.Open()
                With mycmd
                    .Connection = con
                    .CommandText = "INSERT INTO service_items (service_name, service_description, price, stocked, created_at, updated_at) " & _
                                   "VALUES ('" & service_name & "', '" & service_description & "', " & priceValue & ", " & stockedValue & ", CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)"
                    .ExecuteNonQuery()
                End With


                MessageBox.Show("Service/Item Information Added", "Add Service/Item", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtItemName.Clear()
                txtDescription.Clear()
                txtPrice.Clear()
                txtStock.Clear()

                txtItemName.Focus()

                Call get_service_id()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Please enter valid price and stock values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        txtItemName.Clear()
        txtDescription.Clear()
        txtPrice.Clear()
        txtStock.Clear()
        txtCreationDate.Clear()
        txtLastUpdated.Clear()

        txtItemID.ReadOnly = False
        txtItemName.ReadOnly = False
        txtDescription.ReadOnly = False
        txtPrice.ReadOnly = False
        txtStock.ReadOnly = False
        txtCreationDate.ReadOnly = False
        txtLastUpdated.ReadOnly = False
    End Sub





    Private Sub dgvInventory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        If e.RowIndex >= 0 Then
            Dim i As Integer = e.RowIndex
            txtItemID.Text = dgvInventory.Item(0, i).Value.ToString()
            txtItemName.Text = dgvInventory.Item(1, i).Value.ToString()
            txtDescription.Text = dgvInventory.Item(2, i).Value.ToString()
            txtPrice.Text = dgvInventory.Item(3, i).Value.ToString()
            txtStock.Text = dgvInventory.Item(4, i).Value.ToString()

            If dgvInventory.Item(5, i).Value IsNot DBNull.Value Then
                txtCreationDate.Text = Convert.ToDateTime(dgvInventory.Item(5, i).Value).ToString("yyyy-MM-dd HH:mm:ss")
            Else
                txtCreationDate.Text = "N/A"
            End If

            If dgvInventory.Item(6, i).Value IsNot DBNull.Value Then
                txtLastUpdated.Text = Convert.ToDateTime(dgvInventory.Item(6, i).Value).ToString("yyyy-MM-dd HH:mm:ss")
            Else
                txtLastUpdated.Text = "N/A"
            End If

            txtItemName.Enabled = False
            txtDescription.Enabled = False
            txtPrice.Enabled = False
            txtStock.Enabled = False
            txtCreationDate.Enabled = False
            txtLastUpdated.Enabled = False

            btnAddItem.Enabled = False


        End If
    End Sub


    Private Sub btnActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActive.Click
        Dim service_id As String = txtID.Text.Trim()

        If String.IsNullOrEmpty(service_id) Then
            MessageBox.Show("Please enter a valid Service ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(constring) Then
            MessageBox.Show("Database connection string is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sql As String = "UPDATE service_items SET status = 'active', updated_at = CURRENT_TIMESTAMP WHERE service_id = " & service_id

        Try

            con.ConnectionString = constring
            con.Open()


            With mycmd
                .Connection = con
                .CommandText = sql


                Dim rowsAffected As Integer = .ExecuteNonQuery()


                If rowsAffected > 0 Then
                    MessageBox.Show("Service item activated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No service item found with that ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnVoid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoid.Click
        Dim service_id As String = txtID.Text.Trim()

        If String.IsNullOrEmpty(service_id) Then
            MessageBox.Show("Please enter a valid Service ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If String.IsNullOrEmpty(constring) Then
            MessageBox.Show("Database connection string is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sql As String = "UPDATE service_items SET status = 'voided', updated_at = CURRENT_TIMESTAMP WHERE service_id = " & service_id

        Try

            con.ConnectionString = constring
            con.Open()

            With mycmd
                .Connection = con
                .CommandText = sql


                Dim rowsAffected As Integer = .ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Service item voided successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No service item found with that ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Frm_vet.Show()
        Me.Hide()
    End Sub
    Private Sub btnupdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtidrestock.Text.Trim() = "" Or txtquantity.Text.Trim() = "" Then
            MessageBox.Show("Please enter both ID and quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim itemId As Integer
        Dim quantity As Integer

        If Not Integer.TryParse(txtidrestock.Text.Trim(), itemId) Then
            MessageBox.Show("Please enter a valid numeric ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Integer.TryParse(txtquantity.Text.Trim(), quantity) OrElse quantity < 0 Then
            MessageBox.Show("Please enter a valid positive quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try

            connectMe()

            Dim query As String = "UPDATE service_items SET stocked = stocked + " & quantity & " WHERE service_id = " & itemId


            Using mycmd As New OdbcCommand(query, con)
                Dim rowsAffected As Integer = mycmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No item found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class