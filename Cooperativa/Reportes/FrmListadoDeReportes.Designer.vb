<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoDeReportes
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.grdListadoDeReportes = New System.Windows.Forms.DataGridView()
      Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TextBoxSD3 = New Library.TextBoxSD()
      Me.TextBoxSD2 = New Library.TextBoxSD()
      Me.TextBoxSD1 = New Library.TextBoxSD()
      CType(Me.grdListadoDeReportes, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'grdListadoDeReportes
      '
      Me.grdListadoDeReportes.AllowUserToAddRows = False
      Me.grdListadoDeReportes.AllowUserToDeleteRows = False
      Me.grdListadoDeReportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grdListadoDeReportes.BorderStyle = System.Windows.Forms.BorderStyle.None
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.grdListadoDeReportes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.grdListadoDeReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.grdListadoDeReportes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Descripcion, Me.Archivo})
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.grdListadoDeReportes.DefaultCellStyle = DataGridViewCellStyle2
      Me.grdListadoDeReportes.Location = New System.Drawing.Point(2, 56)
      Me.grdListadoDeReportes.MultiSelect = False
      Me.grdListadoDeReportes.Name = "grdListadoDeReportes"
      Me.grdListadoDeReportes.ReadOnly = True
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.grdListadoDeReportes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
      Me.grdListadoDeReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.grdListadoDeReportes.Size = New System.Drawing.Size(784, 321)
      Me.grdListadoDeReportes.TabIndex = 0
      '
      'Codigo
      '
      Me.Codigo.DataPropertyName = "IDReporte"
      Me.Codigo.HeaderText = "Código"
      Me.Codigo.Name = "Codigo"
      Me.Codigo.ReadOnly = True
      '
      'Nombre
      '
      Me.Nombre.DataPropertyName = "Nombre"
      Me.Nombre.HeaderText = "Nombre"
      Me.Nombre.Name = "Nombre"
      Me.Nombre.ReadOnly = True
      Me.Nombre.Width = 300
      '
      'Descripcion
      '
      Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      Me.Descripcion.DataPropertyName = "Resumen"
      Me.Descripcion.HeaderText = "Descripción"
      Me.Descripcion.Name = "Descripcion"
      Me.Descripcion.ReadOnly = True
      '
      'Archivo
      '
      Me.Archivo.DataPropertyName = "Archivo"
      Me.Archivo.HeaderText = "Archivo"
      Me.Archivo.Name = "Archivo"
      Me.Archivo.ReadOnly = True
      Me.Archivo.Visible = False
      '
      'Panel1
      '
      Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel1.BackColor = System.Drawing.SystemColors.Control
      Me.Panel1.Controls.Add(Me.Button1)
      Me.Panel1.Controls.Add(Me.Label3)
      Me.Panel1.Controls.Add(Me.Label2)
      Me.Panel1.Controls.Add(Me.Label1)
      Me.Panel1.Controls.Add(Me.TextBoxSD3)
      Me.Panel1.Controls.Add(Me.TextBoxSD2)
      Me.Panel1.Controls.Add(Me.TextBoxSD1)
      Me.Panel1.Location = New System.Drawing.Point(2, 2)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(784, 53)
      Me.Panel1.TabIndex = 1
      '
      'Button1
      '
      Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button1.Location = New System.Drawing.Point(624, 10)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(100, 36)
      Me.Button1.TabIndex = 4
      Me.Button1.Text = "Buscar"
      Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(358, 7)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(63, 13)
      Me.Label3.TabIndex = 3
      Me.Label3.Text = "Descripción"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(93, 7)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(47, 13)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Nombre:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(8, 7)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(43, 13)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "Código:"
      '
      'TextBoxSD3
      '
      Me.TextBoxSD3.AutoTrim = True
      Me.TextBoxSD3.BackColor = System.Drawing.Color.White
      Me.TextBoxSD3.BordeDisable = System.Drawing.Color.DarkGray
      Me.TextBoxSD3.BordeNormal = System.Drawing.Color.DimGray
      Me.TextBoxSD3.BordeOnFocus = System.Drawing.Color.Blue
      Me.TextBoxSD3.BordesRedondeados = False
      Me.TextBoxSD3.CantidadDecimales = CType(2, Short)
      Me.TextBoxSD3.CantidadEnteros = CType(15, Short)
      Me.TextBoxSD3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TextBoxSD3.Location = New System.Drawing.Point(358, 23)
      Me.TextBoxSD3.Name = "TextBoxSD3"
      Me.TextBoxSD3.NavegarConEnter = True
      Me.TextBoxSD3.NumeroDeDecimales = 0
      Me.TextBoxSD3.Size = New System.Drawing.Size(262, 23)
      Me.TextBoxSD3.TabIndex = 2
      Me.TextBoxSD3.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Personalizado
      Me.TextBoxSD3.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
      Me.TextBoxSD3.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
      Me.TextBoxSD3.ValidChars = Nothing
      '
      'TextBoxSD2
      '
      Me.TextBoxSD2.AutoTrim = True
      Me.TextBoxSD2.BackColor = System.Drawing.Color.White
      Me.TextBoxSD2.BordeDisable = System.Drawing.Color.DarkGray
      Me.TextBoxSD2.BordeNormal = System.Drawing.Color.DimGray
      Me.TextBoxSD2.BordeOnFocus = System.Drawing.Color.Blue
      Me.TextBoxSD2.BordesRedondeados = False
      Me.TextBoxSD2.CantidadDecimales = CType(2, Short)
      Me.TextBoxSD2.CantidadEnteros = CType(15, Short)
      Me.TextBoxSD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TextBoxSD2.Location = New System.Drawing.Point(93, 23)
      Me.TextBoxSD2.Name = "TextBoxSD2"
      Me.TextBoxSD2.NavegarConEnter = True
      Me.TextBoxSD2.NumeroDeDecimales = 0
      Me.TextBoxSD2.Size = New System.Drawing.Size(262, 23)
      Me.TextBoxSD2.TabIndex = 1
      Me.TextBoxSD2.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Personalizado
      Me.TextBoxSD2.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
      Me.TextBoxSD2.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
      Me.TextBoxSD2.ValidChars = Nothing
      '
      'TextBoxSD1
      '
      Me.TextBoxSD1.AutoTrim = True
      Me.TextBoxSD1.BackColor = System.Drawing.Color.White
      Me.TextBoxSD1.BordeDisable = System.Drawing.Color.DarkGray
      Me.TextBoxSD1.BordeNormal = System.Drawing.Color.DimGray
      Me.TextBoxSD1.BordeOnFocus = System.Drawing.Color.Blue
      Me.TextBoxSD1.BordesRedondeados = False
      Me.TextBoxSD1.CantidadDecimales = CType(2, Short)
      Me.TextBoxSD1.CantidadEnteros = CType(15, Short)
      Me.TextBoxSD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TextBoxSD1.Location = New System.Drawing.Point(8, 23)
      Me.TextBoxSD1.Name = "TextBoxSD1"
      Me.TextBoxSD1.NavegarConEnter = True
      Me.TextBoxSD1.NumeroDeDecimales = 0
      Me.TextBoxSD1.Size = New System.Drawing.Size(82, 23)
      Me.TextBoxSD1.TabIndex = 0
      Me.TextBoxSD1.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Personalizado
      Me.TextBoxSD1.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
      Me.TextBoxSD1.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
      Me.TextBoxSD1.ValidChars = Nothing
      '
      'FrmListadoDeReportes
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.Highlight
      Me.ClientSize = New System.Drawing.Size(788, 379)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.grdListadoDeReportes)
      Me.Name = "FrmListadoDeReportes"
      Me.Text = "FrmListadoDeReportes"
      CType(Me.grdListadoDeReportes, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents grdListadoDeReportes As System.Windows.Forms.DataGridView
   Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Archivo As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TextBoxSD3 As Library.TextBoxSD
   Friend WithEvents TextBoxSD2 As Library.TextBoxSD
   Friend WithEvents TextBoxSD1 As Library.TextBoxSD
   Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
