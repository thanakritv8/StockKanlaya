Imports DAL
Imports Utility
Imports System.Windows.Forms
Public Class BLL_Warehouse : Inherits Globalvariable
    Public Function SearchProduct(ByVal IdCategory As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdCategory = '" & IdCategory & "' ORDER BY NameProduct ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SearchCategory(ByVal IdCategory As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = String.Empty
        If IdCategory = "ALL" Then
            _SQL = "SELECT * FROM Category ORDER BY IdCategory ASC"
        Else
            _SQL = "SELECT * FROM Category WHERE IdCategory = '" & IdCategory & "'"
        End If
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function SearchIdCategory(ByVal Name As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = String.Empty
        _SQL = "SELECT * FROM Category WHERE NameCategory LIKE '%" & Name & "%'"
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

    Public Function InsertWarehouse(ByVal IdCategory As String, ByVal NameCategory As String, ByVal Detail As String, ByVal Brand As String, ByVal Block As String, ByVal Position As String, ByVal Tag As String, ByVal DGV As DataGridView, ByVal Path As String)
        Dim DB As DB = New DB
        Dim StatusInsert As Boolean = True
        Dim _SQL As String = "INSERT INTO Category (IdCategory, NameCategory, Detail, Brand, Block, Position, Tag, PathPicture) VALUES ('" & IdCategory & "', '" & NameCategory & "', '" & Detail & "', '" & Brand & "', '" & Block & "', '" & Position & "', '" & Tag & "', '" & Path & "')"
        If DB.ExecuteSQL(_SQL) Then
            For i As Integer = 0 To DGV.Rows.Count - 1
                Dim IdProduct As String = DGV.Rows(i).Cells("cIdProduct").Value
                Dim NameProduct As String = DGV.Rows(i).Cells("CNameProduct").Value
                Dim Price_Buy As Double = CDbl(Val(DGV.Rows(i).Cells("cPriceBuy").Value))
                Dim Price_Sell As Double = CDbl(Val(DGV.Rows(i).Cells("cPriceSell").Value))
                Dim Stock As Integer = CInt(DGV.Rows(i).Cells("cAmount").Value)
                Dim Unit As String = DGV.Rows(i).Cells("cUnit").Value
                _SQL = "INSERT INTO Product (IdProduct, NameProduct, Price_Buy, Price_Sell, Stock, Unit, IdCategory) VALUES ('" & IdProduct & "', '" & NameProduct & "', " & Price_Buy & ", " & Price_Sell & ", " & Stock & ", '" & Unit & "', '" & IdCategory & "')"
                If DB.ExecuteSQL(_SQL) = False Then
                    StatusInsert = False
                    Exit For
                End If
            Next
        Else
            StatusInsert = False
        End If
        Return StatusInsert
    End Function

    Public Function UpdateWarehouse(ByVal IdCategory As String, ByVal NameCategory As String, ByVal Detail As String, ByVal Brand As String, ByVal Block As String, ByVal Position As String, ByVal Tag As String, ByVal DGV As DataGridView, ByVal Path As String)
        Dim DB As DB = New DB
        Dim StatusInsert As Boolean = True
        Dim _SQL As String = "UPDATE Category SET NameCategory = '" & NameCategory & "', Detail = '" & Detail & "', Brand = '" & Brand & "', Block = '" & Block & "', Position = '" & Position & "', Tag = '" & Tag & "', PathPicture = '" & Path & "' WHERE IdCategory = '" & IdCategory & "'"
        If DB.ExecuteSQL(_SQL) Then
            For i As Integer = 0 To DGV.Rows.Count - 1
                Dim IdProduct As String = DGV.Rows(i).Cells("cIdProduct").Value
                Dim NameProduct As String = DGV.Rows(i).Cells("CNameProduct").Value
                Dim Price_Buy As Double = CDbl(Val(DGV.Rows(i).Cells("cPriceBuy").Value))
                Dim Price_Sell As Double = CDbl(Val(DGV.Rows(i).Cells("cPriceSell").Value))
                Dim Stock As Integer = CInt(DGV.Rows(i).Cells("cAmount").Value)
                Dim Unit As String = DGV.Rows(i).Cells("cUnit").Value
                If CheckProduct(IdProduct) Then
                    _SQL = "UPDATE Product SET NameProduct = '" & NameProduct & "', Price_Buy = '" & Price_Buy & "', Price_Sell = '" & Price_Sell & "', Stock = " & Stock & ", Unit = '" & Unit & "' WHERE IdProduct = '" & IdProduct & "'"
                    If DB.ExecuteSQL(_SQL) = False Then
                        StatusInsert = False
                        Exit For
                    End If
                Else
                    _SQL = "INSERT INTO Product (IdProduct, NameProduct, Price_Buy, Price_Sell, Stock, Unit, IdCategory) VALUES ('" & IdProduct & "', '" & NameProduct & "', " & Price_Buy & ", " & Price_Sell & ", " & Stock & ", '" & Unit & "', '" & IdCategory & "')"
                    If DB.ExecuteSQL(_SQL) = False Then
                        StatusInsert = False
                        Exit For
                    End If
                End If
            Next
        Else
            StatusInsert = False
        End If
        Return StatusInsert
    End Function

    Private Function CheckProduct(ByVal IdProduct As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Product WHERE IdProduct = '" & IdProduct & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetIdCategory(ByVal IdProduct As String) As String
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT IdCategory FROM Product WHERE IdProduct = '" & IdProduct & "'"
        Dim Dt As DataTable = DB.SelectSQL(_SQL)
        If Dt.Rows.Count > 0 Then
            Return Dt.Rows(0).Item("IdCategory").ToString
        Else
            Return String.Empty
        End If
    End Function

    Public Function DelProduct(ByVal IdCategory As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "DELETE FROM Category WHERE IdCategory = '" & IdCategory & "'"
        If DB.ExecuteSQL(_SQL) Then
            _SQL = "DELETE FROM Product WHERE IdCategory = '" & IdCategory & "'"
            If DB.ExecuteSQL(_SQL) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function DelProducts(ByVal IdCatgory As String, ByVal DGV As DataGridView) As Boolean
        Dim DB As DB = New DB
        Dim IdProducts As String = String.Empty
        For i As Integer = 0 To DGV.Rows.Count - 1
            If i = DGV.Rows.Count - 1 Then
                IdProducts &= "'" & DGV.Rows(i).Cells("cIdProduct").Value & "'"
            Else
                IdProducts &= "'" & DGV.Rows(i).Cells("cIdProduct").Value & "', "
            End If
        Next
        Dim _SQL As String = "DELETE FROM Product WHERE IdProduct Not IN (" & IdProducts & ") AND IdCategory = '" & IdCatgory & "'"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function StatusDGV(ByVal DGV As DataGridView) As Boolean
        Dim Status As Boolean = True
        Dim Dt As DataTable = New DataTable
        Dt.Columns.Add("IdProduct")
        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Rows(i).Cells("cIdProduct").Value = String.Empty Then
                Status = False
                Exit For
            End If
            Dt.Rows.Add(DGV.Rows(i).Cells("cIdProduct").Value)
        Next

        Dim _Query = (From row In Dt.AsEnumerable _
                         Select row.Field(Of String)("IdProduct")).Distinct.ToList
        If _Query.Count < DGV.Rows.Count Then
            Status = False
        End If
        Return Status
    End Function
    
    Public Function GetMenu() As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM Menu ORDER BY NameMenu ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function InsertMenu(ByVal Name As String, ByVal Detail As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "INSERT INTO Menu (NameMenu, DetailMenu) VALUES ('" & Name & "', '" & Detail & "')"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function UpdateMenu(ByVal Id As Integer, ByVal Name As String, ByVal Detail As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "UPDATE Menu SET NameMenu = '" & Name & "', DetailMenu = '" & Detail & "' WHERE IdMenu = " & Id
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function DeleteMenu(ByVal Id As Integer) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "DELETE FROM Menu WHERE IdMenu = " & Id
        Return DB.ExecuteSQL(_SQL)
    End Function

End Class
