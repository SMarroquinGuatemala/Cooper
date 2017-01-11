Public Class FrmProveedores
    Dim _Modo As ModosDeTecleo = ModosDeTecleo.Grabar
    Dim Proveedores As New CooperativaBLL.clsProveedores

    Property Modo As ModosDeTecleo
        Get
            Return _Modo
        End Get
        Set(value As ModosDeTecleo)
            _Modo = value
        End Set
    End Property

    Public Property Proveedor As Integer
        Get
            Return lblProveedor.Text
        End Get
        Set(value As Integer)
            lblProveedor.Text = value
        End Set
    End Property

    Private Sub cboTipoRetencion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboTipoRetencion.Validating
        Try
            If Not cboTipoRetencion.isNull And Not e.Cancel Then
                ValidTipoRetencion()
            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar tipo retencion")
        End Try
    End Sub

    Sub ValidTipoRetencion()
        If Not cboTipoRetencion.isNull Then
            If cboTipoRetencion.Codigo = 3 Then
                txtTasaRetencion.Text = 5 / 100
                chkAplicaRetencion.Checked = True
            Else
                txtTasaRetencion.Text = 0
                chkAplicaRetencion.Checked = False
            End If
        End If
    End Sub
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Combos(cboTipoRetencion)
        Catch ex As Exception
            F_Error(ex, "Cargar Formulario")
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            
            AutoajustarGrid(grdProveedores, Proveedores.ConsultarProveedores(txtNombreLargo.Text, txtNombreCorto.Text, txtActividadProveedor.Text,
                                                                             txtNITProveedor.Text, txtDireccion.Text, txtTelefono1.Text, txtTelefono2.Text,
                                                                             txtContacto.Text, txtEmailContacto.Text, cboTipoRetencion.Codigo,
                                                                             chkAplicaRetencion.Checked, chkActivo.Checked, chkAplicaComoCliente.Checked, txtDPI.Text,
                                                                             Proveedor))
            If grdProveedores.Rows.Count = 0 Then
                lblMensajes.Text = "No se encontraron registros"
            Else
                lblMensajes.Text = "Registros encontrados: " & grdProveedores.Rows.Count.ToString
            End If

        Catch ex As Exception
            F_Error(ex, "Buscar registros")
        End Try
    End Sub
    Public Function DatosValidos() As Boolean
        Try
            If Not Valid_CampoObligatorio(txtNombreCorto) Or
                Not Valid_CampoObligatorio(txtNombreLargo) Or
                Not Valid_CampoObligatorio(txtNITProveedor) Or
                Not Valid_CampoObligatorio(txtActividadProveedor) Or
                Not Valid_CampoObligatorio(txtDireccion) Or
                Not Valid_CampoObligatorio(cboTipoRetencion) Then
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
                    Proveedor = Proveedores.GrabarProveedor(txtNombreLargo.Text, txtNombreCorto.Text, txtActividadProveedor.Text,
                                                                                 txtNITProveedor.Text, txtDireccion.Text, txtTelefono1.Text, txtTelefono2.Text,
                                                                                 txtContacto.Text, txtEmailContacto.Text, txtTasaRetencion.Text, cboTipoRetencion.Codigo,
                                                                                 chkAplicaRetencion.Checked, chkActivo.Checked, chkAplicaComoCliente.Checked, txtDPI.Text
                                                                                 )
                    If Proveedor > 0 Then
                        Modo = ModosDeTecleo.Modificar
                        LimpiarVariables()
                        lblMensajes.Text = "Proveedor grabado exitosamente"
                    End If
                ElseIf Modo = ModosDeTecleo.Modificar Then
                    Proveedores.ActualizaProveedor(txtNombreLargo.Text, txtNombreCorto.Text, txtActividadProveedor.Text,
                                                                                 txtNITProveedor.Text, txtDireccion.Text, txtTelefono1.Text, txtTelefono2.Text,
                                                                                 txtContacto.Text, txtEmailContacto.Text, txtTasaRetencion.Text, cboTipoRetencion.Codigo,
                                                                                 chkAplicaRetencion.Checked, chkActivo.Checked, chkAplicaComoCliente.Checked, txtDPI.Text,
                                                                                 Proveedor)
                    LimpiarVariables()
                    lblMensajes.Text = "Proveedor modificado exitosamente"
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
            Proveedor = 0
            txtNombreCorto.Text = ""
            txtNombreLargo.Text = ""
            txtNITProveedor.Text = ""
            txtActividadProveedor.Text = ""
            txtDireccion.Text = ""
            txtTelefono1.Text = ""
            txtTelefono2.Text = ""
            txtDPI.Text = ""
            cboTipoRetencion.Text = ""
            ValidTipoRetencion()
            txtContacto.Text = ""
            txtEmailContacto.Text = ""
            chkAplicaComoCliente.Checked = False
            chkAplicaRetencion.Checked = False
            chkActivo.Checked = True
            Modo = ModosDeTecleo.Grabar
            lblMensajes.Text = ""
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Try
            LimpiarVariables()
            Me.ActiveControl = txtNombreLargo
        Catch ex As Exception
            F_Error(ex, "Nuevo proveedor")
        End Try
    End Sub

    Private Sub grdProveedores_DoubleClick(sender As Object, e As EventArgs) Handles grdProveedores.DoubleClick
        Try
            If grdProveedores.SelectedRows.Count = 1 Then
                LimpiarVariables()
                Proveedor = grdProveedores.SelectedRows(0).Cells("cellProveedor").Value.ToString
                Proveedores.Get_InformacionProveedor(Proveedor)
                With Proveedores
                    If .ProveedorValido Then
                        txtNombreCorto.Text = .NombreCorto
                        txtNombreLargo.Text = .Nombrelargo
                        txtNITProveedor.Text = .NITProveedor
                        txtActividadProveedor.Text = .ActividadProveedor
                        txtDireccion.Text = .Direccion
                        txtTelefono1.Text = .Telefono1
                        txtTelefono2.Text = .Telefono2
                        txtDPI.Text = .DPI
                        txtContacto.Text = .Contacto
                        txtEmailContacto.Text = .EmailContacto
                        cboTipoRetencion.Codigo = .TipoRetencion
                        ValidTipoRetencion()
                        txtTasaRetencion.Text = .TasaRetencion
                        chkAplicaComoCliente.Checked = .AplicaComoCliente
                        chkAplicaRetencion.Checked = .AplicaRetencion
                        chkActivo.Checked = .ProveedorActivo
                        lblMensajes.Text = "Proveedor: " & Proveedor.ToString & " seleccionado correctamente"
                        Modo = ModosDeTecleo.Modificar
                        Me.ActiveControl = txtNombreLargo
                    Else
                        ShowMsgBox("No se pudo recuperar la informacion del proveedor")
                    End If
                End With
            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar Proveedor")
        End Try
    End Sub

    Private Sub cboTipoRetencion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoRetencion.SelectedIndexChanged

    End Sub

    Private Sub grbDatosProveedor_Enter(sender As Object, e As EventArgs) Handles grbDatosProveedor.Enter

    End Sub
End Class