using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Asofarma.Asonioscoc.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Asofarma(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Asonioscoc addenda = new Asonioscoc();

      addenda.Data.TipoProveedor.Value = 2;
      addenda.Data.NoProveedor.Value = "test";
      addenda.Data.Serie.Value = "TFA";
      addenda.Data.Folio.Value = "1022975";
      addenda.Data.OrdenCompra.Value = "124";

      Partida partida = addenda.Data.Partidas.Add();
      partida.NoPartida.Value = 1;
      partida.IvaAcreditable.Value = 8;
      partida.IvaDevengado.Value = 16;
      partida.Otros.Value = "otrox";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Asofarma_Asonioscoc.xml", out fileName);
    }
  }
}