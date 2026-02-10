namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class Aerolinea
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.Aerolineas.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO AEROLINEA");
      Utils.ShowField("Versión     ", data.Version);
      Utils.ShowField("TUA         ", data.TarifaUnicaAeropuerto);

      Utils.ShowField("Total cargos", data.OtrosCargos.TotalCargos);

      for (int i = 0; i < data.OtrosCargos.Count; i++)
      {
        Utils.ShowTitle("AEROLINEA / OTROSCARGOS - " + (i + 1));
        Utils.ShowField("Código ", data.OtrosCargos[i].Codigo);
        Utils.ShowField("Importe", data.OtrosCargos[i].Importe);
      }
    }
  }
}