Public Class clsEmpleadosManager
    Inherits ManagerBase
    Private dt As DataRow
    Public Function ObtenerEmpleadosDataTable(ByVal NumerodeEmpleado As String, ByVal Nombres As String, ByVal Apellidos As String, ByVal FechaInicial As String) As List(Of clsEmpleados)
        Dim dt As New DataTable()
        Dim ret As List(Of clsEmpleados) = Nothing
        dt = CooperativaDB.ExecuteDataSet("UpGetEmpleados", NumerodeEmpleado, Nombres, Apellidos, FechaInicial).Tables(0)
        ' Build Collection of Entity Objets using Reflection
        Try
            ret = MyBase.BuildCollection(Of clsEmpleados)(GetType(clsEmpleados), dt)
            Return ret
        Catch ex As Exception

        End Try
    End Function

   


    Public Function GetDataByNumeroDeEmpleado(ByVal NumeroDeEmpleado As String) As List(Of clsEmpleados)
        dt = Nothing
        Dim ret As List(Of clsEmpleados) = Nothing
        dt = CooperativaDB.ExecuteDataSet("UpGetEmpleado", NumeroDeEmpleado).Tables(0).Rows(0)
        ' Build Collection of Entity Objets using Reflection
        Try
            ret = MyBase.BuildCollection(Of clsEmpleados)(GetType(clsEmpleados), dt)

            Return ret
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function GetDataByNumeroDeEmpleadoParametros(ByVal NumeroDeEmpleado As String) As List(Of ClsEmpleadosParametros)
        oTable = Nothing
        dt = Nothing
        Dim ret As List(Of ClsEmpleadosParametros) = Nothing
        Try
            oTable = CooperativaDB.ExecuteDataSet("DbSolidarismo.dbo.UpSPlaEmpleadosParametros", NumeroDeEmpleado).Tables(0)
            If (Not oTable Is Nothing AndAlso oTable.Rows.Count > 0) Then
                dt = oTable.Rows(0)
            End If
            ret = MyBase.BuildCollection(Of ClsEmpleadosParametros)(GetType(ClsEmpleadosParametros), dt)
            Return ret
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


End Class
