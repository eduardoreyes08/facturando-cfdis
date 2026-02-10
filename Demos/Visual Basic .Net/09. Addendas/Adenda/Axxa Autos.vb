Imports System.Globalization
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Axxa.Addenda.Autos

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function AxxaAutos(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Autos = Autos.NewEntity()

		addenda.Data.TipoDocumento.Value = "Factura"
		addenda.Data.Emisor.NumeroRegistro.Value = "A"
		addenda.Data.Receptor.NumeroRegistro.Value = "A"

		addenda.Data.Encabezado.FormaPago.Value = "Pago en una sola exhibición"
		addenda.Data.Encabezado.SubTotal.Value = 1
		addenda.Data.Encabezado.TasaIva.Value = 2
		addenda.Data.Encabezado.Iva.Value = 3
		addenda.Data.Encabezado.TasaIsr.Value = 4
		addenda.Data.Encabezado.Isr.Value = 5
		addenda.Data.Encabezado.TasaIvaRetenido.Value = 6
		addenda.Data.Encabezado.IvaRetenido.Value = 7
		addenda.Data.Encabezado.Total.Value = 8
		addenda.Data.Encabezado.Moneda.Value = "MXN"
		addenda.Data.Encabezado.CondicionPago.Value = "CondicionPago"
		addenda.Data.Encabezado.FolioReferencia.Value = "FolioReferencia"
		addenda.Data.Encabezado.Observaciones.Value = "Observaciones"
		addenda.Data.Encabezado.Descuento.Value = 9
		addenda.Data.Encabezado.Deducible.Value = 10
		addenda.Data.Encabezado.ProcesoId.Value = 11
		addenda.Data.Encabezado.FolioPrefactura.Value = "FolioPrefactura"
		addenda.Data.Encabezado.FechaPrefactura.Value = DateTime.Now.ToString(CultureInfo.InvariantCulture)
		addenda.Data.Encabezado.ImporteNeto.Value = 12
		addenda.Data.Encabezado.ImporteBruto.Value = 13
		addenda.Data.Encabezado.ImporteConLetra.Value = "Un peso"
		addenda.Data.Encabezado.TipoFacturacion.Value = "AUTOS"
		addenda.Data.Encabezado.Siniestro.Value = "Siniestro"
		addenda.Data.Encabezado.Riesgo.Value = "Riesgo"
		addenda.Data.Encabezado.ModeloAutomovil.Value = "ModeloAutomovil"
		addenda.Data.Encabezado.PlacasAutomovil.Value = "PlacasAutomovil"
		addenda.Data.Encabezado.Marca.Value = "Marca"
		addenda.Data.Encabezado.Tipo.Value = "Tipo"
		addenda.Data.Encabezado.AnioAutomovil.Value = 2010
		addenda.Data.Encabezado.NumeroPoliza.Value = "NumeroPoliza"
		addenda.Data.Encabezado.NumeroAutorizacion.Value = "NumeroAutorizacion"
		addenda.Data.Encabezado.TipoComprobante.Value = 1

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

		Return Save("Addenda_AxxaAutos.xml", fileName)
	End Function

End Class