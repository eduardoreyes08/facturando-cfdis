using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Loreal.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Loreal(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Loreal addenda = HyperSoft.ElectronicDocumentLibrary.Loreal.Addenda.Loreal.NewEntity();

      addenda.Data.TipoDocumento.Value = "Factura";

      addenda.Data.Emisor.NumeroRegistro.Value = "1";

      addenda.Data.Receptor.NumeroRegistro.Value = "1";

      addenda.Data.Encabezado.Folio.Value = "1";
      addenda.Data.Encabezado.Serie.Value = "A";
      addenda.Data.Encabezado.Moneda.Value = "MXN";
      addenda.Data.Encabezado.FolioOrdenCompra.Value = "123";
      addenda.Data.Encabezado.FolioNotaRecepcion.Value = "456";
      addenda.Data.Encabezado.Fecha.Value = DateTime.Now;
      addenda.Data.Encabezado.CondicionPago.Value = "XXX";
      addenda.Data.Encabezado.IvaPorcentaje.Value = 3;
      addenda.Data.Encabezado.NumeroProveedor.Value = "123";
      addenda.Data.Encabezado.CargoTipo.Value = "456";
      addenda.Data.Encabezado.SubTotal.Value = 4;
      addenda.Data.Encabezado.Iva.Value = 5;
      addenda.Data.Encabezado.Total.Value = 6;
      addenda.Data.Encabezado.Observaciones.Value = "Observaciones";

      ElectronicDocumentLibrary.Loreal.Addenda.Cuerpo detalle = addenda.Data.Encabezado.Detalles.Add();
      detalle.Partida.Value = 1;
      detalle.Cantidad.Value = 2;
      detalle.Concepto.Value = "Concepto 1";
      detalle.PrecioUnitario.Value = 3;
      detalle.Importe.Value = 4;
      detalle.UnidadMedida.Value = "Caja";
      detalle.Iva.Value = 5;
      detalle.IvaPorcentaje.Value = 6;

      detalle = addenda.Data.Encabezado.Detalles.Add();
      detalle.Partida.Value = 2;
      detalle.Cantidad.Value = 2;
      detalle.Concepto.Value = "Concepto 2";
      detalle.PrecioUnitario.Value = 3;
      detalle.Importe.Value = 4;
      detalle.UnidadMedida.Value = "Caja";
      detalle.Iva.Value = 5;
      detalle.IvaPorcentaje.Value = 6;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Loreal.xml", out fileName);
    }
  }
}