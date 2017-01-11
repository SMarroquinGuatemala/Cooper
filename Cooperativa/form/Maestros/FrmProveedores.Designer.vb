<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Me.grbDatosProveedor = New System.Windows.Forms.GroupBox()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.chkAplicaComoCliente = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTipoRetencion = New Library.ComboBoxSD()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkAplicaRetencion = New System.Windows.Forms.CheckBox()
        Me.txtTasaRetencion = New Library.TextBoxSD()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContacto = New Library.TextBoxSD()
        Me.txtEmailContacto = New Library.TextBoxSD()
        Me.txtDPI = New Library.TextBoxSD()
        Me.txtTelefono2 = New Library.TextBoxSD()
        Me.txtTelefono1 = New Library.TextBoxSD()
        Me.txtNITProveedor = New Library.TextBoxSD()
        Me.txtDireccion = New Library.TextBoxSD()
        Me.txtActividadProveedor = New Library.TextBoxSD()
        Me.txtNombreCorto = New Library.TextBoxSD()
        Me.txtNombreLargo = New Library.TextBoxSD()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.grdProveedores = New System.Windows.Forms.DataGridView()
        Me.cellProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellNombreLargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellNombreCorto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellActividadProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellNITProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellTelefono1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellTelefono2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellEmailContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellTasaRetencionISR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellTipoRetencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellAplicaRetencion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cellProveedorActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cellAplicaComoCliente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cellDPI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.grbDatosProveedor.SuspendLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbDatosProveedor
        '
        Me.grbDatosProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDatosProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.grbDatosProveedor.Controls.Add(Me.cmdGrabar)
        Me.grbDatosProveedor.Controls.Add(Me.cmdNuevo)
        Me.grbDatosProveedor.Controls.Add(Me.cmdBuscar)
        Me.grbDatosProveedor.Controls.Add(Me.chkAplicaComoCliente)
        Me.grbDatosProveedor.Controls.Add(Me.Label7)
        Me.grbDatosProveedor.Controls.Add(Me.cboTipoRetencion)
        Me.grbDatosProveedor.Controls.Add(Me.chkActivo)
        Me.grbDatosProveedor.Controls.Add(Me.Label18)
        Me.grbDatosProveedor.Controls.Add(Me.chkAplicaRetencion)
        Me.grbDatosProveedor.Controls.Add(Me.txtTasaRetencion)
        Me.grbDatosProveedor.Controls.Add(Me.Label14)
        Me.grbDatosProveedor.Controls.Add(Me.Label13)
        Me.grbDatosProveedor.Controls.Add(Me.Label12)
        Me.grbDatosProveedor.Controls.Add(Me.Label11)
        Me.grbDatosProveedor.Controls.Add(Me.Label10)
        Me.grbDatosProveedor.Controls.Add(Me.Label6)
        Me.grbDatosProveedor.Controls.Add(Me.Label5)
        Me.grbDatosProveedor.Controls.Add(Me.Label4)
        Me.grbDatosProveedor.Controls.Add(Me.Label3)
        Me.grbDatosProveedor.Controls.Add(Me.Label2)
        Me.grbDatosProveedor.Controls.Add(Me.txtContacto)
        Me.grbDatosProveedor.Controls.Add(Me.txtEmailContacto)
        Me.grbDatosProveedor.Controls.Add(Me.txtDPI)
        Me.grbDatosProveedor.Controls.Add(Me.txtTelefono2)
        Me.grbDatosProveedor.Controls.Add(Me.txtTelefono1)
        Me.grbDatosProveedor.Controls.Add(Me.txtNITProveedor)
        Me.grbDatosProveedor.Controls.Add(Me.txtDireccion)
        Me.grbDatosProveedor.Controls.Add(Me.txtActividadProveedor)
        Me.grbDatosProveedor.Controls.Add(Me.txtNombreCorto)
        Me.grbDatosProveedor.Controls.Add(Me.txtNombreLargo)
        Me.grbDatosProveedor.Controls.Add(Me.Label1)
        Me.grbDatosProveedor.Controls.Add(Me.lblProveedor)
        Me.grbDatosProveedor.Location = New System.Drawing.Point(2, 2)
        Me.grbDatosProveedor.Name = "grbDatosProveedor"
        Me.grbDatosProveedor.Size = New System.Drawing.Size(902, 167)
        Me.grbDatosProveedor.TabIndex = 0
        Me.grbDatosProveedor.TabStop = False
        Me.grbDatosProveedor.Text = "Datos del proveedor"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Image = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabar.Location = New System.Drawing.Point(776, 104)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(58, 57)
        Me.cmdGrabar.TabIndex = 12
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Document_64
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNuevo.Location = New System.Drawing.Point(835, 104)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(57, 57)
        Me.cmdNuevo.TabIndex = 59
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Search_64
        Me.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBuscar.Location = New System.Drawing.Point(718, 104)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(57, 57)
        Me.cmdBuscar.TabIndex = 13
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'chkAplicaComoCliente
        '
        Me.chkAplicaComoCliente.AutoSize = True
        Me.chkAplicaComoCliente.Location = New System.Drawing.Point(111, 16)
        Me.chkAplicaComoCliente.Name = "chkAplicaComoCliente"
        Me.chkAplicaComoCliente.Size = New System.Drawing.Size(119, 17)
        Me.chkAplicaComoCliente.TabIndex = 57
        Me.chkAplicaComoCliente.Text = "Aplica como Cliente"
        Me.chkAplicaComoCliente.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Tipo Retencion"
        '
        'cboTipoRetencion
        '
        Me.cboTipoRetencion.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboTipoRetencion.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboTipoRetencion.Codigo = ""
        Me.cboTipoRetencion.FormattingEnabled = True
        Me.cboTipoRetencion.Location = New System.Drawing.Point(404, 134)
        Me.cboTipoRetencion.Name = "cboTipoRetencion"
        Me.cboTipoRetencion.NavegarConEnter = True
        Me.cboTipoRetencion.Separador = "-"
        Me.cboTipoRetencion.Size = New System.Drawing.Size(120, 21)
        Me.cboTipoRetencion.sqlQuery = ""
        Me.cboTipoRetencion.TabIndex = 11
        Me.cboTipoRetencion.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboTipoRetencion.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboTipoRetencion.ValidAllText = False
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(454, 15)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 54
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(588, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Tasa Retencion"
        '
        'chkAplicaRetencion
        '
        Me.chkAplicaRetencion.AutoSize = True
        Me.chkAplicaRetencion.Enabled = False
        Me.chkAplicaRetencion.Location = New System.Drawing.Point(305, 15)
        Me.chkAplicaRetencion.Name = "chkAplicaRetencion"
        Me.chkAplicaRetencion.Size = New System.Drawing.Size(107, 17)
        Me.chkAplicaRetencion.TabIndex = 52
        Me.chkAplicaRetencion.Text = "Aplica Retencion"
        Me.chkAplicaRetencion.UseVisualStyleBackColor = True
        '
        'txtTasaRetencion
        '
        Me.txtTasaRetencion.AutoTrim = True
        Me.txtTasaRetencion.BackColor = System.Drawing.Color.LightGreen
        Me.txtTasaRetencion.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtTasaRetencion.BordeNormal = System.Drawing.Color.DimGray
        Me.txtTasaRetencion.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtTasaRetencion.BordesRedondeados = False
        Me.txtTasaRetencion.CantidadDecimales = CType(2, Short)
        Me.txtTasaRetencion.CantidadEnteros = CType(15, Short)
        Me.txtTasaRetencion.Location = New System.Drawing.Point(591, 96)
        Me.txtTasaRetencion.Name = "txtTasaRetencion"
        Me.txtTasaRetencion.NavegarConEnter = True
        Me.txtTasaRetencion.NumeroDeDecimales = 0
        Me.txtTasaRetencion.ReadOnly = True
        Me.txtTasaRetencion.Size = New System.Drawing.Size(45, 20)
        Me.txtTasaRetencion.TabIndex = 8
        Me.txtTasaRetencion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtTasaRetencion.TiposDeFormato = Library.TextBoxSD.Formato.Moneda
        Me.txtTasaRetencion.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtTasaRetencion.ValidChars = Nothing
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(213, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Correo Electronico"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(513, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "NIT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(414, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Telefono 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(580, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Actividad Proveedor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(250, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Nombre Corto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Contacto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "DPI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Telefono 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre Largo"
        '
        'txtContacto
        '
        Me.txtContacto.AutoTrim = True
        Me.txtContacto.BackColor = System.Drawing.Color.LightGray
        Me.txtContacto.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtContacto.BordeNormal = System.Drawing.Color.DimGray
        Me.txtContacto.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtContacto.BordesRedondeados = False
        Me.txtContacto.CantidadDecimales = CType(2, Short)
        Me.txtContacto.CantidadEnteros = CType(15, Short)
        Me.txtContacto.Location = New System.Drawing.Point(8, 135)
        Me.txtContacto.MaxLength = 100
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.NavegarConEnter = True
        Me.txtContacto.NumeroDeDecimales = 0
        Me.txtContacto.Size = New System.Drawing.Size(205, 20)
        Me.txtContacto.TabIndex = 9
        Me.txtContacto.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtContacto.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtContacto.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtContacto.ValidChars = Nothing
        '
        'txtEmailContacto
        '
        Me.txtEmailContacto.AutoTrim = True
        Me.txtEmailContacto.BackColor = System.Drawing.Color.LightGray
        Me.txtEmailContacto.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtEmailContacto.BordeNormal = System.Drawing.Color.DimGray
        Me.txtEmailContacto.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtEmailContacto.BordesRedondeados = False
        Me.txtEmailContacto.CantidadDecimales = CType(2, Short)
        Me.txtEmailContacto.CantidadEnteros = CType(15, Short)
        Me.txtEmailContacto.Location = New System.Drawing.Point(216, 135)
        Me.txtEmailContacto.MaxLength = 40
        Me.txtEmailContacto.Name = "txtEmailContacto"
        Me.txtEmailContacto.NavegarConEnter = True
        Me.txtEmailContacto.NumeroDeDecimales = 0
        Me.txtEmailContacto.Size = New System.Drawing.Size(182, 20)
        Me.txtEmailContacto.TabIndex = 10
        Me.txtEmailContacto.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtEmailContacto.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtEmailContacto.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtEmailContacto.ValidChars = Nothing
        '
        'txtDPI
        '
        Me.txtDPI.AutoTrim = True
        Me.txtDPI.BackColor = System.Drawing.Color.LightGray
        Me.txtDPI.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDPI.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDPI.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDPI.BordesRedondeados = False
        Me.txtDPI.CantidadDecimales = CType(2, Short)
        Me.txtDPI.CantidadEnteros = CType(15, Short)
        Me.txtDPI.Location = New System.Drawing.Point(493, 96)
        Me.txtDPI.MaxLength = 15
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.NavegarConEnter = True
        Me.txtDPI.NumeroDeDecimales = 0
        Me.txtDPI.Size = New System.Drawing.Size(96, 20)
        Me.txtDPI.TabIndex = 7
        Me.txtDPI.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtDPI.TiposDeFormato = Library.TextBoxSD.Formato.Texto
        Me.txtDPI.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDPI.ValidChars = Nothing
        '
        'txtTelefono2
        '
        Me.txtTelefono2.AutoTrim = True
        Me.txtTelefono2.BackColor = System.Drawing.Color.LightGray
        Me.txtTelefono2.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtTelefono2.BordeNormal = System.Drawing.Color.DimGray
        Me.txtTelefono2.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtTelefono2.BordesRedondeados = False
        Me.txtTelefono2.CantidadDecimales = CType(2, Short)
        Me.txtTelefono2.CantidadEnteros = CType(15, Short)
        Me.txtTelefono2.Location = New System.Drawing.Point(412, 96)
        Me.txtTelefono2.MaxLength = 15
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.NavegarConEnter = True
        Me.txtTelefono2.NumeroDeDecimales = 0
        Me.txtTelefono2.Size = New System.Drawing.Size(80, 20)
        Me.txtTelefono2.TabIndex = 6
        Me.txtTelefono2.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtTelefono2.TiposDeFormato = Library.TextBoxSD.Formato.Texto
        Me.txtTelefono2.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtTelefono2.ValidChars = Nothing
        '
        'txtTelefono1
        '
        Me.txtTelefono1.AutoTrim = True
        Me.txtTelefono1.BackColor = System.Drawing.Color.LightGray
        Me.txtTelefono1.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtTelefono1.BordeNormal = System.Drawing.Color.DimGray
        Me.txtTelefono1.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtTelefono1.BordesRedondeados = False
        Me.txtTelefono1.CantidadDecimales = CType(2, Short)
        Me.txtTelefono1.CantidadEnteros = CType(15, Short)
        Me.txtTelefono1.Location = New System.Drawing.Point(332, 96)
        Me.txtTelefono1.MaxLength = 15
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.NavegarConEnter = True
        Me.txtTelefono1.NumeroDeDecimales = 0
        Me.txtTelefono1.Size = New System.Drawing.Size(80, 20)
        Me.txtTelefono1.TabIndex = 5
        Me.txtTelefono1.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtTelefono1.TiposDeFormato = Library.TextBoxSD.Formato.Texto
        Me.txtTelefono1.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtTelefono1.ValidChars = Nothing
        '
        'txtNITProveedor
        '
        Me.txtNITProveedor.AutoTrim = True
        Me.txtNITProveedor.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNITProveedor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNITProveedor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNITProveedor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNITProveedor.BordesRedondeados = False
        Me.txtNITProveedor.CantidadDecimales = CType(2, Short)
        Me.txtNITProveedor.CantidadEnteros = CType(15, Short)
        Me.txtNITProveedor.Location = New System.Drawing.Point(512, 57)
        Me.txtNITProveedor.MaxLength = 12
        Me.txtNITProveedor.Name = "txtNITProveedor"
        Me.txtNITProveedor.NavegarConEnter = True
        Me.txtNITProveedor.NumeroDeDecimales = 0
        Me.txtNITProveedor.Size = New System.Drawing.Size(66, 20)
        Me.txtNITProveedor.TabIndex = 2
        Me.txtNITProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNITProveedor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNITProveedor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNITProveedor.ValidChars = Nothing
        '
        'txtDireccion
        '
        Me.txtDireccion.AutoTrim = True
        Me.txtDireccion.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDireccion.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDireccion.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDireccion.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDireccion.BordesRedondeados = False
        Me.txtDireccion.CantidadDecimales = CType(2, Short)
        Me.txtDireccion.CantidadEnteros = CType(15, Short)
        Me.txtDireccion.Location = New System.Drawing.Point(7, 96)
        Me.txtDireccion.MaxLength = 150
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NavegarConEnter = True
        Me.txtDireccion.NumeroDeDecimales = 0
        Me.txtDireccion.Size = New System.Drawing.Size(324, 20)
        Me.txtDireccion.TabIndex = 4
        Me.txtDireccion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtDireccion.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDireccion.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDireccion.ValidChars = Nothing
        '
        'txtActividadProveedor
        '
        Me.txtActividadProveedor.AutoTrim = True
        Me.txtActividadProveedor.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtActividadProveedor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtActividadProveedor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtActividadProveedor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtActividadProveedor.BordesRedondeados = False
        Me.txtActividadProveedor.CantidadDecimales = CType(2, Short)
        Me.txtActividadProveedor.CantidadEnteros = CType(15, Short)
        Me.txtActividadProveedor.Location = New System.Drawing.Point(579, 57)
        Me.txtActividadProveedor.MaxLength = 50
        Me.txtActividadProveedor.Name = "txtActividadProveedor"
        Me.txtActividadProveedor.NavegarConEnter = True
        Me.txtActividadProveedor.NumeroDeDecimales = 0
        Me.txtActividadProveedor.Size = New System.Drawing.Size(313, 20)
        Me.txtActividadProveedor.TabIndex = 3
        Me.txtActividadProveedor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtActividadProveedor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtActividadProveedor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtActividadProveedor.ValidChars = Nothing
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.AutoTrim = True
        Me.txtNombreCorto.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNombreCorto.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreCorto.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreCorto.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreCorto.BordesRedondeados = False
        Me.txtNombreCorto.CantidadDecimales = CType(2, Short)
        Me.txtNombreCorto.CantidadEnteros = CType(15, Short)
        Me.txtNombreCorto.Location = New System.Drawing.Point(253, 57)
        Me.txtNombreCorto.MaxLength = 75
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.NavegarConEnter = True
        Me.txtNombreCorto.NumeroDeDecimales = 0
        Me.txtNombreCorto.Size = New System.Drawing.Size(257, 20)
        Me.txtNombreCorto.TabIndex = 1
        Me.txtNombreCorto.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNombreCorto.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreCorto.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreCorto.ValidChars = Nothing
        '
        'txtNombreLargo
        '
        Me.txtNombreLargo.AutoTrim = True
        Me.txtNombreLargo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNombreLargo.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreLargo.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreLargo.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreLargo.BordesRedondeados = False
        Me.txtNombreLargo.CantidadDecimales = CType(2, Short)
        Me.txtNombreLargo.CantidadEnteros = CType(15, Short)
        Me.txtNombreLargo.Location = New System.Drawing.Point(7, 57)
        Me.txtNombreLargo.MaxLength = 100
        Me.txtNombreLargo.Name = "txtNombreLargo"
        Me.txtNombreLargo.NavegarConEnter = True
        Me.txtNombreLargo.NumeroDeDecimales = 0
        Me.txtNombreLargo.Size = New System.Drawing.Size(245, 20)
        Me.txtNombreLargo.TabIndex = 0
        Me.txtNombreLargo.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNombreLargo.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreLargo.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreLargo.ValidChars = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(677, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.Color.White
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblProveedor.Location = New System.Drawing.Point(810, 10)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(90, 23)
        Me.lblProveedor.TabIndex = 23
        Me.lblProveedor.Text = "0"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdProveedores
        '
        Me.grdProveedores.AllowUserToAddRows = False
        Me.grdProveedores.AllowUserToDeleteRows = False
        Me.grdProveedores.AllowUserToResizeRows = False
        Me.grdProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellProveedor, Me.cellNombreLargo, Me.cellNombreCorto, Me.cellActividadProveedor, Me.cellNITProveedor, Me.cellDireccion, Me.cellTelefono1, Me.cellTelefono2, Me.cellContacto, Me.cellEmailContacto, Me.cellTasaRetencionISR, Me.cellTipoRetencion, Me.cellAplicaRetencion, Me.cellProveedorActivo, Me.cellAplicaComoCliente, Me.cellDPI})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdProveedores.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdProveedores.Location = New System.Drawing.Point(1, 200)
        Me.grdProveedores.Name = "grdProveedores"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdProveedores.RowHeadersVisible = False
        Me.grdProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProveedores.Size = New System.Drawing.Size(903, 277)
        Me.grdProveedores.TabIndex = 1
        '
        'cellProveedor
        '
        Me.cellProveedor.DataPropertyName = "Proveedor"
        Me.cellProveedor.HeaderText = "Proveedor"
        Me.cellProveedor.Name = "cellProveedor"
        '
        'cellNombreLargo
        '
        Me.cellNombreLargo.DataPropertyName = "NombreLargo"
        Me.cellNombreLargo.HeaderText = "NombreLargo"
        Me.cellNombreLargo.Name = "cellNombreLargo"
        '
        'cellNombreCorto
        '
        Me.cellNombreCorto.DataPropertyName = "NombreCorto"
        Me.cellNombreCorto.HeaderText = "NombreCorto"
        Me.cellNombreCorto.Name = "cellNombreCorto"
        '
        'cellActividadProveedor
        '
        Me.cellActividadProveedor.DataPropertyName = "ActividadProveedor"
        Me.cellActividadProveedor.HeaderText = "ActividadProveedor"
        Me.cellActividadProveedor.Name = "cellActividadProveedor"
        '
        'cellNITProveedor
        '
        Me.cellNITProveedor.DataPropertyName = "NITProveedor"
        Me.cellNITProveedor.HeaderText = "NIT"
        Me.cellNITProveedor.Name = "cellNITProveedor"
        '
        'cellDireccion
        '
        Me.cellDireccion.DataPropertyName = "Direccion"
        Me.cellDireccion.HeaderText = "Direccion"
        Me.cellDireccion.Name = "cellDireccion"
        '
        'cellTelefono1
        '
        Me.cellTelefono1.DataPropertyName = "Telefono1"
        Me.cellTelefono1.HeaderText = "Telefono1"
        Me.cellTelefono1.Name = "cellTelefono1"
        '
        'cellTelefono2
        '
        Me.cellTelefono2.DataPropertyName = "Telefono2"
        Me.cellTelefono2.HeaderText = "Telefono2"
        Me.cellTelefono2.Name = "cellTelefono2"
        '
        'cellContacto
        '
        Me.cellContacto.DataPropertyName = "Contacto"
        Me.cellContacto.HeaderText = "Contacto"
        Me.cellContacto.Name = "cellContacto"
        '
        'cellEmailContacto
        '
        Me.cellEmailContacto.DataPropertyName = "EmailContacto"
        Me.cellEmailContacto.HeaderText = "EmailContacto"
        Me.cellEmailContacto.Name = "cellEmailContacto"
        '
        'cellTasaRetencionISR
        '
        Me.cellTasaRetencionISR.DataPropertyName = "TasaRetencionISR"
        Me.cellTasaRetencionISR.HeaderText = "TasaRetencionISR"
        Me.cellTasaRetencionISR.Name = "cellTasaRetencionISR"
        '
        'cellTipoRetencion
        '
        Me.cellTipoRetencion.DataPropertyName = "TipoRetencion"
        Me.cellTipoRetencion.HeaderText = "TipoRetencion"
        Me.cellTipoRetencion.Name = "cellTipoRetencion"
        '
        'cellAplicaRetencion
        '
        Me.cellAplicaRetencion.DataPropertyName = "AplicaRetencion"
        Me.cellAplicaRetencion.HeaderText = "AplicaRetencion"
        Me.cellAplicaRetencion.Name = "cellAplicaRetencion"
        '
        'cellProveedorActivo
        '
        Me.cellProveedorActivo.DataPropertyName = "ProveedorActivo"
        Me.cellProveedorActivo.HeaderText = "ProveedorActivo"
        Me.cellProveedorActivo.Name = "cellProveedorActivo"
        '
        'cellAplicaComoCliente
        '
        Me.cellAplicaComoCliente.DataPropertyName = "AplicaComoCliente"
        Me.cellAplicaComoCliente.HeaderText = "AplicaComoCliente"
        Me.cellAplicaComoCliente.Name = "cellAplicaComoCliente"
        '
        'cellDPI
        '
        Me.cellDPI.DataPropertyName = "DPI"
        Me.cellDPI.HeaderText = "DPI"
        Me.cellDPI.Name = "cellDPI"
        Me.cellDPI.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cellDPI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblMensajes
        '
        Me.lblMensajes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensajes.BackColor = System.Drawing.Color.SteelBlue
        Me.lblMensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajes.ForeColor = System.Drawing.Color.White
        Me.lblMensajes.Location = New System.Drawing.Point(3, 172)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(901, 25)
        Me.lblMensajes.TabIndex = 2
        Me.lblMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 478)
        Me.Controls.Add(Me.lblMensajes)
        Me.Controls.Add(Me.grdProveedores)
        Me.Controls.Add(Me.grbDatosProveedor)
        Me.Name = "FrmProveedores"
        Me.Text = "FrmProveedores"
        Me.grbDatosProveedor.ResumeLayout(False)
        Me.grbDatosProveedor.PerformLayout()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbDatosProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboTipoRetencion As Library.ComboBoxSD
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkAplicaRetencion As System.Windows.Forms.CheckBox
    Friend WithEvents txtTasaRetencion As Library.TextBoxSD
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtContacto As Library.TextBoxSD
    Friend WithEvents txtEmailContacto As Library.TextBoxSD
    Friend WithEvents txtDPI As Library.TextBoxSD
    Friend WithEvents txtTelefono2 As Library.TextBoxSD
    Friend WithEvents txtTelefono1 As Library.TextBoxSD
    Friend WithEvents txtNITProveedor As Library.TextBoxSD
    Friend WithEvents txtDireccion As Library.TextBoxSD
    Friend WithEvents txtActividadProveedor As Library.TextBoxSD
    Friend WithEvents txtNombreCorto As Library.TextBoxSD
    Friend WithEvents txtNombreLargo As Library.TextBoxSD
    Friend WithEvents chkAplicaComoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents grdProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents cellProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellNombreLargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellNombreCorto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellActividadProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellNITProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellTelefono1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellTelefono2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellContacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellEmailContacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellTasaRetencionISR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellTipoRetencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellAplicaRetencion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cellProveedorActivo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cellAplicaComoCliente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cellDPI As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
