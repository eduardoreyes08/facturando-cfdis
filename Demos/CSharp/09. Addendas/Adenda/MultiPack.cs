using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.MultiPack.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool MultiPack(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      MultiPack addenda = HyperSoft.ElectronicDocumentLibrary.MultiPack.Addenda.MultiPack.NewEntity();

      addenda.Data.CorreoContacto.Value = "correocontacto@suempresa.com";
      addenda.Data.NumeroProveedor.Value = "123456";
      addenda.Data.CorreoProveedor.Value = "correocontacto@suempresa.com";
      addenda.Data.Tipo.Value = 1;
      addenda.Data.NumeroRelacion.Value = "NumeroRelacion";
      addenda.Data.NumeroOrden.Value = "NumeroOrden";
      addenda.Data.Moneda.Value = "MXN";
      addenda.Data.Division.Value = "1234";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_MultiPack.xml", out fileName);
    }
  }
}