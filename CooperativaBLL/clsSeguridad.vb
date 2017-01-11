Public Class clsSeguridad
    Private db As New DataBase.DataBase.DataBase
    Dim xTable As DataTable

    Public ReadOnly Property Servidor As String
        Get
            Return db.Server.ToUpper
        End Get
    End Property

    Public ReadOnly Property Get_NumeroDeEmpleado(Usuario As String) As String
        Get
            Return db.ConsultarEscalar("Select Usuario from DbCooperativa.dbo.TblSecUsuarios where credencial = " & Send(Usuario))
        End Get
    End Property

End Class
