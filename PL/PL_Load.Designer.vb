<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PL_Load
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มสินค้า")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มเมนู")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดรายการสินค้า", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลการชำระเงิน")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลการจัดส่ง")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มส่วนลด")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ตั้งค่าแอดบิล", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สินค้าที่จำหน่าย")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลการขายสินค้า ")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลการขาย", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลลูกค้า")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลธนาคาร")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ประเภทลูกค้า")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ช่องทางทั้งหมด")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการออเดอร์ลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode15})
        Me.FaTab = New FarsiLibrary.Win.FATabStrip()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Main_warehouse = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.menuMain = New System.Windows.Forms.TreeView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Main_Order = New System.Windows.Forms.TreeView()
        Me.btn_Createbill = New System.Windows.Forms.Button()
        CType(Me.FaTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaTab
        '
        Me.FaTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaTab.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FaTab.Location = New System.Drawing.Point(190, 12)
        Me.FaTab.Name = "FaTab"
        Me.FaTab.Size = New System.Drawing.Size(905, 686)
        Me.FaTab.TabIndex = 1
        Me.FaTab.Text = "FaTabStrip1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Main_warehouse)
        Me.Panel3.Location = New System.Drawing.Point(3, 298)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(181, 206)
        Me.Panel3.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "คลังสินค้า"
        '
        'Main_warehouse
        '
        Me.Main_warehouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Main_warehouse.Location = New System.Drawing.Point(0, 34)
        Me.Main_warehouse.Name = "Main_warehouse"
        TreeNode1.Name = "Node2"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode1.Text = "เพิ่มสินค้า"
        TreeNode2.Name = "Node0"
        TreeNode2.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode2.Text = "เพิ่มเมนู"
        TreeNode3.Name = "Node0"
        TreeNode3.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode3.Text = "จัดรายการสินค้า"
        TreeNode4.Name = "Node1"
        TreeNode4.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode4.Text = "เพิ่มข้อมูลการชำระเงิน"
        TreeNode5.Name = "Node2"
        TreeNode5.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode5.Text = "เพิ่มข้อมูลการจัดส่ง"
        TreeNode6.Name = "Node3"
        TreeNode6.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode6.Text = "เพิ่มส่วนลด"
        TreeNode7.Name = "Node0"
        TreeNode7.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode7.Text = "ตั้งค่าแอดบิล"
        Me.Main_warehouse.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode7})
        Me.Main_warehouse.Size = New System.Drawing.Size(181, 162)
        Me.Main_warehouse.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.menuMain)
        Me.Panel1.Location = New System.Drawing.Point(3, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 206)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Dashboard"
        '
        'menuMain
        '
        Me.menuMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.menuMain.Location = New System.Drawing.Point(0, 31)
        Me.menuMain.Name = "menuMain"
        TreeNode8.Name = "Node1"
        TreeNode8.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode8.Text = "สินค้าที่จำหน่าย"
        TreeNode9.Name = "Node2"
        TreeNode9.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode9.Text = "ข้อมูลการขายสินค้า "
        TreeNode10.Name = "Node0"
        TreeNode10.Text = "รายงานข้อมูลการขาย"
        TreeNode11.Name = "Node6"
        TreeNode11.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode11.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode12.Name = "Node0"
        TreeNode12.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode12.Text = "เพิ่มข้อมูลธนาคาร"
        TreeNode13.Name = "Node5"
        TreeNode13.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode13.Text = "ประเภทลูกค้า"
        TreeNode14.Name = "Node1"
        TreeNode14.Text = "จัดการลูกค้า"
        Me.menuMain.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode14})
        Me.menuMain.Size = New System.Drawing.Size(181, 169)
        Me.menuMain.TabIndex = 7
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 711)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1096, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Main_Order)
        Me.Panel2.Location = New System.Drawing.Point(3, 510)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 119)
        Me.Panel2.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ช่องทางการติดตาม"
        '
        'Main_Order
        '
        Me.Main_Order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Main_Order.Location = New System.Drawing.Point(0, 34)
        Me.Main_Order.Name = "Main_Order"
        TreeNode15.Name = "Node2"
        TreeNode15.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        TreeNode15.Text = "ช่องทางทั้งหมด"
        TreeNode16.Name = "Node0"
        TreeNode16.Text = "จัดการออเดอร์ลูกค้า"
        Me.Main_Order.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.Main_Order.Size = New System.Drawing.Size(181, 79)
        Me.Main_Order.TabIndex = 7
        '
        'btn_Createbill
        '
        Me.btn_Createbill.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_Createbill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Createbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Createbill.ForeColor = System.Drawing.Color.White
        Me.btn_Createbill.Image = Global.PL.My.Resources.Resources.P_1
        Me.btn_Createbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Createbill.Location = New System.Drawing.Point(3, 12)
        Me.btn_Createbill.Name = "btn_Createbill"
        Me.btn_Createbill.Size = New System.Drawing.Size(181, 68)
        Me.btn_Createbill.TabIndex = 17
        Me.btn_Createbill.Text = "สร้างบิลใหม่"
        Me.btn_Createbill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Createbill.UseVisualStyleBackColor = False
        '
        'PL_Load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 733)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_Createbill)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FaTab)
        Me.Name = "PL_Load"
        Me.Text = "Kanlaya"
        CType(Me.FaTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FaTab As FarsiLibrary.Win.FATabStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Main_warehouse As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents menuMain As TreeView
    Friend WithEvents btn_Createbill As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Main_Order As TreeView
End Class
