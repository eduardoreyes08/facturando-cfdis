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
    Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.redtInformation = New System.Windows.Forms.RichTextBox()
    Me.gbxDatos = New System.Windows.Forms.GroupBox()
    Me.edtUuid = New System.Windows.Forms.TextBox()
    Me.edtTotal = New System.Windows.Forms.TextBox()
    Me.edtRfcReceptor = New System.Windows.Forms.TextBox()
    Me.edtRfcEmisor = New System.Windows.Forms.TextBox()
    Me.lblUUID = New System.Windows.Forms.Label()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblRFCReceptor = New System.Windows.Forms.Label()
    Me.lblRFCEmisor = New System.Windows.Forms.Label()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.lblResultado = New System.Windows.Forms.Label()
    Me.redtResult = New System.Windows.Forms.RichTextBox()
    Me.stb.SuspendLayout
    Me.gbxDatos.SuspendLayout
    Me.SuspendLayout
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 514)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(559, 22)
    Me.stb.TabIndex = 9
    Me.stb.Text = "statusStrip1"
    '
    'toolStripStatusLabel1
    '
    Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
    Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(422, 17)
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
    '
    'lblVersion
    '
    Me.lblVersion.IsLink = true
    Me.lblVersion.Name = "lblVersion"
    Me.lblVersion.Size = New System.Drawing.Size(59, 17)
    Me.lblVersion.Text = "lblVersion"
    Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'redtInformation
    '
    Me.redtInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.redtInformation.Dock = System.Windows.Forms.DockStyle.Top
    Me.redtInformation.Location = New System.Drawing.Point(0, 0)
    Me.redtInformation.Name = "redtInformation"
    Me.redtInformation.ReadOnly = true
    Me.redtInformation.Size = New System.Drawing.Size(559, 85)
    Me.redtInformation.TabIndex = 10
    Me.redtInformation.Text = resources.GetString("redtInformation.Text")
    '
    'gbxDatos
    '
    Me.gbxDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
    Me.gbxDatos.Controls.Add(Me.edtUuid)
    Me.gbxDatos.Controls.Add(Me.edtTotal)
    Me.gbxDatos.Controls.Add(Me.edtRfcReceptor)
    Me.gbxDatos.Controls.Add(Me.edtRfcEmisor)
    Me.gbxDatos.Controls.Add(Me.lblUUID)
    Me.gbxDatos.Controls.Add(Me.lblTotal)
    Me.gbxDatos.Controls.Add(Me.lblRFCReceptor)
    Me.gbxDatos.Controls.Add(Me.lblRFCEmisor)
    Me.gbxDatos.Location = New System.Drawing.Point(7, 92)
    Me.gbxDatos.Name = "gbxDatos"
    Me.gbxDatos.Size = New System.Drawing.Size(340, 134)
    Me.gbxDatos.TabIndex = 11
    Me.gbxDatos.TabStop = false
    Me.gbxDatos.Text = "Datos"
    '
    'edtUuid
    '
    Me.edtUuid.Location = New System.Drawing.Point(98, 94)
    Me.edtUuid.Name = "edtUuid"
    Me.edtUuid.Size = New System.Drawing.Size(227, 20)
    Me.edtUuid.TabIndex = 7
    Me.edtUuid.Text = "20FF9E03-3DA8-4EE2-988B-8E45663642BC"
    '
    'edtTotal
    '
    Me.edtTotal.Location = New System.Drawing.Point(98, 72)
    Me.edtTotal.Name = "edtTotal"
    Me.edtTotal.Size = New System.Drawing.Size(227, 20)
    Me.edtTotal.TabIndex = 5
    Me.edtTotal.Text = "1740.00"
    Me.edtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'edtRfcReceptor
    '
    Me.edtRfcReceptor.Location = New System.Drawing.Point(98, 50)
    Me.edtRfcReceptor.Name = "edtRfcReceptor"
    Me.edtRfcReceptor.Size = New System.Drawing.Size(227, 20)
    Me.edtRfcReceptor.TabIndex = 3
    Me.edtRfcReceptor.Text = "TME001214SP6"
    '
    'edtRfcEmisor
    '
    Me.edtRfcEmisor.Location = New System.Drawing.Point(98, 28)
    Me.edtRfcEmisor.Name = "edtRfcEmisor"
    Me.edtRfcEmisor.Size = New System.Drawing.Size(227, 20)
    Me.edtRfcEmisor.TabIndex = 1
    Me.edtRfcEmisor.Text = "AAAD770905441"
    '
    'lblUUID
    '
    Me.lblUUID.AutoSize = true
    Me.lblUUID.Location = New System.Drawing.Point(59, 97)
    Me.lblUUID.Name = "lblUUID"
    Me.lblUUID.Size = New System.Drawing.Size(37, 13)
    Me.lblUUID.TabIndex = 6
    Me.lblUUID.Text = "UUID:"
    '
    'lblTotal
    '
    Me.lblTotal.AutoSize = true
    Me.lblTotal.Location = New System.Drawing.Point(62, 75)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(34, 13)
    Me.lblTotal.TabIndex = 4
    Me.lblTotal.Text = "Total:"
    '
    'lblRFCReceptor
    '
    Me.lblRFCReceptor.AutoSize = true
    Me.lblRFCReceptor.Location = New System.Drawing.Point(6, 53)
    Me.lblRFCReceptor.Name = "lblRFCReceptor"
    Me.lblRFCReceptor.Size = New System.Drawing.Size(90, 13)
    Me.lblRFCReceptor.TabIndex = 2
    Me.lblRFCReceptor.Text = "RFC del receptor:"
    '
    'lblRFCEmisor
    '
    Me.lblRFCEmisor.AutoSize = true
    Me.lblRFCEmisor.Location = New System.Drawing.Point(15, 31)
    Me.lblRFCEmisor.Name = "lblRFCEmisor"
    Me.lblRFCEmisor.Size = New System.Drawing.Size(81, 13)
    Me.lblRFCEmisor.TabIndex = 0
    Me.lblRFCEmisor.Text = "RFC del emisor:"
    '
    'btnExecute
    '
    Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnExecute.Location = New System.Drawing.Point(353, 92)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(194, 76)
    Me.btnExecute.TabIndex = 12
    Me.btnExecute.Text = "&CONSULTAR"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnHelp
    '
    Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnHelp.Location = New System.Drawing.Point(452, 174)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(95, 23)
    Me.btnHelp.TabIndex = 14
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnAbout.Location = New System.Drawing.Point(353, 174)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(95, 23)
    Me.btnAbout.TabIndex = 13
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.Location = New System.Drawing.Point(353, 203)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(194, 23)
    Me.btnClose.TabIndex = 15
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'lblResultado
    '
    Me.lblResultado.AutoSize = true
    Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblResultado.Location = New System.Drawing.Point(4, 244)
    Me.lblResultado.Name = "lblResultado"
    Me.lblResultado.Size = New System.Drawing.Size(82, 13)
    Me.lblResultado.TabIndex = 16
    Me.lblResultado.Text = "RESULTADO"
    '
    'redtResult
    '
    Me.redtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.redtResult.Font = New System.Drawing.Font("Consolas", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtResult.Location = New System.Drawing.Point(7, 260)
    Me.redtResult.Name = "redtResult"
    Me.redtResult.ReadOnly = true
    Me.redtResult.Size = New System.Drawing.Size(540, 250)
    Me.redtResult.TabIndex = 17
    Me.redtResult.Text = ""
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(559, 536)
    Me.Controls.Add(Me.redtResult)
    Me.Controls.Add(Me.lblResultado)
    Me.Controls.Add(Me.btnExecute)
    Me.Controls.Add(Me.btnHelp)
    Me.Controls.Add(Me.btnAbout)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.gbxDatos)
    Me.Controls.Add(Me.redtInformation)
    Me.Controls.Add(Me.stb)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Consultar el Status de un CFDI en el SAT"
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.gbxDatos.ResumeLayout(false)
    Me.gbxDatos.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Private WithEvents stb As StatusStrip
  Private WithEvents toolStripStatusLabel1 As ToolStripStatusLabel
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents redtInformation As RichTextBox
  Private WithEvents gbxDatos As GroupBox
  Private WithEvents edtUuid As TextBox
  Private WithEvents edtTotal As TextBox
  Private WithEvents edtRfcReceptor As TextBox
  Private WithEvents edtRfcEmisor As TextBox
  Private WithEvents lblUUID As Label
  Private WithEvents lblTotal As Label
  Private WithEvents lblRFCReceptor As Label
  Private WithEvents lblRFCEmisor As Label
  Private WithEvents btnExecute As Button
  Private WithEvents btnHelp As Button
  Private WithEvents btnAbout As Button
  Private WithEvents btnClose As Button
  Private WithEvents lblResultado As Label
  Private WithEvents redtResult As RichTextBox
End Class
