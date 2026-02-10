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
    Me.panel1 = New System.Windows.Forms.Panel()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcInformacion = New System.Windows.Forms.TabControl()
    Me.tshSample1 = New System.Windows.Forms.TabPage()
    Me.redtSample1 = New System.Windows.Forms.RichTextBox()
    Me.tshSample2 = New System.Windows.Forms.TabPage()
    Me.redtSample2 = New System.Windows.Forms.RichTextBox()
    Me.tshSample3 = New System.Windows.Forms.TabPage()
    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.panel1.SuspendLayout
    Me.pgcInformacion.SuspendLayout
    Me.tshSample1.SuspendLayout
    Me.tshSample2.SuspendLayout
    Me.tshSample3.SuspendLayout
    Me.stb.SuspendLayout
    Me.SuspendLayout
    '
    'panel1
    '
    Me.panel1.Controls.Add(Me.btnTimbrado)
    Me.panel1.Controls.Add(Me.btnHelp)
    Me.panel1.Controls.Add(Me.btnClose)
    Me.panel1.Controls.Add(Me.btnExecute)
    Me.panel1.Controls.Add(Me.btnAbout)
    Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.panel1.Location = New System.Drawing.Point(0, 382)
    Me.panel1.Name = "panel1"
    Me.panel1.Size = New System.Drawing.Size(632, 46)
    Me.panel1.TabIndex = 7
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(311, 12)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(147, 23)
    Me.btnTimbrado.TabIndex = 2
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'btnHelp
    '
    Me.btnHelp.Location = New System.Drawing.Point(92, 12)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(75, 23)
    Me.btnHelp.TabIndex = 1
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClose.Location = New System.Drawing.Point(545, 12)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 23)
    Me.btnClose.TabIndex = 4
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnExecute.Location = New System.Drawing.Point(464, 12)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 23)
    Me.btnExecute.TabIndex = 3
    Me.btnExecute.Text = "&Mostrar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Location = New System.Drawing.Point(11, 12)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 23)
    Me.btnAbout.TabIndex = 0
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'pgcInformacion
    '
    Me.pgcInformacion.Controls.Add(Me.tshSample1)
    Me.pgcInformacion.Controls.Add(Me.tshSample2)
    Me.pgcInformacion.Controls.Add(Me.tshSample3)
    Me.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcInformacion.Location = New System.Drawing.Point(0, 0)
    Me.pgcInformacion.Name = "pgcInformacion"
    Me.pgcInformacion.SelectedIndex = 0
    Me.pgcInformacion.Size = New System.Drawing.Size(632, 382)
    Me.pgcInformacion.TabIndex = 8
    Me.pgcInformacion.TabStop = false
    '
    'tshSample1
    '
    Me.tshSample1.Controls.Add(Me.redtSample1)
    Me.tshSample1.Location = New System.Drawing.Point(4, 22)
    Me.tshSample1.Name = "tshSample1"
    Me.tshSample1.Padding = New System.Windows.Forms.Padding(3)
    Me.tshSample1.Size = New System.Drawing.Size(624, 356)
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
    Me.redtSample1.Size = New System.Drawing.Size(618, 350)
    Me.redtSample1.TabIndex = 0
    Me.redtSample1.Text = "En este ejemplo se muestra como obtener los datos de un certificado."&Global.Microsoft.VisualBasic.ChrW(10)
    '
    'tshSample2
    '
    Me.tshSample2.Controls.Add(Me.redtSample2)
    Me.tshSample2.Location = New System.Drawing.Point(4, 22)
    Me.tshSample2.Name = "tshSample2"
    Me.tshSample2.Padding = New System.Windows.Forms.Padding(3)
    Me.tshSample2.Size = New System.Drawing.Size(624, 356)
    Me.tshSample2.TabIndex = 1
    Me.tshSample2.Text = "Ejemplo 2"
    Me.tshSample2.UseVisualStyleBackColor = true
    '
    'redtSample2
    '
    Me.redtSample2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.redtSample2.Location = New System.Drawing.Point(3, 3)
    Me.redtSample2.Name = "redtSample2"
    Me.redtSample2.ReadOnly = true
    Me.redtSample2.Size = New System.Drawing.Size(618, 350)
    Me.redtSample2.TabIndex = 0
    Me.redtSample2.Text = "En este ejemplo se muestra como :"&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"1. Leer un certificado en formato PKCS12 o PFX"& _ 
    "."&Global.Microsoft.VisualBasic.ChrW(10)&"2. Obtener los datos de un certificado."
    '
    'tshSample3
    '
    Me.tshSample3.Controls.Add(Me.richTextBox1)
    Me.tshSample3.Location = New System.Drawing.Point(4, 22)
    Me.tshSample3.Name = "tshSample3"
    Me.tshSample3.Padding = New System.Windows.Forms.Padding(3)
    Me.tshSample3.Size = New System.Drawing.Size(624, 356)
    Me.tshSample3.TabIndex = 2
    Me.tshSample3.Text = "Ejemplo 3"
    Me.tshSample3.UseVisualStyleBackColor = true
    '
    'richTextBox1
    '
    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.richTextBox1.Location = New System.Drawing.Point(3, 3)
    Me.richTextBox1.Name = "richTextBox1"
    Me.richTextBox1.ReadOnly = true
    Me.richTextBox1.Size = New System.Drawing.Size(618, 350)
    Me.richTextBox1.TabIndex = 1
    Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 428)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(632, 22)
    Me.stb.TabIndex = 9
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(495, 17)
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
    Me.ClientSize = New System.Drawing.Size(632, 450)
    Me.Controls.Add(Me.pgcInformacion)
    Me.Controls.Add(Me.panel1)
    Me.Controls.Add(Me.stb)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(648, 484)
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ejemplo para el manejo del Certificado"
    Me.panel1.ResumeLayout(false)
    Me.pgcInformacion.ResumeLayout(false)
    Me.tshSample1.ResumeLayout(false)
    Me.tshSample2.ResumeLayout(false)
    Me.tshSample3.ResumeLayout(false)
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents panel1 As System.Windows.Forms.Panel
  Private WithEvents btnTimbrado As System.Windows.Forms.Button
  Private WithEvents btnHelp As System.Windows.Forms.Button
  Private WithEvents btnClose As System.Windows.Forms.Button
  Private WithEvents btnExecute As System.Windows.Forms.Button
  Private WithEvents btnAbout As System.Windows.Forms.Button
  Private WithEvents pgcInformacion As System.Windows.Forms.TabControl
  Private WithEvents tshSample1 As System.Windows.Forms.TabPage
  Private WithEvents redtSample1 As System.Windows.Forms.RichTextBox
  Private WithEvents tshSample2 As System.Windows.Forms.TabPage
  Private WithEvents redtSample2 As System.Windows.Forms.RichTextBox
  Private WithEvents tshSample3 As System.Windows.Forms.TabPage
  Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
End Class
