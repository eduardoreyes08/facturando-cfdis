using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.ECodex;

namespace HyperSoft.Ejemplo.Utilerias.Gui
{
  public static class Timbrado
  {
    private const string RfcTest = "EKU9003173C9";

    #region Vars
    private static Control[] rfcs;
    private static ComboBox cbbEnviroment;
    #endregion

    #region Methods

    public static bool IsTestMode()
    {
      return cbbEnviroment.SelectedIndex == 0;
    }

    public static Enviroment Enviroment()
    {
      if ((cbbEnviroment.SelectedIndex == 0) || (cbbEnviroment.SelectedIndex == 1))
        return ElectronicDocumentLibrary.ECodex.Enviroment.Default;

      return ElectronicDocumentLibrary.ECodex.Enviroment.Nomina;
    }

    public static void Initialization(Control[] controls, ComboBox comboBox, ToolStripStatusLabel label)
    {
      rfcs = controls;
      cbbEnviroment = comboBox;
      cbbEnviroment.SelectedIndexChanged += cbbEnviroment_SelectedIndexChanged;

      label.Text = $"E.D.L. - {ElectronicDocument.Version()} / ECODEX - {Proveedor.Version()}";
    }

    private static void SetRfcTest()
    {
      foreach (Control control in rfcs)
        control.Text = RfcTest;
    }

    #endregion

    #region Events

    private static void cbbEnviroment_SelectedIndexChanged(object sender, System.EventArgs e)
    {
      if (IsTestMode())
        SetRfcTest();

      Shared.EnabledControls(IsTestMode() == false, rfcs);
    }

    #endregion
  }
}