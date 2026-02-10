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
    Me.cmbTipo = New System.Windows.Forms.ComboBox()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcDocumento = New System.Windows.Forms.TabControl()
    Me.tshConstancia = New System.Windows.Forms.TabPage()
    Me.redtSample1 = New System.Windows.Forms.RichTextBox()
    Me.tshComplemento = New System.Windows.Forms.TabPage()
    Me.redtComplemento = New System.Windows.Forms.RichTextBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pblDatos.SuspendLayout
    Me.pgcDocumento.SuspendLayout
    Me.tshConstancia.SuspendLayout
    Me.tshComplemento.SuspendLayout
    Me.stb.SuspendLayout
    Me.SuspendLayout
    '
    'pblDatos
    '
    Me.pblDatos.Controls.Add(Me.btnTimbrado)
    Me.pblDatos.Controls.Add(Me.cmbTipo)
    Me.pblDatos.Controls.Add(Me.lblTipo)
    Me.pblDatos.Controls.Add(Me.btnHelp)
    Me.pblDatos.Controls.Add(Me.btnClose)
    Me.pblDatos.Controls.Add(Me.btnExecute)
    Me.pblDatos.Controls.Add(Me.btnAbout)
    Me.pblDatos.Dock = System.Windows.Forms.DockStyle.Top
    Me.pblDatos.Location = New System.Drawing.Point(0, 0)
    Me.pblDatos.Name = "pblDatos"
    Me.pblDatos.Size = New System.Drawing.Size(690, 71)
    Me.pblDatos.TabIndex = 13
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(522, 7)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(156, 23)
    Me.btnTimbrado.TabIndex = 3
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'cmbTipo
    '
    Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTipo.FormattingEnabled = true
    Me.cmbTipo.Items.AddRange(New Object() {"Constancia de retenciones", "  - Arrendamiento en fideicomiso", "  - Dividendos", "  - Enajenacion de acciones", "  - Fideicomiso no empresarial", "  - Intereses", "  - Intereses hipotecarios", "  - Operaciones con derivados", "  - Pagos a extranjeros", "  - Planes de retiro", "  - Plataformas técnologicas", "  - Premios", "  - Sector Financiero"})
    Me.cmbTipo.Location = New System.Drawing.Point(101, 9)
    Me.cmbTipo.Name = "cmbTipo"
    Me.cmbTipo.Size = New System.Drawing.Size(334, 21)
    Me.cmbTipo.TabIndex = 1
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = true
    Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTipo.Location = New System.Drawing.Point(12, 9)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(32, 13)
    Me.lblTipo.TabIndex = 0
    Me.lblTipo.Text = "Tipo"
    '
    'btnHelp
    '
    Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnHelp.Location = New System.Drawing.Point(522, 36)
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
    Me.btnClose.Location = New System.Drawing.Point(603, 36)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 23)
    Me.btnClose.TabIndex = 6
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnExecute.Location = New System.Drawing.Point(441, 7)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 23)
    Me.btnExecute.TabIndex = 2
    Me.btnExecute.Text = "&Generar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnAbout.Location = New System.Drawing.Point(441, 36)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 23)
    Me.btnAbout.TabIndex = 4
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'pgcDocumento
    '
    Me.pgcDocumento.Controls.Add(Me.tshConstancia)
    Me.pgcDocumento.Controls.Add(Me.tshComplemento)
    Me.pgcDocumento.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcDocumento.Location = New System.Drawing.Point(0, 71)
    Me.pgcDocumento.Name = "pgcDocumento"
    Me.pgcDocumento.SelectedIndex = 0
    Me.pgcDocumento.Size = New System.Drawing.Size(690, 357)
    Me.pgcDocumento.TabIndex = 14
    '
    'tshConstancia
    '
    Me.tshConstancia.Controls.Add(Me.redtSample1)
    Me.tshConstancia.Location = New System.Drawing.Point(4, 22)
    Me.tshConstancia.Name = "tshConstancia"
    Me.tshConstancia.Padding = New System.Windows.Forms.Padding(3)
    Me.tshConstancia.Size = New System.Drawing.Size(682, 331)
    Me.tshConstancia.TabIndex = 13
    Me.tshConstancia.Text = "Constancia"
    Me.tshConstancia.UseVisualStyleBackColor = true
    '
    'redtSample1
    '
    Me.redtSample1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtSample1.Location = New System.Drawing.Point(3, 3)
    Me.redtSample1.Name = "redtSample1"
    Me.redtSample1.ReadOnly = true
    Me.redtSample1.Size = New System.Drawing.Size(676, 325)
    Me.redtSample1.TabIndex = 3
    Me.redtSample1.Text = resources.GetString("redtSample1.Text")
    '
    'tshComplemento
    '
    Me.tshComplemento.Controls.Add(Me.redtComplemento)
    Me.tshComplemento.Location = New System.Drawing.Point(4, 22)
    Me.tshComplemento.Name = "tshComplemento"
    Me.tshComplemento.Padding = New System.Windows.Forms.Padding(3)
    Me.tshComplemento.Size = New System.Drawing.Size(682, 331)
    Me.tshComplemento.TabIndex = 14
    Me.tshComplemento.Text = "Complemento"
    Me.tshComplemento.UseVisualStyleBackColor = true
    '
    'redtComplemento
    '
    Me.redtComplemento.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtComplemento.Location = New System.Drawing.Point(3, 3)
    Me.redtComplemento.Name = "redtComplemento"
    Me.redtComplemento.ReadOnly = true
    Me.redtComplemento.Size = New System.Drawing.Size(676, 325)
    Me.redtComplemento.TabIndex = 3
    Me.redtComplemento.Text = resources.GetString("redtComplemento.Text")
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 428)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(690, 22)
    Me.stb.TabIndex = 15
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(553, 17)
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
    Me.ClientSize = New System.Drawing.Size(690, 450)
    Me.Controls.Add(Me.pgcDocumento)
    Me.Controls.Add(Me.stb)
    Me.Controls.Add(Me.pblDatos)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.Name = "MainForm"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ejemplo de la generación de una constancia de retenciones y pagos 2.0"
    Me.pblDatos.ResumeLayout(false)
    Me.pblDatos.PerformLayout
    Me.pgcDocumento.ResumeLayout(false)
    Me.tshConstancia.ResumeLayout(false)
    Me.tshComplemento.ResumeLayout(false)
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents pblDatos As System.Windows.Forms.Panel
  Private WithEvents btnTimbrado As System.Windows.Forms.Button
  Private WithEvents cmbTipo As System.Windows.Forms.ComboBox
  Private WithEvents lblTipo As System.Windows.Forms.Label
  Private WithEvents btnHelp As System.Windows.Forms.Button
  Private WithEvents btnClose As System.Windows.Forms.Button
  Private WithEvents btnExecute As System.Windows.Forms.Button
  Private WithEvents btnAbout As System.Windows.Forms.Button
  Private WithEvents pgcDocumento As System.Windows.Forms.TabControl
  Private WithEvents tshConstancia As System.Windows.Forms.TabPage
  Private WithEvents redtSample1 As System.Windows.Forms.RichTextBox
  Private WithEvents tshComplemento As System.Windows.Forms.TabPage
  Private WithEvents redtComplemento As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
End Class
