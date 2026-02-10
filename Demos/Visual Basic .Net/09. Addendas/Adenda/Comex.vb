Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Comex.Addenda

Friend NotInheritable Partial Class Adenda
	
  Friend Shared Function Comex(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Comex = HyperSoft.ElectronicDocumentLibrary.Comex.Addenda.Comex.NewEntity()

		addenda.Data.OrderIdentification.ReferenceIdentificationList.Add().Value = "NumeroPedido 1"
		addenda.Data.OrderIdentification.ReferenceIdentificationList.Add().Value = "NumeroPedido  2"

		addenda.Data.Buyer.ContactInformation.PersonOrDepartmentName.Text.Value = "a@a.com"

		Dim currency As ElectronicDocumentLibrary.Comex.Addenda.Currency = addenda.Data.Currency.Add()
		currency.CurrencyIsoCode.Value = "MXN"
		currency.RateOfChange.Value = "1"

		addenda.Data.BaseAmount.Amount.Value = 120

		addenda.Data.Tax.Amount.Value = 1230

		addenda.Data.PayableAmount.Amount.Value = 350

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Comex.xml", fileName)
	End Function

End Class