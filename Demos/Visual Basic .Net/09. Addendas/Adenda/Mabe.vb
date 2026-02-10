Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Mabe.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Mabe(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Mabe = HyperSoft.ElectronicDocumentLibrary.Mabe.Addenda.Mabe.NewEntity()

		addenda.Data.Version.Value = 1

		' Posibles valores: FACTURA | NOTA CREDITO | NOTA CARGO
		addenda.Data.TipoDocumento.Value = "FACTURA"

		addenda.Data.Folio.Value = "Folio"
		addenda.Data.Fecha.Value = DateTime.Now
		addenda.Data.OrdenCompra.Value = "OrdenCompra"
		addenda.Data.Referencia1.Value = "Referencia1"
		addenda.Data.Referencia2.Value = "Referencia2"

		addenda.Data.Moneda.ImporteConLetra.Value = "ImporteConLetra"
		addenda.Data.Moneda.TipoCambio.Value = 1

		' Posibles valores: MXN | USD | XEU 
		addenda.Data.Moneda.TipoMoneda.Value = "MXN"

		addenda.Data.Proveedor.Codigo.Value = "Codigo"

		addenda.Data.Entrega.Calle.Value = "Calle"
		addenda.Data.Entrega.CodigoPostal.Value = "12345"
		addenda.Data.Entrega.NumeroExterior.Value = "12345"
		addenda.Data.Entrega.NumeroInterior.Value = "12345"
		addenda.Data.Entrega.PlantaEntrega.Value = "1"

		Dim detalle As Detalle = addenda.Data.Detalles.Add()
		detalle.Cantidad.Value = 1
		detalle.CodigoArticulo.Value = "CodigoArticulo"
		detalle.Descripcion.Value = "Descripcion"
		detalle.ImporteConIva.Value = 1
		detalle.ImporteSinIva.Value = 1
		detalle.NumeroLineaArticulo.Value = 1
		detalle.PrecioConIva.Value = 1
		detalle.PrecioSinIva.Value = 1
		detalle.Unidad.Value = "UND"

		' Posibles valores: CARGO | DESCUENTO
		addenda.Data.Descuentos.Tipo.Value = "DESCUENTO"

		addenda.Data.Descuentos.Importe.Value = 1
		addenda.Data.Descuentos.Descripcion.Value = "Descripcion"

		addenda.Data.SubTotal.Importe.Value = 1

		Dim traslado As Traslado = addenda.Data.Traslados.Add()
		traslado.Importe.Value = 1
		traslado.Tasa.Value = 1
		traslado.Tipo.Value = "Tipo"

		Dim retencion As Retencion = addenda.Data.Retenciones.Add()
		retencion.Importe.Value = 1
		retencion.Tasa.Value = 1
		retencion.Tipo.Value = "Tipo"

		addenda.Data.Total.Importe.Value = 1


		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Mabe.xml", fileName)
	End Function

End Class