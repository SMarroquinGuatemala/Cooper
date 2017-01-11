Imports System.Drawing.Image
Imports System.IO

Public Class clsSocio
    Private _NumeroDeEmpleado As String = String.Empty
    Private _Nombre As String = String.Empty
    Private _Direccion As String = String.Empty
    Private _Planilla As String = String.Empty
    Private _Telefono As String = String.Empty
    Private _Fotografia As Drawing.Image
    Private _Catorcenal As Boolean = False
    Private _Salario As Double = 0
    Dim xSql As String = String.Empty
    Dim db As New DataBase.DataBase.DataBase
    Private _EmpleadoValido As Boolean = False
    Dim rw As DataRow
    Private _FechaSolicitud As Date
    Private _Capital As Double = 0



    Sub New()
        InicializarVariables()
    End Sub


    Sub InicializarVariables()
        NumeroDeEmpleado = ""
        Nombre = ""
        Direccion = ""
        Planilla = ""
        Telefono = ""
        Fotografia = Nothing
        Catorcenal = False
        EmpleadoValido = False
    End Sub
    Public Property Salario As Double
        Get
            Return _Salario
        End Get
        Set(value As Double)
            _Salario = value
        End Set
    End Property
    Public Property NumeroDeEmpleado As String
        Get
            Return _NumeroDeEmpleado
        End Get
        Set(value As String)
            _NumeroDeEmpleado = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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
    Public Property Planilla As String
        Get
            Return _Planilla
        End Get
        Set(value As String)
            _Planilla = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Fotografia As Drawing.Image
        Get
            Return _Fotografia
        End Get
        Set(value As Drawing.Image)
            _Fotografia = value
        End Set
    End Property
    Public Property Catorcenal As Boolean
        Get
            Return _Catorcenal
        End Get
        Set(value As Boolean)
            _Catorcenal = value
        End Set
    End Property
    Public Property EmpleadoValido As Boolean
        Get
            Return _EmpleadoValido
        End Get
        Set(value As Boolean)
            _EmpleadoValido = value
        End Set
    End Property
    Public Property FechaSolicitud As Date
        Get
            Return _FechaSolicitud
        End Get
        Set(value As Date)
            _FechaSolicitud = value
        End Set
    End Property
    Public Property Capital() As Double
        Get
            Return _Capital
        End Get
        Set(ByVal value As Double)
            _Capital = value
        End Set
    End Property

    Public Sub Get_Empleado(NumeroDeEmpleado As String)
        Try
            If Me.NumeroDeEmpleado <> NumeroDeEmpleado Then
                xSql = _
                        "SELECT  a.NumeroDeEmpleado , " & _
                        "        a.Nombre , " & _
                        "        Direccion , " & _
                        "        a.Planilla , " & _
                        "        Catorcenal , " & _
                        "        Salario , " & _
                        "        ( SELECT Foto " & _
                        "                    FROM    DbRecursosHumanosfotos.dbo.TblCarnet car " & _
                        "                    WHERE   car.numerodeempleado = a.numerodeempleado " & _
                        "                  ) Fotografia , " & _
                        "        isnull(Telefono,'S/T')Telefono " & _
                        "FROM    DbRecursosHumanos.dbo.TblPersonal a " & _
                        "        INNER JOIN DbRecursosHumanos.dbo.TblPlanillas b ON a.Planilla = b.Planilla " & _
                        "                                         AND a.Empresa = b.Empresa " & _
                        "        INNER JOIN dbrecursoshumanos.dbo.tbltiposdeplanilla tpla on tpla.tipodeplanilla = b.tipodeplanilla and tpla.empresa=b.Empresa " & _
                        "WHERE   a.FechaDeEgreso IS NULL " & _
                        "        AND a.NumeroDeEmpleado =  " & Send(NumeroDeEmpleado)
                rw = db.ConsultarFilaTabla(xSql)

                If Not F_Null(rw) Then
                    Me.NumeroDeEmpleado = NumeroDeEmpleado
                    Nombre = rw("Nombre").ToString
                    Direccion = rw("Direccion").ToString
                    Planilla = rw("Planilla").ToString
                    Catorcenal = CBool(rw("Catorcenal").ToString)
                    Telefono = rw("Telefono").ToString
                    Salario = rw("Salario").ToString
                    Dim Photo() As Byte = CType(rw("Fotografia"), Byte())
                    Fotografia = Drawing.Image.FromStream(New MemoryStream(Photo))
                    EmpleadoValido = True
                Else
                    InicializarVariables()
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ValidaIngresoNuevo(Optional xEmpleado As String = "") As Boolean
        Try
            If F_Null(xEmpleado) Then xEmpleado = NumeroDeEmpleado

            If F_Null(xEmpleado) Then
                MsgBox("No se encontro codigo de empleado")
                Return False
            Else
                rw = Nothing : rw = db.ConsultarFilaTabla("Exec DbCooperativa.dbo.UpV_SocioNuevo " & Send(xEmpleado))
                If Not F_Null(rw) Then
                    If CInt(rw("Exito").ToString) = 0 Then
                        Return True
                    Else
                        MsgBox(rw("Mensaje").ToString, vbCritical, "MensajeDeSistema")
                        Return False
                    End If
                Else
                    MsgBox("No se pudo validar el nuevo socio")
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GrabarNuevoSocio(NumeroDeEmpleado As String, Fecha As String, Capital As Double) As Integer
        Try
            If Not F_Null(NumeroDeEmpleado) And Not F_Null(Fecha) Then
                Return db.ConsultarEscalar("exec UpI_SolicitudDeAdmision " & Send(NumeroDeEmpleado) & "," & Send(Fecha) & "," & Send(Capital))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ActualizarNuevoSocio(NumeroDeEmpleado As String, Fecha As String, Capital As Double, Direccion As String, Telefono As String,
                                        Planilla As String, Catorcenal As Boolean, Salario As Double, IdTransaccion As Integer)
        Try
            If Not F_Null(NumeroDeEmpleado) And Not F_Null(Fecha) Then
                db.ConsultarEscalar("exec UpU_SolicitudDeAdmision " & Send(NumeroDeEmpleado) & "," & Send(Fecha) & "," & Send(Capital) &
                                            "," & Send(Direccion) & "," & Send(Telefono) & "," & Send(Planilla) & "," & F_BoolInt(Catorcenal) & "," &
                                            Send(Salario) & "," & IdTransaccion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Sub SeleccionarNuevoSocio(NumeroDeEmpleado As String, IdTransaccion As Integer)
        Try
            If Not F_Null(NumeroDeEmpleado) And IdTransaccion > 0 Then
                Dim dr As DataRow = _
                    db.ConsultarFilaTabla("Exec  UpS_SolicitudDeAdmision " & Send(NumeroDeEmpleado) & "," & Send(IdTransaccion))
                If Not F_Null(dr) Then
                    Get_Empleado(NumeroDeEmpleado)
                    Direccion = dr("Direccion").ToString
                    Salario = dr("Salario").ToString
                    Me.NumeroDeEmpleado = NumeroDeEmpleado
                    Nombre = dr("NombreEmpleado").ToString
                    Planilla = dr("Planilla").ToString
                    Telefono = dr("Telefono").ToString
                    Catorcenal = F_IntBool(dr("Catorcenal").ToString)
                    EmpleadoValido = True
                    FechaSolicitud = dr("Fechasolicitud").ToString
                    Capital = dr("Capital").ToString
                Else
                    MsgBox("No hay solicitudes activas")
                    EmpleadoValido = False
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ActualizarBeneficiario(Nombre As String, Parentesco As String, Direccion As String, TipoDeBeneficiario As String, IdBeneficiario As String)
        Try
            If Not F_Null(NumeroDeEmpleado) And Not F_Null(Nombre) And Not F_Null(Parentesco) Then
                db.EjecutarQuery("Exec DbCooperativa.dbo.UpU_SociosBeneficiarios " & Send(Nombre) & "," &
                                           Send(Parentesco) & "," & Send(Direccion) & "," & Send(TipoDeBeneficiario) & "," & Send(IdBeneficiario))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function GrabarBeneficiario(NumeroDeEmpleado As String, Nombre As String, Parentesco As String, Direccion As String, TipoDeBeneficiario As String) As Integer
        Try
            If Not F_Null(NumeroDeEmpleado) And Not F_Null(Nombre) And Not F_Null(Parentesco) Then
                Return db.ConsultarEscalar("Exec DbCooperativa.dbo.UpI_SociosBeneficiarios " &
                                           Send(NumeroDeEmpleado) & "," & Send(Nombre) & "," &
                                           Send(Parentesco) & "," & Send(Direccion) & "," & Send(TipoDeBeneficiario))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function SeleccionarBeneficiario(IdBeneficiario As String) As DataRow
        Try
            If Not F_Null(NumeroDeEmpleado) Then
                Return db.ConsultarFilaTabla("Exec DbCooperativa.dbo.UpS_Sociosbenefciarios NULL, " & Send(IdBeneficiario))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function SeleccionarBeneficiarios(NumeroDeEmpleado As String) As DataTable
        Try
            If Not F_Null(NumeroDeEmpleado) Then
                Return db.ConsultarTabla("Exec DbCooperativa.dbo.UpS_Sociosbenefciarios " & Send(NumeroDeEmpleado))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub EliminarBeneficiario(IdBeneficiario As Integer)
        Try
            If IdBeneficiario > 0 Then
                db.EjecutarQuery("Exec   DbCooperativa.dbo.UpD_Sociosbenefciarios " & IdBeneficiario)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub




End Class
