Public Class clsTransacciones
    Private _OrigenTransaccion As Int16 = 0
    Private _Descripcion As String = String.Empty
    Private _Nombre As String = String.Empty
    Dim db As New DataBase.DataBase.DataBase
    Dim xSqlDefault As String

    Private _isMovBancos As Boolean
    Public Property isMovBancos() As Boolean
        Get
            Return _isMovBancos
        End Get
        Set(ByVal value As Boolean)
            _isMovBancos = value
        End Set
    End Property

    Public Property OrigenTransaccion As Int16
        Get
            Return _OrigenTransaccion
        End Get
        Set(value As Int16)
            _OrigenTransaccion = value

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

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Sub New(xOrigenTransaccion As Int16)
        Try
            EstablecerOrigenTransaccion(xOrigenTransaccion)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub New()
        OrigenTransaccion = 0
        Nombre = String.Empty
        Descripcion = String.Empty
    End Sub

    Public Function ConsultarOrigenTransaccion(xOrigenTransaccion As Int16) As DataRow
        Try
            If xOrigenTransaccion > 0 Then
                Return db.ConsultarFilaTabla("select origentransaccion,nombre,descripcion,isMovBancos from tbltransaccionesorigen where origentransaccion = " & xOrigenTransaccion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub EstablecerOrigenTransaccion(xOrigenTransaccion As Int16)
        Try
            Dim dr As DataRow = ConsultarOrigenTransaccion(xOrigenTransaccion)
            If Not F_Null(dr) Then
                OrigenTransaccion = xOrigenTransaccion
                Descripcion = dr("Descripcion").ToString
                Nombre = dr("Nombre").ToString
                isMovBancos = CBool(dr("isMovBancos").ToString)
            Else
                OrigenTransaccion = 0
                Nombre = String.Empty
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ConsultarTransacciones(FechaInicial As String, FechaFinal As String, NumeroDeEmpleado As String,
                                      Estado As String, ValorInicial As String, ValorFinal As String, xOrigenTransaccion As String) As DataTable
        Try
            xsqldefault = String.Empty
            xSqlDefault = _
                      "	Select trans.idTransaccion , convert(varchar,trans.FechaInicial,103)Fecha,trans.FechaInicial, " & vbCrLf _
                    & "		soc.NombreCompleto as Nombre,  " & vbCrLf _
                    & "		trans.observaciones, origen.nombre as Origen_Nombre , origen.descripcion as Origen_Descripcion, " & vbCrLf _
                    & "     trans.Valor, sol.idSolicitud, sol.Capital, sol.NumeroDeEmpleado Referencia, Ret.Retencion, trn_est.NombreActual Estado, " & vbCrLf _
                    & "     trans.EstadoActual , isnull(sol.TipoPago,0) as TipoPago, sol.SaldoPrestamos,sol.Empresa " & vbCrLf _
                    & "	from DbCooperativa.dbo.TblTransacciones trans , " & vbCrLf _
                    & "		DbCooperativa.dbo.TblTransaccionesOrigen origen, " & vbCrLf _
                    & "     DbCooperativa.dbo.tbltransorigenretencion ret, " & vbCrLf _
                    & "     DbCooperativa.dbo.TblSolicitudes sol, " & vbCrLf _
                    & "     DbCooperativa.dbo.TblSocios soc, " & vbCrLf _
                    & "     DbCooperativa.dbo.tblTransaccionesEstados trn_est " & vbCrLf _
                    & "	where origen.origentransaccion = trans.origentransaccion " & vbCrLf _
                    & "   and sol.idTransaccion = trans.idTransaccion " & vbCrLf _
                    & "   and soc.numerodeempleado = sol.numerodeempleado " & vbCrLf _
                    & "   and ret.origentransaccion = trans.origentransaccion " & vbCrLf _
                    & "   and trn_est.Estado = trans.estadoactual " & vbCrLf _
                    & "   and sol.isSolicitudVigente = 1 " & vbCrLf _
                    & "   and trans.origentransaccion = " & Send(xOrigenTransaccion)

            If Not F_Null(FechaInicial) Then
                xSqlDefault &= _
                    " and trans.fechaInicial >= " & Send(FechaInicial)
            End If
            If Not F_Null(FechaFinal) Then
                xSqlDefault &= _
                     " and trans.fechainicial <= " & Send(FechaFinal)
            End If
            If Not F_Null(NumeroDeEmpleado) Then
                xSqlDefault &= _
                 " and sol.numerodeempleado = " & Send(NumeroDeEmpleado)
            End If
            If Not F_Null(Estado) Then
                xSqlDefault &= _
                 " and trans.estadoactual = " & Send(Estado)
            End If
            If Not F_Null(ValorInicial) Then
                xSqlDefault &= _
                 " and sol.Capital >= " & Send(F_UnFormat(ValorInicial))
            End If
            If Not F_Null(ValorFinal) Then
                xSqlDefault &= _
                 " and sol.Capital <= " & Send(F_UnFormat(ValorFinal))
            End If

            xSqlDefault &= " Order by trans.FechaInicial "

            Return db.ConsultarTabla(xSqlDefault)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub GrabarModificarPrestamo(xOrigenTransaccion As Int16, xIdSolicitud As Integer,
                                       xNumeroDeEmpleado As String, xFechaInicial As String,
                                       xCantidad As String, xMesesPlazoFijo As String,
                                       xTipoDePago As String, xNombreDeUsuario As String)
        Try
            xSqlDefault = String.Empty
            xSqlDefault = _
                " exec DbCooperativa.dbo.up_SolicitudPrestamos " _
                & Send(xOrigenTransaccion) & " , " _
                & Send(xIdSolicitud) & " , " _
                & Send(xNumeroDeEmpleado) & " , " _
                & Send(xFechaInicial) & " , " _
                & Send(xCantidad) & " , " _
                & Send(xMesesPlazoFijo) & " , " _
                & Send(xTipoDePago) & " , " _
                & Send(xNombreDeUsuario)

            db.EjecutarQuery(xSqlDefault)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ConsultarPrestamo(xNumeroDeEmpleado As String, Optional idTransaccion As Integer = 0) As DataRow
        Try
            xSqlDefault = String.Empty
            xSqlDefault = "SELECT  a.idTransaccion ," _
                        + "        idSolicitud ," _
                        + "        Capital ," _
                        + "        Intereses ," _
                        + "        InteresPorcentaje ," _
                        + "        Amortizaciones ," _
                        + "        MesesPlazo ," _
                        + "        CuotaTotal ," _
                        + "        ISNULL(a.Valor, 0) Valor ," _
                        + "        AhorroAcumulado ," _
                        + "        SaldoPrestamos ," _
                        + "        SaldoElectrodomesticos ," _
                        + "        SaldoCodeudor ," _
                        + "        TotalDeuda ," _
                        + "        AhorroLibreDeuda ," _
                        + "        capital - SaldoPrestamos ChequePor ," _
                        + "        TipoPago," _
                        + "        FechaSolicitud," _
                        + "        MesesPlazo," _
                        + "        b.NumeroDeEmpleado,c.DescripcionActual  " _
                        + "FROM    DbCooperativa.dbo.TblTransacciones a  " _
                        + "        INNER JOIN DbCooperativa.dbo.TblSolicitudes b ON a.idTransaccion = b.idSolicitud  " _
                        + "        inner join dbCooperativa.dbo.TblTransaccionesEstados c on c.Estado = a.Estadoactual " _
                        + "WHERE   1= 1  "

            If idTransaccion = 0 Then
                xSqlDefault &= " and b.idSolicitud = ( SELECT    MAX(idSolicitud)" _
                    + "                          FROM      dbo.TblSolicitudes" _
                    + "                          WHERE     NumeroDeEmpleado = " & Send(xNumeroDeEmpleado) _
                    + "                        )"
            Else
                xSqlDefault &= " and a.IdTransaccion =  " & idTransaccion
            End If

            Return db.ConsultarFilaTabla(xSqlDefault)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarAmortizaciones(idSolicitud As Integer) As DataTable
        Try
            Return db.ConsultarTabla(" select Numero, Fecha, Capital, Intereses, " _
                        & "  Valor, Saldo from DbCooperativa.dbo.tblsolicitudamortizacion " _
                        & " where idSolicitud = " & Send(idSolicitud))

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub GrabarCodeudor(IdTransaccion As Integer, IdSolicitud As Integer, Codeudor As String, FechaSolicitud As String, Valor As Double)
        Try
            xSqlDefault = " Declare @AhorroAcumulado decimal(15,2), @SaldoPrestamos decimal(15,2), " & vbCrLf _
                          & " @SaldoElectrodomesticos decimal(15,2), @TotalDeuda decimal(15,2), " & vbCrLf _
                          & "  @AhorroLibreDeuda decimal(15,2) " & vbCrLf _
                          & "  Select @AhorroAcumulado = dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'400', " & _
                            Send(FechaSolicitud) & ")+dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'401', " & Send(FechaSolicitud) & ")" & vbCrLf _
                          & "	select @SaldoPrestamos = dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'430', " & Send(FechaSolicitud) & ")" & vbCrLf _
                          & "	select @SaldoElectrodomesticos = dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'420', " & Send(FechaSolicitud) & ")" & vbCrLf _
                          & " select @TotalDeuda = @SaldoPrestamos+@SaldoElectrodomesticos " & vbCrLf _
                          & "	select  @AhorroLibreDeuda = @AhorroAcumulado + @TotalDeuda " & vbCrLf _
                          & " insert into DbCooperativa.dbo.TblSolicitudCodeudor " & vbCrLf _
                          & " ( idTransaccion,idSolicitud,NumeroDeEmpleado,AhorroAcumulado,SaldoPrestamos, " & vbCrLf _
                          & " SaldoElectrodomesticos,TotalDeuda,AhorroLibreDeuda,SaldoCodeudor, ValorCodeudor ) values ( " & vbCrLf _
                          & IdTransaccion & " , " & IdSolicitud & " , " & Send(Codeudor) & " , " & vbCrLf _
                          & " @AhorroAcumulado , @SaldoPrestamos, " & vbCrLf _
                          & " @SaldoElectrodomesticos,@TotalDeuda,@AhorroLibreDeuda,0, " & Send(Valor) & "  ) "
            db.EjecutarQuery(xSqlDefault)
        Catch ex As Exception
            Throw
        End Try
    End Sub


    Public Sub ModificarCodeudor(IdTransaccion As Integer, IdSolicitud As Integer, Codeudor As String, FechaSolicitud As String, Valor As Double)
        Try
            xSqlDefault = " Declare @AhorroAcumulado decimal(15,2), @SaldoPrestamos decimal(15,2), " & vbCrLf _
                          & " @SaldoElectrodomesticos decimal(15,2), @TotalDeuda decimal(15,2), " & vbCrLf _
                          & "  @AhorroLibreDeuda decimal(15,2) " & vbCrLf _
                          & "  Select @AhorroAcumulado = dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'400', " & _
                            Send(FechaSolicitud) & ")+dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'401', " & Send(FechaSolicitud) & ")" & vbCrLf _
                          & "	select @SaldoPrestamos = dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'430', " & Send(FechaSolicitud) & ")" & vbCrLf _
                          & "	select @SaldoElectrodomesticos = dbo.fnSocioSaldoRetencion(" & Send(Codeudor) & ",'420', " & Send(FechaSolicitud) & ")" & vbCrLf _
                          & " select @TotalDeuda = @SaldoPrestamos+@SaldoElectrodomesticos " & vbCrLf _
                          & "	select  @AhorroLibreDeuda = @AhorroAcumulado + @TotalDeuda " & vbCrLf _
                          & "  delete from DbCooperativa.dbo.TblSolicitudCodeudor where idsolicitud =  " & IdSolicitud & " and idtransaccion = " & IdTransaccion & " and numerodeempleado = " & Send(Codeudor) _
                          & " insert into DbCooperativa.dbo.TblSolicitudCodeudor " & vbCrLf _
                          & " ( idTransaccion,idSolicitud,NumeroDeEmpleado,AhorroAcumulado,SaldoPrestamos, " & vbCrLf _
                          & " SaldoElectrodomesticos,TotalDeuda,AhorroLibreDeuda,SaldoCodeudor, ValorCodeudor ) values ( " & vbCrLf _
                          & IdTransaccion & " , " & IdSolicitud & " , " & Send(Codeudor) & " , " & vbCrLf _
                          & " @AhorroAcumulado , @SaldoPrestamos, " & vbCrLf _
                          & " @SaldoElectrodomesticos,@TotalDeuda,@AhorroLibreDeuda,0, " & Send(Valor) & "  ) "
            db.EjecutarQuery(xSqlDefault)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ConsultarCodeudoresPrestamo(idTransaccion As Integer, IdSolicitud As Integer) As DataTable
        Try
            Return db.ConsultarTabla("Select b.NombreCompleto Nombre,ValorCodeudor,a.NumeroDeEmpleado " &
                                     " from DbCooperativa.dbo.TblSolicitudCodeudor a  " &
                                     " inner join DbCooperativa.dbo.TblSocios b on a.numerodeempleado " &
                                     " = b.numerodeempleado where IdTransaccion=" & idTransaccion &
                                     " and IdSolicitud = " & IdSolicitud)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
