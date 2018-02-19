Imports BLL
Imports Utility
Imports DAL
Public Class BLL_Dashboard : Inherits Globalvariable
    Public Function SearchProduct(ByVal IdCategory As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdCategory = '" & IdCategory & "' ORDER BY NameProduct ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SearchCategory(ByVal IdCategory As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = String.Empty
        If IdCategory = "ALL" Then
            _SQL = "SELECT * FROM Category ORDER BY NameCategory ASC"
        Else
            _SQL = "SELECT * FROM Category WHERE IdCategory = '" & IdCategory & "'"
        End If
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SearchStatusProduct(ByVal Status As String, ByVal IdProduct As String) As Integer
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT SUM(Amount) as num FROM ListOrder WHERE IdOrder IN (SELECT IdOrder FROM DataOrder WHERE Status = '" & Status & "') AND IdProduct = '" & IdProduct & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return IIf(Dt.Rows(0).Item("num").ToString = String.Empty, 0, Dt.Rows(0).Item("num").ToString)
        Else
            Return 0
        End If
    End Function

    Public Function SearchSell(ByVal DateSell As DateTime) As Integer
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT SUM(Price) AS Sum FROM DataOrder WHERE DAY(CreateDate) = " & DateSell.Day & " AND MONTH(CreateDate) = " & DateSell.Month & " AND YEAR(CreateDate) = " & DateSell.Year & " AND Status = 'จ่ายแล้ว'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        Return CInt(IIf(String.IsNullOrEmpty(Dt.Rows(0).Item("Sum").ToString), 0, Dt.Rows(0).Item("Sum").ToString))
    End Function

    Public Function SearchOrder(DateSell) As Integer
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE DAY(CreateDate) = " & DateSell.Day & " AND MONTH(CreateDate) = " & DateSell.Month & " AND YEAR(CreateDate) = " & DateSell.Year & " AND Status = 'จ่ายแล้ว'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows.Count
        Else
            Return 0
        End If
    End Function

    Public Function GetOrder(ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE CreateDate BETWEEN '" & Date1.ToString("yyyy-MM-dd 00:00:00") & "' AND '" & Date2.ToString("yyyy-MM-dd 23:59:59") & "'"
        Return DB.SelectSQL(_SQL)
    End Function


    Public Function GetCus(ByVal IdCus As Integer) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Customer WHERE IdCustomer = " & IdCus
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function GetNameMenu(ByVal IdOrder As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT TOP 1 NameMenu FROM ListOrder WHERE IdOrder = '" & IdOrder & "'"
        Return DB.SelectSQL(_SQL).Rows(0).Item("NameMenu").ToString
    End Function

    Public Function GetDataGroup(ByVal GroupCus As String, ByVal Date1 As DateTime, ByVal Date2 As DateTime) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT DataOrder.CreateDate, Customer.Name, Customer.GroupCus, Customer.Address, Customer.Tel, DataOrder.IdOrder, DataOrder.Bank, DataOrder.DateBank, DataOrder.CreateDate, product.NameProduct, ListOrder.Amount, ListOrder.Price FROM ListOrder JOIN DataOrder on ListOrder.IdOrder = DataOrder.IdOrder JOIN Product ON ListOrder.IdProduct = Product.IdProduct JOIN Customer On DataOrder.IdCustomer = Customer.IdCustomer WHERE ListOrder.IdOrder IN (SELECT IdOrder FROM DataOrder WHERE IdCustomer IN (SELECT IdCustomer FROM Customer WHERE GroupCus = '" & GroupCus & "') AND DataOrder.CreateDate BETWEEN '" & Date1.ToString("yyyy-MM-dd 00:00:00") & "' AND '" & Date2.ToString("yyyy-MM-dd 23:59:59") & "')"
        Return DB.SelectSQL(_SQL)
    End Function

End Class
