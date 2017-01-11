Imports CooperativaBLL.ClsGenerarDatosReportes
Imports Microsoft.Reporting.WinForms

Public Class FrmReportingServicesDisplay
   Private Table As DataTable
   Private Sub FrmReportingServicesDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Overloads Sub Show(ByVal NameReport As String,
                      ByVal ValueDataSource As DataSet,
                      ByVal NameDataSource As String)
      ShowReport(NameReport, ValueDataSource, NameDataSource)
      Me.Show()
   End Sub

   Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
      MyBase.OnKeyDown(e)
      If (e.KeyData = Keys.Control + Keys.P) Then
         Me.ReportViewer1.PrintDialog()
      End If
   End Sub


   Public Sub ShowReport(NameReport As String, ValueDataSource As DataSet, NameDataSource As String)
        Dim myStartupPath As String = Application.StartupPath
        If Not TipoUsuario = "Usuario" Then
            myStartupPath = "C:\Sistemas San Diego\Cooperativa\Cooperativa"
        End If
        Try
            Me.ReportViewer1.ProcessingMode = ProcessingMode.Local

            Me.ReportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(myStartupPath, My.Resources.UbicacionReportesDessarrollo, NameReport)
            Dim rds As ReportDataSource = New ReportDataSource()
            rds.Name = NameDataSource
            rds.Value = ValueDataSource.Tables(0)
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.ZoomPercent = 100
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            F_Error(ex)
        End Try
   End Sub

   


End Class