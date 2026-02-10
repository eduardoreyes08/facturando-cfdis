namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class SectorFinanciero
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.SectorFinanciero.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO SECTOR FINANCIERO");
      Utils.ShowField("Version               ", data.Version);
      Utils.ShowField("IdFideicomis          ", data.IdFideicomiso);
      Utils.ShowField("NombreFideicomiso     ", data.NombreFideicomiso);
      Utils.ShowField("DescripcionFideicomiso", data.DescripcionFideicomiso);      
    }
  }
}