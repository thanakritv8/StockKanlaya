Imports BLL
Public Class frmAdd_Customer
    Dim IdCus() As Integer
    Dim StatusSearch As Boolean = False
    Private Sub btn_AddCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddCustomer.Click
        Try
            Dim frm As frm_Customer = New frm_Customer
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                frmAdd_Customer_Load(sender, e)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbSearch_Click(sender As Object, e As EventArgs) Handles lbSearch.Click
        Dim BLL_Customer As BLL_Customer = New BLL_Customer
        Dim DtCus As DataTable = BLL_Customer.SelectCustomer(cbSearch.Text)
        DGVAddRowCus(DtCus)
    End Sub

    Private Sub DGVCus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCus.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim BLL_Customer As BLL_Customer = New BLL_Customer
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                BLL_Extra.SendStatus("Edit")
                BLL_Customer.SendIdCus(IdCus(e.RowIndex))
                Dim frm As frm_Customer = New frm_Customer
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    frmAdd_Customer_Load(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub frmAdd_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            Dim DtCus As DataTable = BLL_Customer.SelectCustomer("ALL")
            DGVAddRowCus(DtCus)
            cbSearch.Items.Clear()
            For i As Integer = 0 To DtCus.Rows.Count - 1
                cbSearch.Items.Add(DtCus.Rows(i).Item("Name").ToString)
            Next
            'Dim DtOrder As DataTable = BLL_Customer.SelectOrder()
            'DGVAddRowOrder(DtOrder)
            CHeaders1()
            CHeaders2()
            DSize1()
            DSize2()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CHeaders1()
        DGVCus.EnableHeadersVisualStyles = False
        DGVCus.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGVCus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize1()
        DGVCus.Columns("DataGridViewTextBoxColumn1").Width = 20
        DGVCus.Columns("DataGridViewTextBoxColumn2").Width = 80
        DGVCus.Columns("DataGridViewTextBoxColumn3").Width = 120
        DGVCus.Columns("DataGridViewTextBoxColumn4").Width = 20
        DGVCus.Columns("DataGridViewTextBoxColumn5").Width = 90
        DGVCus.Columns("DataGridViewTextBoxColumn6").Width = 30
        DGVCus.Columns("Ordering_Officer").Width = 60
        DGVCus.Columns("Column1").Width = 70
    End Sub

    Private Sub CHeaders2()
        DGVOrder.EnableHeadersVisualStyles = False
        DGVOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGVOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize2()
        DGVOrder.Columns("DataGridViewTextBoxColumn11").Width = 30
        DGVOrder.Columns("DataGridViewTextBoxColumn12").Width = 80
        DGVOrder.Columns("DataGridViewTextBoxColumn13").Width = 40
        DGVOrder.Columns("DataGridViewTextBoxColumn14").Width = 100

    End Sub

    Public Sub DGVAddRowCus(ByVal DtCus As DataTable)
        Try
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            DGVCus.Rows.Clear()
            ReDim IdCus(DtCus.Rows.Count - 1)
            For i As Integer = 0 To DtCus.Rows.Count - 1
                IdCus(i) = DtCus.Rows(i).Item("IdCustomer")
                Dim Arr() As String
                If StatusSearch Then
                    Arr = BLL_Customer.NumOrder(IdCus(i), Format(D11.Value, "yyyy-MM-dd 00:00:00"), Format(D12.Value, "yyyy-MM-dd 23:59:59"))
                    If Arr(3) <> String.Empty Then
                        DGVCus.Rows.Add(i + 1, DtCus.Rows(i).Item("Name").ToString, DtCus.Rows(i).Item("Address").ToString, Arr(0), Arr(1), Arr(2), Arr(3), "แก้ไข")
                    End If
                Else
                    Arr = BLL_Customer.NumOrder(IdCus(i))
                    DGVCus.Rows.Add(i + 1, DtCus.Rows(i).Item("Name").ToString, DtCus.Rows(i).Item("Address").ToString, Arr(0), Arr(1), Arr(2), Arr(3), "แก้ไข")
                End If


            Next
        Catch ex As Exception

        End Try

    End Sub


    'Public Sub DGVAddRowOrder(ByVal DtOrder As DataTable)
    '    Dim BLL_Customer As BLL_Customer = New BLL_Customer
    '    DGVOrder1.Rows.Clear()
    '    For i As Integer = 0 To DtOrder.Rows.Count - 1
    '        DGVOrder1.Rows.Add(DtOrder.Rows(i).Item("IdOrder").ToString, DtOrder.Rows(i).Item("CreateDate").ToString, DtOrder.Rows(i).Item("Status").ToString, DtOrder.Rows(i).Item("Price").ToString)
    '    Next
    'End Sub

    Public Sub DGVAddRowOrder(ByVal DtOrder As DataTable)
        Try
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            DGVOrder.Rows.Clear()
            For i As Integer = 0 To DtOrder.Rows.Count - 1
                DGVOrder.Rows.Add(DtOrder.Rows(i).Item("IdOrder").ToString, DtOrder.Rows(i).Item("CreateDate").ToString, DtOrder.Rows(i).Item("Status").ToString, DtOrder.Rows(i).Item("Price").ToString)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles cbSearch.KeyUp
        lbSearch_Click(sender, e)
    End Sub

    'Private Sub cbSearch_TextChanged(sender As Object, e As EventArgs) Handles cbSearch.TextChanged
    '    If cbSearch.SelectedIndex < 0 Then

    '        cbSearch.Text = "Please, select any value"

    '    Else
    '        cbSearch.Text = cbSearch.SelectedText
    '    End If
    'End Sub

    Private Sub btSEmp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSEmp1.Click 'ข้อมูลลูกค้า
        Try
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            Dim DtCus As DataTable = BLL_Customer.SelectCustomer("ALL")
            StatusSearch = True
            DGVAddRowCus(DtCus)
            StatusSearch = False
            cbSearch.Items.Clear()
            For i As Integer = 0 To DtCus.Rows.Count - 1
                cbSearch.Items.Add(DtCus.Rows(i).Item("Name").ToString)
            Next
            'Dim DtOrder As DataTable = BLL_Customer.SelectOrder(Format(D11.Value, "yyyy-MM-dd 00:00:00"), Format(D12.Value, "yyyy-MM-dd 23:59:59"))
            'DGVAddRowOrder(DtOrder)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btEmp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEmp2.Click
        Try
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            Dim DtCus As DataTable = BLL_Customer.SelectCustomer("ALL")
            DGVAddRowCus(DtCus)
            cbSearch.Items.Clear()
            For i As Integer = 0 To DtCus.Rows.Count - 1
                cbs.Items.Add(DtCus.Rows(i).Item("Name").ToString)
            Next
            Dim DtOrder As DataTable = BLL_Customer.SelectOrder(Format(D21.Value, "yyyy-MM-dd 00:00:00"), Format(D22.Value, "yyyy-MM-dd 23:59:59"))
            DGVAddRowOrder(DtOrder)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbs.Click
        Dim BLL_Customer As BLL_Customer = New BLL_Customer
        Dim DtCus As DataTable = BLL_Customer.SelectCustomer(cbs.Text)
        DGVAddRowCus(DtCus)
    End Sub

    Private Sub btDEx_CM_Click(sender As Object, e As EventArgs) Handles btDEx_CM.Click
        Try
            If DGVCus.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\Ex_Customer.xlsx"
                FileCopy(Application.StartupPath & "\Doc\Ex_Cus.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DGVCus.RowCount - 1, DGVCus.ColumnCount - 1) As String
                For i As Integer = 0 To DGVCus.RowCount - 1
                    For j As Integer = 0 To DGVCus.ColumnCount - 1
                        Arr(i, j) = DGVCus.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.WriteEx_Customer(Path, "Sheet1", Arr, DGVCus.RowCount - 1, DGVCus.ColumnCount - 1)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\Ex_Customer.xlsx")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

    Private Sub btEx_order_Click(sender As Object, e As EventArgs) Handles btEx_order.Click
        Try
            If DGVOrder.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\Ex_OrderCustomer.xlsx"
                FileCopy(Application.StartupPath & "\Doc\Ex_Order.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DGVOrder.RowCount - 1, DGVOrder.ColumnCount - 1) As String
                For i As Integer = 0 To DGVOrder.RowCount - 1
                    For j As Integer = 0 To DGVOrder.ColumnCount - 1
                        Arr(i, j) = DGVOrder.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.WriteEx_Order(Path, "Sheet1", Arr, DGVOrder.RowCount - 1, DGVOrder.ColumnCount - 1)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\Ex_OrderCustomer.xlsx")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

    Private Sub cbs_KeyUp(sender As Object, e As KeyEventArgs) Handles cbs.KeyUp
        Try
            lbSearch_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

End Class