using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.SevenEleven.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool SevenEleven(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      SevenEleven addenda = new HyperSoft.ElectronicDocumentLibrary.SevenEleven.Addenda.SevenEleven();

      addenda.Data.Autorizacion.Folio.Value = "123";
      addenda.Data.Moneda.Tipo.Value = "MXN";
      addenda.Data.Moneda.TipoCambio.Value = 1;
      addenda.Data.Proveedor.Clave.Value = 1;

      ElectronicDocumentLibrary.SevenEleven.Addenda.Recepcion recepcion = addenda.Data.Recepciones.Add();
      recepcion.Folio.Value = "1";
      recepcion.Tienda.Value = 12;
      recepcion.Fecha.Value = DateTime.Now;

      ElectronicDocumentLibrary.SevenEleven.Addenda.Producto producto = recepcion.Productos.Add();
      producto.Cantidad.Value = 1;
      producto.Codigo.Value = "2";
      producto.Descripcion.Value = "Producto 1";
      producto.Precio.Value = 3;
      producto.Ieps.Value = 4;
      producto.Iva.Value = 5;
      producto.PiezasPorUnidad.Value = 6;
      producto.RetencionIsr.Value = 7;
      producto.RetencionIva.Value = 8;

      producto = recepcion.Productos.Add();
      producto.Cantidad.Value = 11;
      producto.Codigo.Value = "12";
      producto.Descripcion.Value = "Producto 2";
      producto.Precio.Value = 13;
      producto.Ieps.Value = 14;
      producto.Iva.Value = 15;
      producto.PiezasPorUnidad.Value = 16;
      producto.RetencionIsr.Value = 17;
      producto.RetencionIva.Value = 18;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_SevenEleven.xml", out fileName);
    }
  }
}