<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pet_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pet_info))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_fname = New System.Windows.Forms.TextBox
        Me.txt_lname = New System.Windows.Forms.TextBox
        Me.cmb_species = New System.Windows.Forms.ComboBox
        Me.cmb_breed = New System.Windows.Forms.ComboBox
        Me.Btn_view = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.dtpbd = New System.Windows.Forms.DateTimePicker
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txt_color = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_fullname = New System.Windows.Forms.TextBox
        Me.txt_petname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_vid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_fname)
        Me.GroupBox1.Controls.Add(Me.txt_lname)
        Me.GroupBox1.Controls.Add(Me.cmb_species)
        Me.GroupBox1.Controls.Add(Me.cmb_breed)
        Me.GroupBox1.Controls.Add(Me.Btn_view)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.dtpbd)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_fullname)
        Me.GroupBox1.Controls.Add(Me.txt_petname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_vid)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1300, 733)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PET DETAILS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(646, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 23)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(462, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 23)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "FIRST NAME"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(465, 183)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(143, 27)
        Me.txt_fname.TabIndex = 34
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(650, 183)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(136, 27)
        Me.txt_lname.TabIndex = 33
        '
        'cmb_species
        '
        Me.cmb_species.FormattingEnabled = True
        Me.cmb_species.Items.AddRange(New Object() {"CAT", "DOG"})
        Me.cmb_species.Location = New System.Drawing.Point(469, 461)
        Me.cmb_species.Name = "cmb_species"
        Me.cmb_species.Size = New System.Drawing.Size(292, 30)
        Me.cmb_species.TabIndex = 32
        '
        'cmb_breed
        '
        Me.cmb_breed.FormattingEnabled = True
        Me.cmb_breed.Items.AddRange(New Object() {"*CATS", "A", "Abyssinian cat", "Aegean cat", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair", "Arabian Mau", "Asian cat", "Australian Mist", "B", "Balinese cat", "Bengal cat", "Birman", "Bohemian Rex", "Bombay cat", "Brazilian Shorthair", "British Shorthair", "Burmese cat", "Burmilla", "C", "California Spangled", "Cashmere cat", "Chantilly-Tiffany", "Chartreux", "Chausie", "Colorpoint Shorthair", "Cornish Rex", "Cymric cat", "Cyprus cat", "D", "Devon Rex", "Donskoy cat", "Dragon Li", "E", "Egyptian Mau", "European Shorthair", "Exotic Shorthair", "F", "Foldex cat", "Foreign White", "G", "German Rex", "H", "Havana Brown", "Highlander cat", "Himalayan cat", "I", "Isle of Man Longhair cat", "Isle of Man Shorthair cat", "J", "Japanese Bobtail", "Javanese cat", "Jianzhou cat", "K", "Kanaani cat", "Khao Manee", "Korat", "", "*DOGS", "Affenpinscher", "Afghan Hound", "Africanis", "Aidi", "Airedale Terrier", "Akbash", "Akita", "Aksaray Malaklisi", "Alano Español", "Alapaha Blue Blood Bulldog", "Alaskan Husky", "Alaskan Klee Kai", "Alaskan Malamute", "Alopekis", "Alpine Dachsbracke", "American Bulldog", "American Bully", "American Cocker Spaniel", "American English Coonhound", "American Eskimo Dog[19]", "American Foxhound[20]", "American Hairless Terrier", "American Leopard Hound", "American Pit Bull Terrier", "American Staffordshire Terrier", "American Water Spaniel", "Andalusian Terrier", "Anglo-Français de Petite Vénerie", "Appenzeller Sennenhund", "Ariège Pointer", "Ariégeois", "Argentine Pila", "Armant", "Armenian Gampr", "Artois Hound", "Australian Cattle Dog", "Australian Kelpie", "Australian Shepherd", "Australian Silky Terrier", "Australian Stumpy Tail Cattle Dog", "Australian Terrier", "Austrian Black and Tan Hound", "Austrian Pinscher", "Azawakh", "Bắc Hà", "Bakharwal", "Banjara Hound", "Bankhar Dog", "Barak hound", "Barbado da Terceira", "Barbet", "Basenji", "Basque Shepherd Dog", "Basset Artésien Normand"})
        Me.cmb_breed.Location = New System.Drawing.Point(467, 544)
        Me.cmb_breed.Name = "cmb_breed"
        Me.cmb_breed.Size = New System.Drawing.Size(292, 30)
        Me.cmb_breed.TabIndex = 31
        '
        'Btn_view
        '
        Me.Btn_view.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn_view.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_view.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_view.Location = New System.Drawing.Point(407, 655)
        Me.Btn_view.Name = "Btn_view"
        Me.Btn_view.Size = New System.Drawing.Size(181, 50)
        Me.Btn_view.TabIndex = 27
        Me.Btn_view.TabStop = False
        Me.Btn_view.Text = "VIEW " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATA"
        Me.Btn_view.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_add.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_add.Location = New System.Drawing.Point(665, 655)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(192, 50)
        Me.btn_add.TabIndex = 17
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'dtpbd
        '
        Me.dtpbd.CustomFormat = "yyyy/MM/dd"
        Me.dtpbd.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpbd.Location = New System.Drawing.Point(467, 606)
        Me.dtpbd.MaxDate = New Date(9998, 12, 1, 0, 0, 0, 0)
        Me.dtpbd.Name = "dtpbd"
        Me.dtpbd.Size = New System.Drawing.Size(300, 27)
        Me.dtpbd.TabIndex = 23
        Me.dtpbd.Value = New Date(2024, 10, 1, 22, 3, 8, 0)
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(628, 394)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 27)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "male"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(477, 394)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 27)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "female"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(467, 323)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(288, 27)
        Me.txt_color.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(465, 577)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "BIRTHDAY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(466, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "ANIMAL BREED"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(463, 430)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ANIMAL SPECIES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(466, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(466, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "MAIN COLOR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(463, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "OWNERS FULL NAME"
        '
        'Txt_fullname
        '
        Me.Txt_fullname.Enabled = False
        Me.Txt_fullname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fullname.Location = New System.Drawing.Point(465, 250)
        Me.Txt_fullname.Name = "Txt_fullname"
        Me.Txt_fullname.Size = New System.Drawing.Size(321, 27)
        Me.Txt_fullname.TabIndex = 4
        '
        'txt_petname
        '
        Me.txt_petname.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_petname.Location = New System.Drawing.Point(465, 100)
        Me.txt_petname.Name = "txt_petname"
        Me.txt_petname.Size = New System.Drawing.Size(288, 27)
        Me.txt_petname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(461, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PET NAME"
        '
        'txt_vid
        '
        Me.txt_vid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vid.Location = New System.Drawing.Point(465, 41)
        Me.txt_vid.Name = "txt_vid"
        Me.txt_vid.Size = New System.Drawing.Size(52, 27)
        Me.txt_vid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(463, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "pet id"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1300, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.vet_mangement_system.My.Resources.Resources.fed81b8b054414eb4e0d859d6cbd50ce_removebg_preview
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'pet_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 758)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pet_info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_vid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_fullname As System.Windows.Forms.TextBox
    Friend WithEvents txt_petname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents txt_color As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents dtpbd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_view As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmb_breed As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_species As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
End Class
