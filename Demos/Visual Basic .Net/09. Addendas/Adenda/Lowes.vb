Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Lowes.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Lowes(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Lowes = New HyperSoft.ElectronicDocumentLibrary.Lowes.Addenda.Lowes()

		addenda.Data.Proveedor.Id.Value = 123445

		addenda.Data.Orden.Id.Value = 3465734657UI
		addenda.Data.Orden.Articulos.Value = 300

		addenda.Data.Comprobante.Moneda.Value = "MXN"
		addenda.Data.Comprobante.SubTotal.Value = 24578.76
		addenda.Data.Comprobante.Serie.Value = "A"
		addenda.Data.Comprobante.Folio.Value = "1"

		Dim articulo As Articulo = addenda.Data.Articulos.Add()
		articulo.Id.Value = "100047367"
		articulo.Upc.Value = "400000029825"
		articulo.Cantidad.Value = 200
		articulo.UnidadMedida.Value = "EA"
		articulo.ValorUnitario.Value = 300.5
		articulo.Importe.Value = 15289.76
		articulo.Iva.Value = 16.0
		articulo.Ieps.Value = 0

		articulo = addenda.Data.Articulos.Add()
		articulo.Id.Value = "100047368"
		articulo.Upc.Value = "500000039840"
		articulo.Cantidad.Value = 100
		articulo.UnidadMedida.Value = "EA"
		articulo.ValorUnitario.Value = 100.88
		articulo.Importe.Value = 9289.0
		articulo.Iva.Value = 16.0
		articulo.Ieps.Value = 0

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Lowes.xml", fileName)
	End Function

End Class