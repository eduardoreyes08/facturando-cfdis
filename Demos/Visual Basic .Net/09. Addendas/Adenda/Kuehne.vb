Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Kuehne.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Kuehne(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Kuehne = New HyperSoft.ElectronicDocumentLibrary.Kuehne.Addenda.Kuehne()

		addenda.Data.PurchaseOrder.Value = "aaaaaaaaaaaaaa"
		addenda.Data.FileNumberGl.Value = "00000000000000"
		addenda.Data.BranchCentre.Value = "aaaaaaa"
		addenda.Data.TransportRef.Value = "aaaaaaa"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Kuehne.xml", fileName)
	End Function

End Class