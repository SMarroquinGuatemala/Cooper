Imports System.Text
Public Class RetencionesManager
    Inherits ManagerBase


    Public Function GetData() As List(Of Retenciones)
        Try
            Dim ret As List(Of Retenciones) = Nothing
            sSQL = New StringBuilder
            dt = New DataTable
            sSQL.Append("SELECT  Retencion,Nombre,Descripcion,CuentaContable,SignoMovimiento FROM TblRetenciones")
            dt = SolidarismoDB.ExecuteDataSet(CommandType.Text, sSQL.ToString).Tables(0)
            ret = MyBase.BuildCollection(Of Retenciones)(GetType(Retenciones), dt)
            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetDataBy(ByVal Retencion As String) As List(Of Retenciones)
        Try
            Dim ret As List(Of Retenciones) = Nothing
            sSQL = New StringBuilder
            dt = New DataTable
            sSQL.Append("SELECT  Retencion,Nombre,Descripcion,CuentaContable,SignoMovimiento FROM TblRetenciones")
            sSQL.Append("where Retencion =@Retencion")
            Dim cmd = SolidarismoDB.GetSqlStringCommand(sSQL.ToString)
            SolidarismoDB.AddInParameter(cmd, "Retencion", DbType.String, Retencion)
            dt = SolidarismoDB.ExecuteDataSet(cmd).Tables(0)
            ret = MyBase.BuildCollection(Of Retenciones)(GetType(Retenciones), dt)
            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
