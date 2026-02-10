namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class ImpuestosLocales
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO IMPUESTOS LOCALES");
      Utils.ShowMessage();
      Utils.ShowField("Versión", data.Version);
    }
  }
}