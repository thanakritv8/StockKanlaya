Imports DAL
Imports Utility
Public Class BLL_Customer : Inherits Globalvariable
    Public Function InsertCustomer(ByVal Name As String, ByVal Address As String, ByVal Transpot As String, ByVal Tel As String,
                                   ByVal Country As String, ByVal ZipCode As String, ByVal Email As String, ByVal PathPicture As String, ByVal GroupCus As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "INSERT INTO Customer (Name, Address, Transpot, Tel, Country, ZipCode, Email, PathPicture, GroupCus) VALUES "
        _SQL &= "('" & Name & "', '" & Address & "', '" & Transpot & "', '" & Tel & "', '" & Country & "', '" & ZipCode & "', '" & Email & "', '" & PathPicture & "', '" & GroupCus & "')"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function UpdateCustomer(ByVal Name As String, ByVal Address As String, ByVal Transpot As String, ByVal Tel As String,
                                  ByVal Country As String, ByVal ZipCode As String, ByVal Email As String, ByVal PathPicture As String, ByVal GroupCus As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "UPDATE Customer SET Name = '" & Name & "', Address = '" & Address & "', Transpot = '" & Transpot & "', Tel = '" & Tel & "',"
        _SQL &= " Country = '" & Country & "', ZipCode = '" & ZipCode & "', Email = '" & Email & "', PathPicture = '" & PathPicture & "', GroupCus = '" & GroupCus & "' WHERE IdCustomer = " & IdCus
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function DeleteCustomer() As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "DELETE FROM Customer WHERE IdCustomer = " & IdCus
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function SelectCustomer(ByVal Name As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = String.Empty
        If Name = "ALL" Then
            _SQL = "SELECT * FROM Customer ORDER BY Name ASC"
        Else
            _SQL = "SELECT * FROM Customer WHERE Name LIKE '%" & Name & "%'"
        End If
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectCustomer(ByVal D1 As String, ByVal D2 As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Customer WHERE CreateDate BETWEEN '" & D1 & "' AND '" & D2 & "'"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectIdCustomer() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Customer WHERE IdCustomer = " & IdCus
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function NumOrder(ByVal IdCustomer As Integer) As String()
        Dim Arr() As String = {0, 0, 0, ""}
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE IdCustomer = " & IdCustomer & " ORDER BY CreateDate DESC"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Arr(0) = Dt.Rows.Count  'จำนวน Order ที่เคยสั่ง
            Arr(1) = Dt.Rows(0).Item("IdOrder") 'Order ที่สั่งล่าสุด
            Arr(2) = Dt.Compute("SUM(Price)", "IdCustomer = " & IdCustomer)
            Arr(3) = Dt.Rows(0).Item("CreateDate").ToString
        End If
        Return Arr
    End Function

    Public Function NumOrder(ByVal IdCustomer As Integer, ByVal D1 As String, ByVal D2 As String) As String()
        Dim Arr() As String = {0, 0, 0, ""}
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE IdCustomer = " & IdCustomer & " AND CreateDate BETWEEN '" & D1 & "' AND '" & D2 & "' ORDER BY CreateDate DESC"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Arr(0) = Dt.Rows.Count  'จำนวน Order ที่เคยสั่ง
            Arr(1) = Dt.Rows(0).Item("IdOrder") 'Order ที่สั่งล่าสุด
            Arr(2) = Dt.Compute("SUM(Price)", "IdCustomer = " & IdCustomer)
            Arr(3) = Dt.Rows(0).Item("CreateDate").ToString
        End If
        Return Arr
    End Function

    Public Function SelectOrder() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder ORDER BY CreateDate DESC"
        Return DB.SelectSQL(_SQL)
    End Function

    'Public Function SelectCutomer(ByVal D1 As String, ByVal D2 As String) As DataTable
    '    Dim DB As DB = New DB
    '    Dim _SQL As String = "SELECT * FROM Customer WHERE CreateDate BETWEEN '" & D1 & "' AND '" & D2 & "' ORDER BY CreateDate DESC "
    '    Return DB.SelectSQL(_SQL)
    'End Function


    Public Function SelectOrder(ByVal D1 As String, ByVal D2 As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM DataOrder WHERE CreateDate BETWEEN '" & D1 & "' AND '" & D2 & "' ORDER BY CreateDate DESC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SelectLastCustomer() As Integer
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Customer ORDER BY IdCustomer DESC"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("IdCustomer")
        Else
            Return 0
        End If
    End Function

    Public Sub SendIdCus(ByVal _Data As String)
        IdCus = _Data
    End Sub

    Public Function SelectBank() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM BANK ORDER BY NameBank ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function InsertBank(ByVal Bank As String, ByVal Name As String, ByVal Num As String, ByVal Branch As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "INSERT INTO BANK (NameBank, NumBank, Name, Branch) VALUES ('" & Bank & "', '" & Num & "', '" & Name & "', '" & Branch & "')"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function UpdateBank(ByVal IdBank As Integer, ByVal Bank As String, ByVal Name As String, ByVal Num As String, ByVal Branch As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "UPDATE BANK SET NameBank = '" & Bank & "', NumBank = '" & Num & "', Name = '" & Name & "', Branch = '" & Branch & "' WHERE IdBank = " & IdBank
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function DelBank(ByVal IdBank As Integer) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "DELETE FROM BANK WHERE IdBank = " & IdBank
        Return DB.ExecuteSQL(_SQL)
    End Function
End Class
