Public Class SociosCuotasManager
    Inherits ManagerBase
    Public Function GetData(ByVal SociosCuotas As SociosCuotas) As List(Of SociosCuotas)
        Dim dt As New DataTable()
        Dim ret As List(Of SociosCuotas) = Nothing
        dt = CooperativaDB.ExecuteDataSet("DbSolidarismo.dbo.UPSSociosCuotas",
                                          SociosCuotas.NumeroDeEmpleado,
                                          SociosCuotas.Fecha,
                                          SociosCuotas.Retencion,
                                          SociosCuotas.FechaFinal,
                                          SociosCuotas.Descripcion,
                                          SociosCuotas.Observaciones,
                                          SociosCuotas.Capital,
                                          SociosCuotas.Intereses,
                                          SociosCuotas.Valor).Tables(0)
        ' Build Collection of Entity Objets using Reflection
        Try
            ret = MyBase.BuildCollection(Of SociosCuotas)(GetType(SociosCuotas), dt)
            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub Save(ByVal SociosCuotas As SociosCuotas)
        Try
            CooperativaDB.ExecuteNonQuery("DbSolidarismo.dbo.UpGrabarSociosCuotas", SociosCuotas.NumeroDeEmpleado,
                                          SociosCuotas.Fecha,
                                          SociosCuotas.Retencion,
                                          SociosCuotas.FechaFinal,
                                          SociosCuotas.Descripcion,
                                          SociosCuotas.Observaciones,
                                          SociosCuotas.Capital,
                                          SociosCuotas.Intereses,
                                          SociosCuotas.Valor)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
