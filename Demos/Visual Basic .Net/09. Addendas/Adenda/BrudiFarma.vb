Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.BrudiFarma.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function BrudiFarma(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As BrudiFarma = HyperSoft.ElectronicDocumentLibrary.BrudiFarma.Addenda.BrudiFarma.NewEntity()

		addenda.Data.Proveedor.Value = "Proveedor"
		addenda.Data.Factura.Value = "Factura"
		addenda.Data.Remision.Value = "Remision"
		addenda.Data.FechaFactura.Value = DateTime.Now
		addenda.Data.Moneda.Value = "MXN"
		addenda.Data.Sociedad.Value = "sociedad"
		addenda.Data.Importe.Value = 3
		addenda.Data.TipoDocumento.Value = "FC"

		Dim partida As ElectronicDocumentLibrary.BrudiFarma.Addenda.Partida = addenda.Data.Partidas.Add()
		partida.Proveedor.Value = "Proveedor"
		partida.Factura.Value = "Factura"
		partida.Remision.Value = "Remision"
		partida.PartidaFactura.Value = 1
		partida.Pedido.Value = "Pedido"
		partida.Material.Value = "Material"
		partida.ImportePartida.Value = 1
		partida.Cantidad.Value = 2
		partida.UnidadMedida.Value = "UnidadMedida"

		partida = addenda.Data.Partidas.Add()
		partida.Proveedor.Value = "Proveedor"
		partida.Factura.Value = "Factura"
		partida.Remision.Value = "Remision"
		partida.PartidaFactura.Value = 2
		partida.Pedido.Value = "Pedido"
		partida.Material.Value = "Material"
		partida.ImportePartida.Value = 1
		partida.Cantidad.Value = 2
		partida.UnidadMedida.Value = "UnidadMedida"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_BrudiFarma.xml", fileName)
	End Function

End Class