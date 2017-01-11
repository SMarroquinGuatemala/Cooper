
Public Class clsTransDocumentos
    Dim db As New DataBase.DataBase.DataBase, xSqlDefault As String = String.Empty

    Public Function ConsultarMovimientosContablesDocumento(Solicitud As String, Documento As String) As DataTable
        Try
            Return db.ConsultarTabla("  Select IdMovimiento,  " _
              & "         Nivel1 + Nivel2 + Nivel3 + Nivel4  as CuentaContable , " _
              & "         Descripcion , Valor, TipoCuentaContable, " _
              & "         IdDocumento " _
              & "    From DbCooperativa..tblTransMovimientos    " _
              & "   Where IdTransaccion = " & Send(Solicitud) _
              & "     And IdDocumento = " & Send(Documento) _
              & "     order by valor desc , cuentacontablefull  ")

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarMovimientoContableDocumento(Solicitud As String, Documento As String, Movimiento As Integer) As DataRow
        Try
            Return db.ConsultarFilaTabla("Select IdMovimiento,  " _
              & "         Nivel1 + Nivel2 + Nivel3 + Nivel4 as  CuentaContable,  " _
              & "         Descripcion , Valor, TipoCuentaContable, " _
              & "         IdDocumento " _
              & "    From DbCooperativa..tblTransMovimientos    " _
              & "   Where IdTransaccion = " & Send(Solicitud) _
              & "     And IdDocumento = " & Send(Documento) _
              & "     And IdMovimiento = " & Send(Movimiento))
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Sub GrabarDocumento(Solicitud As String, Documento As String, CuentaContablen1 As String,
                                                            CuentaContablen2 As String, CuentaContablen3 As String, CuentaContableN4 As String,
                                                            Descripcion As String, Valor As String, TipoCuentaContable As String,
                                                            ByRef IdMovimiento As String)
        Try
            If IdMovimiento = 0 Then
                IdMovimiento = db.ConsultarEscalar(" Select isnull(Max(IdMovimiento),0) + 1 " _
                                                & " From DbCooperativa..tblTransMovimientos " _
                                                & " Where IdTransaccion = " & Send(Solicitud) _
                                                & "   And IdDocumento = " & Send(Documento) _
                                                & "   And IdMovimiento < 1000 ")
            End If
            xSqlDefault = " Insert Into DbCooperativa..tblTransMovimientos ( IdTransaccion, IdDocumento, " _
            & " IdMovimiento , Nivel1, Nivel2 , Nivel3 , Nivel4, " _
            & " Descripcion , Valor, TipoCuentaContable) Values ( " _
            & Send(Solicitud) & " , " _
            & Send(Documento) & " , " _
            & Send(IdMovimiento) & " , " _
            & Send(CuentaContablen1) & " , " & Send(CuentaContablen2) & " , " _
            & Send(CuentaContablen3) & " , " & Send(CuentaContableN4) & " , " _
            & Send(Descripcion) & " , " _
            & F_UnFormat(Valor) & " , " & Send(TipoCuentaContable) & ")"

            db.EjecutarQuery(xSqlDefault)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ModificarMovimiento(Solicitud As String, Documento As String, CuentaContablen1 As String,
                                                            CuentaContablen2 As String, CuentaContablen3 As String, CuentaContableN4 As String,
                                                            Descripcion As String, Valor As String, TipoCuentaContable As String,
                                                            ByRef IdMovimiento As String)
        Try
            xSqlDefault = " Update DbCooperativa..tblTransMovimientos Set " _
                            & " " _
                            & " Nivel1 = " & Send(CuentaContablen1) & " , " _
                            & " Nivel2 = " & Send(CuentaContablen2) & " , " _
                            & " Nivel3 = " & Send(CuentaContablen3) & " , " _
                            & " Nivel4 = " & Send(CuentaContableN4) & " , " _
                            & " Descripcion = " & Send(Descripcion) & " , " _
                            & " Valor = " & F_UnFormat(Valor) & " , " _
                            & " TipoCuentaContable = " & Send(TipoCuentaContable) _
                            & " Where IdTransaccion = " & Send(Solicitud) _
                            & "   And IdDocumento = " & Send(Documento) _
                            & "   And IdMovimiento = " & Send(IdMovimiento)

            db.EjecutarQuery(xSqlDefault)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub EliminarMovimiento(Solicitud As String, Documento As String, ByRef IdMovimiento As Integer)
        Try
            xSqlDefault = " delete from  DbCooperativa..tblTransMovimientos " _
                            & " Where IdTransaccion = " & Send(Solicitud) _
                            & "   And IdDocumento = " & Send(Documento) _
                            & "   And IdMovimiento = " & Send(IdMovimiento)

            db.EjecutarQuery(xSqlDefault)
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
