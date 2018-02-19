<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSales_information
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.btEx = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cIdProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNameProduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1149, 542)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.DGV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1141, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูลรายการสินค้าที่ขาย"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btEx)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 99)
        Me.Panel1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTP2)
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 89)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาตาม วัน/เดือน/ปี"
        '
        'DTP1
        '
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(6, 43)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(146, 26)
        Me.DTP1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(158, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "To"
        '
        'DTP2
        '
        Me.DTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP2.Location = New System.Drawing.Point(191, 43)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(149, 26)
        Me.DTP2.TabIndex = 8
        '
        'btSearch
        '
        Me.btSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSearch.Image = Global.PL.My.Resources.Resources.S_3
        Me.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSearch.Location = New System.Drawing.Point(355, 28)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(111, 49)
        Me.btSearch.TabIndex = 9
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'btEx
        '
        Me.btEx.BackColor = System.Drawing.Color.Green
        Me.btEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEx.ForeColor = System.Drawing.Color.White
        Me.btEx.Image = Global.PL.My.Resources.Resources.clear_2
        Me.btEx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEx.Location = New System.Drawing.Point(985, 22)
        Me.btEx.Name = "btEx"
        Me.btEx.Size = New System.Drawing.Size(124, 54)
        Me.btEx.TabIndex = 10
        Me.btEx.Text = "Export"
        Me.btEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEx.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdProduct, Me.cNameProduct, Me.cStock, Me.cSell})
        Me.DGV.Location = New System.Drawing.Point(6, 118)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(1129, 389)
        Me.DGV.TabIndex = 9
        '
        'cIdProduct
        '
        Me.cIdProduct.HeaderText = "รหัสสินค้า"
        Me.cIdProduct.Name = "cIdProduct"
        Me.cIdProduct.ReadOnly = True
        '
        'cNameProduct
        '
        Me.cNameProduct.HeaderText = "ชื่อสินค้า"
        Me.cNameProduct.Name = "cNameProduct"
        Me.cNameProduct.ReadOnly = True
        '
        'cStock
        '
        Me.cStock.HeaderText = "จำนวนคงเหลือ"
        Me.cStock.Name = "cStock"
        Me.cStock.ReadOnly = True
        '
        'cSell
        '
        Me.cSell.HeaderText = "จำนวนที่ขาย"
        Me.cSell.Name = "cSell"
        Me.cSell.ReadOnly = True
        '
        'frmSales_information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1173, 633)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSales_information"
        Me.Text = "ข้อมูลการขายสินค้า"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cIdProduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNameProduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSell As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btEx As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
