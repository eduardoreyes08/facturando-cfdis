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
      this.pgcDocumento = new System.Windows.Forms.TabControl();
      this.tshConstancia = new System.Windows.Forms.TabPage();
      this.redtConstancia = new System.Windows.Forms.RichTextBox();
      this.tshComplemento = new System.Windows.Forms.TabPage();
      this.redtComplemento = new System.Windows.Forms.RichTextBox();
      this.pnlDatos = new System.Windows.Forms.Panel();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.cmbTipo = new System.Windows.Forms.ComboBox();
      this.lblTipo = new System.Windows.Forms.Label();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pgcDocumento.SuspendLayout();
      this.tshConstancia.SuspendLayout();
      this.tshComplemento.SuspendLayout();
      this.pnlDatos.SuspendLayout();
      this.panel2.SuspendLayout();
      this.stb.SuspendLayout();
      this.SuspendLayout();
      // 
      // pgcDocumento
      // 
      this.pgcDocumento.Controls.Add(this.tshConstancia);
      this.pgcDocumento.Controls.Add(this.tshComplemento);
      this.pgcDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcDocumento.Location = new System.Drawing.Point(0, 0);
      this.pgcDocumento.Name = "pgcDocumento";
      this.pgcDocumento.SelectedIndex = 0;
      this.pgcDocumento.Size = new System.Drawing.Size(700, 367);
      this.pgcDocumento.TabIndex = 0;
      // 
      // tshConstancia
      // 
      this.tshConstancia.Controls.Add(this.redtConstancia);
      this.tshConstancia.Location = new System.Drawing.Point(4, 22);
      this.tshConstancia.Name = "tshConstancia";
      this.tshConstancia.Padding = new System.Windows.Forms.Padding(3);
      this.tshConstancia.Size = new System.Drawing.Size(692, 341);
      this.tshConstancia.TabIndex = 13;
      this.tshConstancia.Text = "Constancia";
      this.tshConstancia.UseVisualStyleBackColor = true;
      // 
      // redtConstancia
      // 
      this.redtConstancia.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtConstancia.Location = new System.Drawing.Point(3, 3);
      this.redtConstancia.Name = "redtConstancia";
      this.redtConstancia.ReadOnly = true;
      this.redtConstancia.Size = new System.Drawing.Size(686, 335);
      this.redtConstancia.TabIndex = 3;
      this.redtConstancia.Text = resources.GetString("redtConstancia.Text");
      // 
      // tshComplemento
      // 
      this.tshComplemento.Controls.Add(this.redtComplemento);
      this.tshComplemento.Location = new System.Drawing.Point(4, 22);
      this.tshComplemento.Name = "tshComplemento";
      this.tshComplemento.Padding = new System.Windows.Forms.Padding(3);
      this.tshComplemento.Size = new System.Drawing.Size(692, 341);
      this.tshComplemento.TabIndex = 14;
      this.tshComplemento.Text = "Complemento";
      this.tshComplemento.UseVisualStyleBackColor = true;
      // 
      // redtComplemento
      // 
      this.redtComplemento.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtComplemento.Location = new System.Drawing.Point(3, 3);
      this.redtComplemento.Name = "redtComplemento";
      this.redtComplemento.ReadOnly = true;
      this.redtComplemento.Size = new System.Drawing.Size(686, 335);
      this.redtComplemento.TabIndex = 3;
      this.redtComplemento.Text = resources.GetString("redtComplemento.Text");
      // 
      // pnlDatos
      // 
      this.pnlDatos.Controls.Add(this.btnTimbrado);
      this.pnlDatos.Controls.Add(this.cmbTipo);
      this.pnlDatos.Controls.Add(this.lblTipo);
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
      // cmbTipo
      // 
      this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbTipo.FormattingEnabled = true;
      this.cmbTipo.Items.AddRange(new object[] {
            "Constancia de retenciones 2.0",
            "  - Arrendamiento en fideicomiso",
            "  - Dividendos",
            "  - Enajenacion de acciones",
            "  - Fideicomiso no empresarial",
            "  - Intereses",
            "  - Intereses hipotecarios",
            "  - Operaciones con derivados",
            "  - Pagos a extranjeros",
            "  - Planes de retiro",
            "  - Plataformas técnologicas",
            "  - Premios",
            "  - Sector Financiero"});
      this.cmbTipo.Location = new System.Drawing.Point(106, 9);
      this.cmbTipo.Name = "cmbTipo";
      this.cmbTipo.Size = new System.Drawing.Size(334, 21);
      this.cmbTipo.TabIndex = 1;
      this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
      // 
      // lblTipo
      // 
      this.lblTipo.AutoSize = true;
      this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTipo.Location = new System.Drawing.Point(12, 9);
      this.lblTipo.Name = "lblTipo";
      this.lblTipo.Size = new System.Drawing.Size(32, 13);
      this.lblTipo.TabIndex = 0;
      this.lblTipo.Text = "Tipo";
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
      this.panel2.Controls.Add(this.pgcDocumento);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 71);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(700, 367);
      this.panel2.TabIndex = 3;
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
      this.Text = "Ejemplo de la generación de una constancia de retenciones y pagos 2.0";
      this.pgcDocumento.ResumeLayout(false);
      this.tshConstancia.ResumeLayout(false);
      this.tshComplemento.ResumeLayout(false);
      this.pnlDatos.ResumeLayout(false);
      this.pnlDatos.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl pgcDocumento;
    private System.Windows.Forms.Panel pnlDatos;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.ComboBox cmbTipo;
    private System.Windows.Forms.Label lblTipo;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.TabPage tshConstancia;
    private System.Windows.Forms.RichTextBox redtConstancia;
    private System.Windows.Forms.TabPage tshComplemento;
    private System.Windows.Forms.RichTextBox redtComplemento;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}

