namespace HyperSoft.Ejemplo.Validacion
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
      this.mmoInformation = new System.Windows.Forms.RichTextBox();
      this.btnAbout = new System.Windows.Forms.Button();
      this.btnHelp = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.stb = new System.Windows.Forms.StatusStrip();
      this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLicencia = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.tbcOpciones = new System.Windows.Forms.TabControl();
      this.tshCfdi = new System.Windows.Forms.TabPage();
      this.lblCfdi = new System.Windows.Forms.Label();
      this.cbbCfdi = new System.Windows.Forms.ComboBox();
      this.tshContabilidad = new System.Windows.Forms.TabPage();
      this.cbbContabilidadTipo = new System.Windows.Forms.ComboBox();
      this.lblContabilidadTipo = new System.Windows.Forms.Label();
      this.cbbContabilidad = new System.Windows.Forms.ComboBox();
      this.lblContabilidad = new System.Windows.Forms.Label();
      this.tshRetenciones = new System.Windows.Forms.TabPage();
      this.cbbConstanciaRetenciones = new System.Windows.Forms.ComboBox();
      this.lblConstanciaRetenciones = new System.Windows.Forms.Label();
      this.btnValidar = new System.Windows.Forms.Button();
      this.btnSeleccionar = new System.Windows.Forms.Button();
      this.stb.SuspendLayout();
      this.tbcOpciones.SuspendLayout();
      this.tshCfdi.SuspendLayout();
      this.tshContabilidad.SuspendLayout();
      this.tshRetenciones.SuspendLayout();
      this.SuspendLayout();
      // 
      // mmoInformation
      // 
      this.mmoInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mmoInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mmoInformation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mmoInformation.Location = new System.Drawing.Point(12, 168);
      this.mmoInformation.Name = "mmoInformation";
      this.mmoInformation.ReadOnly = true;
      this.mmoInformation.Size = new System.Drawing.Size(960, 462);
      this.mmoInformation.TabIndex = 6;
      this.mmoInformation.Text = "";
      this.mmoInformation.WordWrap = false;
      // 
      // btnAbout
      // 
      this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbout.Location = new System.Drawing.Point(834, 78);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(138, 23);
      this.btnAbout.TabIndex = 3;
      this.btnAbout.Text = "&Acerca de...";
      this.btnAbout.UseVisualStyleBackColor = true;
      // 
      // btnHelp
      // 
      this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnHelp.Location = new System.Drawing.Point(830, 136);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(142, 23);
      this.btnHelp.TabIndex = 5;
      this.btnHelp.Text = "A&yuda";
      this.btnHelp.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(834, 107);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(138, 23);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      // 
      // stb
      // 
      this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTime,
            this.lblLicencia,
            this.lblVersion});
      this.stb.Location = new System.Drawing.Point(0, 644);
      this.stb.Name = "stb";
      this.stb.Size = new System.Drawing.Size(984, 22);
      this.stb.TabIndex = 7;
      this.stb.Text = "statusStrip1";
      // 
      // lblTime
      // 
      this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(847, 17);
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
      // tbcOpciones
      // 
      this.tbcOpciones.Controls.Add(this.tshCfdi);
      this.tbcOpciones.Controls.Add(this.tshContabilidad);
      this.tbcOpciones.Controls.Add(this.tshRetenciones);
      this.tbcOpciones.Location = new System.Drawing.Point(12, 12);
      this.tbcOpciones.Name = "tbcOpciones";
      this.tbcOpciones.SelectedIndex = 0;
      this.tbcOpciones.Size = new System.Drawing.Size(816, 150);
      this.tbcOpciones.TabIndex = 0;
      // 
      // tshCfdi
      // 
      this.tshCfdi.Controls.Add(this.lblCfdi);
      this.tshCfdi.Controls.Add(this.cbbCfdi);
      this.tshCfdi.Location = new System.Drawing.Point(4, 22);
      this.tshCfdi.Name = "tshCfdi";
      this.tshCfdi.Padding = new System.Windows.Forms.Padding(3);
      this.tshCfdi.Size = new System.Drawing.Size(808, 124);
      this.tshCfdi.TabIndex = 0;
      this.tshCfdi.Text = "Comprobantes (CFD / CFDI)";
      this.tshCfdi.UseVisualStyleBackColor = true;
      // 
      // lblCfdi
      // 
      this.lblCfdi.AutoSize = true;
      this.lblCfdi.Location = new System.Drawing.Point(6, 10);
      this.lblCfdi.Name = "lblCfdi";
      this.lblCfdi.Size = new System.Drawing.Size(179, 13);
      this.lblCfdi.TabIndex = 11;
      this.lblCfdi.Text = "Selecciona el comprobante a validar";
      // 
      // cbbCfdi
      // 
      this.cbbCfdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbbCfdi.DropDownWidth = 1050;
      this.cbbCfdi.FormattingEnabled = true;
      this.cbbCfdi.Location = new System.Drawing.Point(9, 26);
      this.cbbCfdi.Name = "cbbCfdi";
      this.cbbCfdi.Size = new System.Drawing.Size(793, 21);
      this.cbbCfdi.TabIndex = 10;
      // 
      // tshContabilidad
      // 
      this.tshContabilidad.Controls.Add(this.cbbContabilidadTipo);
      this.tshContabilidad.Controls.Add(this.lblContabilidadTipo);
      this.tshContabilidad.Controls.Add(this.cbbContabilidad);
      this.tshContabilidad.Controls.Add(this.lblContabilidad);
      this.tshContabilidad.Location = new System.Drawing.Point(4, 22);
      this.tshContabilidad.Name = "tshContabilidad";
      this.tshContabilidad.Padding = new System.Windows.Forms.Padding(3);
      this.tshContabilidad.Size = new System.Drawing.Size(808, 124);
      this.tshContabilidad.TabIndex = 1;
      this.tshContabilidad.Text = "Contabilidad electrónica";
      this.tshContabilidad.UseVisualStyleBackColor = true;
      // 
      // cbbContabilidadTipo
      // 
      this.cbbContabilidadTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbContabilidadTipo.FormattingEnabled = true;
      this.cbbContabilidadTipo.Items.AddRange(new object[] {
            "Cuentas contables",
            "Balanza de comprobación",
            "Pólizas",
            "Auxiliar de cuentas",
            "Auxiliar de folios"});
      this.cbbContabilidadTipo.Location = new System.Drawing.Point(9, 70);
      this.cbbContabilidadTipo.Name = "cbbContabilidadTipo";
      this.cbbContabilidadTipo.Size = new System.Drawing.Size(264, 21);
      this.cbbContabilidadTipo.TabIndex = 16;
      this.cbbContabilidadTipo.SelectedIndexChanged += new System.EventHandler(this.cbbContabilidadTipo_SelectedIndexChanged);
      // 
      // lblContabilidadTipo
      // 
      this.lblContabilidadTipo.AutoSize = true;
      this.lblContabilidadTipo.Location = new System.Drawing.Point(6, 54);
      this.lblContabilidadTipo.Name = "lblContabilidadTipo";
      this.lblContabilidadTipo.Size = new System.Drawing.Size(81, 13);
      this.lblContabilidadTipo.TabIndex = 15;
      this.lblContabilidadTipo.Text = "Tipo de archivo";
      // 
      // cbbContabilidad
      // 
      this.cbbContabilidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbbContabilidad.DropDownWidth = 1050;
      this.cbbContabilidad.FormattingEnabled = true;
      this.cbbContabilidad.Location = new System.Drawing.Point(9, 26);
      this.cbbContabilidad.Name = "cbbContabilidad";
      this.cbbContabilidad.Size = new System.Drawing.Size(793, 21);
      this.cbbContabilidad.TabIndex = 13;
      // 
      // lblContabilidad
      // 
      this.lblContabilidad.AutoSize = true;
      this.lblContabilidad.Location = new System.Drawing.Point(6, 10);
      this.lblContabilidad.Name = "lblContabilidad";
      this.lblContabilidad.Size = new System.Drawing.Size(179, 13);
      this.lblContabilidad.TabIndex = 12;
      this.lblContabilidad.Text = "Selecciona el comprobante a validar";
      // 
      // tshRetenciones
      // 
      this.tshRetenciones.Controls.Add(this.cbbConstanciaRetenciones);
      this.tshRetenciones.Controls.Add(this.lblConstanciaRetenciones);
      this.tshRetenciones.Location = new System.Drawing.Point(4, 22);
      this.tshRetenciones.Name = "tshRetenciones";
      this.tshRetenciones.Padding = new System.Windows.Forms.Padding(3);
      this.tshRetenciones.Size = new System.Drawing.Size(808, 124);
      this.tshRetenciones.TabIndex = 2;
      this.tshRetenciones.Text = "Constancia de retenciones";
      this.tshRetenciones.UseVisualStyleBackColor = true;
      // 
      // cbbConstanciaRetenciones
      // 
      this.cbbConstanciaRetenciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbbConstanciaRetenciones.DropDownWidth = 1050;
      this.cbbConstanciaRetenciones.FormattingEnabled = true;
      this.cbbConstanciaRetenciones.Location = new System.Drawing.Point(9, 26);
      this.cbbConstanciaRetenciones.Name = "cbbConstanciaRetenciones";
      this.cbbConstanciaRetenciones.Size = new System.Drawing.Size(793, 21);
      this.cbbConstanciaRetenciones.TabIndex = 13;
      // 
      // lblConstanciaRetenciones
      // 
      this.lblConstanciaRetenciones.AutoSize = true;
      this.lblConstanciaRetenciones.Location = new System.Drawing.Point(6, 10);
      this.lblConstanciaRetenciones.Name = "lblConstanciaRetenciones";
      this.lblConstanciaRetenciones.Size = new System.Drawing.Size(179, 13);
      this.lblConstanciaRetenciones.TabIndex = 12;
      this.lblConstanciaRetenciones.Text = "Selecciona el comprobante a validar";
      // 
      // btnValidar
      // 
      this.btnValidar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnValidar.Image = global::HyperSoft.Ejemplo.Validacion.Properties.Resources.openFile;
      this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnValidar.Location = new System.Drawing.Point(834, 8);
      this.btnValidar.Name = "btnValidar";
      this.btnValidar.Size = new System.Drawing.Size(138, 30);
      this.btnValidar.TabIndex = 1;
      this.btnValidar.Text = " &Validar archivo";
      this.btnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnValidar.UseVisualStyleBackColor = true;
      this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
      // 
      // btnSeleccionar
      // 
      this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSeleccionar.Image = global::HyperSoft.Ejemplo.Validacion.Properties.Resources.validate;
      this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSeleccionar.Location = new System.Drawing.Point(834, 44);
      this.btnSeleccionar.Name = "btnSeleccionar";
      this.btnSeleccionar.Size = new System.Drawing.Size(138, 30);
      this.btnSeleccionar.TabIndex = 2;
      this.btnSeleccionar.Text = " &Seleccionar archivo";
      this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSeleccionar.UseVisualStyleBackColor = true;
      this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(984, 666);
      this.Controls.Add(this.btnValidar);
      this.Controls.Add(this.btnSeleccionar);
      this.Controls.Add(this.tbcOpciones);
      this.Controls.Add(this.stb);
      this.Controls.Add(this.mmoInformation);
      this.Controls.Add(this.btnAbout);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnHelp);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ejemplo de validación y recepción";
      this.stb.ResumeLayout(false);
      this.stb.PerformLayout();
      this.tbcOpciones.ResumeLayout(false);
      this.tshCfdi.ResumeLayout(false);
      this.tshCfdi.PerformLayout();
      this.tshContabilidad.ResumeLayout(false);
      this.tshContabilidad.PerformLayout();
      this.tshRetenciones.ResumeLayout(false);
      this.tshRetenciones.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.RichTextBox mmoInformation;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.StatusStrip stb;
    private System.Windows.Forms.ToolStripStatusLabel lblTime;
    private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    private System.Windows.Forms.TabControl tbcOpciones;
    private System.Windows.Forms.TabPage tshCfdi;
    private System.Windows.Forms.TabPage tshRetenciones;
    private System.Windows.Forms.ToolStripStatusLabel lblLicencia;
    private System.Windows.Forms.ComboBox cbbCfdi;
    private System.Windows.Forms.Label lblCfdi;
    private System.Windows.Forms.TabPage tshContabilidad;
    private System.Windows.Forms.Button btnSeleccionar;
    private System.Windows.Forms.Button btnValidar;
    private System.Windows.Forms.ComboBox cbbContabilidad;
    private System.Windows.Forms.Label lblContabilidad;
    private System.Windows.Forms.ComboBox cbbConstanciaRetenciones;
    private System.Windows.Forms.Label lblConstanciaRetenciones;
    private System.Windows.Forms.Label lblContabilidadTipo;
    private System.Windows.Forms.ComboBox cbbContabilidadTipo;
  }
}

