using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;

namespace HyperSoft.Ejemplo.Adendas
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";
    private const string StatusText = "E.D.L. - {0} / {2} - {1}";

    #endregion

    #region Vars

    private string generationDirectory;
    private ElectronicDocument electronicDocument;
    private Dictionary<string, Data> addendas;

    #endregion

    #region Methods

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();
        
      // Instanciamos la clase TManageElectronicDocument
      ElectronicManage manage = new ElectronicManage().Initialization();

      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      manage.CertificateAuthorityList.UseForTest();

      //Se crea la clase que va a ser usada en el proceso de firmado.
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
      Gui.MessageBoxCaption = "Addendas";

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
      // -- Código para uso interno de este ejemplo
      if (License.CheckLicense() == false)
        return;

      // = Configuramos la interfaz del ejemplo ===========================
      this.lblTime.Text = string.Empty;
      Application.DoEvents();
      Chronometer.Instance.StartWithCursor();
      //===================================================================

      bool generatedfile = false;

      string fileName = string.Empty;

      Data data;
      this.addendas.TryGetValue((string)this.cmbTipo.SelectedItem, out data);
      if (data == null)
        return;

      try
      {
        generatedfile = data.Metodo(out fileName);
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();

        if (generatedfile && Gui.ShowQuestion(string.Format("El CFDI fue generado con éxito.{0}{0}¿Desea visualizarlo ?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnXmlAddenda_Click(object sender, EventArgs e)
    {
      // -- Código para uso interno de este ejemplo
      if (License.CheckLicense() == false)
        return;

      string fileName = Path.Combine(DataDirectory, "archivos\\XML de ejemplos\\3.2\\CFDI1.xml");

      FileInfo info = new FileInfo(fileName);

      Gui.ShowMessage(string.Format(
        "Este ejemplo muestra como se puede agregar una adenda a un XML{0}" +
        "previamente generado, para este caso hemos usado la adenda de{0}" +
        "ADO, pero se puede usar con cualquiera.{0}{0}" +
        "Archivo:{1}",
        Environment.NewLine, info.FullName));

      // Antes de cargar el XML al que le vamos a agregar la adenda, deshabilitamos la validacion del PAC.
      // *** ESTAS LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      LoadOptions options = this.electronicDocument.Manage.Load.Options;
      this.electronicDocument.Manage.Load.Options -= LoadOptions.ValidateStamp;
      try
      {
        //Cargamos el XML y en caso de existir un error lo mostramos
        if (this.electronicDocument.LoadFromFile(fileName) == false)
        {
          Gui.ShowError(string.Format("Se generó el siguiente error al leer el CFDI.{0}{0}{1}", Environment.NewLine, this.electronicDocument.ErrorText));
          return;
        }


        if (Adenda.Ado(out fileName) == false)
        {
          Gui.ShowError(string.Format("Se generó el siguiente error al crear el archivo XML.{0}{0}{1}", Environment.NewLine, this.electronicDocument.ErrorText));
          return;
        }

        if (Gui.ShowQuestion(string.Format("El documento fue generado con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
      finally
      {
        this.electronicDocument.Manage.Load.Options = options;
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      Data data;
      this.addendas.TryGetValue((string)this.cmbTipo.SelectedItem, out data);

      if (string.IsNullOrWhiteSpace(data.Version))
        data.Version = Adenda.GetAddendaVersion(this.cmbTipo.SelectedIndex);

      this.lblVersion.Text = string.Format(StatusText, ElectronicDocument.Version(), data.Version, this.cmbTipo.Text.ToUpper());
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void MainForm_Load(object sender, EventArgs e)
    {
      #region Addendas

      this.addendas = new Dictionary<string, Data>
      {
        {"Aba Seguros", new Data {Metodo = Adenda.Aba}},
        {"Ado", new Data {Metodo = Adenda.Ado}},
        {"AlSuper", new Data {Metodo = Adenda.AlSuper}},
        {"Altos Hornos de México", new Data {Metodo = Adenda.AltosHornosMexico}},
        {"Aluprint", new Data {Metodo = Adenda.Aluprint}},
        {"Amece", new Data {Metodo = Adenda.Amece}},
        {"Asociación mexicana de instituciones de seguros AMIS", new Data {Metodo = Adenda.Amis}},
        {"Asoforma - ASONIOSCOC", new Data {Metodo = Adenda.Asofarma}},
        {"Axxa - Autos", new Data {Metodo = Adenda.AxxaAutos}},
        {"Axxa - Gastos médicos", new Data {Metodo = Adenda.AxxaGastosMedicos}},
        {"BBVA", new Data {Metodo = Adenda.Bbva}},
        { "Bexel", new Data {Metodo = Adenda.Bexel}},
        {"BrudiFarma", new Data {Metodo = Adenda.BrudiFarma}},
        {"Capa de ozono", new Data {Metodo = Adenda.CapaOzono}},
        {"Chrysler", new Data {Metodo = Adenda.Chrysler}},
        {"Comex", new Data {Metodo = Adenda.Comex}},
        {"Continental Tire", new Data {Metodo = Adenda.ContinentalTire}},
        {"Coppel - Ropa", new Data {Metodo = Adenda.CoppelRopa}},
        {"Corporate Travel Services", new Data {Metodo = Adenda.CorporateTravelServices}},
        {"Disney", new Data {Metodo = Adenda.Disney}},
        {"Elektra", new Data {Metodo = Adenda.Elektra}},
        {"Emerson", new Data {Metodo = Adenda.Emerson}},
        {"Emsur", new Data {Metodo = Adenda.EmSur}},
        {"Envases universales de México", new Data {Metodo = Adenda.EnvasesUniversalesdeMexico}},
        {"Femsa", new Data {Metodo = Adenda.Femsa}},
        {"Ferro Mexicana", new Data {Metodo = Adenda.FerroMexicana}},
        {"Fuller", new Data {Metodo = Adenda.Fuller}},
        {"Gayosso", new Data {Metodo = Adenda.Gayosso}},
        {"General Motors", new Data {Metodo = Adenda.GeneralMotors}},
        {"Gomsa", new Data {Metodo = Adenda.Gomsa}},
        {"Grupo Modelo", new Data {Metodo = Adenda.GrupoModelo}},
        {"HEB", new Data {Metodo = Adenda.Heb}},
        {"Inbursa", new Data {Metodo = Adenda.Inbursa}},
        {"IT Smart Business", new Data {Metodo = Adenda.ItSmartBusiness}},
        {"Iusacell", new Data {Metodo = Adenda.Iusacell}},
        {"KUEHNE + NAGEL", new Data {Metodo = Adenda.Kuehne}},
        {"Lamosa", new Data {Metodo = Adenda.Lamosa}},
        {"Landsteiner", new Data {Metodo = Adenda.Landsteiner}},
        {"Loreal", new Data {Metodo = Adenda.Loreal}},
        {"Lowes", new Data {Metodo = Adenda.Lowes}},
        {"Mabe", new Data {Metodo = Adenda.Mabe}},
        {"Maersk", new Data {Metodo = Adenda.Maersk}},
        {"MultiPack", new Data {Metodo = Adenda.MultiPack}},
        {"Oxxo", new Data {Metodo = Adenda.Oxxo}},
        {"Pemex - Exploración", new Data {Metodo = Adenda.PemexExploracion}},
        {"Pemex - Refinación", new Data {Metodo = Adenda.PemexRefinacion}},
        {"Pepsico", new Data {Metodo = Adenda.Pepsico}},
        {"Pilgrims", new Data {Metodo = Adenda.Pilgrims}},
        {"Prolec", new Data {Metodo = Adenda.Prolec}},
        {"Sanmina", new Data {Metodo = Adenda.Sanmina}},
        {"Santander", new Data {Metodo = Adenda.Santander}},
        {"Sector Primario", new Data {Metodo = Adenda.SectorPrimario}},
        {"Seven Eleven", new Data {Metodo = Adenda.SevenEleven}},
        {"Soler & Palau", new Data {Metodo = Adenda.SolerPalau}},
        {"Soriana - Remision", new Data {Metodo = Adenda.SorianaRemision}},
        {"Soriana - Servicio", new Data {Metodo = Adenda.SorianaServicio}},
        {"Tiendas neto", new Data {Metodo = Adenda.TiendasNeto}},
        {"Transportes Castores", new Data {Metodo = Adenda.TransportesCastores}},
        {"Tres M", new Data {Metodo = Adenda.TresM}},
        {"Tv Azteca", new Data {Metodo = Adenda.TvAzteca}},
        {"Viscofan", new Data {Metodo = Adenda.Viscofan}},
        {"Volkswagen", new Data {Metodo = Adenda.Volkswagen}},
        {"WalMart", new Data {Metodo = Adenda.WalMart}},
        {"ZF México", new Data {Metodo = Adenda.ZfMexico}}
      };

      string[] texto = new string[this.addendas.Count];
      this.addendas.Keys.CopyTo(texto, 0);
      this.cmbTipo.Items.Clear();
      this.cmbTipo.Items.AddRange(texto);
      #endregion

      // -- Código para uso interno de este ejemplo
      this.cmbTipo.SelectedIndex = 0;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void After_Show(object sender, EventArgs e)
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      IntegrationForm.ShowForm();

      Adenda.SetConfiguration(this.generationDirectory, this.electronicDocument);

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