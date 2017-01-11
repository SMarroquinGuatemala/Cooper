Public Module modVariablesGlobales
    'Public XReport As New ReportDocument
    Private _usuario As String = String.Empty


    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Private _computadora As String = String.Empty
    Public Property Computadora As String
        Get
            Return _computadora
        End Get
        Set(value As String)
            _computadora = value
        End Set
    End Property

    Private _servidor As String = String.Empty
    Public Property Servidor As String
        Get
            Return _servidor
        End Get
        Set(value As String)
            _servidor = value
        End Set
    End Property

    Private _appName As String = String.Empty
    Public Property AppName As String
        Get
            Return _appName
        End Get
        Set(value As String)
            _appName = value
        End Set
    End Property

    Private _version As String
    Public Property Version As String
        Get
            Return _version
        End Get
        Set(value As String)
            _version = value
        End Set
    End Property

End Module
