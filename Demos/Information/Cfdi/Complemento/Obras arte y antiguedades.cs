namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class ObrasArteAntiguedades
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.ObrasArteAntiguedades.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO OBRAS, ARTE y ANTIGUEDADES");
      Utils.ShowField("Versión                    ", data.Version);
      Utils.ShowField("TipoBien                   ", data.TipoBien);
      Utils.ShowField("OtrosTipoBien              ", data.OtrosTipoBien);
      Utils.ShowField("TituloAdquirido            ", data.TituloAdquirido);
      Utils.ShowField("OtrosTituloAdquirido       ", data.OtrosTituloAdquirido);
      Utils.ShowField("Subtotal                   ", data.Subtotal);
      Utils.ShowField("Iva                        ", data.Iva);
      Utils.ShowField("FechaAdquisicion           ", data.FechaAdquisicion);
      Utils.ShowField("CaracteristicasDeObraoPieza", data.CaracteristicasDeObraoPieza);
    }
  }
}