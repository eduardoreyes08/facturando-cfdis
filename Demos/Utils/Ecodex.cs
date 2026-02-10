using System;
using System.Text;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.ECodex;
using HyperSoft.ElectronicDocumentLibrary.ECodex.Timbre;
using HyperSoft.Shared;

namespace HyperSoft.Ejemplo.Utilerias
{
  public static class ECodex
  {
    // *** VER NOTA AL FINAL DEL ARCHIVO
    public static bool Timbrar(ElectronicDocument electronicDocument)
    {
      TimbrarParameters parameters = new TimbrarParameters().Initialization();

      // Se crea el objeto que contiene la información retornada por el PAC
      Informacion informacion = new Informacion().Initialization();

      // Se asigna los parámetros a usar durante el proceso
      parameters.ElectronicDocument = electronicDocument;
      parameters.Informacion = informacion;
      parameters.TestMode = true;
      parameters.Rfc.Value = electronicDocument.Data.Emisor.Rfc.Value;
      parameters.IdTransaccion.Value = long.MaxValue;

      Proveedor proveedor = new Proveedor().Initialization();

      // Se envia a timbrar el documento
      ProcessProviderResult result = proveedor.GenerarTimbre(parameters);

      Chronometer.Instance.Stop();

      // Se le da formato a la información retornada por el PAC
      string texto = FormatInformationTimbre(parameters.IdTransaccion.Value, informacion, result, electronicDocument.FingerPrintPac);

      // Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("CFDI", texto);

      return result == ProcessProviderResult.Ok;
    }

    public static string Version()
    {
      return $"E.D.L - {ElectronicDocument.Version()} / ECODEX - {Proveedor.Version()}";
    }

    private static string FormatInformationTimbre(long idTransaccion, Informacion informacion, ProcessProviderResult providerResult, string cadenaOrignal)
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

      FormatTypeError(text, providerResult);

      text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO");
      text.AppendLine("=================================================");
      text.AppendLine("Número      : " + informacion.Error.Numero.Value);
      text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value);

      return text.ToString();
    }

    private static void FormatTypeError(StringBuilder text, ProcessProviderResult providerResult)
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
  }
}

/*******************************************************************************************************
Esta clase hacer una implemtación LITE de como hacer la conexión con ECODEX para timbrar un XML.

Te recomendamos estudiar el ejemplo PAC ECODEX para conocer:
  1. Como es el proceso de integración
  2. Que significa cada clase y propiedad usada
********************************************************************************************************/
