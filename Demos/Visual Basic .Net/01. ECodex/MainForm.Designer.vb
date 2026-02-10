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
    Me.cbbOperacion = New System.Windows.Forms.ComboBox()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.pgcInformacion = New System.Windows.Forms.TabControl()
    Me.tshTimbrado = New System.Windows.Forms.TabPage()
    Me.redtTimbrado = New System.Windows.Forms.RichTextBox()
    Me.tshSolicitudCancelacion = New System.Windows.Forms.TabPage()
    Me.chkOtroPac = New System.Windows.Forms.CheckBox()
    Me.lblUuidSustitucionCancelacion = New System.Windows.Forms.Label()
    Me.lblMotivoCancelacion = New System.Windows.Forms.Label()
    Me.txtUuidSustitucionCancelacion = New System.Windows.Forms.TextBox()
    Me.txtMotivoCancelacion = New System.Windows.Forms.TextBox()
    Me.redtCancelacion = New System.Windows.Forms.RichTextBox()
    Me.lblRfcEmisorCancelacion = New System.Windows.Forms.Label()
    Me.txtUuidCancelacion = New System.Windows.Forms.TextBox()
    Me.txtRfcEmisorCancelacion = New System.Windows.Forms.TextBox()
    Me.lblUuidEmisorCancelacion = New System.Windows.Forms.Label()
    Me.tshAcuseSolicitudCancelacion = New System.Windows.Forms.TabPage()
    Me.lblRfcEmisorAcuse = New System.Windows.Forms.Label()
    Me.txtUuidAcuse = New System.Windows.Forms.TextBox()
    Me.txtRfcEmisorAcuse = New System.Windows.Forms.TextBox()
    Me.lblUuidAcuse = New System.Windows.Forms.Label()
    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
    Me.tshConstanciaRetenciones = New System.Windows.Forms.TabPage()
    Me.redtConstanciaRetenciones = New System.Windows.Forms.RichTextBox()
    Me.tshFechaHora = New System.Windows.Forms.TabPage()
    Me.redFechaHora = New System.Windows.Forms.RichTextBox()
    Me.tshDescargarXml = New System.Windows.Forms.TabPage()
    Me.lblRfcEmisorDescarga = New System.Windows.Forms.Label()
    Me.txtRfcEmisorDescarga = New System.Windows.Forms.TextBox()
    Me.txtUuidDescarga = New System.Windows.Forms.TextBox()
    Me.lblUuid3 = New System.Windows.Forms.Label()
    Me.redtAcuse = New System.Windows.Forms.RichTextBox()
    Me.tshEstadoCuenta = New System.Windows.Forms.TabPage()
    Me.txtRfcEmpresa = New System.Windows.Forms.TextBox()
    Me.lblRfcEmpresa = New System.Windows.Forms.Label()
    Me.redtAsignarCodigoUsuario = New System.Windows.Forms.RichTextBox()
    Me.tshParametros = New System.Windows.Forms.TabPage()
    Me.lblAmbiente = New System.Windows.Forms.Label()
    Me.cbbEnviroment = New System.Windows.Forms.ComboBox()
    Me.chkUseHttps = New System.Windows.Forms.CheckBox()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pnlOperaciones.SuspendLayout
    Me.pgcInformacion.SuspendLayout
    Me.tshTimbrado.SuspendLayout
    Me.tshSolicitudCancelacion.SuspendLayout
    Me.tshAcuseSolicitudCancelacion.SuspendLayout
    Me.tshConstanciaRetenciones.SuspendLayout
    Me.tshFechaHora.SuspendLayout
    Me.tshDescargarXml.SuspendLayout
    Me.tshEstadoCuenta.SuspendLayout
    Me.tshParametros.SuspendLayout
    Me.stb.SuspendLayout
    Me.SuspendLayout
    '
    'pnlOperaciones
    '
    Me.pnlOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlOperaciones.Controls.Add(Me.btnTimbrado)
    Me.pnlOperaciones.Controls.Add(Me.lblOperacion)
    Me.pnlOperaciones.Controls.Add(Me.cbbOperacion)
    Me.pnlOperaciones.Controls.Add(Me.btnHelp)
    Me.pnlOperaciones.Controls.Add(Me.btnClose)
    Me.pnlOperaciones.Controls.Add(Me.btnExecute)
    Me.pnlOperaciones.Controls.Add(Me.btnAbout)
    Me.pnlOperaciones.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlOperaciones.Location = New System.Drawing.Point(0, 0)
    Me.pnlOperaciones.Name = "pnlOperaciones"
    Me.pnlOperaciones.Size = New System.Drawing.Size(626, 82)
    Me.pnlOperaciones.TabIndex = 3
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
    'cbbOperacion
    '
    Me.cbbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbbOperacion.FormattingEnabled = true
    Me.cbbOperacion.Items.AddRange(New Object() {"Generar el timbre de un CFDI", "Solicitar la cancelacion de un CFDI", "Acuse de la solicitud de cancelación", "Descargar el XML del servidor del PAC", "Generar de una constancia de retenciones y pagos", "Obtener la Fecha y Hora del PAC", "Obtener el estado de cuenta de un cliente", "Parametros de conexión"})
    Me.cbbOperacion.Location = New System.Drawing.Point(3, 24)
    Me.cbbOperacion.Name = "cbbOperacion"
    Me.cbbOperacion.Size = New System.Drawing.Size(360, 21)
    Me.cbbOperacion.TabIndex = 1
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
    Me.pgcInformacion.Controls.Add(Me.tshSolicitudCancelacion)
    Me.pgcInformacion.Controls.Add(Me.tshAcuseSolicitudCancelacion)
    Me.pgcInformacion.Controls.Add(Me.tshDescargarXml)
    Me.pgcInformacion.Controls.Add(Me.tshConstanciaRetenciones)
    Me.pgcInformacion.Controls.Add(Me.tshFechaHora)
    Me.pgcInformacion.Controls.Add(Me.tshEstadoCuenta)
    Me.pgcInformacion.Controls.Add(Me.tshParametros)
    Me.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pgcInformacion.Location = New System.Drawing.Point(0, 82)
    Me.pgcInformacion.Name = "pgcInformacion"
    Me.pgcInformacion.SelectedIndex = 0
    Me.pgcInformacion.Size = New System.Drawing.Size(626, 282)
    Me.pgcInformacion.TabIndex = 4
    '
    'tshTimbrado
    '
    Me.tshTimbrado.Controls.Add(Me.redtTimbrado)
    Me.tshTimbrado.Location = New System.Drawing.Point(4, 22)
    Me.tshTimbrado.Name = "tshTimbrado"
    Me.tshTimbrado.Padding = New System.Windows.Forms.Padding(3)
    Me.tshTimbrado.Size = New System.Drawing.Size(618, 256)
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
    Me.redtTimbrado.Size = New System.Drawing.Size(612, 250)
    Me.redtTimbrado.TabIndex = 2
    Me.redtTimbrado.Text = resources.GetString("redtTimbrado.Text")
    '
    'tshSolicitudCancelacion
    '
    Me.tshSolicitudCancelacion.Controls.Add(Me.chkOtroPac)
    Me.tshSolicitudCancelacion.Controls.Add(Me.lblUuidSustitucionCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.lblMotivoCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.txtUuidSustitucionCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.txtMotivoCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.redtCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.lblRfcEmisorCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.txtUuidCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.txtRfcEmisorCancelacion)
    Me.tshSolicitudCancelacion.Controls.Add(Me.lblUuidEmisorCancelacion)
    Me.tshSolicitudCancelacion.Location = New System.Drawing.Point(4, 22)
    Me.tshSolicitudCancelacion.Name = "tshSolicitudCancelacion"
    Me.tshSolicitudCancelacion.Padding = New System.Windows.Forms.Padding(3)
    Me.tshSolicitudCancelacion.Size = New System.Drawing.Size(618, 256)
    Me.tshSolicitudCancelacion.TabIndex = 0
    Me.tshSolicitudCancelacion.Text = "Solicitud de cancelación"
    Me.tshSolicitudCancelacion.UseVisualStyleBackColor = true
    '
    'chkOtroPac
    '
    Me.chkOtroPac.AutoSize = true
    Me.chkOtroPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.chkOtroPac.Location = New System.Drawing.Point(120, 107)
    Me.chkOtroPac.Name = "chkOtroPac"
    Me.chkOtroPac.Size = New System.Drawing.Size(177, 17)
    Me.chkOtroPac.TabIndex = 14
    Me.chkOtroPac.Text = "UUID emitido por otro PAC"
    Me.chkOtroPac.UseVisualStyleBackColor = true
    '
    'lblUuidSustitucionCancelacion
    '
    Me.lblUuidSustitucionCancelacion.AutoSize = true
    Me.lblUuidSustitucionCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblUuidSustitucionCancelacion.Location = New System.Drawing.Point(9, 84)
    Me.lblUuidSustitucionCancelacion.Name = "lblUuidSustitucionCancelacion"
    Me.lblUuidSustitucionCancelacion.Size = New System.Drawing.Size(105, 13)
    Me.lblUuidSustitucionCancelacion.TabIndex = 12
    Me.lblUuidSustitucionCancelacion.Text = "UUID Sustitución"
    '
    'lblMotivoCancelacion
    '
    Me.lblMotivoCancelacion.AutoSize = true
    Me.lblMotivoCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblMotivoCancelacion.Location = New System.Drawing.Point(9, 58)
    Me.lblMotivoCancelacion.Name = "lblMotivoCancelacion"
    Me.lblMotivoCancelacion.Size = New System.Drawing.Size(45, 13)
    Me.lblMotivoCancelacion.TabIndex = 10
    Me.lblMotivoCancelacion.Text = "Motivo"
    '
    'txtUuidSustitucionCancelacion
    '
    Me.txtUuidSustitucionCancelacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtUuidSustitucionCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUuidSustitucionCancelacion.Location = New System.Drawing.Point(120, 81)
    Me.txtUuidSustitucionCancelacion.MaxLength = 36
    Me.txtUuidSustitucionCancelacion.Name = "txtUuidSustitucionCancelacion"
    Me.txtUuidSustitucionCancelacion.Size = New System.Drawing.Size(492, 20)
    Me.txtUuidSustitucionCancelacion.TabIndex = 13
    '
    'txtMotivoCancelacion
    '
    Me.txtMotivoCancelacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtMotivoCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtMotivoCancelacion.Location = New System.Drawing.Point(120, 55)
    Me.txtMotivoCancelacion.MaxLength = 36
    Me.txtMotivoCancelacion.Name = "txtMotivoCancelacion"
    Me.txtMotivoCancelacion.Size = New System.Drawing.Size(492, 20)
    Me.txtMotivoCancelacion.TabIndex = 11
    '
    'redtCancelacion
    '
    Me.redtCancelacion.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.redtCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtCancelacion.Location = New System.Drawing.Point(3, 130)
    Me.redtCancelacion.Name = "redtCancelacion"
    Me.redtCancelacion.ReadOnly = true
    Me.redtCancelacion.Size = New System.Drawing.Size(612, 123)
    Me.redtCancelacion.TabIndex = 9
    Me.redtCancelacion.Text = resources.GetString("redtCancelacion.Text")
    '
    'lblRfcEmisorCancelacion
    '
    Me.lblRfcEmisorCancelacion.AutoSize = true
    Me.lblRfcEmisorCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblRfcEmisorCancelacion.Location = New System.Drawing.Point(9, 6)
    Me.lblRfcEmisorCancelacion.Name = "lblRfcEmisorCancelacion"
    Me.lblRfcEmisorCancelacion.Size = New System.Drawing.Size(71, 13)
    Me.lblRfcEmisorCancelacion.TabIndex = 0
    Me.lblRfcEmisorCancelacion.Text = "RFC emisor"
    '
    'txtUuidCancelacion
    '
    Me.txtUuidCancelacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtUuidCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUuidCancelacion.Location = New System.Drawing.Point(120, 29)
    Me.txtUuidCancelacion.MaxLength = 36
    Me.txtUuidCancelacion.Name = "txtUuidCancelacion"
    Me.txtUuidCancelacion.Size = New System.Drawing.Size(492, 20)
    Me.txtUuidCancelacion.TabIndex = 3
    '
    'txtRfcEmisorCancelacion
    '
    Me.txtRfcEmisorCancelacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtRfcEmisorCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtRfcEmisorCancelacion.Location = New System.Drawing.Point(120, 3)
    Me.txtRfcEmisorCancelacion.MaxLength = 13
    Me.txtRfcEmisorCancelacion.Name = "txtRfcEmisorCancelacion"
    Me.txtRfcEmisorCancelacion.Size = New System.Drawing.Size(492, 20)
    Me.txtRfcEmisorCancelacion.TabIndex = 1
    '
    'lblUuidEmisorCancelacion
    '
    Me.lblUuidEmisorCancelacion.AutoSize = true
    Me.lblUuidEmisorCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblUuidEmisorCancelacion.Location = New System.Drawing.Point(9, 32)
    Me.lblUuidEmisorCancelacion.Name = "lblUuidEmisorCancelacion"
    Me.lblUuidEmisorCancelacion.Size = New System.Drawing.Size(38, 13)
    Me.lblUuidEmisorCancelacion.TabIndex = 2
    Me.lblUuidEmisorCancelacion.Text = "UUID"
    '
    'tshAcuseSolicitudCancelacion
    '
    Me.tshAcuseSolicitudCancelacion.Controls.Add(Me.lblRfcEmisorAcuse)
    Me.tshAcuseSolicitudCancelacion.Controls.Add(Me.txtUuidAcuse)
    Me.tshAcuseSolicitudCancelacion.Controls.Add(Me.txtRfcEmisorAcuse)
    Me.tshAcuseSolicitudCancelacion.Controls.Add(Me.lblUuidAcuse)
    Me.tshAcuseSolicitudCancelacion.Controls.Add(Me.richTextBox1)
    Me.tshAcuseSolicitudCancelacion.Location = New System.Drawing.Point(4, 22)
    Me.tshAcuseSolicitudCancelacion.Name = "tshAcuseSolicitudCancelacion"
    Me.tshAcuseSolicitudCancelacion.Padding = New System.Windows.Forms.Padding(3)
    Me.tshAcuseSolicitudCancelacion.Size = New System.Drawing.Size(618, 256)
    Me.tshAcuseSolicitudCancelacion.TabIndex = 10
    Me.tshAcuseSolicitudCancelacion.Text = "Acuse de la solicitud de cancelación"
    Me.tshAcuseSolicitudCancelacion.UseVisualStyleBackColor = true
    '
    'lblRfcEmisorAcuse
    '
    Me.lblRfcEmisorAcuse.AutoSize = true
    Me.lblRfcEmisorAcuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblRfcEmisorAcuse.Location = New System.Drawing.Point(9, 9)
    Me.lblRfcEmisorAcuse.Name = "lblRfcEmisorAcuse"
    Me.lblRfcEmisorAcuse.Size = New System.Drawing.Size(71, 13)
    Me.lblRfcEmisorAcuse.TabIndex = 0
    Me.lblRfcEmisorAcuse.Text = "RFC emisor"
    '
    'txtUuidAcuse
    '
    Me.txtUuidAcuse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtUuidAcuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUuidAcuse.Location = New System.Drawing.Point(86, 32)
    Me.txtUuidAcuse.MaxLength = 36
    Me.txtUuidAcuse.Name = "txtUuidAcuse"
    Me.txtUuidAcuse.Size = New System.Drawing.Size(526, 20)
    Me.txtUuidAcuse.TabIndex = 3
    '
    'txtRfcEmisorAcuse
    '
    Me.txtRfcEmisorAcuse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtRfcEmisorAcuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtRfcEmisorAcuse.Location = New System.Drawing.Point(86, 6)
    Me.txtRfcEmisorAcuse.MaxLength = 13
    Me.txtRfcEmisorAcuse.Name = "txtRfcEmisorAcuse"
    Me.txtRfcEmisorAcuse.Size = New System.Drawing.Size(526, 20)
    Me.txtRfcEmisorAcuse.TabIndex = 1
    '
    'lblUuidAcuse
    '
    Me.lblUuidAcuse.AutoSize = true
    Me.lblUuidAcuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblUuidAcuse.Location = New System.Drawing.Point(9, 35)
    Me.lblUuidAcuse.Name = "lblUuidAcuse"
    Me.lblUuidAcuse.Size = New System.Drawing.Size(38, 13)
    Me.lblUuidAcuse.TabIndex = 2
    Me.lblUuidAcuse.Text = "UUID"
    '
    'richTextBox1
    '
    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.richTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.richTextBox1.Location = New System.Drawing.Point(3, 105)
    Me.richTextBox1.Name = "richTextBox1"
    Me.richTextBox1.ReadOnly = true
    Me.richTextBox1.Size = New System.Drawing.Size(612, 148)
    Me.richTextBox1.TabIndex = 4
    Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
    '
    'tshConstanciaRetenciones
    '
    Me.tshConstanciaRetenciones.Controls.Add(Me.redtConstanciaRetenciones)
    Me.tshConstanciaRetenciones.Location = New System.Drawing.Point(4, 22)
    Me.tshConstanciaRetenciones.Name = "tshConstanciaRetenciones"
    Me.tshConstanciaRetenciones.Padding = New System.Windows.Forms.Padding(3)
    Me.tshConstanciaRetenciones.Size = New System.Drawing.Size(618, 256)
    Me.tshConstanciaRetenciones.TabIndex = 9
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
    Me.redtConstanciaRetenciones.Size = New System.Drawing.Size(612, 250)
    Me.redtConstanciaRetenciones.TabIndex = 3
    Me.redtConstanciaRetenciones.Text = resources.GetString("redtConstanciaRetenciones.Text")
    '
    'tshFechaHora
    '
    Me.tshFechaHora.Controls.Add(Me.redFechaHora)
    Me.tshFechaHora.Location = New System.Drawing.Point(4, 22)
    Me.tshFechaHora.Name = "tshFechaHora"
    Me.tshFechaHora.Padding = New System.Windows.Forms.Padding(3)
    Me.tshFechaHora.Size = New System.Drawing.Size(618, 256)
    Me.tshFechaHora.TabIndex = 8
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
    Me.redFechaHora.Size = New System.Drawing.Size(612, 250)
    Me.redFechaHora.TabIndex = 4
    Me.redFechaHora.Text = "En este ejemplo se demuestra "&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"    •  Cómo obtener la fecha y hora del PAC."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo"& _ 
    " lo anterior es ejecutado en el método ObtenerFechaHora()"
    '
    'tshDescargarXml
    '
    Me.tshDescargarXml.Controls.Add(Me.lblRfcEmisorDescarga)
    Me.tshDescargarXml.Controls.Add(Me.txtRfcEmisorDescarga)
    Me.tshDescargarXml.Controls.Add(Me.txtUuidDescarga)
    Me.tshDescargarXml.Controls.Add(Me.lblUuid3)
    Me.tshDescargarXml.Controls.Add(Me.redtAcuse)
    Me.tshDescargarXml.Location = New System.Drawing.Point(4, 22)
    Me.tshDescargarXml.Name = "tshDescargarXml"
    Me.tshDescargarXml.Padding = New System.Windows.Forms.Padding(3)
    Me.tshDescargarXml.Size = New System.Drawing.Size(618, 256)
    Me.tshDescargarXml.TabIndex = 2
    Me.tshDescargarXml.Text = "Descargar XML"
    Me.tshDescargarXml.UseVisualStyleBackColor = true
    '
    'lblRfcEmisorDescarga
    '
    Me.lblRfcEmisorDescarga.AutoSize = true
    Me.lblRfcEmisorDescarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblRfcEmisorDescarga.Location = New System.Drawing.Point(18, 9)
    Me.lblRfcEmisorDescarga.Name = "lblRfcEmisorDescarga"
    Me.lblRfcEmisorDescarga.Size = New System.Drawing.Size(71, 13)
    Me.lblRfcEmisorDescarga.TabIndex = 0
    Me.lblRfcEmisorDescarga.Text = "RFC emisor"
    '
    'txtRfcEmisorDescarga
    '
    Me.txtRfcEmisorDescarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtRfcEmisorDescarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtRfcEmisorDescarga.Location = New System.Drawing.Point(92, 6)
    Me.txtRfcEmisorDescarga.MaxLength = 13
    Me.txtRfcEmisorDescarga.Name = "txtRfcEmisorDescarga"
    Me.txtRfcEmisorDescarga.Size = New System.Drawing.Size(523, 20)
    Me.txtRfcEmisorDescarga.TabIndex = 1
    '
    'txtUuidDescarga
    '
    Me.txtUuidDescarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtUuidDescarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtUuidDescarga.Location = New System.Drawing.Point(92, 32)
    Me.txtUuidDescarga.MaxLength = 36
    Me.txtUuidDescarga.Name = "txtUuidDescarga"
    Me.txtUuidDescarga.Size = New System.Drawing.Size(523, 20)
    Me.txtUuidDescarga.TabIndex = 3
    '
    'lblUuid3
    '
    Me.lblUuid3.AutoSize = true
    Me.lblUuid3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblUuid3.Location = New System.Drawing.Point(18, 35)
    Me.lblUuid3.Name = "lblUuid3"
    Me.lblUuid3.Size = New System.Drawing.Size(38, 13)
    Me.lblUuid3.TabIndex = 2
    Me.lblUuid3.Text = "UUID"
    '
    'redtAcuse
    '
    Me.redtAcuse.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.redtAcuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtAcuse.Location = New System.Drawing.Point(3, 104)
    Me.redtAcuse.Name = "redtAcuse"
    Me.redtAcuse.ReadOnly = true
    Me.redtAcuse.Size = New System.Drawing.Size(612, 149)
    Me.redtAcuse.TabIndex = 4
    Me.redtAcuse.Text = "En este ejemplo se demuestra como descargar el XML de un CFDI previamente timbrad"& _ 
    "o por el PAC"&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo lo anterior es ejecutado en el método DescargarXml()"
    '
    'tshEstadoCuenta
    '
    Me.tshEstadoCuenta.Controls.Add(Me.txtRfcEmpresa)
    Me.tshEstadoCuenta.Controls.Add(Me.lblRfcEmpresa)
    Me.tshEstadoCuenta.Controls.Add(Me.redtAsignarCodigoUsuario)
    Me.tshEstadoCuenta.Location = New System.Drawing.Point(4, 22)
    Me.tshEstadoCuenta.Name = "tshEstadoCuenta"
    Me.tshEstadoCuenta.Padding = New System.Windows.Forms.Padding(3)
    Me.tshEstadoCuenta.Size = New System.Drawing.Size(618, 256)
    Me.tshEstadoCuenta.TabIndex = 7
    Me.tshEstadoCuenta.Text = "Estado de cuenta"
    Me.tshEstadoCuenta.UseVisualStyleBackColor = true
    '
    'txtRfcEmpresa
    '
    Me.txtRfcEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.txtRfcEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtRfcEmpresa.Location = New System.Drawing.Point(130, 9)
    Me.txtRfcEmpresa.MaxLength = 13
    Me.txtRfcEmpresa.Name = "txtRfcEmpresa"
    Me.txtRfcEmpresa.Size = New System.Drawing.Size(485, 20)
    Me.txtRfcEmpresa.TabIndex = 1
    '
    'lblRfcEmpresa
    '
    Me.lblRfcEmpresa.AutoSize = true
    Me.lblRfcEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblRfcEmpresa.Location = New System.Drawing.Point(10, 12)
    Me.lblRfcEmpresa.Name = "lblRfcEmpresa"
    Me.lblRfcEmpresa.Size = New System.Drawing.Size(114, 13)
    Me.lblRfcEmpresa.TabIndex = 0
    Me.lblRfcEmpresa.Text = "RFC de la empresa"
    '
    'redtAsignarCodigoUsuario
    '
    Me.redtAsignarCodigoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.redtAsignarCodigoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.redtAsignarCodigoUsuario.Location = New System.Drawing.Point(3, 78)
    Me.redtAsignarCodigoUsuario.Name = "redtAsignarCodigoUsuario"
    Me.redtAsignarCodigoUsuario.ReadOnly = true
    Me.redtAsignarCodigoUsuario.Size = New System.Drawing.Size(612, 175)
    Me.redtAsignarCodigoUsuario.TabIndex = 2
    Me.redtAsignarCodigoUsuario.Text = "En este ejemplo se demuestra como asignar un código de usuario a un usuario regis"& _ 
    "trado en el PAC."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"Todo lo anterior es ejecutado en el método EstadoCuentaCliente"& _ 
    "()"
    '
    'tshParametros
    '
    Me.tshParametros.Controls.Add(Me.lblAmbiente)
    Me.tshParametros.Controls.Add(Me.cbbEnviroment)
    Me.tshParametros.Controls.Add(Me.chkUseHttps)
    Me.tshParametros.Location = New System.Drawing.Point(4, 22)
    Me.tshParametros.Name = "tshParametros"
    Me.tshParametros.Padding = New System.Windows.Forms.Padding(3)
    Me.tshParametros.Size = New System.Drawing.Size(618, 256)
    Me.tshParametros.TabIndex = 4
    Me.tshParametros.Text = "Parámetros de conexión"
    Me.tshParametros.UseVisualStyleBackColor = true
    '
    'lblAmbiente
    '
    Me.lblAmbiente.AutoSize = true
    Me.lblAmbiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblAmbiente.Location = New System.Drawing.Point(14, 17)
    Me.lblAmbiente.Name = "lblAmbiente"
    Me.lblAmbiente.Size = New System.Drawing.Size(141, 13)
    Me.lblAmbiente.TabIndex = 36
    Me.lblAmbiente.Text = "Trabajar en el ambiente"
    '
    'cbbEnviroment
    '
    Me.cbbEnviroment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbbEnviroment.FormattingEnabled = true
    Me.cbbEnviroment.Items.AddRange(New Object() {"Pruebas", "Produccion", "Nómina"})
    Me.cbbEnviroment.Location = New System.Drawing.Point(161, 17)
    Me.cbbEnviroment.Name = "cbbEnviroment"
    Me.cbbEnviroment.Size = New System.Drawing.Size(181, 21)
    Me.cbbEnviroment.TabIndex = 35
    '
    'chkUseHttps
    '
    Me.chkUseHttps.AutoSize = true
    Me.chkUseHttps.Checked = true
    Me.chkUseHttps.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkUseHttps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.chkUseHttps.Location = New System.Drawing.Point(161, 55)
    Me.chkUseHttps.Name = "chkUseHttps"
    Me.chkUseHttps.Size = New System.Drawing.Size(181, 17)
    Me.chkUseHttps.TabIndex = 34
    Me.chkUseHttps.Text = "Conectarse por medio de HTTPs"
    Me.chkUseHttps.UseVisualStyleBackColor = true
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 364)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(626, 22)
    Me.stb.TabIndex = 10
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(489, 17)
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
    Me.ClientSize = New System.Drawing.Size(626, 386)
    Me.Controls.Add(Me.pgcInformacion)
    Me.Controls.Add(Me.stb)
    Me.Controls.Add(Me.pnlOperaciones)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Integración con un PAC - ECodex"
    Me.pnlOperaciones.ResumeLayout(false)
    Me.pnlOperaciones.PerformLayout
    Me.pgcInformacion.ResumeLayout(false)
    Me.tshTimbrado.ResumeLayout(false)
    Me.tshSolicitudCancelacion.ResumeLayout(false)
    Me.tshSolicitudCancelacion.PerformLayout
    Me.tshAcuseSolicitudCancelacion.ResumeLayout(false)
    Me.tshAcuseSolicitudCancelacion.PerformLayout
    Me.tshConstanciaRetenciones.ResumeLayout(false)
    Me.tshFechaHora.ResumeLayout(false)
    Me.tshDescargarXml.ResumeLayout(false)
    Me.tshDescargarXml.PerformLayout
    Me.tshEstadoCuenta.ResumeLayout(false)
    Me.tshEstadoCuenta.PerformLayout
    Me.tshParametros.ResumeLayout(false)
    Me.tshParametros.PerformLayout
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents pnlOperaciones As System.Windows.Forms.Panel
  Private WithEvents btnTimbrado As System.Windows.Forms.Button
  Private WithEvents lblOperacion As System.Windows.Forms.Label
  Private WithEvents cbbOperacion As System.Windows.Forms.ComboBox
  Private WithEvents btnHelp As System.Windows.Forms.Button
  Private WithEvents btnClose As System.Windows.Forms.Button
  Private WithEvents btnExecute As System.Windows.Forms.Button
  Private WithEvents btnAbout As System.Windows.Forms.Button
  Private WithEvents pgcInformacion As System.Windows.Forms.TabControl
  Private WithEvents tshSolicitudCancelacion As System.Windows.Forms.TabPage
  Private WithEvents tshDescargarXml As System.Windows.Forms.TabPage
  Private WithEvents redtAcuse As System.Windows.Forms.RichTextBox
  Private WithEvents tshEstadoCuenta As System.Windows.Forms.TabPage
  Private WithEvents redtAsignarCodigoUsuario As System.Windows.Forms.RichTextBox
  Private WithEvents tshParametros As System.Windows.Forms.TabPage
  Friend WithEvents tshFechaHora As System.Windows.Forms.TabPage
  Private WithEvents redFechaHora As System.Windows.Forms.RichTextBox
  Friend WithEvents tshConstanciaRetenciones As System.Windows.Forms.TabPage
  Private WithEvents redtConstanciaRetenciones As System.Windows.Forms.RichTextBox
  Friend WithEvents tshAcuseSolicitudCancelacion As System.Windows.Forms.TabPage
  Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents lblRfcEmisorCancelacion As Label
  Private WithEvents txtUuidCancelacion As TextBox
  Private WithEvents txtRfcEmisorCancelacion As TextBox
  Private WithEvents lblUuidEmisorCancelacion As Label
  Private WithEvents lblRfcEmisorAcuse As Label
  Private WithEvents txtUuidAcuse As TextBox
  Private WithEvents txtRfcEmisorAcuse As TextBox
  Private WithEvents lblUuidAcuse As Label
  Private WithEvents lblRfcEmisorDescarga As Label
  Private WithEvents txtRfcEmisorDescarga As TextBox
  Private WithEvents txtUuidDescarga As TextBox
  Private WithEvents lblUuid3 As Label
  Private WithEvents txtRfcEmpresa As TextBox
  Private WithEvents lblRfcEmpresa As Label
  Private WithEvents lblAmbiente As Label
  Private WithEvents cbbEnviroment As ComboBox
  Private WithEvents chkUseHttps As CheckBox
  Private WithEvents lblUuidSustitucionCancelacion As Label
  Private WithEvents lblMotivoCancelacion As Label
  Private WithEvents txtUuidSustitucionCancelacion As TextBox
  Private WithEvents txtMotivoCancelacion As TextBox
  Private WithEvents redtCancelacion As RichTextBox
  Private WithEvents tshTimbrado As TabPage
  Private WithEvents redtTimbrado As RichTextBox
  Private WithEvents chkOtroPac As CheckBox
End Class
