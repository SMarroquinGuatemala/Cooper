Imports System.Data
Imports System.Reflection
Imports System.Data.SqlClient

Public Class ManagerBase
#Region "BuildCollection (DataTable) Method"
    Public Function BuildCollection(Of T)(typ As Type, dt As DataTable) As List(Of T)
        Dim ret As New List(Of T)()
        Dim entity As T
        Dim props As PropertyInfo() = typ.GetProperties()
        For Each dr As DataRow In dt.Rows
            ' Create new instance of Entity
            entity = Activator.CreateInstance(Of T)()
            ' Set all properties from the column names
            ' NOTE: This assumes your column names are the 
            '       same name as your class property names
            For Each col As PropertyInfo In props
                If dr(col.Name) Is DBNull.Value Then
                    col.SetValue(entity, Nothing, Nothing)
                Else
                    col.SetValue(entity, dr(col.Name), Nothing)
                End If
            Next

            ret.Add(entity)
        Next
        Return ret
    End Function
#End Region

#Region "BuildCollection (DataReader) Method"
    Public Function BuildCollection(Of T)(typ As Type, rdr As SqlDataReader) As List(Of T)
        Dim ret As New List(Of T)()
        Dim entity As T

        ' Get all the properties in Entity Class
        Dim props As PropertyInfo() = typ.GetProperties()

        While rdr.Read()
            ' Create new instance of Entity
            entity = Activator.CreateInstance(Of T)()

            ' Set all properties from the column names
            ' NOTE: This assumes your column names are the 
            '       same name as your class property names
            For Each col As PropertyInfo In props
                If rdr(col.Name).Equals(DBNull.Value) Then
                    col.SetValue(entity, Nothing, Nothing)
                Else
                    col.SetValue(entity, rdr(col.Name), Nothing)
                End If
            Next

            ret.Add(entity)
        End While

        Return ret
    End Function
#End Region

#Region "BuildCollection (DataReader) Method"
    Public Function BuildCollection(Of T)(typ As Type, rdr As DataRow) As List(Of T)
        Dim ret As New List(Of T)()
        Dim entity As T

        ' Get all the properties in Entity Class
        Dim props As PropertyInfo() = typ.GetProperties()
        Try

        
        If Not IsNothing(rdr) Then
            ' Create new instance of Entity
            entity = Activator.CreateInstance(Of T)()

            ' Set all properties from the column names
            ' NOTE: This assumes your column names are the 
            '       same name as your class property names
            For Each col As PropertyInfo In props
                If rdr(col.Name).Equals(DBNull.Value) Then
                    col.SetValue(entity, Nothing, Nothing)
                Else
                    col.SetValue(entity, rdr(col.Name), Nothing)
                End If
            Next

            ret.Add(entity)
        End If

            Return ret
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region


End Class
