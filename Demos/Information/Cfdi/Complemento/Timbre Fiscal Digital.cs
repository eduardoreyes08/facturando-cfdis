namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class TimbreFiscalDigital
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.TimbreFiscalDigital.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO TIMBRE FISCAL DIGITAL");
      Utils.ShowField("Versión                       ", data.Version);
      Utils.ShowField("UUID                          ", data.Uuid);
      Utils.ShowField("Fecha de timbrado             ", data.FechaTimbrado);
      Utils.ShowField("Sello del CFD                 ", data.SelloCfd);
      Utils.ShowField("Número del Certificado del SAT", data.NumeroCertificadoSat);
      Utils.ShowField("Sello del SAT                 ", data.SelloSat);
      Utils.ShowField("RFC PAC                       ", data.RfcProveedorCertificacion);
    }
  }
}