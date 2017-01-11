<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewer
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
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grbParametros = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechaFinal = New Library.MaskedTextBoxSD()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtFechaInicial = New Library.MaskedTextBoxSD()
        Me.lblParametros = New System.Windows.Forms.Label()
        Me.grbParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Location = New System.Drawing.Point(6, 5)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.Size = New System.Drawing.Size(983, 535)
        Me.crvReporte.TabIndex = 9
        Me.crvReporte.ViewTimeSelectionFormula = ""
        '
        'grbParametros
        '
        Me.grbParametros.BackColor = System.Drawing.Color.White
        Me.grbParametros.Controls.Add(Me.Label2)
        Me.grbParametros.Controls.Add(Me.Label1)
        Me.grbParametros.Controls.Add(Me.txtFechaFinal)
        Me.grbParametros.Controls.Add(Me.cmdBuscar)
        Me.grbParametros.Controls.Add(Me.txtFechaInicial)
        Me.grbParametros.Location = New System.Drawing.Point(6, 5)
        Me.grbParametros.Name = "grbParametros"
        Me.grbParametros.Size = New System.Drawing.Size(268, 80)
        Me.grbParametros.TabIndex = 10
        Me.grbParametros.TabStop = False
        Me.grbParametros.Text = "Parametros del reporte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "FechaFinal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Inicial"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaFinal.Location = New System.Drawing.Point(96, 40)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.NavegarConEnter = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(82, 20)
        Me.txtFechaFinal.TabIndex = 15
        Me.txtFechaFinal.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaFinal.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Recycle_Refresh_simple_48
        Me.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBuscar.Location = New System.Drawing.Point(196, 16)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(57, 57)
        Me.cmdBuscar.TabIndex = 14
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFechaInicial.Location = New System.Drawing.Point(10, 40)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.NavegarConEnter = True
        Me.txtFechaInicial.Size = New System.Drawing.Size(82, 20)
        Me.txtFechaInicial.TabIndex = 0
        Me.txtFechaInicial.TipoDeCampo = Library.MaskedTextBoxSD.TiposDeCampo.Obligatorio
        Me.txtFechaInicial.TipoDeDato = Library.MaskedTextBoxSD.TiposDeDato.isDate
        '
        'lblParametros
        '
        Me.lblParametros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblParametros.AutoSize = True
        Me.lblParametros.BackColor = System.Drawing.Color.Transparent
        Me.lblParametros.Location = New System.Drawing.Point(689, 9)
        Me.lblParametros.Name = "lblParametros"
        Me.lblParametros.Size = New System.Drawing.Size(292, 13)
        Me.lblParametros.TabIndex = 11
        Me.lblParametros.Text = "Presione F8 para mostrar u ocultar los parametros del reporte"
        '
        'FrmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 544)
        Me.Controls.Add(Me.lblParametros)
        Me.Controls.Add(Me.grbParametros)
        Me.Controls.Add(Me.crvReporte)
        Me.KeyPreview = True
        Me.Name = "FrmViewer"
        Me.Text = "FrmViewer"
        Me.grbParametros.ResumeLayout(False)
        Me.grbParametros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grbParametros As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaInicial As Library.MaskedTextBoxSD
    Friend WithEvents lblParametros As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFechaFinal As Library.MaskedTextBoxSD
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
End Class
