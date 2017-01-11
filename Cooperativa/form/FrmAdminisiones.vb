Public Class FrmAdminisiones
    Dim Empleado As New CooperativaBLL.clsSocio
    Dim _Modo As ModosDeTecleo = ModosDeTecleo.Grabar
    Dim _ModoBeneficiario As ModosDeTecleo = ModosDeTecleo.Grabar
    Private _IdTransaccion As Integer = 0

    Property Modo As ModosDeTecleo
        Get
            Return _Modo
        End Get
        Set(value As ModosDeTecleo)
            _Modo = value
            If value = ModosDeTecleo.Grabar Then
                grbBeneficiarios.Enabled = False
            ElseIf value = ModosDeTecleo.Modificar Then
                grbBeneficiarios.Enabled = True
            End If
        End Set
    End Property
    

    Public Property IdTransaccion As Integer
        Get
            Return _IdTransaccion
        End Get
        Set(value As Integer)
            _IdTransaccion = value
        End Set
    End Property

    Property ModoBeneficiario As ModosDeTecleo
        Get
            Return _ModoBeneficiario
        End Get
        Set(value As ModosDeTecleo)
            _ModoBeneficiario = value
        End Set
    End Property

    Private Sub FrmAdminisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSSolidarismo.TblSociosApellidosCasada' Puede moverla o quitarla según sea necesario.
        Me.TblSociosApellidosCasadaTableAdapter.Fill(Me.DSSolidarismo.TblSociosApellidosCasada)
        'TODO: esta línea de código carga datos en la tabla 'DSSolidarismo.TblSociosTelefono' Puede moverla o quitarla según sea necesario.
        Me.TblSociosTelefonoTableAdapter.Fill(Me.DSSolidarismo.TblSociosTelefono)
        'TODO: esta línea de código carga datos en la tabla 'DSSolidarismo.TblSocios' Puede moverla o quitarla según sea necesario.
        Me.TblSociosTableAdapter.Fill(Me.DSSolidarismo.TblSocios)
        'TODO: esta línea de código carga datos en la tabla 'DSSolidarismo.TblSocios' Puede moverla o quitarla según sea necesario.
        Me.TblSociosTableAdapter.Fill(Me.DSSolidarismo.TblSocios)
        Try
            Fill_Combos(cboParentescos)
            Fill_Combos(cboTipoDeBeneficiario)
            If Modo = ModosDeTecleo.Grabar Then txtFecha.Text = Date.Now.ToShortDateString
        Catch ex As Exception
            F_Error(ex, "cargar admisiones")
        Finally
            AplicaEfectoControles(Me)
        End Try
    End Sub
    Public Sub ExecuteQuery(IdTransaccion As Integer, NumeroDeEmpleado As String)
        Try
            Empleado.SeleccionarNuevoSocio(NumeroDeEmpleado, IdTransaccion)
            If Empleado.EmpleadoValido Then
                txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
                With Empleado
                    txtDireccion.Text = .Direccion
                    txtFecha.Text = .FechaSolicitud
                    txtCapital.Text = .Capital
                    txtSalario.Text = .Salario
                    txtNombreEmpleado.Text = .Nombre
                    txtNumeroDeEmpleado.Text = .NumeroDeEmpleado
                    pcbCategoria.Image = .Fotografia
                    txtTelefono.Text = .Telefono
                    txtPlanilla.Text = .Planilla
                    chkCatorcenal.Checked = .Catorcenal
                    cmdGrabar.Enabled = True
                    Modo = ModosDeTecleo.Modificar
                    Fill_Beneficiarios(NumeroDeEmpleado)
                    Me.IdTransaccion = IdTransaccion
                End With
            Else
                Me.IdTransaccion = 0
                txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
                Me.ActiveControl = cboParentescos
                Modo = ModosDeTecleo.Grabar
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Try
            If ValidDatos() Then
                If Modo = ModosDeTecleo.Grabar Then
                    IdTransaccion = Empleado.GrabarNuevoSocio(txtNumeroDeEmpleado.Text, txtFecha.Text, txtCapital.Text)
                    MensajeDeSistema(Me, "Solicitud de admision grabada exitosamente")
                    Modo = ModosDeTecleo.Modificar

                ElseIf Modo = ModosDeTecleo.Modificar Then
                    Empleado.ActualizarNuevoSocio(txtNumeroDeEmpleado.Text, txtFecha.Text, txtCapital.Text, txtDireccion.Text, txtTelefono.Text, txtPlanilla.Text, chkCatorcenal.Checked, txtSalario.Text, IdTransaccion)
                    MensajeDeSistema(Me, "Solicitud de admision modificada exitosamente")
                End If
                ExecuteQuery(IdTransaccion, txtNumeroDeEmpleado.Text)
            End If
        Catch ex As Exception
            F_Error(ex, "Grabar")
        End Try
    End Sub
    Function ValidDatos() As Boolean
        Try
            If Not Valid_CampoObligatorio(txtNumeroDeEmpleado) Or
                Not Valid_CampoObligatorio(txtDireccion) Or
                Not Valid_CampoObligatorio(txtFecha) Or
                Not Valid_CampoObligatorio(txtTelefono) Or
                Not Valid_CampoObligatorio(txtPlanilla) Then
                Return False
            End If
            'Planilla Guatemala
            If RTrim(txtPlanilla.Text) = "70" And (txtCapital.isNull Or CInt(txtCapital.Text) <= 0) Then
                MensajeDeSistema(Me, "Debe ingresar capital")
                Return False
            End If

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub txtNumeroDeEmpleado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroDeEmpleado.Validating
        Try
            If Not txtNumeroDeEmpleado.isNull Then
                Me.Cursor = Cursors.WaitCursor
                If txtNumeroDeEmpleado.Text <> Empleado.NumeroDeEmpleado Then
                    IdTransaccion = 0
                    Empleado.Get_Empleado(txtNumeroDeEmpleado.Text)
                    limpiarControles(Me)
                    txtFecha.Text = Date.Now.ToShortDateString
                    pcbCategoria.Image = My.Resources.Add_male_user_256
                    If Empleado.EmpleadoValido Then
                        With Empleado
                            txtNumeroDeEmpleado.Text = .NumeroDeEmpleado
                            pcbCategoria.Image = .Fotografia
                            txtNombreEmpleado.Text = .Nombre
                            txtDireccion.Text = .Direccion
                            txtTelefono.Text = .Telefono
                            txtPlanilla.Text = .Planilla
                            chkCatorcenal.Checked = .Catorcenal
                            txtSalario.Text = .Salario
                            txtCapital.Text = .Capital
                            e.Cancel = False
                        End With
                    Else
                        e.Cancel = True
                        MensajeDeSistema(Me, "Empleado no valido")
                    End If
                    If Not e.Cancel And Modo = ModosDeTecleo.Grabar Then
                        e.Cancel = Not Empleado.ValidaIngresoNuevo
                    ElseIf Modo = ModosDeTecleo.Modificar And Not e.Cancel Then
                        txtCapital.Text = Empleado.Capital
                    End If
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "cargar admisiones")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cndNuevo_Click(sender As Object, e As EventArgs) Handles cndNuevo.Click
        Try
            txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
            limpiarControles(Me)
            pcbCategoria.Image = My.Resources.Add_male_user_256

            Modo = ModosDeTecleo.Grabar
            IdTransaccion = 0
            Me.ActiveControl = txtNumeroDeEmpleado
        Catch ex As Exception
            F_Error(ex, "Nuevo socio")
        End Try
    End Sub

#Region "Beneficiarios"

    Private Sub cboParentescos_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboParentescos.Validating
        If Not e.Cancel Then
            Me.ActiveControl = txtNombreBeneficiario
        End If
    End Sub

    Sub LimpiarBeneficiarios()
        cboParentescos.Text = ""
        txtNombreBeneficiario.Text = ""
        txtDireccionBeneficiario.Text = ""
        cboTipoDeBeneficiario.Text = ""
        txtIdBeneficiario.Text = "0"
        ModoBeneficiario = ModosDeTecleo.Grabar
    End Sub
    Function ValidaBenficiario() As Boolean
        Try
            If Not Valid_CampoObligatorio(cboParentescos) Or Not _
                Valid_CampoObligatorio(txtNombreBeneficiario) Or Not _
                Valid_CampoObligatorio(txtDireccionBeneficiario) Or Not _
                Valid_CampoObligatorio(cboTipoDeBeneficiario) Then
                Return False
            End If
            If ModoBeneficiario = ModosDeTecleo.Modificar AndAlso CInt(txtIdBeneficiario.Text) = 0 Then
                ShowMsgBox("Beneficiario invalido", vbCritical)
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
    Private Sub cmdAgregarBeneficiario_Click(sender As Object, e As EventArgs) Handles cmdAgregarBeneficiario.Click
        Try
            If ValidaBenficiario() Then
                If ModoBeneficiario = ModosDeTecleo.Grabar Then
                    Empleado.GrabarBeneficiario(txtNumeroDeEmpleado.Text, txtNombreBeneficiario.Text, cboParentescos.Codigo, txtDireccionBeneficiario.Text, cboTipoDeBeneficiario.Codigo)
                    MensajeDeSistema(Me, "Beneficiario grabado con éxito")
                Else
                    Empleado.ActualizarBeneficiario(txtNumeroDeEmpleado.Text, txtNombreBeneficiario.Text, cboParentescos.Codigo, txtDireccionBeneficiario.Text, cboTipoDeBeneficiario.Codigo)
                    MensajeDeSistema(Me, "Beneficiario modificado con éxito")
                End If
                LimpiarBeneficiarios()
                Fill_Beneficiarios(txtNumeroDeEmpleado.Text)
            End If
        Catch ex As Exception
            F_Error(ex, "Agregar Beneficiario")
        End Try
    End Sub

    Sub ExecuteBeneficiario(IdBeneficiario As Integer)
        Try
            If IdBeneficiario > 0 Then
                Dim dr As DataRow = Empleado.SeleccionarBeneficiario(IdBeneficiario)
                If Not F_Null(dr) Then
                    cboParentescos.Codigo = dr("IdParentesco").ToString
                    txtNombreBeneficiario.Text = dr("Nombre").ToString
                    txtDireccionBeneficiario.Text = dr("Direccion").ToString
                    cboTipoDeBeneficiario.Codigo = dr("TipoBeneficiario").ToString
                    ModoBeneficiario = ModosDeTecleo.Modificar
                    Me.ActiveControl = txtNombreBeneficiario
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cmdBorrarBeneficiario_Click(sender As Object, e As EventArgs) Handles cmdBorrarBeneficiario.Click
        Try
            If MsgBox("¿Desea eliminar este beneficiario?", vbYesNo, "MensajeDeSistema") = MsgBoxResult.Yes Then
                Empleado.EliminarBeneficiario(txtIdBeneficiario.Text)
                MensajeDeSistema(Me, "Beneficiario eliminado exitosamente")
                Me.ActiveControl = cboTipoDeBeneficiario
                LimpiarBeneficiarios()
            End If
        Catch ex As Exception
            F_Error(ex, "Eliminar Beneficiario")
        End Try
    End Sub

    Sub Fill_Beneficiarios(NumeroDeEmpleado As String)
        Try
            If Not F_Null(NumeroDeEmpleado) Then
                AutoajustarGrid(grdBeneficiarios, Empleado.SeleccionarBeneficiarios(NumeroDeEmpleado))
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub grdBeneficiarios_DoubleClick(sender As Object, e As EventArgs) Handles grdBeneficiarios.DoubleClick
        Try
            If grdBeneficiarios.SelectedRows.Count = 1 Then
                ExecuteBeneficiario(grdBeneficiarios.SelectedRows(0).Cells("IdBeneficiario").Value.ToString)
            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar Beneficiario")
        End Try
    End Sub

    Private Sub TblSociosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSSolidarismo)

    End Sub

    Private Sub TblSociosBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSociosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSSolidarismo)

    End Sub

    Private Sub TblSociosApellidosCasadaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblSociosApellidosCasadaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSSolidarismo)

    End Sub

    Private Sub SexoComboBoxSD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SexoComboBoxSD.SelectedIndexChanged

    End Sub

#End Region



End Class