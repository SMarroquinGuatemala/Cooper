<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChequesAuxilioPostumoDetalleTipoDePlanilla
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
        Me.grdDatos = New System.Windows.Forms.DataGridView()
        Me.TipoDePlanillaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtTotal = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtNumeroDeDocumento = New UserWindowsControlLibrary.TextBoxSD()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCuota = New UserWindowsControlLibrary.TextBoxSD()
        Me.txtNombreFallecido = New UserWindowsControlLibrary.TextBoxSD()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.grdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoDePlanillaColumn, Me.NombreColumn, Me.ValorColumn})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDatos.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdDatos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.grdDatos.Location = New System.Drawing.Point(3, 54)
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
        Me.grdDatos.Size = New System.Drawing.Size(475, 220)
        Me.grdDatos.TabIndex = 5
        '
        'TipoDePlanillaColumn
        '
        Me.TipoDePlanillaColumn.DataPropertyName = "TipoDePlanilla"
        Me.TipoDePlanillaColumn.HeaderText = "Tipo De Planilla"
        Me.TipoDePlanillaColumn.Name = "TipoDePlanillaColumn"
        Me.TipoDePlanillaColumn.ReadOnly = True
        Me.TipoDePlanillaColumn.Width = 120
        '
        'NombreColumn
        '
        Me.NombreColumn.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.Format = "d"
        Me.NombreColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NombreColumn.HeaderText = "Nombre"
        Me.NombreColumn.Name = "NombreColumn"
        Me.NombreColumn.ReadOnly = True
        Me.NombreColumn.Width = 200
        '
        'ValorColumn
        '
        Me.ValorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValorColumn.DataPropertyName = "Valor"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ValorColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ValorColumn.HeaderText = "Valor"
        Me.ValorColumn.Name = "ValorColumn"
        Me.ValorColumn.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtTotal, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 278)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(481, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtTotal
        '
        Me.txtTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 25)
        Me.txtTotal.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "Total:"
        '
        'txtNumeroDeDocumento
        '
        Me.txtNumeroDeDocumento.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtNumeroDeDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeDocumento.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.txtNumeroDeDocumento.Location = New System.Drawing.Point(7, 22)
        Me.txtNumeroDeDocumento.MaxLength = 7
        Me.txtNumeroDeDocumento.Name = "txtNumeroDeDocumento"
        Me.txtNumeroDeDocumento.NumberDecimal = 0
        Me.txtNumeroDeDocumento.Size = New System.Drawing.Size(100, 21)
        Me.txtNumeroDeDocumento.TabEnter = True
        Me.txtNumeroDeDocumento.TabIndex = 7
        Me.txtNumeroDeDocumento.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Obligatorio
        Me.txtNumeroDeDocumento.ValidField = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "No. de Documento"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCuota)
        Me.Panel1.Controls.Add(Me.txtNombreFallecido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNumeroDeDocumento)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 49)
        Me.Panel1.TabIndex = 9
        '
        'txtCuota
        '
        Me.txtCuota.BackColor = System.Drawing.Color.LightGreen
        Me.txtCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuota.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.txtCuota.Location = New System.Drawing.Point(399, 22)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.NumberDecimal = 0
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(73, 21)
        Me.txtCuota.TabEnter = True
        Me.txtCuota.TabIndex = 9
        Me.txtCuota.TabStop = False
        Me.txtCuota.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtCuota.ValidField = False
        '
        'txtNombreFallecido
        '
        Me.txtNombreFallecido.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombreFallecido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreFallecido.FormatInput = UserWindowsControlLibrary.TextBoxSD.InputFormat.InputString
        Me.txtNombreFallecido.Location = New System.Drawing.Point(111, 22)
        Me.txtNombreFallecido.Name = "txtNombreFallecido"
        Me.txtNombreFallecido.NumberDecimal = 0
        Me.txtNombreFallecido.ReadOnly = True
        Me.txtNombreFallecido.Size = New System.Drawing.Size(284, 21)
        Me.txtNombreFallecido.TabEnter = True
        Me.txtNombreFallecido.TabIndex = 9
        Me.txtNombreFallecido.TabStop = False
        Me.txtNombreFallecido.TypeField = UserWindowsControlLibrary.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombreFallecido.ValidField = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(399, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cuota:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "No. de Documento"
        '
        'FrmChequesAuxilioPostumoDetalleTipoDePlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 303)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdDatos)
        Me.KeyPreview = True
        Me.Name = "FrmChequesAuxilioPostumoDetalleTipoDePlanilla"
        Me.Text = "FrmChequesAuxilioPostumoDetalleTipoDePlanilla"
        CType(Me.grdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDatos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TipoDePlanillaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotal As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtNumeroDeDocumento As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCuota As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents txtNombreFallecido As UserWindowsControlLibrary.TextBoxSD
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
