

Public Class FrmSolicitud
    Private clsSolicitud As New CooperativaBLL.clsSolicitudes
    Private clsDocumento As New CooperativaBLL.clsDocumentos
    Private clsContabilidad As New CooperativaBLL.clsTransDocumentos
    Private clstransacciones As New CooperativaBLL.clsTransacciones
    Private isCalculaIva As Boolean = False
    Private isMovVentas As Boolean = False
    Private isMovRetencion As Boolean = False
    Private xTasaDelIva As Double = 0.0
    Private xTasaDelISRBienes As Double = 0.0
    Private Get_TasaRetencion As Double = 0.0
    Private xTasaDelISRServicios As Double = 0.0
    Private isAplicaRetencion As Boolean = False
    Private clsBancos As New CooperativaBLL.clsBancos


#Region "Propiedades"
    Private _Solicitud As Integer
    Private _OrigenTransaccion As Int16
    Private _IdDocumento As Integer = 0
    Private _Modo As ModosDeTecleo = ModosDeTecleo.Grabar
    Private _Estado As Int16 = 0
    Private _ModoDocumento As ModosDeTecleo = ModosDeTecleo.Grabar
    Private _isExecuteQuery As Boolean = False
    Private _TipoDocumentoOriginal As String = String.Empty
    Private _NumeroDocumentoOriginal As String = String.Empty
    Private _ProveedorOriginal As String = String.Empty

    Private _IdMovimiento As Integer = 0
    Private _ModoContabilidad As ModosDeTecleo = ModosDeTecleo.Grabar

    Private _TipoDeCuenta As String = String.Empty
    Private LaboresCostos As New clsLaboresCostos
    Private clsContabilidadDocumento As New CooperativaBLL.clsTransDocumentos


    Private _isMovBancos As Boolean = False
    Public Property isMovBancos() As Boolean
        Get
            Return _isMovBancos
        End Get
        Set(ByVal value As Boolean)
            _isMovBancos = value
            HabilitarCamposDeBanco(value)
        End Set
    End Property

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

    Public Property IdMovimiento() As Integer
        Get
            Return _IdMovimiento
        End Get
        Set(ByVal value As Integer)
            _IdMovimiento = value
        End Set
    End Property

    Property ModoContabilidad As ModosDeTecleo
        Get
            Return _ModoContabilidad
        End Get
        Set(value As ModosDeTecleo)
            _ModoContabilidad = value
            If value = ModosDeTecleo.Consultar Then
                cmdGrabarContabilidad.Enabled = False
            Else
                cmdGrabarContabilidad.Enabled = True
            End If
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
    Public Property OrigenTransaccion As Int16
        Get
            Return _OrigenTransaccion
        End Get
        Set(value As Int16)
            _OrigenTransaccion = value
            clstransacciones.EstablecerOrigenTransaccion(value)
            Me.Text = ("Tecleo " & clstransacciones.Nombre)
            Me.isMovBancos = clstransacciones.isMovBancos
        End Set
    End Property

    Public Property IdDocumento As Integer
        Get
            Return _IdDocumento
        End Get
        Set(ByVal value As Integer)
            _IdDocumento = value
        End Set
    End Property


    Public Property Estado As Int16
        Get
            Return _Estado
        End Get
        Set(value As Int16)
            _Estado = value
            If value > 0 Then
                LblEstado.Text = clsSolicitud.ConsultarEstadoSolicitud(_Estado)("DescripcionActual").ToString
            Else
                LblEstado.Text = ""
            End If
        End Set
    End Property

    Public Property Solicitud As String
        Get
            Return _Solicitud
        End Get
        Set(value As String)
            _Solicitud = value
            lblSolicitud.Text = _Solicitud
            Me.Text = String.Concat(New String() {":", Me.clstransacciones.Nombre, "#: ", Me.Solicitud, ":"})
        End Set
    End Property


    Property Modo As ModosDeTecleo
        Get
            Return _Modo
        End Get
        Set(value As ModosDeTecleo)
            _Modo = value
            If _Modo = ModosDeTecleo.Grabar Then
                grbDetalle.Enabled = False
                LimpiarDocumento()
                cmdGrabarEncabezado.Enabled = True
                cmdEliminarSolicitud.Enabled = False
            ElseIf _Modo = ModosDeTecleo.Modificar Then
                grbDetalle.Enabled = True
                cmdGrabarEncabezado.Enabled = True
                cmdEliminarSolicitud.Enabled = True
            ElseIf _Modo = ModosDeTecleo.Consultar Then
                cmdGrabarEncabezado.Enabled = False
                cmdContabilizar.Enabled = False
                cmdEliminarSolicitud.Enabled = False
            End If
        End Set
    End Property
    Property ModoDocumento As ModosDeTecleo
        Get
            Return _ModoDocumento
        End Get
        Set(value As ModosDeTecleo)
            _ModoDocumento = value


            If value = ModosDeTecleo.Grabar Then
                _TipoDocumentoOriginal = String.Empty
                _ProveedorOriginal = String.Empty
                _NumeroDocumentoOriginal = String.Empty
                cmdNuevoDocumento.Enabled = False
                cmdEliminarDocumento.Enabled = False
                grbContabilidad.Enabled = False
            ElseIf value = ModosDeTecleo.Modificar Then
                _TipoDocumentoOriginal = cboTipoDocumento.Codigo
                _ProveedorOriginal = TxtProveedor.Text
                _NumeroDocumentoOriginal = TxtNumeroDocumento.Text
                cmdNuevoDocumento.Enabled = True
                cmdEliminarDocumento.Enabled = True
                grbContabilidad.Enabled = True
            End If
            If Modo = ModosDeTecleo.Consultar Then
                _ModoDocumento = ModosDeTecleo.Consultar
                cmdGrabarDocumento.Enabled = False
                cmdEliminarDocumento.Enabled = False
                cmdNuevoDocumento.Enabled = False
                grbContabilidad.Enabled = False
            End If
        End Set
    End Property

#End Region

    Private Sub FrmSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Combos(cboMoneda)
            Fill_Combos(cboTipoDocumento, , OrigenTransaccion)
            Fill_Combos(cboBancos)
            Fill_Combos(cboBaseLegal)
            cboBancos.Codigo = "003"
            Fill_Combos(cboCuentasBancarias, , cboBancos.Codigo)
            TxtFechaDePago.Text = Date.Now.ToShortDateString
            TxtFechaSolicitud.Text = Date.Now.ToShortDateString
            cboMoneda.Codigo = "GTQ"
            ActiveControl = TxtNombre
            If Modo = ModosDeTecleo.Modificar Then ExecuteQuery()
            AplicaEfectoControles(Me)
        Catch ex As Exception
            F_Error(ex, "Cargar Form: " & Menu.Name)
        End Try
    End Sub


    Private Sub FrmSolicitud_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Close()
    End Sub


    Private Sub ExecuteQuery()
        Try
            isExecuteQuery = True
            xRowDefault = Nothing : xRowDefault = clsSolicitud.ConsultarSolicitud(Solicitud)
            If xRowDefault IsNot Nothing Then
                TxtNombre.Text = xRowDefault.Item("Nombre").ToString
                TxtFechaSolicitud.Text = xRowDefault.Item("Fecha").ToString
                TxtFechaDePago.Text = xRowDefault.Item("Fecha").ToString
                TxtUtilizacion.Text = xRowDefault.Item("Observaciones").ToString
                TxtDescripcion.Text = xRowDefault.Item("Descripcion").ToString
                cboBancos.Text = ""
                Fill_Combos(cboCuentasBancarias)
                cboCuentasBancarias.Text = xRowDefault.Item("CuentaBancaria").ToString
                TxtDocumentoBancos.Text = xRowDefault.Item("NumeroDocumento").ToString
                TxtFechaDocumento.Text = xRowDefault.Item("FechaDocumento").ToString
                txtValor.Text = F_Format(xRowDefault.Item("Valor").ToString, , 2)
                Estado = Split(xRowDefault.Item("Estado").ToString, "-")(0)
                chkValidSolicitud.Checked = CBool(xRowDefault.Item("isValid").ToString)

                Fill_GrdDocumentos()
                If (Estado >= 3) Then
                    Modo = ModosDeTecleo.Consultar
                ElseIf chkValidSolicitud.Checked Then
                    cmdContabilizar.Enabled = True
                    cmdBoletaTransaccion.Enabled = True
                Else
                    cmdContabilizar.Enabled = False
                    cmdBoletaTransaccion.Enabled = False
                End If

            End If

        Catch ex As Exception
            Throw ex
        Finally
            isExecuteQuery = False
        End Try
    End Sub



    Private Sub grdSolicitudMovimientoBancos_SelectionChanged(sender As Object, e As EventArgs) Handles grdContabilidad.SelectionChanged
        Try

        Catch ex As Exception
            F_Error(ex, "seleccion")
        End Try
    End Sub

    Private Sub txtProveedorSolicitud_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtProveedorSolicitud.Validating
        Try
            If Not txtProveedorSolicitud.isNull Then
                txtProveedorSolicitud.Text = FindItem(ItemsToFind.Proveedores, txtProveedorSolicitud.Text)
                If Not F_Null(RowFound) Then
                    TxtNombre.Text = RowFound("NombreLargo").ToString
                Else
                    TxtNombre.Text = ""
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Buscar proveedor")
        End Try
    End Sub

    Private Sub cmdGrabarEncabezado_Click(sender As Object, e As EventArgs) Handles cmdGrabarEncabezado.Click
        Try
            If EncabezadoValido() Then
                If Modo = ModosDeTecleo.Grabar Then

                    Solicitud = clsSolicitud.GrabarSolicitud(OrigenTransaccion, TxtFechaSolicitud.Text, TxtNombre.Text,
                                                 TxtDescripcion.Text, txtValor.Text, TxtUtilizacion.Text, False)

                    Modo = ModosDeTecleo.Modificar
                    MensajeDeSistema(Me, "Solicitud grabada, por favor continue grabando los documentos")
                    lblSolicitud.Text = Solicitud
                    Estado = 1

                ElseIf Modo = ModosDeTecleo.Modificar Then
                    clsSolicitud.ModificarSolicitud(TxtNombre.Text,
                                                 TxtDescripcion.Text, TxtUtilizacion.Text, txtValor.Text, cboCuentasBancarias.Codigo, Solicitud)
                    MensajeDeSistema(Me, "Solicitud modificada correctamente.")
                End If
                ActiveControl = cboTipoDocumento
            End If
        Catch ex As Exception
            F_Error(ex, "Grabar o modificar encabezado")
        End Try
    End Sub

    Private Function EncabezadoValido() As Boolean
        Try
            If txtValor.isNull Then txtValor.Text = "0.00"
            If Not Valid_CampoObligatorio(TxtNombre) Or _
                Not Valid_CampoObligatorio(TxtDescripcion) Or _
                Not Valid_CampoObligatorio(cboMoneda) Then

                Return False
            Else
                If cboMoneda.Codigo <> "GTQ" AndAlso (Val(TxtTipoDeCambio.Text) <= 1 Or Val(TxtTipoDeCambio.Text) <= 0) Then
                    ShowMsgBox("Valor de tipo de cambio invalido")
                    Return False
                End If
                If TxtTipoDeCambio.isNull And cboMoneda.Codigo = "GTQ" Then TxtTipoDeCambio.Text = "1"
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub cboMoneda_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboMoneda.Validating
        Try
            If cboMoneda.Codigo <> "GTQ" Then
                TxtTipoDeCambio.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
                TxtTipoDeCambio.Text = "0.00"
                TxtValorOtraMoneda.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
            Else
                TxtTipoDeCambio.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
                TxtTipoDeCambio.Text = "1"
                TxtValorOtraMoneda.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
            End If
        Catch ex As Exception
            F_Error(ex, "Validar Moneda")
        End Try
    End Sub

    Private Sub txtValor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtValor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ActiveControl = cmdGrabarEncabezado
        End If
    End Sub

    Private Sub txtValor_MouseDown(sender As Object, e As MouseEventArgs) Handles txtValor.MouseDown

    End Sub

    Private Sub txtValor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtValor.Validating
        Try

        Catch ex As Exception
            F_Error(ex, "Validar valor")
        End Try
    End Sub

    Private Sub cmdGrabarEncabezado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmdGrabarEncabezado.Validating
        ' If Not e.Cancel Then ActiveControl = txtValor
    End Sub



    Private Sub TxtFecha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtFecha.Validating
        Try
            If Not TxtFecha.isNull Then
                If Not IsDate(TxtFecha.Text) Then
                    MsgBox("Fecha invalida")
                    e.Cancel = True
                End If
                If Not e.Cancel Then
                    xTasaDelIva = clsDocumento.ConsultarTasaDelIVA(TxtFecha.Text)
                    Establecer_TasaRetencionISR()
                    Format_Ordenes()
                    f_ValorLiquido()
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Validar fecha")
        End Try

    End Sub

    Private Sub TxtValorBienes_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtValorBienes.Validating
        If Not TxtValorBienes.isNull Then
            f_ValorLiquido()
        End If
    End Sub

    Private Sub TxtDocumento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNumeroDocumento.Validating
        Try
            If Not TxtNumeroDocumento.isNull Then
                TxtNumeroDocumento.Text = F_Ceros(TxtNumeroDocumento.Text, 10)
                e.Cancel = Not clsDocumento.Valid_PrimaryKey(Solicitud, TxtProveedor.Text,
                                                                    cboTipoDocumento.Codigo,
                                                                    TxtNumeroDocumento.Text, TxtSerie.Text,
                                                                    isExecuteQuery, ModoDocumento, isCalculaIva)

            End If
        Catch ex As Exception
            F_Error(ex, "Validar Documento")
        End Try
    End Sub

    Private Sub TxtProveedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtProveedor.Validating
        Try
            If Not TxtProveedor.isNull Then

                e.Cancel = Not Valid_Proveedor


                If Not e.Cancel Then e.Cancel = Not clsDocumento.Valid_PrimaryKey(Solicitud, TxtProveedor.Text,
                                                                    cboTipoDocumento.Codigo,
                                                                    TxtNumeroDocumento.Text, TxtSerie.Text,
                                                                    isExecuteQuery, ModoDocumento, isCalculaIva)
                If (cboTipoDocumento.Codigo = "FAV" Or _
                    cboTipoDocumento.Codigo = "FES" Or _
                    (cboTipoDocumento.Codigo = "NCR" And Modulo <> "BCO") Or _
                    (cboTipoDocumento.Codigo = "NDB" And Modulo <> "BCO") Or _
                    cboTipoDocumento.Codigo = "FAC" Or _
                    cboTipoDocumento.Codigo = "REC" Or _
                    (cboTipoDocumento.Codigo = "OTR")) _
                        And RTrim(TxtProveedor.Text) = "0" Then
                    MsgBox("Debe ingresar un proveedor válido, o diferente de cero, verifique", vbInformation, "MensajeDeSistema")
                    e.Cancel = True
                End If

                If Not e.Cancel Then f_ValorLiquido()
            End If
        Catch ex As Exception
            F_Error(ex, "Validar proveedor")
        End Try
    End Sub

    Private Sub cboTipoDocumento_KeyUp(sender As Object, e As KeyEventArgs) Handles cboTipoDocumento.KeyUp
        modFunciones.KeyTab(Me, CInt(e.KeyCode), Me.TxtFecha)
    End Sub

    Private Sub cboTipoDocumento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboTipoDocumento.Validating
        Try
            If Not cboTipoDocumento.isNull Then
                If Not isExecuteQuery Then
                    If Not e.Cancel Then
                        e.Cancel = Not clsDocumento.Valid_PrimaryKey(Solicitud, TxtProveedor.Text,
                                                                    cboTipoDocumento.Codigo,
                                                                    TxtNumeroDocumento.Text, TxtSerie.Text,
                                                                    isExecuteQuery, ModoDocumento, isCalculaIva)
                    End If
                    If Not e.Cancel Then Format_Ordenes()
                End If
                Establecer_ModoDocumento()
                isAplicaReclamoIVA()

            End If
        Catch ex As Exception
            F_Error(ex, "Validar Documento")
        End Try
    End Sub

    Sub Format_Ordenes()
        Try
            Dim TipoDocumento As String = cboTipoDocumento.Codigo

            If TipoDocumento = "OTR" Then
                TxtValorExcentoIva.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
            ElseIf TipoDocumento = "REC" Then
                TxtValorServicios.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
                TxtValorExcentoIva.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
            Else
                TxtValorExcentoIva.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
                TxtValorServicios.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
            End If

            If (TipoDocumento = "OTR" Or
                    TipoDocumento = "FAV" Or
                    TipoDocumento = "FAC" Or
                    TipoDocumento = "BTA") And
                    RTrim(TxtProveedor.Text) = "0" Then
                TxtNombreProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
            End If

            If TipoDocumento = "OTR" And TxtProveedor.Text <> "0" Then TxtNombreProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque



        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Establecer_ModoDocumento()
        Try
            Dim dr As DataRow = clsDocumento.ConsultarModoDocumento(cboTipoDocumento.Codigo)
            If Not F_Null(dr) Then
                isCalculaIva = dr("isCalculaIva")
                isMovVentas = dr("isMovVentas")
                isMovRetencion = dr("isMovRetencion")
            End If

            If isCalculaIva Then lblBienes.Text = "Bienes" Else lblBienes.Text = "Valor"

            lblExcento.Visible = isCalculaIva
            TxtValorExcentoIva.Visible = isCalculaIva
            lblValorIva.Visible = isCalculaIva
            txtValorIVA.Visible = isCalculaIva

            cboBaseLegal.Visible = isMovVentas
            lblBaseLegal.Visible = isMovVentas


        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub isAplicaReclamoIVA()
        If Not isExecuteQuery Then
            If isCalculaIva Then ' si son facturas u otros
                chkReclamaIVA.Checked = True
            Else
                chkReclamaIVA.Checked = False
            End If
        End If
    End Sub

    Sub Establecer_TasaRetencionISR()
        Try
            If (Val(F_UnFormat(TxtValorServicios.Text)) < 2800 And Val(F_UnFormat(TxtValorBienes.Text)) < 2800) And cboTipoDocumento.Codigo = "FAC" Then
                xTasaDelISRBienes = 0
                Get_TasaRetencion = 0
                xTasaDelISRServicios = 0
            Else
                If Not F_Null(TxtFecha.Text) Then
                    xTasaDelISRBienes = clsDocumento.ConsultarTasaDelISR(TxtFecha.Text, "REC", "B")
                    xTasaDelISRServicios = clsDocumento.ConsultarTasaDelISR(TxtFecha.Text, "REC", "S")
                    If isAplicaRetencion Then Get_TasaRetencion = xTasaDelISRBienes
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub TxtSerie_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtSerie.KeyUp
        KeyTab(Me, CInt(e.KeyCode), Me.TxtNumeroDocumento)
    End Sub

    Private Sub TxtSerie_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtSerie.Validating
        TxtSerie.Text = TxtSerie.Text.ToString.ToUpper
        If Not e.Cancel Then
            Me.ActiveControl = Me.TxtNumeroDocumento
        End If

    End Sub

    Private Function Valid_Proveedor() As Boolean
        Try
            If Not (TxtProveedor.isNull) Then
                TxtProveedor.Text = FindItem(ItemsToFind.Proveedores, TxtProveedor.Text)
                If Not F_Null(RowFound) Then
                    TxtNombreProveedor.Text = RowFound("NombreLargo").ToString
                    txtNIT.Text = RowFound("NitProveedor").ToString
                Else
                    TxtNombreProveedor.Text = ""
                    txtNIT.Text = ""
                    Return False
                End If

                isAplicaRetencion = False
                Get_TasaRetencion = 0
                'Retencion de proveedor
                If Not F_Null(txtNIT.Text) AndAlso CBool(RowFound("AplicaRetencion")) Then
                    isAplicaRetencion = True
                    If RowFound("TipoREtencion").ToString = 2 Then
                        isAplicaRetencion = False
                        Get_TasaRetencion = 0
                    End If

                Else
                    isAplicaRetencion = False
                End If


                Establecer_TasaRetencionISR() '--Cambio  de retencion elopez 29/05/2013
                Return True
            Else
                TxtNombreProveedor.Text = ""
                txtNIT.Text = ""
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function




    Private Sub LimpiarDocumento()

        TxtFecha.Text = "__/__/____"
        TxtSerie.Text = ""
        TxtNumeroDocumento.Text = ""
        chkReclamaIVA.Checked = True
        TxtValorBienes.Text = "0.00"
        TxtValorServicios.Text = "0.00"
        txtValorIVA.Text = "0.00"
        TxtValorLiquido.Text = "0.00"
        TxtValorTotal.Text = "0.00"
        TxtValorExcentoIva.Text = "0.00"
        TxtIvaBienes.Text = "0.00"
        TxtIvaBienesGasto.Text = "0.00"
        TxtIvaServicios.Text = "0.00"
        TxtIvaServiciosGasto.Text = "0.00"
        cboBaseLegal.Text = ""
        ActiveControl = TxtFecha
        ModoDocumento = ModosDeTecleo.Grabar
        cmdContabilizar.Enabled = False
        cmdBoletaTransaccion.Enabled = False
        LimpiarVariablesContabilidad()
        LimpiarGrid(grdContabilidad)

    End Sub



    Private Sub cmdGrabarDocumento_Click(sender As Object, e As EventArgs) Handles cmdGrabarDocumento.Click
        Try
            If DocumentoValido() Then
                Cursor = Cursors.WaitCursor
                If ModoDocumento = ModosDeTecleo.Grabar Then
                    IdDocumento = clsDocumento.GrabarDocumento(Solicitud,
                                                               TxtProveedor.Text,
                                                               cboTipoDocumento.Codigo,
                                                               TxtSerie.Text,
                                                               TxtNumeroDocumento.Text,
                                                               TxtNombreProveedor.Text,
                                                               TxtFecha.Text,
                                                               FechaOperacion,
                                                               TxtValorBienes.Text,
                                                               TxtValorServicios.Text,
                                                               TxtValorExcentoIva.Text,
                                                               txtValorIVA.Text,
                                                               txtValorRetencion.Text,
                                                               txtValorRetencionBienes.Text,
                                                               TxtValorLiquido.Text, 0,
                                                               TxtValorTotal.Text, False,
                                                               txtOrdenDeCompra.Text,
                                                               txtOrdenDeServicio.Text, chkReclamaIVA.Checked,
                                                               1,
                                                               TxtIvaBienes.Text,
                                                               TxtIvaServicios.Text,
                                                               TxtIvaBienesGasto.Text,
                                                               TxtIvaServiciosGasto.Text,
                                                               txtNIT.Text,
                                                               cboMoneda.Codigo,
                                                               TxtTipoDeCambio.Text,
                                                               cboBaseLegal.Codigo,
                                                               "001")

                    MensajeDeSistema(Me, "Documento grabado correctamente.")

                    If MsgBox("¿Desea grabar otro documento?", MsgBoxStyle.YesNo, "Mensaje De Sistema") = MsgBoxResult.Yes Then
                        LimpiarDocumento()
                        ActiveControl = cboTipoDocumento
                    Else
                        ModoDocumento = ModosDeTecleo.Modificar
                    End If

                ElseIf ModoDocumento = ModosDeTecleo.Modificar Then
                    clsDocumento.ModificarDocumento(Solicitud, TxtProveedor.Text, cboTipoDocumento.Codigo, TxtSerie.Text, TxtNumeroDocumento.Text,
                                                TxtNombreProveedor.Text, TxtFecha.Text, FechaOperacion, TxtValorBienes.Text, TxtValorServicios.Text, TxtValorExcentoIva.Text, txtValorIVA.Text,
                                                txtValorRetencion.Text, txtValorRetencionBienes.Text, TxtValorLiquido.Text, 0, TxtValorTotal.Text, False, txtOrdenDeCompra.Text, txtOrdenDeServicio.Text,
                                                chkReclamaIVA.Checked, 1, TxtIvaBienes.Text, TxtIvaServicios.Text, TxtIvaBienesGasto.Text, TxtIvaServiciosGasto.Text, txtNIT.Text,
                                                cboMoneda.Codigo, TxtTipoDeCambio.Text, cboBaseLegal.Codigo, TxtFecha.Text, IdDocumento)
                    MensajeDeSistema(Me, "Documento modificado correctamente.")
                    ModoDocumento = ModosDeTecleo.Modificar
                End If
                Fill_GrdContabilidad()
                ValorLiquido()
            End If
        Catch ex As Exception
            F_Error(ex, "Grabar modificar documento")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Function DocumentoValido() As Boolean
        Try
            If TxtValorServicios.isNull Then TxtValorServicios.Text = "0.00"
            If TxtValorBienes.isNull Then TxtValorBienes.Text = "0.00"
            If TxtValorExcentoIva.isNull Then TxtValorExcentoIva.Text = "0.00"

            If Not Valid_CampoObligatorio(cboTipoDocumento) Or
                Not Valid_CampoObligatorio(TxtNumeroDocumento) Or
                 Not Valid_CampoObligatorio(TxtProveedor) Or
                  Not Valid_CampoObligatorio(TxtValorBienes) Or
                   Not Valid_CampoObligatorio(TxtValorServicios) Or
                    Not Valid_CampoObligatorio(TxtFecha) Or
                     Not Valid_CampoObligatorio(TxtNombreProveedor) Then
                Return False
            End If

            If (Me.isMovVentas AndAlso Not modFunciones.Valid_CampoObligatorio(Me.cboBaseLegal, Nothing, False)) Then
                Return False
            End If

            If Val(TxtValorBienes.Text) + Val(TxtValorServicios.Text) + Val(TxtValorExcentoIva.Text) = 0 Then
                MsgBox("Debe Ingresar un Valor", vbInformation, "MensajeDeSistema")
                ActiveControl = TxtValorBienes
                Return False
            End If

            If Not Valid_CampoObligatorio(TxtValorLiquido) Then Return False


            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub f_ValorLiquido()
        Try
            If Not isExecuteQuery Then
                TxtValorTotal.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, 0)) + Val(F_NVL(TxtValorServicios.Text, 0))), , 2)
                TxtValorTotal.Text = F_NVL(TxtValorTotal.Text, "0")

                If isCalculaIva Then
                    Dim xTasaRetencion As Double
                    xTasaRetencion = 0

                    If cboTipoDocumento.Codigo <> "REC" And cboTipoDocumento.Codigo <> "FES" Then

                        '===========================
                        If chkReclamaIVA.Checked Then
                            '---------------------------
                            'Local
                            TxtIvaBienes.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) / (1 + (xTasaDelIva)) * xTasaDelIva), 10, 2)
                            TxtIvaServicios.Text = F_Format((Val(F_NVL(TxtValorServicios.Text, "0")) / (1 + (xTasaDelIva)) * xTasaDelIva), 10, 2)

                        End If 'If OptisReclamaIVASi Then
                        '===========================
                        If Not chkReclamaIVA.Checked Then
                            TxtIvaBienesGasto.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) / (1 + (xTasaDelIva)) * xTasaDelIva), 10, 2)
                            TxtIvaServiciosGasto.Text = F_Format((Val(F_NVL(TxtValorServicios.Text, "0")) / (1 + (xTasaDelIva)) * xTasaDelIva), 10, 2)
                        End If 'OptisReclamaIVaNo Then 
                        '-------------------------------------------- 
                        xTasaRetencion = Get_TasaRetencion
                        Establecer_TasaRetencionISR() '--Cambio  de retencion elopez 29/05/2013
                        xTasaRetencion = Get_TasaRetencion
                        If isMovRetencion Then
                            calculaRetencionISR(3)
                        Else
                            txtValorRetencion.Text = "0.00"
                            txtValorRetencionBienes.Text = "0.00"
                        End If
                        '===========================================
                    ElseIf cboTipoDocumento.Codigo = "FES" Then
                        '-------------------------------------------
                        '===========================
                        If chkReclamaIVA.Checked Then
                            '---------------------------
                            'Local
                            TxtIvaBienes.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) / (1 + xTasaDelIva)) * xTasaDelIva)
                            TxtIvaServicios.Text = F_Format((Val(F_NVL(TxtValorServicios.Text, "0")) / (1 + xTasaDelIva)) * xTasaDelIva)

                        End If 'If OptisReclamaIVASi Then
                        If Not chkReclamaIVA.Checked Then
                            TxtIvaBienesGasto.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) / (1 + xTasaDelIva)) * xTasaDelIva)
                            TxtIvaServiciosGasto.Text = F_Format((Val(F_NVL(TxtValorServicios.Text, "0")) / (1 + xTasaDelIva)) * xTasaDelIva)
                        End If
                        calculaRetencionISR(2)

                        '====================== 
                    Else
                        If chkReclamaIVA.Checked Then
                            '---------------------------
                            'Local
                            TxtIvaBienes.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) * xTasaDelIva), 10, 2)
                            TxtIvaServicios.Text = F_Format((Val(F_NVL(TxtValorServicios.Text, "0")) * xTasaDelIva), 10, 2)

                        End If ' If OptisReclamaIVASi Then
                        If Not chkReclamaIVA.Checked Then
                            TxtIvaBienesGasto.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) * xTasaDelIva), 10, 2)
                            TxtIvaServiciosGasto.Text = F_Format((Val(F_NVL(TxtValorServicios.Text, "0")) * xTasaDelIva), 10, 2)
                        End If
                        calculaRetencionISR(1)
                    End If

                    txtValorIVA.Text = F_Format(Val(TxtIvaBienes.Text) + Val(TxtIvaServicios.Text) + Val(TxtIvaServiciosGasto.Text) + Val(TxtIvaBienesGasto.Text))


                Else
                    txtValorIVA.Text = "0.00"
                    TxtIvaBienes.Text = "0.00"
                    TxtIvaServicios.Text = "0.00"

                    TxtIvaBienesGasto.Text = "0.00"
                    TxtIvaServiciosGasto.Text = "0.00"

                    TxtValorExcentoIva.Text = "0.00"
                    txtValorRetencion.Text = "0.00"
                    txtValorRetencionBienes.Text = "0.00"
                End If

                If cboTipoDocumento.Codigo <> "FES" Then
                    TxtValorLiquido.Text = F_Format((Val(F_NVL(TxtValorBienes.Text, "0")) + Val(F_NVL(TxtValorServicios.Text, "0")) + Val(F_NVL(TxtValorExcentoIva.Text, "0"))), 2)
                Else
                    TxtValorLiquido.Text = F_Format((Val(TxtValorTotal.Text) / (1 + xTasaDelIva)))
                End If

                TxtValorTotal.Text = F_Format(Val(F_NVL(TxtValorBienes.Text, 0)) + Val(F_NVL(TxtValorServicios.Text, 0)) + Val(F_NVL(TxtValorExcentoIva.Text, 0)), 2)

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub chkReclamaIVA_Click(sender As Object, e As EventArgs) Handles chkReclamaIVA.Click
        Try
            f_ValorLiquido()
        Catch ex As Exception
            F_Error(ex, "Cambiar reclamo de IVA")
        End Try
    End Sub

    Private Sub TxtValorExcentoIva_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtValorExcentoIva.Validating
        Try
            f_ValorLiquido()
        Catch ex As Exception
            F_Error(ex, "Valor excento")
        End Try
    End Sub

    Private Sub TxtValorServicios_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtValorServicios.Validating
        Try
            f_ValorLiquido()
        Catch ex As Exception
            F_Error(ex, "valor servicios")
        End Try
    End Sub
    Public Sub Fill_GrdContabilidad()
        Try

            AutoajustarGrid(grdContabilidad,
                            clsContabilidad.ConsultarMovimientosContablesDocumento(Solicitud, IdDocumento))
            '===============================
            'CALCULA CARGOS ABONOS Y SALDO
            '-------------------------------
            TxtCargos.Text = F_Format(SumarColumna(grdContabilidad, "cellValor", False, "C"))
            TxtAbonos.Text = F_Format(SumarColumna(grdContabilidad, "cellValor", False, "A"))
            TxtSaldo.Text = F_Format(SumarColumna(grdContabilidad, "cellValor"))

        Catch ex As Exception
            F_Error(ex, "Llenar Grid Contabilidad")
        End Try
    End Sub
    Public Sub Fill_GrdDocumentos()
        Try

            AutoajustarGrid(grdIndice, clsDocumento.ConsultarDocumentos(Solicitud))
            Fill_GrdContabilidad()

        Catch ex As Exception
            F_Error(ex, "Llenar Grid Documentos")
        End Try
    End Sub

    Private Sub grdIndice_Click(sender As Object, e As EventArgs) Handles grdIndice.Click

    End Sub

    Private Sub grdIndice_SelectionChanged(sender As Object, e As EventArgs) Handles grdIndice.SelectionChanged
        Try

            If grdIndice.SelectedRows.Count = 1 And Not isExecuteQuery Then
                cboTipoDocumento.Codigo = grdIndice.SelectedRows(0).Cells("cellTipoDocumentoIndice").Value.ToString
                TxtProveedor.Text = grdIndice.SelectedRows(0).Cells("cellProveedorIndice").Value.ToString
                TxtNumeroDocumento.Text = grdIndice.SelectedRows(0).Cells("cellNumeroDocumentoIndice").Value.ToString
                IdDocumento = grdIndice.SelectedRows(0).Cells("cellIdDocumento").Value.ToString
                ModoDocumento = ModosDeTecleo.Modificar
                ExecuteQueryDocumento()
            End If


        Catch ex As Exception
            F_Error(ex, "Visualizar Documento")
        End Try
    End Sub

    Private Sub ExecuteQueryDocumento()
        Try
            xRowDefault = Nothing : xRowDefault = clsDocumento.ConsultarDocumento(Solicitud, IdDocumento)
            If xRowDefault IsNot Nothing Then
                cboTipoDocumento.Codigo = xRowDefault.Item("TipoDocumento").ToString
                cboTipoDocumento_Validating(cboTipoDocumento, New System.ComponentModel.CancelEventArgs())
                TxtFecha.Text = xRowDefault.Item("FechaDocumento").ToString
                TxtFecha_Validating(TxtFecha, New System.ComponentModel.CancelEventArgs())
                Me.cboBaseLegal.Codigo = modFunciones.xRowDefault.Item("BaseLegal").ToString
                TxtSerie.Text = xRowDefault.Item("Serie").ToString
                TxtNumeroDocumento.Text = xRowDefault.Item("NumeroDocumento").ToString
                TxtProveedor.Text = Trim(xRowDefault.Item("Proveedor").ToString)
                txtNIT.Text = Trim(xRowDefault.Item("NItProveedor").ToString)
                TxtNombreProveedor.Text = xRowDefault.Item("Descripcion")
                TxtValorBienes.Text = F_Format(xRowDefault.Item("ValorBienes").ToString, , 2)
                TxtValorServicios.Text = F_Format(xRowDefault.Item("ValorServicios").ToString, , 2)
                TxtValorExcentoIva.Text = F_Format(xRowDefault.Item("ValorExcentoIva").ToString, , 2)
                TxtValorLiquido.Text = F_Format(xRowDefault.Item("ValorLiquido").ToString, , 2)
                TxtValorTotal.Text = F_Format(xRowDefault.Item("ValorTotal").ToString, , 2)
                txtValorIVA.Text = F_Format(xRowDefault.Item("ValorIVA").ToString, , 2)
                TxtIvaBienes.Text = F_Format(xRowDefault.Item("IVaBienes").ToString, , 2)
                TxtIvaBienesGasto.Text = F_Format(xRowDefault.Item("IvaBienesGasto").ToString, , 2)
                TxtIvaServicios.Text = F_Format(xRowDefault.Item("IvaServicios").ToString, , 2)
                TxtIvaServiciosGasto.Text = F_Format(xRowDefault.Item("IvaServiciosGasto").ToString, , 2)
                chkReclamaIVA.Checked = CBool(xRowDefault("isReclamaIVA").ToString)
                txtOrdenDeCompra.Text = xRowDefault("OrdenDeCompra").ToString
                txtOrdenDeServicio.Text = xRowDefault("OrdenDeServicio").ToString
                txtValorRetencion.Text = xRowDefault("ValorRetencion").ToString
                txtValorRetencionBienes.Text = xRowDefault("ValorRetencionBienes").ToString

                Fill_GrdContabilidad()
            End If
        Catch ex As Exception
            F_Error(ex, "GetDatosDocumentos")
        End Try
    End Sub


    Sub LimpiarEncabezado()
        TxtNombre.Text = String.Empty
        cboBancos.Text = String.Empty
        cboCuentasBancarias.Text = String.Empty
        TxtFechaDocumento.Text = String.Empty
        TxtFechaSolicitud.Text = String.Empty
        TxtTipoDeCambio.Text = String.Empty
        TxtFechaDePago.Text = String.Empty
        TxtValorOtraMoneda.Text = String.Empty
        txtValor.Text = String.Empty
        cboMoneda.Codigo = "GTQ"
        TxtDescripcion.Text = String.Empty
        TxtUtilizacion.Text = String.Empty
        TxtNumeroDocumento.Text = String.Empty
        Estado = 0
        Solicitud = 0
        LimpiarDocumento()
        Modo = ModosDeTecleo.Grabar
        ActiveControl = TxtNombre
        Fill_GrdDocumentos()
    End Sub

    Private Sub cmdNuevoEncabezado_Click(sender As Object, e As EventArgs) Handles cmdNuevoEncabezado.Click
        Try
            LimpiarEncabezado()
            TxtProveedor.Text = String.Empty
            TxtNombreProveedor.Text = String.Empty
            txtNIT.Text = String.Empty
        Catch ex As Exception
            F_Error(ex, "Nuevo encabezado")
        End Try
    End Sub

    Private Sub cmdNuevoDocumento_Click(sender As Object, e As EventArgs) Handles cmdNuevoDocumento.Click
        Try
            LimpiarDocumento()
        Catch ex As Exception
            F_Error(ex, "Nuevo documento")
        End Try
    End Sub

    Private Sub cmdEliminarDocumento_Click(sender As Object, e As EventArgs) Handles cmdEliminarDocumento.Click
        Try
            If MsgBox("¿Desea eliminar este documento y todos sus cambios?", MsgBoxStyle.YesNo, "MensajeDeSistema") = MsgBoxResult.Yes Then
                clsDocumento.EliminarDocumento(Solicitud, IdDocumento)
                MensajeDeSistema(Me, "Documento eliminado con Exito")
                LimpiarDocumento()
                Fill_GrdDocumentos()
            End If
        Catch ex As Exception
            F_Error(ex, "Eliminar Documento")
        End Try
    End Sub

    Private Sub mnuGrabarContabilidad_Click(sender As Object, e As EventArgs) Handles mnuGrabarContabilidad.Click
        Try
            If ModoDocumento = ModosDeTecleo.Modificar Then
                Grabar()
            Else
                ShowMsgBox("Debe grabar un documento primero")
            End If

        Catch ex As Exception
            F_Error(ex, "Grabar contabilidad")
        End Try
    End Sub

    Public Sub HabilitarCamposDeBanco(ByVal Activos As Boolean)
        Me.cboBancos.Enabled = Activos
        Me.cboCuentasBancarias.Enabled = Activos
        Me.txtValor.TipoDeCampo = IIf(Activos, TiposDeCampo.Obligatorio, TiposDeCampo.Despliegue)
    End Sub




    Private Sub grdContabilidad_MouseDown(sender As Object, e As MouseEventArgs) Handles grdContabilidad.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                DeshabilitaMenuContextual(mnuContabilidad)
                mnuGrabarContabilidad.Enabled = True
                If grdContabilidad.SelectedRows.Count = 1 Then
                    mnuModificar.Enabled = True
                    mnuEliminar.Enabled = True
                End If

            End If
        Catch ex As Exception
            F_Error(ex, "Mostrar menu")
        End Try
    End Sub

    Private Sub Modificar()
        Try
            If Trim(grdContabilidad.SelectedRows.Item(0).Cells("cellTipoCuentaContable").Value.ToString) = "NOR" Then
                LimpiarVariablesContabilidad()
                IdMovimiento = grdContabilidad.SelectedRows.Item(0).Cells("cellIDMovimiento").Value.ToString
                ModoContabilidad = IIf(Modo = ModosDeTecleo.Consultar, ModosDeTecleo.Consultar, ModosDeTecleo.Modificar)
                If _TipoDocumentoOriginal <> "REC" Then
                    Saldo = "Saldo: " & F_Format(Val(TxtValorTotal.Text) - Val(F_NVL(txtValorIVA.Text, "0")) + Val(F_NVL(TxtIvaBienesGasto.Text, "0")) + Val(F_NVL(TxtIvaServiciosGasto.Text, "0"))).ToString
                Else
                    Saldo = "Saldo: " & F_Format(Val(TxtValorTotal.Text) + Val(F_NVL(TxtIvaBienesGasto.Text, "0")) + Val(F_NVL(TxtIvaServiciosGasto.Text, "0"))).ToString
                End If
                ExecuteQueryContabilidad()
            Else
                LimpiarVariablesContabilidad()
            End If
        Catch ex As Exception
            F_Error(ex, "Modificar")
        End Try
    End Sub

    Private Sub Grabar()
        Try
            LimpiarVariablesContabilidad()
            ModoContabilidad = IIf(Modo = ModosDeTecleo.Consultar, ModosDeTecleo.Consultar, ModosDeTecleo.Grabar)
            If _TipoDocumentoOriginal <> "REC" Then
                Saldo = "Saldo: " & F_Format(Val(TxtValorTotal.Text) - Val(F_NVL(txtValorIVA.Text, "0")) + Val(F_NVL(TxtIvaBienesGasto.Text, "0")) + Val(F_NVL(TxtIvaServiciosGasto.Text, "0"))).ToString
            Else
                Saldo = "Saldo: " & F_Format(Val(TxtValorTotal.Text) + Val(F_NVL(TxtIvaBienesGasto.Text, "0")) + Val(F_NVL(TxtIvaServiciosGasto.Text, "0"))).ToString
            End If

            IdMovimiento = 0
        Catch ex As Exception
            F_Error(ex, "Grabar")
        End Try
    End Sub

    Private Sub grdContabilidad_DoubleClick(sender As Object, e As EventArgs) Handles grdContabilidad.DoubleClick
        Try
            If grdContabilidad.Rows.Count > 0 Then
                Modificar()
            Else
                Grabar()
            End If
        Catch ex As Exception
            F_Error(ex, "Doble click")
        End Try
    End Sub

    Private Sub grdContabilidad_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles grdContabilidad.RowPrePaint
        Try
            If Trim(grdContabilidad.Rows(e.RowIndex).Cells("cellTipoCuentaContable").Value.ToString) <> "NOR" Then
                grdContabilidad.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Catch ex As Exception
            F_Error(ex, "Pintar grid")
        End Try
    End Sub

    Private Sub mnuModificar_Click(sender As Object, e As EventArgs) Handles mnuModificar.Click
        Try
            Modificar()
        Catch ex As Exception
            F_Error(ex, "Modificar linea")
        End Try
    End Sub

    Private Sub mnuEliminar_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        Try
            If grdContabilidad.SelectedRows.Count = 1 Then
                If MsgBox("¿Desea eliminar este movimiento contable?", vbYesNo, "MensajeDeSistema") = MsgBoxResult.Yes Then
                    clsContabilidad.EliminarMovimiento(Solicitud, IdDocumento,
                                                       grdContabilidad.SelectedRows(0).Cells("cellIdMovimiento").Value.ToString)
                    Fill_GrdContabilidad()
                    MensajeDeSistema(Me, "Linea eliminada exitosamente")
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Eliminar linea")
        End Try
    End Sub

    Public Sub calculaRetencionISR(TipoCalculo As Integer)
        Dim Total As Double, TasaExcedente As Double, RetencionFija As Double
        Const Top1 = 2799.99, Top2 = 33600, Top3 = 30000

        TasaExcedente = 0.07
        RetencionFija = 1500

        If xTasaDelISRServicios Or xTasaDelISRBienes Then
            TasaExcedente = 0
            RetencionFija = 0
        End If
        Total = 0
        If TipoCalculo = 1 Then '--Recibos
            Total = (CDbl(F_NVL(TxtValorServicios.Text, "0")) + CDbl(F_NVL(TxtValorBienes.Text, "0")))
            If Total <= Top3 Then
                txtValorRetencion.Text = F_Format((CDbl(F_NVL(TxtValorServicios.Text, "0") * xTasaDelISRServicios) + CDbl(F_NVL(TxtValorBienes.Text, "0") * xTasaDelISRBienes)), 10, 2)
            Else
                TxtValorRetencion.Text = F_Format(RetencionFija + ((Total - Top3) * TasaExcedente), 10, 2)
            End If
            'TxtValorRetencion.Text  = F_Format((CCur(F_NVL(TxtValorServicios.Text, "0") * xTasaDelISRServicios) + CCur(F_NVL(TxtValorBienes.Text, "0") * xTasaDelISRBienes)), 10, 2) <<--asi estaba antes
        ElseIf TipoCalculo = 2 Then '--FES



            Total = (CDbl(F_NVL(TxtValorServicios.Text, "0")))

            If Total <= Top2 Then
                txtValorRetencion.Text = F_Format((CDbl(Total / (1 + (xTasaDelIva))) * xTasaDelISRServicios))
            Else
                txtValorRetencion.Text = F_Format(RetencionFija + ( _
                                                                ( _
                                                                    CDbl(Total - Top2) / (1 + (xTasaDelIva)) _
                                                                 ) * TasaExcedente _
                                                                ), 10, 2)
            End If


            Total = (CDbl(F_NVL(TxtValorBienes.Text, "0")))
            If Total <= Top2 Then
                txtValorRetencionBienes.Text = F_Format((CDbl(Total / (1 + (xTasaDelIva))) * xTasaDelISRBienes))
            Else
                txtValorRetencionBienes.Text = F_Format(RetencionFija + ( _
                                                                ( _
                                                                    CDbl(Total - Top2) / (1 + (xTasaDelIva)) _
                                                                 ) * TasaExcedente _
                                                                ), 10, 2)
            End If


            'Antes
            'TxtValorRetencionBienes.Text = F_Format(CCur(F_NVL(TxtValorBienes.Text, "0") / (1 + xTAsaDelIva) * xTasaDelISRBienes))

        ElseIf TipoCalculo = 3 Then '--<>"FES" and <>"REC"

            Total = (CDbl(F_NVL(TxtValorServicios.Text, "0")))
            If Get_TasaRetencion = 0 Then
                TasaExcedente = 0
                RetencionFija = 0
            End If
            If Total <= Top1 Then
                txtValorRetencion.Text = 0
            ElseIf Total <= Top2 Then
                txtValorRetencion.Text = F_Format((CDbl(Total / (1 + (xTasaDelIva))) * Get_TasaRetencion))
            Else
                txtValorRetencion.Text = F_Format(RetencionFija + ( _
                                                                ( _
                                                                    CDbl(Total - Top2) / (1 + (xTasaDelIva)) _
                                                                 ) * TasaExcedente _
                                                                ), 10, 2)
            End If

            Total = (CDbl(F_NVL(TxtValorBienes.Text, "0")))
            If Total <= Top1 Then
                txtValorRetencionBienes.Text = 0
            ElseIf Total <= Top2 Then
                txtValorRetencionBienes.Text = F_Format(CDbl(Total / (1 + (xTasaDelIva))) * Get_TasaRetencion)
            Else
                txtValorRetencionBienes.Text = F_Format(RetencionFija + ( _
                                                                ( _
                                                                    CDbl(Total - Top2) / (1 + (xTasaDelIva)) _
                                                                 ) * TasaExcedente _
                                                                ), 10, 2)
            End If

        End If

    End Sub


    Private Sub chkValidSolicitud_CheckedChanged(sender As Object, e As EventArgs) Handles chkValidSolicitud.CheckedChanged
        Try
            If chkValidSolicitud.Checked And Not isMovBancos Then
                'cboBancos.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
                cboCuentasBancarias.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
            Else
                ' cboBancos.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Desplieque
                cboCuentasBancarias.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Desplieque
            End If
        Catch ex As Exception
            F_Error(ex, "Valida Solicitud")
        End Try
    End Sub

    Sub ValorLiquido()
        Try
            Dim documento As Int16 = IdDocumento
            clsDocumento.EjecutarValorLiquido(Solicitud, IdDocumento)
            ExecuteQuery()
            SelectRowFromDataGridview(grdIndice, "cellIdDocumento", documento, "cellisValido")
        Catch ex As Exception
            Throw New ArgumentException("Exception Occured")
        End Try
    End Sub

    Private Sub cmdBoletaTransaccion_Click(sender As Object, e As EventArgs) Handles cmdBoletaTransaccion.Click
        Try
            If Not F_Null(Solicitud) AndAlso Solicitud > 0 Then
                Dim frm As New FrmViewer
                frm.IdReporte = 2
                frm.Parametro1 = Solicitud
                frm.ReporteConParametros = False
                mdiMenu.ParentMDI(frm)
            End If
        Catch ex As Exception
            F_Error(ex, "Mostrar Boleta Transaccion")
        End Try
    End Sub



#Region "Contabilidad"

    Private Sub FrmContabilidadSolicitud_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Dispose()
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

    Sub ExecuteQueryContabilidad()
        Try
            isExecuteQuery = True
            Dim rwMovimiento As DataRow = clsContabilidadDocumento.ConsultarMovimientoContableDocumento(Solicitud, IdDocumento, IdMovimiento)
            If Not F_Null(rwMovimiento) Then

                txtCuentaContableContabilidad.Text = rwMovimiento("CuentaContable").ToString
                txtDescripcionContabilidad.Text = rwMovimiento("Descripcion").ToString
                txtValorContabilidad.Text = rwMovimiento("Valor").ToString
                If (Me.Modo = ModosDeTecleo.Consultar) Then
                    ModoContabilidad = ModosDeTecleo.Consultar
                Else
                    ModoContabilidad = ModosDeTecleo.Modificar
                End If
                Valid_CuentaContable()
                ActiveControl = txtDescripcionContabilidad
            End If
        Catch ex As Exception
            Throw
        Finally
            isExecuteQuery = False
        End Try
    End Sub

    Function DatosValidosMovimiento() As Boolean
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

    Private Sub cmdGrabarContabilidad_Click(sender As Object, e As EventArgs) Handles cmdGrabarContabilidad.Click
        Try
            If DatosValidosMovimiento() Then
                Cursor = Cursors.WaitCursor
                If ModoContabilidad = ModosDeTecleo.Grabar Then
                    clsContabilidadDocumento.GrabarDocumento(Solicitud, IdDocumento, GetNivelCuenta(CuentaContable, 1),
                                                             GetNivelCuenta(CuentaContable, 2), GetNivelCuenta(CuentaContable, 3), GetNivelCuenta(CuentaContable, 4),
                                                             txtDescripcionContabilidad.Text, txtValorContabilidad.Text, TipoCuenta,
                                                            IdMovimiento)
                    MensajeDeSistema(Me, "Movimiento contable grabado")
                    LimpiarVariablesContabilidad()

                ElseIf Modo = ModosDeTecleo.Modificar Then
                    clsContabilidadDocumento.ModificarMovimiento(Solicitud, IdDocumento, GetNivelCuenta(CuentaContable, 1),
                                                             GetNivelCuenta(CuentaContable, 2), GetNivelCuenta(CuentaContable, 3), GetNivelCuenta(CuentaContable, 4),
                                                             txtDescripcionContabilidad.Text, txtValorContabilidad.Text, TipoCuenta,
                                                             IdMovimiento)
                    MensajeDeSistema(Me, "Movimiento contable modificado")
                    'Dispose()
                End If

                ValorLiquido()
                LimpiarVariablesContabilidad()
                Fill_GrdContabilidad()

            End If
        Catch ex As Exception
            F_Error(ex, "Grabar movimiento")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Sub LimpiarVariablesContabilidad()
        Try
            lblNombreCuentaContabilidad.Text = ""
            txtCuentaContableContabilidad.Text = ""
            txtValorContabilidad.Text = "0.00"
            IdMovimiento = 0
            Me.ActiveControl = txtCuentaContableContabilidad
            ModoContabilidad = ModosDeTecleo.Grabar
            lblSaldoContabilidad.Text = ""
            TipoCuenta = ""

        Catch ex As Exception
            Throw
        End Try
    End Sub

#End Region


    Private Sub cboCuentasBancarias_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboCuentasBancarias.Validating
        Try
            If (Modo = ModosDeTecleo.Modificar) Then
                If (Not e.Cancel And Not cboCuentasBancarias.isNull) Then
                    TxtDocumentoBancos.Text = (clsBancos.ConsultarNumeroCheque(cboCuentasBancarias.Text))
                    TxtFechaDocumento.Text = (FechaOperacion)
                Else
                    TxtDocumentoBancos.Text = ""
                    TxtFechaDocumento.Text = ""
                End If
            End If
        Catch ex As Exception
            modFunciones.F_Error(ex, "Validar cuenta bancaria")
        End Try

    End Sub


    Private Sub cmdContabilizar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdContabilizar.Click
        Try
            If (Not Me.isMovBancos OrElse Not modFunciones.Valid_CampoObligatorio(Me.cboCuentasBancarias, Nothing, False)) Then
                Me.cmdGrabarEncabezado_Click(sender, e)
                Me.clsSolicitud.ContabilizarSolicitud(Solicitud, FechaOperacion)
                Me.ExecuteQuery()
            End If
        Catch ex As Exception
            F_Error(ex, "Contabilizar solicitud")

        End Try
    End Sub


    Private Sub cmdEliminarSolicitud_Click(sender As Object, e As EventArgs) Handles cmdEliminarSolicitud.Click
        Try
            clsSolicitud.EliminarSolicitud(Solicitud)
            MensajeDeSistema(Me, "Solicitud Eliminada exitosamente")
            Me.Dispose()
        Catch ex As Exception
            F_Error(ex, "Eliminar solicitud")
        End Try
    End Sub
End Class