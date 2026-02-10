Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.TvAzteca.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function TvAzteca(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As TvAzteca = HyperSoft.ElectronicDocumentLibrary.TvAzteca.Addenda.TvAzteca.NewEntity()

		addenda.Data.TipoDocumento.Value = "Factura"

		addenda.Data.Emisor.NumeroRegistro.Value = "1"
		addenda.Data.Emisor.NumeroProveedor.Value = "123"
		addenda.Data.Receptor.NumeroRegistro.Value = "2"

		addenda.Data.Encabezado.NumeroProveedor.Value = "123"
		addenda.Data.Encabezado.Fecha.Value = DateTime.Now
		addenda.Data.Encabezado.OrdenCompra.Value = "4"
		addenda.Data.Encabezado.SubTotal.Value = 10
		addenda.Data.Encabezado.Iva.Value = 11
		addenda.Data.Encabezado.IvaPorcentaje.Value = 12
		addenda.Data.Encabezado.Total.Value = 13
		addenda.Data.Encabezado.Moneda.Value = "MXN"
		addenda.Data.Encabezado.MonedaDescripcion.Value = "Pesos Mexicanos"
		addenda.Data.Encabezado.Sociedad.Value = "Sociedad"
		addenda.Data.Encabezado.Folio.Value = "Folio"
		addenda.Data.Encabezado.Serie.Value = "Serie"
		addenda.Data.Encabezado.FolioNotaRecepcion.Value = "4"

		Dim cuerpo As ElectronicDocumentLibrary.TvAzteca.Addenda.Cuerpo = addenda.Data.Encabezado.Detalles.Add()
		cuerpo.Renglon.Value = 1
		cuerpo.Cantidad.Value = 2
		cuerpo.UnidadMedida.Value = "ABC"
		cuerpo.Concepto.Value = "Concepto 1"
		cuerpo.PrecioUnitario.Value = 3
		cuerpo.Importe.Value = 7
		cuerpo.FolioNotaRecepcion.Value = "1"
		cuerpo.RenglonNotaRecepcion.Value = 1

		cuerpo = addenda.Data.Encabezado.Detalles.Add()
		cuerpo.Renglon.Value = 2
		cuerpo.Cantidad.Value = 2
		cuerpo.UnidadMedida.Value = "ABC"
		cuerpo.Concepto.Value = "Concepto 1"
		cuerpo.PrecioUnitario.Value = 3
		cuerpo.Importe.Value = 7
		cuerpo.FolioNotaRecepcion.Value = "2"
		cuerpo.RenglonNotaRecepcion.Value = 2

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_TvAzteca.xml", fileName)
	End Function

End Class