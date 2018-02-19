Imports DAL
Imports Utility
Imports System.Windows.Forms
Public Class BLL_Create_Bill : Inherits Globalvariable
    Public Function SearchCategory(ByVal Tag As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = String.Empty
        If Tag = "ALL" Then
            _SQL = "SELECT * FROM Category ORDER BY NameCategory ASC"
        Else
            _SQL = "SELECT * FROM Category WHERE Tag = '" & Tag & "' ORDER BY NameCategory ASC"
        End If
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SearchProduct(ByVal IdCategory As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdCategory = '" & IdCategory & "' ORDER BY NameProduct ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SearchStatusOrder(ByVal Status As String, ByVal IdProduct As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder as a join ListOrder as b on a.IdOrder = b.IdOrder WHERE b.IdProduct = '" & IdProduct & "' AND a.Status = '" & Status & "'"
        '"SELECT * FROM DataOrder WHERE IdProduct = '" & IdProduct & "' AND Status = '" & Status & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows.Count
        Else
            Return 0
        End If
    End Function

    Public Function SearchIdCategory(ByVal IdProduct As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdProduct= '" & IdProduct & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("IdCategory").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Function SearchNameCategory(ByVal _IdCategory As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Category WHERE IdCategory = '" & _IdCategory & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("NameCategory").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Sub Product(ByVal Pro As DataTable)
        AddProduct = Pro
    End Sub

    Public Function ReProduct() As DataTable
        Return AddProduct
    End Function

    Public Sub SetDGVLesson(ByVal Dt As DataGridView)
        DGV = Dt
    End Sub

    Public Function GetDGVLesson() As DataGridView
        Return DGV
    End Function

    Public Function InsertOrder(ByVal IdOrder As String, ByVal Status As String, ByVal TypePay As String, ByVal TransportPay As Double, _
                                ByVal StatusTransport As String, ByVal Rebate As Double, ByVal Price As Double, ByVal Transport As String, ByVal Country As String, _
                                ByVal ZipCode As String, ByVal IdCustomer As Integer) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "INSERT INTO DataOrder (IdOrder, Status, TypePay, TransportPay, StatusTransport, Rebate, Price, Transport, Country, ZipCode, CreateDate, IdCustomer) "
        _SQL &= "VALUES ('" & IdOrder & "', '" & Status & "', '" & TypePay & "', " & TransportPay & ", '" & StatusTransport & "', " & Rebate & ", " & Price & ", '" & Transport & "', '" & Country & "', '" & ZipCode & "', GETDATE(), " & IdCustomer & ")"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function InsertListOrder(ByVal IdOrder As String, ByVal IdProduct As String, ByVal Amount As Integer, ByVal Price As Double, ByVal Menu As String, ByVal Free As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "INSERT INTO ListOrder (IdOrder, IdProduct, Amount, Price, NameMenu, StatusFree) VALUES ('" & IdOrder & "', '" & IdProduct & "', " & Amount & ", " & Price & ", '" & Menu & "', '" & Free & "')"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function InsertLesson(ByVal IdOrder As String, ByVal DGVLesson As DataGridView) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = String.Empty
        Dim Status As Boolean = True
        For i As Integer = 0 To DGVLesson.Rows.Count - 1
            With DGVLesson.Rows(i)
                _SQL = "INSERT INTO Lesson (Lesson, LessonDate, LessonPay, IdOrder) VALUES ('" & .Cells("cLesson").Value & "', '" & .Cells("cDateLesson").Value & "', '" & .Cells("cPrice").Value & "', '" & IdOrder & "')"
                If DB.ExecuteSQL(_SQL) = False Then
                    Status = False
                    Exit For
                End If
            End With
        Next
        Return Status
    End Function

    Public Function GetMenu() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT DISTINCT NameMenu FROM Menu ORDER BY NameMenu ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectCustomer(ByVal Name As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Customer WHERE Name = '" & Name & "'"
        Return DB.SelectSQL(_SQL)
    End Function

End Class
