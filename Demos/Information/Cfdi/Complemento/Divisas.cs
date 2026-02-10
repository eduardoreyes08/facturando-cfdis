namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class Divisas
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.Divisas.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO DIVISAS");
      Utils.ShowField("Versión          ", data.Version);
      Utils.ShowField("Tipo de operacion", data.TipoOperacion);
    }
  }
}