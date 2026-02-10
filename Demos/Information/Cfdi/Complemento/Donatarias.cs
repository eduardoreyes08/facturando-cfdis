namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class Donatarias
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.Donatarias.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO DONATARIAS");
      Utils.ShowField("Versión               ", data.Version);
      Utils.ShowField("Número de autorización", data.NumeroAutorizacion);
      Utils.ShowField("Fecha de autorización ", data.FechaAutorizacion);
      Utils.ShowField("Leyenda               ", data.Leyenda);
    }
  }
}