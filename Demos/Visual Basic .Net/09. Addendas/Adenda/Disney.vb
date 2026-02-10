Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Disney.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function Disney(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Disney = HyperSoft.ElectronicDocumentLibrary.Disney.Addenda.Disney.NewEntity()

		addenda.Data.Proveedor.Contacto.Value = "contacto"
		addenda.Data.Proveedor.Telefono.Value = "telefono"
		addenda.Data.Proveedor.CorreoElectronico.Value = "correoelectronico"
		addenda.Data.Proveedor.Numero.Value = "numero"

		addenda.Data.Transaccion.CorreoElectronicoCompradorCasual.Value = "correoelectronicocompradorcasual"
		addenda.Data.Transaccion.NumeroRecibo.Value = "numerorecibo"
		addenda.Data.Transaccion.OrdenCompra.Value = "ordencompra"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Disney.xml", fileName)
	End Function

End Class