Imports BLL
Public Class frmSales_information
    Dim Main() As String
    Dim MainName() As String
    Dim FullMain As String
    Dim FullMainName As String
    Dim IdCategory() As String
    Dim FullIdCategory As String

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

                        'e.Graphics.DrawString(MainName(_r) & " (" & IdCategory(_r) & ")", Me.Font, Brushes.Green, rc, format)

                        Dim f As Drawing.Font = New Drawing.Font("Times New Roman", 16, FontStyle.Bold)
                        e.Graphics.DrawString(MainName(_r), f, Brushes.DodgerBlue, rc, format)
                        'End Font
                    End If

                End If
            Next
            CHeaders()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Try
            DGV.Rows.Clear()
            Dim BLL_Dashboard As BLL_Dashboard = New BLL_Dashboard
            FullMain = String.Empty
            FullMainName = String.Empty
            Dim DtCategory As DataTable = BLL_Dashboard.SearchCategory("ALL")
            For i As Integer = 0 To DtCategory.Rows.Count - 1
                FullMain &= "M" & vbNewLine
                FullMainName &= DtCategory.Rows(i).Item("NameCategory") & vbNewLine
                FullIdCategory &= DtCategory.Rows(i).Item("IdCategory") & vbNewLine
                DGV.Rows.Add("", "", "", "", "", "")
                Dim DtProduct As DataTable = BLL_Dashboard.SearchProduct(DtCategory.Rows(i).Item("IdCategory"))
                For j As Integer = 0 To DtProduct.Rows.Count - 1
                    FullMain &= "0" & vbNewLine
                    FullMainName &= "0" & vbNewLine
                    FullIdCategory &= "0" & vbNewLine
                    Dim NumOrder As String = BLL_Dashboard.SearchStatusProductDate("จ่ายแล้ว", DtProduct.Rows(j).Item("IdProduct"), DTP1.Value, DTP2.Value)
                    DGV.Rows.Add(DtProduct.Rows(j).Item("IdProduct"), DtProduct.Rows(j).Item("NameProduct"), DtProduct.Rows(j).Item("Stock"), NumOrder)
                Next
            Next
            MainName = Split(FullMainName, vbNewLine)
            Main = Split(FullMain, vbNewLine)
            IdCategory = Split(FullIdCategory, vbNewLine)
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try


    End Sub

    Private Sub btEx_Click(sender As Object, e As EventArgs) Handles btEx.Click
        Try
            If DGV.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\stockreal.xlsx"
                FileCopy(Application.StartupPath & "\Doc\stock.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DGV.RowCount - 1, 2) As String
                Dim _r As Integer = 0
                For i As Integer = 0 To DGV.RowCount - 1
                    If DGV.Rows(i).Cells("cSell").Value <> "" Then
                        If DGV.Rows(i).Cells("cSell").Value <> 0 Then
                            Arr(_r, 0) = DGV.Rows(i).Cells("cIdProduct").Value
                            Arr(_r, 1) = DGV.Rows(i).Cells("cNameProduct").Value
                            Arr(_r, 2) = DGV.Rows(i).Cells("cSell").Value
                            _r += 1
                        End If
                    End If
                Next
                BLL_Extra.WriteStock(Path, "Sheet1", Arr, _r, 2)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\stockreal.xlsx")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CHeaders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub

End Class