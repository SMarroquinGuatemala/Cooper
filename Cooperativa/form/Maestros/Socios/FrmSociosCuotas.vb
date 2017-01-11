Public Class FrmSociosCuotas
    Dim ListCuotas As New List(Of CooperativaBLL.SociosCuotas)
    'Dim NivelDeAcceso As new NivelesDeAcceso = NivelesDeAcceso.Administrador
    'Public Enum NivelesDeAcceso
    '    Administrador
    '   Consultas
    'End Enum
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Try
            'If Not String.IsNullOrEmpty(txtNumeroDeEmpleado.Text) Then
            Dim SociosCuotas As New CooperativaBLL.SociosCuotas
            If (Not String.IsNullOrEmpty(txtNumeroDeEmpleado.Text)) Then SociosCuotas.NumeroDeEmpleado = txtNumeroDeEmpleado.Text
            If Not String.IsNullOrEmpty(cboRetenciones.SelectedValue) Then SociosCuotas.Retencion = cboRetenciones.SelectedValue
            Dim SociosCuotasManager As New CooperativaBLL.SociosCuotasManager
            ListCuotas = SociosCuotasManager.GetData(SociosCuotas)
            grdDatos.DataSource = ListCuotas
            'End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub FrmSociosCuotas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim ListRetenciones As New List(Of CooperativaBLL.Retenciones)
            Dim RetencionesManager As New CooperativaBLL.RetencionesManager
            ListRetenciones = RetencionesManager.GetData
            cboRetenciones.ValueMember = "Retencion"
            cboRetenciones.DisplayMember = "Nombre"
            cboRetenciones.DataSource = ListRetenciones
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub grdDatos_MouseUp(sender As Object, e As MouseEventArgs) Handles grdDatos.MouseUp
        Try
            If Not IsNothing(CType(sender, DataGridView).ContextMenuStrip) Then
                For Each item In CType(sender, DataGridView).ContextMenuStrip.Items
                    If String.Equals(item.GetType.Name, GetType(ToolStripMenuItem).Name) Then
                        item.Enabled = False
                    End If
                Next

                mnuGrabar.Enabled = True
                If (CType(sender, DataGridView).RowCount > 0) Then
                    If CType(sender, DataGridView).SelectedRows.Count = 1 Then
                        mnuModificar.Enabled = True
                        mnuConsultar.Enabled = True
                    End If
                    If CType(sender, DataGridView).RowCount >= 1 Then mnuEliminar.Enabled = True
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub mnuGrabar_Click(sender As Object, e As EventArgs) Handles mnuGrabar.Click
        Try
            Dim Frm As New FrmSociosCuotasTecleo
            Frm.ModoTecleo = ModosDeTecleo.Grabar
            Frm.ShowDialog()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub mnuModificar_Click(sender As Object, e As EventArgs) Handles mnuModificar.Click
        Try
            Dim Frm As New FrmSociosCuotasTecleo
            Frm.NumeroDeEmpleado = grdDatos.SelectedRows(0).Cells.Item("NumeroDeEmpleadoColumn").Value.ToString.Split(" ")(0)
            Frm.Fecha = grdDatos.SelectedRows(0).Cells.Item("FechaColumn").Value.ToString
            Frm.Retencion = grdDatos.SelectedRows(0).Cells.Item("RetencionColumn").Value.ToString
            Frm.ModoTecleo = ModosDeTecleo.Modificar
            Frm.ShowDialog()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub mnuEliminar_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        Try
            Dim Frm As New FrmSociosCuotasTecleo

            Frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mnuConsultar_Click(sender As Object, e As EventArgs) Handles mnuConsultar.Click
        Try
            Dim Frm As New FrmSociosCuotasTecleo
            Frm.ModoTecleo = ModosDeTecleo.Consultar
            Frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class