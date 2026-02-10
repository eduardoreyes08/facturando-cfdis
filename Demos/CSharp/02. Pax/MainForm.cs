using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.ElectronicDocumentLibrary.Pax.Timbrado.Resultado;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.ElectronicDocumentLibrary.Pax;

namespace HyperSoft.Ejemplo.Pax
{
  public partial class MainForm : Form
  {
    #region Bussines

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Vars

    private TabPage[] pages;

    private string generationDirectory;
    private ElectronicManage manage;
    private ElectronicCertificate certificate;
    private ElectronicDocument electronicDocument;
    private ConstanciaRetenciones constanciaRetenciones;
    private Proveedor proveedor;

    #endregion

    #region Methods

    private bool TimbrarCfdi(out string fileName)
    {
      TimbrarParameters parameters = new TimbrarParameters().Initialization();
      try
      {
        // - En este método se cargan los datos de la FACTURA
        Cfdi40.CargarDatosTimbrado(this.electronicDocument);
        fileName = Path.Combine(this.generationDirectory, "CFDI40.xml");

        // - En este método se cargan los datos de un RECIBO DE PAGO 2.0
        // Data.Complemento.ReciboPago20.CargarDatosTimbrado(this.electronicDocument);
        // fileName = Path.Combine(this.generationDirectory, "recibo_pago_20.xml");

        // - En este método se cargan los datos de un RECIBO DE NÓMINA 1.2
        // Data.Complemento.Nomina12.CargarDatosCfdi40Timbrado(this.electronicDocument);
        // fileName = Path.Combine(this.generationDirectory, "recibo_nomina_12.xml");

        // - En este método se cargan los datos de una CARTA PORTE 2.0
        // Data.Complemento.CartaPorte.Timbrado.CargarDatos(this.electronicDocument);
        // fileName = Path.Combine(this.generationDirectory, "carta_porte_20.xml");

        ContribuyentePax(this.electronicDocument);

        // Se crea el objeto que contiene la información retornada por el PAC
        Informacion informacion = new Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.Usuario.Value = this.txtUsuario.Text;
        parameters.Password.Value = this.txtPassword.Text;
        parameters.Identificador.Value = this.txtIdentificador.Text;
        parameters.ElectronicDocument = this.electronicDocument;
        parameters.TipoDocumento = DocumentType.Factura;
        parameters.TestMode = this.chkPrueba.Checked;
        parameters.Informacion = informacion;

        // Se envia a timbrar el documento
        ProcessProviderResult result = this.proveedor.TimbrarCfdi(parameters);

        Chronometer.Instance.Stop();

        // En este caso se verifica que el proceso fue correcto
        if (result == ProcessProviderResult.Ok)
        {
          //this.txtUuidCancelacion.Text = informacion.Timbre.Uuid.Value;
          //this.chkCancelarConstancia.Checked = false;
        }

        // Se le da formato a la información retornada por el PAC
        string resultadoTexto = this.FormatInformationTimbre(informacion, result, this.electronicDocument.FingerPrintPac);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Timbrado CFDI", resultadoTexto);

        if (result != ProcessProviderResult.Ok)
          return false;

        // Se guarda el documento, en este punto ya contiene los datos del timbre
        SaveOptions options = this.electronicDocument.Manage.Save.Options;
        this.electronicDocument.Manage.Save.Options = SaveOptions.EncodeApostrophe;
        try
        {
          this.electronicDocument.SaveToFile(fileName);
        }
        catch
        {
          Gui.ShowError(this.electronicDocument.ErrorText);
          return false;
        }
        finally
        {
          this.electronicDocument.Manage.Save.Options = options;
        }
        return true;
      }
      finally
      {
        parameters.Dispose();
        Chronometer.Instance.Stop();
      }
    }

    private bool TimbrarConstanciaRetenciones(out string fileName)
    {
      fileName = Path.Combine(this.generationDirectory, "Constancia_Retenciones_20.xml");

      TimbrarConstanciaRetencionesParameters parameters = new TimbrarConstanciaRetencionesParameters().Initialization();
      try
      {
        //En este método se cargan los datos de la constancia.
        ConstanciaRetenciones20.CargarDatosTimbrado(this.constanciaRetenciones);

        this.constanciaRetenciones.Data.Emisor.Rfc.Value = "AAA010101AAA";
        this.constanciaRetenciones.Data.Emisor.RazonSocial.Value = "INDISTRIA ILUMINADORA DE ALMACENES SA DE CV";
        this.constanciaRetenciones.Data.Emisor.RegimenFiscal.Value = "601";

        // Se crea el objeto que contiene la información retornada por el PAC
        Informacion informacion = new Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.Usuario.Value = this.txtUsuario.Text;
        parameters.Password.Value = this.txtPassword.Text;
        parameters.Identificador.Value = this.txtIdentificador.Text;
        parameters.ConstanciaRetenciones = this.constanciaRetenciones;
        parameters.TipoConstancia = 1;
        parameters.TestMode = this.chkPrueba.Checked;
        parameters.Informacion = informacion;

        // Se envia a timbrar el documento
        ProcessProviderResult result = this.proveedor.TimbrarConstanciaRetenciones(parameters);

        Chronometer.Instance.Stop();

        // En este caso se verifica que el proceso fue correcto
        if (result == ProcessProviderResult.Ok)
        {
          //this.txtUuidCancelacion.Text = informacion.Timbre.Uuid.Value;
          //this.chkCancelarConstancia.Checked = true;
        }

        // Se le da formato a la información retornada por el PAC
        string resultadoTexto = this.FormatInformationTimbre(informacion, result, this.constanciaRetenciones.FingerPrintPac);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Timbrado de una CONSTANCIA DE RETENCIONES", resultadoTexto);

        if (result != ProcessProviderResult.Ok)
          return false;

        // Se guarda el documento, en este punto ya contiene los datos del timbre
        SaveOptions options = this.constanciaRetenciones.Manage.Save.Options;
        this.constanciaRetenciones.Manage.Save.Options = SaveOptions.EncodeApostrophe;
        try
        {
          this.constanciaRetenciones.SaveToFile(fileName);
        }
        catch
        {
          Gui.ShowError(this.constanciaRetenciones.ErrorText);
          return false;
        }
        finally
        {
          this.constanciaRetenciones.Manage.Save.Options = options;
        }
        return true;
      }
      finally
      {
        parameters.Dispose();
        Chronometer.Instance.Stop();
      }
    }

    private void CancelarCfdi(bool isConstancia)
    {
      CancelarParameters parameters = new CancelarParameters().Initialization();
      try
      {
        // Se crea el objeto que contiene la información retornada por el PAC
        ElectronicDocumentLibrary.Pax.Cancelar.Informacion informacion = new ElectronicDocumentLibrary.Pax.Cancelar.Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.Usuario.Value = this.txtUsuario.Text;
        parameters.Password.Value = this.txtPassword.Text;
        parameters.Identificador.Value = this.txtIdentificador.Text;
        parameters.TestMode = this.chkPrueba.Checked;
        parameters.Informacion = informacion;
        parameters.ConstanciaRetenciones = isConstancia;

        parameters.RfcEmisor.Value = "AAA010101AAA";
        parameters.RfcReceptor.Add("AAA010101AAA");
        parameters.Uuid.Add("dbfd9f2f-1b75-4e07-a865-082d0dbc7712");
        parameters.Total.Add(new decimal(10.77));
        parameters.Motivo.Add("02");

        // En caso de no existir folio de sustitución, se tiene que agregar vacío
        parameters.FolioSustitucion.Add("");

        // Se envia a cancelar el documento
        ProcessProviderResult result = this.proveedor.CancelarCfdi(parameters);

        Chronometer.Instance.Stop();

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationCancelacion(informacion, result);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Cancelar CFDI", texto);
      }
      finally
      {
        parameters.Dispose();
        Chronometer.Instance.Stop();
      }
    }

    private void ObtenerFechaHora()
    {
      // Se crea el objeto que contiene la información retornada por el PAC
      ElectronicDocumentLibrary.Pax.FechaHora.Informacion informacion = new ElectronicDocumentLibrary.Pax.FechaHora.Informacion().Initialization();

      // Se obtiene la hora y fecha que tiene el servidor de timbrado del PAC
      ProcessProviderResult result = this.proveedor.FechaHora(informacion);

      Chronometer.Instance.Stop();

      // Se le da formato a la información retornada por el PAC
      string texto = this.FormatInformationFechaHora(informacion, result);

      // Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Hora y Fecha del PAC", texto);
    }

    private string FormatInformationTimbre(Informacion informacion, ProcessProviderResult providerResult, string cadenaOrignal)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.Timbre.IsAssigned)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION DEL TIMBRE");
        text.AppendLine("=================================================");
        text.AppendLine("Versión                       : " + informacion.Timbre.Version.AsString());
        text.AppendLine("UUID                          : " + informacion.Timbre.Uuid.AsString());
        text.AppendLine("Fecha de timbrado             : " + informacion.Timbre.FechaTimbrado.AsString());
        text.AppendLine("Sello del CFD                 : " + informacion.Timbre.SelloCfd.AsString());
        text.AppendLine("Número de Certificado del SAT : " + informacion.Timbre.NumeroCertificadoSat.AsString());
        text.AppendLine("Sello del SAT                 : " + informacion.Timbre.SelloSat.AsString());
        text.AppendLine("Leyenda                       : " + informacion.Timbre.Leyenda.AsString());
        text.AppendLine("RFC del PAC                   : " + informacion.Timbre.RfcProveedorCertificacion.AsString());
        text.AppendLine();
        text.AppendLine();
        text.AppendLine("CADENA ORIGINAL DEL COMPLEMENTO");
        text.AppendLine("==============================================");
        text.AppendLine("Cadena original    : " + cadenaOrignal);
        text.AppendLine();
        text.AppendLine();
      }

      if (informacion.Error.IsAssigned == false)
        return text.ToString();

      this.FormatTypeError(text, providerResult);

      text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      text.AppendLine("=================================================");
      text.AppendLine("Número      : " + informacion.Error.Numero.Value);
      text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return text.ToString();
    }

    private string FormatInformationCancelacion(ElectronicDocumentLibrary.Pax.Cancelar.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.Folios.Count > 0)
      {
        text.AppendLine("FOLIOS");
        text.AppendLine("=================================================");

        for (int i = 0; i < informacion.Folios.Count; i++)
        {
          text.AppendLine("UUID        : " + informacion.Folios[i].Uuid.Value);
          text.AppendLine("Status      : " + informacion.Folios[i].Status.Value);
          text.AppendLine("Descripción : " + informacion.Folios[i].Description.Value);
          text.AppendLine("Fecha       : " + informacion.Folios[i].Fecha.Value);

          if ((informacion.Folios[i].Status.Value == 201) || (informacion.Folios[i].Status.Value == 202))
            text.AppendLine("CANCELADO");

          text.AppendLine();
        }
      }


      if (informacion.Error.IsAssigned == false)
        return text.ToString();

      this.FormatTypeError(text, providerResult);

      text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      text.AppendLine("=================================================");
      text.AppendLine("Número      : " + informacion.Error.Numero.Value);
      text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return text.ToString();
    }

    private string FormatInformationFechaHora(ElectronicDocumentLibrary.Pax.FechaHora.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.FechaHora.IsAssigned)
      {
        text
          .Append("Fecha y Hora en el PAC : ").AppendLine(informacion.FechaHora.Value.ToString(CultureInfo.CurrentCulture))
          .Append("Fecha y Hora actual    : ").AppendLine(DateTime.Now.ToString(CultureInfo.CurrentCulture))
          .Append("Diferencia             : ").Append(DateTime.Now - informacion.FechaHora.Value)
          ;
      }

      if (informacion.Error.IsAssigned == false)
        return text.ToString();

      this.FormatTypeError(text, providerResult);

      text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      text.AppendLine("=================================================");
      text.AppendLine("Número      : " + informacion.Error.Numero.Value);
      text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return text.ToString();
    }

    private void FormatTypeError(StringBuilder text, ProcessProviderResult providerResult)
    {
      if (providerResult == ProcessProviderResult.Ok)
        return;

      text.AppendLine();
      text.AppendLine();
      text.AppendLine("=================================================");
      switch (providerResult)
      {
        case ProcessProviderResult.ErrorInDocument:
          text.AppendLine("EL ERROR SE PRESENTO AL GENERAR LOS PARAMETROS,");
          text.AppendLine("ANTES DE EJECUTAR LA OPERACION CON EL PAC.");
          break;

        case ProcessProviderResult.ErrorWithProvider:
          text.AppendLine("EL ERROR FUE GENERADO POR EL PAC.");
          break;

        case ProcessProviderResult.ErrorInConnectionWithProvider:
          text.AppendLine("EL ERROR SE PRESENTO AL CONTACTAR EL SERVIDOR DEL PAC.");
          break;

        default:
          throw new ArgumentOutOfRangeException();
      }
      text.AppendLine("=================================================");
      text.AppendLine();
      text.AppendLine();
    }

    private static void ContribuyentePax(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Emisor.Rfc.Value = "AAA010101AAA";
      electronicDocument.Data.Emisor.Nombre.Value = "INDISTRIA ILUMINADORA DE ALMACENES SA DE CV";
      electronicDocument.Data.Emisor.RegimenFiscal.Value = "601";      
    }

    /// <summary>
    /// Método que muestra como crear los objetos a usar en este ejemplos
    /// </summary>
    private void CreateObjects()
    {
      // Se configuran algunas opciones de la librería
      Configuration.Library();

      // Se crea el objeto que representa al PAC y para este ejemplo lo he configurado 
      // con los parámetros de prueba de la conexión. Para mayor información acerca de 
      // lo relación con el PAC póngase en contacto con el mismo.
      this.proveedor = new Proveedor().Initialization();

      // Instanciamos la clase TManageElectronicDocument
      this.manage = new ElectronicManage().Initialization();


      // NOTA
      //  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
      //  . Para que se realice una validación FULL, debes activar las siguientes líneas
      //  . Si deseas conocer más al respecto:
      //       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
      //this.manage.Save.Options |= SaveOptions.ValidateWithSchema;
      //this.manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;


      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      this.manage.CertificateAuthorityList.UseForTest();

      // Con esta línea evitamos usar el archivo CSD.txt que emite el SAT
      this.manage.Save.Options -= SaveOptions.ValidateCertificateWithCrl;

      // Esta línea es requerida para el ambiente de pruebas porque se esta usando el RFC AAA010101AAA
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      this.manage.Save.Options -= SaveOptions.ValidateCertificateSubject;


      //Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
      //la llave privada y el password de la misma.
      string cerFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.cer");
      string keyFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.key");
      string password = "12345678a";
      this.certificate = new ElectronicCertificate().Load(cerFile, keyFile, password);

      // Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
      // y administrar TODOS los recursos que serán usados en el proceso
      this.manage.Save.AssignCertificate(this.certificate);

      // Se instancia la clase que es la encarga de llevar a cabo el proceso de generación de la FACTURA ELECTRONICA (CFDI)
      // y se le pasa el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
      this.electronicDocument = new ElectronicDocument().Initialization();
      this.electronicDocument.AssignManage(this.manage);


      // Se instancia la clase que es la encarga de llevar a cabo el proceso de generación de la CONSTANCIA DE RETENCIONES Y PAGOS
      // y se le pasa el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
      this.constanciaRetenciones = new ConstanciaRetenciones().Initialization();
      this.constanciaRetenciones.AssignManage(this.manage);


      // Directorio donde van a ser almacenado los XML generados
      this.generationDirectory = Utils.CreateDirectory();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "PAX FACTURACION";

      // -- Código para uso interno de este ejemplo
      this.pages = new[]{
        this.tshTimbrado, this.tshConstanciaRetenciones, this.tshCancelacion,
        this.tshFechaHora, this.tshParameters
      };

      // -- Código para uso interno de este ejemplo
      this.pgcInformacion.SuspendLayout();
      while (this.pgcInformacion.TabPages.Count > 0)
        this.pgcInformacion.TabPages.RemoveAt(0);
      this.pgcInformacion.ResumeLayout();

      // -- Código para uso interno de este ejemplo
      this.cmbOperacion.SelectedIndex = 0;

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);

      // -- Código para uso interno de este ejemplo
      this.txtIdentificador.Text = Utilerias.Pax.Identificador("AAA010101AAA");
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
          // Timbrar un documento
          case 0:
            generatedfile = this.TimbrarCfdi(out fileName);
            break;
          
          // Timbrar un constancia de retenciones y pagos
          case 1:
            generatedfile = this.TimbrarConstanciaRetenciones(out fileName);
            break;

          // Cancelar un documento
          case 2:
            this.CancelarCfdi(false);
            break;

          // Obtener la fecha y hora del PAC
          case 3:
            this.ObtenerFechaHora();
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
      }
      finally
      {
        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
        System.Media.SystemSounds.Asterisk.Play();

        if (generatedfile && Gui.ShowQuestion(string.Format("El documento fue generado con éxito.{0}{0}¿Desea visualizarlo?", Environment.NewLine)))
          Process.Start(Path.GetFullPath(fileName));
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void CmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.pgcInformacion.SuspendLayout();
      try
      {
        if (this.pgcInformacion.TabPages.Count > 0)
          this.pgcInformacion.TabPages.RemoveAt(0);

        this.pgcInformacion.TabPages.Add(this.pages[this.cmbOperacion.SelectedIndex]);
        this.btnExecute.Enabled = this.cmbOperacion.SelectedIndex != (this.cmbOperacion.Items.Count - 1);
      }
      finally
      {
        this.pgcInformacion.ResumeLayout();
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.electronicDocument.UnAssignManage();

      this.constanciaRetenciones.UnAssignManage();

      this.manage.Save.UnAssignCertificate();

      this.certificate?.Dispose();
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

      // -- Código para uso interno de este ejemplo
      this.lblVersion.Text = $"E.D.L. - {ElectronicDocument.Version()} / PAX - {Proveedor.Version()}";
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