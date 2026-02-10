namespace HyperSoft.Ejemplo.ContabilidadElectronica
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
      this.pnlOperaciones = new System.Windows.Forms.Panel();
      this.chkGenerarZip = new System.Windows.Forms.CheckBox();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.lblOperacion = new System.Windows.Forms.Label();
      this.cmbOperacion = new System.Windows.Forms.ComboBox();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pgcInformacion = new System.Windows.Forms.TabControl();
      this.tshCatalogo = new System.Windows.Forms.TabPage();
      this.redtCatalogo = new System.Windows.Forms.RichTextBox();
      this.tshBalanza = new System.Windows.Forms.TabPage();
      this.redtBalanza = new System.Windows.Forms.RichTextBox();
      this.tshPoliza = new System.Windows.Forms.TabPage();
      this.redtPoliza = new System.Windows.Forms.RichTextBox();
      this.tshAuxiliarFolios = new System.Windows.Forms.TabPage();
      this.redtAuxiliarFolios = new System.Windows.Forms.RichTextBox();
      this.tshAuxiliarCuentas = new System.Windows.Forms.TabPage();
      this.redtAuxiliarCuentas = new System.Windows.Forms.RichTextBox();
      this.tshSelloDigital = new System.Windows.Forms.TabPage();
      this.redtSelloDigital = new System.Windows.Forms.RichTextBox();
      this.pnlOperaciones.SuspendLayout();
      this.stb.SuspendLayout();
      this.pgcInformacion.SuspendLayout();
      this.tshCatalogo.SuspendLayout();
      this.tshBalanza.SuspendLayout();
      this.tshPoliza.SuspendLayout();
      this.tshAuxiliarFolios.SuspendLayout();
      this.tshAuxiliarCuentas.SuspendLayout();
      this.tshSelloDigital.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlOperaciones
      // 
      this.pnlOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlOperaciones.Controls.Add(this.chkGenerarZip);
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
      this.pnlOperaciones.Size = new System.Drawing.Size(692, 76);
      this.pnlOperaciones.TabIndex = 1;
      // 
      // chkGenerarZip
      // 
      this.chkGenerarZip.AutoSize = true;
      this.chkGenerarZip.Checked = true;
      this.chkGenerarZip.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkGenerarZip.Location = new System.Drawing.Point(160, 42);
      this.chkGenerarZip.Name = "chkGenerarZip";
      this.chkGenerarZip.Size = new System.Drawing.Size(122, 17);
      this.chkGenerarZip.TabIndex = 9;
      this.chkGenerarZip.Text = "Generar archivo ZIP";
      this.chkGenerarZip.UseVisualStyleBackColor = true;
      // 
      // btnTimbrado
      // 
      this.btnTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimbrado.Location = new System.Drawing.Point(529, 12);
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
      this.lblOperacion.Location = new System.Drawing.Point(3, 12);
      this.lblOperacion.Name = "lblOperacion";
      this.lblOperacion.Size = new System.Drawing.Size(155, 13);
      this.lblOperacion.TabIndex = 4;
      this.lblOperacion.Text = "Seleccione una operación";
      // 
      // cmbOperacion
      // 
      this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbOperacion.FormattingEnabled = true;
      this.cmbOperacion.Items.AddRange(new object[] {
            "Catálogo de cuentas contables",
            "Balanza de comprobación",
            "Pólizas del periodo",
            "Reporte auxiliar de folios",
            "Reporte auxiliar de cuentas y/o subcuentas"});
      this.cmbOperacion.Location = new System.Drawing.Point(160, 12);
      this.cmbOperacion.Name = "cmbOperacion";
      this.cmbOperacion.Size = new System.Drawing.Size(282, 21);
      this.cmbOperacion.TabIndex = 5;
      this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
      // 
      // btnHelp
      // 
      this.btnHelp.Location = new System.Drawing.Point(529, 39);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 21);
      this.btnHelp.TabIndex = 7;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(610, 39);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 21);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(448, 12);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 21);
      this.btnExecute.TabIndex = 2;
      this.btnExecute.Text = "&Ejecutar";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Location = new System.Drawing.Point(448, 39);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(75, 21);
      this.btnAbout.TabIndex = 6;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 440);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(692, 22);
      this.stb.SizingGrip = false;
      this.stb.TabIndex = 2;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(555, 17);
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
      // pgcInformacion
      // 
      this.pgcInformacion.Controls.Add(this.tshCatalogo);
      this.pgcInformacion.Controls.Add(this.tshBalanza);
      this.pgcInformacion.Controls.Add(this.tshPoliza);
      this.pgcInformacion.Controls.Add(this.tshAuxiliarFolios);
      this.pgcInformacion.Controls.Add(this.tshAuxiliarCuentas);
      this.pgcInformacion.Controls.Add(this.tshSelloDigital);
      this.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcInformacion.Location = new System.Drawing.Point(0, 76);
      this.pgcInformacion.Name = "pgcInformacion";
      this.pgcInformacion.SelectedIndex = 0;
      this.pgcInformacion.Size = new System.Drawing.Size(692, 364);
      this.pgcInformacion.TabIndex = 4;
      // 
      // tshCatalogo
      // 
      this.tshCatalogo.Controls.Add(this.redtCatalogo);
      this.tshCatalogo.Location = new System.Drawing.Point(4, 22);
      this.tshCatalogo.Name = "tshCatalogo";
      this.tshCatalogo.Padding = new System.Windows.Forms.Padding(3);
      this.tshCatalogo.Size = new System.Drawing.Size(684, 338);
      this.tshCatalogo.TabIndex = 3;
      this.tshCatalogo.Text = "Catálogo";
      this.tshCatalogo.UseVisualStyleBackColor = true;
      // 
      // redtCatalogo
      // 
      this.redtCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtCatalogo.Location = new System.Drawing.Point(3, 3);
      this.redtCatalogo.Name = "redtCatalogo";
      this.redtCatalogo.ReadOnly = true;
      this.redtCatalogo.Size = new System.Drawing.Size(678, 332);
      this.redtCatalogo.TabIndex = 1;
      this.redtCatalogo.Text = "En este ejemplo se demuestra la generación del archivo XML de las cuentas contabl" +
    "es.\n\nTodo lo anterior es ejecutado en el método CreateCatalogo()";
      // 
      // tshBalanza
      // 
      this.tshBalanza.Controls.Add(this.redtBalanza);
      this.tshBalanza.Location = new System.Drawing.Point(4, 22);
      this.tshBalanza.Name = "tshBalanza";
      this.tshBalanza.Padding = new System.Windows.Forms.Padding(3);
      this.tshBalanza.Size = new System.Drawing.Size(684, 338);
      this.tshBalanza.TabIndex = 0;
      this.tshBalanza.Text = "Balanza";
      this.tshBalanza.UseVisualStyleBackColor = true;
      // 
      // redtBalanza
      // 
      this.redtBalanza.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtBalanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtBalanza.Location = new System.Drawing.Point(3, 3);
      this.redtBalanza.Name = "redtBalanza";
      this.redtBalanza.ReadOnly = true;
      this.redtBalanza.Size = new System.Drawing.Size(678, 332);
      this.redtBalanza.TabIndex = 0;
      this.redtBalanza.Text = "En este ejemplo se demuestra la generación del archivo XML de la balanza de compr" +
    "obación.\n\nTodo lo anterior es ejecutado en el método CreateBalanza()";
      // 
      // tshPoliza
      // 
      this.tshPoliza.Controls.Add(this.redtPoliza);
      this.tshPoliza.Location = new System.Drawing.Point(4, 22);
      this.tshPoliza.Name = "tshPoliza";
      this.tshPoliza.Padding = new System.Windows.Forms.Padding(3);
      this.tshPoliza.Size = new System.Drawing.Size(684, 338);
      this.tshPoliza.TabIndex = 8;
      this.tshPoliza.Text = "Póliza";
      this.tshPoliza.UseVisualStyleBackColor = true;
      // 
      // redtPoliza
      // 
      this.redtPoliza.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtPoliza.Location = new System.Drawing.Point(3, 3);
      this.redtPoliza.Name = "redtPoliza";
      this.redtPoliza.ReadOnly = true;
      this.redtPoliza.Size = new System.Drawing.Size(678, 332);
      this.redtPoliza.TabIndex = 2;
      this.redtPoliza.Text = resources.GetString("redtPoliza.Text");
      // 
      // tshAuxiliarFolios
      // 
      this.tshAuxiliarFolios.Controls.Add(this.redtAuxiliarFolios);
      this.tshAuxiliarFolios.Location = new System.Drawing.Point(4, 22);
      this.tshAuxiliarFolios.Name = "tshAuxiliarFolios";
      this.tshAuxiliarFolios.Padding = new System.Windows.Forms.Padding(3);
      this.tshAuxiliarFolios.Size = new System.Drawing.Size(684, 338);
      this.tshAuxiliarFolios.TabIndex = 9;
      this.tshAuxiliarFolios.Text = "Auxiliar de folios";
      this.tshAuxiliarFolios.UseVisualStyleBackColor = true;
      // 
      // redtAuxiliarFolios
      // 
      this.redtAuxiliarFolios.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtAuxiliarFolios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtAuxiliarFolios.Location = new System.Drawing.Point(3, 3);
      this.redtAuxiliarFolios.Name = "redtAuxiliarFolios";
      this.redtAuxiliarFolios.ReadOnly = true;
      this.redtAuxiliarFolios.Size = new System.Drawing.Size(678, 332);
      this.redtAuxiliarFolios.TabIndex = 2;
      this.redtAuxiliarFolios.Text = resources.GetString("redtAuxiliarFolios.Text");
      // 
      // tshAuxiliarCuentas
      // 
      this.tshAuxiliarCuentas.Controls.Add(this.redtAuxiliarCuentas);
      this.tshAuxiliarCuentas.Location = new System.Drawing.Point(4, 22);
      this.tshAuxiliarCuentas.Name = "tshAuxiliarCuentas";
      this.tshAuxiliarCuentas.Padding = new System.Windows.Forms.Padding(3);
      this.tshAuxiliarCuentas.Size = new System.Drawing.Size(684, 338);
      this.tshAuxiliarCuentas.TabIndex = 10;
      this.tshAuxiliarCuentas.Text = "Auxiliar de cuentas";
      this.tshAuxiliarCuentas.UseVisualStyleBackColor = true;
      // 
      // redtAuxiliarCuentas
      // 
      this.redtAuxiliarCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtAuxiliarCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtAuxiliarCuentas.Location = new System.Drawing.Point(3, 3);
      this.redtAuxiliarCuentas.Name = "redtAuxiliarCuentas";
      this.redtAuxiliarCuentas.ReadOnly = true;
      this.redtAuxiliarCuentas.Size = new System.Drawing.Size(678, 332);
      this.redtAuxiliarCuentas.TabIndex = 2;
      this.redtAuxiliarCuentas.Text = resources.GetString("redtAuxiliarCuentas.Text");
      // 
      // tshSelloDigital
      // 
      this.tshSelloDigital.Controls.Add(this.redtSelloDigital);
      this.tshSelloDigital.Location = new System.Drawing.Point(4, 22);
      this.tshSelloDigital.Name = "tshSelloDigital";
      this.tshSelloDigital.Padding = new System.Windows.Forms.Padding(3);
      this.tshSelloDigital.Size = new System.Drawing.Size(684, 338);
      this.tshSelloDigital.TabIndex = 11;
      this.tshSelloDigital.Text = "Sello digital";
      this.tshSelloDigital.UseVisualStyleBackColor = true;
      // 
      // redtSelloDigital
      // 
      this.redtSelloDigital.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtSelloDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtSelloDigital.Location = new System.Drawing.Point(3, 3);
      this.redtSelloDigital.Name = "redtSelloDigital";
      this.redtSelloDigital.ReadOnly = true;
      this.redtSelloDigital.Size = new System.Drawing.Size(678, 332);
      this.redtSelloDigital.TabIndex = 2;
      this.redtSelloDigital.Text = "En este ejemplo se demuestra la generación del archivo XML de las cuentas contabl" +
    "es.\n\nTodo lo anterior es ejecutado en el método CreateCatalogo()";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(692, 462);
      this.Controls.Add(this.pgcInformacion);
      this.Controls.Add(this.stb);
      this.Controls.Add(this.pnlOperaciones);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ejemplo de contabilidad electrónica";
      this.pnlOperaciones.ResumeLayout(false);
      this.pnlOperaciones.PerformLayout();
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.pgcInformacion.ResumeLayout(false);
      this.tshCatalogo.ResumeLayout(false);
      this.tshBalanza.ResumeLayout(false);
      this.tshPoliza.ResumeLayout(false);
      this.tshAuxiliarFolios.ResumeLayout(false);
      this.tshAuxiliarCuentas.ResumeLayout(false);
      this.tshSelloDigital.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlOperaciones;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.Label lblOperacion;
    private System.Windows.Forms.ComboBox cmbOperacion;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.TabControl pgcInformacion;
    private System.Windows.Forms.TabPage tshCatalogo;
    private System.Windows.Forms.RichTextBox redtCatalogo;
    private System.Windows.Forms.TabPage tshBalanza;
    private System.Windows.Forms.RichTextBox redtBalanza;
    private System.Windows.Forms.TabPage tshPoliza;
    private System.Windows.Forms.RichTextBox redtPoliza;
    private System.Windows.Forms.TabPage tshAuxiliarFolios;
    private System.Windows.Forms.RichTextBox redtAuxiliarFolios;
    private System.Windows.Forms.TabPage tshAuxiliarCuentas;
    private System.Windows.Forms.RichTextBox redtAuxiliarCuentas;
    private System.Windows.Forms.CheckBox chkGenerarZip;
    private System.Windows.Forms.TabPage tshSelloDigital;
    private System.Windows.Forms.RichTextBox redtSelloDigital;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}

