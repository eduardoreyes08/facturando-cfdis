using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class Aerolineas10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.Aerolineas);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Aerolineas.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Aerolineas.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TarifaUnicaAeropuerto.Value = 123.56;

      data.OtrosCargos.TotalCargos.Value = 232.36;

      ElectronicDocumentLibrary.Complemento.Aerolineas.Cargo cargo = data.OtrosCargos.Add();
      cargo.Codigo.Value = "001AAAAL";
      cargo.Importe.Value = 100;

      cargo = data.OtrosCargos.Add();
      cargo.Codigo.Value = "020LHGEC";
      cargo.Importe.Value = 132.56;

      return Base.Save(electronicDocument, "Aerolineas.xml", out fileName);
    }
  }
}