Public Class clsCuentasContables
    Private _CuentaContable As String = String.Empty
    Private _Nombre As String = String.Empty
    Private _Descripcion As String = String.Empty
    Private _Clasificacion As String = String.Empty
    Private _Auxiliar As String = String.Empty
    Private xSql As String = String.Empty
    Dim rw As DataRow
    Dim db As New DataBase.DataBase.DataBase

    Sub New()
        InicializarVariables()
    End Sub

    Public ReadOnly Property Nivel1 As String
        Get
            Return Mid(_CuentaContable, 1, 1)
        End Get
    End Property
    Public ReadOnly Property Nivel2 As String
        Get
            Return Mid(_CuentaContable, 2, 1)
        End Get
    End Property
    Public ReadOnly Property Nivel3 As String
        Get
            Return Mid(_CuentaContable, 3, 1)
        End Get
    End Property
    Public ReadOnly Property Nivel4 As String
        Get
            Return Mid(_CuentaContable, 4, 2)
        End Get
    End Property

    Public Property Clasificacion As String
        Get
            Return _Clasificacion
        End Get
        Set(value As String)
            _Clasificacion = value
        End Set
    End Property

    Public Property Nombe As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Auxiliar As String
        Get
            Return _Auxiliar
        End Get
        Set(value As String)
            _Auxiliar = value
        End Set
    End Property

    Public Property CuentaContable As String
        Get
            Return _CuentaContable
        End Get
        Set(value As String)
            _CuentaContable = value
        End Set
    End Property

    Private Sub InicializarVariables()
        _Clasificacion = 0
        _CuentaContable = String.Empty
        _Nombre = String.Empty
        _Descripcion = String.Empty
        _Auxiliar = String.Empty
    End Sub

    Public Sub Get_InformacionProveedor(pCuentaContable As String)
        Try
            If Not F_Null(pCuentaContable) Then
                xSql = "SELECT  CuentaContable, " &
                       "        Nombre ," &
                       "        Descripcion," &
                       "        isnull(Auxiliar,'')Auxiliar, " &
                       "        isnull(cast(clasificacion as varchar),'')Clasificacion " &
                       "        FROM TblContaCuentasN4" &
                       "        WHERE CuentaContable = " & pCuentaContable

                rw = db.ConsultarFilaTabla(xSql)
                If Not F_Null(rw) Then
                    CuentaContable = pCuentaContable
                    Nombe = rw("Nombre").ToString
                    Descripcion = rw("Descripcion").ToString
                    Clasificacion = rw("Clasificacion").ToString
                    Auxiliar = rw("Auxiliar").ToString
                Else
                    InicializarVariables()
                End If

            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function GrabarCuentaContable(
                                 pCuentaContable As String,
                                 pNombre As String,
                                 pDescripcion As String,
                                 pAuxiliar As String,
                                 pClasificacion As String) As Integer
        Try
            CuentaContable = pCuentaContable
            Return db.ConsultarEscalar("Exec   DbCooperativa.dbo.UpI_CuentaContable " &
                                        Send(pCuentaContable) & "," &
                                        Send(pNombre) & "," &
                                        Send(pDescripcion) & "," &
                                        Send(Nivel1) & "," &
                                        Send(Nivel2) & "," &
                                        Send(Nivel3) & "," &
                                        Send(Nivel4) & "," &
                                        Send(pAuxiliar) & "," &
                                        Send(pClasificacion))

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ActualizaProveedor(
                                 pCuentaContable As String,
                                 pNombre As String,
                                 pDescripcion As String,
                                 pAuxiliar As String,
                                 pClasificacion As String)
        Try
            CuentaContable = pCuentaContable
            db.EjecutarQuery("Exec   DbCooperativa.dbo.UpU_CuentaContable " &
                                        Send(pCuentaContable) & "," &
                                        Send(pNombre) & "," &
                                        Send(pDescripcion) & "," &
                                        Send(Nivel1) & "," &
                                        Send(Nivel2) & "," &
                                        Send(Nivel3) & "," &
                                        Send(Nivel4) & "," &
                                        Send(pAuxiliar) & "," &
                                        Send(pClasificacion))
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

    Public Function ConsultarCuentaContable(pCuentaContable As String,
                                 pNombre As String,
                                 pDescripcion As String,
                                 pAuxiliar As String,
                                 pClasificacion As String) As DataTable
        Try

            Return db.ConsultarTabla("Exec DbCooperativa.dbo.UpS_CuentasContables " &
                                        Send(pCuentaContable) & "," &
                                        Send(pNombre) & "," &
                                        Send(pDescripcion) & "," &
                                        Send(pAuxiliar) & "," &
                                        Send(pClasificacion))

        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
