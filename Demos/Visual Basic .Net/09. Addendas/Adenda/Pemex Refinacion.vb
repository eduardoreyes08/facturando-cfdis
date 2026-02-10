Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Pemex.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function PemexRefinacion(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As New PemexRefinacion()

		addenda.Data.Campo1.Value = "Campo1"
		addenda.Data.Campo2.Value = "Campo2"
		addenda.Data.Campo3.Value = "Campo3"
		addenda.Data.Campo4.Value = "1"
		addenda.Data.Campo5.Value = "2"
		addenda.Data.Campo6.Value = "Campo6"
		addenda.Data.Campo7.Value = "Campo7"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_PemexRefinacion.xml", fileName)
	End Function

End Class