Imports System.Windows.Forms
Public Class Globalvariable

#Region "Config connect database"
    Private Shared ipaddress As String
    Private Shared database As String
    Private Shared username As String
    Private Shared password As String


    Public Property ip As String
        Get
            Return ipaddress
        End Get
        Set(value As String)
            ipaddress = value
        End Set
    End Property
    Public Property db As String
        Get
            Return database
        End Get
        Set(value As String)
            database = value
        End Set
    End Property
    Public Property user As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property
    Public Property pass As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property


#End Region

#Region "Customer"
    Private Shared IdCustomer As Integer
    Private Shared Status As String
    Public Property IdCus As Integer
        Get
            Return IdCustomer
        End Get
        Set(value As Integer)
            IdCustomer = value
        End Set
    End Property

    Public Property UseStatus As String
        Get
            Return Status
        End Get
        Set(value As String)
            Status = value
        End Set
    End Property
#End Region

#Region "Create Bill"
    Private Shared ArrProduct As DataTable
    Public Property AddProduct As DataTable
        Get
            Return ArrProduct
        End Get
        Set(value As DataTable)
            ArrProduct = value
        End Set
    End Property

    Private Shared DGVLesson As DataGridView
    Public Property DGV As DataGridView
        Get
            Return DGVLesson
        End Get
        Set(value As DataGridView)
            DGVLesson = value
        End Set
    End Property
#End Region

#Region "Warehouse"
    Private Shared IdProduct As String
    Public Property IdPro As String
        Get
            Return IdProduct
        End Get
        Set(value As String)
            IdProduct = value
        End Set
    End Property
#End Region

#Region "Order"
    Private Shared IdOrder As String
    Public Property Order As String
        Get
            Return IdOrder
        End Get
        Set(value As String)
            IdOrder = value
        End Set
    End Property
#End Region

End Class
