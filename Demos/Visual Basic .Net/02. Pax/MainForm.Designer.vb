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
    Me.pnlOperaciones = New System.Windows.Forms.Panel()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.lblOperacion = New System.Windows.Forms.Label()
    Me.cmbOperacion = New System.Windows.Forms.ComboBox()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcInformacion = New System.Windows.Forms.TabControl()
    Me.tshTimbrado = New System.Windows.Forms.TabPage()
    Me.redtTimbrado = New System.Windows.Forms.RichTextBox()
    Me.tshConstanciaRetenciones = New System.Windows.Forms.TabPage()
    Me.redtConstanciaRetenciones = New System.Windows.Forms.RichTextBox()
    Me.tshCancelacion = New System.Windows.Forms.TabPage()
    Me.redtCancelacion = New System.Windows.Forms.RichTextBox()
    Me.tshFechaHora = New System.Windows.Forms.TabPage()
    Me.redFechaHora = New System.Windows.Forms.RichTextBox()
    Me.tshParameters = New System.Windows.Forms.TabPage()
    Me.txtIdentificador = New System.Windows.Forms.TextBox()
    Me.lblIdentificador = New System.Windows.Forms.Label()
    Me.chkPrueba = New System.Windows.Forms.CheckBox()
    Me.txtPassword = New System.Windows.Forms.TextBox()
    Me.lblPassword = New System.Windows.Forms.Label()
    Me.txtUsuario = New System.Windows.Forms.TextBox()
    Me.lblUsuario = New System.Windows.Forms.Label()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pnlOperaciones.SuspendLayout
    Me.pgcInformacion.SuspendLayout
    Me.tshTimbrado.SuspendLayout
    Me.tshConstanciaRetenciones.SuspendLayout
    Me.tshCancelacion.SuspendLayout
    Me.tshFechaHora.SuspendLayout
    Me.tshParameters.SuspendLayout
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
    Me.pnlOperaciones.Size = New System.Drawing.Size(619, 82)
    Me.pnlOperaciones.TabIndex = 1
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
    Me.cmbOperacion.Items.AddRange(New Object() {"Generar el timbre de un CFDI", "Constancia de retenciones y pagos", "Cancelar un CFDI", "Obtener la Fecha y Hora del PAC", "Parametros de conexión"})
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
    'pgcInformacion
    '
    Me.pgcInformacion.Controls.Add(Me.tshTimbrado)
    Me.pgcInformacion.Controls.Add(Me.tshConstanciaRetenciones)
    Me.pgcInformacion.Controls.Add(Me.tshCancelacion)
    Me.pgcInformacion.Controls.Add(Me.tshFechaHora)
    Me.pgcInformacion.Controls.Add(Me.tshParameters)
    Me.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcInformacion.Location = New System.Drawing.Point(0, 82)
    Me.pgcInformacion.Name = "pgcInformacion"
    Me.pgcInformacion.SelectedIndex = 0
    Me.pgcInformacion.Size = New System.Drawing.Size(619, 239)
    Me.pgcInformacion.TabIndex = 4
    '
    'tshTimbrado
    '
    Me.tshTimbrado.Controls.Add(Me.redtTimbrado)
    Me.tshTimbrado.Location = New System.Drawing.Point(4, 22)
    Me.tshTimbrado.Name = "tshTimbrado"
    Me.tshTimbrado.Padding = New System.Windows.Forms.Padding(3)
    Me.tshTimbrado.Size = New System.Drawing.Size(611, 213)
    Me.tshTimbrado.TabIndex = 3
    Me.tshTimbrado.Text = "Timbrado"
    Me.tshTimbrado.UseVisualStyleBackColor = true
    '
    'redtTimbrado
    '
    Me.redtTimbrado.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtTimbrado.Location = New System.Drawing.Point(3, 3)
    Me.redtTimbrado.Name = "redtTimbrado"
    Me.redtTimbrado.ReadOnly = true
    Me.redtTimbrado.Size = New System.Drawing.Size(605, 207)
    Me.redtTimbrado.TabIndex = 1
    Me.redtTimbrado.Text = resources.GetString("redtTimbrado.Text")
    '
    'tshConstanciaRetenciones
    '
    Me.tshConstanciaRetenciones.Controls.Add(Me.redtConstanciaRetenciones)
    Me.tshConstanciaRetenciones.Location = New System.Drawing.Point(4, 22)
    Me.tshConstanciaRetenciones.Name = "tshConstanciaRetenciones"
    Me.tshConstanciaRetenciones.Padding = New System.Windows.Forms.Padding(3)
    Me.tshConstanciaRetenciones.Size = New System.Drawing.Size(611, 213)
    Me.tshConstanciaRetenciones.TabIndex = 6
    Me.tshConstanciaRetenciones.Text = "Constancia de retenciones"
    Me.tshConstanciaRetenciones.UseVisualStyleBackColor = true
    '
    'redtConstanciaRetenciones
    '
    Me.redtConstanciaRetenciones.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtConstanciaRetenciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtConstanciaRetenciones.Location = New System.Drawing.Point(3, 3)
    Me.redtConstanciaRetenciones.Name = "redtConstanciaRetenciones"
    Me.redtConstanciaRetenciones.ReadOnly = true
    Me.redtConstanciaRetenciones.Size = New System.Drawing.Size(605, 207)
    Me.redtConstanciaRetenciones.TabIndex = 4
    Me.redtConstanciaRetenciones.Text = resources.GetString("redtConstanciaRetenciones.Text")
    '
    'tshCancelacion
    '
    Me.tshCancelacion.Controls.Add(Me.redtCancelacion)
    Me.tshCancelacion.Location = New System.Drawing.Point(4, 22)
    Me.tshCancelacion.Name = "tshCancelacion"
    Me.tshCancelacion.Padding = New System.Windows.Forms.Padding(3)
    Me.tshCancelacion.Size = New System.Drawing.Size(611, 213)
    Me.tshCancelacion.TabIndex = 0
    Me.tshCancelacion.Text = "Cancelación"
    Me.tshCancelacion.UseVisualStyleBackColor = true
    '
    'redtCancelacion
    '
    Me.redtCancelacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtCancelacion.Location = New System.Drawing.Point(3, 3)
    Me.redtCancelacion.Name = "redtCancelacion"
    Me.redtCancelacion.ReadOnly = true
    Me.redtCancelacion.Size = New System.Drawing.Size(605, 207)
    Me.redtCancelacion.TabIndex = 0
    Me.redtCancelacion.Text = resources.GetString("redtCancelacion.Text")
    '
    'tshFechaHora
    '
    Me.tshFechaHora.Controls.Add(Me.redFechaHora)
    Me.tshFechaHora.Location = New System.Drawing.Point(4, 22)
    Me.tshFechaHora.Name = "tshFechaHora"
    Me.tshFechaHora.Padding = New System.Windows.Forms.Padding(3)
    Me.tshFechaHora.Size = New System.Drawing.Size(611, 213)
    Me.tshFechaHora.TabIndex = 5
    Me.tshFechaHora.Text = "Fecha y Hora del PAC"
    Me.tshFechaHora.UseVisualStyleBackColor = true
    '
    'redFechaHora
    '
    Me.redFechaHora.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redFechaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redFechaHora.Location = New System.Drawing.Point(3, 3)
    Me.redFechaHora.Name = "redFechaHora"
    Me.redFechaHora.ReadOnly = true
    Me.redFechaHora.Size = New System.Drawing.Size(605, 207)
    Me.redFechaHora.TabIndex = 2
    Me.redFechaHora.Text = "En este ejemplo se demuestra "&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"    •  Cómo obtener la fecha y hora del PAC."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo"& _ 
    " lo anterior es ejecutado en el método ObtenerFechaHora()"
    '
    'tshParameters
    '
    Me.tshParameters.Controls.Add(Me.txtIdentificador)
    Me.tshParameters.Controls.Add(Me.lblIdentificador)
    Me.tshParameters.Controls.Add(Me.chkPrueba)
    Me.tshParameters.Controls.Add(Me.txtPassword)
    Me.tshParameters.Controls.Add(Me.lblPassword)
    Me.tshParameters.Controls.Add(Me.txtUsuario)
    Me.tshParameters.Controls.Add(Me.lblUsuario)
    Me.tshParameters.Location = New System.Drawing.Point(4, 22)
    Me.tshParameters.Name = "tshParameters"
    Me.tshParameters.Padding = New System.Windows.Forms.Padding(3)
    Me.tshParameters.Size = New System.Drawing.Size(611, 213)
    Me.tshParameters.TabIndex = 4
    Me.tshParameters.Text = "Parámetros de conexión"
    Me.tshParameters.UseVisualStyleBackColor = true
    '
    'txtIdentificador
    '
    Me.txtIdentificador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtIdentificador.Location = New System.Drawing.Point(88, 72)
    Me.txtIdentificador.Name = "txtIdentificador"
    Me.txtIdentificador.Size = New System.Drawing.Size(509, 20)
    Me.txtIdentificador.TabIndex = 31
    '
    'lblIdentificador
    '
    Me.lblIdentificador.AutoSize = true
    Me.lblIdentificador.Location = New System.Drawing.Point(8, 75)
    Me.lblIdentificador.Name = "lblIdentificador"
    Me.lblIdentificador.Size = New System.Drawing.Size(65, 13)
    Me.lblIdentificador.TabIndex = 30
    Me.lblIdentificador.Text = "Identificador"
    '
    'chkPrueba
    '
    Me.chkPrueba.AutoSize = true
    Me.chkPrueba.Checked = true
    Me.chkPrueba.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkPrueba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.chkPrueba.Location = New System.Drawing.Point(88, 107)
    Me.chkPrueba.Name = "chkPrueba"
    Me.chkPrueba.Size = New System.Drawing.Size(147, 17)
    Me.chkPrueba.TabIndex = 29
    Me.chkPrueba.Text = "Usar métodos de pruebas"
    Me.chkPrueba.UseVisualStyleBackColor = true
    '
    'txtPassword
    '
    Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtPassword.Location = New System.Drawing.Point(88, 46)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.Size = New System.Drawing.Size(509, 20)
    Me.txtPassword.TabIndex = 23
    Me.txtPassword.Text = "wqfCr8O3xLfEhMOHw4nEjMSrxJnvv7bvvr4cVcKuKkBEM++/ke+/gCPvv4nvvrfvvaDvvb/vvqTvvoA="
    '
    'lblPassword
    '
    Me.lblPassword.AutoSize = true
    Me.lblPassword.Location = New System.Drawing.Point(8, 49)
    Me.lblPassword.Name = "lblPassword"
    Me.lblPassword.Size = New System.Drawing.Size(53, 13)
    Me.lblPassword.TabIndex = 22
    Me.lblPassword.Text = "Password"
    '
    'txtUsuario
    '
    Me.txtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtUsuario.Location = New System.Drawing.Point(88, 20)
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(509, 20)
    Me.txtUsuario.TabIndex = 23
    Me.txtUsuario.Text = "WSDL_PAX"
    '
    'lblUsuario
    '
    Me.lblUsuario.AutoSize = true
    Me.lblUsuario.Location = New System.Drawing.Point(6, 23)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
    Me.lblUsuario.TabIndex = 22
    Me.lblUsuario.Text = "Usuario"
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 321)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(619, 22)
    Me.stb.TabIndex = 10
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(482, 17)
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
    Me.ClientSize = New System.Drawing.Size(619, 343)
    Me.Controls.Add(Me.pgcInformacion)
    Me.Controls.Add(Me.stb)
    Me.Controls.Add(Me.pnlOperaciones)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Integración con un PAC - PAX Facturación"
    Me.pnlOperaciones.ResumeLayout(false)
    Me.pnlOperaciones.PerformLayout
    Me.pgcInformacion.ResumeLayout(false)
    Me.tshTimbrado.ResumeLayout(false)
    Me.tshConstanciaRetenciones.ResumeLayout(false)
    Me.tshCancelacion.ResumeLayout(false)
    Me.tshFechaHora.ResumeLayout(false)
    Me.tshParameters.ResumeLayout(false)
    Me.tshParameters.PerformLayout
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
  Private WithEvents pgcInformacion As System.Windows.Forms.TabControl
  Private WithEvents tshTimbrado As System.Windows.Forms.TabPage
  Private WithEvents redtTimbrado As System.Windows.Forms.RichTextBox
  Private WithEvents tshCancelacion As System.Windows.Forms.TabPage
  Private WithEvents redtCancelacion As System.Windows.Forms.RichTextBox
  Private WithEvents tshFechaHora As System.Windows.Forms.TabPage
  Private WithEvents redFechaHora As System.Windows.Forms.RichTextBox
  Private WithEvents tshParameters As System.Windows.Forms.TabPage
  Private WithEvents txtIdentificador As System.Windows.Forms.TextBox
  Private WithEvents lblIdentificador As System.Windows.Forms.Label
  Private WithEvents chkPrueba As System.Windows.Forms.CheckBox
  Private WithEvents txtPassword As System.Windows.Forms.TextBox
  Private WithEvents lblPassword As System.Windows.Forms.Label
  Private WithEvents txtUsuario As System.Windows.Forms.TextBox
  Private WithEvents lblUsuario As System.Windows.Forms.Label
  Friend WithEvents tshConstanciaRetenciones As System.Windows.Forms.TabPage
  Private WithEvents redtConstanciaRetenciones As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
End Class