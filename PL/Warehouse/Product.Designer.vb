<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btEx_Product = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_addProductNew = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cIdProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNameProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cReserve = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1173, 548)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.DGV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1165, 519)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รายการสินค้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btEx_Product)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.btn_addProductNew)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1156, 97)
        Me.Panel4.TabIndex = 1
        '
        'btEx_Product
        '
        Me.btEx_Product.BackColor = System.Drawing.Color.Green
        Me.btEx_Product.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btEx_Product.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEx_Product.ForeColor = System.Drawing.Color.White
        Me.btEx_Product.Image = Global.PL.My.Resources.Resources.clear_2
        Me.btEx_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEx_Product.Location = New System.Drawing.Point(697, 24)
        Me.btEx_Product.Name = "btEx_Product"
        Me.btEx_Product.Size = New System.Drawing.Size(112, 54)
        Me.btEx_Product.TabIndex = 4
        Me.btEx_Product.Text = "Export"
        Me.btEx_Product.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEx_Product.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.lbSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(285, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 81)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาจากชื่อสินค้า"
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(14, 32)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(274, 29)
        Me.tbSearch.TabIndex = 0
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSearch.ForeColor = System.Drawing.Color.White
        Me.lbSearch.Location = New System.Drawing.Point(294, 38)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(84, 20)
        Me.lbSearch.TabIndex = 2
        Me.lbSearch.Text = "ค้นหาสินค้า"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(854, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 82)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "สถานะ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PL.My.Resources.Resources.C_1
        Me.PictureBox1.Location = New System.Drawing.Point(9, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 51)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(79, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 25)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "สถานะ : เปิดขาย"
        '
        'btn_addProductNew
        '
        Me.btn_addProductNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_addProductNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addProductNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_addProductNew.ForeColor = System.Drawing.Color.White
        Me.btn_addProductNew.Image = Global.PL.My.Resources.Resources.P_6
        Me.btn_addProductNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addProductNew.Location = New System.Drawing.Point(19, 17)
        Me.btn_addProductNew.Name = "btn_addProductNew"
        Me.btn_addProductNew.Size = New System.Drawing.Size(186, 59)
        Me.btn_addProductNew.TabIndex = 1
        Me.btn_addProductNew.Text = "เพิ่มสินค้าใหม่"
        Me.btn_addProductNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addProductNew.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdProduct, Me.cNameProduct, Me.cReserve, Me.Column1, Me.cPrice, Me.cStock, Me.cUnit, Me.cEdit})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV.Location = New System.Drawing.Point(3, 106)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(1156, 407)
        Me.DGV.TabIndex = 0
        '
        'cIdProduct
        '
        Me.cIdProduct.HeaderText = "รหัสสินค้า"
        Me.cIdProduct.Name = "cIdProduct"
        Me.cIdProduct.ReadOnly = True
        '
        'cNameProduct
        '
        Me.cNameProduct.HeaderText = "รายละเอียดย่อย"
        Me.cNameProduct.Name = "cNameProduct"
        Me.cNameProduct.ReadOnly = True
        '
        'cReserve
        '
        Me.cReserve.HeaderText = "สั่งจองทั้งหมด"
        Me.cReserve.Name = "cReserve"
        Me.cReserve.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ราคาต้นทุน"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'cPrice
        '
        DataGridViewCellStyle3.Format = "#,##0.00"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.cPrice.HeaderText = "ราคาขาย"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'cStock
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cStock.DefaultCellStyle = DataGridViewCellStyle4
        Me.cStock.HeaderText = "จำนวนสินค้าคงเหลือในสต๊อก"
        Me.cStock.Name = "cStock"
        Me.cStock.ReadOnly = True
        '
        'cUnit
        '
        Me.cUnit.HeaderText = "หน่วย"
        Me.cUnit.Name = "cUnit"
        Me.cUnit.ReadOnly = True
        '
        'cEdit
        '
        Me.cEdit.HeaderText = "แก้ไขข้อมูล"
        Me.cEdit.Name = "cEdit"
        Me.cEdit.ReadOnly = True
        Me.cEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cEdit.Text = "แก้ไขข้อมูล"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 636)
        Me.Panel1.TabIndex = 1
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1197, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Product"
        Me.Text = "สินค้า"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lbSearch As Label
    Friend WithEvents btn_addProductNew As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents btEx_Product As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cIdProduct As DataGridViewTextBoxColumn
    Friend WithEvents cNameProduct As DataGridViewTextBoxColumn
    Friend WithEvents cReserve As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
    Friend WithEvents cStock As DataGridViewTextBoxColumn
    Friend WithEvents cUnit As DataGridViewTextBoxColumn
    Friend WithEvents cEdit As DataGridViewButtonColumn
End Class
