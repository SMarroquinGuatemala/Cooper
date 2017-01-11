Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Configuration

 
Imports System.Net.Mail
Imports System.IO
Imports System.Net 
Imports System.Data.OleDb

Namespace DataBase
    Public Class DataBase

        Public Enum ObjectsDataBase
            DataBases
            Tables
            Columns
        End Enum

        Dim dbConnectionString As New ConnectionString(My.Settings(My.Settings.cnDefault).ToString)
        Dim connection As SqlConnection = New SqlConnection(dbConnectionString.ConnectionString)

        Private cnCurrent As New SqlConnection
        Public cnDefault As SqlConnection = New SqlConnection(dbConnectionString.ConnectionString)
        Public ReadOnly Property cnStrDefault As String
            Get
                Return cnDefault.ConnectionString.ToString
            End Get
        End Property

        Public ReadOnly Property Server As String
            Get
                Return connection.DataSource
            End Get
        End Property

        Public ReadOnly Property DataBase As String
            Get
                Return connection.Database
            End Get
        End Property

        Public Property ConnectionString As String
            Get
                Return dbConnectionString.ToString
            End Get
            Set(value As String)
                dbConnectionString = New ConnectionString(value)
            End Set
        End Property

        Public ReadOnly Property cnStrSanDiego As String
            Get
                Return My.Settings("cnSanDiego").ToString()
            End Get
        End Property

        Public ReadOnly Property cnStrTrinidad As String
            Get
                Return My.Settings("cnTrinidad").ToString()
            End Get
        End Property

        Public ReadOnly Property cnStrGuatemala As String
            Get
                Return My.Settings("cnGuatemala").ToString()
            End Get
        End Property

        Public Function CreateConnection() As SqlConnection
            Dim newConnection As SqlConnection = New SqlConnection
            newConnection.ConnectionString = ConnectionString
            Return newConnection
        End Function

        Friend Function GetNewOpenConnection() As SqlConnection
            Dim connection As SqlConnection = Nothing
            Try
                Try
                    connection = CreateConnection()
                    connection.Open()
                Catch e As Exception
                    Throw
                End Try
            Catch
                If connection IsNot Nothing Then
                    connection.Close()
                End If
                Throw
            End Try
            Return connection
        End Function

        Public Function GetStoredProcCommand(storedProcedureName As String) As SqlCommand
            If String.IsNullOrEmpty(storedProcedureName) Then
                Throw New ArgumentException(My.Resources.ExceptionNullOrEmptyString, "storedProcedureName")
            End If
            Return CreateCommandByCommandType(CommandType.StoredProcedure, storedProcedureName)
        End Function

        Public Function GetStoredProcCommand(storedProcedureName As String, ParamArray parameterValues As Object()) As SqlCommand
            If String.IsNullOrEmpty(storedProcedureName) Then
                Throw New ArgumentException(My.Resources.ExceptionNullOrEmptyString, "storedProcedureName")
            End If
            Dim command As SqlCommand = CreateCommandByCommandType(CommandType.StoredProcedure, storedProcedureName)
            AssignParameters(command, parameterValues)
            Return command
        End Function

        Public Sub AssignParameters(command As SqlCommand, parameterValues As Object())
            DiscoverParameters(command)
            If SameNumberOfParametersAndValues(command, parameterValues) = False Then
                Throw New InvalidOperationException(My.Resources.ExceptionMessageParameterMatchFailure)
            End If
            AssignParameterValues(command, parameterValues)
        End Sub

        Public Sub AddInParameter(command As SqlCommand, name As String, dbType As DbType)
            AddParameter(command, name, dbType, ParameterDirection.Input, [String].Empty, DataRowVersion.[Default], Nothing)
        End Sub

        Public Sub AddInParameter(command As SqlCommand, name As String, dbType As DbType, value As Object)
            AddParameter(command, name, dbType, ParameterDirection.Input, [String].Empty, DataRowVersion.[Default], value)
        End Sub

        Public Sub AddParameter(command As SqlCommand, name As String, dbType As DbType, direction As ParameterDirection, sourceColumn As String, sourceVersion As DataRowVersion, value As Object)
            AddParameter(command, name, dbType, 0, direction, False, 0, 0, sourceColumn, sourceVersion, value)
        End Sub

        Public Sub AddParameter(command As SqlCommand, name As String, dbType As DbType, size As Integer, direction As ParameterDirection, nullable As Boolean, precision As Byte, scale As Byte, sourceColumn As String, sourceVersion As DataRowVersion, value As Object)
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            Dim parameter As SqlParameter = CreateParameter(name, dbType, size, direction, nullable, precision, scale, sourceColumn, sourceVersion, value)
            command.Parameters.Add(parameter)
        End Sub

        Public Function CreateParameter(name As String, dbType As DbType, size As Integer, direction As ParameterDirection, nullable As Boolean, precision As Byte, scale As Byte, sourceColumn As String, sourceVersion As DataRowVersion, value As Object) As SqlParameter
            Dim param As SqlParameter = CreateParameter(name)
            ConfigureParameter(param, name, dbType, size, direction, nullable, precision, scale, sourceColumn, sourceVersion, value)
            Return param
        End Function

        Protected Sub ConfigureParameter(param As SqlParameter, name As String, dbType As DbType, size As Integer, direction As ParameterDirection, nullable As Boolean, precision As Byte, scale As Byte, sourceColumn As String, sourceVersion As DataRowVersion, value As Object)
            param.DbType = dbType
            param.Size = size
            param.Value = If(value <> Nothing, value, DBNull.Value)
            param.Direction = direction
            param.IsNullable = nullable
            param.SourceColumn = sourceColumn
            param.SourceVersion = sourceVersion
        End Sub

        Protected Function CreateParameter(name As String) As SqlParameter
            Dim param As SqlParameter = New SqlParameter
            param.ParameterName = BuildParameterName(name)
            Return param
        End Function

        Public Function GetSchema(ByVal Objects As ObjectsDataBase) As DataTable
            'Public Function GetSchema() As DataTable
            Try
                Using connection = GetNewOpenConnection()
                    Return connection.GetSchema(Objects.ToString)
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Function

        Protected Sub DeriveParameters(discoveryCommand As SqlCommand)
            'Using connection = GetNewOpenConnection()
            '   connection.GetSchema("Procedures")
            '   Dim procedureDataTable As DataTable = connection.GetSchema("Procedures")
            '   Dim procedureDataColumn As DataColumn = procedureDataTable.Columns("ROUTINE_NAME")
            discoveryCommand.Connection = GetNewOpenConnection()
            SqlCommandBuilder.DeriveParameters(discoveryCommand)
            'End Using
        End Sub

        Public Sub DiscoverParameters(command As SqlCommand)
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            Using discoveryCommand As SqlCommand = CreateCommandByCommandType(command.CommandType, command.CommandText)
                DeriveParameters(discoveryCommand)
                For Each parameter As SqlParameter In discoveryCommand.Parameters
                    Dim cloneParameter As SqlParameter = CType(CType(parameter, ICloneable).Clone(), SqlParameter)
                    command.Parameters.Add(cloneParameter)
                Next
            End Using
        End Sub

        Private Sub AssignParameterValues(command As SqlCommand, values As Object())
            Dim parameterIndexShift As Integer = 1
            Dim i As Integer = 0
            While i < values.Length
                Dim parameter As IDataParameter = command.Parameters(i + parameterIndexShift)
                SetParameterValue(command, parameter.ParameterName, values(i))
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
        End Sub

        Protected Function SameNumberOfParametersAndValues(command As SqlCommand, values As Object()) As Boolean
            Dim returnParameterCount As Integer = 1
            Dim numberOfParametersToStoredProcedure As Integer = command.Parameters.Count - returnParameterCount
            Dim numberOfValuesProvidedForStoredProcedure As Integer = values.Length
            Return numberOfParametersToStoredProcedure = numberOfValuesProvidedForStoredProcedure
        End Function

        Protected ReadOnly Property ParameterToken() As Char
            Get
                Return "@"c
            End Get
        End Property

        Public Function BuildParameterName(name As String) As String
            If name = Nothing Then
                Throw New ArgumentNullException("name")
            End If

            If name(0) <> ParameterToken Then
                Return name.Insert(0, New String(ParameterToken, 1))
            End If
            Return name
        End Function

        Public Sub SetParameterValue(command As SqlCommand, parameterName As String, value As Object)
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            If value IsNot Nothing Then
                If Not value.GetType Is GetType(Boolean) Then
                    command.Parameters(BuildParameterName(parameterName)).Value = If(value <> Nothing, value, DBNull.Value)
                Else
                    command.Parameters(BuildParameterName(parameterName)).Value = value
                End If
            Else
                command.Parameters(BuildParameterName(parameterName)).Value = If(value <> Nothing, value, DBNull.Value)
            End If
        End Sub

        Public Overridable Function GetParameterValue(command As SqlCommand, name As String) As Object
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            Return command.Parameters(BuildParameterName(name)).Value
        End Function

        Public Function GetSqlStringCommand(query As String) As SqlCommand
            If String.IsNullOrEmpty(query) Then
                Throw New ArgumentException(My.Resources.ExceptionNullOrEmptyString, "query")
            End If
            Return CreateCommandByCommandType(CommandType.Text, query)
        End Function

        Private Function CreateCommandByCommandType(commandType As CommandType, commandText As String) As SqlCommand
            Dim command As SqlCommand = New SqlCommand
            command.CommandType = commandType
            command.CommandText = commandText
            command.CommandTimeout = 180
            Return command
        End Function

        Public Function ExecuteNonQuery(command As SqlCommand) As Integer
            Using Connection = GetNewOpenConnection()
                PrepareCommand(command, Connection)
                Return DoExecuteNonQuery(command)
            End Using
        End Function

        Public Function ExecuteNonQuery(storedProcedureName As String, ParamArray parameterValues As Object()) As Integer
            Using command As SqlCommand = GetStoredProcCommand(storedProcedureName, parameterValues)
                Return ExecuteNonQuery(command)
            End Using
        End Function

        Public Function ExecuteNonQuery(commandType As CommandType, commandText As String) As Integer
            Using command As SqlCommand = CreateCommandByCommandType(commandType, commandText)
                Return ExecuteNonQuery(command)
            End Using
        End Function

        Protected Function DoExecuteNonQuery(command As SqlCommand) As Integer
            If command Is Nothing Then Throw New ArgumentNullException("command")
            Try
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected
            Catch e As Exception

                Throw
            End Try
        End Function

        Public Function ExecuteScalar(command As SqlCommand) As Object
            If command Is Nothing Then Throw New ArgumentNullException("command")
            Using connection = GetNewOpenConnection()
                PrepareCommand(command, connection)
                Return DoExecuteScalar(command)
            End Using
        End Function

        Public Function ExecuteScalar(storedProcedureName As String, ParamArray parameterValues As Object()) As Object
            Using command As SqlCommand = GetStoredProcCommand(storedProcedureName, parameterValues)
                Return ExecuteScalar(command)
            End Using
        End Function

        Public Function ExecuteScalar(commandType As CommandType, commandText As String) As Object
            Using command As SqlCommand = CreateCommandByCommandType(commandType, commandText)
                Return ExecuteScalar(command)
            End Using
        End Function

        Private Function DoExecuteScalar(command As SqlCommand) As Object
            Try
                Dim returnValue As Object = command.ExecuteScalar()
                Return returnValue
            Catch e As Exception
                Throw
            End Try
        End Function

        Protected Function GetDataAdapter() As SqlDataAdapter
            Dim adapter As SqlDataAdapter = New SqlDataAdapter
            Return adapter
        End Function

        Public Function ExecuteDataSet(command As SqlCommand) As DataSet
            Dim dataSet As New DataSet()
            dataSet.Locale = CultureInfo.InvariantCulture
            LoadDataSet(command, dataSet, "Table")
            Return dataSet
        End Function

        Public Function ExecuteDataSet(storedProcedureName As String, ParamArray parameterValues As Object()) As DataSet
            Using command As SqlCommand = GetStoredProcCommand(storedProcedureName, parameterValues)
                Return ExecuteDataSet(command)
            End Using
        End Function

        Public Function ExecuteDataSet(commandType As CommandType, commandText As String) As DataSet
            Using command As SqlCommand = CreateCommandByCommandType(commandType, commandText)
                Return ExecuteDataSet(command)
            End Using
        End Function

        Public Sub LoadDataSet(command As SqlCommand, dataSet As DataSet, tableNames As String())
            Using connection = GetNewOpenConnection()
                PrepareCommand(command, connection)
                DoLoadDataSet(command, dataSet, tableNames)
            End Using
        End Sub

        Public Sub LoadDataSet(command As SqlCommand, dataSet As DataSet, tableName As String)
            LoadDataSet(command, dataSet, {tableName})
        End Sub

        Public Sub LoadDataSet(storedProcedureName As String, dataSet As DataSet, tableNames As String(), ParamArray parameterValues As Object())
            Using command As SqlCommand = GetStoredProcCommand(storedProcedureName, parameterValues)
                LoadDataSet(command, dataSet, tableNames)
            End Using
        End Sub

        Public Sub LoadDataSet(commandType As CommandType, commandText As String, dataSet As DataSet, tableNames As String())
            Using command As SqlCommand = CreateCommandByCommandType(commandType, commandText)
                LoadDataSet(command, dataSet, tableNames)
            End Using
        End Sub

        Private Sub DoLoadDataSet(command As SqlCommand, dataSet As DataSet, tableNames As String())
            Dim i As Integer = 0
            If tableNames Is Nothing Then
                Throw New ArgumentNullException("tableNames")
            End If
            If tableNames.Length = 0 Then
                Throw New ArgumentException(My.Resources.ExceptionMessageParameterMatchFailure, "tableNames")
            End If

            While i < tableNames.Length
                If String.IsNullOrEmpty(tableNames(i)) Then
                    Throw New ArgumentException(My.Resources.ExceptionNullOrEmptyString, String.Concat("tableNames[", i, "]"))
                End If
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While

            Using adapter As SqlDataAdapter = GetDataAdapter()
                CType(adapter, SqlDataAdapter).SelectCommand = command
                Try

                    Dim systemCreatedTableNameRoot As String = "Table"
                    i = 0
                    While i < tableNames.Length
                        Dim systemCreatedTableName As String = If((i = 0), systemCreatedTableNameRoot, systemCreatedTableNameRoot + i)
                        adapter.TableMappings.Add(systemCreatedTableName, tableNames(i))
                        System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                    End While
                    adapter.Fill(dataSet)
                Catch e As Exception

                    Throw
                End Try
            End Using
        End Sub

        Public Function ConsultarImagen(ByVal sqlQuery As String, Optional ByVal cnString As String = "") As MemoryStream
            Try

                If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                If F_Null(cnString) Then cnCurrent.ConnectionString = cnDefault.ConnectionString Else cnCurrent.ConnectionString = cnString
                If Not F_Null(sqlQuery) Then
                    Dim SelectCommand = New SqlCommand(sqlQuery, cnCurrent)
                    cnCurrent.Open()

                    Dim MyPhoto() As Byte = CType(SelectCommand.ExecuteScalar(), Byte())
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                    If Not MyPhoto Is Nothing Then
                        Dim ms As New MemoryStream(MyPhoto)
                        Return ms
                    Else
                        Return Nothing
                    End If

                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function



        ''' <summary>
        ''' Devuelve un DataTable que representa el resultado del query enviado
        ''' </summary>
        ''' <param name="sqlQuery">Query a ejectuar</param>
        ''' <param name="cnString">Opcional si no se envia conexion agarra la default</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ConsultarTabla(ByVal sqlQuery As String, Optional ByVal cnString As String = "", Optional ByVal timeOut As Integer = 0) As DataTable
            Try
                If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                If F_Null(cnString) Then cnCurrent.ConnectionString = cnDefault.ConnectionString Else cnCurrent.ConnectionString = cnString
                If Not F_Null(sqlQuery) Then
                    Dim da As New SqlDataAdapter
                    Dim table As New DataTable
                    da.SelectCommand = New SqlCommand(sqlQuery, cnCurrent)
                    If timeOut <> 0 Then da.SelectCommand.CommandTimeout = timeOut
                    da.Fill(table)
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()

                    Return table
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function

        ''' <summary>
        ''' Devuelve un DataRow que contiene el primer Row que se obtenga del query enviado.
        ''' </summary>
        ''' <param name="sqlQuery">Query a ejectuar.</param>
        ''' <param name="cnString">Opcional si no se envia conexion agarra la default</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ConsultarFilaTabla(ByVal sqlQuery As String, Optional ByVal cnString As String = "") As DataRow
            Try
                Dim Table As DataTable = ConsultarTabla(sqlQuery, cnString)
                If Not (Table Is Nothing) Then
                    If Table.Rows.Count > 0 Then
                        Return Table.Rows(0)
                    End If
                End If
                Return Nothing
            Catch ex As Exception
                Throw
            End Try
        End Function




        ''' <summary>
        ''' Ejecuta un Up especifico. Nota: NO es necesario enviar el 'Exec'
        ''' </summary>
        ''' <param name="strUp">Up a ejecutar con sus parametros.</param>
        ''' <param name="cnString">Opcional si no se envia conexion agarra la default</param>
        ''' <param name="TimeOut">Tiempo antes de que lance la exception de tiempo de espera</param>
        ''' <remarks></remarks>
        Public Sub EjecutarUp(ByVal strUp As String, Optional ByVal cnString As String = "", Optional ByVal TimeOut As Integer = 590)
            Try
                If Not F_Null(strUp) Then
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                    If F_Null(cnString) Then cnCurrent.ConnectionString = cnDefault.ConnectionString Else cnCurrent.ConnectionString = cnString
                    Dim cmd As New SqlCommand
                    If cnCurrent.State = ConnectionState.Closed Then cnCurrent.Open()
                    cmd.Connection = cnCurrent
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Exec " & strUp
                    cmd.CommandTimeout = TimeOut
                    cmd.ExecuteNonQuery()
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                End If

            Catch ex As Exception
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Lee un escalar de un Up. Nota: no es necesario enviar en el query 'Exec'
        ''' </summary>
        ''' <param name="strUp">Up a ejecutar con sus parametros si los tubiere</param>
        ''' <param name="cnString">Opcional si no se envia conexion agarra la default</param>
        ''' <param name="TimeOut">Tiempo antes de que lance la exception de tiempo de espera</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function LeerUPEscalar(ByVal strUp As String, Optional ByVal cnString As String = "", Optional ByVal TimeOut As Integer = 190) As String
            Try
                If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                If F_Null(cnString) Then cnCurrent.ConnectionString = cnDefault.ConnectionString Else cnCurrent.ConnectionString = cnString
                If Not F_Null(strUp) Then
                    Dim cmd As New SqlCommand
                    If cnCurrent.State = ConnectionState.Closed Then cnCurrent.Open()
                    cmd.Connection = cnCurrent
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "Exec " & strUp
                    cmd.CommandTimeout = TimeOut
                    LeerUPEscalar = cmd.ExecuteScalar
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                    Return LeerUPEscalar
                End If
                Return Nothing
            Catch ex As Exception
                Throw
            End Try
        End Function

        ''' <summary>
        ''' Devuelve un escalar obtenido del query que se asigne.
        ''' </summary>
        ''' <param name="sqlQuery">Query para obtener el escalar.</param>
        ''' <param name="cnString">Opcional si no se envia conexion agarra la default</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ConsultarEscalar(ByVal sqlQuery As String, Optional ByVal cnString As String = "") As String
            ConsultarEscalar = ""
            Try
                If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                If F_Null(cnString) Then cnCurrent.ConnectionString = cnDefault.ConnectionString Else cnCurrent.ConnectionString = cnString
                If Not F_Null(sqlQuery) Then
                    Dim sqlCmd As New SqlCommand
                    sqlCmd.CommandText = sqlQuery
                    sqlCmd.CommandType = CommandType.Text
                    If cnCurrent.State = ConnectionState.Closed Then cnCurrent.Open()
                    sqlCmd.Connection = cnCurrent
                    ConsultarEscalar = Convert.ToString(sqlCmd.ExecuteScalar)
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                    Return ConsultarEscalar
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                Throw
            End Try
        End Function

        ''' <summary>
        ''' Ejecuta el query que se envie, en la conexion especificada.
        ''' </summary>
        ''' <param name="sqlQuery">Query a ejecutar</param>
        ''' <param name="cnString">Opcional si no se envia conexion agarra la default</param>
        ''' <remarks></remarks>
        Public Sub EjecutarQuery(ByVal sqlQuery As String, Optional ByVal cnString As String = "")
            Try
                If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                If F_Null(cnString) Then cnCurrent.ConnectionString = cnDefault.ConnectionString Else cnCurrent.ConnectionString = cnString
                If Not F_Null(sqlQuery) Then
                    Dim sqlCmd As New SqlCommand
                    sqlCmd.CommandText = sqlQuery
                    sqlCmd.CommandType = CommandType.Text
                    If cnCurrent.State = ConnectionState.Closed Then cnCurrent.Open()
                    sqlCmd.Connection = cnCurrent
                    sqlCmd.ExecuteNonQuery()
                    If cnCurrent.State = ConnectionState.Open Then cnCurrent.Close()
                End If
            Catch ex As Exception
                Throw
            End Try
        End Sub

        '''<summary>
        '''Verifica si el campo esta nulo
        '''</summary>
        Private Function F_Null(ByVal xstring As String) As Boolean
            F_Null = True
            If xstring Is Nothing Then
                F_Null = True
            ElseIf Len(LTrim(RTrim(xstring))) = 0 Or xstring = "__/__/____" Or xstring = "__-___.___" Or xstring = "__:__" Or xstring = "  /  /" Or Trim(xstring) = ":" Or Trim(xstring) = Trim("  /  /   :") Then
                F_Null = True
            Else
                F_Null = False
            End If
        End Function


        Public Function Parametro(ByVal Nombre As String, ByVal Valor As String) As SqlParameter
            Try
                If Mid(Nombre, 1, 1) <> "@" Then Nombre = "@" & Nombre
                Return New SqlParameter(Nombre, IIf(F_Null(Valor), DBNull.Value, Valor))
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Function ConsultarTablaSP(ByVal spName As String, ByVal Cn As String, ByVal ParamArray arrParam() As SqlParameter) As DataTable
            Try
                Dim dt As DataTable
                Using cnn As New SqlConnection(Cn)
                    cnn.Open()
                    Using cmd As New SqlCommand
                        cmd.Connection = cnn
                        cmd.CommandTimeout = 10000
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = spName
                        'Manejo de parametros
                        If arrParam IsNot Nothing Then
                            For Each param As SqlParameter In arrParam
                                cmd.Parameters.Add(param)
                            Next
                        End If
                        'Llenamos el DT
                        Using da As New SqlDataAdapter(cmd)
                            dt = New DataTable : da.Fill(dt)
                            ' If dt.Rows.Count <= 0 Then dt = Nothing
                        End Using
                    End Using
                End Using
                Return dt
            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Function ConsultarDataSetSP(ByVal spName As String, ByVal Cn As String, ByVal ParamArray arrParam() As SqlParameter) As DataSet
            Try
                Dim ds As DataSet
                Using cnn As New SqlConnection(Cn)
                    cnn.Open()
                    Using cmd As New SqlCommand
                        cmd.Connection = cnn
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = spName
                        cmd.CommandTimeout = 100000
                        'Manejo de parametros
                        If arrParam IsNot Nothing Then
                            For Each param As SqlParameter In arrParam
                                cmd.Parameters.Add(param)
                            Next
                        End If
                        'Llenamos el DT
                        Using da As New SqlDataAdapter(cmd)
                            ds = New DataSet : da.Fill(ds)
                            If ds.Tables.Count <= 0 Then ds = Nothing
                        End Using
                    End Using
                End Using
                Return ds
            Catch ex As Exception
                Throw
            End Try
        End Function


        Public Function ConsultarLineaSP(ByVal spName As String, ByVal Cn As String, ByVal ParamArray arrParam() As SqlParameter) As DataRow
            Try
                Dim dr As DataRow, dt As DataTable = (ConsultarTablaSP(spName, Cn, arrParam))
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then dr = dt.Rows(0) Else dr = Nothing
                Else
                    dr = Nothing
                End If
                Return dr
            Catch ex As Exception
                Throw
            End Try
        End Function

        ''' <summary>
        ''' devuelve la fecha del servidor en formato dd/MM/yyyy
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function F_DateServer() As Date
            F_DateServer = Nothing
            Dim Vresultado As String = Nothing
            Try
                Dim xSqlDefault As String = String.Empty
                xSqlDefault = "SELECT getdate()"
                Vresultado = ConsultarEscalar(xSqlDefault)
                Return CDate(Vresultado).ToString("dd/MM/yyyy")

            Catch ex As Exception
                Throw
            End Try
        End Function
        Public Function ConsultarEscalarSP(ByVal spName As String, ByVal Cn As String, ByVal ParamArray arrParam() As SqlParameter) As String
            Try
                Dim dr As DataRow, dt As DataTable = (ConsultarTablaSP(spName, Cn, arrParam))
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then dr = dt.Rows(0) Else dr = Nothing
                Else
                    dr = Nothing
                End If
                Return dr.Item(0).ToString
            Catch ex As Exception
                Throw
            End Try
        End Function

        Public Sub EjectuarSP(ByVal spName As String, ByVal Cn As String, ByVal ParamArray arrParam() As SqlParameter)
            Try
                Using cnn As New SqlConnection(Cn)
                    cnn.Open()
                    Using cmd As New SqlCommand
                        cmd.CommandTimeout = 10000
                        cmd.Connection = cnn
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = spName
                        'Manejo de parametros
                        If arrParam IsNot Nothing Then
                            For Each param As SqlParameter In arrParam
                                cmd.Parameters.Add(param)
                            Next
                        End If
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Sub
    End Class
End Namespace