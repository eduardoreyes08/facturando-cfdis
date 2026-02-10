using System;
using System.Text;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.ElectronicDocumentLibrary.StatusCfdi;

// ReSharper disable UseStringInterpolation
// ReSharper disable LocalizableElement
namespace HyperSoft.Ejemplo.StatusCfdi
{
  public partial class MainForm : Form
  {
    #region Business

    #region Vars

    private ElectronicDocumentLibrary.StatusCfdi.StatusCfdi statusCfdi;
    private readonly SslValidator sslValidator;

    #endregion

    #region Methods

    /// <summary>
    /// Método que permite consultar el STATUS de un CFDI en el SAT
    /// </summary>
    private void Consultar()
    {
      // Creamos el objeto de parametros y lo llenamos
      Parameters parameters = new Parameters
      {
        RfcEmisor = this.edtRfcEmisor.Text.Trim(),
        RfcReceptor = this.edtRfcReceptor.Text.Trim(),
        Uuid = this.edtUuid.Text.Trim(),
        Total = decimal.Parse(this.edtTotal.Text.Trim())
      };

      // Con este parámetro evitamos que se validen los datos antes
      // de hacer la consulta ante el SAT.
      // Si estas seguro que la información es correcta, puedes aplicarlo
      //parameters.ValidBeforeExecute = false;

      this.sslValidator.OverrideValidation();
      ProcessProviderResult result;
      ElectronicDocumentLibrary.StatusCfdi.Information information;
      try
      {
        // Ejecutamos la consulta
        result = this.statusCfdi.Execute(parameters, out information);
      }
      finally
      {
        this.sslValidator.RestoreValidation();
      }
      

      Chronometer.Instance.Stop();

      // Si todo es correcto mostramos el resultado
      this.redtResult.Text = result == ProcessProviderResult.Ok 
        ? this.ShowResult(information) 
        : this.ShowError(result, information.Error);
    }

    /// <summary>
    /// Método usado para mostrar el resultado de la consulta
    /// </summary>
    /// <param name="information"></param>
    /// <returns></returns>
    private string ShowResult(ElectronicDocumentLibrary.StatusCfdi.Information information)
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine();
      sb.AppendLine("RESULTADO");
      sb.AppendLine("=================================================");

      switch (information.Status)
      {
        case SatStatusType.UnKnow:
          sb.AppendLine("Status                : ");
          break;
        case SatStatusType.Active:
          sb.AppendLine("Status                : Vigente");
          break;
        case SatStatusType.Canceled:
          sb.AppendLine("Status                : Cancelado");
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }

      switch (information.FormaCancelacion)
      {
        case FormaCancelacionType.UnKnow:
          sb.AppendLine("Forma de cancelación  : ");
          break;
        case FormaCancelacionType.NoCancelable:
          sb.AppendLine("Forma de cancelación  : No cancelable");
          break;
        case FormaCancelacionType.CancelableSinAceptacion:
          sb.AppendLine("Forma de cancelación  : Cancelable sin aceptación");
          break;
        case FormaCancelacionType.CancelableConAceptacion:
          sb.AppendLine("Forma de cancelación  : Cancelable con aceptación");
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }


      switch (information.StatusCancelacion)
      {
        case StatusCancelacionType.UnKnow:
          sb.AppendLine("Status de cancelación : ");
          break;
        case StatusCancelacionType.EnProceso:
          sb.AppendLine("Status de cancelación : En proceso");
          break;
        case StatusCancelacionType.SolicitudRechazada:
          sb.AppendLine("Status de cancelación : La solicitud fue rechazada");
          break;
        case StatusCancelacionType.CanceladoPlazoVencido:
          sb.AppendLine("Status de cancelación : Cancelado por plazo vencido");
          break;
        case StatusCancelacionType.CanceladoConAceptacion:
          sb.AppendLine("Status de cancelación : Cancelado con aceptación");
          break;
        case StatusCancelacionType.CanceladoSinAceptacion:
          sb.AppendLine("Status de cancelación : Cancelado sin aceptación");
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }

      return sb.ToString();
    }

    /// <summary>
    /// Método usado para mostrar el error que se generó durante la consulta al SAT
    /// </summary>
    /// <param name="providerResult"></param>
    /// <param name="error"></param>
    /// <returns></returns>
    private string ShowError(ProcessProviderResult providerResult, InformacionError error)
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine();
      sb.AppendLine("SE GENERO UN ERROR EN LA CONSULTA");
      sb.AppendLine("=================================================");

      switch (providerResult)
      {
        case ProcessProviderResult.ErrorInDocument:
          sb.AppendLine("EL ERROR SE PRESENTO EN LOS PARAMETROS, ANTES DE CONSULTAR AL SAT");
          break;
        case ProcessProviderResult.ErrorWithProvider:
          sb.AppendLine("EL ERROR FUE GENERADO POR EL SAT.");
          break;
        case ProcessProviderResult.ErrorInConnectionWithProvider:
          sb.AppendLine("EL ERROR SE PRESENTO AL CONTACTAR EL SERVIDOR DEL SAT.");
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }

      sb.AppendLine().AppendLine();
      sb.AppendLine("Códgio      : " + error.Codigo);
      sb.AppendLine("Descripción : " + error.Descripcion);

      if (providerResult == ProcessProviderResult.ErrorWithProvider)
      {
        sb.AppendLine().AppendLine().AppendLine().AppendLine("-=-");
        sb.AppendLine("Cuando el CFDI no existe, el SAT puede regresar 2 tipos de errores:");
        sb.AppendLine("601 - La expresión impresa proporcionada no es válida.");
        sb.AppendLine("602 - Comprobante no encontrado.");
      }

      return sb.ToString();
    }

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      this.statusCfdi = new ElectronicDocumentLibrary.StatusCfdi.StatusCfdi();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // -- Código para uso interno de este ejemplo
      Gui.MessageBoxCaption = "Status de un CFDI en el SAT";

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(null, this.btnHelp, this.btnAbout, this.btnClose);
      
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

      try
      {
        this.Consultar();
      }
      finally
      {
        this.lblTime.Text = string.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger);
        System.Media.SystemSounds.Asterisk.Play();
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

      this.sslValidator = new SslValidator();
      
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