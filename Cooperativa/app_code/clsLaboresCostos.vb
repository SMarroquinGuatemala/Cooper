
Public Class clsLaboresCostos
    Private _CentroDeCosto As String = String.Empty
    Private _ClaveDeLabor As String = String.Empty
    Private _NombreCC As String = String.Empty
    Private _isActivoCC As Boolean = False
    Private _LocalizacionCC As String = String.Empty
    Private _IvaCreditoCC As Integer = 0
    Private _isValidCC As Boolean = False
    Private _isValid_MensajeCC As String = String.Empty
    Private _isExisteCC As Boolean = False

    Private _NombreCuenta As String = String.Empty

    Private _CCN1 As String = String.Empty
    Private _CCN2 As String = String.Empty
    Private _CCN3 As String = String.Empty
    Private _CCN4 As String = String.Empty
    Private _CCN5 As String = String.Empty

    Private _CLN1 As String = String.Empty
    Private _CLN2 As String = String.Empty
    Private _CLN3 As String = String.Empty
    Private _CLN4 As String = String.Empty
    Private _CLN5 As String = String.Empty
    Private _NombreCL As String
    Private _isActivoCL As Boolean
    Private _isValidCL As Boolean
    Private _isValid_MensajeCL As String
    Private _isExisteCL As Boolean
    Private _TipoCategoria As String = String.Empty
    Private _Categoria As String = String.Empty

    Private _isValid As Boolean
    Private _isValid_Mensaje As String
    Private _isMaquinaria As Boolean = False
    Private _CuentaContableN1 As String = String.Empty
    Private _CuentaContableN2 As String = String.Empty
    Private _CuentaContableN3 As String = String.Empty
    Private _CuentaContableN4 As String = String.Empty
    Private _CuentaContableN5 As String = String.Empty

    Private _CodigoActivoFijo As String = String.Empty
    Private _NombreActivoFijo As String = String.Empty
    Private _CentroDeCostoActivoFijo As String = String.Empty

    Private _Exito As Int16 = 0
    Private LaboresCostos As New CooperativaBLL.clsLAboresCostos

    Public ReadOnly Property NombreCuenta As String
        Get
            Return _NombreCuenta
        End Get
    End Property
    Public Property isValid As Boolean
        Get
            Return _isValid
        End Get
        Set(ByVal value As Boolean)
            _isValid = value
        End Set
    End Property
    Public Property isMaquinaria As Boolean
        Get
            Return _isMaquinaria
        End Get
        Set(ByVal value As Boolean)
            _isMaquinaria = value
        End Set
    End Property
    Public Property isValid_Mensaje As String
        Get
            Return _isValid_Mensaje
        End Get
        Set(ByVal value As String)
            _isValid_Mensaje = value
        End Set
    End Property
    Public Property Exito As Int16
        Get
            Return _Exito
        End Get
        Set(ByVal value As Int16)
            _Exito = value
        End Set
    End Property

    Sub LimpiaVariablesCL()
        _ClaveDeLabor = String.Empty
        NombreCL = String.Empty
        isActivoCL = False
        isValidCL = False
        isValid_MensajeCl = False
        isExisteCl = False

        CLN1 = String.Empty
        CLN2 = String.Empty
        CLN3 = String.Empty
        CLN4 = String.Empty
        CLN5 = String.Empty
    End Sub
    Public Property NombreCL As String
        Get
            Return _NombreCL
        End Get
        Set(ByVal value As String)
            _NombreCL = value
        End Set
    End Property
    Public Property isActivoCL As Boolean
        Get
            Return _isActivoCL
        End Get
        Set(ByVal value As Boolean)
            _isActivoCL = value
        End Set
    End Property
    Public Property isValidCL As Boolean
        Get
            Return _isValidCL
        End Get
        Set(ByVal value As Boolean)
            _isValidCL = value
        End Set
    End Property
    Public Property isValid_MensajeCl As String
        Get
            Return _isValid_MensajeCL
        End Get
        Set(ByVal value As String)
            _isValid_MensajeCL = value
        End Set
    End Property
    Public Property isExisteCl As Boolean
        Get
            Return _isExisteCL
        End Get
        Set(ByVal value As Boolean)
            _isExisteCL = value
        End Set
    End Property
    Public Property CLN1 As String
        Get
            Return _CLN1
        End Get
        Set(ByVal value As String)
            _CLN1 = value
        End Set
    End Property
    Public Property CLN2 As String
        Get
            Return _CLN2
        End Get
        Set(ByVal value As String)
            _CLN2 = value
        End Set
    End Property
    Public Property CLN3 As String
        Get
            Return _CLN3
        End Get
        Set(ByVal value As String)
            _CLN3 = value
        End Set
    End Property
    Public Property CLN4 As String
        Get
            Return _CLN4
        End Get
        Set(ByVal value As String)
            _CLN4 = value
        End Set
    End Property
    Public Property CLN5 As String
        Get
            Return _CLN5
        End Get
        Set(ByVal value As String)
            _CLN5 = value
        End Set
    End Property
    Public ReadOnly Property ClaveDeLabor As String
        Get
            Return _ClaveDeLabor
        End Get
    End Property
    Public Property CodigoActivoFijo As String
        Get
            Return _CodigoActivoFijo
        End Get
        Set(ByVal value As String)
            _CodigoActivoFijo = value
        End Set
    End Property
    Public Property NombreActivoFijo As String
        Get
            Return _NombreActivoFijo
        End Get
        Set(ByVal value As String)
            _NombreActivoFijo = value
        End Set
    End Property
    Public Property CentroDeCostoActivoFijo As String
        Get
            Return _CentroDeCostoActivoFijo
        End Get
        Set(ByVal value As String)
            _CentroDeCostoActivoFijo = value
        End Set
    End Property

    Sub LimpiaVariablesCC()
        _CentroDeCosto = String.Empty
        LocalizacionCC = String.Empty
        NombreCC = String.Empty
        isActivoCC = False
        IvaCreditoCC = 0
        isExisteCC = False
        isValidCC = False
        isValid_MensajeCC = String.Empty
        CCN1 = String.Empty
        CCN2 = String.Empty
        CCN3 = String.Empty
        CCN4 = String.Empty
        CCN5 = String.Empty
    End Sub
    Public ReadOnly Property CuentaFull As String
        Get
            Return CuentaN1 & CuentaN2 & CuentaN3 & CuentaN4 & CuentaN5
        End Get
    End Property
    Public ReadOnly Property CuentaNivel3 As String
        Get
            Return CuentaN1 & CuentaN2 & CuentaN3
        End Get
    End Property
    Public Property CuentaN5 As String
        Get
            Return _CuentaContableN5
        End Get
        Set(ByVal value As String)
            _CuentaContableN5 = value
        End Set
    End Property
    Public Property CuentaN4 As String
        Get
            Return _CuentaContableN4
        End Get
        Set(ByVal value As String)
            _CuentaContableN4 = value
        End Set
    End Property
    Public Property CuentaN3 As String
        Get
            Return _CuentaContableN3
        End Get
        Set(ByVal value As String)
            _CuentaContableN3 = value
        End Set
    End Property
    Public Property CuentaN2 As String
        Get
            Return _CuentaContableN2
        End Get
        Set(ByVal value As String)
            _CuentaContableN2 = value
        End Set
    End Property
    Public Property CuentaN1 As String
        Get
            Return _CuentaContableN1
        End Get
        Set(ByVal value As String)
            _CuentaContableN1 = value
        End Set
    End Property
    Public Property TipoCategoria As String
        Get
            Return _TipoCategoria
        End Get
        Set(ByVal value As String)
            _TipoCategoria = value
        End Set
    End Property
    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(ByVal value As String)
            _Categoria = value
        End Set
    End Property
    Public Property isExisteCC As Boolean
        Get
            Return _isExisteCC
        End Get
        Set(ByVal value As Boolean)
            _isExisteCC = value
        End Set
    End Property
    Public Property isValid_MensajeCC As String
        Get
            Return _isValid_MensajeCC
        End Get
        Set(ByVal value As String)
            _isValid_MensajeCC = value
        End Set
    End Property
    Public Property isValidCC As Boolean
        Get
            Return _isValidCC
        End Get
        Set(ByVal value As Boolean)
            _isValidCC = value
        End Set
    End Property
    Public Property IvaCreditoCC As Integer
        Get
            Return _IvaCreditoCC
        End Get
        Set(ByVal value As Integer)
            _IvaCreditoCC = value
        End Set
    End Property
    Public Property LocalizacionCC As String
        Get
            Return _LocalizacionCC
        End Get
        Set(ByVal value As String)
            _LocalizacionCC = value
        End Set
    End Property
    Public Property isActivoCC As Boolean
        Get
            Return _isActivoCC
        End Get
        Set(ByVal value As Boolean)
            _isActivoCC = value
        End Set
    End Property
    Public Property NombreCC As String
        Get
            Return _NombreCC
        End Get
        Set(ByVal value As String)
            _NombreCC = value
        End Set
    End Property

    Public Property CCN1 As String
        Get
            Return _CCN1
        End Get
        Set(ByVal value As String)
            _CCN1 = value
        End Set
    End Property
    Public Property CCN2 As String
        Get
            Return _CCN2
        End Get
        Set(ByVal value As String)
            _CCN2 = value
        End Set
    End Property
    Public Property CCN3 As String
        Get
            Return _CCN3
        End Get
        Set(ByVal value As String)
            _CCN3 = value
        End Set
    End Property
    Public Property CCN4 As String
        Get
            Return _CCN4
        End Get
        Set(ByVal value As String)
            _CCN4 = value
        End Set
    End Property
    Public Property CCN5 As String
        Get
            Return _CCN5
        End Get
        Set(ByVal value As String)
            _CCN5 = value
        End Set
    End Property
    Public ReadOnly Property CentroDeCosto As String
        Get
            Return _CentroDeCosto
        End Get
    End Property


    


    



    
    Sub ValidarCuentaN3()
        Try
            If Not isValidCC And Not isValidCL Then
                CuentaN1 = String.Empty : CuentaN2 = String.Empty : CuentaN3 = String.Empty : CuentaN4 = String.Empty : CuentaN5 = String.Empty
                Exit Sub
            End If

            If isValidCC And isValidCL Then
                If Not F_Null(CCN1) Then
                    CuentaN1 = CCN1 : CuentaN2 = CCN2 : CuentaN3 = CCN3 : CuentaN4 = CCN4 : CuentaN5 = CCN5
                Else
                    CuentaN1 = CLN1 : CuentaN2 = CLN2 : CuentaN3 = CLN3 : CuentaN4 = CLN4 : CuentaN5 = CLN5
                End If
                Exit Sub
            End If
            If isValidCC And Not F_Null(CCN1) Then
                CuentaN1 = CCN1 : CuentaN2 = CCN2 : CuentaN3 = CCN3 : CuentaN4 = CCN4 : CuentaN5 = CCN5
                Exit Sub
            End If
            If isValidCC And Not F_Null(CLN1) Then
                CuentaN1 = CLN1 : CuentaN2 = CLN2 : CuentaN3 = CLN3 : CuentaN4 = CLN4 : CuentaN5 = CLN5
                Exit Sub
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    
    Public Function isValidCuentaN3(ByVal CuentaN3 As String, Optional ByRef NombreCuenta As String = "") As Boolean
        Try
            If Not F_Null(CuentaN3) AndAlso Len(CuentaN3) = 4 Then
                Dim Cuenta As DataRow = LaboresCostos.ConsultarCuentaN3(CuentaN3)

                If Not F_Null(Cuenta) Then
                    NombreCuenta = Cuenta("DescripcionCuenta").ToString
                    Me._NombreCuenta = Trim(NombreCuenta)
                    Return True
                Else
                    ShowMsgBox("Cuenta Invalida", MsgBoxStyle.Exclamation)
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            Throw New Exception("Validar Cuenta Contable", ex)
        End Try
    End Function

    Public Function Get_TipoCuenta(ByVal xCuenta As String) As String
        Try
            If Not F_Null(xCuenta) Then

                '======================================
                '         De Cuentas Especiales
                '--------------------------------------
                Dim N1 As String = Mid(xCuenta, 1, 1)
                Get_TipoCuenta = "NOR"
                'Dim dr As DataRow = LaboresCostos.ConsultarTipoCuenta(xCuenta)
                'If Not F_Null(dr) Then Return dr("CodigoAplicacion")

                'If N1 = 6 Or N1 = 7 Or N1 = 8 Or N1 = 9 Then Get_TipoCuenta = "CC2"

            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
