Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Pepsico.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function Pepsico(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Pepsico = HyperSoft.ElectronicDocumentLibrary.Pepsico.Addenda.Pepsico.NewEntity()

		addenda.Data.Tipo.Value = "AddendaPCO"
		addenda.Data.Version.Value = "2.0"
		addenda.Data.IdPedido.Value = "1234567890"
		addenda.Data.IdSolicitudPago.Value = "1234567890"

		addenda.Data.Documento.Referencia.Value = "Referencia"
		addenda.Data.Documento.FolioUuid.Value = "FolioUuid"
		addenda.Data.Documento.TipoDocumento.Value = 1

		addenda.Data.Proveedor.Id.Value = 1234567890

		Dim recepcion As ElectronicDocumentLibrary.Pepsico.Addenda.Recepcion = addenda.Data.Recepciones.Add()
		recepcion.Id.Value = 1234567890

		Dim concepto As ElectronicDocumentLibrary.Pepsico.Addenda.Concepto = recepcion.Conceptos.Add()
		concepto.Cantidad.Value = 1
		concepto.Unidad.Value = "Unidad"
		concepto.Descripcion.Value = "Descripcion"
		concepto.ValorUnitario.Value = 2
		concepto.Importe.Value = 3

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Pepsico.xml", fileName)
	End Function

End Class