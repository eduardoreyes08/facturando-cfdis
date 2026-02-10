using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.GeneralMotors.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool GeneralMotors(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      GeneralMotors addenda = new HyperSoft.ElectronicDocumentLibrary.GeneralMotors.Addenda.GeneralMotors();

      addenda.Data.Header.NumeroRemision.Value = "0";
      addenda.Data.Header.FechaRecibo.Value = DateTime.Now;
      addenda.Data.Header.FolioInterno.Value = "0";
      addenda.Data.Header.Moneda.Value = 1;

      Item item = addenda.Data.Header.Items.Add();
      item.OrdenCompra.Value = "0";
      item.NumeroParte.Value = "0";
      item.Material.Value = 1;
      item.Cantidad.Value = 2;
      item.PrecioUnitario.Value = 1;
      item.Descripcion.Value = "a";

      item = addenda.Data.Header.Items.Add();
      item.OrdenCompra.Value = "11";
      item.NumeroParte.Value = "11";
      item.Material.Value = 12;
      item.Cantidad.Value = 23;
      item.PrecioUnitario.Value = 14;
      item.Descripcion.Value = "b";


      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_GeneralMotors.xml", out fileName);
    }
  }
}