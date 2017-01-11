Public Class FrmEmpleados

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles Me.Load
      
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim mgr As New CooperativaBLL.clsEmpleadosManager
            grdDatos.DataSource = mgr.ObtenerEmpleadosDataTable(txtNumeroDeEmpleado.ToString, txtNombres.ToString, txtApellidos.ToString, txtFechaInicial.ToString)
            tssRegistros.Text = grdDatos.RowCount
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    
    Private Sub mnuGrabar_Click(sender As Object, e As EventArgs) Handles mnuGrabar.Click

        Try

        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub


    Private Sub muModificar_Click(sender As Object, e As EventArgs) Handles muModificar.Click
        Dim frm As New FrmEmpleadosTecleo
        Try
            frm.txtNumeroDeEmpleado.Text = grdDatos.SelectedRows(0).Cells.Item("NumeroDeEmpleadoColumn").Value.ToString
            frm.ShowDialog()
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub
End Class