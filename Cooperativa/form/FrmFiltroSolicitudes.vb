Imports Library

Public Class FrmFiltroSolicitudes
    Private Solicitudes As New CooperativaBLL.clsSolicitudes
    Private clsTransacciones As New CooperativaBLL.clsTransacciones
    Dim Combos As New CooperativaBLL.clsCombos
    Private _OrigenTransaccion As String

    Public Property OrigenTransaccion As String
        Get
            Return _OrigenTransaccion
        End Get
        Set(value As String)
            _OrigenTransaccion = value
            clsTransacciones.EstablecerOrigenTransaccion(value)
            Me.Text = clsTransacciones.Nombre
        End Set
    End Property

    Private Sub FrmFiltroSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Llenamos el indice 
            grdIndice.DataSource = Solicitudes.OrigenesDeTransaccion(NumeroDeEmpleado) 'ToDo

  
            'Datos default
            grdSolicitudMovimientoBancos.AutoGenerateColumns = False
            txtFechaInicial.Text = F_PrimerDia(Date.Now)
            txtFechaFinal.Text = F_UltimoDia(Date.Now)
            cmdBuscar_Click(sender, (New System.EventArgs))
        Catch ex As Exception
            F_Error(ex, "Cargar formulario de filtro  solicitudes")
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            If Not Valid_CampoObligatorio(txtFechaInicial) Or Not Valid_CampoObligatorio(txtFechaFinal) Then Exit Sub
            'Busca solicitudes
            Dim Total As Decimal = 0.0
            grdSolicitudMovimientoBancos.DataSource = Solicitudes.BuscarSolicitudes(txtFechaInicial.Text, txtFechaFinal.Text, NumeroDeEmpleado,
                                                                                    txtNombreCheque.Text, txtDescripcionCheque.Text,
                                                                                    OrigenTransaccion,
                                                                                    txtCodigoProveedor.Text, txtNombreProveedor.Text, txtSolicitud.Text)
            lblMensajes.Text = grdSolicitudMovimientoBancos.RowCount.ToString & " Registro(s) encontrado(s)"
        Catch ex As Exception
            F_Error(ex, "Buscar registros")
        End Try
    End Sub

    Private Sub grdSolicitudMovimientoBancos_SelectionChanged(sender As Object, e As EventArgs) Handles grdSolicitudMovimientoBancos.SelectionChanged
        mdiMenu.tssEstado.Text = "Solicitudes: " & grdSolicitudMovimientoBancos.SelectedRows.Count & "  |     Total: " & F_Format(SumarColumna(grdSolicitudMovimientoBancos, "Valor", True)).ToString()
    End Sub

    Private Sub grdIndice_Click(sender As Object, e As EventArgs) Handles grdIndice.Click
        cmdBuscar_Click(sender, (New System.EventArgs))
    End Sub

    Private Sub grdSolicitudMovimientoBancos_MouseDown(sender As Object, e As MouseEventArgs) Handles grdSolicitudMovimientoBancos.MouseDown
        MnuVerSolicitud.Enabled = False
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If grdSolicitudMovimientoBancos.SelectedRows.Count = 1 Then MnuVerSolicitud.Enabled = True
        End If
    End Sub

    Private Sub grdSolicitudMovimientoBancos_DoubleClick(sender As Object, e As EventArgs) Handles grdSolicitudMovimientoBancos.DoubleClick
        If grdSolicitudMovimientoBancos.SelectedRows.Count = 1 Then MnuVerSolicitud_Click(MnuVerSolicitud, (New System.EventArgs))
    End Sub

    Private Sub MnuVerSolicitud_Click(sender As Object, e As EventArgs) Handles MnuVerSolicitud.Click
        Try
            Dim frm As New FrmSolicitud
            frm.OrigenTransaccion = OrigenTransaccion
            frm.Solicitud = grdSolicitudMovimientoBancos.SelectedRows.Item(0).Cells("Solicitud").Value.ToString
            frm.Modo = ModosDeTecleo.Modificar
            mdiMenu.ParentMDI(frm)
        Catch ex As Exception
            F_Error(ex, "Ver Solicitud")
        End Try
    End Sub

    Private Sub cmdNuevoEncabezado_Click(sender As Object, e As EventArgs) Handles cmdNuevoEncabezado.Click
        Try
            Dim frm As New FrmSolicitud
            frm.OrigenTransaccion = OrigenTransaccion
            mdiMenu.ParentMDI(frm)

        Catch ex As Exception
            F_Error(ex, "Mostrar formulario de tecleo")
        End Try
    End Sub

    Private Sub cmdExportar_Click(sender As Object, e As EventArgs) Handles cmdExportar.Click
        Try
            If grdSolicitudMovimientoBancos.ColumnCount > 1 Then
                ExportGrd(grdSolicitudMovimientoBancos)
            End If
        Catch ex As Exception
            F_Error(ex, "Exportar a excel")
        End Try
    End Sub
End Class