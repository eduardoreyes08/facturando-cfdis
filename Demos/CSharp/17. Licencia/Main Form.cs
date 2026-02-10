using System;
using System.IO;
using System.Windows.Forms;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.ElectronicDocumentLibrary.Base;

namespace HyperSoft.Ejemplo.Licencia
{
  public partial class MainForm : Form
  {
    #region Methods

    /// <summary>
    /// Método que muestra como cargar la licencia de la librería
    /// </summary>
    private void CargarLicencia()
    {
      using (new Shared.WaitCursor())
      {
        if (File.Exists(License.LicenseCfdiData) == false)
        {
          const string Message = "Estimado usuario:{0}{0}No es posible cargar la licencia porque no existe el archivo.{0}{0}{0}{1}{0}{0}{0}Si tiene una licencia, por favor, copiela a esa carpeta.{0}{0}";
          Shared.Gui.ShowError(string.Format(Message, Environment.NewLine, License.LicenseCfdiData));
          return;
        }

        // Con este código se carga la licencia
        using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(License.LicenseCfdiData)))
          ElectronicDocumentLibrary.Activaction.LoadActivationFile(stream);

        Shared.Gui.ShowMessage(string.Format(
          "Estimado usuario:{0}{0}" +
          "Se ha cargado la licencia de E.D.L., te recomendamos verificar su STATUS." +
          "{0}{0}" +
          "Archivo:{0}" +
          "{1}{0}{0}" +
          "Atte.{0}" +
          "FACTURANDO", Environment.NewLine, License.LicenseCfdiData));
      }
    }

    /// <summary>
    /// Método que muestra como obtener el status de la licencia previamente cargada
    /// 
    /// Si el status es diferente a LICENSED no podrás hacer uso de la librería.
    /// </summary>
    private void StatusLicencia()
    {
      string description = LicenciaForm.StatusToText(ElectronicDocumentLibrary.Activaction.ActivationStatus);

      string message = string.Format("Este es el estatus de la licencia previamente cargada.{0}{0}{1}", Environment.NewLine, description);

      if (ElectronicDocumentLibrary.Activaction.ActivationStatus == ActivationStatusType.Licensed)
        Shared.Gui.ShowMessage(message);
      else
        Shared.Gui.ShowError(message);
    }

    /// <summary>
    /// Método que muestra como extraer los datos contenidos en la licencia
    /// 
    /// Un dato que te podría se de gran utilidad, es la fecha de vencimiento.
    /// </summary>
    private void DatosLicencia()
    {
      LicenciaForm.ShowData();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // -- Código para uso interno de este ejemplo
      Shared.Gui.MessageBoxCaption = "Licencia - CFDI DATA";

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(null, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(null, null, null, this.btnClose, this.btnPuertos);
      
    }

    #endregion

    #region Events

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnCargarLicencia_Click(object sender, EventArgs e)
    {
      this.CargarLicencia();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnStatusLicencia_Click(object sender, EventArgs e)
    {
      this.StatusLicencia();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnDatosLicencia_Click(object sender, EventArgs e)
    {
      this.DatosLicencia();
    }

    #endregion

    #region Factory

    public MainForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      this.ConfigurateControls();
    }

    #endregion
  }
}