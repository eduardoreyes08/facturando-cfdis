using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Viscofan.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Viscofan(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Viscofan addenda = new Viscofan().Initialization();

      addenda.Data.OrdenCompra.Value = 1;
      addenda.Data.NumeroAcreedor.Value = 2;
      addenda.Data.PlantaEntrega.Value = "3";
      addenda.Data.NumeroLineaArticulo.Value = "4";
      addenda.Data.CorreoElectronico.Value = "5";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_VISCOFAN.xml", out fileName);
    }
  }
}