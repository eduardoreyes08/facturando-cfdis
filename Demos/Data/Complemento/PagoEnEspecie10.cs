using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class PagoEnEspecie10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.PagoEspecie);
      HyperSoft.ElectronicDocumentLibrary.Complemento.PagoEspecie.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.PagoEspecie.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.ClavePic.Value = "&&&000000000-20001030-000";
      data.FolioSolicitudDonacion.Value = "PE-12-12345";
      data.PiezaArteNombre.Value = "ABC";
      data.PiezaArteTecnica.Value = "Oleo";
      data.PiezaArteProduccion.Value = "1974";
      data.PiezaArteDimensiones.Value = "123";

      return Base.Save(electronicDocument, "PagoEnEspecie.xml", out fileName);
    }
  }
}