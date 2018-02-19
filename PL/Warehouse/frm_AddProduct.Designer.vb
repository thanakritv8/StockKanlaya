<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddProduct
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btClear = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PicProduct = New System.Windows.Forms.PictureBox()
        Me.tbDetail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbIdCategory = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNameCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPosition = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbBlock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbBrand = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tbUnit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbPriceSell = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbPriceBuy = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cIdCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNameCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNameProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPriceBuy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPriceSell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbNameCategory = New System.Windows.Forms.ComboBox()
        Me.tbNameProduct = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btClear)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.btDel)
        Me.Panel1.Controls.Add(Me.btSave)
        Me.Panel1.Controls.Add(Me.btEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 567)
        Me.Panel1.TabIndex = 0
        '
        'btClear
        '
        Me.btClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClear.ForeColor = System.Drawing.Color.White
        Me.btClear.Image = Global.PL.My.Resources.Resources.clear
        Me.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btClear.Location = New System.Drawing.Point(989, 333)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(114, 56)
        Me.btClear.TabIndex = 13
        Me.btClear.Text = "เคลียร์"
        Me.btClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btClear.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(971, 476)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(963, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "เพิ่มสินค้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.tbDetail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbIdCategory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbNameCategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(951, 430)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลพื้นฐาน"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(19, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(926, 69)
        Me.Panel2.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(119, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(658, 32)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "กำหนดสินค้า รหัสสินค้า, ชื่อสินค้า, รายละเอียดสินค้า และอื่นๆ ให้ถูกต้อง"
        '
        'PicProduct
        '
        Me.PicProduct.BackColor = System.Drawing.Color.Silver
        Me.PicProduct.Location = New System.Drawing.Point(330, 39)
        Me.PicProduct.Name = "PicProduct"
        Me.PicProduct.Size = New System.Drawing.Size(174, 120)
        Me.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProduct.TabIndex = 22
        Me.PicProduct.TabStop = False
        '
        'tbDetail
        '
        Me.tbDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbDetail.Location = New System.Drawing.Point(33, 279)
        Me.tbDetail.Multiline = True
        Me.tbDetail.Name = "tbDetail"
        Me.tbDetail.Size = New System.Drawing.Size(375, 125)
        Me.tbDetail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "รายละเอียดของสินค้า"
        '
        'tbIdCategory
        '
        Me.tbIdCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbIdCategory.Location = New System.Drawing.Point(35, 158)
        Me.tbIdCategory.Name = "tbIdCategory"
        Me.tbIdCategory.Size = New System.Drawing.Size(373, 29)
        Me.tbIdCategory.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสสินค้า"
        '
        'tbNameCategory
        '
        Me.tbNameCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbNameCategory.Location = New System.Drawing.Point(35, 219)
        Me.tbNameCategory.Name = "tbNameCategory"
        Me.tbNameCategory.Size = New System.Drawing.Size(373, 29)
        Me.tbNameCategory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อสินค้า"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(19, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 317)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "สินค้าหมวดที่ 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.PicProduct)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Location = New System.Drawing.Point(430, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 317)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายละเอียดหน่วยสินค้า"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(349, 173)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(135, 30)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "ใส่รูปภาพสินค้า"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.tbTag)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.tbPosition)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.tbBlock)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tbBrand)
        Me.Panel5.Location = New System.Drawing.Point(19, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(302, 257)
        Me.Panel5.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "แท็ก  (เช่น โปรโมชั่น, สินค้าขายดี)"
        '
        'tbTag
        '
        Me.tbTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTag.Location = New System.Drawing.Point(10, 217)
        Me.tbTag.Name = "tbTag"
        Me.tbTag.Size = New System.Drawing.Size(282, 29)
        Me.tbTag.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ตำแหน่งจัดวางสินค้า  (เช่น ชั้นที่ 1, แถวที่ 2)"
        '
        'tbPosition
        '
        Me.tbPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbPosition.Location = New System.Drawing.Point(10, 157)
        Me.tbPosition.Name = "tbPosition"
        Me.tbPosition.Size = New System.Drawing.Size(282, 29)
        Me.tbPosition.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "หมวดหมู่สินค้า  (เช่น เสื้อ, กางเกง, รองเท้า)"
        '
        'tbBlock
        '
        Me.tbBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbBlock.Location = New System.Drawing.Point(10, 93)
        Me.tbBlock.Name = "tbBlock"
        Me.tbBlock.Size = New System.Drawing.Size(282, 29)
        Me.tbBlock.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "แบรนด์"
        '
        'tbBrand
        '
        Me.tbBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbBrand.Location = New System.Drawing.Point(10, 30)
        Me.tbBrand.Name = "tbBrand"
        Me.tbBrand.Size = New System.Drawing.Size(282, 29)
        Me.tbBrand.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tbUnit)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.tbAmount)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.tbPriceSell)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.tbPriceBuy)
        Me.TabPage3.Controls.Add(Me.DGV)
        Me.TabPage3.Controls.Add(Me.btAdd)
        Me.TabPage3.Controls.Add(Me.cbNameCategory)
        Me.TabPage3.Controls.Add(Me.tbNameProduct)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(963, 442)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ชนิดสินค้า"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tbUnit
        '
        Me.tbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbUnit.Location = New System.Drawing.Point(802, 33)
        Me.tbUnit.Name = "tbUnit"
        Me.tbUnit.Size = New System.Drawing.Size(84, 29)
        Me.tbUnit.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(805, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "หน่วย"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(709, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "จำนวน"
        '
        'tbAmount
        '
        Me.tbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbAmount.Location = New System.Drawing.Point(712, 33)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(84, 29)
        Me.tbAmount.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(611, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "ราคาขาย"
        '
        'tbPriceSell
        '
        Me.tbPriceSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbPriceSell.Location = New System.Drawing.Point(614, 33)
        Me.tbPriceSell.Name = "tbPriceSell"
        Me.tbPriceSell.Size = New System.Drawing.Size(92, 29)
        Me.tbPriceSell.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(515, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "ราคาทุน"
        '
        'tbPriceBuy
        '
        Me.tbPriceBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbPriceBuy.Location = New System.Drawing.Point(518, 33)
        Me.tbPriceBuy.Name = "tbPriceBuy"
        Me.tbPriceBuy.Size = New System.Drawing.Size(90, 29)
        Me.tbPriceBuy.TabIndex = 8
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdCategory, Me.cNameCategory, Me.cIdProduct, Me.cNameProduct, Me.cPriceBuy, Me.cPriceSell, Me.cAmount, Me.cUnit, Me.cDel})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.Location = New System.Drawing.Point(10, 68)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(947, 368)
        Me.DGV.TabIndex = 7
        '
        'cIdCategory
        '
        Me.cIdCategory.HeaderText = "รหัสสินค้า"
        Me.cIdCategory.Name = "cIdCategory"
        Me.cIdCategory.ReadOnly = True
        '
        'cNameCategory
        '
        Me.cNameCategory.HeaderText = "ชื่อสินค้า"
        Me.cNameCategory.Name = "cNameCategory"
        Me.cNameCategory.ReadOnly = True
        '
        'cIdProduct
        '
        Me.cIdProduct.HeaderText = "รหัสสินค้าย่อย"
        Me.cIdProduct.Name = "cIdProduct"
        Me.cIdProduct.ReadOnly = True
        '
        'cNameProduct
        '
        Me.cNameProduct.HeaderText = "ชื่อสินค้าย่อย"
        Me.cNameProduct.Name = "cNameProduct"
        Me.cNameProduct.ReadOnly = True
        '
        'cPriceBuy
        '
        DataGridViewCellStyle2.Format = "#,##0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cPriceBuy.DefaultCellStyle = DataGridViewCellStyle2
        Me.cPriceBuy.HeaderText = "ราคาต้นทุน"
        Me.cPriceBuy.Name = "cPriceBuy"
        Me.cPriceBuy.ReadOnly = True
        '
        'cPriceSell
        '
        DataGridViewCellStyle3.Format = "#,##0.00"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cPriceSell.DefaultCellStyle = DataGridViewCellStyle3
        Me.cPriceSell.HeaderText = "ราคาขาย"
        Me.cPriceSell.Name = "cPriceSell"
        Me.cPriceSell.ReadOnly = True
        '
        'cAmount
        '
        DataGridViewCellStyle4.Format = "#,##0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cAmount.DefaultCellStyle = DataGridViewCellStyle4
        Me.cAmount.HeaderText = "จำนวนสินค้าในสต๊อก"
        Me.cAmount.Name = "cAmount"
        Me.cAmount.ReadOnly = True
        '
        'cUnit
        '
        Me.cUnit.HeaderText = "หน่วย"
        Me.cUnit.Name = "cUnit"
        Me.cUnit.ReadOnly = True
        '
        'cDel
        '
        Me.cDel.HeaderText = "ลบ"
        Me.cDel.Name = "cDel"
        Me.cDel.ReadOnly = True
        Me.cDel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Location = New System.Drawing.Point(892, 28)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 36)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "เพิ่ม"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'cbNameCategory
        '
        Me.cbNameCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbNameCategory.FormattingEnabled = True
        Me.cbNameCategory.Location = New System.Drawing.Point(10, 34)
        Me.cbNameCategory.Name = "cbNameCategory"
        Me.cbNameCategory.Size = New System.Drawing.Size(217, 28)
        Me.cbNameCategory.TabIndex = 5
        '
        'tbNameProduct
        '
        Me.tbNameProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbNameProduct.Location = New System.Drawing.Point(233, 33)
        Me.tbNameProduct.Name = "tbNameProduct"
        Me.tbNameProduct.Size = New System.Drawing.Size(279, 29)
        Me.tbNameProduct.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(230, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "สินค้าย่อย"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ชื่อสินค้า"
        '
        'btDel
        '
        Me.btDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.ForeColor = System.Drawing.Color.White
        Me.btDel.Image = Global.PL.My.Resources.Resources.icondelete
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(989, 256)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(114, 59)
        Me.btDel.TabIndex = 12
        Me.btDel.Text = "ลบ"
        Me.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDel.UseVisualStyleBackColor = False
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSave.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.ForeColor = System.Drawing.Color.White
        Me.btSave.Image = Global.PL.My.Resources.Resources.img_1
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSave.Location = New System.Drawing.Point(989, 98)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(114, 60)
        Me.btSave.TabIndex = 10
        Me.btSave.Text = "บันทึก"
        Me.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSave.UseVisualStyleBackColor = False
        '
        'btEdit
        '
        Me.btEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEdit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.ForeColor = System.Drawing.Color.White
        Me.btEdit.Image = Global.PL.My.Resources.Resources.P_5
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(989, 176)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(114, 64)
        Me.btEdit.TabIndex = 11
        Me.btEdit.Text = "แก้ไข"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEdit.UseVisualStyleBackColor = False
        '
        'frm_AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 567)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frm_AddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มข้อมูลสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btDel As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btSave As Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbTag As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbBlock As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbBrand As System.Windows.Forms.TextBox
    Friend WithEvents tbDetail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbIdCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNameCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbPriceSell As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbPriceBuy As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents cbNameCategory As System.Windows.Forms.ComboBox
    Friend WithEvents tbNameProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PicProduct As System.Windows.Forms.PictureBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents cIdCategory As DataGridViewTextBoxColumn
    Friend WithEvents cNameCategory As DataGridViewTextBoxColumn
    Friend WithEvents cIdProduct As DataGridViewTextBoxColumn
    Friend WithEvents cNameProduct As DataGridViewTextBoxColumn
    Friend WithEvents cPriceBuy As DataGridViewTextBoxColumn
    Friend WithEvents cPriceSell As DataGridViewTextBoxColumn
    Friend WithEvents cAmount As DataGridViewTextBoxColumn
    Friend WithEvents cUnit As DataGridViewTextBoxColumn
    Friend WithEvents cDel As DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
