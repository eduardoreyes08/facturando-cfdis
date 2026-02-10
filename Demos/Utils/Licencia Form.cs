using System;
using System.Text;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Base;

// ReSharper disable RedundantNameQualifier
// ReSharper disable UseStringInterpolation
namespace HyperSoft.Ejemplo.Utilerias
{
  public partial class LicenciaForm : Form
  {
    #region Methods

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static void ShowData()
    {
      using (new HyperSoft.Shared.WaitCursor())
      {
        Application.OpenForms[0].Enabled = false;
        try
        {
          using (LicenciaForm form = new LicenciaForm())
            form.ShowDialog();
        }
        finally
        {
          Application.OpenForms[0].Enabled = true;
        }
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static string StatusToText(ActivationStatusType status)
    {
      switch (status)
      {
        case ActivationStatusType.EvaluationExpired: return "Expired - No podrás usar la librería porque la licencia ya venció.";
        case ActivationStatusType.EvaluationMode: return "EvaluationMode - No se ha cargado una licencia.";
        case ActivationStatusType.InValid: return "InValid - La licencia cargada no es válida.";
        case ActivationStatusType.Licensed: return "Licensed - La licencia es válida y podrá hacer uso de la librería.";
        default:
          throw new ArgumentOutOfRangeException(nameof(status), status, null);
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private string ShowLicenseInformation()
    {
      ElectronicDocumentLibrary.Activation.Data data = HyperSoft.ElectronicDocumentLibrary.Activaction.ActivationData();

      this.Text = string.Format("DATOS DE LA LICENCIA    -= {0} =-", data.Status.ToString().ToUpperInvariant());

      StringBuilder sb = new StringBuilder();

      sb.AppendLine(string.Format("Versión     : {0}", data.Version));
      sb.AppendLine(string.Format("Empresa     : {0}", data.Enterprise));
      sb.AppendLine(string.Format("No de serie : {0}", data.SerialNumber));
      sb.AppendLine().AppendLine();
      sb.AppendLine(string.Format("Vigencia    : {0:d}", data.FechaVencimiento));
      sb.AppendLine(string.Format("Status      : {0}", StatusToText(data.Status)));

      return sb.ToString().Trim();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private string ShowEvaluationModeInformation()
    {
      StringBuilder sb = new StringBuilder();

      if (System.IO.File.Exists(License.LicenseCfdiData))
      {
        sb.AppendLine("Se encontró una licencia, pero no pudo ser activada la librería");
        sb.AppendLine("por alguno de los siguientes motivos:").AppendLine();
        sb.AppendLine("  - No pudo ser leido el archivo");
        sb.AppendLine("  - El archivo esta dañado.");
        sb.AppendLine("  - El archivo corresponde a otro producto.");
        sb.AppendLine().AppendLine();
        sb.AppendLine(License.LicenseCfdiData);
      }
      else
      {
        sb.AppendLine("No existe una licencia para poder activar la librería.");
        sb.AppendLine();
        sb.AppendLine("Si cuentas con una, por favor, copiala al siguiente directorio");
        sb.AppendLine("y vuelve a ejecutar este DEMO.");
        sb.AppendLine().AppendLine();
        sb.AppendLine(System.IO.Path.GetDirectoryName(License.LicenseCfdiData));
      }

      return sb.ToString().Trim();
    }

    #endregion

    #region Events

    private void After_Show(object sender, EventArgs e)
    {
      if (HyperSoft.ElectronicDocumentLibrary.Activaction.ActivationStatus == ActivationStatusType.EvaluationMode)
        this.mmoCfdi.Text = this.ShowEvaluationModeInformation();
      else
        this.mmoCfdi.Text = this.ShowLicenseInformation();
    }

    #endregion

    #region Factory

    private LicenciaForm()
    {
      // -- Código para uso interno de este ejemplo
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      Gui.Shared.ConfigurateModalForm(this);

      // -- Código para uso interno de este ejemplo
      this.Shown += this.After_Show;
    }

    #endregion
  }
}
