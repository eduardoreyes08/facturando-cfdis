using System;
using System.Collections.Generic;
using System.Text;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;
using HyperSoft.ElectronicDocumentLibrary.Pax.Timbrado.Resultado;
using HyperSoft.Shared;
using HyperSoft.ElectronicDocumentLibrary.Pax;

namespace HyperSoft.Ejemplo.Utilerias
{
  public static class Pax
  {
    // *** VER NOTA AL FINAL DEL ARCHIVO
    public static bool Timbrar(ElectronicDocument electronicDocument)
    {
      ConfigurationForPax(electronicDocument);

      TimbrarParameters parameters = new TimbrarParameters().Initialization();

      // Se crea el objeto que contiene la información retornada por el PAC
      Informacion informacion = new Informacion().Initialization();

      // Se asigna los parámetros a usar durante el proceso
      parameters.Usuario.Value = "WSDL_PAX";
      parameters.Password.Value = "wqfCr8O3xLfEhMOHw4nEjMSrxJnvv7bvvr4cVcKuKkBEM++/ke+/gCPvv4nvvrfvvaDvvb/vvqTvvoA=";
      parameters.Identificador.Value = Identificador(electronicDocument.Data.Emisor.Rfc.Value);
      parameters.ElectronicDocument = electronicDocument;
      parameters.TipoDocumento = DocumentType.Factura;
      parameters.TestMode = true;
      parameters.Informacion = informacion;

      Proveedor proveedor = new Proveedor().Initialization();

      // Se envia a timbrar el documento
      ProcessProviderResult result = proveedor.TimbrarCfdi(parameters);

      Chronometer.Instance.Stop();

      // Se le da formato a la información retornada por el PAC
      string texto = FormatInformationTimbre(informacion, result, electronicDocument.FingerPrintPac);

      // Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("CFDI", texto);

      return result == ProcessProviderResult.Ok;
    }

    public static string Identificador(string rfc)
    {
      Dictionary<string, string> data = new Dictionary<string, string>
      {
        {"AAA010101AAA", "q+Nu2Fxq03aPR9bu1VHnz7oRv0e5VlOLK9zICF+pBl+HmvSIg67JVuSthuF4aBsB"},
        {"MAR980114GQA", "JSp8dGI8S81IAcLSSRBDfpESrnOikLfthTuQJqcRn71Sy6M5sZCP5QggHOdeAQPO"},
        {"MAG041126GT8", "VAml2+AUMIw6U3SXObIrrMdEsDOmRck2+054sx9BoZXwiaA7upjCNSyxyGtwFC9E"},
        {"LAN8507268IA", "XQr6Y3u2jitOYrsWWI4JJDy4Ei5PUrhY/qqN6gWmYohxtRIj0hy8Q6Lx/hiXJNPA"},
        {"VOC990129I26", "29GS04IxbuRIEzD83k6rUrMD9zKIJKQjAcXJWkNKoR51VHjCHVWh2cIJfnvheaDy"},
        {"URU070122S28", "ZQFtPxPsvC7+1sf6IUzBCpALSQWas2lsVusvGirokmzwm5Ch1kDAq+veVtlbB4wG"},
        {"ULC051129GC0", "Vr4YnQGEqGhmTSTEta7vZoWIJBSQSWfs9NBdC48SBHUl5GhyJ9k5vHeAj/CICk9n"},
        {"TME960709LR2", "V9f1Xr9XtW4eQcL9rO7TGkDLXwmcZOd/e/L1/T5xwU52+GPS6VOXYQY29+NZCNuN"},
        {"TCM970625MB1", "QGrB1xMtB9j2rYCrFYbCKkZ/J3URNx0yeHvSPpEzWal+ycM6EZ79MfdTZ3IwyCjV"},
        {"SUL010720JN8", "RDWbnDax6eEjXWlNHIXf7URv3glfK3hVNX1S3t3Z3XSajItI5wFN6BaX4P2AUfCZ"},
        {"PZA000413788", "Rwi+QyMy4ZPtP7ajHvvpXMGahz9Gc5PO+MfHlHHhPwa8kYT1Zzms2Vz8ii2BQdDV"},
        {"MSE061107IA8", "q61bPjrkgkvi5Jh4otjmizO8QUfA8tLNprvt7yEsotKcXImreO8eVndI34En0IOs"},
        {"IIA040805DZ4", "otaX4e5Qrn/p0eK0vL14WnuikIwpYSTR/sWK1g/UlGokqWXSTbGqJE41jV97//9Y"},
        {"EKU9003173C9", "r18iKbiA7pnb22fWLAOatMWw/d/0Qc4N8VEEefVuFcRc9j1RRPprNhcDbrCY35Ti"}
      };

      string id;
      return data.TryGetValue(rfc, out id) ? id : string.Empty;
    }

    private static string FormatInformationTimbre(Informacion informacion, ProcessProviderResult providerResult, string cadenaOrignal)
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

    private static void ConfigurationForPax(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Emisor.Rfc.Value = "AAA010101AAA";
      electronicDocument.Data.Emisor.Nombre.Value = "INDISTRIA ILUMINADORA DE ALMACENES SA DE CV";
      electronicDocument.Data.Emisor.RegimenFiscal.Value = "601";

      electronicDocument.Manage.Save.Options -= SaveOptions.ValidateCertificateSubject;
    }
  }
}
