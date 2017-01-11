<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBasePrestamosTecleo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New Library.TextBoxSD()
        Me.txtNombre = New Library.TextBoxSD()
        Me.txtNivelOrganizacional = New Library.TextBoxSD()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nivel Organizacional"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtValor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNivelOrganizacional)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 143)
        Me.Panel1.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.save_32
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(286, 98)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(86, 38)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Grabar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.AutoTrim = True
        Me.txtValor.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtValor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValor.BordesRedondeados = False
        Me.txtValor.CantidadDecimales = CType(2, Short)
        Me.txtValor.CantidadEnteros = CType(15, Short)
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(7, 110)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.NavegarConEnter = True
        Me.txtValor.NumeroDeDecimales = 0
        Me.txtValor.Size = New System.Drawing.Size(108, 26)
        Me.txtValor.TabIndex = 2
        Me.txtValor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtValor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtValor.ValidChars = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.AutoTrim = True
        Me.txtNombre.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombre.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombre.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombre.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombre.BordesRedondeados = False
        Me.txtNombre.CantidadDecimales = CType(2, Short)
        Me.txtNombre.CantidadEnteros = CType(15, Short)
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(7, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NavegarConEnter = True
        Me.txtNombre.NumeroDeDecimales = 0
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(365, 26)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombre.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombre.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombre.ValidChars = Nothing
        '
        'txtNivelOrganizacional
        '
        Me.txtNivelOrganizacional.AutoTrim = True
        Me.txtNivelOrganizacional.BackColor = System.Drawing.Color.LightGreen
        Me.txtNivelOrganizacional.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNivelOrganizacional.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNivelOrganizacional.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNivelOrganizacional.BordesRedondeados = False
        Me.txtNivelOrganizacional.CantidadDecimales = CType(2, Short)
        Me.txtNivelOrganizacional.CantidadEnteros = CType(15, Short)
        Me.txtNivelOrganizacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivelOrganizacional.Location = New System.Drawing.Point(7, 20)
        Me.txtNivelOrganizacional.Name = "txtNivelOrganizacional"
        Me.txtNivelOrganizacional.NavegarConEnter = True
        Me.txtNivelOrganizacional.NumeroDeDecimales = 0
        Me.txtNivelOrganizacional.ReadOnly = True
        Me.txtNivelOrganizacional.Size = New System.Drawing.Size(104, 26)
        Me.txtNivelOrganizacional.TabIndex = 0
        Me.txtNivelOrganizacional.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNivelOrganizacional.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNivelOrganizacional.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNivelOrganizacional.ValidChars = Nothing
        '
        'FrmBasePrestamosTecleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(387, 151)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmBasePrestamosTecleo"
        Me.Text = "FrmBasePrestamosTecleo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As Library.TextBoxSD
    Friend WithEvents txtNivelOrganizacional As Library.TextBoxSD
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtValor As Library.TextBoxSD
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
