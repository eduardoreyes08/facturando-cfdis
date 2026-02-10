namespace HyperSoft.Ejemplo.Cfdi40
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
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pgcInformacion = new System.Windows.Forms.TabControl();
      this.tshSample1 = new System.Windows.Forms.TabPage();
      this.redtSample1 = new System.Windows.Forms.RichTextBox();
      this.pblBotones = new System.Windows.Forms.Panel();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.stb.SuspendLayout();
      this.pgcInformacion.SuspendLayout();
      this.tshSample1.SuspendLayout();
      this.pblBotones.SuspendLayout();
      this.SuspendLayout();
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 427);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(806, 22);
      this.stb.TabIndex = 12;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(669, 17);
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
      // pgcInformacion
      // 
      this.pgcInformacion.Controls.Add(this.tshSample1);
      this.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcInformacion.Location = new System.Drawing.Point(0, 0);
      this.pgcInformacion.Name = "pgcInformacion";
      this.pgcInformacion.SelectedIndex = 0;
      this.pgcInformacion.Size = new System.Drawing.Size(806, 427);
      this.pgcInformacion.TabIndex = 14;
      // 
      // tshSample1
      // 
      this.tshSample1.Controls.Add(this.redtSample1);
      this.tshSample1.Controls.Add(this.pblBotones);
      this.tshSample1.Location = new System.Drawing.Point(4, 22);
      this.tshSample1.Name = "tshSample1";
      this.tshSample1.Padding = new System.Windows.Forms.Padding(3);
      this.tshSample1.Size = new System.Drawing.Size(798, 401);
      this.tshSample1.TabIndex = 0;
      this.tshSample1.Text = "Ejemplo 1";
      this.tshSample1.UseVisualStyleBackColor = true;
      // 
      // redtSample1
      // 
      this.redtSample1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtSample1.Location = new System.Drawing.Point(3, 3);
      this.redtSample1.Name = "redtSample1";
      this.redtSample1.ReadOnly = true;
      this.redtSample1.Size = new System.Drawing.Size(792, 349);
      this.redtSample1.TabIndex = 0;
      this.redtSample1.Text = "En este ejemplo se demuestra la generación del Pre - CFDI, esto es el CFDI  antes" +
    " de ser timbrado\n\nSi deseas ver como se genera un CFDI 4.0 timbrado, por favor, " +
    "revisa el ejemplo PAC ECODEX";
      // 
      // pblBotones
      // 
      this.pblBotones.Controls.Add(this.btnTimbrado);
      this.pblBotones.Controls.Add(this.btnHelp);
      this.pblBotones.Controls.Add(this.btnClose);
      this.pblBotones.Controls.Add(this.btnExecute);
      this.pblBotones.Controls.Add(this.btnAbout);
      this.pblBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pblBotones.Location = new System.Drawing.Point(3, 352);
      this.pblBotones.Name = "pblBotones";
      this.pblBotones.Size = new System.Drawing.Size(792, 46);
      this.pblBotones.TabIndex = 13;
      // 
      // btnTimbrado
      // 
      this.btnTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimbrado.Location = new System.Drawing.Point(413, 9);
      this.btnTimbrado.Name = "btnTimbrado";
      this.btnTimbrado.Size = new System.Drawing.Size(147, 23);
      this.btnTimbrado.TabIndex = 4;
      this.btnTimbrado.Text = "Servicio de Timbrado";
      this.btnTimbrado.UseVisualStyleBackColor = true;
      // 
      // btnHelp
      // 
      this.btnHelp.Location = new System.Drawing.Point(88, 9);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 23);
      this.btnHelp.TabIndex = 3;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(705, 9);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExecute.Location = new System.Drawing.Point(624, 9);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 23);
      this.btnExecute.TabIndex = 0;
      this.btnExecute.Text = "&Generar";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Location = new System.Drawing.Point(7, 9);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(75, 23);
      this.btnAbout.TabIndex = 2;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(806, 449);
      this.Controls.Add(this.pgcInformacion);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Generación de CFDI 4.0";
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.pgcInformacion.ResumeLayout(false);
      this.tshSample1.ResumeLayout(false);
      this.pblBotones.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.TabControl pgcInformacion;
    private System.Windows.Forms.TabPage tshSample1;
    private System.Windows.Forms.RichTextBox redtSample1;
    private System.Windows.Forms.Panel pblBotones;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
  }
}

