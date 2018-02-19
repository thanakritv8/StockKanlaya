Imports BLL
Public Class Add_shipping

    Dim IdBill As Integer

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Try
            If tbListData.Text <> String.Empty And txt_detaill.Text <> String.Empty Then
                If MsgBox("ต้องการบันทึกข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Bill As BLL_BIll = New BLL_BIll
                    If BLL_Bill.InsertListBill(tbListData.Text, txt_detaill.Text, "ข้อมูลการขนส่ง") Then
                        MsgBox("บันทึกข้อมูลสำเร็จ", MsgBoxStyle.Information, "Information")
                        Clear()
                        Add_shipping_Load(sender, e)
                    Else
                        MsgBox("บันทึกข้อมูลไม่สำเร็จ", MsgBoxStyle.Information, "Information")
                    End If
                End If
            Else
                MsgBox("กรุณาเช็คข้อมุล", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Add_shipping_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV.Columns(0).Visible = False
        Try
            IdBill = 0
            btEdit.Enabled = False
            btDel.Enabled = False
            btAdd.Enabled = True
            Dim BLL_Bill As BLL_BIll = New BLL_BIll
            Dim Dt As DataTable = BLL_Bill.SelectListBill("ข้อมูลการขนส่ง")
            DGV.Rows.Clear()
            For i As Integer = 0 To Dt.Rows.Count - 1
                With Dt.Rows(i)
                    DGV.Rows.Add(.Item("IdBill"), .Item("ListData"), .Item("Detail"))
                End With
            Next
            CHeaders()
            DSize()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Try
            If tbListData.Text <> String.Empty And txt_detaill.Text <> String.Empty Then
                If MsgBox("ต้องการแก้ไขข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Bill As BLL_BIll = New BLL_BIll
                    If BLL_Bill.UpdateListBill(IdBill, tbListData.Text, txt_detaill.Text) Then
                        MsgBox("แก้ไขข้อมูลสำเร็จ", MsgBoxStyle.Information, "Information")
                        Clear()
                        Add_shipping_Load(sender, e)
                    Else
                        MsgBox("แก้ไขข้อมูลไม่สำเร็จ", MsgBoxStyle.Information, "Information")
                    End If
                End If
            Else
                MsgBox("กรุณาเช็คข้อมุล", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        Try
            If tbListData.Text <> String.Empty And txt_detaill.Text <> String.Empty Then
                If MsgBox("ต้องการลบข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Bill As BLL_BIll = New BLL_BIll
                    If BLL_Bill.DelListBill(IdBill) Then
                        MsgBox("ลบข้อมูลสำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                        Clear()
                        Add_shipping_Load(sender, e)
                    Else
                        MsgBox("ลบข้อมูลไม่สำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                    End If
                End If
            Else
                MsgBox("กรุณาเช็คข้อมุล", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Clear()
        tbListData.Text = String.Empty
        txt_detaill.Text = String.Empty
    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Try
            tbListData.Text = DGV.Rows(e.RowIndex).Cells("cListData").Value
            txt_detaill.Text = DGV.Rows(e.RowIndex).Cells("cDetail").Value
            IdBill = DGV.Rows(e.RowIndex).Cells("cIdBill").Value
            btEdit.Enabled = True
            btDel.Enabled = True
            btAdd.Enabled = False
        Catch ex As Exception

        End Try

    End Sub


    Private Sub CHeaders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize()
        DGV.Columns("cIdBill").Width = 20
        DGV.Columns("cListData").Width = 40
        DGV.Columns("cDetail").Width = 400
    End Sub

End Class