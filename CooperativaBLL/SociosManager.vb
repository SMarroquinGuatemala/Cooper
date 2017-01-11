Imports System.Text
Public Class SociosManager
    Inherits ManagerBase

    Public Function GetData() As List(Of Socios)
        Try
            Dim ret As List(Of Socios) = Nothing
            oSql = New StringBuilder
            dt = New DataTable
            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function GetDataBy(ByVal NumeroDeEmpleado As String) As List(Of Socios)
        Try
            Dim ret As List(Of Socios) = Nothing
            oSql = New StringBuilder
            oSql.AppendLine("SELECT  NumeroDeEmpleado,Nombres,Apellidos,NombreCompleto,ApellidoDeCasada")
            oSql.AppendLine(",FechaDeNacimiento,LugarDeNacimiento,Sexo,Nacionalidad")
            oSql.AppendLine(",NumeroOrdenCedula,NumeroRegistroCedula,MunicipioCedula,DepartamentoCedula")
            oSql.AppendLine(",Direccion,Comunidad,Telefono,Nit,EstadoCivil")
            oSql.AppendLine(",DepartamentoEmpresa,FechaDeIngreso,FechaDeEgreso")
            oSql.AppendLine(",Planilla,TipoDePlanilla,Catorcenal,Salario,isActivo,DPI ")
            oSql.AppendLine(" FROM TblSocios WHERE NumeroDeEmpleado =@PNumeroDeEmpleado")
            Dim cmd = SolidarismoDB.GetSqlStringCommand(oSql.ToString)
            SolidarismoDB.AddInParameter(cmd, "PNumeroDeEmpleado", DbType.String, NumeroDeEmpleado)
            dt = New DataTable
            dt = SolidarismoDB.ExecuteDataSet(cmd).Tables(0)
            ret = MyBase.BuildCollection(Of Socios)(GetType(Socios), dt)
            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function




End Class
