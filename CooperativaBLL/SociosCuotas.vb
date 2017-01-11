Public Class SociosCuotas
    Public Property NumeroDeEmpleado() As String = Nothing
    Public Property Fecha As Nullable(Of Date) = Nothing
    Public Property Retencion As String = Nothing
    Public Property FechaFinal As Nullable(Of Date) = Nothing
    Public Property Descripcion As String = Nothing
    Public Property Observaciones As String = Nothing
    Public Property Capital As Nullable(Of Decimal) = Nothing
    Public Property Intereses As Nullable(Of Decimal) = Nothing
    Public Property Valor As Nullable(Of Decimal) = Capital + Intereses
End Class
