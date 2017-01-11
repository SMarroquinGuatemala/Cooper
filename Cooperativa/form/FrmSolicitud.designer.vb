<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitud
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grbEncabezado = New System.Windows.Forms.GroupBox()
        Me.txtProveedorSolicitud = New Library.TextBoxSD()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtFechaDePago = New Library.MaskedTextBoxSD()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFechaSolicitud = New Library.MaskedTextBoxSD()
        Me.grbBanco = New System.Windows.Forms.GroupBox()
        Me.cmdEliminarSolicitud = New System.Windows.Forms.Button()
        Me.cmdBoletaTransaccion = New System.Windows.Forms.Button()
        Me.cmdContabilizar = New System.Windows.Forms.Button()
        Me.chkValidSolicitud = New System.Windows.Forms.CheckBox()
        Me.cboCuentasBancarias = New Library.ComboBoxSD()
        Me.cboBancos = New Library.ComboBoxSD()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSolicitud = New System.Windows.Forms.Label()
        Me.cmdNuevoEncabezado = New System.Windows.Forms.Button()
        Me.cmdGrabarEncabezado = New System.Windows.Forms.Button()
        Me.txtValor = New Library.TextBoxSD()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtValorOtraMoneda = New Library.TextBoxSD()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFechaDocumento = New Library.MaskedTextBoxSD()
        Me.TxtDocumentoBancos = New Library.TextBoxSD()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New Library.TextBoxSD()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUtilizacion = New Library.TextBoxSD()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New Library.TextBoxSD()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grbDetalle = New System.Windows.Forms.GroupBox()
        Me.grbContabilidad = New System.Windows.Forms.GroupBox()
        Me.lblSaldoContabilidad = New System.Windows.Forms.Label()
        Me.cmdGrabarContabilidad = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblNombreCuentaContabilidad = New System.Windows.Forms.Label()
        Me.txtValorContabilidad = New Library.TextBoxSD()
        Me.txtDescripcionContabilidad = New Library.TextBoxSD()
        Me.txtCuentaContableContabilidad = New Library.TextBoxSD()
        Me.grdIndice = New System.Windows.Forms.DataGridView()
        Me.cellisValido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cellNumeroDocumentoIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellTipoDocumentoIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellProveedorIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellIdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDocumentos = New System.Windows.Forms.TabPage()
        Me.grbDocumentos = New System.Windows.Forms.GroupBox()
        Me.cboBaseLegal = New Library.ComboBoxSD()
        Me.lblBaseLegal = New System.Windows.Forms.Label()
        Me.txtOrdenDeServicio = New Library.TextBoxSD()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtOrdenDeCompra = New Library.TextBoxSD()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtValorRetencionBienes = New Library.TextBoxSD()
        Me.txtValorRetencion = New Library.TextBoxSD()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtIvaServiciosGasto = New Library.TextBoxSD()
        Me.TxtIvaBienesGasto = New Library.TextBoxSD()
        Me.TxtIvaServicios = New Library.TextBoxSD()
        Me.TxtIvaBienes = New Library.TextBoxSD()
        Me.cboMoneda = New Library.ComboBoxSD()
        Me.txtValorIVA = New Library.TextBoxSD()
        Me.lblValorIva = New System.Windows.Forms.Label()
        Me.TxtTipoDeCambio = New Library.TextBoxSD()
        Me.chkReclamaIVA = New System.Windows.Forms.CheckBox()
        Me.cmdNuevoDocumento = New System.Windows.Forms.Button()
        Me.cmdEliminarDocumento = New System.Windows.Forms.Button()
        Me.cmdGrabarDocumento = New System.Windows.Forms.Button()
        Me.cboTipoDocumento = New Library.ComboBoxSD()
        Me.TxtFecha = New Library.MaskedTextBoxSD()
        Me.txtNIT = New Library.TextBoxSD()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New Library.TextBoxSD()
        Me.TxtNombreProveedor = New Library.TextBoxSD()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtValorServicios = New Library.TextBoxSD()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtValorLiquido = New Library.TextBoxSD()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtValorTotal = New Library.TextBoxSD()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtValorExcentoIva = New Library.TextBoxSD()
        Me.lblExcento = New System.Windows.Forms.Label()
        Me.TxtValorBienes = New Library.TextBoxSD()
        Me.lblBienes = New System.Windows.Forms.Label()
        Me.TxtSerie = New Library.TextBoxSD()
        Me.TxtNumeroDocumento = New Library.TextBoxSD()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtSaldo = New Library.TextBoxSD()
        Me.TxtAbonos = New Library.TextBoxSD()
        Me.TxtCargos = New Library.TextBoxSD()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grdContabilidad = New System.Windows.Forms.DataGridView()
        Me.cellIdMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellRegistroReservado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellValido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cellTipoCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocIdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuContabilidad = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuGrabarContabilidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tltMensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbEncabezado.SuspendLayout()
        Me.grbBanco.SuspendLayout()
        Me.grbDetalle.SuspendLayout()
        Me.grbContabilidad.SuspendLayout()
        CType(Me.grdIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabDocumentos.SuspendLayout()
        Me.grbDocumentos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdContabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuContabilidad.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEncabezado
        '
        Me.grbEncabezado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbEncabezado.BackColor = System.Drawing.SystemColors.Control
        Me.grbEncabezado.Controls.Add(Me.txtProveedorSolicitud)
        Me.grbEncabezado.Controls.Add(Me.Label11)
        Me.grbEncabezado.Controls.Add(Me.Label5)
        Me.grbEncabezado.Controls.Add(Me.TxtFechaDePago)
        Me.grbEncabezado.Controls.Add(Me.Label4)
        Me.grbEncabezado.Controls.Add(Me.TxtFechaSolicitud)
        Me.grbEncabezado.Controls.Add(Me.grbBanco)
        Me.grbEncabezado.Controls.Add(Me.TxtDescripcion)
        Me.grbEncabezado.Controls.Add(Me.Label3)
        Me.grbEncabezado.Controls.Add(Me.TxtUtilizacion)
        Me.grbEncabezado.Controls.Add(Me.Label2)
        Me.grbEncabezado.Controls.Add(Me.Label1)
        Me.grbEncabezado.Controls.Add(Me.TxtNombre)
        Me.grbEncabezado.Location = New System.Drawing.Point(3, 3)
        Me.grbEncabezado.Name = "grbEncabezado"
        Me.grbEncabezado.Size = New System.Drawing.Size(923, 167)
        Me.grbEncabezado.TabIndex = 0
        Me.grbEncabezado.TabStop = False
        Me.grbEncabezado.Text = "Encabezado"
        '
        'txtProveedorSolicitud
        '
        Me.txtProveedorSolicitud.AutoTrim = True
        Me.txtProveedorSolicitud.BackColor = System.Drawing.Color.LightGray
        Me.txtProveedorSolicitud.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtProveedorSolicitud.BordeNormal = System.Drawing.Color.DimGray
        Me.txtProveedorSolicitud.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtProveedorSolicitud.BordesRedondeados = False
        Me.txtProveedorSolicitud.CantidadDecimales = CType(2, Short)
        Me.txtProveedorSolicitud.CantidadEnteros = CType(2, Short)
        Me.txtProveedorSolicitud.Location = New System.Drawing.Point(231, 17)
        Me.txtProveedorSolicitud.Name = "txtProveedorSolicitud"
        Me.txtProveedorSolicitud.NavegarConEnter = True
        Me.txtProveedorSolicitud.NumeroDeDecimales = 0
        Me.txtProveedorSolicitud.Size = New System.Drawing.Size(71, 20)
        Me.txtProveedorSolicitud.TabIndex = 18
        Me.txtProveedorSolicitud.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtProveedorSolicitud.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtProveedorSolicitud.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.tltMensajes.SetToolTip(Me.txtProveedorSolicitud, "Proveedor de la solicitud para obtener el nombre guardado")
        Me.txtProveedorSolicitud.ValidChars = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(172, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(388, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha De Pago"
        '
        'TxtFechaDePago
        '
        Me.TxtFechaDePago.BackColor = System.Drawing.Color.LightGreen
        Me.TxtFechaDePago.Location = New System.Drawing.Point(391, 43)
        Me.TxtFechaDePago.Mask = "00/00/0000"
        Me.TxtFechaDePago.Name = "TxtFechaDePago"
        Me.TxtFechaDePago.NavegarConEnter = True
        Me.TxtFechaDePago.ReadOnly = True
        Me.TxtFechaDePago.Size = New System.Drawing.Size(71, 20)
        Me.TxtFechaDePago.TabIndex = 9
        Me.TxtFechaDePago.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Desplieque
        Me.TxtFechaDePago.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Solicitud"
        '
        'TxtFechaSolicitud
        '
        Me.TxtFechaSolicitud.BackColor = System.Drawing.Color.LightGreen
        Me.TxtFechaSolicitud.Location = New System.Drawing.Point(308, 43)
        Me.TxtFechaSolicitud.Mask = "00/00/0000"
        Me.TxtFechaSolicitud.Name = "TxtFechaSolicitud"
        Me.TxtFechaSolicitud.NavegarConEnter = True
        Me.TxtFechaSolicitud.ReadOnly = True
        Me.TxtFechaSolicitud.Size = New System.Drawing.Size(77, 20)
        Me.TxtFechaSolicitud.TabIndex = 7
        Me.TxtFechaSolicitud.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Desplieque
        Me.TxtFechaSolicitud.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'grbBanco
        '
        Me.grbBanco.BackColor = System.Drawing.Color.White
        Me.grbBanco.Controls.Add(Me.cmdEliminarSolicitud)
        Me.grbBanco.Controls.Add(Me.cmdBoletaTransaccion)
        Me.grbBanco.Controls.Add(Me.cmdContabilizar)
        Me.grbBanco.Controls.Add(Me.chkValidSolicitud)
        Me.grbBanco.Controls.Add(Me.cboCuentasBancarias)
        Me.grbBanco.Controls.Add(Me.cboBancos)
        Me.grbBanco.Controls.Add(Me.Label18)
        Me.grbBanco.Controls.Add(Me.lblSolicitud)
        Me.grbBanco.Controls.Add(Me.cmdNuevoEncabezado)
        Me.grbBanco.Controls.Add(Me.cmdGrabarEncabezado)
        Me.grbBanco.Controls.Add(Me.txtValor)
        Me.grbBanco.Controls.Add(Me.LblEstado)
        Me.grbBanco.Controls.Add(Me.Label26)
        Me.grbBanco.Controls.Add(Me.TxtValorOtraMoneda)
        Me.grbBanco.Controls.Add(Me.Label9)
        Me.grbBanco.Controls.Add(Me.Label7)
        Me.grbBanco.Controls.Add(Me.TxtFechaDocumento)
        Me.grbBanco.Controls.Add(Me.TxtDocumentoBancos)
        Me.grbBanco.Controls.Add(Me.Label6)
        Me.grbBanco.Location = New System.Drawing.Point(470, 11)
        Me.grbBanco.Name = "grbBanco"
        Me.grbBanco.Size = New System.Drawing.Size(448, 170)
        Me.grbBanco.TabIndex = 3
        Me.grbBanco.TabStop = False
        Me.grbBanco.Text = "Banco"
        '
        'cmdEliminarSolicitud
        '
        Me.cmdEliminarSolicitud.BackgroundImage = Global.Cooperativa.My.Resources.Resources.delete_48
        Me.cmdEliminarSolicitud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEliminarSolicitud.Location = New System.Drawing.Point(386, 102)
        Me.cmdEliminarSolicitud.Name = "cmdEliminarSolicitud"
        Me.cmdEliminarSolicitud.Size = New System.Drawing.Size(57, 53)
        Me.cmdEliminarSolicitud.TabIndex = 308
        Me.tltMensajes.SetToolTip(Me.cmdEliminarSolicitud, "Eliminar solicitud")
        Me.cmdEliminarSolicitud.UseVisualStyleBackColor = True
        '
        'cmdBoletaTransaccion
        '
        Me.cmdBoletaTransaccion.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Reports_48
        Me.cmdBoletaTransaccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBoletaTransaccion.Location = New System.Drawing.Point(217, 102)
        Me.cmdBoletaTransaccion.Name = "cmdBoletaTransaccion"
        Me.cmdBoletaTransaccion.Size = New System.Drawing.Size(55, 53)
        Me.cmdBoletaTransaccion.TabIndex = 307
        Me.tltMensajes.SetToolTip(Me.cmdBoletaTransaccion, "Imprime boleta de solicitud")
        Me.cmdBoletaTransaccion.UseVisualStyleBackColor = True
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Banknotes_48
        Me.cmdContabilizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdContabilizar.Location = New System.Drawing.Point(197, 44)
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(53, 53)
        Me.cmdContabilizar.TabIndex = 306
        Me.tltMensajes.SetToolTip(Me.cmdContabilizar, "Cerrar Solicitud")
        Me.cmdContabilizar.UseVisualStyleBackColor = True
        '
        'chkValidSolicitud
        '
        Me.chkValidSolicitud.AutoSize = True
        Me.chkValidSolicitud.Enabled = False
        Me.chkValidSolicitud.Location = New System.Drawing.Point(392, 0)
        Me.chkValidSolicitud.Name = "chkValidSolicitud"
        Me.chkValidSolicitud.Size = New System.Drawing.Size(55, 17)
        Me.chkValidSolicitud.TabIndex = 305
        Me.chkValidSolicitud.Text = "Valida"
        Me.chkValidSolicitud.UseVisualStyleBackColor = True
        '
        'cboCuentasBancarias
        '
        Me.cboCuentasBancarias.BackColor = System.Drawing.Color.LightGray
        Me.cboCuentasBancarias.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboCuentasBancarias.Codigo = ""
        Me.cboCuentasBancarias.FormattingEnabled = True
        Me.cboCuentasBancarias.Location = New System.Drawing.Point(143, 17)
        Me.cboCuentasBancarias.Name = "cboCuentasBancarias"
        Me.cboCuentasBancarias.NavegarConEnter = True
        Me.cboCuentasBancarias.Separador = "-"
        Me.cboCuentasBancarias.Size = New System.Drawing.Size(107, 21)
        Me.cboCuentasBancarias.sqlQuery = ""
        Me.cboCuentasBancarias.TabIndex = 304
        Me.cboCuentasBancarias.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Opcional
        Me.cboCuentasBancarias.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboCuentasBancarias.ValidAllText = False
        '
        'cboBancos
        '
        Me.cboBancos.BackColor = System.Drawing.Color.LightGray
        Me.cboBancos.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboBancos.Codigo = ""
        Me.cboBancos.FormattingEnabled = True
        Me.cboBancos.Location = New System.Drawing.Point(9, 18)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.NavegarConEnter = True
        Me.cboBancos.Separador = "-"
        Me.cboBancos.Size = New System.Drawing.Size(128, 21)
        Me.cboBancos.sqlQuery = ""
        Me.cboBancos.TabIndex = 303
        Me.cboBancos.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Opcional
        Me.cboBancos.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboBancos.ValidAllText = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(39, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 302
        Me.Label18.Text = "Otra Moneda"
        '
        'lblSolicitud
        '
        Me.lblSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitud.ForeColor = System.Drawing.Color.Blue
        Me.lblSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSolicitud.Location = New System.Drawing.Point(257, 27)
        Me.lblSolicitud.Name = "lblSolicitud"
        Me.lblSolicitud.Size = New System.Drawing.Size(182, 29)
        Me.lblSolicitud.TabIndex = 30
        Me.lblSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdNuevoEncabezado
        '
        Me.cmdNuevoEncabezado.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Document_64
        Me.cmdNuevoEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNuevoEncabezado.Location = New System.Drawing.Point(329, 102)
        Me.cmdNuevoEncabezado.Name = "cmdNuevoEncabezado"
        Me.cmdNuevoEncabezado.Size = New System.Drawing.Size(57, 53)
        Me.cmdNuevoEncabezado.TabIndex = 100
        Me.tltMensajes.SetToolTip(Me.cmdNuevoEncabezado, "Nuevo solicitud")
        Me.cmdNuevoEncabezado.UseVisualStyleBackColor = True
        '
        'cmdGrabarEncabezado
        '
        Me.cmdGrabarEncabezado.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGrabarEncabezado.Location = New System.Drawing.Point(272, 102)
        Me.cmdGrabarEncabezado.Name = "cmdGrabarEncabezado"
        Me.cmdGrabarEncabezado.Size = New System.Drawing.Size(57, 53)
        Me.cmdGrabarEncabezado.TabIndex = 2
        Me.tltMensajes.SetToolTip(Me.cmdGrabarEncabezado, "Grabar cambios en el encabezado")
        Me.cmdGrabarEncabezado.UseVisualStyleBackColor = True
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
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(9, 115)
        Me.txtValor.MaxLength = 18
        Me.txtValor.Name = "txtValor"
        Me.txtValor.NavegarConEnter = True
        Me.txtValor.NumeroDeDecimales = 0
        Me.txtValor.Size = New System.Drawing.Size(182, 38)
        Me.txtValor.TabIndex = 1
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtValor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValor.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValor.ValidChars = Nothing
        '
        'LblEstado
        '
        Me.LblEstado.BackColor = System.Drawing.Color.LightGray
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ForeColor = System.Drawing.Color.Blue
        Me.LblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblEstado.Location = New System.Drawing.Point(256, 57)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(183, 40)
        Me.LblEstado.TabIndex = 11
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(257, 3)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(181, 23)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Solicitud"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtValorOtraMoneda
        '
        Me.TxtValorOtraMoneda.AutoTrim = True
        Me.TxtValorOtraMoneda.BackColor = System.Drawing.Color.LightGreen
        Me.TxtValorOtraMoneda.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtValorOtraMoneda.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtValorOtraMoneda.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtValorOtraMoneda.BordesRedondeados = False
        Me.TxtValorOtraMoneda.CantidadDecimales = CType(2, Short)
        Me.TxtValorOtraMoneda.CantidadEnteros = CType(2, Short)
        Me.TxtValorOtraMoneda.Location = New System.Drawing.Point(115, 84)
        Me.TxtValorOtraMoneda.MaxLength = 18
        Me.TxtValorOtraMoneda.Name = "TxtValorOtraMoneda"
        Me.TxtValorOtraMoneda.NavegarConEnter = True
        Me.TxtValorOtraMoneda.NumeroDeDecimales = 0
        Me.TxtValorOtraMoneda.ReadOnly = True
        Me.TxtValorOtraMoneda.Size = New System.Drawing.Size(76, 20)
        Me.TxtValorOtraMoneda.TabIndex = 15
        Me.TxtValorOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtValorOtraMoneda.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtValorOtraMoneda.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtValorOtraMoneda.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtValorOtraMoneda.ValidChars = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Valor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Fecha Doc."
        '
        'TxtFechaDocumento
        '
        Me.TxtFechaDocumento.BackColor = System.Drawing.Color.LightGreen
        Me.TxtFechaDocumento.Location = New System.Drawing.Point(114, 58)
        Me.TxtFechaDocumento.Mask = "00/00/0000"
        Me.TxtFechaDocumento.Name = "TxtFechaDocumento"
        Me.TxtFechaDocumento.NavegarConEnter = True
        Me.TxtFechaDocumento.ReadOnly = True
        Me.TxtFechaDocumento.Size = New System.Drawing.Size(77, 20)
        Me.TxtFechaDocumento.TabIndex = 9
        Me.TxtFechaDocumento.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Desplieque
        Me.TxtFechaDocumento.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'TxtDocumentoBancos
        '
        Me.TxtDocumentoBancos.AutoTrim = True
        Me.TxtDocumentoBancos.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDocumentoBancos.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtDocumentoBancos.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtDocumentoBancos.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtDocumentoBancos.BordesRedondeados = False
        Me.TxtDocumentoBancos.CantidadDecimales = CType(2, Short)
        Me.TxtDocumentoBancos.CantidadEnteros = CType(2, Short)
        Me.TxtDocumentoBancos.Location = New System.Drawing.Point(9, 58)
        Me.TxtDocumentoBancos.Name = "TxtDocumentoBancos"
        Me.TxtDocumentoBancos.NavegarConEnter = True
        Me.TxtDocumentoBancos.NumeroDeDecimales = 0
        Me.TxtDocumentoBancos.ReadOnly = True
        Me.TxtDocumentoBancos.Size = New System.Drawing.Size(99, 20)
        Me.TxtDocumentoBancos.TabIndex = 5
        Me.TxtDocumentoBancos.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtDocumentoBancos.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtDocumentoBancos.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtDocumentoBancos.ValidChars = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Documento"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AutoTrim = True
        Me.TxtDescripcion.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtDescripcion.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtDescripcion.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtDescripcion.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtDescripcion.BordesRedondeados = False
        Me.TxtDescripcion.CantidadDecimales = CType(2, Short)
        Me.TxtDescripcion.CantidadEnteros = CType(2, Short)
        Me.TxtDescripcion.Location = New System.Drawing.Point(9, 82)
        Me.TxtDescripcion.MaxLength = 100
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.NavegarConEnter = True
        Me.TxtDescripcion.NumeroDeDecimales = 0
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(455, 30)
        Me.TxtDescripcion.TabIndex = 1
        Me.TxtDescripcion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtDescripcion.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtDescripcion.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.tltMensajes.SetToolTip(Me.TxtDescripcion, "Descripcion del pago")
        Me.TxtDescripcion.ValidChars = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'TxtUtilizacion
        '
        Me.TxtUtilizacion.AutoTrim = True
        Me.TxtUtilizacion.BackColor = System.Drawing.Color.LightGray
        Me.TxtUtilizacion.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtUtilizacion.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtUtilizacion.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtUtilizacion.BordesRedondeados = False
        Me.TxtUtilizacion.CantidadDecimales = CType(2, Short)
        Me.TxtUtilizacion.CantidadEnteros = CType(2, Short)
        Me.TxtUtilizacion.Location = New System.Drawing.Point(9, 130)
        Me.TxtUtilizacion.MaxLength = 500
        Me.TxtUtilizacion.Multiline = True
        Me.TxtUtilizacion.Name = "TxtUtilizacion"
        Me.TxtUtilizacion.NavegarConEnter = True
        Me.TxtUtilizacion.NumeroDeDecimales = 0
        Me.TxtUtilizacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtUtilizacion.Size = New System.Drawing.Size(455, 31)
        Me.TxtUtilizacion.TabIndex = 2
        Me.TxtUtilizacion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.TxtUtilizacion.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtUtilizacion.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.tltMensajes.SetToolTip(Me.TxtUtilizacion, "Descripcion adicional del pago")
        Me.TxtUtilizacion.ValidChars = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Utilizacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.AutoTrim = True
        Me.TxtNombre.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtNombre.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtNombre.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtNombre.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtNombre.BordesRedondeados = False
        Me.TxtNombre.CantidadDecimales = CType(2, Short)
        Me.TxtNombre.CantidadEnteros = CType(2, Short)
        Me.TxtNombre.Location = New System.Drawing.Point(9, 43)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.NavegarConEnter = True
        Me.TxtNombre.NumeroDeDecimales = 0
        Me.TxtNombre.Size = New System.Drawing.Size(293, 20)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtNombre.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtNombre.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.tltMensajes.SetToolTip(Me.TxtNombre, "Nombre a quien saldra el cheque ")
        Me.TxtNombre.ValidChars = Nothing
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(332, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Tipo Cambio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(251, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Moneda"
        '
        'grbDetalle
        '
        Me.grbDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.grbDetalle.Controls.Add(Me.grbContabilidad)
        Me.grbDetalle.Controls.Add(Me.grdIndice)
        Me.grbDetalle.Controls.Add(Me.TabControl1)
        Me.grbDetalle.Controls.Add(Me.GroupBox1)
        Me.grbDetalle.Controls.Add(Me.Label12)
        Me.grbDetalle.Controls.Add(Me.grdContabilidad)
        Me.grbDetalle.Enabled = False
        Me.grbDetalle.Location = New System.Drawing.Point(3, 176)
        Me.grbDetalle.Name = "grbDetalle"
        Me.grbDetalle.Size = New System.Drawing.Size(923, 364)
        Me.grbDetalle.TabIndex = 1
        Me.grbDetalle.TabStop = False
        Me.grbDetalle.Text = "Detalle"
        '
        'grbContabilidad
        '
        Me.grbContabilidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbContabilidad.BackColor = System.Drawing.Color.White
        Me.grbContabilidad.Controls.Add(Me.lblSaldoContabilidad)
        Me.grbContabilidad.Controls.Add(Me.cmdGrabarContabilidad)
        Me.grbContabilidad.Controls.Add(Me.Label33)
        Me.grbContabilidad.Controls.Add(Me.Label34)
        Me.grbContabilidad.Controls.Add(Me.Label35)
        Me.grbContabilidad.Controls.Add(Me.lblNombreCuentaContabilidad)
        Me.grbContabilidad.Controls.Add(Me.txtValorContabilidad)
        Me.grbContabilidad.Controls.Add(Me.txtDescripcionContabilidad)
        Me.grbContabilidad.Controls.Add(Me.txtCuentaContableContabilidad)
        Me.grbContabilidad.Location = New System.Drawing.Point(526, 167)
        Me.grbContabilidad.Name = "grbContabilidad"
        Me.grbContabilidad.Size = New System.Drawing.Size(391, 155)
        Me.grbContabilidad.TabIndex = 14
        Me.grbContabilidad.TabStop = False
        Me.grbContabilidad.Text = "Por Concepto De"
        '
        'lblSaldoContabilidad
        '
        Me.lblSaldoContabilidad.Location = New System.Drawing.Point(252, 5)
        Me.lblSaldoContabilidad.Name = "lblSaldoContabilidad"
        Me.lblSaldoContabilidad.Size = New System.Drawing.Size(126, 13)
        Me.lblSaldoContabilidad.TabIndex = 23
        Me.lblSaldoContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdGrabarContabilidad
        '
        Me.cmdGrabarContabilidad.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabarContabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGrabarContabilidad.Location = New System.Drawing.Point(308, 56)
        Me.cmdGrabarContabilidad.Name = "cmdGrabarContabilidad"
        Me.cmdGrabarContabilidad.Size = New System.Drawing.Size(75, 73)
        Me.cmdGrabarContabilidad.TabIndex = 300
        Me.cmdGrabarContabilidad.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(161, 119)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(31, 13)
        Me.Label33.TabIndex = 22
        Me.Label33.Text = "Valor"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 50)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 13)
        Me.Label34.TabIndex = 21
        Me.Label34.Text = "Descripcion"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 13)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 13)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Cuenta Contable"
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
        Me.txtValorContabilidad.Location = New System.Drawing.Point(198, 112)
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
        Me.txtDescripcionContabilidad.Location = New System.Drawing.Point(13, 64)
        Me.txtDescripcionContabilidad.MaxLength = 100
        Me.txtDescripcionContabilidad.Multiline = True
        Me.txtDescripcionContabilidad.Name = "txtDescripcionContabilidad"
        Me.txtDescripcionContabilidad.NavegarConEnter = True
        Me.txtDescripcionContabilidad.NumeroDeDecimales = 0
        Me.txtDescripcionContabilidad.Size = New System.Drawing.Size(285, 44)
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
        'grdIndice
        '
        Me.grdIndice.AllowUserToAddRows = False
        Me.grdIndice.AllowUserToDeleteRows = False
        Me.grdIndice.AllowUserToOrderColumns = True
        Me.grdIndice.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grdIndice.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdIndice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdIndice.BackgroundColor = System.Drawing.Color.White
        Me.grdIndice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdIndice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIndice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdIndice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellisValido, Me.cellNumeroDocumentoIndice, Me.cellTipoDocumentoIndice, Me.cellProveedorIndice, Me.cellIdDocumento})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdIndice.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdIndice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdIndice.Location = New System.Drawing.Point(5, 14)
        Me.grdIndice.Name = "grdIndice"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdIndice.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdIndice.RowHeadersWidth = 10
        Me.grdIndice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdIndice.ShowEditingIcon = False
        Me.grdIndice.Size = New System.Drawing.Size(139, 344)
        Me.grdIndice.TabIndex = 13
        '
        'cellisValido
        '
        Me.cellisValido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cellisValido.DataPropertyName = "Valido"
        Me.cellisValido.HeaderText = "Valido"
        Me.cellisValido.Name = "cellisValido"
        '
        'cellNumeroDocumentoIndice
        '
        Me.cellNumeroDocumentoIndice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cellNumeroDocumentoIndice.DataPropertyName = "Documento"
        Me.cellNumeroDocumentoIndice.HeaderText = "NumeroDocumento"
        Me.cellNumeroDocumentoIndice.Name = "cellNumeroDocumentoIndice"
        '
        'cellTipoDocumentoIndice
        '
        Me.cellTipoDocumentoIndice.DataPropertyName = "TipoDocumento"
        Me.cellTipoDocumentoIndice.HeaderText = "TipoDocumento"
        Me.cellTipoDocumentoIndice.Name = "cellTipoDocumentoIndice"
        Me.cellTipoDocumentoIndice.Visible = False
        '
        'cellProveedorIndice
        '
        Me.cellProveedorIndice.DataPropertyName = "Proveedor"
        Me.cellProveedorIndice.HeaderText = "Proveedor"
        Me.cellProveedorIndice.Name = "cellProveedorIndice"
        Me.cellProveedorIndice.Visible = False
        '
        'cellIdDocumento
        '
        Me.cellIdDocumento.DataPropertyName = "IdDocumento"
        Me.cellIdDocumento.HeaderText = "IdDocumento"
        Me.cellIdDocumento.Name = "cellIdDocumento"
        Me.cellIdDocumento.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDocumentos)
        Me.TabControl1.Location = New System.Drawing.Point(147, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(771, 154)
        Me.TabControl1.TabIndex = 12
        '
        'tabDocumentos
        '
        Me.tabDocumentos.Controls.Add(Me.grbDocumentos)
        Me.tabDocumentos.Location = New System.Drawing.Point(4, 22)
        Me.tabDocumentos.Name = "tabDocumentos"
        Me.tabDocumentos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDocumentos.Size = New System.Drawing.Size(763, 128)
        Me.tabDocumentos.TabIndex = 0
        Me.tabDocumentos.Text = "Documento"
        Me.tabDocumentos.UseVisualStyleBackColor = True
        '
        'grbDocumentos
        '
        Me.grbDocumentos.BackColor = System.Drawing.Color.White
        Me.grbDocumentos.Controls.Add(Me.cboBaseLegal)
        Me.grbDocumentos.Controls.Add(Me.lblBaseLegal)
        Me.grbDocumentos.Controls.Add(Me.txtOrdenDeServicio)
        Me.grbDocumentos.Controls.Add(Me.Label29)
        Me.grbDocumentos.Controls.Add(Me.txtOrdenDeCompra)
        Me.grbDocumentos.Controls.Add(Me.Label27)
        Me.grbDocumentos.Controls.Add(Me.txtValorRetencionBienes)
        Me.grbDocumentos.Controls.Add(Me.txtValorRetencion)
        Me.grbDocumentos.Controls.Add(Me.Label19)
        Me.grbDocumentos.Controls.Add(Me.Label13)
        Me.grbDocumentos.Controls.Add(Me.TxtIvaServiciosGasto)
        Me.grbDocumentos.Controls.Add(Me.TxtIvaBienesGasto)
        Me.grbDocumentos.Controls.Add(Me.TxtIvaServicios)
        Me.grbDocumentos.Controls.Add(Me.TxtIvaBienes)
        Me.grbDocumentos.Controls.Add(Me.cboMoneda)
        Me.grbDocumentos.Controls.Add(Me.txtValorIVA)
        Me.grbDocumentos.Controls.Add(Me.lblValorIva)
        Me.grbDocumentos.Controls.Add(Me.TxtTipoDeCambio)
        Me.grbDocumentos.Controls.Add(Me.chkReclamaIVA)
        Me.grbDocumentos.Controls.Add(Me.Label10)
        Me.grbDocumentos.Controls.Add(Me.cmdNuevoDocumento)
        Me.grbDocumentos.Controls.Add(Me.cmdEliminarDocumento)
        Me.grbDocumentos.Controls.Add(Me.cmdGrabarDocumento)
        Me.grbDocumentos.Controls.Add(Me.cboTipoDocumento)
        Me.grbDocumentos.Controls.Add(Me.Label8)
        Me.grbDocumentos.Controls.Add(Me.TxtFecha)
        Me.grbDocumentos.Controls.Add(Me.txtNIT)
        Me.grbDocumentos.Controls.Add(Me.Label22)
        Me.grbDocumentos.Controls.Add(Me.TxtProveedor)
        Me.grbDocumentos.Controls.Add(Me.TxtNombreProveedor)
        Me.grbDocumentos.Controls.Add(Me.Label21)
        Me.grbDocumentos.Controls.Add(Me.Label20)
        Me.grbDocumentos.Controls.Add(Me.TxtValorServicios)
        Me.grbDocumentos.Controls.Add(Me.Label28)
        Me.grbDocumentos.Controls.Add(Me.TxtValorLiquido)
        Me.grbDocumentos.Controls.Add(Me.Label30)
        Me.grbDocumentos.Controls.Add(Me.TxtValorTotal)
        Me.grbDocumentos.Controls.Add(Me.Label31)
        Me.grbDocumentos.Controls.Add(Me.TxtValorExcentoIva)
        Me.grbDocumentos.Controls.Add(Me.lblExcento)
        Me.grbDocumentos.Controls.Add(Me.TxtValorBienes)
        Me.grbDocumentos.Controls.Add(Me.lblBienes)
        Me.grbDocumentos.Controls.Add(Me.TxtSerie)
        Me.grbDocumentos.Controls.Add(Me.TxtNumeroDocumento)
        Me.grbDocumentos.Controls.Add(Me.Label17)
        Me.grbDocumentos.Controls.Add(Me.Label16)
        Me.grbDocumentos.Controls.Add(Me.Label15)
        Me.grbDocumentos.Controls.Add(Me.Label14)
        Me.grbDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbDocumentos.Location = New System.Drawing.Point(3, 3)
        Me.grbDocumentos.Name = "grbDocumentos"
        Me.grbDocumentos.Size = New System.Drawing.Size(757, 122)
        Me.grbDocumentos.TabIndex = 0
        Me.grbDocumentos.TabStop = False
        '
        'cboBaseLegal
        '
        Me.cboBaseLegal.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboBaseLegal.cnDefault = "Data Source=sqlsdgua3;Initial Catalog=DbContabilidad;Integrated Security=True; Ap" & _
    "plication Name=Pagos"
        Me.cboBaseLegal.Codigo = ""
        Me.cboBaseLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseLegal.FormattingEnabled = True
        Me.cboBaseLegal.Location = New System.Drawing.Point(179, 97)
        Me.cboBaseLegal.Name = "cboBaseLegal"
        Me.cboBaseLegal.NavegarConEnter = True
        Me.cboBaseLegal.Separador = "-"
        Me.cboBaseLegal.Size = New System.Drawing.Size(66, 21)
        Me.cboBaseLegal.sqlQuery = ""
        Me.cboBaseLegal.TabIndex = 37
        Me.cboBaseLegal.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboBaseLegal.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboBaseLegal.ValidAllText = False
        Me.cboBaseLegal.Visible = False
        '
        'lblBaseLegal
        '
        Me.lblBaseLegal.AutoSize = True
        Me.lblBaseLegal.Location = New System.Drawing.Point(177, 84)
        Me.lblBaseLegal.Name = "lblBaseLegal"
        Me.lblBaseLegal.Size = New System.Drawing.Size(60, 13)
        Me.lblBaseLegal.TabIndex = 38
        Me.lblBaseLegal.Text = "Base Legal"
        Me.lblBaseLegal.Visible = False
        '
        'txtOrdenDeServicio
        '
        Me.txtOrdenDeServicio.AutoTrim = True
        Me.txtOrdenDeServicio.BackColor = System.Drawing.Color.LightGray
        Me.txtOrdenDeServicio.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtOrdenDeServicio.BordeNormal = System.Drawing.Color.DimGray
        Me.txtOrdenDeServicio.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtOrdenDeServicio.BordesRedondeados = False
        Me.txtOrdenDeServicio.CantidadDecimales = CType(2, Short)
        Me.txtOrdenDeServicio.CantidadEnteros = CType(2, Short)
        Me.txtOrdenDeServicio.Location = New System.Drawing.Point(94, 97)
        Me.txtOrdenDeServicio.MaxLength = 10
        Me.txtOrdenDeServicio.Name = "txtOrdenDeServicio"
        Me.txtOrdenDeServicio.NavegarConEnter = True
        Me.txtOrdenDeServicio.NumeroDeDecimales = 0
        Me.txtOrdenDeServicio.Size = New System.Drawing.Size(79, 20)
        Me.txtOrdenDeServicio.TabIndex = 35
        Me.txtOrdenDeServicio.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtOrdenDeServicio.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtOrdenDeServicio.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtOrdenDeServicio.ValidChars = Nothing
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(93, 84)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 13)
        Me.Label29.TabIndex = 36
        Me.Label29.Text = "Orden Servicio"
        '
        'txtOrdenDeCompra
        '
        Me.txtOrdenDeCompra.AutoTrim = True
        Me.txtOrdenDeCompra.BackColor = System.Drawing.Color.LightGray
        Me.txtOrdenDeCompra.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtOrdenDeCompra.BordeNormal = System.Drawing.Color.DimGray
        Me.txtOrdenDeCompra.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtOrdenDeCompra.BordesRedondeados = False
        Me.txtOrdenDeCompra.CantidadDecimales = CType(2, Short)
        Me.txtOrdenDeCompra.CantidadEnteros = CType(2, Short)
        Me.txtOrdenDeCompra.Location = New System.Drawing.Point(10, 97)
        Me.txtOrdenDeCompra.MaxLength = 10
        Me.txtOrdenDeCompra.Name = "txtOrdenDeCompra"
        Me.txtOrdenDeCompra.NavegarConEnter = True
        Me.txtOrdenDeCompra.NumeroDeDecimales = 0
        Me.txtOrdenDeCompra.Size = New System.Drawing.Size(79, 20)
        Me.txtOrdenDeCompra.TabIndex = 33
        Me.txtOrdenDeCompra.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtOrdenDeCompra.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtOrdenDeCompra.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtOrdenDeCompra.ValidChars = Nothing
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 84)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 13)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Orden Compra"
        '
        'txtValorRetencionBienes
        '
        Me.txtValorRetencionBienes.AutoTrim = True
        Me.txtValorRetencionBienes.BackColor = System.Drawing.Color.LightGreen
        Me.txtValorRetencionBienes.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorRetencionBienes.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorRetencionBienes.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorRetencionBienes.BordesRedondeados = False
        Me.txtValorRetencionBienes.CantidadDecimales = CType(2, Short)
        Me.txtValorRetencionBienes.CantidadEnteros = CType(15, Short)
        Me.txtValorRetencionBienes.Location = New System.Drawing.Point(488, 97)
        Me.txtValorRetencionBienes.MaxLength = 18
        Me.txtValorRetencionBienes.Name = "txtValorRetencionBienes"
        Me.txtValorRetencionBienes.NavegarConEnter = True
        Me.txtValorRetencionBienes.NumeroDeDecimales = 0
        Me.txtValorRetencionBienes.ReadOnly = True
        Me.txtValorRetencionBienes.Size = New System.Drawing.Size(89, 20)
        Me.txtValorRetencionBienes.TabIndex = 32
        Me.txtValorRetencionBienes.Text = "0.00"
        Me.txtValorRetencionBienes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorRetencionBienes.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtValorRetencionBienes.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValorRetencionBienes.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValorRetencionBienes.ValidChars = Nothing
        '
        'txtValorRetencion
        '
        Me.txtValorRetencion.AutoTrim = True
        Me.txtValorRetencion.BackColor = System.Drawing.Color.LightGreen
        Me.txtValorRetencion.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorRetencion.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorRetencion.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorRetencion.BordesRedondeados = False
        Me.txtValorRetencion.CantidadDecimales = CType(2, Short)
        Me.txtValorRetencion.CantidadEnteros = CType(15, Short)
        Me.txtValorRetencion.Location = New System.Drawing.Point(406, 97)
        Me.txtValorRetencion.MaxLength = 18
        Me.txtValorRetencion.Name = "txtValorRetencion"
        Me.txtValorRetencion.NavegarConEnter = True
        Me.txtValorRetencion.NumeroDeDecimales = 0
        Me.txtValorRetencion.ReadOnly = True
        Me.txtValorRetencion.Size = New System.Drawing.Size(81, 20)
        Me.txtValorRetencion.TabIndex = 31
        Me.txtValorRetencion.Text = "0.00"
        Me.txtValorRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorRetencion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtValorRetencion.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValorRetencion.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValorRetencion.ValidChars = Nothing
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(491, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "ISR Bien"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(411, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "ISR Serv."
        '
        'TxtIvaServiciosGasto
        '
        Me.TxtIvaServiciosGasto.AutoTrim = True
        Me.TxtIvaServiciosGasto.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtIvaServiciosGasto.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtIvaServiciosGasto.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtIvaServiciosGasto.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtIvaServiciosGasto.BordesRedondeados = False
        Me.TxtIvaServiciosGasto.CantidadDecimales = CType(2, Short)
        Me.TxtIvaServiciosGasto.CantidadEnteros = CType(15, Short)
        Me.TxtIvaServiciosGasto.Location = New System.Drawing.Point(367, 61)
        Me.TxtIvaServiciosGasto.MaxLength = 18
        Me.TxtIvaServiciosGasto.Name = "TxtIvaServiciosGasto"
        Me.TxtIvaServiciosGasto.NavegarConEnter = True
        Me.TxtIvaServiciosGasto.NumeroDeDecimales = 0
        Me.TxtIvaServiciosGasto.Size = New System.Drawing.Size(10, 20)
        Me.TxtIvaServiciosGasto.TabIndex = 28
        Me.TxtIvaServiciosGasto.Text = "0.00"
        Me.TxtIvaServiciosGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIvaServiciosGasto.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtIvaServiciosGasto.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtIvaServiciosGasto.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtIvaServiciosGasto.ValidChars = Nothing
        Me.TxtIvaServiciosGasto.Visible = False
        '
        'TxtIvaBienesGasto
        '
        Me.TxtIvaBienesGasto.AutoTrim = True
        Me.TxtIvaBienesGasto.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtIvaBienesGasto.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtIvaBienesGasto.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtIvaBienesGasto.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtIvaBienesGasto.BordesRedondeados = False
        Me.TxtIvaBienesGasto.CantidadDecimales = CType(2, Short)
        Me.TxtIvaBienesGasto.CantidadEnteros = CType(15, Short)
        Me.TxtIvaBienesGasto.Location = New System.Drawing.Point(358, 61)
        Me.TxtIvaBienesGasto.MaxLength = 18
        Me.TxtIvaBienesGasto.Name = "TxtIvaBienesGasto"
        Me.TxtIvaBienesGasto.NavegarConEnter = True
        Me.TxtIvaBienesGasto.NumeroDeDecimales = 0
        Me.TxtIvaBienesGasto.Size = New System.Drawing.Size(13, 20)
        Me.TxtIvaBienesGasto.TabIndex = 27
        Me.TxtIvaBienesGasto.Text = "0.00"
        Me.TxtIvaBienesGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIvaBienesGasto.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtIvaBienesGasto.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtIvaBienesGasto.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtIvaBienesGasto.ValidChars = Nothing
        Me.TxtIvaBienesGasto.Visible = False
        '
        'TxtIvaServicios
        '
        Me.TxtIvaServicios.AutoTrim = True
        Me.TxtIvaServicios.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtIvaServicios.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtIvaServicios.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtIvaServicios.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtIvaServicios.BordesRedondeados = False
        Me.TxtIvaServicios.CantidadDecimales = CType(2, Short)
        Me.TxtIvaServicios.CantidadEnteros = CType(15, Short)
        Me.TxtIvaServicios.Location = New System.Drawing.Point(373, 61)
        Me.TxtIvaServicios.MaxLength = 18
        Me.TxtIvaServicios.Name = "TxtIvaServicios"
        Me.TxtIvaServicios.NavegarConEnter = True
        Me.TxtIvaServicios.NumeroDeDecimales = 0
        Me.TxtIvaServicios.Size = New System.Drawing.Size(12, 20)
        Me.TxtIvaServicios.TabIndex = 26
        Me.TxtIvaServicios.Text = "0.00"
        Me.TxtIvaServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIvaServicios.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtIvaServicios.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtIvaServicios.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtIvaServicios.ValidChars = Nothing
        Me.TxtIvaServicios.Visible = False
        '
        'TxtIvaBienes
        '
        Me.TxtIvaBienes.AutoTrim = True
        Me.TxtIvaBienes.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtIvaBienes.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtIvaBienes.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtIvaBienes.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtIvaBienes.BordesRedondeados = False
        Me.TxtIvaBienes.CantidadDecimales = CType(2, Short)
        Me.TxtIvaBienes.CantidadEnteros = CType(15, Short)
        Me.TxtIvaBienes.Location = New System.Drawing.Point(381, 61)
        Me.TxtIvaBienes.MaxLength = 18
        Me.TxtIvaBienes.Name = "TxtIvaBienes"
        Me.TxtIvaBienes.NavegarConEnter = True
        Me.TxtIvaBienes.NumeroDeDecimales = 0
        Me.TxtIvaBienes.Size = New System.Drawing.Size(10, 20)
        Me.TxtIvaBienes.TabIndex = 25
        Me.TxtIvaBienes.Text = "0.00"
        Me.TxtIvaBienes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIvaBienes.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtIvaBienes.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtIvaBienes.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtIvaBienes.ValidChars = Nothing
        Me.TxtIvaBienes.Visible = False
        '
        'cboMoneda
        '
        Me.cboMoneda.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboMoneda.cnDefault = "Data Source=sqlsdgua3;Initial Catalog=DbContabilidad;Integrated Security=True; Ap" & _
    "plication Name=Pagos"
        Me.cboMoneda.Codigo = ""
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(253, 97)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.NavegarConEnter = True
        Me.cboMoneda.Separador = "-"
        Me.cboMoneda.Size = New System.Drawing.Size(81, 21)
        Me.cboMoneda.sqlQuery = ""
        Me.cboMoneda.TabIndex = 0
        Me.cboMoneda.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboMoneda.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboMoneda.ValidAllText = False
        '
        'txtValorIVA
        '
        Me.txtValorIVA.AutoTrim = True
        Me.txtValorIVA.BackColor = System.Drawing.Color.LightGreen
        Me.txtValorIVA.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorIVA.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorIVA.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorIVA.BordesRedondeados = False
        Me.txtValorIVA.CantidadDecimales = CType(2, Short)
        Me.txtValorIVA.CantidadEnteros = CType(15, Short)
        Me.txtValorIVA.Location = New System.Drawing.Point(301, 61)
        Me.txtValorIVA.MaxLength = 18
        Me.txtValorIVA.Name = "txtValorIVA"
        Me.txtValorIVA.NavegarConEnter = True
        Me.txtValorIVA.NumeroDeDecimales = 0
        Me.txtValorIVA.ReadOnly = True
        Me.txtValorIVA.Size = New System.Drawing.Size(91, 20)
        Me.txtValorIVA.TabIndex = 23
        Me.txtValorIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorIVA.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtValorIVA.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtValorIVA.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtValorIVA.ValidChars = Nothing
        '
        'lblValorIva
        '
        Me.lblValorIva.AutoSize = True
        Me.lblValorIva.Location = New System.Drawing.Point(298, 48)
        Me.lblValorIva.Name = "lblValorIva"
        Me.lblValorIva.Size = New System.Drawing.Size(51, 13)
        Me.lblValorIva.TabIndex = 24
        Me.lblValorIva.Text = "Valor IVA"
        '
        'TxtTipoDeCambio
        '
        Me.TxtTipoDeCambio.AutoTrim = True
        Me.TxtTipoDeCambio.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTipoDeCambio.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtTipoDeCambio.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtTipoDeCambio.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtTipoDeCambio.BordesRedondeados = False
        Me.TxtTipoDeCambio.CantidadDecimales = CType(2, Short)
        Me.TxtTipoDeCambio.CantidadEnteros = CType(2, Short)
        Me.TxtTipoDeCambio.Location = New System.Drawing.Point(336, 97)
        Me.TxtTipoDeCambio.MaxLength = 7
        Me.TxtTipoDeCambio.Name = "TxtTipoDeCambio"
        Me.TxtTipoDeCambio.NavegarConEnter = True
        Me.TxtTipoDeCambio.NumeroDeDecimales = 0
        Me.TxtTipoDeCambio.ReadOnly = True
        Me.TxtTipoDeCambio.Size = New System.Drawing.Size(70, 20)
        Me.TxtTipoDeCambio.TabIndex = 19
        Me.TxtTipoDeCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTipoDeCambio.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtTipoDeCambio.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtTipoDeCambio.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtTipoDeCambio.ValidChars = Nothing
        '
        'chkReclamaIVA
        '
        Me.chkReclamaIVA.AutoSize = True
        Me.chkReclamaIVA.Checked = True
        Me.chkReclamaIVA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReclamaIVA.Location = New System.Drawing.Point(666, 3)
        Me.chkReclamaIVA.Name = "chkReclamaIVA"
        Me.chkReclamaIVA.Size = New System.Drawing.Size(88, 17)
        Me.chkReclamaIVA.TabIndex = 22
        Me.chkReclamaIVA.Text = "Reclama IVA"
        Me.chkReclamaIVA.UseVisualStyleBackColor = True
        '
        'cmdNuevoDocumento
        '
        Me.cmdNuevoDocumento.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Document_64
        Me.cmdNuevoDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNuevoDocumento.Location = New System.Drawing.Point(640, 58)
        Me.cmdNuevoDocumento.Name = "cmdNuevoDocumento"
        Me.cmdNuevoDocumento.Size = New System.Drawing.Size(57, 53)
        Me.cmdNuevoDocumento.TabIndex = 8
        Me.tltMensajes.SetToolTip(Me.cmdNuevoDocumento, "Nuevo documento")
        Me.cmdNuevoDocumento.UseVisualStyleBackColor = True
        '
        'cmdEliminarDocumento
        '
        Me.cmdEliminarDocumento.BackgroundImage = Global.Cooperativa.My.Resources.Resources.delete_48
        Me.cmdEliminarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEliminarDocumento.Location = New System.Drawing.Point(697, 58)
        Me.cmdEliminarDocumento.Name = "cmdEliminarDocumento"
        Me.cmdEliminarDocumento.Size = New System.Drawing.Size(57, 53)
        Me.cmdEliminarDocumento.TabIndex = 9
        Me.tltMensajes.SetToolTip(Me.cmdEliminarDocumento, "Eliminar documento")
        Me.cmdEliminarDocumento.UseVisualStyleBackColor = True
        '
        'cmdGrabarDocumento
        '
        Me.cmdGrabarDocumento.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabarDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGrabarDocumento.Location = New System.Drawing.Point(583, 58)
        Me.cmdGrabarDocumento.Name = "cmdGrabarDocumento"
        Me.cmdGrabarDocumento.Size = New System.Drawing.Size(57, 53)
        Me.cmdGrabarDocumento.TabIndex = 7
        Me.tltMensajes.SetToolTip(Me.cmdGrabarDocumento, "Grabar cambios en el documento")
        Me.cmdGrabarDocumento.UseVisualStyleBackColor = True
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboTipoDocumento.cnDefault = "Data Source=sqlsdgua3;Initial Catalog=DbContabilidad;Integrated Security=True; Ap" & _
    "plication Name=Pagos"
        Me.cboTipoDocumento.Codigo = ""
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(10, 27)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.NavegarConEnter = True
        Me.cboTipoDocumento.Separador = "-"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(152, 21)
        Me.cboTipoDocumento.sqlQuery = ""
        Me.cboTipoDocumento.TabIndex = 0
        Me.cboTipoDocumento.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboTipoDocumento.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboTipoDocumento.ValidAllText = False
        '
        'TxtFecha
        '
        Me.TxtFecha.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtFecha.Location = New System.Drawing.Point(168, 27)
        Me.TxtFecha.Mask = "00/00/0000"
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.NavegarConEnter = True
        Me.TxtFecha.Size = New System.Drawing.Size(77, 20)
        Me.TxtFecha.TabIndex = 1
        Me.TxtFecha.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtFecha.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'txtNIT
        '
        Me.txtNIT.AutoTrim = True
        Me.txtNIT.BackColor = System.Drawing.Color.LightGreen
        Me.txtNIT.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNIT.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNIT.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNIT.BordesRedondeados = False
        Me.txtNIT.CantidadDecimales = CType(2, Short)
        Me.txtNIT.CantidadEnteros = CType(2, Short)
        Me.txtNIT.Location = New System.Drawing.Point(477, 27)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.NavegarConEnter = True
        Me.txtNIT.NumeroDeDecimales = 0
        Me.txtNIT.ReadOnly = True
        Me.txtNIT.Size = New System.Drawing.Size(60, 20)
        Me.txtNIT.TabIndex = 21
        Me.txtNIT.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNIT.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNIT.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNIT.ValidChars = Nothing
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(474, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "NIT"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.AutoTrim = True
        Me.TxtProveedor.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtProveedor.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtProveedor.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtProveedor.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtProveedor.BordesRedondeados = False
        Me.TxtProveedor.CantidadDecimales = CType(2, Short)
        Me.TxtProveedor.CantidadEnteros = CType(2, Short)
        Me.TxtProveedor.Location = New System.Drawing.Point(388, 27)
        Me.TxtProveedor.MaxLength = 15
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.NavegarConEnter = True
        Me.TxtProveedor.NumeroDeDecimales = 0
        Me.TxtProveedor.Size = New System.Drawing.Size(83, 20)
        Me.TxtProveedor.TabIndex = 3
        Me.TxtProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtProveedor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtProveedor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtProveedor.ValidChars = Nothing
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.AutoTrim = True
        Me.TxtNombreProveedor.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreProveedor.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtNombreProveedor.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtNombreProveedor.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtNombreProveedor.BordesRedondeados = False
        Me.TxtNombreProveedor.CantidadDecimales = CType(2, Short)
        Me.TxtNombreProveedor.CantidadEnteros = CType(2, Short)
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(542, 27)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.NavegarConEnter = True
        Me.TxtNombreProveedor.NumeroDeDecimales = 0
        Me.TxtNombreProveedor.ReadOnly = True
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(203, 20)
        Me.TxtNombreProveedor.TabIndex = 18
        Me.TxtNombreProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtNombreProveedor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtNombreProveedor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtNombreProveedor.ValidChars = Nothing
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(542, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Nombre Proveedor"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(385, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Proveedor"
        '
        'TxtValorServicios
        '
        Me.TxtValorServicios.AutoTrim = True
        Me.TxtValorServicios.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtValorServicios.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtValorServicios.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtValorServicios.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtValorServicios.BordesRedondeados = False
        Me.TxtValorServicios.CantidadDecimales = CType(2, Short)
        Me.TxtValorServicios.CantidadEnteros = CType(15, Short)
        Me.TxtValorServicios.Location = New System.Drawing.Point(107, 61)
        Me.TxtValorServicios.MaxLength = 18
        Me.TxtValorServicios.Name = "TxtValorServicios"
        Me.TxtValorServicios.NavegarConEnter = True
        Me.TxtValorServicios.NumeroDeDecimales = 0
        Me.TxtValorServicios.Size = New System.Drawing.Size(91, 20)
        Me.TxtValorServicios.TabIndex = 5
        Me.TxtValorServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtValorServicios.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtValorServicios.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtValorServicios.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtValorServicios.ValidChars = Nothing
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(104, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 13)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Valor Servicios"
        '
        'TxtValorLiquido
        '
        Me.TxtValorLiquido.AutoTrim = True
        Me.TxtValorLiquido.BackColor = System.Drawing.Color.LightGreen
        Me.TxtValorLiquido.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtValorLiquido.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtValorLiquido.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtValorLiquido.BordesRedondeados = False
        Me.TxtValorLiquido.CantidadDecimales = CType(2, Short)
        Me.TxtValorLiquido.CantidadEnteros = CType(2, Short)
        Me.TxtValorLiquido.Location = New System.Drawing.Point(395, 61)
        Me.TxtValorLiquido.Name = "TxtValorLiquido"
        Me.TxtValorLiquido.NavegarConEnter = True
        Me.TxtValorLiquido.NumeroDeDecimales = 0
        Me.TxtValorLiquido.ReadOnly = True
        Me.TxtValorLiquido.Size = New System.Drawing.Size(91, 20)
        Me.TxtValorLiquido.TabIndex = 15
        Me.TxtValorLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtValorLiquido.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtValorLiquido.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtValorLiquido.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtValorLiquido.ValidChars = Nothing
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(395, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 14
        Me.Label30.Text = "Valor Liquido"
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.AutoTrim = True
        Me.TxtValorTotal.BackColor = System.Drawing.Color.LightGreen
        Me.TxtValorTotal.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtValorTotal.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtValorTotal.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtValorTotal.BordesRedondeados = False
        Me.TxtValorTotal.CantidadDecimales = CType(2, Short)
        Me.TxtValorTotal.CantidadEnteros = CType(2, Short)
        Me.TxtValorTotal.Location = New System.Drawing.Point(488, 61)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.NavegarConEnter = True
        Me.TxtValorTotal.NumeroDeDecimales = 0
        Me.TxtValorTotal.ReadOnly = True
        Me.TxtValorTotal.Size = New System.Drawing.Size(91, 20)
        Me.TxtValorTotal.TabIndex = 15
        Me.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtValorTotal.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtValorTotal.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtValorTotal.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtValorTotal.ValidChars = Nothing
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(491, 48)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(58, 13)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Valor Total"
        '
        'TxtValorExcentoIva
        '
        Me.TxtValorExcentoIva.AutoTrim = True
        Me.TxtValorExcentoIva.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtValorExcentoIva.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtValorExcentoIva.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtValorExcentoIva.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtValorExcentoIva.BordesRedondeados = False
        Me.TxtValorExcentoIva.CantidadDecimales = CType(2, Short)
        Me.TxtValorExcentoIva.CantidadEnteros = CType(15, Short)
        Me.TxtValorExcentoIva.Location = New System.Drawing.Point(204, 61)
        Me.TxtValorExcentoIva.MaxLength = 18
        Me.TxtValorExcentoIva.Name = "TxtValorExcentoIva"
        Me.TxtValorExcentoIva.NavegarConEnter = True
        Me.TxtValorExcentoIva.NumeroDeDecimales = 0
        Me.TxtValorExcentoIva.Size = New System.Drawing.Size(91, 20)
        Me.TxtValorExcentoIva.TabIndex = 6
        Me.TxtValorExcentoIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtValorExcentoIva.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtValorExcentoIva.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtValorExcentoIva.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtValorExcentoIva.ValidChars = Nothing
        '
        'lblExcento
        '
        Me.lblExcento.AutoSize = True
        Me.lblExcento.Location = New System.Drawing.Point(201, 48)
        Me.lblExcento.Name = "lblExcento"
        Me.lblExcento.Size = New System.Drawing.Size(94, 13)
        Me.lblExcento.TabIndex = 14
        Me.lblExcento.Text = "Valor Excento Iva."
        '
        'TxtValorBienes
        '
        Me.TxtValorBienes.AutoTrim = True
        Me.TxtValorBienes.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtValorBienes.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtValorBienes.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtValorBienes.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtValorBienes.BordesRedondeados = False
        Me.TxtValorBienes.CantidadDecimales = CType(2, Short)
        Me.TxtValorBienes.CantidadEnteros = CType(15, Short)
        Me.TxtValorBienes.Location = New System.Drawing.Point(12, 61)
        Me.TxtValorBienes.MaxLength = 18
        Me.TxtValorBienes.Name = "TxtValorBienes"
        Me.TxtValorBienes.NavegarConEnter = True
        Me.TxtValorBienes.NumeroDeDecimales = 0
        Me.TxtValorBienes.Size = New System.Drawing.Size(91, 20)
        Me.TxtValorBienes.TabIndex = 4
        Me.TxtValorBienes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtValorBienes.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtValorBienes.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtValorBienes.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.TxtValorBienes.ValidChars = Nothing
        '
        'lblBienes
        '
        Me.lblBienes.AutoSize = True
        Me.lblBienes.Location = New System.Drawing.Point(9, 48)
        Me.lblBienes.Name = "lblBienes"
        Me.lblBienes.Size = New System.Drawing.Size(66, 13)
        Me.lblBienes.TabIndex = 14
        Me.lblBienes.Text = "Valor Bienes"
        '
        'TxtSerie
        '
        Me.TxtSerie.AutoTrim = True
        Me.TxtSerie.BackColor = System.Drawing.Color.LightGray
        Me.TxtSerie.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtSerie.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtSerie.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtSerie.BordesRedondeados = False
        Me.TxtSerie.CantidadDecimales = CType(2, Short)
        Me.TxtSerie.CantidadEnteros = CType(2, Short)
        Me.TxtSerie.Location = New System.Drawing.Point(251, 27)
        Me.TxtSerie.MaxLength = 5
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.NavegarConEnter = True
        Me.TxtSerie.NumeroDeDecimales = 0
        Me.TxtSerie.Size = New System.Drawing.Size(44, 20)
        Me.TxtSerie.TabIndex = 11
        Me.TxtSerie.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.TxtSerie.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtSerie.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtSerie.ValidChars = Nothing
        '
        'TxtNumeroDocumento
        '
        Me.TxtNumeroDocumento.AutoTrim = True
        Me.TxtNumeroDocumento.BackColor = System.Drawing.Color.LemonChiffon
        Me.TxtNumeroDocumento.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtNumeroDocumento.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtNumeroDocumento.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtNumeroDocumento.BordesRedondeados = False
        Me.TxtNumeroDocumento.CantidadDecimales = CType(2, Short)
        Me.TxtNumeroDocumento.CantidadEnteros = CType(2, Short)
        Me.TxtNumeroDocumento.Location = New System.Drawing.Point(301, 27)
        Me.TxtNumeroDocumento.MaxLength = 10
        Me.TxtNumeroDocumento.Name = "TxtNumeroDocumento"
        Me.TxtNumeroDocumento.NavegarConEnter = True
        Me.TxtNumeroDocumento.NumeroDeDecimales = 0
        Me.TxtNumeroDocumento.Size = New System.Drawing.Size(79, 20)
        Me.TxtNumeroDocumento.TabIndex = 2
        Me.TxtNumeroDocumento.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.TxtNumeroDocumento.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtNumeroDocumento.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtNumeroDocumento.ValidChars = Nothing
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(250, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Serie"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(300, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "No. Documento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(168, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Fecha"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Tipo Documento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TxtSaldo)
        Me.GroupBox1.Controls.Add(Me.TxtAbonos)
        Me.GroupBox1.Controls.Add(Me.TxtCargos)
        Me.GroupBox1.Location = New System.Drawing.Point(147, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 38)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(605, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Saldos"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(454, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Abonos"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(306, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 13)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Cargos"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaldo.AutoTrim = True
        Me.TxtSaldo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtSaldo.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtSaldo.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtSaldo.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtSaldo.BordesRedondeados = False
        Me.TxtSaldo.CantidadDecimales = CType(2, Short)
        Me.TxtSaldo.CantidadEnteros = CType(2, Short)
        Me.TxtSaldo.Location = New System.Drawing.Point(650, 14)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.NavegarConEnter = True
        Me.TxtSaldo.NumeroDeDecimales = 0
        Me.TxtSaldo.ReadOnly = True
        Me.TxtSaldo.Size = New System.Drawing.Size(96, 20)
        Me.TxtSaldo.TabIndex = 13
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSaldo.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtSaldo.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtSaldo.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtSaldo.ValidChars = Nothing
        '
        'TxtAbonos
        '
        Me.TxtAbonos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAbonos.AutoTrim = True
        Me.TxtAbonos.BackColor = System.Drawing.Color.LightGreen
        Me.TxtAbonos.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtAbonos.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtAbonos.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtAbonos.BordesRedondeados = False
        Me.TxtAbonos.CantidadDecimales = CType(2, Short)
        Me.TxtAbonos.CantidadEnteros = CType(2, Short)
        Me.TxtAbonos.Location = New System.Drawing.Point(503, 14)
        Me.TxtAbonos.Name = "TxtAbonos"
        Me.TxtAbonos.NavegarConEnter = True
        Me.TxtAbonos.NumeroDeDecimales = 0
        Me.TxtAbonos.ReadOnly = True
        Me.TxtAbonos.Size = New System.Drawing.Size(96, 20)
        Me.TxtAbonos.TabIndex = 13
        Me.TxtAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtAbonos.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtAbonos.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtAbonos.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtAbonos.ValidChars = Nothing
        '
        'TxtCargos
        '
        Me.TxtCargos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCargos.AutoTrim = True
        Me.TxtCargos.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCargos.BordeDisable = System.Drawing.Color.DarkGray
        Me.TxtCargos.BordeNormal = System.Drawing.Color.DimGray
        Me.TxtCargos.BordeOnFocus = System.Drawing.Color.Blue
        Me.TxtCargos.BordesRedondeados = False
        Me.TxtCargos.CantidadDecimales = CType(2, Short)
        Me.TxtCargos.CantidadEnteros = CType(2, Short)
        Me.TxtCargos.Location = New System.Drawing.Point(352, 14)
        Me.TxtCargos.Name = "TxtCargos"
        Me.TxtCargos.NavegarConEnter = True
        Me.TxtCargos.NumeroDeDecimales = 0
        Me.TxtCargos.ReadOnly = True
        Me.TxtCargos.Size = New System.Drawing.Size(96, 20)
        Me.TxtCargos.TabIndex = 13
        Me.TxtCargos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCargos.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.TxtCargos.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.TxtCargos.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.TxtCargos.ValidChars = Nothing
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(151, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Contabilidad"
        '
        'grdContabilidad
        '
        Me.grdContabilidad.AllowUserToAddRows = False
        Me.grdContabilidad.AllowUserToDeleteRows = False
        Me.grdContabilidad.AllowUserToOrderColumns = True
        Me.grdContabilidad.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.grdContabilidad.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdContabilidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdContabilidad.BackgroundColor = System.Drawing.Color.White
        Me.grdContabilidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdContabilidad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdContabilidad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdContabilidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellIdMovimiento, Me.cellCuentaContable, Me.cellDescripcion, Me.cellValor, Me.cellRegistroReservado, Me.cellValido, Me.cellTipoCuentaContable, Me.DocIdDocumento})
        Me.grdContabilidad.ContextMenuStrip = Me.mnuContabilidad
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdContabilidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.grdContabilidad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdContabilidad.Location = New System.Drawing.Point(147, 180)
        Me.grdContabilidad.Name = "grdContabilidad"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdContabilidad.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdContabilidad.RowHeadersWidth = 10
        Me.grdContabilidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdContabilidad.ShowEditingIcon = False
        Me.grdContabilidad.Size = New System.Drawing.Size(373, 141)
        Me.grdContabilidad.TabIndex = 7
        '
        'cellIdMovimiento
        '
        Me.cellIdMovimiento.DataPropertyName = "IdMovimiento"
        Me.cellIdMovimiento.HeaderText = "IdMovimiento"
        Me.cellIdMovimiento.Name = "cellIdMovimiento"
        Me.cellIdMovimiento.Visible = False
        '
        'cellCuentaContable
        '
        Me.cellCuentaContable.DataPropertyName = "CuentaContable"
        Me.cellCuentaContable.HeaderText = "Cuenta Contable"
        Me.cellCuentaContable.Name = "cellCuentaContable"
        '
        'cellDescripcion
        '
        Me.cellDescripcion.DataPropertyName = "Descripcion"
        Me.cellDescripcion.HeaderText = "Descripcion"
        Me.cellDescripcion.Name = "cellDescripcion"
        '
        'cellValor
        '
        Me.cellValor.DataPropertyName = "Valor"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.cellValor.DefaultCellStyle = DataGridViewCellStyle7
        Me.cellValor.HeaderText = "Valor"
        Me.cellValor.Name = "cellValor"
        '
        'cellRegistroReservado
        '
        Me.cellRegistroReservado.DataPropertyName = "RegistroReservado"
        Me.cellRegistroReservado.HeaderText = "RegistroReservado"
        Me.cellRegistroReservado.Name = "cellRegistroReservado"
        Me.cellRegistroReservado.Visible = False
        '
        'cellValido
        '
        Me.cellValido.DataPropertyName = "Valido"
        Me.cellValido.HeaderText = "Valido"
        Me.cellValido.Name = "cellValido"
        Me.cellValido.Visible = False
        '
        'cellTipoCuentaContable
        '
        Me.cellTipoCuentaContable.DataPropertyName = "TipoCuentaContable"
        Me.cellTipoCuentaContable.HeaderText = "TipoCuentaContable"
        Me.cellTipoCuentaContable.Name = "cellTipoCuentaContable"
        Me.cellTipoCuentaContable.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cellTipoCuentaContable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cellTipoCuentaContable.Visible = False
        '
        'DocIdDocumento
        '
        Me.DocIdDocumento.DataPropertyName = "IdDocumento"
        Me.DocIdDocumento.HeaderText = "IdDocumento"
        Me.DocIdDocumento.Name = "DocIdDocumento"
        Me.DocIdDocumento.Visible = False
        '
        'mnuContabilidad
        '
        Me.mnuContabilidad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGrabarContabilidad, Me.mnuModificar, Me.mnuEliminar})
        Me.mnuContabilidad.Name = "mnuContabilidad"
        Me.mnuContabilidad.Size = New System.Drawing.Size(126, 70)
        '
        'mnuGrabarContabilidad
        '
        Me.mnuGrabarContabilidad.Name = "mnuGrabarContabilidad"
        Me.mnuGrabarContabilidad.Size = New System.Drawing.Size(125, 22)
        Me.mnuGrabarContabilidad.Text = "Grabar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.Size = New System.Drawing.Size(125, 22)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(125, 22)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grbEncabezado, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grbDetalle, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(929, 543)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'tltMensajes
        '
        Me.tltMensajes.IsBalloon = True
        '
        'FrmSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(937, 550)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmSolicitud"
        Me.Text = "-- :: Solicitud De Pago :: --"
        Me.grbEncabezado.ResumeLayout(False)
        Me.grbEncabezado.PerformLayout()
        Me.grbBanco.ResumeLayout(False)
        Me.grbBanco.PerformLayout()
        Me.grbDetalle.ResumeLayout(False)
        Me.grbDetalle.PerformLayout()
        Me.grbContabilidad.ResumeLayout(False)
        Me.grbContabilidad.PerformLayout()
        CType(Me.grdIndice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabDocumentos.ResumeLayout(False)
        Me.grbDocumentos.ResumeLayout(False)
        Me.grbDocumentos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdContabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuContabilidad.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombre As Library.TextBoxSD
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaDePago As Library.MaskedTextBoxSD
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaSolicitud As Library.MaskedTextBoxSD
    Friend WithEvents grbBanco As System.Windows.Forms.GroupBox
    Friend WithEvents TxtValorOtraMoneda As Library.TextBoxSD
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFechaDocumento As Library.MaskedTextBoxSD
    Friend WithEvents TxtDocumentoBancos As Library.TextBoxSD
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As Library.TextBoxSD
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtUtilizacion As Library.TextBoxSD
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTipoDeCambio As Library.TextBoxSD
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grbDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents grbDocumentos As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grdContabilidad As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtProveedor As Library.TextBoxSD
    Friend WithEvents TxtNombreProveedor As Library.TextBoxSD
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtSerie As Library.TextBoxSD
    Friend WithEvents TxtNumeroDocumento As Library.TextBoxSD
    Friend WithEvents txtNIT As Library.TextBoxSD
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TxtFecha As Library.MaskedTextBoxSD
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtSaldo As Library.TextBoxSD
    Friend WithEvents TxtAbonos As Library.TextBoxSD
    Friend WithEvents TxtCargos As Library.TextBoxSD
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents TxtValorServicios As Library.TextBoxSD
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtValorLiquido As Library.TextBoxSD
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtValorTotal As Library.TextBoxSD
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxtValorExcentoIva As Library.TextBoxSD
    Friend WithEvents lblExcento As System.Windows.Forms.Label
    Friend WithEvents TxtValorBienes As Library.TextBoxSD
    Friend WithEvents lblBienes As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As Library.ComboBoxSD
    Friend WithEvents cmdGrabarDocumento As System.Windows.Forms.Button
    Friend WithEvents cmdNuevoDocumento As System.Windows.Forms.Button
    Friend WithEvents cmdEliminarDocumento As System.Windows.Forms.Button
    Friend WithEvents txtValor As Library.TextBoxSD
    Friend WithEvents tltMensajes As System.Windows.Forms.ToolTip
    Friend WithEvents cmdNuevoEncabezado As System.Windows.Forms.Button
    Friend WithEvents cmdGrabarEncabezado As System.Windows.Forms.Button
    Friend WithEvents cboMoneda As Library.ComboBoxSD
    Friend WithEvents txtProveedorSolicitud As Library.TextBoxSD
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSolicitud As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabDocumentos As System.Windows.Forms.TabPage
    Friend WithEvents chkReclamaIVA As System.Windows.Forms.CheckBox
    Friend WithEvents txtValorIVA As Library.TextBoxSD
    Friend WithEvents lblValorIva As System.Windows.Forms.Label
    Friend WithEvents TxtIvaBienes As Library.TextBoxSD
    Friend WithEvents TxtIvaServicios As Library.TextBoxSD
    Friend WithEvents TxtIvaBienesGasto As Library.TextBoxSD
    Friend WithEvents TxtIvaServiciosGasto As Library.TextBoxSD
    Friend WithEvents grdIndice As System.Windows.Forms.DataGridView
    Friend WithEvents mnuContabilidad As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuGrabarContabilidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtValorRetencionBienes As Library.TextBoxSD
    Friend WithEvents txtValorRetencion As Library.TextBoxSD
    Friend WithEvents txtOrdenDeServicio As Library.TextBoxSD
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenDeCompra As Library.TextBoxSD
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboBaseLegal As Library.ComboBoxSD
    Friend WithEvents lblBaseLegal As System.Windows.Forms.Label
    Friend WithEvents chkValidSolicitud As System.Windows.Forms.CheckBox
    Friend WithEvents cboCuentasBancarias As Library.ComboBoxSD
    Friend WithEvents cboBancos As Library.ComboBoxSD
    Friend WithEvents cmdContabilizar As System.Windows.Forms.Button
    Friend WithEvents cellIdMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellRegistroReservado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellValido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cellTipoCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocIdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellisValido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cellNumeroDocumentoIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellTipoDocumentoIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellProveedorIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellIdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdBoletaTransaccion As System.Windows.Forms.Button
    Friend WithEvents grbContabilidad As System.Windows.Forms.GroupBox
    Friend WithEvents lblSaldoContabilidad As System.Windows.Forms.Label
    Friend WithEvents cmdGrabarContabilidad As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblNombreCuentaContabilidad As System.Windows.Forms.Label
    Friend WithEvents txtValorContabilidad As Library.TextBoxSD
    Friend WithEvents txtDescripcionContabilidad As Library.TextBoxSD
    Friend WithEvents txtCuentaContableContabilidad As Library.TextBoxSD
    Friend WithEvents cmdEliminarSolicitud As System.Windows.Forms.Button
End Class
