Imports BLL
Imports System.Windows.Forms
Public Class frm_confirm
    Dim PathFile As String
    Dim IdOrder As String
    Private Sub frm_confirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            IdOrder = BLL_Extra.ReadIdOrder
            Dim BLL_Order As BLL_Order = New BLL_Order

            Dim DtOrder As DataTable = BLL_Order.SelectOrder(IdOrder)
            Dim IdCustomer As Integer
            With DtOrder.Rows(0)
                cbTypePay.Text = .Item("TypePay").ToString
                cbTransportPay.Text = .Item("StatusTransport").ToString
                tbTypePay.Text = CDbl(Val(.Item("Price"))) - CDbl(Val(.Item("TransportPay"))) + CDbl(Val(.Item("Rebate")))
                tbTransportPay.Text = .Item("TransportPay").ToString
                tbRebate.Text = .Item("Rebate").ToString
                tbTotal.Text = .Item("Price").ToString
                IdCustomer = .Item("IdCustomer").ToString
                tbAddress.Text = .Item("Transport").ToString
                Dim DtBank As DataTable = BLL_Order.SelectBank()
                cbBank.Text = .Item("TypePay").ToString

                For i As Integer = 0 To DtBank.Rows.Count - 1
                    cbBank.Items.Add(DtBank.Rows(i).Item("NameBank").ToString)
                Next
                If .Item("Status") = "สั่งจอง" Then
                    btOK.Enabled = True
                    btDel.Enabled = True
                    cbBank.Enabled = True
                    btBrowse.Visible = True
                    lbPath.Visible = True
                    DTP1.Enabled = True
                    DTP2.Enabled = True
                    btTax.Enabled = False
                Else
                    Dim DateBank As DateTime = IIf(String.IsNullOrEmpty(.Item("DateBank").ToString), Now, .Item("DateBank").ToString)
                    DTP1.Value = DateBank
                    DTP2.Value = DateBank
                    If Not IsDBNull(.Item("Path")) Then
                        If Not String.IsNullOrEmpty(.Item("Path")) Then
                            Dim fs As System.IO.FileStream
                            fs = New System.IO.FileStream(Application.StartupPath & .Item("Path").ToString, IO.FileMode.Open, IO.FileAccess.Read)
                            Pic.Image = System.Drawing.Image.FromStream(fs)
                            fs.Close()
                        End If
                    End If

                    cbBank.Text = IIf(IsDBNull(.Item("Bank")), String.Empty, .Item("Bank"))
                    btOK.Enabled = False
                    btDel.Enabled = False
                    btBrowse.Visible = False
                    lbPath.Visible = False
                    cbBank.Enabled = False
                    DTP1.Enabled = False
                    DTP2.Enabled = False
                    btTax.Enabled = True
                End If
            End With
            Dim DtCus As DataTable = BLL_Order.SelectIdCustomer(IdCustomer)
            With DtCus.Rows(0)
                tbName.Text = .Item("Name").ToString
                tbTel.Text = .Item("Tel").ToString
                tbCountry.Text = .Item("Country").ToString
                tbZipCode.Text = .Item("ZipCode").ToString
                tbEmail.Text = .Item("Email").ToString
            End With
            Dim DtList As DataTable = BLL_Order.SelectList(IdOrder)
            For i As Integer = 0 To DtList.Rows.Count - 1
                With DtList.Rows(i)
                    Dim Dt As DataTable = BLL_Order.SelectProduct(.Item("IdProduct"))
                    Dim NameMenu As String = .Item("NameMenu").ToString
                    Dim NameProduct As String = Dt.Rows(0).Item("NameProduct").ToString
                    Dim Unit As String = Dt.Rows(0).Item("Unit").ToString
                    Dim Price_Sell As String = Dt.Rows(0).Item("Price_Sell").ToString
                    Dim IdCategory As String = BLL_Order.SelectIdCategory(.Item("IdProduct"))
                    Dim NameCategory As String = BLL_Order.SelectNameCategory(IdCategory)
                    If .Item("StatusFree").ToString = "YES" Then
                        DGV.Rows.Add(NameMenu, NameCategory & " (Free)", .Item("IdProduct"), NameProduct, .Item("Amount"), Unit, Price_Sell, .Item("Amount") * Price_Sell, .Item("Price"))
                    Else
                        DGV.Rows.Add(NameMenu, NameCategory, .Item("IdProduct"), NameProduct, .Item("Amount"), Unit, Price_Sell, "", .Item("Price"))
                    End If

                End With
            Next
            DHerders()
            DSize()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btBrowse_Click(sender As Object, e As EventArgs) Handles btBrowse.Click
        Try
            Dim result As DialogResult = OFD.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                PathFile = OFD.FileName
                lbPath.Text = PathFile
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(PathFile, IO.FileMode.Open, IO.FileAccess.Read)
                Pic.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        Try
            If MsgBox("ต้องการบันทึกจ่ายแล้ว ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Dim PathCopy As String = String.Empty
                Dim FileName As String = String.Empty
                If PathFile <> String.Empty Then
                    Dim FileLast() As String = PathFile.Split(".")
                    FileName = "\PicOrder\" & IdOrder & "." & FileLast(FileLast.Length - 1)
                    PathCopy = Application.StartupPath & FileName
                End If
                Dim myDate As DateTime = (DTP1.Value.Date + DTP2.Value.TimeOfDay).ToString("yyyy-MM-dd hh:mm:ss")
                Dim BLL_Order As BLL_Order = New BLL_Order
                If BLL_Order.UpdateStatus(IdOrder, "จ่ายแล้ว", FileName, cbBank.Text, myDate) Then
                    If BLL_Order.UpdateStock(DGV) Then
                        If PathCopy <> String.Empty Then
                            FileCopy(PathFile, PathCopy)
                        End If
                        MsgBox("ข้อมูลถูกบันทึกแล้ว", MsgBoxStyle.Information, "Information")
                        ReadTax()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        MsgBox("ข้อมูลบันทึกไม่สำเร็จ", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("ข้อมูลบันทึกไม่สำเร็จ", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try

    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        Try
            If MsgBox("ต้องการยกเลิกใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                Dim BLL_Order As BLL_Order = New BLL_Order
                If BLL_Order.UpdateStatus(IdOrder, "ยกเลิก", String.Empty, cbBank.Text, Now) Then
                    MsgBox("ข้อมูลถูกบันทึกแล้ว", MsgBoxStyle.Information, "Information")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btTax_Click(sender As Object, e As EventArgs) Handles btTax.Click
        Try
            ReadTax()
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

    Public Sub ReadTax()
        Try
            Dim Path As String = Application.StartupPath & "\Doc\taxreal.xlsx"
            FileCopy(Application.StartupPath & "\Doc\tax.xlsx", Path)
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            Dim Bank As String = String.Empty
            If cbBank.Text.Contains("เงินสด") = False And cbBank.Text.Contains("ชำระแบบเต็มจำนวน") = False Then
                Dim BLL_Order As BLL_Order = New BLL_Order
                Bank = cbBank.Text & " บัญชีเลขที่ " & BLL_Order.SelectBank(cbBank.Text)
            Else
                Bank = cbBank.Text
            End If
            Dim Str() As String = {tbName.Text, tbName.Text, tbAddress.Text, tbAddress.Text, tbTel.Text, tbZipCode.Text,
                                   IdOrder, cbTransportPay.Text, Now.ToString("yyyy-MM-dd"), Bank}
            Dim _r() As Integer = {4, 28, 6, 30, 2, 12, 15, 16, 29, 51}
            Dim _c() As Integer = {3, 2, 3, 2, 6, 6, 4, 4, 7, 5}
            BLL_Extra.WriteExcel(Path, _r, _c, "Sheet1", Str, tbRebate.Text, tbTypePay.Text, DGV)
            BLL_Extra.OpenExcel(Application.StartupPath & "\Doc\taxreal.xlsx")
        Catch ex As Exception
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("EXCEL") Then
                    prog.Kill()
                End If
            Next
        End Try
    End Sub

    Private Sub DHerders()
        DGV.EnableHeadersVisualStyles = False
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray
        DGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Private Sub DSize()
        DGV.Columns("cMenu").Width = 25
        DGV.Columns("cNameCategory").Width = 15
        DGV.Columns("cIdProduct").Width = 16
        DGV.Columns("cNameProduct").Width = 55
        DGV.Columns("cAmount").Width = 10
        DGV.Columns("cPriceUnit").Width = 12
        DGV.Columns("cRebate").Width = 10
        DGV.Columns("cPrice").Width = 60
    End Sub
End Class