using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.ZfMexico.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool ZfMexico(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      ZfMexico addenda = HyperSoft.ElectronicDocumentLibrary.ZfMexico.Addenda.ZfMexico.NewEntity();

      addenda.Data.Version.Value = "1.0";
      addenda.Data.Moneda.Value = "MXN";
      addenda.Data.IdFactura.Value = "12345abcde";

      ElectronicDocumentLibrary.ZfMexico.Addenda.Concepto concepto = addenda.Data.Conceptos.Add();
      concepto.NumeroPosicion.Value = 1;
      concepto.NumeroOrdenCompra.Value = 2;
      concepto.Cantidad.Value = 3;
      concepto.ValorUnitario.Value = 4;
      concepto.Importe.Value = 5;

      concepto = addenda.Data.Conceptos.Add();
      concepto.NumeroPosicion.Value = 7;
      concepto.NumeroOrdenCompra.Value = 8;
      concepto.Cantidad.Value = 9;
      concepto.ValorUnitario.Value = 10;
      concepto.Importe.Value = 11;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_ZfMexico.xml", out fileName);
    }
  }
}