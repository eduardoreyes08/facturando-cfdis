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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.pblDatos = New System.Windows.Forms.Panel()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.cmbComplemento = New System.Windows.Forms.ComboBox()
    Me.lblComplemento = New System.Windows.Forms.Label()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.redtText = New System.Windows.Forms.RichTextBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pblDatos.SuspendLayout
    Me.stb.SuspendLayout
    Me.SuspendLayout
    '
    'pblDatos
    '
    Me.pblDatos.Controls.Add(Me.btnTimbrado)
    Me.pblDatos.Controls.Add(Me.cmbComplemento)
    Me.pblDatos.Controls.Add(Me.lblComplemento)
    Me.pblDatos.Controls.Add(Me.btnHelp)
    Me.pblDatos.Controls.Add(Me.btnClose)
    Me.pblDatos.Controls.Add(Me.btnExecute)
    Me.pblDatos.Controls.Add(Me.btnAbout)
    Me.pblDatos.Dock = System.Windows.Forms.DockStyle.Top
    Me.pblDatos.Location = New System.Drawing.Point(0, 0)
    Me.pblDatos.Name = "pblDatos"
    Me.pblDatos.Size = New System.Drawing.Size(700, 71)
    Me.pblDatos.TabIndex = 13
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(532, 7)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(156, 23)
    Me.btnTimbrado.TabIndex = 3
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'cmbComplemento
    '
    Me.cmbComplemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbComplemento.FormattingEnabled = true
    Me.cmbComplemento.Items.AddRange(New Object() {"DOCUMENTO", "  - Aerolíneas 1.0", "  - Certificado de destrucción 1.0", "  - CFDI registro fiscal 1.0", "  - Comercio exterior 2.0", "  - Consumo de combustible 1.1", "  - Detallista 1.3.1", "  - Divisas 1.0", "  - Donatarias 1.1", "  - Estado de cuenta de combustible 1.2", "  - Hidrocarburos - Gastos  1.0", "  - Hidrocarburos - Ingresos  1.0", "  - Impuestos locales 1.0", "  - INE 1.1", "  - Leyenda fiscal 1.0", "  - Notarios públicos 1.0", "  - Obras, artes y antiguedades 1.0", "  - Pago en especie 1.0", "  - Persona física integrante coordinado 1.0", "  - Renovación y sustitución vehicular 1.0", "  - Servicios parciales de construcción 1.0", "  - Turista pasajero extranjero 1.0", "  - Vales de despensa 1.0", "  - Vehículo usado 1.0", "CONCEPTO", "  - Instituciones educativas privadas 1.0", "  - Venta vehicular 1.1"})
    Me.cmbComplemento.Location = New System.Drawing.Point(106, 9)
    Me.cmbComplemento.Name = "cmbComplemento"
    Me.cmbComplemento.Size = New System.Drawing.Size(334, 21)
    Me.cmbComplemento.TabIndex = 1
    '
    'lblComplemento
    '
    Me.lblComplemento.AutoSize = true
    Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblComplemento.Location = New System.Drawing.Point(12, 9)
    Me.lblComplemento.Name = "lblComplemento"
    Me.lblComplemento.Size = New System.Drawing.Size(88, 13)
    Me.lblComplemento.TabIndex = 0
    Me.lblComplemento.Text = "Complementos"
    '
    'btnHelp
    '
    Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnHelp.Location = New System.Drawing.Point(532, 36)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(75, 23)
    Me.btnHelp.TabIndex = 5
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(613, 36)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 23)
    Me.btnClose.TabIndex = 6
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnExecute.Location = New System.Drawing.Point(451, 7)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 23)
    Me.btnExecute.TabIndex = 2
    Me.btnExecute.Text = "&Generar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnAbout.Location = New System.Drawing.Point(451, 36)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 23)
    Me.btnAbout.TabIndex = 4
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'redtText
    '
    Me.redtText.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtText.Location = New System.Drawing.Point(0, 71)
    Me.redtText.Name = "redtText"
    Me.redtText.ReadOnly = true
    Me.redtText.Size = New System.Drawing.Size(700, 367)
    Me.redtText.TabIndex = 14
    Me.redtText.Text = resources.GetString("redtText.Text")
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 438)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(700, 22)
    Me.stb.TabIndex = 15
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(563, 17)
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
    Me.ClientSize = New System.Drawing.Size(700, 460)
    Me.Controls.Add(Me.redtText)
    Me.Controls.Add(Me.stb)
    Me.Controls.Add(Me.pblDatos)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ejemplo de la generación de un CFDI con complemento"
    Me.pblDatos.ResumeLayout(false)
    Me.pblDatos.PerformLayout
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents pblDatos As System.Windows.Forms.Panel
  Private WithEvents btnTimbrado As System.Windows.Forms.Button
  Private WithEvents cmbComplemento As System.Windows.Forms.ComboBox
  Private WithEvents lblComplemento As System.Windows.Forms.Label
  Private WithEvents btnHelp As System.Windows.Forms.Button
  Private WithEvents btnClose As System.Windows.Forms.Button
  Private WithEvents btnExecute As System.Windows.Forms.Button
  Private WithEvents btnAbout As System.Windows.Forms.Button
  Private WithEvents redtText As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
End Class
