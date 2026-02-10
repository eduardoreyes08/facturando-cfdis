namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class EnajenacionAcciones
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.EnajenacionAcciones.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO ENAJENACION DE ACCIONES");
      Utils.ShowField("Version               ", data.Version);
      Utils.ShowField("ContratoIntermediacion", data.ContratoIntermediacion);
      Utils.ShowField("Ganancia              ", data.Ganancia);
      Utils.ShowField("Perdida               ", data.Perdida);
    }
  }
}