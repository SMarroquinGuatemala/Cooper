Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class clsReportes
    Private _IdReporte As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _Archivo As String
    Private _Vigente As Boolean
    Private _Codigo As String
    Private ReportDir As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\"
    Private dr As DataRow
    Private db As New DataBase.DataBase.DataBase
    Private xSql As String

    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Vigente() As Boolean
        Get
            Return _Vigente
        End Get
        Set(ByVal value As Boolean)
            _Vigente = value
        End Set
    End Property

    Public Property Archivo() As String
        Get
            Return _Archivo
        End Get
        Set(ByVal value As String)
            _Archivo = Replace(value, "|", ReportDir)
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property IdReporte() As Integer
        Get
            Return _IdReporte
        End Get
        Set(ByVal value As Integer)
            _IdReporte = value
            ConsultarReporte()
        End Set
    End Property

    Sub New()
        InicializarVariables()
    End Sub

    Sub New(xIdReporte As Integer)
        Try
            _IdReporte = xIdReporte
            ConsultarReporte()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub InicializarVariables()
        '_IdReporte = 0
        _Nombre = String.Empty
        _Descripcion = String.Empty
        _Archivo = String.Empty
        _Vigente = False
        _Codigo = False
        xSql = String.Empty
    End Sub

    Sub ConsultarReporte()
        Try
            If IdReporte > 0 Then
                InicializarVariables()
                dr = db.ConsultarFilaTabla("Exec DbCooperativa.dbo.UpS_Reportes " & IdReporte)
                If Not F_Null(dr) Then
                    Nombre = dr("Nombre").ToString
                    Descripcion = dr("Descripcion").ToString
                    Archivo = dr("Archivo").ToString
                    Vigente = CBool(dr("Vigente").ToString)
                    Codigo = dr("Codigo").ToString
                Else
                    MsgBox("No se encontro el reporte " & IdReporte, vbCritical, "MensajeDeSistema")
                End If
            Else
                Vigente = False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
   


   Public Shared Function ListOfReports(ByVal List As EntityReports) As DataTable
      Try
         Return CooperativaDB.ExecuteDataSet("UPS_SecReportes", List.IdReporte, List.Nombre, List.Resumen).Tables(0)
      Catch ex As Exception
         Throw
      End Try
   End Function

End Class
