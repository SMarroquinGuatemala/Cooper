<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransacciones
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tblControles = New System.Windows.Forms.TableLayoutPanel()
        Me.grbTransacciones = New System.Windows.Forms.GroupBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.grdTransacciones = New System.Windows.Forms.DataGridView()
        Me.cellReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellIdTransaccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbFiltros = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorFinal = New Library.TextBoxSD()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorInicial = New Library.TextBoxSD()
        Me.txtFechaFinal = New Library.MaskedTextBoxSD()
        Me.txtFechaInicial = New Library.MaskedTextBoxSD()
        Me.txtNumeroDeEmpleado = New Library.TextBoxSD()
        Me.cboEstadosTransaccion = New Library.ComboBoxSD()
        Me.grbNombreTransaccion = New System.Windows.Forms.GroupBox()
        Me.lblNombreOrigenTransaccion = New System.Windows.Forms.Label()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.tblControles.SuspendLayout()
        Me.grbTransacciones.SuspendLayout()
        CType(Me.grdTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltros.SuspendLayout()
        Me.grbNombreTransaccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblControles
        '
        Me.tblControles.ColumnCount = 1
        Me.tblControles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblControles.Controls.Add(Me.grbTransacciones, 0, 2)
        Me.tblControles.Controls.Add(Me.grbFiltros, 0, 0)
        Me.tblControles.Controls.Add(Me.grbNombreTransaccion, 0, 1)
        Me.tblControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblControles.Location = New System.Drawing.Point(0, 0)
        Me.tblControles.Name = "tblControles"
        Me.tblControles.RowCount = 3
        Me.tblControles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tblControles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tblControles.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblControles.Size = New System.Drawing.Size(994, 571)
        Me.tblControles.TabIndex = 0
        '
        'grbTransacciones
        '
        Me.grbTransacciones.Controls.Add(Me.lblRegistros)
        Me.grbTransacciones.Controls.Add(Me.grdTransacciones)
        Me.grbTransacciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbTransacciones.Location = New System.Drawing.Point(3, 133)
        Me.grbTransacciones.Name = "grbTransacciones"
        Me.grbTransacciones.Size = New System.Drawing.Size(988, 435)
        Me.grbTransacciones.TabIndex = 2
        Me.grbTransacciones.TabStop = False
        '
        'lblRegistros
        '
        Me.lblRegistros.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblRegistros.BackColor = System.Drawing.Color.Lavender
        Me.lblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.Location = New System.Drawing.Point(248, 421)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(535, 14)
        Me.lblRegistros.TabIndex = 1
        Me.lblRegistros.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grdTransacciones
        '
        Me.grdTransacciones.AllowUserToAddRows = False
        Me.grdTransacciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdTransacciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTransacciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.grdTransacciones.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransacciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTransacciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellReferencia, Me.cellEstado, Me.cellNombre, Me.cellFecha, Me.cellValor, Me.cellIdTransaccion})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTransacciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.grdTransacciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdTransacciones.Location = New System.Drawing.Point(248, 12)
        Me.grdTransacciones.Name = "grdTransacciones"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransacciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdTransacciones.RowHeadersVisible = False
        Me.grdTransacciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTransacciones.Size = New System.Drawing.Size(535, 406)
        Me.grdTransacciones.TabIndex = 0
        '
        'cellReferencia
        '
        Me.cellReferencia.DataPropertyName = "Referencia"
        Me.cellReferencia.HeaderText = "Referencia"
        Me.cellReferencia.Name = "cellReferencia"
        '
        'cellEstado
        '
        Me.cellEstado.DataPropertyName = "Estado"
        Me.cellEstado.HeaderText = "Estado"
        Me.cellEstado.Name = "cellEstado"
        '
        'cellNombre
        '
        Me.cellNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.cellNombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.cellNombre.HeaderText = "Nombre"
        Me.cellNombre.Name = "cellNombre"
        '
        'cellFecha
        '
        Me.cellFecha.DataPropertyName = "Fecha"
        Me.cellFecha.HeaderText = "Fecha"
        Me.cellFecha.Name = "cellFecha"
        '
        'cellValor
        '
        Me.cellValor.DataPropertyName = "Valor"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.cellValor.DefaultCellStyle = DataGridViewCellStyle4
        Me.cellValor.HeaderText = "Valor"
        Me.cellValor.Name = "cellValor"
        '
        'cellIdTransaccion
        '
        Me.cellIdTransaccion.DataPropertyName = "IdTransaccion"
        Me.cellIdTransaccion.HeaderText = "IdTransaccion"
        Me.cellIdTransaccion.Name = "cellIdTransaccion"
        Me.cellIdTransaccion.Visible = False
        '
        'grbFiltros
        '
        Me.grbFiltros.BackColor = System.Drawing.Color.White
        Me.grbFiltros.Controls.Add(Me.cmdNuevo)
        Me.grbFiltros.Controls.Add(Me.cmdBuscar)
        Me.grbFiltros.Controls.Add(Me.Label6)
        Me.grbFiltros.Controls.Add(Me.txtValorFinal)
        Me.grbFiltros.Controls.Add(Me.Label5)
        Me.grbFiltros.Controls.Add(Me.Label4)
        Me.grbFiltros.Controls.Add(Me.Label3)
        Me.grbFiltros.Controls.Add(Me.lblNombreEmpleado)
        Me.grbFiltros.Controls.Add(Me.Label2)
        Me.grbFiltros.Controls.Add(Me.Label1)
        Me.grbFiltros.Controls.Add(Me.txtValorInicial)
        Me.grbFiltros.Controls.Add(Me.txtFechaFinal)
        Me.grbFiltros.Controls.Add(Me.txtFechaInicial)
        Me.grbFiltros.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.grbFiltros.Controls.Add(Me.cboEstadosTransaccion)
        Me.grbFiltros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbFiltros.Location = New System.Drawing.Point(3, 3)
        Me.grbFiltros.Name = "grbFiltros"
        Me.grbFiltros.Size = New System.Drawing.Size(988, 74)
        Me.grbFiltros.TabIndex = 1
        Me.grbFiltros.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(639, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Al"
        '
        'txtValorFinal
        '
        Me.txtValorFinal.AutoTrim = True
        Me.txtValorFinal.BackColor = System.Drawing.Color.LightGray
        Me.txtValorFinal.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorFinal.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorFinal.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorFinal.BordesRedondeados = False
        Me.txtValorFinal.Location = New System.Drawing.Point(665, 47)
        Me.txtValorFinal.MaxLength = 10
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.NavegarConEnter = True
        Me.txtValorFinal.NumeroDeDecimales = 0
        Me.txtValorFinal.Size = New System.Drawing.Size(79, 20)
        Me.txtValorFinal.TabIndex = 5
        Me.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorFinal.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtValorFinal.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValorFinal.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValorFinal.ValidChars = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(507, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Valor Del"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Al"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Del"
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(545, 14)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(238, 20)
        Me.lblNombreEmpleado.TabIndex = 7
        Me.lblNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(413, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(245, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Estado"
        '
        'txtValorInicial
        '
        Me.txtValorInicial.AutoTrim = True
        Me.txtValorInicial.BackColor = System.Drawing.Color.LightGray
        Me.txtValorInicial.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorInicial.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorInicial.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorInicial.BordesRedondeados = False
        Me.txtValorInicial.Location = New System.Drawing.Point(558, 47)
        Me.txtValorInicial.MaxLength = 10
        Me.txtValorInicial.Name = "txtValorInicial"
        Me.txtValorInicial.NavegarConEnter = True
        Me.txtValorInicial.NumeroDeDecimales = 0
        Me.txtValorInicial.Size = New System.Drawing.Size(79, 20)
        Me.txtValorInicial.TabIndex = 4
        Me.txtValorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorInicial.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtValorInicial.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValorInicial.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValorInicial.ValidChars = Nothing
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaFinal.Location = New System.Drawing.Point(434, 47)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NavegarConEnter = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(70, 20)
        Me.txtFechaFinal.TabIndex = 3
        Me.txtFechaFinal.Text = "00000000"
        Me.txtFechaFinal.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaFinal.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaInicial.Location = New System.Drawing.Point(345, 47)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NavegarConEnter = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(70, 20)
        Me.txtFechaInicial.TabIndex = 2
        Me.txtFechaInicial.Text = "00000000"
        Me.txtFechaInicial.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaInicial.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'txtNumeroDeEmpleado
        '
        Me.txtNumeroDeEmpleado.AutoTrim = True
        Me.txtNumeroDeEmpleado.BackColor = System.Drawing.Color.LightGray
        Me.txtNumeroDeEmpleado.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNumeroDeEmpleado.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNumeroDeEmpleado.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNumeroDeEmpleado.BordesRedondeados = False
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(473, 14)
        Me.txtNumeroDeEmpleado.MaxLength = 7
        Me.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado"
        Me.txtNumeroDeEmpleado.NavegarConEnter = True
        Me.txtNumeroDeEmpleado.NumeroDeDecimales = 0
        Me.txtNumeroDeEmpleado.Size = New System.Drawing.Size(66, 20)
        Me.txtNumeroDeEmpleado.TabIndex = 1
        Me.txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNumeroDeEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNumeroDeEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Numeros
        Me.txtNumeroDeEmpleado.ValidChars = Nothing
        '
        'cboEstadosTransaccion
        '
        Me.cboEstadosTransaccion.BackColor = System.Drawing.Color.LightGray
        Me.cboEstadosTransaccion.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboEstadosTransaccion.Codigo = ""
        Me.cboEstadosTransaccion.FormattingEnabled = True
        Me.cboEstadosTransaccion.Location = New System.Drawing.Point(286, 14)
        Me.cboEstadosTransaccion.Name = "cboEstadosTransaccion"
        Me.cboEstadosTransaccion.NavegarConEnter = True
        Me.cboEstadosTransaccion.Separador = "-"
        Me.cboEstadosTransaccion.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadosTransaccion.sqlQuery = ""
        Me.cboEstadosTransaccion.TabIndex = 0
        Me.cboEstadosTransaccion.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Opcional
        Me.cboEstadosTransaccion.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboEstadosTransaccion.ValidAllText = False
        '
        'grbNombreTransaccion
        '
        Me.grbNombreTransaccion.Controls.Add(Me.lblNombreOrigenTransaccion)
        Me.grbNombreTransaccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbNombreTransaccion.Location = New System.Drawing.Point(3, 83)
        Me.grbNombreTransaccion.Name = "grbNombreTransaccion"
        Me.grbNombreTransaccion.Size = New System.Drawing.Size(988, 44)
        Me.grbNombreTransaccion.TabIndex = 3
        Me.grbNombreTransaccion.TabStop = False
        '
        'lblNombreOrigenTransaccion
        '
        Me.lblNombreOrigenTransaccion.BackColor = System.Drawing.Color.SteelBlue
        Me.lblNombreOrigenTransaccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombreOrigenTransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreOrigenTransaccion.ForeColor = System.Drawing.Color.White
        Me.lblNombreOrigenTransaccion.Location = New System.Drawing.Point(3, 16)
        Me.lblNombreOrigenTransaccion.Name = "lblNombreOrigenTransaccion"
        Me.lblNombreOrigenTransaccion.Size = New System.Drawing.Size(982, 25)
        Me.lblNombreOrigenTransaccion.TabIndex = 0
        Me.lblNombreOrigenTransaccion.Text = "Prestamos"
        Me.lblNombreOrigenTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Document_64
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNuevo.Location = New System.Drawing.Point(847, 10)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(57, 57)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Search_64
        Me.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBuscar.Location = New System.Drawing.Point(790, 10)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(57, 57)
        Me.cmdBuscar.TabIndex = 6
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'FrmTransacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 571)
        Me.Controls.Add(Me.tblControles)
        Me.Name = "FrmTransacciones"
        Me.Text = "<< Transacciones >>"
        Me.tblControles.ResumeLayout(False)
        Me.grbTransacciones.ResumeLayout(False)
        CType(Me.grdTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltros.ResumeLayout(False)
        Me.grbFiltros.PerformLayout()
        Me.grbNombreTransaccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblControles As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValorInicial As Library.TextBoxSD
    Friend WithEvents txtFechaFinal As Library.MaskedTextBoxSD
    Friend WithEvents txtFechaInicial As Library.MaskedTextBoxSD
    Friend WithEvents txtNumeroDeEmpleado As Library.TextBoxSD
    Friend WithEvents cboEstadosTransaccion As Library.ComboBoxSD
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtValorFinal As Library.TextBoxSD
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents grbTransacciones As System.Windows.Forms.GroupBox
    Friend WithEvents grdTransacciones As System.Windows.Forms.DataGridView
    Friend WithEvents grbNombreTransaccion As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreOrigenTransaccion As System.Windows.Forms.Label
    Friend WithEvents lblRegistros As System.Windows.Forms.Label
    Friend WithEvents cellReferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellIdTransaccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
