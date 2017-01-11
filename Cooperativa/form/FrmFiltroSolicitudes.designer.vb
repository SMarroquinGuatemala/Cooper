<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltroSolicitudes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MnuMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuVerSolicitud = New System.Windows.Forms.ToolStripMenuItem()
        Me.tltMensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbFiltros = New System.Windows.Forms.GroupBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdExportar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaInicial = New Library.MaskedTextBoxSD()
        Me.txtNombreProveedor = New Library.TextBoxSD()
        Me.txtDescripcionCheque = New Library.TextBoxSD()
        Me.txtFechaFinal = New Library.MaskedTextBoxSD()
        Me.txtCodigoProveedor = New Library.TextBoxSD()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreCheque = New Library.TextBoxSD()
        Me.chkContabilizadas = New System.Windows.Forms.CheckBox()
        Me.txtSolicitud = New Library.TextBoxSD()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdNuevoEncabezado = New System.Windows.Forms.Button()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.grdSolicitudMovimientoBancos = New System.Windows.Forms.DataGridView()
        Me.FechaDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaBancaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tblGeneral = New System.Windows.Forms.TableLayoutPanel()
        Me.grdIndice = New System.Windows.Forms.DataGridView()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblData = New System.Windows.Forms.TableLayoutPanel()
        Me.MnuMenu.SuspendLayout()
        Me.grbFiltros.SuspendLayout()
        CType(Me.grdSolicitudMovimientoBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblGeneral.SuspendLayout()
        CType(Me.grdIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblData.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMenu
        '
        Me.MnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuVerSolicitud})
        Me.MnuMenu.Name = "MnuMenu"
        Me.MnuMenu.Size = New System.Drawing.Size(141, 26)
        '
        'MnuVerSolicitud
        '
        Me.MnuVerSolicitud.Name = "MnuVerSolicitud"
        Me.MnuVerSolicitud.Size = New System.Drawing.Size(140, 22)
        Me.MnuVerSolicitud.Text = "Ver Solicitud"
        '
        'grbFiltros
        '
        Me.grbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbFiltros.BackColor = System.Drawing.Color.White
        Me.grbFiltros.Controls.Add(Me.lblMensajes)
        Me.grbFiltros.Controls.Add(Me.cmdNuevoEncabezado)
        Me.grbFiltros.Controls.Add(Me.Label8)
        Me.grbFiltros.Controls.Add(Me.txtSolicitud)
        Me.grbFiltros.Controls.Add(Me.chkContabilizadas)
        Me.grbFiltros.Controls.Add(Me.txtNombreCheque)
        Me.grbFiltros.Controls.Add(Me.Label6)
        Me.grbFiltros.Controls.Add(Me.txtCodigoProveedor)
        Me.grbFiltros.Controls.Add(Me.txtFechaFinal)
        Me.grbFiltros.Controls.Add(Me.txtDescripcionCheque)
        Me.grbFiltros.Controls.Add(Me.txtNombreProveedor)
        Me.grbFiltros.Controls.Add(Me.txtFechaInicial)
        Me.grbFiltros.Controls.Add(Me.Label3)
        Me.grbFiltros.Controls.Add(Me.Label2)
        Me.grbFiltros.Controls.Add(Me.Label1)
        Me.grbFiltros.Controls.Add(Me.cmdExportar)
        Me.grbFiltros.Controls.Add(Me.cmdBuscar)
        Me.grbFiltros.Location = New System.Drawing.Point(3, 3)
        Me.grbFiltros.Name = "grbFiltros"
        Me.grbFiltros.Size = New System.Drawing.Size(1063, 94)
        Me.grbFiltros.TabIndex = 0
        Me.grbFiltros.TabStop = False
        Me.grbFiltros.Text = "Filtros"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Search_64
        Me.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBuscar.Location = New System.Drawing.Point(688, 24)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(57, 53)
        Me.cmdBuscar.TabIndex = 0
        Me.tltMensajes.SetToolTip(Me.cmdBuscar, "Buscar registros")
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdExportar
        '
        Me.cmdExportar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Reports_48
        Me.cmdExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExportar.Location = New System.Drawing.Point(747, 24)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(55, 53)
        Me.cmdExportar.TabIndex = 1
        Me.tltMensajes.SetToolTip(Me.cmdExportar, "Exportar a excel")
        Me.cmdExportar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Solicitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaInicial.Location = New System.Drawing.Point(429, 30)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NavegarConEnter = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(66, 20)
        Me.txtFechaInicial.TabIndex = 5
        Me.txtFechaInicial.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaInicial.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.AutoTrim = True
        Me.txtNombreProveedor.BackColor = System.Drawing.Color.LightGray
        Me.txtNombreProveedor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreProveedor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreProveedor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreProveedor.BordesRedondeados = False
        Me.txtNombreProveedor.CantidadDecimales = CType(2, Short)
        Me.txtNombreProveedor.CantidadEnteros = CType(15, Short)
        Me.txtNombreProveedor.Location = New System.Drawing.Point(116, 30)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.NavegarConEnter = True
        Me.txtNombreProveedor.NumeroDeDecimales = 0
        Me.txtNombreProveedor.Size = New System.Drawing.Size(139, 20)
        Me.txtNombreProveedor.TabIndex = 6
        Me.txtNombreProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNombreProveedor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreProveedor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreProveedor.ValidChars = Nothing
        '
        'txtDescripcionCheque
        '
        Me.txtDescripcionCheque.AutoTrim = True
        Me.txtDescripcionCheque.BackColor = System.Drawing.Color.LightGray
        Me.txtDescripcionCheque.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDescripcionCheque.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDescripcionCheque.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDescripcionCheque.BordesRedondeados = False
        Me.txtDescripcionCheque.CantidadDecimales = CType(2, Short)
        Me.txtDescripcionCheque.CantidadEnteros = CType(15, Short)
        Me.txtDescripcionCheque.Location = New System.Drawing.Point(66, 55)
        Me.txtDescripcionCheque.Name = "txtDescripcionCheque"
        Me.txtDescripcionCheque.NavegarConEnter = True
        Me.txtDescripcionCheque.NumeroDeDecimales = 0
        Me.txtDescripcionCheque.Size = New System.Drawing.Size(615, 20)
        Me.txtDescripcionCheque.TabIndex = 7
        Me.txtDescripcionCheque.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtDescripcionCheque.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDescripcionCheque.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDescripcionCheque.ValidChars = Nothing
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaFinal.Location = New System.Drawing.Point(501, 30)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NavegarConEnter = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(69, 20)
        Me.txtFechaFinal.TabIndex = 8
        Me.txtFechaFinal.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaFinal.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.AutoTrim = True
        Me.txtCodigoProveedor.BackColor = System.Drawing.Color.LightGray
        Me.txtCodigoProveedor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtCodigoProveedor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtCodigoProveedor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtCodigoProveedor.BordesRedondeados = False
        Me.txtCodigoProveedor.CantidadDecimales = CType(2, Short)
        Me.txtCodigoProveedor.CantidadEnteros = CType(15, Short)
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(58, 29)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.NavegarConEnter = True
        Me.txtCodigoProveedor.NumeroDeDecimales = 0
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoProveedor.TabIndex = 9
        Me.txtCodigoProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtCodigoProveedor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtCodigoProveedor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtCodigoProveedor.ValidChars = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(256, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nombre"
        '
        'txtNombreCheque
        '
        Me.txtNombreCheque.AutoTrim = True
        Me.txtNombreCheque.BackColor = System.Drawing.Color.LightGray
        Me.txtNombreCheque.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreCheque.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreCheque.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreCheque.BordesRedondeados = False
        Me.txtNombreCheque.CantidadDecimales = CType(2, Short)
        Me.txtNombreCheque.CantidadEnteros = CType(15, Short)
        Me.txtNombreCheque.Location = New System.Drawing.Point(298, 30)
        Me.txtNombreCheque.Name = "txtNombreCheque"
        Me.txtNombreCheque.NavegarConEnter = True
        Me.txtNombreCheque.NumeroDeDecimales = 0
        Me.txtNombreCheque.Size = New System.Drawing.Size(125, 20)
        Me.txtNombreCheque.TabIndex = 15
        Me.txtNombreCheque.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNombreCheque.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreCheque.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreCheque.ValidChars = Nothing
        '
        'chkContabilizadas
        '
        Me.chkContabilizadas.AutoSize = True
        Me.chkContabilizadas.Location = New System.Drawing.Point(687, 8)
        Me.chkContabilizadas.Name = "chkContabilizadas"
        Me.chkContabilizadas.Size = New System.Drawing.Size(118, 17)
        Me.chkContabilizadas.TabIndex = 19
        Me.chkContabilizadas.Text = "Solo Contabilizadas"
        Me.chkContabilizadas.UseVisualStyleBackColor = True
        '
        'txtSolicitud
        '
        Me.txtSolicitud.AutoTrim = True
        Me.txtSolicitud.BackColor = System.Drawing.Color.LightGray
        Me.txtSolicitud.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtSolicitud.BordeNormal = System.Drawing.Color.DimGray
        Me.txtSolicitud.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtSolicitud.BordesRedondeados = False
        Me.txtSolicitud.CantidadDecimales = CType(2, Short)
        Me.txtSolicitud.CantidadEnteros = CType(15, Short)
        Me.txtSolicitud.Location = New System.Drawing.Point(625, 31)
        Me.txtSolicitud.Name = "txtSolicitud"
        Me.txtSolicitud.NavegarConEnter = True
        Me.txtSolicitud.NumeroDeDecimales = 0
        Me.txtSolicitud.Size = New System.Drawing.Size(56, 20)
        Me.txtSolicitud.TabIndex = 20
        Me.txtSolicitud.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtSolicitud.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtSolicitud.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtSolicitud.ValidChars = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(576, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Solicitud"
        '
        'cmdNuevoEncabezado
        '
        Me.cmdNuevoEncabezado.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Document_64
        Me.cmdNuevoEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNuevoEncabezado.Location = New System.Drawing.Point(804, 24)
        Me.cmdNuevoEncabezado.Name = "cmdNuevoEncabezado"
        Me.cmdNuevoEncabezado.Size = New System.Drawing.Size(57, 53)
        Me.cmdNuevoEncabezado.TabIndex = 29
        Me.tltMensajes.SetToolTip(Me.cmdNuevoEncabezado, "Nuevo documento")
        Me.cmdNuevoEncabezado.UseVisualStyleBackColor = True
        '
        'lblMensajes
        '
        Me.lblMensajes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensajes.Location = New System.Drawing.Point(867, 24)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(190, 51)
        Me.lblMensajes.TabIndex = 30
        '
        'grdSolicitudMovimientoBancos
        '
        Me.grdSolicitudMovimientoBancos.AllowUserToAddRows = False
        Me.grdSolicitudMovimientoBancos.AllowUserToDeleteRows = False
        Me.grdSolicitudMovimientoBancos.AllowUserToOrderColumns = True
        Me.grdSolicitudMovimientoBancos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue
        Me.grdSolicitudMovimientoBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSolicitudMovimientoBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSolicitudMovimientoBancos.BackgroundColor = System.Drawing.Color.White
        Me.grdSolicitudMovimientoBancos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSolicitudMovimientoBancos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdSolicitudMovimientoBancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Valido, Me.Estado, Me.Solicitud, Me.Fecha, Me.Nombre, Me.Valor, Me.CuentaBancaria, Me.NumeroDocumento, Me.DescripcionPago, Me.FechaDocumento})
        Me.grdSolicitudMovimientoBancos.ContextMenuStrip = Me.MnuMenu
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSolicitudMovimientoBancos.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdSolicitudMovimientoBancos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdSolicitudMovimientoBancos.Location = New System.Drawing.Point(3, 3)
        Me.grdSolicitudMovimientoBancos.Name = "grdSolicitudMovimientoBancos"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSolicitudMovimientoBancos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdSolicitudMovimientoBancos.RowHeadersWidth = 10
        Me.grdSolicitudMovimientoBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSolicitudMovimientoBancos.ShowEditingIcon = False
        Me.grdSolicitudMovimientoBancos.Size = New System.Drawing.Size(1057, 293)
        Me.grdSolicitudMovimientoBancos.TabIndex = 5
        '
        'FechaDocumento
        '
        Me.FechaDocumento.DataPropertyName = "FechaDocumento"
        Me.FechaDocumento.HeaderText = "FechaDocumento"
        Me.FechaDocumento.Name = "FechaDocumento"
        Me.FechaDocumento.Visible = False
        '
        'DescripcionPago
        '
        Me.DescripcionPago.DataPropertyName = "Descripcion"
        Me.DescripcionPago.HeaderText = "DescripcionPago"
        Me.DescripcionPago.Name = "DescripcionPago"
        Me.DescripcionPago.Visible = False
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumeroDocumento.DefaultCellStyle = DataGridViewCellStyle6
        Me.NumeroDocumento.HeaderText = "NumeroDocumento"
        Me.NumeroDocumento.Name = "NumeroDocumento"
        '
        'CuentaBancaria
        '
        Me.CuentaBancaria.DataPropertyName = "CuentaBancaria"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CuentaBancaria.DefaultCellStyle = DataGridViewCellStyle5
        Me.CuentaBancaria.HeaderText = "CuentaBancaria"
        Me.CuentaBancaria.Name = "CuentaBancaria"
        Me.CuentaBancaria.Width = 110
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle4
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 230
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Fecha.Width = 90
        '
        'Solicitud
        '
        Me.Solicitud.DataPropertyName = "Solicitud"
        Me.Solicitud.HeaderText = "Solicitud"
        Me.Solicitud.Name = "Solicitud"
        Me.Solicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Solicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Solicitud.Width = 50
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Estado.DefaultCellStyle = DataGridViewCellStyle3
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 185
        '
        'Valido
        '
        Me.Valido.DataPropertyName = "Valido"
        Me.Valido.HeaderText = "Valido"
        Me.Valido.Name = "Valido"
        Me.Valido.Width = 38
        '
        'tblGeneral
        '
        Me.tblGeneral.AutoSize = True
        Me.tblGeneral.ColumnCount = 1
        Me.tblGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblGeneral.Controls.Add(Me.grbFiltros, 0, 0)
        Me.tblGeneral.Controls.Add(Me.tblData, 0, 1)
        Me.tblGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblGeneral.Location = New System.Drawing.Point(0, 0)
        Me.tblGeneral.Name = "tblGeneral"
        Me.tblGeneral.RowCount = 2
        Me.tblGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblGeneral.Size = New System.Drawing.Size(1069, 405)
        Me.tblGeneral.TabIndex = 0
        '
        'grdIndice
        '
        Me.grdIndice.AllowUserToAddRows = False
        Me.grdIndice.AllowUserToDeleteRows = False
        Me.grdIndice.AllowUserToResizeRows = False
        Me.grdIndice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdIndice.BackgroundColor = System.Drawing.Color.White
        Me.grdIndice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdIndice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIndice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdIndice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdIndice.ColumnHeadersVisible = False
        Me.grdIndice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Origen, Me.Descripcion})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdIndice.DefaultCellStyle = DataGridViewCellStyle10
        Me.grdIndice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdIndice.Location = New System.Drawing.Point(3, 3)
        Me.grdIndice.MultiSelect = False
        Me.grdIndice.Name = "grdIndice"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIndice.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdIndice.RowHeadersWidth = 10
        Me.grdIndice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdIndice.ShowEditingIcon = False
        Me.grdIndice.Size = New System.Drawing.Size(1, 293)
        Me.grdIndice.TabIndex = 4
        Me.grdIndice.VirtualMode = True
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descipcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Origen
        '
        Me.Origen.DataPropertyName = "OrigenTransaccion"
        Me.Origen.HeaderText = "OrigenTransaccion"
        Me.Origen.Name = "Origen"
        Me.Origen.Width = 20
        '
        'tblData
        '
        Me.tblData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblData.ColumnCount = 2
        Me.tblData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.0!))
        Me.tblData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblData.Controls.Add(Me.grdSolicitudMovimientoBancos, 1, 0)
        Me.tblData.Controls.Add(Me.grdIndice, 0, 0)
        Me.tblData.Location = New System.Drawing.Point(3, 103)
        Me.tblData.Name = "tblData"
        Me.tblData.RowCount = 1
        Me.tblData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblData.Size = New System.Drawing.Size(1063, 299)
        Me.tblData.TabIndex = 1
        '
        'FrmFiltroSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 405)
        Me.Controls.Add(Me.tblGeneral)
        Me.Name = "FrmFiltroSolicitudes"
        Me.Text = "::: Solicitudes :::"
        Me.MnuMenu.ResumeLayout(False)
        Me.grbFiltros.ResumeLayout(False)
        Me.grbFiltros.PerformLayout()
        CType(Me.grdSolicitudMovimientoBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblGeneral.ResumeLayout(False)
        CType(Me.grdIndice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblData.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MnuMenu As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents MnuVerSolicitud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tltMensajes As System.Windows.Forms.ToolTip
    Friend WithEvents grbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents cmdNuevoEncabezado As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitud As Library.TextBoxSD
    Friend WithEvents chkContabilizadas As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombreCheque As Library.TextBoxSD
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProveedor As Library.TextBoxSD
    Friend WithEvents txtFechaFinal As Library.MaskedTextBoxSD
    Friend WithEvents txtDescripcionCheque As Library.TextBoxSD
    Friend WithEvents txtNombreProveedor As Library.TextBoxSD
    Friend WithEvents txtFechaInicial As Library.MaskedTextBoxSD
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents grdSolicitudMovimientoBancos As System.Windows.Forms.DataGridView
    Friend WithEvents Valido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaBancaria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tblGeneral As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grdIndice As System.Windows.Forms.DataGridView
    Friend WithEvents Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
