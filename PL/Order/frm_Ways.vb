Imports BLL
Public Class frm_Ways
    Dim Dt As DataTable
    Dim SPage As Integer = 0
    Private Sub frm_Ways_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DGVTotal.Rows.Clear()
            DGVS1.Rows.Clear()
            DGVS2.Rows.Clear()
            Dim BLL_Order As BLL_Order = New BLL_Order
            If SPage = 0 Then
                Dt = BLL_Order.SelectOrder()
            ElseIf SPage = 1 Then
                CHeaders1()
                DSize1()
                Dt = BLL_Order.SelectOrder(Format(D11.Value, "yyyy-MM-dd 00:00:00"), Format(D12.Value, "yyyy-MM-dd 23:59:59"))
            ElseIf SPage = 2 Then
                CHeaders2()
                DSize2()
                Dt = BLL_Order.SelectOrder(Format(D21.Value, "yyyy-MM-dd 00:00:00"), Format(D22.Value, "yyyy-MM-dd 23:59:59"))
            ElseIf SPage = 3 Then
                CHeaders3()
                DSize3()
                Dt = BLL_Order.SelectOrder(Format(D31.Value, "yyyy-MM-dd 00:00:00"), Format(D32.Value, "yyyy-MM-dd 23:59:59"))
            End If
            For i As Integer = 0 To Dt.Rows.Count - 1
                Dim NameCus As String = BLL_Order.SelectNameCus(CInt(Dt.Rows(i).Item("IdCustomer").ToString))
                DGVTotal.Rows.Add(Dt.Rows(i).Item("IdOrder").ToString, Dt.Rows(i).Item("Price").ToString, Dt.Rows(i).Item("Status").ToString, Dt.Rows(i).Item("Transport").ToString,
                                  NameCus, Dt.Rows(i).Item("StatusTransport").ToString, Dt.Rows(i).Item("CreateDate").ToString, "Confirm", "ลบข้อมูล")
            Next
            lbTotal.Text = Dt.Rows.Count
            Dim RS1() As DataRow = Dt.Select("Status = 'สั่งจอง'")
            For i As Integer = 0 To RS1.Count - 1
                Dim NameCus As String = BLL_Order.SelectNameCus(CInt(RS1(i).Item("IdCustomer").ToString))
                DGVS1.Rows.Add(RS1(i).Item("IdOrder").ToString, RS1(i).Item("Price").ToString, RS1(i).Item("Status").ToString, RS1(i).Item("Transport").ToString, NameCus,
                               RS1(i).Item("StatusTransport").ToString, Dt.Rows(i).Item("CreateDate").ToString, "Confirm", "ลบข้อมูล")
            Next
            lbS1.Text = RS1.Count
            Dim RS2() As DataRow = Dt.Select("Status = 'จ่ายแล้ว'")
            For i As Integer = 0 To RS2.Count - 1
                Dim NameCus As String = BLL_Order.SelectNameCus(CInt(RS2(i).Item("IdCustomer").ToString))
                DGVS2.Rows.Add(RS2(i).Item("IdOrder").ToString, RS2(i).Item("Price").ToString, RS2(i).Item("Status").ToString, RS2(i).Item("Transport").ToString, NameCus,
                               RS2(i).Item("StatusTransport").ToString, Dt.Rows(i).Item("CreateDate").ToString, "Confirm", "ลบข้อมูล")
            Next
            lbS2.Text = RS2.Count
            CHeaders1()
            CHeaders2()
            CHeaders3()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CHeaders1()
        DGVTotal.EnableHeadersVisualStyles = False
        DGVTotal.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGVTotal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize1()
        DGVTotal.Columns("cIdOrder").Width = 70
        DGVTotal.Columns("cPrice").Width = 25
        DGVTotal.Columns("cStatus").Width = 25
        DGVTotal.Columns("cAddress").Width = 120
        DGVTotal.Columns("cNameCus").Width = 60
        DGVTotal.Columns("cTransport").Width = 30
        DGVTotal.Columns("cDateOrder1").Width = 60
        DGVTotal.Columns("cSee").Width = 30
        DGVTotal.Columns("cDel1").Width = 70

    End Sub

    Private Sub CHeaders2()
        DGVS1.EnableHeadersVisualStyles = False
        DGVS1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGVS1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize2()
        DGVS1.Columns("D1").Width = 70
        DGVS1.Columns("D2").Width = 25
        DGVS1.Columns("D3").Width = 25
        DGVS1.Columns("D4").Width = 120
        DGVS1.Columns("D5").Width = 60
        DGVS1.Columns("D6").Width = 30
        DGVS1.Columns("Column6").Width = 60
        DGVS1.Columns("cSeeS1").Width = 30
        DGVS1.Columns("Column3").Width = 70
    End Sub

    Private Sub CHeaders3()
        DGVS2.EnableHeadersVisualStyles = False
        DGVS2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGVS2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize3()
        DGVS2.Columns("DataGridViewTextBoxColumn7").Width = 70
        DGVS2.Columns("DataGridViewTextBoxColumn8").Width = 25
        DGVS2.Columns("DataGridViewTextBoxColumn9").Width = 25
        DGVS2.Columns("DataGridViewTextBoxColumn10").Width = 120
        DGVS2.Columns("DataGridViewTextBoxColumn11").Width = 60
        DGVS2.Columns("DataGridViewTextBoxColumn12").Width = 30
        DGVS2.Columns("Column5").Width = 60
        DGVS2.Columns("cSeeS2").Width = 30
        DGVS2.Columns("cDel").Width = 70
    End Sub

    Private Sub DGVTotal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTotal.CellContentClick
        Try
            'Dim senderGrid = DirectCast(sender, DataGridView)
            'If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            '    Dim BLL_Extra As BLL_Extra = New BLL_Extra
            '    BLL_Extra.SendIdOrder(DGVTotal.Rows(e.RowIndex).Cells("cIdOrder").Value)
            '    Dim frm As frm_confirm = New frm_confirm
            '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '        frm_Ways_Load(sender, e)
            '    End If
            'End If
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If e.ColumnIndex = 7 Then
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    BLL_Extra.SendIdOrder(DGVTotal.Rows(e.RowIndex).Cells(0).Value)
                    Dim frm As frm_confirm = New frm_confirm
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        frm_Ways_Load(sender, e)
                    End If
                ElseIf e.ColumnIndex = 8 Then
                    Dim BLL_Order As BLL_Order = New BLL_Order
                    If MsgBox("ต้องการลบใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                        If BLL_Order.DelOrder(DGVTotal.Rows(e.RowIndex).Cells(0).Value) Then
                            MsgBox("ลบสำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                            frm_Ways_Load(sender, e)
                        Else
                            MsgBox("ลบไม่สำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGVS1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVS1.CellContentClick
        Try
            'Dim senderGrid = DirectCast(sender, DataGridView)
            'If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            '    Dim BLL_Extra As BLL_Extra = New BLL_Extra
            '    BLL_Extra.SendIdOrder(DGVS1.Rows(e.RowIndex).Cells(0).Value)
            '    Dim frm As frm_confirm = New frm_confirm
            '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '        frm_Ways_Load(sender, e)
            '    End If
            'End If
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If e.ColumnIndex = 7 Then
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    BLL_Extra.SendIdOrder(DGVS1.Rows(e.RowIndex).Cells(0).Value)
                    Dim frm As frm_confirm = New frm_confirm
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        frm_Ways_Load(sender, e)
                    End If
                ElseIf e.ColumnIndex = 8 Then
                    Dim BLL_Order As BLL_Order = New BLL_Order
                    If MsgBox("ต้องการลบใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                        If BLL_Order.DelOrder(DGVS1.Rows(e.RowIndex).Cells(0).Value) Then
                            MsgBox("ลบสำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                            frm_Ways_Load(sender, e)
                        Else
                            MsgBox("ลบไม่สำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DGVS2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVS2.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If e.ColumnIndex = 7 Then
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    BLL_Extra.SendIdOrder(DGVS2.Rows(e.RowIndex).Cells(0).Value)
                    Dim frm As frm_confirm = New frm_confirm
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        frm_Ways_Load(sender, e)
                    End If
                ElseIf e.ColumnIndex = 8 Then
                    Dim BLL_Order As BLL_Order = New BLL_Order
                    If MsgBox("ต้องการลบใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                        If BLL_Order.DelOrder(DGVS2.Rows(e.RowIndex).Cells(0).Value) Then
                            MsgBox("ลบสำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                            frm_Ways_Load(sender, e)
                        Else
                            MsgBox("ลบไม่สำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lbSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearch1.Click
        Try
            DGVTotal.Rows.Clear()
            Dim BLL_Order As BLL_Order = New BLL_Order
            Dim IdCus As DataTable = BLL_Order.SelectIdCus(tbSearch1.Text)
            For m As Integer = 0 To IdCus.Rows.Count - 1
                Dim RS2() As DataRow = Dt.Select("IdCustomer = '" & IdCus.Rows(m).Item("IdCustomer") & "'")
                For i As Integer = 0 To RS2.Count - 1
                    Dim NameCus As String = BLL_Order.SelectNameCus(CInt(RS2(i).Item("IdCustomer").ToString))
                    DGVTotal.Rows.Add(RS2(i).Item("IdOrder").ToString, RS2(i).Item("Price").ToString, RS2(i).Item("Status").ToString, RS2(i).Item("Transport").ToString, NameCus, RS2(i).Item("StatusTransport").ToString, "Confirm", "ลบข้อมูล")
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearch2.Click
        Try
            DGVS1.Rows.Clear()
            Dim BLL_Order As BLL_Order = New BLL_Order
            Dim IdCus As DataTable = BLL_Order.SelectIdCus(tbSearch2.Text)
            For m As Integer = 0 To IdCus.Rows.Count - 1
                Dim RS2() As DataRow = Dt.Select("IdCustomer = '" & IdCus.Rows(m).Item("IdCustomer") & "' AND Status = 'สั่งจอง'")
                For i As Integer = 0 To RS2.Count - 1
                    Dim NameCus As String = BLL_Order.SelectNameCus(CInt(RS2(i).Item("IdCustomer").ToString))
                    DGVS1.Rows.Add(RS2(i).Item("IdOrder").ToString, RS2(i).Item("Price").ToString, RS2(i).Item("Status").ToString, RS2(i).Item("Transport").ToString, NameCus, RS2(i).Item("StatusTransport").ToString, "Confirm", "ลบข้อมูล")
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lbSearch3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearch3.Click
        Try
            DGVS2.Rows.Clear()
            Dim BLL_Order As BLL_Order = New BLL_Order
            Dim IdCus As DataTable = BLL_Order.SelectIdCus(tbSearch3.Text)
            For m As Integer = 0 To IdCus.Rows.Count - 1
                Dim RS2() As DataRow = Dt.Select("IdCustomer = '" & IdCus.Rows(m).Item("IdCustomer") & "' AND Status = 'จ่ายแล้ว'")
                For i As Integer = 0 To RS2.Count - 1
                    Dim NameCus As String = BLL_Order.SelectNameCus(CInt(RS2(i).Item("IdCustomer").ToString))
                    DGVS2.Rows.Add(RS2(i).Item("IdOrder").ToString, RS2(i).Item("Price").ToString, RS2(i).Item("Status").ToString, RS2(i).Item("Transport").ToString, NameCus, RS2(i).Item("StatusTransport").ToString, "Confirm", "ลบข้อมูล")
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btExport_Click(sender As Object, e As EventArgs) Handles btExport.Click
        Try
            If DGVTotal.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\totalreal.xlsx"
                FileCopy(Application.StartupPath & "\Doc\total.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DGVTotal.RowCount - 1, DGVTotal.ColumnCount - 2) As String
                For i As Integer = 0 To DGVTotal.RowCount - 1
                    For j As Integer = 0 To DGVTotal.ColumnCount - 2
                        Arr(i, j) = DGVTotal.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.WriteStock(Path, "Sheet1", Arr, DGVTotal.RowCount - 1, DGVTotal.ColumnCount - 2)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\totalreal.xlsx")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

    Private Sub tbSearch1_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch1.KeyUp
        lbSearch1_Click(sender, e)
    End Sub

    Private Sub tbSearch2_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch2.KeyUp
        lbSearch2_Click(sender, e)
    End Sub

    Private Sub tbSearch3_KeyUp(sender As Object, e As KeyEventArgs) Handles tbSearch3.KeyUp
        lbSearch3_Click(sender, e)
    End Sub

    Private Sub btSDate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSDate1.Click
        SPage = 1
        frm_Ways_Load(sender, e)
    End Sub

    Private Sub btSDate3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSDate3.Click
        SPage = 3
        frm_Ways_Load(sender, e)
    End Sub

    Private Sub btSDate2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSDate2.Click
        SPage = 2
        frm_Ways_Load(sender, e)
    End Sub

    Private Sub btEx_piad_Click(sender As Object, e As EventArgs) Handles btEx_piad.Click
        Try
            If DGVS2.Rows.Count > 0 Then
                Dim Path As String = Application.StartupPath & "\Doc\Ex_PaidCus.xlsx"
                FileCopy(Application.StartupPath & "\Doc\Ex_Paid.xlsx", Path)
                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                Dim Arr(DGVS2.RowCount - 1, DGVS2.ColumnCount - 2) As String
                For i As Integer = 0 To DGVS2.RowCount - 1
                    For j As Integer = 0 To DGVS2.ColumnCount - 2
                        Arr(i, j) = DGVS2.Rows(i).Cells(j).Value
                    Next
                Next
                BLL_Extra.WriteStock(Path, "Sheet1", Arr, DGVS2.RowCount - 1, DGVS2.ColumnCount - 2)
                BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\Ex_PaidCus.xlsx")
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

End Class