<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnVoid = New System.Windows.Forms.Button
        Me.btnActive = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItemID = New System.Windows.Forms.TextBox
        Me.btnAddItem = New System.Windows.Forms.Button
        Me.btnLoadInventory = New System.Windows.Forms.Button
        Me.dgvInventory = New System.Windows.Forms.DataGridView
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.txtStock = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLastUpdated = New System.Windows.Forms.TextBox
        Me.txtCreationDate = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.btnVoid)
        Me.GroupBox1.Controls.Add(Me.btnLoadInventory)
        Me.GroupBox1.Controls.Add(Me.btnAddItem)
        Me.GroupBox1.Controls.Add(Me.btnActive)
        Me.GroupBox1.Location = New System.Drawing.Point(213, 323)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 130)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Item/Service ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(167, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 21
        '
        'btnVoid
        '
        Me.btnVoid.Location = New System.Drawing.Point(134, 56)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(148, 23)
        Me.btnVoid.TabIndex = 20
        Me.btnVoid.Text = "void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'btnActive
        '
        Me.btnActive.Location = New System.Drawing.Point(17, 56)
        Me.btnActive.Name = "btnActive"
        Me.btnActive.Size = New System.Drawing.Size(111, 23)
        Me.btnActive.TabIndex = 19
        Me.btnActive.Text = "active"
        Me.btnActive.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Item/Service ID:"
        '
        'txtItemID
        '
        Me.txtItemID.Location = New System.Drawing.Point(390, 100)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(100, 20)
        Me.txtItemID.TabIndex = 42
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(138, 90)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(129, 23)
        Me.btnAddItem.TabIndex = 39
        Me.btnAddItem.Text = " Add Item/Service"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'btnLoadInventory
        '
        Me.btnLoadInventory.Location = New System.Drawing.Point(30, 90)
        Me.btnLoadInventory.Name = "btnLoadInventory"
        Me.btnLoadInventory.Size = New System.Drawing.Size(89, 23)
        Me.btnLoadInventory.TabIndex = 38
        Me.btnLoadInventory.Text = "Load Inventory"
        Me.btnLoadInventory.UseVisualStyleBackColor = True
        '
        'dgvInventory
        '
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(552, 95)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.Size = New System.Drawing.Size(590, 341)
        Me.dgvInventory.TabIndex = 37
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(552, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Last Updated:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Creation Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Stock Quantity:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(633, 43)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(509, 20)
        Me.txtSearch.TabIndex = 29
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(390, 206)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 26
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(390, 179)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 25
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(390, 153)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 24
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(390, 126)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(100, 20)
        Me.txtItemName.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Item/Service Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Item/Service Description:"
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Location = New System.Drawing.Point(390, 259)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(100, 20)
        Me.txtLastUpdated.TabIndex = 28
        '
        'txtCreationDate
        '
        Me.txtCreationDate.Location = New System.Drawing.Point(390, 232)
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.ReadOnly = True
        Me.txtCreationDate.Size = New System.Drawing.Size(100, 20)
        Me.txtCreationDate.TabIndex = 27
        '
        'inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLastUpdated)
        Me.Controls.Add(Me.txtCreationDate)
        Me.Name = "inventory"
        Me.Text = "inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents btnActive As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnLoadInventory As System.Windows.Forms.Button
    Friend WithEvents dgvInventory As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdated As System.Windows.Forms.TextBox
    Friend WithEvents txtCreationDate As System.Windows.Forms.TextBox
End Class
