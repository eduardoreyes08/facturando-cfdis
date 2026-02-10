namespace HyperSoft.Ejemplo.Certificado
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
      this.pgcInformacion = new System.Windows.Forms.TabControl();
      this.tshSample1 = new System.Windows.Forms.TabPage();
      this.redtSample1 = new System.Windows.Forms.RichTextBox();
      this.tshSample2 = new System.Windows.Forms.TabPage();
      this.redtSample2 = new System.Windows.Forms.RichTextBox();
      this.tshSample3 = new System.Windows.Forms.TabPage();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pgcInformacion.SuspendLayout();
      this.tshSample1.SuspendLayout();
      this.tshSample2.SuspendLayout();
      this.tshSample3.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.stb.SuspendLayout();
      this.SuspendLayout();
      // 
      // pgcInformacion
      // 
      this.pgcInformacion.Controls.Add(this.tshSample1);
      this.pgcInformacion.Controls.Add(this.tshSample2);
      this.pgcInformacion.Controls.Add(this.tshSample3);
      this.pgcInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcInformacion.Location = new System.Drawing.Point(0, 0);
      this.pgcInformacion.Name = "pgcInformacion";
      this.pgcInformacion.SelectedIndex = 0;
      this.pgcInformacion.Size = new System.Drawing.Size(642, 392);
      this.pgcInformacion.TabIndex = 0;
      this.pgcInformacion.TabStop = false;
      // 
      // tshSample1
      // 
      this.tshSample1.Controls.Add(this.redtSample1);
      this.tshSample1.Location = new System.Drawing.Point(4, 22);
      this.tshSample1.Name = "tshSample1";
      this.tshSample1.Padding = new System.Windows.Forms.Padding(3);
      this.tshSample1.Size = new System.Drawing.Size(634, 366);
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
      this.redtSample1.Size = new System.Drawing.Size(628, 360);
      this.redtSample1.TabIndex = 0;
      this.redtSample1.Text = "En este ejemplo se muestra como obtener los datos de un certificado.\n";
      // 
      // tshSample2
      // 
      this.tshSample2.Controls.Add(this.redtSample2);
      this.tshSample2.Location = new System.Drawing.Point(4, 22);
      this.tshSample2.Name = "tshSample2";
      this.tshSample2.Padding = new System.Windows.Forms.Padding(3);
      this.tshSample2.Size = new System.Drawing.Size(634, 366);
      this.tshSample2.TabIndex = 1;
      this.tshSample2.Text = "Ejemplo 2";
      this.tshSample2.UseVisualStyleBackColor = true;
      // 
      // redtSample2
      // 
      this.redtSample2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtSample2.Location = new System.Drawing.Point(3, 3);
      this.redtSample2.Name = "redtSample2";
      this.redtSample2.ReadOnly = true;
      this.redtSample2.Size = new System.Drawing.Size(628, 360);
      this.redtSample2.TabIndex = 0;
      this.redtSample2.Text = "En este ejemplo se muestra como :\n\n1. Leer un certificado en formato PKCS12 o PFX" +
    ".\n2. Obtener los datos de un certificado.";
      // 
      // tshSample3
      // 
      this.tshSample3.Controls.Add(this.richTextBox1);
      this.tshSample3.Location = new System.Drawing.Point(4, 22);
      this.tshSample3.Name = "tshSample3";
      this.tshSample3.Padding = new System.Windows.Forms.Padding(3);
      this.tshSample3.Size = new System.Drawing.Size(634, 366);
      this.tshSample3.TabIndex = 2;
      this.tshSample3.Text = "Ejemplo 3";
      this.tshSample3.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBox1.Location = new System.Drawing.Point(3, 3);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.Size = new System.Drawing.Size(628, 360);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnTimbrado);
      this.panel1.Controls.Add(this.btnHelp);
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Controls.Add(this.btnExecute);
      this.panel1.Controls.Add(this.btnAbout);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 392);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(642, 46);
      this.panel1.TabIndex = 0;
      // 
      // btnTimbrado
      // 
      this.btnTimbrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimbrado.Location = new System.Drawing.Point(321, 12);
      this.btnTimbrado.Name = "btnTimbrado";
      this.btnTimbrado.Size = new System.Drawing.Size(147, 23);
      this.btnTimbrado.TabIndex = 2;
      this.btnTimbrado.Text = "Servicio de Timbrado";
      this.btnTimbrado.UseVisualStyleBackColor = true;
      // 
      // btnHelp
      // 
      this.btnHelp.Location = new System.Drawing.Point(92, 12);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 23);
      this.btnHelp.TabIndex = 1;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(555, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExecute.Location = new System.Drawing.Point(474, 12);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(75, 23);
      this.btnExecute.TabIndex = 3;
      this.btnExecute.Text = "&Mostrar";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Location = new System.Drawing.Point(11, 12);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(75, 23);
      this.btnAbout.TabIndex = 0;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.pgcInformacion);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(642, 392);
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
      this.stb.Size = new System.Drawing.Size(642, 22);
      this.stb.TabIndex = 5;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(505, 17);
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
      this.ClientSize = new System.Drawing.Size(642, 460);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MinimumSize = new System.Drawing.Size(648, 484);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ejemplo para el manejo del Certificado";
      this.pgcInformacion.ResumeLayout(false);
      this.tshSample1.ResumeLayout(false);
      this.tshSample2.ResumeLayout(false);
      this.tshSample3.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl pgcInformacion;
    private System.Windows.Forms.TabPage tshSample1;
    private System.Windows.Forms.TabPage tshSample2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.RichTextBox redtSample1;
    private System.Windows.Forms.RichTextBox redtSample2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.TabPage tshSample3;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}

