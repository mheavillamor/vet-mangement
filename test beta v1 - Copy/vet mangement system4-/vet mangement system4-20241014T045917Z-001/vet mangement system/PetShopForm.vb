Imports System.Data.Odbc
Imports System.Text
Imports System.Drawing.Printing
Public Class PetShopForm
    Dim totalAmount As Decimal = 0
    Dim paidAmount As Decimal = 0
    Dim changeAmount As Decimal = 0
    Private ReceiptContent As String = ""
    WithEvents txtPaidAmount As TextBox
    WithEvents lblTotalAmount As Label
    WithEvents lblPaidAmount As Label
    WithEvents lblChangeAmount As Label
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PetShopForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SetupListView()
        SetupLabels()
    End Sub

    Private Sub SetupLabels()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblPaidAmount = New System.Windows.Forms.Label()
        Me.lblChangeAmount = New System.Windows.Forms.Label()

        If lblTotalAmount IsNot Nothing Then
            lblTotalAmount.Text = "TOTAL: 0.00"
        End If

        If lblPaidAmount IsNot Nothing Then
            lblPaidAmount.Text = "PAID: 0.00"
        End If

        If lblChangeAmount IsNot Nothing Then
            lblChangeAmount.Text = "CHANGE: 0.00"
        End If
    End Sub
    Private Sub SetupListView()
        lvCart.Columns.Add("Service Name", 150)
        lvCart.Columns.Add("Quantity", 80)
        lvCart.Columns.Add("Unit Price", 100)
        lvCart.Columns.Add("Total Price", 100)
        lvCart.View = View.Details
        lvCart.FullRowSelect = True
    End Sub
    Private Sub txtServiceId_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtServiceId.KeyDown
        If e.KeyCode = Keys.Enter Then
            FillServiceDetails(txtServiceId.Text)

            txtQuantity.Focus()
        End If
    End Sub
    Private Sub btnAddToCart_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles btnAddToCart.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItemToCart()
        End If
    End Sub
    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddToCart.Focus()
        End If
    End Sub
    Private Sub txtAmountPaid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtAmountPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPrint.Focus()
        End If
    End Sub
    Private Sub txtReceiptID_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtReceiptID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnVoid.Focus()
        End If
    End Sub

    Private Sub FillServiceDetails(ByVal serviceId As String)
        If String.IsNullOrEmpty(serviceId) Then
            MsgBox("Please enter a valid Service ID.")
            Exit Sub
        End If

        Try
            connectMe()
            mycmd.Connection = con
            mycmd.CommandText = "SELECT service_name, price FROM service_items WHERE service_id = ?"
            mycmd.Parameters.Clear()
            mycmd.Parameters.AddWithValue("?", serviceId)
            Dim reader As OdbcDataReader = mycmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                txtServiceName.Text = reader("service_name").ToString()
                txtPrice.Text = reader("price").ToString()
            Else
                MsgBox("Service ID not found. Please check the ID and try again.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub CalculateTotalPrice()
        Try
            Dim quantity As Integer = Convert.ToInt32(txtQuantity.Text)
            Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)
            txtTotalPrice.Text = (quantity * price).ToString("0.00")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddItemToCart()
        If String.IsNullOrEmpty(txtServiceName.Text) OrElse String.IsNullOrEmpty(txtPrice.Text) OrElse String.IsNullOrEmpty(txtQuantity.Text) Then
            MsgBox("Please fill in all the required fields (Service Name, Price, and Quantity).")
            Exit Sub
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MsgBox("Please enter a valid number for Quantity.")
            Exit Sub
        End If

        MsgBox("Item added to cart successfully.")
    End Sub
    Private Sub btnAddToCart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddToCart.Click

        If txtServiceName.Text = "" OrElse txtQuantity.Text = "" OrElse txtPrice.Text = "" Then
            MsgBox("Please fill in all required fields.")
            Exit Sub
        End If

        Dim quantity As Integer
        Dim price As Decimal
        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse Not Decimal.TryParse(txtPrice.Text, price) Then
            MsgBox("Please enter valid numeric values for Quantity and Price.")
            Exit Sub
        End If

        Dim stock As Integer = GetItemStock(txtServiceName.Text)
        Dim itemStatus As String = GetItemStatus(txtServiceName.Text)
        If quantity > stock Then
            MsgBox("Not enough stock available. Only " & stock.ToString() & " items left.")
            Exit Sub
        End If
        If itemStatus = "voided" Then
            MsgBox("This item is voided and cannot be added to the cart.", MsgBoxStyle.Critical, "Item Void")
            Exit Sub
        End If
        Dim totalPrice As Decimal = quantity * price
        Dim item As New ListViewItem(txtServiceName.Text)
        item.SubItems.Add(quantity.ToString())
        item.SubItems.Add(price.ToString("0.00"))
        item.SubItems.Add(totalPrice.ToString("0.00"))

        lvCart.Items.Add(item)
        CalculateTotalAmount()
        CalculateChange()

        txtServiceId.Clear()
        txtServiceName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()

        For Each listItem As ListViewItem In lvCart.Items
            Dim serviceName As String = listItem.SubItems(0).Text
            Dim itemQuantity As Integer = Convert.ToInt32(listItem.SubItems(1).Text)
            Dim unitPrice As Decimal = Convert.ToDecimal(listItem.SubItems(2).Text)
            Dim itemTotalPrice As Decimal = itemQuantity * unitPrice

            totalAmount += itemTotalPrice
            listItem.SubItems.Add(itemQuantity.ToString() & " x " & serviceName & " " & itemTotalPrice.ToString("0.00"))

            Dim updateStockCmd As New OdbcCommand
            updateStockCmd.Connection = con
            updateStockCmd.CommandText = "UPDATE service_items SET stocked = stocked - " & itemQuantity & _
                                         " WHERE service_name = '" & serviceName & "' AND stocked >= " & itemQuantity
            updateStockCmd.ExecuteNonQuery()

        Next
    End Sub

    Private Function GetItemStock(ByVal serviceName As String) As Integer
        Dim stock As Integer = 0
        Dim cmd As New OdbcCommand("SELECT stocked FROM service_items WHERE service_name = ?", con)
        cmd.Parameters.AddWithValue("@serviceName", serviceName)

        Dim reader As OdbcDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            stock = Convert.ToInt32(reader("stocked"))
        End If
        reader.Close()

        Return stock
    End Function
    Private Function GetItemStatus(ByVal serviceName As String) As String
        Dim status As String = ""
        Dim cmd As New OdbcCommand("SELECT status FROM service_items WHERE service_name = ?", con)
        cmd.Parameters.AddWithValue("@serviceName", serviceName)

        Dim reader As OdbcDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            status = Convert.ToString(reader("status"))
        End If
        reader.Close()

        Return status
    End Function

    Private Sub RemoveItemFromCart()
        If lvCart.SelectedItems.Count > 0 Then
            totalAmount -= Convert.ToDecimal(lvCart.SelectedItems(0).SubItems(3).Text)
            lvCart.Items.Remove(lvCart.SelectedItems(0))
            lblTotalAmount.Text = "TOTAL: " & totalAmount.ToString("0.00")
        Else
            MsgBox("Please select an item to remove.")
        End If
    End Sub
    Private Sub txtQuantity_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtQuantity.TextChanged, txtPrice.TextChanged
        CalculateTotalPrice()

    End Sub
    Private Sub txtPaidAmount_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPaidAmount.TextChanged
        If txtPaidAmount.Text <> "" Then
            Try
                paidAmount = Convert.ToDecimal(txtPaidAmount.Text)
                changeAmount = paidAmount - totalAmount
                lblPaidAmount.Text = "PAID: " & paidAmount.ToString("0.00")
                lblChangeAmount.Text = "CHANGE: " & changeAmount.ToString("0.00")
            Catch ex As Exception
                MsgBox("Invalid input for Paid Amount.")
            End Try
        End If
    End Sub

    Private Sub CalculateTotalAmount()
        Dim total As Decimal = 0
        For Each item As ListViewItem In lvCart.Items
            Dim itemTotalPrice As Decimal
            If Decimal.TryParse(item.SubItems(3).Text, itemTotalPrice) Then
                total += itemTotalPrice
            End If
        Next
        txtTotalAmount.Text = total.ToString("0.00")
        lblTotalAmount.Text = "TOTAL: " & total.ToString("0.00")
    End Sub



    Private Sub CalculateChange()
        Try
            If String.IsNullOrEmpty(txtTotalAmount.Text) OrElse Not IsNumeric(txtTotalAmount.Text) Then

                Exit Sub
            End If

            If String.IsNullOrEmpty(txtAmountPaid.Text) OrElse Not IsNumeric(txtAmountPaid.Text) Then

                Exit Sub
            End If
            Dim total As Decimal = Convert.ToDecimal(txtTotalAmount.Text)
            Dim amountPaid As Decimal = Convert.ToDecimal(txtAmountPaid.Text)
            Dim change As Decimal = amountPaid - total
            If change < 0 Then

                txtChange.Text = "0.00"
            Else
                txtChange.Text = change.ToString("0.00")
            End If
        Catch ex As Exception
            MsgBox("Error calculating change: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateTotalAndChange()
        CalculateTotalAmount()
        CalculateChange()
    End Sub

    Private Sub txtAmountPaid_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAmountPaid.TextChanged

        CalculateChange()
    End Sub
    Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemove.Click
        If lvCart.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvCart.SelectedItems(0)
            Dim serviceName As String = selectedItem.SubItems(0).Text
            Dim itemQuantity As Integer = Convert.ToInt32(selectedItem.SubItems(1).Text)
            Dim updateStockCmd As New OdbcCommand
            updateStockCmd.Connection = con
            updateStockCmd.CommandText = "UPDATE service_items SET stocked = stocked + " & itemQuantity & _
                                         " WHERE service_name = '" & serviceName & "'"
            updateStockCmd.ExecuteNonQuery()
            lvCart.Items.Remove(selectedItem)
            CalculateTotalAmount()
        Else
            MsgBox("Please select an item to remove.")
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click

        Dim receiptId As Integer = 0
        Dim receiptDate As DateTime = DateTime.Now
        Dim totalAmount As Decimal = 0
        Dim amountPaid As Decimal = 0
        Dim change As Decimal = 0
        Dim items As New List(Of String)()
        Dim constring As String = "driver={MySQL ODBC 5.3 ANSI Driver};localhost;port=3308;uid='root';pwd=;database=vet_db"

        If String.IsNullOrEmpty(txtAmountPaid.Text) OrElse Not Decimal.TryParse(txtAmountPaid.Text, amountPaid) Then
            MessageBox.Show("Please enter a valid amount paid.")
            Exit Sub
        End If


        If String.IsNullOrEmpty(txtChange.Text) OrElse Not Decimal.TryParse(txtChange.Text, change) Then
            MessageBox.Show("Please enter a valid change amount.")
            Exit Sub
        End If


        Using con As New OdbcConnection(constring)
            Try
                con.Open()

                For Each item As ListViewItem In lvCart.Items
                    Dim serviceName As String = item.SubItems(0).Text
                    Dim quantity As Integer = Convert.ToInt32(item.SubItems(1).Text)
                    Dim unitPrice As Decimal = Convert.ToDecimal(item.SubItems(2).Text)
                    Dim totalPrice As Decimal = quantity * unitPrice
                    totalAmount += totalPrice


                    items.Add(quantity.ToString() & " x " & serviceName & " " & totalPrice.ToString("0.00"))
                Next


                change = amountPaid - totalAmount


                Dim cmd As New OdbcCommand
                With cmd
                    .Connection = con
                    .CommandText = "INSERT INTO receipts VALUES (null,'" & receiptDate.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & totalAmount.ToString("0.00") & "', '" & amountPaid.ToString("0.00") & "', '" & change.ToString("0.00") & "', 'complete')"
                    .ExecuteNonQuery()
                End With


                receiptId = Convert.ToInt32(New OdbcCommand("SELECT LAST_INSERT_ID()", con).ExecuteScalar())


                For Each item As ListViewItem In lvCart.Items
                    Dim serviceName As String = item.SubItems(0).Text
                    Dim quantity As Integer = Convert.ToInt32(item.SubItems(1).Text)
                    Dim unitPrice As Decimal = Convert.ToDecimal(item.SubItems(2).Text)
                    Dim totalPrice As Decimal = quantity * unitPrice


                    Dim itemCmd As New OdbcCommand
                    With itemCmd
                        .Connection = con
                        .CommandText = "INSERT INTO receipt_items VALUES (null,'" & receiptId.ToString() & "', '" & serviceName & "', '" & quantity.ToString() & "', '" & unitPrice.ToString("0.00") & "', '" & totalPrice.ToString("0.00") & "')"
                        .ExecuteNonQuery()
                    End With
                Next


                Dim sb As New StringBuilder()
                sb.AppendLine("-------------------------------------")
                sb.AppendLine("            PET SHOP")
                sb.AppendLine("        Itemized Receipt")
                sb.AppendLine("Receipt ID: " & receiptId.ToString())
                sb.AppendLine("Date: " & receiptDate.ToString("MM/dd/yyyy HH:mm:ss"))
                sb.AppendLine("-------------------------------------")


                For Each item As String In items
                    sb.AppendLine(item)
                Next

                sb.AppendLine("-------------------------------------")
                sb.AppendLine("Total: " & totalAmount.ToString("0.00"))
                sb.AppendLine("Amount Paid: " & amountPaid.ToString("0.00"))
                sb.AppendLine("Change: " & change.ToString("0.00"))
                sb.AppendLine("-------------------------------------")

                ReceiptContent = sb.ToString()
                ShowPrintPreview()
                MessageBox.Show("Receipt Added Successfully", "Add Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lvCart.Items.Clear()
            Catch ex As Exception

                MsgBox("Error adding receipt: " & ex.Message)
            Finally
                txtServiceId.Clear()
                txtServiceName.Clear()
                txtQuantity.Clear()
                txtPrice.Clear()
                txtTotalPrice.Clear()
                txtTotalAmount.Clear()
                txtAmountPaid.Clear()
                txtChange.Clear()

            End Try
        End Using
    End Sub

    Private Sub ShowPrintPreview()

        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf PrintPageHandler

        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = pd
        printPreview.ShowDialog()
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim pageWidth As Single = e.PageBounds.Width
        Dim pageHeight As Single = e.PageBounds.Height
        Dim margins As New Drawing.Printing.Margins(50, 50, 50, 50)

        Dim font As New Font("Arial", 10)


        Dim yPos As Single = margins.Top


        Dim receiptText As String = ReceiptContent
        Dim textHeight As Single = e.Graphics.MeasureString(receiptText, font).Height
        Dim remainingHeight As Single = pageHeight - margins.Top - margins.Bottom


        If textHeight > remainingHeight Then

            font = New Font("Arial", 8)
            textHeight = e.Graphics.MeasureString(receiptText, font).Height
        End If


        e.Graphics.DrawString(receiptText, font, Brushes.Black, margins.Left, yPos)

        If textHeight > remainingHeight Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
    Private Sub btnVoid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVoid.Click

        Dim receiptId As Integer
        If String.IsNullOrEmpty(txtReceiptID.Text) OrElse Not Integer.TryParse(txtReceiptID.Text, receiptId) Then
            MessageBox.Show("Please enter a valid Receipt ID.")
            Exit Sub
        End If
        Try
            mod_Connection.connectMe()
            Dim cmd As New OdbcCommand
            With cmd
                .Connection = con
                .CommandText = "UPDATE receipts SET status = 'void' WHERE receipt_id = " & receiptId
                Dim rowsAffected As Integer = .ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Receipt marked as voided successfully.")
                Else
                    MessageBox.Show("Receipt ID not found.")
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("Error voiding receipt: " & ex.Message)
        Finally
            If con.State = System.Data.ConnectionState.Open Then
                con.Close()
            End If
            ShowPrintPreview()
        End Try
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inventory.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Frm_vet.Show()
        Me.Hide()
    End Sub
End Class