using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Sanmina.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Sanmina(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Sanmina addenda = HyperSoft.ElectronicDocumentLibrary.Sanmina.Addenda.Sanmina.NewEntity();

      addenda.Data.PoNumber.Value = "PoNumber";
      addenda.Data.ElectronicMail.Value = "ElectronicMail";
      addenda.Data.LegalEntityName.Value = "LegalEntityName";
      addenda.Data.CustomerCode.Value = "CustomerCode";
      addenda.Data.Currency.Value = "Currency";
      addenda.Data.ExchangeRate.Value = 1;
      addenda.Data.InternalInvoiceNumber.Value = "InternalInvoiceNumber";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_SANMINA.xml", out fileName);
    }
  }
}