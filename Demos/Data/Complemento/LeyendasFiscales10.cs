using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.LeyendasFiscales;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class LeyendasFiscales10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.LeyendasFiscales);
      HyperSoft.ElectronicDocumentLibrary.Complemento.LeyendasFiscales.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.LeyendasFiscales.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      Leyenda leyenda = data.Leyendas.Add();
      leyenda.DisposicionFiscal.Value = "1";
      leyenda.Norma.Value = "2";
      leyenda.TextoLeyenda.Value = "3";

      leyenda = data.Leyendas.Add();
      leyenda.DisposicionFiscal.Value = "A";
      leyenda.Norma.Value = "B";
      leyenda.TextoLeyenda.Value = "C";

      return Base.Save(electronicDocument, "LeyendasFiscales.xml", out fileName);
    }
  }
}