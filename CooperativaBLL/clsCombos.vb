
Public Class clsCombos
    Dim db As New DataBase.DataBase.DataBase
    Dim xtable As New DataTable, xsql As String

    Public Function BasesLegales() As DataTable 
        Try
            Return db.ConsultarTabla("select 'A' BaseLegal,'A-Exportacion' Nombre Union ALL select 'B' BaseLegal,'B-Local' Nombre  ", "", 0)
        Catch exception1 As Exception
            Throw
        End Try
    End Function


    Public Function Clasificaciones() As DataTable
        Try
            Return db.ConsultarTabla(" SELECT  Clase , " & _
                                     " CAST(clase as  varchar)+ '-' + nombre Nombre " & _
                                     " FROM    dbo.vwClasificacion")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Parentescos() As DataTable
        Try
            Return db.ConsultarTabla("select idParentesco,cast(idParentesco as varchar) +'-'+Descripcion from dbcooperativa.dbo.TblTiposDeParentesco")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function TiposDeBeneficiarios() As DataTable
        Try
            Return db.ConsultarTabla("select 0 TipoBeneficiario,'0-No Definido' Nombre Union ALL " &
                                     "select 1 TipoBeneficiario,'1-Beneficiario de Ahorro' Nombre Union ALL " &
                                     "select 2 TipoBeneficiario,'2-Auxilio Postumo' Nombre Union ALL " &
                                     "select 3 TipoBeneficiario,'3-Dependientes' Nombre  ")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function TransaccionesEstados() As DataTable
        Try
            Return db.ConsultarTabla("SELECT  cast(Estado as varchar) Estado, " & _
                                     " CAST(estado AS VARCHAR) + '-' + NombreActual Nombre " & _
                                     " FROM    dbo.TblTransaccionesEstados ")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Modalidades() As DataTable
        Try
            Return db.ConsultarTabla("select '1' Modalidad, '1-Intereses plazo fijo' Nombre " &
                                     "union all select '2' Modalidad, '2-Intereses sobre saldo' Nombre " &
                                     "union all select '3' Modalidad, '3-Cancela saldo anterior' Nombre ")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function TipoRetencion() As DataTable
        Try
            Return db.ConsultarTabla("select 1 TipoRetencion,'1-Pago Directo' Nombre Union ALL " &
                                     "select 2 TipoRetencion,'2-PagoTrimestral' Nombre Union ALL " &
                                     "select 3 TipoRetencion,'3-5% Definitivo' Nombre Union ALL " &
                                     "select 4 TipoRetencion,'4-Pequeño Contribuyente' Nombre  ")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Monedas() As DataTable
        Try
            Return db.ConsultarTabla("select 'GTQ' Moneda,'GTQ-Quetzales' Descripcion union all " &
                                     "select 'USD' Moneda,'USD-Dolares' Descripcion union all " &
                                     "select 'EUR' Moneda,'EUR-Euros' Descripcion ")
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function TiposDeDocumentos(ByVal OrigenTransaccion As Short) As DataTable
        Try
            Return db.ConsultarTabla(("SELECT  a.TipoDocumento,a.TipoDocumento+'-'+Nombre Nombre " & _
                                      "  FROM  DbCooperativa.dbo.TblTransTiposDocumentos a  " & _
                                      " INNER JOIN DbCooperativa.dbo.TblTransOrigenTipodocumento b ON " & _
                                      " a.TipoDocumento = b.TipoDocumento  WHERE OrigenTransaccion = " & Send(OrigenTransaccion) & " "), "", 0)
        Catch exception1 As Exception
            Throw
        End Try
    End Function




    Public Function Bancos() As DataTable
        Try
            Return db.ConsultarTabla("select banco, banco+'-'+NombreBanco Nombre from dbcooperativa.dbo.tblbancos ")
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function CuentasBancarias(Banco As String) As DataTable
        Try
            Return db.ConsultarTabla("select CuentaBancaria, CuentaBancaria Nombre from dbcooperativa.dbo.TblBancosCuentas where banco =  isnull(" & Send(Banco) & " ,banco)")
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function ItemsProveedores(Optional Buscar As String = "") As DataTable
        Try
            xtable = New DataTable

            xsql = " Select rtrim(Proveedor)Proveedor, NombreLargo, NitProveedor, " _
                   & " rtrim(ltrim(str(ProveedorActivo))) as ProveedorActivo,cast(AplicaRetencion as varchar)AplicaRetencion ,cast(TipoRetencion as varchar)TipoRetencion   " _
                   & "   From DbCooperativa.dbo.TblProveedores " _
                   & " Where ProveedorActivo = 1 "

            If Not F_Null(Buscar) Then
                xsql &= _
                    "    And (cast(Proveedor as varchar) = isnull(" & Send(Buscar) & ",cast(Proveedor as varchar)) " _
                   & "     Or  rtrim(NitProveedor) = isnull(" & Send(Buscar) & ", Proveedor) or  " _
                   & "     Nombrelargo like  " & Send("%" & Buscar & "%") & ") "
            End If

            xtable = db.ConsultarTabla(xsql)

            If xtable.Rows.Count = 0 Then
                xsql = " Select rtrim(Proveedor)Proveedor, NombreLargo, NitProveedor,   " _
                   & " rtrim(ltrim(str(ProveedorActivo))) as ProveedorActivo ,cast(AplicaRetencion as varchar)AplicaRetencion ,cast(TipoRetencion as varchar)TipoRetencion  " _
                 & "  From DbCooperativa.dbo.TblProveedores " _
                 & " Where ProveedorActivo = 1 "
                xtable = db.ConsultarTabla(xsql)
            End If

            Return xtable
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ItemsCuentasContables(Cuenta As String) As DataTable
        Try
            xtable = New DataTable
            xsql =
                  " Select Nivel1 + Nivel2 + Nivel3+ Nivel4 as CuentaContable,  " _
                & " Descripcion From DbCooperativa..TblContaCuentasN4 " _
                & "  Where Nivel1 + Nivel2 + Nivel3+ Nivel4 = " & Send(Cuenta) _
                & "      or Descripcion like '%" & Cuenta & "%'"


            xtable = db.ConsultarTabla(xsql)

            If xtable.Rows.Count > 0 Then
                Return xtable
            Else
                Return db.ConsultarTabla("  Select Nivel1 + Nivel2 + Nivel3+ Nivel4 as CuentaContable,  " _
                & " Descripcion From DbCooperativa..TblContaCuentasN4")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
