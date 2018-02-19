Imports BLL
Imports Utility
Imports System.IO

Public Class frm_Customer
    Dim PathFile As String
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            If MsgBox("ต้องการบันทึกข้อมูลใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                If Not String.IsNullOrEmpty(tbName.Text) And Not String.IsNullOrEmpty(tbAddress.Text) And Not String.IsNullOrEmpty(tbTranspot.Text) _
                    And Not String.IsNullOrEmpty(tbTel.Text) And Not String.IsNullOrEmpty(tbCountry.Text) And Not String.IsNullOrEmpty(tbZipCode.Text) Then
                    Dim BLL_Customer As BLL_Customer = New BLL_Customer
                    Dim BLL_Extra As BLL_Extra = New BLL_Extra
                    Dim DtCus As DataTable = BLL_Customer.SelectCustomer(tbName.Text)
                    If DtCus.Rows.Count > 0 Then
                        MsgBox("มีลูกค้านี้แล้วกรุณาตรวจสอบข้อมูล", MsgBoxStyle.Information, "Information")
                    Else
                        Dim PathCopy As String = String.Empty
                        Dim FileName As String = String.Empty
                        If PathFile <> String.Empty Then
                            Dim FileLast() As String = PathFile.Split(".")
                            Dim LastCustomer As Integer = BLL_Customer.SelectLastCustomer()
                            FileName = "\PicCustomer\" & BLL_Extra.EncoderMD5(LastCustomer) & "." & FileLast(FileLast.Length - 1)
                            PathCopy = Application.StartupPath & FileName
                        End If
                        If BLL_Customer.InsertCustomer(tbName.Text, tbAddress.Text, tbTranspot.Text, tbTel.Text, tbCountry.Text, tbZipCode.Text, tbEmail.Text, FileName, cbGroup.Text) Then
                            If PathCopy <> String.Empty Then
                                FileCopy(PathFile, PathCopy)
                            End If
                            ClearData()
                            MsgBox("ข้อมูลถูกบันทึกแล้ว", MsgBoxStyle.Information, "Information")
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                Else
                    MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frm_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PathFile = String.Empty
            ClearData()
            Dim BLL_Customer As BLL_Customer = New BLL_Customer
            Dim BLL_Extra As BLL_Extra = New BLL_Extra
            If BLL_Extra.Status() = "Edit" Then
                BLL_Extra.SendStatus(String.Empty)
                Dim DtCus As DataTable = BLL_Customer.SelectIdCustomer()
                If DtCus.Rows.Count > 0 Then
                    tbName.Text = DtCus.Rows(0).Item("Name").ToString
                    tbAddress.Text = DtCus.Rows(0).Item("Address").ToString
                    tbTranspot.Text = DtCus.Rows(0).Item("Transpot").ToString
                    If tbTranspot.Text = String.Empty Then
                        tbTranspot.Text = tbAddress.Text
                    End If
                    tbTel.Text = DtCus.Rows(0).Item("Tel").ToString
                    tbCountry.Text = DtCus.Rows(0).Item("Country").ToString
                    tbZipCode.Text = DtCus.Rows(0).Item("ZipCode").ToString
                    tbEmail.Text = DtCus.Rows(0).Item("Email").ToString
                    PathFile = DtCus.Rows(0).Item("PathPicture").ToString
                    cbGroup.Text = DtCus.Rows(0).Item("GroupCus").ToString
                    If PathFile <> String.Empty Then
                        Dim fs As System.IO.FileStream
                        fs = New System.IO.FileStream(Application.StartupPath & "\" & PathFile, IO.FileMode.Open, IO.FileAccess.Read)
                        PicCustomer.Image = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                    End If

                End If
                btSave.Enabled = False
                btEdit.Enabled = True
                btClear.Enabled = False
            Else
                btSave.Enabled = True
                btEdit.Enabled = False
                btClear.Enabled = True
            End If
            cbGroup.Items.Clear()
            Dim BLL_Add_Bill As BLL_BIll = New BLL_BIll
            Dim DtBill As DataTable = BLL_Add_Bill.SelectListBill("ประเภทลูกค้า")
            For i As Integer = 0 To DtBill.Rows.Count - 1
                cbGroup.Items.Add(DtBill.Rows(i).Item("ListData"))
            Next
        Catch ex As Exception

        End Try


    End Sub

    Private Sub PicCustomer_DoubleClick(sender As Object, e As EventArgs) Handles PicCustomer.DoubleClick
        Try
            Dim result As DialogResult = OFD.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                PathFile = OFD.FileName
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(PathFile, IO.FileMode.Open, IO.FileAccess.Read)
                PicCustomer.Image = System.Drawing.Image.FromStream(fs)
                fs.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ClearData()
        Try
            tbName.Text = String.Empty
            tbAddress.Text = String.Empty
            tbTranspot.Text = String.Empty
            tbTel.Text = String.Empty
            tbCountry.Text = String.Empty
            tbZipCode.Text = String.Empty
            tbEmail.Text = String.Empty
            PicCustomer.Image = Nothing
            PathFile = String.Empty
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        ClearData()
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Try
            If MsgBox("ต้องการแก้ไขข้อมูลใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                If Not String.IsNullOrEmpty(tbName.Text) And Not String.IsNullOrEmpty(tbAddress.Text) And Not String.IsNullOrEmpty(tbTranspot.Text) _
                    And Not String.IsNullOrEmpty(tbTel.Text) And Not String.IsNullOrEmpty(tbCountry.Text) And Not String.IsNullOrEmpty(tbZipCode.Text) Then
                    Dim BLL_Customer As BLL_Customer = New BLL_Customer
                    Dim DtCus As DataTable = BLL_Customer.SelectIdCustomer()
                    If DtCus.Rows.Count > 0 Then
                        Dim PathCopy As String = DtCus.Rows(0).Item("PathPicture")
                        If PathFile <> PathCopy Then
                            If PathCopy = String.Empty Then
                                Dim BLL_Extra As BLL_Extra = New BLL_Extra
                                Dim FileLast() As String = PathFile.Split(".")
                                Dim LastCustomer As Integer = BLL_Customer.SelectLastCustomer()
                                PathCopy = "\PicCustomer\" & BLL_Extra.EncoderMD5(LastCustomer) & "." & FileLast(FileLast.Length - 1)
                            End If
                        End If
                        If BLL_Customer.UpdateCustomer(tbName.Text, tbAddress.Text, tbTranspot.Text, tbTel.Text, tbCountry.Text, tbZipCode.Text, tbEmail.Text, PathCopy, cbGroup.Text) Then
                            Try
                                FileCopy(PathFile, Application.StartupPath & PathCopy)
                            Catch ex As Exception

                            End Try

                            ClearData()
                            MsgBox("ข้อมูลถูกแก้ไขแล้ว", MsgBoxStyle.Information, "Information")
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        Else
                            MsgBox("ข้อมูลแก้ไขไม่สำเร็จ", MsgBoxStyle.Information, "Information")
                        End If
                    Else
                        MsgBox("ไม่มีข้อมูลนี้", MsgBoxStyle.Information, "Information")
                    End If
                Else
                    MsgBox("กรุณากรอกข้อมูลให้ครบถ้วน", MsgBoxStyle.Information, "Information")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        If MsgBox("ต้องการลบข้อมูลใช่มั้ย ?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
            If Not String.IsNullOrEmpty(tbName.Text) And Not String.IsNullOrEmpty(tbAddress.Text) And Not String.IsNullOrEmpty(tbTranspot.Text) _
                And Not String.IsNullOrEmpty(tbTel.Text) And Not String.IsNullOrEmpty(tbCountry.Text) And Not String.IsNullOrEmpty(tbZipCode.Text) Then
                Dim BLL_Customer As BLL_Customer = New BLL_Customer
                Dim DtCus As DataTable = BLL_Customer.SelectIdCustomer()
                If DtCus.Rows.Count > 0 Then
                    ClearData()
                    'Dim PathFile As String = DtCus.Rows(0).Item("PathPicture")
                    If BLL_Customer.DeleteCustomer() Then
                        If PathFile <> String.Empty Then
                            File.Delete(Application.StartupPath & PathFile)
                        End If
                        MsgBox("ข้อมูลถูกลบแล้ว", MsgBoxStyle.Exclamation, "Exclamation")
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        MsgBox("ข้อมูลลบไม่สำเร็จ", MsgBoxStyle.Exclamation, "Exclamation")
                    End If
                Else
                    MsgBox("ไม่มีข้อมูลนี้", MsgBoxStyle.Information, "Information")
                End If
            Else
                MsgBox("ไม่มีข้อมูลผู้ใช้นี้", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

End Class