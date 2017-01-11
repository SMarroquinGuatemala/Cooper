
Public Class clsProveedores
    Private _Proveedor As Integer = 0
    Private _ProveedorValido As Boolean = False
    Private _Nombrelargo As String = String.Empty
    Private _NombreCorto As String = String.Empty
    Private _ActividadProveedor As String = String.Empty
    Private _NITProveedor As String = String.Empty
    Private _Direccion As String = String.Empty
    Private _Telefono1 As String = String.Empty
    Private _telefono2 As String = String.Empty
    Private _Contacto As String = String.Empty
    Private _EmailContacto As String = String.Empty
    Private _TasaRetencion As Double = 0.0
    Private _TipoRetencion As Int16 = 0
    Private _AplicaRetencion As Boolean = False
    Private _ProveedorActivo As Boolean = False
    Private _AplicaComoCliente As Boolean = False
    Private _DPI As String = String.Empty
    Private xSql As String = String.Empty

    Dim rw As DataRow

    Dim db As New DataBase.DataBase.DataBase

    Sub New()
        InicializarVariables()
    End Sub

    Public ReadOnly Property ProveedorValido As Boolean
        Get
            Return _ProveedorValido
        End Get
    End Property
    Public Property AplicaComoCliente As Boolean
        Get
            Return _AplicaComoCliente
        End Get
        Set(value As Boolean)
            _AplicaComoCliente = value
        End Set
    End Property

    Public Property ProveedorActivo As Boolean
        Get
            Return _ProveedorActivo
        End Get
        Set(value As Boolean)
            _ProveedorActivo = value
        End Set
    End Property

    Public Property AplicaRetencion As Boolean
        Get
            Return _AplicaRetencion
        End Get
        Set(value As Boolean)
            _AplicaRetencion = value
        End Set
    End Property

    Public Property TasaRetencion As Double
        Get
            Return _TasaRetencion
        End Get
        Set(value As Double)
            _TasaRetencion = value
        End Set
    End Property

    Public Property Proveedor As Integer
        Get
            Return _Proveedor
        End Get
        Set(value As Integer)
            _Proveedor = value
        End Set
    End Property

    Public Property TipoRetencion As Int16
        Get
            Return _TipoRetencion
        End Get
        Set(value As Int16)
            _TipoRetencion = value
        End Set
    End Property

    Public Property Nombrelargo As String
        Get
            Return _Nombrelargo
        End Get
        Set(value As String)
            _Nombrelargo = value
        End Set
    End Property

    Public Property NombreCorto As String
        Get
            Return _NombreCorto
        End Get
        Set(value As String)
            _NombreCorto = value
        End Set
    End Property

    Public Property ActividadProveedor As String
        Get
            Return _ActividadProveedor
        End Get
        Set(value As String)
            _ActividadProveedor = value
        End Set
    End Property

    Public Property NITProveedor As String
        Get
            Return _NITProveedor
        End Get
        Set(value As String)
            _NITProveedor = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return _Telefono1
        End Get
        Set(value As String)
            _Telefono1 = value
        End Set
    End Property

    Public Property Telefono2 As String
        Get
            Return _telefono2
        End Get
        Set(value As String)
            _telefono2 = value
        End Set
    End Property

    Public Property Contacto As String
        Get
            Return _Contacto
        End Get
        Set(value As String)
            _Contacto = value
        End Set
    End Property

    Public Property EmailContacto As String
        Get
            Return _EmailContacto
        End Get
        Set(value As String)
            _EmailContacto = value
        End Set
    End Property

    Public Property DPI As String
        Get
            Return _DPI
        End Get
        Set(value As String)
            _DPI = value
        End Set
    End Property

    Private Sub InicializarVariables()
        _Proveedor = 0
        _Nombrelargo = String.Empty
        _NombreCorto = String.Empty
        _ActividadProveedor = String.Empty
        _NITProveedor = String.Empty
        _Direccion = String.Empty
        _Telefono1 = String.Empty
        _telefono2 = String.Empty
        _Contacto = String.Empty
        _EmailContacto = String.Empty
        _TasaRetencion = 0.0
        _TipoRetencion = 0
        _AplicaRetencion = False
        _ProveedorActivo = False
        _AplicaComoCliente = False
        _DPI = String.Empty
    End Sub

    Public Sub Get_InformacionProveedor(pProveedor As Integer)
        Try
            If Not pProveedor = 0 Then
                xSql = "SELECT  Proveedor ," &
                       "        Nombrelargo," &
                       "        NombreCorto, " &
                       "        ActividadProveedor, " &
                       "        NITProveedor, " &
                       "        Direccion, " &
                       "        Telefono1, " &
                       "        Telefono2, " &
                       "        Contacto, " &
                       "        EmailContacto, " &
                       "        TasaRetencionISR TasaRetencion, " &
                       "        TipoRetencion, " &
                       "        AplicaRetencion, " &
                       "        ProveedorActivo, " &
                       "        ProveedorCuentaCorriente, " &
                       "        AplicaComoCliente, " &
                       "        ExentoDeIVA, " &
                       "        AgenteRetenedor, " &
                       "        DPI " &
                       "        FROM TblProveedores" &
                       "        WHERE Proveedor = " & pProveedor

                rw = db.ConsultarFilaTabla(xSql)
                _ProveedorValido = False
                If Not F_Null(rw) Then
                    Proveedor = pProveedor
                    Nombrelargo = rw("NombreLargo").ToString
                    NombreCorto = rw("NombreCorto").ToString
                    ActividadProveedor = rw("ActividadProveedor").ToString
                    NITProveedor = rw("NITProveedor").ToString
                    Direccion = rw("Direccion").ToString
                    Telefono1 = rw("Telefono1").ToString
                    Telefono2 = rw("Telefono2").ToString
                    Contacto = rw("Contacto").ToString
                    EmailContacto = rw("EmailContacto").ToString
                    TasaRetencion = rw("TasaRetencion").ToString
                    TipoRetencion = rw("TipoRetencion").ToString
                    AplicaRetencion = CBool(rw("AplicaRetencion").ToString)
                    ProveedorActivo = CBool(rw("ProveedorActivo").ToString)
                    AplicaComoCliente = CBool(rw("AplicaComoCliente").ToString)
                    DPI = rw("DPI").ToString
                    _ProveedorValido = True
                Else
                    InicializarVariables()
                End If

            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function GrabarProveedor(
                                 pNombrelargo As String,
                                 pNombreCorto As String,
                                 pActividadProveedor As String,
                                 pNITProveedor As String,
                                 pDireccion As String,
                                 pTelefono1 As String,
                                 ptelefono2 As String,
                                 pContacto As String,
                                 pEmailContacto As String,
                                 pTasaRetencion As Double,
                                 pTipoRetencion As Int16,
                                 pAplicaRetencion As Boolean,
                                 pProveedorActivo As Boolean,
                                 pAplicaComoCliente As Boolean,
                                 pDPI As String) As Integer
        Try
            Return db.ConsultarEscalar("Exec   DbCooperativa.dbo.UpI_Proveedor " &
                                        Send(pNombrelargo) & "," &
                                        Send(pNombreCorto) & "," &
                                        Send(pActividadProveedor) & "," &
                                        Send(pNITProveedor) & "," &
                                        Send(pDireccion) & "," &
                                        Send(pTelefono1) & "," &
                                        Send(ptelefono2) & "," &
                                        Send(pContacto) & "," &
                                        Send(pEmailContacto) & "," &
                                        pTasaRetencion & "," &
                                        pTipoRetencion & "," &
                                        F_BoolInt(pAplicaRetencion) & "," &
                                        F_BoolInt(pProveedorActivo) & ",NULL," &
                                        F_BoolInt(pAplicaComoCliente) & "," &
                                        "0,0," &
                                        Send(pDPI))

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ActualizaProveedor(
                             pNombrelargo As String,
                             pNombreCorto As String,
                             pActividadProveedor As String,
                             pNITProveedor As String,
                             pDireccion As String,
                             pTelefono1 As String,
                             ptelefono2 As String,
                             pContacto As String,
                             pEmailContacto As String,
                             pTasaRetencion As Double,
                             pTipoRetencion As Int16,
                             pAplicaRetencion As Boolean,
                             pProveedorActivo As Boolean,
                             pAplicaComoCliente As Boolean,
                             pDPI As String,
                             pProveedor As Integer)
        Try
            db.EjecutarQuery("Exec   DbCooperativa.dbo.UpU_Proveedor " &
                                        Send(pNombrelargo) & "," &
                                        Send(pNombreCorto) & "," &
                                        Send(pActividadProveedor) & "," &
                                        Send(pNITProveedor) & "," &
                                        Send(pDireccion) & "," &
                                        Send(pTelefono1) & "," &
                                        Send(ptelefono2) & "," &
                                        Send(pContacto) & "," &
                                        Send(pEmailContacto) & "," &
                                        pTasaRetencion & "," &
                                        pTipoRetencion & "," &
                                        F_BoolInt(pAplicaRetencion) & "," &
                                        F_BoolInt(pProveedorActivo) & ",NULL," &
                                        F_BoolInt(pAplicaComoCliente) & ",0,0," &
                                        Send(pDPI) & "," &
                                        pProveedor)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub EliminarBeneficiario(pProveedor As Integer)
        Try
            If pProveedor > 0 Then
                db.EjecutarQuery("Exec   DbCooperativa.dbo.UpD_Proveedores " & pProveedor)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ConsultarProveedores(pNombrelargo As String,
                             pNombreCorto As String,
                             pActividadProveedor As String,
                             pNITProveedor As String,
                             pDireccion As String,
                             pTelefono1 As String,
                             ptelefono2 As String,
                             pContacto As String,
                             pEmailContacto As String,
                             pTipoRetencion As String,
                             pAplicaRetencion As Boolean,
                             pProveedorActivo As Boolean,
                             pAplicaComoCliente As Boolean,
                             pDPI As String,
                             pProveedor As Integer) As DataTable
        Try

            Return db.ConsultarTabla("Exec DbCooperativa.dbo.UpS_Proveedores " &
                                        Send(pNombrelargo) & "," &
                                        Send(pNombreCorto) & "," &
                                        Send(pActividadProveedor) & "," &
                                        Send(pNITProveedor) & "," &
                                        Send(pDireccion) & "," &
                                        Send(pTelefono1) & "," &
                                        Send(ptelefono2) & "," &
                                        Send(pContacto) & "," &
                                        Send(pEmailContacto) & "," &
                                        Send(pTipoRetencion) & "," &
                                        F_BoolInt(AplicaRetencion) & "," &
                                        F_BoolInt(pProveedorActivo) & "," &
                                        F_BoolInt(pAplicaComoCliente) & "," &
                                        Send(pDPI) & "," &
                                        IIf(pProveedor = 0, "NULL", pProveedor))

        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
