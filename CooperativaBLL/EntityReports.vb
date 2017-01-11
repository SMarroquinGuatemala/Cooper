Public Class EntityReports
   'IdReporte	int
   Private IdReporteValue As Nullable(Of Int16) = Nothing
   Public Property IdReporte() As Nullable(Of Int16)
      Get
         Return IdReporteValue
      End Get
      Set(ByVal value As Nullable(Of Int16))
         IdReporteValue = value
      End Set
   End Property
   'Nombre	varchar
   Private NombreValue As String
   Public Property Nombre() As String
      Get
         Return NombreValue
      End Get
      Set(ByVal value As String)
         NombreValue = value
      End Set
   End Property
   'Resumen	varchar
   Private ResumenValue As String
   Public Property Resumen() As String
      Get
         Return ResumenValue
      End Get
      Set(ByVal value As String)
         ResumenValue = value
      End Set
   End Property
   'Archivo	varchar
   Private ArchivoValue As FileIO.FileSystem
   Public Property Archivo() As FileIO.FileSystem
      Get
         Return ArchivoValue
      End Get
      Set(ByVal value As FileIO.FileSystem)
         ArchivoValue = value
      End Set
   End Property

   'Vigente	tinyint
   Private VigenteValue As String
   Public Property Vigente() As String
      Get
         Return VigenteValue
      End Get
      Set(ByVal value As String)
         VigenteValue = value
      End Set
   End Property

End Class
