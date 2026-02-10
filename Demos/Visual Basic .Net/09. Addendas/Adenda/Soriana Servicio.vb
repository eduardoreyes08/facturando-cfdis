Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Soriana.Servicio.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function SorianaServicio(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Servicio = HyperSoft.ElectronicDocumentLibrary.Soriana.Servicio.Addenda.Servicio.NewEntity()

		addenda.Data.Tipo.Value = "Publicidad"
		addenda.Data.Version.Value = "1.0"
		addenda.Data.Proveedor.Value = 1
		addenda.Data.UnidadNegocio.Value = 2

		Dim concepto As Concepto = addenda.Data.Conceptos.Add()
		concepto.Descripcion.Value = "ABC"
		concepto.Unidades.Value = 1
		concepto.ValorUnitario.Value = 2
		concepto.Importe.Value = 3

		concepto = addenda.Data.Conceptos.Add()
		concepto.Descripcion.Value = "DEF"
		concepto.Unidades.Value = 4
		concepto.ValorUnitario.Value = 5
		concepto.Importe.Value = 6

		addenda.Data.Impuestos.TotalRetenido.Value = 7
		addenda.Data.Impuestos.TotalTrasladado.Value = 8

		Dim retencion As Retencion = addenda.Data.Impuestos.Retenciones.Add()
		retencion.Impuesto.Value = "IVA"
		retencion.Importe.Value = 3

		Dim traslado As Traslado = addenda.Data.Impuestos.Traslados.Add()
		traslado.Impuesto.Value = "IVA"
		traslado.Tasa.Value = 15
		traslado.Importe.Value = 4

		addenda.Data.FolioReferencia.Value = 3
		addenda.Data.SubTotal.Value = 4
		addenda.Data.Total.Value = 5

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Soriana_Servicio.xml", fileName)
	End Function

End Class