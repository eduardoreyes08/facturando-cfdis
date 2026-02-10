using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.CorporateTravelServices.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool CorporateTravelServices(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      CorporateTravelServices addenda = HyperSoft.ElectronicDocumentLibrary.CorporateTravelServices.Addenda.CorporateTravelServices.NewEntity();

      // Se asignan los datos del complemento
      addenda.Data.Cupon.Value = "123";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_CorporateTravelServices.xml", out fileName);
    }
  }
}