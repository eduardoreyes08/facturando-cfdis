using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Prolec.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Prolec(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Prolec addenda = HyperSoft.ElectronicDocumentLibrary.Prolec.Addenda.Prolec.NewEntity();

      addenda.Data.Aviso.Value = "Aviso";
      addenda.Data.Divisa.Value = "Divisa";
      addenda.Data.OrdenCompra.Value = "OrdenCompra";
      addenda.Data.Proveedor.Value = "Proveedor";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Prolec.xml", out fileName);
    }
  }
}