namespace HyperSoft.Ejemplo.Pax
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
      this.cmbOperacion = new System.Windows.Forms.ComboBox();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.tshParameters = new System.Windows.Forms.TabPage();
      this.txtIdentificador = new System.Windows.Forms.TextBox();
      this.lblIdentificador = new System.Windows.Forms.Label();
      this.chkPrueba = new System.Windows.Forms.CheckBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.lblUsuario = new System.Windows.Forms.Label();
      this.tshCancelacion = new System.Windows.Forms.TabPage();
      this.redtCancelacion = new System.Windows.Forms.RichTextBox();
      this.tshTimbrado = new System.Windows.Forms.TabPage();
      this.redtTimbrado = new System.Windows.Forms.RichTextBox();
      this.pgcInformacion = new System.Windows.Forms.TabControl();
      this.tshConstanciaRetenciones = new System.Windows.Forms.TabPage();
      this.redtConstanciaRetenciones = new System.Windows.Forms.RichTextBox();
      this.tshFechaHora = new System.Windows.Forms.TabPage();
      this.redFechaHora = new System.Windows.Forms.RichTextBox();
      this.stb.SuspendLayout();
      this.pnlOperaciones.SuspendLayout();
      this.tshParameters.SuspendLayout();
      this.tshCancelacion.SuspendLayout();
      this.tshTimbrado.SuspendLayout();
      this.pgcInformacion.SuspendLayout();
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
      this.stb.Location = new System.Drawing.Point(0, 321);
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
      this.pnlOperaciones.Controls.Add(this.cmbOperacion);
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
      // cmbOperacion
      // 
      this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOperacion.FormattingEnabled = true;
      this.cmbOperacion.Items.AddRange(new object[] {
            "Generar el timbre de un CFDI",
            "Constancia de retenciones y pagos",
            "Cancelar un CFDI",
            "Obtener la Fecha y Hora del PAC",
            "Parametros de conexión"});
      this.cmbOperacion.Location = new System.Drawing.Point(3, 24);
      this.cmbOperacion.Name = "cmbOperacion";
      this.cmbOperacion.Size = new System.Drawing.Size(360, 21);
      this.cmbOperacion.TabIndex = 1;
      this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.CmbOperacion_SelectedIndexChanged);
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
      // tshParameters
      // 
      this.tshParameters.Controls.Add(this.txtIdentificador);
      this.tshParameters.Controls.Add(this.lblIdentificador);
      this.tshParameters.Controls.Add(this.chkPrueba);
      this.tshParameters.Controls.Add(this.txtPassword);
      this.tshParameters.Controls.Add(this.lblPassword);
      this.tshParameters.Controls.Add(this.txtUsuario);
      this.tshParameters.Controls.Add(this.lblUsuario);
      this.tshParameters.Location = new System.Drawing.Point(4, 22);
      this.tshParameters.Name = "tshParameters";
      this.tshParameters.Padding = new System.Windows.Forms.Padding(3);
      this.tshParameters.Size = new System.Drawing.Size(611, 213);
      this.tshParameters.TabIndex = 4;
      this.tshParameters.Text = "Parámetros de conexión";
      this.tshParameters.UseVisualStyleBackColor = true;
      // 
      // txtIdentificador
      // 
      this.txtIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtIdentificador.Location = new System.Drawing.Point(88, 72);
      this.txtIdentificador.Name = "txtIdentificador";
      this.txtIdentificador.Size = new System.Drawing.Size(509, 20);
      this.txtIdentificador.TabIndex = 31;
      // 
      // lblIdentificador
      // 
      this.lblIdentificador.AutoSize = true;
      this.lblIdentificador.Location = new System.Drawing.Point(8, 75);
      this.lblIdentificador.Name = "lblIdentificador";
      this.lblIdentificador.Size = new System.Drawing.Size(65, 13);
      this.lblIdentificador.TabIndex = 30;
      this.lblIdentificador.Text = "Identificador";
      // 
      // chkPrueba
      // 
      this.chkPrueba.AutoSize = true;
      this.chkPrueba.Checked = true;
      this.chkPrueba.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkPrueba.Location = new System.Drawing.Point(88, 107);
      this.chkPrueba.Name = "chkPrueba";
      this.chkPrueba.Size = new System.Drawing.Size(147, 17);
      this.chkPrueba.TabIndex = 29;
      this.chkPrueba.Text = "Usar métodos de pruebas";
      this.chkPrueba.UseVisualStyleBackColor = true;
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(88, 46);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(509, 20);
      this.txtPassword.TabIndex = 23;
      this.txtPassword.Text = "wqfCr8O3xLfEhMOHw4nEjMSrxJnvv7bvvr4cVcKuKkBEM++/ke+/gCPvv4nvvrfvvaDvvb/vvqTvvoA=";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(8, 49);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(53, 13);
      this.lblPassword.TabIndex = 22;
      this.lblPassword.Text = "Password";
      // 
      // txtUsuario
      // 
      this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUsuario.Location = new System.Drawing.Point(88, 20);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(509, 20);
      this.txtUsuario.TabIndex = 23;
      this.txtUsuario.Text = "WSDL_PAX";
      // 
      // lblUsuario
      // 
      this.lblUsuario.AutoSize = true;
      this.lblUsuario.Location = new System.Drawing.Point(6, 23);
      this.lblUsuario.Name = "lblUsuario";
      this.lblUsuario.Size = new System.Drawing.Size(43, 13);
      this.lblUsuario.TabIndex = 22;
      this.lblUsuario.Text = "Usuario";
      // 
      // tshCancelacion
      // 
      this.tshCancelacion.Controls.Add(this.redtCancelacion);
      this.tshCancelacion.Location = new System.Drawing.Point(4, 22);
      this.tshCancelacion.Name = "tshCancelacion";
      this.tshCancelacion.Padding = new System.Windows.Forms.Padding(3);
      this.tshCancelacion.Size = new System.Drawing.Size(611, 213);
      this.tshCancelacion.TabIndex = 0;
      this.tshCancelacion.Text = "Cancelación";
      this.tshCancelacion.UseVisualStyleBackColor = true;
      // 
      // redtCancelacion
      // 
      this.redtCancelacion.Dock = System.Windows.Forms.DockStyle.Top;
      this.redtCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtCancelacion.Location = new System.Drawing.Point(3, 3);
      this.redtCancelacion.Name = "redtCancelacion";
      this.redtCancelacion.ReadOnly = true;
      this.redtCancelacion.Size = new System.Drawing.Size(605, 204);
      this.redtCancelacion.TabIndex = 0;
      this.redtCancelacion.Text = resources.GetString("redtCancelacion.Text");
      // 
      // tshTimbrado
      // 
      this.tshTimbrado.Controls.Add(this.redtTimbrado);
      this.tshTimbrado.Location = new System.Drawing.Point(4, 22);
      this.tshTimbrado.Name = "tshTimbrado";
      this.tshTimbrado.Padding = new System.Windows.Forms.Padding(3);
      this.tshTimbrado.Size = new System.Drawing.Size(611, 213);
      this.tshTimbrado.TabIndex = 3;
      this.tshTimbrado.Text = "Timbrado";
      this.tshTimbrado.UseVisualStyleBackColor = true;
      // 
      // redtTimbrado
      // 
      this.redtTimbrado.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtTimbrado.Location = new System.Drawing.Point(3, 3);
      this.redtTimbrado.Name = "redtTimbrado";
      this.redtTimbrado.ReadOnly = true;
      this.redtTimbrado.Size = new System.Drawing.Size(605, 207);
      this.redtTimbrado.TabIndex = 1;
      this.redtTimbrado.Text = resources.GetString("redtTimbrado.Text");
      // 
      // pgcInformacion
      // 
      this.pgcInformacion.Controls.Add(this.tshTimbrado);
      this.pgcInformacion.Controls.Add(this.tshConstanciaRetenciones);
      this.pgcInformacion.Controls.Add(this.tshCancelacion);
      this.pgcInformacion.Controls.Add(this.tshFechaHora);
      this.pgcInformacion.Controls.Add(this.tshParameters);
      this.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcInformacion.Location = new System.Drawing.Point(0, 82);
      this.pgcInformacion.Name = "pgcInformacion";
      this.pgcInformacion.SelectedIndex = 0;
      this.pgcInformacion.Size = new System.Drawing.Size(619, 239);
      this.pgcInformacion.TabIndex = 3;
      // 
      // tshConstanciaRetenciones
      // 
      this.tshConstanciaRetenciones.Controls.Add(this.redtConstanciaRetenciones);
      this.tshConstanciaRetenciones.Location = new System.Drawing.Point(4, 22);
      this.tshConstanciaRetenciones.Name = "tshConstanciaRetenciones";
      this.tshConstanciaRetenciones.Padding = new System.Windows.Forms.Padding(3);
      this.tshConstanciaRetenciones.Size = new System.Drawing.Size(611, 213);
      this.tshConstanciaRetenciones.TabIndex = 6;
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
      this.redtConstanciaRetenciones.Size = new System.Drawing.Size(605, 207);
      this.redtConstanciaRetenciones.TabIndex = 3;
      this.redtConstanciaRetenciones.Text = resources.GetString("redtConstanciaRetenciones.Text");
      // 
      // tshFechaHora
      // 
      this.tshFechaHora.Controls.Add(this.redFechaHora);
      this.tshFechaHora.Location = new System.Drawing.Point(4, 22);
      this.tshFechaHora.Name = "tshFechaHora";
      this.tshFechaHora.Padding = new System.Windows.Forms.Padding(3);
      this.tshFechaHora.Size = new System.Drawing.Size(611, 213);
      this.tshFechaHora.TabIndex = 5;
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
      this.redFechaHora.Size = new System.Drawing.Size(605, 207);
      this.redFechaHora.TabIndex = 2;
      this.redFechaHora.Text = "En este ejemplo se demuestra \n\n    •  Cómo obtener la fecha y hora del PAC.\n\nTodo" +
    " lo anterior es ejecutado en el método ObtenerFechaHora()";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 343);
      this.Controls.Add(this.pgcInformacion);
      this.Controls.Add(this.pnlOperaciones);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Integración con un PAC - PAX Facturación";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.pnlOperaciones.ResumeLayout(false);
      this.pnlOperaciones.PerformLayout();
      this.tshParameters.ResumeLayout(false);
      this.tshParameters.PerformLayout();
      this.tshCancelacion.ResumeLayout(false);
      this.tshTimbrado.ResumeLayout(false);
      this.pgcInformacion.ResumeLayout(false);
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
    private System.Windows.Forms.ComboBox cmbOperacion;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.TabPage tshParameters;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.TabPage tshCancelacion;
    private System.Windows.Forms.RichTextBox redtCancelacion;
    private System.Windows.Forms.TabPage tshTimbrado;
    private System.Windows.Forms.RichTextBox redtTimbrado;
    private System.Windows.Forms.TabControl pgcInformacion;
    private System.Windows.Forms.CheckBox chkPrueba;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.TextBox txtIdentificador;
    private System.Windows.Forms.Label lblIdentificador;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TabPage tshFechaHora;
    private System.Windows.Forms.RichTextBox redFechaHora;
    private System.Windows.Forms.TabPage tshConstanciaRetenciones;
    private System.Windows.Forms.RichTextBox redtConstanciaRetenciones;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}
