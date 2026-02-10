Imports HyperSoft.Base
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Amece.Addenda
Imports HyperSoft.ElectronicDocumentLibrary.Amece.Addenda.Header
Imports HyperSoft.ElectronicDocumentLibrary.Amece.Addenda.Lines

Partial Friend NotInheritable Class Adenda

  Friend Shared Function Amece(ByRef fileName As String) As Boolean
    'En este método se cargan los datos de la factura.
    Cfdi40.CargarDatosCompleto(electronicDocument)

    Dim addenda As Amece = HyperSoft.ElectronicDocumentLibrary.Amece.Addenda.Amece.NewEntity()

    ' Se asignan los datos del complemento
    addenda.Data.Type.Value = "SimpleInvoiceType"
    addenda.Data.ContentVersion.Value = "1.3.1"
    addenda.Data.DocumentStructureVersion.Value = "AMC8.1"
    addenda.Data.DocumentStatus.Value = "ORIGINAL"

    ' Se especifica el tipo de transacción a utilizar
    addenda.Data.RequestForPaymentIdentification.EntityType.Value = "INVOICE"
    addenda.Data.RequestForPaymentIdentification.UniqueCreatorIdentification.Value = "ABCDEFGHT1"

    ' Se especifica que tipo de instrucciones comerciales son enviadas
    Dim specialInstruction As ElectronicDocumentLibrary.Amece.Addenda.Header.SpecialInstruction = addenda.Data.SpecialInstructionList.Add()
    specialInstruction.Code.Value = "AAB"

    Dim text As ObjectBaseString = specialInstruction.TextList.Add()
    text.Value = "Text 1"

    text = specialInstruction.TextList.Add()
    text.Value = "Text 2"

    '  Se especifica información sobre la orden de compra a la que hace referencia la factura
    Dim referenceIdentification As ElectronicDocumentLibrary.Amece.Addenda.Header.ReferenceIdentification = addenda.Data.OrderIdentification.ReferenceIdentificationList.Add()
    referenceIdentification.Value = "AB12345"
    referenceIdentification.TypeDefinition.Value = "ON"

    addenda.Data.OrderIdentification.ReferenceDate.Value = DateTime.Now

    ' Se especifican las referencias adicionales a nivel global de la factura
    referenceIdentification = addenda.Data.AdditionalInformation.ReferenceIdentificationList.Add()
    referenceIdentification.Value = "P1258"
    referenceIdentification.TypeDefinition.Value = "ON"

    ' Se especifica información de recepción de mercancia.Información emitida por el comprador cuando recibe la mercancía que es facturada.
    referenceIdentification = addenda.Data.DeliveryNote.ReferenceIdentificationList.Add()
    referenceIdentification.Value = "A9876"
    addenda.Data.DeliveryNote.ReferenceDate.Value = DateTime.Now

    ' Se especifica información del comprador
    addenda.Data.Buyer.Gln.Value = "A234678901234"
    addenda.Data.Buyer.ContactInformation.PersonOrDepartmentName.Text.Value = "Juan Pérez"

    ' Se especifica información del vendedor
    addenda.Data.Seller.Gln.Value = "B234678901234"
    addenda.Data.Seller.AlternatePartyIdentification.Value = "5511"
    addenda.Data.Seller.AlternatePartyIdentification.TypeDefinition.Value = "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY"

    ' Se especifica la ubicación donde debe realizarse la entrega de la mercancía.
    addenda.Data.ShipTo.Gln.Value = "C234678901234"
    Dim nameAndAddress As NameAndAddress = addenda.Data.ShipTo.NameAndAddressList.Add()
    nameAndAddress.Name.Value = "Empresa Prueba 1"
    nameAndAddress.StreetAddressOne.Value = "Heriberto Frias 513 Col. Narvarte"
    nameAndAddress.City.Value = "MEXICO , EDO. DISTRITO FEDERAL"
    nameAndAddress.PostalCode.Value = "03100"

    ' Ubicación donde se especifica el identificador del emisor de la factura si es distinto del identificador del proveedor.
    addenda.Data.InvoiceCreator.Gln.Value = "D234678901234"
    addenda.Data.InvoiceCreator.AlternatePartyIdentification.Value = "55896"
    addenda.Data.InvoiceCreator.AlternatePartyIdentification.TypeDefinition.Value = "IA"
    addenda.Data.InvoiceCreator.NameAndAddress.Name.Value = "Empresa Prueba 2"
    addenda.Data.InvoiceCreator.NameAndAddress.StreetAddressOne.Value = "Madero 705, Col Centro"
    addenda.Data.InvoiceCreator.NameAndAddress.City.Value = "Aguascalientes, Ags"
    addenda.Data.InvoiceCreator.NameAndAddress.PostalCode.Value = "20080"

    ' Se especifica la ubicación de la aduana
    Dim customs As ElectronicDocumentLibrary.Amece.Addenda.Lines.Customs = addenda.Data.CustomsList.Add()
    customs.Gln.Value = "E234678901234"
    customs.AlternatePartyIdentification.TypeDefinition.Value = "TN"
    customs.ReferenceDate.Value = DateTime.Now
    customs.NameAndAddress.Name.Value = "Nombre"
    customs.NameAndAddress.City.Value = "City"

    ' Se especifica el tipo de divisa utilizada, para efectos de comprobantes fiscales digitales emitidos UNICAMENTE se podrá utilizar como
    ' divisa la moneda nacional (MXN), sin embargo dentro del complemento se podrá detallar en otra de forma informativa. Lo detallado en esta etiqueta deberá
    ' coincidir con lo declarado en las etiquetas del SAT considerando el tipo de cambio.
    Dim currency As ElectronicDocumentLibrary.Amece.Addenda.Header.Currency = addenda.Data.CurrencyList.Add()
    currency.CurrencyIsoCode.Value = "MXN"

    Dim currencyFunction As ObjectBaseString = currency.CurrencyFunctionList.Add()
    currencyFunction.Value = "PAYMENT_CURRENCY"

    currency.RateOfChange.Value = "1"

    ' Se especifica los términos de pago de la factura
    addenda.Data.PaymentTerms.PaymentTermsEvent.Value = "EFFECTIVE_DATE"
    addenda.Data.PaymentTerms.PaymentTermsRelationTime.Value = "REFERENCE_AFTER"

    ' Se especifica las condiciones de pago
    addenda.Data.PaymentTerms.NetPayment.NetPaymentTermsType.Value = "END_OF_MONTH"
    addenda.Data.PaymentTerms.NetPayment.PaymentTimePeriod.TimePeriodDue.TimePeriod.Value = "DAYS"
    addenda.Data.PaymentTerms.NetPayment.PaymentTimePeriod.TimePeriodDue.ValueDescripcion.Value = "30"

    ' Se especifica los descuentos por pago
    addenda.Data.PaymentTerms.DiscountPayment.DiscountType.Value = "ALLOWANCE_BY_PAYMENT_ON_TIME"
    addenda.Data.PaymentTerms.DiscountPayment.Percentage.Value = "0"

    ' Se especifica la información de los cargos o descuentos globales mercantiles por factura
    Dim allowanceCharge As ElectronicDocumentLibrary.Amece.Addenda.Header.AllowanceCharge = addenda.Data.AllowanceChargeList.Add()
    allowanceCharge.AllowanceChargeType.Value = "ALLOWANCE_GLOBAL"
    allowanceCharge.SettlementType.Value = "BILL_BACK"
    allowanceCharge.SequenceNumber.Value = "11"
    allowanceCharge.SpecialServicesType.Value = "EAB"
    allowanceCharge.MonetaryAmountOrPercentage.Rate.Base.Value = "INVOICE_VALUE"
    allowanceCharge.MonetaryAmountOrPercentage.Rate.Percentage.Value = "0"

    '*******************************************************************

    ' Se agregan 2 partidas
    For i As Integer = 0 To 2
      ' Se especifica la linea de detalle de la factura

      Dim lineItem As LineItem = addenda.Data.LineItemList.Add()

      lineItem.TypeDescription.Value = "Tipo prueba"
      lineItem.Number.Value = 1

      ' Se especifica la identificación de cada artículo
      lineItem.TradeItemIdentification.Gtin.Value = "7501234567890"

      ' tipo de identificacion adicional
      Dim alternateTradeItemIdentification As AlternateTradeItemIdentification = lineItem.AlternateTradeItemIdentificationList.Add()
      alternateTradeItemIdentification.TypeDefinition.Value = "BUYER_ASSIGNED"
      alternateTradeItemIdentification.Value = "XX" + i.ToString()

      ' indica la descripcion del articulo
      lineItem.TradeItemDescriptionInformation.Language.Value = "ES"
      lineItem.TradeItemDescriptionInformation.LongText.Value = "Caja de DVD"

      ' cantidad facturada del producto
      lineItem.InvoicedQuantity.UnitOfMeasure.Value = "Caja"
      lineItem.InvoicedQuantity.Value = "10"

      ' cantidad que se esta declarando como adicional
      Dim aditionalQuantity As AditionalQuantity = lineItem.AditionalQuantityList.Add()
      aditionalQuantity.Value = "1"
      aditionalQuantity.QuantityType.Value = "FREE_GOODS"

      ' declaracion del precio bruto
      lineItem.GrossPrice.Amount.Value = "1200"

      ' declaracion del precio neto
      lineItem.NetPrice.Amount.Value = "1392"

      ' Informacion adicional de referencia en el detalle de producto
      lineItem.AdditionalInformation.ReferenceIdentification.Value = "OR591"
      lineItem.AdditionalInformation.ReferenceIdentification.TypeDescription.Value = "ON"

      ' Se especifica la información de la aduana
      Dim customsLine As ElectronicDocumentLibrary.Amece.Addenda.Lines.Customs = lineItem.CustomsList.Add()
      customsLine.Gln.Value = "F2346789012341"
      customsLine.AlternatePartyIdentification.Value = "P2459"
      customsLine.AlternatePartyIdentification.TypeDefinition.Value = "TN"
      customsLine.ReferenceDate.Value = DateTime.Now
      ' Nombre de la aduana
      customsLine.NameAndAddress.Name.Value = "Aduana Prueba"

      ' Información de identificación logística
      lineItem.LogisticUnits.SerialShippingContainerCode.Value = "XX458"
      lineItem.LogisticUnits.SerialShippingContainerCode.TypeDefinition.Value = "BJ"

      ' Información de empaquetado
      lineItem.PalletInformation.PalletQuantity.Value = "10"
      lineItem.PalletInformation.Description.Value = "CAJAS"
      lineItem.PalletInformation.Description.TypeDefinition.Value = "BOX"
      lineItem.PalletInformation.Transport.MethodOfPayment.Value = "PAID_BY_BUYER"

      ' información adicional de lote del producto facturado
      Dim lotNumber As LotNumber = lineItem.ExtendedAttributes.LotNumberList.Add()
      lotNumber.ProductionDate.Value = DateTime.Now
      lotNumber.Value = "LOTE1"

      ' información de los cargos o descuentos globales por línea de artículo
      Dim allowanceChargeLine As Lines.AllowanceCharge = lineItem.AllowanceChargeList.Add()
      allowanceChargeLine.AllowanceChargeType.Value = "CHARGE_GLOBAL"
      allowanceChargeLine.SettlementType.Value = "CHARGE_TO_BE_PAID_BY_CUSTOMER"
      allowanceChargeLine.SequenceNumber.Value = "1"
      allowanceChargeLine.SpecialServicesType.Value = "HD"
      allowanceChargeLine.MonetaryAmountOrPercentage.PercentagePerUnit.Value = "2"
      allowanceChargeLine.MonetaryAmountOrPercentage.RatePerUnit.AmountPerUnit.Value = "2.4"

      ' impuestos por cada línea de artículo
      Dim tradeItemTaxInformation As TradeItemTaxInformation = lineItem.TradeItemTaxInformationList.Add()
      tradeItemTaxInformation.TaxTypeDescription.Value = "VAT"
      tradeItemTaxInformation.ReferenceNumber.Value = "15"
      tradeItemTaxInformation.TradeItemTaxAmount.TaxPercentage.Value = "16"
      tradeItemTaxInformation.TradeItemTaxAmount.TaxAmount.Value = "192"
      tradeItemTaxInformation.TaxCategory.Value = "TRANSFERIDO"

      ' importes monetarios por línea de articulo
      lineItem.TotalLineAmount.GrossAmount.Amount.Value = "1224"
      lineItem.TotalLineAmount.NetAmount.Amount.Value = "1392"
    Next

    ' el monto total de las líneas de artículos
    addenda.Data.TotalAmount.Amount.Value = 1392

    Dim totalAllowanceCharge As ElectronicDocumentLibrary.Amece.Addenda.TotalAllowanceCharge = addenda.Data.TotalAllowanceChargeList.Add()
    totalAllowanceCharge.AllowanceOrChargeType.Value = "CHARGE"
    totalAllowanceCharge.SpecialServicesType.Value = "HD"
    totalAllowanceCharge.Amount.Value = "24"

    addenda.Data.BaseAmount.Amount.Value = 10

    Dim tax As ElectronicDocumentLibrary.Amece.Addenda.Tax = addenda.Data.TaxList.Add()
    tax.Type.Value = "VAT"
    tax.Amount.Value = 15
    tax.Percentage.Value = 5
    tax.Category.Value = "TRANSFERIDO"

    addenda.Data.PayableAmount.Amount.Value = 16

    electronicDocument.Data.Addendas.Add(addenda)

    Return Save("Addenda_Amece.xml", fileName)
  End Function

End Class