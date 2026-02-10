using System;
using HyperSoft.Base;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle;
using HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Header;
using HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Lines;
using HyperSoft.ElectronicDocumentLibrary.Document;
using AllowanceCharge = HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Header.AllowanceCharge;
using ReferenceIdentification = HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Header.ReferenceIdentification;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class SectorDeVentasAlDetalle131
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.SectorDeVentasAlDetalle);
      HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Data)electronicDocument.Data.Complementos.Last();

      // Se asignan los datos del complemento
      data.Type.Value = "SimpleInvoiceType";
      data.ContentVersion.Value = "1.3.1";
      data.DocumentStructureVersion.Value = "AMC8.1";
      data.DocumentStatus.Value = "ORIGINAL";

      // Se especifica el tipo de transacción a utilizar
      data.RequestForPaymentIdentification.EntityType.Value = "INVOICE";

      // Se especifica que tipo de instrucciones comerciales son enviadas
      SpecialInstruction specialInstruction = data.SpecialInstructionList.Add();
      specialInstruction.Code.Value = "AAB";

      ObjectBaseString text = specialInstruction.TextList.Add();
      text.Value = "Text 1";

      text = specialInstruction.TextList.Add();
      text.Value = "Text 2";

      //  Se especifica información sobre la orden de compra a la que hace referencia la factura
      ReferenceIdentification referenceIdentification = data.OrderIdentification.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "AB12345";
      referenceIdentification.TypeDefinition.Value = "ON";
      data.OrderIdentification.ReferenceDate.Value = DateTime.Now;

      // Se especifican las referencias adicionales a nivel global de la factura
      referenceIdentification = data.AdditionalInformation.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "P1258";
      referenceIdentification.TypeDefinition.Value = "ON";

      // Se especifica información de recepción de mercancia.Información emitida por el comprador cuando recibe la mercancía que es facturada.
      referenceIdentification = data.DeliveryNote.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "A9876";
      data.DeliveryNote.ReferenceDate.Value = DateTime.Now;

      // Se especifica información del comprador
      data.Buyer.Gln.Value = "A234678901234";
      data.Buyer.ContactInformation.PersonOrDepartmentName.Text.Value = "Juan Pérez";

      // Se especifica información del vendedor
      data.Seller.Gln.Value = "B234678901234";
      data.Seller.AlternatePartyIdentification.Value = "5511";
      data.Seller.AlternatePartyIdentification.TypeDefinition.Value = "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY";

      // Se especifica la ubicación donde debe realizarse la entrega de la mercancía.
      data.ShipTo.Gln.Value = "C234678901234";
      NameAndAddress nameAndAddress = data.ShipTo.NameAndAddressList.Add();
      nameAndAddress.Name.Value = "Empresa Prueba 1";
      nameAndAddress.StreetAddressOne.Value = "Heriberto Frias 513 Col. Narvarte";
      nameAndAddress.City.Value = "MEXICO , EDO. DISTRITO FEDERAL";
      nameAndAddress.PostalCode.Value = "03100";

      // Ubicación donde se especifica el identificador del emisor de la factura si es distinto del identificador del proveedor.
      data.InvoiceCreator.Gln.Value = "D234678901234";
      data.InvoiceCreator.AlternatePartyIdentification.Value = "55896";
      data.InvoiceCreator.AlternatePartyIdentification.TypeDefinition.Value = "IA";
      data.InvoiceCreator.NameAndAddress.Name.Value = "Empresa Prueba 2";
      data.InvoiceCreator.NameAndAddress.StreetAddressOne.Value = "Madero 705, Col Centro";
      data.InvoiceCreator.NameAndAddress.City.Value = "Aguascalientes, Ags";
      data.InvoiceCreator.NameAndAddress.PostalCode.Value = "20080";

      // Se especifica la ubicación de la aduana
      Customs customs = data.CustomsList.Add();
      customs.Gln.Value = "E234678901234";

      customs = data.CustomsList.Add();
      customs.Gln.Value = "E234678901235";

      // Se especifica el tipo de divisa utilizada, para efectos de comprobantes fiscales digitales emitidos UNICAMENTE se podrá utilizar como
      // divisa la moneda nacional (MXN), sin embargo dentro del complemento se podrá detallar en otra de forma informativa. Lo detallado en esta etiqueta deberá
      // coincidir con lo declarado en las etiquetas del SAT considerando el tipo de cambio.
      Currency currency = data.CurrencyList.Add();
      currency.CurrencyIsoCode.Value = "MXN";

      ObjectBaseString currencyFunction = currency.CurrencyFunctionList.Add();
      currencyFunction.Value = "PAYMENT_CURRENCY";

      currency.RateOfChange.Value = "1";

      // Se especifica los términos de pago de la factura
      data.PaymentTerms.PaymentTermsEvent.Value = "EFFECTIVE_DATE";
      data.PaymentTerms.PaymentTermsRelationTime.Value = "REFERENCE_AFTER";

      // Se especifica las condiciones de pago
      data.PaymentTerms.NetPayment.NetPaymentTermsType.Value = "END_OF_MONTH";
      data.PaymentTerms.NetPayment.PaymentTimePeriod.TimePeriodDue.TimePeriod.Value = "DAYS";
      data.PaymentTerms.NetPayment.PaymentTimePeriod.TimePeriodDue.ValueDescripcion.Value = "30";

      // Se especifica los descuentos por pago
      data.PaymentTerms.DiscountPayment.DiscountType.Value = "ALLOWANCE_BY_PAYMENT_ON_TIME";
      data.PaymentTerms.DiscountPayment.Percentage.Value = "0";

      // Se especifica la información de los cargos o descuentos globales mercantiles por factura
      AllowanceCharge allowanceCharge = data.AllowanceChargeList.Add();
      allowanceCharge.AllowanceChargeType.Value = "ALLOWANCE_GLOBAL";
      allowanceCharge.SettlementType.Value = "BILL_BACK";
      allowanceCharge.SequenceNumber.Value = "11";
      allowanceCharge.SpecialServicesType.Value = "EAB";
      allowanceCharge.MonetaryAmountOrPercentage.Rate.Base.Value = "INVOICE_VALUE";
      allowanceCharge.MonetaryAmountOrPercentage.Rate.Percentage.Value = "0";

      //*******************************************************************//

      // Se agregan 2 partidas
      for (int i = 1; i <= 2; i++)
      {
        // Se especifica la linea de detalle de la factura

        LineItem lineItem = data.LineItemList.Add();

        lineItem.TypeDescription.Value = "Tipo prueba";
        lineItem.Number.Value = 1;

        // Se especifica la identificación de cada artículo
        lineItem.TradeItemIdentification.Gtin.Value = "7501234567890";

        // tipo de identificacion adicional
        AlternateTradeItemIdentification alternateTradeItemIdentification = lineItem.AlternateTradeItemIdentificationList.Add();
        alternateTradeItemIdentification.TypeDefinition.Value = "BUYER_ASSIGNED";
        alternateTradeItemIdentification.Value = "XX" + i;

        // indica la descripcion del articulo
        lineItem.TradeItemDescriptionInformation.Language.Value = "ES";
        lineItem.TradeItemDescriptionInformation.LongText.Value = "Caja de DVD";

        // cantidad facturada del producto
        lineItem.InvoicedQuantity.UnitOfMeasure.Value = "Caja";
        lineItem.InvoicedQuantity.Value = "10";

        // cantidad que se esta declarando como adicional
        AditionalQuantity aditionalQuantity = lineItem.AditionalQuantityList.Add();
        aditionalQuantity.Value = "1";
        aditionalQuantity.QuantityType.Value = "FREE_GOODS";

        // declaracion del precio bruto
        lineItem.GrossPrice.Amount.Value = "1200";

        // declaracion del precio neto
        lineItem.NetPrice.Amount.Value = "1392";

        // Informacion adicional de referencia en el detalle de producto
        lineItem.AdditionalInformation.ReferenceIdentification.Value = "OR591";
        lineItem.AdditionalInformation.ReferenceIdentification.TypeDescription.Value = "ON";

        // Se especifica la información de la aduana
        Customs customsLine = lineItem.CustomsList.Add();
        customsLine.Gln.Value = "F234678901234";
        customsLine.AlternatePartyIdentification.Value = "P2459";
        customsLine.AlternatePartyIdentification.TypeDefinition.Value = "TN";
        customsLine.ReferenceDate.Value = DateTime.Now;
        // Nombre de la aduana
        customsLine.NameAndAddress.Name.Value = "Aduana Prueba";

        // Información de identificación logística
        lineItem.LogisticUnits.SerialShippingContainerCode.Value = "XX458";
        lineItem.LogisticUnits.SerialShippingContainerCode.TypeDefinition.Value = "BJ";

        // Información de empaquetado
        lineItem.PalletInformation.PalletQuantity.Value = "10";
        lineItem.PalletInformation.Description.Value = "CAJAS";
        lineItem.PalletInformation.Description.TypeDefinition.Value = "BOX";
        lineItem.PalletInformation.Transport.MethodOfPayment.Value = "PAID_BY_BUYER";

        // información adicional de lote del producto facturado
        LotNumber lotNumber = lineItem.ExtendedAttributes.LotNumberList.Add();
        lotNumber.ProductionDate.Value = DateTime.Now;
        lotNumber.Value = "LOTE1";

        // información de los cargos o descuentos globales por línea de artículo
        var allowanceChargeLine = lineItem.AllowanceChargeList.Add();
        allowanceChargeLine.AllowanceChargeType.Value = "CHARGE_GLOBAL";
        allowanceChargeLine.SettlementType.Value = "CHARGE_TO_BE_PAID_BY_CUSTOMER";
        allowanceChargeLine.SequenceNumber.Value = "1";
        allowanceChargeLine.SpecialServicesType.Value = "HD";
        allowanceChargeLine.MonetaryAmountOrPercentage.PercentagePerUnit.Value = "2";
        allowanceChargeLine.MonetaryAmountOrPercentage.RatePerUnit.AmountPerUnit.Value = "2.4";

        // impuestos por cada línea de artículo
        TradeItemTaxInformation tradeItemTaxInformation = lineItem.TradeItemTaxInformationList.Add();
        tradeItemTaxInformation.TaxTypeDescription.Value = "VAT";
        tradeItemTaxInformation.ReferenceNumber.Value = "15";
        tradeItemTaxInformation.TradeItemTaxAmount.TaxPercentage.Value = "16";
        tradeItemTaxInformation.TradeItemTaxAmount.TaxAmount.Value = "192";
        tradeItemTaxInformation.TaxCategory.Value = "TRANSFERIDO";

        // importes monetarios por línea de articulo
        lineItem.TotalLineAmount.GrossAmount.Amount.Value = "1224";
        lineItem.TotalLineAmount.NetAmount.Amount.Value = "1392";
      }

      // el monto total de las líneas de artículos
      data.TotalAmount.Amount.Value = "1392";

      TotalAllowanceCharge totalAllowanceCharge = data.TotalAllowanceChargeList.Add();
      totalAllowanceCharge.AllowanceOrChargeType.Value = "CHARGE";
      totalAllowanceCharge.SpecialServicesType.Value = "HD";
      totalAllowanceCharge.Amount.Value = "24";

      return Base.Save(electronicDocument, "SectorDeVentasAlDetalle.xml", out fileName);
    }
  }
}