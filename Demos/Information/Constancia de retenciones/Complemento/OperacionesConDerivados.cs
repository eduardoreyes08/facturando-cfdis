namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class OperacionesConDerivados
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.OperacionesConDerivados.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO OPERACIONES CON DERIVADOS");
      Utils.ShowField("Version             ", data.Version);
      Utils.ShowField("Monto de la ganancia", data.MontoGanancia);
      Utils.ShowField("Monto de la perdida ", data.MontoPerdida);
    }
  }
}