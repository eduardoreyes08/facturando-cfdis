using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class RegistroFiscal10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.RegistroFiscal);
      HyperSoft.ElectronicDocumentLibrary.Complemento.RegistroFiscal.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.RegistroFiscal.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.Folio.Value = "0000000000000001";

      return Base.Save(electronicDocument, "RegistroFiscal10.xml", out fileName);
    }
  }
}