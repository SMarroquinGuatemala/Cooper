Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Configuration
Public Class clsDocumentos
    Dim dr As DataRow, strQuery As String = String.Empty
    Dim db As New DataBase.DataBase.DataBase, xSqlDefault As String = String.Empty

    Public Function ConsultarModoDocumento(xTipoDocumento As String) As DataRow
        Try


            dr = db.ConsultarFilaTabla(" Select isnull(isCalculaIva,0) as isCalculaIva, isnull(isMovVentas,0) as isMovVentas, " _
                                         & "        isnull(isMovRetencion,0) as isMovRetencion " _
                                         & "  From DbCooperativa.dbo.TblTransTiposDocumentos " _
                                         & " Where TipoDocumento = " & Send(xTipoDocumento))

            Return dr

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Valid_PrimaryKey(Solicitud As String, Proveedor As String,
                                     TipoDocumento As String, NumeroDocumento As String,
                                     Serie As String, isExecuteQuery As Boolean,
                                     ModoDocumento As Int16, isCalculaIVA As Boolean) As Boolean
        Valid_PrimaryKey = True
        Try
            If F_Null(Proveedor) Then Return True
            dr = db.ConsultarFilaTabla(" Select isnull(count(*),0) Conteo " _
                  & "   From DbCooperativa.dbo.TblTransDocumentos " _
                  & "  Where  idTransaccion = " & Solicitud _
                  & "    and TipoDocumento = " & Send(TipoDocumento) _
                  & "    and Proveedor = " & Send(Proveedor) _
                  & "    and NumeroDocumento = " & Send(NumeroDocumento) _
                  & "    and isnull(rtrim(Serie),'') = " & Send(Serie))

            If Not F_Null(dr) AndAlso CInt(dr("Conteo")) > 0 Then
                If ModoDocumento = 1 Then
                    GoTo Not_Valid_Primarykey
                Else
                    'Confuso en vb6
                End If
            End If


            If Not isExecuteQuery Then
                ''valida si se encuentra el documento en otra solicitud.
                ''=========================================================

                If TipoDocumento = "FAC" Or TipoDocumento = "NCR" Or TipoDocumento = "FES" Or (isCalculaIVA And TipoDocumento <> "REC") Then

                    dr = db.ConsultarFilaTabla(" Select  idTransaccion  " _
                     & "   From DbCooperativa..TblTransDocumentos a " _
                     & "  Where  a.idTransaccion <> " & Solicitud _
                     & "    and TipoDocumento = " & Send(TipoDocumento) _
                     & "    and Proveedor = " & Send(Proveedor) _
                     & "    and NumeroDocumento = " & Send(NumeroDocumento) _
                     & "    and Serie = " & Send(Serie, False) _
                     & "    and not Exists (select Proveedor " _
                     & "                      from DbCooperativa.Dbo.TblProveedores b with (nolock) " _
                     & "                      where b.Proveedor = a.Proveedor and isnull(b.TasaRetencionISR,0)>=0)")


                    If Not F_Null(dr) AndAlso Not F_Null(dr("idTransaccion").ToString) Then
                        If Not isExecuteQuery Then
                            MsgBox("ya se encuentra esta factura en la solicitud " &
                                dr("Solicitud").ToString & ", Verifique", vbInformation, "MensajeDeSistema")
                        End If
                        GoTo Not_Valid_Primarykey
                    End If 'Not IsNull(rs(0))
                End If 'If Not rs.EOF Then 
                ''=========================================================
            End If
            Return True

Not_Valid_Primarykey:
            If Not isExecuteQuery Then
                Proveedor = ""
                MsgBox("Este documento ya fue ingresado")
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarTasaDelIVA(FechaDocumento As String) As Double
        Try
            If F_Null(FechaDocumento) Then
                Return 0.0
            Else
                Return db.ConsultarEscalar("select DbCooperativa.dbo.fnTasaDelIva(" & Send(FechaDocumento) & ") as TasaDelIva")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarTasaDelISR(FechaDocumento As String, TipoDocumento As String, TipoDeValor As String) As Double
        Try
            If F_Null(FechaDocumento) Then
                Return 0.0
            Else
                Return db.ConsultarEscalar("select DbCooperativa.dbo.fnTasaDelISR(" & Send(FechaDocumento) & "," & Send(TipoDocumento) & " ," & Send(TipoDeValor) & " ) as TasaDelISR")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function GrabarDocumento(Solicitud As String, Proveedor As String, TipoDocumento As String,
                               Serie As String, NumeroDocumento As String, Descripcion As String,
                               FechaDocumento As String, FechaAplicacion As String, ValorBienes As String,
                               ValorServicios As String, ValorExcentoIva As String, ValorIVA As String, ValorRetencion As String,
                               ValorRetencionBienes As String, ValorLiquido As String, ValorDescuentos As String,
                               ValorTotal As String, Valido As Boolean, OrdenDeCompra As String, OrdenDeTrabajo As String, isReclamaIva As Boolean,
                               isReclamaIvaTipo As String, IvaBienes As String, IvaServicios As String, IvaBienesGasto As String, IvaServiciosGasto As String,
                               NITProveedor As String, Moneda As String, TipoDeCambio As String, BaseLegal As String, SucursalFacturacion As String) As Integer
        Try
            strQuery = String.Empty

            strQuery = String.Concat(New String() {" Exec DbCooperativa.dbo.UpI_TransDocumentos ",
                                                   Send(Solicitud), ",",
                                                   Send(Proveedor), ",",
                                                   Send(TipoDocumento), ",",
                                                   Send(Serie), ",",
                                                   Send(NumeroDocumento), ",",
                                                   Send(Descripcion), ",",
                                                   Send(FechaDocumento), ",",
                                                   Send(FechaAplicacion), ",",
                                                   F_UnFormat(ValorBienes, 20, 2, False), ",",
                                                   F_UnFormat(ValorServicios, 20, 2, False), ",",
                                                   F_UnFormat(ValorExcentoIva, 20, 2, False), ",",
                                                   F_UnFormat(ValorIVA, 20, 2, False), ",",
                                                   F_UnFormat(ValorRetencion, 20, 2, False), ",",
                                                   F_UnFormat(ValorRetencionBienes, 20, 2, False), ",",
                                                   F_UnFormat(ValorLiquido, 20, 2, False), ",",
                                                   F_UnFormat(ValorDescuentos, 20, 2, False), ",",
                                                   F_UnFormat(ValorTotal, 20, 2, False), ",",
                                                   (F_BoolInt(Valido)), ",",
                                                   F_UnFormat(OrdenDeCompra, 20, 2, False), ",",
                                                   F_UnFormat(OrdenDeTrabajo, 20, 2, False), ",",
                                                   (F_BoolInt(isReclamaIva)), ",",
                                                   F_UnFormat(isReclamaIvaTipo, 20, 2, False), ",",
                                                   F_UnFormat(IvaBienes, 20, 2, False), ",",
                                                   F_UnFormat(IvaServicios, 20, 2, False), ",",
                                                   F_UnFormat(IvaBienesGasto, 20, 2, False), ",",
                                                   F_UnFormat(IvaServiciosGasto, 20, 2, False), ",NULL,",
                                                   Send(NITProveedor), ",",
                                                   Send(Moneda), ",",
                                                   Send(TipoDeCambio), ",",
                                                   Send(BaseLegal), ",",
                                                   Send(SucursalFacturacion)})


            Return db.ConsultarEscalar(strQuery)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ModificarDocumento(Solicitud As String, Proveedor As String, TipoDocumento As String,
                               Serie As String, NumeroDocumento As String, Descripcion As String,
                               FechaDocumento As String, FechaAplicacion As String, ValorBienes As String,
                               ValorServicios As String, ValorExcentoIva As String, ValorIVA As String, ValorRetencion As String,
                               ValorRetencionBienes As String, ValorLiquido As String, ValorDescuentos As String,
                               ValorTotal As String, Valido As Boolean, OrdenDeCompra As String, OrdenDeTrabajo As String, isReclamaIva As Boolean,
                               isReclamaIvaTipo As String, IvaBienes As String, IvaServicios As String, IvaBienesGasto As String, IvaServiciosGasto As String,
                               NITProveedor As String, Moneda As String, TipoDeCambio As String, BaseLegal As String, SucursalFacturacion As String, IdDocumento As String)
        Try
            strQuery = String.Empty

            strQuery = String.Concat(New String() {" Exec DbCooperativa.dbo.UpU_TransDocumentos ",
                                                    Send(Solicitud), ",",
                                                    Send(Proveedor), ",",
                                                    Send(TipoDocumento), ",",
                                                    Send(Serie), ",",
                                                    Send(NumeroDocumento), ",",
                                                    Send(Descripcion), ",",
                                                    Send(FechaDocumento), ",",
                                                    Send(FechaAplicacion), ",",
                                                    F_UnFormat(ValorBienes, 20, 2, False), ",",
                                                    F_UnFormat(ValorServicios, 20, 2, False), ",",
                                                    F_UnFormat(ValorExcentoIva, 20, 2, False), ",",
                                                    F_UnFormat(ValorIVA, 20, 2, False), ",",
                                                    F_UnFormat(ValorRetencion, 20, 2, False), ",",
                                                    F_UnFormat(ValorRetencionBienes, 20, 2, False), ",",
                                                    F_UnFormat(ValorLiquido, 20, 2, False), ",",
                                                    F_UnFormat(ValorDescuentos, 20, 2, False), ",",
                                                    F_UnFormat(ValorTotal, 20, 2, False), ",",
                                                    (F_BoolInt(Valido)), ",",
                                                    F_UnFormat(OrdenDeCompra, 20, 2, False), ",",
                                                    F_UnFormat(OrdenDeTrabajo, 20, 2, False), ",",
                                                    (F_BoolInt(isReclamaIva)), ",",
                                                    F_UnFormat(isReclamaIvaTipo, 20, 2, False), ",",
                                                    F_UnFormat(IvaBienes, 20, 2, False), ",",
                                                    F_UnFormat(IvaServicios, 20, 2, False), ",",
                                                    F_UnFormat(IvaServiciosGasto, 20, 2, False), ",NULL,",
                                                    Send(NITProveedor), ",",
                                                    Send(Moneda), ",",
                                                    F_UnFormat(TipoDeCambio, 20, 2, False), ",",
                                                    Send(BaseLegal), ",",
                                                    Send(SucursalFacturacion), ",",
                                                    F_UnFormat(IdDocumento, 20, 2, False)})
            F_UnFormat(SucursalFacturacion)

            db.EjecutarQuery(strQuery)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ConsultarDocumentos(Solicitud As String) As DataTable
        Try

            strQuery = "  select NumeroDocumento Documento ,Valido, IdDocumento,TipoDocumento ,Proveedor  " & vbCrLf _
             & "    From DbCooperativa..TblTransDocumentos  " & vbCrLf _
             & "    Where IdTransaccion = " & F_UnFormat(Solicitud, , 0) & vbCrLf


            Return db.ConsultarTabla(strQuery)

        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Function ConsultarDocumento(Solicitud As Integer, Documento As String) As DataRow
        Try
            Dim XsqlDefault As String = Nothing
            XsqlDefault = "SELECT a.TipoDocumento,FechaDocumento,Serie,NumeroDocumento,OrdenDeCompra, "
            XsqlDefault &= " OrdenDeServicio,Proveedor,NITProveedor,ValorBienes,ValorServicios,ValorExcentoIva,ValorLiquido,ValorTotal,ValorIva, "
            XsqlDefault &= " IvaBienes,IvaServicios,  IvaBienesGasto, IvaServiciosGasto,isnull(isReclamaIVA ,0)isReclamaIVA ,Descripcion,ValorRetencion,ValorRetencionBienes,BaseLegal "
            XsqlDefault &= " FROM DbCooperativa.dbo.TblTransDocumentos a "
            XsqlDefault &= " WHERE IdTransaccion = " & Send(Solicitud)
            XsqlDefault &= " and IdDocumento = " & Send(Documento)
            Return db.ConsultarFilaTabla(XsqlDefault)
        Catch ex As Exception
            Throw New Exception("GetDatosDocumento", ex)
        End Try

    End Function

    Public Sub EjecutarValorLiquido(Solicitud As String, IdDocumento As String)
        Try

            Dim TblDocumentos As New DataTable
            Dim ValorLiquido As Double = 0.0, ValorDocumentos As Double = 0.0, ValorCheque As Double = 0.0
            strQuery = _
                   "  Select IdTransaccion,IdDocumento, ValorBienes, " _
                 & "         ValorServicios , ValorIVA, ValorTotal, ValorLiquido, ValorRetencion, " _
                 & "         ValorExcentoIva, isnull(ValorRetencionBienes,0) as ValorRetencionBienes " _
                 & "    From DbCooperativa..TblTransDocumentos Tbl  " _
                 & "   Where IdTransaccion = " & F_UnFormat(Solicitud, , 0)

            TblDocumentos = db.ConsultarTabla(strQuery)
            For i As Integer = 0 To TblDocumentos.Rows.Count - 1

                Dim dr As DataRow = TblDocumentos.Rows(i), drDescuento As DataRow

                db.EjecutarQuery(
                       " Exec DbCooperativa.dbo.UpDetalleCuentasContables " _
                       & F_UnFormat(Solicitud, , 0) & " , " _
                       & Send(IdDocumento) _
                       & " ")

                ' Descuenta todas las cuentas que aparecen en negativo y no son automaticas

                drDescuento = db.ConsultarFilaTabla( _
                    "  Select isnull(SUM(tbl.Valor),0) as ValorDescuento " _
                  & "    From DbCooperativa.dbo.TblTransMovimientos Tbl inner join tbltransdocumentos b on tbl.idtransaccion = b.idtransaccion and tbl.iddocumento = b.iddocumento " _
                  & "   Where tbl.IdTransaccion = " & (dr("Idtransaccion")) _
                  & "     And tbl.IdDocumento =  " & Send(dr("IdDocumento")) _
                  & "     And Tbl.Valor < 0 " _
                  & "     And Tbl.IdMovimiento < 1000 And b.TipoDocumento in ('REC', 'FAC', 'OTR', 'NDB') " _
                  & "     And Tbl.TipoCuentaContable not in ('IVA' , 'IV@', 'ISR' ) ")


                ValorLiquido = Val(dr("ValorBienes")) + Val(dr("ValorServicios")) + Val(dr("ValorExcentoIva")) - Val(dr("ValorRetencion")) - Val(dr("ValorRetencionBienes")) + Val(drDescuento("ValorDescuento"))
                ValorDocumentos = Val(dr("valortotal"))

                db.EjecutarQuery(
                "  Update DbCooperativa..TblTransDocumentos Set" _
              & "         ValorLiquido = " & (ValorLiquido) & " , " _
              & "         ValorDescuentos = " & (Math.Abs(drDescuento("ValorDescuento"))) _
              & "   Where IdTransaccion = " & (dr("IdTransaccion")) _
              & "     And IdDocumento =  " & Send(dr("IdDocumento")))



            Next 'Documentos


        
            db.EjecutarQuery( _
                     " Exec DbCooperativa.dbo.UpDetalleCuentasContables " _
                       & F_UnFormat(Solicitud, , 0) & " , " _
                       & Send(IdDocumento) & _
                       " ")

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub EliminarDocumento(Solicitud As Integer, IdDocumento As String)
        Try
            Dim XsqlDefault As String = Nothing

            XsqlDefault = "delete  FROM DbCooperativa.dbo.TblTransDocumentos "
            XsqlDefault &= " WHERE idTransaccion = " & Send(Solicitud) &
                           " AND IdDocumento = " & IdDocumento

            db.EjecutarQuery(XsqlDefault)
        Catch ex As Exception
            Throw New Exception("GetDatosDocumento", ex)
        End Try
    End Sub

End Class
