Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.ContinentalTire.Addenda
Imports HyperSoft.ElectronicDocumentLibrary.ContinentalTire.OrdenCompra

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function ContinentalTire(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As New ContinentalTire()

		addenda.Data.OrdenCompra.Value = "a"
		addenda.Data.Pedido.Value = 1
		addenda.Data.TipoProveedor.Value = "1"

		Dim posicion As Posicion = addenda.Data.PosicionesOrdenCompra.Add()
		posicion.Descripcion.Value = "1"
		posicion.Numero.Value = 2
		posicion.Embarque.Value = 3
		posicion.TasaRetencionIsr.Value = 4
		posicion.TasaRetencionIva.Value = 5

		posicion = addenda.Data.PosicionesOrdenCompra.Add()
		posicion.Descripcion.Value = "1"
		posicion.Numero.Value = 2
		posicion.Embarque.Value = 3
		posicion.TasaRetencionIsr.Value = 4
		posicion.TasaRetencionIva.Value = 5

		addenda.Data.CodigoCompania.Value = 6
		addenda.Data.ReferenciaOrdenCompra.Value = 7
		addenda.Data.ReferenciaOtros.Value = "8"
		addenda.Data.CentroCostos.Value = "9"
		addenda.Data.Solicitante.Value = "10"
		addenda.Data.Embarque.Value = 11

		Dim valores As ElectronicDocumentLibrary.ContinentalTire.Posicion = addenda.Data.Posiciones.Add()
		valores.Descripcion.Value = "ZS"
		valores.TasaRetencionIsr.Value = 4
		valores.TasaRetencionIva.Value = 5


		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Continental_Tire.xml", fileName)
	End Function

End Class