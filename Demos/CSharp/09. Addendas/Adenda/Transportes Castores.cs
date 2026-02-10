using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.TransportesCastores.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool TransportesCastores(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      TransportesCastores addenda = HyperSoft.ElectronicDocumentLibrary.TransportesCastores.Addenda.TransportesCastores.NewEntity();

      addenda.Data.ImporteEntregado.Value = 1;
      addenda.Data.NumeroProveedor.Value = "NumeroProveedor";
      addenda.Data.Produccion = false;

      Vale vale = addenda.Data.Vales.Add();
      vale.Numero.Value = "Numero";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_TransportesCastores.xml", out fileName);
    }
  }
}