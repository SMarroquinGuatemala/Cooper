Public Class DataConvert
    Public Shared Function ConvertTo(Of T As Structure)(value As Object, defaultvalue As Object) As T
        If value.Equals(DBNull.Value) Then
            Return DirectCast(defaultvalue, T)
        Else
            Return DirectCast(value, T)
        End If
    End Function
End Class
