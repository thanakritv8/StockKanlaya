Imports BLL
Public Class Product
    Dim Main() As String
    Dim MainName() As String
    Dim FullMain As String
    Dim FullMainName As String
    Dim IdCategory() As String
    Dim FullIdCategory As String

    Private Sub btn_addProductNew_Click(sender As Object, e As EventArgs) Handles btn_addProductNew.Click
        Try
            Dim frm As frm_AddProduct = New frm_AddProduct
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Product_Load(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DGV.Rows.Clear()
            Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
            FullMain = String.Empty
            FullMainName = String.Empty
            FullIdCategory = String.Empty
            Dim DtCategory As DataTable = BLL_Warehouse.SearchCategory("ALL")
            For i As Integer = 0 To DtCategory.Rows.Count - 1
                FullMain &= "M" & vbNewLine
                FullMainName &= DtCategory.Rows(i).Item("NameCategory") & vbNewLine
                FullIdCategory &= DtCategory.Rows(i).Item("IdCategory") & vbNewLine
                DGV.Rows.Add("", "", "", "", "", "", "", "")
                Dim DtProduct As DataTable = BLL_Warehouse.SearchProduct(DtCategory.Rows(i).Item("IdCategory"))
                For j As Integer = 0 To DtProduct.Rows.Count - 1
                    FullMain &= "0" & vbNewLine
                    FullMainName &= "0" & vbNewLine
                    FullIdCategory &= "0" & vbNewLine
                    Dim NumOrder As String = BLL_Warehouse.SearchStatusProduct("สั่งจอง", DtProduct.Rows(j).Item("IdProduct"))
                    DGV.Rows.Add(DtProduct.Rows(j).Item("IdProduct"), DtProduct.Rows(j).Item("NameProduct"), NumOrder, DtProduct.Rows(j).Item("Price_Buy"), DtProduct.Rows(j).Item("Price_Sell"), DtProduct.Rows(j).Item("Stock"), DtProduct.Rows(j).Item("Unit"), "แก้ไข")
                Next
            Next
            MainName = Split(FullMainName, vbNewLine) 'DtProduct.Rows(j).Item("Price_Buy")
            Main = Split(FullMain, vbNewLine)
            IdCategory = Split(FullIdCategory, vbNewLine)

            CHeaders()
            DSize()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DGV_Paint(sender As Object, e As PaintEventArgs) Handles DGV.Paint
        Try
            For _r As Integer = 0 To DGV.Rows.Count - 1 '16
                If Main(_r) = "M" Then
                    'Config Merge DataGrid
                    Dim RowMerge As Integer = _r
                    Dim rec As Rectangle = DGV.GetCellDisplayRectangle(0, RowMerge, True)    'Start Cell, *Start Row 
                    Dim Width As Integer = 0
                    For Each Item In DGV.Rows(RowMerge).Cells
                        Width += Item.Size.Width
                    Next
                    If rec.Y <> 0 Then
                        Dim rc As Rectangle = New Rectangle(rec.X, rec.Y, Width, DGV.Rows(RowMerge).Cells(0).Size.Height)
                        'End Config Merge DataGrid
                        e.Graphics.FillRectangle(Brushes.LightGray, rc) 'Config Background
                        e.Graphics.DrawRectangle(Pens.Black, rc)    'Config Border
                        'Config Font
                        Dim format As StringFormat = New StringFormat
                        format.LineAlignment = StringAlignment.Near
                        format.Alignment = StringAlignment.Near
                        Dim f As Drawing.Font = New Drawing.Font("Times New Roman", 16, FontStyle.Bold)
                        e.Graphics.DrawString(MainName(_r) & " ( " & IdCategory(_r) & " )", f, Brushes.DodgerBlue, rc, format) 'DeepSkyBlue
                        'End Font
                    End If

                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                BLL_Extra.SendStatus("Edit")
                BLL_Extra.SendIdProduct(DGV.Rows(e.RowIndex).Cells("cIdProduct").Value)
                Dim frm As frm_AddProduct = New frm_AddProduct
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Product_Load(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearch.Click
        Try
            DGV.Rows.Clear()
            Dim BLL_Warehouse As BLL_Warehouse = New BLL_Warehouse
            FullMain = String.Empty
            FullMainName = String.Empty

            Dim DtCategory As DataTable = BLL_Warehouse.SearchIdCategory(tbSearch.Text)
            For i As Integer = 0 To DtCategory.Rows.Count - 1
                FullMain &= "M" & vbNewLine
                FullMainName &= DtCategory.Rows(i).Item("NameCategory") & vbNewLine
                FullIdCategory &= DtCategory.Rows(i).Item("IdCategory") & vbNewLine
                DGV.Rows.Add("", "", "", "", "", "", "")
                Dim DtProduct As DataTable = BLL_Warehouse.SearchProduct(DtCategory.Rows(i).Item("IdCategory"))
                For j As Integer = 0 To DtProduct.Rows.Count - 1
                    FullMain &= "0" & vbNewLine
                    FullMainName &= "0" & vbNewLine
                    FullIdCategory &= "0" & vbNewLine
                    Dim NumOrder As String = BLL_Warehouse.SearchStatusProduct("สั่งจอง", DtProduct.Rows(j).Item("IdProduct"))
                    DGV.Rows.Add(DtProduct.Rows(j).Item("IdProduct"), DtProduct.Rows(j).Item("NameProduct"), NumOrder, DtProduct.Rows(j).Item("Price_Buy"), DtProduct.Rows(j).Item("Price_Sell"), DtProduct.Rows(j).Item("Stock"), DtProduct.Rows(j).Item("Unit"), "แก้ไข")
                Next
            Next
            MainName = Split(FullMainName, vbNewLine)
            Main = Split(FullMain, vbNewLine)
            IdCategory = Split(FullIdCategory, vbNewLine)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch.KeyUp
        Try
            lbSearch_Click(sender, e)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btEx_Product_Click(sender As Object, e As EventArgs) Handles btEx_Product.Click
        Try
            If DGV.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\Ex_ProductCus.xlsx"
                FileCopy(Application.StartupPath & "\Doc\Ex_Product.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DGV.RowCount - 1, DGV.ColumnCount - 2) As String
                For i As Integer = 0 To DGV.RowCount - 1
                    For j As Integer = 0 To DGV.ColumnCount - 2
                        Arr(i, j) = DGV.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.Write_ExProduct(Path, "Sheet1", Arr, DGV.RowCount - 1, DGV.ColumnCount - 2)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\Ex_ProductCus.xlsx")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

    Private Sub CHeaders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize()
        DGV.Columns("cIdProduct").Width = 30
        DGV.Columns("cNameProduct").Width = 120
        DGV.Columns("cReserve").Width = 20
        DGV.Columns("Column1").Width = 20
        DGV.Columns("cPrice").Width = 20
        DGV.Columns("cStock").Width = 40
        DGV.Columns("cUnit").Width = 20
        DGV.Columns("cEdit").Width = 90

    End Sub


End Class