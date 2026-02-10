using System.Windows.Forms;

namespace HyperSoft.Ejemplo.Utilerias
{
  public partial class HelpForm : Form
  {
    #region Business

    #region Methods

    public static void ShowForm()
    {
      using (HelpForm helpform = new HelpForm())
      {
        helpform.ShowDialog();
      }
    }

    #endregion

    #region Events

    private void LblWebSiteLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
    }

    #endregion

    #endregion

    #region Factory

    private HelpForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      Gui.Shared.ConfigurateModalForm(this);

      this.lblWebSite.Links.Add(0, this.lblWebSite.Text.Length, this.lblWebSite.Text);
    }

    #endregion
  }
}
