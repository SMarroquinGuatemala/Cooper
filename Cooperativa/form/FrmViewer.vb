Public Class FrmViewer
    Private _ReporteConParametros As Boolean = True
    Private _Parametro1 As String
    Private _IdReporte As Integer
    Private Reporte As New CooperativaBLL.clsReportes

    Public Property IdReporte() As Integer
        Get
            Return _IdReporte
        End Get
        Set(ByVal value As Integer)
            _IdReporte = value
            Reporte.IdReporte = value
            If Reporte.Vigente Then
                Me.Text = Reporte.Nombre
            End If
        End Set
    End Property

    Public Property Parametro1() As String
        Get
            Return _Parametro1
        End Get
        Set(ByVal value As String)
            _Parametro1 = value
        End Set
    End Property

    Public Property ReporteConParametros() As Boolean
        Get
            Return _ReporteConParametros
        End Get
        Set(ByVal value As Boolean)
            _ReporteConParametros = value
        End Set
    End Property

    Private Sub FrmViewer_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 And ReporteConParametros Then
            PanelParametros(Not lblParametros.Visible)
        End If
    End Sub

    Sub PanelParametros(Visible As Boolean)
        lblParametros.Visible = Visible
        grbParametros.Visible = Visible
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            GenerarReporte()
        Catch ex As Exception
            F_Error(ex, "Generar reporte")
        End Try
    End Sub

    Sub GenerarReporte()
        Try
            If Reporte.Vigente AndAlso CamposValidos() Then
                Me.Cursor = Cursors.WaitCursor
                If xReport.IsLoaded Then xReport.Close()
                xReport.Load(Reporte.Archivo)
                Select Case Reporte.IdReporte
                    Case 1 'Libro compras
                        xReport.ParameterFields.Item("@PFechaIncial").CurrentValues.Clear()
                        xReport.ParameterFields.Item("@PFechaIncial").CurrentValues.AddValue(CDate(txtFechaInicial.Text))
                        xReport.ParameterFields.Item("@PFechaFinal").CurrentValues.Clear()
                        xReport.ParameterFields.Item("@PFechaFinal").CurrentValues.AddValue(CDate(txtFechaFinal.Text))
                    Case 2 'Boleta Transaccion
                        xReport.ParameterFields.Item("@IdTransaccion").CurrentValues.Clear()
                        xReport.ParameterFields.Item("@IdTransaccion").CurrentValues.AddValue(CInt(Parametro1))
                    Case 3 'LibroVentas
                        xReport.ParameterFields.Item("@PFechaIncial").CurrentValues.Clear()
                        xReport.ParameterFields.Item("@PFechaIncial").CurrentValues.AddValue(CDate(txtFechaInicial.Text))
                        xReport.ParameterFields.Item("@PFechaFinal").CurrentValues.Clear()
                        xReport.ParameterFields.Item("@PFechaFinal").CurrentValues.AddValue(CDate(txtFechaFinal.Text))
                End Select
                For i As Integer = 0 To xReport.DataSourceConnections.Count - 1
                    xReport.DataSourceConnections(i).IntegratedSecurity = True
                Next
                crvReporte.ReportSource = xReport
                crvReporte.Refresh()
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Throw
        Finally
            Me.Cursor = Cursors.Default
            PanelParametros(False)
        End Try
    End Sub

    Function CamposValidos() As Boolean
        Try
            If ReporteConParametros Then
                If Not Valid_CampoObligatorio(txtFechaFinal) Or
                    Not Valid_CampoObligatorio(txtFechaInicial) Then
                    Return False
                End If
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub FrmViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not ReporteConParametros Then
                GenerarReporte()
            Else
                txtFechaInicial.Text = F_PrimerDia(Date.Now)
                txtFechaFinal.Text = F_UltimoDia(Date.Now)
            End If
        Catch ex As Exception
            F_Error(ex, "Cargar Formulario")
        End Try
    End Sub

    Private Sub crvReporte_Load(sender As Object, e As EventArgs) Handles crvReporte.Load

    End Sub
End Class