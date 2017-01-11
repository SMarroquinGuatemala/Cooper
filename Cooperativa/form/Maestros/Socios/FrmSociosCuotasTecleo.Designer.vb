<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSociosCuotasTecleo
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
        Dim NumeroDeEmpleadoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim RetencionLabel As System.Windows.Forms.Label
        Dim FechaFinalLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim CapitalLabel As System.Windows.Forms.Label
        Dim InteresesLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Me.NumeroDeEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.cboRetenciones = New System.Windows.Forms.ComboBox()
        Me.FechaFinalMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.CapitalTextBox = New System.Windows.Forms.TextBox()
        Me.InteresesTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombreDeEmpleado = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        NumeroDeEmpleadoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        RetencionLabel = New System.Windows.Forms.Label()
        FechaFinalLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CapitalLabel = New System.Windows.Forms.Label()
        InteresesLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumeroDeEmpleadoLabel
        '
        NumeroDeEmpleadoLabel.AutoSize = True
        NumeroDeEmpleadoLabel.Location = New System.Drawing.Point(9, 6)
        NumeroDeEmpleadoLabel.Name = "NumeroDeEmpleadoLabel"
        NumeroDeEmpleadoLabel.Size = New System.Drawing.Size(77, 13)
        NumeroDeEmpleadoLabel.TabIndex = 1
        NumeroDeEmpleadoLabel.Text = "No. Empleado:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(9, 45)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'RetencionLabel
        '
        RetencionLabel.AutoSize = True
        RetencionLabel.Location = New System.Drawing.Point(88, 44)
        RetencionLabel.Name = "RetencionLabel"
        RetencionLabel.Size = New System.Drawing.Size(59, 13)
        RetencionLabel.TabIndex = 5
        RetencionLabel.Text = "Retencion:"
        '
        'FechaFinalLabel
        '
        FechaFinalLabel.AutoSize = True
        FechaFinalLabel.Location = New System.Drawing.Point(9, 84)
        FechaFinalLabel.Name = "FechaFinalLabel"
        FechaFinalLabel.Size = New System.Drawing.Size(65, 13)
        FechaFinalLabel.TabIndex = 7
        FechaFinalLabel.Text = "Fecha Final:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(88, 84)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 9
        DescripcionLabel.Text = "Descripcion:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(9, 123)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 11
        ObservacionesLabel.Text = "Observaciones:"
        '
        'CapitalLabel
        '
        CapitalLabel.AutoSize = True
        CapitalLabel.Location = New System.Drawing.Point(9, 162)
        CapitalLabel.Name = "CapitalLabel"
        CapitalLabel.Size = New System.Drawing.Size(42, 13)
        CapitalLabel.TabIndex = 13
        CapitalLabel.Text = "Capital:"
        '
        'InteresesLabel
        '
        InteresesLabel.AutoSize = True
        InteresesLabel.Location = New System.Drawing.Point(88, 162)
        InteresesLabel.Name = "InteresesLabel"
        InteresesLabel.Size = New System.Drawing.Size(53, 13)
        InteresesLabel.TabIndex = 15
        InteresesLabel.Text = "Intereses:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(167, 162)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 17
        ValorLabel.Text = "Valor:"
        '
        'NumeroDeEmpleadoTextBox
        '
        Me.NumeroDeEmpleadoTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.NumeroDeEmpleadoTextBox.Location = New System.Drawing.Point(9, 22)
        Me.NumeroDeEmpleadoTextBox.MaxLength = 7
        Me.NumeroDeEmpleadoTextBox.Name = "NumeroDeEmpleadoTextBox"
        Me.NumeroDeEmpleadoTextBox.Size = New System.Drawing.Size(77, 20)
        Me.NumeroDeEmpleadoTextBox.TabIndex = 2
        '
        'FechaMaskedTextBox
        '
        Me.FechaMaskedTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.FechaMaskedTextBox.Location = New System.Drawing.Point(9, 61)
        Me.FechaMaskedTextBox.Mask = "00/00/0000"
        Me.FechaMaskedTextBox.Name = "FechaMaskedTextBox"
        Me.FechaMaskedTextBox.Size = New System.Drawing.Size(77, 20)
        Me.FechaMaskedTextBox.TabIndex = 4
        Me.FechaMaskedTextBox.ValidatingType = GetType(Date)
        '
        'cboRetenciones
        '
        Me.cboRetenciones.BackColor = System.Drawing.Color.LemonChiffon
        Me.cboRetenciones.FormattingEnabled = True
        Me.cboRetenciones.Location = New System.Drawing.Point(88, 60)
        Me.cboRetenciones.Name = "cboRetenciones"
        Me.cboRetenciones.Size = New System.Drawing.Size(176, 21)
        Me.cboRetenciones.TabIndex = 6
        '
        'FechaFinalMaskedTextBox
        '
        Me.FechaFinalMaskedTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.FechaFinalMaskedTextBox.BackColor = System.Drawing.Color.DarkGray
        Me.FechaFinalMaskedTextBox.Location = New System.Drawing.Point(9, 100)
        Me.FechaFinalMaskedTextBox.Mask = "00/00/0000"
        Me.FechaFinalMaskedTextBox.Name = "FechaFinalMaskedTextBox"
        Me.FechaFinalMaskedTextBox.Size = New System.Drawing.Size(77, 20)
        Me.FechaFinalMaskedTextBox.TabIndex = 8
        Me.FechaFinalMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BackColor = System.Drawing.Color.DarkGray
        Me.DescripcionTextBox.Location = New System.Drawing.Point(88, 100)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(176, 20)
        Me.DescripcionTextBox.TabIndex = 10
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.BackColor = System.Drawing.Color.DarkGray
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(9, 139)
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(255, 20)
        Me.ObservacionesTextBox.TabIndex = 12
        '
        'CapitalTextBox
        '
        Me.CapitalTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.CapitalTextBox.Location = New System.Drawing.Point(9, 178)
        Me.CapitalTextBox.Name = "CapitalTextBox"
        Me.CapitalTextBox.Size = New System.Drawing.Size(77, 20)
        Me.CapitalTextBox.TabIndex = 14
        Me.CapitalTextBox.Text = "0.00"
        '
        'InteresesTextBox
        '
        Me.InteresesTextBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.InteresesTextBox.Location = New System.Drawing.Point(88, 178)
        Me.InteresesTextBox.Name = "InteresesTextBox"
        Me.InteresesTextBox.Size = New System.Drawing.Size(77, 20)
        Me.InteresesTextBox.TabIndex = 16
        Me.InteresesTextBox.Text = "0.00"
        '
        'ValorTextBox
        '
        Me.ValorTextBox.BackColor = System.Drawing.Color.LightGreen
        Me.ValorTextBox.Location = New System.Drawing.Point(167, 178)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(97, 20)
        Me.ValorTextBox.TabIndex = 18
        Me.ValorTextBox.Text = "0.00"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNombreDeEmpleado)
        Me.Panel1.Controls.Add(Me.btnGrabar)
        Me.Panel1.Controls.Add(Me.NumeroDeEmpleadoTextBox)
        Me.Panel1.Controls.Add(NumeroDeEmpleadoLabel)
        Me.Panel1.Controls.Add(Me.ValorTextBox)
        Me.Panel1.Controls.Add(ValorLabel)
        Me.Panel1.Controls.Add(FechaLabel)
        Me.Panel1.Controls.Add(Me.InteresesTextBox)
        Me.Panel1.Controls.Add(Me.FechaMaskedTextBox)
        Me.Panel1.Controls.Add(InteresesLabel)
        Me.Panel1.Controls.Add(RetencionLabel)
        Me.Panel1.Controls.Add(Me.CapitalTextBox)
        Me.Panel1.Controls.Add(Me.cboRetenciones)
        Me.Panel1.Controls.Add(CapitalLabel)
        Me.Panel1.Controls.Add(FechaFinalLabel)
        Me.Panel1.Controls.Add(Me.ObservacionesTextBox)
        Me.Panel1.Controls.Add(Me.FechaFinalMaskedTextBox)
        Me.Panel1.Controls.Add(ObservacionesLabel)
        Me.Panel1.Controls.Add(DescripcionLabel)
        Me.Panel1.Controls.Add(Me.DescripcionTextBox)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 242)
        Me.Panel1.TabIndex = 19
        '
        'txtNombreDeEmpleado
        '
        Me.txtNombreDeEmpleado.BackColor = System.Drawing.Color.LightGreen
        Me.txtNombreDeEmpleado.Location = New System.Drawing.Point(88, 22)
        Me.txtNombreDeEmpleado.Name = "txtNombreDeEmpleado"
        Me.txtNombreDeEmpleado.Size = New System.Drawing.Size(176, 20)
        Me.txtNombreDeEmpleado.TabIndex = 20
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.Image = Global.Cooperativa.My.Resources.Resources.plainicon_com_49341_32px_ef2
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabar.Location = New System.Drawing.Point(169, 202)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(95, 35)
        Me.btnGrabar.TabIndex = 19
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'FrmSociosCuotasTecleo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 246)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSociosCuotasTecleo"
        Me.Text = "FrmSociosCuotasTecleo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NumeroDeEmpleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboRetenciones As System.Windows.Forms.ComboBox
    Friend WithEvents FechaFinalMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapitalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InteresesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtNombreDeEmpleado As System.Windows.Forms.TextBox
End Class
