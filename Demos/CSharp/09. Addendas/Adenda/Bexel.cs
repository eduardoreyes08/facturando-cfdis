using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Bexel.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Bexel(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Bexel addenda = HyperSoft.ElectronicDocumentLibrary.Bexel.Addenda.Bexel.NewEntity();

      addenda.Data.Version.Value = "1.0";
      addenda.Data.InformacionPago.LugarEntrega.Value = "Planta Guadalajara";
      addenda.Data.InformacionPago.NumeroRecepcion.Value = "REC1234567";
      addenda.Data.InformacionPago.OrdenCompra.Value = "OC1234567";
      addenda.Data.InformacionPago.CorreoElectronico.Value = "contacto1@proveedor.com; contacto2@proveedor.com";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Bexel.xml", out fileName);
    }
  }
}