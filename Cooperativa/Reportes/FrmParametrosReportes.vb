Option Strict Off
Imports CooperativaBLL.ClsGenerarDatosReportes

Public Class FrmParametrosReportes

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
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

   Overloads Sub Show(ByVal IdReporte As Integer)
      idReporteValue = IdReporte
      Me.Show()
   End Sub

   Overloads Sub ShowDialog(ByVal IdReporte As Integer)
      idReporteValue = IdReporte
      Me.ShowDialog()
   End Sub

   Private Sub FrmParametrosReportes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      Me.Dispose()
   End Sub

   Private Sub FrmParametrosReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.Cursor = Cursors.WaitCursor
      xTableDefault = Nothing
      Dim item As New Control
      Dim itemlabel As New Control
      Dim type As Type


        Try
            xTableDefault = reportsparameters.ReportsParameters(idReporteValue)
            If (Not xTableDefault Is Nothing) Then
                For Each row As DataRow In xTableDefault.Rows

                    type = GetType(Control).Assembly.[GetType]("System.Windows.Forms." & row.Item("Control").ToString, True)
                    item = Activator.CreateInstance(type)
                    item.Location = New System.Drawing.Point(10, itemHeight + (count * 20))
                    item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

                    Me.ToolTip1.SetToolTip(item, row.Item("Etiqueta").ToString)
                    itemHeight += item.Height
                    If (row.Item("type").ToString = 2) Then
                        CType(item, MaskedTextBox).Mask = "00/00/0000"
                        CType(item, MaskedTextBox).ValidatingType = GetType(Date)
                        If (idReporteValue = 55) Then
                            CType(item, MaskedTextBox).Text = Date.Now
                        End If
                    End If

                    If (row.Item("Opcional").ToString = 1) Then
                        item.BackColor = System.Drawing.Color.LightGray
                    Else
                        item.BackColor = System.Drawing.Color.LemonChiffon
                    End If
                    item.TabIndex = count
                    item.Tag = row.Item("Parameter_name").ToString
                    Me.Controls.Add(item)
                    type = GetType(Control).Assembly.[GetType]("System.Windows.Forms.Label", True)
                    itemlabel = Activator.CreateInstance(type)
                    itemlabel.Text = row.Item("Etiqueta").ToString
                    itemlabel.AutoSize = True
                    itemlabel.Location = New System.Drawing.Point(10, (CType(item, Control).Location.Y) - 15)

                    Me.Controls.Add(itemlabel)
                    System.Math.Max(System.Threading.Interlocked.Increment(count), count - 1)

                Next
            End If
        Catch ex As Exception
            F_Error(ex, "Error al cargar formulario")
        Finally
            Me.Cursor = Cursors.Default
        End Try
   End Sub
End Class