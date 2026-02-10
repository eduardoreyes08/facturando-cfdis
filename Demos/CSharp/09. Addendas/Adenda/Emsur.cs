using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Emsur.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool EmSur(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      EmSur addenda = ElectronicDocumentLibrary.Emsur.Addenda.EmSur.NewEntity();

      addenda.Data.FechaVencimiento.Value = DateTime.Now;
      addenda.Data.Total.Value = 1;
      addenda.Data.Moneda.Value = "2";
      addenda.Data.TipoCambio.Value = 3;
      addenda.Data.Serie.Value = "4";
      addenda.Data.Folio.Value = "5";
      addenda.Data.Rfc.Value = "XXX010101AAA";
      addenda.Data.Usuario.Value = "6";
      addenda.Data.OrdenCompra.Value = "7";
      addenda.Data.DiasCredito.Value = 8;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Emsur.xml", out fileName);
    }
  }
}