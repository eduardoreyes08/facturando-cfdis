using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.TiendasNeto.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool TiendasNeto(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      TiendasNeto addenda = HyperSoft.ElectronicDocumentLibrary.TiendasNeto.Addenda.TiendasNeto.NewEntity();

      addenda.Data.TipoComprobante.Value = "Aviso";
      addenda.Data.PlazoPago.Value = "Divisa";
      addenda.Data.Observaciones.Value = "OrdenCompra";

      ElectronicDocumentLibrary.TiendasNeto.Addenda.Producto producto = addenda.Data.Detalle.Productos.Add();
      producto.CajasEntregadas.Value = 1;
      producto.CodigoBarras.Value = 1;

      producto.Impuestos.TotalTrasladados.Value = 1;
      ElectronicDocumentLibrary.TiendasNeto.Addenda.Traslado traslado = producto.Impuestos.Traslados.Add();
      traslado.Importe.Value = 1;
      traslado.Tasa.Value = 1;
      traslado.Tipo.Value = "Tipo";

      producto.PiezasEntregadas.Value = 1;
      producto.PrecioUnitarioCaja.Value = 1;
      producto.PrecioUnitarioPieza.Value = 1;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_TiendasNeto.xml", out fileName);
    }
  }
}