<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pet_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pet_view))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.cmb_breed = New System.Windows.Forms.ComboBox
        Me.cmb_species = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Txt_fullname = New System.Windows.Forms.TextBox
        Me.MaleRadio = New System.Windows.Forms.RadioButton
        Me.FemaleRadio = New System.Windows.Forms.RadioButton
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_color = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_petname = New System.Windows.Forms.TextBox
        Me.dgv_petview = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_vid = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_petview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_fname)
        Me.GroupBox1.Controls.Add(Me.txt_lname)
        Me.GroupBox1.Controls.Add(Me.cmb_breed)
        Me.GroupBox1.Controls.Add(Me.cmb_species)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Txt_fullname)
        Me.GroupBox1.Controls.Add(Me.MaleRadio)
        Me.GroupBox1.Controls.Add(Me.FemaleRadio)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_petname)
        Me.GroupBox1.Controls.Add(Me.dgv_petview)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_vid)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1692, 736)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(212, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "LAST NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(64, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "FIRST NAME"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(67, 205)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(126, 27)
        Me.txt_fname.TabIndex = 38
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(216, 205)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(136, 27)
        Me.txt_lname.TabIndex = 37
        '
        'cmb_breed
        '
        Me.cmb_breed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_breed.FormattingEnabled = True
        Me.cmb_breed.Items.AddRange(New Object() {"*CATS", "A", "Abyssinian cat", "Aegean cat", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair", "Arabian Mau", "Asian cat", "Australian Mist", "B", "Balinese cat", "Bengal cat", "Birman", "Bohemian Rex", "Bombay cat", "Brazilian Shorthair", "British Shorthair", "Burmese cat", "Burmilla", "C", "California Spangled", "Cashmere cat", "Chantilly-Tiffany", "Chartreux", "Chausie", "Colorpoint Shorthair", "Cornish Rex", "Cymric cat", "Cyprus cat", "D", "Devon Rex", "Donskoy cat", "Dragon Li", "E", "Egyptian Mau", "European Shorthair", "Exotic Shorthair", "F", "Foldex cat", "Foreign White", "G", "German Rex", "H", "Havana Brown", "Highlander cat", "Himalayan cat", "I", "Isle of Man Longhair cat", "Isle of Man Shorthair cat", "J", "Japanese Bobtail", "Javanese cat", "Jianzhou cat", "K", "Kanaani cat", "Khao Manee", "Korat", "", "*DOGS", "Affenpinscher", "Afghan Hound", "Africanis", "Aidi", "Airedale Terrier", "Akbash", "Akita", "Aksaray Malaklisi", "Alano Español", "Alapaha Blue Blood Bulldog", "Alaskan Husky", "Alaskan Klee Kai", "Alaskan Malamute", "Alopekis", "Alpine Dachsbracke", "American Bulldog", "American Bully", "American Cocker Spaniel", "American English Coonhound", "American Eskimo Dog[19]", "American Foxhound[20]", "American Hairless Terrier", "American Leopard Hound", "American Pit Bull Terrier", "American Staffordshire Terrier", "American Water Spaniel", "Andalusian Terrier", "Anglo-Français de Petite Vénerie", "Appenzeller Sennenhund", "Ariège Pointer", "Ariégeois", "Argentine Pila", "Armant", "Armenian Gampr", "Artois Hound", "Australian Cattle Dog", "Australian Kelpie", "Australian Shepherd", "Australian Silky Terrier", "Australian Stumpy Tail Cattle Dog", "Australian Terrier", "Austrian Black and Tan Hound", "Austrian Pinscher", "Azawakh", "Bắc Hà", "Bakharwal", "Banjara Hound", "Bankhar Dog", "Barak hound", "Barbado da Terceira", "Barbet", "Basenji", "Basque Shepherd Dog", "Basset Artésien Normand"})
        Me.cmb_breed.Location = New System.Drawing.Point(71, 496)
        Me.cmb_breed.Name = "cmb_breed"
        Me.cmb_breed.Size = New System.Drawing.Size(217, 28)
        Me.cmb_breed.TabIndex = 30
        '
        'cmb_species
        '
        Me.cmb_species.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_species.FormattingEnabled = True
        Me.cmb_species.Items.AddRange(New Object() {"CAT", "DOG"})
        Me.cmb_species.Location = New System.Drawing.Point(71, 421)
        Me.cmb_species.Name = "cmb_species"
        Me.cmb_species.Size = New System.Drawing.Size(217, 28)
        Me.cmb_species.TabIndex = 29
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(72, 655)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 26)
        Me.DateTimePicker1.TabIndex = 27
        '
        'Txt_fullname
        '
        Me.Txt_fullname.Enabled = False
        Me.Txt_fullname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fullname.Location = New System.Drawing.Point(67, 292)
        Me.Txt_fullname.Name = "Txt_fullname"
        Me.Txt_fullname.Size = New System.Drawing.Size(281, 27)
        Me.Txt_fullname.TabIndex = 25
        '
        'MaleRadio
        '
        Me.MaleRadio.AutoSize = True
        Me.MaleRadio.Location = New System.Drawing.Point(197, 579)
        Me.MaleRadio.Name = "MaleRadio"
        Me.MaleRadio.Size = New System.Drawing.Size(54, 17)
        Me.MaleRadio.TabIndex = 23
        Me.MaleRadio.TabStop = True
        Me.MaleRadio.Text = "MALE"
        Me.MaleRadio.UseVisualStyleBackColor = True
        '
        'FemaleRadio
        '
        Me.FemaleRadio.AutoSize = True
        Me.FemaleRadio.Location = New System.Drawing.Point(74, 579)
        Me.FemaleRadio.Name = "FemaleRadio"
        Me.FemaleRadio.Size = New System.Drawing.Size(67, 17)
        Me.FemaleRadio.TabIndex = 22
        Me.FemaleRadio.TabStop = True
        Me.FemaleRadio.Text = "FEMALE"
        Me.FemaleRadio.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Snow
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.Location = New System.Drawing.Point(395, 580)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(166, 68)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Snow
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.Location = New System.Drawing.Point(579, 580)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(167, 68)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_update.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Snow
        Me.btn_update.Location = New System.Drawing.Point(752, 579)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(161, 69)
        Me.btn_update.TabIndex = 19
        Me.btn_update.Text = "update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(74, 615)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "BIRTHDAY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(71, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ANIMAL BREED"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ANIMAL SPECIES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(71, 541)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "GENDER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(71, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "COLOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "FULL NAME"
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(71, 361)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(217, 27)
        Me.txt_color.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PET NAME"
        '
        'txt_petname
        '
        Me.txt_petname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname.Location = New System.Drawing.Point(67, 108)
        Me.txt_petname.Name = "txt_petname"
        Me.txt_petname.Size = New System.Drawing.Size(285, 27)
        Me.txt_petname.TabIndex = 3
        '
        'dgv_petview
        '
        Me.dgv_petview.AllowUserToAddRows = False
        Me.dgv_petview.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_petview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_petview.Location = New System.Drawing.Point(378, 36)
        Me.dgv_petview.Name = "dgv_petview"
        Me.dgv_petview.Size = New System.Drawing.Size(910, 474)
        Me.dgv_petview.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PET ID"
        '
        'txt_vid
        '
        Me.txt_vid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vid.Location = New System.Drawing.Point(68, 46)
        Me.txt_vid.Name = "txt_vid"
        Me.txt_vid.Size = New System.Drawing.Size(66, 27)
        Me.txt_vid.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.vet_mangement_system.My.Resources.Resources.fed81b8b054414eb4e0d859d6cbd50ce_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(178, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(676, 475)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1300, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'pet_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vet_mangement_system.My.Resources.Resources.BG5_optimized1
        Me.ClientSize = New System.Drawing.Size(1300, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pet_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_petview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_vid As System.Windows.Forms.TextBox
    Friend WithEvents txt_petname As System.Windows.Forms.TextBox
    Friend WithEvents dgv_petview As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmb_breed As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_species As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
End Class
