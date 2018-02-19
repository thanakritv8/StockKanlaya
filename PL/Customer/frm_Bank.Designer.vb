<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Bank
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cIdBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cBranch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbBank = New System.Windows.Forms.TextBox()
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbBranch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdBank, Me.cBank, Me.cNum, Me.cName, Me.cBranch})
        Me.DGV.Location = New System.Drawing.Point(35, 183)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersVisible = False
        Me.DGV.Size = New System.Drawing.Size(1178, 311)
        Me.DGV.TabIndex = 0
        '
        'cIdBank
        '
        Me.cIdBank.HeaderText = "รหัส"
        Me.cIdBank.Name = "cIdBank"
        Me.cIdBank.ReadOnly = True
        '
        'cBank
        '
        Me.cBank.HeaderText = "ธนาคาร"
        Me.cBank.Name = "cBank"
        Me.cBank.ReadOnly = True
        '
        'cNum
        '
        Me.cNum.HeaderText = "เลขที่บัญชี"
        Me.cNum.Name = "cNum"
        Me.cNum.ReadOnly = True
        '
        'cName
        '
        Me.cName.HeaderText = "ชื่อบัญชี"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        '
        'cBranch
        '
        Me.cBranch.HeaderText = "ชื่อสาขา"
        Me.cBranch.Name = "cBranch"
        Me.cBranch.ReadOnly = True
        '
        'tbBank
        '
        Me.tbBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbBank.Location = New System.Drawing.Point(89, 35)
        Me.tbBank.Name = "tbBank"
        Me.tbBank.Size = New System.Drawing.Size(255, 26)
        Me.tbBank.TabIndex = 1
        '
        'tbNum
        '
        Me.tbNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbNum.Location = New System.Drawing.Point(430, 29)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(287, 26)
        Me.tbNum.TabIndex = 2
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbName.Location = New System.Drawing.Point(89, 70)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(255, 26)
        Me.tbName.TabIndex = 3
        '
        'tbBranch
        '
        Me.tbBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbBranch.Location = New System.Drawing.Point(430, 64)
        Me.tbBranch.Name = "tbBranch"
        Me.tbBranch.Size = New System.Drawing.Size(195, 26)
        Me.tbBranch.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ธนาคาร :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "เลขบัญชี :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ชื่อบัญชี :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "สาขา :"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PL.My.Resources.Resources.Backgro
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1251, 633)
        Me.Panel1.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1227, 534)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1219, 500)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "เพิ่มบัญชีธนาคาร"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.tbBank)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btDel)
        Me.GroupBox1.Controls.Add(Me.tbBranch)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btEdit)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.tbNum)
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(782, 158)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "บัญชีธนาคาร"
        '
        'btDel
        '
        Me.btDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btDel.Image = Global.PL.My.Resources.Resources.ex_img_1
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(640, 106)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(77, 43)
        Me.btDel.TabIndex = 11
        Me.btDel.Text = "ลบ"
        Me.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btEdit.Image = Global.PL.My.Resources.Resources.Edit_img_3
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(532, 106)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(102, 43)
        Me.btEdit.TabIndex = 10
        Me.btEdit.Text = "แก้ไข"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAdd.Image = Global.PL.My.Resources.Resources.Add_img_2
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(439, 106)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(87, 43)
        Me.btAdd.TabIndex = 9
        Me.btAdd.Text = "เพิ่ม"
        Me.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'frm_Bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 633)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_Bank"
        Me.Text = "frm_Bank"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents cIdBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBranch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbBank As TextBox
    Friend WithEvents tbNum As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbBranch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
End Class
