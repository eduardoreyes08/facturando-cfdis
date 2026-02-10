Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Iusacell.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function Iusacell(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Iusacell = HyperSoft.ElectronicDocumentLibrary.Iusacell.Addenda.Iusacell.NewEntity()

		addenda.Data.TipoDocumento.Value = "Factura"

		addenda.Data.Emisor.NumeroRegistro.Value = "1"
		addenda.Data.Receptor.NumeroRegistro.Value = "2"

		addenda.Data.Encabezado.NumeroProveedor.Value = "3"
		addenda.Data.Encabezado.Fecha.Value = DateTime.Now
		addenda.Data.Encabezado.OrdenCompra.Value = "4"
		addenda.Data.Encabezado.SubTotal.Value = 10
		addenda.Data.Encabezado.Iva.Value = 11
		addenda.Data.Encabezado.IvaPorcentaje.Value = 12
		addenda.Data.Encabezado.Total.Value = 13
		addenda.Data.Encabezado.Moneda.Value = "MXN"
		addenda.Data.Encabezado.FechaEntrega.Value = DateTime.Now
		addenda.Data.Encabezado.LugarEntrega.Value = "LugarEntrega"
		addenda.Data.Encabezado.CondicionPago.Value = "CondicionPago"

		Dim cuerpo As ElectronicDocumentLibrary.Iusacell.Addenda.Cuerpo = addenda.Data.Encabezado.Detalles.Add()
		cuerpo.Renglon.Value = 1
		cuerpo.Cantidad.Value = 2
		cuerpo.UnidadMedida.Value = "UnidadMedida"
		cuerpo.Concepto.Value = "Concepto 1"
		cuerpo.PrecioUnitario.Value = 3
		cuerpo.Importe.Value = 7
		cuerpo.Material.Value = "Material"

		cuerpo = addenda.Data.Encabezado.Detalles.Add()
		cuerpo.Renglon.Value = 2
		cuerpo.Cantidad.Value = 2
		cuerpo.UnidadMedida.Value = "ABC"
		cuerpo.Concepto.Value = "Concepto 1"
		cuerpo.PrecioUnitario.Value = 3
		cuerpo.Importe.Value = 7
		cuerpo.Material.Value = "Material"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Iusacell.xml", fileName)
	End Function

End Class