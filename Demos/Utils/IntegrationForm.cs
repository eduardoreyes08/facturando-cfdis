using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HyperSoft.Ejemplo.Utilerias
{
  public partial class IntegrationForm : Form
  {
    #region Bussines

    #region Constants

    public const string UrlTimbrado = "http://www.facturando.mx/productos/timbrado-factura-electronica/presentacion.php";

    #endregion

    #region Vars
    
    private static IntegrationForm integrationform;
    
    #endregion

    #region Methods

    public static void ShowForm()
    {
      if (System.IO.File.Exists("info.txt"))
        return;

      if (integrationform == null)
        integrationform = new IntegrationForm();

      if (integrationform.chkHide.Checked == false)
      {
        Application.OpenForms[0].Enabled = false;
        integrationform.ShowDialog();
        Application.OpenForms[0].Enabled = true;
      }
    }

    #endregion

    #region Events

    private void LnkMailtoLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(UrlTimbrado);
    }

    private void PbxPresentationClick(object sender, EventArgs e)
    {
      Process.Start(UrlTimbrado);
    }

    private void BtnCloseClick(object sender, EventArgs e)
    {
      this.Close();
    }

    private void IntegrationForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (this.chkHide.Checked)
        System.IO.File.WriteAllText("info.txt", string.Empty);
      else
        if (System.IO.File.Exists("info.txt"))
        System.IO.File.Delete("info.txt");
    }


    #endregion

    #endregion

    #region Factory

    private IntegrationForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      Gui.Shared.ConfigurateModalForm(this);
    } 
    
    #endregion
  }
}