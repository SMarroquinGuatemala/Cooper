Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

<ToolboxBitmap("C:\Sistemas San Diego\TextBoxEd\TextBoxEd\TextBoxEd\TxtEd.bmp")> _
Public Class TextBoxSD
    Inherits TextBox
    Private NavEnter As Boolean = True
    Private _Decimales As Integer = 0
    Private _BordesRedondeados As Boolean = False
    Private TipoCampo As TiposDeCampo = TiposDeCampo.Personalizado
    Private _TiposDeFormato As Formato = Formato.Undefined
    Private Trim As Boolean = True
    Private _TipoFiltro As Filtro = Filtro.Indefinido
    Private _CaracteresValidos As String
    Private state As states = states.normal

    Private WithEvents Timer As Timer = New Timer
    Private mLeavingEventlist As ArrayList
    Declare Function GetWindowDC Lib "user32" (ByVal hwnd As IntPtr) As IntPtr
    Declare Function ReleaseDC Lib "user32.dll" _
       (ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer
    Dim BorderPen As Pen
    Dim ArrowBrush, ButtonBrush, TextBrush As Brush
    Dim MainRect As Rectangle
    Dim pointArrow(2) As PointF
    Dim VerticalMiddle As Integer
    Dim ArrowPath As GraphicsPath = New GraphicsPath
    Dim TxtLoc As PointF

    Private _OriText As String = ""
    Private _NewText As String = ""
    Private _Texthaschanged As Boolean = False
    Private _bcfocused As Color = Color.Blue
    Private _bcdisabled As Color = Color.DarkGray
    Private _bcnormal As Color = Color.DimGray
    Private _CantidadDecimales As Int16 = 2
    Private _CantidadEnteros As Int16 = 15

    Public Property CantidadEnteros As Int16
        Get
            Return _CantidadEnteros
        End Get
        Set(value As Int16)
            _CantidadEnteros = value
        End Set
    End Property

    Public Property CantidadDecimales As Int16
        Get
            Return _CantidadDecimales
        End Get
        Set(value As Int16)
            _CantidadDecimales = value
        End Set
    End Property



    Public Property BordeOnFocus As Color
        Get
            Return _bcfocused
        End Get
        Set(ByVal value As Color)
            _bcfocused = value
        End Set
    End Property
    Public Property BordeDisable As Color
        Get
            Return _bcdisabled
        End Get
        Set(ByVal value As Color)
            _bcdisabled = value
        End Set
    End Property

    Public Property BordeNormal As Color
        Get
            Return _bcnormal
        End Get
        Set(ByVal value As Color)
            _bcnormal = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub



    Enum states
        normal
        focused
        disabled
    End Enum

    Enum Formato
        Undefined = 0
        Numero = 1
        Moneda = 2
        Texto = 3
        TipoTitulo = 4
    End Enum
    Enum Filtro
        Indefinido = 0
        Numeros = 1
        NumeroDecimal = 2
        NumerosYLetras = 3
    End Enum
    Public Property BordesRedondeados As Boolean
        Get
            Return _BordesRedondeados
        End Get
        Set(ByVal value As Boolean)
            _BordesRedondeados = value
        End Set
    End Property

    <Category("Pimp Properties"), DefaultValue(GetType(System.String), "Indefinido"), _
    Description("Filtra el tipo de caracteres que se desea escribir en el TextBox")>
    Public Property TiposFiltro() As Filtro
        Get
            Return _TipoFiltro
        End Get
        Set(ByVal value As Filtro)
            _TipoFiltro = value
        End Set
    End Property
    <Category("Behavior"), Description("Escriba los caracteres que necesita que se pueda escribir dentro del Textbox. Valido solo para el tipo de filtro NumerosYLetras")>
    Public Property ValidChars() As String
        Get
            Return _CaracteresValidos
        End Get
        Set(ByVal value As String)
            _CaracteresValidos = value
        End Set
    End Property
    <Category("Behavior"), Description("No usar esta propiedad. utilice la propiedad TiposFiltro.  Esta propiedad puede ser util con la opcion TipoTitulo")>
    Public Property TiposDeFormato() As Formato
        Get
            Return _TiposDeFormato
        End Get
        Set(ByVal value As Formato)
            Set_TipoFormato(value)
            _TiposDeFormato = value

        End Set
    End Property
    Public Property AutoTrim() As Boolean
        Get
            Return Trim
        End Get
        Set(ByVal value As Boolean)
            Trim = value
        End Set
    End Property

    Public Property NumeroDeDecimales() As Integer
        Get
            Return _Decimales
        End Get
        Set(ByVal value As Integer)
            If Not value < 0 And Not value > 10 Then
                _Decimales = value
            End If
        End Set
    End Property


    Private Function Set_TipoFormato(ByVal Formatos As Formato) As Boolean
        Set_TipoFormato = True
        If Not Me.isNull Then
            If Formatos = Formato.Numero Then
                If IsNumeric(Me.Text) Then
                    Me.Text = FormatNumber(Me.Text, _Decimales)
                    Return True
                Else
                    MsgBox("Los datos ingresados no son validos, debe de ingresar numeros")
                    Return False
                End If
            End If
            If Formatos = Formato.Moneda Then
                If IsNumeric(Me.Text) Then
                    Me.Text = Replace(Replace(FormatCurrency(Me.Text, 2, , TriState.False), "Q", ""), "$", "")
                    Return True
                Else
                    MsgBox("Los datos ingresados no son validos, debe de ingresar numeros")
                    Return False
                End If
            End If
            If Formatos = Formato.TipoTitulo Then
                Me.Text = StrConv(Me.Text, VbStrConv.ProperCase)
                Return True
            End If
        End If
    End Function
    ''' <summary>
    ''' filtra los caracteres que pueden ser escritos. dependiendo el tipo de filtro seleccionado. 
    ''' (Numeros, NumeroDecimal, NumerosYLetras + caracteres ingresados por el usuario en la Propiedad ValidChar.)
    ''' </summary>
    ''' <param name="x"></param>
    ''' <remarks></remarks>
    Public Sub Set_TipoFiltro(ByVal x As System.Windows.Forms.KeyPressEventArgs)
        Select Case TiposFiltro
            Case Filtro.Numeros
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
            Case Filtro.NumeroDecimal
                If x.KeyChar = ChrW(Keys.Enter) Then
                    x.Handled = False
                ElseIf Char.IsSeparator(x.KeyChar) Then
                    x.Handled = False
                ElseIf Char.IsControl(x.KeyChar) Then
                    x.Handled = False
                ElseIf Char.IsNumber(x.KeyChar) Then
                    x.Handled = False
                ElseIf x.KeyChar = "-" Then
                    If Me.Text.Contains("-") Then
                        x.Handled = True
                    Else
                        x.Handled = False
                    End If
                ElseIf x.KeyChar = "." Then
                    If Me.Text.Contains(".") Then
                        x.Handled = True
                    Else
                        x.Handled = False
                    End If
                Else
                    x.Handled = True
                End If
            Case Filtro.NumerosYLetras
                If x.KeyChar = ChrW(Keys.Enter) Then
                    x.Handled = False
                ElseIf Char.IsSeparator(x.KeyChar) Then
                    x.Handled = False
                ElseIf Char.IsControl(x.KeyChar) Then
                    x.Handled = False
                ElseIf Char.IsLetter(x.KeyChar) Then
                    x.Handled = False
                ElseIf Char.IsNumber(x.KeyChar) Then
                    x.Handled = False
                ElseIf Not ValidChars Is Nothing Then
                    x.Handled = Not ValidChars.Contains(x.KeyChar)
                Else
                    x.Handled = True
                End If
        End Select

    End Sub



    Enum TiposDeCampo
        Indefinido = 0
        Obligatorio = 1
        Opcional = 2
        Desplieque = 3
        Personalizado = 4
    End Enum

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
        'se valida el tipo de filtro seleccionado por el usuario.
        Set_TipoFiltro(e)
    End Sub

    Public Shared Function F_Null(ByVal xstring As String) As Boolean
        F_Null = True
        If xstring Is Nothing Then
            F_Null = True
        ElseIf Len(LTrim(RTrim(xstring))) = 0 Or xstring = "__/__/____" Or xstring = "__-___.___" Or xstring = "__:__" Or xstring = "  /  /" Then
            F_Null = True
        Else
            F_Null = False
        End If
    End Function

    Private Sub TextBoxEd_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
        If AutoTrim Then Microsoft.VisualBasic.Trim(Me.Text)
        e.Cancel = Not Set_TipoFormato(TiposDeFormato)
        If Not e.Cancel AndAlso Me.TiposFiltro = Filtro.NumeroDecimal AndAlso Not F_Null(Me.Text) Then
            Me.Text = F_Format(Me.Text)
        End If
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
        yString = yString.Replace(",", "")
        If Len(yString.Trim) = 0 Then
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
        F_Format = Val(yString).ToString(xFormat)
    End Function

    '------------Rounded corners


    Private Sub TekenRondeRechthoek(ByVal g As Graphics, ByVal pen As Pen, ByVal rectangle As Rectangle, ByVal radius As Single)
        Dim size As Single = (radius * 2.0!)
        Dim gp As GraphicsPath = New GraphicsPath
        gp.AddArc(rectangle.X, rectangle.Y, size, size, 180, 90)
        gp.AddArc((rectangle.X _
                        + (rectangle.Width - size)), rectangle.Y, size, size, 270, 90)
        gp.AddArc((rectangle.X _
                        + (rectangle.Width - size)), (rectangle.Y _
                        + (rectangle.Height - size)), size, size, 0, 90)
        gp.AddArc(rectangle.X, (rectangle.Y _
                        + (rectangle.Height - size)), size, size, 90, 90)
        gp.CloseFigure()
        gp.FillMode = System.Drawing.Drawing2D.FillMode.Winding
        g.DrawPath(pen, gp)
        gp.Dispose()
    End Sub

    Private Sub DrawBorder(ByVal g As Graphics)
        MainRect = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Select Case state
            Case states.focused
                BorderPen = New Pen(BordeOnFocus)
            Case states.disabled
                BorderPen = New Pen(BordeDisable)
            Case states.normal
                BorderPen = New Pen(BordeNormal)
            Case Else
                Exit Sub
        End Select
        TekenRondeRechthoek(g, BorderPen, MainRect, 3.0!)

    End Sub

    Private Sub DrawText(ByVal g As Graphics)
        Dim text As String = ""
        Select Case state
            Case states.normal, states.focused
                TextBrush = New SolidBrush(Me.ForeColor)
            Case states.disabled
                TextBrush = New SolidBrush(Color.DarkGray)
        End Select
        If g.MeasureString(Me.Text, Me.Font).Width > Me.Width - 30 Then
            Dim i As Integer = -1
            Do
                i += 1
                If g.MeasureString(text, Me.Font).Width > Me.Width - 30 Then Exit Do
                text &= Me.Text.Substring(i, 1)
            Loop
        Else
            text = Me.Text
        End If
        If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
            TxtLoc = New PointF(1, 4)
        Else
            Dim temp As Single = Me.Width - (g.MeasureString(text, Me.Font).Width)
            TxtLoc = New PointF(temp, 4)
        End If
        g.DrawString(text, Me.Font, TextBrush, TxtLoc)
    End Sub

    Public Custom Event BijLeaving As EventHandler
        AddHandler(ByVal value As EventHandler)
            If mLeavingEventlist Is Nothing Then
                mLeavingEventlist = New ArrayList
            End If
            mLeavingEventlist.Add(value)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
            mLeavingEventlist.Remove(value)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal ea As EventArgs)
            If mLeavingEventlist IsNot Nothing Then
                For Each handler As EventHandler In mLeavingEventlist
                    If handler IsNot Nothing Then
                        handler.BeginInvoke(sender, ea, Nothing, Nothing)
                    End If
                Next
            End If
        End RaiseEvent
    End Event


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        MyBase.WndProc(m)
        If Not BordesRedondeados Then Exit Sub
        Select Case m.Msg

            Case &HF
                'WM_PAINT
                Dim rect As New Rectangle(0, 0, MyBase.Width, MyBase.Height)

                Dim hDC As IntPtr = GetWindowDC(Me.Handle)
                Dim g As Graphics = Graphics.FromHdc(hDC)
                If Me.Enabled Then
                    g.Clear(Me.BackColor)
                Else
                    g.Clear(Color.FromName("control"))
                End If
                DrawBorder(g)
                DrawText(g)
                ReleaseDC(Me.Handle, hDC)
                g.Dispose()

            Case &H7, &H8, &H200, &H2A3
                'CMB_DROPDOWN, CMB_CLOSEUP, WM_SETFOCUS, 
                'WM_KILLFOCUS, WM_MOUSEMOVE,  
                'WM_MOUSELEAVE (if you move the mouse fast over
                'the combobox, mouseleave doesn't always react)

                UpdateState()

        End Select

    End Sub


    Private Sub Enabled_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        UpdateState()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        UpdateState()
    End Sub

    Private Sub UpdateState()
        'save the current state
        Dim temp As states = state
        '
        If Me.Enabled Then
            If ClientRectangle.Contains(PointToClient(Control.MousePosition)) Then
                Me.state = states.focused
            ElseIf Me.Focused Then
                Me.state = states.focused
            Else
                Me.state = states.normal
            End If
        Else
            Me.state = states.disabled
        End If

        If state <> temp Then
            Me.Invalidate()
        End If
    End Sub

    '--------------------------
    Public Overrides Function ToString() As String
        If String.IsNullOrEmpty(Me.Text.Trim) Then
            Return Nothing
        Else
            Return Me.Text
        End If
    End Function

End Class




