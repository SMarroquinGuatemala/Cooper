

Public Class ClsGenerarDatosReportes
   Private FechaInicialValue As Nullable(Of Date)
   Public Property FechaInicial() As String
      Get
         Return FechaInicialValue
      End Get
      Set(ByVal value As String)
         FechaInicialValue = value
      End Set
   End Property

   ''' <summary>
   ''' Obtiene los descuentos de las retenciones que inician con un "4"(Solidarismo) para  el personal de nomina (Guatemala, San Diego)
   ''' </summary>
   ''' <param name="FechaInicial"></param>
   ''' <param name="FechaFinal"></param>
   ''' <param name="Retencion"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function FillDescuentosNomina(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal Retencion As String, NumeroDeEmpleado As String) As DataTable      
      Return SolidarismoDB.ExecuteDataSet("UpSMovimientoRetenciones", FechaInicial, FechaFinal, Retencion, NumeroDeEmpleado).Tables(0)
   End Function
End Class
