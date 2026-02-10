Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.CorporateTravelServices.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function CorporateTravelServices(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As CorporateTravelServices = HyperSoft.ElectronicDocumentLibrary.CorporateTravelServices.Addenda.CorporateTravelServices.NewEntity()

		' Se asignan los datos del complemento
		addenda.Data.Cupon.Value = "123"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_CorporateTravelServices.xml", fileName)
	End Function

End Class