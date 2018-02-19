Imports BLL
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmStore_statistic

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        Try
            Dim NumDay As Integer = DateDiff(DateInterval.Day, DTP1.Value, DTP2.Value)
            Dim sumTotal As Integer = 0
            Dim sumOrder As Integer = 0
            Chart.Series(0).Points.Clear()
            For i As Integer = 0 To NumDay
                Dim BLL_Dashboard As BLL_Dashboard = New BLL_Dashboard
                Chart.Series(0).XValueType = ChartValueType.DateTime
                Dim Sum As Integer = IIf(IsDBNull(BLL_Dashboard.SearchSell(DTP1.Value.AddDays(i))), 0, BLL_Dashboard.SearchSell(DTP1.Value.AddDays(i)))
                Chart.Series(0).Points.AddXY(DTP1.Value.AddDays(i).ToOADate, Sum)
                sumTotal += Sum
                Dim D = DTP1.Value.AddDays(i)
                sumOrder += BLL_Dashboard.SearchOrder(DTP1.Value.AddDays(i))
                'Chart.Series(0).Points.AddXY(DTP1.Value.AddDays(i), Sum)
                'Chart.Series(0).XValueMember = DTP1.Value.AddDays(i)
                'Chart.Series(0).YValueMembers = Sum
            Next
            lbNum.Text = sumOrder
            lbTotal.Text = sumTotal
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmStore_statistic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbGroup.Items.Clear()
            Dim BLL_Add_Bill As BLL_BIll = New BLL_BIll
            Dim DtBill As DataTable = BLL_Add_Bill.SelectListBill("ประเภทลูกค้า")
            For i As Integer = 0 To DtBill.Rows.Count - 1
                cbGroup.Items.Add(DtBill.Rows(i).Item("ListData"))
            Next
            CHeaders1()
            CHeaders2()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btD_Click(sender As Object, e As EventArgs) Handles btD.Click
        Try
            Dim BLL_Dashboard As BLL_Dashboard = New BLL_Dashboard
            Dim Dt As DataTable = BLL_Dashboard.GetOrder(DDTP1.Value, DDTP2.Value)
            DDGV.Rows.Clear()
            For i As Integer = 0 To Dt.Rows.Count - 1
                With Dt.Rows(i)
                    Dim CusType As String = String.Empty
                    Dim CusName As String = String.Empty
                    Dim CusAddress As String = String.Empty
                    Dim CusTel As String = String.Empty
                    Dim Menu As String = BLL_Dashboard.GetNameMenu(.Item("IdOrder").ToString)
                    Dim DtCus As DataTable = BLL_Dashboard.GetCus(CInt(.Item("IdCustomer").ToString))
                    If DtCus.Rows.Count > 0 Then
                        CusType = DtCus.Rows(0).Item("GroupCus").ToString
                        CusName = DtCus.Rows(0).Item("Name").ToString
                        CusAddress = DtCus.Rows(0).Item("Address").ToString
                        CusTel = DtCus.Rows(0).Item("Tel").ToString
                    End If
                    DDGV.Rows.Add(.Item("IdOrder").ToString, CusType, CusName, CusAddress, Menu, .Item("Price").ToString _
                                  , CusTel, .Item("DateBank").ToString, .Item("Bank").ToString, .Item("CreateDate").ToString, .Item("StatusTransport").ToString)
                End With

            Next
            CHeaders1()
            DSize1()
        Catch ex As Exception

        End Try


    End Sub



    Private Sub btDEx_Click(sender As Object, e As EventArgs) Handles btDEx.Click
        Try
            If DDGV.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\dmyreal.xls"
                FileCopy(Application.StartupPath & "\Doc\dmy.xls", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DDGV.RowCount - 1, DDGV.ColumnCount - 1) As String
                For i As Integer = 0 To DDGV.RowCount - 1
                    For j As Integer = 0 To DDGV.ColumnCount - 1
                        Arr(i, j) = DDGV.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.WriteStock(Path, "Sheet1", Arr, DDGV.RowCount - 1, DDGV.ColumnCount - 1)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\dmyreal.xls")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try


    End Sub

    Private Sub btG_Click(sender As Object, e As EventArgs) Handles btG.Click
        Try
            If cbGroup.Text <> "" Then
                Dim BLL_Dashboard As BLL_Dashboard = New BLL_Dashboard
                Dim Dt As DataTable = BLL_Dashboard.GetDataGroup(cbGroup.Text, GDTP1.Value, GDTP2.Value)
                GDGV.Rows.Clear()
                Dim Total As Integer = 0
                For i As Integer = 0 To Dt.Rows.Count - 1
                    With Dt.Rows(i)
                        Dim _Row(Dt.Columns.Count - 1) As Object
                        For j As Integer = 0 To Dt.Columns.Count - 1
                            _Row(j) = Dt.Rows(i).Item(j).ToString
                        Next
                        Total += .Item("Price")
                        GDGV.Rows.Add(_Row)
                    End With
                Next
                GDGV.Rows.Add("รวม", "", "", "", "", "", "", "", "", "", "", Total)
            End If
            CHeaders2()
            DSize2()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btGEx_Click(sender As Object, e As EventArgs) Handles btGEx.Click
        Try
            If GDGV.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\groupreal.xlsx"
                FileCopy(Application.StartupPath & "\Doc\group.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(GDGV.RowCount - 1, GDGV.ColumnCount - 1) As String
                For i As Integer = 0 To GDGV.RowCount - 1
                    For j As Integer = 0 To GDGV.ColumnCount - 1
                        Arr(i, j) = GDGV.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.WriteStock(Path, "Sheet1", Arr, GDGV.RowCount - 1, GDGV.ColumnCount - 1)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\groupreal.xlsx")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try



    End Sub

    Private Sub CHeaders1()
        DDGV.EnableHeadersVisualStyles = False
        DDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize1()
        DDGV.Columns("cOrder").Width = 100
        DDGV.Columns("cCusType").Width = 60
        DDGV.Columns("cCusName").Width = 80
        DDGV.Columns("cCusAddress").Width = 120
        DDGV.Columns("cProduct").Width = 40
        DDGV.Columns("cPrice").Width = 30
        DDGV.Columns("cTel").Width = 55
        DDGV.Columns("cTime").Width = 100
        DDGV.Columns("cBank").Width = 40
        DDGV.Columns("cDateOrder").Width = 105
        DDGV.Columns("cTransport").Width = 70
    End Sub

    Private Sub CHeaders2()
        GDGV.EnableHeadersVisualStyles = False
        GDGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        GDGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize2()
        GDGV.Columns("Column1").Width = 100
        GDGV.Columns("Column2").Width = 60
        GDGV.Columns("DataGridViewTextBoxColumn1").Width = 40
        GDGV.Columns("Column4").Width = 120
        GDGV.Columns("Column5").Width = 70
        GDGV.Columns("Column6").Width = 60
        GDGV.Columns("Column7").Width = 40
        GDGV.Columns("Column3").Width = 100
        GDGV.Columns("Column8").Width = 40
        GDGV.Columns("DataGridViewTextBoxColumn2").Width = 105
        GDGV.Columns("DataGridViewTextBoxColumn3").Width = 30
        GDGV.Columns("Column12").Width = 40
    End Sub



End Class