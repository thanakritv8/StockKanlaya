Imports BLL
Public Class Add_Product
    Dim Main() As String
    Dim MainName() As String
    Dim FullMain As String
    Dim FullMainName As String
    Dim MainPro() As String
    Dim MainNamePro() As String
    Dim FullMainPro As String
    Dim FullMainNamePro As String
    Private Sub DGV_Paint(sender As Object, e As PaintEventArgs) Handles DGV.Paint
        Try
            For _r As Integer = 0 To DGV.Rows.Count - 1
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
                        e.Graphics.DrawString(MainName(_r), f, Brushes.DodgerBlue, rc, format)        'ไม่โชว์รหัสสินค้า
                        'e.Graphics.DrawString(MainName(_r) & " ( " & MainNamePro(_r) & " )", f, Brushes.DodgerBlue, rc, format) 'โชว์รหัสสินค้า 'DeepSkyBlue 
                        'End Font
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
        'DGV.Columns(0).Width = 50

    End Sub

    Private Sub Add_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FullMain = String.Empty
            FullMainName = String.Empty
            Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
            Dim DtCategory As DataTable = BLL_Bill.SearchCategory("ALL")
            For i As Integer = 0 To DtCategory.Rows.Count - 1
                FullMain &= "M" & vbNewLine
                FullMainName &= DtCategory.Rows(i).Item("NameCategory") & vbNewLine
                DGV.Rows.Add("", "", "", "", "", "", "")
                Dim DtProduct As DataTable = BLL_Bill.SearchProduct(DtCategory.Rows(i).Item("IdCategory"))
                For j As Integer = 0 To DtProduct.Rows.Count - 1
                    FullMain &= "0" & vbNewLine
                    FullMainName &= "0" & vbNewLine
                    Dim NumOrder As String = BLL_Bill.SearchStatusOrder("สั่งจอง", DtProduct.Rows(j).Item("IdProduct"))
                    DGV.Rows.Add(DtProduct.Rows(j).Item("IdProduct"), DtProduct.Rows(j).Item("NameProduct"), DtProduct.Rows(j).Item("Stock"), NumOrder, 1, DtProduct.Rows(j).Item("Price_Sell"), "เลือก")
                Next
            Next
            MainName = Split(FullMainName, vbNewLine)
            Main = Split(FullMain, vbNewLine)
            DGV.Columns(4).ReadOnly = False
            DGVPro.Columns(4).ReadOnly = False

            cbMenu.Items.Clear()
            Dim DtMenu As DataTable = BLL_Bill.GetMenu
            For i As Integer = 0 To DtMenu.Rows.Count - 1
                cbMenu.Items.Add(DtMenu.Rows(i).Item("NameMenu"))
            Next
            CHeaders1()
            CHeaders2()
            DSize1()
            DSize2()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                If BLL_Extra.CheckNum(DGV.Rows(e.RowIndex).Cells("cNum").Value) Then
                    Dim Num As Integer = CInt(DGV.Rows(e.RowIndex).Cells("cNum").Value)
                    Dim Stock As Integer = CInt(DGV.Rows(e.RowIndex).Cells("c3").Value)
                    Dim Order As Integer = CInt(DGV.Rows(e.RowIndex).Cells("c4").Value)
                    If Num > 0 Then
                        If Num <= (Stock - Order) Then

                            DGVSelect.Rows.Add(DGV.Rows(e.RowIndex).Cells("c1").Value, DGV.Rows(e.RowIndex).Cells("c2").Value, DGV.Rows(e.RowIndex).Cells("c5").Value * Num, Num, False, "ลบ")
                            'For i As Integer = 0 To Num - 1
                            '    DGVSelect.Rows.Add(DGV.Rows(e.RowIndex).Cells("c1").Value, DGV.Rows(e.RowIndex).Cells("c2").Value, DGV.Rows(e.RowIndex).Cells("c5").Value, "ลบ")
                            'Next
                        Else
                            MsgBox("จำนวน Stock ไม่เพียงพอ", MsgBoxStyle.Information, "Information")
                        End If
                    Else
                        MsgBox("กรุณาเช็คจำนวน", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("กรุณากรอกเฉพาะตัวเลข", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGVPro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPro.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                If BLL_Extra.CheckNum(DGVPro.Rows(e.RowIndex).Cells("cNum").Value) Then
                    Dim Num As Integer = CInt(DGVPro.Rows(e.RowIndex).Cells("cNum").Value)
                    Dim Stock As Integer = CInt(DGVPro.Rows(e.RowIndex).Cells("c3").Value)
                    Dim Order As Integer = CInt(DGVPro.Rows(e.RowIndex).Cells("c4").Value)
                    If Num > 0 Then
                        If Num <= (Stock - Order) Then
                            For i As Integer = 0 To Num - 1
                                DGVSelect.Rows.Add(DGVPro.Rows(e.RowIndex).Cells(0).Value, DGVPro.Rows(e.RowIndex).Cells(1).Value, DGVPro.Rows(e.RowIndex).Cells(5).Value, False, "ลบ")
                            Next
                        Else
                            MsgBox("จำนวน Stock ไม่เพียงพอ", MsgBoxStyle.Information, "Information")
                        End If
                    Else
                        MsgBox("กรุณาเช็คจำนวน", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("กรุณากรอกเฉพาะตัวเลข", MsgBoxStyle.Information, "Information")
                End If

                'DGVSelect.Rows.Add(DGVPro.Rows(e.RowIndex).Cells(0).Value, DGVPro.Rows(e.RowIndex).Cells(1).Value, DGVPro.Rows(e.RowIndex).Cells(4).Value, "ลบ")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab.SelectedIndexChanged
        Try
            DGV.Rows.Clear()
            DGVPro.Rows.Clear()
            Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
            If Tab.SelectedIndex = 0 Then
                FullMain = String.Empty
                FullMainName = String.Empty
                Dim DtCategory As DataTable = BLL_Bill.SearchCategory("ALL")
                For i As Integer = 0 To DtCategory.Rows.Count - 1
                    FullMain &= "M" & vbNewLine
                    FullMainName &= DtCategory.Rows(i).Item("NameCategory") & vbNewLine
                    DGV.Rows.Add("", "", "", "", "", "", "")
                    Dim DtProduct As DataTable = BLL_Bill.SearchProduct(DtCategory.Rows(i).Item("IdCategory"))
                    For j As Integer = 0 To DtProduct.Rows.Count - 1
                        FullMain &= "0" & vbNewLine
                        FullMainName &= "0" & vbNewLine
                        Dim NumOrder As String = BLL_Bill.SearchStatusOrder("สั่งจอง", DtProduct.Rows(j).Item("IdProduct"))
                        DGV.Rows.Add(DtProduct.Rows(j).Item("IdProduct"), DtProduct.Rows(j).Item("NameProduct"), DtProduct.Rows(j).Item("Stock"), NumOrder, 1, DtProduct.Rows(j).Item("Price_Sell"), "เลือก")
                    Next
                Next
                MainName = Split(FullMainName, vbNewLine)
                Main = Split(FullMain, vbNewLine)
            Else
                FullMainPro = String.Empty
                FullMainNamePro = String.Empty
                Dim DtCategory As DataTable = BLL_Bill.SearchCategory("โปรโมชั่น")
                For i As Integer = 0 To DtCategory.Rows.Count - 1
                    FullMainPro &= "M" & vbNewLine
                    FullMainNamePro &= DtCategory.Rows(i).Item("NameCategory") & vbNewLine
                    DGVPro.Rows.Add("", "", "", "", "", "", "")
                    Dim DtProduct As DataTable = BLL_Bill.SearchProduct(DtCategory.Rows(i).Item("IdCategory"))
                    For j As Integer = 0 To DtProduct.Rows.Count - 1
                        FullMainPro &= "0" & vbNewLine
                        FullMainNamePro &= "0" & vbNewLine
                        Dim NumOrder As String = BLL_Bill.SearchStatusOrder("สั่งจอง", DtProduct.Rows(j).Item("IdProduct"))
                        DGVPro.Rows.Add(DtProduct.Rows(j).Item("IdProduct"), DtProduct.Rows(j).Item("NameProduct"), DtProduct.Rows(j).Item("Stock"), NumOrder, 1, DtProduct.Rows(j).Item("Price_Sell"), "เลือก")
                    Next
                Next
                MainNamePro = Split(FullMainNamePro, vbNewLine)
                MainPro = Split(FullMainPro, vbNewLine)
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DGVPro_Paint(sender As Object, e As PaintEventArgs) Handles DGVPro.Paint
        Try
            For _r As Integer = 0 To DGVPro.Rows.Count - 1
                If MainPro(_r) = "M" Then
                    'Config Merge DataGrid
                    Dim RowMerge As Integer = _r
                    Dim rec As Rectangle = DGVPro.GetCellDisplayRectangle(0, RowMerge, True)    'Start Cell, *Start Row 
                    Dim Width As Integer = 0
                    For Each Item In DGVPro.Rows(RowMerge).Cells
                        Width += Item.Size.Width
                    Next
                    Dim rc As Rectangle = New Rectangle(rec.X, rec.Y, Width, DGVPro.Rows(RowMerge).Cells(0).Size.Height)
                    'End Config Merge DataGrid
                    e.Graphics.FillRectangle(Brushes.LightGray, rc) 'Config Background
                    e.Graphics.DrawRectangle(Pens.Black, rc)    'Config Border
                    'Config Font
                    Dim format As StringFormat = New StringFormat
                    format.LineAlignment = StringAlignment.Center
                    format.Alignment = StringAlignment.Center
                    Dim f As Drawing.Font = New Drawing.Font("Times New Roman", 16, FontStyle.Bold)
                    e.Graphics.DrawString(MainNamePro(_r), f, Brushes.Green, rc, format)
                    'End Font
                End If
            Next
        Catch ex As Exception

        End Try
        'DGV.Columns(0).Width = 50

    End Sub

    Private Sub DGVSelect_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSelect.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                DGVSelect.Rows.RemoveAt(e.RowIndex)
            End If

            If e.ColumnIndex = 4 Then
                DGVSelect.Rows(e.RowIndex).Cells("cFree").Value = IIf(DGVSelect.Rows(e.RowIndex).Cells("cFree").Value, False, True)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Try
            If cbMenu.Text <> String.Empty And cbMenu.Text <> "เลือก" Then
                Dim BLL_Bill As BLL_Create_Bill = New BLL_Create_Bill
                Dim Dt As DataTable = New DataTable
                Dt.Columns.Add("NameMenu")
                Dt.Columns.Add("IdProduct")
                Dt.Columns.Add("NameProduct")
                Dt.Columns.Add("Price", System.Type.GetType("System.Int32"))
                Dt.Columns.Add("Num", System.Type.GetType("System.Int32"))
                Dt.Columns.Add("Free")

                For i As Integer = 0 To DGVSelect.Rows.Count - 1
                    With DGVSelect.Rows(i)
                        Dt.Rows.Add(cbMenu.Text, .Cells("cIdProduct").Value, .Cells("cName").Value, .Cells("cPrice").Value, .Cells("cCount").Value, IIf(.Cells("cFree").Value, "Free", "NoFree"))
                    End With
                Next
                BLL_Bill.Product(Dt)
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("กรุณาเลือกเมนู", MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CHeaders1()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize1()
        DGV.Columns("c1").Width = 10
        DGV.Columns("c2").Width = 30
        DGV.Columns("c3").Width = 7
        DGV.Columns("c4").Width = 8
        DGV.Columns("cNum").Width = 7
        DGV.Columns("c5").Width = 7
        DGV.Columns("c6").Width = 80

    End Sub

    Private Sub CHeaders2()
        DGVSelect.EnableHeadersVisualStyles = False
        DGVSelect.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGVSelect.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize2()
        DGVSelect.Columns("cIdProduct").Width = 19
        DGVSelect.Columns("cName").Width = 30
        DGVSelect.Columns("cPrice").Width = 12
        DGVSelect.Columns("cCount").Width = 10
        DGVSelect.Columns("cFree").Width = 7
        DGVSelect.Columns("cDel").Width = 60
    End Sub

End Class