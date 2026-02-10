Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Oxxo.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Oxxo(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Oxxo = HyperSoft.ElectronicDocumentLibrary.Oxxo.Addenda.Oxxo.NewEntity()

		addenda.Data.Version.Value = "1"
		addenda.Data.ClaseDocumento.Value = "1"
		addenda.Data.Plaza.Value = "00AAA"
		addenda.Data.TipoProveedor.Value = "01"
		addenda.Data.TipoLocalizacion.Value = "T"
		addenda.Data.FolioPago.Value = "1"
		addenda.Data.OrdenCompra.Value = "0123456789"
		addenda.Data.GlnEmisor.Value = "0123456789ABC"
		addenda.Data.GlnReceptor.Value = "ABC0123456789"
		addenda.Data.Moneda.Value = "MXN"
		addenda.Data.TipoCambio.Value = 1.0
		addenda.Data.ReferenciaSerie.Value = "a"
		addenda.Data.ReferenciaFolio.Value = "1"
		addenda.Data.MontoDescuento0.Value = 2
		addenda.Data.TipoDescuento0.Value = "ECE"
		addenda.Data.MontoDescuento1.Value = 3
		addenda.Data.TipoDescuento1.Value = "ECE"
		addenda.Data.MontoDescuento2.Value = 4
		addenda.Data.TipoDescuento2.Value = "ECE"
		addenda.Data.MontoDescuento3.Value = 5
		addenda.Data.TipoDescuento3.Value = "ECE"
		addenda.Data.TotalDescuentos.Value = 6
		addenda.Data.ImporteTotal.Value = 7
		addenda.Data.TipoValidacion.Value = "1"
		addenda.Data.FuenteNota.Value = "1"

		Dim detalle As ElectronicDocumentLibrary.Oxxo.Addenda.Detalle = addenda.Data.Articulos.Add()
		detalle.PedidoAdicional.Value = "ABC"
		detalle.Remision.Value = "123"
		detalle.FechaEntrega.Value = DateTime.Now
		detalle.CrTienda.Value = "00AAA"
		detalle.NombreTienda.Value = "NombreTienda"
		detalle.NumeroProducto.Value = "NumeroProducto"
		detalle.Descripcion.Value = "Descripcion"
		detalle.UnidadMedida.Value = "UnidadMedida"
		detalle.Cantidad.Value = 1
		detalle.NumeroSerieProductos.Value = "NumeroSerieProductos"
		detalle.PorcentajeIva.Value = 2
		detalle.MontoIva.Value = 3
		detalle.PorcentajeIeps1.Value = 4
		detalle.MontoIeps1.Value = 5
		detalle.PorcentajeIeps2.Value = 6
		detalle.MontoIeps2.Value = 7
		detalle.PorcentajeIeps3.Value = 8
		detalle.MontoIeps3.Value = 9
		detalle.ImporteNeto.Value = 10

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Oxxo.xml", fileName)
	End Function

End Class