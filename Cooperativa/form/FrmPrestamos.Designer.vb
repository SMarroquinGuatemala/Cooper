<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrestamos
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
        Me.txtCantidad = New Library.TextBoxSD()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New Library.TextBoxSD()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtNumeroDeEmpleado = New Library.TextBoxSD()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudMeses = New System.Windows.Forms.NumericUpDown()
        Me.cboModalidad = New Library.ComboBoxSD()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFecha = New Library.MaskedTextBoxSD()
        Me.grbCondicionesFinancieras = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblChequePor = New System.Windows.Forms.Label()
        Me.lblAhorroLibreDeuda = New System.Windows.Forms.Label()
        Me.lblTotalDeuda = New System.Windows.Forms.Label()
        Me.lblSaldoCodeudor = New System.Windows.Forms.Label()
        Me.lblSaldoBazar = New System.Windows.Forms.Label()
        Me.lblSaldoEnPrestamos = New System.Windows.Forms.Label()
        Me.lblAhorroAcumulado = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblCuota = New System.Windows.Forms.Label()
        Me.lblMesesPlazo = New System.Windows.Forms.Label()
        Me.lblAmortizaciones = New System.Windows.Forms.Label()
        Me.lblPorcentajeInteres = New System.Windows.Forms.Label()
        Me.lblIntereses = New System.Windows.Forms.Label()
        Me.lblCapital = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEstadoSolicitud = New System.Windows.Forms.Label()
        Me.tltMensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdAutorizar = New System.Windows.Forms.Button()
        Me.cmdReporte = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.grbCodeudor = New System.Windows.Forms.GroupBox()
        Me.cmdBorrarCodeudor = New System.Windows.Forms.Button()
        Me.cmdAgregarCodeudor = New System.Windows.Forms.Button()
        Me.txtValorCodeudor = New Library.TextBoxSD()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtNombreCodeudor = New Library.TextBoxSD()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCodeudor = New Library.TextBoxSD()
        Me.grdCodeudores = New System.Windows.Forms.DataGridView()
        Me.CellNombreCodeudor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellValorCodeudor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellNumeroDeEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbAmortizaciones = New System.Windows.Forms.GroupBox()
        Me.lblValidSolicitud = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblValorCodeudores = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSolicitando = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblAhorroLibre = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grdAmortizaciones = New System.Windows.Forms.DataGridView()
        Me.cellNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellFechaAmortizacon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellCapitalAmortizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellInteresesAmortizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CellValorAmortizcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellSaldoAmortizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pcbEmpleado = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboRetenciones = New Library.ComboBoxSD()
        CType(Me.nudMeses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCondicionesFinancieras.SuspendLayout()
        Me.grbCodeudor.SuspendLayout()
        CType(Me.grdCodeudores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAmortizaciones.SuspendLayout()
        CType(Me.grdAmortizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoTrim = True
        Me.txtCantidad.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCantidad.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtCantidad.BordeNormal = System.Drawing.Color.DimGray
        Me.txtCantidad.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtCantidad.BordesRedondeados = False
        Me.txtCantidad.CantidadDecimales = CType(2, Short)
        Me.txtCantidad.CantidadEnteros = CType(15, Short)
        Me.txtCantidad.Location = New System.Drawing.Point(250, 73)
        Me.txtCantidad.MaxLength = 12
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NavegarConEnter = True
        Me.txtCantidad.NumeroDeDecimales = 0
        Me.txtCantidad.Size = New System.Drawing.Size(66, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtCantidad.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtCantidad.TiposFiltro = Library.TextBoxSD.Filtro.NumeroDecimal
        Me.txtCantidad.ValidChars = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 592
        Me.Label9.Text = "Cantidad"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.AutoTrim = True
        Me.txtNombreEmpleado.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombreEmpleado.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreEmpleado.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreEmpleado.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreEmpleado.BordesRedondeados = False
        Me.txtNombreEmpleado.CantidadDecimales = CType(2, Short)
        Me.txtNombreEmpleado.CantidadEnteros = CType(15, Short)
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(55, 73)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.NavegarConEnter = True
        Me.txtNombreEmpleado.NumeroDeDecimales = 0
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(189, 20)
        Me.txtNombreEmpleado.TabIndex = 591
        Me.txtNombreEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombreEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreEmpleado.ValidChars = Nothing
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(464, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(145, 130)
        Me.Panel3.TabIndex = 590
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(7, 56)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(48, 13)
        Me.lbl.TabIndex = 587
        Me.lbl.Text = "Emleado"
        '
        'txtNumeroDeEmpleado
        '
        Me.txtNumeroDeEmpleado.AutoTrim = True
        Me.txtNumeroDeEmpleado.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumeroDeEmpleado.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNumeroDeEmpleado.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNumeroDeEmpleado.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNumeroDeEmpleado.BordesRedondeados = False
        Me.txtNumeroDeEmpleado.CantidadDecimales = CType(2, Short)
        Me.txtNumeroDeEmpleado.CantidadEnteros = CType(15, Short)
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(7, 73)
        Me.txtNumeroDeEmpleado.MaxLength = 7
        Me.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado"
        Me.txtNumeroDeEmpleado.NavegarConEnter = True
        Me.txtNumeroDeEmpleado.NumeroDeDecimales = 0
        Me.txtNumeroDeEmpleado.Size = New System.Drawing.Size(48, 20)
        Me.txtNumeroDeEmpleado.TabIndex = 0
        Me.txtNumeroDeEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNumeroDeEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNumeroDeEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNumeroDeEmpleado.ValidChars = Nothing
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(-5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 40)
        Me.Label1.TabIndex = 585
        Me.Label1.Text = "Solicitud De Préstamo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudMeses
        '
        Me.nudMeses.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.nudMeses.Location = New System.Drawing.Point(209, 123)
        Me.nudMeses.Name = "nudMeses"
        Me.nudMeses.Size = New System.Drawing.Size(48, 20)
        Me.nudMeses.TabIndex = 4
        Me.nudMeses.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'cboModalidad
        '
        Me.cboModalidad.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboModalidad.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboModalidad.Codigo = ""
        Me.cboModalidad.FormattingEnabled = True
        Me.cboModalidad.Location = New System.Drawing.Point(82, 123)
        Me.cboModalidad.Name = "cboModalidad"
        Me.cboModalidad.NavegarConEnter = True
        Me.cboModalidad.Separador = "-"
        Me.cboModalidad.Size = New System.Drawing.Size(121, 21)
        Me.cboModalidad.sqlQuery = ""
        Me.cboModalidad.TabIndex = 3
        Me.cboModalidad.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboModalidad.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboModalidad.ValidAllText = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 597
        Me.Label2.Text = "Modalidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 598
        Me.Label3.Text = "Meses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 599
        Me.Label4.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFecha.Location = New System.Drawing.Point(6, 123)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NavegarConEnter = True
        Me.txtFecha.Size = New System.Drawing.Size(70, 20)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFecha.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'grbCondicionesFinancieras
        '
        Me.grbCondicionesFinancieras.BackColor = System.Drawing.Color.White
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label13)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblChequePor)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblAhorroLibreDeuda)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblTotalDeuda)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblSaldoCodeudor)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblSaldoBazar)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblSaldoEnPrestamos)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblAhorroAcumulado)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label27)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label28)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label29)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label30)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label31)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label32)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label33)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblValor)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblCuota)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblMesesPlazo)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblAmortizaciones)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblPorcentajeInteres)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblIntereses)
        Me.grbCondicionesFinancieras.Controls.Add(Me.lblCapital)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label12)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label11)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label10)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label7)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label6)
        Me.grbCondicionesFinancieras.Controls.Add(Me.Label5)
        Me.grbCondicionesFinancieras.Location = New System.Drawing.Point(227, 156)
        Me.grbCondicionesFinancieras.Name = "grbCondicionesFinancieras"
        Me.grbCondicionesFinancieras.Size = New System.Drawing.Size(380, 204)
        Me.grbCondicionesFinancieras.TabIndex = 601
        Me.grbCondicionesFinancieras.TabStop = False
        Me.grbCondicionesFinancieras.Text = "Condiciones Financieras"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 605
        Me.Label13.Text = "Captial .............."
        '
        'lblChequePor
        '
        Me.lblChequePor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblChequePor.Location = New System.Drawing.Point(292, 165)
        Me.lblChequePor.Name = "lblChequePor"
        Me.lblChequePor.Size = New System.Drawing.Size(69, 13)
        Me.lblChequePor.TabIndex = 625
        Me.lblChequePor.Text = "0.00"
        Me.lblChequePor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAhorroLibreDeuda
        '
        Me.lblAhorroLibreDeuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAhorroLibreDeuda.Location = New System.Drawing.Point(292, 142)
        Me.lblAhorroLibreDeuda.Name = "lblAhorroLibreDeuda"
        Me.lblAhorroLibreDeuda.Size = New System.Drawing.Size(69, 13)
        Me.lblAhorroLibreDeuda.TabIndex = 624
        Me.lblAhorroLibreDeuda.Text = "0.00"
        Me.lblAhorroLibreDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalDeuda
        '
        Me.lblTotalDeuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalDeuda.Location = New System.Drawing.Point(292, 119)
        Me.lblTotalDeuda.Name = "lblTotalDeuda"
        Me.lblTotalDeuda.Size = New System.Drawing.Size(69, 13)
        Me.lblTotalDeuda.TabIndex = 623
        Me.lblTotalDeuda.Text = "0.00"
        Me.lblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaldoCodeudor
        '
        Me.lblSaldoCodeudor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoCodeudor.Location = New System.Drawing.Point(292, 96)
        Me.lblSaldoCodeudor.Name = "lblSaldoCodeudor"
        Me.lblSaldoCodeudor.Size = New System.Drawing.Size(69, 13)
        Me.lblSaldoCodeudor.TabIndex = 622
        Me.lblSaldoCodeudor.Text = "0.00"
        Me.lblSaldoCodeudor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaldoBazar
        '
        Me.lblSaldoBazar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoBazar.Location = New System.Drawing.Point(292, 73)
        Me.lblSaldoBazar.Name = "lblSaldoBazar"
        Me.lblSaldoBazar.Size = New System.Drawing.Size(69, 13)
        Me.lblSaldoBazar.TabIndex = 621
        Me.lblSaldoBazar.Text = "0.00"
        Me.lblSaldoBazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaldoEnPrestamos
        '
        Me.lblSaldoEnPrestamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldoEnPrestamos.Location = New System.Drawing.Point(292, 50)
        Me.lblSaldoEnPrestamos.Name = "lblSaldoEnPrestamos"
        Me.lblSaldoEnPrestamos.Size = New System.Drawing.Size(69, 13)
        Me.lblSaldoEnPrestamos.TabIndex = 620
        Me.lblSaldoEnPrestamos.Text = "0.00"
        Me.lblSaldoEnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAhorroAcumulado
        '
        Me.lblAhorroAcumulado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAhorroAcumulado.Location = New System.Drawing.Point(292, 27)
        Me.lblAhorroAcumulado.Name = "lblAhorroAcumulado"
        Me.lblAhorroAcumulado.Size = New System.Drawing.Size(69, 13)
        Me.lblAhorroAcumulado.TabIndex = 619
        Me.lblAhorroAcumulado.Text = "0.00"
        Me.lblAhorroAcumulado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(170, 165)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 13)
        Me.Label27.TabIndex = 618
        Me.Label27.Text = "Cheque Por .................."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(170, 142)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 13)
        Me.Label28.TabIndex = 617
        Me.Label28.Text = "Ahorro Libre Deuda ......"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(170, 119)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 13)
        Me.Label29.TabIndex = 616
        Me.Label29.Text = "Total Deuda ................."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(170, 96)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(119, 13)
        Me.Label30.TabIndex = 615
        Me.Label30.Text = "Saldo Codeudor ..........."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(170, 73)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(121, 13)
        Me.Label31.TabIndex = 614
        Me.Label31.Text = "Saldo Bazar .................."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(170, 50)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(123, 13)
        Me.Label32.TabIndex = 613
        Me.Label32.Text = "Saldo En Préstamos ......"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(170, 27)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(124, 13)
        Me.Label33.TabIndex = 612
        Me.Label33.Text = "Ahorro Acumulado ........."
        '
        'lblValor
        '
        Me.lblValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblValor.Location = New System.Drawing.Point(98, 166)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(69, 13)
        Me.lblValor.TabIndex = 611
        Me.lblValor.Text = "0.00"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCuota
        '
        Me.lblCuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCuota.Location = New System.Drawing.Point(98, 143)
        Me.lblCuota.Name = "lblCuota"
        Me.lblCuota.Size = New System.Drawing.Size(69, 13)
        Me.lblCuota.TabIndex = 610
        Me.lblCuota.Text = "0.00"
        Me.lblCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMesesPlazo
        '
        Me.lblMesesPlazo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMesesPlazo.Location = New System.Drawing.Point(98, 120)
        Me.lblMesesPlazo.Name = "lblMesesPlazo"
        Me.lblMesesPlazo.Size = New System.Drawing.Size(69, 13)
        Me.lblMesesPlazo.TabIndex = 609
        Me.lblMesesPlazo.Text = "0.00"
        Me.lblMesesPlazo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmortizaciones
        '
        Me.lblAmortizaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAmortizaciones.Location = New System.Drawing.Point(98, 97)
        Me.lblAmortizaciones.Name = "lblAmortizaciones"
        Me.lblAmortizaciones.Size = New System.Drawing.Size(69, 13)
        Me.lblAmortizaciones.TabIndex = 608
        Me.lblAmortizaciones.Text = "0.00"
        Me.lblAmortizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPorcentajeInteres
        '
        Me.lblPorcentajeInteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPorcentajeInteres.Location = New System.Drawing.Point(98, 74)
        Me.lblPorcentajeInteres.Name = "lblPorcentajeInteres"
        Me.lblPorcentajeInteres.Size = New System.Drawing.Size(69, 13)
        Me.lblPorcentajeInteres.TabIndex = 607
        Me.lblPorcentajeInteres.Text = "0.00"
        Me.lblPorcentajeInteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIntereses
        '
        Me.lblIntereses.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIntereses.Location = New System.Drawing.Point(98, 51)
        Me.lblIntereses.Name = "lblIntereses"
        Me.lblIntereses.Size = New System.Drawing.Size(69, 13)
        Me.lblIntereses.TabIndex = 606
        Me.lblIntereses.Text = "0.00"
        Me.lblIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCapital
        '
        Me.lblCapital.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCapital.Location = New System.Drawing.Point(98, 28)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(69, 13)
        Me.lblCapital.TabIndex = 605
        Me.lblCapital.Text = "0.00"
        Me.lblCapital.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 604
        Me.Label12.Text = "Valor ................"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 603
        Me.Label11.Text = "Cuota ..............."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 602
        Me.Label10.Text = "Meses Plazo ....."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 600
        Me.Label7.Text = "% Interes .........."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 599
        Me.Label6.Text = "Intereses .........."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 598
        Me.Label5.Text = "Captial .............."
        '
        'lblEstadoSolicitud
        '
        Me.lblEstadoSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEstadoSolicitud.Location = New System.Drawing.Point(10, 13)
        Me.lblEstadoSolicitud.Name = "lblEstadoSolicitud"
        Me.lblEstadoSolicitud.Size = New System.Drawing.Size(182, 29)
        Me.lblEstadoSolicitud.TabIndex = 601
        Me.lblEstadoSolicitud.Text = "Esperando autorizacion"
        Me.lblEstadoSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdAutorizar
        '
        Me.cmdAutorizar.Image = Global.Cooperativa.My.Resources.Resources.Approve_48
        Me.cmdAutorizar.Location = New System.Drawing.Point(387, 99)
        Me.cmdAutorizar.Name = "cmdAutorizar"
        Me.cmdAutorizar.Size = New System.Drawing.Size(61, 51)
        Me.cmdAutorizar.TabIndex = 8
        Me.tltMensajes.SetToolTip(Me.cmdAutorizar, "Autorizar")
        Me.cmdAutorizar.UseVisualStyleBackColor = True
        '
        'cmdReporte
        '
        Me.cmdReporte.Image = Global.Cooperativa.My.Resources.Resources.Reports_48
        Me.cmdReporte.Location = New System.Drawing.Point(326, 99)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(61, 51)
        Me.cmdReporte.TabIndex = 6
        Me.tltMensajes.SetToolTip(Me.cmdReporte, "Imprimir Pagaré")
        Me.cmdReporte.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Image = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabar.Location = New System.Drawing.Point(268, 99)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(58, 51)
        Me.cmdGrabar.TabIndex = 5
        Me.tltMensajes.SetToolTip(Me.cmdGrabar, "Grabar cambios")
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'grbCodeudor
        '
        Me.grbCodeudor.BackColor = System.Drawing.Color.White
        Me.grbCodeudor.Controls.Add(Me.cmdBorrarCodeudor)
        Me.grbCodeudor.Controls.Add(Me.cmdAgregarCodeudor)
        Me.grbCodeudor.Controls.Add(Me.txtValorCodeudor)
        Me.grbCodeudor.Controls.Add(Me.Label35)
        Me.grbCodeudor.Controls.Add(Me.txtNombreCodeudor)
        Me.grbCodeudor.Controls.Add(Me.Label34)
        Me.grbCodeudor.Controls.Add(Me.txtCodeudor)
        Me.grbCodeudor.Controls.Add(Me.grdCodeudores)
        Me.grbCodeudor.Enabled = False
        Me.grbCodeudor.Location = New System.Drawing.Point(6, 156)
        Me.grbCodeudor.Name = "grbCodeudor"
        Me.grbCodeudor.Size = New System.Drawing.Size(211, 204)
        Me.grbCodeudor.TabIndex = 7
        Me.grbCodeudor.TabStop = False
        Me.grbCodeudor.Text = "Codeudores"
        '
        'cmdBorrarCodeudor
        '
        Me.cmdBorrarCodeudor.BackgroundImage = Global.Cooperativa.My.Resources.Resources.delete_48
        Me.cmdBorrarCodeudor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBorrarCodeudor.Enabled = False
        Me.cmdBorrarCodeudor.Location = New System.Drawing.Point(177, 23)
        Me.cmdBorrarCodeudor.Name = "cmdBorrarCodeudor"
        Me.cmdBorrarCodeudor.Size = New System.Drawing.Size(28, 30)
        Me.cmdBorrarCodeudor.TabIndex = 3
        Me.cmdBorrarCodeudor.UseVisualStyleBackColor = True
        '
        'cmdAgregarCodeudor
        '
        Me.cmdAgregarCodeudor.BackgroundImage = Global.Cooperativa.My.Resources.Resources.add_48
        Me.cmdAgregarCodeudor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAgregarCodeudor.Location = New System.Drawing.Point(148, 23)
        Me.cmdAgregarCodeudor.Name = "cmdAgregarCodeudor"
        Me.cmdAgregarCodeudor.Size = New System.Drawing.Size(28, 30)
        Me.cmdAgregarCodeudor.TabIndex = 2
        Me.cmdAgregarCodeudor.UseVisualStyleBackColor = True
        '
        'txtValorCodeudor
        '
        Me.txtValorCodeudor.AutoTrim = True
        Me.txtValorCodeudor.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtValorCodeudor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtValorCodeudor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtValorCodeudor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtValorCodeudor.BordesRedondeados = False
        Me.txtValorCodeudor.CantidadDecimales = CType(2, Short)
        Me.txtValorCodeudor.CantidadEnteros = CType(15, Short)
        Me.txtValorCodeudor.Location = New System.Drawing.Point(76, 33)
        Me.txtValorCodeudor.MaxLength = 12
        Me.txtValorCodeudor.Name = "txtValorCodeudor"
        Me.txtValorCodeudor.NavegarConEnter = True
        Me.txtValorCodeudor.NumeroDeDecimales = 0
        Me.txtValorCodeudor.Size = New System.Drawing.Size(66, 20)
        Me.txtValorCodeudor.TabIndex = 1
        Me.txtValorCodeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValorCodeudor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtValorCodeudor.TiposDeFormato = Library.TextBoxSD.Formato.Moneda
        Me.txtValorCodeudor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtValorCodeudor.ValidChars = Nothing
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(73, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(31, 13)
        Me.Label35.TabIndex = 594
        Me.Label35.Text = "Valor"
        '
        'txtNombreCodeudor
        '
        Me.txtNombreCodeudor.AutoTrim = True
        Me.txtNombreCodeudor.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombreCodeudor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreCodeudor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreCodeudor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreCodeudor.BordesRedondeados = False
        Me.txtNombreCodeudor.CantidadDecimales = CType(2, Short)
        Me.txtNombreCodeudor.CantidadEnteros = CType(15, Short)
        Me.txtNombreCodeudor.Location = New System.Drawing.Point(6, 59)
        Me.txtNombreCodeudor.Name = "txtNombreCodeudor"
        Me.txtNombreCodeudor.NavegarConEnter = True
        Me.txtNombreCodeudor.NumeroDeDecimales = 0
        Me.txtNombreCodeudor.ReadOnly = True
        Me.txtNombreCodeudor.Size = New System.Drawing.Size(199, 20)
        Me.txtNombreCodeudor.TabIndex = 592
        Me.txtNombreCodeudor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombreCodeudor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreCodeudor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreCodeudor.ValidChars = Nothing
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 13)
        Me.Label34.TabIndex = 589
        Me.Label34.Text = "Empleado"
        '
        'txtCodeudor
        '
        Me.txtCodeudor.AutoTrim = True
        Me.txtCodeudor.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodeudor.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtCodeudor.BordeNormal = System.Drawing.Color.DimGray
        Me.txtCodeudor.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtCodeudor.BordesRedondeados = False
        Me.txtCodeudor.CantidadDecimales = CType(2, Short)
        Me.txtCodeudor.CantidadEnteros = CType(15, Short)
        Me.txtCodeudor.Location = New System.Drawing.Point(6, 33)
        Me.txtCodeudor.MaxLength = 7
        Me.txtCodeudor.Name = "txtCodeudor"
        Me.txtCodeudor.NavegarConEnter = True
        Me.txtCodeudor.NumeroDeDecimales = 0
        Me.txtCodeudor.Size = New System.Drawing.Size(64, 20)
        Me.txtCodeudor.TabIndex = 0
        Me.txtCodeudor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodeudor.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtCodeudor.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtCodeudor.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtCodeudor.ValidChars = Nothing
        '
        'grdCodeudores
        '
        Me.grdCodeudores.AllowUserToAddRows = False
        Me.grdCodeudores.AllowUserToDeleteRows = False
        Me.grdCodeudores.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCodeudores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCodeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCodeudores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CellNombreCodeudor, Me.CellValorCodeudor, Me.cellNumeroDeEmpleado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCodeudores.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCodeudores.Location = New System.Drawing.Point(6, 85)
        Me.grdCodeudores.Name = "grdCodeudores"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCodeudores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdCodeudores.RowHeadersVisible = False
        Me.grdCodeudores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCodeudores.Size = New System.Drawing.Size(199, 116)
        Me.grdCodeudores.TabIndex = 1
        '
        'CellNombreCodeudor
        '
        Me.CellNombreCodeudor.DataPropertyName = "Nombre"
        Me.CellNombreCodeudor.HeaderText = "Nombre"
        Me.CellNombreCodeudor.Name = "CellNombreCodeudor"
        '
        'CellValorCodeudor
        '
        Me.CellValorCodeudor.DataPropertyName = "ValorCodeudor"
        Me.CellValorCodeudor.HeaderText = "Valor"
        Me.CellValorCodeudor.Name = "CellValorCodeudor"
        '
        'cellNumeroDeEmpleado
        '
        Me.cellNumeroDeEmpleado.DataPropertyName = "NumeroDeEmpleado"
        Me.cellNumeroDeEmpleado.HeaderText = "NumeroDeEmpleado"
        Me.cellNumeroDeEmpleado.Name = "cellNumeroDeEmpleado"
        '
        'grbAmortizaciones
        '
        Me.grbAmortizaciones.BackColor = System.Drawing.Color.White
        Me.grbAmortizaciones.Controls.Add(Me.lblValidSolicitud)
        Me.grbAmortizaciones.Controls.Add(Me.lblSaldo)
        Me.grbAmortizaciones.Controls.Add(Me.Label20)
        Me.grbAmortizaciones.Controls.Add(Me.lblValorCodeudores)
        Me.grbAmortizaciones.Controls.Add(Me.Label18)
        Me.grbAmortizaciones.Controls.Add(Me.lblSolicitando)
        Me.grbAmortizaciones.Controls.Add(Me.Label16)
        Me.grbAmortizaciones.Controls.Add(Me.lblAhorroLibre)
        Me.grbAmortizaciones.Controls.Add(Me.Label14)
        Me.grbAmortizaciones.Controls.Add(Me.grdAmortizaciones)
        Me.grbAmortizaciones.Controls.Add(Me.Label21)
        Me.grbAmortizaciones.Controls.Add(Me.lblEstadoSolicitud)
        Me.grbAmortizaciones.Location = New System.Drawing.Point(5, 366)
        Me.grbAmortizaciones.Name = "grbAmortizaciones"
        Me.grbAmortizaciones.Size = New System.Drawing.Size(602, 159)
        Me.grbAmortizaciones.TabIndex = 604
        Me.grbAmortizaciones.TabStop = False
        Me.grbAmortizaciones.Text = "Amortizaciones"
        '
        'lblValidSolicitud
        '
        Me.lblValidSolicitud.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblValidSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidSolicitud.Location = New System.Drawing.Point(7, 114)
        Me.lblValidSolicitud.Name = "lblValidSolicitud"
        Me.lblValidSolicitud.Size = New System.Drawing.Size(186, 38)
        Me.lblValidSolicitud.TabIndex = 634
        Me.lblValidSolicitud.Text = "Solicitud Valida"
        Me.lblValidSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaldo
        '
        Me.lblSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSaldo.Location = New System.Drawing.Point(126, 99)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(69, 13)
        Me.lblSaldo.TabIndex = 632
        Me.lblSaldo.Text = "0.00"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(44, 99)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 631
        Me.Label20.Text = "Saldo .............."
        '
        'lblValorCodeudores
        '
        Me.lblValorCodeudores.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblValorCodeudores.Location = New System.Drawing.Point(127, 77)
        Me.lblValorCodeudores.Name = "lblValorCodeudores"
        Me.lblValorCodeudores.Size = New System.Drawing.Size(69, 13)
        Me.lblValorCodeudores.TabIndex = 630
        Me.lblValorCodeudores.Text = "0.00"
        Me.lblValorCodeudores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 629
        Me.Label18.Text = "Valor Codeudores ......"
        '
        'lblSolicitando
        '
        Me.lblSolicitando.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSolicitando.Location = New System.Drawing.Point(127, 44)
        Me.lblSolicitando.Name = "lblSolicitando"
        Me.lblSolicitando.Size = New System.Drawing.Size(69, 13)
        Me.lblSolicitando.TabIndex = 628
        Me.lblSolicitando.Text = "0.00"
        Me.lblSolicitando.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 627
        Me.Label16.Text = "Solicitando ...."
        '
        'lblAhorroLibre
        '
        Me.lblAhorroLibre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAhorroLibre.Location = New System.Drawing.Point(127, 60)
        Me.lblAhorroLibre.Name = "lblAhorroLibre"
        Me.lblAhorroLibre.Size = New System.Drawing.Size(69, 13)
        Me.lblAhorroLibre.TabIndex = 626
        Me.lblAhorroLibre.Text = "0.00"
        Me.lblAhorroLibre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 13)
        Me.Label14.TabIndex = 625
        Me.Label14.Text = "Ahorro Libre Deuda ......"
        '
        'grdAmortizaciones
        '
        Me.grdAmortizaciones.AllowUserToAddRows = False
        Me.grdAmortizaciones.AllowUserToDeleteRows = False
        Me.grdAmortizaciones.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAmortizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdAmortizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAmortizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellNumero, Me.cellFechaAmortizacon, Me.cellCapitalAmortizacion, Me.cellInteresesAmortizacion, Me.CellValorAmortizcion, Me.cellSaldoAmortizacion})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdAmortizaciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.grdAmortizaciones.Location = New System.Drawing.Point(199, 17)
        Me.grdAmortizaciones.Name = "grdAmortizaciones"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdAmortizaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdAmortizaciones.RowHeadersVisible = False
        Me.grdAmortizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdAmortizaciones.Size = New System.Drawing.Size(397, 135)
        Me.grdAmortizaciones.TabIndex = 2
        '
        'cellNumero
        '
        Me.cellNumero.DataPropertyName = "Numero"
        Me.cellNumero.HeaderText = "Pago"
        Me.cellNumero.Name = "cellNumero"
        '
        'cellFechaAmortizacon
        '
        Me.cellFechaAmortizacon.DataPropertyName = "Fecha"
        Me.cellFechaAmortizacon.HeaderText = "Fecha"
        Me.cellFechaAmortizacon.Name = "cellFechaAmortizacon"
        '
        'cellCapitalAmortizacion
        '
        Me.cellCapitalAmortizacion.DataPropertyName = "Capital"
        Me.cellCapitalAmortizacion.HeaderText = "Capital"
        Me.cellCapitalAmortizacion.Name = "cellCapitalAmortizacion"
        '
        'cellInteresesAmortizacion
        '
        Me.cellInteresesAmortizacion.DataPropertyName = "Intereses"
        Me.cellInteresesAmortizacion.HeaderText = "Intereses"
        Me.cellInteresesAmortizacion.Name = "cellInteresesAmortizacion"
        '
        'CellValorAmortizcion
        '
        Me.CellValorAmortizcion.DataPropertyName = "Valor"
        Me.CellValorAmortizcion.HeaderText = "Valor"
        Me.CellValorAmortizcion.Name = "CellValorAmortizcion"
        '
        'cellSaldoAmortizacion
        '
        Me.cellSaldoAmortizacion.DataPropertyName = "Saldo"
        Me.cellSaldoAmortizacion.HeaderText = "Saldo"
        Me.cellSaldoAmortizacion.Name = "cellSaldoAmortizacion"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(181, 13)
        Me.Label21.TabIndex = 633
        Me.Label21.Text = "_____________________________"
        '
        'pcbEmpleado
        '
        Me.pcbEmpleado.Image = Global.Cooperativa.My.Resources.Resources.Add_male_user_256
        Me.pcbEmpleado.Location = New System.Drawing.Point(454, 19)
        Me.pcbEmpleado.Name = "pcbEmpleado"
        Me.pcbEmpleado.Size = New System.Drawing.Size(150, 131)
        Me.pcbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbEmpleado.TabIndex = 589
        Me.pcbEmpleado.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 606
        Me.Label8.Text = "Retencion"
        '
        'cboRetenciones
        '
        Me.cboRetenciones.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboRetenciones.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboRetenciones.Codigo = ""
        Me.cboRetenciones.FormattingEnabled = True
        Me.cboRetenciones.Location = New System.Drawing.Point(322, 72)
        Me.cboRetenciones.Name = "cboRetenciones"
        Me.cboRetenciones.NavegarConEnter = True
        Me.cboRetenciones.Separador = "-"
        Me.cboRetenciones.Size = New System.Drawing.Size(121, 21)
        Me.cboRetenciones.sqlQuery = ""
        Me.cboRetenciones.TabIndex = 605
        Me.cboRetenciones.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboRetenciones.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboRetenciones.ValidAllText = False
        '
        'FrmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(616, 529)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboRetenciones)
        Me.Controls.Add(Me.grbAmortizaciones)
        Me.Controls.Add(Me.grbCodeudor)
        Me.Controls.Add(Me.cmdAutorizar)
        Me.Controls.Add(Me.grbCondicionesFinancieras)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboModalidad)
        Me.Controls.Add(Me.nudMeses)
        Me.Controls.Add(Me.cmdReporte)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.pcbEmpleado)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPrestamos"
        Me.Text = "FrmPrestamos"
        CType(Me.nudMeses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCondicionesFinancieras.ResumeLayout(False)
        Me.grbCondicionesFinancieras.PerformLayout()
        Me.grbCodeudor.ResumeLayout(False)
        Me.grbCodeudor.PerformLayout()
        CType(Me.grdCodeudores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAmortizaciones.ResumeLayout(False)
        Me.grbAmortizaciones.PerformLayout()
        CType(Me.grdAmortizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCantidad As Library.TextBoxSD
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents txtNombreEmpleado As Library.TextBoxSD
    Friend WithEvents pcbEmpleado As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDeEmpleado As Library.TextBoxSD
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdReporte As System.Windows.Forms.Button
    Friend WithEvents nudMeses As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboModalidad As Library.ComboBoxSD
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As Library.MaskedTextBoxSD
    Friend WithEvents grbCondicionesFinancieras As System.Windows.Forms.GroupBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblCuota As System.Windows.Forms.Label
    Friend WithEvents lblMesesPlazo As System.Windows.Forms.Label
    Friend WithEvents lblAmortizaciones As System.Windows.Forms.Label
    Friend WithEvents lblPorcentajeInteres As System.Windows.Forms.Label
    Friend WithEvents lblIntereses As System.Windows.Forms.Label
    Friend WithEvents lblCapital As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEstadoSolicitud As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblChequePor As System.Windows.Forms.Label
    Friend WithEvents lblAhorroLibreDeuda As System.Windows.Forms.Label
    Friend WithEvents lblTotalDeuda As System.Windows.Forms.Label
    Friend WithEvents lblSaldoCodeudor As System.Windows.Forms.Label
    Friend WithEvents lblSaldoBazar As System.Windows.Forms.Label
    Friend WithEvents lblSaldoEnPrestamos As System.Windows.Forms.Label
    Friend WithEvents lblAhorroAcumulado As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmdAutorizar As System.Windows.Forms.Button
    Friend WithEvents tltMensajes As System.Windows.Forms.ToolTip
    Friend WithEvents grbCodeudor As System.Windows.Forms.GroupBox
    Friend WithEvents grdCodeudores As System.Windows.Forms.DataGridView
    Friend WithEvents txtValorCodeudor As Library.TextBoxSD
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCodeudor As Library.TextBoxSD
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtCodeudor As Library.TextBoxSD
    Friend WithEvents cmdBorrarCodeudor As System.Windows.Forms.Button
    Friend WithEvents cmdAgregarCodeudor As System.Windows.Forms.Button
    Friend WithEvents grbAmortizaciones As System.Windows.Forms.GroupBox
    Friend WithEvents grdAmortizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents cellNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellFechaAmortizacon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellCapitalAmortizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellInteresesAmortizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CellValorAmortizcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellSaldoAmortizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblValorCodeudores As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblSolicitando As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblAhorroLibre As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblValidSolicitud As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CellNombreCodeudor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CellValorCodeudor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellNumeroDeEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboRetenciones As Library.ComboBoxSD
End Class
