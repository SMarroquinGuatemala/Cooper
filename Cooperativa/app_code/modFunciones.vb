Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Net.Mail
Imports System.IO
Imports System.Net
Imports Library
Imports System.Data.OleDb
'''<summary>
'''Contiene funciones utiles para desarrollar
'''</summary>
Public Module modFunciones
    'Variables Globales-------------------------------------------------
    Public Empresa As String = String.Empty
    Public NombreEmpresa As String = String.Empty
    Public Corporacion As String = String.Empty
    Public IdUsuario As Integer = 0
    Public TipoUsuario As String = String.Empty
    Public Modulo As String = String.Empty
    Public GrupoUsuario As String = String.Empty
    Public Grupo As String = String.Empty
    Public NivelDeAcceso As String = String.Empty
    Public hstActual As String = String.Empty
    Public NumeroDeEmpleado As String = String.Empty
    Public NombreUsuario As String = String.Empty
    Public RowFound As DataRow
    Public Password As String = String.Empty
    Public Empresas As String = "'01','06','65','71','74'"
    Public xReport As New ReportDocument
    Public FechaOperacion As Date
    '*******************************************************************
    Public Const FileConfiguration As String = "\Configuracion.ini"


    Public xRowDefault As DataRow
    Public xTableDefault As New DataTable
    Public xSqlDefault As String = ""
    Public ReadOnly startup As String = Application.StartupPath
    Public Remotepath As String = "\\..\Sistema_SanDiego_Update\Cooperativa\"
    Public BD As String = String.Empty
    Public FileDialog As New OpenFileDialog
    Public SaveDialog As New SaveFileDialog
    Public Grabar As String = "Grabar", Modificar As String = "Modificar", Eliminar As String = "Eliminar"
    Public isVisualizaAllMovID As Boolean = False
    Public Const PrestacionesFactura = 0.263783
    Public Const CuentaDeInversion = "1202"
    Private clsSeguridad As New CooperativaBLL.clsSeguridad
    Dim Combos As New CooperativaBLL.clsCombos
    '''<summary>
    ''' Crea o Registra los ODBC en la computadora
    '''</summary>
    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal fRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer
     
    '''<summary>
    ''' Inicializa las variables globales del usuario 
    '''</summary>
    Public Sub LogIn()
        Try
            Usuario = UCase(SystemInformation.UserDomainName.ToString & "\" & SystemInformation.UserName)
            Computadora = UCase(SystemInformation.ComputerName.ToCharArray)
            Servidor = UCase(clsSeguridad.Servidor)
            AppName = Application.ProductName
            NumeroDeEmpleado = clsSeguridad.Get_NumeroDeEmpleado(Usuario)
            FechaOperacion = Date.Now.ToShortDateString
            '**********************************************
        Catch ex As Exception
            ShowMsgBox(ex.Message)
            ShowMsgBox(ex.InnerException.Message)
            Throw
        End Try
    End Sub


    Public Function AutoUpdate() As Boolean
        Dim Ip As String = String.Empty

        For i As Integer = 0 To Dns.GetHostEntry(Dns.GetHostName()).AddressList.Count - 1
            If InStr(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(i).ToString, ".") > 0 Then
                If Split(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(i).ToString, ".").Length > 3 Then
                    Ip = Split(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(i).ToString, ".")(2)
                End If
                Exit For
            End If
        Next
        If F_Null(Ip) Then Ip = "2"

        'Ip = Split(Dns.GetHostEntry(Dns.GetHostName()).AddressList.GetValue(1).ToString, ".")(2)
        If CInt(Ip) = 1 Then
            Remotepath = Replace(Remotepath, "..", "dhcsdgua1")
        ElseIf CInt(Ip) >= 24 And CInt(Ip) <= 32 Then
            Remotepath = Replace(Remotepath, "..", "NETTRFCA1")
        Else
            Remotepath = Replace(Remotepath, "..", "dhcsdfca1")
        End If
        Const Key As String = "&*Dave*#@!"
        If InStr(Microsoft.VisualBasic.Command(), Key) > 0 Then
            For Each dFile As String In Directory.GetFiles(startup, "*.old*", SearchOption.TopDirectoryOnly)
                Try
                    File.Delete(dFile)
                Catch ex As Exception
                    'F_Error(ex, , False)
                End Try
            Next
            Return False
        Else
            Try
                If CheckDirectory(Remotepath) Then
                    System.Diagnostics.Process.Start( _
                            Application.StartupPath & "\" & My.Application.Info.AssemblyName.ToArray, Key)
                    Return True
                End If
                Return False
            Catch ex As Exception
                MsgBox("Aviso no se pudo actualizar su aplicacion." & vbCr & _
                    "Por favor consulte a soporte." & vbCr & ex.Message, _
                    MsgBoxStyle.Critical)
                Return False
            End Try
        End If
    End Function




    Public Function CheckDirectory(ByVal Dir As String) As Boolean
        Try
            CheckDirectory = False
            Dim myWebClient As New System.Net.WebClient
            Dim LocalDirectory As String = Application.StartupPath & "\" & Replace(Dir, Remotepath, "")
            For Each sDirectory As String In Directory.GetDirectories(Dir, "*.*", SearchOption.TopDirectoryOnly)
                CheckDirectory(sDirectory)
            Next sDirectory

            For Each sFichero As String In Directory.GetFiles(Dir, "*.*", SearchOption.TopDirectoryOnly)
                Dim archivo As New FileInfo(sFichero)

                If File.Exists(LocalDirectory & "\" & archivo.Name.ToString) Then
                    Dim Archivolocal As New FileInfo(LocalDirectory & "\" & archivo.Name.ToString)

                    If archivo.LastWriteTime > Archivolocal.LastWriteTime Then
                        If Archivolocal.IsReadOnly Then Archivolocal.IsReadOnly = False
                        If UCase(archivo.Extension.ToString) = ".EXE" Then
                            File.Move(LocalDirectory & "\" & Archivolocal.Name.ToString, _
                                LocalDirectory & "\" & Now.TimeOfDay.TotalMilliseconds & ".old")
                        End If

                        If UCase(Right(archivo.Name.ToString, 2)) <> UCase("db") Then myWebClient.DownloadFile(Dir & "\" & archivo.Name.ToString, _
                                  LocalDirectory & "\" & archivo.Name.ToString)

                        CheckDirectory = True
                    End If
                Else
                    CheckDirectory = True
                    CrearDirectorio(LocalDirectory)
                    myWebClient.DownloadFile(Dir & "\" & archivo.Name.ToString, _
                    LocalDirectory & "\" & archivo.Name.ToString)
                End If
            Next
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Sub CrearDirectorio(ByVal El_Path As String)
        Try
            Dim Array_Dir As Object
            Dim Sub_Dir As String
            If El_Path = vbNullString Then Exit Sub

            Array_Dir = Split(El_Path, "\")
            El_Path = vbNullString

            For i As Integer = LBound(Array_Dir) To UBound(Array_Dir)
                Sub_Dir = Array_Dir(i)
                If Sub_Dir <> vbNullString Then
                    El_Path = El_Path & Sub_Dir & "\"
                    If (Sub_Dir.Substring(Sub_Dir.Length - 1, 1)) <> ":" Then
                        If Dir(El_Path, vbDirectory) = vbNullString Then Call MkDir(El_Path)
                    End If
                End If
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub


    '''<summary>
    ''' Crea un ODBC con los parametros que se le proporcionen.
    '''</summary>
    Public Function CrearODBC(ByVal NombreODBC As String, ByVal Server As String, ByVal Database As String, Optional ByVal Descripcion As String = "") As Boolean
        CrearODBC = True
        Try
            If Not F_Null(Server) And Not F_Null(Database) Then
                Dim Str As String = ""
                Str = "SERVER=" & Server & Chr(0)
                Str &= "DESCRIPTION=" & Descripcion & Chr(0)
                Str &= "DSN=" & NombreODBC & Chr(0) & "DATABASE=" & Database & Chr(0)
                Return SQLConfigDataSource(0, 1, "SQL Server", Str)
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function FechaDelDia() As String
        FechaDelDia = ""
        Try
            If Date.Now.Hour >= 0 And Date.Now.Hour < 6 Then
                Return DateAdd(DateInterval.Day, -1, Date.Now).ToString
            Else
                Return Date.Now.ToString
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Enum TiposDeAplicacion
        Undefined = 0
        Despacho = 1
        Ingreso = 2
        Devolucion = 3
        DesglocePesos = 4
        IngresoVarios = 5
        Madera = 6
        Cania = 7
    End Enum

    Public Enum TiposDeCampo
        Indefinido = 0
        Obligatorio = 1
        Opcional = 2
        Despliegue = 3
        Personalizado = 4
    End Enum

    Public Function GetVariableFromAppSettings(ByVal Variable As String) As String
        Try
            GetVariableFromAppSettings = ""
            If Variable <> "MovID" Then
                Return My.Settings(Variable).ToString
            Else
                Dim Directorio As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Configuracion.INI")
                If Not System.IO.File.Exists(Directorio) Then
                    If CInt(My.Settings(Variable).ToString) > 0 Then
                        Dim Archivo As New System.IO.StreamWriter(Directorio)
                        Archivo.WriteLine(Encriptar(My.Settings(Variable).ToString))
                        Archivo.Close()
                    End If
                Else
                    Dim sr As New System.IO.StreamReader(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Configuracion.INI"))
                    Dim str As String = sr.ReadToEnd()
                    sr.Close()
                    Return Desencriptar(str)
                End If
            End If
            Return 0
        Catch ex As Exception
            F_Error(ex, "traer variable de aplicacion")
        End Try
        GetVariableFromAppSettings = ""
    End Function

    'Public Sub SetVariableFromAppSettings(ByVal Variable As String, ByVal Valor As String)
    '   Try
    '      Presupuesto.My.Settings(Variable) = Valor
    '      My.Settings.Save()
    '   Catch ex As Exception
    '      F_Error(ex, "traer variable de aplicacion")
    '   End Try
    'End Sub
    'Public Sub SetVariableFromAppSettings(ByVal Variable As String, ByVal Valor As Integer)
    '   Try
    '      Presupuesto.My.Settings(Variable) = Valor
    '      My.Settings.Save()
    '   Catch ex As Exception
    '      F_Error(ex, "traer variable de aplicacion")
    '   End Try
    'End Sub

    Public Sub SetVariableFromAppSettings(ByVal MovId As String, Valor As String)
        Try
            Dim Directorio As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Configuracion.INI")
            If Not System.IO.File.Exists(Directorio) Then
                Dim Archivo As New System.IO.StreamWriter(Directorio)
                Archivo.WriteLine(Encriptar(Valor))
                Archivo.Close()
            Else
                If File.Exists(Directorio) Then System.IO.File.SetAttributes(Directorio, FileAttributes.Normal)
                Dim sw As New System.IO.StreamWriter(Directorio)
                sw.WriteLine(Encriptar(Valor))
                sw.Close()
            End If
        Catch ex As Exception
            F_Error(ex, "SetVariableFromAppSettings")
        End Try
    End Sub

    '''<summary>
    ''' Enumera los Sistemas disponibles
    '''</summary>
    Public Enum Sistemas As Integer
        ProductoTerminado = 1
        Materiales = 2
        Contabilidad = 3
        ContabilidadGT = 4
        RecursosHumanos = 5
        RelojAcceso = 6
        Bascula = 7
        ContabilidadTR = 8
        Maquinaria = 9
        Campo = 10
        Presupuesto = 11
        cnTrinidad = 12
        cnSanDiego = 13
        cnGuatemala = 14
    End Enum
    ''' <summary>
    ''' Modos de grabacion en filtros y tecleos
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ModosDeTecleo As Integer
        Grabar = 1
        Modificar = 2
        Consultar = 3
    End Enum
    '''<summary>
    ''' Convierte de una datatable a un string delimitado por separadores de filas y columnas "," y "|" por default
    '''</summary>
    Public Function CreateStringFromTable(ByVal Tabla As DataTable, Optional ByVal rSeparator As String = "|", Optional ByVal cSeparator As String = ",") As String
        Try
            Dim str As String = ""
            If Tabla.Rows.Count > 0 Then
                For i As Int16 = 0 To Tabla.Rows.Count - 1
                    For j As Int16 = 0 To Tabla.Columns.Count - 1
                        str &= Tabla.Rows(i).Item(j).ToString
                        If j <> Tabla.Columns.Count - 1 Then str &= cSeparator
                    Next
                    If i <> Tabla.Rows.Count - 1 Then str &= rSeparator
                Next
            End If
            Return str
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    ''' Convierte de una datarow a un string delimitado por separadores de filas y columnas "," y "|" por default
    '''</summary>
    '''<param name="ColumnStart">
    '''Parametro opcional por si se requiere empezar de una columna especifica del datarow</param>
    Public Function ConvertRowToString(ByVal Row As DataRow, Optional ByVal CSeparator As String = ",", Optional ByVal RSeparator As String = "|", Optional ByVal ColumnStart As Integer = 0, Optional ByVal CIncluye As Integer = -1) As String
        Try
            Dim str As String = ""
            If Row.ItemArray.Count > 0 Then
                If CIncluye > 0 Then str &= EraseSeparators(Trim(Row.Item(CIncluye).ToString), CSeparator, RSeparator) & CSeparator
                For i As Integer = ColumnStart To Row.ItemArray.Count - 1
                    str &= EraseSeparators((Row.Item(i).ToString), CSeparator, RSeparator)
                    If i <> Row.ItemArray.Count - 1 Then str &= CSeparator
                Next i
                str &= RSeparator
            End If
            Return Replace(Replace(str, " 00:00:00", ""), " 12:00:00 a.m.", "")
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    '''Borra los separadores 00:00:00 y 12:00:00 a.m. ademas de los que se envian
    '''</summary>
    Public Function EraseSeparators(ByVal columnString As String, ByVal CSeparator As String, ByVal RSeparator As String) As String
        Try
            Dim Str As String = columnString
            Str = Replace(Str, CSeparator, "")
            Str = Replace(Str, RSeparator, "")
            Str = Replace(Str, " 00:00:00", "")
            Str = Replace(Str, " 12:00:00 a.m.", "")
            Return Trim(Str)
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    '''Captura el error y guarda el Trace en el Errorlog.txt
    '''</summary>
    Public Function F_Error(ByVal ex As Exception, Optional ByVal strSubOrMessage As String = "") As String
        Try
            Dim usuario As String = String.Empty
            Dim NombreMaq As String = String.Empty
            FileClose(1)
            FileOpen(1, Application.StartupPath & "\ErrorLog.txt", OpenMode.Append)
            usuario = Environment.UserName
            NombreMaq = Environment.MachineName
            Print(1, Now & "," & usuario & ", " & NombreMaq & " ,Problema: " & ex.StackTrace & " Programador: " & strSubOrMessage & Environment.NewLine & Environment.NewLine)
            FileClose(1)
            MsgBox("Se encontro un problema, favor reportar a TI. ( TI: " & ex.Message & ".- " & strSubOrMessage & " )", MsgBoxStyle.OkOnly, "Mensaje de Sistema")
            Cursor.Current = Cursors.Default
            Return ex.Message
        Catch exep As Exception
            F_Error = exep.Message
        End Try
    End Function

    '''<summary>
    '''Verifica si el campo esta nulo
    '''</summary>
    Public Function F_Null(ByVal xstring As String) As Boolean
        F_Null = True
        If xstring Is Nothing Then
            F_Null = True
        ElseIf Len(LTrim(RTrim(xstring))) = 0 Or xstring = "__/__/____" Or xstring = "__-___.___" Or xstring = "__:__" Or xstring = "  /  /" Or Trim(xstring) = ":" Or Trim(xstring) = Trim("  /  /   :") Then
            F_Null = True
        Else
            F_Null = False
        End If
    End Function
    Public Function F_Null(ByVal Row As DataRow) As Boolean
        If Row Is Nothing Then Return True Else Return False
    End Function
    Public Function F_Null(ByVal Table As DataTable) As Boolean
        If Table Is Nothing Then Return True Else Return False
    End Function
    Public Function F_Null(ByVal xobject As Object) As Boolean
        F_Null = True
        If xobject Is Nothing Then
            F_Null = True
        ElseIf Len(LTrim(RTrim(xobject))) = 0 Or xobject = "__/__/____" Or xobject = "__-___.___" Or xobject = "__:__" Or xobject = "  /  /" Or Trim(xobject) = ":" Or Trim(xobject) = Trim("  /  /   :") Then
            F_Null = True
        Else
            F_Null = False
        End If
    End Function
    '''<summary>
    '''Envia el string de la forma 'MiString'
    '''</summary>
    Public Function SendWhereNull(ByVal xCampo As String, ByVal xValor As String) As String
        If F_Null(xValor) Then
            Return " and " & xCampo & " is null"
        Else
            Return " and " & xCampo & "=" & Send(xValor)
        End If
    End Function
    '''<summary>
    '''Envia el string de la forma 'MiString'
    '''</summary>
    Public Function Send(ByVal xstring As String, Optional ByVal xNull As Boolean = True) As String
        If F_Null(xstring) Then
            If xNull Then Send = "Null" Else Send = " '' "
        Else
            Send = "'" & Trim(xstring).Replace("'", "''") & "'"
        End If
    End Function
    Public Function Send(ByVal txt As TextBoxSD, Optional ByVal xNull As Boolean = True) As String
        If txt.isNull Then
            If xNull Then Send = "Null" Else Send = " '' "
        Else
            Send = "'" & Trim(txt.Text).Replace("'", "''") & "'"
        End If
    End Function
    Public Function Send(ByVal cbo As ComboBoxSD, Optional ByVal xNull As Boolean = True) As String
        If cbo.isNull Then
            If xNull Then Send = "Null" Else Send = " '' "
        Else
            Send = "'" & Trim(cbo.Codigo).Replace("'", "''") & "'"
        End If
    End Function
    Public Function Send(ByVal msk As MaskedTextBoxSD, Optional ByVal xNull As Boolean = True) As String
        If msk.isNull Then
            If xNull Then Send = "Null" Else Send = " '' "
        Else
            Send = "'" & Trim(msk.Text).Replace("'", "''") & "'"
        End If
    End Function
    Public Function Send(ByVal lbl As Label, Optional ByVal xNull As Boolean = True) As String
        If F_Null(lbl.Text) Then
            If xNull Then Send = "Null" Else Send = " '' "
        Else
            Send = "'" & Trim(lbl.Text).Replace("'", "''") & "'"
        End If
    End Function

    Public Function fnSinComillas(ByVal xstring As String) As String
        Dim I As Integer
        Dim x As String
        fnSinComillas = ""
        For I = 1 To Len(xstring)
            x = xstring.Substring(I, 1)
            If x <> "'" Then
                fnSinComillas = fnSinComillas & x
            Else
                fnSinComillas = fnSinComillas & " "
            End If
        Next I
        Exit Function
    End Function
    '''<summary>
    '''Envia el string de la forma "'MiString'," (agrega una coma al final)
    '''</summary>
    Public Function SendWithComa(ByVal xstring As String, Optional ByVal xNull As Boolean = True) As String
        If F_Null(xstring) Then
            If xNull Then SendWithComa = "Null," Else SendWithComa = " '', "
        Else
            SendWithComa = "'" & Trim(xstring) & "',"
        End If
    End Function
    Public Function SendWithComa(ByVal txt As TextBoxSD, Optional ByVal xNull As Boolean = True) As String
        If txt.isNull Then
            If xNull Then SendWithComa = "Null," Else SendWithComa = " '', "
        Else
            SendWithComa = "'" & Trim(txt.Text) & "',"
        End If
    End Function
    Public Function SendWithComa(ByVal cbo As ComboBoxSD, Optional ByVal xNull As Boolean = True) As String
        If cbo.isNull Then
            If xNull Then SendWithComa = "Null," Else SendWithComa = " '', "
        Else
            SendWithComa = "'" & Trim(cbo.Codigo) & "',"
        End If
    End Function
    Public Function SendWithComa(ByVal msk As MaskedTextBoxSD, Optional ByVal xNull As Boolean = True) As String
        If msk.isNull Then
            If xNull Then SendWithComa = "Null," Else SendWithComa = " '', "
        Else
            SendWithComa = "'" & Trim(msk.Text) & "',"
        End If
    End Function
    Public Function SendWithComa(ByVal lbl As Label, Optional ByVal xNull As Boolean = True) As String
        If F_Null(lbl.Text) Then
            If xNull Then SendWithComa = "Null," Else SendWithComa = " '', "
        Else
            SendWithComa = "'" & Trim(lbl.Text) & "',"
        End If
    End Function
    '''<summary>
    '''Trae el Nombre del Archivo de una direccion con o sin extencion
    '''</summary>
    Public Function Get_Archivo(ByVal xstring As String, Optional ByVal Separator As String = "\", Optional ByVal WithoutExtension As Boolean = False) As String
        Get_Archivo = xstring
        Try
            If Not F_Null(xstring) Then
                Dim Posicion
                Dim xLen
                Posicion = InStr(xstring, Separator)
                While Posicion > 0
                    xLen = Len(xstring)
                    xstring = Right(xstring, xLen - Posicion)
                    Posicion = InStr(xstring, "\")
                End While
                Get_Archivo = xstring
                If WithoutExtension Then
                    Dim ch As String = Right(xstring, 1)
                    While Left(ch, 1) <> "."
                        ch = Right(xstring, Len(ch) + 1)
                    End While
                    Return xstring.Substring(0, Len(xstring) - Len(ch))
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    '''Convierte de Boolean a Integer
    '''</summary>
    Public Function F_BoolInt(ByVal xval As Boolean) As Integer
        If xval = False Then
            F_BoolInt = 0
        Else
            F_BoolInt = 1
        End If
    End Function

    '''<summary>
    '''Convierte de Integer a Boolean
    '''</summary>
    Public Function F_IntBool(ByVal xval As Integer) As Boolean
        If xval = 0 Then
            F_IntBool = False
        Else
            F_IntBool = True
        End If
    End Function

    '''<summary>
    '''Agrega lo ceros que se indiquen al principio.
    '''</summary>
    Public Function F_Ceros(ByVal PNumero As String, ByVal NumCeros As Integer) As String
        F_Ceros = RTrim(LTrim(CStr(PNumero)))
        For ceros As Integer = 1 To NumCeros - Len(PNumero)
            F_Ceros = "0" & F_Ceros
        Next
    End Function

    '''<summary>
    '''Devuelve el primer dia del mes de la fecha que se indique
    '''</summary>
    Public Function F_PrimerDia(ByVal xdate As String) As String
        F_PrimerDia = ""
        Try
            Dim yDate
            If F_Null(xdate) Then
                yDate = Date.Today
            Else
                yDate = CDate(xdate)
            End If
            Return "01/" & F_Ceros(Month(yDate), 2) & "/" & Year(yDate)
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    '''Devuelve el ultimo dia del mes de la fecha que se indique
    '''</summary>
    Public Function F_UltimoDia(ByVal xdate As Date) As String
        F_UltimoDia = ""
        Try
            Dim yDate As Date
            If F_Null(xdate.ToString()) Then
                yDate = Date.Today.ToString("dd/MM/yyyy")
            Else
                yDate = CDate(xdate).ToString("dd/MM/yyyy")
            End If
            If Month(yDate) < 12 Then
                F_UltimoDia = (CDate("01/" & F_Ceros(yDate.Month + 1, 2) & "/" & Year(yDate)))
                F_UltimoDia = DateAdd(DateInterval.Day, -1, CDate(F_UltimoDia)).ToString("dd/MM/yyyy")
            Else
                F_UltimoDia = "31/12/" & Year(yDate)
            End If
            Return F_UltimoDia
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    '''Devuelve el primer dia de la semana de la fecha que se indique
    '''</summary>
    Public Function F_PrimerDiaSemana(ByVal xdate As String) As String
        F_PrimerDiaSemana = ""
        Try
            Dim diaHoy As Date
            Dim dia As Integer
            Dim PrimerDiaSemana As Date
            If F_Null(xdate) Then diaHoy = Date.Today.ToString("dd/MM/yyyy") Else diaHoy = xdate
            dia = ((Weekday(diaHoy, vbMonday)) * -1) + 1
            PrimerDiaSemana = DateAdd(DateInterval.Day, dia, diaHoy)
            Return PrimerDiaSemana
        Catch ex As Exception
            Throw
        End Try
    End Function

    '''<summary>
    '''Devuelve el ultimo dia de la semana de la fecha que se indique
    '''</summary>
    Public Function F_UltimoDiaSemana(ByVal xdate) As String
        F_UltimoDiaSemana = ""
        Try
            Dim diaHoy As Date
            Dim dia As Integer
            Dim PrimerDiaSemana As Date
            Dim UltimoDiaSemana As Date
            If F_Null(xdate) Then diaHoy = Date.Today.ToString("dd/MM/yyyy") Else diaHoy = xdate
            dia = ((Weekday(diaHoy, vbMonday)) * -1) + 1
            PrimerDiaSemana = DateAdd(DateInterval.Day, dia, diaHoy)
            UltimoDiaSemana = DateAdd(DateInterval.Day, 6, PrimerDiaSemana)
            Return UltimoDiaSemana
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Extrae una linea de un string dado
    ''' </summary>
    ''' <param name="Cadena">Cadena de texto</param>
    ''' <param name="Separator">Separador de columnas y/o Filas</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExtraerLinea(ByRef Cadena As String, Optional ByVal Separator As String = ",") As String
        ExtraerLinea = ""
        Try
            Dim Linea As String = ""
            Linea = Trim(GetLineFromString(Cadena, Separator))
            If Len(Linea) <> Len(Cadena) Then
                Cadena = Cadena.Substring((Len(Linea) + 1))
            Else
                Cadena = ""
            End If
            Return Linea
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Crea un string HTML de una tabla desde un data set
    ''' </summary>
    ''' <param name="xDataSet"></param>
    ''' <param name="xTabla"> Nombre de la tabla</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Crear_Tabla(ByVal xDataSet As DataSet, ByVal xTabla As String) As String
        Crear_Tabla = ""
        Dim i, x As Integer
        Crear_Tabla = ("<table align=""center"" border=""1"">")
        '==================================\	
        '           COLUMNS                 |
        '----------------------------------/
        Crear_Tabla = Crear_Tabla & ("<tr>" & vbCrLf)
        For i = 0 To (xDataSet.Tables(xTabla).Columns.Count - 1)
            Crear_Tabla = Crear_Tabla & ("<td class='tdHeader' ><b>" & "<center><font size='1' face='Verdana, Arial, Helvetica, sans-serif'> " _
                          & xDataSet.Tables(xTabla).Columns(i).Caption & "</font></center></b></td>" & vbCrLf)
        Next
        Crear_Tabla = Crear_Tabla & ("</tr>" & vbCrLf)
        '==================================\	
        '           DATA ROWS               |
        '----------------------------------/
        Dim xtdFooter As String = ""
        For i = 0 To (xDataSet.Tables(xTabla).Rows.Count - 1)
            If xtdFooter = "tdFooter" Then
                xtdFooter = "tdFooter2"
            Else
                xtdFooter = "tdFooter"
            End If
            Crear_Tabla = Crear_Tabla & ("<tr" & ">" & vbCrLf)
            For x = 0 To (xDataSet.Tables(xTabla).Columns.Count - 1)
                Crear_Tabla = Crear_Tabla & ("<td class='" & xtdFooter & "'  valign=""top"">" & "<font size='1' face='Verdana, Arial, Helvetica, sans-serif'> ")
                Crear_Tabla = Crear_Tabla & xDataSet.Tables(xTabla).Rows(i).Item(x).ToString
                Crear_Tabla = Crear_Tabla & ("</font></td>" & vbCrLf)
            Next
            Crear_Tabla = Crear_Tabla & ("</tr>" & vbCrLf)
        Next
        Crear_Tabla = Crear_Tabla & ("</table>")
    End Function

    ''' <summary>
    ''' Valida si el campo esta nulo y muestra un mensaje en caso de ser cierto.
    ''' </summary>
    ''' <param name="xCampo">Campo a validar</param>
    ''' <param name="Mensage">Label en donde se quiere mostrar el mensaje</param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function Valid_CampoObligatorio(ByVal xCampo As String, ByVal VarName As String, Optional ByVal Mensage As Label = Nothing) As Boolean
        Try
            Valid_CampoObligatorio = True
            If F_Null(xCampo) Then
                If Not Mensage Is Nothing Then
                    Mensage.Text = "El Campo " & VarName & " es requerido para este proceso"
                Else
                    ShowMsgBox("El Campo  " & VarName & "  es requerido para este proceso")
                End If
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Valid_CampoObligatorio(ByVal xCampo As ComboBoxSD, Optional ByVal Mensage As Label = Nothing, Optional ByVal ValidWithTipo As Boolean = False) As Boolean
        Try
            Valid_CampoObligatorio = True
            If F_Null(xCampo.Text) Then
                If ValidWithTipo And xCampo.TipoDeCampo <> TiposDeCampo.Obligatorio Then Return True
                If Not Mensage Is Nothing Then
                    Mensage.Text = "El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso"
                Else
                    ShowMsgBox("El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso")
                End If
                xCampo.Focus()
                Valid_CampoObligatorio = False
                xCampo.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Valid_CampoObligatorio(ByVal xCampo As TextBoxSD, Optional ByVal Mensage As Label = Nothing, Optional ByVal ValidWithTipo As Boolean = False) As Boolean
        Try
            Valid_CampoObligatorio = True
            If F_Null(xCampo.Text) Then
                If ValidWithTipo And xCampo.TipoDeCampo <> TiposDeCampo.Obligatorio Then Return True
                If Not Mensage Is Nothing Then
                    Mensage.Text = "El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso"
                Else
                    ShowMsgBox("El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso")
                End If
                xCampo.Focus()
                Valid_CampoObligatorio = False
                xCampo.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Valid_CampoObligatorio(ByVal xCampo As TextBox, Optional ByVal Mensage As Label = Nothing, Optional ByVal ValidWithTipo As Boolean = False) As Boolean
        Try
            Valid_CampoObligatorio = True
            If F_Null(xCampo.Text) Then
                'If ValidWithTipo And xCampo.TipoDeCampo <> TiposDeCampo.Obligatorio Then Return True
                If Not Mensage Is Nothing Then
                    Mensage.Text = "El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso"
                Else
                    ShowMsgBox("El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso")
                End If
                xCampo.Focus()
                Valid_CampoObligatorio = False
                xCampo.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function Valid_CampoObligatorio(ByVal xCampo As MaskedTextBoxSD, Optional ByVal Mensage As Label = Nothing, Optional ByVal ValidWithTipo As Boolean = False) As Boolean
        Try
            Valid_CampoObligatorio = True
            If F_Null(xCampo.Text) Then
                If ValidWithTipo And xCampo.TipoDeCampo <> TiposDeCampo.Obligatorio Then Return True
                If Not Mensage Is Nothing Then
                    Mensage.Text = "El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso"
                Else
                    ShowMsgBox("El Campo " & Mid(xCampo.Name.ToString, 4, Len(xCampo.Name.ToString)) & " es requerido para este proceso")
                End If
                xCampo.Focus()
                Valid_CampoObligatorio = False
                xCampo.Focus()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function




    ''' <summary>
    ''' Obtiene el tipo de campo de un objeto
    ''' </summary>
    ''' <param name="txtCampo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Get_TipoCampo(ByVal txtCampo As Object) As TiposDeCampo
        If txtCampo.BackColor = Color.LightGreen Then
            Return TiposDeCampo.Despliegue
        ElseIf txtCampo.BackColor = Color.LightGray Then
            Return TiposDeCampo.Opcional
        ElseIf txtCampo.BackColor = Color.LemonChiffon Then
            Return TiposDeCampo.Obligatorio
        Else
            Return TiposDeCampo.Personalizado
        End If
    End Function

    ''' <summary>
    ''' Setea el tipo de campo a un objeto (color,readonly)
    ''' </summary>
    ''' <param name="txt"></param>
    ''' <param name="Tipo"></param>
    ''' <remarks></remarks>
    Public Sub Set_TipoCampo(ByVal txt As Object, Optional ByVal Tipo As TiposDeCampo = 1)
        Try
            If Tipo = TiposDeCampo.Obligatorio Then
                txt.ReadOnly = False
                txt.BackColor = Color.LemonChiffon
            ElseIf Tipo = TiposDeCampo.Despliegue Then
                txt.ReadOnly = True
                txt.BackColor = Color.LightGreen
            ElseIf Tipo = TiposDeCampo.Opcional Then
                txt.ReadOnly = False
                txt.BackColor = Color.LightGray
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Formatea un string dado en el formato especificado, sin especificar formato lo formatea de la forma 0.00
    ''' </summary>
    ''' <param name="yString">String a Formatear</param>
    ''' <param name="xInt">Cantidad de enteros </param>
    ''' <param name="xDec">cantidad de decimales</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function F_Format(ByVal yString As String, Optional ByVal xInt As Integer = 10, Optional ByVal xDec As Integer = 2) As String
        If Len(Trim(yString)) = 0 Then
            yString = 0
        End If
        Dim yInt As Integer
        Dim xFormat As String = ""
        Dim yDec As Integer
        For yDec = 1 To xDec
            If yDec = 1 Then
                xFormat = "." & xFormat
            End If
            xFormat = xFormat & "0"
        Next yDec
        For yInt = 1 To xInt - xDec
            If yInt <> 1 Then
                xFormat = "#" & xFormat
            Else
                xFormat = "0" & xFormat
            End If
            If yInt Mod 3 = 0 And yInt < xInt - xDec Then
                xFormat = "," & xFormat
            End If
        Next yInt
        F_Format = Format(Val(yString), xFormat)
    End Function

    ''' <summary>
    ''' Si el parametro por defecto es nulo devuelve el segundo parametro
    ''' </summary>
    ''' <param name="ParamDefecto">Parametro por defecto</param>
    ''' <param name="ParamOpcional">Parametro Opcional a devolver si el parametro por defecto esta nulo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function F_NVL(ByVal ParamDefecto As String, ByVal ParamOpcional As String) As String
        If IsDBNull(ParamDefecto) Or Trim(ParamDefecto) = "" Or Trim(ParamDefecto) = "__/__/____" Or Trim(ParamDefecto) = "__-___.___" Or Trim(ParamDefecto) = "__:__" Or Trim(ParamDefecto) = "Null" Or Trim(ParamDefecto) = Trim("  /  /") Then
            F_NVL = Trim(ParamOpcional)
        Else
            F_NVL = Trim(ParamDefecto)
        End If
    End Function

    ''' <summary>
    ''' Devuelve un parametro con el tipo de datos que se indique (usado en datasets)
    ''' </summary>
    ''' <param name="xString">Valor del parametro</param>
    ''' <param name="isShort">Si el dataset espera tipo short</param>
    ''' <param name="isDate">Si el dataset espera tipo Date</param>
    ''' <param name="isDecimal">Si el dataset espera tipo Decimal</param>
    ''' <param name="isInteger">Si el dataset espera tipo Integer</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Send2(ByVal xString As String, Optional ByVal isShort As Boolean = False, Optional ByVal isDate As Boolean = False, Optional ByVal isDecimal As Boolean = False, Optional ByVal isInteger As Boolean = False)
        If xString = "" Then
            Return Nothing
        ElseIf xString = "&nbsp;" Then
            Return Nothing
        ElseIf isShort Then
            Dim sx As Short
            sx = xString
            Return sx
        ElseIf isDate Then
            Dim xFecha As Date
            xFecha = xString
            Return xFecha
        ElseIf isDecimal Then
            Dim xDecimal As Decimal
            xDecimal = xString
            Return xDecimal
        ElseIf isInteger Then
            Dim xInteger As Integer
            xInteger = xString
            Return xInteger
        Else
            Return xString
        End If
    End Function

    ''' <summary>
    ''' Trae el codigo de un stringo con el formato codigo-descripcion
    ''' </summary>
    ''' <param name="xString"></param>
    ''' <param name="Separator">Separador que indica el fin del codigo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Get_Codigo(ByVal xString As String, Optional ByVal Separator As String = "-") As String
        Dim Posicion As Integer
        Posicion = InStr(xString, Separator)
        If Posicion = 0 Then
            Get_Codigo = RTrim(xString)
        Else
            Get_Codigo = Left(xString, Posicion - 1)
        End If
    End Function

    ''' <summary>
    ''' Trae la descripcion del formato  codigo-Descripcion
    ''' </summary>
    ''' <param name="xString"></param>
    ''' <param name="Separator">Separador que indica el fin del codigo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Get_Descripcion(ByVal xString As String, Optional ByVal Separator As String = "-") As String
        Dim Posicion As Integer
        Dim xLen As Integer
        xString = Trim(xString)
        Posicion = InStr(xString, Separator)
        If Posicion = 0 Then
            Get_Descripcion = xString
        Else
            xLen = Len(xString)
            Get_Descripcion = Right(xString, xLen - Posicion)
        End If
    End Function

    ''' <summary>
    ''' Devuelve el formato específico sin comas
    ''' </summary>
    ''' <param name="zString">Valor a convertir</param> 
    ''' <param name="xNull">Si se desea que devuelva "" si el valor esta en blanco</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function F_UnFormat(ByVal zString As String, Optional ByVal xNull As Boolean = False) As String
        If F_Null(zString) And Not xNull Then
            Return 0
        ElseIf F_Null(zString) And xNull Then
            Return "Null"
        Else
            Return Format(zString, "Fixed")
        End If
    End Function

    ''' <summary>
    ''' Crea un archivo de texto desde una tabla
    ''' </summary>
    ''' <param name="Table">Tabla a convertir en txt</param>
    ''' <param name="FileName">Nombre del Archivo</param>
    ''' <param name="Path">Donde se guardara el archivo </param>
    ''' <param name="Separator">Separador que marca el fin de campo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreateFileFromTable(ByVal Table As DataTable, ByVal FileName As String, ByVal Path As String, Optional ByVal Separator As String = ",") As String
        Try
            Dim fila As String
            FileClose(1)
            FileOpen(1, Path & "\" & FileName, OpenMode.Append)
            If Table.Rows.Count > 0 Then
                For i As Integer = 0 To Table.Rows.Count - 1
                    fila = ""
                    For j As Integer = 0 To Table.Columns.Count - 1
                        fila &= Table.Rows(i).Item(j).ToString & Separator
                    Next j
                    Print(1, fila & Environment.NewLine)
                Next i
            End If
            FileClose(1)
            Return "Archivo generado exitosamente..."
        Catch ex As Exception
            CreateFileFromTable = "Oucurrio un error en la generacion del archivo"
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae la primera linea de un string dado hasta el separador.
    ''' </summary>
    ''' <param name="cadena">String de donde se extraera la linea</param>
    ''' <param name="Separator">Separador que marca el fin de linea</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLineFromString(ByVal cadena As String, Optional ByVal Separator As String = ",") As String
        Dim top As Integer = InStr(cadena, Separator) - 1
        Dim line As String = ""
        If top > 0 Then
            line = cadena.Substring(0, top)
        ElseIf top < 0 Then
            line = cadena
        Else
            line = ""
        End If
        Return line
    End Function

    Public Function getNextFieldFromString(ByVal cadena As String, Optional ByVal Separator As String = ",") As String
        Dim pos As Integer
        pos = InStr(cadena, Separator, CompareMethod.Text)
        If Not F_Null(cadena) Then
            If pos >= 0 Then
                Return Mid(cadena, pos + 1)
            Else
                Return cadena
            End If
        Else
            Return ""
        End If
    End Function

    Public Function GetCount(ByVal Cadena As String, Optional ByVal Separator As String = ",") As Int16
        Dim pos As Int16 = Len(Cadena)
        Dim cont As Int16 = 0
        Dim substr As String = ""
        For i As Int16 = 1 To pos
            substr = Mid(Cadena, i, 1)
            If substr = Separator Then cont = cont + 1
        Next
        Return cont
    End Function

    Public Function Conexion(ByVal Cn As String) As String
        If Not F_Null(Cn) Then
            Return GetVariableFromAppSettings(Cn) 'Return ConfigurationManager.ConnectionStrings(Cn).ConnectionString.ToString
        Else
            Return GetVariableFromAppSettings("cnDesarrollo") ' ConfigurationManager.ConnectionStrings("cnDesarrollo").ConnectionString.ToString
        End If
    End Function

    Public Function GetStringFromTxt() As String
        Dim Variables As String = ""
        Dim path As String = ""
        path = (My.Computer.FileSystem.CurrentDirectory)
        Dim Archivo As New System.IO.StreamReader(path & FileConfiguration)
        Variables = Archivo.ReadToEnd
        Archivo.Close()
        Return Variables
    End Function

    ''' <summary>
    ''' Trae el valor de una variable del Configuracion.Ini
    ''' </summary>
    ''' <param name="variable">Variable a Buscar</param>
    ''' <param name="EndOfValue">Simbolo que representa el final del valor</param>
    ''' <param name="VarDelimiter">Delimitador de la variable a buscar de la forma *MiVariable*</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVariableFromIni(ByVal variable As String, Optional ByVal EndOfValue As String = "|", Optional ByVal VarDelimiter As String = "*") As String
        GetVariableFromIni = ""
        Try
            Return GetVariableFromString(GetStringFromTxt(), variable, EndOfValue, VarDelimiter)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae una variable de un string.
    ''' </summary>
    ''' <param name="Variables">String que contiene las variables</param>
    ''' <param name="variable">Variable a Buscar</param>
    ''' <param name="EndOfValue">Simbolo que representa el final del valor</param>
    ''' <param name="VarDelimiter">Delimitador de la variable a buscar de la forma *MiVariable*</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetVariableFromString(ByVal Variables As String, ByVal variable As String, Optional ByVal EndOfValue As String = "|", Optional ByVal VarDelimiter As String = "*") As String
        GetVariableFromString = ""
        Try
            variable = VarDelimiter & variable & VarDelimiter
            Dim pos As Integer = InStr(Variables, variable, CompareMethod.Text)
            Dim Valor As String = ""
            If pos > 0 Then
                Valor = Variables.Substring(pos - 1)
                pos = InStr(Valor, "=", CompareMethod.Text)
                Valor = Trim(Valor.Substring(pos, Len(Valor.Substring(pos, InStr(Valor.Substring(pos), EndOfValue))) - 1))
                Return Valor
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Actualiza una varable del Ini.
    ''' </summary>
    ''' <param name="varName">Variable a actualizar</param>
    ''' <param name="varValue">Nuevo valor de la variable</param>
    ''' <remarks></remarks>
    Public Sub UpdateVariableIni(ByVal varName As String, ByVal varValue As String)
        Dim variables As String = GetStringFromTxt()
        Dim path As String = "" : Dim oldValue As String = Trim(GetVariableFromIni(varName))
        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase.ToString)
        Dim Archivo As New System.IO.StreamWriter(path & FileConfiguration)
        variables = Replace(variables, Trim(varName) & "=" & Trim(oldValue), Trim(varName) & "=" & Trim(varValue))
        Archivo.Write(Replace(variables, " ", ""))
        Archivo.Close()
    End Sub

    ''' <summary>
    ''' Muestra un MessageBox con el titulo Mensaje de sistema.
    ''' </summary>
    ''' <param name="Mensaje">Mensaje para mostrar</param>
    ''' <param name="Style">Estilo del mensaje</param>
    ''' <remarks></remarks>
    Public Sub ShowMsgBox(ByVal Mensaje As String, Optional ByVal Style As MsgBoxStyle = MsgBoxStyle.Exclamation)
        MsgBox(Mensaje, Style, "Mensaje De Sistema")
    End Sub

    ''' <summary>
    ''' Envia un Tab si se presiona Enter
    ''' </summary>
    ''' <param name="xKeyAscii">Tecla presionada</param>
    ''' <remarks></remarks>
    Public Sub KeyTab(ByVal xKeyAscii As Integer)
        On Error Resume Next
        If xKeyAscii = 39 Then
            SendKeys.Send("{BACKSPACE}")
        End If
        If xKeyAscii = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub KeyTab(ByVal form As Form, ByVal KeyCode As Integer, ByVal Control As Control)
        Try
            If ((KeyCode = 13) Or (KeyCode = 9)) Then
                form.ActiveControl = Control
            End If
        Catch exception1 As Exception
            Throw
        End Try
    End Sub



    ''' <summary>
    ''' Devuelve una conection string segun los parametros que se indiquen
    ''' </summary>
    ''' <param name="Sistema">La conexion de que sistema se desea obtener</param>
    ''' <param name="Sitio">Si se desea un sitio en especifico si no hagarra el default 'cnSanDiego'</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Set_Conexion(ByVal Sistema As Sistemas, Optional ByVal Sitio As String = "") As String
        Dim Site As String = ""
        If Not UCase(Servidor) = "TFSSDFCA2" AndAlso TipoUsuario = "Des@rrollo" Then
            Site = "cnSanDiego"
        ElseIf Not UCase(Servidor) = "TFSSDFCA2" AndAlso TipoUsuario <> "Des@rrollo" Then
            Site = "cnSanDiego"
        Else
            Site = "cnDesarrollo"
        End If
        If Sistema = Sistemas.cnGuatemala Then Sitio = "cnGuatemala"
        If Sistema = Sistemas.cnSanDiego Then Sitio = "cnSanDiego"
        If Sistema = Sistemas.cnTrinidad Then Sitio = "cnTrinidad"
        If Not F_Null(Sitio) Then Site = Sitio

        Return Conexion(Site)
    End Function

    ''' <summary>
    ''' Valida Fecha Mayor de dos fechas
    ''' </summary>
    ''' <param name="FechaInicial"></param>
    ''' <param name="FechaFinal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidaFechaMayor(ByVal FechaInicial As String, ByVal FechaFinal As String) As Boolean
        ValidaFechaMayor = True
        Try
            If Not F_Null(FechaInicial) And Not F_Null(FechaFinal) Then
                If IsDate(FechaFinal) And IsDate(FechaFinal) Then
                    If Not F_Null(FechaInicial) And Not F_Null(FechaFinal) Then
                        If CDate(FechaInicial) > CDate(FechaFinal) Then
                            ShowMsgBox("La fecha final no puede ser menor a la inicial", MsgBoxStyle.Information)
                            Return False
                        Else
                            Return True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function SumarColumna(ByVal Grid As DataGridView, ByVal Columna As String, Optional ByVal OnlySelected As Boolean = False) As Double
        SumarColumna = 0.0
        Try
            If OnlySelected Then
                If Grid.SelectedRows.Count > 0 Then
                    For i As Integer = 0 To Grid.SelectedRows.Count - 1
                        If Not F_Null(Grid.SelectedRows(i).Cells(Columna).Value.ToString) Then SumarColumna += Convert.ToDouble(Grid.SelectedRows(i).Cells(Columna).Value.ToString)
                    Next
                    Return SumarColumna
                End If
            Else
                If Grid.Rows.Count > 0 Then
                    For i As Integer = 0 To Grid.Rows.Count - 1
                        If Not F_Null(Grid.Rows(i).Cells(Columna).Value.ToString) Then SumarColumna += Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString)
                    Next
                    Return SumarColumna
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SumarColumna(ByVal Grid As DataGridView, Optional ByVal Columna As Integer = 0) As Double
        SumarColumna = 0.0
        Try
            If Grid.Rows.Count > 0 Then
                For i As Integer = 0 To Grid.Rows.Count - 1
                    SumarColumna += Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString)
                Next
                Return SumarColumna
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function SumarColumna(ByVal Grid As DataGridView, ByVal Columna As String) As Double
        SumarColumna = 0.0
        Try
            If Grid.Rows.Count > 0 Then
                For i As Integer = 0 To Grid.Rows.Count - 1
                    If Not F_Null(Grid.Rows(i).Cells(Columna).Value.ToString) Then SumarColumna += Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString)
                Next
                Return SumarColumna
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function




    Public Function EnviarCorreo(ByVal Para() As String, ByVal Asunto As String, ByVal Body As String, Optional ByVal isBodyHTML As Boolean = True, Optional ByVal Attch As String = "", Optional ByVal isPriorityHigth As Boolean = False, Optional ByVal isCopy As Boolean = False) As String
        EnviarCorreo = ""
        Try
            Dim correo As New System.Net.Mail.MailMessage()
            correo.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess
            correo.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            correo.DeliveryNotificationOptions = DeliveryNotificationOptions.Delay
            correo.DeliveryNotificationOptions = DeliveryNotificationOptions.Never
            correo.DeliveryNotificationOptions = DeliveryNotificationOptions.None

            correo.From = New System.Net.Mail.MailAddress(LCase(Get_Archivo(Usuario)) & "@sandiego.com.gt")
            If isCopy Then
                correo.CC.Add(LCase(Get_Archivo(Usuario)) & "@sandiego.com.gt")
            End If

            Dim ciclo
            For ciclo = 0 To Para.Length - 1
                If Not F_Null(Para(ciclo)) Then
                    correo.To.Add(New System.Net.Mail.MailAddress(Para(ciclo)))
                End If
            Next
            correo.Subject = Asunto
            correo.DeliveryNotificationOptions = Net.Mail.DeliveryNotificationOptions.OnSuccess

            'Para Attachar la retencion
            If Not F_Null(Attch) Then
                Dim Attachment As System.Net.Mail.Attachment
                Attachment = New System.Net.Mail.Attachment(Attch)
                correo.Attachments.Add(Attachment)
            End If
            '--------------------------
            If isBodyHTML Then
                correo.Body = "<HTML><HEAD>" & vbCrLf _
          & "<META http-equiv=Content-Type content='text/html; charset=windows-1252'>" & vbCrLf _
          & "<STYLE type=text/css> .style1 {FONT-FAMILY: verdana, arial, sans-serif }" & vbCrLf _
          & ".style5 {font-size: x-small;	font-family: 'Comic Sans MS', 'Times New Roman', sans-serif;}" & vbCrLf _
          & ".style6 {font-size: 10px; font-weight: bold; font-style: italic;}" & vbCrLf _
          & ".tdFooter {	border-top-style: none;	border-bottom-style: solid;	border-bottom-color: #CCCCCC;" & vbCrLf _
          & "border-bottom-width: 1px;vertical-align: middle;background: #FFFFFF;" & vbCrLf _
          & "font-family: Verdana, Arial, Helvetica, sans-serif;	font-size: xx-small;	padding: 2px;" & vbCrLf _
          & "border-right-style: none; border-left-style: none;}" & vbCrLf _
          & ".tdFooter2{border-top-style: none;border-right-style: none;border-bottom-style: solid;" & vbCrLf _
          & "	border-left-style: none;	border-bottom-color: #CCCCCC;	border-bottom-width: 1px;" & vbCrLf _
          & "border-right-width: thin;	border-right-color: #999999;	vertical-align: middle;" & vbCrLf _
          & "background-color: #FFFFCC;	font-size: xx-small;}" & vbCrLf _
          & ".tdHeader {background-color: #C6CBD6;	vertical-align: middle;" & vbCrLf _
          & "font-family: Verdana, Arial, Helvetica, sans-serif;" & vbCrLf _
          & "font-size: xx-small;	color: #333333;	font-weight: bold;	padding: 2px;	text-align: center;" & vbCrLf _
          & "border-top-width: 1px;border-right-width: 1px;border-bottom-width: 1px;	border-left-width: 1px;" & vbCrLf _
          & "border-top-style: none;	border-right-style: solid;	border-bottom-style: solid;	border-left-style: solid;" & vbCrLf _
          & "border-top-color: #CCCCCC;	border-right-color: #CCCCCC;	border-bottom-color: #999999;" & vbCrLf _
          & "border-left-color: #CCCCCC;	height: 20px;background-repeat: no-repeat;	background-attachment: fixed;}" & vbCrLf _
          & "</STYLE>" & vbCrLf _
          & "" & vbCrLf _
          & "<META content='MSHTML 6.00.2900.2180' name=GENERATOR></HEAD>" & vbCrLf _
          & "<BODY>" & vbCrLf _
          & Body & vbCrLf _
          & "</BODY></HTML>" & vbCrLf
                correo.IsBodyHtml = True
            Else
                correo.Body = Body
                correo.IsBodyHtml = False
            End If
            If isPriorityHigth Then
                correo.Priority = System.Net.Mail.MailPriority.High
            End If
            Dim smtp As New System.Net.Mail.SmtpClient

            smtp.Timeout = 900000
            smtp.Send(correo)
            EnviarCorreo = "Correo enviado satisfactoriamente"
        Catch ex As Exception
            F_Error(ex, ex.Message)
        End Try
    End Function
    Public Function EnviarCorreo(ByVal Para As String, ByVal Asunto As String, ByVal Body As String, Optional ByVal isBodyHTML As Boolean = True, Optional ByVal Attch As String = "", Optional ByVal isPriorityHigth As Boolean = False, Optional ByVal isCopy As Boolean = False) As String
        EnviarCorreo = ""
        Try
            Dim correo As New System.Net.Mail.MailMessage()
            correo.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnSuccess
            correo.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.OnFailure
            correo.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.Delay
            correo.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.Never
            correo.DeliveryNotificationOptions = System.Net.Mail.DeliveryNotificationOptions.None

            correo.From = New System.Net.Mail.MailAddress(LCase(Get_Archivo(Usuario, , False)) & "@sandiego.com.gt")
            If isCopy Then
                correo.CC.Add(LCase(Get_Archivo(Usuario, , False)) & "@sandiego.com.gt")
            End If


            If Not F_Null(Para) Then
                correo.To.Add(New System.Net.Mail.MailAddress(Para))
            Else
                EnviarCorreo = " No hay destinatario"
                Exit Function
            End If

            correo.Subject = Asunto
            correo.DeliveryNotificationOptions = Net.Mail.DeliveryNotificationOptions.OnSuccess

            'Para Attachar la retencion
            If Not F_Null(Attch) Then
                Dim Attachment As System.Net.Mail.Attachment
                Attachment = New System.Net.Mail.Attachment(Attch)
                correo.Attachments.Add(Attachment)
            End If
            '--------------------------
            If isBodyHTML Then
                correo.Body = "<HTML><HEAD>" & vbCrLf _
          & "<META http-equiv=Content-Type content='text/html; charset=windows-1252'>" & vbCrLf _
          & "<STYLE type=text/css> .style1 {FONT-FAMILY: verdana, arial, sans-serif }" & vbCrLf _
          & ".style5 {font-size: x-small;	font-family: 'Comic Sans MS', 'Times New Roman', sans-serif;}" & vbCrLf _
          & ".style6 {font-size: 10px; font-weight: bold; font-style: italic;}" & vbCrLf _
          & ".tdFooter {	border-top-style: none;	border-bottom-style: solid;	border-bottom-color: #CCCCCC;" & vbCrLf _
          & "border-bottom-width: 1px;vertical-align: middle;background: #FFFFFF;" & vbCrLf _
          & "font-family: Verdana, Arial, Helvetica, sans-serif;	font-size: x-small;	padding: 2px;" & vbCrLf _
          & "border-right-style: none; border-left-style: none;}" & vbCrLf _
          & ".tdFooter2{border-top-style: none;border-right-style: none;border-bottom-style: solid;" & vbCrLf _
          & "	border-left-style: none;	border-bottom-color: #CCCCCC;	border-bottom-width: 1px;" & vbCrLf _
          & "border-right-width: thin;	border-right-color: #999999;	vertical-align: middle;" & vbCrLf _
          & "background-color: #FFFFCC;	font-size: xx-small;}" & vbCrLf _
          & ".tdHeader {background-color: #C6CBD6;	vertical-align: middle;" & vbCrLf _
          & "font-family: Verdana, Arial, Helvetica, sans-serif;" & vbCrLf _
          & "font-size: medium;	color: #333333;	font-weight: bold;	padding: 2px;	text-align: center;" & vbCrLf _
          & "border-top-width: 1px;border-right-width: 1px;border-bottom-width: 1px;	border-left-width: 1px;" & vbCrLf _
          & "border-top-style: none;	border-right-style: solid;	border-bottom-style: solid;	border-left-style: solid;" & vbCrLf _
          & "border-top-color: #CCCCCC;	border-right-color: #CCCCCC;	border-bottom-color: #999999;" & vbCrLf _
          & "border-left-color: #CCCCCC;	height: 20px;background-repeat: no-repeat;	background-attachment: fixed;}" & vbCrLf _
          & "</STYLE>" & vbCrLf _
          & "" & vbCrLf _
          & "<META content='MSHTML 6.00.2900.2180' name=GENERATOR></HEAD>" & vbCrLf _
          & "<BODY>" & vbCrLf _
          & Body & vbCrLf _
          & "</BODY></HTML>" & vbCrLf
                correo.IsBodyHtml = True
            Else
                correo.Body = Body
                correo.IsBodyHtml = False
            End If
            If isPriorityHigth Then
                correo.Priority = System.Net.Mail.MailPriority.High
            End If
            Dim smtp As New System.Net.Mail.SmtpClient

            smtp.Timeout = 900000
            smtp.Send(correo)
            EnviarCorreo = "Correo enviado satisfactoriamente"
        Catch ex As Exception
            F_Error(ex, ex.Message)
        End Try
    End Function


    'Public Function isValidEmpleado(ByVal Empleado As String, Optional ByVal lblDisplay As Object = Nothing) As Boolean
    '    Try
    '        Dim xEmp As New Presupuesto.clsEmpleados
    '        isValidEmpleado = True
    '        If Not F_Null(Empleado) Then
    '            isValidEmpleado = False
    '            xEmp.open(Empleado)
    '            lblDisplay.Text = ""
    '            If Not xEmp.Exists Then
    '                lblDisplay.Text = " Empleado no existe"
    '                Return False
    '            ElseIf Not xEmp.isActivo Then
    '                lblDisplay.Text = " Empleado inactivo"
    '                Return False
    '            ElseIf xEmp.Exists And xEmp.isActivo Then
    '                lblDisplay.Text = xEmp.NombreCompleto
    '                Return True
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw
    '    End Try
    'End Function




    Public Sub DesactivarMenus(ByVal Menu As MenuStrip, Optional ByVal Activo As Boolean = False)
        Try
            For Each mnu As ToolStripMenuItem In Menu.Items
                If mnu.Name <> "mnuSalir" Then mnu.Enabled = Activo
                If mnu.DropDownItems.Count > 0 Then DesactivarMenuItems(mnu, Activo)
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub DesactivarMenusRx(ByVal Menu As MenuStrip, Optional ByVal Activo As Boolean = False)
        Try
            For Each mnu As ToolStripMenuItem In Menu.Items
                If mnu.Name <> "mnuSalirRx" Then mnu.Enabled = Activo
                If mnu.DropDownItems.Count > 0 Then DesactivarMenuItems(mnu, Activo)
            Next
        Catch ex As Exception
            F_Error(ex, "DesactivarMenusRx")
        End Try
    End Sub

    'Public Sub DesactivarMenuToolStrip(ByVal Menu As ToolStrip, Optional ByVal Activo As Boolean = False)
    '   Try
    '      For Each mnu As ToolStripItem In Menu.Items
    '         If mnu. > 0 Then DesactivarMenuToolStrip(mnu, Activo)
    '      Next
    '   Catch ex As Exception
    '      Throw
    '   End Try
    'End Sub

    Public Sub DesactivarMenuItems(ByVal Menu As ToolStripMenuItem, Optional ByVal Activo As Boolean = False)
        Try
            For Each mnu In Menu.DropDownItems
                If mnu.GetType.Name = "ToolStripMenuItem" Then
                    mnu.Enabled = False
                    If mnu.DropDownItems.Count > 0 Then DesactivarMenuItems(mnu, Activo)
                End If
            Next
        Catch ex As Exception
            F_Error(ex, "DesactivarMenuItems")
        End Try
    End Sub
    'Public Sub CargarPermisos(ByVal Nombre As String, ByVal Menu As MenuStrip)
    '    Try
    '        'Activar menus a los que se tiene acceso 
    '        Dim Accesos As DataTable = BuscarOpciones(Nombre, Usuario)
    '        If Not F_Null(Accesos) Then
    '            For i As Integer = 0 To Accesos.Rows.Count - 1
    '                BuscarOpcionMenu(Accesos.Rows(i).Item("Opcion").ToString, Menu)
    '            Next
    '        End If
    '    Catch ex As Exception
    '        F_Error(ex, "CargarPermisos")
    '    End Try
    'End Sub
    'Public Sub CargarPermisos(ByVal Nombre As String, ByVal Menu As ContextMenuStrip)
    '    Try
    '        'Activar menus a los que se tiene acceso 
    '        Dim Accesos As DataTable = BuscarOpciones(Nombre, Usuario)
    '        If Not F_Null(Accesos) Then
    '            For i As Integer = 0 To Accesos.Rows.Count - 1
    '                BuscarOpcionMenu(Accesos.Rows(i).Item("Opcion").ToString, Menu)
    '            Next
    '        End If
    '    Catch ex As Exception
    '        F_Error(ex, "CargarPermisos")
    '    End Try
    'End Sub
    ''1
    'Public Sub BuscarOpcionMenu(ByVal Nombre As String, ByVal Menu As ContextMenuStrip)
    '   Try
    '      If Not F_Null(Nombre) And Not Menu Is Nothing Then
    '         For Each mnu In Menu.Items
    '            If mnu.GetType.Name = "ToolStripMenuItem" Then
    '               If UCase(mnu.Name) = UCase(Nombre) Then
    '                  mnu.Enabled = True
    '               ElseIf mnu.DropDownItems.Count > 0 Then
    '                  If HabilitarMenuItem(Nombre, mnu) Then Exit Sub
    '               End If
    '            End If
    '         Next
    '      End If
    '   Catch ex As Exception
    '      F_Error(ex, "BuscarOpcionMenu")
    '   End Try
    'End Sub
    ''2
    Public Sub BuscarOpcionMenu(ByVal Nombre As String, ByVal Menu As MenuStrip)
        Try
            If Not F_Null(Nombre) And Not Menu Is Nothing Then
                For Each mnu In Menu.Items
                    If mnu.GetType.Name = "ToolStripMenuItem" Then
                        If UCase(mnu.Name) = UCase(Nombre) Then
                            mnu.Enabled = True
                        ElseIf mnu.DropDownItems.Count > 0 Then
                            If HabilitarMenuItem(Nombre, mnu) Then Exit Sub
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            F_Error(ex, "BuscarOpcionesMenu")
        End Try
    End Sub

    Public Sub BuscarOpcionMenu(ByVal Nombre As String, ByVal Menu As ToolStrip)
        Try
            If Not F_Null(Nombre) And Not Menu Is Nothing Then
                For Each mnu In Menu.Items
                    If mnu.GetType.Name = "ToolStripButton" Then
                        If UCase(mnu.name) = UCase(Nombre) Then
                            mnu.Enabled = True
                            mnu.Visible = True
                            Menu.Visible = True
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            F_Error(ex, "BuscarOpcionMenu")
        End Try
    End Sub


    Public Function HabilitarMenuItem(ByVal Nombre As String, ByVal Menu As ToolStripMenuItem) As Boolean
        HabilitarMenuItem = False
        Try
            If Not F_Null(Nombre) And Not Menu Is Nothing Then
                For Each mnu In Menu.DropDownItems
                    If mnu.GetType.Name = "ToolStripMenuItem" Then
                        If UCase(mnu.Name) = UCase(Nombre) Then
                            mnu.Enabled = True
                            Menu.Enabled = True
                            Return True
                        ElseIf mnu.DropDownItems.Count > 0 Then
                            If HabilitarMenuItem(Nombre, mnu) Then Menu.Enabled = True
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            F_Error(ex, "HabilitarMenuItem")
        End Try
    End Function

    'Public  Function ExportGrd(ByVal grd As DataGridView) As Boolean

    '   'Creamos las variables
    '   Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '   Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '   Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    '   Try
    '      'Añadimos el Libro al programa, y la hoja al libro
    '      exLibro = exApp.Workbooks.Add
    '      exHoja = exLibro.Worksheets.Add()

    '      ' ¿Cuantas columnas y cuantas filas?
    '      Dim NCol As Integer = grd.ColumnCount
    '      Dim NRow As Integer = grd.RowCount

    '      'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
    '      For i As Integer = 1 To NCol
    '         exHoja.Cells.Item(1, i) = grd.Columns(i - 1).Name.ToString
    '         'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
    '      Next

    '      For Fila As Integer = 0 To NRow - 1
    '         For Col As Integer = 0 To NCol - 1
    '            exHoja.Cells.Item(Fila + 2, Col + 1) = grd.Rows(Fila).Cells(Col).Value
    '         Next
    '      Next
    '      'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
    '      exHoja.Rows.Item(1).Font.Bold = 1
    '      exHoja.Rows.Item(1).HorizontalAlignment = 3
    '      exHoja.Columns.AutoFit()


    '      'Aplicación visible
    '      exApp.Application.Visible = True

    '      exHoja = Nothing
    '      exLibro = Nothing
    '      exApp = Nothing

    '   Catch ex As Exception
    '      Throw (ex)
    '   End Try

    '   Return True

    'End Function


    Public Function ExportGrd(ByVal grd As DataGridView, Optional ByVal grd2 As DataGridView = Nothing, Optional ByVal WithHeaders As Boolean = True) As Boolean

        'Creamos las variables
        If grd.Rows.Count = 0 Then
            MsgBox("No existen datos que exportar a Excel, verificar que el grid tenga datos", vbInformation, "Mensaje Del Sistema")
            Return False
        End If
        'Dim exApp As New Microsoft.Office.Interop.Excel.Application
        'Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        'Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim exApp As New Excel.Application
        Dim exlibro As Excel.Workbook
        Dim exhoja As Excel.Worksheet

        Dim i As Integer = 0
        Dim Col As Integer = 0
        Dim fila As Integer = 0, n As Integer = 0
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exlibro = exApp.Workbooks.Add
            exhoja = exlibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = grd.ColumnCount
            Dim NRow As Integer = grd.RowCount

            If WithHeaders Then
                'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
                For i = 1 To NCol
                    If grd.Columns(i - 1).Visible Then exhoja.Cells.Item(1, i) = grd.Columns(i - 1).HeaderText.ToString
                    'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
                Next
                exhoja.Rows.Item(1).Font.Bold = 1
                exhoja.Rows.Item(1).HorizontalAlignment = 3
                n = 1
            End If

            For fila = 0 To NRow - 1
                For Col = 0 To NCol - 1
                    If grd.Rows(fila).Cells(Col).Visible = True Then exhoja.Cells.Item(fila + n + 1, Col + 1) = grd.Rows(fila).Cells(Col).Value
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exhoja.Columns.AutoFit()
            '----------Grd2----------

            If Not grd2 Is Nothing Then
                Dim Ncol2 As Integer = grd2.ColumnCount
                Dim NRow2 As Integer = grd2.RowCount

                For x As Integer = 1 To Ncol2
                    exhoja.Cells.Item(fila + 4, x) = grd2.Columns(x - 1).Name.ToString
                Next

                exhoja.Rows.Item(fila + 4).Font.Bold = 1
                exhoja.Rows.Item(fila + 4).HorizontalAlignment = 3
                exhoja.Columns.AutoFit()

                For fila2 As Integer = 0 To NRow2 - 1
                    For col2 As Integer = 0 To Ncol2 - 1
                        exhoja.Cells.Item(fila + 6 + fila2, col2 + 1) = grd2.Rows(fila2).Cells(col2).Value
                    Next
                Next
            End If

            'Aplicación visible
            exApp.Application.Visible = True

            exhoja = Nothing
            exlibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            Throw
        End Try

        Return True

    End Function

    '**********************--------------------------------------------------------************************
    Public Function FormatDate(ByVal Fecha As String) As String
        FormatDate = ""
        Try
            If Not F_Null(Fecha) Then
                Return CDate(Fecha).ToString("dd/MM/yyyy HH:mm")
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function HoraValida(ByVal Hora As String) As Boolean
        Try
            If Not F_Null(Hora) Then
                Dim Min As Integer = Mid(Hora, 4)
                Dim Hor As Integer = Mid(Hora, 1, 2)
                If Min > 59 Or Min < 0 Then
                    ShowMsgBox("Los minutos no pueden ser mayor a 59 o menor a 0")
                    Return False
                End If
                If Hor > 23 Or Hor < 0 Then
                    ShowMsgBox("Las horas no pueden ser mayor a 23  o menor a 0. (La hora 24 se toma como 00)")
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Val(ByVal Value As String) As Double
        Try
            Return Valor(Value)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Valor(ByVal Cadena As String) As String
        Try
            If F_Null(Cadena) Then Return 0 Else Return Convert.ToDouble(Cadena)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Valid_RangoValores(ByVal xValorIni As String, ByVal xValorFin As String) As Boolean
        Try
            If Not F_Null(xValorIni) And Not F_Null(xValorFin) Then
                Dim xIni As Double
                Dim xFin As Double
                xIni = CDbl(xValorIni)
                xFin = CDbl(xValorFin)

                If xIni > xFin Then
                    MsgBox("El Valor Inicial " & xValorIni & " no puede ser Mayor A " & xValorFin)
                    Valid_RangoValores = False
                    Exit Function
                End If
            End If
            Valid_RangoValores = True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Valid_RangoHoras(ByVal FechaInicial As String, ByVal FechaFinal As String, _
                                                              ByVal HoraInicial As String, ByVal HoraFinal As String) As Boolean
        Try
            If Not F_Null(FechaInicial) And Not F_Null(FechaFinal) And Not F_Null(HoraInicial) And Not F_Null(HoraFinal) Then
                If (CDate(FechaInicial & " " & HoraInicial) < CDate(FechaFinal & " " & HoraFinal)) Then
                    Return True
                Else
                    ShowMsgBox("La fecha y hora final no pueden ser menor a la inicial, verifique")
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function isValidRangoValores(ByVal RInicial As String, ByVal RFinal As String) As Boolean
        isValidRangoValores = True
        Try
            If Not F_Null(RInicial) And Not F_Null(RFinal) Then
                If RInicial > RFinal Then
                    MsgBox("El valor Inicial no puede ser mayor  al valor final")
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function isValidRangeDate(ByVal FInicial As Date, ByVal FFinal As Date) As Boolean
        isValidRangeDate = True
        Try
            If Not F_Null(FInicial) And Not F_Null(FFinal) Then
                If FInicial > FFinal Then
                    MsgBox("El Fecha Inicial no puede ser mayor  a la fecha final")
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Devuelve la Fecha u Hora con la ventaja de que si esta en blanco devuelve ""
    ''' </summary>
    ''' <param name="DateTime">Fecha</param>
    ''' <param name="opcion">1:Devuelve Fecha , 2: Devuelve Hora</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Get_DbDateTime(ByVal DateTime As String, Optional ByVal opcion As Integer = 1) As String
        Try
            If F_Null(DateTime) Then
                Return ""
            Else
                If opcion = 1 Then
                    Return CDate(DateTime).ToShortDateString
                Else
                    Return CDate(DateTime).ToShortTimeString
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function SendDateTime(ByVal Fecha As String, ByVal Hora As String, Optional ByVal WithComa As Boolean = False, Optional ByVal OnlyTime As Boolean = False) As String
        Try
            If Not F_Null(Fecha) Then
                If Not F_Null(Hora) Then
                    Return If(WithComa, SendWithComa(Trim(Fecha & " " & Hora)), Send(Trim(Fecha & " " & Hora)))
                Else
                    Return If(WithComa, SendWithComa(Trim(Fecha & " 00:00")), Send(Trim(Fecha & " 00:00")))
                End If
            ElseIf OnlyTime And Not F_Null(Hora) Then
                Return If(WithComa, SendWithComa(Send("01/01/1900 " & Hora)), Send("01/01/1900 " & Hora))
            Else
                Return If(WithComa, "Null,", "NULL")
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarValores(ByVal Vinicial As String, ByVal Vfinal As String) As Boolean
        ValidarValores = True
        Try
            If Not F_Null(Vinicial) And Not F_Null(Vfinal) Then
                If Val(Vinicial) > Val(Vfinal) Then
                    MsgBox("El valor inicial " & Vinicial & " No puede ser mayor que el valor " & Vfinal, vbInformation, "Mensaje Del Sistema")
                    Return False
                End If
            Else
                MsgBox("Alguno de los campos esta vacio favor de verificar ", vbInformation, "Mensaje Del Sistema")
                Return False
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Get_Fecha(ByVal fecha) As String
        Try
            If Not F_Null(fecha) Then
                fecha = Left(fecha, 10)
            End If
            Return fecha
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Get_Hora(ByVal hora) As String
        Dim Vinicio As Integer = 0
        Try
            If Not F_Null(hora) Then

                Vinicio = InStr(hora, " ")
                hora = Mid(hora, Vinicio, 9)
            End If
            Return F_NVL(hora, "__:__")
        Catch ex As Exception
            Throw
        End Try
    End Function





    Public Sub ValidaTextNumero(ByVal xText As TextBox)
        Try
            If Not F_Null(xText.Text) And Not IsNumeric(xText.Text) Then
                MsgBox("Este Campo solo admite valores numéricos, verificar", vbInformation, "Mensaje Del Sistema")
                xText.Focus()
            End If
        Catch ex As Exception
            F_Error(ex, "ValidaTextNumero")
        End Try
    End Sub

    Public Sub LetrasNumeros(ByVal x As System.Windows.Forms.KeyPressEventArgs)
        Try
            If x.KeyChar = ChrW(Keys.Enter) Then
                x.Handled = False
            ElseIf Char.IsLetter(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsSeparator(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsControl(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsNumber(x.KeyChar) Then
                x.Handled = False
            ElseIf x.KeyChar = "/" Then
                x.Handled = False
            ElseIf x.KeyChar = "-" Then
                x.Handled = False
            ElseIf x.KeyChar = "." Then
                x.Handled = False
            Else
                x.Handled = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Numeros(ByVal x As System.Windows.Forms.KeyPressEventArgs)
        Try
            If x.KeyChar = ChrW(Keys.Enter) Then
                x.Handled = False
            ElseIf Char.IsSeparator(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsControl(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsNumber(x.KeyChar) Then
                x.Handled = False
            Else
                x.Handled = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub NumeroDecimal(ByVal x As System.Windows.Forms.KeyPressEventArgs)
        Try
            If x.KeyChar = ChrW(Keys.Enter) Then
                x.Handled = False
            ElseIf Char.IsSeparator(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsControl(x.KeyChar) Then
                x.Handled = False
            ElseIf Char.IsNumber(x.KeyChar) Then
                x.Handled = False
            ElseIf x.KeyChar = "." Then
                x.Handled = False
            Else
                x.Handled = True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub




    ''' <summary>
    ''' Limpia los controles de un formulario enviando el formulario, Ejem. limpiarControles(me)
    ''' </summary>
    ''' <param name="contenedor"></param>
    ''' <remarks></remarks>
    Public Sub limpiarControles(ByVal contenedor As Control)
        Try
            For Each C As Control In contenedor.Controls
                If TypeOf C Is TextBox Then C.Text = ""
                If TypeOf C Is TextBoxSD Then C.Text = ""
                If TypeOf C Is ComboBox Then C.Text = ""
                If TypeOf C Is ComboBoxSD Then C.Text = ""
                If TypeOf C Is MaskedTextBoxSD Then C.Text = ""
                If TypeOf C Is CheckBox Then CType(C, CheckBox).Checked = False
                If TypeOf C Is RadioButton Then CType(C, RadioButton).Checked = False
                If TypeOf C Is ListBox Then CType(C, ListBox).DataSource = Nothing
                If TypeOf C Is RichTextBox Then C.Text = ""
                If TypeOf C Is TableLayoutPanel Then limpiarControles(C)
                If TypeOf C Is GroupBox Then limpiarControles(C)
                If TypeOf C Is Panel Then limpiarControles(C)
                If TypeOf C Is TabControl Then limpiarControles(C)
                If TypeOf C Is SplitContainer Then limpiarControles(C)
                If TypeOf C Is DataGridView Then LimpiarGrid(CType(C, DataGridView))

            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub








    Public Sub SetSelectionStart(ByVal txt As MaskedTextBoxSD)
        Try
            If txt.RightToLeft Then
                If txt.SelectionStart > Len(txt.Mask.ToString) - 1 Then
                    txt.SelectionStart = Len(txt.Mask.ToString)
                End If
            Else
                If txt.SelectionStart > Len(txt.Mask.ToString) - 1 Then
                    txt.SelectionStart = 0
                End If
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub




    Public Sub convertExcelToCSV(ByVal targetFile As String)
        Dim source As String = String.Empty
        source = OpenFile("Excel (*.xls, *.xlsx)|*.xls;*.xlsx", "Importar archivo")
        If Not F_Null(source) Then
            Dim strConn As String = GetConexionAExcel((source))
            Dim conn As OleDbConnection = Nothing
            Dim wrtr As StreamWriter = Nothing
            Dim cmd As OleDbCommand = Nothing
            Dim da As OleDbDataAdapter = Nothing
            Try

                conn = New OleDbConnection(strConn)
                conn.Open()

                cmd = New OleDbCommand("SELECT * FROM [" & "Presupuesto" & "$]", conn)
                cmd.CommandType = CommandType.Text
                wrtr = New StreamWriter(targetFile, True)
                da = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable()
                da.Fill(dt)

                For x As Integer = 0 To dt.Rows.Count - 1
                    Dim rowString As String = ""

                    For y As Integer = 0 To dt.Columns.Count - 1
                        rowString &= """" & dt.Rows(x)(y).ToString() & ""","
                    Next y
                    wrtr.WriteLine(rowString)
                Next x

            Catch exc As Exception
                Throw
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                wrtr.Close()
            End Try
        End If
    End Sub
    Public Function GetConexionAExcel(ByVal Source As String) As String
        GetConexionAExcel = ""
        If Not F_Null(Source) Then
            If Right(Source, 1) = "x" Then
                GetConexionAExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Source & ";Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1'"
            Else
                GetConexionAExcel = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Source & ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1'"
            End If
        End If
        Return GetConexionAExcel
    End Function

    Public Function OpenFile(Optional ByVal Filter As String = "", Optional ByVal Titulo As String = "Abrir archivo") As String
        OpenFile = ""
        Try
            With FileDialog
                .Filter = Filter
                .FilterIndex = 1
                .Title = Titulo
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim AllText As String = String.Empty
                    AllText = .FileName
                    .Dispose()
                    Return AllText
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function SaveFile(Optional ByVal Filter As String = "Excel|*.xlsx", Optional ByVal Titulo As String = "Elegir ubicacion y nombre de archivo") As String
        SaveFile = ""
        Try
            With SaveDialog
                .Filter = Filter
                .FilterIndex = 1
                .Title = Titulo
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim AllText As String = String.Empty
                    AllText = .FileName
                    .Dispose()
                    Return AllText
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Sub LimpiarGrid(ByVal grid As DataGridView)
        Try
            For i As Integer = 0 To grid.Rows.Count - 1
                grid.Rows.RemoveAt(0)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Function GetNivelCuenta(ByVal Cuenta As String, ByVal Nivel As Int16)
        Try
            GetNivelCuenta = ""
            If Not F_Null(Cuenta) And (Nivel) > 0 Then
                If Nivel = 1 Then
                    Return Mid(Cuenta, 1, 1)
                ElseIf Nivel = 2 Then
                    Return Mid(Cuenta, 2, 1)
                ElseIf Nivel = 3 Then
                    Return Mid(Cuenta, 3, 1)
                ElseIf Nivel = 4 Then
                    Return Mid(Cuenta, 4, 2)
                Else
                    Return ""
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AutoajustarGrid(ByVal grid As DataGridView, ByVal Datos As DataTable)
        Try
            If Not F_Null(Datos) Then
                grid.DataSource = Datos
                If Datos.Rows.Count <= 0 Then
                    LimpiarGrid(grid)
                Else
                    For i As Integer = 0 To grid.Columns.Count - 1
                        grid.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Next
                End If
                grid.Refresh()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

 
    Sub FilterDataViewChange(ByVal Grid As DataGridView, ByVal Text As String, ByVal vwVista As DataView, Optional ByVal MinText As Integer = 3, Optional ByVal FiltroFijo As String = "")
        Try

            Dim RowFilter As String = String.Empty, AddOr As Boolean = False
            If Not F_Null(vwVista.Table) And Not F_Null(Text) And Len(Text) >= MinText Then
                'Armamos un filtro para cualquier columna de la tabla
                For i As Integer = 0 To vwVista.Table.Columns.Count - 1
                    AddOr = False
                    ' RowFilter &= xTable.Columns(i).ColumnName & "=" & Send(FindString)
                    If vwVista.Table.Columns(i).DataType.ToString <> "System.Boolean" Then
                        If InStr(vwVista.Table.Columns(i).DataType.ToString, "Int") > 0 And IsNumeric(F_NVL(Text, "0")) Then
                            RowFilter &= vwVista.Table.Columns(i).ColumnName & "=" & Send(Text)
                            AddOr = True
                        ElseIf InStr(vwVista.Table.Columns(i).DataType.ToString, "String") > 0 Then
                            RowFilter &= vwVista.Table.Columns(i).ColumnName & " like " & Send("%" & Text & "%")
                            AddOr = True
                        End If
                        If (i <> vwVista.Table.Columns.Count - 1 And Not F_Null(RowFilter)) And AddOr Then RowFilter &= " or "
                    End If
                Next i
            Else
                RowFilter = ""
            End If
            If Not F_Null(RowFilter) Then
                If Trim(Mid(RowFilter, Len(RowFilter) - 3)) = "or" Then RowFilter = Mid(RowFilter, 1, Len(RowFilter) - 3)
                RowFilter = "(" & RowFilter & ")"
                If Not F_Null(FiltroFijo) Then RowFilter &= " and " & FiltroFijo
            Else
                RowFilter = FiltroFijo
            End If

            vwVista.RowFilter = RowFilter

            Grid.DataSource = vwVista
            Grid.Refresh()

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function Encriptar(ByVal Input As String) As String
        Encriptar = Nothing
        Try
            Dim IV() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = System.Text.Encoding.UTF8.GetBytes(Input)
            Dim des As System.Security.Cryptography.TripleDESCryptoServiceProvider = New System.Security.Cryptography.TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV
            Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        Catch ex As Exception
            F_Error(ex, "Encriptar")
        End Try
    End Function

    Public Function Desencriptar(ByVal Input As String) As String
        Desencriptar = Nothing
        Try
            Dim IV() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
            Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
            Dim buffer() As Byte = Convert.FromBase64String(Input)
            Dim des As System.Security.Cryptography.TripleDESCryptoServiceProvider = New System.Security.Cryptography.TripleDESCryptoServiceProvider
            des.Key = EncryptionKey
            des.IV = IV
            Return System.Text.Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        Catch ex As Exception
            F_Error(ex, "Desencriptar")
        End Try
    End Function

    Public Sub AplicaEfectoControles(ByVal Contenedor As Control)
        For Each c As Control In Contenedor.Controls
            If TypeOf c Is TextBoxSD Or TypeOf c Is MaskedTextBoxSD Or TypeOf c Is ComboBoxSD Then
                If TypeOf c Is TextBoxSD Then AddHandler CType(c, TextBoxSD).GotFocus, AddressOf AgregarFoco
                If TypeOf c Is MaskedTextBoxSD Then AddHandler CType(c, MaskedTextBoxSD).GotFocus, AddressOf AgregarFoco
                If TypeOf c Is ComboBoxSD Then AddHandler CType(c, ComboBoxSD).GotFocus, AddressOf AgregarFoco

                If TypeOf c Is TextBoxSD Then AddHandler CType(c, TextBoxSD).LostFocus, AddressOf PierdeFoco
                If TypeOf c Is MaskedTextBoxSD Then AddHandler CType(c, MaskedTextBoxSD).LostFocus, AddressOf PierdeFoco
                If TypeOf c Is ComboBoxSD Then AddHandler CType(c, ComboBoxSD).LostFocus, AddressOf PierdeFoco
            Else
                AplicaEfectoControles(c)
            End If
        Next
    End Sub

    Private Sub AgregarFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        If TypeOf sender Is TextBoxSD Then
            'TipoDeCampo = CType(sender, TextBoxSD).TipoDeCampo
            CType(sender, TextBoxSD).BackColor = Color.LightSkyBlue
            CType(sender, TextBoxSD).Font = New System.Drawing.Font("Microsoft Sans Serif", CType(sender, TextBoxSD).Font.Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If
        If TypeOf sender Is MaskedTextBoxSD Then
            'TipoDeCampo = CType(sender, MaskedTextBoxSD).TipoDeCampo
            CType(sender, MaskedTextBoxSD).BackColor = Color.LightSkyBlue
            CType(sender, MaskedTextBoxSD).Font = New System.Drawing.Font("Microsoft Sans Serif", CType(sender, MaskedTextBoxSD).Font.Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If
        If TypeOf sender Is ComboBoxSD Then
            'TipoDeCampo = CType(sender, ComboBoxSD).TipoDeCampo
            CType(sender, ComboBoxSD).BackColor = Color.LightSkyBlue
            CType(sender, ComboBoxSD).Font = New System.Drawing.Font("Microsoft Sans Serif", CType(sender, ComboBoxSD).Font.Size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If
    End Sub

    Private Sub PierdeFoco(ByVal sender As Object, ByVal e As System.EventArgs)
        If TypeOf sender Is TextBoxSD Then
            CType(sender, TextBoxSD).TipoDeCampo = CType(sender, TextBoxSD).TipoDeCampo
            CType(sender, TextBoxSD).Font = New Font(CType(sender, TextBoxSD).Font, FontStyle.Regular)
            CType(sender, TextBoxSD).SelectionLength = 0
        End If
        If TypeOf sender Is MaskedTextBoxSD Then
            CType(sender, MaskedTextBoxSD).TipoDeCampo = CType(sender, MaskedTextBoxSD).TipoDeCampo
            CType(sender, MaskedTextBoxSD).Font = New Font(CType(sender, MaskedTextBoxSD).Font, FontStyle.Regular)
            CType(sender, MaskedTextBoxSD).SelectionLength = 0
        End If
        If TypeOf sender Is ComboBoxSD Then
            CType(sender, ComboBoxSD).TipoDeCampo = CType(sender, ComboBoxSD).TipoDeCampo
            CType(sender, ComboBoxSD).Font = New Font(CType(sender, ComboBoxSD).Font, FontStyle.Regular)
            CType(sender, ComboBoxSD).SelectionLength = 0
        End If
    End Sub

    Sub MensajeDeSistema(form As Form, mensaje As String)
        mdiMenu.udaAlerta.Show(form.Text, mensaje)
    End Sub
    ''' <summary>
    ''' Llena el combo segun el nombre del mismo
    ''' </summary>
    ''' <param name="Combo">Combo para llenar</param>
    ''' <param name="AgregarTodos">Si se agrega la opcion "Todos" utilizada comunmente en filtros</param>
    ''' <param name="xParameter1">Parametro opcional</param>
    ''' <param name="xParameter2">Parametro opcional</param>
    ''' <param name="xParameter3">Parametro opcional</param>
    ''' <remarks></remarks>
    Public Sub Fill_Combos(Combo As ComboBoxSD, Optional ByVal AgregarTodos As Boolean = False, Optional ByVal xParameter1 As String = "", Optional ByVal xParameter2 As String = "", Optional ByVal xParameter3 As String = "")
        Try
            Dim Nombre As String = UCase(Combo.Name), TblConsulta As New DataTable

            Select Case Nombre
                Case UCase("cboParentescos")
                    TblConsulta = Combos.Parentescos
                Case UCase("cboTipoDeBeneficiario")
                    TblConsulta = Combos.TiposDeBeneficiarios
                Case UCase("cboEstadosTransaccion")
                    TblConsulta = Combos.TransaccionesEstados
                Case UCase("cboModalidad")
                    TblConsulta = Combos.Modalidades
                Case UCase("cboTipoRetencion")
                    TblConsulta = Combos.TipoRetencion
                Case UCase("cboMoneda")
                    TblConsulta = Combos.Monedas
                Case UCase("cboTipoDocumento")
                    TblConsulta = Combos.TiposDeDocumentos(xParameter1)
                Case UCase("cboBancos")
                    TblConsulta = Combos.Bancos
                Case UCase("cboCuentasBancarias")
                    TblConsulta = Combos.CuentasBancarias(xParameter1)
                Case UCase("cboBaseLegal")
                    TblConsulta = Combos.BasesLegales
                Case UCase("cboClasificacion")
                    TblConsulta = Combos.Clasificaciones
            End Select

            If AgregarTodos Then TblConsulta.Rows.Add("", "-Todos-")

            'Si se define el agregar todos se agrega a la tabla con valor ""
            If AgregarTodos Then TblConsulta.Rows.Add("", "-Todos-")
            'Se setea el valuemember del data source
            Combo.ValueMember = TblConsulta.Columns(0).ColumnName.ToString
            'Se Setea el datamember del data source
            Combo.DisplayMember = TblConsulta.Columns(1).ColumnName.ToString
            'Se iguala el Datasource a la tabla
            Combo.DataSource = TblConsulta
            'Se Refresca el combo
            Combo.Refresh()
            'If Not F_Null(ValorActual) Then xCombo.Codigo = ValorActual Else 
            Combo.Text = ""
            'Se Selecciona el todos como default
            If AgregarTodos Then Combo.SelectedValue = ""


        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Enum ItemsToFind
        Generico = 0
        Proveedores = 1
        CuentasContables = 2
    End Enum

    ''' <summary>
    ''' Para encontrar un registro especifico en una lista de valores
    ''' </summary>
    ''' <param name="ItemToFind">Especifica un query predefinido para cargar la lista</param>
    ''' <param name="FindString">Parte o todo de lo que se esta buscando </param>
    ''' <param name="AlternativeQuery">Si se desea sustituir el query definido por otro</param>
    ''' <param name="OnlyWith">Para no traer todos los registros, ideal para tablas grandes </param>
    ''' <returns>Retorna un DataRow</returns>
    ''' <remarks></remarks>
    Public Function FindItem(ByVal ItemToFind As ItemsToFind, Optional ByVal FindString As String = "", Optional ByVal OnlyWith As String = "", Optional ByVal AlternativeQuery As String = "", Optional ByVal Maximize As Boolean = False) As String
        Try
            'If F_Null(ItemToFind) Then Return Nothing
            Dim sqlQuery As String = String.Empty, xTable As New DataTable, RowFilter As String = String.Empty
            RowFound = Nothing
            'Seleccionamos un query Predefinido
            Select Case UCase(ItemToFind)

                Case ItemsToFind.Proveedores
                    xTable = Combos.ItemsProveedores(FindString)

                Case ItemsToFind.CuentasContables
                    xTable = Combos.ItemsCuentasContables(FindString)
            End Select

            'Si enviamos un query alternativo se asigna al query original
            If Not F_Null(AlternativeQuery) Then sqlQuery = AlternativeQuery

            'Si tenemos un query lo consultamos en una tabla
            If xTable.Rows.Count > 0 Then
                If F_Null(xTable) Then Return Nothing

                'Instanciamos una vista de esa tabla
                Dim vwFiltro As New DataView(xTable)
                If InStr(FindString, "|") > 0 Then FindString = FindString.Split("|")(0)
                'Armamos un filtro para cualquier columna de la tabla
                If Not F_Null(FindString) Then
                    For i As Integer = 0 To xTable.Columns.Count - 1
                        ' RowFilter &= xTable.Columns(i).ColumnName & "=" & Send(FindString)
                        If InStr(xTable.Columns(i).DataType.ToString, "Int") > 0 And IsNumeric(FindString) Then
                            RowFilter &= xTable.Columns(i).ColumnName & "=" & Send(FindString)
                        ElseIf InStr(xTable.Columns(i).DataType.ToString, "String") > 0 Then
                            RowFilter &= xTable.Columns(i).ColumnName & " like " & Send("%" & FindString & "%")
                        End If
                        If i <> xTable.Columns.Count - 1 And Not F_Null(RowFilter) Then RowFilter &= " or "
                    Next i
                End If
                'Asignamos el filtro a la vista para que muestre las ocurrencias encontradas 
                vwFiltro.RowFilter = RowFilter

                'si encontramos exactamente un registro devolvemos la row
                If vwFiltro.Count = 1 Then
                    RowFound = vwFiltro(0).Row
                    Return vwFiltro(0).Row.Item(0).ToString
                Else
                    'Si no existe  ningun registro que coincide eliminamos el filtro para que nos muestre todo el resultado del query
                    If vwFiltro.Count < 1 Then vwFiltro.RowFilter = ""
                    Dim Lov As New FrmLov
                    Lov.Filter = FindString
                    Lov.vwFiltro = vwFiltro
                    If Maximize Then Lov.WindowState = FormWindowState.Maximized Else Lov.WindowState = FormWindowState.Normal
                    Lov.ShowDialog()
                    If Not F_Null(RowFound) Then Return RowFound.Item(0).ToString Else Return ""
                End If

            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function SumarColumna(ByVal Grid As DataGridView, ByVal Columna As String,
                                     Optional ByVal OnlySelected As Boolean = False,
                                     Optional isCargosAbonos As String = "") As Double
        SumarColumna = 0.0
        Try
            If OnlySelected Then
                If Grid.SelectedRows.Count > 0 Then
                    For i As Integer = 0 To Grid.SelectedRows.Count - 1
                        If Not F_Null(Grid.SelectedRows(i).Cells(Columna).Value.ToString) Then
                            If Not F_Null(isCargosAbonos) Then
                                If isCargosAbonos = "A" Then
                                    If Convert.ToDouble(Grid.SelectedRows(i).Cells(Columna).Value.ToString) < 0 Then
                                        SumarColumna += Convert.ToDouble(Grid.SelectedRows(i).Cells(Columna).Value.ToString)
                                    End If
                                ElseIf isCargosAbonos = "C" Then
                                    If Convert.ToDouble(Grid.SelectedRows(i).Cells(Columna).Value.ToString) > 0 Then
                                        SumarColumna += Convert.ToDouble(Grid.SelectedRows(i).Cells(Columna).Value.ToString)
                                    End If
                                End If
                            Else
                                SumarColumna += Convert.ToDouble(Grid.SelectedRows(i).Cells(Columna).Value.ToString)
                            End If
                        End If
                    Next
                    Return SumarColumna
                End If
            Else
                If Grid.Rows.Count > 0 Then
                    For i As Integer = 0 To Grid.Rows.Count - 1
                        If Not F_Null(Grid.Rows(i).Cells(Columna).Value.ToString) Then
                            If Not F_Null(isCargosAbonos) Then
                                If isCargosAbonos = "A" Then
                                    If Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString) < 0 Then
                                        SumarColumna += Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString)
                                    End If
                                ElseIf isCargosAbonos = "C" Then
                                    If Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString) > 0 Then
                                        SumarColumna += Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString)
                                    End If
                                End If
                            Else
                                SumarColumna += Convert.ToDouble(Grid.Rows(i).Cells(Columna).Value.ToString)
                            End If
                        End If
                    Next
                    Return SumarColumna
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub DeshabilitaMenuContextual(ByVal MenuContextual As ContextMenuStrip)
        Dim Menu As New ContextMenuStrip
        Menu = MenuContextual
        For Each item In Menu.Items
            If item.GetType.Name = "ToolStripMenuItem" Then item.Enabled = False
        Next
    End Sub

    Public Function SelectRowFromDataGridview(ByVal gridview As DataGridView, ByVal Column As String, ByVal Valor As String, Optional ByVal VisibleColumn As String = "") As Boolean
        Try
            For i As Integer = 0 To gridview.Rows.Count - 1
                'gridview.Rows(i).Selected = False
                If gridview.Rows(i).Cells(Column).Value.ToString() = Valor Then
                    gridview.Rows(i).Selected = True
                    gridview.CurrentCell = gridview.Rows(i).Cells(If(Not F_Null(VisibleColumn), VisibleColumn, Column))
                    'gridview.CurrentRow. = gridview.Rows(i)
                    Return True
                End If
            Next i
            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function
End Module


