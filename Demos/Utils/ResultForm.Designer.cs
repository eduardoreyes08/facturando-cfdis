namespace HyperSoft.Ejemplo.Utilerias
{
  partial class ResultForm
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
      this.rtbResult = new System.Windows.Forms.RichTextBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // rtbResult
      // 
      this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbResult.Location = new System.Drawing.Point(12, 12);
      this.rtbResult.Name = "rtbResult";
      this.rtbResult.ReadOnly = true;
      this.rtbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
      this.rtbResult.Size = new System.Drawing.Size(573, 342);
      this.rtbResult.TabIndex = 4;
      this.rtbResult.Text = "";
      this.rtbResult.WordWrap = false;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(510, 360);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "&Salir";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
      // 
      // ResultForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(597, 395);
      this.Controls.Add(this.rtbResult);
      this.Controls.Add(this.btnClose);
      this.Name = "ResultForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Resultado";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtbResult;
    private System.Windows.Forms.Button btnClose;
  }
}