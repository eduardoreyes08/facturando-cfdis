using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Emerson.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Emerson(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Emerson addenda = new HyperSoft.ElectronicDocumentLibrary.Emerson.Addenda.Emerson();

      addenda.Data.Version.Value = "1.6";
      addenda.Data.NumeroProveedor.Value = "150041642";
      addenda.Data.Moneda.Value = "MXN";
      addenda.Data.NumeroOrdenCompra.Value = "4110074260";
      addenda.Data.NumeroRecepcion.Value = "28344";
      addenda.Data.UsoFuturo.Value = "65536";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Emerson.xml", out fileName);
    }
  }
}