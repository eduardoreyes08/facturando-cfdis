using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Iusacell.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Iusacell(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Iusacell addenda = HyperSoft.ElectronicDocumentLibrary.Iusacell.Addenda.Iusacell.NewEntity();

      addenda.Data.TipoDocumento.Value = "Factura";

      addenda.Data.Emisor.NumeroRegistro.Value = "1";
      addenda.Data.Receptor.NumeroRegistro.Value = "2";

      addenda.Data.Encabezado.NumeroProveedor.Value = "3";
      addenda.Data.Encabezado.Fecha.Value = DateTime.Now;
      addenda.Data.Encabezado.OrdenCompra.Value = "4";
      addenda.Data.Encabezado.SubTotal.Value = 10;
      addenda.Data.Encabezado.Iva.Value = 11;
      addenda.Data.Encabezado.IvaPorcentaje.Value = 12;
      addenda.Data.Encabezado.Total.Value = 13;
      addenda.Data.Encabezado.Moneda.Value = "MXN";
      addenda.Data.Encabezado.FechaEntrega.Value = DateTime.Now;
      addenda.Data.Encabezado.LugarEntrega.Value = "LugarEntrega";
      addenda.Data.Encabezado.CondicionPago.Value = "CondicionPago";

      ElectronicDocumentLibrary.Iusacell.Addenda.Cuerpo cuerpo = addenda.Data.Encabezado.Detalles.Add();
      cuerpo.Renglon.Value = 1;
      cuerpo.Cantidad.Value = 2;
      cuerpo.UnidadMedida.Value = "UnidadMedida";
      cuerpo.Concepto.Value = "Concepto 1";
      cuerpo.PrecioUnitario.Value = 3;
      cuerpo.Importe.Value = 7;
      cuerpo.Material.Value = "Material";

      cuerpo = addenda.Data.Encabezado.Detalles.Add();
      cuerpo.Renglon.Value = 2;
      cuerpo.Cantidad.Value = 2;
      cuerpo.UnidadMedida.Value = "ABC";
      cuerpo.Concepto.Value = "Concepto 1";
      cuerpo.PrecioUnitario.Value = 3;
      cuerpo.Importe.Value = 7;
      cuerpo.Material.Value = "Material";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Iusacell.xml", out fileName);
    }
  }
}