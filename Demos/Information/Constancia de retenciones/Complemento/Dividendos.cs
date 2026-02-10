namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class Dividendos
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.Dividendos.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO DIVIDENDOS");
      Utils.ShowField("Version                 ", data.Version);
      Utils.ShowField("ClaveTipoDividendo      ", data.DividendosUtilidades.ClaveTipoDividendo);
      Utils.ShowField("MontoIsrMexico          ", data.DividendosUtilidades.MontoIsrMexico);
      Utils.ShowField("MontoIsrExtranjero      ", data.DividendosUtilidades.MontoIsrExtranjero);
      Utils.ShowField("MontoRetencionExtranjero", data.DividendosUtilidades.MontoRetencionExtranjero);
      Utils.ShowField("TipoSociedad            ", data.DividendosUtilidades.TipoSociedad);
      Utils.ShowField("MontoIsrNacional        ", data.DividendosUtilidades.MontoIsrNacional);
      Utils.ShowField("MontoDividendoNacional  ", data.DividendosUtilidades.MontoDividendoNacional);
      Utils.ShowField("MontoDividendoExtranjero", data.DividendosUtilidades.MontoDividendoExtranjero);

      Utils.ShowField("Proporcion              ", data.Remanente.Proporcion);
      
    }
  }
}