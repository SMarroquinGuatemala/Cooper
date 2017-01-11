Public Class FrmCuentasContables
    Dim _Modo As ModosDeTecleo = ModosDeTecleo.Grabar
    Dim CuentasContables As New CooperativaBLL.clsCuentasContables

    Property Modo As ModosDeTecleo
        Get
            Return _Modo
        End Get
        Set(value As ModosDeTecleo)
            _Modo = value
        End Set
    End Property

    Private Sub txtCuentaContable_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCuentaContable.Validating
        Try
            If Not txtCuentaContable.isNull Then
                If Mid(txtCuentaContable.Text, 1, 1) = "0" Or
                        Mid(txtCuentaContable.Text, 2, 1) = "0" Or
                            Mid(txtCuentaContable.Text, 3, 1) = "0" Or
                                Mid(txtCuentaContable.Text, 4, 2) = "00" Or
                                    Len(txtCuentaContable.Text) < 5 Then
                    MensajeDeSistema(Me, "Codigo de cuenta invalido")
                    e.Cancel = True
                Else
                    e.Cancel = False
                    EstablecerCuenta()
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Validar cuenta")
        End Try
    End Sub

    Private Sub FrmCuentasContables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Combos(cboClasificacion)
            Me.ActiveControl = txtCuentaContable
        Catch ex As Exception
            F_Error(ex, "Cargar formulario ")
        End Try
    End Sub

    Private Sub TextBoxSD2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAuxiliar.Validating
        Try
            txtAuxiliar.Text = txtAuxiliar.Text.ToUpper
        Catch ex As Exception
            F_Error(ex, "Validar  ")
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try

            AutoajustarGrid(grdCuentasContables, CuentasContables.ConsultarCuentaContable(txtCuentaContable.Text, txtNombre.Text,
                                                                                          txtDescripcion.Text, txtAuxiliar.Text, cboClasificacion.Codigo))
            If grdCuentasContables.Rows.Count = 0 Then
                lblMensajes.Text = "No se encontraron registros"
            Else
                lblMensajes.Text = "Registros encontrados: " & grdCuentasContables.Rows.Count.ToString
            End If

        Catch ex As Exception
            F_Error(ex, "Buscar registros")
        End Try
    End Sub
    Public Function DatosValidos() As Boolean
        Try
            If Not Valid_CampoObligatorio(txtCuentaContable) Or
                Not Valid_CampoObligatorio(txtNombre) Or
                Not Valid_CampoObligatorio(txtDescripcion) Or
                Not Valid_CampoObligatorio(cboClasificacion)  Then
                Return False

            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Try
            If DatosValidos() Then
                If Modo = ModosDeTecleo.Grabar Then
                    CuentasContables.GrabarCuentaContable(txtCuentaContable.Text, txtNombre.Text, txtDescripcion.Text, txtAuxiliar.Text, cboClasificacion.Codigo)

                    LimpiarVariables()
                    lblMensajes.Text = "Cuenta grabada exitosamente"

                ElseIf Modo = ModosDeTecleo.Modificar Then
                    CuentasContables.ActualizaProveedor(txtCuentaContable.Text, txtNombre.Text, txtDescripcion.Text, txtAuxiliar.Text, cboClasificacion.Codigo)
                    LimpiarVariables()
                    lblMensajes.Text = "Cuenta modificada exitosamente"
                ElseIf Modo = ModosDeTecleo.Consultar Then
                    ShowMsgBox("Su usuario no puede modificar este maestro")
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Grabar o modificar proveedor")
        End Try
    End Sub

    Sub LimpiarVariables()
        Try
            txtCuentaContable.Text = ""
            txtNombre.Text = ""
            txtDescripcion.Text = ""
            txtAuxiliar.Text = ""
            cboClasificacion.Text = ""
            
            Modo = ModosDeTecleo.Grabar
            lblMensajes.Text = ""
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Try
            LimpiarVariables()
            Me.ActiveControl = txtCuentaContable
        Catch ex As Exception
            F_Error(ex, "Nuevo proveedor")
        End Try
    End Sub

    Private Sub grdCuentasContables_DoubleClick(sender As Object, e As EventArgs) Handles grdCuentasContables.DoubleClick
        Try
            If grdCuentasContables.SelectedRows.Count = 1 Then
                LimpiarVariables()
                txtCuentaContable.Text = grdCuentasContables.SelectedRows(0).Cells("cellCuenta").Value.ToString
                EstablecerCuenta()
            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar Proveedor")
        End Try
    End Sub

    Sub EstablecerCuenta()
        CuentasContables.Get_InformacionProveedor(txtCuentaContable.Text)
        If Not F_Null(CuentasContables.CuentaContable) Then
            With CuentasContables
                txtNombre.Text = .Nombe
                txtDescripcion.Text = .Descripcion
                txtAuxiliar.Text = .Auxiliar
                cboClasificacion.Codigo = .Clasificacion
                lblMensajes.Text = "Cuenta: " & txtCuentaContable.Text.ToString & " seleccionado correctamente"
                Modo = ModosDeTecleo.Modificar
                Me.ActiveControl = txtNombre
                Modo = ModosDeTecleo.Modificar
            End With
        Else
            Me.ActiveControl = txtNombre
            Modo = ModosDeTecleo.Grabar
        End If
    End Sub


End Class