using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;
using License = HyperSoft.Ejemplo.Utilerias.License;

// ReSharper disable RedundantNameQualifier
// ReSharper disable LocalizableElement
namespace HyperSoft.Ejemplo.Complementos
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constants

    private const string SourceDirectory = "..\\..\\..";

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Vars

    private string message;
    private string generationDirectory;
    private ElectronicDocument electronicDocument;

    #endregion

    #region Methods

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      string applicationDirectory = Application.StartupPath + SourceDirectory;

      // Instanciamos la clase TManageElectronicDocument
      ElectronicManage manage = new ElectronicManage().Initialization();

      //  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
      //  . Para que se realice una validación FULL, debes activar las siguientes líneas
      //  . Si deseas conocer más al respecto:
      //       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
      //manage.Save.Options |= SaveOptions.ValidateWithSchema;
      //manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;

      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      manage.CertificateAuthorityList.UseForTest();

      // Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
      // la llave privada y el password de la misma.
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

      // Se crea el directorio donde van a ser almacenado los CFDI generados, esto no tiene que ver con la librería,
      // solo es para mantener ordenados los archivos generados.
      this.generationDirectory = Path.Combine(applicationDirectory, "Generados");
      if (Directory.Exists(this.generationDirectory) == false)
      {
        try
        {
          Directory.CreateDirectory(this.generationDirectory);
        }
        catch
        {
          HyperSoft.Shared.Gui.ShowError(string.Format("No se pudo crear el directorio donde se van a almacenar los CFDI's.{0}{0}{1}", Environment.NewLine, this.generationDirectory));
          Application.Exit();
        }
      }

      HyperSoft.Ejemplo.Data.Complemento.Base.SetConfiguration(this.generationDirectory);

      this.lblTime.Text = string.Empty;
      this.lblVersion.Text = $"E.D.L. - {ElectronicDocument.Version()}";
      HyperSoft.Shared.Gui.MessageBoxCaption = "Complementos";
      
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      HyperSoft.Shared.Gui.MessageBoxCaption = "Complementos";

      // -- Código para uso interno de este ejemplo
      this.message = this.redtText.Text;
      this.cmbComplemento.SelectedIndex = 4;

      // -- Código para uso interno de este ejemplo
      HyperSoft.Ejemplo.Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      HyperSoft.Ejemplo.Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);      
    }

    #endregion

    #region Events

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
        switch (this.cmbComplemento.SelectedIndex)
        {
          case 1:
            generatedfile = Data.Complemento.Aerolineas10.Create(this.electronicDocument, out fileName);
            break;

          case 2:
            generatedfile = Data.Complemento.CertificadoDestruccion10.Create(this.electronicDocument, out fileName);
            break;
          
          case 3:
            generatedfile = Data.Complemento.RegistroFiscal10.Create(this.electronicDocument, out fileName);
            break;

          case 4:
            generatedfile = Data.Complemento.ComercioExterior20.Completo(this.electronicDocument, out fileName);
            break;

          case 5:
            generatedfile = Data.Complemento.ConsumoCombustibles11.Create(this.electronicDocument, out fileName);
            break;

          case 6:
            generatedfile = Data.Complemento.SectorDeVentasAlDetalle131.Create(this.electronicDocument, out fileName);
            break;

          case 7:
            generatedfile = Data.Complemento.Divisas10.Create(this.electronicDocument, out fileName);
            break;
            
          case 8:
            generatedfile = Data.Complemento.Donatarias11.Create(this.electronicDocument, out fileName);
            break;

          case 9:
            generatedfile = Data.Complemento.EstadoDeCuentaDeCombustible12.Create(this.electronicDocument, out fileName);
            break;

          case 10:
            generatedfile = Data.Complemento.HidrocarburosGastos10.Create(this.electronicDocument, out fileName);
            break;

          case 11:
            generatedfile = Data.Complemento.HidrocarburosIngresos10.Create(this.electronicDocument, out fileName);
            break;

          case 12:
            generatedfile = Data.Complemento.ImpuestosLocales10.Create(this.electronicDocument, out fileName);
            break;

          case 13:
            generatedfile = Data.Complemento.Ine11.Create(this.electronicDocument, out fileName);
            break;

          case 14:
            generatedfile = Data.Complemento.LeyendasFiscales10.Create(this.electronicDocument, out fileName);
            break;

          case 15:
            generatedfile = Data.Complemento.NotariosPublicos10.Create(this.electronicDocument, out fileName);
            break;

          case 16:
            generatedfile = Data.Complemento.ObrasArtesAntiguedades10.Create(this.electronicDocument, out fileName);
            break;

          case 17:
            generatedfile = Data.Complemento.PagoEnEspecie10.Create(this.electronicDocument, out fileName);
            break;

          case 18:
            generatedfile = Data.Complemento.PersonaFisicaIntegranteCoordinado10.Create(this.electronicDocument, out fileName);
            break;

          case 19:
            generatedfile = Data.Complemento.RenovacionSustitucionVehiculos10.Create(this.electronicDocument, out fileName);
            break;

          case 20:
            generatedfile = Data.Complemento.ServicioParcialConstruccion10.Create(this.electronicDocument, out fileName);
            break;          

          case 21:
            generatedfile = Data.Complemento.TuristaPasajeroExtranjero10.Create(this.electronicDocument, out fileName);
            break;

          case 22:
            generatedfile = Data.Complemento.ValesDespensa10.Create(this.electronicDocument, out fileName);
            break;

          case 23:
            generatedfile = Data.Complemento.VehiculoUsado10.Create(this.electronicDocument, out fileName);
            break;
          
          case 25:
            generatedfile = Data.Complemento.InstitucionesEducativas10.Create(this.electronicDocument, out fileName);
            break;

          case 26:
            generatedfile = Data.Complemento.VentaVehiculos11.Create(this.electronicDocument, out fileName);
            break;

          default:
            throw new InvalidEnumArgumentException();
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();

        if (generatedfile && HyperSoft.Shared.Gui.ShowQuestion(string.Format("El documento fue generado con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
    }

    private void cmbComplemento_SelectedIndexChanged(object sender, EventArgs e)
    {
      if ((this.cmbComplemento.SelectedIndex == 0) || (this.cmbComplemento.SelectedIndex == 24))
        this.cmbComplemento.SelectedIndex += 1;

      string text = this.cmbComplemento.Text.Trim().Trim('-').Trim();
      this.redtText.Text = string.Format(this.message, text.ToUpperInvariant());
    }

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
// ReSharper restore LocalizableElement