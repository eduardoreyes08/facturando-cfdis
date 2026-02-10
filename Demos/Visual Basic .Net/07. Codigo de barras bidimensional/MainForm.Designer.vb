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
    Me.panel2 = New System.Windows.Forms.Panel()
    Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.gbxConfiguracion = New System.Windows.Forms.GroupBox()
    Me.btnConfigurar = New System.Windows.Forms.Button()
    Me.cbxFormato = New System.Windows.Forms.ComboBox()
    Me.edtTamano = New System.Windows.Forms.TextBox()
    Me.label6 = New System.Windows.Forms.Label()
    Me.label5 = New System.Windows.Forms.Label()
    Me.pgcInformacion = New System.Windows.Forms.TabControl()
    Me.tshCfdi = New System.Windows.Forms.TabPage()
    Me.redtSample1 = New System.Windows.Forms.RichTextBox()
    Me.gbxDatos = New System.Windows.Forms.GroupBox()
    Me.edtSello = New System.Windows.Forms.TextBox()
    Me.lblSello = New System.Windows.Forms.Label()
    Me.edtUuid = New System.Windows.Forms.TextBox()
    Me.edtTotal = New System.Windows.Forms.TextBox()
    Me.edtRFCReceptor = New System.Windows.Forms.TextBox()
    Me.edtRFCEmisor = New System.Windows.Forms.TextBox()
    Me.lblUUID = New System.Windows.Forms.Label()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblRFCReceptor = New System.Windows.Forms.Label()
    Me.lblRFCEmisor = New System.Windows.Forms.Label()
    Me.tshConstancia = New System.Windows.Forms.TabPage()
    Me.gbxConstancia = New System.Windows.Forms.GroupBox()
    Me.edtSelloConstancia = New System.Windows.Forms.TextBox()
    Me.lblSelloConstancia = New System.Windows.Forms.Label()
    Me.edtUuidConstancia = New System.Windows.Forms.TextBox()
    Me.edtTotalConstancia = New System.Windows.Forms.TextBox()
    Me.edtReceptorConstancia = New System.Windows.Forms.TextBox()
    Me.edtEmisorConstancia = New System.Windows.Forms.TextBox()
    Me.lblUuidConstancia = New System.Windows.Forms.Label()
    Me.lblTotalConstancia = New System.Windows.Forms.Label()
    Me.lblReceptoConstancia = New System.Windows.Forms.Label()
    Me.lblEmisorConstancia = New System.Windows.Forms.Label()
    Me.redtSample2 = New System.Windows.Forms.RichTextBox()
    Me.picBarCode = New System.Windows.Forms.PictureBox()
    Me.pnlImageSize = New System.Windows.Forms.Panel()
    Me.lblImageSize = New System.Windows.Forms.Label()
    Me.stb = New System.Windows.Forms.StatusStrip()
    Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblLicencia = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
    Me.pnlBoton = New System.Windows.Forms.Panel()
    Me.btnTimbrado = New System.Windows.Forms.Button()
    Me.btnText = New System.Windows.Forms.Button()
    Me.btnHelp = New System.Windows.Forms.Button()
    Me.btnClose = New System.Windows.Forms.Button()
    Me.btnExecute = New System.Windows.Forms.Button()
    Me.btnAbout = New System.Windows.Forms.Button()
    Me.tshCartaPorte = New System.Windows.Forms.TabPage()
    Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
    Me.dteFechaTimbrado = New System.Windows.Forms.DateTimePicker()
    Me.dteFechaOrigen = New System.Windows.Forms.DateTimePicker()
    Me.label3 = New System.Windows.Forms.Label()
    Me.label2 = New System.Windows.Forms.Label()
    Me.edtUuidCartaPorte = New System.Windows.Forms.TextBox()
    Me.label1 = New System.Windows.Forms.Label()
    Me.panel2.SuspendLayout
    CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
    Me.splitContainer1.Panel1.SuspendLayout
    Me.splitContainer1.Panel2.SuspendLayout
    Me.splitContainer1.SuspendLayout
    Me.gbxConfiguracion.SuspendLayout
    Me.pgcInformacion.SuspendLayout
    Me.tshCfdi.SuspendLayout
    Me.gbxDatos.SuspendLayout
    Me.tshConstancia.SuspendLayout
    Me.gbxConstancia.SuspendLayout
    CType(Me.picBarCode,System.ComponentModel.ISupportInitialize).BeginInit
    Me.pnlImageSize.SuspendLayout
    Me.stb.SuspendLayout
    Me.pnlBoton.SuspendLayout
    Me.tshCartaPorte.SuspendLayout
    Me.SuspendLayout
    '
    'panel2
    '
    Me.panel2.Controls.Add(Me.splitContainer1)
    Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel2.Location = New System.Drawing.Point(0, 0)
    Me.panel2.Name = "panel2"
    Me.panel2.Size = New System.Drawing.Size(759, 392)
    Me.panel2.TabIndex = 7
    '
    'splitContainer1
    '
    Me.splitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
    Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.splitContainer1.Name = "splitContainer1"
    '
    'splitContainer1.Panel1
    '
    Me.splitContainer1.Panel1.Controls.Add(Me.gbxConfiguracion)
    Me.splitContainer1.Panel1.Controls.Add(Me.pgcInformacion)
    '
    'splitContainer1.Panel2
    '
    Me.splitContainer1.Panel2.Controls.Add(Me.picBarCode)
    Me.splitContainer1.Panel2.Controls.Add(Me.pnlImageSize)
    Me.splitContainer1.Size = New System.Drawing.Size(751, 381)
    Me.splitContainer1.SplitterDistance = 376
    Me.splitContainer1.TabIndex = 1
    '
    'gbxConfiguracion
    '
    Me.gbxConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
    Me.gbxConfiguracion.Controls.Add(Me.btnConfigurar)
    Me.gbxConfiguracion.Controls.Add(Me.cbxFormato)
    Me.gbxConfiguracion.Controls.Add(Me.edtTamano)
    Me.gbxConfiguracion.Controls.Add(Me.label6)
    Me.gbxConfiguracion.Controls.Add(Me.label5)
    Me.gbxConfiguracion.Location = New System.Drawing.Point(6, 276)
    Me.gbxConfiguracion.Name = "gbxConfiguracion"
    Me.gbxConfiguracion.Size = New System.Drawing.Size(357, 98)
    Me.gbxConfiguracion.TabIndex = 2
    Me.gbxConfiguracion.TabStop = false
    Me.gbxConfiguracion.Text = "Configuración"
    '
    'btnConfigurar
    '
    Me.btnConfigurar.Location = New System.Drawing.Point(273, 64)
    Me.btnConfigurar.Name = "btnConfigurar"
    Me.btnConfigurar.Size = New System.Drawing.Size(81, 23)
    Me.btnConfigurar.TabIndex = 5
    Me.btnConfigurar.Text = "Configurar"
    Me.btnConfigurar.UseVisualStyleBackColor = true
    '
    'cbxFormato
    '
    Me.cbxFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbxFormato.FormattingEnabled = true
    Me.cbxFormato.Location = New System.Drawing.Point(114, 38)
    Me.cbxFormato.Name = "cbxFormato"
    Me.cbxFormato.Size = New System.Drawing.Size(147, 21)
    Me.cbxFormato.TabIndex = 3
    '
    'edtTamano
    '
    Me.edtTamano.Location = New System.Drawing.Point(114, 14)
    Me.edtTamano.Name = "edtTamano"
    Me.edtTamano.Size = New System.Drawing.Size(147, 20)
    Me.edtTamano.TabIndex = 1
    Me.edtTamano.Text = "4"
    '
    'label6
    '
    Me.label6.AutoSize = true
    Me.label6.Location = New System.Drawing.Point(64, 41)
    Me.label6.Name = "label6"
    Me.label6.Size = New System.Drawing.Size(48, 13)
    Me.label6.TabIndex = 2
    Me.label6.Text = "Formato:"
    '
    'label5
    '
    Me.label5.AutoSize = true
    Me.label5.Location = New System.Drawing.Point(63, 17)
    Me.label5.Name = "label5"
    Me.label5.Size = New System.Drawing.Size(49, 13)
    Me.label5.TabIndex = 0
    Me.label5.Text = "Tamaño:"
    '
    'pgcInformacion
    '
    Me.pgcInformacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
    Me.pgcInformacion.Controls.Add(Me.tshCfdi)
    Me.pgcInformacion.Controls.Add(Me.tshConstancia)
    Me.pgcInformacion.Controls.Add(Me.tshCartaPorte)
    Me.pgcInformacion.Location = New System.Drawing.Point(1, 3)
    Me.pgcInformacion.Name = "pgcInformacion"
    Me.pgcInformacion.SelectedIndex = 0
    Me.pgcInformacion.Size = New System.Drawing.Size(388, 268)
    Me.pgcInformacion.TabIndex = 1
    Me.pgcInformacion.TabStop = false
    '
    'tshCfdi
    '
    Me.tshCfdi.Controls.Add(Me.redtSample1)
    Me.tshCfdi.Controls.Add(Me.gbxDatos)
    Me.tshCfdi.Location = New System.Drawing.Point(4, 22)
    Me.tshCfdi.Name = "tshCfdi"
    Me.tshCfdi.Padding = New System.Windows.Forms.Padding(3)
    Me.tshCfdi.Size = New System.Drawing.Size(380, 242)
    Me.tshCfdi.TabIndex = 0
    Me.tshCfdi.Text = "CFDI"
    Me.tshCfdi.UseVisualStyleBackColor = true
    '
    'redtSample1
    '
    Me.redtSample1.Location = New System.Drawing.Point(3, 4)
    Me.redtSample1.Name = "redtSample1"
    Me.redtSample1.ReadOnly = true
    Me.redtSample1.Size = New System.Drawing.Size(371, 88)
    Me.redtSample1.TabIndex = 0
    Me.redtSample1.Text = resources.GetString("redtSample1.Text")
    '
    'gbxDatos
    '
    Me.gbxDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
    Me.gbxDatos.Controls.Add(Me.edtSello)
    Me.gbxDatos.Controls.Add(Me.lblSello)
    Me.gbxDatos.Controls.Add(Me.edtUuid)
    Me.gbxDatos.Controls.Add(Me.edtTotal)
    Me.gbxDatos.Controls.Add(Me.edtRFCReceptor)
    Me.gbxDatos.Controls.Add(Me.edtRFCEmisor)
    Me.gbxDatos.Controls.Add(Me.lblUUID)
    Me.gbxDatos.Controls.Add(Me.lblTotal)
    Me.gbxDatos.Controls.Add(Me.lblRFCReceptor)
    Me.gbxDatos.Controls.Add(Me.lblRFCEmisor)
    Me.gbxDatos.Location = New System.Drawing.Point(3, 98)
    Me.gbxDatos.Name = "gbxDatos"
    Me.gbxDatos.Size = New System.Drawing.Size(366, 138)
    Me.gbxDatos.TabIndex = 1
    Me.gbxDatos.TabStop = false
    Me.gbxDatos.Text = "Datos"
    '
    'edtSello
    '
    Me.edtSello.Location = New System.Drawing.Point(117, 107)
    Me.edtSello.Name = "edtSello"
    Me.edtSello.Size = New System.Drawing.Size(237, 20)
    Me.edtSello.TabIndex = 11
    Me.edtSello.Text = "XXXXXXXX"
    '
    'lblSello
    '
    Me.lblSello.AutoSize = true
    Me.lblSello.Location = New System.Drawing.Point(71, 110)
    Me.lblSello.Name = "lblSello"
    Me.lblSello.Size = New System.Drawing.Size(44, 13)
    Me.lblSello.TabIndex = 10
    Me.lblSello.Text = "SELLO:"
    '
    'edtUuid
    '
    Me.edtUuid.Location = New System.Drawing.Point(117, 80)
    Me.edtUuid.Name = "edtUuid"
    Me.edtUuid.Size = New System.Drawing.Size(237, 20)
    Me.edtUuid.TabIndex = 7
    Me.edtUuid.Text = "76D13901-C371-4246-92DE-FEFE6EB9A977"
    '
    'edtTotal
    '
    Me.edtTotal.Location = New System.Drawing.Point(117, 58)
    Me.edtTotal.Name = "edtTotal"
    Me.edtTotal.Size = New System.Drawing.Size(237, 20)
    Me.edtTotal.TabIndex = 6
    Me.edtTotal.Text = "120.25"
    '
    'edtRFCReceptor
    '
    Me.edtRFCReceptor.Location = New System.Drawing.Point(117, 36)
    Me.edtRFCReceptor.Name = "edtRFCReceptor"
    Me.edtRFCReceptor.Size = New System.Drawing.Size(237, 20)
    Me.edtRFCReceptor.TabIndex = 5
    Me.edtRFCReceptor.Text = "AAA010101AAA"
    '
    'edtRFCEmisor
    '
    Me.edtRFCEmisor.Location = New System.Drawing.Point(117, 14)
    Me.edtRFCEmisor.Name = "edtRFCEmisor"
    Me.edtRFCEmisor.Size = New System.Drawing.Size(237, 20)
    Me.edtRFCEmisor.TabIndex = 4
    Me.edtRFCEmisor.Text = "EKU9003173C9"
    '
    'lblUUID
    '
    Me.lblUUID.AutoSize = true
    Me.lblUUID.Location = New System.Drawing.Point(78, 83)
    Me.lblUUID.Name = "lblUUID"
    Me.lblUUID.Size = New System.Drawing.Size(37, 13)
    Me.lblUUID.TabIndex = 3
    Me.lblUUID.Text = "UUID:"
    '
    'lblTotal
    '
    Me.lblTotal.AutoSize = true
    Me.lblTotal.Location = New System.Drawing.Point(8, 61)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(107, 13)
    Me.lblTotal.TabIndex = 2
    Me.lblTotal.Text = "Total del documento:"
    '
    'lblRFCReceptor
    '
    Me.lblRFCReceptor.AutoSize = true
    Me.lblRFCReceptor.Location = New System.Drawing.Point(25, 39)
    Me.lblRFCReceptor.Name = "lblRFCReceptor"
    Me.lblRFCReceptor.Size = New System.Drawing.Size(90, 13)
    Me.lblRFCReceptor.TabIndex = 1
    Me.lblRFCReceptor.Text = "RFC del receptor:"
    '
    'lblRFCEmisor
    '
    Me.lblRFCEmisor.AutoSize = true
    Me.lblRFCEmisor.Location = New System.Drawing.Point(34, 17)
    Me.lblRFCEmisor.Name = "lblRFCEmisor"
    Me.lblRFCEmisor.Size = New System.Drawing.Size(81, 13)
    Me.lblRFCEmisor.TabIndex = 0
    Me.lblRFCEmisor.Text = "RFC del emisor:"
    '
    'tshConstancia
    '
    Me.tshConstancia.Controls.Add(Me.gbxConstancia)
    Me.tshConstancia.Controls.Add(Me.redtSample2)
    Me.tshConstancia.Location = New System.Drawing.Point(4, 22)
    Me.tshConstancia.Name = "tshConstancia"
    Me.tshConstancia.Padding = New System.Windows.Forms.Padding(3)
    Me.tshConstancia.Size = New System.Drawing.Size(380, 242)
    Me.tshConstancia.TabIndex = 1
    Me.tshConstancia.Text = "Constancia de retenciones"
    Me.tshConstancia.UseVisualStyleBackColor = true
    '
    'gbxConstancia
    '
    Me.gbxConstancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
    Me.gbxConstancia.Controls.Add(Me.edtSelloConstancia)
    Me.gbxConstancia.Controls.Add(Me.lblSelloConstancia)
    Me.gbxConstancia.Controls.Add(Me.edtUuidConstancia)
    Me.gbxConstancia.Controls.Add(Me.edtTotalConstancia)
    Me.gbxConstancia.Controls.Add(Me.edtReceptorConstancia)
    Me.gbxConstancia.Controls.Add(Me.edtEmisorConstancia)
    Me.gbxConstancia.Controls.Add(Me.lblUuidConstancia)
    Me.gbxConstancia.Controls.Add(Me.lblTotalConstancia)
    Me.gbxConstancia.Controls.Add(Me.lblReceptoConstancia)
    Me.gbxConstancia.Controls.Add(Me.lblEmisorConstancia)
    Me.gbxConstancia.Location = New System.Drawing.Point(3, 104)
    Me.gbxConstancia.Name = "gbxConstancia"
    Me.gbxConstancia.Size = New System.Drawing.Size(369, 132)
    Me.gbxConstancia.TabIndex = 2
    Me.gbxConstancia.TabStop = false
    Me.gbxConstancia.Text = "Datos"
    '
    'edtSelloConstancia
    '
    Me.edtSelloConstancia.Location = New System.Drawing.Point(115, 106)
    Me.edtSelloConstancia.Name = "edtSelloConstancia"
    Me.edtSelloConstancia.Size = New System.Drawing.Size(237, 20)
    Me.edtSelloConstancia.TabIndex = 9
    Me.edtSelloConstancia.Text = "XXXXXXXX"
    '
    'lblSelloConstancia
    '
    Me.lblSelloConstancia.AutoSize = true
    Me.lblSelloConstancia.Location = New System.Drawing.Point(69, 109)
    Me.lblSelloConstancia.Name = "lblSelloConstancia"
    Me.lblSelloConstancia.Size = New System.Drawing.Size(44, 13)
    Me.lblSelloConstancia.TabIndex = 8
    Me.lblSelloConstancia.Text = "SELLO:"
    '
    'edtUuidConstancia
    '
    Me.edtUuidConstancia.Location = New System.Drawing.Point(117, 80)
    Me.edtUuidConstancia.Name = "edtUuidConstancia"
    Me.edtUuidConstancia.Size = New System.Drawing.Size(237, 20)
    Me.edtUuidConstancia.TabIndex = 7
    Me.edtUuidConstancia.Text = "76D13901-C371-4246-92DE-FEFE6EB9A977"
    '
    'edtTotalConstancia
    '
    Me.edtTotalConstancia.Location = New System.Drawing.Point(117, 58)
    Me.edtTotalConstancia.Name = "edtTotalConstancia"
    Me.edtTotalConstancia.Size = New System.Drawing.Size(237, 20)
    Me.edtTotalConstancia.TabIndex = 6
    Me.edtTotalConstancia.Text = "120.25"
    '
    'edtReceptorConstancia
    '
    Me.edtReceptorConstancia.Location = New System.Drawing.Point(117, 36)
    Me.edtReceptorConstancia.Name = "edtReceptorConstancia"
    Me.edtReceptorConstancia.Size = New System.Drawing.Size(237, 20)
    Me.edtReceptorConstancia.TabIndex = 5
    Me.edtReceptorConstancia.Text = "AAA010101AAA"
    '
    'edtEmisorConstancia
    '
    Me.edtEmisorConstancia.Location = New System.Drawing.Point(117, 14)
    Me.edtEmisorConstancia.Name = "edtEmisorConstancia"
    Me.edtEmisorConstancia.Size = New System.Drawing.Size(237, 20)
    Me.edtEmisorConstancia.TabIndex = 4
    Me.edtEmisorConstancia.Text = "EKU9003173C9"
    '
    'lblUuidConstancia
    '
    Me.lblUuidConstancia.AutoSize = true
    Me.lblUuidConstancia.Location = New System.Drawing.Point(78, 83)
    Me.lblUuidConstancia.Name = "lblUuidConstancia"
    Me.lblUuidConstancia.Size = New System.Drawing.Size(37, 13)
    Me.lblUuidConstancia.TabIndex = 3
    Me.lblUuidConstancia.Text = "UUID:"
    '
    'lblTotalConstancia
    '
    Me.lblTotalConstancia.AutoSize = true
    Me.lblTotalConstancia.Location = New System.Drawing.Point(8, 61)
    Me.lblTotalConstancia.Name = "lblTotalConstancia"
    Me.lblTotalConstancia.Size = New System.Drawing.Size(107, 13)
    Me.lblTotalConstancia.TabIndex = 2
    Me.lblTotalConstancia.Text = "Total del documento:"
    '
    'lblReceptoConstancia
    '
    Me.lblReceptoConstancia.AutoSize = true
    Me.lblReceptoConstancia.Location = New System.Drawing.Point(10, 39)
    Me.lblReceptoConstancia.Name = "lblReceptoConstancia"
    Me.lblReceptoConstancia.Size = New System.Drawing.Size(105, 13)
    Me.lblReceptoConstancia.TabIndex = 1
    Me.lblReceptoConstancia.Text = "Receptor (Nal / Ext):"
    '
    'lblEmisorConstancia
    '
    Me.lblEmisorConstancia.AutoSize = true
    Me.lblEmisorConstancia.Location = New System.Drawing.Point(34, 17)
    Me.lblEmisorConstancia.Name = "lblEmisorConstancia"
    Me.lblEmisorConstancia.Size = New System.Drawing.Size(81, 13)
    Me.lblEmisorConstancia.TabIndex = 0
    Me.lblEmisorConstancia.Text = "RFC del emisor:"
    '
    'redtSample2
    '
    Me.redtSample2.Dock = System.Windows.Forms.DockStyle.Top
    Me.redtSample2.Location = New System.Drawing.Point(3, 3)
    Me.redtSample2.Name = "redtSample2"
    Me.redtSample2.ReadOnly = true
    Me.redtSample2.Size = New System.Drawing.Size(374, 82)
    Me.redtSample2.TabIndex = 1
    Me.redtSample2.Text = resources.GetString("redtSample2.Text")
    '
    'picBarCode
    '
    Me.picBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.picBarCode.Dock = System.Windows.Forms.DockStyle.Fill
    Me.picBarCode.Location = New System.Drawing.Point(0, 0)
    Me.picBarCode.Name = "picBarCode"
    Me.picBarCode.Size = New System.Drawing.Size(371, 356)
    Me.picBarCode.TabIndex = 3
    Me.picBarCode.TabStop = false
    '
    'pnlImageSize
    '
    Me.pnlImageSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlImageSize.Controls.Add(Me.lblImageSize)
    Me.pnlImageSize.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlImageSize.Location = New System.Drawing.Point(0, 356)
    Me.pnlImageSize.Name = "pnlImageSize"
    Me.pnlImageSize.Size = New System.Drawing.Size(371, 25)
    Me.pnlImageSize.TabIndex = 2
    '
    'lblImageSize
    '
    Me.lblImageSize.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblImageSize.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblImageSize.Location = New System.Drawing.Point(0, 0)
    Me.lblImageSize.Name = "lblImageSize"
    Me.lblImageSize.Size = New System.Drawing.Size(369, 23)
    Me.lblImageSize.TabIndex = 0
    Me.lblImageSize.Text = "Tamaño"
    Me.lblImageSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'stb
    '
    Me.stb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime, Me.lblLicencia, Me.lblVersion})
    Me.stb.Location = New System.Drawing.Point(0, 438)
    Me.stb.Name = "stb"
    Me.stb.Size = New System.Drawing.Size(759, 22)
    Me.stb.TabIndex = 8
    Me.stb.Text = "statusStrip1"
    '
    'lblTime
    '
    Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTime.Name = "lblTime"
    Me.lblTime.Size = New System.Drawing.Size(622, 17)
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
    'pnlBoton
    '
    Me.pnlBoton.Controls.Add(Me.btnTimbrado)
    Me.pnlBoton.Controls.Add(Me.btnText)
    Me.pnlBoton.Controls.Add(Me.btnHelp)
    Me.pnlBoton.Controls.Add(Me.btnClose)
    Me.pnlBoton.Controls.Add(Me.btnExecute)
    Me.pnlBoton.Controls.Add(Me.btnAbout)
    Me.pnlBoton.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlBoton.Location = New System.Drawing.Point(0, 392)
    Me.pnlBoton.Name = "pnlBoton"
    Me.pnlBoton.Size = New System.Drawing.Size(759, 46)
    Me.pnlBoton.TabIndex = 9
    '
    'btnTimbrado
    '
    Me.btnTimbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTimbrado.Location = New System.Drawing.Point(327, 9)
    Me.btnTimbrado.Name = "btnTimbrado"
    Me.btnTimbrado.Size = New System.Drawing.Size(147, 23)
    Me.btnTimbrado.TabIndex = 2
    Me.btnTimbrado.Text = "Servicio de Timbrado"
    Me.btnTimbrado.UseVisualStyleBackColor = true
    '
    'btnText
    '
    Me.btnText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnText.Location = New System.Drawing.Point(510, 9)
    Me.btnText.Name = "btnText"
    Me.btnText.Size = New System.Drawing.Size(75, 23)
    Me.btnText.TabIndex = 3
    Me.btnText.Text = "&Cadena"
    Me.btnText.UseVisualStyleBackColor = true
    '
    'btnHelp
    '
    Me.btnHelp.Location = New System.Drawing.Point(88, 9)
    Me.btnHelp.Name = "btnHelp"
    Me.btnHelp.Size = New System.Drawing.Size(75, 23)
    Me.btnHelp.TabIndex = 1
    Me.btnHelp.Text = "A&yuda..."
    Me.btnHelp.UseVisualStyleBackColor = true
    '
    'btnClose
    '
    Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnClose.Location = New System.Drawing.Point(672, 9)
    Me.btnClose.Name = "btnClose"
    Me.btnClose.Size = New System.Drawing.Size(75, 23)
    Me.btnClose.TabIndex = 5
    Me.btnClose.Text = "&Salir"
    Me.btnClose.UseVisualStyleBackColor = true
    '
    'btnExecute
    '
    Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
    Me.btnExecute.Location = New System.Drawing.Point(591, 9)
    Me.btnExecute.Name = "btnExecute"
    Me.btnExecute.Size = New System.Drawing.Size(75, 23)
    Me.btnExecute.TabIndex = 4
    Me.btnExecute.Text = "&Generar"
    Me.btnExecute.UseVisualStyleBackColor = true
    '
    'btnAbout
    '
    Me.btnAbout.Location = New System.Drawing.Point(7, 9)
    Me.btnAbout.Name = "btnAbout"
    Me.btnAbout.Size = New System.Drawing.Size(75, 23)
    Me.btnAbout.TabIndex = 0
    Me.btnAbout.Text = "&Acerca de..."
    Me.btnAbout.UseVisualStyleBackColor = true
    '
    'tshCartaPorte
    '
    Me.tshCartaPorte.Controls.Add(Me.dteFechaTimbrado)
    Me.tshCartaPorte.Controls.Add(Me.dteFechaOrigen)
    Me.tshCartaPorte.Controls.Add(Me.label3)
    Me.tshCartaPorte.Controls.Add(Me.label2)
    Me.tshCartaPorte.Controls.Add(Me.edtUuidCartaPorte)
    Me.tshCartaPorte.Controls.Add(Me.label1)
    Me.tshCartaPorte.Controls.Add(Me.richTextBox1)
    Me.tshCartaPorte.Location = New System.Drawing.Point(4, 22)
    Me.tshCartaPorte.Name = "tshCartaPorte"
    Me.tshCartaPorte.Padding = New System.Windows.Forms.Padding(3)
    Me.tshCartaPorte.Size = New System.Drawing.Size(380, 242)
    Me.tshCartaPorte.TabIndex = 2
    Me.tshCartaPorte.Text = "Carta porte"
    Me.tshCartaPorte.UseVisualStyleBackColor = true
    '
    'richTextBox1
    '
    Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.richTextBox1.Location = New System.Drawing.Point(3, 3)
    Me.richTextBox1.Name = "richTextBox1"
    Me.richTextBox1.ReadOnly = true
    Me.richTextBox1.Size = New System.Drawing.Size(374, 82)
    Me.richTextBox1.TabIndex = 3
    Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
    '
    'dteFechaTimbrado
    '
    Me.dteFechaTimbrado.CustomFormat = "yyyy-MM-ddTHH:mm:ss"
    Me.dteFechaTimbrado.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dteFechaTimbrado.Location = New System.Drawing.Point(131, 143)
    Me.dteFechaTimbrado.Name = "dteFechaTimbrado"
    Me.dteFechaTimbrado.Size = New System.Drawing.Size(237, 20)
    Me.dteFechaTimbrado.TabIndex = 21
    '
    'dteFechaOrigen
    '
    Me.dteFechaOrigen.CustomFormat = "yyyy-MM-ddTHH:mm:ss"
    Me.dteFechaOrigen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dteFechaOrigen.Location = New System.Drawing.Point(131, 117)
    Me.dteFechaOrigen.Name = "dteFechaOrigen"
    Me.dteFechaOrigen.Size = New System.Drawing.Size(237, 20)
    Me.dteFechaOrigen.TabIndex = 20
    '
    'label3
    '
    Me.label3.AutoSize = true
    Me.label3.Location = New System.Drawing.Point(31, 147)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(98, 13)
    Me.label3.TabIndex = 19
    Me.label3.Text = "Fecha de timbrado:"
    '
    'label2
    '
    Me.label2.AutoSize = true
    Me.label2.Location = New System.Drawing.Point(42, 121)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(87, 13)
    Me.label2.TabIndex = 18
    Me.label2.Text = "Fecha de origen:"
    '
    'edtUuidCartaPorte
    '
    Me.edtUuidCartaPorte.Location = New System.Drawing.Point(131, 91)
    Me.edtUuidCartaPorte.Name = "edtUuidCartaPorte"
    Me.edtUuidCartaPorte.Size = New System.Drawing.Size(237, 20)
    Me.edtUuidCartaPorte.TabIndex = 17
    Me.edtUuidCartaPorte.Text = "76D13901-C371-4246-92DE-FEFE6EB9A977"
    '
    'label1
    '
    Me.label1.AutoSize = true
    Me.label1.Location = New System.Drawing.Point(92, 94)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(37, 13)
    Me.label1.TabIndex = 16
    Me.label1.Text = "UUID:"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(759, 460)
    Me.Controls.Add(Me.panel2)
    Me.Controls.Add(Me.pnlBoton)
    Me.Controls.Add(Me.stb)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "MainForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Ejemplo para la generación de código de barras bidimensional"
    Me.panel2.ResumeLayout(false)
    Me.splitContainer1.Panel1.ResumeLayout(false)
    Me.splitContainer1.Panel2.ResumeLayout(false)
    CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
    Me.splitContainer1.ResumeLayout(false)
    Me.gbxConfiguracion.ResumeLayout(false)
    Me.gbxConfiguracion.PerformLayout
    Me.pgcInformacion.ResumeLayout(false)
    Me.tshCfdi.ResumeLayout(false)
    Me.gbxDatos.ResumeLayout(false)
    Me.gbxDatos.PerformLayout
    Me.tshConstancia.ResumeLayout(false)
    Me.gbxConstancia.ResumeLayout(false)
    Me.gbxConstancia.PerformLayout
    CType(Me.picBarCode,System.ComponentModel.ISupportInitialize).EndInit
    Me.pnlImageSize.ResumeLayout(false)
    Me.stb.ResumeLayout(false)
    Me.stb.PerformLayout
    Me.pnlBoton.ResumeLayout(false)
    Me.tshCartaPorte.ResumeLayout(false)
    Me.tshCartaPorte.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Private WithEvents panel2 As System.Windows.Forms.Panel
  Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
  Private WithEvents gbxConfiguracion As System.Windows.Forms.GroupBox
  Private WithEvents btnConfigurar As System.Windows.Forms.Button
  Private WithEvents cbxFormato As System.Windows.Forms.ComboBox
  Private WithEvents edtTamano As System.Windows.Forms.TextBox
  Private WithEvents label6 As System.Windows.Forms.Label
  Private WithEvents label5 As System.Windows.Forms.Label
  Private WithEvents pgcInformacion As System.Windows.Forms.TabControl
  Private WithEvents tshCfdi As System.Windows.Forms.TabPage
  Private WithEvents redtSample1 As System.Windows.Forms.RichTextBox
  Private WithEvents gbxDatos As System.Windows.Forms.GroupBox
  Private WithEvents edtUuid As System.Windows.Forms.TextBox
  Private WithEvents edtTotal As System.Windows.Forms.TextBox
  Private WithEvents edtRFCReceptor As System.Windows.Forms.TextBox
  Private WithEvents edtRFCEmisor As System.Windows.Forms.TextBox
  Private WithEvents lblUUID As System.Windows.Forms.Label
  Private WithEvents lblTotal As System.Windows.Forms.Label
  Private WithEvents lblRFCReceptor As System.Windows.Forms.Label
  Private WithEvents lblRFCEmisor As System.Windows.Forms.Label
  Private WithEvents tshConstancia As System.Windows.Forms.TabPage
  Private WithEvents gbxConstancia As System.Windows.Forms.GroupBox
  Private WithEvents edtUuidConstancia As System.Windows.Forms.TextBox
  Private WithEvents edtTotalConstancia As System.Windows.Forms.TextBox
  Private WithEvents edtReceptorConstancia As System.Windows.Forms.TextBox
  Private WithEvents edtEmisorConstancia As System.Windows.Forms.TextBox
  Private WithEvents lblUuidConstancia As System.Windows.Forms.Label
  Private WithEvents lblTotalConstancia As System.Windows.Forms.Label
  Private WithEvents lblReceptoConstancia As System.Windows.Forms.Label
  Private WithEvents lblEmisorConstancia As System.Windows.Forms.Label
  Private WithEvents redtSample2 As System.Windows.Forms.RichTextBox
  Private WithEvents picBarCode As System.Windows.Forms.PictureBox
  Private WithEvents pnlImageSize As System.Windows.Forms.Panel
  Private WithEvents lblImageSize As System.Windows.Forms.Label
    Private WithEvents edtSello As TextBox
    Private WithEvents lblSello As Label
    Private WithEvents edtSelloConstancia As TextBox
    Private WithEvents lblSelloConstancia As Label
  Private WithEvents stb As StatusStrip
  Private WithEvents lblTime As ToolStripStatusLabel
  Private WithEvents lblLicencia As ToolStripStatusLabel
  Private WithEvents lblVersion As ToolStripStatusLabel
  Private WithEvents pnlBoton As Panel
  Private WithEvents btnTimbrado As Button
  Private WithEvents btnText As Button
  Private WithEvents btnHelp As Button
  Private WithEvents btnClose As Button
  Private WithEvents btnExecute As Button
  Private WithEvents btnAbout As Button
  Friend WithEvents tshCartaPorte As TabPage
  Private WithEvents dteFechaTimbrado As DateTimePicker
  Private WithEvents dteFechaOrigen As DateTimePicker
  Private WithEvents label3 As Label
  Private WithEvents label2 As Label
  Private WithEvents edtUuidCartaPorte As TextBox
  Private WithEvents label1 As Label
  Private WithEvents richTextBox1 As RichTextBox
End Class