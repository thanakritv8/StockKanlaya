Imports BLL
Public Class PL_Load

#Region "Simple"
    Public Sub Simple()
        ''############# Read and Write Excel #################################
        'Dim extra As BLL_Extra = New BLL_Extra
        'Dim Str As String = extra.ReadExcel("D:\Book1.xlsx", 1, 2, "Sheet1")
        'extra.WriteExcel("D:\Book1.xlsx", 1, 7, "Sheet1", "TEST1")
        'extra.WriteExcel("D:\Book1.xlsx", 2, 7, "Sheet1", "TEST2")
        ''####################################################################
    End Sub
#End Region

    Private Sub PL_Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BLL_Extra As BLL_Extra = New BLL_Extra
        BLL_Extra.ConfigDataBase(Application.StartupPath & "/Config.ini")
        Me.WindowState = FormWindowState.Maximized

        'FaTab.BackgroundImage = Image.FromFile(My.Application.Info.DirectoryPath & "\447_n.png")
        'FaTab.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub menuMain_DoubleClick(sender As Object, e As EventArgs) Handles menuMain.DoubleClick
        Try
            Dim Form_Name As String = menuMain.SelectedNode.Text
            Dim frm As Form = Nothing
            If Form_Name = "สินค้าที่จำหน่าย" Then
                frm = New frmSales_information
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "ข้อมูลการขายสินค้า " Then
                frm = New frmStore_statistic
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "รายงานการขาย " Then
                frm = New Sales_itemff
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "รายงานการตลาด" Then
                frm = New Marketing_report
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "รายงานประสิทธิภาพผู้ดูแล" Then
                frm = New Number_customers
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "เพิ่มข้อมูลลูกค้า" Then
                frm = New frmAdd_Customer
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "เพิ่มข้อมูลธนาคาร" Then
                frm = New frm_Bank
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "ประเภทลูกค้า" Then
                frm = New Add_customer_segment
                OpenForm(frm, Form_Name)
            ElseIf Form_Name = "Sell Product" Then
                frm = New Sell
                OpenForm(frm, Form_Name)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TreeView3_DoubleClick(sender As Object, e As EventArgs) Handles Main_warehouse.DoubleClick
        Dim Form_Name As String = Main_warehouse.SelectedNode.Text
        Dim frm As Form = Nothing
        If Form_Name = "เพิ่มสินค้า" Then
            frm = New Product
            OpenForm(frm, Form_Name)
        ElseIf Form_Name = "เพิ่มเมนู" Then
            frm = New frm_Menu
            OpenForm(frm, Form_Name)

        ElseIf Form_Name = "เพิ่มข้อมูลการชำระเงิน" Then
            frm = New Add_payment
            OpenForm(frm, Form_Name)

        ElseIf Form_Name = "เพิ่มข้อมูลการจัดส่ง" Then
            frm = New Add_shipping
            OpenForm(frm, Form_Name)

        ElseIf Form_Name = "เพิ่มส่วนลด" Then
            frm = New Add_discount
            OpenForm(frm, Form_Name)

        End If
    End Sub

    Private Sub OpenForm(ByVal formToOpen As Form, ByVal Headfrm As String)
        Try
            Dim myForm As New Form()
            Dim formIsOpenning As Boolean = False
            myForm = formToOpen

            If myForm IsNot Nothing Then
                Dim tabTmp As FarsiLibrary.Win.FATabStripItem = Nothing
                For Each tab As FarsiLibrary.Win.FATabStripItem In FaTab.Items
                    If tab.Name = Headfrm Then ' Check open form
                        FaTab.SelectedItem = tab
                        tabTmp = tab
                        formIsOpenning = True
                        Exit For
                    End If
                Next

                If formIsOpenning = True Then ' Focus form
                    FaTab.SelectedItem = tabTmp
                Else ' New form
                    tabTmp = New FarsiLibrary.Win.FATabStripItem()
                    myForm.TopLevel = False
                    myForm.FormBorderStyle = FormBorderStyle.None
                    myForm.Dock = DockStyle.Fill
                    myForm.Visible = True

                    Dim uc As New UserControl()
                    uc.Dock = DockStyle.Fill
                    uc.Controls.Add(myForm)

                    tabTmp.Controls.Add(uc)
                    tabTmp.CanClose = True
                    tabTmp.Title = Headfrm
                    tabTmp.Name = Headfrm
                    tabTmp.Dock = DockStyle.Fill
                    FaTab.AddTab(tabTmp)
                    FaTab.SelectedItem = tabTmp
                End If
            End If
        Catch generatedExceptionName As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_bill_Click(sender As Object, e As EventArgs) Handles btn_Createbill.Click
        Dim frm As Form = New frmCreate_bill
        OpenForm(frm, frm.Text)

    End Sub


    Private Sub Main_Order_DoubleClick(sender As Object, e As EventArgs) Handles Main_Order.DoubleClick
        Try
            Dim Form_Name As String = Main_Order.SelectedNode.Text
            Dim frm As Form = Nothing
            If Form_Name = "ช่องทางทั้งหมด" Then
                frm = New frm_Ways
                OpenForm(frm, Form_Name)
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class
