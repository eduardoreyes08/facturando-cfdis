namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class EstadoDeCuentaBancario
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaBancario.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO ESTADO DE CUENTA BANCARIO");
      Utils.ShowMessage();
      Utils.ShowField("Versión", data.Version);
    }
  }
}