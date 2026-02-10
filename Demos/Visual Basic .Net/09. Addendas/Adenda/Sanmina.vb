Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Sanmina.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Sanmina(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Sanmina = HyperSoft.ElectronicDocumentLibrary.Sanmina.Addenda.Sanmina.NewEntity()

		addenda.Data.PoNumber.Value = "PoNumber"
		addenda.Data.ElectronicMail.Value = "ElectronicMail"
		addenda.Data.LegalEntityName.Value = "LegalEntityName"
		addenda.Data.CustomerCode.Value = "CustomerCode"
		addenda.Data.Currency.Value = "Currency"
		addenda.Data.ExchangeRate.Value = 1
		addenda.Data.InternalInvoiceNumber.Value = "InternalInvoiceNumber"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_SANMINA.xml", fileName)
	End Function

End Class