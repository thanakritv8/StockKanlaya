Imports DAL
Imports Utility
Imports System.Windows.Forms
Public Class BLL_Order : Inherits Globalvariable
    Public Function SelectOrder() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder ORDER BY CreateDate DESC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectOrder(ByVal D1 As String, ByVal D2 As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE CreateDate BETWEEN '" & D1 & "' AND '" & D2 & "' ORDER BY CreateDate DESC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectOrder(ByVal IdOrder As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE IdOrder = '" & IdOrder & "'"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectNameCus(ByVal IdCustomer As Integer) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT Name FROM Customer WHERE IdCustomer = " & IdCustomer
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("Name").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Function SelectIdCus(ByVal Name As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT IdCustomer FROM Customer WHERE Name LIKE '%" & Name & "%'"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectIdCustomer(ByVal IdCustomer As Integer) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Customer WHERE IdCustomer = " & IdCustomer
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectList(ByVal IdOrder As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM ListOrder WHERE IdOrder = '" & IdOrder & "'"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectIdCategory(ByVal IdProduct As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdProduct = '" & IdProduct & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("IdCategory").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Function SelectProduct(ByVal IdProduct As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdProduct = '" & IdProduct & "'"
        Return DB.SelectSQL(_SQL)

    End Function

    Public Function SelectNameCategory(ByVal IdCategory As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Category WHERE IdCategory = '" & IdCategory & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("NameCategory").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Function UpdateStatus(ByVal IdOrder As String, ByVal Status As String, ByVal Path As String, ByVal Bank As String, ByVal DateBank As DateTime) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "UPDATE DataOrder SET Status = '" & Status & "', Path = '" & Path & "', Bank = '" & Bank & "', DateBank = '" & DateBank.ToString("yyyy-MM-dd hh:mm:ss") & "' WHERE IdOrder = '" & IdOrder & "'"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function UpdateStock(ByVal DGV As DataGridView) As Boolean
        Dim DB As DB = New DB
        Dim Status As Boolean = True
        For i As Integer = 0 To DGV.RowCount - 1
            Dim Stock As Integer = CInt(DGV.Rows(i).Cells("cAmount").Value)
            Dim IdProduct As String = DGV.Rows(i).Cells("cIdProduct").Value
            Dim _SQL As String = "UPDATE Product SET Stock = Stock - " & Stock & " WHERE IdProduct = '" & IdProduct & "'"
            If Not DB.ExecuteSQL(_SQL) Then
                Status = False
                Exit For
            End If
        Next
        Return Status
    End Function

    Public Function SelectBank() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM BANK ORDER BY NameBank ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectBank(ByVal NameBank As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM BANK WHERE NameBank = '" & NameBank & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("NumBank").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Function DelOrder(ByVal IdOrder As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "DELETE FROM DataOrder WHERE IdOrder = '" & IdOrder & "'"
        If DB.ExecuteSQL(_SQL) Then
            _SQL = "DELETE FROM ListOrder WHERE IdOrder = '" & IdOrder & "'"
            Return DB.ExecuteSQL(_SQL)
        Else
            Return False
        End If
    End Function
End Class
