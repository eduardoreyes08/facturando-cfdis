using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Disney.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Disney(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Disney addenda = HyperSoft.ElectronicDocumentLibrary.Disney.Addenda.Disney.NewEntity();

      addenda.Data.Proveedor.Contacto.Value = "contacto";
      addenda.Data.Proveedor.Telefono.Value = "telefono";
      addenda.Data.Proveedor.CorreoElectronico.Value = "correoelectronico";
      addenda.Data.Proveedor.Numero.Value = "numero";

      addenda.Data.Transaccion.CorreoElectronicoCompradorCasual.Value = "correoelectronicocompradorcasual";
      addenda.Data.Transaccion.NumeroRecibo.Value = "numerorecibo";
      addenda.Data.Transaccion.OrdenCompra.Value = "ordencompra";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Disney.xml", out fileName);
    }
  }
}