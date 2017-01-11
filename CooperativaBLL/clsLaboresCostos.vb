Public Class clsLaboresCostos
    Dim db As New DataBase.DataBase.DataBase
    Public Function ConsultarClaveDeLabor(ClaveDeLabor As String, CentroDeCosto As String) As DataRow
        Try
            Return db.ConsultarFilaTabla(" EXEC DbContabilidad.dbo.up_clavesdelabor " _
              & Send(ClaveDeLabor) & " , " & Send(CentroDeCosto))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarCentroDeCosto(ClaveDeLabor As String, CentroDeCosto As String) As DataRow
        Try
            Return db.ConsultarFilaTabla(" EXEC DbContabilidad.dbo.up_CentrosDeCosto " _
                                                         & Send(CentroDeCosto) & " , " & Send(ClaveDeLabor))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarActivoFijo(CodigoActivo As String, CentroDeCosto As String) As DataRow
        Try
            Return db.ConsultarFilaTabla(" select CodigoActivo,isnull(CentroDeCosto,'')CentroDeCosto,Nombre " _
                            & "   From DbActivosFijos.dbo.tblactivosfijos a " _
                            & "  where activo = 1 " _
                            & "    and (CodigoActivo =  " & Send(CodigoActivo) _
                            & IIf(Not F_Null(CentroDeCosto), "   or CentroDeCosto = " & Send(CentroDeCosto) & ")", ")"))
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarLaboresCostos(ClaveDeLabor As String, CentroDeCosto As String) As DataRow
        Try
            Return db.ConsultarFilaTabla(" Declare @VCuentaContableN1 char(1) , @VCuentaContableN2 char(1) , @VCuentaContableN3 char(2) , @lExito int , @lMensaje varchar(100) " _
                      & " exec DbContabilidad.dbo.UpValidarLaboresCostos  " & Send(ClaveDeLabor) & " , " _
                      & Send(CentroDeCosto) & " , @VCuentaContableN1 output, @VCuentaContableN2 output, @VCuentaContableN3 output, @lExito output, @lMensaje output " _
                      & " select isnull(@VCuentaContableN1,'') as CuentaN1 , isnull(@VCuentaContableN2,'') as CuentaN2 , isnull(@VCuentaContableN3,'') as CuentaN3 , @lExito as Exito , @lMensaje as Mensaje ")

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarLaboresCostosMaquinaria(ClaveDeLabor As String, CentroDeCosto As String) As DataRow
        Try
            Return db.ConsultarFilaTabla(" Declare @VCuentaContableN1 char(1) , @VCuentaContableN2 char(1) , @VCuentaContableN3 char(2) , @lExito int , @lMensaje varchar(100) " _
                     & " exec DbContabilidad.dbo.UpValidarLaboresCostosMaquinaria  " & Send(ClaveDeLabor) & " , " _
                     & Send(CentroDeCosto) & " , @VCuentaContableN1 output, @VCuentaContableN2 output, @VCuentaContableN3 output, @lExito output, @lMensaje output " _
                     & " select isnull(@VCuentaContableN1,'') as CuentaN1 , isnull(@VCuentaContableN2,'') as CuentaN2 , isnull(@VCuentaContableN3,'') as CuentaN3 , @lExito as Exito , @lMensaje as Mensaje ")

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ConsultarCuentaN3(CuentaN3 As String) As DataRow
        Try
            If Not F_Null(CuentaN3) Then
                Return db.ConsultarFilaTabla(" Select DescripcionCuenta From DbContabilidad.dbo.vwCatalogoCuentasContablesN3 " _
                  & "  Where CuentaContable = " & Send(CuentaN3))
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function ConsultarTipoCuenta(ByVal xCuenta As String) As DataRow
        Try
            Dim dr As DataRow = db.ConsultarFilaTabla(" Select CodigoAplicacion " _
              & "    From DbCooperativa..TblContaCuentasEspeciales " _
              & "   Where CuentaContableFull = " & Send(xCuenta))
            Return dr
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class

