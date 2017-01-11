<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContabilidadSolicitud
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
        Me.components = New System.ComponentModel.Container()
        Me.grbContabilidad = New System.Windows.Forms.GroupBox()
        Me.lblSaldoContabilidad = New System.Windows.Forms.Label()
        Me.cmdGrabarContabilidad = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNombreCuentaContabilidad = New System.Windows.Forms.Label()
        Me.txtValorContabilidad = New Library.TextBoxSD()
        Me.txtDescripcionContabilidad = New Library.TextBoxSD()
        Me.txtCuentaContableContabilidad = New Library.TextBoxSD()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbContabilidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbContabilidad
        '
        Me.grbContabilidad.BackColor = System.Drawing.Color.White
        Me.grbContabilidad.Controls.Add(Me.lblSaldoContabilidad)
        Me.grbContabilidad.Controls.Add(Me.cmdGrabarContabilidad)
        Me.grbContabilidad.Controls.Add(Me.Label7)
        Me.grbContabilidad.Controls.Add(Me.Label6)
        Me.grbContabilidad.Controls.Add(Me.Label5)
        Me.grbContabilidad.Controls.Add(Me.lblNombreCuentaContabilidad)
        Me.grbContabilidad.Controls.Add(Me.txtValorContabilidad)
        Me.grbContabilidad.Controls.Add(Me.txtDescripcionContabilidad)
        Me.grbContabilidad.Controls.Add(Me.txtCuentaContableContabilidad)
        Me.grbContabilidad.Location = New System.Drawing.Point(1, 2)
        Me.grbContabilidad.Name = "grbContabilidad"
        Me.grbContabilidad.Size = New System.Drawing.Size(391, 161)
        Me.grbContabilidad.TabIndex = 0
        Me.grbContabilidad.TabStop = False
        Me.grbContabilidad.Text = "Por Concepto De"
        '
        'lblSaldoContabilidad
        '
        Me.lblSaldoContabilidad.Location = New System.Drawing.Point(252, 7)
        Me.lblSaldoContabilidad.Name = "lblSaldoContabilidad"
        Me.lblSaldoContabilidad.Size = New System.Drawing.Size(126, 11)
        Me.lblSaldoContabilidad.TabIndex = 23
        Me.lblSaldoContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdGrabarContabilidad
        '
        Me.cmdGrabarContabilidad.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabarContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGrabarContabilidad.Location = New System.Drawing.Point(304, 72)
        Me.cmdGrabarContabilidad.Name = "cmdGrabarContabilidad"
        Me.cmdGrabarContabilidad.Size = New System.Drawing.Size(81, 80)
        Me.cmdGrabarContabilidad.TabIndex = 300
        Me.cmdGrabarContabilidad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Valor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cuenta Contable"
        '
        'lblNombreCuentaContabilidad
        '
        Me.lblNombreCuentaContabilidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreCuentaContabilidad.Location = New System.Drawing.Point(94, 28)
        Me.lblNombreCuentaContabilidad.Name = "lblNombreCuentaContabilidad"
        Me.lblNombreCuentaContabilidad.Size = New System.Drawing.Size(290, 20)
        Me.lblNombreCuentaContabilidad.TabIndex = 17
        '
        'txtValorContabilidad
        '
        Me.txtValorContabilidad.AutoTrim = True
        Me.txtValorContabilidad.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtValorContabilidad.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorContabilidad.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorContabilidad.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorContabilidad.BordesRedondeados = False
        Me.txtValorContabilidad.CantidadDecimales = CType(2, Short)
        Me.txtValorContabilidad.CantidadEnteros = CType(15, Short)
        Me.txtValorContabilidad.Location = New System.Drawing.Point(198, 132)
        Me.txtValorContabilidad.MaxLength = 15
        Me.txtValorContabilidad.Name = "txtValorContabilidad"
        Me.txtValorContabilidad.NavegarConEnter = True
        Me.txtValorContabilidad.NumeroDeDecimales = 0
        Me.txtValorContabilidad.Size = New System.Drawing.Size(100, 20)
        Me.txtValorContabilidad.TabIndex = 5
        Me.txtValorContabilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorContabilidad.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtValorContabilidad.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValorContabilidad.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValorContabilidad.ValidChars = Nothing
        '
        'txtDescripcionContabilidad
        '
        Me.txtDescripcionContabilidad.AutoTrim = True
        Me.txtDescripcionContabilidad.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDescripcionContabilidad.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDescripcionContabilidad.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDescripcionContabilidad.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDescripcionContabilidad.BordesRedondeados = False
        Me.txtDescripcionContabilidad.CantidadDecimales = CType(2, Short)
        Me.txtDescripcionContabilidad.CantidadEnteros = CType(15, Short)
        Me.txtDescripcionContabilidad.Location = New System.Drawing.Point(13, 72)
        Me.txtDescripcionContabilidad.MaxLength = 100
        Me.txtDescripcionContabilidad.Multiline = True
        Me.txtDescripcionContabilidad.Name = "txtDescripcionContabilidad"
        Me.txtDescripcionContabilidad.NavegarConEnter = True
        Me.txtDescripcionContabilidad.NumeroDeDecimales = 0
        Me.txtDescripcionContabilidad.Size = New System.Drawing.Size(285, 58)
        Me.txtDescripcionContabilidad.TabIndex = 4
        Me.txtDescripcionContabilidad.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtDescripcionContabilidad.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDescripcionContabilidad.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDescripcionContabilidad.ValidChars = Nothing
        '
        'txtCuentaContableContabilidad
        '
        Me.txtCuentaContableContabilidad.AutoTrim = True
        Me.txtCuentaContableContabilidad.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuentaContableContabilidad.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtCuentaContableContabilidad.BordeNormal = System.Drawing.Color.DimGray
        Me.txtCuentaContableContabilidad.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtCuentaContableContabilidad.BordesRedondeados = False
        Me.txtCuentaContableContabilidad.CantidadDecimales = CType(2, Short)
        Me.txtCuentaContableContabilidad.CantidadEnteros = CType(15, Short)
        Me.txtCuentaContableContabilidad.Location = New System.Drawing.Point(13, 28)
        Me.txtCuentaContableContabilidad.MaxLength = 5
        Me.txtCuentaContableContabilidad.Name = "txtCuentaContableContabilidad"
        Me.txtCuentaContableContabilidad.NavegarConEnter = True
        Me.txtCuentaContableContabilidad.NumeroDeDecimales = 0
        Me.txtCuentaContableContabilidad.Size = New System.Drawing.Size(78, 20)
        Me.txtCuentaContableContabilidad.TabIndex = 3
        Me.txtCuentaContableContabilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCuentaContableContabilidad.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtCuentaContableContabilidad.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtCuentaContableContabilidad.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtCuentaContableContabilidad.ValidChars = Nothing
        '
        'FrmContabilidadSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 165)
        Me.Controls.Add(Me.grbContabilidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmContabilidadSolicitud"
        Me.Text = "FrmContabilidadSolicitud"
        Me.grbContabilidad.ResumeLayout(False)
        Me.grbContabilidad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbContabilidad As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGrabarContabilidad As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNombreCuentaContabilidad As System.Windows.Forms.Label
    Friend WithEvents txtValorContabilidad As Library.TextBoxSD
    Friend WithEvents txtDescripcionContabilidad As Library.TextBoxSD
    Friend WithEvents txtCuentaContableContabilidad As Library.TextBoxSD
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblSaldoContabilidad As System.Windows.Forms.Label
End Class
