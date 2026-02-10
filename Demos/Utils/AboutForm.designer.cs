namespace HyperSoft.Ejemplo.Utilerias
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.lblWebSite = new System.Windows.Forms.LinkLabel();
      this.lblWebSiteText = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblInvoice = new System.Windows.Forms.LinkLabel();
      this.lblInvoiceText = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.splitContainer1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(9, 9);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(417, 265);
      this.panel1.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.lblWebSite);
      this.splitContainer1.Panel1.Controls.Add(this.lblWebSiteText);
      this.splitContainer1.Panel1.Controls.Add(this.lblVersion);
      this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.lblInvoice);
      this.splitContainer1.Panel2.Controls.Add(this.lblInvoiceText);
      this.splitContainer1.Size = new System.Drawing.Size(417, 265);
      this.splitContainer1.SplitterDistance = 202;
      this.splitContainer1.SplitterWidth = 1;
      this.splitContainer1.TabIndex = 0;
      // 
      // lblWebSite
      // 
      this.lblWebSite.AutoSize = true;
      this.lblWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWebSite.Location = new System.Drawing.Point(147, 145);
      this.lblWebSite.Name = "lblWebSite";
      this.lblWebSite.Size = new System.Drawing.Size(121, 16);
      this.lblWebSite.TabIndex = 3;
      this.lblWebSite.TabStop = true;
      this.lblWebSite.Text = "www.facturando.mx";
      this.lblWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblWebSiteLinkClicked);
      // 
      // lblWebSiteText
      // 
      this.lblWebSiteText.AutoSize = true;
      this.lblWebSiteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWebSiteText.Location = new System.Drawing.Point(171, 122);
      this.lblWebSiteText.Name = "lblWebSiteText";
      this.lblWebSiteText.Size = new System.Drawing.Size(72, 13);
      this.lblWebSiteText.TabIndex = 2;
      this.lblWebSiteText.Text = "Sitio Oficial";
      // 
      // lblVersion
      // 
      this.lblVersion.Location = new System.Drawing.Point(3, 64);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(409, 18);
      this.lblVersion.TabIndex = 1;
      this.lblVersion.Text = "Version:";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(53, 31);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(308, 20);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "ELECTRONIC DOCUMENT LIBRARY";
      // 
      // lblInvoice
      // 
      this.lblInvoice.AutoSize = true;
      this.lblInvoice.Location = new System.Drawing.Point(121, 33);
      this.lblInvoice.Name = "lblInvoice";
      this.lblInvoice.Size = new System.Drawing.Size(167, 13);
      this.lblInvoice.TabIndex = 1;
      this.lblInvoice.TabStop = true;
      this.lblInvoice.Text = "https://www.facturando.mx/blog/";
      this.lblInvoice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblInvoiceLinkClicked);
      // 
      // lblInvoiceText
      // 
      this.lblInvoiceText.AutoSize = true;
      this.lblInvoiceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInvoiceText.Location = new System.Drawing.Point(118, 9);
      this.lblInvoiceText.Name = "lblInvoiceText";
      this.lblInvoiceText.Size = new System.Drawing.Size(179, 13);
      this.lblInvoiceText.TabIndex = 0;
      this.lblInvoiceText.Text = "Blog de la Factura Electrónica";
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 283);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Acerca de...";
      this.Shown += new System.EventHandler(this.AboutFormShown);
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel lblWebSite;
        private System.Windows.Forms.Label lblWebSiteText;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lblInvoice;
        private System.Windows.Forms.Label lblInvoiceText;

    }
}
