Imports System.ComponentModel

<DataObject>
Public Class NivelOrganizacionalClass
    Inherits NivelOrganizacionalEntity
    Public NivelesOrganicacionales As List(Of NivelOrganizacionalEntity)
    Private table As New DataTable

    Public Sub FillList()
        Try
        NivelesOrganicacionales = New List(Of NivelOrganizacionalEntity)
            table = SolidarismoDB.ExecuteDataSet("UpSNivelOrganizacional", NivelOrganizacional, Nombre).Tables(0)
        For Each row As DataRow In table.Rows
            NivelesOrganicacionales.Add(New NivelOrganizacionalEntity() With {.NivelOrganizacional = row("NivelOrganizacional").ToString,
                                                                              .Nombre = row("Nombre").ToString,
                                                                              .ValorBasePrestamo = row("ValorBasePrestamo").ToString,
                                                                              .Permanente = row("Permanente").ToString
                                                                             })
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub Save()
        Try
            SolidarismoDB.ExecuteNonQuery("UpINivelOrganizacional", Me.NivelOrganizacional, Me.Nombre, Me.ValorBasePrestamo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
