<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSociosCuotas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNumeroDeEmpleado = New Library.TextBoxSD()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboRetenciones = New System.Windows.Forms.ComboBox()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.NumeroDeEmpleadoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetencionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuGrabar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTipoDePlailla = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumeroDeEmpleado
        '
        Me.txtNumeroDeEmpleado.AutoTrim = True
        Me.txtNumeroDeEmpleado.BackColor = System.Drawing.Color.LightGray
        Me.txtNumeroDeEmpleado.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNumeroDeEmpleado.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNumeroDeEmpleado.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNumeroDeEmpleado.BordesRedondeados = False
        Me.txtNumeroDeEmpleado.CantidadDecimales = CType(2, Short)
        Me.txtNumeroDeEmpleado.CantidadEnteros = CType(15, Short)
        Me.txtNumeroDeEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(3, 22)
        Me.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado"
        Me.txtNumeroDeEmpleado.NavegarConEnter = True
        Me.txtNumeroDeEmpleado.NumeroDeDecimales = 0
        Me.txtNumeroDeEmpleado.Size = New System.Drawing.Size(100, 26)
        Me.txtNumeroDeEmpleado.TabIndex = 0
        Me.txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNumeroDeEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNumeroDeEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNumeroDeEmpleado.ValidChars = Nothing
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboTipoDePlailla)
        Me.Panel1.Controls.Add(Me.cboRetenciones)
        Me.Panel1.Controls.Add(Me.grdDatos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnVer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 481)
        Me.Panel1.TabIndex = 1
        '
        'cboRetenciones
        '
        Me.cboRetenciones.BackColor = System.Drawing.Color.LightGray
        Me.cboRetenciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRetenciones.FormattingEnabled = True
        Me.cboRetenciones.Location = New System.Drawing.Point(106, 22)
        Me.cboRetenciones.Name = "cboRetenciones"
        Me.cboRetenciones.Size = New System.Drawing.Size(244, 28)
        Me.cboRetenciones.TabIndex = 4
        '
        'grdDatos
        '
        Me.grdDatos.AllowUserToAddRows = False
        Me.grdDatos.AllowUserToDeleteRows = False
        Me.grdDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDatos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDeEmpleadoColumn, Me.FechaColumn, Me.RetencionColumn, Me.FechaFinal, Me.DescripcionColumn, Me.ObservacionesColumn, Me.CapitalColumn, Me.InteresesColumn, Me.ValorColumn})
        Me.grdDatos.ContextMenuStrip = Me.mnuOpciones
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDatos.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdDatos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grdDatos.Location = New System.Drawing.Point(3, 52)
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdDatos.RowHeadersWidth = 25
        Me.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDatos.Size = New System.Drawing.Size(1045, 424)
        Me.grdDatos.TabIndex = 3
        '
        'NumeroDeEmpleadoColumn
        '
        Me.NumeroDeEmpleadoColumn.DataPropertyName = "NumeroDeEmpleado"
        Me.NumeroDeEmpleadoColumn.HeaderText = "Numero de Empleado"
        Me.NumeroDeEmpleadoColumn.Name = "NumeroDeEmpleadoColumn"
        Me.NumeroDeEmpleadoColumn.ReadOnly = True
        Me.NumeroDeEmpleadoColumn.Width = 300
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Format = "d"
        Me.FechaColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        Me.FechaColumn.Width = 90
        '
        'RetencionColumn
        '
        Me.RetencionColumn.DataPropertyName = "Retencion"
        Me.RetencionColumn.HeaderText = "Retencion"
        Me.RetencionColumn.Name = "RetencionColumn"
        Me.RetencionColumn.ReadOnly = True
        Me.RetencionColumn.Width = 200
        '
        'FechaFinal
        '
        Me.FechaFinal.DataPropertyName = "FechaFinal"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaFinal.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaFinal.HeaderText = "Fecha Final"
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.ReadOnly = True
        Me.FechaFinal.Width = 90
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "Descripcion"
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        Me.DescripcionColumn.Width = 120
        '
        'ObservacionesColumn
        '
        Me.ObservacionesColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesColumn.HeaderText = "Observaciones"
        Me.ObservacionesColumn.Name = "ObservacionesColumn"
        Me.ObservacionesColumn.ReadOnly = True
        Me.ObservacionesColumn.Width = 120
        '
        'CapitalColumn
        '
        Me.CapitalColumn.DataPropertyName = "Capital"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CapitalColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CapitalColumn.HeaderText = "Capital"
        Me.CapitalColumn.Name = "CapitalColumn"
        Me.CapitalColumn.ReadOnly = True
        Me.CapitalColumn.Width = 70
        '
        'InteresesColumn
        '
        Me.InteresesColumn.DataPropertyName = "Intereses"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.InteresesColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.InteresesColumn.HeaderText = "Intereses"
        Me.InteresesColumn.Name = "InteresesColumn"
        Me.InteresesColumn.ReadOnly = True
        Me.InteresesColumn.Width = 70
        '
        'ValorColumn
        '
        Me.ValorColumn.DataPropertyName = "Valor"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ValorColumn.HeaderText = "Valor"
        Me.ValorColumn.Name = "ValorColumn"
        Me.ValorColumn.ReadOnly = True
        Me.ValorColumn.Width = 70
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGrabar, Me.mnuModificar, Me.mnuEliminar, Me.ToolStripSeparator1, Me.mnuConsultar})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(126, 98)
        '
        'mnuGrabar
        '
        Me.mnuGrabar.Image = Global.Cooperativa.My.Resources.Resources.plainicon_com_49341_32px_ef2
        Me.mnuGrabar.Name = "mnuGrabar"
        Me.mnuGrabar.Size = New System.Drawing.Size(125, 22)
        Me.mnuGrabar.Text = "Grabar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Image = Global.Cooperativa.My.Resources.Resources.glyphicons_081_refresh
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.Size = New System.Drawing.Size(125, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Image = Global.Cooperativa.My.Resources.Resources.images
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(125, 22)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(122, 6)
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Image = Global.Cooperativa.My.Resources.Resources._32
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.Size = New System.Drawing.Size(125, 22)
        Me.mnuConsultar.Text = "Consultar"
        '
        'btnVer
        '
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.Image = Global.Cooperativa.My.Resources.Resources.exclamationmark
        Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVer.Location = New System.Drawing.Point(957, 10)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(86, 40)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "Cuotas"
        Me.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Retención:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. de Empleado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo de Planilla:"
        Me.Label3.Visible = False
        '
        'cboTipoDePlailla
        '
        Me.cboTipoDePlailla.BackColor = System.Drawing.Color.LightGray
        Me.cboTipoDePlailla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDePlailla.FormattingEnabled = True
        Me.cboTipoDePlailla.Location = New System.Drawing.Point(353, 22)
        Me.cboTipoDePlailla.Name = "cboTipoDePlailla"
        Me.cboTipoDePlailla.Size = New System.Drawing.Size(244, 28)
        Me.cboTipoDePlailla.TabIndex = 4
        Me.cboTipoDePlailla.Visible = False
        '
        'FrmSociosCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSociosCuotas"
        Me.Text = "FrmSociosCuotas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNumeroDeEmpleado As Library.TextBoxSD
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents grdDatos As System.Windows.Forms.DataGridView
    Friend WithEvents NumeroDeEmpleadoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetencionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapitalColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InteresesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboRetenciones As System.Windows.Forms.ComboBox
    Friend WithEvents mnuOpciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuGrabar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDePlailla As System.Windows.Forms.ComboBox
End Class
