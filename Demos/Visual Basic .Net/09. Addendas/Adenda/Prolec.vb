Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Prolec.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Prolec(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Prolec = HyperSoft.ElectronicDocumentLibrary.Prolec.Addenda.Prolec.NewEntity()

		addenda.Data.Aviso.Value = "Aviso"
		addenda.Data.Divisa.Value = "Divisa"
		addenda.Data.OrdenCompra.Value = "OrdenCompra"
		addenda.Data.Proveedor.Value = "Proveedor"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Prolec.xml", fileName)
	End Function

End Class