using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Ado.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Ado(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Ado addenda = HyperSoft.ElectronicDocumentLibrary.Ado.Addenda.Ado.NewEntity();

      addenda.Data.Proveedor.TipoAddenda.Value = "Tipo";
      addenda.Data.Addenda.Valor.Value = "Addenda";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Ado.xml", out fileName);
    }
  }
}