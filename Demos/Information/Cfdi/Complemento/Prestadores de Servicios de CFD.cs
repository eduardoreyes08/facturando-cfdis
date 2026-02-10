namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class PrestadoresDeServiciosDeCfd
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.PrestadoresDeServiciosDeCFD.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO PRESTADORES DE SERVICIOS DE CFD");
      Utils.ShowMessage();
      Utils.ShowField("Versión", data.Version);

    }
  }
}