<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_payment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.txt_detaill = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.tbListData = New System.Windows.Forms.ComboBox()
        Me.btDel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cIdBill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cListData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 638)
        Me.Panel1.TabIndex = 68
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1122, 531)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DGV)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1114, 497)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มข้อมูลการชำระเงิน"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btEdit)
        Me.GroupBox1.Controls.Add(Me.txt_detaill)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.tbListData)
        Me.GroupBox1.Controls.Add(Me.btDel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(71, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 202)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ช่องทางการชำระเงินในแบบต่างๆ"
        '
        'btEdit
        '
        Me.btEdit.Image = Global.PL.My.Resources.Resources.Edit_img_3
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(497, 147)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(94, 45)
        Me.btEdit.TabIndex = 73
        Me.btEdit.Text = "แก้ไข"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'txt_detaill
        '
        Me.txt_detaill.Location = New System.Drawing.Point(161, 82)
        Me.txt_detaill.Multiline = True
        Me.txt_detaill.Name = "txt_detaill"
        Me.txt_detaill.Size = New System.Drawing.Size(324, 110)
        Me.txt_detaill.TabIndex = 75
        '
        'btAdd
        '
        Me.btAdd.Image = Global.PL.My.Resources.Resources.Add_img_2
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(497, 96)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(95, 45)
        Me.btAdd.TabIndex = 69
        Me.btAdd.Text = "เพิ่ม"
        Me.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'tbListData
        '
        Me.tbListData.AllowDrop = True
        Me.tbListData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.tbListData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbListData.FormattingEnabled = True
        Me.tbListData.Location = New System.Drawing.Point(161, 46)
        Me.tbListData.Name = "tbListData"
        Me.tbListData.Size = New System.Drawing.Size(324, 28)
        Me.tbListData.Sorted = True
        Me.tbListData.TabIndex = 68
        '
        'btDel
        '
        Me.btDel.Image = Global.PL.My.Resources.Resources.ex_img_1
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(597, 147)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(87, 45)
        Me.btDel.TabIndex = 74
        Me.btDel.Text = "ลบ"
        Me.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "ช่องทางชำระเงิน :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "รายละเอียด :"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdBill, Me.cListData, Me.cDetail})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Location = New System.Drawing.Point(71, 230)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(1037, 261)
        Me.DGV.TabIndex = 67
        '
        'cIdBill
        '
        Me.cIdBill.HeaderText = "รหัส"
        Me.cIdBill.Name = "cIdBill"
        Me.cIdBill.ReadOnly = True
        '
        'cListData
        '
        Me.cListData.HeaderText = "ช่องทางการชำระเงิน"
        Me.cListData.Name = "cListData"
        Me.cListData.ReadOnly = True
        '
        'cDetail
        '
        Me.cDetail.HeaderText = "รายละเอียด"
        Me.cDetail.Name = "cDetail"
        Me.cDetail.ReadOnly = True
        '
        'Add_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 638)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Add_payment"
        Me.Text = "Add_payment"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tbListData As ComboBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btDel As System.Windows.Forms.Button
    Friend WithEvents cIdBill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cListData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_detaill As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
