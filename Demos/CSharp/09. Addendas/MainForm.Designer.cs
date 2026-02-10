namespace HyperSoft.Ejemplo.Adendas
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
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.pnlOptions = new System.Windows.Forms.Panel();
      this.btnXmlAddenda = new System.Windows.Forms.Button();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.lblTipo = new System.Windows.Forms.Label();
      this.cmbTipo = new System.Windows.Forms.ComboBox();
      this.redtSample1 = new System.Windows.Forms.RichTextBox();
      this.stb.SuspendLayout();
      this.pnlOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 356);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(784, 22);
      this.stb.TabIndex = 2;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(647, 17);
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
      // btnHelp
      // 
      this.btnHelp.Location = new System.Drawing.Point(551, 64);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(68, 21);
      this.btnHelp.TabIndex = 4;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(704, 64);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(68, 21);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(551, 10);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(68, 21);
      this.btnExecute.TabIndex = 2;
      this.btnExecute.Text = "&Generar";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Location = new System.Drawing.Point(625, 64);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(73, 21);
      this.btnAbout.TabIndex = 5;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // pnlOptions
      // 
      this.pnlOptions.Controls.Add(this.btnXmlAddenda);
      this.pnlOptions.Controls.Add(this.btnTimbrado);
      this.pnlOptions.Controls.Add(this.btnClose);
      this.pnlOptions.Controls.Add(this.btnHelp);
      this.pnlOptions.Controls.Add(this.lblTipo);
      this.pnlOptions.Controls.Add(this.btnAbout);
      this.pnlOptions.Controls.Add(this.cmbTipo);
      this.pnlOptions.Controls.Add(this.btnExecute);
      this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlOptions.Location = new System.Drawing.Point(0, 0);
      this.pnlOptions.Name = "pnlOptions";
      this.pnlOptions.Size = new System.Drawing.Size(784, 91);
      this.pnlOptions.TabIndex = 0;
      // 
      // btnXmlAddenda
      // 
      this.btnXmlAddenda.Location = new System.Drawing.Point(625, 10);
      this.btnXmlAddenda.Name = "btnXmlAddenda";
      this.btnXmlAddenda.Size = new System.Drawing.Size(147, 21);
      this.btnXmlAddenda.TabIndex = 8;
      this.btnXmlAddenda.Text = "&Agregar a un XML";
      this.btnXmlAddenda.UseVisualStyleBackColor = true;
      this.btnXmlAddenda.Click += new System.EventHandler(this.btnXmlAddenda_Click);
      // 
      // btnTimbrado
      // 
      this.btnTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimbrado.Location = new System.Drawing.Point(551, 37);
      this.btnTimbrado.Name = "btnTimbrado";
      this.btnTimbrado.Size = new System.Drawing.Size(221, 21);
      this.btnTimbrado.TabIndex = 3;
      this.btnTimbrado.Text = "Servicio de Timbrado";
      this.btnTimbrado.UseVisualStyleBackColor = true;
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Location = new System.Drawing.Point(12, 15);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(28, 13);
      this.lblTipo.TabIndex = 0;
      this.lblTipo.Text = "Tipo";
      // 
      // cmbTipo
      // 
      this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Items.AddRange(new object[] {
            "Aba Seguros",
            "Ado",
            "AlSuper",
            "Altos Hornos de México",
            "Amece",
            "Asociación mexicana de instituciones de seguros AMIS",
            "Axxa - Autos",
            "Axxa - Gastos médicos",
            "BrudiFarma",
            "Capa de ozono",
            "Chrysler",
            "Coppel - Ropa",
            "Disney",
            "Envases universales de méxico",
            "Femsa",
            "Grupo Modelo",
            "Inbursa",
            "Landsteiner",
            "Mabe",
            "MultiPack",
            "Oxxo",
            "Pemex - Exploración",
            "Pemex - Refinación",
            "Pilgrims",
            "Prolec",
            "Sanmina",
            "Sector Primario",
            "Soler & Palau",
            "Tiendas neto",
            "Trasnsportes castores"});
      this.cmbTipo.Location = new System.Drawing.Point(46, 12);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new System.Drawing.Size(499, 21);
      this.cmbTipo.TabIndex = 1;
      this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
      // 
      // redtSample1
      // 
      this.redtSample1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtSample1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtSample1.Location = new System.Drawing.Point(0, 91);
      this.redtSample1.Name = "redtSample1";
      this.redtSample1.ReadOnly = true;
      this.redtSample1.Size = new System.Drawing.Size(784, 265);
      this.redtSample1.TabIndex = 1;
      this.redtSample1.Text = resources.GetString("redtSample1.Text");
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 378);
      this.Controls.Add(this.redtSample1);
      this.Controls.Add(this.pnlOptions);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MinimumSize = new System.Drawing.Size(800, 400);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Generación de adenda";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.pnlOptions.ResumeLayout(false);
      this.pnlOptions.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Panel pnlOptions;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.ComboBox cmbTipo;
    private System.Windows.Forms.RichTextBox redtSample1;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.Button btnXmlAddenda;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}