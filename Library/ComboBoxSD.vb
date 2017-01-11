

Imports System.Windows.Forms
Imports System.Drawing
Imports DataBase.DataBase


Public Class ComboBoxSD
    Inherits ComboBox
    Private NavEnter As Boolean = True
    Private isAllText As Boolean = False
    Private Separator As String = "-"
    Private Nulo As Boolean = False
    Private TipoCampo As TiposDeCampo = TiposDeCampo.Personalizado
    Private Validacion As TiposValidacion = TiposValidacion.Tabla
    Private _sqlQuery As String = String.Empty
    Private _db As New DataBase.DataBase.DataBase

    Enum TiposValidacion
        Undefined = 0
        Tabla = 1
        Manual = 2
        Valor = 3
    End Enum
    ''' <summary>
    ''' Query para hacer el fill del combo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property sqlQuery As String
        Get
            Return _sqlQuery
        End Get
        Set(value As String)
            _sqlQuery = value
        End Set
    End Property

    ''' <summary>
    ''' Conexion a la base de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property cnDefault As String
        Get
            Return _db.ConnectionString
        End Get
        Set(value As String)
            _db.ConnectionString = value
        End Set
    End Property

    ''' <summary>
    ''' Propieda que sirve para definir contra que se valida el combo en el validate
    ''' </summary>
    ''' <remarks></remarks>
    Public Property TipoValidacion As TiposValidacion
        Get
            Return Validacion
        End Get
        Set(ByVal value As TiposValidacion)
            Validacion = value
        End Set
    End Property
    Enum TiposDeCampo
        Undefined = 0
        Obligatorio = 1
        Opcional = 2
        Desplieque = 3
        Personalizado = 4
    End Enum
    Public Property Separador As String
        Get
            Return Separator
        End Get
        Set(ByVal value As String)
            Separator = value
        End Set
    End Property

    ''' <summary>
    ''' Otiene o Determina si se validara todo el texto del combo o solo el codigo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ValidAllText() As Boolean
        Get
            Return isAllText
        End Get
        Set(ByVal value As Boolean)
            isAllText = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            If TipoValidacion = TiposValidacion.Valor Then
                Return Me.SelectedValue
            Else
                Return Obtener_Codigo(Me.Text)
            End If
        End Get
        Set(ByVal value As String)
            If TipoValidacion = TiposValidacion.Valor Then
                Me.SelectedValue = value
            Else
                Me.Text = value
            End If

            Valid_Combo()
        End Set
    End Property
    Private Function Valid_Combo() As Boolean
        Try
            Valid_Combo = True
            If Not F_Null(Me.Text) Then
                Dim x As Integer = 0
                Valid_Combo = False
                While Not Valid_Combo And Not x = Me.Items.Count
                    If Not isAllText Then
                        If TipoValidacion = TiposValidacion.Tabla Then
                            If UCase(Me.Codigo) = UCase(Obtener_Codigo(Items(x).item(1).ToString)) Then Valid_Combo = True
                        ElseIf TipoValidacion = TiposValidacion.Manual Then
                            If UCase(Me.Codigo) = UCase(Obtener_Codigo(Items(x).ToString)) Then Valid_Combo = True
                        ElseIf TipoValidacion = TiposValidacion.Valor Then
                            If UCase(Me.Codigo) = UCase(Obtener_Codigo(Items(x).item(0).ToString)) Then Valid_Combo = True
                        End If
                    Else
                        If TipoValidacion = TiposValidacion.Tabla Then
                            If UCase(Me.Text) = UCase((Items(x).item(1).ToString)) Then Valid_Combo = True
                        ElseIf TipoValidacion = TiposValidacion.Manual Then
                            If UCase(Me.Text) = UCase((Items(x).ToString)) Then Valid_Combo = True
                        ElseIf TipoValidacion = TiposValidacion.Valor Then
                            If UCase(Me.Text) = UCase((Items(x).item(0).ToString)) Then Valid_Combo = True
                        End If
                    End If
                    If Valid_Combo Then
                        If TipoValidacion = TiposValidacion.Tabla Or TipoValidacion = TiposValidacion.Valor Then
                            Me.Text = Trim(Me.Items(x).item(1).ToString)
                            Me.SelectedValue = Me.Items(x).item(0).ToString
                        ElseIf TipoValidacion = TiposValidacion.Manual Then
                            Me.Text = Trim(Me.Items(x).ToString)
                        End If
                    End If

                    x += 1
                End While
                If Not Valid_Combo Then MsgBox("Código de " & Mid(Me.Name, 4) & " no encontrado ", vbInformation, "Mensaje De Sistema")
            End If
            Return Valid_Combo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtiene o Determina si al presionar enter se ejecuta un Tab
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NavegarConEnter() As Boolean
        Get
            Return NavEnter
        End Get
        Set(ByVal value As Boolean)
            NavEnter = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene o Determina el tipo de campo para este control
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TipoDeCampo() As TiposDeCampo
        Get
            Return TipoCampo
        End Get
        Set(ByVal value As TiposDeCampo)
            Set_TipoCampo(value)
            TipoCampo = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene un false si el control contiene texto ingresado o un true si esta en blanco
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property isNull() As Boolean
        Get
            Nulo = False
            If F_Null(Me.Text) Then
                Return True
            ElseIf Not (Me.SelectedValue) Is Nothing Then
                If F_Null(Me.SelectedValue.ToString) Then Return True
            End If
            Return Nulo
        End Get
    End Property
    Private Sub Set_TipoCampo(ByVal Tipo As TiposDeCampo)
        If Tipo = TiposDeCampo.Obligatorio Then
            Me.Enabled = True
            Me.BackColor = color.LemonChiffon
        ElseIf Tipo = TiposDeCampo.Desplieque Then
            Me.Enabled = False
            Me.BackColor = Color.LightGreen
        ElseIf Tipo = TiposDeCampo.Opcional Then
            Me.Enabled = True
            Me.BackColor = Color.LightGray
        Else
            Me.Enabled = True
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub ComboBoxEd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.SelectionStart = 0
        Me.SelectionLength = Len(Me.Text)
    End Sub

    Private Sub ComboBoxEd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If NavegarConEnter Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub
    Private Function Obtener_Codigo(ByVal xString As String) As String
        Dim Posicion As Integer
        Posicion = InStr(xString, Separador)
        If Posicion = 0 Then
            Return Trim(xString)
        Else
            Return Trim(Mid(xString, 1, Posicion - 1))
        End If
    End Function
    '''<summary>
    '''Verifica si el campo esta nulo
    '''</summary>
    Private Function F_Null(ByVal xstring As String) As Boolean
        F_Null = True
        If xstring Is Nothing Then
            F_Null = True
        ElseIf Len(LTrim(RTrim(xstring))) = 0 Then
            F_Null = True
        Else
            F_Null = False
        End If
    End Function


    Private Sub ComboBoxEd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        e.Cancel = Not Valid_Combo()
    End Sub

    Public ReadOnly Property Firma As String
        Get
            Return "SD-TI031110"
        End Get
    End Property

    Public Sub Fill(Optional ByVal AgregarTodos As Boolean = False)
        Try
            If sqlQuery = String.Empty Then
                Throw New Exception("No se especifico la informacion necesaria para llenar el combo")
            Else
                Dim TblConsulta As New DataTable
                'Consulta el query
                TblConsulta = _db.ConsultarTabla(sqlQuery)
                'Si se define el agregar todos se agrega a la tabla con valor ""
                If AgregarTodos Then TblConsulta.Rows.Add("", "-Todos-")
                'Se setea el valuemember del data source
                Me.ValueMember = TblConsulta.Columns(0).ColumnName.ToString
                'Se Setea el datamember del data source
                Me.DisplayMember = TblConsulta.Columns(1).ColumnName.ToString
                'Se iguala el Datasource a la tabla
                Me.DataSource = TblConsulta
                'Se Refresca el combo
                Me.Refresh()
                'If Not F_Null(ValorActual) Then xCombo.Codigo = ValorActual Else 
                Me.Text = ""
                'Se Selecciona el todos como default
                If AgregarTodos Then Me.SelectedValue = ""
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub


End Class

