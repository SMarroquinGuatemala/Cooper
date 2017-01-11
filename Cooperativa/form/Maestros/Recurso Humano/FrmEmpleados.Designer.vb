<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.NumeroDeEmpleadoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicialColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuGrabar = New System.Windows.Forms.ToolStripMenuItem()
        Me.muModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechaInicial = New Library.MaskedTextBoxSD()
        Me.txtApellidos = New Library.TextBoxSD()
        Me.txtNombres = New Library.TextBoxSD()
        Me.txtNumeroDeEmpleado = New Library.TextBoxSD()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssRegistros = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDeEmpleadoColumn, Me.NombresColumn, Me.ApellidosColumn, Me.NombreCompletoColumn, Me.FechaInicialColumn, Me.FechaFinal})
        Me.grdDatos.ContextMenuStrip = Me.mnuOpciones
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDatos.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdDatos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grdDatos.Location = New System.Drawing.Point(2, 64)
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdDatos.RowHeadersWidth = 25
        Me.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDatos.Size = New System.Drawing.Size(908, 272)
        Me.grdDatos.TabIndex = 0
        '
        'NumeroDeEmpleadoColumn
        '
        Me.NumeroDeEmpleadoColumn.DataPropertyName = "NumeroDeEmpleado"
        Me.NumeroDeEmpleadoColumn.HeaderText = "Numero de Empleado"
        Me.NumeroDeEmpleadoColumn.Name = "NumeroDeEmpleadoColumn"
        Me.NumeroDeEmpleadoColumn.ReadOnly = True
        '
        'NombresColumn
        '
        Me.NombresColumn.DataPropertyName = "Nombres"
        Me.NombresColumn.HeaderText = "Nombres"
        Me.NombresColumn.Name = "NombresColumn"
        Me.NombresColumn.ReadOnly = True
        Me.NombresColumn.Width = 200
        '
        'ApellidosColumn
        '
        Me.ApellidosColumn.DataPropertyName = "Apellidos"
        Me.ApellidosColumn.HeaderText = "Apellidos"
        Me.ApellidosColumn.Name = "ApellidosColumn"
        Me.ApellidosColumn.ReadOnly = True
        Me.ApellidosColumn.Width = 200
        '
        'NombreCompletoColumn
        '
        Me.NombreCompletoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreCompletoColumn.DataPropertyName = "NombreCompleto"
        Me.NombreCompletoColumn.HeaderText = "Nombre Completo"
        Me.NombreCompletoColumn.Name = "NombreCompletoColumn"
        Me.NombreCompletoColumn.ReadOnly = True
        '
        'FechaInicialColumn
        '
        Me.FechaInicialColumn.DataPropertyName = "FechaInicial"
        DataGridViewCellStyle2.Format = "d"
        Me.FechaInicialColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaInicialColumn.HeaderText = "Fecha Inicial"
        Me.FechaInicialColumn.Name = "FechaInicialColumn"
        Me.FechaInicialColumn.ReadOnly = True
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
        '
        'mnuOpciones
        '
        Me.mnuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGrabar, Me.muModificar, Me.mnuEliminar, Me.ToolStripSeparator1, Me.mnuConsultar})
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
        'muModificar
        '
        Me.muModificar.Image = Global.Cooperativa.My.Resources.Resources.glyphicons_081_refresh
        Me.muModificar.Name = "muModificar"
        Me.muModificar.Size = New System.Drawing.Size(125, 22)
        Me.muModificar.Text = "Modificar"
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 61)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(717, 42)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(15, 14)
        Me.chkActivo.TabIndex = 4
        Me.chkActivo.ThreeState = True
        Me.chkActivo.UseVisualStyleBackColor = True
        Me.chkActivo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(706, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Activo"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(601, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(351, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No. de Empleado"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.BackColor = System.Drawing.Color.White
        Me.txtFechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicial.Location = New System.Drawing.Point(601, 37)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NavegarConEnter = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(88, 21)
        Me.txtFechaInicial.TabIndex = 2
        Me.txtFechaInicial.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Personalizado
        Me.txtFechaInicial.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        Me.txtFechaInicial.ValidatingType = GetType(Date)
        '
        'txtApellidos
        '
        Me.txtApellidos.AutoTrim = True
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtApellidos.BordeNormal = System.Drawing.Color.DimGray
        Me.txtApellidos.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtApellidos.BordesRedondeados = False
        Me.txtApellidos.CantidadDecimales = CType(2, Short)
        Me.txtApellidos.CantidadEnteros = CType(15, Short)
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(351, 37)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.NavegarConEnter = True
        Me.txtApellidos.NumeroDeDecimales = 0
        Me.txtApellidos.Size = New System.Drawing.Size(248, 21)
        Me.txtApellidos.TabIndex = 1
        Me.txtApellidos.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Personalizado
        Me.txtApellidos.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtApellidos.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtApellidos.ValidChars = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.AutoTrim = True
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombres.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombres.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombres.BordesRedondeados = False
        Me.txtNombres.CantidadDecimales = CType(2, Short)
        Me.txtNombres.CantidadEnteros = CType(15, Short)
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(101, 37)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.NavegarConEnter = True
        Me.txtNombres.NumeroDeDecimales = 0
        Me.txtNombres.Size = New System.Drawing.Size(248, 21)
        Me.txtNombres.TabIndex = 1
        Me.txtNombres.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Personalizado
        Me.txtNombres.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombres.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombres.ValidChars = Nothing
        '
        'txtNumeroDeEmpleado
        '
        Me.txtNumeroDeEmpleado.AutoTrim = True
        Me.txtNumeroDeEmpleado.BackColor = System.Drawing.Color.White
        Me.txtNumeroDeEmpleado.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNumeroDeEmpleado.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNumeroDeEmpleado.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNumeroDeEmpleado.BordesRedondeados = False
        Me.txtNumeroDeEmpleado.CantidadDecimales = CType(2, Short)
        Me.txtNumeroDeEmpleado.CantidadEnteros = CType(15, Short)
        Me.txtNumeroDeEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(6, 37)
        Me.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado"
        Me.txtNumeroDeEmpleado.NavegarConEnter = True
        Me.txtNumeroDeEmpleado.NumeroDeDecimales = 0
        Me.txtNumeroDeEmpleado.Size = New System.Drawing.Size(93, 21)
        Me.txtNumeroDeEmpleado.TabIndex = 1
        Me.txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Personalizado
        Me.txtNumeroDeEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNumeroDeEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNumeroDeEmpleado.ValidChars = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Cooperativa.My.Resources.Resources._32
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(749, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(83, 38)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssRegistros, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 334)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(912, 26)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssRegistros
        '
        Me.tssRegistros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tssRegistros.Name = "tssRegistros"
        Me.tssRegistros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tssRegistros.Size = New System.Drawing.Size(19, 21)
        Me.tssRegistros.Text = "0"
        Me.tssRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(85, 21)
        Me.ToolStripStatusLabel1.Text = "Registro(s):"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(912, 360)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdDatos)
        Me.Name = "FrmEmpleados"
        Me.Text = "FrmEmpleados"
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDatos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtApellidos As Library.TextBoxSD
    Friend WithEvents txtNombres As Library.TextBoxSD
    Friend WithEvents txtNumeroDeEmpleado As Library.TextBoxSD
    Friend WithEvents txtFechaInicial As Library.MaskedTextBoxSD
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssRegistros As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NumeroDeEmpleadoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicialColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mnuOpciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuGrabar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents muModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuConsultar As System.Windows.Forms.ToolStripMenuItem
End Class
