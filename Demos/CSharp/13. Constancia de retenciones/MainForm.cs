using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;

// ReSharper disable LocalizableElement
namespace HyperSoft.Ejemplo.Complementos
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Vars

    private string message;
    private string generationDirectory;
    private ElectronicDocumentLibrary.ConstanciaRetenciones.ConstanciaRetenciones constanciaRetenciones;

    #endregion

    #region Methods

    private bool ConstanciaRetenciones(out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosCompleto(this.constanciaRetenciones);

      // Se ejecuta el proceso de generación
      fileName = Path.Combine(this.generationDirectory, "Constancia_Retenciones_20.xml");
      if (this.constanciaRetenciones.SaveToFile(fileName) == false)
      {
        Gui.ShowError(this.constanciaRetenciones.ErrorText);
        return false;
      }

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
      this.constanciaRetenciones = new ElectronicDocumentLibrary.ConstanciaRetenciones.ConstanciaRetenciones().Initialization();
      this.constanciaRetenciones.AssignManage(manage);

      // Directorio donde van a ser almacenado los XML generados
      this.generationDirectory = Utils.CreateDirectory();
      Data.Complemento.Constancias.Base.SetConfiguration(this.generationDirectory);
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "Constancia de retenciones 2.0";

      
      // -- Código para uso interno de este ejemplo
      this.pgcDocumento.SuspendLayout();
      while (this.pgcDocumento.TabPages.Count > 0)
        this.pgcDocumento.TabPages.RemoveAt(0);
      this.pgcDocumento.ResumeLayout();

      this.message = this.redtComplemento.Text;
      this.cmbTipo.SelectedIndex = 0;

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
      string fileName = string.Empty;
      try
      {
        switch (this.cmbTipo.SelectedIndex)
        {
          case 0:
            generatedfile = this.ConstanciaRetenciones(out fileName);
            break;

          case 1:
            generatedfile = Data.Complemento.Constancias.ArrendamientoEnFideicomiso.Create(this.constanciaRetenciones, out fileName);
            break;

          case 2:
            generatedfile = Data.Complemento.Constancias.Dividendos.Create(this.constanciaRetenciones, out fileName);
            break;

          case 3:
            generatedfile = Data.Complemento.Constancias.EnajenacionAcciones.Create(this.constanciaRetenciones, out fileName);
            break;

          case 4:
            generatedfile = Data.Complemento.Constancias.FideicomisoNoEmpresarial.Create(this.constanciaRetenciones, out fileName);
            break;

          case 5:
            generatedfile = Data.Complemento.Constancias.Intereses.Create(this.constanciaRetenciones, out fileName);
            break;

          case 6:
            generatedfile = Data.Complemento.Constancias.InteresesHipotecarios.Create(this.constanciaRetenciones, out fileName);
            break;

          case 7:
            generatedfile = Data.Complemento.Constancias.OperacionesConDerivados.Create(this.constanciaRetenciones, out fileName);
            break;

          case 8:
            generatedfile = Data.Complemento.Constancias.PagosAExtranjeros.Create(this.constanciaRetenciones, out fileName);
            break;

          case 9:
            generatedfile = Data.Complemento.Constancias.PlanesRetiro.Create(this.constanciaRetenciones, out fileName);
            break;

          case 10:
            generatedfile = Data.Complemento.Constancias.PlataformasTecnologicas.Create(this.constanciaRetenciones, out fileName);
            break;

          case 11:
            generatedfile = Data.Complemento.Constancias.Premios.Create(this.constanciaRetenciones, out fileName);
            break;

          case 12:
            generatedfile = Data.Complemento.Constancias.SectorFinanciero.Create(this.constanciaRetenciones, out fileName);
            break;

          default:
            throw new InvalidEnumArgumentException();
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();

        if (generatedfile && Gui.ShowQuestion(string.Format("El documento fue generado con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.pgcDocumento.SuspendLayout();
      try
      {
        if (this.pgcDocumento.TabPages.Count > 0)
          this.pgcDocumento.TabPages.RemoveAt(0);

        if (this.cmbTipo.SelectedIndex == 0)
        {
          this.pgcDocumento.TabPages.Add(this.tshConstancia);
          return;
        }

        this.pgcDocumento.TabPages.Add(this.tshComplemento);

        string text = this.cmbTipo.Text.Trim().Trim('-').Trim();
        this.redtComplemento.Text = string.Format(this.message, text.ToUpperInvariant());
      }
      finally
      {
        this.pgcDocumento.ResumeLayout();
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
      Utilerias.License.CargarLicencia();

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