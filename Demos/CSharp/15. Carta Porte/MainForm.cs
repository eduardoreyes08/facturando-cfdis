using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;

namespace HyperSoft.Ejemplo.CartaPorte
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Vars

    private string generationDirectory;
    private ElectronicDocument electronicDocument;

    #endregion

    #region Methods

    /// <summary>
    /// Método para generar y timbrar la carta porte 3.1
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    private bool GenerarTimbrar(out string fileName)
    {
      // -= Ejemplo para AUTOTRANSPORTE
      fileName = Path.Combine(this.generationDirectory, "CartaPorte31_Autotransporte.xml");
      Data.Complemento.CartaPorte.Autotransporte.Timbrado(this.electronicDocument);

      // -= Ejemplo para TRANSPORTE AEREO
      //fileName = Path.Combine(this.generationDirectory, "CartaPorte31_TransporteAereo.xml");
      //Data.Complemento.CartaPorte.TransporteAereo.Timbrado(this.electronicDocument);

      // -= Ejemplo para TRANSPORTE FERROVIARIO
      //fileName = Path.Combine(this.generationDirectory, "CartaPorte31_TransporteFerroviario.xml");
      //Data.Complemento.CartaPorte.TransporteFerroviario.Timbrado(this.electronicDocument);

      // -= Ejemplo para TRANSPORTE MARITIMO
      //fileName = Path.Combine(this.generationDirectory, "CartaPorte31_TransporteMaritimo.xml");
      //Data.Complemento.CartaPorte.TransporteMaritimo.Timbrado(this.electronicDocument);

      // -= Se timbra la CARTA PORTE por medio de ECODEX
      if (ECodex.Timbrar(this.electronicDocument) == false)
        return false;

      // -= Se timbra la CARTA PORTE por medio de PAX
      //if (Pax.Timbrar(this.electronicDocument) == false)
      //  return false;

      Chronometer.Instance.Stop();

      // Se guarda el documento, en este punto ya contiene los datos del timbre
      if (this.electronicDocument.SaveToFile(fileName) == false)
      {
        Gui.ShowMessage(this.electronicDocument.ErrorText);
        return false;
      }

      return true;
    }

    /// <summary>
    /// Método para generar el XML de una carta porte 3.1
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    private bool GenerarXml(out string fileName)
    {
      // -= Ejemplo que muestra como llenar TODOS los datos de una carta porte 3.1
      fileName = Path.Combine(this.generationDirectory, "CartaPorte31_Completo.xml");
      Data.Complemento.CartaPorte.Completo.CargarDatos(this.electronicDocument);

      //// -= Ejemplo que muestra como llenar los datos MINIMOS de una carta porte 3.1
      //fileName = Path.Combine(this.generationDirectory, "CartaPorte31_Minimo.xml");
      //Data.Complemento.CartaPorte.Minimo.CargarDatos(this.electronicDocument);

      //// -= Ejemplo que muestra como llenar los datos LISTAS de una carta porte 3.1
      //fileName = Path.Combine(this.generationDirectory, "CartaPorte31_Listas.xml");
      //Data.Complemento.CartaPorte.Listas.CargarDatos(this.electronicDocument);

      // Se guarda el XML
      if (this.electronicDocument.SaveToFile(fileName) == false)
      {
        Gui.ShowMessage(this.electronicDocument.ErrorText);
        return false;
      }

      Chronometer.Instance.Stop();

      return true;
    }

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      // Instanciamos la clase TManageElectronicDocument
      ElectronicManage manage = new ElectronicManage().Initialization();
      
      // NOTA
      //  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del XML contra el schema
      //  . Para que se realice una validación FULL, debes activar las siguientes líneas
      //  . Si deseas conocer más al respecto:
      //       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
      //manage.Save.Options |= SaveOptions.ValidateWithSchema;
      //manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;


      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      manage.CertificateAuthorityList.UseForTest();


      //Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
      //la llave privada y el password de la misma.
      string cerFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.cer");
      string keyFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.key");
      string password = "12345678a";
      ElectronicCertificate certificate = new ElectronicCertificate().Load(cerFile, keyFile, password);

      // Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
      // y administrar TODOS los recursos que serán usados en el proceso
      manage.Save.AssignCertificate(certificate);

      // Se instancia la clase que es la encarga de llevar a cabo el proceso de generación y se le pasa
      // el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
      this.electronicDocument = new ElectronicDocument().Initialization();
      this.electronicDocument.AssignManage(manage);

      // Directorio donde van a ser almacenado los XML generados
      this.generationDirectory = Utils.CreateDirectory();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "Carta Porte 3.1";

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);

      // -- Código para uso interno de este ejemplo
      string[] description = { Properties.Resources.Timbrar, Properties.Resources.GenerarXml };
      Utilerias.Gui.Shared.Description(this.redtDescripcion, description, this.cmbOperacion);

      // -- Código para uso interno de este ejemplo
      this.lblVersion.Text = ECodex.Version();

      // -- Código para uso interno de este ejemplo
      this.cmbOperacion.SelectedIndex = 0;
    }

    #endregion

    #region Events

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnExecute_Click(object sender, EventArgs e)
    {
      // = Configuramos la interfaz del ejemplo ===========================
      this.lblTime.Text = string.Empty;
      Application.DoEvents();
      Chronometer.Instance.StartWithCursor();
      //===================================================================

      bool generatedfile = false;
      string fileName = string.Empty;
      try
      {
        switch (this.cmbOperacion.SelectedIndex)
        {
          // Se genera la carta porte y se timbra
          case 0:
            generatedfile = this.GenerarTimbrar(out fileName);
            break;

          case 1:
            generatedfile = this.GenerarXml(out fileName);
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();

        if (generatedfile && Gui.ShowQuestion(string.Format("La CARTA PORTE fue generada con éxito.{0}{0}Desea visualizarla ?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void After_Show(object sender, EventArgs e)
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      IntegrationForm.ShowForm();

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.TimerLicenciaEnabled();
    }

    #endregion

    #endregion

    #region Factory

    public MainForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      License.CargarLicencia();

      // -- Código para uso interno de este ejemplo
      this.ConfigurateControls();

      // -- Muestra como crear los objetos requeridos para este ejemplos
      this.CreateObjects();

      // -- Código para uso interno de este ejemplo
      this.Shown += this.After_Show;
    }

    #endregion
  }
}