Imports Utility
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Text
Imports System.Security.Cryptography

Public Class BLL_Extra : Inherits Globalvariable

    Public Sub ConfigDataBase(ByVal _Path As String)
        Dim gv As Globalvariable = New Globalvariable
        Dim sr As StreamReader = New StreamReader(_Path)
        Dim line() As String = Split(sr.ReadToEnd, vbNewLine)
        For row As Integer = 0 To line.Length - 1
            If line(row) = "[ip]" Then
                gv.ip = line(row + 1)
            ElseIf line(row) = "[db]" Then
                gv.db = line(row + 1)
            ElseIf line(row) = "[user]" Then
                gv.user = line(row + 1)
            ElseIf line(row) = "[pass]" Then
                gv.pass = line(row + 1)
            End If
        Next
    End Sub

    Public Sub OpenExcel(ByVal _Path As String)
        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook
        wb = excel.Workbooks.Open(_Path) 'error is here
        excel.Visible = True
        wb.Activate()
    End Sub

    Public Function ReadExcel(ByVal _Path As String, ByVal _row As Integer, ByVal _col As Integer, ByVal Sheet As String) As String
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        Dim r As Range = s.UsedRange
        Dim array(,) As Object = r.Value(XlRangeValueDataType.xlRangeValueDefault)
        w.Close()
        If array IsNot Nothing Then
            Return array(_row, _col)
        Else
            Return String.Empty
        End If
    End Function

    Public Sub WriteExcel(ByVal _Path As String, ByVal _row() As Integer, ByVal _col() As Integer, ByVal Sheet As String, ByVal _data() As String, ByVal Arr(,) As String, ByVal r As Integer, ByVal c As Integer, ByVal Rebate As String, ByVal _Total As String)
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        Dim _Bank As String = String.Empty
        For i As Integer = 0 To _row.Length - 1
            If i <> 9 Then
                s.Cells(_row(i), _col(i)).Value = _data(i)
            Else
                _Bank = _data(i)
            End If
        Next
        For i As Integer = 0 To r
            For j As Integer = 0 To c
                s.Cells(34 + i, j + 1).Value = Arr(i, j)
            Next
            s.Cells(34 + i, 7).Value = "=C" & 34 + i & "*E" & 34 + i & "-F" & 34 + i
        Next
        s.Cells(34 + r + 2, 2).Value = "ส่วนลดรวม"
        s.Cells(34 + r + 2, 6).Value = Rebate '"=SUM(F34:F" & r + 34 & ")"
        s.Cells(34 + r + 7, 2).Value = "(ราคานี้ได้รวมภาษีมูลค่าเพิ่มแล้ว) จำนวนเงินรวมทั้งเงิน"
        s.Range(s.Cells(34 + r + 7, 1), s.Cells(34 + r + 7, 6)).Merge()

        s.Range("A" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("B" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("C" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("D" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("E" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("F" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("G" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeTop).Weight = 2
        s.Range("A" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2
        s.Range("B" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2
        s.Range("C" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2
        s.Range("D" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2
        s.Range("E" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2
        s.Range("F" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2
        s.Range("G" & 34 + r + 7).Borders(XlBordersIndex.xlEdgeBottom).Weight = 2

        s.Cells(34 + r + 7, 7).Value = _Total - Rebate '"=SUM(G34:G" & r + 2 + 34 & ") - " & Rebate
        s.Cells(34 + r + 9, 2).Value = "จำนวนเงินรวมทั้งสิ้น  (ตัวอักษร)"
        s.Cells(34 + r + 9, 4).Value = "=BAHTTEXT(G" & r + 7 + 34 & ")"
        s.Range(s.Cells(34 + r + 9, 4), s.Cells(34 + r + 9, 7)).Merge()
        For i As Integer = 4 To 7
            s.Cells(34 + r + 9, i).BORDERS.Weight = 2
        Next
        s.Cells(34 + r + 11, 1).Value = "ผู้รับเงิน..............................................."
        s.Cells(34 + r + 11, 3).Value = "ผู้ชำระเงิน.............................................."
        s.Cells(34 + r + 12, 1).Value = "การชำระเงิน"
        s.Cells(34 + r + 12, 2).Value = _Bank
        w.Save()
        w.Close()
        excel.Quit()
    End Sub

    Public Sub WriteStock(ByVal _Path As String, ByVal Sheet As String, ByVal Arr(,) As String, ByVal _r As Integer, ByVal _c As Integer)
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        For i As Integer = 0 To _r
            For j As Integer = 0 To _c
                s.Cells(i + 2, j + 1).Value = Arr(i, j)
            Next
        Next
        w.Save()
        w.Close()
        excel.Quit()
    End Sub

    Public Sub Write_ExPaid(ByVal _Path As String, ByVal Sheet As String, ByVal Arr(,) As String, ByVal _r As Integer, ByVal _c As Integer)
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        For i As Integer = 0 To _r
            For j As Integer = 0 To _c
                s.Cells(i + 2, j + 1).Value = Arr(i, j)
            Next
        Next
        w.Save()
        w.Close()
        excel.Quit()
    End Sub


    Public Sub WriteEx_Customer(ByVal _Path As String, ByVal Sheet As String, ByVal Arr(,) As String, ByVal _r As Integer, ByVal _c As Integer)
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        For i As Integer = 0 To _r
            For j As Integer = 0 To _c
                s.Cells(i + 2, j + 1).Value = Arr(i, j)
            Next
        Next
        w.Save()
        w.Close()
        excel.Quit()
    End Sub


    Public Sub WriteEx_Order(ByVal _Path As String, ByVal Sheet As String, ByVal Arr(,) As String, ByVal _r As Integer, ByVal _c As Integer)
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        For i As Integer = 0 To _r
            For j As Integer = 0 To _c
                s.Cells(i + 2, j + 1).Value = Arr(i, j)
            Next
        Next
        w.Save()
        w.Close()
        excel.Quit()
    End Sub

    Public Sub Write_ExProduct(ByVal _Path As String, ByVal Sheet As String, ByVal Arr(,) As String, ByVal _r As Integer, ByVal _c As Integer)
        Dim excel As Application = New Application
        Dim w As Workbook = excel.Workbooks.Open(_Path)
        Dim s As Worksheet = w.Sheets(Sheet)
        For i As Integer = 0 To _r
            For j As Integer = 0 To _c
                s.Cells(i + 2, j + 1).Value = Arr(i, j)
            Next
        Next
        w.Save()
        w.Close()
        excel.Quit()
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Function EncoderMD5(ByVal strString As String) As String
        Dim ASCIIenc As New ASCIIEncoding
        Dim strReturn As String = String.Empty
        Dim ByteSourceText() As Byte = ASCIIenc.GetBytes(strString)
        Dim Md5Hash As New MD5CryptoServiceProvider
        Dim ByteHash() As Byte = Md5Hash.ComputeHash(ByteSourceText)
        For Each b As Byte In ByteHash
            strReturn = strReturn & b.ToString("x2")
        Next
        Return strReturn
    End Function

    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        For i As Integer = 1 To 16
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Public Function Status() As String
        Return UseStatus
    End Function

    Public Sub SendStatus(ByVal _Data As String)
        UseStatus = _Data
    End Sub

    Public Function ReadIdProduct() As String
        Return IdPro
    End Function

    Public Sub SendIdProduct(ByVal _Data As String)
        IdPro = _Data
    End Sub

    Public Function ReadIdOrder() As String
        Return Order
    End Function

    Public Sub SendIdOrder(ByVal _Data As String)
        Order = _Data
    End Sub

    Public Function CheckNum(ByVal number As String) As Boolean
        If Integer.TryParse(number, Nothing) Then
            Return True
        Else
            If number <> String.Empty Then
                If Double.TryParse(number, Nothing) Then
                    Return True
                Else
                    Return False
                End If

            Else
                Return True
            End If
            Return False
        End If
    End Function

End Class
