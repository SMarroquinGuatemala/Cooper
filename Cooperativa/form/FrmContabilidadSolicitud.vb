Public Class FrmContabilidadSolicitud
#Region "Propiedades"
    Private _Solicitud As Integer
    Private _IdDocumento As String = String.Empty
    Private _IdMovimiento As String = String.Empty
    Private _Modo As ModosDeTecleo = ModosDeTecleo.Grabar
    Private _Estado As Int16 = 0
    Private _Modulo As String = "SOL"
    Private _ModoDocumento As ModosDeTecleo = ModosDeTecleo.Grabar
    Private _isExecuteQuery As Boolean = False
    Private _TipoDeCuenta As String = String.Empty
    Private LaboresCostos As New clsLaboresCostos
    Private clsContabilidadDocumento As New CooperativaBLL.clsTransDocumentos

    Public ReadOnly Property CuentaContable As String
        Get
            Return txtCuentaContableContabilidad.Text
        End Get
    End Property
    Public Property Saldo As String
        Get
            Return lblSaldoContabilidad.Text
        End Get
        Set(value As String)
            lblSaldoContabilidad.Text = value
        End Set
    End Property
    Public Property TipoCuenta As String
        Get
            Return _TipoDeCuenta
        End Get
        Set(value As String)
            _TipoDeCuenta = value
        End Set
    End Property

    Public Property IdDocumento() As Integer
        Get
            Return _IdDocumento
        End Get
        Set(ByVal value As Integer)
            _IdDocumento = value
        End Set
    End Property

    Public Property IdMovimiento() As Integer
        Get
            Return _IdMovimiento
        End Get
        Set(ByVal value As Integer)
            _IdMovimiento = value
        End Set
    End Property
    Public Property Solicitud() As Integer
        Get
            Return _Solicitud
        End Get
        Set(ByVal value As Integer)
            _Solicitud = value
        End Set
    End Property

    Public Property isExecuteQuery As Boolean
        Get
            Return _isExecuteQuery
        End Get
        Set(value As Boolean)
            _isExecuteQuery = value
        End Set
    End Property
    Property Modo As ModosDeTecleo
        Get
            Return _Modo
        End Get
        Set(value As ModosDeTecleo)
            _Modo = value
            If value = ModosDeTecleo.Consultar Then
                cmdGrabarContabilidad.Enabled = False
            Else
                cmdGrabarContabilidad.Enabled = True
            End If
        End Set
    End Property


#End Region

    Private Sub FrmContabilidadSolicitud_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Dispose()
            End If
        Catch ex As Exception
            F_Error(ex, "Reconocer tecla presionada")
        End Try
    End Sub

    Private Sub txtCuenta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaContableContabilidad.Validating
        Try
            If txtCuentaContableContabilidad.isNull Then
                lblNombreCuentaContabilidad.Text = ""
            Else
                e.Cancel = Not Valid_CuentaContable()
                If Not e.Cancel Then TipoCuenta = LaboresCostos.Get_TipoCuenta(txtCuentaContableContabilidad.Text)

            End If
        Catch ex As Exception
            F_Error(ex, "Validar cuenta contable")
        End Try
    End Sub



    Private Function Valid_CuentaContable() As Boolean
        Try
            Valid_CuentaContable = False

            If Not F_Null(txtCuentaContableContabilidad.Text) Then

                txtCuentaContableContabilidad.Text = FindItem(ItemsToFind.CuentasContables, txtCuentaContableContabilidad.Text)

                If Not F_Null(RowFound) Then
                    txtCuentaContableContabilidad.Text = RowFound("CuentaContable").ToString
                    lblNombreCuentaContabilidad.Text = RowFound("Descripcion").ToString
                    Valid_CuentaContable = True
                    'Return True
                Else
                    lblNombreCuentaContabilidad.Text = "Cuenta Invalida"
                    Return False
                End If

            End If


            If Not Valid_CuentaContable Then TipoCuenta = LaboresCostos.Get_TipoCuenta(txtCuentaContableContabilidad.Text)

            Return Valid_CuentaContable
        Catch ex As Exception
            F_Error(ex, "Validar Cuenta Contable")
        End Try
    End Function

    Sub ExecuteQuery()
        Try
            isExecuteQuery = True
            Dim rwMovimiento As DataRow = clsContabilidadDocumento.ConsultarMovimientoContableDocumento(Solicitud, IdDocumento, IdMovimiento)
            If Not F_Null(rwMovimiento) Then

                txtCuentaContableContabilidad.Text = rwMovimiento("CuentaContable").ToString
                txtDescripcionContabilidad.Text = rwMovimiento("Descripcion").ToString
                txtValorContabilidad.Text = rwMovimiento("Valor").ToString
                'If (rwMovimiento("RegistroReservado").ToString) = "R" Or Modo = ModosDeTecleo.Consultar Then
                '    Modo = ModosDeTecleo.Consultar
                'Else
                '    Modo = ModosDeTecleo.Modificar
                'End If
                Valid_CuentaContable()
                Me.ActiveControl = txtDescripcionContabilidad
            End If
        Catch ex As Exception
            Throw
        Finally
            isExecuteQuery = False
        End Try
    End Sub

    Private Sub FrmContabilidadSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Modo = ModosDeTecleo.Modificar Or Modo = ModosDeTecleo.Consultar Then
                ExecuteQuery()
            Else
                Me.ActiveControl = txtCuentaContableContabilidad
            End If
        Catch ex As Exception
            F_Error(ex, "Cargar formulario")
        End Try
    End Sub

    Function DatosValidos() As Boolean
        Try
            If Not Valid_CampoObligatorio(txtCuentaContableContabilidad, , True) Or
                   Not Valid_CampoObligatorio(txtDescripcionContabilidad, , True) Or
                    Not Valid_CampoObligatorio(txtValorContabilidad, , True) Then
                Return False
            End If
            If CDbl(txtValorContabilidad.Text) = 0 Then
                MsgBox("El valor no puede ser 0 ")
                Return False
            End If
            txtDescripcionContabilidad.Text = Trim(txtDescripcionContabilidad.Text.Replace(vbCrLf, ""))
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabarContabilidad.Click
        Try
            If DatosValidos() Then
                Me.Cursor = Cursors.WaitCursor
                If Modo = ModosDeTecleo.Grabar Then
                    clsContabilidadDocumento.GrabarDocumento(Solicitud, IdDocumento, GetNivelCuenta(CuentaContable, 1),
                                                             GetNivelCuenta(CuentaContable, 2), GetNivelCuenta(CuentaContable, 3), GetNivelCuenta(CuentaContable, 4),
                                                             txtDescripcionContabilidad.Text, txtValorContabilidad.Text, TipoCuenta,
                                                             IdMovimiento)
                    MensajeDeSistema(Me, "Movimiento contable grabado")
                    Modo = ModosDeTecleo.Modificar
                    If MsgBox("¿Desea grabar otro movimiento?", MsgBoxStyle.YesNo, "MensajeDeSistema") = MsgBoxResult.Yes Then
                        LimpiarVariables()
                    Else
                        Me.Dispose()
                    End If
                ElseIf Modo = ModosDeTecleo.Modificar Then
                    clsContabilidadDocumento.ModificarMovimiento(Solicitud, IdDocumento, GetNivelCuenta(CuentaContable, 1),
                                                             GetNivelCuenta(CuentaContable, 2), GetNivelCuenta(CuentaContable, 3), GetNivelCuenta(CuentaContable, 4),
                                                             txtDescripcionContabilidad.Text, txtValorContabilidad.Text, TipoCuenta,
                                                             IdMovimiento)
                    MensajeDeSistema(Me, "Movimiento contable modificado")
                    Me.Dispose()
                End If

            End If
        Catch ex As Exception
            F_Error(ex, "Grabar movimiento")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Sub LimpiarVariables()
        Try
            lblNombreCuentaContabilidad.Text = ""
            txtCuentaContableContabilidad.Text = ""
            txtValorContabilidad.Text = "0.00"
            IdMovimiento = 0
            Me.ActiveControl = txtCuentaContableContabilidad
        Catch ex As Exception
            Throw
        End Try
    End Sub

 
End Class