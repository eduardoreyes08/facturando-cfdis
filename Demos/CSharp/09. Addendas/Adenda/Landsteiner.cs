using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Landsteiner.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Landsteiner(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Landsteiner addenda = HyperSoft.ElectronicDocumentLibrary.Landsteiner.Addenda.Landsteiner.NewEntity();

      addenda.Data.CodigoSociedad.Value = "CodigoSociedad";
      addenda.Data.NombreSociedad.Value = "NombreSociedad";
      addenda.Data.CodigoProveedor.Value = "CodigoProveedor";
      addenda.Data.NombreProveedor.Value = "NombreProveedor";
      addenda.Data.OrdenCompra.Value = "OrdenCompra";
      addenda.Data.NotaEntrega.Value = "NotaEntrega";
      addenda.Data.CondicionesPago.Value = "CondicionesPago";
      addenda.Data.TipoMoneda.Value = 1;
      addenda.Data.Moneda.Value = "Moneda";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Landsteiner.xml", out fileName);
    }
  }
}