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
    Me.mmoInformation = New System.Windows.Forms.RichTextBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tbcOpciones = New System.Windows.Forms.TabControl()
    Me.tshCfdi = New System.Windows.Forms.TabPage()
    Me.lblCfdi = New System.Windows.Forms.Label()
    Me.cbbCfdi = New System.Windows.Forms.ComboBox()
    Me.tshContabilidad = New System.Windows.Forms.TabPage()
    Me.cbbContabilidadTipo = New System.Windows.Forms.ComboBox()
    Me.lblContabilidadTipo = New System.Windows.Forms.Label()
    Me.cbbContabilidad = New System.Windows.Forms.ComboBox()
    Me.lblContabilidad = New System.Windows.Forms.Label()
    Me.tshRetenciones = New System.Windows.Forms.TabPage()
    Me.cbbConstanciaRetenciones = New System.Windows.Forms.ComboBox()
    Me.lblConstanciaRetenciones = New System.Windows.Forms.Label()
    Me.btnValidar = New System.Windows.Forms.Button()
    Me.btnSeleccionar = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.stb.SuspendLayout
    Me.tbcOpciones.SuspendLayout
    Me.tshCfdi.SuspendLayout
    Me.tshContabilidad.SuspendLayout
    Me.tshRetenciones.SuspendLayout
    Me.SuspendLayout
    '
    'mmoInformation
    '
    Me.mmoInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.mmoInformation.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.mmoInformation.Location = New System.Drawing.Point(12, 168)
    Me.mmoInformation.Name = "mmoInformation"
    Me.mmoInformation.Size = New System.Drawing.Size(964, 461)
    Me.mmoInformation.TabIndex = 6
    Me.mmoInformation.Text = ""
    Me.mmoInformation.WordWrap = false
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 644)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(984, 22)
    Me.stb.TabIndex = 7
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(847, 17)
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
    'tbcOpciones
    '
    Me.tbcOpciones.Controls.Add(Me.tshCfdi)
    Me.tbcOpciones.Controls.Add(Me.tshContabilidad)
    Me.tbcOpciones.Controls.Add(Me.tshRetenciones)
    Me.tbcOpciones.Location = New System.Drawing.Point(12, 12)
    Me.tbcOpciones.Name = "tbcOpciones"
    Me.tbcOpciones.SelectedIndex = 0
    Me.tbcOpciones.Size = New System.Drawing.Size(816, 150)
    Me.tbcOpciones.TabIndex = 0
    '
    'tshCfdi
    '
    Me.tshCfdi.Controls.Add(Me.lblCfdi)
    Me.tshCfdi.Controls.Add(Me.cbbCfdi)
    Me.tshCfdi.Location = New System.Drawing.Point(4, 22)
    Me.tshCfdi.Name = "tshCfdi"
    Me.tshCfdi.Padding = New System.Windows.Forms.Padding(3)
    Me.tshCfdi.Size = New System.Drawing.Size(808, 124)
    Me.tshCfdi.TabIndex = 0
    Me.tshCfdi.Text = "Comprobantes (CFD / CFDI)"
    Me.tshCfdi.UseVisualStyleBackColor = true
    '
    'lblCfdi
    '
    Me.lblCfdi.AutoSize = true
    Me.lblCfdi.Location = New System.Drawing.Point(6, 10)
    Me.lblCfdi.Name = "lblCfdi"
    Me.lblCfdi.Size = New System.Drawing.Size(179, 13)
    Me.lblCfdi.TabIndex = 11
    Me.lblCfdi.Text = "Selecciona el comprobante a validar"
    '
    'cbbCfdi
    '
    Me.cbbCfdi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.cbbCfdi.DropDownWidth = 1050
    Me.cbbCfdi.FormattingEnabled = true
    Me.cbbCfdi.Location = New System.Drawing.Point(9, 26)
    Me.cbbCfdi.Name = "cbbCfdi"
    Me.cbbCfdi.Size = New System.Drawing.Size(793, 21)
    Me.cbbCfdi.TabIndex = 10
    '
    'tshContabilidad
    '
    Me.tshContabilidad.Controls.Add(Me.cbbContabilidadTipo)
    Me.tshContabilidad.Controls.Add(Me.lblContabilidadTipo)
    Me.tshContabilidad.Controls.Add(Me.cbbContabilidad)
    Me.tshContabilidad.Controls.Add(Me.lblContabilidad)
    Me.tshContabilidad.Location = New System.Drawing.Point(4, 22)
    Me.tshContabilidad.Name = "tshContabilidad"
    Me.tshContabilidad.Padding = New System.Windows.Forms.Padding(3)
    Me.tshContabilidad.Size = New System.Drawing.Size(808, 124)
    Me.tshContabilidad.TabIndex = 1
    Me.tshContabilidad.Text = "Contabilidad electrónica"
    Me.tshContabilidad.UseVisualStyleBackColor = true
    '
    'cbbContabilidadTipo
    '
    Me.cbbContabilidadTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbbContabilidadTipo.FormattingEnabled = true
    Me.cbbContabilidadTipo.Items.AddRange(New Object() {"Cuentas contables", "Balanza de comprobación", "Pólizas", "Auxiliar de cuentas", "Auxiliar de folios"})
    Me.cbbContabilidadTipo.Location = New System.Drawing.Point(9, 70)
    Me.cbbContabilidadTipo.Name = "cbbContabilidadTipo"
    Me.cbbContabilidadTipo.Size = New System.Drawing.Size(264, 21)
    Me.cbbContabilidadTipo.TabIndex = 16
    '
    'lblContabilidadTipo
    '
    Me.lblContabilidadTipo.AutoSize = true
    Me.lblContabilidadTipo.Location = New System.Drawing.Point(6, 54)
    Me.lblContabilidadTipo.Name = "lblContabilidadTipo"
    Me.lblContabilidadTipo.Size = New System.Drawing.Size(81, 13)
    Me.lblContabilidadTipo.TabIndex = 15
    Me.lblContabilidadTipo.Text = "Tipo de archivo"
    '
    'cbbContabilidad
    '
    Me.cbbContabilidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.cbbContabilidad.DropDownWidth = 1050
    Me.cbbContabilidad.FormattingEnabled = true
    Me.cbbContabilidad.Location = New System.Drawing.Point(9, 26)
    Me.cbbContabilidad.Name = "cbbContabilidad"
    Me.cbbContabilidad.Size = New System.Drawing.Size(793, 21)
    Me.cbbContabilidad.TabIndex = 13
    '
    'lblContabilidad
    '
    Me.lblContabilidad.AutoSize = true
    Me.lblContabilidad.Location = New System.Drawing.Point(6, 10)
    Me.lblContabilidad.Name = "lblContabilidad"
    Me.lblContabilidad.Size = New System.Drawing.Size(179, 13)
    Me.lblContabilidad.TabIndex = 12
    Me.lblContabilidad.Text = "Selecciona el comprobante a validar"
    '
    'tshRetenciones
    '
    Me.tshRetenciones.Controls.Add(Me.cbbConstanciaRetenciones)
    Me.tshRetenciones.Controls.Add(Me.lblConstanciaRetenciones)
    Me.tshRetenciones.Location = New System.Drawing.Point(4, 22)
    Me.tshRetenciones.Name = "tshRetenciones"
    Me.tshRetenciones.Padding = New System.Windows.Forms.Padding(3)
    Me.tshRetenciones.Size = New System.Drawing.Size(808, 124)
    Me.tshRetenciones.TabIndex = 2
    Me.tshRetenciones.Text = "Constancia de retenciones"
    Me.tshRetenciones.UseVisualStyleBackColor = true
    '
    'cbbConstanciaRetenciones
    '
    Me.cbbConstanciaRetenciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.cbbConstanciaRetenciones.DropDownWidth = 1050
    Me.cbbConstanciaRetenciones.FormattingEnabled = true
    Me.cbbConstanciaRetenciones.Location = New System.Drawing.Point(9, 26)
    Me.cbbConstanciaRetenciones.Name = "cbbConstanciaRetenciones"
    Me.cbbConstanciaRetenciones.Size = New System.Drawing.Size(793, 21)
    Me.cbbConstanciaRetenciones.TabIndex = 13
    '
    'lblConstanciaRetenciones
    '
    Me.lblConstanciaRetenciones.AutoSize = true
    Me.lblConstanciaRetenciones.Location = New System.Drawing.Point(6, 10)
    Me.lblConstanciaRetenciones.Name = "lblConstanciaRetenciones"
    Me.lblConstanciaRetenciones.Size = New System.Drawing.Size(179, 13)
    Me.lblConstanciaRetenciones.TabIndex = 12
    Me.lblConstanciaRetenciones.Text = "Selecciona el comprobante a validar"
    '
    'btnValidar
    '
    Me.btnValidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnValidar.Image = Global.HyperSoft.Ejemplo.Validacion.My.Resources.Resources.validate
    Me.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnValidar.Location = New System.Drawing.Point(838, 12)
    Me.btnValidar.Name = "btnValidar"
    Me.btnValidar.Size = New System.Drawing.Size(138, 30)
    Me.btnValidar.TabIndex = 1
    Me.btnValidar.Text = " &Validar archivo"
    Me.btnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnValidar.UseVisualStyleBackColor = true
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.btnSeleccionar.Image = Global.HyperSoft.Ejemplo.Validacion.My.Resources.Resources.openFile
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(838, 48)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(138, 30)
    Me.btnSeleccionar.TabIndex = 2
    Me.btnSeleccionar.Text = " &Seleccionar archivo"
    Me.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
    Me.btnSeleccionar.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnAbout.Location = New System.Drawing.Point(838, 82)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(138, 23)
    Me.btnAbout.TabIndex = 3
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(838, 111)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(138, 23)
    Me.btnClose.TabIndex = 4
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnHelp
    '
    Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnHelp.Location = New System.Drawing.Point(834, 140)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(142, 23)
    Me.btnHelp.TabIndex = 5
    Me.btnHelp.Text = "A&yuda"
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(984, 666)
    Me.Controls.Add(Me.btnValidar)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.btnAbout)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.btnHelp)
    Me.Controls.Add(Me.tbcOpciones)
    Me.Controls.Add(Me.mmoInformation)
    Me.Controls.Add(Me.stb)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ejemplo de validación y recepción"
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.tbcOpciones.ResumeLayout(false)
    Me.tshCfdi.ResumeLayout(false)
    Me.tshCfdi.PerformLayout
    Me.tshContabilidad.ResumeLayout(false)
    Me.tshContabilidad.PerformLayout
    Me.tshRetenciones.ResumeLayout(false)
    Me.tshRetenciones.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents mmoInformation As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents tbcOpciones As TabControl
  Private WithEvents tshCfdi As TabPage
  Private WithEvents lblCfdi As Label
  Private WithEvents cbbCfdi As ComboBox
  Private WithEvents tshContabilidad As TabPage
  Private WithEvents cbbContabilidadTipo As ComboBox
  Private WithEvents lblContabilidadTipo As Label
  Private WithEvents cbbContabilidad As ComboBox
  Private WithEvents lblContabilidad As Label
  Private WithEvents tshRetenciones As TabPage
  Private WithEvents cbbConstanciaRetenciones As ComboBox
  Private WithEvents lblConstanciaRetenciones As Label
  Private WithEvents btnValidar As Button
  Private WithEvents btnSeleccionar As Button
  Private WithEvents btnAbout As Button
  Private WithEvents btnClose As Button
  Private WithEvents btnHelp As Button
End Class
