using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.SectorPrimario.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool SectorPrimario(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      SectorPrimario addenda = HyperSoft.ElectronicDocumentLibrary.SectorPrimario.Addenda.SectorPrimario.NewEntity();

      addenda.Data.Adquiriente.CertificateFile.Value = "ABC";
      addenda.Data.Adquiriente.KeyFile.Value = "DEF";
      addenda.Data.Adquiriente.Password.Value = "12345678a";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_SectorPrimario.xml", out fileName);
    }
  }
}