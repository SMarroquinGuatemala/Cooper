Public Class FrmTransacciones
    Private _OrigenTransaccion As Int16 = 0
    Dim clsTransacciones As New CooperativaBLL.clsTransacciones
    Dim Socio As New CooperativaBLL.clsSocio

    Public Property OrigenTransaccion As String
        Get
            Return _OrigenTransaccion
        End Get
        Set(value As String)
            _OrigenTransaccion = value
            clsTransacciones.EstablecerOrigenTransaccion(value)
            lblNombreOrigenTransaccion.Text = clsTransacciones.Nombre
            Me.Text = clsTransacciones.Nombre
        End Set
    End Property



    Private Sub FrmTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Combos(cboEstadosTransaccion, True)
            txtFechaInicial.Text = F_PrimerDia(Date.Now)
            txtFechaFinal.Text = F_UltimoDia(Date.Now)
            Me.ActiveControl = txtNumeroDeEmpleado
            Me.grdTransacciones.AutoGenerateColumns = False
        Catch ex As Exception
            F_Error(ex, "Cargar Transacciones")
        End Try
    End Sub

    Private Sub grbTransacciones_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub grbTransacciones_Enter_1(sender As Object, e As EventArgs) Handles grbTransacciones.Enter

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            If Not Valid_CampoObligatorio(txtFechaInicial) Or Not Valid_CampoObligatorio(txtFechaFinal) Then
                Exit Sub
            Else
                AutoajustarGrid(grdTransacciones, clsTransacciones.ConsultarTransacciones(txtFechaInicial.Text, txtFechaFinal.Text, txtNumeroDeEmpleado.Text, cboEstadosTransaccion.Codigo, txtValorInicial.Text, txtValorFinal.Text, OrigenTransaccion))
                If grdTransacciones.Rows.Count = 0 Then
                    lblRegistros.Text = "No se encontraron registros"
                Else
                    lblRegistros.Text = "Registros encontrados: " & grdTransacciones.Rows.Count.ToString
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Buscar registros")
        End Try
    End Sub

    Private Sub txtNumeroDeEmpleado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumeroDeEmpleado.Validating
        Try
            If Not txtNumeroDeEmpleado.isNull Then
                Me.Cursor = Cursors.WaitCursor
                Socio.Get_Empleado(txtNumeroDeEmpleado.Text)
                lblNombreEmpleado.Text = ""
                If Socio.EmpleadoValido Then
                    lblNombreEmpleado.Text = Socio.Nombre
                Else
                    lblNombreEmpleado.Text = "Empleado no valido"
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            F_Error(ex, "Validar empleado")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Try
            Select Case OrigenTransaccion
                Case 1
                    Dim Admision As New FrmAdminisiones
                    Admision.Show()
                Case 6
                    Dim Prestamo As New FrmPrestamos
                    FrmPrestamos.Show()
            End Select
        Catch ex As Exception
            F_Error(ex, "Nuevo")
        End Try
    End Sub

    Private Sub grdTransacciones_DoubleClick(sender As Object, e As EventArgs) Handles grdTransacciones.DoubleClick
        Try
            If grdTransacciones.SelectedRows.Count = 1 Then
                Select Case OrigenTransaccion
                    Case 1
                        Dim Admision As New FrmAdminisiones
                        Admision.ExecuteQuery(grdTransacciones.SelectedRows(0).Cells("cellIdTransaccion").Value.ToString, grdTransacciones.SelectedRows(0).Cells("cellReferencia").Value.ToString)
                        Admision.Show()
                    Case 6
                        Dim Prestamo As New FrmPrestamos
                        Prestamo.IdTransaccion = grdTransacciones.SelectedRows(0).Cells("cellIdTransaccion").Value.ToString
                        Prestamo.Modo = ModosDeTecleo.Modificar
                        Prestamo.Show()
                End Select
            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar transaccion")
        End Try
    End Sub
End Class