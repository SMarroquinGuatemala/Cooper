﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportingServicesDisplay
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
      Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel1
      '
      Me.Panel1.Controls.Add(Me.ReportViewer1)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.Panel1.Location = New System.Drawing.Point(0, 0)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(1008, 710)
      Me.Panel1.TabIndex = 0
      '
      'ReportViewer1
      '
      Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.ReportViewer1.DocumentMapCollapsed = True
      Me.ReportViewer1.DocumentMapWidth = 250
      ReportDataSource1.Name = "DSMovimientosRetenciones"
      ReportDataSource1.Value = Nothing
      Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
      Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
      Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
      Me.ReportViewer1.Name = "ReportViewer1"
      Me.ReportViewer1.Size = New System.Drawing.Size(1008, 710)
      Me.ReportViewer1.TabIndex = 0
      '
      'FrmReportingServicesDisplay
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1008, 710)
      Me.Controls.Add(Me.Panel1)
      Me.KeyPreview = True
      Me.Name = "FrmReportingServicesDisplay"
      Me.Text = "FrmReportingServicesDisplay"
      Me.Panel1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
