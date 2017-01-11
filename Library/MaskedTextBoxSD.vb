Imports System.Windows.Forms
Imports System.Drawing
Public Class MaskedTextBoxSD
    Inherits MaskedTextBox
    Private NavEnter As Boolean = True
    Private TipoDato As TiposDeDato = TiposDeDato.isDate
    Private TipoCampo As TiposDeCampo = TiposDeCampo.Personalizado
    Enum TiposDeCampo
        Undefined = 0
        Obligatorio = 1
        Opcional = 2
        Desplieque = 3
        Personalizado = 4
    End Enum
    Enum TiposDeDato
        Undefined = 0
        Personalizado = 1
        isDate = 2
    End Enum
    Public Property TipoDeDato() As TiposDeDato
        Get
            Return TipoDato
        End Get
        Set(ByVal value As TiposDeDato)
            set_TipoDato(value)
            TipoDato = value
        End Set
    End Property
    Private Sub set_TipoDato(ByVal Tipo As TiposDeDato)
        If Tipo = TiposDeDato.isDate Then
            Me.Mask = "00/00/0000"
        ElseIf Tipo = TiposDeCampo.Undefined Then
            Me.Mask = ""
        End If
    End Sub
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
            Return F_Null(Me.Text)
        End Get
    End Property
    Private Sub Set_TipoCampo(ByVal Tipo As TiposDeCampo)
        If Tipo = TiposDeCampo.Obligatorio Then
            Me.ReadOnly = False
            Me.BackColor = Color.LemonChiffon
        ElseIf Tipo = TiposDeCampo.Desplieque Then
            Me.ReadOnly = True
            Me.BackColor = Color.LightGreen
        ElseIf Tipo = TiposDeCampo.Opcional Then
            Me.ReadOnly = False
            Me.BackColor = Color.LightGray
        Else
            Me.ReadOnly = False
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub TextBoxED_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.SelectionStart = 0
        Me.SelectionLength = Len(Me.Text)
    End Sub

    Private Sub TextBoxED_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If NavegarConEnter Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub

    '''<summary>
    '''Verifica si el campo esta nulo
    '''</summary>
    Public Shared Function F_Null(ByVal xstring As String) As Boolean
        F_Null = True
        If xstring Is Nothing Then
            F_Null = True
        ElseIf Len(LTrim(RTrim(xstring))) = 0 Or
            xstring = "__/__/____" Or xstring = "__-___.___" _
            Or xstring = "__:__" Or xstring = "  /  /" _
            Or xstring = "  :  " Or xstring = "  :" _
            Or xstring = "  -  ." Or xstring = "  -  .  " Then
            F_Null = True
        Else
            F_Null = False
        End If
    End Function

    Private Sub MaskedTextBoxEd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        If TipoDeDato = TiposDeDato.isDate Then
            If Not F_Null(Me.Text) Then
                If Not IsDate(Me.Text) Then
                    MsgBox("La fecha ingresada no es valida", MsgBoxStyle.Information, "Mensaje de Sistema")
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Public Overrides Function ToString() As String
        If String.IsNullOrEmpty(Me.Text.Replace(Me.Culture.DateTimeFormat.DateSeparator, "").Replace(Me.Culture.DateTimeFormat.TimeSeparator, "").Trim) Then
            Return Nothing
        Else
            Return Me.Text
        End If
    End Function
End Class