Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Asofarma.Asonioscoc.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Asofarma(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As New Asonioscoc()

		addenda.Data.TipoProveedor.Value = 2
		addenda.Data.NoProveedor.Value = "test"
		addenda.Data.Serie.Value = "TFA"
		addenda.Data.Folio.Value = "1022975"
		addenda.Data.OrdenCompra.Value = "124"

		Dim partida As Partida = addenda.Data.Partidas.Add()
		partida.NoPartida.Value = 1
		partida.IvaAcreditable.Value = 8
		partida.IvaDevengado.Value = 16
		partida.Otros.Value = "otrox"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Asofarma_Asonioscoc.xml", fileName)
	End Function

End Class