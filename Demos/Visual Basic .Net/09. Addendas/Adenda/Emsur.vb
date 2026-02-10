Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Emsur.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function EmSur(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As EmSur = ElectronicDocumentLibrary.Emsur.Addenda.EmSur.NewEntity()

		addenda.Data.FechaVencimiento.Value = DateTime.Now
		addenda.Data.Total.Value = 1
		addenda.Data.Moneda.Value = "2"
		addenda.Data.TipoCambio.Value = 3
		addenda.Data.Serie.Value = "4"
		addenda.Data.Folio.Value = "5"
		addenda.Data.Rfc.Value = "XXX010101AAA"
		addenda.Data.Usuario.Value = "6"
		addenda.Data.OrdenCompra.Value = "7"
		addenda.Data.DiasCredito.Value = 8

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Emsur.xml", fileName)
	End Function

End Class