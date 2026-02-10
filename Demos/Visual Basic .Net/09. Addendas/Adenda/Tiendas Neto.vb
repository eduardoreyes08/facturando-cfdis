Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.TiendasNeto.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function TiendasNeto(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As TiendasNeto = HyperSoft.ElectronicDocumentLibrary.TiendasNeto.Addenda.TiendasNeto.NewEntity()

		addenda.Data.TipoComprobante.Value = "Aviso"
		addenda.Data.PlazoPago.Value = "Divisa"
		addenda.Data.Observaciones.Value = "OrdenCompra"

		Dim producto As ElectronicDocumentLibrary.TiendasNeto.Addenda.Producto = addenda.Data.Detalle.Productos.Add()
		producto.CajasEntregadas.Value = 1
		producto.CodigoBarras.Value = 1

		producto.Impuestos.TotalTrasladados.Value = 1
		Dim traslado As ElectronicDocumentLibrary.TiendasNeto.Addenda.Traslado = producto.Impuestos.Traslados.Add()
		traslado.Importe.Value = 1
		traslado.Tasa.Value = 1
		traslado.Tipo.Value = "Tipo"

		producto.PiezasEntregadas.Value = 1
		producto.PrecioUnitarioCaja.Value = 1
		producto.PrecioUnitarioPieza.Value = 1

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_TiendasNeto.xml", fileName)
	End Function

End Class