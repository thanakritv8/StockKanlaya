Imports BLL
Public Class frmCreate_bill
    Dim IdCus As String = String.Empty
    Dim IdOrderBill As String = String.Empty
    Private Sub btn_savebill_Click(sender As Object, e As EventArgs) Handles btn_savebill.Click
        Try
            'Bill_records.Show()
            Dim StatusOrder As Boolean = False
            Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
            Dim DtCusData As DataTable = BLL_Bill.SelectCustomer(cbName.Text)
            If DtCusData.Rows.Count = 0 Then
                If MsgBox("ยังไม่มีลูกค้าคนนี้คุณต้องการเพิ่มลูกค้าใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    If Not String.IsNullOrEmpty(cbName.Text) And Not String.IsNullOrEmpty(tbAddress.Text) And
                        Not String.IsNullOrEmpty(tbTel.Text) And Not String.IsNullOrEmpty(cbCountry.Text) And Not String.IsNullOrEmpty(tbZipCode.Text) Then
                        Dim BLL_Customer As BLL_Customer = New BLL_Customer
                        Dim BLL_Extra As BLL_Extra = New BLL_Extra
                        Dim DtCus As DataTable = BLL_Customer.SelectCustomer(cbName.Text)
                        If BLL_Customer.InsertCustomer(cbName.Text, tbAddress.Text, tbAddress.Text, tbTel.Text, cbCountry.Text, tbZipCode.Text, tbEmail.Text, "", cbGroup.Text) Then
                            MsgBox("ข้อมูลลูกค้าถูกบันทึกแล้ว", MsgBoxStyle.Information, "Information")

                            DtCusData = BLL_Bill.SelectCustomer(cbName.Text)
                            If DtCusData.Rows.Count > 0 Then
                                IdCus = DtCusData.Rows(0).Item("IdCustomer").ToString
                                StatusOrder = True
                            End If
                        End If
                    Else
                        MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน", MsgBoxStyle.Exclamation, "Exclamation")
                    End If
                End If
            Else
                StatusOrder = True
            End If

            If Not String.IsNullOrEmpty(cbName.Text) And DGV.Rows.Count > 0 And Not String.IsNullOrEmpty(tbAddress.Text) And StatusOrder Then
                If MsgBox("คุณต้องการสั่งจองใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim InsertStatus As Boolean = True
                    If BLL_Bill.InsertOrder(IdOrderBill, "สั่งจอง", cbTypePay.Text, tbTransportPay.Text, cbTransportPay.Text, tbRebate.Text, tbTotal.Text, tbAddress.Text, cbCountry.Text, tbZipCode.Text, IdCus) Then
                        For i As Integer = 0 To DGV.Rows.Count - 1
                            If BLL_Bill.InsertListOrder(IdOrderBill, DGV.Rows(i).Cells("cIdProduct").Value, DGV.Rows(i).Cells("cAmount").Value, DGV.Rows(i).Cells("cPrice").Value, DGV.Rows(i).Cells("cMenu").Value, DGV.Rows(i).Cells("cFree").Value) = False Then
                                InsertStatus = False
                                Exit For
                            End If
                        Next
                    Else
                        InsertStatus = False
                    End If
                    If InsertStatus Then
                        If cbTypePay.Text = "ชำระแบบแบ่งงวด" Then
                            Dim DGVLesson As DataGridView = BLL_Bill.GetDGVLesson
                            If BLL_Bill.InsertLesson(IdOrderBill, DGVLesson) Then
                                MsgBox("สั่งจองสำเร็จ", MsgBoxStyle.Information, "Information")
                                ClearData()
                            Else
                                MsgBox("กรุณาเช็คข้อมูลก่อนบันทึก", MsgBoxStyle.Information, "Information")
                            End If
                        Else
                            MsgBox("สั่งจองสำเร็จ", MsgBoxStyle.Information, "Information")
                            ClearData()
                        End If
                    End If
                End If
            Else
                If StatusOrder Then
                    MsgBox("กรุณาเช็คข้อมูลก่อนบันทึก", MsgBoxStyle.Information, "Information")
                Else
                    MsgBox("กรุณาเช็คการกรอกข้อมูลลูกค้า", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception
            Dim BLL_Err As BLL_Extra = New BLL_Extra
            BLL_Err.InsertLog("Function btn_savebill_Click :" & ex.Message)
        End Try

    End Sub

    Private Sub btn_Addproduct_Click(sender As Object, e As EventArgs) Handles btn_Addproduct.Click
        Try
            Dim frm As Add_Product = New Add_Product
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                frmCreate_bill_Load(sender, e)
            End If
        Catch ex As Exception
            Dim BLL_Err As BLL_Extra = New BLL_Extra
            BLL_Err.InsertLog("Function btn_Addproduct_Click :" & ex.Message)
        End Try

    End Sub

    Private Sub frmCreate_bill_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
            Dim Dt As DataTable = BLL_Bill.ReProduct
            If Not IsNothing(Dt) Then
                Dim Total As Integer = IIf(String.IsNullOrEmpty(tbTypePay.Text), 0, CInt(tbTypePay.Text))
                Dim Rebate As Integer = IIf(String.IsNullOrEmpty(tbRebate.Text), 0, CInt(tbRebate.Text))
                Dim _Query = (From row In Dt.AsEnumerable _
                              Where row.Field(Of String)("Free") = "NoFree"
                             Select row.Field(Of String)("IdProduct")).Distinct.ToList
                For Each _Item In _Query
                    Dim IdCategory As String = BLL_Bill.SearchIdCategory(_Item)
                    Dim NameCategory As String = BLL_Bill.SearchNameCategory(IdCategory)

                    Dim Price = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item And _num.Field(Of String)("Free") = "NoFree"
                             Select _num.Field(Of Integer)("Price")).Sum
                    Total += Price
                    Dim Num = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item And _num.Field(Of String)("Free") = "NoFree"
                             Select _num.Field(Of Integer)("Num")).Sum
                    Dim Name = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item
                             Select _num.Field(Of String)("NameProduct")).FirstOrDefault

                    Dim NameMenu = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item
                             Select _num.Field(Of String)("NameMenu")).FirstOrDefault
                    DGV.Rows.Add(NameMenu, NameCategory, _Item, Name, Num, Price, "No", "ลบ")
                Next

                Dim _QueryFree = (From row In Dt.AsEnumerable _
                              Where row.Field(Of String)("Free") = "Free"
                             Select row.Field(Of String)("IdProduct")).Distinct.ToList
                For Each _Item In _QueryFree
                    Dim IdCategory As String = BLL_Bill.SearchIdCategory(_Item)
                    Dim NameCategory As String = BLL_Bill.SearchNameCategory(IdCategory)

                    Dim Price = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item And _num.Field(Of String)("Free") = "Free"
                             Select _num.Field(Of Integer)("Price")).Sum
                    Total += Price
                    Rebate += Price
                    Dim Num = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item And _num.Field(Of String)("Free") = "Free"
                             Select _num.Field(Of Integer)("Num")).Sum
                    Dim Name = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item
                             Select _num.Field(Of String)("NameProduct")).FirstOrDefault

                    Dim NameMenu = (From _num In Dt.AsEnumerable _
                               Where _num.Field(Of String)("IdProduct") = _Item
                             Select _num.Field(Of String)("NameMenu")).FirstOrDefault
                    DGV.Rows.Add(NameMenu, NameCategory, _Item, Name, Num, Price, "YES", "ลบ")
                Next

                tbTypePay.Text = Total
                tbTotal.Text = Total
                If cbRebate.Text.Contains("%") Then
                    Rebate = (Rebate * 100) / Total
                End If
                tbRebate.Text = Rebate
                cbName.Items.Clear()
                Dim BLL_Customer As BLL_Customer = New BLL_Customer
                Dim DtCus As DataTable = BLL_Customer.SelectCustomer("ALL")
                For i As Integer = 0 To DtCus.Rows.Count - 1
                    cbName.Items.Add(DtCus.Rows(i).Item("Name").ToString)
                Next
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim r As New Random
                IdOrderBill = BLL_Extra.RandomString(r)

            End If
            cbTypePay.Items.Clear()
            cbTransportPay.Items.Clear()
            cbRebate.Items.Clear()
            Dim BLL_Add_Bill As BLL_BIll = New BLL_BIll
            Dim DtBill As DataTable = BLL_Add_Bill.SelectListBill("ข้อมูลการชำระเงิน")
            For i As Integer = 0 To DtBill.Rows.Count - 1
                cbTypePay.Items.Add(DtBill.Rows(i).Item("ListData"))
            Next
            cbTypePay.SelectedIndex = 0
            DtBill = BLL_Add_Bill.SelectListBill("ข้อมูลการขนส่ง")
            For i As Integer = 0 To DtBill.Rows.Count - 1
                cbTransportPay.Items.Add(DtBill.Rows(i).Item("ListData"))
            Next
            cbTransportPay.SelectedIndex = 0
            DtBill = BLL_Add_Bill.SelectListBill("ข้อมูลส่วนลด")
            For i As Integer = 0 To DtBill.Rows.Count - 1
                cbRebate.Items.Add(DtBill.Rows(i).Item("ListData"))
            Next
            cbRebate.SelectedIndex = 0
            CHeaders()
            DSize()
        Catch ex As Exception
            Dim BLL_Err As BLL_Extra = New BLL_Extra
            BLL_Err.InsertLog("Function frmCreate_bill_Load :" & ex.Message)
        End Try

    End Sub

    Private Sub cbName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbName.SelectedIndexChanged
        Try
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            Dim DtCus As DataTable = BLL_Customer.SelectCustomer(cbName.Text)
            If DtCus.Rows.Count > 0 Then
                With DtCus.Rows(0)
                    tbTel.Text = IIf(IsDBNull(.Item("Tel")), String.Empty, .Item("Tel").ToString)
                    tbAddress.Text = IIf(IsDBNull(.Item("Address")), String.Empty, .Item("Address").ToString)
                    cbCountry.Text = IIf(IsDBNull(.Item("Country")), String.Empty, .Item("Country").ToString)
                    tbZipCode.Text = IIf(IsDBNull(.Item("Zipcode")), String.Empty, .Item("Zipcode").ToString)
                    tbEmail.Text = IIf(IsDBNull(.Item("Email")), String.Empty, .Item("Email").ToString)
                    IdCus = IIf(IsDBNull(.Item("IdCustomer")), String.Empty, .Item("IdCustomer").ToString)
                    cbGroup.Text = IIf(IsDBNull(.Item("GroupCus")), String.Empty, .Item("GroupCus").ToString)
                    cbGroup.Enabled = False
                End With
            Else
                cbGroup.Enabled = True
            End If
        Catch ex As Exception
            Dim BLL_Err As BLL_Extra = New BLL_Extra
            BLL_Err.InsertLog("Function cbName_SelectedIndexChanged :" & ex.Message)
        End Try

    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        ClearData()
    End Sub

    Public Sub ClearData()
        DGV.Rows.Clear()
        cbName.Text = String.Empty
        tbTel.Text = String.Empty
        tbAddress.Text = String.Empty
        cbCountry.Text = "ไทย"
        tbZipCode.Text = String.Empty
        tbEmail.Text = String.Empty
        tbTypePay.Text = 0
        tbTransportPay.Text = 0
        tbRebate.Text = 0
        tbTotal.Text = 0
        Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
        BLL_Bill.Product(New DataTable)
    End Sub

    Private Sub cbTypePay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTypePay.SelectedIndexChanged
        Try
            If cbTypePay.Text = "ชำระแบบแบ่งงวด" And tbTypePay.Text <> 0 Then
                Dim frm As frm_lesson = New frm_lesson
                frm.IdBill = IdOrderBill
                frm.Price = tbTotal.Text
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
                    Dim DGVLesson As DataGridView = BLL_Bill.GetDGVLesson
                    lbLesson.Text = "แบ่งจ่าย " & DGVLesson.Rows.Count & " งวด"
                    lbLesson.Visible = True
                End If
            Else
                lbLesson.Visible = False
            End If
        Catch ex As Exception
            Dim BLL_Err As BLL_Extra = New BLL_Extra
            BLL_Err.InsertLog("Function cbTypePay_SelectedIndexChanged :" & ex.Message)
        End Try

    End Sub

    Private Sub tbTransportPay_TextChanged(sender As Object, e As EventArgs) Handles tbTransportPay.TextChanged
        Try
            If tbRebate.Text <> String.Empty And tbTypePay.Text <> String.Empty And tbTransportPay.Text <> String.Empty Then
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                If Not BLL_Extra.CheckNum(tbTransportPay.Text) Then
                    MsgBox("กรุณาใส่ตัวเลข", MsgBoxStyle.Exclamation, "Exclamation")
                Else
                    'tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - CInt(tbRebate.Text)
                    If cbRebate.Text.Contains("%") Then
                        tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - (CInt(tbRebate.Text) * CInt(tbTypePay.Text) / 100)
                    Else
                        tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - CInt(tbRebate.Text)
                    End If
                End If
            End If
        Catch ex As Exception
            Dim BLL_Err As BLL_Extra = New BLL_Extra
            BLL_Err.InsertLog("Function tbTransportPay_TextChanged :" & ex.Message)
        End Try
    End Sub

    Private Sub tbRebate_TextChanged(sender As Object, e As EventArgs) Handles tbRebate.TextChanged
        Try
            If tbRebate.Text <> String.Empty And tbTypePay.Text <> String.Empty And tbTransportPay.Text <> String.Empty Then
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                If Not BLL_Extra.CheckNum(tbRebate.Text) Then
                    MsgBox("กรุณาใส่ตัวเลข", MsgBoxStyle.Exclamation, "Exclamation")
                Else

                    If cbRebate.Text.Contains("%") Then
                        tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - (CInt(tbRebate.Text) * CInt(tbTypePay.Text) / 100)
                    Else
                        tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - CInt(tbRebate.Text)
                    End If

                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                DGV.Rows.RemoveAt(e.RowIndex)
                Dim sum As Double = 0.0
                For i As Integer = 0 To DGV.Rows.Count - 1
                    sum += DGV.Rows(i).Cells("cPrice").Value
                Next
                tbTypePay.Text = sum
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbTypePay_TextChanged(sender As Object, e As EventArgs) Handles tbTypePay.TextChanged
        Try
            If tbRebate.Text <> String.Empty And tbTypePay.Text <> String.Empty And tbTransportPay.Text <> String.Empty Then
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                If Not BLL_Extra.CheckNum(tbRebate.Text) Then
                    MsgBox("กรุณาใส่ตัวเลข", MsgBoxStyle.Exclamation, "Exclamation")
                Else
                    'If cbRebate.Text.Contains("%") Then
                    '    tbRebate.Text = (tbRebate.Text * tbTypePay.Text) / 100
                    'End If
                    'tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - CInt(tbRebate.Text)
                    If cbRebate.Text.Contains("%") Then
                        tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - (CInt(tbRebate.Text) * CInt(tbTypePay.Text) / 100)
                    Else
                        tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - CInt(tbRebate.Text)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbRebate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRebate.SelectedIndexChanged
        Try
            If cbRebate.Text.Contains("%") Then
                tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - (CInt(tbRebate.Text) * CInt(tbTypePay.Text) / 100)
            Else
                tbTotal.Text = CInt(tbTypePay.Text) + CInt(tbTransportPay.Text) - CInt(tbRebate.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbName_TextChanged(sender As Object, e As EventArgs) Handles cbName.TextChanged
        cbGroup.Enabled = True
        Dim BLL_Bill As BLL_BIll = New BLL_BIll
        Dim DtBill As DataTable = BLL_Bill.SelectListBill("ประเภทลูกค้า")
        cbGroup.Items.Clear()
        For i As Integer = 0 To DtBill.Rows.Count - 1
            cbGroup.Items.Add(DtBill.Rows(i)("ListData").ToString)
        Next

    End Sub

    Private Sub CHeaders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize()
        DGV.Columns("cMenu").Width = 20
        DGV.Columns("cNameCategory").Width = 30
        DGV.Columns("cIdProduct").Width = 19
        DGV.Columns("cNameProduct").Width = 60
        DGV.Columns("cAmount").Width = 10
        DGV.Columns("cPrice").Width = 15
        DGV.Columns("cFree").Width = 8
        DGV.Columns("cDel").Width = 60
    End Sub

End Class