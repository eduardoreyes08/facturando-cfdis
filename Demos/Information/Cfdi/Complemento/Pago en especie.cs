namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class PagoEspecie
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.PagoEspecie.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO PAGO EN ESPECIE");
      Utils.ShowField("Versión    ", data.Version);
      Utils.ShowField("Clave pic  ", data.ClavePic);
      Utils.ShowField("Folio      ", data.FolioSolicitudDonacion);
      Utils.ShowField("Nombre     ", data.PiezaArteNombre);
      Utils.ShowField("Técnica    ", data.PiezaArteTecnica);
      Utils.ShowField("Producción ", data.PiezaArteProduccion);
      Utils.ShowField("Dimensiones", data.PiezaArteDimensiones);
    }
  }
}