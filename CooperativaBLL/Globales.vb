Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.VisualBasic



Module Globales
    Public factory As DatabaseProviderFactory = New DatabaseProviderFactory
    Public SolidarismoDB As Microsoft.Practices.EnterpriseLibrary.Data.Database = factory.Create("Solidarismo")
    Public CooperativaDB As Microsoft.Practices.EnterpriseLibrary.Data.Database = factory.Create("Cooperativa")
    Public oTable As New DataTable
    Public dt As New DataTable
    Public oSql As System.Text.StringBuilder
    Public sSQL As System.Text.StringBuilder

End Module
