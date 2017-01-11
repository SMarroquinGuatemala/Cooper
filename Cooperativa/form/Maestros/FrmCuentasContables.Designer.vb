<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentasContables
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
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.grdCuentasContables = New System.Windows.Forms.DataGridView()
        Me.cellCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellAuxiliar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellClasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbDatosDeLaCuenta = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAuxiliar = New Library.TextBoxSD()
        Me.cboClasificacion = New Library.ComboBoxSD()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New Library.TextBoxSD()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New Library.TextBoxSD()
        Me.txtNombre = New Library.TextBoxSD()
        CType(Me.grdCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosDeLaCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMensajes
        '
        Me.lblMensajes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensajes.BackColor = System.Drawing.Color.SteelBlue
        Me.lblMensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajes.ForeColor = System.Drawing.Color.White
        Me.lblMensajes.Location = New System.Drawing.Point(6, 97)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(589, 26)
        Me.lblMensajes.TabIndex = 5
        Me.lblMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdCuentasContables
        '
        Me.grdCuentasContables.AllowUserToAddRows = False
        Me.grdCuentasContables.AllowUserToDeleteRows = False
        Me.grdCuentasContables.AllowUserToResizeRows = False
        Me.grdCuentasContables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCuentasContables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCuentasContables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cellCuenta, Me.cellNombre, Me.cellDescripcion, Me.cellAuxiliar, Me.cellClasificacion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCuentasContables.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCuentasContables.Location = New System.Drawing.Point(5, 126)
        Me.grdCuentasContables.Name = "grdCuentasContables"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCuentasContables.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdCuentasContables.RowHeadersVisible = False
        Me.grdCuentasContables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCuentasContables.Size = New System.Drawing.Size(590, 285)
        Me.grdCuentasContables.TabIndex = 4
        '
        'cellCuenta
        '
        Me.cellCuenta.DataPropertyName = "CuentaContable"
        Me.cellCuenta.HeaderText = "Cuenta"
        Me.cellCuenta.Name = "cellCuenta"
        '
        'cellNombre
        '
        Me.cellNombre.DataPropertyName = "Nombre"
        Me.cellNombre.HeaderText = "Nombre"
        Me.cellNombre.Name = "cellNombre"
        '
        'cellDescripcion
        '
        Me.cellDescripcion.DataPropertyName = "Descripcion"
        Me.cellDescripcion.HeaderText = "Descripcion"
        Me.cellDescripcion.Name = "cellDescripcion"
        '
        'cellAuxiliar
        '
        Me.cellAuxiliar.DataPropertyName = "Auxiliar"
        Me.cellAuxiliar.HeaderText = "Auxiliar"
        Me.cellAuxiliar.Name = "cellAuxiliar"
        '
        'cellClasificacion
        '
        Me.cellClasificacion.DataPropertyName = "Clasificacion"
        Me.cellClasificacion.HeaderText = "Clasificacion"
        Me.cellClasificacion.Name = "cellClasificacion"
        '
        'grbDatosDeLaCuenta
        '
        Me.grbDatosDeLaCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbDatosDeLaCuenta.BackColor = System.Drawing.SystemColors.Control
        Me.grbDatosDeLaCuenta.Controls.Add(Me.Label1)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.txtAuxiliar)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.cboClasificacion)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.Descripcion)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.txtDescripcion)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.cmdGrabar)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.cmdNuevo)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.cmdBuscar)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.Label12)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.Label4)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.Label2)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.txtCuentaContable)
        Me.grbDatosDeLaCuenta.Controls.Add(Me.txtNombre)
        Me.grbDatosDeLaCuenta.Location = New System.Drawing.Point(5, 1)
        Me.grbDatosDeLaCuenta.Name = "grbDatosDeLaCuenta"
        Me.grbDatosDeLaCuenta.Size = New System.Drawing.Size(590, 93)
        Me.grbDatosDeLaCuenta.TabIndex = 0
        Me.grbDatosDeLaCuenta.TabStop = False
        Me.grbDatosDeLaCuenta.Text = "Datos de la cuenta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Auxiliar"
        '
        'txtAuxiliar
        '
        Me.txtAuxiliar.AutoTrim = True
        Me.txtAuxiliar.BackColor = System.Drawing.Color.LightGray
        Me.txtAuxiliar.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtAuxiliar.BordeNormal = System.Drawing.Color.DimGray
        Me.txtAuxiliar.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtAuxiliar.BordesRedondeados = False
        Me.txtAuxiliar.CantidadDecimales = CType(2, Short)
        Me.txtAuxiliar.CantidadEnteros = CType(15, Short)
        Me.txtAuxiliar.Location = New System.Drawing.Point(326, 31)
        Me.txtAuxiliar.MaxLength = 100
        Me.txtAuxiliar.Name = "txtAuxiliar"
        Me.txtAuxiliar.NavegarConEnter = True
        Me.txtAuxiliar.NumeroDeDecimales = 0
        Me.txtAuxiliar.Size = New System.Drawing.Size(74, 20)
        Me.txtAuxiliar.TabIndex = 2
        Me.txtAuxiliar.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtAuxiliar.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtAuxiliar.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtAuxiliar.ValidChars = Nothing
        '
        'cboClasificacion
        '
        Me.cboClasificacion.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboClasificacion.cnDefault = "Data Source=sqlsdfca5;Initial Catalog=DbCooperativa;Integrated Security=True; App" & _
    "lication Name=Cooperativa"
        Me.cboClasificacion.Codigo = ""
        Me.cboClasificacion.FormattingEnabled = True
        Me.cboClasificacion.Location = New System.Drawing.Point(279, 66)
        Me.cboClasificacion.Name = "cboClasificacion"
        Me.cboClasificacion.NavegarConEnter = True
        Me.cboClasificacion.Separador = "-"
        Me.cboClasificacion.Size = New System.Drawing.Size(121, 21)
        Me.cboClasificacion.sqlQuery = ""
        Me.cboClasificacion.TabIndex = 4
        Me.cboClasificacion.TipoDeCampo = Library.ComboBoxSD.TiposDeCampo.Obligatorio
        Me.cboClasificacion.TipoValidacion = Library.ComboBoxSD.TiposValidacion.Tabla
        Me.cboClasificacion.ValidAllText = False
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(6, 53)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 62
        Me.Descripcion.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoTrim = True
        Me.txtDescripcion.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtDescripcion.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDescripcion.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDescripcion.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDescripcion.BordesRedondeados = False
        Me.txtDescripcion.CantidadDecimales = CType(2, Short)
        Me.txtDescripcion.CantidadEnteros = CType(15, Short)
        Me.txtDescripcion.Location = New System.Drawing.Point(6, 67)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.NavegarConEnter = True
        Me.txtDescripcion.NumeroDeDecimales = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(270, 20)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtDescripcion.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDescripcion.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDescripcion.ValidChars = Nothing
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Image = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabar.Location = New System.Drawing.Point(464, 19)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(58, 57)
        Me.cmdGrabar.TabIndex = 5
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Document_64
        Me.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNuevo.Location = New System.Drawing.Point(523, 19)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(57, 57)
        Me.cmdNuevo.TabIndex = 7
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Search_64
        Me.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBuscar.Location = New System.Drawing.Point(406, 19)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(57, 57)
        Me.cmdBuscar.TabIndex = 6
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(276, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Clasificacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Nombre"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.AutoTrim = True
        Me.txtCuentaContable.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuentaContable.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtCuentaContable.BordeNormal = System.Drawing.Color.DimGray
        Me.txtCuentaContable.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtCuentaContable.BordesRedondeados = False
        Me.txtCuentaContable.CantidadDecimales = CType(2, Short)
        Me.txtCuentaContable.CantidadEnteros = CType(15, Short)
        Me.txtCuentaContable.Location = New System.Drawing.Point(6, 31)
        Me.txtCuentaContable.MaxLength = 5
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.NavegarConEnter = True
        Me.txtCuentaContable.NumeroDeDecimales = 0
        Me.txtCuentaContable.Size = New System.Drawing.Size(55, 20)
        Me.txtCuentaContable.TabIndex = 0
        Me.txtCuentaContable.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtCuentaContable.TiposDeFormato = Library.TextBoxSD.Formato.Texto
        Me.txtCuentaContable.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtCuentaContable.ValidChars = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.AutoTrim = True
        Me.txtNombre.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNombre.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombre.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombre.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombre.BordesRedondeados = False
        Me.txtNombre.CantidadDecimales = CType(2, Short)
        Me.txtNombre.CantidadEnteros = CType(15, Short)
        Me.txtNombre.Location = New System.Drawing.Point(67, 31)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.NavegarConEnter = True
        Me.txtNombre.NumeroDeDecimales = 0
        Me.txtNombre.Size = New System.Drawing.Size(254, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNombre.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombre.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombre.ValidChars = Nothing
        '
        'FrmCuentasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 412)
        Me.Controls.Add(Me.lblMensajes)
        Me.Controls.Add(Me.grdCuentasContables)
        Me.Controls.Add(Me.grbDatosDeLaCuenta)
        Me.Name = "FrmCuentasContables"
        Me.Text = "FrmCuentasContables"
        CType(Me.grdCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosDeLaCuenta.ResumeLayout(False)
        Me.grbDatosDeLaCuenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents grdCuentasContables As System.Windows.Forms.DataGridView
    Friend WithEvents grbDatosDeLaCuenta As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContable As Library.TextBoxSD
    Friend WithEvents txtNombre As Library.TextBoxSD
    Friend WithEvents Descripcion As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As Library.TextBoxSD
    Friend WithEvents cboClasificacion As Library.ComboBoxSD
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAuxiliar As Library.TextBoxSD
    Friend WithEvents cellCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellAuxiliar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cellClasificacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
