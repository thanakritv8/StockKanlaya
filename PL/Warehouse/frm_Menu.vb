Imports BLL
Public Class frm_Menu
    Dim Id As Integer
    Private Sub frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV.Columns(0).Visible = False
        CHeaders()
        DSize()
        btEdit.Enabled = False
        RefreshDGV()
    End Sub

    Private Sub CHeaders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    'tbdetail
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Try
            If tbMenu.Text <> String.Empty And txt_Detail.Text <> String.Empty Then
                If MsgBox("ต้องการบันทึกข้อมูลใช่มั้ย ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
                    If BLL_Warehouse.InsertMenu(tbMenu.Text, txt_Detail.Text) Then
                        MsgBox("เพิ่มเมนูสำเร็จ", MsgBoxStyle.Information, "Information")
                        RefreshDGV()
                    Else
                        MsgBox("เพิ่มเมนูไม่สำเร็จ", MsgBoxStyle.Information, "Information")
                    End If
                End If
            Else
                MsgBox("กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try


    End Sub

    Public Sub Claer_Menu()
        tbMenu.Text = String.Empty
        txt_Detail.Text = String.Empty
    End Sub

    Public Sub RefreshDGV()
        Try
            tbMenu.Text = String.Empty
            txt_Detail.Text = String.Empty
            btEdit.Enabled = False
            btAdd.Enabled = True
            Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
            Dim Dt As DataTable = BLL_Warehouse.GetMenu
            DGV.Rows.Clear()
            For i As Integer = 0 To Dt.Rows.Count - 1
                With Dt.Rows(i)
                    DGV.Rows.Add(.Item("IdMenu"), .Item("NameMenu"), .Item("DetailMenu"), "ลบ")
                End With
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        Try
            tbMenu.Text = DGV.Rows(e.RowIndex).Cells("cName").Value
            txt_Detail.Text = DGV.Rows(e.RowIndex).Cells("cDetail").Value
            Id = DGV.Rows(e.RowIndex).Cells("cId").Value
            btEdit.Enabled = True
            btAdd.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Try
            Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
            If BLL_Warehouse.UpdateMenu(Id, tbMenu.Text, txt_Detail.Text) Then
                MsgBox("แก้ไขเมนูสำเร็จ", MsgBoxStyle.Information, "Information")
                RefreshDGV()
            Else
                MsgBox("แก้ไขเมนูไม่สำเร็จ", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
                If BLL_Warehouse.DeleteMenu(DGV.Rows(e.RowIndex).Cells("cId").Value) Then
                    MsgBox("ลบเมนูสำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                    RefreshDGV()
                Else
                    MsgBox("ลบเมนูไม่สำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DSize()
        DGV.Columns("cId").Width = 60
        DGV.Columns("cName").Width = 120
        DGV.Columns("cDetail").Width = 120
        DGV.Columns("cDel").Width = 80
    End Sub

End Class