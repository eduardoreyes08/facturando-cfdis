Imports HyperSoft.Base
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.CapaOzono.Addenda

Partial Friend NotInheritable Class Adenda

  Friend Shared Function CapaOzono(ByRef fileName As String) As Boolean
    'En este método se cargan los datos de la factura.
    Cfdi40.CargarDatosCompleto(electronicDocument)

    Dim addenda As CapaOzono = HyperSoft.ElectronicDocumentLibrary.CapaOzono.Addenda.CapaOzono.NewEntity()

    ' Se asignan los datos del complemento
    addenda.Data.Type.Value = "SimpleInvoiceType"
    addenda.Data.ContentVersion.Value = "1.0"
    addenda.Data.DocumentStructureVersion.Value = "CPLR1.0"
    addenda.Data.DocumentStatus.Value = "ORIGINAL"
    addenda.Data.DeliveryDate.Value = DateTime.Now

    ' Se especifica el tipo de transacción a utilizar
    addenda.Data.RequestForPaymentIdentification.EntityType.Value = "INVOICE"

    ' Se especifica que tipo de instrucciones comerciales son enviadas
    Dim specialInstruction As ElectronicDocumentLibrary.CapaOzono.Addenda.Header.SpecialInstruction = addenda.Data.RequestForPaymentIdentification.SpecialInstructionList.Add()
    specialInstruction.Code.Value = "ZZZ"

    Dim text As ObjectBaseString = specialInstruction.TextList.Add()
    text.Value = "OCHENTA Y SIETE MIL CUATROCIENTOS TREINTA Y SEIS PESOS 87/100 MXN"

    addenda.Data.RequestForPaymentIdentification.UniqueCreatorIdentification.Value = "FMG3084"

    '  Se especifica información sobre la orden de compra a la que hace referencia la factura
    Dim referenceIdentification As ElectronicDocumentLibrary.CapaOzono.Addenda.Header.ReferenceIdentification = addenda.Data.OrderIdentification.ReferenceIdentificationList.Add()
    referenceIdentification.Value = "1942"
    referenceIdentification.TypeDefinition.Value = "ON"

    addenda.Data.OrderIdentification.ReferenceDate.Value = DateTime.Now

    ' Se especifica información del comprador
    addenda.Data.Buyer.Gln.Value = "89"

    ' Se especifica información del vendedor
    addenda.Data.Seller.Gln.Value = "1422"
    addenda.Data.Seller.AlternatePartyIdentification.Value = "58"
    addenda.Data.Seller.AlternatePartyIdentification.TypeDefinition.Value = "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY"
    addenda.Data.Seller.IndentificaTipoProveedor.Value = "2"

    ' Se especifica la ubicación donde debe realizarse la entrega de la mercancía.
    addenda.Data.ShipTo.Gln.Value = ""
    Dim nameAndAddress As ElectronicDocumentLibrary.CapaOzono.Addenda.Header.NameAndAddress = addenda.Data.ShipTo.NameAndAddressList.Add()
    nameAndAddress.Name.Value = "BODEGA LEON"
    nameAndAddress.StreetAddressOne.Value = "OLIMPO 205"
    nameAndAddress.City.Value = "LEON"
    nameAndAddress.PostalCode.Value = "37500"

    ' Ubicación donde se especifica el identificador del emisor de la factura si es distinto del identificador del proveedor.
    addenda.Data.InvoiceCreator.Gln.Value = "D234678901234"
    addenda.Data.InvoiceCreator.AlternatePartyIdentification.Value = "55896"
    addenda.Data.InvoiceCreator.AlternatePartyIdentification.TypeDefinition.Value = "IA"
    addenda.Data.InvoiceCreator.NameAndAddress.Name.Value = "Empresa Prueba 2"
    addenda.Data.InvoiceCreator.NameAndAddress.StreetAddressOne.Value = "Madero 705, Col Centro"
    addenda.Data.InvoiceCreator.NameAndAddress.City.Value = "Aguascalientes, Ags"
    addenda.Data.InvoiceCreator.NameAndAddress.PostalCode.Value = "20080"

    ' Se especifica la ubicación de la aduana
    Dim customs As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.Customs = addenda.Data.CustomsList.Add()
    customs.Gln.Value = "E234678901234"
    customs.AlternatePartyIdentification.TypeDefinition.Value = "TN"
    customs.ReferenceDate.Value = DateTime.Now
    customs.NameAndAddress.Name.Value = "Nombre"
    customs.NameAndAddress.City.Value = "City"

    ' Se especifica el tipo de divisa utilizada, para efectos de comprobantes fiscales digitales emitidos UNICAMENTE se podrá utilizar como
    ' divisa la moneda nacional (MXN), sin embargo dentro del complemento se podrá detallar en otra de forma informativa. Lo detallado en esta etiqueta deberá
    ' coincidir con lo declarado en las etiquetas del SAT considerando el tipo de cambio.
    Dim currency As ElectronicDocumentLibrary.CapaOzono.Addenda.Header.Currency = addenda.Data.CurrencyList.Add()
    currency.CurrencyIsoCode.Value = "MXN"

    Dim currencyFunction As ObjectBaseString = currency.CurrencyFunctionList.Add()
    currencyFunction.Value = "BILLING_CURRENCY"
    currency.RateOfChange.Value = "1.00"

    ' Se especifica el total de lotes
    Dim totalLotes As ElectronicDocumentLibrary.CapaOzono.Addenda.Header.TotalLotes = addenda.Data.TotalLotesList.Add()
    totalLotes.Cajas.Value = 348

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
    Dim allowanceCharge As ElectronicDocumentLibrary.CapaOzono.Addenda.Header.AllowanceCharge = addenda.Data.AllowanceChargeList.Add()
    allowanceCharge.AllowanceChargeType.Value = "ALLOWANCE_GLOBAL"
    allowanceCharge.SettlementType.Value = "BILL_BACK"
    allowanceCharge.SequenceNumber.Value = "11"
    allowanceCharge.SpecialServicesType.Value = "EAB"
    allowanceCharge.MonetaryAmountOrPercentage.Rate.Base.Value = "INVOICE_VALUE"
    allowanceCharge.MonetaryAmountOrPercentage.Rate.Percentage.Value = "0"

    '*******************************************************************//

    ' Se agregan 2 partidas
    For i As Integer = 0 To 2
      ' Se especifica la linea de detalle de la factura

      Dim lineItem As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.LineItem = addenda.Data.LineItemList.Add()

      lineItem.TypeDescription.Value = "SimpleInvoiceLineItemType"
      lineItem.Number.Value = 1

      ' Se especifica la identificación de cada artículo
      lineItem.TradeItemIdentification.Gtin.Value = "165807-2"

      ' tipo de identificacion adicional
      Dim alternateTradeItemIdentification As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.AlternateTradeItemIdentification = lineItem.AlternateTradeItemIdentificationList.Add()
      alternateTradeItemIdentification.TypeDefinition.Value = "BUYER_ASSIGNED"
      alternateTradeItemIdentification.Value = "1-165807-2" + i.ToString()

      ' Codigo Talla Interno Ozono
      lineItem.CodigoTallaInterno.Codigo.Value = "165807-2"
      lineItem.CodigoTallaInterno.Talla.Value = 220
      lineItem.CodigoTallaInterno.Pedido.Value = "99323552"
      lineItem.CodigoTallaInterno.Renglon.Value = 139
      lineItem.CodigoTallaInterno.SemanaEntrega.Value = 201238

      ' indica la descripcion del articulo
      lineItem.TradeItemDescriptionInformation.Language.Value = "ES"
      lineItem.TradeItemDescriptionInformation.LongText.Value = "165807-2 KAMBAS MARINO"

      ' cantidad facturada del producto
      lineItem.InvoicedQuantity.UnitOfMeasure.Value = "PCE"
      lineItem.InvoicedQuantity.Value = "15.00"

      ' cantidad que se esta declarando como adicional
      Dim aditionalQuantity As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.AditionalQuantity = lineItem.AditionalQuantityList.Add()
      aditionalQuantity.Value = "1"
      aditionalQuantity.QuantityType.Value = "FREE_GOODS"

      ' declaracion del precio bruto
      lineItem.GrossPrice.Amount.Value = "100"

      ' declaracion del precio neto
      lineItem.NetPrice.Amount.Value = "100"

      ' Informacion adicional de referencia en el detalle de producto
      lineItem.AdditionalInformation.ReferenceIdentification.Value = "OR591"
      lineItem.AdditionalInformation.ReferenceIdentification.TypeDescription.Value = "ON"

      ' Se especifica la información de la aduana
      Dim customsLine As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.Customs = lineItem.CustomsList.Add()
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
      lineItem.PalletInformation.Description.Value = "CAJAS"
      lineItem.PalletInformation.Description.TypeDefinition.Value = "BOX"
      lineItem.PalletInformation.Transport.MethodOfPayment.Value = "PAID_BY_BUYER"
      lineItem.PalletInformation.PrepactCant.Value = "2"
      ' falta prepactCant

      ' información adicional de lote del producto facturado
      Dim lotNumber As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.LotNumber = lineItem.ExtendedAttributes.LotNumberList.Add()
      lotNumber.ProductionDate.Value = DateTime.Now
      lotNumber.Value = "LOTE1"

      ' información de los cargos o descuentos globales por línea de artículo
      Dim allowanceChargeLine As ElectronicDocumentLibrary.CapaOzono.Addenda.Lines.AllowanceCharge = lineItem.AllowanceChargeList.Add()
      allowanceChargeLine.AllowanceChargeType.Value = "CHARGE_GLOBAL"
      allowanceChargeLine.SettlementType.Value = "CHARGE_TO_BE_PAID_BY_CUSTOMER"
      allowanceChargeLine.SequenceNumber.Value = "1"
      allowanceChargeLine.SpecialServicesType.Value = "AA"
      allowanceChargeLine.MonetaryAmountOrPercentage.PercentagePerUnit.Value = "0"
      allowanceChargeLine.MonetaryAmountOrPercentage.RatePerUnit.AmountPerUnit.Value = "0.00"

      ' importes monetarios por línea de articulo
      lineItem.TotalLineAmount.GrossAmount.Amount.Value = "100"
      lineItem.TotalLineAmount.NetAmount.Amount.Value = "116"
    Next

    ' el monto total de las líneas de artículos
    addenda.Data.TotalAmount.Amount.Value = 116.0

    Dim totalAllowanceCharge As ElectronicDocumentLibrary.CapaOzono.Addenda.TotalAllowanceCharge = addenda.Data.TotalAllowanceChargeList.Add()
    totalAllowanceCharge.AllowanceOrChargeType.Value = "ALLOWANCE"
    totalAllowanceCharge.SpecialServicesType.Value = "AA"
    totalAllowanceCharge.Amount.Value = "0.00"

    addenda.Data.BaseAmount.Amount.Value = 100

    Dim tax As ElectronicDocumentLibrary.CapaOzono.Addenda.Tax = addenda.Data.TaxList.Add()
    tax.Type.Value = "VAT"
    tax.Amount.Value = 16.0
    tax.Percentage.Value = 16.0
    tax.Category.Value = "TRANSFERIDO"

    addenda.Data.PayableAmount.Amount.Value = 116.0

    ' Cadena original
    addenda.Data.CadenaOriginal.Cadena.Value = electronicDocument.FingerPrint

    electronicDocument.Data.Addendas.Add(addenda)

    Return Save("Addenda_CapaOzono.xml", fileName)
  End Function

End Class