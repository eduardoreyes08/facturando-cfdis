using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Comex.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Comex(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Comex addenda = HyperSoft.ElectronicDocumentLibrary.Comex.Addenda.Comex.NewEntity();

      addenda.Data.OrderIdentification.ReferenceIdentificationList.Add().Value = "NumeroPedido 1";
      addenda.Data.OrderIdentification.ReferenceIdentificationList.Add().Value = "NumeroPedido  2";

      addenda.Data.Buyer.ContactInformation.PersonOrDepartmentName.Text.Value = "a@a.com";

      ElectronicDocumentLibrary.Comex.Addenda.Currency currency = addenda.Data.Currency.Add();
      currency.CurrencyIsoCode.Value = "MXN";
      currency.RateOfChange.Value = "1";

      addenda.Data.BaseAmount.Amount.Value = 120;

      addenda.Data.Tax.Amount.Value = 1230;

      addenda.Data.PayableAmount.Amount.Value = 350;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Comex.xml", out fileName);
    }
  }
}