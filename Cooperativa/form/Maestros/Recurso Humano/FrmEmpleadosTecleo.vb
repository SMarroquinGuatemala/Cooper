Public Class FrmEmpleadosTecleo
    Dim ListEmpleados As List(Of CooperativaBLL.clsEmpleados)
    Dim ListEmpleadosParametros As List(Of CooperativaBLL.ClsEmpleadosParametros)

    Private Sub FrmEmpleadosTecleo_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (Not String.IsNullOrEmpty(txtNumeroDeEmpleado.Text)) Then
            Dim Empleados As New CooperativaBLL.clsEmpleadosManager
            ListEmpleados = Empleados.GetDataByNumeroDeEmpleado(txtNumeroDeEmpleado.Text)
            txtNombres.Text = ListEmpleados.FirstOrDefault.Nombres
            txtApellidos.Text = ListEmpleados.FirstOrDefault.Apellidos
            txtNombreCompleto.Text = ListEmpleados.FirstOrDefault.NombreCompleto
            txtFechaInicial.Text = ListEmpleados.FirstOrDefault.FechaInicial
            If (Not IsNothing(ListEmpleados.FirstOrDefault.FechaFinal)) Then txtFechaFinal.Text = ListEmpleados.FirstOrDefault.FechaFinal

            ListEmpleadosParametros = Empleados.GetDataByNumeroDeEmpleadoParametros(txtNumeroDeEmpleado.Text)
        End If
    End Sub

    
End Class