using System.Windows.Forms;

namespace HyperSoft.Ejemplo.Utilerias
{
  public partial class VersionsForm : Form
  {
    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void ShowData(string data)
    {
      using (new HyperSoft.Shared.WaitCursor())
      {
        using (VersionsForm form = new VersionsForm())
        {
          form.mmoCfdi.Text = data;
          form.ShowDialog();
        }          
      }
    }

    #region Factory

    private VersionsForm()
    {
      this.InitializeComponent();
    }

    #endregion
  }
}