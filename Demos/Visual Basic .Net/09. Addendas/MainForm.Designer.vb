<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pnlOptions = New System.Windows.Forms.Panel()
    Me.btnXmlAddenda = New System.Windows.Forms.Button()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.cmbTipo = New System.Windows.Forms.ComboBox()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.redtSample1 = New System.Windows.Forms.RichTextBox()
    Me.stb.SuspendLayout
    Me.pnlOptions.SuspendLayout
    Me.SuspendLayout
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 344)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(784, 22)
    Me.stb.TabIndex = 3
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(616, 17)
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
    'pnlOptions
    '
    Me.pnlOptions.Controls.Add(Me.btnXmlAddenda)
    Me.pnlOptions.Controls.Add(Me.btnTimbrado)
    Me.pnlOptions.Controls.Add(Me.btnClose)
    Me.pnlOptions.Controls.Add(Me.btnHelp)
    Me.pnlOptions.Controls.Add(Me.lblTipo)
    Me.pnlOptions.Controls.Add(Me.btnAbout)
    Me.pnlOptions.Controls.Add(Me.cmbTipo)
    Me.pnlOptions.Controls.Add(Me.btnExecute)
    Me.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlOptions.Location = New System.Drawing.Point(0, 0)
    Me.pnlOptions.Name = "pnlOptions"
    Me.pnlOptions.Size = New System.Drawing.Size(784, 91)
    Me.pnlOptions.TabIndex = 4
    '
    'btnXmlAddenda
    '
    Me.btnXmlAddenda.Location = New System.Drawing.Point(625, 10)
    Me.btnXmlAddenda.Name = "btnXmlAddenda"
    Me.btnXmlAddenda.Size = New System.Drawing.Size(147, 21)
    Me.btnXmlAddenda.TabIndex = 8
    Me.btnXmlAddenda.Text = "&Agregar a un XML"
    Me.btnXmlAddenda.UseVisualStyleBackColor = true
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(551, 37)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(221, 21)
    Me.btnTimbrado.TabIndex = 3
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(704, 64)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(68, 21)
    Me.btnClose.TabIndex = 6
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnHelp
    '
    Me.btnHelp.Location = New System.Drawing.Point(551, 64)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(68, 21)
    Me.btnHelp.TabIndex = 4
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = true
    Me.lblTipo.Location = New System.Drawing.Point(12, 15)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(28, 13)
    Me.lblTipo.TabIndex = 0
    Me.lblTipo.Text = "Tipo"
    '
    'btnAbout
    '
    Me.btnAbout.Location = New System.Drawing.Point(625, 64)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(73, 21)
    Me.btnAbout.TabIndex = 5
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'cmbTipo
    '
    Me.cmbTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbTipo.FormattingEnabled = true
    Me.cmbTipo.Items.AddRange(New Object() {"Aba Seguros", "Ado", "AlSuper", "Altos Hornos de México", "Amece", "Asociación mexicana de instituciones de seguros AMIS", "Axxa - Autos", "Axxa - Gastos médicos", "BrudiFarma", "Capa de ozono", "Chrysler", "Coppel - Ropa", "Disney", "Envases universales de méxico", "Femsa", "Grupo Modelo", "Inbursa", "Landsteiner", "Mabe", "MultiPack", "Oxxo", "Pemex - Exploración", "Pemex - Refinación", "Pilgrims", "Prolec", "Sanmina", "Sector Primario", "Soler & Palau", "Tiendas neto", "Trasnsportes castores"})
    Me.cmbTipo.Location = New System.Drawing.Point(46, 12)
    Me.cmbTipo.Name = "cmbTipo"
    Me.cmbTipo.Size = New System.Drawing.Size(499, 21)
    Me.cmbTipo.TabIndex = 1
    '
    'btnExecute
    '
    Me.btnExecute.Location = New System.Drawing.Point(551, 10)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(68, 21)
    Me.btnExecute.TabIndex = 2
    Me.btnExecute.Text = "&Generar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'redtSample1
    '
    Me.redtSample1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtSample1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtSample1.Location = New System.Drawing.Point(0, 91)
    Me.redtSample1.Name = "redtSample1"
    Me.redtSample1.ReadOnly = true
    Me.redtSample1.Size = New System.Drawing.Size(784, 253)
    Me.redtSample1.TabIndex = 5
    Me.redtSample1.Text = resources.GetString("redtSample1.Text")
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(784, 366)
    Me.Controls.Add(Me.redtSample1)
    Me.Controls.Add(Me.pnlOptions)
    Me.Controls.Add(Me.stb)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Generación de adenda"
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.pnlOptions.ResumeLayout(false)
    Me.pnlOptions.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents pnlOptions As Panel
  Private WithEvents btnXmlAddenda As Button
  Private WithEvents btnTimbrado As Button
  Private WithEvents btnClose As Button
  Private WithEvents btnHelp As Button
  Private WithEvents lblTipo As Label
  Private WithEvents btnAbout As Button
  Private WithEvents cmbTipo As ComboBox
  Private WithEvents btnExecute As Button
  Private WithEvents redtSample1 As RichTextBox
End Class
