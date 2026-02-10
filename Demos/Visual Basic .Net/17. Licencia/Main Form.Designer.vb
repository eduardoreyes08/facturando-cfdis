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
    Me.statusStrip = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.btnStatusLicencia = New System.Windows.Forms.Button()
    Me.btnDatosLicencia = New System.Windows.Forms.Button()
    Me.btnCargarLicencia = New System.Windows.Forms.Button()
    Me.btnPuertos = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.statusStrip.SuspendLayout
    Me.SuspendLayout
    '
    'statusStrip
    '
    Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblVersion})
    Me.statusStrip.Location = New System.Drawing.Point(0, 184)
    Me.statusStrip.Name = "statusStrip"
    Me.statusStrip.Size = New System.Drawing.Size(624, 22)
    Me.statusStrip.TabIndex = 20
    Me.statusStrip.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(550, 17)
    Me.lblTime.Spring = true
    Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblVersion
    '
    Me.lblVersion.IsLink = true
    Me.lblVersion.Name = "lblVersion"
    Me.lblVersion.Size = New System.Drawing.Size(59, 17)
    Me.lblVersion.Text = "lblVersion"
    Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'btnStatusLicencia
    '
    Me.btnStatusLicencia.Location = New System.Drawing.Point(12, 68)
    Me.btnStatusLicencia.Name = "btnStatusLicencia"
    Me.btnStatusLicencia.Size = New System.Drawing.Size(250, 50)
    Me.btnStatusLicencia.TabIndex = 30
    Me.btnStatusLicencia.Text = "STATUS DE LA LICENCIA"
    Me.btnStatusLicencia.UseVisualStyleBackColor = true
    '
    'btnDatosLicencia
    '
    Me.btnDatosLicencia.Location = New System.Drawing.Point(12, 124)
    Me.btnDatosLicencia.Name = "btnDatosLicencia"
    Me.btnDatosLicencia.Size = New System.Drawing.Size(250, 50)
    Me.btnDatosLicencia.TabIndex = 28
    Me.btnDatosLicencia.Text = "DATOS DE LA LICENCIA"
    Me.btnDatosLicencia.UseVisualStyleBackColor = true
    '
    'btnCargarLicencia
    '
    Me.btnCargarLicencia.Location = New System.Drawing.Point(12, 12)
    Me.btnCargarLicencia.Name = "btnCargarLicencia"
    Me.btnCargarLicencia.Size = New System.Drawing.Size(250, 50)
    Me.btnCargarLicencia.TabIndex = 29
    Me.btnCargarLicencia.Text = "CARGAR LICENCIA"
    Me.btnCargarLicencia.UseVisualStyleBackColor = true
    '
    'btnPuertos
    '
    Me.btnPuertos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnPuertos.Location = New System.Drawing.Point(471, 124)
    Me.btnPuertos.Name = "btnPuertos"
    Me.btnPuertos.Size = New System.Drawing.Size(141, 23)
    Me.btnPuertos.TabIndex = 32
    Me.btnPuertos.Text = "Puertos"
    Me.btnPuertos.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnClose.Location = New System.Drawing.Point(471, 152)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(141, 22)
    Me.btnClose.TabIndex = 31
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(624, 206)
    Me.Controls.Add(Me.btnPuertos)
    Me.Controls.Add(Me.btnClose)
    Me.Controls.Add(Me.btnStatusLicencia)
    Me.Controls.Add(Me.btnDatosLicencia)
    Me.Controls.Add(Me.btnCargarLicencia)
    Me.Controls.Add(Me.statusStrip)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "LICENCIA"
    Me.statusStrip.ResumeLayout(false)
    Me.statusStrip.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Private WithEvents statusStrip As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents btnStatusLicencia As Button
  Private WithEvents btnDatosLicencia As Button
  Private WithEvents btnCargarLicencia As Button
  Private WithEvents btnPuertos As Button
  Private WithEvents btnClose As Button
End Class
