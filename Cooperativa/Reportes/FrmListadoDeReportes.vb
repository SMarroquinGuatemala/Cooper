Imports CooperativaBLL.ClsGenerarDatosReportes
Imports CooperativaBLL.clsReportes
Public Class FrmListadoDeReportes
   Dim listofparameters As CooperativaBLL.EntityReports

   Private Sub FrmListadoDeReportes_Load(sender As Object, e As EventArgs) Handles Me.Load
      listofparameters = New CooperativaBLL.EntityReports
      'listofparameters.IdReporte = 50
      grdListadoDeReportes.DataSource = ListOfReports(listofparameters)
   End Sub

   
   Private Sub grdListadoDeReportes_DoubleClick(sender As Object, e As EventArgs) Handles grdListadoDeReportes.DoubleClick
      Dim IdReporte As Integer = 0
      Dim Archivo As String = String.Empty
      If (grdListadoDeReportes.RowCount > 0) Then
         IdReporte = grdListadoDeReportes.SelectedRows(0).Cells.Item("Codigo").Value.ToString
         Archivo = grdListadoDeReportes.SelectedRows(0).Cells.Item("Archivo").Value.ToString
         FrmParametrosReportes.ShowDialog(IdReporte)
      End If
   End Sub

  
End Class