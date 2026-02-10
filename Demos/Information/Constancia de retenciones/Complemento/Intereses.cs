namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class Intereses
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.Intereses.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO INTERESES");
      Utils.ShowField("Version", data.Version);
      Utils.ShowField("SistemaFinanciero", data.SistemaFinanciero);
      Utils.ShowField("Retiro", data.Retiro);
      Utils.ShowField("OperacionesDerivadas", data.OperacionesDerivadas);
      Utils.ShowField("MontoNominal", data.MontoNominal);
      Utils.ShowField("MontoReal", data.MontoReal);
      Utils.ShowField("Perdida", data.Perdida);
    }
  }
}