// ReSharper disable LocalizableElement
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;

namespace HyperSoft.Ejemplo.Cfdi33
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constans

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Vars

    private string generationDirectory;
    private ElectronicDocument electronicDocument;

    #endregion

    #region Methods

    private bool Cfdi33(out string fileName)
    {
      fileName = Path.Combine(this.generationDirectory, "CFDI33.xml");

      //En este método se cargan los datos de la factura.
      Data.Cfdi33.CargarDatosCompleto(this.electronicDocument);
      
      // Por default estan activas todas las opciones, si quisiera quitar alguna, que no se validara
      // el vencimiento o revocación del certificado con el que se va a firma,
      // se podria hacer esto:
      // manage.Save.Options -= SaveOptions.ValidateWithFoliosAutorizados; //manage.Save.Options - [ValidateWithFA]
      // A continuacion se muestran todas las opciones
      //    ValidateWithSchema,
      //    ValidateInformation,
      //    ValidateWithFoliosAutorizados,
      //    ValidateCertificateWithCA,
      //    ValidateCertificateWithCRL,
      //    AddCertificate,
      //    Sign;

      // Se ejecuta el proceso de generación
      if (this.electronicDocument.SaveToFile(fileName) == false)
      {
        Gui.ShowError(this.electronicDocument.ErrorText);
        return false;
      }

      // Para conocer como timbrar el CFDI 3.3, por favor, revisa el ejemplo PAC ECODEX

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
      //  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
      //  . Para que se realice una validación FULL, debes activar las siguientes líneas
      //  . Si deseas conocer más al respecto:
      //       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
      //this.manage.Save.Options |= SaveOptions.ValidateWithSchema;
      //this.manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;

      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      manage.CertificateAuthorityList.UseForTest();

      //Se crea la clase que va a ser usada en el proceso de firmado
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
      Gui.MessageBoxCaption = "CFDI 3.3";

      // -- Código para uso interno de este ejemplo
      this.pgcInformacion.SelectedIndex = 0;
      
      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);
      
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
      string fileName = null;
      try
      {
        switch (this.pgcInformacion.SelectedIndex)
        {
          case 0:
            generatedfile = this.Cfdi33(out fileName);
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";

        if (generatedfile && Gui.ShowQuestion(string.Format("El CFDI fue generado con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)))
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