Public Class mdiMenu
    Private Sub utrToolbar_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utrToolbar.ToolClick
      Try
            Select Case e.Tool.Key
                Case "MnuEmpleados"
                    Dim frm As New FrmEmpleados
                    ParentMDI(frm)
                Case "mnuArchivosBanco"
                    Dim frm As New FrmGenerarArchivoBanco
                    ParentMDI(frm)
                Case "mnuValoresporNivel"
                    Dim frm As New FrmBasePrestamos
                    frm.Show()
                Case "MnuListadodeReportes"
                    Dim frm As New FrmListadoDeReportes
                    ParentMDI(frm)
                Case "mnuAdmisiones"
                    Dim frm As New FrmTransacciones
                    frm.OrigenTransaccion = 1
                    ParentMDI(frm)
                Case "mnuPrestamos"
                    Dim frm As New FrmTransacciones
                    frm.OrigenTransaccion = 6
                    ParentMDI(frm)
                Case "mnuRetiros"
                    Dim frm As New FrmTransacciones
                    frm.OrigenTransaccion = 7
                    ParentMDI(frm)
                Case "mnuBazar"
                    Dim frm As New FrmTransacciones
                    frm.OrigenTransaccion = 8
                    ParentMDI(frm)
                Case "mnuProveedores"
                    Dim frm As New FrmProveedores
                    ParentMDI(frm)
                Case "mnuCompras"
                    Dim frm As New FrmFiltroSolicitudes
                    frm.OrigenTransaccion = 20
                    ParentMDI(frm)
                Case "mnuLibroCompras"
                    Dim frm As New FrmViewer
                    frm.IdReporte = 1
                    ParentMDI(frm)
                Case "mnuLibroVentas"
                    Dim frm As New FrmViewer
                    frm.IdReporte = 3
                    ParentMDI(frm)
                Case "mnuContabilidad"
                    Dim frm As New FrmFiltroSolicitudes
                    frm.OrigenTransaccion = 23
                    ParentMDI(frm)
                Case "mnuFechaOperacion"
                    Dim frm As New FrmCambioFechaOperacion
                    frm.ShowDialog()
                Case "mnuCuentas"
                    Dim frm As New FrmCuentasContables
                    ParentMDI(frm)
                Case "mnuTecleoDirecto"
                    Dim frm As New FrmIntranet
                    ParentMDI(frm)
            End Select
            If (Not String.IsNullOrEmpty(e.Tool.SharedProps.AccessibleName)) Then
                Dim _frm As Form = DirectCast(Activator.CreateInstance( _
                              Type.GetType(Me.ProductName + "." + e.Tool.SharedProps.AccessibleName)), Form)
                If (e.Tool.SharedProps.AccessibleRole = Windows.Forms.AccessibleRole.PageTab) Then
                    ParentMDI(_frm)
                Else
                    _frm.ShowDialog()
                End If


            End If
        Catch ex As Exception
            F_Error(ex, "Seleccionar opcion")
        End Try
    End Sub

    Public Sub ParentMDI(ByVal Formulario As Form, Optional Maximized As Boolean = True)
        Formulario.MdiParent = Me
        Formulario.Show()
        If Maximized Then Formulario.WindowState = FormWindowState.Maximized
    End Sub
 
 
    Private Sub mdiMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Try

         LogIn()
         tssAplicacion.Text = AppName
         tssUsuario.Text = Usuario
         tssComputadora.Text = Computadora
         tssServidor.Text = Servidor
         tssFechaOperacion.Text = FechaOperacion
         If AutoUpdate() Then
            Dispose()
            Application.Exit()
         End If
      Catch ex As Exception
         F_Error(ex, "Iniciar sistema")
      End Try
    End Sub

End Class
