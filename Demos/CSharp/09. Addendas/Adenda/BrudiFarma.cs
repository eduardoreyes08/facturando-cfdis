using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.BrudiFarma.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool BrudiFarma(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      BrudiFarma addenda = HyperSoft.ElectronicDocumentLibrary.BrudiFarma.Addenda.BrudiFarma.NewEntity();

      addenda.Data.Proveedor.Value = "Proveedor";
      addenda.Data.Factura.Value = "Factura";
      addenda.Data.Remision.Value = "Remision";
      addenda.Data.FechaFactura.Value = DateTime.Now;
      addenda.Data.Moneda.Value = "MXN";
      addenda.Data.Sociedad.Value = "sociedad";
      addenda.Data.Importe.Value = 3;
      addenda.Data.TipoDocumento.Value = "FC";

      ElectronicDocumentLibrary.BrudiFarma.Addenda.Partida partida = addenda.Data.Partidas.Add();
      partida.Proveedor.Value = "Proveedor";
      partida.Factura.Value = "Factura";
      partida.Remision.Value = "Remision";
      partida.PartidaFactura.Value = 1;
      partida.Pedido.Value = "Pedido";
      partida.Material.Value = "Material";
      partida.ImportePartida.Value = 1;
      partida.Cantidad.Value = 2;
      partida.UnidadMedida.Value = "UnidadMedida";

      partida = addenda.Data.Partidas.Add();
      partida.Proveedor.Value = "Proveedor";
      partida.Factura.Value = "Factura";
      partida.Remision.Value = "Remision";
      partida.PartidaFactura.Value = 2;
      partida.Pedido.Value = "Pedido";
      partida.Material.Value = "Material";
      partida.ImportePartida.Value = 1;
      partida.Cantidad.Value = 2;
      partida.UnidadMedida.Value = "UnidadMedida";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_BrudiFarma.xml", out fileName);
    }
  }
}