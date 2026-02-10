Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Axxa.Addenda.GastosMedicos

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function AxxaGastosMedicos(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As GastosMedicos = GastosMedicos.NewEntity()

		addenda.Data.TipoDocumento.Value = "Factura"
		addenda.Data.Emisor.NumeroRegistro.Value = "A"
		addenda.Data.Receptor.NumeroRegistro.Value = "A"

		addenda.Data.Encabezado.FormaPago.Value = "Pago en una sola exhibición"
		addenda.Data.Encabezado.SubTotal.Value = 1
		addenda.Data.Encabezado.Descuento.Value = 9
		addenda.Data.Encabezado.TasaIva.Value = 2
		addenda.Data.Encabezado.Iva.Value = 3
		addenda.Data.Encabezado.TasaIsr.Value = 4
		addenda.Data.Encabezado.Isr.Value = 5
		addenda.Data.Encabezado.TasaIvaRetenido.Value = 6
		addenda.Data.Encabezado.IvaRetenido.Value = 7
		addenda.Data.Encabezado.Total.Value = 8
		addenda.Data.Encabezado.EstadoProveedor.Value = "EstadoProveedor"
		addenda.Data.Encabezado.Moneda.Value = "MXN"
		addenda.Data.Encabezado.TipoCambio.Value = 1
		addenda.Data.Encabezado.CondicionPago.Value = "CondicionPago"
		addenda.Data.Encabezado.TipoDocumento.Value = "Factura"
		addenda.Data.Encabezado.TipoComprobante.Value = 1
		addenda.Data.Encabezado.FolioReferencia.Value = "FolioReferencia"
		addenda.Data.Encabezado.Observaciones.Value = "Observaciones"
		addenda.Data.Encabezado.ProcesoId.Value = 11
		addenda.Data.Encabezado.NumeroAtencion.Value = "NumeroAtencion"
		addenda.Data.Encabezado.NumeroFolio.Value = "NumeroFolio"
		addenda.Data.Encabezado.NumeroDictamen.Value = 15

		addenda.Data.Encabezado.NombreSolicitante.Value = "NombreSolicitante"
		addenda.Data.Encabezado.PaternoSolicitante.Value = "PaternoSolicitante"
		addenda.Data.Encabezado.MaternoSolicitante.Value = "MaternoSolicitante"
		addenda.Data.Encabezado.DiasHospitalizacion.Value = 1
		addenda.Data.Encabezado.ClaveTipoAtencion.Value = 1
		addenda.Data.Encabezado.NombreTipoAtencion.Value = "NombreTipoAtencion"

		Dim impuesto As Impuesto = addenda.Data.Encabezado.Impuestos.Add()
		impuesto.CodigoMultiple.Value = "CodigoMultiple"
		impuesto.ImpuestoLocalTrasladado.Value = "Impuesto Cedular"
		impuesto.TasaTraslado.Value = 14
		impuesto.Importe.Value = 15

		impuesto = addenda.Data.Encabezado.Impuestos.Add()
		impuesto.CodigoMultiple.Value = "CodigoMultiple"
		impuesto.ImpuestoLocalTrasladado.Value = "Impuesto Cedular"
		impuesto.TasaTraslado.Value = 16
		impuesto.Importe.Value = 17

		Dim cuerpo As Cuerpo = addenda.Data.Encabezado.Detalles.Add()
		cuerpo.Renglon.Value = 1
		cuerpo.Cantidad.Value = 2
		cuerpo.Codigo.Value = "Codigo"
		cuerpo.Concepto.Value = "Concepto 1"
		cuerpo.PrecioUnitario.Value = 3
		cuerpo.Importe.Value = 4

		cuerpo = addenda.Data.Encabezado.Detalles.Add()
		cuerpo.Renglon.Value = 2
		cuerpo.Cantidad.Value = 2
		cuerpo.Concepto.Value = "Concepto 2"
		cuerpo.PrecioUnitario.Value = 3
		cuerpo.Importe.Value = 4

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_AxxaGastosMedicos.xml", fileName)
	End Function

End Class