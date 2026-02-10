using System;
using HyperSoft.Base;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Coppel.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool CoppelRopa(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Coppel addenda = HyperSoft.ElectronicDocumentLibrary.Coppel.Addenda.Coppel.NewEntity();

      // Se asignan los datos del complemento
      addenda.Data.Type.Value = "SimpleInvoiceType";
      addenda.Data.ContentVersion.Value = "1";
      addenda.Data.DocumentStructureVersion.Value = "CPLR1.0";
      addenda.Data.DocumentStatus.Value = "ORIGINAL";
      addenda.Data.DeliveryDate.Value = DateTime.Now;

      // Se especifica el tipo de transacción a utilizar
      addenda.Data.RequestForPaymentIdentification.EntityType.Value = "INVOICE";
      addenda.Data.RequestForPaymentIdentification.UniqueCreatorIdentification.Value = "FMG344";

      //  Se especifica información sobre la orden de compra a la que hace referencia la factura
      ElectronicDocumentLibrary.Coppel.Addenda.Header.ReferenceIdentification referenceIdentification = addenda.Data.OrderIdentification.ReferenceIdentificationList.Add();
      referenceIdentification.Value = "41349K";
      referenceIdentification.TypeDefinition.Value = "ON";

      addenda.Data.OrderIdentification.ReferenceDate.Value = DateTime.Now;

      // Se especifica información del vendedor
      addenda.Data.Seller.Gln.Value = "1";
      addenda.Data.Seller.AlternatePartyIdentification.Value = "41114";
      addenda.Data.Seller.AlternatePartyIdentification.TypeDefinition.Value = "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY";
      addenda.Data.Seller.IndentificaTipoProveedor.Value = "2";

      // Se especifica la ubicación donde debe realizarse la entrega de la mercancía.
      addenda.Data.ShipTo.Gln.Value = "C234678901234";
      ElectronicDocumentLibrary.Coppel.Addenda.Header.NameAndAddressBodega nameAndAddress = addenda.Data.ShipTo.NameAndAddressList.Add();
      nameAndAddress.Name.Value = "Empresa Prueba 1";
      nameAndAddress.StreetAddressOne.Value = "Heriberto Frias 513 Col. Narvarte";
      nameAndAddress.City.Value = "MEXICO , EDO. DISTRITO FEDERAL";
      nameAndAddress.PostalCode.Value = "03100";
      nameAndAddress.BodegaEntrega.Value = "1";

      // Se especifica el tipo de divisa utilizada, para efectos de comprobantes fiscales digitales emitidos UNICAMENTE se podrá utilizar como
      // divisa la moneda nacional (MXN), sin embargo dentro del complemento se podrá detallar en otra de forma informativa. Lo detallado en esta etiqueta deberá
      // coincidir con lo declarado en las etiquetas del SAT considerando el tipo de cambio.
      ElectronicDocumentLibrary.Coppel.Addenda.Header.Currency currency = addenda.Data.CurrencyList.Add();
      currency.CurrencyIsoCode.Value = "MXN";

      ObjectBaseString currencyFunction = currency.CurrencyFunctionList.Add();
      currencyFunction.Value = "BILLING_CURRENCY";

      currency.RateOfChange.Value = "1.00";

      // Se especifica el total de lotes
      ElectronicDocumentLibrary.Coppel.Addenda.Header.TotalLotes totalLotes = addenda.Data.TotalLotesList.Add();
      totalLotes.Cajas.Value = 28;

      //*******************************************************************//

      // Se agregan 2 partidas
      for (int i = 1; i <= 2; i++)
      {
        // Se especifica la linea de detalle de la factura

        ElectronicDocumentLibrary.Coppel.Addenda.Lines.LineItem lineItem = addenda.Data.LineItemList.Add();

        lineItem.TypeDescription.Value = "SimpleInvoiceLineItemType";
        lineItem.Number.Value = 1;

        // Se especifica la identificación de cada artículo
        lineItem.TradeItemIdentification.Gtin.Value = "7501234567890";

        // tipo de identificacion adicional
        ElectronicDocumentLibrary.Coppel.Addenda.Lines.AlternateTradeItemIdentification alternateTradeItemIdentification = lineItem.AlternateTradeItemIdentificationList.Add();
        alternateTradeItemIdentification.TypeDefinition.Value = "BUYER_ASSIGNED";
        alternateTradeItemIdentification.Value = "803183" + i; // no lo esta reflejando

        // Codigo Talla Interno Ozono      CAMBIAR POR CodigoTallaInternoCop
        lineItem.CodigoTallaInterno.Codigo.Value = "1";
        lineItem.CodigoTallaInterno.Talla.Value = 2;

        // indica la descripcion del articulo
        lineItem.TradeItemDescriptionInformation.Language.Value = "ES";
        lineItem.TradeItemDescriptionInformation.LongText.Value = "803183 SOFIA N NEGRO";

        // cantidad facturada del producto
        lineItem.InvoicedQuantity.UnitOfMeasure.Value = "PCE";
        lineItem.InvoicedQuantity.Value = "28.00";

        // cantidad que se esta declarando como adicional
        ElectronicDocumentLibrary.Coppel.Addenda.Lines.AditionalQuantity aditionalQuantity = lineItem.AditionalQuantityList.Add();
        aditionalQuantity.Value = "1";
        aditionalQuantity.QuantityType.Value = "FREE_GOODS";

        // declaracion del precio bruto
        lineItem.GrossPrice.Amount.Value = "132.00";

        // declaracion del precio neto
        lineItem.NetPrice.Amount.Value = "132.00";

        // Información de empaquetado
        lineItem.PalletInformation.Description.Value = "CAJAS";
        lineItem.PalletInformation.Description.TypeDefinition.Value = "BOX";
        lineItem.PalletInformation.Transport.MethodOfPayment.Value = "PREPAID_BY_SELLER";
        lineItem.PalletInformation.PrepactCant.Value = "6";

        // información adicional de lote del producto facturado
        ElectronicDocumentLibrary.Coppel.Addenda.Lines.LotNumber lotNumber = lineItem.ExtendedAttributes.LotNumberList.Add();
        lotNumber.ProductionDate.Value = DateTime.Now;
        lotNumber.Value = "LOTE1";

        // información de los cargos o descuentos globales por línea de artículo
        ElectronicDocumentLibrary.Coppel.Addenda.Lines.AllowanceCharge allowanceChargeLine = lineItem.AllowanceChargeList.Add();
        allowanceChargeLine.AllowanceChargeType.Value = "ALLOWANCE_GLOBAL";
        allowanceChargeLine.SettlementType.Value = "CHARGE_TO_BE_PAID_BY_CUSTOMER";
        allowanceChargeLine.SequenceNumber.Value = "1";
        allowanceChargeLine.SpecialServicesType.Value = "PAD";
        allowanceChargeLine.MonetaryAmountOrPercentage.PercentagePerUnit.Value = "0.00";
        allowanceChargeLine.MonetaryAmountOrPercentage.RatePerUnit.AmountPerUnit.Value = "0.00";

        // importes monetarios por línea de articulo
        lineItem.TotalLineAmount.GrossAmount.Amount.Value = "3696.00";
        lineItem.TotalLineAmount.NetAmount.Amount.Value = "3696.00";
      }

      // el monto total de las líneas de artículos
      addenda.Data.TotalAmount.Amount.Value = 4287.32;

      ElectronicDocumentLibrary.Coppel.Addenda.TotalAllowanceCharge totalAllowanceCharge = addenda.Data.TotalAllowanceChargeList.Add();
      totalAllowanceCharge.AllowanceOrChargeType.Value = "ALLOWANCE";
      totalAllowanceCharge.SpecialServicesType.Value = "TD";
      totalAllowanceCharge.Amount.Value = "0.00";

      addenda.Data.BaseAmount.Amount.Value = 3696.00;

      ElectronicDocumentLibrary.Coppel.Addenda.Tax tax = addenda.Data.TaxList.Add();
      tax.Type.Value = "VAT";
      tax.Amount.Value = 591.36;
      tax.Percentage.Value = 16;
      tax.Category.Value = "TRANSFERIDO";

      addenda.Data.PayableAmount.Amount.Value = 4287.32;

      // Cadena original
      addenda.Data.CadenaOriginal.Cadena.Value = electronicDocument.FingerPrint;


      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_CoppelRopa.xml", out fileName);
    }
  }
}