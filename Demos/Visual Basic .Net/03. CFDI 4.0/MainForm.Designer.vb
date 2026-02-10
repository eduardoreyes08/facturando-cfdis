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
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pblBotones = New System.Windows.Forms.Panel()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcInformacion = New System.Windows.Forms.TabControl()
    Me.tshSample1 = New System.Windows.Forms.TabPage()
    Me.redtSample1 = New System.Windows.Forms.RichTextBox()
    Me.stb.SuspendLayout
    Me.pblBotones.SuspendLayout
    Me.pgcInformacion.SuspendLayout
    Me.tshSample1.SuspendLayout
    Me.SuspendLayout
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 444)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(734, 22)
    Me.stb.TabIndex = 16
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(597, 17)
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
    'pblBotones
    '
    Me.pblBotones.Controls.Add(Me.btnTimbrado)
    Me.pblBotones.Controls.Add(Me.btnHelp)
    Me.pblBotones.Controls.Add(Me.btnClose)
    Me.pblBotones.Controls.Add(Me.btnExecute)
    Me.pblBotones.Controls.Add(Me.btnAbout)
    Me.pblBotones.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pblBotones.Location = New System.Drawing.Point(0, 398)
    Me.pblBotones.Name = "pblBotones"
    Me.pblBotones.Size = New System.Drawing.Size(734, 46)
    Me.pblBotones.TabIndex = 17
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(413, 9)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(147, 23)
    Me.btnTimbrado.TabIndex = 4
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'btnHelp
    '
    Me.btnHelp.Location = New System.Drawing.Point(88, 9)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(75, 23)
    Me.btnHelp.TabIndex = 3
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(647, 9)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 23)
    Me.btnClose.TabIndex = 1
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnExecute.Location = New System.Drawing.Point(566, 9)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 23)
    Me.btnExecute.TabIndex = 0
    Me.btnExecute.Text = "&Generar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Location = New System.Drawing.Point(7, 9)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 23)
    Me.btnAbout.TabIndex = 2
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'pgcInformacion
    '
    Me.pgcInformacion.Controls.Add(Me.tshSample1)
    Me.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcInformacion.Location = New System.Drawing.Point(0, 0)
    Me.pgcInformacion.Name = "pgcInformacion"
    Me.pgcInformacion.SelectedIndex = 0
    Me.pgcInformacion.Size = New System.Drawing.Size(734, 398)
    Me.pgcInformacion.TabIndex = 18
    '
    'tshSample1
    '
    Me.tshSample1.Controls.Add(Me.redtSample1)
    Me.tshSample1.Location = New System.Drawing.Point(4, 22)
    Me.tshSample1.Name = "tshSample1"
    Me.tshSample1.Padding = New System.Windows.Forms.Padding(3)
    Me.tshSample1.Size = New System.Drawing.Size(726, 372)
    Me.tshSample1.TabIndex = 0
    Me.tshSample1.Text = "Ejemplo 1"
    Me.tshSample1.UseVisualStyleBackColor = true
    '
    'redtSample1
    '
    Me.redtSample1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtSample1.Location = New System.Drawing.Point(3, 3)
    Me.redtSample1.Name = "redtSample1"
    Me.redtSample1.ReadOnly = true
    Me.redtSample1.Size = New System.Drawing.Size(720, 366)
    Me.redtSample1.TabIndex = 0
    Me.redtSample1.Text = "En este ejemplo se demuestra la generación del Pre - CFDI, esto es el CFDI  antes"& _ 
    " de ser timbrado"&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Si deseas ver como se genera un CFDI 4.0 timbrado, por favor, "& _ 
    "revisa el ejemplo PAC ECODEX"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(734, 466)
    Me.Controls.Add(Me.pgcInformacion)
    Me.Controls.Add(Me.pblBotones)
    Me.Controls.Add(Me.stb)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Generación de CFDI 4.0"
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.pblBotones.ResumeLayout(false)
    Me.pgcInformacion.ResumeLayout(false)
    Me.tshSample1.ResumeLayout(false)
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents pblBotones As Panel
  Private WithEvents btnTimbrado As Button
  Private WithEvents btnHelp As Button
  Private WithEvents btnClose As Button
  Private WithEvents btnExecute As Button
  Private WithEvents btnAbout As Button
  Private WithEvents pgcInformacion As TabControl
  Private WithEvents tshSample1 As TabPage
  Private WithEvents redtSample1 As RichTextBox
End Class
