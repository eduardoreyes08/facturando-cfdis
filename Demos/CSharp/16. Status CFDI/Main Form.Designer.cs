namespace HyperSoft.Ejemplo.StatusCfdi
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
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.gbxDatos = new System.Windows.Forms.GroupBox();
      this.edtUuid = new System.Windows.Forms.TextBox();
      this.edtTotal = new System.Windows.Forms.TextBox();
      this.edtRfcReceptor = new System.Windows.Forms.TextBox();
      this.edtRfcEmisor = new System.Windows.Forms.TextBox();
      this.lblUUID = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.lblRFCReceptor = new System.Windows.Forms.Label();
      this.lblRFCEmisor = new System.Windows.Forms.Label();
      this.redtInformation = new System.Windows.Forms.RichTextBox();
      this.redtResult = new System.Windows.Forms.RichTextBox();
      this.lblResultado = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnExecute = new System.Windows.Forms.Button();
      this.stb.SuspendLayout();
      this.gbxDatos.SuspendLayout();
      this.SuspendLayout();
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 514);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(559, 22);
      this.stb.TabIndex = 8;
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
      this.lblTime.Size = new System.Drawing.Size(422, 17);
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
      // gbxDatos
      // 
      this.gbxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.gbxDatos.Controls.Add(this.edtUuid);
      this.gbxDatos.Controls.Add(this.edtTotal);
      this.gbxDatos.Controls.Add(this.edtRfcReceptor);
      this.gbxDatos.Controls.Add(this.edtRfcEmisor);
      this.gbxDatos.Controls.Add(this.lblUUID);
      this.gbxDatos.Controls.Add(this.lblTotal);
      this.gbxDatos.Controls.Add(this.lblRFCReceptor);
      this.gbxDatos.Controls.Add(this.lblRFCEmisor);
      this.gbxDatos.Location = new System.Drawing.Point(7, 92);
      this.gbxDatos.Name = "gbxDatos";
      this.gbxDatos.Size = new System.Drawing.Size(340, 134);
      this.gbxDatos.TabIndex = 1;
      this.gbxDatos.TabStop = false;
      this.gbxDatos.Text = "Datos";
      // 
      // edtUuid
      // 
      this.edtUuid.Location = new System.Drawing.Point(98, 94);
      this.edtUuid.Name = "edtUuid";
      this.edtUuid.Size = new System.Drawing.Size(227, 20);
      this.edtUuid.TabIndex = 7;
      this.edtUuid.Text = "20FF9E03-3DA8-4EE2-988B-8E45663642BC";
      // 
      // edtTotal
      // 
      this.edtTotal.Location = new System.Drawing.Point(98, 72);
      this.edtTotal.Name = "edtTotal";
      this.edtTotal.Size = new System.Drawing.Size(227, 20);
      this.edtTotal.TabIndex = 5;
      this.edtTotal.Text = "1740.00";
      this.edtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // edtRfcReceptor
      // 
      this.edtRfcReceptor.Location = new System.Drawing.Point(98, 50);
      this.edtRfcReceptor.Name = "edtRfcReceptor";
      this.edtRfcReceptor.Size = new System.Drawing.Size(227, 20);
      this.edtRfcReceptor.TabIndex = 3;
      this.edtRfcReceptor.Text = "TME001214SP6";
      // 
      // edtRfcEmisor
      // 
      this.edtRfcEmisor.Location = new System.Drawing.Point(98, 28);
      this.edtRfcEmisor.Name = "edtRfcEmisor";
      this.edtRfcEmisor.Size = new System.Drawing.Size(227, 20);
      this.edtRfcEmisor.TabIndex = 1;
      this.edtRfcEmisor.Text = "AAAD770905441";
      // 
      // lblUUID
      // 
      this.lblUUID.AutoSize = true;
      this.lblUUID.Location = new System.Drawing.Point(59, 97);
      this.lblUUID.Name = "lblUUID";
      this.lblUUID.Size = new System.Drawing.Size(37, 13);
      this.lblUUID.TabIndex = 6;
      this.lblUUID.Text = "UUID:";
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.Location = new System.Drawing.Point(62, 75);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(34, 13);
      this.lblTotal.TabIndex = 4;
      this.lblTotal.Text = "Total:";
      // 
      // lblRFCReceptor
      // 
      this.lblRFCReceptor.AutoSize = true;
      this.lblRFCReceptor.Location = new System.Drawing.Point(6, 53);
      this.lblRFCReceptor.Name = "lblRFCReceptor";
      this.lblRFCReceptor.Size = new System.Drawing.Size(90, 13);
      this.lblRFCReceptor.TabIndex = 2;
      this.lblRFCReceptor.Text = "RFC del receptor:";
      // 
      // lblRFCEmisor
      // 
      this.lblRFCEmisor.AutoSize = true;
      this.lblRFCEmisor.Location = new System.Drawing.Point(15, 31);
      this.lblRFCEmisor.Name = "lblRFCEmisor";
      this.lblRFCEmisor.Size = new System.Drawing.Size(81, 13);
      this.lblRFCEmisor.TabIndex = 0;
      this.lblRFCEmisor.Text = "RFC del emisor:";
      // 
      // redtInformation
      // 
      this.redtInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.redtInformation.Dock = System.Windows.Forms.DockStyle.Top;
      this.redtInformation.Location = new System.Drawing.Point(0, 0);
      this.redtInformation.Name = "redtInformation";
      this.redtInformation.ReadOnly = true;
      this.redtInformation.Size = new System.Drawing.Size(559, 85);
      this.redtInformation.TabIndex = 0;
      this.redtInformation.Text = resources.GetString("redtInformation.Text");
      // 
      // redtResult
      // 
      this.redtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.redtResult.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redtResult.Location = new System.Drawing.Point(7, 260);
      this.redtResult.Name = "redtResult";
      this.redtResult.ReadOnly = true;
      this.redtResult.Size = new System.Drawing.Size(540, 250);
      this.redtResult.TabIndex = 7;
      this.redtResult.Text = "";
      // 
      // lblResultado
      // 
      this.lblResultado.AutoSize = true;
      this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResultado.Location = new System.Drawing.Point(4, 244);
      this.lblResultado.Name = "lblResultado";
      this.lblResultado.Size = new System.Drawing.Size(82, 13);
      this.lblResultado.TabIndex = 6;
      this.lblResultado.Text = "RESULTADO";
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(353, 202);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(194, 23);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // btnAbout
      // 
      this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbout.Location = new System.Drawing.Point(353, 173);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(95, 23);
      this.btnAbout.TabIndex = 3;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // btnHelp
      // 
      this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnHelp.Location = new System.Drawing.Point(452, 173);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(95, 23);
      this.btnHelp.TabIndex = 4;
      this.btnHelp.Text = "A&yuda...";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnExecute
      // 
      this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExecute.Location = new System.Drawing.Point(353, 91);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(194, 76);
      this.btnExecute.TabIndex = 2;
      this.btnExecute.Text = "&CONSULTAR";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(559, 536);
      this.Controls.Add(this.btnExecute);
      this.Controls.Add(this.btnHelp);
      this.Controls.Add(this.btnAbout);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.lblResultado);
      this.Controls.Add(this.redtResult);
      this.Controls.Add(this.redtInformation);
      this.Controls.Add(this.gbxDatos);
      this.Controls.Add(this.stb);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consultar el Status de un CFDI en el SAT";
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.gbxDatos.ResumeLayout(false);
      this.gbxDatos.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.GroupBox gbxDatos;
    private System.Windows.Forms.TextBox edtUuid;
    private System.Windows.Forms.TextBox edtTotal;
    private System.Windows.Forms.TextBox edtRfcReceptor;
    private System.Windows.Forms.TextBox edtRfcEmisor;
    private System.Windows.Forms.Label lblUUID;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblRFCReceptor;
    private System.Windows.Forms.Label lblRFCEmisor;
    private System.Windows.Forms.RichTextBox redtInformation;
    private System.Windows.Forms.RichTextBox redtResult;
    private System.Windows.Forms.Label lblResultado;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
  }
}
