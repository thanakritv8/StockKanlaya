<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_confirm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.cbBank = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbPath = New System.Windows.Forms.Label()
        Me.lbLesson = New System.Windows.Forms.Label()
        Me.btBrowse = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbRebate = New System.Windows.Forms.TextBox()
        Me.tbTransportPay = New System.Windows.Forms.TextBox()
        Me.tbTypePay = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbTransportPay = New System.Windows.Forms.ComboBox()
        Me.cbTypePay = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cMenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNameCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNameProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPriceUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cRebate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbCountry = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbZipCode = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btTax = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btOK = New System.Windows.Forms.Button()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DTP1)
        Me.Panel3.Controls.Add(Me.DTP2)
        Me.Panel3.Controls.Add(Me.cbBank)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lbPath)
        Me.Panel3.Controls.Add(Me.lbLesson)
        Me.Panel3.Controls.Add(Me.btBrowse)
        Me.Panel3.Controls.Add(Me.tbTotal)
        Me.Panel3.Controls.Add(Me.tbRebate)
        Me.Panel3.Controls.Add(Me.tbTransportPay)
        Me.Panel3.Controls.Add(Me.tbTypePay)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.cbTransportPay)
        Me.Panel3.Controls.Add(Me.cbTypePay)
        Me.Panel3.Location = New System.Drawing.Point(209, 416)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(629, 158)
        Me.Panel3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "เวลาจ่าย :"
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(97, 108)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(95, 20)
        Me.DTP1.TabIndex = 23
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "MM/dd/yyyy hh:mm:ss"
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP2.Location = New System.Drawing.Point(198, 108)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.ShowUpDown = True
        Me.DTP2.Size = New System.Drawing.Size(88, 20)
        Me.DTP2.TabIndex = 22
        '
        'cbBank
        '
        Me.cbBank.Enabled = False
        Me.cbBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbBank.FormattingEnabled = True
        Me.cbBank.Location = New System.Drawing.Point(97, 74)
        Me.cbBank.Name = "cbBank"
        Me.cbBank.Size = New System.Drawing.Size(189, 28)
        Me.cbBank.TabIndex = 21
        Me.cbBank.Text = "เลือก"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ธนาคาร :"
        '
        'lbPath
        '
        Me.lbPath.AutoSize = True
        Me.lbPath.Location = New System.Drawing.Point(87, 137)
        Me.lbPath.Name = "lbPath"
        Me.lbPath.Size = New System.Drawing.Size(36, 13)
        Me.lbPath.TabIndex = 12
        Me.lbPath.Text = "Empty"
        '
        'lbLesson
        '
        Me.lbLesson.AutoSize = True
        Me.lbLesson.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLesson.Location = New System.Drawing.Point(540, 12)
        Me.lbLesson.Name = "lbLesson"
        Me.lbLesson.Size = New System.Drawing.Size(76, 16)
        Me.lbLesson.TabIndex = 19
        Me.lbLesson.Text = "แบ่งจ่าย 2 งวด"
        Me.lbLesson.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbLesson.Visible = False
        '
        'btBrowse
        '
        Me.btBrowse.Location = New System.Drawing.Point(6, 132)
        Me.btBrowse.Name = "btBrowse"
        Me.btBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btBrowse.TabIndex = 11
        Me.btBrowse.Text = "Browse"
        Me.btBrowse.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(418, 105)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(99, 26)
        Me.tbTotal.TabIndex = 17
        Me.tbTotal.Text = "0"
        '
        'tbRebate
        '
        Me.tbRebate.Enabled = False
        Me.tbRebate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbRebate.Location = New System.Drawing.Point(418, 73)
        Me.tbRebate.Name = "tbRebate"
        Me.tbRebate.Size = New System.Drawing.Size(99, 26)
        Me.tbRebate.TabIndex = 16
        Me.tbRebate.Text = "0"
        '
        'tbTransportPay
        '
        Me.tbTransportPay.Enabled = False
        Me.tbTransportPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTransportPay.Location = New System.Drawing.Point(418, 41)
        Me.tbTransportPay.Name = "tbTransportPay"
        Me.tbTransportPay.Size = New System.Drawing.Size(99, 26)
        Me.tbTransportPay.TabIndex = 15
        Me.tbTransportPay.Text = "0"
        '
        'tbTypePay
        '
        Me.tbTypePay.Enabled = False
        Me.tbTypePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTypePay.Location = New System.Drawing.Point(418, 9)
        Me.tbTypePay.Name = "tbTypePay"
        Me.tbTypePay.Size = New System.Drawing.Size(99, 26)
        Me.tbTypePay.TabIndex = 14
        Me.tbTypePay.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(361, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "รวมสุทธิ :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(368, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "ส่วนลด :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(46, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "ขนส่ง :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(29, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 16)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "ชำระแบบ :"
        '
        'cbTransportPay
        '
        Me.cbTransportPay.Enabled = False
        Me.cbTransportPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTransportPay.FormattingEnabled = True
        Me.cbTransportPay.Items.AddRange(New Object() {"CNขนส่ง", "kerry 0-1 กก", "kerry 1-5 กก"})
        Me.cbTransportPay.Location = New System.Drawing.Point(97, 36)
        Me.cbTransportPay.Name = "cbTransportPay"
        Me.cbTransportPay.Size = New System.Drawing.Size(189, 28)
        Me.cbTransportPay.TabIndex = 2
        Me.cbTransportPay.Text = "เลือก"
        '
        'cbTypePay
        '
        Me.cbTypePay.Enabled = False
        Me.cbTypePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbTypePay.FormattingEnabled = True
        Me.cbTypePay.Items.AddRange(New Object() {"ชำระแบบเต็มจำนวน", "ชำระแบบแบ่งงวด"})
        Me.cbTypePay.Location = New System.Drawing.Point(97, 4)
        Me.cbTypePay.Name = "cbTypePay"
        Me.cbTypePay.Size = New System.Drawing.Size(189, 28)
        Me.cbTypePay.TabIndex = 1
        Me.cbTypePay.Text = "เลือก"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cMenu, Me.cNameCategory, Me.cIdProduct, Me.cNameProduct, Me.cAmount, Me.cUnit, Me.cPriceUnit, Me.cRebate, Me.cPrice})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGV.Location = New System.Drawing.Point(15, 86)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(823, 324)
        Me.DGV.TabIndex = 6
        '
        'cMenu
        '
        Me.cMenu.HeaderText = "รายการเมนู"
        Me.cMenu.Name = "cMenu"
        Me.cMenu.ReadOnly = True
        '
        'cNameCategory
        '
        Me.cNameCategory.HeaderText = "รายการสินค้า"
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
        Me.cNameProduct.HeaderText = "รายการสินค้าย่อย"
        Me.cNameProduct.Name = "cNameProduct"
        Me.cNameProduct.ReadOnly = True
        '
        'cAmount
        '
        Me.cAmount.HeaderText = "จำนวนสินค้า"
        Me.cAmount.Name = "cAmount"
        Me.cAmount.ReadOnly = True
        '
        'cUnit
        '
        Me.cUnit.HeaderText = "หน่วย"
        Me.cUnit.Name = "cUnit"
        Me.cUnit.ReadOnly = True
        '
        'cPriceUnit
        '
        Me.cPriceUnit.HeaderText = "ราคาต่อหน่วย"
        Me.cPriceUnit.Name = "cPriceUnit"
        Me.cPriceUnit.ReadOnly = True
        '
        'cRebate
        '
        Me.cRebate.HeaderText = "ส่วนลด"
        Me.cRebate.Name = "cRebate"
        Me.cRebate.ReadOnly = True
        '
        'cPrice
        '
        DataGridViewCellStyle8.Format = "#,##0.00"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.cPrice.DefaultCellStyle = DataGridViewCellStyle8
        Me.cPrice.HeaderText = "ราคา"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.tbCountry)
        Me.GroupBox4.Controls.Add(Me.tbName)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.tbAddress)
        Me.GroupBox4.Controls.Add(Me.tbZipCode)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.tbEmail)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.tbTel)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(849, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(348, 488)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "รายละเอียดการจัดส่ง"
        '
        'tbCountry
        '
        Me.tbCountry.Enabled = False
        Me.tbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbCountry.Location = New System.Drawing.Point(17, 318)
        Me.tbCountry.Name = "tbCountry"
        Me.tbCountry.Size = New System.Drawing.Size(155, 26)
        Me.tbCountry.TabIndex = 13
        '
        'tbName
        '
        Me.tbName.Enabled = False
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbName.Location = New System.Drawing.Point(16, 55)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(324, 26)
        Me.tbName.TabIndex = 12
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(12, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 18)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "ชื่อ-นามสกุล"
        '
        'tbAddress
        '
        Me.tbAddress.Enabled = False
        Me.tbAddress.Location = New System.Drawing.Point(16, 178)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(326, 104)
        Me.tbAddress.TabIndex = 7
        '
        'tbZipCode
        '
        Me.tbZipCode.Enabled = False
        Me.tbZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbZipCode.Location = New System.Drawing.Point(178, 318)
        Me.tbZipCode.Name = "tbZipCode"
        Me.tbZipCode.Size = New System.Drawing.Size(162, 26)
        Me.tbZipCode.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(12, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 18)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "เบอร์โทรศัพท์ "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(13, 354)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 18)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "อีเมล์ "
        '
        'tbEmail
        '
        Me.tbEmail.Enabled = False
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(16, 376)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(324, 26)
        Me.tbEmail.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(175, 297)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 18)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "รหัสไปษณีย์"
        '
        'tbTel
        '
        Me.tbTel.Enabled = False
        Me.tbTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbTel.Location = New System.Drawing.Point(17, 117)
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(323, 26)
        Me.tbTel.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(12, 155)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 18)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "ที่อยู่"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(12, 295)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 18)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "ประเทศ"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1182, 68)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายการสินค้าที่เลือก"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(371, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(488, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ตรวจสอบรายการสินค้าที่เลือกมา ก่อนจ่ายเงิน"
        '
        'btTax
        '
        Me.btTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btTax.ForeColor = System.Drawing.Color.Black
        Me.btTax.Image = Global.PL.My.Resources.Resources.Edit_img_3
        Me.btTax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTax.Location = New System.Drawing.Point(135, 587)
        Me.btTax.Name = "btTax"
        Me.btTax.Size = New System.Drawing.Size(152, 49)
        Me.btTax.TabIndex = 14
        Me.btTax.Text = "ใบกำกับภาษี"
        Me.btTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btTax.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.ForeColor = System.Drawing.Color.Black
        Me.btCancel.Image = Global.PL.My.Resources.Resources.remove_1
        Me.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCancel.Location = New System.Drawing.Point(293, 587)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(110, 49)
        Me.btCancel.TabIndex = 13
        Me.btCancel.Text = "ยกเลิก"
        Me.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btDel
        '
        Me.btDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.ForeColor = System.Drawing.Color.Black
        Me.btDel.Image = Global.PL.My.Resources.Resources.ex_img_1
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(1061, 587)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(131, 50)
        Me.btDel.TabIndex = 12
        Me.btDel.Text = "ลบข้อมูล"
        Me.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btOK
        '
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btOK.Image = Global.PL.My.Resources.Resources.P_11
        Me.btOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btOK.Location = New System.Drawing.Point(15, 586)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(114, 50)
        Me.btOK.TabIndex = 11
        Me.btOK.Text = "จ่ายแล้ว"
        Me.btOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btOK.UseVisualStyleBackColor = True
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.Color.Silver
        Me.Pic.Location = New System.Drawing.Point(15, 416)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(188, 158)
        Me.Pic.TabIndex = 10
        Me.Pic.TabStop = False
        '
        'frm_confirm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 649)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btTax)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.Name = "frm_confirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_confrim"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbLesson As System.Windows.Forms.Label
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbRebate As System.Windows.Forms.TextBox
    Friend WithEvents tbTransportPay As System.Windows.Forms.TextBox
    Friend WithEvents tbTypePay As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbTransportPay As System.Windows.Forms.ComboBox
    Friend WithEvents cbTypePay As System.Windows.Forms.ComboBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents lbPath As System.Windows.Forms.Label
    Friend WithEvents btBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents tbZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbTel As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents tbCountry As System.Windows.Forms.TextBox
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents btDel As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btTax As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cMenu As DataGridViewTextBoxColumn
    Friend WithEvents cNameCategory As DataGridViewTextBoxColumn
    Friend WithEvents cIdProduct As DataGridViewTextBoxColumn
    Friend WithEvents cNameProduct As DataGridViewTextBoxColumn
    Friend WithEvents cAmount As DataGridViewTextBoxColumn
    Friend WithEvents cUnit As DataGridViewTextBoxColumn
    Friend WithEvents cPriceUnit As DataGridViewTextBoxColumn
    Friend WithEvents cRebate As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
End Class
