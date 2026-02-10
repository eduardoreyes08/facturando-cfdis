using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class Divisas10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.Divisas);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Divisas.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Divisas.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TipoOperacion.Value = "compra";

      return Base.Save(electronicDocument, "Divisas10.xml", out fileName);
    }
  }
}