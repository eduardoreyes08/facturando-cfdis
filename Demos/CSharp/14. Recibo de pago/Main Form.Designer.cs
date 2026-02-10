namespace HyperSoft.Ejemplo.ReciboPago
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
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.pgcDescription = new System.Windows.Forms.TabControl();
      this.tshDescription = new System.Windows.Forms.TabPage();
      this.redtDescripcion = new System.Windows.Forms.RichTextBox();
      this.pnlOperaciones = new System.Windows.Forms.Panel();
      this.btnTimbrado = new System.Windows.Forms.Button();
      this.lblOperacion = new System.Windows.Forms.Label();
      this.cmbOperacion = new System.Windows.Forms.ComboBox();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.stb.SuspendLayout();
      this.pgcDescription.SuspendLayout();
      this.tshDescription.SuspendLayout();
      this.pnlOperaciones.SuspendLayout();
      this.SuspendLayout();
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 382);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(619, 22);
      this.stb.TabIndex = 12;
      this.stb.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
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
      // pgcDescription
      // 
      this.pgcDescription.Controls.Add(this.tshDescription);
      this.pgcDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgcDescription.Location = new System.Drawing.Point(0, 82);
      this.pgcDescription.Name = "pgcDescription";
      this.pgcDescription.SelectedIndex = 0;
      this.pgcDescription.Size = new System.Drawing.Size(619, 300);
      this.pgcDescription.TabIndex = 14;
      // 
      // tshDescription
      // 
      this.tshDescription.Controls.Add(this.redtDescripcion);
      this.tshDescription.Location = new System.Drawing.Point(4, 22);
      this.tshDescription.Name = "tshDescription";
      this.tshDescription.Padding = new System.Windows.Forms.Padding(3);
      this.tshDescription.Size = new System.Drawing.Size(611, 274);
      this.tshDescription.TabIndex = 0;
      this.tshDescription.Text = "Descripción";
      this.tshDescription.UseVisualStyleBackColor = true;
      // 
      // redtDescripcion
      // 
      this.redtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.redtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtDescripcion.Location = new System.Drawing.Point(3, 3);
      this.redtDescripcion.Name = "redtDescripcion";
      this.redtDescripcion.ReadOnly = true;
      this.redtDescripcion.Size = new System.Drawing.Size(605, 268);
      this.redtDescripcion.TabIndex = 0;
      this.redtDescripcion.Text = "";
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
      this.pnlOperaciones.TabIndex = 15;
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
            "Generar y timbrar un recibo pago",
            "Generar un XML de recibo de pago"});
      this.cmbOperacion.Location = new System.Drawing.Point(3, 24);
      this.cmbOperacion.Name = "cmbOperacion";
      this.cmbOperacion.Size = new System.Drawing.Size(360, 21);
      this.cmbOperacion.TabIndex = 1;
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 404);
      this.Controls.Add(this.pgcDescription);
      this.Controls.Add(this.stb);
      this.Controls.Add(this.pnlOperaciones);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RECIBO DE PAGO 2.0  - CFDI 4.0";
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.pgcDescription.ResumeLayout(false);
      this.tshDescription.ResumeLayout(false);
      this.pnlOperaciones.ResumeLayout(false);
      this.pnlOperaciones.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.TabControl pgcDescription;
    private System.Windows.Forms.TabPage tshDescription;
    private System.Windows.Forms.RichTextBox redtDescripcion;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
    private System.Windows.Forms.Panel pnlOperaciones;
    private System.Windows.Forms.Button btnTimbrado;
    private System.Windows.Forms.Label lblOperacion;
    private System.Windows.Forms.ComboBox cmbOperacion;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.Button btnAbout;
  }
}

