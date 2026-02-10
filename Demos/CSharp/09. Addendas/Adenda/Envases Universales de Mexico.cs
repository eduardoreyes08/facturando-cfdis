using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.EnvasesUniversalesMexico.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool EnvasesUniversalesdeMexico(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      EnvasesUniversalesMexico addenda = HyperSoft.ElectronicDocumentLibrary.EnvasesUniversalesMexico.Addenda.EnvasesUniversalesMexico.NewEntity();

      addenda.Data.TipoFactura.Version.Value = "version";
      addenda.Data.TipoFactura.FechaMensaje.Value = DateTime.Now;
      addenda.Data.TipoFactura.IdFactura.Value = "idfactura";

      addenda.Data.Moneda.Clave.Value = "clave";
      addenda.Data.Moneda.Impuesto.Value = 1;
      addenda.Data.Moneda.SubTotal.Value = 2;
      addenda.Data.Moneda.Total.Value = 3;
      addenda.Data.Moneda.TipoCambio.Value = 4;

      addenda.Data.ImpuestosRetenidos.BaseImpuesto.Value = 1;

      OrdenCompra ordenCompra = addenda.Data.OrdenesCompra.Add();
      ordenCompra.Consecutivo.Value = 1;
      ordenCompra.EntradasAlmacen.Add().Albaran.Value = "albaran 1";
      ordenCompra.EntradasAlmacen.Add().Albaran.Value = "albaran 2";
      ordenCompra.IdPedido.Value = "idpedido";

      addenda.Data.TipoTransaccion.IdTransaccion.Value = "idtransaccion";
      addenda.Data.TipoTransaccion.Transaccion.Value = "transaccion";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_EnvasesUniversalesMexico.xml", out fileName);
    }
  }
}