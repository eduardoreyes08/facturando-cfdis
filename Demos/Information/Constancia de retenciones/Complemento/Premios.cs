namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class Premios
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.Premios.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO PREMIOS");
      Utils.ShowField("Version              ", data.Version);
      Utils.ShowField("EntidadFederativa    ", data.EntidadFederativa);
      Utils.ShowField("MontoTotalPago       ", data.MontoTotalPago);
      Utils.ShowField("MontoTotalPagoGravado", data.MontoTotalPagoGravado);
      Utils.ShowField("MontoTotalPagoExento ", data.MontoTotalPagoExento);      
    }
  }
}