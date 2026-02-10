using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.SolerPalau.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool SolerPalau(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      SolerPalau addenda = HyperSoft.ElectronicDocumentLibrary.SolerPalau.Addenda.SolerPalau.NewEntity();

      addenda.Data.NumeroProveedor.Value = "NumeroProveedor";
      addenda.Data.OrdenCompra.Value = "OrdenCompra";
      addenda.Data.OrdenTipo.Value = "OrdenTipo";
      addenda.Data.Moneda.Value = "MXP";
      addenda.Data.TipoComprobante.Value = "FACTURA";

      ElectronicDocumentLibrary.SolerPalau.Addenda.Concepto concepto = addenda.Data.Conceptos.Add();
      concepto.Numero.Value = 1;
      concepto.Cantidad.Value = 2;
      concepto.NumeroIdentificacion.Value = "NumeroIdentificacion 1";
      concepto.ValorUnitario.Value = 3;
      concepto.Importe.Value = 4;

      concepto = addenda.Data.Conceptos.Add();
      concepto.Numero.Value = 2;
      concepto.Cantidad.Value = 5;
      concepto.NumeroIdentificacion.Value = "NumeroIdentificacion 2";
      concepto.ValorUnitario.Value = 6;
      concepto.Importe.Value = 7;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_SOLERPALAU.xml", out fileName);
    }
  }
}