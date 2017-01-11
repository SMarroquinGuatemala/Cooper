Public Class clsReportsParameters

   Public sysTypes As New Dictionary(Of String, String)
   Private parametroValue As Integer
   Public Property Parametro() As Integer
      Get
         Return parametroValue
      End Get
      Set(ByVal value As Integer)
         parametroValue = value
      End Set
   End Property
   Private nombreValue As String
   Public Property Nombre() As String
      Get
         Return nombreValue
      End Get
      Set(ByVal value As String)
         nombreValue = value
      End Set
   End Property

   Private controlValue As Object
   Public Property Control() As Object
      Get
         Return controlValue
      End Get
      Set(ByVal value As Object)
         controlValue = value
      End Set
   End Property

   Private idReporteValue As String
   Public Property IdReporte() As String
      Get
         Return idReporteValue
      End Get
      Set(ByVal value As String)
         idReporteValue = value
      End Set
   End Property

   'Public Sub New()
   '   oTable = New DataTable
   '   Try
   '      oTable = CooperativaDB.ExecuteDataSet(CommandType.Text, "SELECT  distinct type, typename  FROM vwSYSTiposdedatos").Tables(0)
   '      For Each row As DataRow In oTable.Rows
   '         Dim key As Integer = row.Item("type").ToString
   '         Dim value As String = row.Item("typename").ToString
   '         sysTypes.Add(key, value)
   '      Next
   '   Catch ex As Exception
   '      Throw
   '   End Try
   'End Sub
   Public Function ReportsParameters(ByVal IdReporte As Integer) As DataTable
      ReportsParameters = Nothing
      oSql = New System.Text.StringBuilder
      oSql.AppendLine(" SELECT  B.Parametro,b.Nombre,C.NOMBRE Control, B.Parameter_name, type,b.Etiqueta, a.Opcional ")
      oSql.AppendLine(" FROM TblReportesParametrosAsociados A")
      oSql.AppendLine(" INNER JOIN TblReportesParametros  B ON B.Parametro =A.Parametro")
      oSql.AppendLine(" INNER JOIN TblReportesControles C  ON C.ControlID=B.ControlID")
      oSql.AppendLine(" WHERE IdReporte =@PIdReporte ")
      oSql.AppendLine(" ORDER BY A.Orden")
      Dim cmd = CooperativaDB.GetSqlStringCommand(oSql.ToString)
      CooperativaDB.AddInParameter(cmd, "PIdReporte", DbType.Int32, IdReporte)
      Return CooperativaDB.ExecuteDataSet(cmd).Tables(0)
   End Function

   Public Function GetDatabyIDSecReportes(IdReporte) As DataRow
      Try
         oSql = New System.Text.StringBuilder
         oSql.AppendLine("SELECT IdReporte,Nombre,Resumen,Archivo,Vigente,StoredProcedure FROM TblsecReportes")
         oSql.AppendLine(" WHERE IdReporte=@PIdReporte ")
         Dim cmd = CooperativaDB.GetSqlStringCommand(oSql.ToString)
         CooperativaDB.AddInParameter(cmd, "PIdReporte", DbType.Int32, IdReporte)
         Return CooperativaDB.ExecuteDataSet(cmd).Tables(0).Rows(0)
      Catch ex As Exception
         Throw
      End Try
   End Function

   Public Function GetDatabyIDReportesDataSource(IdReporte) As DataRow
      Try
         oSql = New System.Text.StringBuilder
         oSql.AppendLine("SELECT ReportesDataSourceID,IdReporte,ReportDataSource FROM TblReportesDataSource")
         oSql.AppendLine(" WHERE IdReporte=@PIdReporte ")
         Dim cmd = CooperativaDB.GetSqlStringCommand(oSql.ToString)
         CooperativaDB.AddInParameter(cmd, "PIdReporte", DbType.Int32, IdReporte)
         Return CooperativaDB.ExecuteDataSet(cmd).Tables(0).Rows(0)
      Catch ex As Exception
         Throw
      End Try
   End Function

   Public Function sp_executesql(ByVal oSql As System.Text.StringBuilder) As DataSet
      Try
         Dim cmd = CooperativaDB.GetSqlStringCommand(oSql.ToString)
         Return SolidarismoDB.ExecuteDataSet(cmd)
      Catch ex As Exception
         Throw
      End Try
   End Function

End Class
