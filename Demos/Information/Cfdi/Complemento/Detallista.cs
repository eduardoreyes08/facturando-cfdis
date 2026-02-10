namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class Detallista
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO DETALLISTA");
      Utils.ShowMessage();
      Utils.ShowField("Versión", data.ContentVersion);
    }
  }
}