<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarArchivoBanco
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnGenerarArchivo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextoArchivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeAutorizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDocumentoFinal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDocumentoInicial = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCuentaBancaria = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocumentoFinal = New Library.TextBoxSD()
        Me.txtDocumentoInicial = New Library.TextBoxSD()
        Me.txtFechaInicial = New Library.MaskedTextBoxSD()
        Me.txtFechaFinal = New Library.MaskedTextBoxSD()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerarArchivo
        '
        Me.btnGenerarArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarArchivo.Location = New System.Drawing.Point(495, 10)
        Me.btnGenerarArchivo.Name = "btnGenerarArchivo"
        Me.btnGenerarArchivo.Size = New System.Drawing.Size(85, 39)
        Me.btnGenerarArchivo.TabIndex = 5
        Me.btnGenerarArchivo.Text = "Generar Archivo"
        Me.btnGenerarArchivo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Cooperativa.My.Resources.Resources.SearchTwo
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(414, 10)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 39)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grdDatos
        '
        Me.grdDatos.AllowUserToAddRows = False
        Me.grdDatos.AllowUserToDeleteRows = False
        Me.grdDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDatos.BackgroundColor = System.Drawing.Color.White
        Me.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.NumeroDocumento, Me.Valor, Me.Nombre, Me.TextoArchivo, Me.ChequeAutorizado})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDatos.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdDatos.Location = New System.Drawing.Point(2, 63)
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
        Me.grdDatos.Size = New System.Drawing.Size(1004, 665)
        Me.grdDatos.TabIndex = 1
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        Me.NumeroDocumento.HeaderText = "Numero de Documento"
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.ReadOnly = True
        Me.NumeroDocumento.Width = 120
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle3
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 350
        '
        'TextoArchivo
        '
        Me.TextoArchivo.DataPropertyName = "TextoArchivo"
        Me.TextoArchivo.HeaderText = "Texto Archivo"
        Me.TextoArchivo.Name = "TextoArchivo"
        Me.TextoArchivo.ReadOnly = True
        Me.TextoArchivo.Width = 550
        '
        'ChequeAutorizado
        '
        Me.ChequeAutorizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChequeAutorizado.DataPropertyName = "ChequeAutorizado"
        Me.ChequeAutorizado.HeaderText = "Cheque Autorizado"
        Me.ChequeAutorizado.Name = "ChequeAutorizado"
        Me.ChequeAutorizado.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.lblDocumentoFinal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblDocumentoInicial)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblCuentaBancaria)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDocumentoFinal)
        Me.Panel1.Controls.Add(Me.txtDocumentoInicial)
        Me.Panel1.Controls.Add(Me.txtFechaInicial)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtFechaFinal)
        Me.Panel1.Controls.Add(Me.btnGenerarArchivo)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 59)
        Me.Panel1.TabIndex = 0
        '
        'lblDocumentoFinal
        '
        Me.lblDocumentoFinal.BackColor = System.Drawing.Color.LightGreen
        Me.lblDocumentoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentoFinal.Location = New System.Drawing.Point(853, 23)
        Me.lblDocumentoFinal.Name = "lblDocumentoFinal"
        Me.lblDocumentoFinal.Size = New System.Drawing.Size(129, 26)
        Me.lblDocumentoFinal.TabIndex = 6
        Me.lblDocumentoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(853, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Documento Final"
        '
        'lblDocumentoInicial
        '
        Me.lblDocumentoInicial.BackColor = System.Drawing.Color.LightGreen
        Me.lblDocumentoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentoInicial.Location = New System.Drawing.Point(720, 23)
        Me.lblDocumentoInicial.Name = "lblDocumentoInicial"
        Me.lblDocumentoInicial.Size = New System.Drawing.Size(129, 26)
        Me.lblDocumentoInicial.TabIndex = 6
        Me.lblDocumentoInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(720, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Documento Inicial"
        '
        'lblCuentaBancaria
        '
        Me.lblCuentaBancaria.BackColor = System.Drawing.Color.LightGreen
        Me.lblCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaBancaria.Location = New System.Drawing.Point(585, 23)
        Me.lblCuentaBancaria.Name = "lblCuentaBancaria"
        Me.lblCuentaBancaria.Size = New System.Drawing.Size(129, 26)
        Me.lblCuentaBancaria.TabIndex = 6
        Me.lblCuentaBancaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(585, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cuenta Bancaria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Documento Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Documento Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Inicial"
        '
        'txtDocumentoFinal
        '
        Me.txtDocumentoFinal.AutoTrim = True
        Me.txtDocumentoFinal.BackColor = System.Drawing.Color.LightGray
        Me.txtDocumentoFinal.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDocumentoFinal.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDocumentoFinal.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDocumentoFinal.BordesRedondeados = False
        Me.txtDocumentoFinal.CantidadDecimales = CType(2, Short)
        Me.txtDocumentoFinal.CantidadEnteros = CType(15, Short)
        Me.txtDocumentoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoFinal.Location = New System.Drawing.Point(312, 23)
        Me.txtDocumentoFinal.Name = "txtDocumentoFinal"
        Me.txtDocumentoFinal.NavegarConEnter = True
        Me.txtDocumentoFinal.NumeroDeDecimales = 0
        Me.txtDocumentoFinal.Size = New System.Drawing.Size(100, 26)
        Me.txtDocumentoFinal.TabIndex = 3
        Me.txtDocumentoFinal.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtDocumentoFinal.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDocumentoFinal.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDocumentoFinal.ValidChars = Nothing
        '
        'txtDocumentoInicial
        '
        Me.txtDocumentoInicial.AutoTrim = True
        Me.txtDocumentoInicial.BackColor = System.Drawing.Color.LightGray
        Me.txtDocumentoInicial.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtDocumentoInicial.BordeNormal = System.Drawing.Color.DimGray
        Me.txtDocumentoInicial.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtDocumentoInicial.BordesRedondeados = False
        Me.txtDocumentoInicial.CantidadDecimales = CType(2, Short)
        Me.txtDocumentoInicial.CantidadEnteros = CType(15, Short)
        Me.txtDocumentoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoInicial.Location = New System.Drawing.Point(209, 23)
        Me.txtDocumentoInicial.Name = "txtDocumentoInicial"
        Me.txtDocumentoInicial.NavegarConEnter = True
        Me.txtDocumentoInicial.NumeroDeDecimales = 0
        Me.txtDocumentoInicial.Size = New System.Drawing.Size(100, 26)
        Me.txtDocumentoInicial.TabIndex = 2
        Me.txtDocumentoInicial.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Opcional
        Me.txtDocumentoInicial.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtDocumentoInicial.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtDocumentoInicial.ValidChars = Nothing
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicial.Location = New System.Drawing.Point(3, 23)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NavegarConEnter = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(100, 26)
        Me.txtFechaInicial.TabIndex = 0
        Me.txtFechaInicial.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaInicial.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        Me.txtFechaInicial.ValidatingType = GetType(Date)
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinal.Location = New System.Drawing.Point(106, 23)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NavegarConEnter = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(100, 26)
        Me.txtFechaFinal.TabIndex = 1
        Me.txtFechaFinal.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaFinal.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        Me.txtFechaFinal.ValidatingType = GetType(Date)
        '
        'FrmGenerarArchivoBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grdDatos)
        Me.Name = "FrmGenerarArchivoBanco"
        Me.Text = "FrmGenerarArchivoBanco"
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnGenerarArchivo As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtFechaInicial As Library.MaskedTextBoxSD
    Friend WithEvents txtFechaFinal As Library.MaskedTextBoxSD
    Friend WithEvents txtDocumentoInicial As Library.TextBoxSD
    Friend WithEvents grdDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextoArchivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChequeAutorizado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDocumentoFinal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDocumentoInicial As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCuentaBancaria As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDocumentoFinal As Library.TextBoxSD
End Class
