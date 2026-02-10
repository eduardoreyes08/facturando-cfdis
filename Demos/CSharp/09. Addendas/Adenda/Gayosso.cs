using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Gayosso.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Gayosso(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Gayosso addenda = new HyperSoft.ElectronicDocumentLibrary.Gayosso.Addenda.Gayosso();

      addenda.Data.NumeroProveedor.Value = "0100002360";
      addenda.Data.Pedido.Value = "4500040562";
      addenda.Data.NumeroRecepcionMercancia.Value = "5000074500";
      addenda.Data.ImporteTotalRecepcionMercancia.Value = 0.13;
      addenda.Data.Descuento.Value = 0.00;
      addenda.Data.Subtotal.Value = 0.13;
      addenda.Data.TotalFactura.Value = 15;

      //ElectronicDocumentLibrary.Gayosso.Addenda.Impuesto impuesto = gayosso.Data.ImpuestosTrasladados.Add();
      //impuesto.Tipo.Value = "IVA";
      //impuesto.Base.Value = 0.13;
      //impuesto.Tasa.Value = 16;
      //impuesto.Total.Value = 0.02;

      Impuesto impuesto = addenda.Data.ImpuestosRetenidos.Add();
      impuesto.Tipo.Value = "ISR";
      impuesto.Base.Value = 0.14;
      impuesto.Tasa.Value = 17;
      impuesto.Total.Value = 0.03;

      impuesto = addenda.Data.ImpuestosRetenidos.Add();
      impuesto.Tipo.Value = "IVA";
      impuesto.Base.Value = 0.18;
      impuesto.Tasa.Value = 19;
      impuesto.Total.Value = 0.21;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Gayoso.xml", out fileName);
    }
  }
}