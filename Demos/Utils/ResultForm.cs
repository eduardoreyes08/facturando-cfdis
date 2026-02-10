using System.Windows.Forms;

namespace HyperSoft.Ejemplo.Utilerias
{
  public partial class ResultForm : Form
  {
    #region Business

    #region Vars

    private static ResultForm form;

    #endregion

    #region Business

    public static void ShowResult(string title, string content)
    {
      if (form == null)
        form = new ResultForm();

      Application.OpenForms[0].Enabled = false;
      try
      {
        form.Text = title;
        form.rtbResult.Text = content;
        form.ShowDialog();
      }
      finally
      {
        Application.OpenForms[0].Enabled = true;
      }      
    }

    private void BtnCloseClick(object sender, System.EventArgs e)
    {
      this.Close();
    }

    #endregion

    #endregion

    #region Factory

    private ResultForm()
    {
      this.InitializeComponent();
    }

    #endregion
  }
}
