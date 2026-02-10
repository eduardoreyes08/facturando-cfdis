namespace HyperSoft.Ejemplo.ECodex
{
  partial class MainForm
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlOperaciones = new System.Windows.Forms.Panel();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.lblOperacion = new System.Windows.Forms.Label();
      this.cbbOperacion = new System.Windows.Forms.ComboBox();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.tshParametros = new System.Windows.Forms.TabPage();
      this.lblEnviroment = new System.Windows.Forms.Label();
      this.cbbEnviroment = new System.Windows.Forms.ComboBox();
      this.chkUseHttps = new System.Windows.Forms.CheckBox();
      this.tshEstadoCuenta = new System.Windows.Forms.TabPage();
      this.txtRfcEmpresa = new System.Windows.Forms.TextBox();
      this.lblRfcEmpresa = new System.Windows.Forms.Label();
      this.redtEstadoCuenta = new System.Windows.Forms.RichTextBox();
      this.tshDescargarXml = new System.Windows.Forms.TabPage();
      this.lblRfcEmisorDescarga = new System.Windows.Forms.Label();
      this.txtRfcEmisorDescarga = new System.Windows.Forms.TextBox();
      this.txtUuidDescargaCfdi = new System.Windows.Forms.TextBox();
      this.redtDescargarCfdi = new System.Windows.Forms.RichTextBox();
      this.lblUuidDescargaCfdi = new System.Windows.Forms.Label();
      this.tshSolicitudCancelacion = new System.Windows.Forms.TabPage();
      this.chkOtroPac = new System.Windows.Forms.CheckBox();
      this.lblUuidSustitucionCancelacion = new System.Windows.Forms.Label();
      this.lblMotivoCancelacion = new System.Windows.Forms.Label();
      this.txtUuidSustitucionCancelacion = new System.Windows.Forms.TextBox();
      this.txtMotivoCancelacion = new System.Windows.Forms.TextBox();
      this.lblRfcEmisorCancelacion = new System.Windows.Forms.Label();
      this.txtUuidCancelacion = new System.Windows.Forms.TextBox();
      this.txtRfcEmisorCancelacion = new System.Windows.Forms.TextBox();
      this.lblUuidCancelacion = new System.Windows.Forms.Label();
      this.redtCancelacion = new System.Windows.Forms.RichTextBox();
      this.tshTimbrado = new System.Windows.Forms.TabPage();
      this.redtTimbrado = new System.Windows.Forms.RichTextBox();
      this.pgcInformacion = new System.Windows.Forms.TabControl();
      this.tshAcuseSolicitudCancelacion = new System.Windows.Forms.TabPage();
      this.lblRfcEmisorAcuse = new System.Windows.Forms.Label();
      this.txtUuidAcuse = new System.Windows.Forms.TextBox();
      this.txtRfcEmisorAcuse = new System.Windows.Forms.TextBox();
      this.lblUuidAcuse = new System.Windows.Forms.Label();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.tshConstanciaRetenciones = new System.Windows.Forms.TabPage();
      this.redtConstanciaRetenciones = new System.Windows.Forms.RichTextBox();
      this.tshFechaHora = new System.Windows.Forms.TabPage();
      this.redFechaHora = new System.Windows.Forms.RichTextBox();
      this.stb.SuspendLayout();
      this.pnlOperaciones.SuspendLayout();
      this.tshParametros.SuspendLayout();
      this.tshEstadoCuenta.SuspendLayout();
      this.tshDescargarXml.SuspendLayout();
      this.tshSolicitudCancelacion.SuspendLayout();
      this.tshTimbrado.SuspendLayout();
      this.pgcInformacion.SuspendLayout();
      this.tshAcuseSolicitudCancelacion.SuspendLayout();
      this.tshConstanciaRetenciones.SuspendLayout();
      this.tshFechaHora.SuspendLayout();
      this.SuspendLayout();
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 364);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(619, 22);
      this.stb.SizingGrip = false;
      this.stb.TabIndex = 1;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(482, 17);
      this.lblTime.Spring = true;
      this.lblTime.Text = "lblTime";
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblLicencia
      // 
      this.lblLicencia.IsLink = true;
      this.lblLicencia.Name = "lblLicencia";
      this.lblLicencia.Size = new System.Drawing.Size(63, 17);
      this.lblLicencia.Text = "lblLicencia";
      this.lblLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblVersion
      // 
      this.lblVersion.IsLink = true;
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(59, 17);
      this.lblVersion.Text = "lblVersion";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // pnlOperaciones
      // 
      this.pnlOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlOperaciones.Controls.Add(this.btnTimbrado);
      this.pnlOperaciones.Controls.Add(this.lblOperacion);
      this.pnlOperaciones.Controls.Add(this.cbbOperacion);
      this.pnlOperaciones.Controls.Add(this.btnHelp);
      this.pnlOperaciones.Controls.Add(this.btnClose);
      this.pnlOperaciones.Controls.Add(this.btnExecute);
      this.pnlOperaciones.Controls.Add(this.btnAbout);
      this.pnlOperaciones.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlOperaciones.Location = new System.Drawing.Point(0, 0);
      this.pnlOperaciones.Name = "pnlOperaciones";
      this.pnlOperaciones.Size = new System.Drawing.Size(619, 82);
      this.pnlOperaciones.TabIndex = 0;
      // 
      // btnTimbrado
      // 
      this.btnTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimbrado.Location = new System.Drawing.Point(450, 24);
      this.btnTimbrado.Name = "btnTimbrado";
      this.btnTimbrado.Size = new System.Drawing.Size(156, 23);
      this.btnTimbrado.TabIndex = 3;
      this.btnTimbrado.Text = "Servicio de Timbrado";
      this.btnTimbrado.UseVisualStyleBackColor = true;
      // 
      // lblOperacion
      // 
      this.lblOperacion.AutoSize = true;
      this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOperacion.Location = new System.Drawing.Point(3, 8);
      this.lblOperacion.Name = "lblOperacion";
      this.lblOperacion.Size = new System.Drawing.Size(155, 13);
      this.lblOperacion.TabIndex = 0;
      this.lblOperacion.Text = "Seleccione una operación";
      // 
      // cbbOperacion
      // 
      this.cbbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbOperacion.FormattingEnabled = true;
      this.cbbOperacion.Items.AddRange(new object[] {
            "Generar el timbre de un CFDI",
            "Solicitar la cancelacion de un CFDI",
            "Acuse de la solicitud de cancelación",
            "Descargar el XML del servidor del PAC",
            "Generar de una constancia de retenciones y pagos",
            "Obtener la Fecha y Hora del PAC",
            "Obtener el estado de cuenta de un cliente",
            "Parametros de conexión"});
      this.cbbOperacion.Location = new System.Drawing.Point(3, 24);
      this.cbbOperacion.Name = "cbbOperacion";
      this.cbbOperacion.Size = new System.Drawing.Size(360, 21);
      this.cbbOperacion.TabIndex = 1;
      this.cbbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
      // 
      // btnHelp
      // 
      this.btnHelp.Location = new System.Drawing.Point(450, 51);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 21);
      this.btnHelp.TabIndex = 5;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(531, 51);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 21);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(369, 24);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 21);
      this.btnExecute.TabIndex = 2;
      this.btnExecute.Text = "&Ejecutar";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Location = new System.Drawing.Point(369, 51);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(75, 21);
      this.btnAbout.TabIndex = 4;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // tshParametros
      // 
      this.tshParametros.Controls.Add(this.lblEnviroment);
      this.tshParametros.Controls.Add(this.cbbEnviroment);
      this.tshParametros.Controls.Add(this.chkUseHttps);
      this.tshParametros.Location = new System.Drawing.Point(4, 22);
      this.tshParametros.Name = "tshParametros";
      this.tshParametros.Padding = new System.Windows.Forms.Padding(3);
      this.tshParametros.Size = new System.Drawing.Size(611, 256);
      this.tshParametros.TabIndex = 4;
      this.tshParametros.Text = "Parámetros de conexión";
      this.tshParametros.UseVisualStyleBackColor = true;
      // 
      // lblEnviroment
      // 
      this.lblEnviroment.AutoSize = true;
      this.lblEnviroment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEnviroment.Location = new System.Drawing.Point(8, 22);
      this.lblEnviroment.Name = "lblEnviroment";
      this.lblEnviroment.Size = new System.Drawing.Size(141, 13);
      this.lblEnviroment.TabIndex = 33;
      this.lblEnviroment.Text = "Trabajar en el ambiente";
      // 
      // cbbEnviroment
      // 
      this.cbbEnviroment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbEnviroment.FormattingEnabled = true;
      this.cbbEnviroment.Items.AddRange(new object[] {
            "Pruebas",
            "Produccion",
            "Nómina"});
      this.cbbEnviroment.Location = new System.Drawing.Point(155, 22);
      this.cbbEnviroment.Name = "cbbEnviroment";
      this.cbbEnviroment.Size = new System.Drawing.Size(181, 21);
      this.cbbEnviroment.TabIndex = 32;
      // 
      // chkUseHttps
      // 
      this.chkUseHttps.AutoSize = true;
      this.chkUseHttps.Checked = true;
      this.chkUseHttps.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkUseHttps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkUseHttps.Location = new System.Drawing.Point(155, 60);
      this.chkUseHttps.Name = "chkUseHttps";
      this.chkUseHttps.Size = new System.Drawing.Size(181, 17);
      this.chkUseHttps.TabIndex = 30;
      this.chkUseHttps.Text = "Conectarse por medio de HTTPs";
      this.chkUseHttps.UseVisualStyleBackColor = true;
      // 
      // tshEstadoCuenta
      // 
      this.tshEstadoCuenta.Controls.Add(this.txtRfcEmpresa);
      this.tshEstadoCuenta.Controls.Add(this.lblRfcEmpresa);
      this.tshEstadoCuenta.Controls.Add(this.redtEstadoCuenta);
      this.tshEstadoCuenta.Location = new System.Drawing.Point(4, 22);
      this.tshEstadoCuenta.Name = "tshEstadoCuenta";
      this.tshEstadoCuenta.Padding = new System.Windows.Forms.Padding(3);
      this.tshEstadoCuenta.Size = new System.Drawing.Size(611, 256);
      this.tshEstadoCuenta.TabIndex = 7;
      this.tshEstadoCuenta.Text = "Estado de cuenta";
      this.tshEstadoCuenta.UseVisualStyleBackColor = true;
      // 
      // txtRfcEmpresa
      // 
      this.txtRfcEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRfcEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRfcEmpresa.Location = new System.Drawing.Point(123, 9);
      this.txtRfcEmpresa.MaxLength = 13;
      this.txtRfcEmpresa.Name = "txtRfcEmpresa";
      this.txtRfcEmpresa.Size = new System.Drawing.Size(485, 20);
      this.txtRfcEmpresa.TabIndex = 1;
      // 
      // lblRfcEmpresa
      // 
      this.lblRfcEmpresa.AutoSize = true;
      this.lblRfcEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRfcEmpresa.Location = new System.Drawing.Point(3, 12);
      this.lblRfcEmpresa.Name = "lblRfcEmpresa";
      this.lblRfcEmpresa.Size = new System.Drawing.Size(114, 13);
      this.lblRfcEmpresa.TabIndex = 0;
      this.lblRfcEmpresa.Text = "RFC de la empresa";
      // 
      // redtEstadoCuenta
      // 
      this.redtEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.redtEstadoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtEstadoCuenta.Location = new System.Drawing.Point(3, 78);
      this.redtEstadoCuenta.Name = "redtEstadoCuenta";
      this.redtEstadoCuenta.ReadOnly = true;
      this.redtEstadoCuenta.Size = new System.Drawing.Size(605, 175);
      this.redtEstadoCuenta.TabIndex = 2;
      this.redtEstadoCuenta.Text = "En este ejemplo se muestra cómo obtener el estado de cuenta de un cliente.\n\nTodo " +
    "lo anterior es ejecutado en el método EstadoCuentaCliente()";
      // 
      // tshDescargarXml
      // 
      this.tshDescargarXml.Controls.Add(this.lblRfcEmisorDescarga);
      this.tshDescargarXml.Controls.Add(this.txtRfcEmisorDescarga);
      this.tshDescargarXml.Controls.Add(this.txtUuidDescargaCfdi);
      this.tshDescargarXml.Controls.Add(this.redtDescargarCfdi);
      this.tshDescargarXml.Controls.Add(this.lblUuidDescargaCfdi);
      this.tshDescargarXml.Location = new System.Drawing.Point(4, 22);
      this.tshDescargarXml.Name = "tshDescargarXml";
      this.tshDescargarXml.Padding = new System.Windows.Forms.Padding(3);
      this.tshDescargarXml.Size = new System.Drawing.Size(611, 256);
      this.tshDescargarXml.TabIndex = 2;
      this.tshDescargarXml.Text = "Descargar XML";
      this.tshDescargarXml.UseVisualStyleBackColor = true;
      // 
      // lblRfcEmisorDescarga
      // 
      this.lblRfcEmisorDescarga.AutoSize = true;
      this.lblRfcEmisorDescarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRfcEmisorDescarga.Location = new System.Drawing.Point(8, 9);
      this.lblRfcEmisorDescarga.Name = "lblRfcEmisorDescarga";
      this.lblRfcEmisorDescarga.Size = new System.Drawing.Size(71, 13);
      this.lblRfcEmisorDescarga.TabIndex = 0;
      this.lblRfcEmisorDescarga.Text = "RFC emisor";
      // 
      // txtRfcEmisorDescarga
      // 
      this.txtRfcEmisorDescarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRfcEmisorDescarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRfcEmisorDescarga.Location = new System.Drawing.Point(82, 6);
      this.txtRfcEmisorDescarga.MaxLength = 13;
      this.txtRfcEmisorDescarga.Name = "txtRfcEmisorDescarga";
      this.txtRfcEmisorDescarga.Size = new System.Drawing.Size(523, 20);
      this.txtRfcEmisorDescarga.TabIndex = 1;
      // 
      // txtUuidDescargaCfdi
      // 
      this.txtUuidDescargaCfdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUuidDescargaCfdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUuidDescargaCfdi.Location = new System.Drawing.Point(82, 32);
      this.txtUuidDescargaCfdi.MaxLength = 36;
      this.txtUuidDescargaCfdi.Name = "txtUuidDescargaCfdi";
      this.txtUuidDescargaCfdi.Size = new System.Drawing.Size(523, 20);
      this.txtUuidDescargaCfdi.TabIndex = 3;
      // 
      // redtDescargarCfdi
      // 
      this.redtDescargarCfdi.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.redtDescargarCfdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtDescargarCfdi.Location = new System.Drawing.Point(3, 101);
      this.redtDescargarCfdi.Name = "redtDescargarCfdi";
      this.redtDescargarCfdi.ReadOnly = true;
      this.redtDescargarCfdi.Size = new System.Drawing.Size(605, 152);
      this.redtDescargarCfdi.TabIndex = 4;
      this.redtDescargarCfdi.Text = "En este ejemplo se demuestra como descargar el XML de un CFDI previamente timbrad" +
    "o por el PAC\n\nTodo lo anterior es ejecutado en el método DescargarXml()";
      // 
      // lblUuidDescargaCfdi
      // 
      this.lblUuidDescargaCfdi.AutoSize = true;
      this.lblUuidDescargaCfdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUuidDescargaCfdi.Location = new System.Drawing.Point(8, 35);
      this.lblUuidDescargaCfdi.Name = "lblUuidDescargaCfdi";
      this.lblUuidDescargaCfdi.Size = new System.Drawing.Size(38, 13);
      this.lblUuidDescargaCfdi.TabIndex = 2;
      this.lblUuidDescargaCfdi.Text = "UUID";
      // 
      // tshSolicitudCancelacion
      // 
      this.tshSolicitudCancelacion.Controls.Add(this.chkOtroPac);
      this.tshSolicitudCancelacion.Controls.Add(this.lblUuidSustitucionCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.lblMotivoCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.txtUuidSustitucionCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.txtMotivoCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.lblRfcEmisorCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.txtUuidCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.txtRfcEmisorCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.lblUuidCancelacion);
      this.tshSolicitudCancelacion.Controls.Add(this.redtCancelacion);
      this.tshSolicitudCancelacion.Location = new System.Drawing.Point(4, 22);
      this.tshSolicitudCancelacion.Name = "tshSolicitudCancelacion";
      this.tshSolicitudCancelacion.Padding = new System.Windows.Forms.Padding(3);
      this.tshSolicitudCancelacion.Size = new System.Drawing.Size(611, 256);
      this.tshSolicitudCancelacion.TabIndex = 0;
      this.tshSolicitudCancelacion.Text = "Solicitud de cancelación";
      this.tshSolicitudCancelacion.UseVisualStyleBackColor = true;
      // 
      // chkOtroPac
      // 
      this.chkOtroPac.AutoSize = true;
      this.chkOtroPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkOtroPac.Location = new System.Drawing.Point(116, 110);
      this.chkOtroPac.Name = "chkOtroPac";
      this.chkOtroPac.Size = new System.Drawing.Size(177, 17);
      this.chkOtroPac.TabIndex = 9;
      this.chkOtroPac.Text = "UUID emitido por otro PAC";
      this.chkOtroPac.UseVisualStyleBackColor = true;
      // 
      // lblUuidSustitucionCancelacion
      // 
      this.lblUuidSustitucionCancelacion.AutoSize = true;
      this.lblUuidSustitucionCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUuidSustitucionCancelacion.Location = new System.Drawing.Point(5, 87);
      this.lblUuidSustitucionCancelacion.Name = "lblUuidSustitucionCancelacion";
      this.lblUuidSustitucionCancelacion.Size = new System.Drawing.Size(105, 13);
      this.lblUuidSustitucionCancelacion.TabIndex = 6;
      this.lblUuidSustitucionCancelacion.Text = "UUID Sustitución";
      // 
      // lblMotivoCancelacion
      // 
      this.lblMotivoCancelacion.AutoSize = true;
      this.lblMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMotivoCancelacion.Location = new System.Drawing.Point(5, 61);
      this.lblMotivoCancelacion.Name = "lblMotivoCancelacion";
      this.lblMotivoCancelacion.Size = new System.Drawing.Size(45, 13);
      this.lblMotivoCancelacion.TabIndex = 4;
      this.lblMotivoCancelacion.Text = "Motivo";
      // 
      // txtUuidSustitucionCancelacion
      // 
      this.txtUuidSustitucionCancelacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUuidSustitucionCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUuidSustitucionCancelacion.Location = new System.Drawing.Point(116, 84);
      this.txtUuidSustitucionCancelacion.MaxLength = 36;
      this.txtUuidSustitucionCancelacion.Name = "txtUuidSustitucionCancelacion";
      this.txtUuidSustitucionCancelacion.Size = new System.Drawing.Size(487, 20);
      this.txtUuidSustitucionCancelacion.TabIndex = 7;
      // 
      // txtMotivoCancelacion
      // 
      this.txtMotivoCancelacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMotivoCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtMotivoCancelacion.Location = new System.Drawing.Point(116, 58);
      this.txtMotivoCancelacion.MaxLength = 36;
      this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
      this.txtMotivoCancelacion.Size = new System.Drawing.Size(487, 20);
      this.txtMotivoCancelacion.TabIndex = 5;
      // 
      // lblRfcEmisorCancelacion
      // 
      this.lblRfcEmisorCancelacion.AutoSize = true;
      this.lblRfcEmisorCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRfcEmisorCancelacion.Location = new System.Drawing.Point(5, 9);
      this.lblRfcEmisorCancelacion.Name = "lblRfcEmisorCancelacion";
      this.lblRfcEmisorCancelacion.Size = new System.Drawing.Size(71, 13);
      this.lblRfcEmisorCancelacion.TabIndex = 0;
      this.lblRfcEmisorCancelacion.Text = "RFC emisor";
      // 
      // txtUuidCancelacion
      // 
      this.txtUuidCancelacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUuidCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUuidCancelacion.Location = new System.Drawing.Point(116, 32);
      this.txtUuidCancelacion.MaxLength = 36;
      this.txtUuidCancelacion.Name = "txtUuidCancelacion";
      this.txtUuidCancelacion.Size = new System.Drawing.Size(487, 20);
      this.txtUuidCancelacion.TabIndex = 3;
      // 
      // txtRfcEmisorCancelacion
      // 
      this.txtRfcEmisorCancelacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRfcEmisorCancelacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRfcEmisorCancelacion.Location = new System.Drawing.Point(116, 6);
      this.txtRfcEmisorCancelacion.MaxLength = 13;
      this.txtRfcEmisorCancelacion.Name = "txtRfcEmisorCancelacion";
      this.txtRfcEmisorCancelacion.Size = new System.Drawing.Size(487, 20);
      this.txtRfcEmisorCancelacion.TabIndex = 1;
      // 
      // lblUuidCancelacion
      // 
      this.lblUuidCancelacion.AutoSize = true;
      this.lblUuidCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUuidCancelacion.Location = new System.Drawing.Point(5, 35);
      this.lblUuidCancelacion.Name = "lblUuidCancelacion";
      this.lblUuidCancelacion.Size = new System.Drawing.Size(38, 13);
      this.lblUuidCancelacion.TabIndex = 2;
      this.lblUuidCancelacion.Text = "UUID";
      // 
      // redtCancelacion
      // 
      this.redtCancelacion.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.redtCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtCancelacion.Location = new System.Drawing.Point(3, 133);
      this.redtCancelacion.Name = "redtCancelacion";
      this.redtCancelacion.ReadOnly = true;
      this.redtCancelacion.Size = new System.Drawing.Size(605, 120);
      this.redtCancelacion.TabIndex = 8;
      this.redtCancelacion.Text = resources.GetString("redtCancelacion.Text");
      // 
      // tshTimbrado
      // 
      this.tshTimbrado.Controls.Add(this.redtTimbrado);
      this.tshTimbrado.Location = new System.Drawing.Point(4, 22);
      this.tshTimbrado.Name = "tshTimbrado";
      this.tshTimbrado.Padding = new System.Windows.Forms.Padding(3);
      this.tshTimbrado.Size = new System.Drawing.Size(611, 256);
      this.tshTimbrado.TabIndex = 3;
      this.tshTimbrado.Text = "Timbrado";
      this.tshTimbrado.UseVisualStyleBackColor = true;
      // 
      // redtTimbrado
      // 
      this.redtTimbrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.redtTimbrado.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtTimbrado.Location = new System.Drawing.Point(3, 3);
      this.redtTimbrado.Name = "redtTimbrado";
      this.redtTimbrado.ReadOnly = true;
      this.redtTimbrado.Size = new System.Drawing.Size(605, 250);
      this.redtTimbrado.TabIndex = 2;
      this.redtTimbrado.Text = resources.GetString("redtTimbrado.Text");
      // 
      // pgcInformacion
      // 
      this.pgcInformacion.Controls.Add(this.tshTimbrado);
      this.pgcInformacion.Controls.Add(this.tshSolicitudCancelacion);
      this.pgcInformacion.Controls.Add(this.tshAcuseSolicitudCancelacion);
      this.pgcInformacion.Controls.Add(this.tshDescargarXml);
      this.pgcInformacion.Controls.Add(this.tshConstanciaRetenciones);
      this.pgcInformacion.Controls.Add(this.tshFechaHora);
      this.pgcInformacion.Controls.Add(this.tshEstadoCuenta);
      this.pgcInformacion.Controls.Add(this.tshParametros);
      this.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcInformacion.Location = new System.Drawing.Point(0, 82);
      this.pgcInformacion.Name = "pgcInformacion";
      this.pgcInformacion.SelectedIndex = 0;
      this.pgcInformacion.Size = new System.Drawing.Size(619, 282);
      this.pgcInformacion.TabIndex = 3;
      this.pgcInformacion.TabStop = false;
      // 
      // tshAcuseSolicitudCancelacion
      // 
      this.tshAcuseSolicitudCancelacion.Controls.Add(this.lblRfcEmisorAcuse);
      this.tshAcuseSolicitudCancelacion.Controls.Add(this.txtUuidAcuse);
      this.tshAcuseSolicitudCancelacion.Controls.Add(this.txtRfcEmisorAcuse);
      this.tshAcuseSolicitudCancelacion.Controls.Add(this.lblUuidAcuse);
      this.tshAcuseSolicitudCancelacion.Controls.Add(this.richTextBox1);
      this.tshAcuseSolicitudCancelacion.Location = new System.Drawing.Point(4, 22);
      this.tshAcuseSolicitudCancelacion.Name = "tshAcuseSolicitudCancelacion";
      this.tshAcuseSolicitudCancelacion.Padding = new System.Windows.Forms.Padding(3);
      this.tshAcuseSolicitudCancelacion.Size = new System.Drawing.Size(611, 256);
      this.tshAcuseSolicitudCancelacion.TabIndex = 9;
      this.tshAcuseSolicitudCancelacion.Text = "Acuse de la solicitud de cancelación";
      this.tshAcuseSolicitudCancelacion.UseVisualStyleBackColor = true;
      // 
      // lblRfcEmisorAcuse
      // 
      this.lblRfcEmisorAcuse.AutoSize = true;
      this.lblRfcEmisorAcuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRfcEmisorAcuse.Location = new System.Drawing.Point(3, 13);
      this.lblRfcEmisorAcuse.Name = "lblRfcEmisorAcuse";
      this.lblRfcEmisorAcuse.Size = new System.Drawing.Size(71, 13);
      this.lblRfcEmisorAcuse.TabIndex = 19;
      this.lblRfcEmisorAcuse.Text = "RFC emisor";
      // 
      // txtUuidAcuse
      // 
      this.txtUuidAcuse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUuidAcuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtUuidAcuse.Location = new System.Drawing.Point(80, 36);
      this.txtUuidAcuse.MaxLength = 36;
      this.txtUuidAcuse.Name = "txtUuidAcuse";
      this.txtUuidAcuse.Size = new System.Drawing.Size(526, 20);
      this.txtUuidAcuse.TabIndex = 22;
      // 
      // txtRfcEmisorAcuse
      // 
      this.txtRfcEmisorAcuse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRfcEmisorAcuse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtRfcEmisorAcuse.Location = new System.Drawing.Point(80, 10);
      this.txtRfcEmisorAcuse.MaxLength = 13;
      this.txtRfcEmisorAcuse.Name = "txtRfcEmisorAcuse";
      this.txtRfcEmisorAcuse.Size = new System.Drawing.Size(526, 20);
      this.txtRfcEmisorAcuse.TabIndex = 20;
      // 
      // lblUuidAcuse
      // 
      this.lblUuidAcuse.AutoSize = true;
      this.lblUuidAcuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUuidAcuse.Location = new System.Drawing.Point(3, 39);
      this.lblUuidAcuse.Name = "lblUuidAcuse";
      this.lblUuidAcuse.Size = new System.Drawing.Size(38, 13);
      this.lblUuidAcuse.TabIndex = 21;
      this.lblUuidAcuse.Text = "UUID";
      // 
      // richTextBox1
      // 
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.richTextBox1.Location = new System.Drawing.Point(3, 105);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.Size = new System.Drawing.Size(605, 148);
      this.richTextBox1.TabIndex = 18;
      this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
      // 
      // tshConstanciaRetenciones
      // 
      this.tshConstanciaRetenciones.Controls.Add(this.redtConstanciaRetenciones);
      this.tshConstanciaRetenciones.Location = new System.Drawing.Point(4, 22);
      this.tshConstanciaRetenciones.Name = "tshConstanciaRetenciones";
      this.tshConstanciaRetenciones.Padding = new System.Windows.Forms.Padding(3);
      this.tshConstanciaRetenciones.Size = new System.Drawing.Size(611, 256);
      this.tshConstanciaRetenciones.TabIndex = 10;
      this.tshConstanciaRetenciones.Text = "Constancia de retenciones";
      this.tshConstanciaRetenciones.UseVisualStyleBackColor = true;
      // 
      // redtConstanciaRetenciones
      // 
      this.redtConstanciaRetenciones.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtConstanciaRetenciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtConstanciaRetenciones.Location = new System.Drawing.Point(3, 3);
      this.redtConstanciaRetenciones.Name = "redtConstanciaRetenciones";
      this.redtConstanciaRetenciones.ReadOnly = true;
      this.redtConstanciaRetenciones.Size = new System.Drawing.Size(605, 250);
      this.redtConstanciaRetenciones.TabIndex = 2;
      this.redtConstanciaRetenciones.Text = resources.GetString("redtConstanciaRetenciones.Text");
      // 
      // tshFechaHora
      // 
      this.tshFechaHora.Controls.Add(this.redFechaHora);
      this.tshFechaHora.Location = new System.Drawing.Point(4, 22);
      this.tshFechaHora.Name = "tshFechaHora";
      this.tshFechaHora.Padding = new System.Windows.Forms.Padding(3);
      this.tshFechaHora.Size = new System.Drawing.Size(611, 256);
      this.tshFechaHora.TabIndex = 8;
      this.tshFechaHora.Text = "Fecha y Hora del PAC";
      this.tshFechaHora.UseVisualStyleBackColor = true;
      // 
      // redFechaHora
      // 
      this.redFechaHora.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redFechaHora.Location = new System.Drawing.Point(3, 3);
      this.redFechaHora.Name = "redFechaHora";
      this.redFechaHora.ReadOnly = true;
      this.redFechaHora.Size = new System.Drawing.Size(605, 250);
      this.redFechaHora.TabIndex = 3;
      this.redFechaHora.Text = "En este ejemplo se demuestra \n\n    •  Cómo obtener la fecha y hora del PAC.\n\nTodo" +
    " lo anterior es ejecutado en el método ObtenerFechaHora()";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 386);
      this.Controls.Add(this.pgcInformacion);
      this.Controls.Add(this.pnlOperaciones);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Integración con un PAC - ECodex";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.pnlOperaciones.ResumeLayout(false);
      this.pnlOperaciones.PerformLayout();
      this.tshParametros.ResumeLayout(false);
      this.tshParametros.PerformLayout();
      this.tshEstadoCuenta.ResumeLayout(false);
      this.tshEstadoCuenta.PerformLayout();
      this.tshDescargarXml.ResumeLayout(false);
      this.tshDescargarXml.PerformLayout();
      this.tshSolicitudCancelacion.ResumeLayout(false);
      this.tshSolicitudCancelacion.PerformLayout();
      this.tshTimbrado.ResumeLayout(false);
      this.pgcInformacion.ResumeLayout(false);
      this.tshAcuseSolicitudCancelacion.ResumeLayout(false);
      this.tshAcuseSolicitudCancelacion.PerformLayout();
      this.tshConstanciaRetenciones.ResumeLayout(false);
      this.tshFechaHora.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.Panel pnlOperaciones;
    private System.Windows.Forms.Label lblOperacion;
    private System.Windows.Forms.ComboBox cbbOperacion;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.TabPage tshParametros;
    private System.Windows.Forms.TabPage tshEstadoCuenta;
    private System.Windows.Forms.RichTextBox redtEstadoCuenta;
    private System.Windows.Forms.TabPage tshDescargarXml;
    private System.Windows.Forms.TextBox txtUuidDescargaCfdi;
    private System.Windows.Forms.RichTextBox redtDescargarCfdi;
    private System.Windows.Forms.Label lblUuidDescargaCfdi;
    private System.Windows.Forms.TabPage tshSolicitudCancelacion;
    private System.Windows.Forms.RichTextBox redtCancelacion;
    private System.Windows.Forms.TabPage tshTimbrado;
    private System.Windows.Forms.RichTextBox redtTimbrado;
    private System.Windows.Forms.TabControl pgcInformacion;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.TabPage tshFechaHora;
    private System.Windows.Forms.RichTextBox redFechaHora;
    private System.Windows.Forms.TabPage tshAcuseSolicitudCancelacion;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TabPage tshConstanciaRetenciones;
    private System.Windows.Forms.RichTextBox redtConstanciaRetenciones;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
    private System.Windows.Forms.CheckBox chkUseHttps;
    private System.Windows.Forms.TextBox txtRfcEmpresa;
    private System.Windows.Forms.Label lblRfcEmpresa;
    private System.Windows.Forms.Label lblRfcEmisorCancelacion;
    private System.Windows.Forms.TextBox txtUuidCancelacion;
    private System.Windows.Forms.TextBox txtRfcEmisorCancelacion;
    private System.Windows.Forms.Label lblUuidCancelacion;
    private System.Windows.Forms.Label lblRfcEmisorDescarga;
    private System.Windows.Forms.TextBox txtRfcEmisorDescarga;
    private System.Windows.Forms.Label lblRfcEmisorAcuse;
    private System.Windows.Forms.TextBox txtUuidAcuse;
    private System.Windows.Forms.TextBox txtRfcEmisorAcuse;
    private System.Windows.Forms.Label lblUuidAcuse;
    private System.Windows.Forms.Label lblEnviroment;
    private System.Windows.Forms.ComboBox cbbEnviroment;
    private System.Windows.Forms.Label lblMotivoCancelacion;
    private System.Windows.Forms.TextBox txtUuidSustitucionCancelacion;
    private System.Windows.Forms.TextBox txtMotivoCancelacion;
    private System.Windows.Forms.Label lblUuidSustitucionCancelacion;
    private System.Windows.Forms.CheckBox chkOtroPac;
  }
}
