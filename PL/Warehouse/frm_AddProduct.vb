Imports BLL
Imports System.IO

Public Class frm_AddProduct
    Dim IdCategory As String
    Dim PathFile As String
    Private Sub frm_AddProduct_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            PathFile = String.Empty
            IdCategory = String.Empty
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            If BLL_Extra.Status = "Edit" Then
                BLL_Extra.SendStatus(String.Empty)
                DGV.Rows.Clear()
                tbIdCategory.Enabled = False
                btEdit.Enabled = True
                btDel.Enabled = True
                btSave.Enabled = False
                btClear.Enabled = False
                Dim IdProduct As String = BLL_Extra.ReadIdProduct
                Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
                Dim IdCategory As String = BLL_Warehouse.GetIdCategory(IdProduct)
                If Not String.IsNullOrEmpty(IdCategory) Then
                    Dim DtProduct As DataTable = BLL_Warehouse.SearchProduct(IdCategory)
                    Dim DtCategory As DataTable = BLL_Warehouse.SearchCategory(IdCategory)
                    If DtCategory.Rows.Count > 0 And DtProduct.Rows.Count > 0 Then
                        'Category
                        tbIdCategory.Text = IdCategory
                        tbNameCategory.Text = DtCategory.Rows(0).Item("NameCategory").ToString
                        tbDetail.Text = DtCategory.Rows(0).Item("Detail").ToString
                        tbBrand.Text = DtCategory.Rows(0).Item("Brand").ToString
                        tbBlock.Text = DtCategory.Rows(0).Item("Block").ToString
                        tbPosition.Text = DtCategory.Rows(0).Item("Position").ToString
                        tbTag.Text = DtCategory.Rows(0).Item("Tag").ToString
                        PathFile = DtCategory.Rows(0).Item("PathPicture").ToString
                        If PathFile <> String.Empty Then
                            Dim fs As System.IO.FileStream
                            fs = New System.IO.FileStream(Application.StartupPath & PathFile, IO.FileMode.Open, IO.FileAccess.Read)
                            PicProduct.Image = System.Drawing.Image.FromStream(fs)
                            fs.Close()
                        End If
                        tbIdCategory.Enabled = False
                        'Product
                        For i As Integer = 0 To DtProduct.Rows.Count - 1
                            DGV.Rows.Add(IdCategory, cbNameCategory.Text, DtProduct.Rows(i).Item("IdProduct").ToString, DtProduct.Rows(i).Item("NameProduct").ToString, CInt(DtProduct.Rows(i).Item("Price_Buy").ToString), CInt(DtProduct.Rows(i).Item("Price_Sell").ToString), CInt(DtProduct.Rows(i).Item("Stock").ToString), DtProduct.Rows(i).Item("Unit").ToString, "ลบ")
                        Next
                    End If
                End If
                DGV.Columns(2).ReadOnly = True
                For i As Integer = 3 To 7
                    DGV.Columns(i).ReadOnly = False
                Next
            Else
                cbNameCategory.Enabled = False
                btEdit.Enabled = False
                btDel.Enabled = False
                btClear.Enabled = True
                btSave.Enabled = True
                DGV.Columns(2).ReadOnly = False
                For i As Integer = 3 To 7
                    DGV.Columns(i).ReadOnly = True
                Next
            End If
            DHeaders()
            DSize()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbIdCategory_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbIdCategory.TextChanged
        IdCategory = tbIdCategory.Text
    End Sub

    Private Sub tbNameCategory_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbNameCategory.TextChanged
        Try
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            cbNameCategory.Enabled = False
            cbNameCategory.Text = tbNameCategory.Text
            'If BLL_Extra.Status = "Edit" Then

            'Else
            '    cbNameCategory.Enabled = False
            '    cbNameCategory.Text = tbNameCategory.Text
            'End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAdd.Click
        Try
            If Not String.IsNullOrEmpty(tbNameProduct.Text) And Not String.IsNullOrEmpty(tbPriceBuy.Text) And Not String.IsNullOrEmpty(tbPriceSell.Text) And Not String.IsNullOrEmpty(tbAmount.Text) And Not String.IsNullOrEmpty(tbUnit.Text) Then
                'Dim IdProduct As String = IdCategory & "-" & DGV.Rows.Count + 1
                DGV.Rows.Add(IdCategory, cbNameCategory.Text, String.Empty, tbNameProduct.Text, tbPriceBuy.Text, tbPriceSell.Text, tbAmount.Text, tbUnit.Text, "ลบ")
                tbNameProduct.Text = String.Empty
                tbPriceBuy.Text = String.Empty
                tbPriceSell.Text = String.Empty
                tbAmount.Text = String.Empty
                tbUnit.Text = String.Empty
                DGV.Columns(2).ReadOnly = False
                For i As Integer = 3 To 7
                    DGV.Columns(i).ReadOnly = True
                Next
            Else
                MsgBox("กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                DGV.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSave.Click
        Try
            If MsgBox("คุณต้องการเพิ่มรายการสินค้าใช่มั้ย", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
                Dim Status As Boolean = BLL_Warehouse.StatusDGV(DGV)
                If Not String.IsNullOrEmpty(tbIdCategory.Text) And Not String.IsNullOrEmpty(tbNameCategory.Text) And DGV.Rows.Count > 0 And Status Then
                    Dim PathCopy As String = String.Empty
                    Dim FileName As String = String.Empty
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    If PathFile <> String.Empty Then
                        Dim FileLast() As String = PathFile.Split(".")
                        FileName = "\PicProduct\" & BLL_Extra.EncoderMD5(tbIdCategory.Text) & "." & FileLast(FileLast.Length - 1)
                        PathCopy = Application.StartupPath & FileName
                    End If
                    If BLL_Warehouse.InsertWarehouse(tbIdCategory.Text, tbNameCategory.Text, tbDetail.Text, tbBrand.Text, tbBlock.Text, tbPosition.Text, tbTag.Text, DGV, FileName) Then
                        If PathCopy <> String.Empty Then
                            FileCopy(PathFile, PathCopy)
                        End If
                        MsgBox("เพิ่มสินค้าเสร็จสมบูรณ์", MsgBoxStyle.Information, "Information")
                        ClearProduct()
                        BLL_Extra.SendStatus(String.Empty)
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        MsgBox("เพิ่มสินค้าไม่สมบูรณ์ กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEdit.Click
        Try
            If MsgBox("คุณต้องการแก้ไขรายการสินค้าใช่มั้ย", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
                Dim Status As Boolean = BLL_Warehouse.StatusDGV(DGV)
                If Not String.IsNullOrEmpty(tbIdCategory.Text) And Not String.IsNullOrEmpty(tbNameCategory.Text) And DGV.Rows.Count > 0 And Status Then
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    Dim DtCategory As DataTable = BLL_Warehouse.SearchCategory(tbIdCategory.Text)
                    If DtCategory.Rows.Count > 0 Then
                        Dim PathCopy As String = DtCategory.Rows(0).Item("PathPicture").ToString
                        If PathFile <> PathCopy Then
                            If PathCopy = String.Empty Then
                                Dim FileLast() As String = PathFile.Split(".")
                                PathCopy = "\PicProduct\" & BLL_Extra.EncoderMD5(tbIdCategory.Text) & "." & FileLast(FileLast.Length - 1)
                            End If
                        End If
                        If PathFile <> PathCopy Then
                            FileCopy(PathFile, Application.StartupPath & PathCopy)
                        End If
                        If BLL_Warehouse.UpdateWarehouse(tbIdCategory.Text, tbNameCategory.Text, tbDetail.Text, tbBrand.Text, tbBlock.Text, tbPosition.Text, tbTag.Text, DGV, PathCopy) Then
                            If BLL_Warehouse.DelProducts(tbIdCategory.Text, DGV) Then

                                MsgBox("เพิ่มสินค้าเสร็จสมบูรณ์", MsgBoxStyle.Information, "Information")
                                ClearProduct()
                                BLL_Extra.SendStatus(String.Empty)
                                DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        Else
                            MsgBox("กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
                        End If
                    Else
                        MsgBox("ไม่มีข้อมูลนี้", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Public Sub ClearProduct()
        Try
            tbIdCategory.Text = String.Empty
            tbNameCategory.Text = String.Empty
            tbDetail.Text = String.Empty
            tbBrand.Text = String.Empty
            tbBlock.Text = String.Empty
            tbPosition.Text = String.Empty
            tbTag.Text = String.Empty
            tbNameProduct.Text = String.Empty
            tbPriceBuy.Text = 0
            tbPriceSell.Text = 0
            tbAmount.Text = 0
            tbUnit.Text = String.Empty
            DGV.Rows.Clear()
            PathFile = String.Empty
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btDel.Click
        Try
            If MsgBox("คุณต้องการลบรายการสินค้าใช่มั้ย", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
                If BLL_Warehouse.DelProduct(tbIdCategory.Text) Then
                    If PathFile <> String.Empty Then
                        File.Delete(Application.StartupPath & PathFile)
                    End If
                    MsgBox("ลบสินค้าเสร็จสมบูรณ์", MsgBoxStyle.Exclamation, "Exclamation")
                    ClearProduct()
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    BLL_Extra.SendStatus(String.Empty)
                    DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("กรุณาเช็คข้อมูล", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tbPriceBuy_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbPriceBuy.TextChanged
        Try
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            If Not BLL_Extra.CheckNum(tbPriceBuy.Text) Then
                MsgBox("กรุณากรอกเฉพาะตัวเลข", MsgBoxStyle.Exclamation, "Exclamation")
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tbPriceSell_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbPriceSell.TextChanged
        Try
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            If Not BLL_Extra.CheckNum(tbPriceSell.Text) Then
                MsgBox("กรุณากรอกเฉพาะตัวเลข", MsgBoxStyle.Exclamation, "Exclamation")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbAmount_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbAmount.TextChanged
        Try
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            If Not BLL_Extra.CheckNum(tbAmount.Text) Then
                MsgBox("กรุณากรอกเฉพาะตัวเลข", MsgBoxStyle.Exclamation, "Exclamation")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PicProduct_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicProduct.DoubleClick
        Try
            Dim result As DialogResult = OFD.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                PathFile = OFD.FileName
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(PathFile, IO.FileMode.Open, IO.FileAccess.Read)
                PicProduct.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DHeaders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize()
        DGV.Columns("cIdCategory").Width = 16
        DGV.Columns("cNameCategory").Width = 18
        DGV.Columns("cIdProduct").Width = 17
        DGV.Columns("cNameProduct").Width = 55
        DGV.Columns("cPriceBuy").Width = 12
        DGV.Columns("cPriceSell").Width = 13
        DGV.Columns("cAmount").Width = 18
        DGV.Columns("cUnit").Width = 8
        DGV.Columns("cDel").Width = 50
    End Sub

End Class