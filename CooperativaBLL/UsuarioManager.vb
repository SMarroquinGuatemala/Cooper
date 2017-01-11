Public Class UsuarioManager
    Inherits ManagerBase

    Public Function GetUsuariosDataTable() As List(Of Usuario)
        Dim dt As New DataTable
        Dim ret As List(Of Usuario) = Nothing
        dt = CooperativaDB.ExecuteDataSet(CommandType.Text, "SELECT  Usuario,Nombre, Descripcion, Credencial FROM TblSecUsuarios").Tables(0)
        ret = MyBase.BuildCollection(Of Usuario)(GetType(Usuario), dt)
        Return ret
    End Function
End Class
