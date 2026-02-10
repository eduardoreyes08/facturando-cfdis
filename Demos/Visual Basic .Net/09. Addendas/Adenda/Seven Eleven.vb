Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.SevenEleven.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function SevenEleven(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As SevenEleven = New HyperSoft.ElectronicDocumentLibrary.SevenEleven.Addenda.SevenEleven()

		addenda.Data.Autorizacion.Folio.Value = "123"
		addenda.Data.Moneda.Tipo.Value = "MXN"
		addenda.Data.Moneda.TipoCambio.Value = 1
		addenda.Data.Proveedor.Clave.Value = 1

		Dim recepcion As ElectronicDocumentLibrary.SevenEleven.Addenda.Recepcion = addenda.Data.Recepciones.Add()
		recepcion.Folio.Value = "1"
		recepcion.Tienda.Value = 12
		recepcion.Fecha.Value = DateTime.Now

		Dim producto As ElectronicDocumentLibrary.SevenEleven.Addenda.Producto = recepcion.Productos.Add()
		producto.Cantidad.Value = 1
		producto.Codigo.Value = "2"
		producto.Descripcion.Value = "Producto 1"
		producto.Precio.Value = 3
		producto.Ieps.Value = 4
		producto.Iva.Value = 5
		producto.PiezasPorUnidad.Value = 6
		producto.RetencionIsr.Value = 7
		producto.RetencionIva.Value = 8

		producto = recepcion.Productos.Add()
		producto.Cantidad.Value = 11
		producto.Codigo.Value = "12"
		producto.Descripcion.Value = "Producto 2"
		producto.Precio.Value = 13
		producto.Ieps.Value = 14
		producto.Iva.Value = 15
		producto.PiezasPorUnidad.Value = 16
		producto.RetencionIsr.Value = 17
		producto.RetencionIva.Value = 18

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_SevenEleven.xml", fileName)
	End Function

End Class