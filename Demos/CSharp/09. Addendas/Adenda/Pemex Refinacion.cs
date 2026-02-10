using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Pemex.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool PemexRefinacion(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      PemexRefinacion addenda = new PemexRefinacion();

      addenda.Data.Campo1.Value = "Campo1";
      addenda.Data.Campo2.Value = "Campo2";
      addenda.Data.Campo3.Value = "Campo3";
      addenda.Data.Campo4.Value = "1";
      addenda.Data.Campo5.Value = "2";
      addenda.Data.Campo6.Value = "Campo6";
      addenda.Data.Campo7.Value = "Campo7";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_PemexRefinacion.xml", out fileName);
    }
  }
}