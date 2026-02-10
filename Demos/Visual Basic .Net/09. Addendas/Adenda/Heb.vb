Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Heb.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Heb(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Heb = HyperSoft.ElectronicDocumentLibrary.Heb.Addenda.Heb.NewEntity()

		addenda.Data.TipoDocumento.Value = "Factura"

		addenda.Data.Emisor.NumeroRegistro.Value = "1"
		addenda.Data.Emisor.NumeroProveedor.Value = "A"

		addenda.Data.Receptor.NumeroRegistro.Value = "2"

		addenda.Data.Encabezado.Folio.Value = "3"
		addenda.Data.Encabezado.Serie.Value = "A"
		addenda.Data.Encabezado.FolioAvisoPreFactura.Value = "AB"
		addenda.Data.Encabezado.FolioNotaRecepcion.Value = "CD"
		addenda.Data.Encabezado.DomicilioSucursalCliente.Value = "Direcccion"
		addenda.Data.Encabezado.MunicipioSucursalCliente.Value = "Municipio"
		addenda.Data.Encabezado.FormaDePago.Value = "ABC"
		addenda.Data.Encabezado.SubTotal.Value = 1
		addenda.Data.Encabezado.Iva.Value = 2
		addenda.Data.Encabezado.Total.Value = 3
		addenda.Data.Encabezado.IvaPorcentaje.Value = 4
		addenda.Data.Encabezado.NumeroProveedor.Value = "12345"
		addenda.Data.Encabezado.Moneda.Value = "MXN"
		addenda.Data.Encabezado.NumeroSucursal.Value = "123"
		addenda.Data.Encabezado.DepartamentoCliente.Value = "456"

		Dim detalle As ElectronicDocumentLibrary.Heb.Addenda.Cuerpo = addenda.Data.Encabezado.Detalles.Add()
		detalle.FactorEmpaque.Value = 2
		detalle.UnidadMedida.Value = "Caja"
		detalle.CostoUnitarioLista.Value = 3
		detalle.Ean13.Value = "Ean13"
		detalle.Codigo.Value = "Codigo"
		detalle.Cantidad.Value = 4
		detalle.Concepto.Value = "Concepto 1"
		detalle.PrecioUnitario.Value = 5
		detalle.SubTotal.Value = 6

		detalle = addenda.Data.Encabezado.Detalles.Add()
		detalle.FactorEmpaque.Value = 2
		detalle.UnidadMedida.Value = "Caja"
		detalle.CostoUnitarioLista.Value = 3
		detalle.Ean13.Value = "Ean13"
		detalle.Codigo.Value = "Codigo"
		detalle.Cantidad.Value = 4
		detalle.Concepto.Value = "Concepto 2"
		detalle.PrecioUnitario.Value = 5
		detalle.SubTotal.Value = 6

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Heb.xml", fileName)
	End Function

End Class