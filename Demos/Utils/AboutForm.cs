using System;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Utilerias
{
  public partial class AboutForm : Form
  {
    #region Factory
    
    private AboutForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      Gui.Shared.ConfigurateModalForm(this);

      this.lblWebSite.Links.Add(0, this.lblWebSite.Text.Length, this.lblWebSite.Text);
      this.lblInvoice.Links.Add(0, this.lblInvoice.Text.Length, this.lblInvoice.Text);
    } 
    
    #endregion

    #region Business

    #region Methods

    public static void ShowForm()
    {
      using (AboutForm aboutform = new AboutForm())
      {
        aboutform.ShowDialog();
      }
    }

    #endregion
    
    #region Events

    private void LblWebSiteLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
    }

    private void LblInvoiceLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
    }

    private void AboutFormShown(object sender, EventArgs e)
    {
      this.lblVersion.Text = ElectronicDocument.Version();
    }
    #endregion

    #endregion
  }
}