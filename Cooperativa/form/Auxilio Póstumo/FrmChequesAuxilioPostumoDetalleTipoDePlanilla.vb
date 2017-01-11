Public Class FrmChequesAuxilioPostumoDetalleTipoDePlanilla
    Dim SociosAuxilioPostumoManager As New CooperativaBLL.SociosAuxilioPostumoManager
    Public Property NumeroDocumento() As Integer

    Private Sub FrmChequesAuxilioPostumoDetalleTipoDePlanilla_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNumeroDeDocumento.Text = NumeroDocumento
        GetData(NumeroDocumento)
    End Sub

    Public Sub GetData(ByVal NumeroDeDocumento As Integer)
        Dim oDataSet As New DataSet
        Dim otableNombre As New DataTable
        Dim otable As New DataTable
        oDataSet = SociosAuxilioPostumoManager.GetAuxilioPostumoPorTipoDePlanilla(NumeroDeDocumento)
        If (Not (oDataSet.Tables(0).Rows.Count = 0)) Then

            otableNombre = oDataSet.Tables(0)
            If otableNombre.Rows.Count > 0 Then
                txtNombreFallecido.Text = otableNombre.Rows(0).Item("NombreFallecido").ToString
                txtCuota.Text = otableNombre.Rows(0).Item("Cuota").ToString
                otable = oDataSet.Tables(1)
                If (otable.Rows.Count > 0) Then
                    grdDatos.DataSource = otable
                    txtTotal.Text = FormatCurrency(otable.Compute("SUM(Valor)", ""), 2)
                End If
            End If
        Else
            MsgBox("No hay detalle para el número de documento ingresado")
            ActiveControl = txtNumeroDeDocumento
        End If
    End Sub

    Private Sub txtNumeroDeDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroDeDocumento.KeyPress
        Try
            If (e.KeyChar = ChrW(Keys.Enter)) Then
                If (Not String.IsNullOrEmpty(CType(sender, TextBox).Text)) Then
                    GetData(CType(sender, TextBox).Text)
                End If
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

   
   

  
End Class