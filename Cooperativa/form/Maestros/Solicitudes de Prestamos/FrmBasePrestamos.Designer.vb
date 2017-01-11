<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBasePrestamos
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
        Me.grdNivelesOrganizacionales = New System.Windows.Forms.DataGridView()
        Me.mnuOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New Library.TextBoxSD()
        Me.txtNivelOrganizacional = New Library.TextBoxSD()
        Me.NivelOrganizacionalColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorBasePrestamoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermanenteColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.grdNivelesOrganizacionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOpciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdNivelesOrganizacionales
        '
        Me.grdNivelesOrganizacionales.AllowUserToAddRows = False
        Me.grdNivelesOrganizacionales.AllowUserToDeleteRows = False
        Me.grdNivelesOrganizacionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdNivelesOrganizacionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNivelesOrganizacionales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NivelOrganizacionalColumn, Me.NombreColumn, Me.ValorBasePrestamoColumn, Me.PermanenteColumn})
        Me.grdNivelesOrganizacionales.ContextMenuStrip = Me.mnuOpciones
        Me.grdNivelesOrganizacionales.Location = New System.Drawing.Point(2, 60)
        Me.grdNivelesOrganizacionales.Name = "grdNivelesOrganizacionales"
        Me.grdNivelesOrganizacionales.ReadOnly = True
        Me.grdNivelesOrganizacionales.RowHeadersWidth = 26
        Me.grdNivelesOrganizacionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdNivelesOrganizacionales.Size = New System.Drawing.Size(543, 265)
        Me.grdNivelesOrganizacionales.TabIndex = 0
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(167, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtNivelOrganizacional)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 57)
        Me.Panel1.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.SearchTwo
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(463, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 36)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nivel Organizacional"
        '
        'txtNombre
        '
        Me.txtNombre.AutoTrim = True
        Me.txtNombre.BackColor = System.Drawing.Color.LightGray
        Me.txtNombre.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombre.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombre.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombre.BordesRedondeados = False
        Me.txtNombre.CantidadDecimales = CType(2, Short)
        Me.txtNombre.CantidadEnteros = CType(15, Short)
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(110, 23)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NavegarConEnter = True
        Me.txtNombre.NumeroDeDecimales = 0
        Me.txtNombre.Size = New System.Drawing.Size(347, 26)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNombre.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombre.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombre.ValidChars = Nothing
        '
        'txtNivelOrganizacional
        '
        Me.txtNivelOrganizacional.AutoTrim = True
        Me.txtNivelOrganizacional.BackColor = System.Drawing.Color.LightGray
        Me.txtNivelOrganizacional.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNivelOrganizacional.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNivelOrganizacional.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNivelOrganizacional.BordesRedondeados = False
        Me.txtNivelOrganizacional.CantidadDecimales = CType(2, Short)
        Me.txtNivelOrganizacional.CantidadEnteros = CType(15, Short)
        Me.txtNivelOrganizacional.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivelOrganizacional.Location = New System.Drawing.Point(3, 23)
        Me.txtNivelOrganizacional.Name = "txtNivelOrganizacional"
        Me.txtNivelOrganizacional.NavegarConEnter = True
        Me.txtNivelOrganizacional.NumeroDeDecimales = 0
        Me.txtNivelOrganizacional.Size = New System.Drawing.Size(104, 26)
        Me.txtNivelOrganizacional.TabIndex = 0
        Me.txtNivelOrganizacional.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNivelOrganizacional.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNivelOrganizacional.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNivelOrganizacional.ValidChars = Nothing
        '
        'NivelOrganizacionalColumn
        '
        Me.NivelOrganizacionalColumn.DataPropertyName = "NivelOrganizacional"
        Me.NivelOrganizacionalColumn.HeaderText = "Nivel Organizacional"
        Me.NivelOrganizacionalColumn.Name = "NivelOrganizacionalColumn"
        Me.NivelOrganizacionalColumn.ReadOnly = True
        Me.NivelOrganizacionalColumn.Width = 80
        '
        'NombreColumn
        '
        Me.NombreColumn.DataPropertyName = "Nombre"
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.ReadOnly = True
        Me.NombreColumn.Width = 200
        '
        'ValorBasePrestamoColumn
        '
        Me.ValorBasePrestamoColumn.DataPropertyName = "ValorBasePrestamo"
        Me.ValorBasePrestamoColumn.HeaderText = "Valor Base Prestamo"
        Me.ValorBasePrestamoColumn.Name = "ValorBasePrestamoColumn"
        Me.ValorBasePrestamoColumn.ReadOnly = True
        Me.ValorBasePrestamoColumn.Width = 150
        '
        'PermanenteColumn
        '
        Me.PermanenteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PermanenteColumn.DataPropertyName = "Permanente"
        Me.PermanenteColumn.HeaderText = "Permanente"
        Me.PermanenteColumn.Name = "PermanenteColumn"
        Me.PermanenteColumn.ReadOnly = True
        Me.PermanenteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PermanenteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FrmBasePrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(547, 327)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdNivelesOrganizacionales)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FrmBasePrestamos"
        Me.Text = "FrmBasePrestamos"
        CType(Me.grdNivelesOrganizacionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOpciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdNivelesOrganizacionales As System.Windows.Forms.DataGridView
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNivelOrganizacional As Library.TextBoxSD
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtNombre As Library.TextBoxSD
   Friend WithEvents btnBuscar As System.Windows.Forms.Button

    Friend WithEvents mnuOpciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NivelOrganizacionalColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorBasePrestamoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermanenteColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
