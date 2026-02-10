Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Emerson.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Emerson(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Emerson = New HyperSoft.ElectronicDocumentLibrary.Emerson.Addenda.Emerson()

		addenda.Data.Version.Value = "1.6"
		addenda.Data.NumeroProveedor.Value = "150041642"
		addenda.Data.Moneda.Value = "MXN"
		addenda.Data.NumeroOrdenCompra.Value = "4110074260"
		addenda.Data.NumeroRecepcion.Value = "28344"
		addenda.Data.UsoFuturo.Value = "65536"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Emerson.xml", fileName)
	End Function

End Class