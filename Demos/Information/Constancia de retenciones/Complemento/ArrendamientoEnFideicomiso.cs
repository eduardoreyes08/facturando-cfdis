namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class ArrendamientoEnFideicomiso
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.ArrendamientoFideicomiso.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO ARRENDAMIENTO EN FIDEICOMISO");
      Utils.ShowField("Version                       ", data.Version);
      Utils.ShowField("ImportePago                   ", data.ImportePago);
      Utils.ShowField("ImporteRendimiento            ", data.ImporteRendimiento);
      Utils.ShowField("ImporteDeducciones            ", data.ImporteDeducciones);
      Utils.ShowField("MontoTotalRetencion           ", data.MontoTotalRetencion);
      Utils.ShowField("MontoFibras                   ", data.MontoFibras);
      Utils.ShowField("MontoOtrosConceptos           ", data.MontoOtrosConceptos);
      Utils.ShowField("DescripcionMontoOtrosConceptos", data.DescripcionMontoOtrosConceptos);      
    }
  }
}