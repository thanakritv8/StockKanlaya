<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Product
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbMenu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.DGVSelect = New System.Windows.Forms.DataGridView()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c6 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVPro = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNum1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cIdProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFree = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btAdd)
        Me.Panel2.Controls.Add(Me.DGVSelect)
        Me.Panel2.Controls.Add(Me.Tab)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1149, 639)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbMenu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(721, 529)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 72)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "คำอธิบายหมวดสินค้า"
        '
        'cbMenu
        '
        Me.cbMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMenu.FormattingEnabled = True
        Me.cbMenu.Location = New System.Drawing.Point(70, 28)
        Me.cbMenu.Name = "cbMenu"
        Me.cbMenu.Size = New System.Drawing.Size(210, 28)
        Me.cbMenu.TabIndex = 7
        Me.cbMenu.Text = "เลือก"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "เลือกเมนู"
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAdd.Image = Global.PL.My.Resources.Resources.P_8
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(1013, 533)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(124, 57)
        Me.btAdd.TabIndex = 4
        Me.btAdd.Text = "บันทึก"
        Me.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'DGVSelect
        '
        Me.DGVSelect.AllowUserToAddRows = False
        Me.DGVSelect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSelect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdProduct, Me.cName, Me.cPrice, Me.cCount, Me.cFree, Me.cDel})
        Me.DGVSelect.Location = New System.Drawing.Point(721, 105)
        Me.DGVSelect.Name = "DGVSelect"
        Me.DGVSelect.ReadOnly = True
        Me.DGVSelect.RowHeadersVisible = False
        Me.DGVSelect.Size = New System.Drawing.Size(416, 418)
        Me.DGVSelect.TabIndex = 3
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.TabPage4)
        Me.Tab.Controls.Add(Me.TabPage1)
        Me.Tab.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(8, 76)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(711, 537)
        Me.Tab.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DGV)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(703, 504)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "เลือกรายากรสินค้า"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.c2, Me.c3, Me.c4, Me.cNum, Me.c5, Me.c6})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 3)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(697, 498)
        Me.DGV.TabIndex = 3
        '
        'c1
        '
        Me.c1.HeaderText = "รหัสสินค้า"
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        '
        'c2
        '
        Me.c2.HeaderText = "ชื่อสินค้า"
        Me.c2.Name = "c2"
        Me.c2.ReadOnly = True
        '
        'c3
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.c3.DefaultCellStyle = DataGridViewCellStyle3
        Me.c3.HeaderText = "สต๊อกสินค้า"
        Me.c3.Name = "c3"
        Me.c3.ReadOnly = True
        '
        'c4
        '
        Me.c4.HeaderText = "ยอดสั่งจอง"
        Me.c4.Name = "c4"
        Me.c4.ReadOnly = True
        '
        'cNum
        '
        Me.cNum.HeaderText = "จำนวนสินค้า"
        Me.cNum.Name = "cNum"
        Me.cNum.ReadOnly = True
        '
        'c5
        '
        DataGridViewCellStyle4.Format = "#,##0.00"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.c5.DefaultCellStyle = DataGridViewCellStyle4
        Me.c5.HeaderText = "฿ ราคาขาย"
        Me.c5.Name = "c5"
        Me.c5.ReadOnly = True
        '
        'c6
        '
        Me.c6.HeaderText = "เลือกสินค้า"
        Me.c6.Name = "c6"
        Me.c6.ReadOnly = True
        Me.c6.Text = "เลือกสินค้า "
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVPro)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(703, 504)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "ชุดโปรโมชั่น"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVPro
        '
        Me.DGVPro.AllowUserToAddRows = False
        Me.DGVPro.AllowUserToDeleteRows = False
        Me.DGVPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.c22, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.cNum1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewButtonColumn1})
        Me.DGVPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPro.Location = New System.Drawing.Point(3, 3)
        Me.DGVPro.Name = "DGVPro"
        Me.DGVPro.RowHeadersVisible = False
        Me.DGVPro.Size = New System.Drawing.Size(697, 498)
        Me.DGVPro.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "รหัสสินค้า"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'c22
        '
        Me.c22.HeaderText = "ชื่อสินค้า"
        Me.c22.Name = "c22"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "สต๊อก"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "สั่งจอง"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'cNum1
        '
        Me.cNum1.HeaderText = "จำนวน"
        Me.cNum1.Name = "cNum1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "฿ ราคา"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "เลือกสินค้า"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "เลือกสินค้า "
        '
        'cIdProduct
        '
        Me.cIdProduct.HeaderText = "รหัสสินค้า"
        Me.cIdProduct.Name = "cIdProduct"
        Me.cIdProduct.ReadOnly = True
        '
        'cName
        '
        Me.cName.HeaderText = "ชื่อสินค้า"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        '
        'cPrice
        '
        DataGridViewCellStyle1.Format = "#,##0.00"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.cPrice.HeaderText = "฿ ราคาขาย"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'cCount
        '
        Me.cCount.HeaderText = "จำนวน"
        Me.cCount.Name = "cCount"
        Me.cCount.ReadOnly = True
        '
        'cFree
        '
        Me.cFree.HeaderText = "ฟรี"
        Me.cFree.Name = "cFree"
        Me.cFree.ReadOnly = True
        Me.cFree.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cFree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cDel
        '
        Me.cDel.HeaderText = "เมนูลบ"
        Me.cDel.Name = "cDel"
        Me.cDel.ReadOnly = True
        '
        'Add_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 639)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Add_Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสินค้า"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGVPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tab As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV As DataGridView
    Friend WithEvents DGVPro As DataGridView
    Friend WithEvents DGVSelect As System.Windows.Forms.DataGridView
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNum1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbMenu As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents cNum As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents c6 As DataGridViewButtonColumn
    Friend WithEvents cIdProduct As DataGridViewTextBoxColumn
    Friend WithEvents cName As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
    Friend WithEvents cCount As DataGridViewTextBoxColumn
    Friend WithEvents cFree As DataGridViewCheckBoxColumn
    Friend WithEvents cDel As DataGridViewButtonColumn
End Class
