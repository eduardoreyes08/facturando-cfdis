Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Fuller.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Fuller(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Fuller = HyperSoft.ElectronicDocumentLibrary.Fuller.Addenda.Fuller.NewEntity()

		addenda.Data.Version.Tipo.Value = "B2B"
		addenda.Data.Version.Numero.Value = "2.0"

		addenda.Data.Fiscal.TipoDocumento.Value = "FACTURA"
		addenda.Data.Fiscal.Serie.Value = "A"
		addenda.Data.Fiscal.Folio.Value = "1"
		addenda.Data.Fiscal.Sustituye.Value = "1"
		addenda.Data.Fiscal.Moneda.Value = "PESOS"
		addenda.Data.Fiscal.TipoCambio.Value = 1
		'fuller.Data.Fiscal.TipoCambio.Decimals = 4;

		addenda.Data.Negocio.Division.Value = "01"
		addenda.Data.Negocio.InstruccionesEspeciales.Value = "CP"
		addenda.Data.Negocio.TipoProveedor.Value = "DI"
		addenda.Data.Negocio.TipoGasto.Value = "DI"
		addenda.Data.Negocio.NumeroPresupuesto.Value = "123"

		addenda.Data.Comercial.OrdenCompra.Value = "ABC"
		addenda.Data.Comercial.FechaOrdenCompra.Value = DateTime.Now
		addenda.Data.Comercial.CodigoComprador.Value = "123A"

		addenda.Data.Proveedor.Nombre.Value = "XXX"
		addenda.Data.Proveedor.CorreoContacto.Value = "a@a.com"
		addenda.Data.Proveedor.Rfc.Value = "XXX010101XXX"
		addenda.Data.Proveedor.Telefono.Value = "123"
		addenda.Data.Proveedor.GlnComprador.Value = "GlnComprador"
		addenda.Data.Proveedor.GlnProveedor.Value = "GlnProveedor"
		addenda.Data.Proveedor.CodigoProveedor.Value = "A"

		addenda.Data.AlmacenEntrega.Codigo.Value = "A"
		addenda.Data.AlmacenEntrega.Gln.Value = "B"
		addenda.Data.AlmacenEntrega.Nombre.Value = "C"
		addenda.Data.AlmacenEntrega.Direccion.Value = "D"
		addenda.Data.AlmacenEntrega.Ciudad.Value = "E"

		Dim detalle As ElectronicDocumentLibrary.Fuller.Addenda.Detalle = addenda.Data.Detalles.Add()
		detalle.NumeroLinea.Value = 1
		detalle.CodigoArticuloCliente.Value = "A"
		detalle.CodigoArticuloProveedor.Value = "B"
		detalle.CantidadFacturada.Value = 4
		detalle.PrecioUnitario.Value = 5
		detalle.TotalConImpuesto.Value = 6
		detalle.TotalSinImpuesto.Value = 7
		detalle.NumeroRecepcion.Value = "C"
		detalle.FechaRecepcion.Value = DateTime.Now

		detalle = addenda.Data.Detalles.Add()
		detalle.NumeroLinea.Value = 2
		detalle.CodigoArticuloCliente.Value = "A"
		detalle.CodigoArticuloProveedor.Value = "B"
		detalle.CantidadFacturada.Value = 4
		detalle.PrecioUnitario.Value = 5
		detalle.TotalConImpuesto.Value = 6
		detalle.TotalSinImpuesto.Value = 7
		detalle.NumeroRecepcion.Value = "C"
		detalle.FechaRecepcion.Value = DateTime.Now

		addenda.Data.Total.SubTotal.Value = 1
		addenda.Data.Total.Iva16.Value = 2
		addenda.Data.Total.Iva11.Value = 3
		addenda.Data.Total.RetencionIva.Value = 4
		addenda.Data.Total.RetencionIsr.Value = 5
		addenda.Data.Total.GranTotal.Value = 6

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Fuller.xml", fileName)
	End Function

End Class