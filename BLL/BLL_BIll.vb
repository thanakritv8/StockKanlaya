Imports DAL
Public Class BLL_BIll
    Public Function SelectListBill(ByVal Type As String) As DataTable
        Dim DB As DB = New DB
        Dim _SQL As String = "SELECT * FROM ListBill WHERE Type = '" & Type & "' ORDER BY idBill ASC"
        Return DB.SelectSQL(_SQL)
    End Function

    Public Function InsertListBill(ByVal ListData As String, ByVal Detail As String, ByVal Type As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "INSERT INTO ListBill (ListData, Detail, Type) VALUES ('" & ListData & "', '" & Detail & "', '" & Type & "')"
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function UpdateListBill(ByVal IdBill As Integer, ByVal ListData As String, ByVal Detail As String) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "UPDATE ListBill SET ListData = '" & ListData & "', Detail = '" & Detail & "' WHERE IdBill = " & IdBill
        Return DB.ExecuteSQL(_SQL)
    End Function

    Public Function DelListBill(ByVal IdBill As Integer) As Boolean
        Dim DB As DB = New DB
        Dim _SQL As String = "DELETE FROM ListBill WHERE IdBill = " & IdBill
        Return DB.ExecuteSQL(_SQL)
    End Function

End Class
