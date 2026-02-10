using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Aluprint.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Aluprint(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Aluprint addenda = HyperSoft.ElectronicDocumentLibrary.Aluprint.Addenda.Aluprint.NewEntity();

      addenda.Data.RequestForPayment.DocumentStructureVersion.Value = "1.0";
      addenda.Data.RequestForPayment.DeliveryDate.Value = DateTime.Now;
      addenda.Data.RequestForPayment.EntityType.Value = "Factura";

      addenda.Data.SpecialInstruction.Code.Value = "ROC";
      addenda.Data.SpecialInstruction.ReferenceNumber.Value = "123";

      Secuence secuence = addenda.Data.OrderIdentification.Secuence.Add();
      secuence.Consecutivo.Value = 1;
      secuence.ReferenceIdentification.Value = "1234567890";

      secuence = addenda.Data.OrderIdentification.Secuence.Add();
      secuence.Consecutivo.Value = 2;
      secuence.ReferenceIdentification.Value = "0987456321";

      secuence.DeliveryNote.DeliveryIdentification.Add().Text.Value = "0123456789";
      secuence.DeliveryNote.DeliveryIdentification.Add().Text.Value = "1234567890";
      secuence.DeliveryNote.DeliveryIdentification.Add().Text.Value = "2345678901";
      secuence.DeliveryNote.DeliveryIdentification.Add().Text.Value = "3456789012";

      addenda.Data.Customs.AlternatePartyIdentification.Value = "AlternatePartyIdentification";

      addenda.Data.Currency.CurrencyIsoCode.Value = "MXN";
      addenda.Data.Currency.RateOfChange.Value = 1;

      addenda.Data.BaseTaxes.BaseIsr.Value = 102;
      addenda.Data.BaseTaxes.BaseRetenciones.Value = 103;

      SpecialService specialService = addenda.Data.SpecialServices.Add();
      specialService.SequenceNumber.Value = "1";
      specialService.MonetaryAmountOrPercentage.Value = 10;
      specialService.SpecialServicesType.Value = "IMPCCI";

      specialService = addenda.Data.SpecialServices.Add();
      specialService.SequenceNumber.Value = "2";
      specialService.MonetaryAmountOrPercentage.Value = 11;
      specialService.SpecialServicesType.Value = "IMPCCI";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Aluprint.xml", out fileName);
    }
  }
}