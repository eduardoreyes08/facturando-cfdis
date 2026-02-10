using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Kuehne.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Kuehne(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Kuehne addenda = new HyperSoft.ElectronicDocumentLibrary.Kuehne.Addenda.Kuehne();

      addenda.Data.PurchaseOrder.Value = "aaaaaaaaaaaaaa";
      addenda.Data.FileNumberGl.Value = "00000000000000";
      addenda.Data.BranchCentre.Value = "aaaaaaa";
      addenda.Data.TransportRef.Value = "aaaaaaa";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Kuehne.xml", out fileName);
    }
  }
}