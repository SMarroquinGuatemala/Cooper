Public Class FrmChequesAuxilioPostumo
    Dim SociosAuxilioPostumoManager As New CooperativaBLL.SociosAuxilioPostumoManager
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            grdDatos.DataSource = SociosAuxilioPostumoManager.GetDataSociosAuxilioPostumo(txtNumeroDeEmpleado.Text, Nothing)
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub grdDatos_MouseUp(sender As Object, e As MouseEventArgs) Handles grdDatos.MouseUp
        Try
            MnuOpciones.Enabled = False
            If grdDatos.RowCount > 0 Then
                If grdDatos.SelectedRows.Count = 1 Then
                    MnuOpciones.Enabled = True
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub VerDetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDetalleToolStripMenuItem.Click
        Try
            If Not (grdDatos.SelectedRows(0).Cells.Item("NumeroDocumentoColumn").Value) Then
                Dim frm As New FrmChequesAuxilioPostumoDetalleTipoDePlanilla
                frm.NumeroDocumento = grdDatos.SelectedRows(0).Cells.Item("NumeroDocumentoColumn").Value
                frm.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class