Public Class FrmBasePrestamos
    Dim NivelOrganizacional As New CooperativaBLL.NivelOrganizacionalClass
   Private Sub FrmBasePrestamos_Load(sender As Object, e As EventArgs) Handles Me.Load

   End Sub

   Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            NivelOrganizacional.NivelOrganizacional = Nothing
            If Not String.IsNullOrEmpty(txtNivelOrganizacional.Text) Then NivelOrganizacional.NivelOrganizacional = txtNivelOrganizacional.Text
            NivelOrganizacional.Nombre = txtNombre.Text
            NivelOrganizacional.FillList()            
            grdNivelesOrganizacionales.DataSource = NivelOrganizacional.NivelesOrganicacionales
        Catch ex As Exception
            F_Error(ex)
        End Try
   End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Try
            If (grdNivelesOrganizacionales.RowCount > 0 AndAlso grdNivelesOrganizacionales.SelectedRows.Count > 0) Then
                Dim frm As New FrmBasePrestamosTecleo
                frm.NivelOrganizacional = grdNivelesOrganizacionales.SelectedRows(0).Cells.Item("NivelOrganizacionalColumn").Value.ToString
                frm.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class