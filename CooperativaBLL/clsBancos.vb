Public Class clsBancos
    Private db As New DataBase.DataBase.DataBase

    Private NumeroDocumentoValue As Nullable(Of Integer) = Nothing
    Public Property NumeroDocumento() As Nullable(Of Integer)
        Get
            Return NumeroDocumentoValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            NumeroDocumentoValue = value
        End Set
    End Property

    Private NumeroDocumentoInicialValue As Nullable(Of Integer) = Nothing
    Public Property NumeroDocumentoInicial() As Nullable(Of Integer)
        Get
            Return NumeroDocumentoInicialValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            NumeroDocumentoInicialValue = value
        End Set
    End Property

    Private NumeroDocumentoFinalValue As Nullable(Of Integer) = Nothing
    Public Property NumeroDocumentoFinal() As Nullable(Of Integer)
        Get
            Return NumeroDocumentoFinalValue
        End Get
        Set(ByVal value As Nullable(Of Integer))
            NumeroDocumentoFinalValue = value
        End Set
    End Property



    Public Function ConsultarNumeroCheque(ByVal CuentaBancaria As String) As Integer

        Try
            If Not F_Null(CuentaBancaria) Then
                Return CInt(Me.db.ConsultarEscalar(("select  Dbcooperativa.dbo.FnGetBancoNumeroCheque (" & modFunciones.Send(CuentaBancaria, True) & ")+1"), ""))
            Else
                Return 0
            End If
        Catch exception1 As Exception
            Throw
        End Try
    End Function

    Public Function GetListChequesAutorizados(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal NumeroDocumentoInicial As String, ByVal NumeroDocumentoFinal As String) As DataTable
        Try
            Me.NumeroDocumentoInicial = Nothing
            Me.NumeroDocumentoFinal = Nothing
            If Not String.IsNullOrEmpty(NumeroDocumentoInicial) Then Me.NumeroDocumentoInicial = NumeroDocumentoInicial
            If Not String.IsNullOrEmpty(NumeroDocumentoFinal) Then Me.NumeroDocumentoFinal = NumeroDocumentoFinal
            Return SolidarismoDB.ExecuteDataSet("UpSChequesAutorizados", FechaInicial, FechaFinal, Me.NumeroDocumentoInicial, Me.NumeroDocumentoFinal).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GetParametrosNombreArchivo(ByVal FechaInicial As Date, ByVal FechaFinal As Date, ByVal NumeroDocumentoInicial As String, ByVal NumeroDocumentoFinal As String) As DataTable
        Try
            Me.NumeroDocumentoInicial = Nothing
            Me.NumeroDocumentoFinal = Nothing
            If Not String.IsNullOrEmpty(NumeroDocumentoInicial) Then Me.NumeroDocumentoInicial = NumeroDocumentoInicial
            If Not String.IsNullOrEmpty(NumeroDocumentoFinal) Then Me.NumeroDocumentoFinal = NumeroDocumentoFinal
            Return SolidarismoDB.ExecuteDataSet("UpSNombreArchivoChequesAutorizados", FechaInicial, FechaFinal, Me.NumeroDocumentoInicial, Me.NumeroDocumentoFinal).Tables(0)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ActualizaChequesBancos(ByVal CuentaBancaria As String, ByVal NumeroDeDocumentoInicial As Integer, NumeroDeDocumentoFinal As Integer)
        Try
            SolidarismoDB.ExecuteNonQuery("UpUChequeAutorizadoBancos", CuentaBancaria, NumeroDeDocumentoInicial, NumeroDeDocumentoInicial)
        Catch ex As Exception
            Throw
        End Try
    End Sub



End Class
