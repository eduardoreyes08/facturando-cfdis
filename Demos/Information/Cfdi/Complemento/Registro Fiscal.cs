namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class RegistroFiscal
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.RegistroFiscal.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO REGISTRO FISCAL");
      Utils.ShowField("Versión", data.Version);
      Utils.ShowField("Folio  ", data.Folio);
    }
  }
}