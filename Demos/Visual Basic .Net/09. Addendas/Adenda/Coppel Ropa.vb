Imports HyperSoft.Base
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Coppel.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function CoppelRopa(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Coppel = HyperSoft.ElectronicDocumentLibrary.Coppel.Addenda.Coppel.NewEntity()

		' Se asignan los datos del complemento
		addenda.Data.Type.Value = "SimpleInvoiceType"
		addenda.Data.ContentVersion.Value = "1"
		addenda.Data.DocumentStructureVersion.Value = "CPLR1.0"
		addenda.Data.DocumentStatus.Value = "ORIGINAL"
		addenda.Data.DeliveryDate.Value = DateTime.Now

		' Se especifica el tipo de transacción a utilizar
		addenda.Data.RequestForPaymentIdentification.EntityType.Value = "INVOICE"
		addenda.Data.RequestForPaymentIdentification.UniqueCreatorIdentification.Value = "FMG344"

		'  Se especifica información sobre la orden de compra a la que hace referencia la factura
		Dim referenceIdentification As ElectronicDocumentLibrary.Coppel.Addenda.Header.ReferenceIdentification = addenda.Data.OrderIdentification.ReferenceIdentificationList.Add()
		referenceIdentification.Value = "41349K"
		referenceIdentification.TypeDefinition.Value = "ON"

		addenda.Data.OrderIdentification.ReferenceDate.Value = DateTime.Now

		' Se especifica información del vendedor
		addenda.Data.Seller.Gln.Value = "1"
		addenda.Data.Seller.AlternatePartyIdentification.Value = "41114"
		addenda.Data.Seller.AlternatePartyIdentification.TypeDefinition.Value = "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY"
		addenda.Data.Seller.IndentificaTipoProveedor.Value = "2"

		' Se especifica la ubicación donde debe realizarse la entrega de la mercancía.
		addenda.Data.ShipTo.Gln.Value = "C234678901234"
		Dim nameAndAddress As ElectronicDocumentLibrary.Coppel.Addenda.Header.NameAndAddressBodega = addenda.Data.ShipTo.NameAndAddressList.Add()
		nameAndAddress.Name.Value = "Empresa Prueba 1"
		nameAndAddress.StreetAddressOne.Value = "Heriberto Frias 513 Col. Narvarte"
		nameAndAddress.City.Value = "MEXICO , EDO. DISTRITO FEDERAL"
		nameAndAddress.PostalCode.Value = "03100"
		nameAndAddress.BodegaEntrega.Value = "1"

		' Se especifica el tipo de divisa utilizada, para efectos de comprobantes fiscales digitales emitidos UNICAMENTE se podrá utilizar como
		' divisa la moneda nacional (MXN), sin embargo dentro del complemento se podrá detallar en otra de forma informativa. Lo detallado en esta etiqueta deberá
		' coincidir con lo declarado en las etiquetas del SAT considerando el tipo de cambio.
		Dim currency As ElectronicDocumentLibrary.Coppel.Addenda.Header.Currency = addenda.Data.CurrencyList.Add()
		currency.CurrencyIsoCode.Value = "MXN"

		Dim currencyFunction As ObjectBaseString = currency.CurrencyFunctionList.Add()
		currencyFunction.Value = "BILLING_CURRENCY"

		currency.RateOfChange.Value = "1.00"

		' Se especifica el total de lotes
		Dim totalLotes As ElectronicDocumentLibrary.Coppel.Addenda.Header.TotalLotes = addenda.Data.TotalLotesList.Add()
		totalLotes.Cajas.Value = 28

		'*******************************************************************//

		' Se agregan 2 partidas
	  For i As Integer = 0 To 2		
			' Se especifica la linea de detalle de la factura

			Dim lineItem As ElectronicDocumentLibrary.Coppel.Addenda.Lines.LineItem = addenda.Data.LineItemList.Add()

			lineItem.TypeDescription.Value = "SimpleInvoiceLineItemType"
			lineItem.Number.Value = 1

			' Se especifica la identificación de cada artículo
			lineItem.TradeItemIdentification.Gtin.Value = "7501234567890"

			' tipo de identificacion adicional
			Dim alternateTradeItemIdentification As ElectronicDocumentLibrary.Coppel.Addenda.Lines.AlternateTradeItemIdentification = lineItem.AlternateTradeItemIdentificationList.Add()
			alternateTradeItemIdentification.TypeDefinition.Value = "BUYER_ASSIGNED"
			alternateTradeItemIdentification.Value = "803183" + i
			' no lo esta reflejando
			' Codigo Talla Interno Ozono      CAMBIAR POR CodigoTallaInternoCop
			lineItem.CodigoTallaInterno.Codigo.Value = "1"
			lineItem.CodigoTallaInterno.Talla.Value = 2

			' indica la descripcion del articulo
			lineItem.TradeItemDescriptionInformation.Language.Value = "ES"
			lineItem.TradeItemDescriptionInformation.LongText.Value = "803183 SOFIA N NEGRO"

			' cantidad facturada del producto
			lineItem.InvoicedQuantity.UnitOfMeasure.Value = "PCE"
			lineItem.InvoicedQuantity.Value = "28.00"

			' cantidad que se esta declarando como adicional
			Dim aditionalQuantity As ElectronicDocumentLibrary.Coppel.Addenda.Lines.AditionalQuantity = lineItem.AditionalQuantityList.Add()
			aditionalQuantity.Value = "1"
			aditionalQuantity.QuantityType.Value = "FREE_GOODS"

			' declaracion del precio bruto
			lineItem.GrossPrice.Amount.Value = "132.00"

			' declaracion del precio neto
			lineItem.NetPrice.Amount.Value = "132.00"

			' Información de empaquetado
			lineItem.PalletInformation.Description.Value = "CAJAS"
			lineItem.PalletInformation.Description.TypeDefinition.Value = "BOX"
			lineItem.PalletInformation.Transport.MethodOfPayment.Value = "PREPAID_BY_SELLER"
			lineItem.PalletInformation.PrepactCant.Value = "6"

			' información adicional de lote del producto facturado
			Dim lotNumber As ElectronicDocumentLibrary.Coppel.Addenda.Lines.LotNumber = lineItem.ExtendedAttributes.LotNumberList.Add()
			lotNumber.ProductionDate.Value = DateTime.Now
			lotNumber.Value = "LOTE1"

			' información de los cargos o descuentos globales por línea de artículo
			Dim allowanceChargeLine As ElectronicDocumentLibrary.Coppel.Addenda.Lines.AllowanceCharge = lineItem.AllowanceChargeList.Add()
			allowanceChargeLine.AllowanceChargeType.Value = "ALLOWANCE_GLOBAL"
			allowanceChargeLine.SettlementType.Value = "CHARGE_TO_BE_PAID_BY_CUSTOMER"
			allowanceChargeLine.SequenceNumber.Value = "1"
			allowanceChargeLine.SpecialServicesType.Value = "PAD"
			allowanceChargeLine.MonetaryAmountOrPercentage.PercentagePerUnit.Value = "0.00"
			allowanceChargeLine.MonetaryAmountOrPercentage.RatePerUnit.AmountPerUnit.Value = "0.00"

			' importes monetarios por línea de articulo
			lineItem.TotalLineAmount.GrossAmount.Amount.Value = "3696.00"
			lineItem.TotalLineAmount.NetAmount.Amount.Value = "3696.00"			
		Next

		' el monto total de las líneas de artículos
		addenda.Data.TotalAmount.Amount.Value = 4287.32

		Dim totalAllowanceCharge As ElectronicDocumentLibrary.Coppel.Addenda.TotalAllowanceCharge = addenda.Data.TotalAllowanceChargeList.Add()
		totalAllowanceCharge.AllowanceOrChargeType.Value = "ALLOWANCE"
		totalAllowanceCharge.SpecialServicesType.Value = "TD"
		totalAllowanceCharge.Amount.Value = "0.00"

		addenda.Data.BaseAmount.Amount.Value = 3696.0

		Dim tax As ElectronicDocumentLibrary.Coppel.Addenda.Tax = addenda.Data.TaxList.Add()
		tax.Type.Value = "VAT"
		tax.Amount.Value = 591.36
		tax.Percentage.Value = 16
		tax.Category.Value = "TRANSFERIDO"

		addenda.Data.PayableAmount.Amount.Value = 4287.32

		' Cadena original
		addenda.Data.CadenaOriginal.Cadena.Value = electronicDocument.FingerPrint


		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_CoppelRopa.xml", fileName)
	End Function

End Class