<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleadosTecleo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaFinal = New Library.MaskedTextBoxSD()
        Me.txtFechaInicial = New Library.MaskedTextBoxSD()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New Library.TextBoxSD()
        Me.txtNumeroDeEmpleado = New Library.TextBoxSD()
        Me.txtApellidos = New Library.TextBoxSD()
        Me.txtNombres = New Library.TextBoxSD()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(2, 252)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(714, 190)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.txtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Controls.Add(Me.txtNumeroDeEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 244)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Fecha Inicial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Fecha Inicial"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.BackColor = System.Drawing.Color.LightGray
        Me.txtFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinal.Location = New System.Drawing.Point(91, 218)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NavegarConEnter = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(85, 23)
        Me.txtFechaFinal.TabIndex = 19
        Me.txtFechaFinal.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Opcional
        Me.txtFechaFinal.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        Me.txtFechaFinal.ValidatingType = GetType(Date)
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicial.Location = New System.Drawing.Point(6, 218)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NavegarConEnter = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(82, 23)
        Me.txtFechaInicial.TabIndex = 18
        Me.txtFechaInicial.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaInicial.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        Me.txtFechaInicial.ValidatingType = GetType(Date)
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.plainicon_com_49341_32px_ef2
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(179, 203)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(83, 38)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Grabar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "No. de Empleado"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.AutoTrim = True
        Me.txtNombreCompleto.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombreCompleto.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombreCompleto.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombreCompleto.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombreCompleto.BordesRedondeados = False
        Me.txtNombreCompleto.CantidadDecimales = CType(2, Short)
        Me.txtNombreCompleto.CantidadEnteros = CType(15, Short)
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(6, 174)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.NavegarConEnter = True
        Me.txtNombreCompleto.NumeroDeDecimales = 0
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(256, 23)
        Me.txtNombreCompleto.TabIndex = 15
        Me.txtNombreCompleto.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombreCompleto.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombreCompleto.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombreCompleto.ValidChars = Nothing
        '
        'txtNumeroDeEmpleado
        '
        Me.txtNumeroDeEmpleado.AutoTrim = True
        Me.txtNumeroDeEmpleado.BackColor = System.Drawing.Color.LightGreen
        Me.txtNumeroDeEmpleado.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNumeroDeEmpleado.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNumeroDeEmpleado.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNumeroDeEmpleado.BordesRedondeados = False
        Me.txtNumeroDeEmpleado.CantidadDecimales = CType(2, Short)
        Me.txtNumeroDeEmpleado.CantidadEnteros = CType(15, Short)
        Me.txtNumeroDeEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDeEmpleado.Location = New System.Drawing.Point(6, 40)
        Me.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado"
        Me.txtNumeroDeEmpleado.NavegarConEnter = True
        Me.txtNumeroDeEmpleado.NumeroDeDecimales = 0
        Me.txtNumeroDeEmpleado.ReadOnly = True
        Me.txtNumeroDeEmpleado.Size = New System.Drawing.Size(100, 23)
        Me.txtNumeroDeEmpleado.TabIndex = 12
        Me.txtNumeroDeEmpleado.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNumeroDeEmpleado.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNumeroDeEmpleado.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNumeroDeEmpleado.ValidChars = Nothing
        '
        'txtApellidos
        '
        Me.txtApellidos.AutoTrim = True
        Me.txtApellidos.BackColor = System.Drawing.Color.LightGreen
        Me.txtApellidos.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtApellidos.BordeNormal = System.Drawing.Color.DimGray
        Me.txtApellidos.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtApellidos.BordesRedondeados = False
        Me.txtApellidos.CantidadDecimales = CType(2, Short)
        Me.txtApellidos.CantidadEnteros = CType(15, Short)
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(6, 130)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.NavegarConEnter = True
        Me.txtApellidos.NumeroDeDecimales = 0
        Me.txtApellidos.ReadOnly = True
        Me.txtApellidos.Size = New System.Drawing.Size(256, 23)
        Me.txtApellidos.TabIndex = 14
        Me.txtApellidos.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtApellidos.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtApellidos.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtApellidos.ValidChars = Nothing
        '
        'txtNombres
        '
        Me.txtNombres.AutoTrim = True
        Me.txtNombres.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombres.BordeDisable = System.Drawing.Color.DarkGray
        Me.txtNombres.BordeNormal = System.Drawing.Color.DimGray
        Me.txtNombres.BordeOnFocus = System.Drawing.Color.Blue
        Me.txtNombres.BordesRedondeados = False
        Me.txtNombres.CantidadDecimales = CType(2, Short)
        Me.txtNombres.CantidadEnteros = CType(15, Short)
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(6, 84)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.NavegarConEnter = True
        Me.txtNombres.NumeroDeDecimales = 0
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(256, 23)
        Me.txtNombres.TabIndex = 13
        Me.txtNombres.TipoDeCampo = Library.TextBoxSD.TiposDeCampo.Desplieque
        Me.txtNombres.TiposDeFormato = Library.TextBoxSD.Formato.Undefined
        Me.txtNombres.TiposFiltro = Library.TextBoxSD.Filtro.Indefinido
        Me.txtNombres.ValidChars = Nothing
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 439)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(718, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FrmEmpleadosTecleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 464)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmEmpleadosTecleo"
        Me.Text = "FrmEmpleadosTecleo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFinal As Library.MaskedTextBoxSD
    Friend WithEvents txtFechaInicial As Library.MaskedTextBoxSD
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCompleto As Library.TextBoxSD
    Friend WithEvents txtNumeroDeEmpleado As Library.TextBoxSD
    Friend WithEvents txtApellidos As Library.TextBoxSD
    Friend WithEvents txtNombres As Library.TextBoxSD
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
End Class
