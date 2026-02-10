namespace HyperSoft.Ejemplo.Utilerias
{
  partial class VersionsForm
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
      this.pnlCfdi = new System.Windows.Forms.Panel();
      this.mmoCfdi = new System.Windows.Forms.RichTextBox();
      this.pnlCfdi.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlCfdi
      // 
      this.pnlCfdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlCfdi.Controls.Add(this.mmoCfdi);
      this.pnlCfdi.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlCfdi.Location = new System.Drawing.Point(0, 0);
      this.pnlCfdi.Name = "pnlCfdi";
      this.pnlCfdi.Size = new System.Drawing.Size(484, 216);
      this.pnlCfdi.TabIndex = 17;
      // 
      // mmoCfdi
      // 
      this.mmoCfdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mmoCfdi.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mmoCfdi.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mmoCfdi.Location = new System.Drawing.Point(0, 0);
      this.mmoCfdi.Name = "mmoCfdi";
      this.mmoCfdi.ReadOnly = true;
      this.mmoCfdi.Size = new System.Drawing.Size(482, 214);
      this.mmoCfdi.TabIndex = 3;
      this.mmoCfdi.TabStop = false;
      this.mmoCfdi.Text = "";
      this.mmoCfdi.WordWrap = false;
      // 
      // VersionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 216);
      this.Controls.Add(this.pnlCfdi);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "VersionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Librerías - Versiones";
      this.pnlCfdi.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlCfdi;
    private System.Windows.Forms.RichTextBox mmoCfdi;
  }
}