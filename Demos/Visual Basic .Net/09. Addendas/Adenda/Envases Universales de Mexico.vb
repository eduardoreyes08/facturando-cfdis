Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.EnvasesUniversalesMexico.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function EnvasesUniversalesdeMexico(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As EnvasesUniversalesMexico = HyperSoft.ElectronicDocumentLibrary.EnvasesUniversalesMexico.Addenda.EnvasesUniversalesMexico.NewEntity()

		addenda.Data.TipoFactura.Version.Value = "version"
		addenda.Data.TipoFactura.FechaMensaje.Value = DateTime.Now
		addenda.Data.TipoFactura.IdFactura.Value = "idfactura"

		addenda.Data.Moneda.Clave.Value = "clave"
		addenda.Data.Moneda.Impuesto.Value = 1
		addenda.Data.Moneda.SubTotal.Value = 2
		addenda.Data.Moneda.Total.Value = 3
		addenda.Data.Moneda.TipoCambio.Value = 4

		addenda.Data.ImpuestosRetenidos.BaseImpuesto.Value = 1

		Dim ordenCompra As OrdenCompra = addenda.Data.OrdenesCompra.Add()
		ordenCompra.Consecutivo.Value = 1
		ordenCompra.EntradasAlmacen.Add().Albaran.Value = "albaran 1"
		ordenCompra.EntradasAlmacen.Add().Albaran.Value = "albaran 2"
		ordenCompra.IdPedido.Value = "idpedido"

		addenda.Data.TipoTransaccion.IdTransaccion.Value = "idtransaccion"
		addenda.Data.TipoTransaccion.Transaccion.Value = "transaccion"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_EnvasesUniversalesMexico.xml", fileName)
	End Function

End Class