using System.Windows.Forms;

namespace HyperSoft.Ejemplo.Validacion
{
  public partial class InstructionsForm : Form
  {
    public InstructionsForm()
    {
      this.InitializeComponent();
    }

    public static void ShowForm()
    {
      using (InstructionsForm instructionsform = new InstructionsForm())
      {
        instructionsform.ShowDialog(); 
      }
    }
  }
}
