// ReSharper disable LocalizableElement
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
using HyperSoft.ElectronicDocumentLibrary.ECodex;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Shared;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.ElectronicDocumentLibrary;
using HyperSoft.ElectronicDocumentLibrary.Cancelacion;
using Informacion = HyperSoft.ElectronicDocumentLibrary.ECodex.Timbre.Informacion;

namespace HyperSoft.Ejemplo.ECodex
{
  public partial class MainForm : Form
  {
    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";

    private const bool UseOwnTokenDefinition = true;
    private const bool SetDateTimeServerDefinition = true;

    #endregion

    #region Vars

    private TabPage[] pages;

    private string generationDirectory;
    private ElectronicManage manage;
    private ElectronicCertificate certificate;
    private ElectronicDocument electronicDocument;
    private ConstanciaRetenciones constanciaRetenciones;
    private Proveedor proveedor;

    private DateTime dateTimeServer = DateTime.MinValue;
    private DateTime dateLastToken = DateTime.Now;

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

        // - En este método se cargan los datos de una COMERCIO EXTERIOR 2.0
        // HyperSoft.Ejemplo.Data.Complemento.ComercioExterior20.Timbrado(this.electronicDocument);
        // fileName = Path.Combine(this.generationDirectory, "comercio_exterior_20.xml");

        // Se crea el objeto que contiene la información retornada por el PAC
        Informacion informacion = new Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.ElectronicDocument = this.electronicDocument;
        parameters.Informacion = informacion;
        parameters.Rfc.Value = this.electronicDocument.Data.Emisor.Rfc.Value;
        parameters.IdTransaccion.Value = long.MaxValue;
        parameters.TestMode = Utilerias.Gui.Timbrado.IsTestMode();
        parameters.Enviroment = Utilerias.Gui.Timbrado.Enviroment();
        parameters.UseHttps = this.chkUseHttps.Checked;

        // Se envia a timbrar el documento
        ProcessProviderResult result = this.proveedor.GenerarTimbre(parameters);

        Chronometer.Instance.Stop();

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationTimbre(parameters.IdTransaccion.Value, informacion, result, this.electronicDocument.FingerPrintPac);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Timbrado CFDI", texto);

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

        // Se crea el objeto que contiene la información retornada por el PAC
        Informacion informacion = new Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.ConstanciaRetenciones = this.constanciaRetenciones;
        parameters.Informacion = informacion;
        parameters.Rfc.Value = this.constanciaRetenciones.Data.Emisor.Rfc.Value;
        parameters.IdTransaccion.Value = long.MaxValue;
        parameters.TestMode = Utilerias.Gui.Timbrado.IsTestMode();
        parameters.Enviroment = Utilerias.Gui.Timbrado.Enviroment();
        parameters.UseHttps = this.chkUseHttps.Checked;

        // Se envia a timbrar el documento
        ProcessProviderResult result = this.proveedor.GenerarTimbreConstanciaRetenciones(parameters);

        Chronometer.Instance.Stop();

        // En este caso se verifica que el proceso fue correcto
        if (result == ProcessProviderResult.Ok)
          this.txtUuidDescargaCfdi.Text = informacion.Timbre.Uuid.Value;

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationTimbre(parameters.IdTransaccion.Value, informacion, result, this.constanciaRetenciones.FingerPrintPac);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Timbrado de una CONSTANCIA DE RETENCIONES", texto);

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

    /// <summary>
    /// Método con el que podrás solicitar la cancelación de un UUID y podrás indicar el motivo de la misma.
    /// Para conocer como funciona el proceso de cancelación puedes leer aquí:
    /// https://www.facturando.mx/blog/index.php/2022/04/18/sat-problema-al-cancelar-un-cfdi-con-clave-01/
    /// </summary>
    private void SolicitudCancelacionCfdi()
    {
      CancelCfdi cancelCfdi = new CancelCfdi().Initialization();
      cancelCfdi.AssignManage(this.manage);

      cancelCfdi.Data.TipoDocumento = DocumentType.Cfdi;
      cancelCfdi.Data.RfcEmisor.Value = this.txtRfcEmisorCancelacion.Text;
      cancelCfdi.Data.Fecha.Value = DateTime.Now;
      
      Folio folio = cancelCfdi.Data.Folios.Add();
      folio.Uuid.Value = this.txtUuidCancelacion.Text;
      folio.Motivo.Value = this.txtMotivoCancelacion.Text;
      
      if (string.IsNullOrEmpty(this.txtUuidSustitucionCancelacion.Text) == false)
        folio.FolioSustitucion.Value = this.txtUuidSustitucionCancelacion.Text;

      CancelarMotivoParameters parameters = new CancelarMotivoParameters().Initialization();

      try
      {
        // Se crea el objeto que contiene la información retornada por el PAC
        InformacionCancelarMotivo informacion = new InformacionCancelarMotivo().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.CancelCfdi = cancelCfdi;
        parameters.Informacion = informacion;
        parameters.TestMode = Utilerias.Gui.Timbrado.IsTestMode();
        parameters.IdTransaccion = Guid.NewGuid().ToString();
        parameters.FullErrorDescription = true;
        parameters.OtroPac = this.chkOtroPac.Checked;

        // Se envia a cancelar el documento 
        ProcessProviderResult result = this.proveedor.CancelarCfdi(parameters);

        Chronometer.Instance.Stop();

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationCancelarCfdi(parameters.IdTransaccion, informacion, result);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Cancelar CFDI", texto);
      }
      finally
      {
        cancelCfdi.UnAssignManage();
      }
    }

    private void AcuseSolicitudCancelacion()
    {
      AcuseCancelacionMotivoParameters parameters = new AcuseCancelacionMotivoParameters().Initialization();
      try
      {
        // Se crea el objeto que contiene la información retornada por el PAC
        ElectronicDocumentLibrary.ECodex.AcuseCancelacion.Informacion informacion = new ElectronicDocumentLibrary.ECodex.AcuseCancelacion.Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.Informacion = informacion;
        parameters.TestMode = Utilerias.Gui.Timbrado.IsTestMode();
        parameters.RfcEmisor = this.txtRfcEmisorAcuse.Text;
        parameters.Uuid = this.txtUuidAcuse.Text;
        parameters.IdTransaccion = Guid.NewGuid().ToString();
        parameters.FullErrorDescription = true;

        // Se envia a cancelar el documento
        ProcessProviderResult result = this.proveedor.AcuseCancelacion(parameters);

        Chronometer.Instance.Stop();

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationAcuseCancelacion(parameters.IdTransaccion, informacion, result);

        ResultForm.ShowResult("Acuse de cancelación", texto);
      }
      finally
      {
        Chronometer.Instance.Stop();
      }
    }

    private void ObtenerFechaHora()
    {
      // Se crea el objeto que contiene la información retornada por el PAC
      ElectronicDocumentLibrary.ECodex.FechaHora.Informacion informacion = new ElectronicDocumentLibrary.ECodex.FechaHora.Informacion().Initialization();

      // Se obtiene la hora y fecha que tiene el servidor de timbrado del PAC
      ProcessProviderResult result = this.proveedor.FechaHora(informacion);

      Chronometer.Instance.Stop();

      // Se le da formato a la información retornada por el PAC
      string texto = this.FormatInformationFechaHora(informacion, result);

      // Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Hora y Fecha del PAC", texto);
    }

    private void DescargarCfdi()
    {
      ObtenerCfdiParameters parameters = new ObtenerCfdiParameters().Initialization();
      try
      {
        // Se crea el objeto que contiene la información retornada por el PAC
        ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion informacion = new ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.Informacion = informacion;
        parameters.Rfc.Value = this.txtRfcEmisorDescarga.Text;
        parameters.Uuid.Value = this.txtUuidDescargaCfdi.Text;
        parameters.IdTransaccion.Value = long.MaxValue;
        parameters.TestMode = Utilerias.Gui.Timbrado.IsTestMode();
        parameters.Enviroment = Utilerias.Gui.Timbrado.Enviroment();
        parameters.UseHttps = this.chkUseHttps.Checked;


        // Se obtiene el CFDI
        ProcessProviderResult result = this.proveedor.ObtenerCfdi(parameters);

        Chronometer.Instance.Stop();

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationObtenerCfdi(parameters.IdTransaccion.Value, informacion, result);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Obtener CFDI", texto);
      }
      finally
      {
        parameters.Dispose();
        Chronometer.Instance.Stop();
      }
    }

    private void EstadoCuentaCliente()
    {
      EstadoClienteParameters parameters = new EstadoClienteParameters().Initialization();
      try
      {
        // Se crea el objeto que contiene la información retornada por el PAC
        ElectronicDocumentLibrary.ECodex.EstadoCliente.Informacion informacion = new ElectronicDocumentLibrary.ECodex.EstadoCliente.Informacion().Initialization();

        // Se asigna los parámetros a usar durante el proceso
        parameters.Informacion = informacion;
        parameters.Rfc.Value = this.txtRfcEmpresa.Text;
        parameters.IdTransaccion.Value = long.MaxValue;
        parameters.TestMode = Utilerias.Gui.Timbrado.IsTestMode();
        parameters.Enviroment = Utilerias.Gui.Timbrado.Enviroment();
        parameters.UseHttps = this.chkUseHttps.Checked;

        // Se obtiene el estado de cuenta del RFC
        ProcessProviderResult result = this.proveedor.EstadoCliente(parameters);

        Chronometer.Instance.Stop();

        // Se le da formato a la información retornada por el PAC
        string texto = this.FormatInformationEstadoCuentaCliente(parameters.IdTransaccion.Value, informacion, result);

        // Se muestra en pantalla el resultado del proceso
        ResultForm.ShowResult("Obtener aviso", texto);
      }
      finally
      {
        parameters.Dispose();
        Chronometer.Instance.Stop();
      }
    }

    private string FormatInformationTimbre(long idTransaccion, Informacion informacion,
      ProcessProviderResult providerResult, string cadenaOrignal)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.DownloadedByHash)
      {
        text.AppendLine("==================================================");
        text.AppendLine("***      COMPROBANTE PREVIAMENTE GENERADO      ***");
        text.AppendLine("==================================================");
        text.AppendLine(string.Empty);
        text.AppendLine(string.Empty);
      }

      if (informacion.Timbre.IsAssigned)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION DEL TIMBRE");
        text.AppendLine("=================================================");
        text.AppendLine("Versión                    : " + informacion.Timbre.Version.AsString());
        text.AppendLine("UUID                       : " + informacion.Timbre.Uuid.AsString());
        text.AppendLine("Fecha de timbrado          : " + informacion.Timbre.FechaTimbrado.AsString());
        text.AppendLine("Sello del CFD              : " + informacion.Timbre.SelloCfd.AsString());
        text.AppendLine("No. de Certificado del SAT : " + informacion.Timbre.NumeroCertificadoSat.AsString());
        text.AppendLine("Sello del SAT              : " + informacion.Timbre.SelloSat.AsString());
        text.AppendLine("Leyenda                    : " + informacion.Timbre.Leyenda.AsString());
        text.AppendLine("RFC del PAC                : " + informacion.Timbre.RfcProveedorCertificacion.AsString());
        text.AppendLine();
        text.AppendLine("CADENA ORIGINAL DEL COMPLEMENTO");
        text.AppendLine("==============================================");
        text.AppendLine("Cadena original    : " + cadenaOrignal);
        text.AppendLine();
      }

      if (idTransaccion != 0)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION DE LA TRANSACCION");
        text.AppendLine("=================================================");
        text.AppendLine("Número de transacción         : " + idTransaccion);
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

    private string FormatInformationAcuseCancelacion(string idTransaccion, ElectronicDocumentLibrary.ECodex.AcuseCancelacion.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder builder = new StringBuilder();

      #region Se lee la informacion del acuse

      if (informacion.Error.IsAssigned == false)
      {
        try
        {
          ElectronicDocumentLibrary.RecieptCancel.RecieptCancel recieptCancel = new ElectronicDocumentLibrary.RecieptCancel.RecieptCancel().Initialization();
          recieptCancel.LoadFromString(informacion.Acuse.Value);

          builder.AppendLine(string.Empty);
          builder.AppendLine("RESULTADO");
          builder.AppendLine("=================================================");
          builder.AppendLine("RFC : " + recieptCancel.Data.RfcEmisor.Value);
          builder.AppendLine("Fecha de cancelación : " + recieptCancel.Data.Fecha.AsString());

          for (int i = 0; i < recieptCancel.Data.Documentos.Count; i++)
          {
            builder.AppendLine();
            builder.AppendLine("UUID : " + recieptCancel.Data.Documentos[i].Uuid.Value);
            builder.AppendLine("Status : " + recieptCancel.Data.Documentos[i].Status.Value);
            builder.AppendLine("Status description : " + recieptCancel.Data.Documentos[i].StatusDescription.Value);
          }

          builder.AppendLine();
          builder.AppendLine("Status : " + informacion.Status.Value);
          builder.AppendLine("XML : " + recieptCancel.Data.Xml.Value);
        }
        catch (Exception)
        {
          builder.AppendLine("RESULTADO");
          builder.AppendLine("=================================================");
          builder.AppendLine("Mensaje retornado : " + informacion.Acuse.Value);
        }

        builder.AppendLine();
      }

      #endregion

      if (string.IsNullOrEmpty(idTransaccion) == false)
      {
        builder.AppendLine();
        builder.AppendLine("INFORMACION DE LA TRANSACCION");
        builder.AppendLine("=================================================");
        builder.AppendLine("Id de la transacción : " + idTransaccion);
      }

      if (informacion.Error.IsAssigned == false)
        return builder.ToString();

      this.FormatTypeError(builder, providerResult);

      builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      builder.AppendLine("=================================================");
      builder.AppendLine("Número      : " + informacion.Error.Numero.Value);
      builder.AppendLine("Código      : " + informacion.Error.Codigo.Value);
      builder.AppendLine("Mensaje     : " + informacion.Error.Mensaje.Value);
      builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return builder.ToString();
    }

    private string FormatInformationEstadoCfdi(long idTransaccion, ElectronicDocumentLibrary.ECodex.EstadoCfdi.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.Estado.Codigo.IsAssigned)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION");
        text.AppendLine("=================================================");
        text.AppendLine("Código       : " + informacion.Estado.Codigo.AsString());
        text.AppendLine("Descripci+on : " + informacion.Estado.Descripcion.Value);
      }

      if (idTransaccion != 0)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION DE LA TRANSACCION");
        text.AppendLine("=================================================");
        text.AppendLine("Número de transacción         : " + idTransaccion);
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

    private string FormatInformationObtenerCfdi(long idTransaccion, ElectronicDocumentLibrary.ECodex.ObtenerCfdi.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.Xml.IsAssigned)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION");
        text.AppendLine("=================================================");
        text.AppendLine("Xml : " + informacion.Xml.Value);
      }

      if (idTransaccion != 0)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION DE LA TRANSACCION");
        text.AppendLine("=================================================");
        text.AppendLine("Número de transacción         : " + idTransaccion);
      }

      if (informacion.Error.IsAssigned == false) return text.ToString();

      this.FormatTypeError(text, providerResult);

      text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      text.AppendLine("=================================================");
      text.AppendLine("Número      : " + informacion.Error.Numero.Value);
      text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return text.ToString();
    }

    private string FormatInformationEstadoCuentaCliente(long idTransaccion, ElectronicDocumentLibrary.ECodex.EstadoCliente.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.EstadoCliente.IsAssigned)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION");
        text.AppendLine("=================================================");
        text.AppendLine("Código       : " + informacion.EstadoCliente.Codigo.Value);
        text.AppendLine("Descripción  : " + informacion.EstadoCliente.Descripcion.Value);
        text.AppendLine("Fecha inicio : " + informacion.EstadoCliente.FechaInicio.AsString());
        text.AppendLine("Fecha fin : " + informacion.EstadoCliente.FechaFin.AsString());
        text.AppendLine("Timbres asignados : " + informacion.EstadoCliente.TimbresAsignados.Value);
        text.AppendLine("Timbres disponibles : " + informacion.EstadoCliente.TimbresDisponibles.Value);
        foreach (string certificado in informacion.EstadoCliente.Certificados)
        {
          text.AppendLine("Certificado : " + certificado);
        }
      }

      if (idTransaccion != 0)
      {
        text.AppendLine(string.Empty);
        text.AppendLine("INFORMACION DE LA TRANSACCION");
        text.AppendLine("=================================================");
        text.AppendLine("Número de transacción         : " + idTransaccion);
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

    private string FormatInformationFechaHora(ElectronicDocumentLibrary.ECodex.FechaHora.Informacion informacion, ProcessProviderResult providerResult)
    {
      StringBuilder text = new StringBuilder();

      if (informacion.FechaHora.IsAssigned)
      {
        text.Append("Fecha y Hora en el PAC : ").AppendLine(informacion.FechaHora.Value.ToString(CultureInfo.CurrentCulture)).Append("Fecha y Hora actual    : ").AppendLine(DateTime.Now.ToString(CultureInfo.CurrentCulture)).Append("Diferencia             : ").Append(DateTime.Now - informacion.FechaHora.Value);
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

    private string FormatInformationCancelarCfdi(string idTransaccion, InformacionCancelarMotivo informacion, ProcessProviderResult providerResult)
    {
      StringBuilder builder = new StringBuilder();

      if (string.IsNullOrEmpty(informacion.Uuid) == false)
      {
        builder.AppendLine(string.Empty);
        builder.AppendLine("RESULTADO");
        builder.AppendLine("=================================================");
        builder.AppendLine($"Código: {informacion.Codigo}");
        builder.AppendLine($"Fecha : {informacion.Fecha}");
        builder.AppendLine($"UUID  : {informacion.Uuid}");
        builder.AppendLine();
      }

      if (string.IsNullOrEmpty(idTransaccion) == false)
      {
        builder.AppendLine();
        builder.AppendLine("INFORMACION DE LA TRANSACCION");
        builder.AppendLine("=================================================");
        builder.AppendLine("Id de la transacción : " + idTransaccion);
      }

      if (informacion.Error.IsAssigned == false)
        return builder.ToString();

      this.FormatTypeError(builder, providerResult);

      builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      builder.AppendLine("=================================================");
      builder.AppendLine("Número      : " + informacion.Error.Numero.Value);
      builder.AppendLine("Código      : " + informacion.Error.Codigo.Value);
      builder.AppendLine("Mensaje     : " + informacion.Error.Mensaje.Value);
      builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return builder.ToString();
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


    //****************************************************************************************************************************************************************************
    // NOTA:
    // 
    // El uso de este método solo es importante cuando se tiene una aplicación web o un servicio web ya que permite reducir el tiempo de timbrado en aproximadamente 500 ms.
    // 
    // Para el correcto funcionamiento de esta propiedad se requiere que la hora del servidor o computadora sea menor a la del PAC.
    // 
    // Para el integrar esta funcionalifuncionalidad da debe:
    //
    //   1. Declarar dos constantes en la parte superior de este formulario
    //
    //      const bool UseOwnTokenDefinition = true;
    //      const bool SetDateTimeServerDefinition = true;
    //
    //   2. Declarar dos variables en la parte superior de este formulario
    //
    //      private DateTime dateTimeServer = DateTime.MinValue;
    //      private DateTime dateLastToken = DateTime.Now;
    //
    //   3. Usar este código antes de realizar cualquier operación con el PAC (timbrar, cancelar, etc)
    //
    //      this.UseOwnToken(parameters, UseOwnTokenDefinition, SetDateTimeServerDefinition);
    //
    //
    // Si desea hace uso de este método póngase en contacto con nosotros para darle todo el detalle del mismo.
    //****************************************************************************************************************************************************************************

    private void UseOwnToken(BaseParameters parameters, bool useOwnToken, bool setDateTimeServer)
    {
      parameters.OwnToken = useOwnToken;

      if ((useOwnToken == false) || (setDateTimeServer == false))
        return;

      if (this.dateTimeServer == DateTime.MinValue)
      {
        ElectronicDocumentLibrary.ECodex.FechaHora.Informacion informacion = new ElectronicDocumentLibrary.ECodex.FechaHora.Informacion().Initialization();
        ProcessProviderResult result = this.proveedor.FechaHora(informacion);
        if (result == ProcessProviderResult.Ok)
          this.dateTimeServer = informacion.FechaHora.Value;
        else
        {
          parameters.OwnToken = false;
          return;
        }

        this.dateLastToken = DateTime.Now;
      }
      else
      {
        int tiempoTranscurrido = (DateTime.Now - this.dateLastToken).Minutes;

        if (tiempoTranscurrido > 8)
          this.dateTimeServer = this.dateTimeServer.AddMinutes(8);
      }

      parameters.DateTimeServer = this.dateTimeServer;
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

      //  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
      //  . Para que se realice una validación FULL, debes activar las siguientes líneas
      //  . Si deseas conocer más al respecto:
      //       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
      //this.manage.Save.Options |= SaveOptions.ValidateWithSchema;
      //this.manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;


      // Se cargan a memoria el archivo de autoridades certificadoras de prueba
      // *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
      this.manage.CertificateAuthorityList.UseForTest();

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
      Gui.MessageBoxCaption = "ECODEX";

      // -- Código para uso interno de este ejemplo
      this.pages = new[]
      {
        this.tshTimbrado, this.tshSolicitudCancelacion, this.tshAcuseSolicitudCancelacion, this.tshDescargarXml, this.tshConstanciaRetenciones,
        this.tshFechaHora, this.tshEstadoCuenta, this.tshParametros
      };

      // -- Código para uso interno de este ejemplo
      this.pgcInformacion.SuspendLayout();
      while (this.pgcInformacion.TabPages.Count > 0)
        this.pgcInformacion.TabPages.RemoveAt(0);

      this.pgcInformacion.ResumeLayout();

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);

      // -- Código para uso interno de este ejemplo
      Control[] rfcs = {
        this.txtRfcEmisorCancelacion, this.txtRfcEmisorDescarga, this.txtRfcEmisorAcuse,
        this.txtRfcEmpresa
      };

      Utilerias.Gui.Timbrado.Initialization(rfcs, this.cbbEnviroment, this.lblVersion);
      
      // -- Código para uso interno de este ejemplo
      this.cbbOperacion.SelectedIndex = 0;
      
      // -- Código para uso interno de este ejemplo
      this.cbbEnviroment.SelectedIndex = 0;
      this.chkUseHttps.Checked = true;
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
        switch (this.cbbOperacion.SelectedIndex)
        {
          // Timbrar un documento
          case 0:
            generatedfile = this.TimbrarCfdi(out fileName);
            break;

          // Cancelar un documento
          case 1:
            this.SolicitudCancelacionCfdi();
            break;

          // Descargar el acuse de cancelación
          case 2:
            this.AcuseSolicitudCancelacion();
            break;

          // Descargar un CFDI previamente generado
          case 3:
            this.DescargarCfdi();
            break;

          // Timbrar un constancia de retenciones y pagos
          case 4:
            generatedfile = this.TimbrarConstanciaRetenciones(out fileName);
            break;

          // Obtener la fecha y hora del PAC
          case 5:
            this.ObtenerFechaHora();
            break;

          // Obtener el estado de cuenta de un RFC
          case 6:
            this.EstadoCuentaCliente();
            break;

          default:
            throw new ArgumentOutOfRangeException();
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
    private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.pgcInformacion.SuspendLayout();
      try
      {
        if (this.pgcInformacion.TabPages.Count > 0)
          this.pgcInformacion.TabPages.RemoveAt(0);

        this.pgcInformacion.TabPages.Add(this.pages[this.cbbOperacion.SelectedIndex]);
        this.btnExecute.Enabled = this.cbbOperacion.SelectedIndex != (this.cbbOperacion.Items.Count - 1);
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
    }

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