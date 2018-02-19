Imports BLL
Public Class frm_Bank
    Dim IdBank As Integer

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Try
            If tbBank.Text <> String.Empty And tbBranch.Text <> String.Empty And tbName.Text <> String.Empty And tbNum.Text <> String.Empty Then
                If MsgBox("ต้องการบันทึกข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Cus As BLL_Customer = New BLL_Customer
                    If BLL_Cus.InsertBank(tbBank.Text, tbName.Text, tbNum.Text, tbBranch.Text) Then
                        MsgBox("บันทึกข้อมูลสำเร็จ", MsgBoxStyle.Information, "Information")
                        Clear()
                        frm_Bank_Load(sender, e)
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

    Private Sub frm_Bank_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV.Columns(0).Visible = False
        Try
            IdBank = 0
            btEdit.Enabled = False
            btDel.Enabled = False
            btAdd.Enabled = True
            Dim BLL_Cus As BLL_Customer = New BLL_Customer
            Dim Dt As DataTable = BLL_Cus.SelectBank
            DGV.Rows.Clear()
            For i As Integer = 0 To Dt.Rows.Count - 1
                With Dt.Rows(i)
                    DGV.Rows.Add(.Item("IdBank"), .Item("NameBank"), .Item("NumBank"), .Item("Name"), .Item("Branch"))
                End With
            Next
            CHeaders()
            DSize()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Try
            If tbBank.Text <> String.Empty And tbBranch.Text <> String.Empty And tbName.Text <> String.Empty And tbNum.Text <> String.Empty Then
                If MsgBox("ต้องการแก้ไขข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Cus As BLL_Customer = New BLL_Customer
                    If BLL_Cus.UpdateBank(IdBank, tbBank.Text, tbName.Text, tbNum.Text, tbBranch.Text) Then
                        MsgBox("แก้ไขข้อมูลสำเร็จ", MsgBoxStyle.Information, "Information")
                        Clear()
                        frm_Bank_Load(sender, e)
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
            If tbBank.Text <> String.Empty And tbBranch.Text <> String.Empty And tbName.Text <> String.Empty And tbNum.Text <> String.Empty Then
                If MsgBox("ต้องการลบข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Cus As BLL_Customer = New BLL_Customer
                    If BLL_Cus.DelBank(IdBank) Then
                        MsgBox("ลบข้อมูลสำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                        Clear()
                        frm_Bank_Load(sender, e)
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
        tbBank.Text = String.Empty
        tbBranch.Text = String.Empty
        tbName.Text = String.Empty
        tbNum.Text = String.Empty
    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Try
            tbBank.Text = DGV.Rows(e.RowIndex).Cells("cBank").Value
            tbNum.Text = DGV.Rows(e.RowIndex).Cells("cNum").Value
            tbName.Text = DGV.Rows(e.RowIndex).Cells("cName").Value
            tbBranch.Text = DGV.Rows(e.RowIndex).Cells("cBranch").Value
            IdBank = DGV.Rows(e.RowIndex).Cells("cIdBank").Value
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
        DGV.Columns("cIdBank").Width = 20
        DGV.Columns("cBank").Width = 40
        DGV.Columns("cNum").Width = 80
        DGV.Columns("cName").Width = 80
        DGV.Columns("cBranch").Width = 70
    End Sub

End Class