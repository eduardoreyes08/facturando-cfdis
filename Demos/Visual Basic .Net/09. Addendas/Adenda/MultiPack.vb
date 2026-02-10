Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.MultiPack.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function MultiPack(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As MultiPack = HyperSoft.ElectronicDocumentLibrary.MultiPack.Addenda.MultiPack.NewEntity()

		addenda.Data.CorreoContacto.Value = "correocontacto@suempresa.com"
		addenda.Data.NumeroProveedor.Value = "123456"
		addenda.Data.CorreoProveedor.Value = "correocontacto@suempresa.com"
		addenda.Data.Tipo.Value = 1
		addenda.Data.NumeroRelacion.Value = "NumeroRelacion"
		addenda.Data.NumeroOrden.Value = "NumeroOrden"
		addenda.Data.Moneda.Value = "MXN"
		addenda.Data.Division.Value = "1234"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_MultiPack.xml", fileName)
	End Function

End Class