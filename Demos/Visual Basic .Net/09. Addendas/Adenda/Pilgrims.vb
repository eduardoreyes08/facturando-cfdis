Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Pilgrims.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Pilgrims(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Pilgrims = HyperSoft.ElectronicDocumentLibrary.Pilgrims.Addenda.Pilgrims.NewEntity()

		addenda.Data.Comprador.Value = "1"
		addenda.Data.Proceso.Value = "2"
		addenda.Data.Proveedor.Value = 3

		Dim partida As ElectronicDocumentLibrary.Pilgrims.Addenda.Partida = addenda.Data.Partidas.Add()
		partida.Pedido.Value = "1"
		partida.Posicion.Value = "2"
		partida.Material.Value = "Material"
		partida.Cantidad.Value = 3
		partida.UnidadMedida.Value = "AZM"
		partida.Precio.Value = 4
		partida.Entrada.Value = 5
		partida.Referencia.Value = "Referencia"
		partida.Pedimento.Value = "000000"
		partida.FacturaPedimento.Value = "123"

		partida.Boletas.Add().Text.Value = "1"
		partida.Boletas.Add().Text.Value = "2"

		partida = addenda.Data.Partidas.Add()
		partida.Pedido.Value = "11"
		partida.Posicion.Value = "12"
		partida.Material.Value = "Material 2"
		partida.Cantidad.Value = 13
		partida.UnidadMedida.Value = "OMU"
		partida.Precio.Value = 14
		partida.Entrada.Value = 15
		partida.Referencia.Value = "Referencia 2"
		partida.Pedimento.Value = "000002"
		partida.FacturaPedimento.Value = "321"

		partida.Boletas.Add().Text.Value = "3"
		partida.Boletas.Add().Text.Value = "4"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Pilgrims.xml", fileName)
	End Function

End Class