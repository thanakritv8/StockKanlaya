<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdd_Customer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGVCus = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ordering_Officer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btDEx_CM = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btSEmp1 = New System.Windows.Forms.Button()
        Me.D11 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.D12 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.btn_AddCustomer = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGVOrder = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btEx_order = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btEmp2 = New System.Windows.Forms.Button()
        Me.D21 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.D22 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbs = New System.Windows.Forms.ComboBox()
        Me.lbs = New System.Windows.Forms.Label()
        Me.TabControl3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGVCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGVOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(16, 74)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1147, 541)
        Me.TabControl3.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGVCus)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1139, 512)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "ข้อมูลลูกค้า"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGVCus
        '
        Me.DGVCus.AllowUserToAddRows = False
        Me.DGVCus.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVCus.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Ordering_Officer, Me.Column1})
        Me.DGVCus.Location = New System.Drawing.Point(3, 112)
        Me.DGVCus.Name = "DGVCus"
        Me.DGVCus.ReadOnly = True
        Me.DGVCus.Size = New System.Drawing.Size(1129, 385)
        Me.DGVCus.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ลำดับที่"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ชื่อ-สกุล"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "ที่อยู่"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "จำนวนออเดอร์"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "ออเดอร์ ล่าสุด"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle2.Format = "#,##0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "เงินได้รวม"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Ordering_Officer
        '
        Me.Ordering_Officer.HeaderText = "วันที่พนักงานสั่งซื้อสินค้า"
        Me.Ordering_Officer.Name = "Ordering_Officer"
        Me.Ordering_Officer.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "แก้ไขข้อมูล"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Edit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btDEx_CM)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btn_AddCustomer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1133, 93)
        Me.Panel1.TabIndex = 44
        '
        'btDEx_CM
        '
        Me.btDEx_CM.BackColor = System.Drawing.Color.Green
        Me.btDEx_CM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btDEx_CM.ForeColor = System.Drawing.Color.White
        Me.btDEx_CM.Image = Global.PL.My.Resources.Resources.clear_2
        Me.btDEx_CM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDEx_CM.Location = New System.Drawing.Point(998, 24)
        Me.btDEx_CM.Name = "btDEx_CM"
        Me.btDEx_CM.Size = New System.Drawing.Size(117, 54)
        Me.btDEx_CM.TabIndex = 48
        Me.btDEx_CM.Text = "Export"
        Me.btDEx_CM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDEx_CM.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btSEmp1)
        Me.GroupBox6.Controls.Add(Me.D11)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.D12)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(204, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(464, 78)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ค้นหาจาก วัน/เดือน/ปี"
        '
        'btSEmp1
        '
        Me.btSEmp1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSEmp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSEmp1.Image = Global.PL.My.Resources.Resources.S_3
        Me.btSEmp1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSEmp1.Location = New System.Drawing.Point(336, 17)
        Me.btSEmp1.Name = "btSEmp1"
        Me.btSEmp1.Size = New System.Drawing.Size(116, 52)
        Me.btSEmp1.TabIndex = 11
        Me.btSEmp1.Text = "ค้นหา"
        Me.btSEmp1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSEmp1.UseVisualStyleBackColor = True
        '
        'D11
        '
        Me.D11.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D11.Location = New System.Drawing.Point(19, 34)
        Me.D11.Name = "D11"
        Me.D11.Size = New System.Drawing.Size(134, 24)
        Me.D11.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(159, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To"
        '
        'D12
        '
        Me.D12.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D12.Location = New System.Drawing.Point(194, 34)
        Me.D12.Name = "D12"
        Me.D12.Size = New System.Drawing.Size(134, 24)
        Me.D12.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSearch)
        Me.GroupBox1.Controls.Add(Me.lbSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(674, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 78)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาตามชื่อลูกค้า"
        '
        'cbSearch
        '
        Me.cbSearch.AllowDrop = True
        Me.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbSearch.FormattingEnabled = True
        Me.cbSearch.Location = New System.Drawing.Point(17, 30)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(193, 28)
        Me.cbSearch.Sorted = True
        Me.cbSearch.TabIndex = 45
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSearch.ForeColor = System.Drawing.Color.White
        Me.lbSearch.Location = New System.Drawing.Point(216, 35)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(86, 20)
        Me.lbSearch.TabIndex = 43
        Me.lbSearch.Text = "ค้นหาข้อมูล"
        '
        'btn_AddCustomer
        '
        Me.btn_AddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddCustomer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddCustomer.ForeColor = System.Drawing.Color.White
        Me.btn_AddCustomer.Image = Global.PL.My.Resources.Resources.P_4
        Me.btn_AddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_AddCustomer.Location = New System.Drawing.Point(19, 18)
        Me.btn_AddCustomer.Name = "btn_AddCustomer"
        Me.btn_AddCustomer.Size = New System.Drawing.Size(174, 63)
        Me.btn_AddCustomer.TabIndex = 5
        Me.btn_AddCustomer.Text = "เพิ่มข้อมูลลูกค้า"
        Me.btn_AddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AddCustomer.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGVOrder)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1139, 512)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "รายการออเดอร์"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGVOrder
        '
        Me.DGVOrder.AllowUserToAddRows = False
        Me.DGVOrder.AllowUserToDeleteRows = False
        Me.DGVOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.DGVOrder.Location = New System.Drawing.Point(3, 102)
        Me.DGVOrder.Name = "DGVOrder"
        Me.DGVOrder.ReadOnly = True
        Me.DGVOrder.Size = New System.Drawing.Size(1130, 404)
        Me.DGVOrder.TabIndex = 6
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "รหัสออเดอร์"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "วันที่สั่งซื้อ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "สถานะ"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "รวม"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btEx_order)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1133, 93)
        Me.Panel3.TabIndex = 1
        '
        'btEx_order
        '
        Me.btEx_order.BackColor = System.Drawing.Color.Green
        Me.btEx_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEx_order.ForeColor = System.Drawing.Color.White
        Me.btEx_order.Image = Global.PL.My.Resources.Resources.clear_2
        Me.btEx_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEx_order.Location = New System.Drawing.Point(988, 21)
        Me.btEx_order.Name = "btEx_order"
        Me.btEx_order.Size = New System.Drawing.Size(129, 54)
        Me.btEx_order.TabIndex = 51
        Me.btEx_order.Text = "Export"
        Me.btEx_order.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEx_order.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(19, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 70)
        Me.Panel2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 31)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ออเดอร์ลูกค้า"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btEmp2)
        Me.GroupBox2.Controls.Add(Me.D21)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.D22)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(191, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(466, 78)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาจาก วัน/เดือน/ปี"
        '
        'btEmp2
        '
        Me.btEmp2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEmp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEmp2.Image = Global.PL.My.Resources.Resources.S_3
        Me.btEmp2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEmp2.Location = New System.Drawing.Point(334, 16)
        Me.btEmp2.Name = "btEmp2"
        Me.btEmp2.Size = New System.Drawing.Size(126, 54)
        Me.btEmp2.TabIndex = 11
        Me.btEmp2.Text = "ค้นหา"
        Me.btEmp2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEmp2.UseVisualStyleBackColor = True
        '
        'D21
        '
        Me.D21.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D21.Location = New System.Drawing.Point(19, 34)
        Me.D21.Name = "D21"
        Me.D21.Size = New System.Drawing.Size(134, 24)
        Me.D21.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(159, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "To"
        '
        'D22
        '
        Me.D22.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D22.Location = New System.Drawing.Point(194, 34)
        Me.D22.Name = "D22"
        Me.D22.Size = New System.Drawing.Size(134, 24)
        Me.D22.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbs)
        Me.GroupBox3.Controls.Add(Me.lbs)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(670, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 78)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาตามชื่อลูกค้า"
        '
        'cbs
        '
        Me.cbs.AllowDrop = True
        Me.cbs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbs.FormattingEnabled = True
        Me.cbs.Location = New System.Drawing.Point(17, 30)
        Me.cbs.Name = "cbs"
        Me.cbs.Size = New System.Drawing.Size(188, 28)
        Me.cbs.Sorted = True
        Me.cbs.TabIndex = 45
        '
        'lbs
        '
        Me.lbs.AutoSize = True
        Me.lbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbs.ForeColor = System.Drawing.Color.White
        Me.lbs.Location = New System.Drawing.Point(211, 35)
        Me.lbs.Name = "lbs"
        Me.lbs.Size = New System.Drawing.Size(86, 20)
        Me.lbs.TabIndex = 43
        Me.lbs.Text = "ค้นหาข้อมูล"
        '
        'frmAdd_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 638)
        Me.Controls.Add(Me.TabControl3)
        Me.Name = "frmAdd_Customer"
        Me.Text = "List ข้อมูลลูกค้า"
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGVCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGVOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DGVCus As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbSearch As Label
    Friend WithEvents btn_AddCustomer As Button
    Friend WithEvents cbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGVOrder As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btSEmp1 As Button
    Friend WithEvents D11 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents D12 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btEmp2 As Button
    Friend WithEvents D21 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents D22 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btDEx_CM As Button
    Friend WithEvents btEx_order As Button
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Ordering_Officer As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbs As ComboBox
    Friend WithEvents lbs As Label
End Class
