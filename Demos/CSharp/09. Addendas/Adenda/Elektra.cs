using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Elektra.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Elektra(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Elektra addenda = HyperSoft.ElectronicDocumentLibrary.Elektra.Addenda.Elektra.NewEntity();

      addenda.Data.TipoDocumento.Value = "Factura";

      addenda.Data.Emisor.NumeroRegistro.Value = "1";
      addenda.Data.Receptor.NumeroRegistro.Value = "2";

      addenda.Data.Encabezado.TipoProveedor.Value = "1";
      addenda.Data.Encabezado.NumeroProveedor.Value = "2";
      addenda.Data.Encabezado.OrdenCompra.Value = "3";
      addenda.Data.Encabezado.Fecha.Value = DateTime.Now;
      addenda.Data.Encabezado.SubTotal.Value = 4;
      addenda.Data.Encabezado.Iva.Value = 5;
      addenda.Data.Encabezado.IvaPorcentaje.Value = 6;
      addenda.Data.Encabezado.Total.Value = 7;
      addenda.Data.Encabezado.Moneda.Value = "MXN";

      ElectronicDocumentLibrary.Elektra.Addenda.Cuerpo cuerpo = addenda.Data.Encabezado.Detalles.Add();
      cuerpo.Renglon.Value = 1;
      cuerpo.Cantidad.Value = 2;
      cuerpo.Concepto.Value = "Concepto 1";
      cuerpo.PrecioUnitario.Value = 3;
      cuerpo.Importe.Value = 4;

      cuerpo = addenda.Data.Encabezado.Detalles.Add();
      cuerpo.Renglon.Value = 2;
      cuerpo.Cantidad.Value = 6;
      cuerpo.Concepto.Value = "Concepto 2";
      cuerpo.PrecioUnitario.Value = 8;
      cuerpo.Importe.Value = 8;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Elektra.xml", out fileName);
    }
  }
}