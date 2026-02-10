using System;
using HyperSoft.Base;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.GrupoModelo.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool GrupoModelo(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      GrupoModelo addenda = HyperSoft.ElectronicDocumentLibrary.GrupoModelo.Addenda.GrupoModelo.NewEntity();

      // Se asignan los datos del complemento
      addenda.Data.Type.Value = "SimpleInvoiceType";
      addenda.Data.ContentVersion.Value = "1.3.1";
      addenda.Data.DocumentStructureVersion.Value = "AMC7.1";
      addenda.Data.DocumentStatus.Value = "ORIGINAL";
      addenda.Data.DeliveryDate.Value = DateTime.Now;

      // Se especifica el tipo de transacción a utilizar
      addenda.Data.RequestForPaymentIdentification.EntityType.Value = "FA"; /* FA = Factura y Nota de Cargo. AN = Anticipo. ND = Nota de Crédito x devolución. NA = Nota de Crédito por ajuste en precio. NE = Nota de Crédito por descuento. CO = factura de Mercancías en Consignación. */
      addenda.Data.RequestForPaymentIdentification.UniqueCreatorIdentification.Value = "12345678901234567"; // Los primeros 17 caracteres del UUID

      // Se especifica que tipo de instrucciones comerciales son enviadas
      ElectronicDocumentLibrary.GrupoModelo.Addenda.Header.SpecialInstruction specialInstruction = addenda.Data.SpecialInstructionList.Add();
      specialInstruction.Code.Value = "AAB";

      ObjectBaseString text = specialInstruction.TextList.Add();
      text.Value = "EMPAQUE";

      //text = specialInstruction.TextList.Add();
      //text.Value = "Text 2";

      //  Se especifica información sobre la orden de compra a la que hace referencia la factura
      ElectronicDocumentLibrary.GrupoModelo.Addenda.Header.ReferenceIdentification referenceIdentification = addenda.Data.OrderIdentification.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "4500371692";
      referenceIdentification.TypeDefinition.Value = "ON";
      addenda.Data.OrderIdentification.ReferenceDate.Value = DateTime.Now;

      // Se especifican las referencias adicionales a nivel global, sólo aplica cuando se trate de una nota de crédito
      referenceIdentification = addenda.Data.AdditionalInformation.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "bfa0d0bd-6024-45a6-bc81-20941fe36606";
      referenceIdentification.TypeDefinition.Value = "IV";

      // Se especifica información de recepción de mercancia.Información emitida por el comprador cuando recibe la mercancía que es facturada.
      referenceIdentification = addenda.Data.DeliveryNote.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "A9876";
      addenda.Data.DeliveryNote.ReferenceDate.Value = DateTime.Now;

      // Se especifica información del comprador
      addenda.Data.Buyer.Gln.Value = "7505000070006";
      addenda.Data.Buyer.ContactInformation.PersonOrDepartmentName.Text.Value = "2007"; // Número de sociedad

      // Se especifica información del vendedor
      addenda.Data.Seller.Gln.Value = "7500000000000";
      addenda.Data.Seller.AlternatePartyIdentification.Value = "10003993";
      addenda.Data.Seller.AlternatePartyIdentification.TypeDefinition.Value = "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY";

      // Se especifica la ubicación donde debe realizarse la entrega de la mercancía.
      addenda.Data.ShipTo.Gln.Value = "C234678901234";
      ElectronicDocumentLibrary.GrupoModelo.Addenda.Header.NameAndAddress nameAndAddress = addenda.Data.ShipTo.NameAndAddressList.Add();
      nameAndAddress.Name.Value = "COMPAÑIA  CERVECERA  ZACATECAS, S.";
      nameAndAddress.StreetAddressOne.Value = "BLVD. ANTONIO FERNANDEZ RODRIGUEZ10";
      nameAndAddress.City.Value = "ZACATECAS";
      nameAndAddress.PostalCode.Value = "98500";

      // Ubicación donde se especifica el identificador del emisor de la factura si es distinto del identificador del proveedor.
      addenda.Data.InvoiceCreator.Gln.Value = "7500000000000";
      addenda.Data.InvoiceCreator.AlternatePartyIdentification.Value = "10003993";
      addenda.Data.InvoiceCreator.AlternatePartyIdentification.TypeDefinition.Value = "VA";
      addenda.Data.InvoiceCreator.NameAndAddress.Name.Value = "PAPEL CARTON Y DERIVADOS S.A de C.V";
      addenda.Data.InvoiceCreator.NameAndAddress.StreetAddressOne.Value = "CAMINO VIEJO A CORTAZAR KM 2.5S/NSI";
      addenda.Data.InvoiceCreator.NameAndAddress.City.Value = "GUANAJUATO";
      addenda.Data.InvoiceCreator.NameAndAddress.PostalCode.Value = "38020";

      // Se especifica la ubicación de la aduana
      ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.Customs customs = addenda.Data.CustomsList.Add();
      customs.Gln.Value = "E234678901234";
      customs.AlternatePartyIdentification.TypeDefinition.Value = "TN";
      customs.ReferenceDate.Value = DateTime.Now;
      customs.NameAndAddress.Name.Value = "Nombre";
      customs.NameAndAddress.City.Value = "City";

      // Se especifica el tipo de divisa utilizada, para efectos de comprobantes fiscales digitales emitidos UNICAMENTE se podrá utilizar como
      // divisa la moneda nacional (MXN), sin embargo dentro del complemento se podrá detallar en otra de forma informativa. Lo detallado en esta etiqueta deberá
      // coincidir con lo declarado en las etiquetas del SAT considerando el tipo de cambio.
      ElectronicDocumentLibrary.GrupoModelo.Addenda.Header.Currency currency = addenda.Data.CurrencyList.Add();
      currency.CurrencyIsoCode.Value = "MXN";

      ObjectBaseString currencyFunction = currency.CurrencyFunctionList.Add();
      currencyFunction.Value = "BILLING_CURRENCY";

      currency.RateOfChange.Value = "1.0000";

      // Se especifica los términos de pago de la factura
      addenda.Data.PaymentTerms.PaymentTermsEvent.Value = "EFFECTIVE_DATE";
      addenda.Data.PaymentTerms.PaymentTermsRelationTime.Value = "REFERENCE_AFTER";

      // Se especifica las condiciones de pago
      addenda.Data.PaymentTerms.NetPayment.NetPaymentTermsType.Value = "END_OF_MONTH";
      addenda.Data.PaymentTerms.NetPayment.PaymentTimePeriod.TimePeriodDue.TimePeriod.Value = "DAYS";
      addenda.Data.PaymentTerms.NetPayment.PaymentTimePeriod.TimePeriodDue.ValueDescripcion.Value = "30";

      // Se especifica los descuentos por pago
      addenda.Data.PaymentTerms.DiscountPayment.DiscountType.Value = "ALLOWANCE_BY_PAYMENT_ON_TIME";
      addenda.Data.PaymentTerms.DiscountPayment.Percentage.Value = "0";

      // Se especifica la información de los cargos o descuentos globales mercantiles por factura
      ElectronicDocumentLibrary.GrupoModelo.Addenda.Header.AllowanceCharge allowanceCharge = addenda.Data.AllowanceChargeList.Add();
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

        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.LineItem lineItem = addenda.Data.LineItemList.Add();

        lineItem.TypeDescription.Value = "SimpleInvoiceLineItemType";
        lineItem.OrderLineNumber.Value = 10;

        // Se especifica la identificación de cada artículo
        lineItem.TradeItemIdentification.Gtin.Value = "98765432109876";

        // tipo de identificacion adicional
        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.AlternateTradeItemIdentification alternateTradeItemIdentification = lineItem.AlternateTradeItemIdentificationList.Add();
        alternateTradeItemIdentification.TypeDefinition.Value = "BUYER_ASSIGNED";
        alternateTradeItemIdentification.Value = "98765432109876" + i;

        // indica la descripcion del articulo
        lineItem.TradeItemDescriptionInformation.Language.Value = "ES";
        lineItem.TradeItemDescriptionInformation.LongText.Value = "CAJAS DE CARTON KRAFT C";

        // cantidad facturada del producto
        lineItem.InvoicedQuantity.UnitOfMeasure.Value = "EA";
        lineItem.InvoicedQuantity.Value = "10";

        // cantidad que se esta declarando como adicional
        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.AditionalQuantity aditionalQuantity = lineItem.AditionalQuantityList.Add();
        aditionalQuantity.Value = "1";
        aditionalQuantity.QuantityType.Value = "FREE_GOODS";

        // declaracion del precio bruto
        lineItem.GrossPrice.Amount.Value = "100";

        // declaracion del precio neto
        lineItem.NetPrice.Amount.Value = "100";

        // Informacion adicional de referencia en el detalle de producto
        lineItem.AdditionalInformation.ReferenceIdentification.Value = "REM0001";
        lineItem.AdditionalInformation.ReferenceIdentification.TypeDescription.Value = "DQ";

        // Se especifica la información de la aduana
        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.Customs customsLine = lineItem.CustomsList.Add();
        customsLine.Gln.Value = "F2346789012341";
        customsLine.AlternatePartyIdentification.Value = "P2459";
        customsLine.AlternatePartyIdentification.TypeDefinition.Value = "TN";
        customsLine.ReferenceDate.Value = DateTime.Now;
        // Nombre de la aduana
        customsLine.NameAndAddress.Name.Value = "Laredo";

        // Información de identificación logística
        lineItem.LogisticUnits.SerialShippingContainerCode.Value = "XX458";
        lineItem.LogisticUnits.SerialShippingContainerCode.TypeDefinition.Value = "BJ";

        // Información de empaquetado
        lineItem.PalletInformation.PalletQuantity.Value = "10";
        lineItem.PalletInformation.Description.Value = "CAJAS";
        lineItem.PalletInformation.Description.TypeDefinition.Value = "BOX";
        lineItem.PalletInformation.Transport.MethodOfPayment.Value = "PAID_BY_BUYER";

        // información adicional de lote del producto facturado
        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.LotNumber lotNumber = lineItem.ExtendedAttributes.LotNumberList.Add();
        lotNumber.ProductionDate.Value = DateTime.Now;
        lotNumber.Value = "LOTE1";

        // información de los cargos o descuentos globales por línea de artículo
        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.AllowanceCharge allowanceChargeLine = lineItem.AllowanceChargeList.Add();
        allowanceChargeLine.AllowanceChargeType.Value = "CHARGE_GLOBAL";
        allowanceChargeLine.SettlementType.Value = "CHARGE_TO_BE_PAID_BY_CUSTOMER";
        allowanceChargeLine.SequenceNumber.Value = "1";
        allowanceChargeLine.SpecialServicesType.Value = "SAB";
        allowanceChargeLine.MonetaryAmountOrPercentage.PercentagePerUnit.Value = "2";
        allowanceChargeLine.MonetaryAmountOrPercentage.RatePerUnit.AmountPerUnit.Value = "2.4";

        // impuestos por cada línea de artículo
        ElectronicDocumentLibrary.GrupoModelo.Addenda.Lines.TradeItemTaxInformation tradeItemTaxInformation = lineItem.TradeItemTaxInformationList.Add();
        tradeItemTaxInformation.TaxTypeDescription.Value = "VAT";
        tradeItemTaxInformation.ReferenceNumber.Value = "15";
        tradeItemTaxInformation.TradeItemTaxAmount.TaxPercentage.Value = "16";
        tradeItemTaxInformation.TradeItemTaxAmount.TaxAmount.Value = "16.00";
        tradeItemTaxInformation.TaxCategory.Value = "TRANSFERIDO";

        // importes monetarios por línea de articulo
        lineItem.TotalLineAmount.GrossAmount.Amount.Value = "100.00";
        lineItem.TotalLineAmount.NetAmount.Amount.Value = "116.00";
      }

      // el monto total de las líneas de artículos
      addenda.Data.TotalAmount.Amount.Value = 116.00;

      ElectronicDocumentLibrary.GrupoModelo.Addenda.TotalAllowanceCharge totalAllowanceCharge = addenda.Data.TotalAllowanceChargeList.Add();
      totalAllowanceCharge.AllowanceOrChargeType.Value = "CHARGE";
      totalAllowanceCharge.SpecialServicesType.Value = "HD";
      totalAllowanceCharge.Amount.Value = "24";

      addenda.Data.BaseAmount.Amount.Value = 100;

      ElectronicDocumentLibrary.GrupoModelo.Addenda.Tax tax = addenda.Data.TaxList.Add();
      tax.Type.Value = "VAT";
      tax.Amount.Value = 16.00;
      tax.Percentage.Value = 16;
      tax.Category.Value = "TRANSFERIDO";

      addenda.Data.PayableAmount.Amount.Value = 16;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Grupo_Modelo.xml", out fileName);
    }
  }
}