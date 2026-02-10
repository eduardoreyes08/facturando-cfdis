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
    Me.chkGenerarZip = New System.Windows.Forms.CheckBox()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.lblOperacion = New System.Windows.Forms.Label()
    Me.cmbOperacion = New System.Windows.Forms.ComboBox()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcInformacion = New System.Windows.Forms.TabControl()
    Me.tshCatalogo = New System.Windows.Forms.TabPage()
    Me.redtCatalogo = New System.Windows.Forms.RichTextBox()
    Me.tshBalanza = New System.Windows.Forms.TabPage()
    Me.redtBalanza = New System.Windows.Forms.RichTextBox()
    Me.tshPoliza = New System.Windows.Forms.TabPage()
    Me.redtPoliza = New System.Windows.Forms.RichTextBox()
    Me.tshAuxiliarFolios = New System.Windows.Forms.TabPage()
    Me.redtAuxiliarFolios = New System.Windows.Forms.RichTextBox()
    Me.tshAuxiliarCuentas = New System.Windows.Forms.TabPage()
    Me.redtAuxiliarCuentas = New System.Windows.Forms.RichTextBox()
    Me.tshSelloDigital = New System.Windows.Forms.TabPage()
    Me.redtSelloDigital = New System.Windows.Forms.RichTextBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pnlOperaciones.SuspendLayout
    Me.pgcInformacion.SuspendLayout
    Me.tshCatalogo.SuspendLayout
    Me.tshBalanza.SuspendLayout
    Me.tshPoliza.SuspendLayout
    Me.tshAuxiliarFolios.SuspendLayout
    Me.tshAuxiliarCuentas.SuspendLayout
    Me.tshSelloDigital.SuspendLayout
    Me.stb.SuspendLayout
    Me.SuspendLayout
    '
    'pnlOperaciones
    '
    Me.pnlOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlOperaciones.Controls.Add(Me.chkGenerarZip)
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
    Me.pnlOperaciones.Size = New System.Drawing.Size(694, 76)
    Me.pnlOperaciones.TabIndex = 4
    '
    'chkGenerarZip
    '
    Me.chkGenerarZip.AutoSize = true
    Me.chkGenerarZip.Checked = true
    Me.chkGenerarZip.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkGenerarZip.Location = New System.Drawing.Point(160, 43)
    Me.chkGenerarZip.Name = "chkGenerarZip"
    Me.chkGenerarZip.Size = New System.Drawing.Size(122, 17)
    Me.chkGenerarZip.TabIndex = 10
    Me.chkGenerarZip.Text = "Generar archivo ZIP"
    Me.chkGenerarZip.UseVisualStyleBackColor = true
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(529, 12)
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
    Me.lblOperacion.Location = New System.Drawing.Point(3, 12)
    Me.lblOperacion.Name = "lblOperacion"
    Me.lblOperacion.Size = New System.Drawing.Size(155, 13)
    Me.lblOperacion.TabIndex = 4
    Me.lblOperacion.Text = "Seleccione una operación"
    '
    'cmbOperacion
    '
    Me.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbOperacion.FormattingEnabled = true
    Me.cmbOperacion.Items.AddRange(New Object() {"Catálogo de cuentas contables", "Balanza de comprobación", "Pólizas del periodo", "Reporte auxiliar de folios", "Reporte auxiliar de cuentas y/o subcuentas"})
    Me.cmbOperacion.Location = New System.Drawing.Point(160, 12)
    Me.cmbOperacion.Name = "cmbOperacion"
    Me.cmbOperacion.Size = New System.Drawing.Size(282, 21)
    Me.cmbOperacion.TabIndex = 5
    '
    'btnHelp
    '
    Me.btnHelp.Location = New System.Drawing.Point(529, 39)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(75, 21)
    Me.btnHelp.TabIndex = 7
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(610, 39)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 21)
    Me.btnClose.TabIndex = 8
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Location = New System.Drawing.Point(448, 12)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 21)
    Me.btnExecute.TabIndex = 2
    Me.btnExecute.Text = "&Ejecutar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Location = New System.Drawing.Point(448, 39)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 21)
    Me.btnAbout.TabIndex = 6
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'pgcInformacion
    '
    Me.pgcInformacion.Controls.Add(Me.tshCatalogo)
    Me.pgcInformacion.Controls.Add(Me.tshBalanza)
    Me.pgcInformacion.Controls.Add(Me.tshPoliza)
    Me.pgcInformacion.Controls.Add(Me.tshAuxiliarFolios)
    Me.pgcInformacion.Controls.Add(Me.tshAuxiliarCuentas)
    Me.pgcInformacion.Controls.Add(Me.tshSelloDigital)
    Me.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcInformacion.Location = New System.Drawing.Point(0, 76)
    Me.pgcInformacion.Name = "pgcInformacion"
    Me.pgcInformacion.SelectedIndex = 0
    Me.pgcInformacion.Size = New System.Drawing.Size(694, 378)
    Me.pgcInformacion.TabIndex = 5
    '
    'tshCatalogo
    '
    Me.tshCatalogo.Controls.Add(Me.redtCatalogo)
    Me.tshCatalogo.Location = New System.Drawing.Point(4, 22)
    Me.tshCatalogo.Name = "tshCatalogo"
    Me.tshCatalogo.Padding = New System.Windows.Forms.Padding(3)
    Me.tshCatalogo.Size = New System.Drawing.Size(686, 352)
    Me.tshCatalogo.TabIndex = 3
    Me.tshCatalogo.Text = "Catálogo"
    Me.tshCatalogo.UseVisualStyleBackColor = true
    '
    'redtCatalogo
    '
    Me.redtCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtCatalogo.Location = New System.Drawing.Point(3, 3)
    Me.redtCatalogo.Name = "redtCatalogo"
    Me.redtCatalogo.ReadOnly = true
    Me.redtCatalogo.Size = New System.Drawing.Size(680, 346)
    Me.redtCatalogo.TabIndex = 1
    Me.redtCatalogo.Text = "En este ejemplo se demuestra la generación del archivo XML de las cuentas contabl"& _ 
    "es."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo lo anterior es ejecutado en el método CreateCatalogo()"
    '
    'tshBalanza
    '
    Me.tshBalanza.Controls.Add(Me.redtBalanza)
    Me.tshBalanza.Location = New System.Drawing.Point(4, 22)
    Me.tshBalanza.Name = "tshBalanza"
    Me.tshBalanza.Padding = New System.Windows.Forms.Padding(3)
    Me.tshBalanza.Size = New System.Drawing.Size(686, 352)
    Me.tshBalanza.TabIndex = 0
    Me.tshBalanza.Text = "Balanza"
    Me.tshBalanza.UseVisualStyleBackColor = true
    '
    'redtBalanza
    '
    Me.redtBalanza.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtBalanza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtBalanza.Location = New System.Drawing.Point(3, 3)
    Me.redtBalanza.Name = "redtBalanza"
    Me.redtBalanza.ReadOnly = true
    Me.redtBalanza.Size = New System.Drawing.Size(680, 346)
    Me.redtBalanza.TabIndex = 0
    Me.redtBalanza.Text = "En este ejemplo se demuestra la generación del archivo XML de la balanza de compr"& _ 
    "obación."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo lo anterior es ejecutado en el método CreateBalanza()"
    '
    'tshPoliza
    '
    Me.tshPoliza.Controls.Add(Me.redtPoliza)
    Me.tshPoliza.Location = New System.Drawing.Point(4, 22)
    Me.tshPoliza.Name = "tshPoliza"
    Me.tshPoliza.Padding = New System.Windows.Forms.Padding(3)
    Me.tshPoliza.Size = New System.Drawing.Size(686, 352)
    Me.tshPoliza.TabIndex = 8
    Me.tshPoliza.Text = "Póliza"
    Me.tshPoliza.UseVisualStyleBackColor = true
    '
    'redtPoliza
    '
    Me.redtPoliza.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtPoliza.Location = New System.Drawing.Point(3, 3)
    Me.redtPoliza.Name = "redtPoliza"
    Me.redtPoliza.ReadOnly = true
    Me.redtPoliza.Size = New System.Drawing.Size(680, 346)
    Me.redtPoliza.TabIndex = 2
    Me.redtPoliza.Text = resources.GetString("redtPoliza.Text")
    '
    'tshAuxiliarFolios
    '
    Me.tshAuxiliarFolios.Controls.Add(Me.redtAuxiliarFolios)
    Me.tshAuxiliarFolios.Location = New System.Drawing.Point(4, 22)
    Me.tshAuxiliarFolios.Name = "tshAuxiliarFolios"
    Me.tshAuxiliarFolios.Padding = New System.Windows.Forms.Padding(3)
    Me.tshAuxiliarFolios.Size = New System.Drawing.Size(686, 352)
    Me.tshAuxiliarFolios.TabIndex = 9
    Me.tshAuxiliarFolios.Text = "Auxiliar de folios"
    Me.tshAuxiliarFolios.UseVisualStyleBackColor = true
    '
    'redtAuxiliarFolios
    '
    Me.redtAuxiliarFolios.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtAuxiliarFolios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtAuxiliarFolios.Location = New System.Drawing.Point(3, 3)
    Me.redtAuxiliarFolios.Name = "redtAuxiliarFolios"
    Me.redtAuxiliarFolios.ReadOnly = true
    Me.redtAuxiliarFolios.Size = New System.Drawing.Size(680, 346)
    Me.redtAuxiliarFolios.TabIndex = 2
    Me.redtAuxiliarFolios.Text = resources.GetString("redtAuxiliarFolios.Text")
    '
    'tshAuxiliarCuentas
    '
    Me.tshAuxiliarCuentas.Controls.Add(Me.redtAuxiliarCuentas)
    Me.tshAuxiliarCuentas.Location = New System.Drawing.Point(4, 22)
    Me.tshAuxiliarCuentas.Name = "tshAuxiliarCuentas"
    Me.tshAuxiliarCuentas.Padding = New System.Windows.Forms.Padding(3)
    Me.tshAuxiliarCuentas.Size = New System.Drawing.Size(686, 352)
    Me.tshAuxiliarCuentas.TabIndex = 10
    Me.tshAuxiliarCuentas.Text = "Auxiliar de cuentas"
    Me.tshAuxiliarCuentas.UseVisualStyleBackColor = true
    '
    'redtAuxiliarCuentas
    '
    Me.redtAuxiliarCuentas.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtAuxiliarCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtAuxiliarCuentas.Location = New System.Drawing.Point(3, 3)
    Me.redtAuxiliarCuentas.Name = "redtAuxiliarCuentas"
    Me.redtAuxiliarCuentas.ReadOnly = true
    Me.redtAuxiliarCuentas.Size = New System.Drawing.Size(680, 346)
    Me.redtAuxiliarCuentas.TabIndex = 2
    Me.redtAuxiliarCuentas.Text = resources.GetString("redtAuxiliarCuentas.Text")
    '
    'tshSelloDigital
    '
    Me.tshSelloDigital.Controls.Add(Me.redtSelloDigital)
    Me.tshSelloDigital.Location = New System.Drawing.Point(4, 22)
    Me.tshSelloDigital.Name = "tshSelloDigital"
    Me.tshSelloDigital.Padding = New System.Windows.Forms.Padding(3)
    Me.tshSelloDigital.Size = New System.Drawing.Size(686, 352)
    Me.tshSelloDigital.TabIndex = 11
    Me.tshSelloDigital.Text = "Sello digital"
    Me.tshSelloDigital.UseVisualStyleBackColor = true
    '
    'redtSelloDigital
    '
    Me.redtSelloDigital.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtSelloDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtSelloDigital.Location = New System.Drawing.Point(3, 3)
    Me.redtSelloDigital.Name = "redtSelloDigital"
    Me.redtSelloDigital.ReadOnly = true
    Me.redtSelloDigital.Size = New System.Drawing.Size(680, 346)
    Me.redtSelloDigital.TabIndex = 2
    Me.redtSelloDigital.Text = "En este ejemplo se demuestra la generación del archivo XML de las cuentas contabl"& _ 
    "es."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo lo anterior es ejecutado en el método CreateCatalogo()"
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 454)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(694, 22)
    Me.stb.TabIndex = 10
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(557, 17)
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
    Me.ClientSize = New System.Drawing.Size(694, 476)
    Me.Controls.Add(Me.pgcInformacion)
    Me.Controls.Add(Me.stb)
    Me.Controls.Add(Me.pnlOperaciones)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ejemplo de contabilidad electrónica"
    Me.pnlOperaciones.ResumeLayout(false)
    Me.pnlOperaciones.PerformLayout
    Me.pgcInformacion.ResumeLayout(false)
    Me.tshCatalogo.ResumeLayout(false)
    Me.tshBalanza.ResumeLayout(false)
    Me.tshPoliza.ResumeLayout(false)
    Me.tshAuxiliarFolios.ResumeLayout(false)
    Me.tshAuxiliarCuentas.ResumeLayout(false)
    Me.tshSelloDigital.ResumeLayout(false)
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
  Private WithEvents chkGenerarZip As System.Windows.Forms.CheckBox
  Private WithEvents pgcInformacion As System.Windows.Forms.TabControl
  Private WithEvents tshCatalogo As System.Windows.Forms.TabPage
  Private WithEvents redtCatalogo As System.Windows.Forms.RichTextBox
  Private WithEvents tshBalanza As System.Windows.Forms.TabPage
  Private WithEvents redtBalanza As System.Windows.Forms.RichTextBox
  Private WithEvents tshPoliza As System.Windows.Forms.TabPage
  Private WithEvents redtPoliza As System.Windows.Forms.RichTextBox
  Private WithEvents tshAuxiliarFolios As System.Windows.Forms.TabPage
  Private WithEvents redtAuxiliarFolios As System.Windows.Forms.RichTextBox
  Private WithEvents tshAuxiliarCuentas As System.Windows.Forms.TabPage
  Private WithEvents redtAuxiliarCuentas As System.Windows.Forms.RichTextBox
  Private WithEvents tshSelloDigital As System.Windows.Forms.TabPage
  Private WithEvents redtSelloDigital As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
End Class
