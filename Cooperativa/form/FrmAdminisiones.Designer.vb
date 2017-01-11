<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdminisiones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NumeroDeAsociadoLabel As System.Windows.Forms.Label
        Dim NumeroDeEmpleadoLabel As System.Windows.Forms.Label
        Dim PrimerNombreLabel As System.Windows.Forms.Label
        Dim SegundoNombreLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim PrimerApellidoLabel As System.Windows.Forms.Label
        Dim SegundoApellidoLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NombreCompletoLabel As System.Windows.Forms.Label
        Dim FechaDeNacimientoLabel As System.Windows.Forms.Label
        Dim LugarDeNacimientoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim NacionalidadLabel As System.Windows.Forms.Label
        Dim NitLabel As System.Windows.Forms.Label
        Dim DPILabel As System.Windows.Forms.Label
        Dim DepartamentoLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim ComunidadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim EstadoCivilLabel As System.Windows.Forms.Label
        Dim DepartamentoEmpresaLabel As System.Windows.Forms.Label
        Dim FechaDeIngresoLabel As System.Windows.Forms.Label
        Dim FechaDeEgresoLabel As System.Windows.Forms.Label
        Dim PlanillaLabel As System.Windows.Forms.Label
        Dim TipoDePlanillaLabel As System.Windows.Forms.Label
        Dim CatorcenalLabel As System.Windows.Forms.Label
        Dim IsActivoLabel As System.Windows.Forms.Label
        Dim IDTiposDeTelefonoLabel As System.Windows.Forms.Label
        Dim NumeroTelefonoLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label()
        Me.grbBeneficiarios = New System.Windows.Forms.GroupBox()
        Me.txtIdBeneficiario = New Library.TextBoxSD()
        Me.cboTipoDeBeneficiario = New Library.ComboBoxSD()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboParentescos = New Library.ComboBoxSD()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccionBeneficiario = New Library.TextBoxSD()
        Me.txtNombreBeneficiario = New Library.TextBoxSD()
        Me.cmdBorrarBeneficiario = New System.Windows.Forms.Button()
        Me.cmdAgregarBeneficiario = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdBeneficiarios = New System.Windows.Forms.DataGridView()
        Me.IdBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeBeneficiario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cndNuevo = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdReporte = New System.Windows.Forms.Button()
        Me.chkCatorcenal = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSalario = New Library.TextBoxSD()
        Me.txtCapital = New Library.TextBoxSD()
        Me.txtFecha = New Library.MaskedTextBoxSD()
        Me.txtPlanilla = New Library.TextBoxSD()
        Me.txtTelefono = New Library.TextBoxSD()
        Me.txtDireccion = New Library.TextBoxSD()
        Me.txtNombreEmpleado = New Library.TextBoxSD()
        Me.txtNumeroDeEmpleado = New Library.TextBoxSD()
        Me.pcbCategoria = New System.Windows.Forms.PictureBox()
        Me.NumeroDeAsociadoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.NumeroDeEmpleadoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.PrimerNombreTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.SegundoNombreTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.NombresTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.PrimerApellidoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.SegundoApellidoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.ApellidosTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.NombreCompletoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.FechaDeNacimientoMaskedTextBoxSD = New UserWindowsControlLibrary.MaskedTextBoxSD()
        Me.LugarDeNacimientoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.SexoComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.NacionalidadComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.NitTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.DPITextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.DepartamentoComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.MunicipioComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.ComunidadComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.DireccionTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.EstadoCivilComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.DepartamentoEmpresaComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.FechaDeIngresoMaskedTextBoxSD = New UserWindowsControlLibrary.MaskedTextBoxSD()
        Me.FechaDeEgresoMaskedTextBoxSD = New UserWindowsControlLibrary.MaskedTextBoxSD()
        Me.PlanillaComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.TipoDePlanillaComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.CatorcenalTextBox = New System.Windows.Forms.TextBox()
        Me.IsActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.IDTiposDeTelefonoComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.NumeroTelefonoComboBoxSD = New UserWindowsControlLibrary.ComboBoxSD()
        Me.GroupBoxDatosDeIndentificacion = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ApellidoTextBoxSD = New UserWindowsControlLibrary.TextBoxSD()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        NumeroDeAsociadoLabel = New System.Windows.Forms.Label()
        NumeroDeEmpleadoLabel = New System.Windows.Forms.Label()
        PrimerNombreLabel = New System.Windows.Forms.Label()
        SegundoNombreLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        PrimerApellidoLabel = New System.Windows.Forms.Label()
        SegundoApellidoLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombreCompletoLabel = New System.Windows.Forms.Label()
        FechaDeNacimientoLabel = New System.Windows.Forms.Label()
        LugarDeNacimientoLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        NacionalidadLabel = New System.Windows.Forms.Label()
        NitLabel = New System.Windows.Forms.Label()
        DPILabel = New System.Windows.Forms.Label()
        DepartamentoLabel = New System.Windows.Forms.Label()
        MunicipioLabel = New System.Windows.Forms.Label()
        ComunidadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        EstadoCivilLabel = New System.Windows.Forms.Label()
        DepartamentoEmpresaLabel = New System.Windows.Forms.Label()
        FechaDeIngresoLabel = New System.Windows.Forms.Label()
        FechaDeEgresoLabel = New System.Windows.Forms.Label()
        PlanillaLabel = New System.Windows.Forms.Label()
        TipoDePlanillaLabel = New System.Windows.Forms.Label()
        CatorcenalLabel = New System.Windows.Forms.Label()
        IsActivoLabel = New System.Windows.Forms.Label()
        IDTiposDeTelefonoLabel = New System.Windows.Forms.Label()
        NumeroTelefonoLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Me.grbBeneficiarios.SuspendLayout()
        CType(Me.grdBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDatosDeIndentificacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(851, 27)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(48, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Emleado"
        '
        'grbBeneficiarios
        '
        Me.grbBeneficiarios.BackColor = System.Drawing.Color.Ivory
        Me.grbBeneficiarios.Controls.Add(Me.txtIdBeneficiario)
        Me.grbBeneficiarios.Controls.Add(Me.cboTipoDeBeneficiario)
        Me.grbBeneficiarios.Controls.Add(Me.Label11)
        Me.grbBeneficiarios.Controls.Add(Me.cboParentescos)
        Me.grbBeneficiarios.Controls.Add(Me.Label8)
        Me.grbBeneficiarios.Controls.Add(Me.Label7)
        Me.grbBeneficiarios.Controls.Add(Me.txtDireccionBeneficiario)
        Me.grbBeneficiarios.Controls.Add(Me.txtNombreBeneficiario)
        Me.grbBeneficiarios.Controls.Add(Me.cmdBorrarBeneficiario)
        Me.grbBeneficiarios.Controls.Add(Me.cmdAgregarBeneficiario)
        Me.grbBeneficiarios.Controls.Add(Me.Label6)
        Me.grbBeneficiarios.Controls.Add(Me.grdBeneficiarios)
        Me.grbBeneficiarios.Enabled = False
        Me.grbBeneficiarios.Location = New System.Drawing.Point(12, 339)
        Me.grbBeneficiarios.Name = "grbBeneficiarios"
        Me.grbBeneficiarios.Size = New System.Drawing.Size(569, 195)
        Me.grbBeneficiarios.TabIndex = 10
        Me.grbBeneficiarios.TabStop = False
        Me.grbBeneficiarios.Text = "Beneficiarios"
        '
        'txtIdBeneficiario
        '
        Me.txtIdBeneficiario.AutoTrim = True
        Me.txtIdBeneficiario.BackColor = System.Drawing.Color.LightGreen
        Me.txtIdBeneficiario.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtIdBeneficiario.BordeNormal = System.Drawing.Color.DimGray
        Me.txtIdBeneficiario.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtIdBeneficiario.BordesRedondeados = False
        Me.txtIdBeneficiario.CantidadDecimales = CType(2, Short)
        Me.txtIdBeneficiario.CantidadEnteros = CType(15, Short)
        Me.txtIdBeneficiario.Location = New System.Drawing.Point(447, 8)
        Me.txtIdBeneficiario.Name = "txtIdBeneficiario"
        Me.txtIdBeneficiario.NavegarConEnter = True
        Me.txtIdBeneficiario.NumeroDeDecimales = 0
        Me.txtIdBeneficiario.ReadOnly = True
        Me.txtIdBeneficiario.Size = New System.Drawing.Size(44, 20)
        Me.txtIdBeneficiario.TabIndex = 584
        Me.txtIdBeneficiario.Text = "0"
        Me.txtIdBeneficiario.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtIdBeneficiario.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtIdBeneficiario.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtIdBeneficiario.ValidChars = Nothing
        Me.txtIdBeneficiario.Visible = False
        '
        'cboTipoDeBeneficiario
        '
        Me.cboTipoDeBeneficiario.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboTipoDeBeneficiario.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" &
    "lication Name=Cooperativa"
        Me.cboTipoDeBeneficiario.Codigo = ""
        Me.cboTipoDeBeneficiario.FormattingEnabled = True
        Me.cboTipoDeBeneficiario.Location = New System.Drawing.Point(335, 73)
        Me.cboTipoDeBeneficiario.Name = "cboTipoDeBeneficiario"
        Me.cboTipoDeBeneficiario.NavegarConEnter = True
        Me.cboTipoDeBeneficiario.Separador = "-"
        Me.cboTipoDeBeneficiario.Size = New System.Drawing.Size(147, 21)
        Me.cboTipoDeBeneficiario.sqlQuery = ""
        Me.cboTipoDeBeneficiario.TabIndex = 3
        Me.cboTipoDeBeneficiario.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboTipoDeBeneficiario.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboTipoDeBeneficiario.ValidAllText = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 583
        Me.Label11.Text = "Tipo De Beneficiario"
        '
        'cboParentescos
        '
        Me.cboParentescos.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboParentescos.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" &
    "lication Name=Cooperativa"
        Me.cboParentescos.Codigo = ""
        Me.cboParentescos.FormattingEnabled = True
        Me.cboParentescos.Location = New System.Drawing.Point(11, 34)
        Me.cboParentescos.Name = "cboParentescos"
        Me.cboParentescos.NavegarConEnter = True
        Me.cboParentescos.Separador = "-"
        Me.cboParentescos.Size = New System.Drawing.Size(147, 21)
        Me.cboParentescos.sqlQuery = ""
        Me.cboParentescos.TabIndex = 0
        Me.cboParentescos.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboParentescos.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboParentescos.ValidAllText = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 581
        Me.Label8.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 580
        Me.Label7.Text = "Dirección"
        '
        'txtDireccionBeneficiario
        '
        Me.txtDireccionBeneficiario.AutoTrim = True
        Me.txtDireccionBeneficiario.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDireccionBeneficiario.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDireccionBeneficiario.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDireccionBeneficiario.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDireccionBeneficiario.BordesRedondeados = False
        Me.txtDireccionBeneficiario.CantidadDecimales = CType(2, Short)
        Me.txtDireccionBeneficiario.CantidadEnteros = CType(15, Short)
        Me.txtDireccionBeneficiario.Location = New System.Drawing.Point(11, 73)
        Me.txtDireccionBeneficiario.MaxLength = 80
        Me.txtDireccionBeneficiario.Name = "txtDireccionBeneficiario"
        Me.txtDireccionBeneficiario.NavegarConEnter = True
        Me.txtDireccionBeneficiario.NumeroDeDecimales = 0
        Me.txtDireccionBeneficiario.Size = New System.Drawing.Size(323, 20)
        Me.txtDireccionBeneficiario.TabIndex = 2
        Me.txtDireccionBeneficiario.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtDireccionBeneficiario.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDireccionBeneficiario.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDireccionBeneficiario.ValidChars = Nothing
        '
        'txtNombreBeneficiario
        '
        Me.txtNombreBeneficiario.AutoTrim = True
        Me.txtNombreBeneficiario.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNombreBeneficiario.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreBeneficiario.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreBeneficiario.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreBeneficiario.BordesRedondeados = False
        Me.txtNombreBeneficiario.CantidadDecimales = CType(2, Short)
        Me.txtNombreBeneficiario.CantidadEnteros = CType(15, Short)
        Me.txtNombreBeneficiario.Location = New System.Drawing.Point(164, 34)
        Me.txtNombreBeneficiario.MaxLength = 50
        Me.txtNombreBeneficiario.Name = "txtNombreBeneficiario"
        Me.txtNombreBeneficiario.NavegarConEnter = True
        Me.txtNombreBeneficiario.NumeroDeDecimales = 0
        Me.txtNombreBeneficiario.Size = New System.Drawing.Size(327, 20)
        Me.txtNombreBeneficiario.TabIndex = 1
        Me.txtNombreBeneficiario.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNombreBeneficiario.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreBeneficiario.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreBeneficiario.ValidChars = Nothing
        '
        'cmdBorrarBeneficiario
        '
        Me.cmdBorrarBeneficiario.BackgroundImage = Global.Cooperativa.My.Resources.Resources.delete_48
        Me.cmdBorrarBeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBorrarBeneficiario.Enabled = False
        Me.cmdBorrarBeneficiario.Location = New System.Drawing.Point(506, 54)
        Me.cmdBorrarBeneficiario.Name = "cmdBorrarBeneficiario"
        Me.cmdBorrarBeneficiario.Size = New System.Drawing.Size(42, 40)
        Me.cmdBorrarBeneficiario.TabIndex = 4
        Me.tttToolTip.SetToolTip(Me.cmdBorrarBeneficiario, "Grabar o modificar socio")
        Me.cmdBorrarBeneficiario.UseVisualStyleBackColor = True
        '
        'cmdAgregarBeneficiario
        '
        Me.cmdAgregarBeneficiario.BackgroundImage = Global.Cooperativa.My.Resources.Resources.add_48
        Me.cmdAgregarBeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAgregarBeneficiario.Location = New System.Drawing.Point(506, 15)
        Me.cmdAgregarBeneficiario.Name = "cmdAgregarBeneficiario"
        Me.cmdAgregarBeneficiario.Size = New System.Drawing.Size(42, 40)
        Me.cmdAgregarBeneficiario.TabIndex = 4
        Me.tttToolTip.SetToolTip(Me.cmdAgregarBeneficiario, "Grabar o modificar socio")
        Me.cmdAgregarBeneficiario.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 574
        Me.Label6.Text = "Parentesco"
        '
        'grdBeneficiarios
        '
        Me.grdBeneficiarios.AllowUserToAddRows = False
        Me.grdBeneficiarios.AllowUserToDeleteRows = False
        Me.grdBeneficiarios.AllowUserToResizeRows = False
        Me.grdBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBeneficiarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBeneficiario, Me.Parentesco, Me.NombreBeneficiario, Me.DireccionBeneficiario, Me.TipoDeBeneficiario})
        Me.grdBeneficiarios.Location = New System.Drawing.Point(6, 100)
        Me.grdBeneficiarios.Name = "grdBeneficiarios"
        Me.grdBeneficiarios.RowHeadersVisible = False
        Me.grdBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBeneficiarios.Size = New System.Drawing.Size(557, 89)
        Me.grdBeneficiarios.TabIndex = 0
        '
        'IdBeneficiario
        '
        Me.IdBeneficiario.DataPropertyName = "IdBeneficiario"
        Me.IdBeneficiario.HeaderText = "IdBeneficiario"
        Me.IdBeneficiario.Name = "IdBeneficiario"
        Me.IdBeneficiario.Visible = False
        '
        'Parentesco
        '
        Me.Parentesco.DataPropertyName = "IdParentesco"
        Me.Parentesco.HeaderText = "Parentesco"
        Me.Parentesco.Name = "Parentesco"
        '
        'NombreBeneficiario
        '
        Me.NombreBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NombreBeneficiario.DataPropertyName = "Nombre"
        Me.NombreBeneficiario.HeaderText = "Nombre Beneficiario"
        Me.NombreBeneficiario.Name = "NombreBeneficiario"
        Me.NombreBeneficiario.Width = 150
        '
        'DireccionBeneficiario
        '
        Me.DireccionBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DireccionBeneficiario.DataPropertyName = "Direccion"
        Me.DireccionBeneficiario.HeaderText = "Direccion Beneficiario"
        Me.DireccionBeneficiario.Name = "DireccionBeneficiario"
        Me.DireccionBeneficiario.Width = 200
        '
        'TipoDeBeneficiario
        '
        Me.TipoDeBeneficiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TipoDeBeneficiario.DataPropertyName = "TipoBeneficiario"
        Me.TipoDeBeneficiario.HeaderText = "Tipo "
        Me.TipoDeBeneficiario.Name = "TipoDeBeneficiario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 574
        Me.Label2.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 575
        Me.Label3.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 576
        Me.Label4.Text = "Plailla"
        '
        'cndNuevo
        '
        Me.cndNuevo.Image = Global.Cooperativa.My.Resources.Resources.Gnome_Contact_New_48
        Me.cndNuevo.Location = New System.Drawing.Point(366, 282)
        Me.cndNuevo.Name = "cndNuevo"
        Me.cndNuevo.Size = New System.Drawing.Size(58, 51)
        Me.cndNuevo.TabIndex = 9
        Me.tttToolTip.SetToolTip(Me.cndNuevo, "Nuevo socio")
        Me.cndNuevo.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Image = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabar.Location = New System.Drawing.Point(249, 282)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(58, 51)
        Me.cmdGrabar.TabIndex = 7
        Me.tttToolTip.SetToolTip(Me.cmdGrabar, "Grabar o modificar socio")
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdReporte
        '
        Me.cmdReporte.Image = Global.Cooperativa.My.Resources.Resources.Reports_48
        Me.cmdReporte.Location = New System.Drawing.Point(306, 282)
        Me.cmdReporte.Name = "cmdReporte"
        Me.cmdReporte.Size = New System.Drawing.Size(61, 51)
        Me.cmdReporte.TabIndex = 8
        Me.tttToolTip.SetToolTip(Me.cmdReporte, "Imprimir reporte de admision")
        Me.cmdReporte.UseVisualStyleBackColor = True
        '
        'chkCatorcenal
        '
        Me.chkCatorcenal.AutoSize = True
        Me.chkCatorcenal.Enabled = False
        Me.chkCatorcenal.Location = New System.Drawing.Point(905, 46)
        Me.chkCatorcenal.Name = "chkCatorcenal"
        Me.chkCatorcenal.Size = New System.Drawing.Size(77, 17)
        Me.chkCatorcenal.TabIndex = 580
        Me.chkCatorcenal.Text = "Catorcenal"
        Me.chkCatorcenal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 582
        Me.Label5.Text = "Fecha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(346, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 583
        Me.Label9.Text = "Cuota"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(187, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 585
        Me.Label10.Text = "Salario"
        '
        'txtSalario
        '
        Me.txtSalario.AutoTrim = True
        Me.txtSalario.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSalario.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtSalario.BordeNormal = System.Drawing.Color.DimGray
        Me.txtSalario.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtSalario.BordesRedondeados = False
        Me.txtSalario.CantidadDecimales = CType(2, Short)
        Me.txtSalario.CantidadEnteros = CType(15, Short)
        Me.txtSalario.Location = New System.Drawing.Point(185, 302)
        Me.txtSalario.MaxLength = 12
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.NavegarConEnter = True
        Me.txtSalario.NumeroDeDecimales = 0
        Me.txtSalario.Size = New System.Drawing.Size(50, 20)
        Me.txtSalario.TabIndex = 6
        Me.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalario.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtSalario.TiposDeFormato = Library.TextBoxSD.Formato.Moneda
        Me.txtSalario.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtSalario.ValidChars = Nothing
        '
        'txtCapital
        '
        Me.txtCapital.AutoTrim = True
        Me.txtCapital.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCapital.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtCapital.BordeNormal = System.Drawing.Color.DimGray
        Me.txtCapital.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtCapital.BordesRedondeados = False
        Me.txtCapital.CantidadDecimales = CType(2, Short)
        Me.txtCapital.CantidadEnteros = CType(15, Short)
        Me.txtCapital.Location = New System.Drawing.Point(344, 256)
        Me.txtCapital.MaxLength = 12
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.NavegarConEnter = True
        Me.txtCapital.NumeroDeDecimales = 0
        Me.txtCapital.Size = New System.Drawing.Size(66, 20)
        Me.txtCapital.TabIndex = 2
        Me.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCapital.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtCapital.TiposDeFormato = Library.TextBoxSD.Formato.Moneda
        Me.txtCapital.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtCapital.ValidChars = Nothing
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFecha.Location = New System.Drawing.Point(15, 302)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.NavegarConEnter = True
        Me.txtFecha.Size = New System.Drawing.Size(68, 20)
        Me.txtFecha.TabIndex = 3
        Me.txtFecha.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFecha.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'txtPlanilla
        '
        Me.txtPlanilla.AutoTrim = True
        Me.txtPlanilla.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPlanilla.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtPlanilla.BordeNormal = System.Drawing.Color.DimGray
        Me.txtPlanilla.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtPlanilla.BordesRedondeados = False
        Me.txtPlanilla.CantidadDecimales = CType(2, Short)
        Me.txtPlanilla.CantidadEnteros = CType(15, Short)
        Me.txtPlanilla.Location = New System.Drawing.Point(146, 302)
        Me.txtPlanilla.MaxLength = 2
        Me.txtPlanilla.Name = "txtPlanilla"
        Me.txtPlanilla.NavegarConEnter = True
        Me.txtPlanilla.NumeroDeDecimales = 0
        Me.txtPlanilla.Size = New System.Drawing.Size(36, 20)
        Me.txtPlanilla.TabIndex = 5
        Me.txtPlanilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPlanilla.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtPlanilla.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtPlanilla.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtPlanilla.ValidChars = Nothing
        '
        'txtTelefono
        '
        Me.txtTelefono.AutoTrim = True
        Me.txtTelefono.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTelefono.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtTelefono.BordeNormal = System.Drawing.Color.DimGray
        Me.txtTelefono.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtTelefono.BordesRedondeados = False
        Me.txtTelefono.CantidadDecimales = CType(2, Short)
        Me.txtTelefono.CantidadEnteros = CType(15, Short)
        Me.txtTelefono.Location = New System.Drawing.Point(85, 302)
        Me.txtTelefono.MaxLength = 8
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.NavegarConEnter = True
        Me.txtTelefono.NumeroDeDecimales = 0
        Me.txtTelefono.Size = New System.Drawing.Size(59, 20)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtTelefono.TiposDeFormato = Library.TextBoxSD.Formato.Texto
        Me.txtTelefono.TiposFiltro = Library.TextBoxSD.Filtro.Numeros
        Me.txtTelefono.ValidChars = Nothing
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
        Me.txtDireccion.Location = New System.Drawing.Point(12, 256)
        Me.txtDireccion.MaxLength = 80
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.NavegarConEnter = True
        Me.txtDireccion.NumeroDeDecimales = 0
        Me.txtDireccion.Size = New System.Drawing.Size(329, 20)
        Me.txtDireccion.TabIndex = 1
        Me.txtDireccion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtDireccion.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDireccion.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDireccion.ValidChars = Nothing
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
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(851, 70)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.NavegarConEnter = True
        Me.txtNombreEmpleado.NumeroDeDecimales = 0
        Me.txtNombreEmpleado.ReadOnly = True
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(237, 20)
        Me.txtNombreEmpleado.TabIndex = 572
        Me.txtNombreEmpleado.Text = "Nombre"
        Me.txtNombreEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombreEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreEmpleado.ValidChars = Nothing
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
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(851, 44)
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
        'pcbCategoria
        '
        Me.pcbCategoria.Image = Global.Cooperativa.My.Resources.Resources.Add_male_user_256
        Me.pcbCategoria.Location = New System.Drawing.Point(925, 96)
        Me.pcbCategoria.Name = "pcbCategoria"
        Me.pcbCategoria.Size = New System.Drawing.Size(148, 88)
        Me.pcbCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCategoria.TabIndex = 567
        Me.pcbCategoria.TabStop = False
        '
        'NumeroDeAsociadoLabel
        '
        NumeroDeAsociadoLabel.AutoSize = True
        NumeroDeAsociadoLabel.Location = New System.Drawing.Point(599, 214)
        NumeroDeAsociadoLabel.Name = "NumeroDeAsociadoLabel"
        NumeroDeAsociadoLabel.Size = New System.Drawing.Size(111, 13)
        NumeroDeAsociadoLabel.TabIndex = 586
        NumeroDeAsociadoLabel.Text = "Numero De Asociado:"
        '
        'NumeroDeAsociadoTextBoxSD
        '
        Me.NumeroDeAsociadoTextBoxSD.BackColor = System.Drawing.Color.White
        Me.NumeroDeAsociadoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.NumeroDeAsociadoTextBoxSD.Location = New System.Drawing.Point(726, 211)
        Me.NumeroDeAsociadoTextBoxSD.Name = "NumeroDeAsociadoTextBoxSD"
        Me.NumeroDeAsociadoTextBoxSD.NumberDecimal = 0
        Me.NumeroDeAsociadoTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.NumeroDeAsociadoTextBoxSD.TabEnter = True
        Me.NumeroDeAsociadoTextBoxSD.TabIndex = 587
        Me.NumeroDeAsociadoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.NumeroDeAsociadoTextBoxSD.ValidField = False
        '
        'NumeroDeEmpleadoLabel
        '
        NumeroDeEmpleadoLabel.AutoSize = True
        NumeroDeEmpleadoLabel.Location = New System.Drawing.Point(599, 240)
        NumeroDeEmpleadoLabel.Name = "NumeroDeEmpleadoLabel"
        NumeroDeEmpleadoLabel.Size = New System.Drawing.Size(114, 13)
        NumeroDeEmpleadoLabel.TabIndex = 588
        NumeroDeEmpleadoLabel.Text = "Numero De Empleado:"
        '
        'NumeroDeEmpleadoTextBoxSD
        '
        Me.NumeroDeEmpleadoTextBoxSD.BackColor = System.Drawing.Color.White
        Me.NumeroDeEmpleadoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.NumeroDeEmpleadoTextBoxSD.Location = New System.Drawing.Point(726, 237)
        Me.NumeroDeEmpleadoTextBoxSD.Name = "NumeroDeEmpleadoTextBoxSD"
        Me.NumeroDeEmpleadoTextBoxSD.NumberDecimal = 0
        Me.NumeroDeEmpleadoTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.NumeroDeEmpleadoTextBoxSD.TabEnter = True
        Me.NumeroDeEmpleadoTextBoxSD.TabIndex = 589
        Me.NumeroDeEmpleadoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.NumeroDeEmpleadoTextBoxSD.ValidField = False
        '
        'PrimerNombreLabel
        '
        PrimerNombreLabel.AutoSize = True
        PrimerNombreLabel.Location = New System.Drawing.Point(503, 5)
        PrimerNombreLabel.Name = "PrimerNombreLabel"
        PrimerNombreLabel.Size = New System.Drawing.Size(107, 17)
        PrimerNombreLabel.TabIndex = 590
        PrimerNombreLabel.Text = "Primer Nombre:"
        '
        'PrimerNombreTextBoxSD
        '
        Me.PrimerNombreTextBoxSD.BackColor = System.Drawing.Color.White
        Me.PrimerNombreTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.PrimerNombreTextBoxSD.Location = New System.Drawing.Point(503, 26)
        Me.PrimerNombreTextBoxSD.Name = "PrimerNombreTextBoxSD"
        Me.PrimerNombreTextBoxSD.NumberDecimal = 0
        Me.PrimerNombreTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.PrimerNombreTextBoxSD.TabEnter = True
        Me.PrimerNombreTextBoxSD.TabIndex = 591
        Me.PrimerNombreTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.PrimerNombreTextBoxSD.ValidField = False
        '
        'SegundoNombreLabel
        '
        SegundoNombreLabel.AutoSize = True
        SegundoNombreLabel.Location = New System.Drawing.Point(670, 5)
        SegundoNombreLabel.Name = "SegundoNombreLabel"
        SegundoNombreLabel.Size = New System.Drawing.Size(123, 17)
        SegundoNombreLabel.TabIndex = 592
        SegundoNombreLabel.Text = "Segundo Nombre:"
        '
        'SegundoNombreTextBoxSD
        '
        Me.SegundoNombreTextBoxSD.BackColor = System.Drawing.Color.White
        Me.SegundoNombreTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.SegundoNombreTextBoxSD.Location = New System.Drawing.Point(670, 26)
        Me.SegundoNombreTextBoxSD.Name = "SegundoNombreTextBoxSD"
        Me.SegundoNombreTextBoxSD.NumberDecimal = 0
        Me.SegundoNombreTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.SegundoNombreTextBoxSD.TabEnter = True
        Me.SegundoNombreTextBoxSD.TabIndex = 593
        Me.SegundoNombreTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.SegundoNombreTextBoxSD.ValidField = False
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(597, 261)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(52, 13)
        NombresLabel.TabIndex = 594
        NombresLabel.Text = "Nombres:"
        '
        'NombresTextBoxSD
        '
        Me.NombresTextBoxSD.BackColor = System.Drawing.Color.White
        Me.NombresTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.NombresTextBoxSD.Location = New System.Drawing.Point(724, 258)
        Me.NombresTextBoxSD.Name = "NombresTextBoxSD"
        Me.NombresTextBoxSD.NumberDecimal = 0
        Me.NombresTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.NombresTextBoxSD.TabEnter = True
        Me.NombresTextBoxSD.TabIndex = 595
        Me.NombresTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.NombresTextBoxSD.ValidField = False
        '
        'PrimerApellidoLabel
        '
        PrimerApellidoLabel.AutoSize = True
        PrimerApellidoLabel.Location = New System.Drawing.Point(3, 6)
        PrimerApellidoLabel.Name = "PrimerApellidoLabel"
        PrimerApellidoLabel.Size = New System.Drawing.Size(107, 17)
        PrimerApellidoLabel.TabIndex = 596
        PrimerApellidoLabel.Text = "Primer Apellido:"
        '
        'PrimerApellidoTextBoxSD
        '
        Me.PrimerApellidoTextBoxSD.BackColor = System.Drawing.Color.White
        Me.PrimerApellidoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.PrimerApellidoTextBoxSD.Location = New System.Drawing.Point(3, 26)
        Me.PrimerApellidoTextBoxSD.MaxLength = 30
        Me.PrimerApellidoTextBoxSD.Name = "PrimerApellidoTextBoxSD"
        Me.PrimerApellidoTextBoxSD.NumberDecimal = 0
        Me.PrimerApellidoTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.PrimerApellidoTextBoxSD.TabEnter = True
        Me.PrimerApellidoTextBoxSD.TabIndex = 597
        Me.PrimerApellidoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.PrimerApellidoTextBoxSD.ValidField = False
        '
        'SegundoApellidoLabel
        '
        SegundoApellidoLabel.AutoSize = True
        SegundoApellidoLabel.Location = New System.Drawing.Point(170, 5)
        SegundoApellidoLabel.Name = "SegundoApellidoLabel"
        SegundoApellidoLabel.Size = New System.Drawing.Size(123, 17)
        SegundoApellidoLabel.TabIndex = 598
        SegundoApellidoLabel.Text = "Segundo Apellido:"
        '
        'SegundoApellidoTextBoxSD
        '
        Me.SegundoApellidoTextBoxSD.BackColor = System.Drawing.Color.White
        Me.SegundoApellidoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.SegundoApellidoTextBoxSD.Location = New System.Drawing.Point(170, 26)
        Me.SegundoApellidoTextBoxSD.Name = "SegundoApellidoTextBoxSD"
        Me.SegundoApellidoTextBoxSD.NumberDecimal = 0
        Me.SegundoApellidoTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.SegundoApellidoTextBoxSD.TabEnter = True
        Me.SegundoApellidoTextBoxSD.TabIndex = 599
        Me.SegundoApellidoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.SegundoApellidoTextBoxSD.ValidField = False
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(852, 286)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 600
        ApellidosLabel.Text = "Apellidos:"
        '
        'ApellidosTextBoxSD
        '
        Me.ApellidosTextBoxSD.BackColor = System.Drawing.Color.White
        Me.ApellidosTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.ApellidosTextBoxSD.Location = New System.Drawing.Point(979, 283)
        Me.ApellidosTextBoxSD.Name = "ApellidosTextBoxSD"
        Me.ApellidosTextBoxSD.NumberDecimal = 0
        Me.ApellidosTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.ApellidosTextBoxSD.TabEnter = True
        Me.ApellidosTextBoxSD.TabIndex = 601
        Me.ApellidosTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.ApellidosTextBoxSD.ValidField = False
        '
        'NombreCompletoLabel
        '
        NombreCompletoLabel.AutoSize = True
        NombreCompletoLabel.Location = New System.Drawing.Point(852, 312)
        NombreCompletoLabel.Name = "NombreCompletoLabel"
        NombreCompletoLabel.Size = New System.Drawing.Size(94, 13)
        NombreCompletoLabel.TabIndex = 602
        NombreCompletoLabel.Text = "Nombre Completo:"
        '
        'NombreCompletoTextBoxSD
        '
        Me.NombreCompletoTextBoxSD.BackColor = System.Drawing.Color.White
        Me.NombreCompletoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.NombreCompletoTextBoxSD.Location = New System.Drawing.Point(979, 309)
        Me.NombreCompletoTextBoxSD.Name = "NombreCompletoTextBoxSD"
        Me.NombreCompletoTextBoxSD.NumberDecimal = 0
        Me.NombreCompletoTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.NombreCompletoTextBoxSD.TabEnter = True
        Me.NombreCompletoTextBoxSD.TabIndex = 603
        Me.NombreCompletoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.NombreCompletoTextBoxSD.ValidField = False
        '
        'FechaDeNacimientoLabel
        '
        FechaDeNacimientoLabel.AutoSize = True
        FechaDeNacimientoLabel.Location = New System.Drawing.Point(503, 52)
        FechaDeNacimientoLabel.Name = "FechaDeNacimientoLabel"
        FechaDeNacimientoLabel.Size = New System.Drawing.Size(147, 17)
        FechaDeNacimientoLabel.TabIndex = 604
        FechaDeNacimientoLabel.Text = "Fecha De Nacimiento:"
        '
        'FechaDeNacimientoMaskedTextBoxSD
        '
        Me.FechaDeNacimientoMaskedTextBoxSD.BackColor = System.Drawing.Color.White
        Me.FechaDeNacimientoMaskedTextBoxSD.Location = New System.Drawing.Point(503, 72)
        Me.FechaDeNacimientoMaskedTextBoxSD.Mask = "00/00/0000"
        Me.FechaDeNacimientoMaskedTextBoxSD.Name = "FechaDeNacimientoMaskedTextBoxSD"
        Me.FechaDeNacimientoMaskedTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.FechaDeNacimientoMaskedTextBoxSD.TabEnter = True
        Me.FechaDeNacimientoMaskedTextBoxSD.TabIndex = 605
        Me.FechaDeNacimientoMaskedTextBoxSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FechaDeNacimientoMaskedTextBoxSD.TypeField = UserWindowsControlLibrary.MaskedTextBoxSD.TiposDeCampo.Personalizado
        Me.FechaDeNacimientoMaskedTextBoxSD.ValidatingType = GetType(Date)
        '
        'LugarDeNacimientoLabel
        '
        LugarDeNacimientoLabel.AutoSize = True
        LugarDeNacimientoLabel.Location = New System.Drawing.Point(581, 290)
        LugarDeNacimientoLabel.Name = "LugarDeNacimientoLabel"
        LugarDeNacimientoLabel.Size = New System.Drawing.Size(110, 13)
        LugarDeNacimientoLabel.TabIndex = 606
        LugarDeNacimientoLabel.Text = "Lugar De Nacimiento:"
        '
        'LugarDeNacimientoTextBoxSD
        '
        Me.LugarDeNacimientoTextBoxSD.BackColor = System.Drawing.Color.White
        Me.LugarDeNacimientoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.LugarDeNacimientoTextBoxSD.Location = New System.Drawing.Point(708, 287)
        Me.LugarDeNacimientoTextBoxSD.Name = "LugarDeNacimientoTextBoxSD"
        Me.LugarDeNacimientoTextBoxSD.NumberDecimal = 0
        Me.LugarDeNacimientoTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.LugarDeNacimientoTextBoxSD.TabEnter = True
        Me.LugarDeNacimientoTextBoxSD.TabIndex = 607
        Me.LugarDeNacimientoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.LugarDeNacimientoTextBoxSD.ValidField = False
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(670, 52)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(60, 17)
        SexoLabel.TabIndex = 608
        SexoLabel.Text = "Genero:"
        '
        'SexoComboBoxSD
        '
        Me.SexoComboBoxSD.AddAll = False
        Me.SexoComboBoxSD.AlternativeQuery = Nothing
        Me.SexoComboBoxSD.BackColor = System.Drawing.Color.White
        Me.SexoComboBoxSD.ColumnDisplay = Nothing
        Me.SexoComboBoxSD.ColumnValue = Nothing
        Me.SexoComboBoxSD.ConcatenarID = True
        Me.SexoComboBoxSD.Conditions = Nothing
        Me.SexoComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.SexoComboBoxSD.FormattingEnabled = True
        Me.SexoComboBoxSD.Location = New System.Drawing.Point(670, 72)
        Me.SexoComboBoxSD.Name = "SexoComboBoxSD"
        Me.SexoComboBoxSD.NumberOfZeros = 0
        Me.SexoComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.SexoComboBoxSD.OrderBy = Nothing
        Me.SexoComboBoxSD.ShowFindDialog = True
        Me.SexoComboBoxSD.Size = New System.Drawing.Size(161, 24)
        Me.SexoComboBoxSD.TabEnter = True
        Me.SexoComboBoxSD.TabIndex = 609
        Me.SexoComboBoxSD.Table = Nothing
        Me.SexoComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.SexoComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.SexoComboBoxSD.User = Nothing
        Me.SexoComboBoxSD.ValidField = False
        '
        'NacionalidadLabel
        '
        NacionalidadLabel.AutoSize = True
        NacionalidadLabel.Location = New System.Drawing.Point(3, 52)
        NacionalidadLabel.Name = "NacionalidadLabel"
        NacionalidadLabel.Size = New System.Drawing.Size(94, 17)
        NacionalidadLabel.TabIndex = 610
        NacionalidadLabel.Text = "Nacionalidad:"
        '
        'NacionalidadComboBoxSD
        '
        Me.NacionalidadComboBoxSD.AddAll = False
        Me.NacionalidadComboBoxSD.AlternativeQuery = Nothing
        Me.NacionalidadComboBoxSD.BackColor = System.Drawing.Color.White
        Me.NacionalidadComboBoxSD.ColumnDisplay = Nothing
        Me.NacionalidadComboBoxSD.ColumnValue = Nothing
        Me.NacionalidadComboBoxSD.ConcatenarID = True
        Me.NacionalidadComboBoxSD.Conditions = Nothing
        Me.NacionalidadComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.NacionalidadComboBoxSD.FormattingEnabled = True
        Me.NacionalidadComboBoxSD.Location = New System.Drawing.Point(3, 72)
        Me.NacionalidadComboBoxSD.Name = "NacionalidadComboBoxSD"
        Me.NacionalidadComboBoxSD.NumberOfZeros = 0
        Me.NacionalidadComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.NacionalidadComboBoxSD.OrderBy = Nothing
        Me.NacionalidadComboBoxSD.ShowFindDialog = True
        Me.NacionalidadComboBoxSD.Size = New System.Drawing.Size(162, 24)
        Me.NacionalidadComboBoxSD.TabEnter = True
        Me.NacionalidadComboBoxSD.TabIndex = 611
        Me.NacionalidadComboBoxSD.Table = Nothing
        Me.NacionalidadComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.NacionalidadComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.NacionalidadComboBoxSD.User = Nothing
        Me.NacionalidadComboBoxSD.ValidField = False
        '
        'NitLabel
        '
        NitLabel.AutoSize = True
        NitLabel.Location = New System.Drawing.Point(336, 52)
        NitLabel.Name = "NitLabel"
        NitLabel.Size = New System.Drawing.Size(29, 17)
        NitLabel.TabIndex = 612
        NitLabel.Text = "Nit:"
        '
        'NitTextBoxSD
        '
        Me.NitTextBoxSD.BackColor = System.Drawing.Color.White
        Me.NitTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.NitTextBoxSD.Location = New System.Drawing.Point(336, 72)
        Me.NitTextBoxSD.Name = "NitTextBoxSD"
        Me.NitTextBoxSD.NumberDecimal = 0
        Me.NitTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.NitTextBoxSD.TabEnter = True
        Me.NitTextBoxSD.TabIndex = 613
        Me.NitTextBoxSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NitTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.NitTextBoxSD.ValidField = False
        '
        'DPILabel
        '
        DPILabel.AutoSize = True
        DPILabel.Location = New System.Drawing.Point(170, 52)
        DPILabel.Name = "DPILabel"
        DPILabel.Size = New System.Drawing.Size(34, 17)
        DPILabel.TabIndex = 614
        DPILabel.Text = "DPI:"
        '
        'DPITextBoxSD
        '
        Me.DPITextBoxSD.BackColor = System.Drawing.Color.White
        Me.DPITextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.DPITextBoxSD.Location = New System.Drawing.Point(170, 72)
        Me.DPITextBoxSD.Name = "DPITextBoxSD"
        Me.DPITextBoxSD.NumberDecimal = 0
        Me.DPITextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.DPITextBoxSD.TabEnter = True
        Me.DPITextBoxSD.TabIndex = 615
        Me.DPITextBoxSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DPITextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.DPITextBoxSD.ValidField = False
        '
        'DepartamentoLabel
        '
        DepartamentoLabel.AutoSize = True
        DepartamentoLabel.Location = New System.Drawing.Point(581, 422)
        DepartamentoLabel.Name = "DepartamentoLabel"
        DepartamentoLabel.Size = New System.Drawing.Size(77, 13)
        DepartamentoLabel.TabIndex = 616
        DepartamentoLabel.Text = "Departamento:"
        '
        'DepartamentoComboBoxSD
        '
        Me.DepartamentoComboBoxSD.AddAll = False
        Me.DepartamentoComboBoxSD.AlternativeQuery = Nothing
        Me.DepartamentoComboBoxSD.BackColor = System.Drawing.Color.White
        Me.DepartamentoComboBoxSD.ColumnDisplay = Nothing
        Me.DepartamentoComboBoxSD.ColumnValue = Nothing
        Me.DepartamentoComboBoxSD.ConcatenarID = True
        Me.DepartamentoComboBoxSD.Conditions = Nothing
        Me.DepartamentoComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.DepartamentoComboBoxSD.FormattingEnabled = True
        Me.DepartamentoComboBoxSD.Location = New System.Drawing.Point(708, 419)
        Me.DepartamentoComboBoxSD.Name = "DepartamentoComboBoxSD"
        Me.DepartamentoComboBoxSD.NumberOfZeros = 0
        Me.DepartamentoComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.DepartamentoComboBoxSD.OrderBy = Nothing
        Me.DepartamentoComboBoxSD.ShowFindDialog = True
        Me.DepartamentoComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.DepartamentoComboBoxSD.TabEnter = True
        Me.DepartamentoComboBoxSD.TabIndex = 617
        Me.DepartamentoComboBoxSD.Table = Nothing
        Me.DepartamentoComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.DepartamentoComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.DepartamentoComboBoxSD.User = Nothing
        Me.DepartamentoComboBoxSD.ValidField = False
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Location = New System.Drawing.Point(581, 449)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(55, 13)
        MunicipioLabel.TabIndex = 618
        MunicipioLabel.Text = "Municipio:"
        '
        'MunicipioComboBoxSD
        '
        Me.MunicipioComboBoxSD.AddAll = False
        Me.MunicipioComboBoxSD.AlternativeQuery = Nothing
        Me.MunicipioComboBoxSD.BackColor = System.Drawing.Color.White
        Me.MunicipioComboBoxSD.ColumnDisplay = Nothing
        Me.MunicipioComboBoxSD.ColumnValue = Nothing
        Me.MunicipioComboBoxSD.ConcatenarID = True
        Me.MunicipioComboBoxSD.Conditions = Nothing
        Me.MunicipioComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.MunicipioComboBoxSD.FormattingEnabled = True
        Me.MunicipioComboBoxSD.Location = New System.Drawing.Point(708, 446)
        Me.MunicipioComboBoxSD.Name = "MunicipioComboBoxSD"
        Me.MunicipioComboBoxSD.NumberOfZeros = 0
        Me.MunicipioComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.MunicipioComboBoxSD.OrderBy = Nothing
        Me.MunicipioComboBoxSD.ShowFindDialog = True
        Me.MunicipioComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.MunicipioComboBoxSD.TabEnter = True
        Me.MunicipioComboBoxSD.TabIndex = 619
        Me.MunicipioComboBoxSD.Table = Nothing
        Me.MunicipioComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.MunicipioComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.MunicipioComboBoxSD.User = Nothing
        Me.MunicipioComboBoxSD.ValidField = False
        '
        'ComunidadLabel
        '
        ComunidadLabel.AutoSize = True
        ComunidadLabel.Location = New System.Drawing.Point(581, 476)
        ComunidadLabel.Name = "ComunidadLabel"
        ComunidadLabel.Size = New System.Drawing.Size(63, 13)
        ComunidadLabel.TabIndex = 620
        ComunidadLabel.Text = "Comunidad:"
        '
        'ComunidadComboBoxSD
        '
        Me.ComunidadComboBoxSD.AddAll = False
        Me.ComunidadComboBoxSD.AlternativeQuery = Nothing
        Me.ComunidadComboBoxSD.BackColor = System.Drawing.Color.White
        Me.ComunidadComboBoxSD.ColumnDisplay = Nothing
        Me.ComunidadComboBoxSD.ColumnValue = Nothing
        Me.ComunidadComboBoxSD.ConcatenarID = True
        Me.ComunidadComboBoxSD.Conditions = Nothing
        Me.ComunidadComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.ComunidadComboBoxSD.FormattingEnabled = True
        Me.ComunidadComboBoxSD.Location = New System.Drawing.Point(708, 473)
        Me.ComunidadComboBoxSD.Name = "ComunidadComboBoxSD"
        Me.ComunidadComboBoxSD.NumberOfZeros = 0
        Me.ComunidadComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.ComunidadComboBoxSD.OrderBy = Nothing
        Me.ComunidadComboBoxSD.ShowFindDialog = True
        Me.ComunidadComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.ComunidadComboBoxSD.TabEnter = True
        Me.ComunidadComboBoxSD.TabIndex = 621
        Me.ComunidadComboBoxSD.Table = Nothing
        Me.ComunidadComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.ComunidadComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.ComunidadComboBoxSD.User = Nothing
        Me.ComunidadComboBoxSD.ValidField = False
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(581, 503)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 622
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBoxSD
        '
        Me.DireccionTextBoxSD.BackColor = System.Drawing.Color.White
        Me.DireccionTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.DireccionTextBoxSD.Location = New System.Drawing.Point(708, 500)
        Me.DireccionTextBoxSD.Name = "DireccionTextBoxSD"
        Me.DireccionTextBoxSD.NumberDecimal = 0
        Me.DireccionTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.DireccionTextBoxSD.TabEnter = True
        Me.DireccionTextBoxSD.TabIndex = 623
        Me.DireccionTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.DireccionTextBoxSD.ValidField = False
        '
        'EstadoCivilLabel
        '
        EstadoCivilLabel.AutoSize = True
        EstadoCivilLabel.Location = New System.Drawing.Point(581, 529)
        EstadoCivilLabel.Name = "EstadoCivilLabel"
        EstadoCivilLabel.Size = New System.Drawing.Size(65, 13)
        EstadoCivilLabel.TabIndex = 624
        EstadoCivilLabel.Text = "Estado Civil:"
        '
        'EstadoCivilComboBoxSD
        '
        Me.EstadoCivilComboBoxSD.AddAll = False
        Me.EstadoCivilComboBoxSD.AlternativeQuery = Nothing
        Me.EstadoCivilComboBoxSD.BackColor = System.Drawing.Color.White
        Me.EstadoCivilComboBoxSD.ColumnDisplay = Nothing
        Me.EstadoCivilComboBoxSD.ColumnValue = Nothing
        Me.EstadoCivilComboBoxSD.ConcatenarID = True
        Me.EstadoCivilComboBoxSD.Conditions = Nothing
        Me.EstadoCivilComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.EstadoCivilComboBoxSD.FormattingEnabled = True
        Me.EstadoCivilComboBoxSD.Location = New System.Drawing.Point(708, 526)
        Me.EstadoCivilComboBoxSD.Name = "EstadoCivilComboBoxSD"
        Me.EstadoCivilComboBoxSD.NumberOfZeros = 0
        Me.EstadoCivilComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.EstadoCivilComboBoxSD.OrderBy = Nothing
        Me.EstadoCivilComboBoxSD.ShowFindDialog = True
        Me.EstadoCivilComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.EstadoCivilComboBoxSD.TabEnter = True
        Me.EstadoCivilComboBoxSD.TabIndex = 625
        Me.EstadoCivilComboBoxSD.Table = Nothing
        Me.EstadoCivilComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.EstadoCivilComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.EstadoCivilComboBoxSD.User = Nothing
        Me.EstadoCivilComboBoxSD.ValidField = False
        '
        'DepartamentoEmpresaLabel
        '
        DepartamentoEmpresaLabel.AutoSize = True
        DepartamentoEmpresaLabel.Location = New System.Drawing.Point(581, 556)
        DepartamentoEmpresaLabel.Name = "DepartamentoEmpresaLabel"
        DepartamentoEmpresaLabel.Size = New System.Drawing.Size(121, 13)
        DepartamentoEmpresaLabel.TabIndex = 626
        DepartamentoEmpresaLabel.Text = "Departamento Empresa:"
        '
        'DepartamentoEmpresaComboBoxSD
        '
        Me.DepartamentoEmpresaComboBoxSD.AddAll = False
        Me.DepartamentoEmpresaComboBoxSD.AlternativeQuery = Nothing
        Me.DepartamentoEmpresaComboBoxSD.BackColor = System.Drawing.Color.White
        Me.DepartamentoEmpresaComboBoxSD.ColumnDisplay = Nothing
        Me.DepartamentoEmpresaComboBoxSD.ColumnValue = Nothing
        Me.DepartamentoEmpresaComboBoxSD.ConcatenarID = True
        Me.DepartamentoEmpresaComboBoxSD.Conditions = Nothing
        Me.DepartamentoEmpresaComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.DepartamentoEmpresaComboBoxSD.FormattingEnabled = True
        Me.DepartamentoEmpresaComboBoxSD.Location = New System.Drawing.Point(708, 553)
        Me.DepartamentoEmpresaComboBoxSD.Name = "DepartamentoEmpresaComboBoxSD"
        Me.DepartamentoEmpresaComboBoxSD.NumberOfZeros = 0
        Me.DepartamentoEmpresaComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.DepartamentoEmpresaComboBoxSD.OrderBy = Nothing
        Me.DepartamentoEmpresaComboBoxSD.ShowFindDialog = True
        Me.DepartamentoEmpresaComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.DepartamentoEmpresaComboBoxSD.TabEnter = True
        Me.DepartamentoEmpresaComboBoxSD.TabIndex = 627
        Me.DepartamentoEmpresaComboBoxSD.Table = Nothing
        Me.DepartamentoEmpresaComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.DepartamentoEmpresaComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.DepartamentoEmpresaComboBoxSD.User = Nothing
        Me.DepartamentoEmpresaComboBoxSD.ValidField = False
        '
        'FechaDeIngresoLabel
        '
        FechaDeIngresoLabel.AutoSize = True
        FechaDeIngresoLabel.Location = New System.Drawing.Point(581, 583)
        FechaDeIngresoLabel.Name = "FechaDeIngresoLabel"
        FechaDeIngresoLabel.Size = New System.Drawing.Size(95, 13)
        FechaDeIngresoLabel.TabIndex = 628
        FechaDeIngresoLabel.Text = "Fecha De Ingreso:"
        '
        'FechaDeIngresoMaskedTextBoxSD
        '
        Me.FechaDeIngresoMaskedTextBoxSD.BackColor = System.Drawing.Color.White
        Me.FechaDeIngresoMaskedTextBoxSD.Location = New System.Drawing.Point(708, 580)
        Me.FechaDeIngresoMaskedTextBoxSD.Name = "FechaDeIngresoMaskedTextBoxSD"
        Me.FechaDeIngresoMaskedTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.FechaDeIngresoMaskedTextBoxSD.TabEnter = True
        Me.FechaDeIngresoMaskedTextBoxSD.TabIndex = 629
        Me.FechaDeIngresoMaskedTextBoxSD.TypeField = UserWindowsControlLibrary.MaskedTextBoxSD.TiposDeCampo.Personalizado
        '
        'FechaDeEgresoLabel
        '
        FechaDeEgresoLabel.AutoSize = True
        FechaDeEgresoLabel.Location = New System.Drawing.Point(581, 609)
        FechaDeEgresoLabel.Name = "FechaDeEgresoLabel"
        FechaDeEgresoLabel.Size = New System.Drawing.Size(93, 13)
        FechaDeEgresoLabel.TabIndex = 630
        FechaDeEgresoLabel.Text = "Fecha De Egreso:"
        '
        'FechaDeEgresoMaskedTextBoxSD
        '
        Me.FechaDeEgresoMaskedTextBoxSD.BackColor = System.Drawing.Color.White
        Me.FechaDeEgresoMaskedTextBoxSD.Location = New System.Drawing.Point(708, 606)
        Me.FechaDeEgresoMaskedTextBoxSD.Name = "FechaDeEgresoMaskedTextBoxSD"
        Me.FechaDeEgresoMaskedTextBoxSD.Size = New System.Drawing.Size(121, 20)
        Me.FechaDeEgresoMaskedTextBoxSD.TabEnter = True
        Me.FechaDeEgresoMaskedTextBoxSD.TabIndex = 631
        Me.FechaDeEgresoMaskedTextBoxSD.TypeField = UserWindowsControlLibrary.MaskedTextBoxSD.TiposDeCampo.Personalizado
        '
        'PlanillaLabel
        '
        PlanillaLabel.AutoSize = True
        PlanillaLabel.Location = New System.Drawing.Point(581, 635)
        PlanillaLabel.Name = "PlanillaLabel"
        PlanillaLabel.Size = New System.Drawing.Size(43, 13)
        PlanillaLabel.TabIndex = 632
        PlanillaLabel.Text = "Planilla:"
        '
        'PlanillaComboBoxSD
        '
        Me.PlanillaComboBoxSD.AddAll = False
        Me.PlanillaComboBoxSD.AlternativeQuery = Nothing
        Me.PlanillaComboBoxSD.BackColor = System.Drawing.Color.White
        Me.PlanillaComboBoxSD.ColumnDisplay = Nothing
        Me.PlanillaComboBoxSD.ColumnValue = Nothing
        Me.PlanillaComboBoxSD.ConcatenarID = True
        Me.PlanillaComboBoxSD.Conditions = Nothing
        Me.PlanillaComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.PlanillaComboBoxSD.FormattingEnabled = True
        Me.PlanillaComboBoxSD.Location = New System.Drawing.Point(708, 632)
        Me.PlanillaComboBoxSD.Name = "PlanillaComboBoxSD"
        Me.PlanillaComboBoxSD.NumberOfZeros = 0
        Me.PlanillaComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.PlanillaComboBoxSD.OrderBy = Nothing
        Me.PlanillaComboBoxSD.ShowFindDialog = True
        Me.PlanillaComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.PlanillaComboBoxSD.TabEnter = True
        Me.PlanillaComboBoxSD.TabIndex = 633
        Me.PlanillaComboBoxSD.Table = Nothing
        Me.PlanillaComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.PlanillaComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.PlanillaComboBoxSD.User = Nothing
        Me.PlanillaComboBoxSD.ValidField = False
        '
        'TipoDePlanillaLabel
        '
        TipoDePlanillaLabel.AutoSize = True
        TipoDePlanillaLabel.Location = New System.Drawing.Point(581, 662)
        TipoDePlanillaLabel.Name = "TipoDePlanillaLabel"
        TipoDePlanillaLabel.Size = New System.Drawing.Size(84, 13)
        TipoDePlanillaLabel.TabIndex = 634
        TipoDePlanillaLabel.Text = "Tipo De Planilla:"
        '
        'TipoDePlanillaComboBoxSD
        '
        Me.TipoDePlanillaComboBoxSD.AddAll = False
        Me.TipoDePlanillaComboBoxSD.AlternativeQuery = Nothing
        Me.TipoDePlanillaComboBoxSD.BackColor = System.Drawing.Color.White
        Me.TipoDePlanillaComboBoxSD.ColumnDisplay = Nothing
        Me.TipoDePlanillaComboBoxSD.ColumnValue = Nothing
        Me.TipoDePlanillaComboBoxSD.ConcatenarID = True
        Me.TipoDePlanillaComboBoxSD.Conditions = Nothing
        Me.TipoDePlanillaComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.TipoDePlanillaComboBoxSD.FormattingEnabled = True
        Me.TipoDePlanillaComboBoxSD.Location = New System.Drawing.Point(708, 659)
        Me.TipoDePlanillaComboBoxSD.Name = "TipoDePlanillaComboBoxSD"
        Me.TipoDePlanillaComboBoxSD.NumberOfZeros = 0
        Me.TipoDePlanillaComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.TipoDePlanillaComboBoxSD.OrderBy = Nothing
        Me.TipoDePlanillaComboBoxSD.ShowFindDialog = True
        Me.TipoDePlanillaComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.TipoDePlanillaComboBoxSD.TabEnter = True
        Me.TipoDePlanillaComboBoxSD.TabIndex = 635
        Me.TipoDePlanillaComboBoxSD.Table = Nothing
        Me.TipoDePlanillaComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.TipoDePlanillaComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.TipoDePlanillaComboBoxSD.User = Nothing
        Me.TipoDePlanillaComboBoxSD.ValidField = False
        '
        'CatorcenalLabel
        '
        CatorcenalLabel.AutoSize = True
        CatorcenalLabel.Location = New System.Drawing.Point(581, 689)
        CatorcenalLabel.Name = "CatorcenalLabel"
        CatorcenalLabel.Size = New System.Drawing.Size(61, 13)
        CatorcenalLabel.TabIndex = 636
        CatorcenalLabel.Text = "Catorcenal:"
        '
        'CatorcenalTextBox
        '
        Me.CatorcenalTextBox.Location = New System.Drawing.Point(708, 686)
        Me.CatorcenalTextBox.Name = "CatorcenalTextBox"
        Me.CatorcenalTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CatorcenalTextBox.TabIndex = 637
        '
        'IsActivoLabel
        '
        IsActivoLabel.AutoSize = True
        IsActivoLabel.Location = New System.Drawing.Point(581, 717)
        IsActivoLabel.Name = "IsActivoLabel"
        IsActivoLabel.Size = New System.Drawing.Size(50, 13)
        IsActivoLabel.TabIndex = 638
        IsActivoLabel.Text = "is Activo:"
        '
        'IsActivoCheckBox
        '
        Me.IsActivoCheckBox.Location = New System.Drawing.Point(708, 712)
        Me.IsActivoCheckBox.Name = "IsActivoCheckBox"
        Me.IsActivoCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.IsActivoCheckBox.TabIndex = 639
        Me.IsActivoCheckBox.Text = "CheckBox1"
        Me.IsActivoCheckBox.UseVisualStyleBackColor = True
        '
        'IDTiposDeTelefonoLabel
        '
        IDTiposDeTelefonoLabel.AutoSize = True
        IDTiposDeTelefonoLabel.Location = New System.Drawing.Point(853, 213)
        IDTiposDeTelefonoLabel.Name = "IDTiposDeTelefonoLabel"
        IDTiposDeTelefonoLabel.Size = New System.Drawing.Size(109, 13)
        IDTiposDeTelefonoLabel.TabIndex = 639
        IDTiposDeTelefonoLabel.Text = "IDTipos De Telefono:"
        '
        'IDTiposDeTelefonoComboBoxSD
        '
        Me.IDTiposDeTelefonoComboBoxSD.AddAll = False
        Me.IDTiposDeTelefonoComboBoxSD.AlternativeQuery = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.ColumnDisplay = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.ColumnValue = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.ConcatenarID = True
        Me.IDTiposDeTelefonoComboBoxSD.Conditions = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.IDTiposDeTelefonoComboBoxSD.FormattingEnabled = True
        Me.IDTiposDeTelefonoComboBoxSD.Location = New System.Drawing.Point(968, 210)
        Me.IDTiposDeTelefonoComboBoxSD.Name = "IDTiposDeTelefonoComboBoxSD"
        Me.IDTiposDeTelefonoComboBoxSD.NumberOfZeros = 0
        Me.IDTiposDeTelefonoComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.IDTiposDeTelefonoComboBoxSD.OrderBy = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.ShowFindDialog = True
        Me.IDTiposDeTelefonoComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.IDTiposDeTelefonoComboBoxSD.TabEnter = True
        Me.IDTiposDeTelefonoComboBoxSD.TabIndex = 640
        Me.IDTiposDeTelefonoComboBoxSD.Table = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.IDTiposDeTelefonoComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.IDTiposDeTelefonoComboBoxSD.User = Nothing
        Me.IDTiposDeTelefonoComboBoxSD.ValidField = False
        '
        'NumeroTelefonoLabel
        '
        NumeroTelefonoLabel.AutoSize = True
        NumeroTelefonoLabel.Location = New System.Drawing.Point(853, 240)
        NumeroTelefonoLabel.Name = "NumeroTelefonoLabel"
        NumeroTelefonoLabel.Size = New System.Drawing.Size(92, 13)
        NumeroTelefonoLabel.TabIndex = 641
        NumeroTelefonoLabel.Text = "Numero Telefono:"
        '
        'NumeroTelefonoComboBoxSD
        '
        Me.NumeroTelefonoComboBoxSD.AddAll = False
        Me.NumeroTelefonoComboBoxSD.AlternativeQuery = Nothing
        Me.NumeroTelefonoComboBoxSD.ColumnDisplay = Nothing
        Me.NumeroTelefonoComboBoxSD.ColumnValue = Nothing
        Me.NumeroTelefonoComboBoxSD.ConcatenarID = True
        Me.NumeroTelefonoComboBoxSD.Conditions = Nothing
        Me.NumeroTelefonoComboBoxSD.DataBase = "DbRecursosHumanos"
        Me.NumeroTelefonoComboBoxSD.FormattingEnabled = True
        Me.NumeroTelefonoComboBoxSD.Location = New System.Drawing.Point(968, 237)
        Me.NumeroTelefonoComboBoxSD.Name = "NumeroTelefonoComboBoxSD"
        Me.NumeroTelefonoComboBoxSD.NumberOfZeros = 0
        Me.NumeroTelefonoComboBoxSD.Objects = UserWindowsControlLibrary.ComboBoxSD.TypeObjects.Table
        Me.NumeroTelefonoComboBoxSD.OrderBy = Nothing
        Me.NumeroTelefonoComboBoxSD.ShowFindDialog = True
        Me.NumeroTelefonoComboBoxSD.Size = New System.Drawing.Size(121, 21)
        Me.NumeroTelefonoComboBoxSD.TabEnter = True
        Me.NumeroTelefonoComboBoxSD.TabIndex = 642
        Me.NumeroTelefonoComboBoxSD.Table = Nothing
        Me.NumeroTelefonoComboBoxSD.TipoDeOrden = UserWindowsControlLibrary.ComboBoxSD.TiposDeOrden.Desc
        Me.NumeroTelefonoComboBoxSD.TypeField = UserWindowsControlLibrary.ComboBoxSD.TiposDeCampo.Personalizado
        Me.NumeroTelefonoComboBoxSD.User = Nothing
        Me.NumeroTelefonoComboBoxSD.ValidField = False
        '
        'GroupBoxDatosDeIndentificacion
        '
        Me.GroupBoxDatosDeIndentificacion.Controls.Add(Me.Panel1)
        Me.GroupBoxDatosDeIndentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosDeIndentificacion.Location = New System.Drawing.Point(2, 2)
        Me.GroupBoxDatosDeIndentificacion.Name = "GroupBoxDatosDeIndentificacion"
        Me.GroupBoxDatosDeIndentificacion.Size = New System.Drawing.Size(843, 124)
        Me.GroupBoxDatosDeIndentificacion.TabIndex = 643
        Me.GroupBoxDatosDeIndentificacion.TabStop = False
        Me.GroupBoxDatosDeIndentificacion.Text = "DATOS DE IDENTIFICACION"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(ApellidoLabel)
        Me.Panel1.Controls.Add(Me.ApellidoTextBoxSD)
        Me.Panel1.Controls.Add(PrimerApellidoLabel)
        Me.Panel1.Controls.Add(Me.PrimerApellidoTextBoxSD)
        Me.Panel1.Controls.Add(SegundoApellidoLabel)
        Me.Panel1.Controls.Add(Me.SegundoApellidoTextBoxSD)
        Me.Panel1.Controls.Add(Me.PrimerNombreTextBoxSD)
        Me.Panel1.Controls.Add(PrimerNombreLabel)
        Me.Panel1.Controls.Add(Me.SegundoNombreTextBoxSD)
        Me.Panel1.Controls.Add(SegundoNombreLabel)
        Me.Panel1.Controls.Add(NacionalidadLabel)
        Me.Panel1.Controls.Add(Me.NacionalidadComboBoxSD)
        Me.Panel1.Controls.Add(Me.DPITextBoxSD)
        Me.Panel1.Controls.Add(DPILabel)
        Me.Panel1.Controls.Add(Me.NitTextBoxSD)
        Me.Panel1.Controls.Add(FechaDeNacimientoLabel)
        Me.Panel1.Controls.Add(NitLabel)
        Me.Panel1.Controls.Add(SexoLabel)
        Me.Panel1.Controls.Add(Me.FechaDeNacimientoMaskedTextBoxSD)
        Me.Panel1.Controls.Add(Me.SexoComboBoxSD)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 104)
        Me.Panel1.TabIndex = 0
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(336, 5)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(136, 17)
        ApellidoLabel.TabIndex = 599
        ApellidoLabel.Text = "Apellido De Casada:"
        '
        'ApellidoTextBoxSD
        '
        Me.ApellidoTextBoxSD.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.ApellidoTextBoxSD.Location = New System.Drawing.Point(336, 26)
        Me.ApellidoTextBoxSD.Name = "ApellidoTextBoxSD"
        Me.ApellidoTextBoxSD.NumberDecimal = 0
        Me.ApellidoTextBoxSD.Size = New System.Drawing.Size(161, 23)
        Me.ApellidoTextBoxSD.TabEnter = True
        Me.ApellidoTextBoxSD.TabIndex = 600
        Me.ApellidoTextBoxSD.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Personalizado
        Me.ApellidoTextBoxSD.ValidField = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 124)
        Me.GroupBox1.TabIndex = 644
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS GENERALES"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(837, 104)
        Me.Panel2.TabIndex = 0
        '
        'FrmAdminisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1158, 803)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxDatosDeIndentificacion)
        Me.Controls.Add(IDTiposDeTelefonoLabel)
        Me.Controls.Add(Me.IDTiposDeTelefonoComboBoxSD)
        Me.Controls.Add(NumeroTelefonoLabel)
        Me.Controls.Add(Me.NumeroTelefonoComboBoxSD)
        Me.Controls.Add(NumeroDeAsociadoLabel)
        Me.Controls.Add(Me.NumeroDeAsociadoTextBoxSD)
        Me.Controls.Add(NumeroDeEmpleadoLabel)
        Me.Controls.Add(Me.NumeroDeEmpleadoTextBoxSD)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBoxSD)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBoxSD)
        Me.Controls.Add(NombreCompletoLabel)
        Me.Controls.Add(Me.NombreCompletoTextBoxSD)
        Me.Controls.Add(LugarDeNacimientoLabel)
        Me.Controls.Add(Me.LugarDeNacimientoTextBoxSD)
        Me.Controls.Add(DepartamentoLabel)
        Me.Controls.Add(Me.DepartamentoComboBoxSD)
        Me.Controls.Add(MunicipioLabel)
        Me.Controls.Add(Me.MunicipioComboBoxSD)
        Me.Controls.Add(ComunidadLabel)
        Me.Controls.Add(Me.ComunidadComboBoxSD)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBoxSD)
        Me.Controls.Add(EstadoCivilLabel)
        Me.Controls.Add(Me.EstadoCivilComboBoxSD)
        Me.Controls.Add(DepartamentoEmpresaLabel)
        Me.Controls.Add(Me.DepartamentoEmpresaComboBoxSD)
        Me.Controls.Add(FechaDeIngresoLabel)
        Me.Controls.Add(Me.FechaDeIngresoMaskedTextBoxSD)
        Me.Controls.Add(FechaDeEgresoLabel)
        Me.Controls.Add(Me.FechaDeEgresoMaskedTextBoxSD)
        Me.Controls.Add(PlanillaLabel)
        Me.Controls.Add(Me.PlanillaComboBoxSD)
        Me.Controls.Add(TipoDePlanillaLabel)
        Me.Controls.Add(Me.TipoDePlanillaComboBoxSD)
        Me.Controls.Add(CatorcenalLabel)
        Me.Controls.Add(Me.CatorcenalTextBox)
        Me.Controls.Add(IsActivoLabel)
        Me.Controls.Add(Me.IsActivoCheckBox)
        Me.Controls.Add(Me.cndNuevo)
        Me.Controls.Add(Me.txtSalario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCapital)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.chkCatorcenal)
        Me.Controls.Add(Me.txtPlanilla)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.grbBeneficiarios)
        Me.Controls.Add(Me.cmdReporte)
        Me.Controls.Add(Me.pcbCategoria)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdminisiones"
        Me.Text = ":: Adminisiones de nuevos socios ::"
        Me.grbBeneficiarios.ResumeLayout(False)
        Me.grbBeneficiarios.PerformLayout()
        CType(Me.grdBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDatosDeIndentificacion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumeroDeEmpleado As Library.TextBoxSD
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents pcbCategoria As System.Windows.Forms.PictureBox
    Friend WithEvents cmdReporte As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents grbBeneficiarios As System.Windows.Forms.GroupBox
    Friend WithEvents grdBeneficiarios As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombreEmpleado As Library.TextBoxSD
    Friend WithEvents txtDireccion As Library.TextBoxSD
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As Library.TextBoxSD
    Friend WithEvents txtPlanilla As Library.TextBoxSD
    Friend WithEvents tttToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarBeneficiario As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionBeneficiario As Library.TextBoxSD
    Friend WithEvents txtNombreBeneficiario As Library.TextBoxSD
    Friend WithEvents cmdBorrarBeneficiario As System.Windows.Forms.Button
    Friend WithEvents chkCatorcenal As System.Windows.Forms.CheckBox
    Friend WithEvents txtFecha As Library.MaskedTextBoxSD
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCapital As Library.TextBoxSD
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSalario As Library.TextBoxSD
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cndNuevo As System.Windows.Forms.Button
    Friend WithEvents cboParentescos As Library.ComboBoxSD
    Friend WithEvents cboTipoDeBeneficiario As Library.ComboBoxSD
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIdBeneficiario As Library.TextBoxSD
    Friend WithEvents IdBeneficiario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Parentesco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreBeneficiario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionBeneficiario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDeBeneficiario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDeAsociadoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents NumeroDeEmpleadoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents PrimerNombreTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents SegundoNombreTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents NombresTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents PrimerApellidoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents SegundoApellidoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents ApellidosTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents NombreCompletoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents FechaDeNacimientoMaskedTextBoxSD As UserWindowsControlLibrary.MaskedTextBoxSD
    Friend WithEvents LugarDeNacimientoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents SexoComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents NacionalidadComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents NitTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents DPITextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents DepartamentoComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents MunicipioComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents ComunidadComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents DireccionTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents EstadoCivilComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents DepartamentoEmpresaComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents FechaDeIngresoMaskedTextBoxSD As UserWindowsControlLibrary.MaskedTextBoxSD
    Friend WithEvents FechaDeEgresoMaskedTextBoxSD As UserWindowsControlLibrary.MaskedTextBoxSD
    Friend WithEvents PlanillaComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents TipoDePlanillaComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents CatorcenalTextBox As TextBox
    Friend WithEvents IsActivoCheckBox As CheckBox
    Friend WithEvents IDTiposDeTelefonoComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents NumeroTelefonoComboBoxSD As UserWindowsControlLibrary.ComboBoxSD
    Friend WithEvents GroupBoxDatosDeIndentificacion As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DSSolidarismo As DSSolidarismo
    Friend WithEvents TblSociosApellidosCasadaBindingSource As BindingSource
    Friend WithEvents TblSociosApellidosCasadaTableAdapter As DSSolidarismoTableAdapters.TblSociosApellidosCasadaTableAdapter
    Friend WithEvents TableAdapterManager As DSSolidarismoTableAdapters.TableAdapterManager
    Friend WithEvents TblSociosApellidosCasadaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblSociosApellidosCasadaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ApellidoTextBoxSD As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
End Class
