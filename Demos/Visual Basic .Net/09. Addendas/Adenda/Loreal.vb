Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Loreal.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function Loreal(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Loreal = HyperSoft.ElectronicDocumentLibrary.Loreal.Addenda.Loreal.NewEntity()

		addenda.Data.TipoDocumento.Value = "Factura"

		addenda.Data.Emisor.NumeroRegistro.Value = "1"

		addenda.Data.Receptor.NumeroRegistro.Value = "1"

		addenda.Data.Encabezado.Folio.Value = "1"
		addenda.Data.Encabezado.Serie.Value = "A"
		addenda.Data.Encabezado.Moneda.Value = "MXN"
		addenda.Data.Encabezado.FolioOrdenCompra.Value = "123"
		addenda.Data.Encabezado.FolioNotaRecepcion.Value = "456"
		addenda.Data.Encabezado.Fecha.Value = DateTime.Now
		addenda.Data.Encabezado.CondicionPago.Value = "XXX"
		addenda.Data.Encabezado.IvaPorcentaje.Value = 3
		addenda.Data.Encabezado.NumeroProveedor.Value = "123"
		addenda.Data.Encabezado.CargoTipo.Value = "456"
		addenda.Data.Encabezado.SubTotal.Value = 4
		addenda.Data.Encabezado.Iva.Value = 5
		addenda.Data.Encabezado.Total.Value = 6
		addenda.Data.Encabezado.Observaciones.Value = "Observaciones"

		Dim detalle As ElectronicDocumentLibrary.Loreal.Addenda.Cuerpo = addenda.Data.Encabezado.Detalles.Add()
		detalle.Partida.Value = 1
		detalle.Cantidad.Value = 2
		detalle.Concepto.Value = "Concepto 1"
		detalle.PrecioUnitario.Value = 3
		detalle.Importe.Value = 4
		detalle.UnidadMedida.Value = "Caja"
		detalle.Iva.Value = 5
		detalle.IvaPorcentaje.Value = 6

		detalle = addenda.Data.Encabezado.Detalles.Add()
		detalle.Partida.Value = 2
		detalle.Cantidad.Value = 2
		detalle.Concepto.Value = "Concepto 2"
		detalle.PrecioUnitario.Value = 3
		detalle.Importe.Value = 4
		detalle.UnidadMedida.Value = "Caja"
		detalle.Iva.Value = 5
		detalle.IvaPorcentaje.Value = 6

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Loreal.xml", fileName)
	End Function

End Class