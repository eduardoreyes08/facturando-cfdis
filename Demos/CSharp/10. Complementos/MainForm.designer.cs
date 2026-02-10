namespace HyperSoft.Ejemplo.Complementos
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.pnlDatos = new System.Windows.Forms.Panel();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.cmbComplemento = new System.Windows.Forms.ComboBox();
      this.lblComplemento = new System.Windows.Forms.Label();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.redtText = new System.Windows.Forms.RichTextBox();
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlDatos.SuspendLayout();
      this.panel2.SuspendLayout();
      this.stb.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlDatos
      // 
      this.pnlDatos.Controls.Add(this.btnTimbrado);
      this.pnlDatos.Controls.Add(this.cmbComplemento);
      this.pnlDatos.Controls.Add(this.lblComplemento);
      this.pnlDatos.Controls.Add(this.btnHelp);
      this.pnlDatos.Controls.Add(this.btnClose);
      this.pnlDatos.Controls.Add(this.btnExecute);
      this.pnlDatos.Controls.Add(this.btnAbout);
      this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlDatos.Location = new System.Drawing.Point(0, 0);
      this.pnlDatos.Name = "pnlDatos";
      this.pnlDatos.Size = new System.Drawing.Size(700, 71);
      this.pnlDatos.TabIndex = 0;
      // 
      // btnTimbrado
      // 
      this.btnTimbrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimbrado.Location = new System.Drawing.Point(532, 7);
      this.btnTimbrado.Name = "btnTimbrado";
      this.btnTimbrado.Size = new System.Drawing.Size(156, 23);
      this.btnTimbrado.TabIndex = 3;
      this.btnTimbrado.Text = "Servicio de Timbrado";
      this.btnTimbrado.UseVisualStyleBackColor = true;
      // 
      // cmbComplemento
      // 
      this.cmbComplemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbComplemento.FormattingEnabled = true;
      this.cmbComplemento.Items.AddRange(new object[] {
            "DOCUMENTO",
            "  - Aerolíneas 1.0",
            "  - Certificado de destrucción 1.0",
            "  - CFDI registro fiscal 1.0",
            "  - Comercio exterior 2.0",
            "  - Consumo de combustible 1.1",
            "  - Detallista 1.3.1",
            "  - Divisas 1.0",
            "  - Donatarias 1.1",
            "  - Estado de cuenta de combustible 1.2",
            "  - Hidrocarburos - Gastos  1.0",
            "  - Hidrocarburos - Ingresos  1.0",
            "  - Impuestos locales 1.0",
            "  - INE 1.1",
            "  - Leyenda fiscal 1.0",
            "  - Notarios públicos 1.0",
            "  - Obras, artes y antiguedades 1.0",
            "  - Pago en especie 1.0",
            "  - Persona física integrante coordinado 1.0",
            "  - Renovación y sustitución vehicular 1.0",
            "  - Servicios parciales de construcción 1.0",
            "  - Turista pasajero extranjero 1.0",
            "  - Vales de despensa 1.0",
            "  - Vehículo usado 1.0",
            "CONCEPTO",
            "  - Instituciones educativas privadas 1.0",
            "  - Venta vehicular 1.1"});
      this.cmbComplemento.Location = new System.Drawing.Point(106, 9);
      this.cmbComplemento.Name = "cmbComplemento";
      this.cmbComplemento.Size = new System.Drawing.Size(334, 21);
      this.cmbComplemento.TabIndex = 1;
      this.cmbComplemento.SelectedIndexChanged += new System.EventHandler(this.cmbComplemento_SelectedIndexChanged);
      // 
      // lblComplemento
      // 
      this.lblComplemento.AutoSize = true;
      this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblComplemento.Location = new System.Drawing.Point(12, 9);
      this.lblComplemento.Name = "lblComplemento";
      this.lblComplemento.Size = new System.Drawing.Size(88, 13);
      this.lblComplemento.TabIndex = 0;
      this.lblComplemento.Text = "Complementos";
      // 
      // btnHelp
      // 
      this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnHelp.Location = new System.Drawing.Point(532, 36);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 23);
      this.btnHelp.TabIndex = 5;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(613, 36);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExecute.Location = new System.Drawing.Point(451, 7);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 23);
      this.btnExecute.TabIndex = 2;
      this.btnExecute.Text = "&Generar";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbout.Location = new System.Drawing.Point(451, 36);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(75, 23);
      this.btnAbout.TabIndex = 4;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.redtText);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 71);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(700, 367);
      this.panel2.TabIndex = 3;
      // 
      // redtText
      // 
      this.redtText.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtText.Location = new System.Drawing.Point(0, 0);
      this.redtText.Name = "redtText";
      this.redtText.ReadOnly = true;
      this.redtText.Size = new System.Drawing.Size(700, 367);
      this.redtText.TabIndex = 9;
      this.redtText.Text = resources.GetString("redtText.Text");
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 438);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(700, 22);
      this.stb.TabIndex = 11;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(563, 17);
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
      // MainForm
      // 
      this.AcceptButton = this.btnExecute;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(700, 460);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.pnlDatos);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MinimumSize = new System.Drawing.Size(648, 484);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ejemplo de la generación de un CFDI con complemento";
      this.pnlDatos.ResumeLayout(false);
      this.pnlDatos.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlDatos;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.ComboBox cmbComplemento;
    private System.Windows.Forms.Label lblComplemento;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.RichTextBox redtText;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}

