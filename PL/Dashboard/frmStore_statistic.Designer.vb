<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStore_statistic
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbNum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DDGV = New System.Windows.Forms.DataGridView()
        Me.cOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCusType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCusAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDateOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTransport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btDEx = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DDTP1 = New System.Windows.Forms.DateTimePicker()
        Me.btD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DDTP2 = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GDTP2 = New System.Windows.Forms.DateTimePicker()
        Me.GDTP1 = New System.Windows.Forms.DateTimePicker()
        Me.btG = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.btGEx = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.GDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1145, 543)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1137, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รายงานการขายสินค้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Chart
        '
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartArea3.AxisX.Title = "วันที่"
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartArea3.AxisY.Title = "ราคา"
        ChartArea3.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart.Legends.Add(Legend3)
        Me.Chart.Location = New System.Drawing.Point(23, 230)
        Me.Chart.Name = "Chart"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.MarkerBorderWidth = 2
        Series3.MarkerColor = System.Drawing.Color.Blue
        Series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series3.Name = "ยอดขาย"
        Me.Chart.Series.Add(Series3)
        Me.Chart.Size = New System.Drawing.Size(1108, 270)
        Me.Chart.TabIndex = 7
        Me.Chart.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.DTP2)
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1125, 207)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(775, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 21)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "To"
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Image = Global.PL.My.Resources.Resources.S_3
        Me.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSearch.Location = New System.Drawing.Point(990, 12)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(114, 53)
        Me.btSearch.TabIndex = 6
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(604, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ยอดขายคิดจากวันที่ยืนยันการชำระเงิน (เปลี่ยน" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "สถานะบิลเป็นจ่ายแล้ว)"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(608, 99)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(29, 31)
        Me.lbTotal.TabIndex = 4
        Me.lbTotal.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(603, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ยอดการขายทั้งหมด"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbNum)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(17, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 99)
        Me.Panel1.TabIndex = 2
        '
        'lbNum
        '
        Me.lbNum.AutoSize = True
        Me.lbNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbNum.ForeColor = System.Drawing.Color.White
        Me.lbNum.Location = New System.Drawing.Point(60, 48)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(29, 31)
        Me.lbNum.TabIndex = 1
        Me.lbNum.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดการขาย"
        '
        'DTP2
        '
        Me.DTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(808, 26)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(165, 26)
        Me.DTP2.TabIndex = 1
        '
        'DTP1
        '
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(614, 26)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(154, 26)
        Me.DTP1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DDGV)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1137, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Export ยอดขาย"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DDGV
        '
        Me.DDGV.AllowUserToAddRows = False
        Me.DDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DDGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cOrder, Me.cCusType, Me.cCusName, Me.cCusAddress, Me.cProduct, Me.cPrice, Me.cTel, Me.cTime, Me.cBank, Me.cDateOrder, Me.cTransport})
        Me.DDGV.Location = New System.Drawing.Point(3, 112)
        Me.DDGV.Name = "DDGV"
        Me.DDGV.ReadOnly = True
        Me.DDGV.RowHeadersVisible = False
        Me.DDGV.Size = New System.Drawing.Size(1128, 399)
        Me.DDGV.TabIndex = 1
        '
        'cOrder
        '
        Me.cOrder.HeaderText = "เลขที่บิล"
        Me.cOrder.Name = "cOrder"
        Me.cOrder.ReadOnly = True
        '
        'cCusType
        '
        Me.cCusType.HeaderText = "ประเภทลูกค้า"
        Me.cCusType.Name = "cCusType"
        Me.cCusType.ReadOnly = True
        '
        'cCusName
        '
        Me.cCusName.HeaderText = "ชื่อลูกค้า"
        Me.cCusName.Name = "cCusName"
        Me.cCusName.ReadOnly = True
        '
        'cCusAddress
        '
        Me.cCusAddress.HeaderText = "ที่อยู่ลูกค้า"
        Me.cCusAddress.Name = "cCusAddress"
        Me.cCusAddress.ReadOnly = True
        '
        'cProduct
        '
        Me.cProduct.HeaderText = "รายการสินค้า"
        Me.cProduct.Name = "cProduct"
        Me.cProduct.ReadOnly = True
        '
        'cPrice
        '
        Me.cPrice.HeaderText = "ราคา"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'cTel
        '
        Me.cTel.HeaderText = "เบอร์โทรลูกค้า"
        Me.cTel.Name = "cTel"
        Me.cTel.ReadOnly = True
        '
        'cTime
        '
        Me.cTime.HeaderText = "เวลาโอนเงิน"
        Me.cTime.Name = "cTime"
        Me.cTime.ReadOnly = True
        '
        'cBank
        '
        Me.cBank.HeaderText = "ธนาคาร"
        Me.cBank.Name = "cBank"
        Me.cBank.ReadOnly = True
        '
        'cDateOrder
        '
        Me.cDateOrder.HeaderText = "วันที่สั่งสินค้า"
        Me.cDateOrder.Name = "cDateOrder"
        Me.cDateOrder.ReadOnly = True
        '
        'cTransport
        '
        Me.cTransport.HeaderText = "ข้อมูลการส่งสินค้า"
        Me.cTransport.Name = "cTransport"
        Me.cTransport.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btDEx)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1131, 103)
        Me.Panel2.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(955, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 55)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "|"
        '
        'btDEx
        '
        Me.btDEx.BackColor = System.Drawing.Color.Green
        Me.btDEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btDEx.ForeColor = System.Drawing.Color.White
        Me.btDEx.Image = Global.PL.My.Resources.Resources.clear_2
        Me.btDEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDEx.Location = New System.Drawing.Point(992, 25)
        Me.btDEx.Name = "btDEx"
        Me.btDEx.Size = New System.Drawing.Size(124, 54)
        Me.btDEx.TabIndex = 11
        Me.btDEx.Text = "Export"
        Me.btDEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDEx.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DDTP1)
        Me.GroupBox3.Controls.Add(Me.btD)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DDTP2)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 84)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาตาม วัน/เดือน/ปี"
        '
        'DDTP1
        '
        Me.DDTP1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DDTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DDTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDTP1.Location = New System.Drawing.Point(14, 39)
        Me.DDTP1.Name = "DDTP1"
        Me.DDTP1.Size = New System.Drawing.Size(172, 26)
        Me.DDTP1.TabIndex = 0
        '
        'btD
        '
        Me.btD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btD.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btD.Image = Global.PL.My.Resources.Resources.S_3
        Me.btD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btD.Location = New System.Drawing.Point(426, 18)
        Me.btD.Name = "btD"
        Me.btD.Size = New System.Drawing.Size(125, 56)
        Me.btD.TabIndex = 14
        Me.btD.Text = "ค้นหา"
        Me.btD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btD.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(192, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "To"
        '
        'DDTP2
        '
        Me.DDTP2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DDTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DDTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DDTP2.Location = New System.Drawing.Point(237, 39)
        Me.DDTP2.Name = "DDTP2"
        Me.DDTP2.Size = New System.Drawing.Size(172, 26)
        Me.DDTP2.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GDGV)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1137, 510)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ยอดขายตามกลุ่มลูกค้า"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GDGV
        '
        Me.GDGV.AllowUserToAddRows = False
        Me.GDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.GDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GDGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.DataGridViewTextBoxColumn1, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column3, Me.Column8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column12})
        Me.GDGV.Location = New System.Drawing.Point(6, 119)
        Me.GDGV.Name = "GDGV"
        Me.GDGV.ReadOnly = True
        Me.GDGV.RowHeadersVisible = False
        Me.GDGV.Size = New System.Drawing.Size(1128, 389)
        Me.GDGV.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "วันที่ทำรายการ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อ-นามสกุลลูกค้า"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ประเภทกลุ่มลูกค้า"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "ที่อยู่ลูกค้า"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "เบอร์โทรศัพท์"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "เลขที่ใบเสร็จ"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "ธนาคาร"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "เวลาโอนเงิน"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "วันที่สั่งสินค้า"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "รายการสินค้า"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "จำนวนสินค้า"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "จำนวนเงิน"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.btGEx)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1131, 102)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GDTP2)
        Me.GroupBox4.Controls.Add(Me.GDTP1)
        Me.GroupBox4.Controls.Add(Me.btG)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(439, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(528, 84)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ค้นหาตาม วัน/เดือน/ปี"
        '
        'GDTP2
        '
        Me.GDTP2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GDTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GDTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GDTP2.Location = New System.Drawing.Point(234, 36)
        Me.GDTP2.Name = "GDTP2"
        Me.GDTP2.Size = New System.Drawing.Size(147, 26)
        Me.GDTP2.TabIndex = 13
        '
        'GDTP1
        '
        Me.GDTP1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GDTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GDTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GDTP1.Location = New System.Drawing.Point(37, 37)
        Me.GDTP1.Name = "GDTP1"
        Me.GDTP1.Size = New System.Drawing.Size(149, 26)
        Me.GDTP1.TabIndex = 0
        '
        'btG
        '
        Me.btG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btG.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btG.Image = Global.PL.My.Resources.Resources.S_3
        Me.btG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btG.Location = New System.Drawing.Point(397, 18)
        Me.btG.Name = "btG"
        Me.btG.Size = New System.Drawing.Size(119, 53)
        Me.btG.TabIndex = 14
        Me.btG.Text = "ค้นหา"
        Me.btG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btG.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(193, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "To"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbGroup)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 87)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ค้นหาตามประเภทลูกค้า"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(264, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ประเภทลูกค้า"
        '
        'cbGroup
        '
        Me.cbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Location = New System.Drawing.Point(6, 38)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(252, 28)
        Me.cbGroup.TabIndex = 15
        Me.cbGroup.Text = "เลือก"
        '
        'btGEx
        '
        Me.btGEx.BackColor = System.Drawing.Color.Green
        Me.btGEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btGEx.ForeColor = System.Drawing.Color.White
        Me.btGEx.Image = Global.PL.My.Resources.Resources.clear_2
        Me.btGEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGEx.Location = New System.Drawing.Point(994, 26)
        Me.btGEx.Name = "btGEx"
        Me.btGEx.Size = New System.Drawing.Size(115, 54)
        Me.btGEx.TabIndex = 11
        Me.btGEx.Text = "Export"
        Me.btGEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGEx.UseVisualStyleBackColor = False
        '
        'frmStore_statistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1169, 639)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmStore_statistic"
        Me.Text = "รายงานการขายสินค้า"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP2 As DateTimePicker
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DDGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DDTP1 As DateTimePicker
    Friend WithEvents btDEx As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DDTP2 As DateTimePicker
    Friend WithEvents btD As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GDGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btG As Button
    Friend WithEvents GDTP2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btGEx As Button
    Friend WithEvents GDTP1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cbGroup As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCusType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCusName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCusAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDateOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTransport As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
