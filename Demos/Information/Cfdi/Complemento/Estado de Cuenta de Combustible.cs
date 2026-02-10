namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class EstadoDeCuentaDeCombustible
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaDeCombustible.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO ESTADO DE CUENTA DE COMBUSTIBLE");
      Utils.ShowMessage();
      Utils.ShowField("Versión", data.Version);
    }
  }
}