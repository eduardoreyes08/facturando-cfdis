using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Itsb.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool ItSmartBusiness(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      ItSmartBusiness addenda = new HyperSoft.ElectronicDocumentLibrary.Itsb.Addenda.ItSmartBusiness();

      addenda.Data.Itsb.Version.Value = "1.1";
      addenda.Data.Itsb.OrdenCompra.Value = "PO-0000000117";


      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_ItSmartBusiness.xml", out fileName);
    }
  }
}