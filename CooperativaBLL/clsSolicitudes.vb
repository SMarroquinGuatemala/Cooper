Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Configuration
Public Class clsSolicitudes
    Dim xTable As DataTable
    Dim xSqlString As String = String.Empty
    Dim db As New DataBase.DataBase.DataBase

    Public Function BuscarSolicitudes(FechaInicial As String, FechaFinal As String, NumeroDeEmpleado As String,
                                 Optional Nombre As String = "", Optional Descripcion As String = "",
                                 Optional OrigenTransaccion As String = "",
                                 Optional Proveedor As String = "", Optional NombreProveedor As String = "",
                                 Optional OrdenDecompra As String = "", Optional OrdenDeTrabajo As String = "",
                                 Optional Solicitud As String = "") As DataTable
        Try

            Dim xQuery As String = String.Empty



            xQuery = "  SELECT  isValid Valido , " & _
                     "   CAST(b.Estado AS VARCHAR) + '-' + b.DescripcionActual Estado ," & _
                     "   a.idTransaccion Solicitud , " & _
                     "   a.FechaInicial Fecha ," & _
                     "   a.Nombre ," & _
                     "   a.Valor ," & _
                     "   a.CuentaBancaria ," & _
                     "   a.NumeroDocumento ," & _
                     "   a.Descripcion," & _
                     "   FechaDocumento " & _
                     "   FROM    DbCooperativa.dbo.TblTransacciones a   " & _
                     "   INNER JOIN DbCooperativa.dbo.TblTransaccionesEstados b ON b.Estado = a.EstadoActual" & _
                     "   LEFT JOIN DbCooperativa.dbo.TblBancosMovimientos c ON c.idTransaccion = a.idTransaccion "


            If Not F_Null(Proveedor) Or Not F_Null(OrdenDecompra) Or Not F_Null(OrdenDeTrabajo) Or Not F_Null(NombreProveedor) Then
                xQuery &= " inner join  DbCooperativa..TblTransDocumentos Doc on doc.idtransaccion = a.idtransaccion "
            End If

            xQuery = xQuery _
            & "   Where (a.Estadoactual<>0) "


            If Not F_Null(Solicitud) Then
                xQuery &= " and a.idTransaccion = " & Send(Solicitud)
            End If

            If Not F_Null(OrigenTransaccion) Then _
                xQuery = xQuery & " And a.OrigenTransaccion = " & Send(OrigenTransaccion) & vbCrLf


            If Not F_Null(FechaInicial) Then xQuery &= " And a.FechaInicial >= " & Send(FechaInicial) & vbCrLf
            If Not F_Null(FechaFinal) Then xQuery &= " and a.FechaInicial <= " & Send(FechaFinal) & vbCrLf
            If Not F_Null(Nombre) Then xQuery &= " And a.Nombre like '%" & Replace(Nombre, " ", "%") & "%'"
            If Not F_Null(Proveedor) Then xQuery &= " and Doc.Proveedor = " & Send(Proveedor)
            If Not F_Null(OrdenDecompra) Then xQuery &= " And Doc.OrdenDeCompra = " & OrdenDecompra
            If Not F_Null(OrdenDeTrabajo) Then xQuery &= " And Doc.OrdenDetrabajo = " & OrdenDeTrabajo
            If Not F_Null(NombreProveedor) Then xQuery &= " And Doc.NombreProveedor like '%" & Replace(NombreProveedor, " ", "%") & "%'"
            If Not F_Null(Descripcion) Then xQuery &= " and a.Descripcion like '%" & Replace(Descripcion, " ", "%") & "%'"
 
 

            xQuery &= " and a.OrigenTransaccion in ( " _
                                & " Select Distinct OrigenTransaccion " _
                                & "   From TblSecRolEstadosTrans " _
                                & "  Where RolId in ( select RolId from DbCooperativa.dbo.TblSecRolUsuarios where Usuario = " & Send(NumeroDeEmpleado) & " ))"
 
            Return db.ConsultarTabla(xQuery)


        Catch ex As Exception
            Throw New Exception("Buscar Registros", ex)
        End Try

    End Function

    Public Function ConsultarSolicitud(ByVal Solicitud As Integer) As DataRow
        Try
            Dim XsqlDefault As String = Nothing
            XsqlDefault = "  SELECT  isValid Valido , " & _
                     "   CAST(b.Estado AS VARCHAR) + '-' + b.DescripcionActual Estado ," & _
                     "   a.idTransaccion  , " & _
                     "   a.FechaInicial Fecha ," & _
                     "   a.Nombre ," & _
                     "   a.Valor ," & _
                     "   a.CuentaBancaria ," & _
                     "   a.NumeroDocumento ," & _
                     "   a.Descripcion," & _
                     "   FechaDocumento,a.Observaciones,isvalid " & _
                     "   FROM    DbCooperativa.dbo.TblTransacciones a   " & _
                     "   INNER JOIN DbCooperativa.dbo.TblTransaccionesEstados b ON b.Estado = a.EstadoActual" & _
                     "   LEFT JOIN DbCooperativa.dbo.TblBancosMovimientos c ON c.idTransaccion = a.idTransaccion "


            XsqlDefault &= " WHERE a.IdTransaccion = " & Send(Solicitud)

            Return db.ConsultarFilaTabla(XsqlDefault)
        Catch ex As Exception
            Throw New Exception("ExecuteQuerySolicitudes", ex)
        End Try
    End Function

    Public Function GetGrdIndice(ByVal Solicitud As Integer) As DataTable
        Try
            Dim XsqlDefault As String = Nothing
            XsqlDefault = "SELECT TipoDocumento, NumeroDocumento "
            XsqlDefault &= " FROM DbCooperativa.dbo.TblTransDocumentos WHERE IdTransaccion = " & Send(Solicitud)
            Return db.ConsultarTabla(XsqlDefault)
        Catch ex As Exception
            Throw New Exception("GetGrdIndice", ex)
        End Try
    End Function


    Public Function GetSolicitudMovimientos(ByVal Solicitud As String, Documento As String) As DataTable
        Try
            Dim XsqlDefault As String = Nothing
            XsqlDefault = "SELECT IdMovimiento,a.CuentaContableFull+'-'+b.Descripcion as CuentaContable, "
            XsqlDefault &= " a.Descripcion , Valor,TipoCuentaContable"
            XsqlDefault &= " FROM DbCooperativa.dbo.TblTransMovimientos  a"
            XsqlDefault &= " INNER JOIN DbCooperativa.dbo.TblContaCuentasN4 b on a.CuentaContableFull = b.Nivel1+b.Nivel2+b.Nivel3+"
            XsqlDefault &= " b.Nivel4 "
            XsqlDefault &= " WHERE a.idSolicitud = " & Send(Solicitud) & "  and a.IdDocumento = " & Send(Documento)

            XsqlDefault &= " ORDER BY valor DESC , CuentaContableFull"
            Return db.ConsultarTabla(XsqlDefault)
        Catch ex As Exception
            Throw New Exception("GetSolicitudMovimientos", ex)
        End Try
    End Function
 

    'Public Function GetDataCuentasPorCobrar(ByVal Corporacion As String, ByVal Empresa As String, ByVal OrigenTransaccion As String,
    '                                          ByVal NumeroSolicitud As String, ByVal Proveedor As String, ByVal TipoDocumento As String,
    '                                          ByVal NumeroDocumento As String, ByVal Correlativo As String) As DataTable
    '    Try
    '        Dim XsqlDefault As String = Nothing
    '        XsqlDefault = " Select Correlativo,rtrim(Tbl.Deudor) +'-'+ Vw.NombreDeudor as Deudor, Descripcion,Valor"
    '        XsqlDefault &= " From DbContabilidad.dbo.TblBoxMovimientoCuentaCorriente Tbl "
    '        XsqlDefault &= " INNER JOIN DbContabilidad.dbo.VwDeudores Vw on Vw.TipoCuentaCorriente = Tbl.TipoCuentaCorriente And Vw.Deudor = Tbl.Deudor "
    '        XsqlDefault &= " WHERE tbl.Corporacion = " & Send(Corporacion)
    '        XsqlDefault &= " AND Tbl.Empresa = " & Send(Empresa)
    '        XsqlDefault &= " AND OrigenTransaccion = " & Send(OrigenTransaccion)
    '        XsqlDefault &= " AND NumeroSolicitud = " & Send(NumeroSolicitud)
    '        XsqlDefault &= " AND Proveedor = " & Send(Proveedor)
    '        XsqlDefault &= " AND TipoDocumento = " & Send(TipoDocumento)
    '        XsqlDefault &= " AND NumeroDocumento = " & Send(NumeroDocumento)
    '        XsqlDefault &= " AND Tbl.Correlativo = " & Send(F_NVL(Correlativo, 0))
    '        Return db.ConsultarTabla(XsqlDefault)
    '    Catch ex As Exception
    '        Throw New Exception("GetDataCuentasPorCobrar", ex)
    '    End Try
    'End Function 

    Public Function GrabarSolicitud(OrigenTransaccion As String, FechaSolicitud As String, Nombre As String, DescripcionPago As String,
                               Valor As Double, Observacion As String, isValid As Boolean) As Integer
        Try

            xSqlString = String.Empty
            xSqlString = " INSERT INTO DbCooperativa.dbo.TblTransacciones " & _
                         "  ( OrigenTransaccion ,FechaInicial ,FechaFinal , Nombre ,Descripcion , " & _
                         "    Observaciones ,Valor ,EstadoActual , isValid  )VALUES ("

            xSqlString &= Send(OrigenTransaccion) & " , convert(varchar,getdate(),103) ,convert(varchar,getdate(),103), "
            xSqlString &= Send(Nombre) & "," & Send(DescripcionPago) & " , " & Send(Observacion) & "," & F_UnFormat(Valor) & " , 1,0); select @@IDENTITY "

            Return db.ConsultarEscalar(xSqlString)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ModificarSolicitud(Nombre As String, Descripcion As String, Observaciones As String, Valor As String, ByVal CuentaBancaria As String,
                                 Solicitud As Integer)
        Try

            xSqlString = String.Empty
            xSqlString = " Update DbCooperativa..TblTransacciones Set " & _
                         "        Nombre = " & Send(Nombre) & "," & _
                         "       Descripcion= " & Send(Descripcion) & "," & _
                         "       Observaciones= " & Send(Observaciones) & " , " & _
                         "       CuentaBancaria= " & Send(CuentaBancaria) & " , " & _
                         "       valor = " & F_UnFormat(Valor)
            xSqlString &= "  Where idTransaccion = " & Solicitud

            db.EjecutarQuery(xSqlString)

        Catch ex As Exception
            Throw
        End Try
    End Sub


    Public Sub EliminarSolicitud(Solicitud As Integer)
        Try

            xSqlString = String.Empty
            xSqlString = " insert into tbltransestadoactual(idtransaccion,estado,fecha)values(" & Solicitud & ",0,getdate() ) " & _
                         " Update DbCooperativa..TblTransacciones Set " & _
                         "        EstadoActual = 0 "
            xSqlString &= "  Where idTransaccion = " & Solicitud

            db.EjecutarQuery(xSqlString)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ConsultarEstadoSolicitud(Estado As Int16) As DataRow
        Try
            If Estado >= 0 Then
                Return db.ConsultarFilaTabla(
                                        "SELECT  Estado , NombreActual,  DescripcionActual  " &
                                        " FROM DbCooperativa.dbo.TblTransaccionesEstados " &
                                        " WHERE  Estado = " & Estado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function OrigenesDeTransaccion(NumeroDeEmpleado As String) As DataTable
        Try
            Dim xQuery As String = String.Empty

            xQuery = _
              " Select Tbl.OrigenTransaccion , Nombre Descripcion " _
             & "   From dbcooperativa..tblTransaccionesOrigen Tbl " _
             & "  Where  ManejaDocumentos = 1 and Tbl.OrigenTransaccion in ( " _
                                & " Select Distinct OrigenTransaccion " _
                                & "   From TblSecRolEstadosTrans " _
                                & "  Where RolId in ( select RolId from DbCooperativa.dbo.TblSecRolUsuarios where Usuario = " & Send(NumeroDeEmpleado) & " ))"

            xQuery &= " union all   Select '' as OrigenTransaccion , 'Todos...' as Descripcion  " _
            & " order by 1 "

            Return db.ConsultarTabla(xQuery)

            Exit Function
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ContabilizarSolicitud(ByVal Solicitud As Integer, ByVal FechaOperacion As String)
        Try
            xSqlString = String.Empty
            xSqlString = " exec DbCooperativa.dbo.UpPolizaGenera  " & Send(Solicitud) & "," & Send(FechaOperacion)
            db.EjecutarQuery(Me.xSqlString, "")
        Catch exception1 As Exception
            Throw
        End Try
    End Sub




End Class
