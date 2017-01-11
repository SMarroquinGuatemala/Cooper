Public Class FrmPrestamos
    Dim Empleado As New CooperativaBLL.clsSocio
    Dim _Modo As ModosDeTecleo = ModosDeTecleo.Grabar
    Dim _ModoBeneficiario As ModosDeTecleo = ModosDeTecleo.Grabar
    Private _IdTransaccion As Integer = 0
    Private _IdSolicitud As Integer = 0
    Dim Transaccion As New CooperativaBLL.clsTransacciones
    Private _OrigenTransaccion As String = 6
    Private _ValidSolicitud As Boolean = False
    Private _ModoCodeudor As ModosDeTecleo = ModosDeTecleo.Grabar

    Public Property ValidSolicitud As Boolean
        Get
            Return _ValidSolicitud
        End Get
        Set(ByVal value As Boolean)
            _ValidSolicitud = value
            If _ValidSolicitud Then
                lblValidSolicitud.Text = "Solicitud Válida"
                lblValidSolicitud.BackColor = Color.LightGreen
                cmdAutorizar.Enabled = True
            Else
                lblValidSolicitud.Text = "Solicitud Inválida"
                lblValidSolicitud.BackColor = Color.Coral
                cmdAutorizar.Enabled = False
            End If
        End Set
    End Property


    Property Modo As ModosDeTecleo
        Get
            Return _Modo
        End Get
        Set(value As ModosDeTecleo)
            _Modo = value
            If value = ModosDeTecleo.Grabar Then
                txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
                grbCodeudor.Enabled = False
            ElseIf value = ModosDeTecleo.Modificar Then
                txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
                grbCodeudor.Enabled = True
            End If
        End Set
    End Property

    Property ModoCodeudor As ModosDeTecleo
        Get
            Return _ModoCodeudor
        End Get
        Set(value As ModosDeTecleo)
            _ModoCodeudor = value
            If value = ModosDeTecleo.Grabar Then
                txtCodeudor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
                cmdBorrarCodeudor.Enabled = False
            ElseIf value = ModosDeTecleo.Modificar Then
                txtCodeudor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
                cmdBorrarCodeudor.Enabled = True
            End If
        End Set
    End Property

    Public ReadOnly Property OrigenTransaccion As String
        Get
            Return _OrigenTransaccion
        End Get
    End Property

    Public Property IdTransaccion As Integer
        Get
            Return _IdTransaccion
        End Get
        Set(value As Integer)
            _IdTransaccion = value
        End Set
    End Property

    Public Property IdSolicitud As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(value As Integer)
            _IdSolicitud = value
        End Set
    End Property

    Private Sub FrmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Combos(cboModalidad)
            If Modo = ModosDeTecleo.Grabar Then
                txtFecha.Text = Date.Now.ToShortDateString
            Else
                ExecuteQuery()
            End If
        Catch ex As Exception
            F_Error(ex, "Cargar Formulario")
        End Try
    End Sub

    Private Sub txtNumeroDeEmpleado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroDeEmpleado.Validating
        Try
            If Not txtNumeroDeEmpleado.isNull Then
                Me.Cursor = Cursors.WaitCursor
                Empleado.Get_Empleado(txtNumeroDeEmpleado.Text)
                If Empleado.EmpleadoValido Then
                    txtNombreEmpleado.Text = Empleado.Nombre
                    pcbEmpleado.Image = Empleado.Fotografia
                Else
                    txtNombreEmpleado.Text = "Empleado no valido"
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Validar empleado")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Try
            If Modo = ModosDeTecleo.Grabar Or Modo = ModosDeTecleo.Modificar Then
                If DatosValidos() Then
                    Transaccion.GrabarModificarPrestamo(OrigenTransaccion, IdSolicitud, txtNumeroDeEmpleado.Text,
                                                        txtFecha.Text, txtCantidad.Text, nudMeses.Value, cboModalidad.Codigo, Usuario)

                    ExecuteQuery()
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Grabar prestamo")
        End Try
    End Sub

    Function DatosValidos() As Boolean
        Try
            If Not Valid_CampoObligatorio(txtNumeroDeEmpleado) Or
                Not Valid_CampoObligatorio(txtFecha) Or
                 Not Valid_CampoObligatorio(txtCantidad) Or
                  Not Valid_CampoObligatorio(cboModalidad) Or
                   nudMeses.Value = 0 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ExecuteQuery()
        Try
            xRowDefault = Transaccion.ConsultarPrestamo(txtNumeroDeEmpleado.Text, IdTransaccion)

            If Not F_Null(xRowDefault) Then
                txtNumeroDeEmpleado.Text = xRowDefault("NumeroDeEmpleado").ToString
                IdSolicitud = xRowDefault("IdSolicitud").ToString
                IdTransaccion = xRowDefault("IdTransaccion").ToString
                txtCantidad.Text = xRowDefault("Capital").ToString
                lblIntereses.Text = F_Format(xRowDefault("Intereses").ToString)
                lblCapital.Text = F_Format(xRowDefault("Capital").ToString)
                lblPorcentajeInteres.Text = F_Format(xRowDefault("InteresPorcentaje").ToString)
                lblAmortizaciones.Text = F_Format(xRowDefault("Amortizaciones").ToString)
                nudMeses.Value = (xRowDefault("MesesPlazo").ToString)
                lblCuota.Text = F_Format(xRowDefault("CuotaTotal").ToString)
                lblValor.Text = F_Format(xRowDefault("Valor").ToString)
                lblAhorroAcumulado.Text = F_Format(xRowDefault("AhorroAcumulado").ToString)
                lblSaldoEnPrestamos.Text = F_Format(xRowDefault("SaldoPrestamos").ToString)
                lblSaldoCodeudor.Text = F_Format(xRowDefault("SaldoCodeudor").ToString)
                lblTotalDeuda.Text = F_Format(xRowDefault("TotalDeuda").ToString)
                lblAhorroLibreDeuda.Text = F_Format(xRowDefault("AhorroLibreDeuda").ToString)
                lblChequePor.Text = F_Format(xRowDefault("ChequePor").ToString)
                cboModalidad.Codigo = (xRowDefault("TipoPago").ToString)
                txtFecha.Text = (xRowDefault("FechaSolicitud").ToString)
                lblEstadoSolicitud.Text = (xRowDefault("DescripcionActual").ToString)
                txtNumeroDeEmpleado_Validating(txtNumeroDeEmpleado, New System.ComponentModel.CancelEventArgs())
                Modo = ModosDeTecleo.Modificar
                Fill_GrdAmortizaciones()
                Fill_GrdCodeudores()
            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Fill_GrdAmortizaciones()
        Try
            AutoajustarGrid(grdAmortizaciones, Transaccion.ConsultarAmortizaciones(IdSolicitud))
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cmdAgregarCodeudor_Click(sender As Object, e As EventArgs) Handles cmdAgregarCodeudor.Click
        Try
            If Valid_CampoObligatorio(txtCodeudor) AndAlso Valid_CampoObligatorio(txtValorCodeudor) Then
                If ModoCodeudor = ModosDeTecleo.Grabar Then
                    Transaccion.GrabarCodeudor(IdTransaccion, IdSolicitud, txtCodeudor.Text, txtFecha.Text, F_UnFormat(txtValorCodeudor.Text))
                    MensajeDeSistema(Me, "Codeudor agregado exitosamente")
                Else
                    Transaccion.ModificarCodeudor(IdTransaccion, IdSolicitud, txtCodeudor.Text, txtFecha.Text, F_UnFormat(txtValorCodeudor.Text))
                    MensajeDeSistema(Me, "Codeudor modificado exitosamente")
                End If
                LimpiarCodeudor()
                Fill_GrdCodeudores()
            End If
        Catch ex As Exception
            F_Error(ex, "Agregar Codeudor")
        End Try
    End Sub

    Sub Fill_GrdCodeudores()
        Try
            If IdSolicitud > 0 And IdTransaccion > 0 Then
                AutoajustarGrid(grdCodeudores, Transaccion.ConsultarCodeudoresPrestamo(IdTransaccion, IdSolicitud))
                Totalizar()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Totalizar()
        Try
            lblSolicitando.Text = lblCapital.Text
            lblAhorroLibre.Text = lblAhorroLibreDeuda.Text
            lblValorCodeudores.Text = F_Format(SumarColumna(grdCodeudores, "cellValorCodeudor"))
            lblSaldo.Text = Val(lblCapital.Text) - Val(lblAhorroAcumulado.Text) - Val(lblValorCodeudores.Text)

            If Val(lblSaldo.Text) > 0 Then
                ValidSolicitud = False
            Else
                ValidSolicitud = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Sub LimpiarCodeudor()
        txtCodeudor.Text = ""
        txtValorCodeudor.Text = ""
        txtNombreCodeudor.Text = ""
        ModoCodeudor = ModosDeTecleo.Grabar
    End Sub
    Private Sub txtCodeudor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodeudor.Validating
        Try
            If Not txtCodeudor.isNull Then
                Me.Cursor = Cursors.WaitCursor
                Empleado.Get_Empleado(txtCodeudor.Text)
                If Empleado.EmpleadoValido Then
                    txtNombreCodeudor.Text = Empleado.Nombre
                Else
                    txtNombreCodeudor.Text = "Empleado no valido"
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Validar codeudor")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdCodeudores_DoubleClick(sender As Object, e As EventArgs) Handles grdCodeudores.DoubleClick
        Try
            If grdCodeudores.SelectedRows.Count = 1 Then
                txtCodeudor.Text = grdCodeudores.SelectedRows(0).Cells("cellNumeroDeEmpleado").Value.ToString
                txtValorCodeudor.Text = grdCodeudores.SelectedRows(0).Cells("cellValorCodeudor").Value.ToString
                txtNombreCodeudor.Text = grdCodeudores.SelectedRows(0).Cells("cellNombreCodeudor").Value.ToString
                ModoCodeudor = ModosDeTecleo.Modificar
                Me.ActiveControl = txtValorCodeudor
            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar Codeudor")
        End Try
    End Sub
End Class