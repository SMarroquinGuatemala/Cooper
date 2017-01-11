<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioFechaOperacion
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
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdGrabarEncabezado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(4, 5)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(200, 45)
        Me.txtFecha.TabIndex = 0
        '
        'cmdGrabarEncabezado
        '
        Me.cmdGrabarEncabezado.BackgroundImage = Global.Cooperativa.My.Resources.Resources.Save_48
        Me.cmdGrabarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGrabarEncabezado.Location = New System.Drawing.Point(206, 5)
        Me.cmdGrabarEncabezado.Name = "cmdGrabarEncabezado"
        Me.cmdGrabarEncabezado.Size = New System.Drawing.Size(51, 45)
        Me.cmdGrabarEncabezado.TabIndex = 3
        Me.cmdGrabarEncabezado.UseVisualStyleBackColor = True
        '
        'FrmCambioFechaOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(263, 54)
        Me.Controls.Add(Me.cmdGrabarEncabezado)
        Me.Controls.Add(Me.txtFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioFechaOperacion"
        Me.ShowInTaskbar = False
        Me.Text = "Cambio Fecha Operación"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdGrabarEncabezado As System.Windows.Forms.Button
End Class
