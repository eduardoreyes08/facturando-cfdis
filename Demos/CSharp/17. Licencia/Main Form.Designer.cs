namespace HyperSoft.Ejemplo.Licencia
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
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.btnStatusLicencia = new System.Windows.Forms.Button();
      this.btnDatosLicencia = new System.Windows.Forms.Button();
      this.btnCargarLicencia = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnPuertos = new System.Windows.Forms.Button();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblVersion});
      this.statusStrip.Location = new System.Drawing.Point(0, 184);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(624, 22);
      this.statusStrip.TabIndex = 19;
      this.statusStrip.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(550, 17);
      this.lblTime.Spring = true;
      this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblVersion
      // 
      this.lblVersion.IsLink = true;
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(59, 17);
      this.lblVersion.Text = "lblVersion";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnStatusLicencia
      // 
      this.btnStatusLicencia.Location = new System.Drawing.Point(12, 68);
      this.btnStatusLicencia.Name = "btnStatusLicencia";
      this.btnStatusLicencia.Size = new System.Drawing.Size(250, 50);
      this.btnStatusLicencia.TabIndex = 27;
      this.btnStatusLicencia.Text = "STATUS DE LA LICENCIA";
      this.btnStatusLicencia.UseVisualStyleBackColor = true;
      this.btnStatusLicencia.Click += new System.EventHandler(this.btnStatusLicencia_Click);
      // 
      // btnDatosLicencia
      // 
      this.btnDatosLicencia.Location = new System.Drawing.Point(12, 124);
      this.btnDatosLicencia.Name = "btnDatosLicencia";
      this.btnDatosLicencia.Size = new System.Drawing.Size(250, 50);
      this.btnDatosLicencia.TabIndex = 25;
      this.btnDatosLicencia.Text = "DATOS DE LA LICENCIA";
      this.btnDatosLicencia.UseVisualStyleBackColor = true;
      this.btnDatosLicencia.Click += new System.EventHandler(this.btnDatosLicencia_Click);
      // 
      // btnCargarLicencia
      // 
      this.btnCargarLicencia.Location = new System.Drawing.Point(12, 12);
      this.btnCargarLicencia.Name = "btnCargarLicencia";
      this.btnCargarLicencia.Size = new System.Drawing.Size(250, 50);
      this.btnCargarLicencia.TabIndex = 26;
      this.btnCargarLicencia.Text = "CARGAR LICENCIA";
      this.btnCargarLicencia.UseVisualStyleBackColor = true;
      this.btnCargarLicencia.Click += new System.EventHandler(this.btnCargarLicencia_Click);
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.Location = new System.Drawing.Point(471, 152);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(141, 22);
      this.btnClose.TabIndex = 29;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnPuertos
      // 
      this.btnPuertos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPuertos.Location = new System.Drawing.Point(471, 124);
      this.btnPuertos.Name = "btnPuertos";
      this.btnPuertos.Size = new System.Drawing.Size(141, 23);
      this.btnPuertos.TabIndex = 30;
      this.btnPuertos.Text = "Puertos";
      this.btnPuertos.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 206);
      this.Controls.Add(this.btnPuertos);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnStatusLicencia);
      this.Controls.Add(this.btnDatosLicencia);
      this.Controls.Add(this.btnCargarLicencia);
      this.Controls.Add(this.statusStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LICENCIA";
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.Button btnStatusLicencia;
    private System.Windows.Forms.Button btnDatosLicencia;
    private System.Windows.Forms.Button btnCargarLicencia;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnPuertos;
  }
}

