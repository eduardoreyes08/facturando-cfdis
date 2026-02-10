<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
    Me.pnlOperaciones = New System.Windows.Forms.Panel()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.lblOperacion = New System.Windows.Forms.Label()
    Me.cmbOperacion = New System.Windows.Forms.ComboBox()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcDescription = New System.Windows.Forms.TabControl()
    Me.tshDescription = New System.Windows.Forms.TabPage()
    Me.redtDescripcion = New System.Windows.Forms.RichTextBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pnlOperaciones.SuspendLayout
    Me.pgcDescription.SuspendLayout
    Me.tshDescription.SuspendLayout
    Me.stb.SuspendLayout
    Me.SuspendLayout
    '
    'pnlOperaciones
    '
    Me.pnlOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlOperaciones.Controls.Add(Me.btnTimbrado)
    Me.pnlOperaciones.Controls.Add(Me.lblOperacion)
    Me.pnlOperaciones.Controls.Add(Me.cmbOperacion)
    Me.pnlOperaciones.Controls.Add(Me.btnHelp)
    Me.pnlOperaciones.Controls.Add(Me.btnClose)
    Me.pnlOperaciones.Controls.Add(Me.btnExecute)
    Me.pnlOperaciones.Controls.Add(Me.btnAbout)
    Me.pnlOperaciones.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlOperaciones.Location = New System.Drawing.Point(0, 0)
    Me.pnlOperaciones.Name = "pnlOperaciones"
    Me.pnlOperaciones.Size = New System.Drawing.Size(609, 82)
    Me.pnlOperaciones.TabIndex = 7
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(450, 24)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(156, 23)
    Me.btnTimbrado.TabIndex = 3
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'lblOperacion
    '
    Me.lblOperacion.AutoSize = true
    Me.lblOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblOperacion.Location = New System.Drawing.Point(3, 8)
    Me.lblOperacion.Name = "lblOperacion"
    Me.lblOperacion.Size = New System.Drawing.Size(155, 13)
    Me.lblOperacion.TabIndex = 0
    Me.lblOperacion.Text = "Seleccione una operación"
    '
    'cmbOperacion
    '
    Me.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbOperacion.FormattingEnabled = true
    Me.cmbOperacion.Items.AddRange(New Object() {"Generar y timbrar un recibo de nómina", "Generar un XML de recibo de nómina"})
    Me.cmbOperacion.Location = New System.Drawing.Point(3, 24)
    Me.cmbOperacion.Name = "cmbOperacion"
    Me.cmbOperacion.Size = New System.Drawing.Size(360, 21)
    Me.cmbOperacion.TabIndex = 1
    '
    'btnHelp
    '
    Me.btnHelp.Location = New System.Drawing.Point(450, 51)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(75, 21)
    Me.btnHelp.TabIndex = 5
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(531, 51)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 21)
    Me.btnClose.TabIndex = 6
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Location = New System.Drawing.Point(369, 24)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 21)
    Me.btnExecute.TabIndex = 2
    Me.btnExecute.Text = "&Ejecutar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Location = New System.Drawing.Point(369, 51)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 21)
    Me.btnAbout.TabIndex = 4
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'pgcDescription
    '
    Me.pgcDescription.Controls.Add(Me.tshDescription)
    Me.pgcDescription.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcDescription.Location = New System.Drawing.Point(0, 82)
    Me.pgcDescription.Name = "pgcDescription"
    Me.pgcDescription.SelectedIndex = 0
    Me.pgcDescription.Size = New System.Drawing.Size(609, 300)
    Me.pgcDescription.TabIndex = 8
    '
    'tshDescription
    '
    Me.tshDescription.Controls.Add(Me.redtDescripcion)
    Me.tshDescription.Location = New System.Drawing.Point(4, 22)
    Me.tshDescription.Name = "tshDescription"
    Me.tshDescription.Padding = New System.Windows.Forms.Padding(3)
    Me.tshDescription.Size = New System.Drawing.Size(601, 274)
    Me.tshDescription.TabIndex = 0
    Me.tshDescription.Text = "Descripcion"
    Me.tshDescription.UseVisualStyleBackColor = true
    '
    'redtDescripcion
    '
    Me.redtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtDescripcion.Location = New System.Drawing.Point(3, 3)
    Me.redtDescripcion.Name = "redtDescripcion"
    Me.redtDescripcion.ReadOnly = true
    Me.redtDescripcion.Size = New System.Drawing.Size(595, 268)
    Me.redtDescripcion.TabIndex = 0
    Me.redtDescripcion.Text = ""
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 382)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(609, 22)
    Me.stb.TabIndex = 10
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(472, 17)
    Me.lblTime.Spring = true
    Me.lblTime.Text = "lblTime"
    Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblLicencia
    '
    Me.lblLicencia.IsLink = true
    Me.lblLicencia.Name = "lblLicencia"
    Me.lblLicencia.Size = New System.Drawing.Size(63, 17)
    Me.lblLicencia.Text = "lblLicencia"
    Me.lblLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblVersion
    '
    Me.lblVersion.IsLink = true
    Me.lblVersion.Name = "lblVersion"
    Me.lblVersion.Size = New System.Drawing.Size(59, 17)
    Me.lblVersion.Text = "lblVersion"
    Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(609, 404)
    Me.Controls.Add(Me.pgcDescription)
    Me.Controls.Add(Me.stb)
    Me.Controls.Add(Me.pnlOperaciones)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "RECIBO DE NOMINA 1.2  - CFDI 4.0"
    Me.pnlOperaciones.ResumeLayout(false)
    Me.pnlOperaciones.PerformLayout
    Me.pgcDescription.ResumeLayout(false)
    Me.tshDescription.ResumeLayout(false)
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents pnlOperaciones As System.Windows.Forms.Panel
  Private WithEvents btnTimbrado As System.Windows.Forms.Button
  Private WithEvents lblOperacion As System.Windows.Forms.Label
  Private WithEvents cmbOperacion As System.Windows.Forms.ComboBox
  Private WithEvents btnHelp As System.Windows.Forms.Button
  Private WithEvents btnClose As System.Windows.Forms.Button
  Private WithEvents btnExecute As System.Windows.Forms.Button
  Private WithEvents btnAbout As System.Windows.Forms.Button
  Private WithEvents pgcDescription As System.Windows.Forms.TabControl
  Private WithEvents tshDescription As System.Windows.Forms.TabPage
  Private WithEvents redtDescripcion As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
End Class
