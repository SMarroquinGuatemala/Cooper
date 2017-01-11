Public Class SociosAuxilioPostumoManager

    Public Function GetDataSociosAuxilioPostumo(ByVal NumeroDeEmpleado As String, ByVal TipoDeParentezco As Nullable(Of Integer)) As DataTable
        Try
            Dim oNumeroDeEmpleado As String = Nothing
            If (Not String.IsNullOrEmpty(NumeroDeEmpleado)) Then oNumeroDeEmpleado = NumeroDeEmpleado
            oTable = New DataTable
            oTable = CooperativaDB.ExecuteDataSet("DbSolidarismo.dbo.UPSChequesSociosAuxilioPostumo", oNumeroDeEmpleado, TipoDeParentezco).Tables(0)
            Return oTable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetAuxilioPostumoPorTipoDePlanilla(ByVal NumeroDocumento As Integer) As DataSet
        Try
            Dim oDataSet As New DataSet
            oDataSet = CooperativaDB.ExecuteDataSet("DbSolidarismo.dbo.UPSAuxilioPostumoPorTipoDePlanilla", NumeroDocumento)
            Return oDataSet
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
