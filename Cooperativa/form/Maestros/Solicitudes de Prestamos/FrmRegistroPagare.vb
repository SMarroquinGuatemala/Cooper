Public Class FrmRegistroPagare
    Private idReporteValue As Integer = 0
    Dim table As DataTable
    Dim count As Integer = 1
    Dim itemHeight As Integer = 0
    Dim reportsparameters As New CooperativaBLL.clsReportsParameters
    Dim SQLString As String = String.Empty
    Dim ParmDefinition As String = String.Empty
    Dim ParmValues As String = String.Empty
    Dim Archivo As String
    Dim reportdatasoure As String = String.Empty
   
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click

        Me.Cursor = Cursors.WaitCursor
        Dim sbSql As New System.Text.StringBuilder
        Dim row As DataRow
        Dim oDataSet As New DataSet
        Try
            xSqlDefault = String.Empty
            row = reportsparameters.GetDatabyIDSecReportes(idReporteValue)
            reportdatasoure = reportsparameters.GetDatabyIDReportesDataSource(idReporteValue).Item("ReportDataSource").ToString
            SQLString = String.Concat("DECLARE @SQLString NVARCHAR(100)=N'", row.Item("StoredProcedure").ToString, Space(1))
            ParmDefinition = " DECLARE @ParmDefinition nvarchar(500) SET @ParmDefinition=N' "
            ParmValues = String.Empty
            Archivo = row.Item("Archivo").ToString
            For Each control As Control In Me.Controls
                If Not TypeOf control Is Label Then
                    If Not String.IsNullOrEmpty(control.Tag) Then
                        SQLString &= String.Concat(control.Tag.ToString.Split(" ")(0), ",")
                        ParmDefinition &= String.Concat(control.Tag, Space(1), ",")
                        ParmValues &= String.Concat(control.Tag.ToString.Split(" ")(0), " = ", IIf(String.IsNullOrEmpty(control.Text), "NULL", String.Concat("'", control.Text, "'")), ",")
                    End If
                End If
            Next
            sbSql.AppendLine(String.Concat(SQLString.Substring(0, SQLString.Length - 1), "'"))
            sbSql.AppendLine(String.Concat(ParmDefinition.Substring(0, ParmDefinition.Length - 1), "'"))
            sbSql.AppendLine("EXECUTE sp_executesql  @SQLString  ,@ParmDefinition, ")
            sbSql.AppendLine(ParmValues.Substring(0, ParmValues.Length - 1))
            oDataSet = reportsparameters.sp_executesql(sbSql)

            FrmReportingServicesDisplay.Show(Archivo, oDataSet, reportdatasoure)
        Catch ex As Exception
            F_Error(ex, "Error al generar reporte")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
      
End Class