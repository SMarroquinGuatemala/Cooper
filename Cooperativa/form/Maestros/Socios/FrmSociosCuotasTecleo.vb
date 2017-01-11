Public Class FrmSociosCuotasTecleo
    Public Property NumeroDeEmpleado() As String
    Public Property Fecha() As Date
    Public Property Retencion() As String
    Public ModoTecleo As ModosDeTecleo = ModosDeTecleo.Consultar

    Dim ListRetenciones As List(Of CooperativaBLL.Retenciones)
    Dim ListSocios As List(Of CooperativaBLL.Socios)
    Dim ListSociosCuotas As List(Of CooperativaBLL.SociosCuotas)

    Dim RetencionesManager As New CooperativaBLL.RetencionesManager
    Dim SociosCuotas As New CooperativaBLL.SociosCuotas
    Dim SociosManager As New CooperativaBLL.SociosManager
    Dim SociosCuotasManager As New CooperativaBLL.SociosCuotasManager



    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            If (String.IsNullOrEmpty(NumeroDeEmpleadoTextBox.Text)) Then Exit Sub
            If (String.IsNullOrEmpty(cboRetenciones.SelectedValue)) Then Exit Sub
            If (Not IsDate(FechaMaskedTextBox.Text)) Then Exit Sub
            If (String.IsNullOrEmpty(CapitalTextBox.Text)) Then Exit Sub
            If (String.IsNullOrEmpty(InteresesTextBox.Text)) Then Exit Sub
            If (String.IsNullOrEmpty(ValorTextBox.Text)) Then Exit Sub
            ValorTextBox.Text = Convert.ToDecimal(CapitalTextBox.Text) + Convert.ToDecimal(InteresesTextBox.Text)
            SociosCuotasManager = New CooperativaBLL.SociosCuotasManager
            SociosCuotas.NumeroDeEmpleado = NumeroDeEmpleadoTextBox.Text
            SociosCuotas.Fecha = FechaMaskedTextBox.Text
            SociosCuotas.Retencion = cboRetenciones.SelectedValue
            If (IsDate(FechaFinalMaskedTextBox.Text)) Then SociosCuotas.FechaFinal = FechaFinalMaskedTextBox.Text
            SociosCuotas.Descripcion = DescripcionTextBox.Text
            SociosCuotas.Observaciones = ObservacionesTextBox.Text
            SociosCuotas.Capital = CapitalTextBox.Text
            SociosCuotas.Intereses = InteresesTextBox.Text
            SociosCuotas.Valor = ValorTextBox.Text
            SociosCuotasManager.Save(SociosCuotas)
            MsgBox("Proceso  terminado correctamente", MsgBoxStyle.OkOnly, My.Resources.MensajedelSistema)
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub FrmSociosCuotasTecleo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            RetencionesManager = New CooperativaBLL.RetencionesManager
            ListRetenciones = New List(Of CooperativaBLL.Retenciones)
            ListRetenciones = RetencionesManager.GetData
            cboRetenciones.ValueMember = "Retencion"
            cboRetenciones.DisplayMember = "Nombre"
            cboRetenciones.DataSource = ListRetenciones

            If ModoTecleo = ModosDeTecleo.Modificar Then
                NumeroDeEmpleadoTextBox.Text = NumeroDeEmpleado
                FechaMaskedTextBox.Text = Fecha
                cboRetenciones.SelectedValue = Retencion.Split(" ")(0)

                ListSocios = New List(Of CooperativaBLL.Socios)
                ListSocios = SociosManager.GetDataBy(NumeroDeEmpleado)
                txtNombreDeEmpleado.Text = ListSocios.FirstOrDefault.NombreCompleto

                SociosManager = New CooperativaBLL.SociosManager
                SociosCuotas.NumeroDeEmpleado = NumeroDeEmpleado
                SociosCuotas.Fecha = Fecha
                SociosCuotas.Retencion = cboRetenciones.SelectedValue

                ListSociosCuotas = New List(Of CooperativaBLL.SociosCuotas)
                ListSociosCuotas = SociosCuotasManager.GetData(SociosCuotas)

                If ListSociosCuotas.Count > 0 Then
                    If Not IsNothing(ListSociosCuotas.FirstOrDefault.FechaFinal) Then FechaFinalMaskedTextBox.Text = ListSociosCuotas.FirstOrDefault.FechaFinal
                    DescripcionTextBox.Text = ListSociosCuotas.FirstOrDefault.Descripcion
                    ObservacionesTextBox.Text = ListSociosCuotas.FirstOrDefault.Observaciones
                    CapitalTextBox.Text = ListSociosCuotas.FirstOrDefault.Capital
                    InteresesTextBox.Text = ListSociosCuotas.FirstOrDefault.Intereses
                    ValorTextBox.Text = ListSociosCuotas.FirstOrDefault.Valor
                End If
            End If

        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

    Private Sub InteresesTextBox_LostFocus(sender As Object, e As EventArgs) Handles InteresesTextBox.LostFocus
        ValorTextBox.Text = Convert.ToDecimal(CapitalTextBox.Text) + Convert.ToDecimal(InteresesTextBox.Text)
    End Sub

    Private Sub CapitalTextBox_LostFocus(sender As Object, e As EventArgs) Handles CapitalTextBox.LostFocus
        ValorTextBox.Text = Convert.ToDecimal(CapitalTextBox.Text) + Convert.ToDecimal(InteresesTextBox.Text)
    End Sub

    Private Sub CapitalTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CapitalTextBox.Validating, InteresesTextBox.Validating, ValorTextBox.Validating
        Try
            If IsNumeric(CType(sender, TextBox).Text) Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Catch ex As Exception
            F_Error(ex)
        End Try
    End Sub

   
    Private Sub FechaFinalMaskedTextBox_TypeValidationCompleted(sender As Object, e As TypeValidationEventArgs) Handles FechaFinalMaskedTextBox.TypeValidationCompleted, FechaMaskedTextBox.TypeValidationCompleted
        Try
            'If (Not CType(sender, MaskedTextBox).AccessibleRole = Windows.Forms.AccessibleRole.WhiteSpace) Then
            If (Not String.IsNullOrEmpty(CType(sender, MaskedTextBox).Text.Replace(CType(sender, MaskedTextBox).Culture.DateTimeFormat.DateSeparator, "").Trim)) Then
                If (Not e.IsValidInput) Then
                    MsgBox(e.Message.ToString, MsgBoxStyle.OkOnly, My.Resources.MensajedelSistema)
                    e.Cancel = True
                End If


            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub NumeroDeEmpleadoTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumeroDeEmpleadoTextBox.Validating
        Dim MethodName As String = New StackFrame(0).GetMethod().Name
        Try
            'If String.IsNullOrEmpty(CType(sender, TextBox).Text) then e.    
            ListSocios = New List(Of CooperativaBLL.Socios)
            SociosManager = New CooperativaBLL.SociosManager
            ListSocios = SociosManager.GetDataBy(CType(sender, TextBox).Text)
            If (Not ListSocios.Count = 0) Then
                If (Not ListSocios.FirstOrDefault.isActivo) Then
                    MsgBox("El socio no esta activo", MsgBoxStyle.OkCancel, My.Resources.MensajedelSistema)
                    e.Cancel = True
                Else
                    txtNombreDeEmpleado.Text = ListSocios.FirstOrDefault.NombreCompleto
                    e.Cancel = False
                End If
            Else
                MsgBox("El socio no existe", MsgBoxStyle.OkCancel, My.Resources.MensajedelSistema)
                e.Cancel = True
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class