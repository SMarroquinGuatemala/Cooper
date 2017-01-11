Public Class FrmCambioFechaOperacion

    Private Sub cmdGrabar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGrabarEncabezado.Click
        Try
            modFunciones.FechaOperacion = CDate(Me.txtFecha.Text)
            mdiMenu.tssFechaOperacion.Text = Me.txtFecha.Text
            Me.Dispose()
        Catch ex As Exception
            modFunciones.F_Error(ex, "Cambiar fecha operacion")
        End Try
    End Sub



     


End Class