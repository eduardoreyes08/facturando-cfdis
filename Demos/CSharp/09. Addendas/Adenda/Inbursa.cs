using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Inbursa.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Inbursa(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Inbursa addenda = HyperSoft.ElectronicDocumentLibrary.Inbursa.Addenda.Inbursa.NewEntity();

      addenda.Data.ReferenciaReceptor.Siniestro.Emisor.Value = "22701";
      addenda.Data.ReferenciaReceptor.Siniestro.Numero.Value = "7000116";
      addenda.Data.ReferenciaReceptor.Siniestro.Afectado.Value = "A";

      addenda.Data.ReferenciaReceptor.Deducible.Importe.Value = 1;
      addenda.Data.ReferenciaReceptor.Descuento.Importe.Value = 2;
      addenda.Data.ReferenciaReceptor.TotalManoObra.Importe.Value = 3;
      addenda.Data.ReferenciaReceptor.TotalRefacciones.Importe.Value = 4;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Inbursa.xml", out fileName);
    }
  }
}