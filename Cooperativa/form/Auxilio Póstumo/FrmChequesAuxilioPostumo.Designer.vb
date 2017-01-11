<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChequesAuxilioPostumo
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumeroDeEmpleado = New UserWindowsControlLibrary.TextBoxSD()
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.NumeroDeEmpleadoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompletoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeParentezcoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeParentezcoNombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreFallecidoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumentoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuotaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTransaccionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnuOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 52)
        Me.Panel1.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.Cooperativa.My.Resources.Resources._32
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(194, 7)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 36)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        'txtNumeroDeEmpleado
        '
        Me.txtNumeroDeEmpleado.BackColor = System.Drawing.Color.LightGray
        Me.txtNumeroDeEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeEmpleado.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(3, 22)
        Me.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado"
        Me.txtNumeroDeEmpleado.NumberDecimal = 0
        Me.txtNumeroDeEmpleado.Size = New System.Drawing.Size(92, 21)
        Me.txtNumeroDeEmpleado.TabEnter = True
        Me.txtNumeroDeEmpleado.TabIndex = 0
        Me.txtNumeroDeEmpleado.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Opcional
        Me.txtNumeroDeEmpleado.ValidField = False
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
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDeEmpleadoColumn, Me.NombreCompletoColumn, Me.TipoDeParentezcoColumn, Me.TipoDeParentezcoNombreColumn, Me.NombreFallecidoColumn, Me.FechaColumn, Me.NumeroDocumentoColumn, Me.CuotaColumn, Me.ValorColumn, Me.DescripcionColumn, Me.ObservacionesColumn, Me.IdTransaccionColumn})
        Me.grdDatos.ContextMenuStrip = Me.MnuOpciones
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDatos.DefaultCellStyle = DataGridViewCellStyle9
        Me.grdDatos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grdDatos.Location = New System.Drawing.Point(2, 57)
        Me.grdDatos.Name = "grdDatos"
        Me.grdDatos.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdDatos.RowHeadersWidth = 25
        Me.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDatos.Size = New System.Drawing.Size(691, 203)
        Me.grdDatos.TabIndex = 4
        '
        'NumeroDeEmpleadoColumn
        '
        Me.NumeroDeEmpleadoColumn.DataPropertyName = "NumeroDeEmpleado"
        Me.NumeroDeEmpleadoColumn.HeaderText = "No. Empleado"
        Me.NumeroDeEmpleadoColumn.Name = "NumeroDeEmpleadoColumn"
        Me.NumeroDeEmpleadoColumn.ReadOnly = True
        '
        'NombreCompletoColumn
        '
        Me.NombreCompletoColumn.DataPropertyName = "NombreCompleto"
        DataGridViewCellStyle2.Format = "d"
        Me.NombreCompletoColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NombreCompletoColumn.HeaderText = "Nombre"
        Me.NombreCompletoColumn.Name = "NombreCompletoColumn"
        Me.NombreCompletoColumn.ReadOnly = True
        Me.NombreCompletoColumn.Width = 180
        '
        'TipoDeParentezcoColumn
        '
        Me.TipoDeParentezcoColumn.DataPropertyName = "TipoDeParentezco"
        Me.TipoDeParentezcoColumn.HeaderText = "Parentezco"
        Me.TipoDeParentezcoColumn.Name = "TipoDeParentezcoColumn"
        Me.TipoDeParentezcoColumn.ReadOnly = True
        Me.TipoDeParentezcoColumn.Width = 70
        '
        'TipoDeParentezcoNombreColumn
        '
        Me.TipoDeParentezcoNombreColumn.DataPropertyName = "TipoDeParentezcoNombre"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TipoDeParentezcoNombreColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TipoDeParentezcoNombreColumn.HeaderText = "Descripcion"
        Me.TipoDeParentezcoNombreColumn.Name = "TipoDeParentezcoNombreColumn"
        Me.TipoDeParentezcoNombreColumn.ReadOnly = True
        Me.TipoDeParentezcoNombreColumn.Width = 140
        '
        'NombreFallecidoColumn
        '
        Me.NombreFallecidoColumn.DataPropertyName = "NombreFallecido"
        Me.NombreFallecidoColumn.HeaderText = "Nombre de Fallecido"
        Me.NombreFallecidoColumn.Name = "NombreFallecidoColumn"
        Me.NombreFallecidoColumn.ReadOnly = True
        Me.NombreFallecidoColumn.Width = 160
        '
        'FechaColumn
        '
        Me.FechaColumn.DataPropertyName = "Fecha"
        Me.FechaColumn.HeaderText = "Fecha"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        Me.FechaColumn.Width = 120
        '
        'NumeroDocumentoColumn
        '
        Me.NumeroDocumentoColumn.DataPropertyName = "NumeroDocumento"
        Me.NumeroDocumentoColumn.HeaderText = "No. Documento"
        Me.NumeroDocumentoColumn.Name = "NumeroDocumentoColumn"
        Me.NumeroDocumentoColumn.ReadOnly = True
        '
        'CuotaColumn
        '
        Me.CuotaColumn.DataPropertyName = "Cuota"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CuotaColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CuotaColumn.HeaderText = "Cuota"
        Me.CuotaColumn.Name = "CuotaColumn"
        Me.CuotaColumn.ReadOnly = True
        Me.CuotaColumn.Width = 70
        '
        'ValorColumn
        '
        Me.ValorColumn.DataPropertyName = "Valor"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ValorColumn.HeaderText = "Valor"
        Me.ValorColumn.Name = "ValorColumn"
        Me.ValorColumn.ReadOnly = True
        Me.ValorColumn.Width = 70
        '
        'DescripcionColumn
        '
        Me.DescripcionColumn.DataPropertyName = "Descripcion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DescripcionColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DescripcionColumn.HeaderText = "Descripcion"
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        Me.DescripcionColumn.Width = 70
        '
        'ObservacionesColumn
        '
        Me.ObservacionesColumn.DataPropertyName = "Observaciones"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ObservacionesColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ObservacionesColumn.HeaderText = "Observaciones"
        Me.ObservacionesColumn.Name = "ObservacionesColumn"
        Me.ObservacionesColumn.ReadOnly = True
        '
        'IdTransaccionColumn
        '
        Me.IdTransaccionColumn.DataPropertyName = "IdTransaccion"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IdTransaccionColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.IdTransaccionColumn.HeaderText = "IdTransaccion"
        Me.IdTransaccionColumn.Name = "IdTransaccionColumn"
        Me.IdTransaccionColumn.ReadOnly = True
        Me.IdTransaccionColumn.Visible = False
        '
        'MnuOpciones
        '
        Me.MnuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerDetalleToolStripMenuItem})
        Me.MnuOpciones.Name = "MnuOpciones"
        Me.MnuOpciones.Size = New System.Drawing.Size(153, 48)
        '
        'VerDetalleToolStripMenuItem
        '
        Me.VerDetalleToolStripMenuItem.Name = "VerDetalleToolStripMenuItem"
        Me.VerDetalleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerDetalleToolStripMenuItem.Text = "Ver Detalle"
        '
        'FrmChequesAuxilioPostumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 262)
        Me.Controls.Add(Me.grdDatos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmChequesAuxilioPostumo"
        Me.Text = "FrmChequesAuxilioPostumo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNumeroDeEmpleado As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents grdDatos As System.Windows.Forms.DataGridView
    Friend WithEvents NumeroDeEmpleadoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCompletoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDeParentezcoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDeParentezcoNombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreFallecidoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumentoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuotaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTransaccionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnuOpciones As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
