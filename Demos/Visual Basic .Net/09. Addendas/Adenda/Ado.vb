Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Ado.Addenda

Friend NotInheritable Partial Class Adenda
	Friend Shared Function Ado(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Ado = HyperSoft.ElectronicDocumentLibrary.Ado.Addenda.Ado.NewEntity()

		addenda.Data.Proveedor.TipoAddenda.Value = "Tipo"
		addenda.Data.Addenda.Valor.Value = "Addenda"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Ado.xml", fileName)
	End Function
End Class