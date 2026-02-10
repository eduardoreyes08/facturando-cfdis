using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Gomsa.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Gomsa(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Gomsa addenda = new Gomsa().Initialization();

      addenda.Data.Referencia.Value = "1";
      addenda.Data.Pedimento.Value = "2";
      addenda.Data.Patente.Value = "3";
      addenda.Data.GuiaContenedor.Value = "4";
      addenda.Data.Aduana.Value = "5";

      for (int i = 0; i < 2; i++)
      {
        Concepto concepto = addenda.Data.Conceptos.Add();
        concepto.Descripcion.Value = "A";
        concepto.GuiaContenedor.Value = "B";
      }
      
      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_GOMSA.xml", out fileName);
    }
  }
}