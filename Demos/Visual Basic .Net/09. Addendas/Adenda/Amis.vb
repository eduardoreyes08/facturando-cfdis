Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Amis.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Amis(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Amis = HyperSoft.ElectronicDocumentLibrary.Amis.Addenda.Amis.NewEntity()

		addenda.Data.Version.Value = "1.0"

		#Region "Documento"
		addenda.Data.Documento.Id.Value = "Id"

		#Region "Encabezado"

		#Region "IdDoc"
		addenda.Data.Documento.Encabezado.IdDoc.NumeroAprobacion.Value = "1"
		addenda.Data.Documento.Encabezado.IdDoc.AnioAprobacion.Value = "2011"
		addenda.Data.Documento.Encabezado.IdDoc.Tipo.Value = 33
		addenda.Data.Documento.Encabezado.IdDoc.Serie.Value = "A"
		addenda.Data.Documento.Encabezado.IdDoc.Folio.Value = 1
		addenda.Data.Documento.Encabezado.IdDoc.Estado.Value = "ORIGINAL"
		addenda.Data.Documento.Encabezado.IdDoc.NumeroInterno.Value = "12345"
		addenda.Data.Documento.Encabezado.IdDoc.FechaEmision.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.IdDoc.IndServicio.Value = 1
		addenda.Data.Documento.Encabezado.IdDoc.TipoServicio.Value = "TipoServicio"
		addenda.Data.Documento.Encabezado.IdDoc.FormaPago.Value = "FormaPago"
		addenda.Data.Documento.Encabezado.IdDoc.MedioPago.Value = "MedioPago"
		addenda.Data.Documento.Encabezado.IdDoc.CondicionesPago.Value = "CondicionesPago"
		addenda.Data.Documento.Encabezado.IdDoc.FechaCancelacion.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.IdDoc.PeriodoDesde.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.IdDoc.PeriodoHasta.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.IdDoc.TerminoPagoCodigo.Value = "TerminoPagoCodigo"
		addenda.Data.Documento.Encabezado.IdDoc.TerminoPagoDias.Value = 1
		addenda.Data.Documento.Encabezado.IdDoc.FechaVencimiento.Value = DateTime.Now

		addenda.Data.Documento.Encabezado.IdDoc.Area.IdArea.Value = "001"
		addenda.Data.Documento.Encabezado.IdDoc.Area.IdRevision.Value = "IdRevision"
		#End Region

		#Region "Emisor"
		addenda.Data.Documento.Encabezado.Emisor.Rfc.Value = electronicDocument.Data.Emisor.Rfc.Value
		addenda.Data.Documento.Encabezado.Emisor.Nombre.Value = electronicDocument.Data.Emisor.Nombre.Value
		addenda.Data.Documento.Encabezado.Emisor.CodigoGln.Value = "1234567890123"
		addenda.Data.Documento.Encabezado.Emisor.CodigoSucursal.Value = "CodigoSucursal"
		addenda.Data.Documento.Encabezado.Emisor.Sucursal.Value = "Sucursal"
		addenda.Data.Documento.Encabezado.Emisor.CodigoVendedor.Value = "CodigoVendedor"

		Dim codigoExterno As CodigoExterno = addenda.Data.Documento.Encabezado.Emisor.CodigosExternos.Add()
		codigoExterno.TipoCodigoInterno.Value = "TipoCodigoInterno"
		codigoExterno.CodigoInterno.Value = "CodigoInterno"

		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Calle.Value = "Calle"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.NumeroExterior.Value = "NumeroExterior"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.NumeroInterior.Value = "NumeroInterior"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Colonia.Value = "Colonia"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Localidad.Value = "Localidad"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Referencia.Value = "Referencia"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Municipio.Value = "Municipio"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Estado.Value = "Estado"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Pais.Value = "Pais"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.CodigoPostal.Value = "00000"
		addenda.Data.Documento.Encabezado.Emisor.DomicilioFiscal.Gln.Value = "1234567890123"

		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Calle.Value = "Calle"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.NumeroExterior.Value = "NumeroExterior"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.NumeroInterior.Value = "NumeroInterior"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Colonia.Value = "Colonia"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Localidad.Value = "Localidad"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Referencia.Value = "Referencia"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Municipio.Value = "Municipio"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Estado.Value = "Estado"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Pais.Value = "Pais"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.CodigoPostal.Value = "00000"
		addenda.Data.Documento.Encabezado.Emisor.LugarExpedicion.Gln.Value = "1234567890123"

		Dim contacto As Contacto = addenda.Data.Documento.Encabezado.Emisor.Contactos.Add()
		contacto.Tipo.Value = "vendedor"
		contacto.Nombre.Value = "Nombre"
		contacto.Descripcion.Value = "Descripcion"
		contacto.Direccion.Value = "Direccion"
		contacto.CorreoElectronico.Value = "CorreoElectronico"
		contacto.Extension.Value = "Extension"
		contacto.Telefono.Value = "Telefono"
		contacto.Fax.Value = "Fax"
		contacto.Gln.Value = "1234567890123"
		#End Region

		#Region "Receptor"

		addenda.Data.Documento.Encabezado.Receptor.Rfc.Value = "XXXX010101XX1"
		addenda.Data.Documento.Encabezado.Receptor.Nombre.Value = "Nombre"
		addenda.Data.Documento.Encabezado.Receptor.CodigoGln.Value = "1234567890ABC"
		addenda.Data.Documento.Encabezado.Receptor.CodigoSucursal.Value = "CodigoSucursal"
		addenda.Data.Documento.Encabezado.Receptor.Sucursal.Value = "Sucursal"
		addenda.Data.Documento.Encabezado.Receptor.Contacto.Value = "Contacto"

		codigoExterno = addenda.Data.Documento.Encabezado.Receptor.CodigosExternos.Add()
		codigoExterno.TipoCodigoInterno.Value = "TipoCodigoInterno"
		codigoExterno.CodigoInterno.Value = "CodigoInterno"

		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Calle.Value = "Calle"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.NumeroExterior.Value = "NumeroExterior"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.NumeroInterior.Value = "NumeroInterior"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Colonia.Value = "Colonia"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Localidad.Value = "Localidad"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Referencia.Value = "Referencia"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Municipio.Value = "Municipio"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Estado.Value = "Estado"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Pais.Value = "Pais"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.CodigoPostal.Value = "00000"
		addenda.Data.Documento.Encabezado.Receptor.DomicilioFiscal.Gln.Value = "1234567890123"

		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Calle.Value = "Calle"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.NumeroExterior.Value = "NumeroExterior"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.NumeroInterior.Value = "NumeroInterior"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Colonia.Value = "Colonia"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Localidad.Value = "Localidad"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Referencia.Value = "Referencia"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Municipio.Value = "Municipio"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Estado.Value = "Estado"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Pais.Value = "Pais"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.CodigoPostal.Value = "00000"
		addenda.Data.Documento.Encabezado.Receptor.LugarRecepcion.Gln.Value = "1234567890123"

		contacto = addenda.Data.Documento.Encabezado.Receptor.Contactos.Add()
		contacto.Tipo.Value = "vendedor"
		contacto.Nombre.Value = "Nombre"
		contacto.Descripcion.Value = "Descripcion"
		contacto.Direccion.Value = "Direccion"
		contacto.CorreoElectronico.Value = "CorreoElectronico"
		contacto.Extension.Value = "Extension"
		contacto.Telefono.Value = "Telefono"
		contacto.Fax.Value = "Fax"
		contacto.Gln.Value = "1234567890123"

		#End Region

		#Region "Totales"
		addenda.Data.Documento.Encabezado.Totales.Moneda.Value = "MXN"
		addenda.Data.Documento.Encabezado.Totales.FactorConversion.Value = 1
		addenda.Data.Documento.Encabezado.Totales.IndLista.Value = "0"
		addenda.Data.Documento.Encabezado.Totales.TipoLista.Value = "1"
		addenda.Data.Documento.Encabezado.Totales.SubTotal.Value = 1
		addenda.Data.Documento.Encabezado.Totales.MontoDescuento.Value = 1
		addenda.Data.Documento.Encabezado.Totales.PorcentajeDescuento.Value = 1
		addenda.Data.Documento.Encabezado.Totales.MontoRecargo.Value = 1
		addenda.Data.Documento.Encabezado.Totales.PorcentajeRecargo.Value = 1
		addenda.Data.Documento.Encabezado.Totales.MontoBase.Value = 1
		addenda.Data.Documento.Encabezado.Totales.MntExe.Value = 1
		addenda.Data.Documento.Encabezado.Totales.MntImp.Value = 1
		addenda.Data.Documento.Encabezado.Totales.MntRet.Value = 1
		addenda.Data.Documento.Encabezado.Totales.SaldoAnterior.Value = 1
		addenda.Data.Documento.Encabezado.Totales.ValorPagar.Value = 1
		addenda.Data.Documento.Encabezado.Totales.ValorPalabras.Value = "ValorPalabras"
		addenda.Data.Documento.Encabezado.Totales.MontoPeriodo.Value = 1
		addenda.Data.Documento.Encabezado.Totales.TotQtyItem.Value = 1

		Dim totalSubMonto As TotalSubMonto = addenda.Data.Documento.Encabezado.Totales.TotalesSubMonto.Add()
		totalSubMonto.Tipo.Value = "Tipo"
		totalSubMonto.Monto.Value = 1
		totalSubMonto.PorCiento.Value = 10
		#End Region

		#Region "Impuestos"
		Dim impuesto As Impuesto = addenda.Data.Documento.Encabezado.Impuestos.Add()
		impuesto.Tipo.Value = "IVA"
		impuesto.Monto.Value = 1.369
		impuesto.Tasa.Value = 10
		#End Region

		#Region "Retenciones"
		Dim retencion As Impuesto = addenda.Data.Documento.Encabezado.Retenciones.Add()
		retencion.Tipo.Value = "IVA"
		retencion.Monto.Value = 1
		retencion.Tasa.Value = 10
		#End Region

		#Region "Aduana"
		addenda.Data.Documento.Encabezado.Aduana.Gln.Value = "1234567890ABC"
		addenda.Data.Documento.Encabezado.Aduana.Nombre.Value = "Nombre"
		addenda.Data.Documento.Encabezado.Aduana.Ubicacion.Value = "Ubicacion"
		addenda.Data.Documento.Encabezado.Aduana.NumeroDocumento.Value = "NumeroDocumento"
		addenda.Data.Documento.Encabezado.Aduana.FechaDocumento.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.Aduana.LugarEmbarque.Value = "LugarEmbarque"
		addenda.Data.Documento.Encabezado.Aduana.LugarDesembarque.Value = "LugarDesembarque"
		addenda.Data.Documento.Encabezado.Aduana.MedioTraslado.Value = "aereo"
		addenda.Data.Documento.Encabezado.Aduana.Agente.Value = "Agente"
		addenda.Data.Documento.Encabezado.Aduana.Representante.Value = "Representante"

		Dim documentoReferencia As DocumentoReferencia = addenda.Data.Documento.Encabezado.Aduana.DocumentosReferencia.Add()
		documentoReferencia.Tipo.Value = "Tipo"
		documentoReferencia.Numero.Value = "Numero"
		documentoReferencia.Fecha.Value = DateTime.Now
		#End Region

		#Region "Poliza"
		addenda.Data.Documento.Encabezado.Poliza.Tipo.Value = "autos"
		addenda.Data.Documento.Encabezado.Poliza.Numero.Value = "Numero"
		addenda.Data.Documento.Encabezado.Poliza.Inc.Value = "Inc"
		addenda.Data.Documento.Encabezado.Poliza.IncNumeroSerie.Value = "IncNumeroSerie"
		addenda.Data.Documento.Encabezado.Poliza.TipoCliente.Value = "0"
		addenda.Data.Documento.Encabezado.Poliza.NumeroReporte.Value = "NumeroReporte"
		addenda.Data.Documento.Encabezado.Poliza.NumeroSint.Value = "NumeroSint"
		addenda.Data.Documento.Encabezado.Poliza.NumeroExpediente.Value = "NumeroExp"
		addenda.Data.Documento.Encabezado.Poliza.NombreContacto.Value = "NombreContacto"
		addenda.Data.Documento.Encabezado.Poliza.CodigoContacto.Value = "CodigoContacto"
		addenda.Data.Documento.Encabezado.Poliza.DireccionContacto.Value = "DireccionContacto"
		addenda.Data.Documento.Encabezado.Poliza.NombreAsegurado.Value = "NombreAsegurado"
		addenda.Data.Documento.Encabezado.Poliza.CodigoAsegurado.Value = "CodigoAsegurado"
		addenda.Data.Documento.Encabezado.Poliza.DireccionAsegurado.Value = "DireccionAsegurado"
		addenda.Data.Documento.Encabezado.Poliza.NombreAfectado.Value = "NombreAfectado"
		addenda.Data.Documento.Encabezado.Poliza.CodigoAfectado.Value = "CodigoAfectado"
		addenda.Data.Documento.Encabezado.Poliza.DireccionAfectado.Value = "DireccionAfectado"
		addenda.Data.Documento.Encabezado.Poliza.VigenciaDesde.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.Poliza.VigenciaHasta.Value = DateTime.Now
		#End Region

		#Region "Servicio"
		addenda.Data.Documento.Encabezado.Servicio.Tipo.Value = "pension"
		addenda.Data.Documento.Encabezado.Servicio.Numero.Value = "Numero"
		addenda.Data.Documento.Encabezado.Servicio.NumeroExpediente.Value = "NroExp"
		addenda.Data.Documento.Encabezado.Servicio.Mandante.Value = "Mandante"
		addenda.Data.Documento.Encabezado.Servicio.Ejecutor.Value = "Ejecutor"
		addenda.Data.Documento.Encabezado.Servicio.Frecuencia.Value = "eventual"
		addenda.Data.Documento.Encabezado.Servicio.Duracion.Value = 30
		addenda.Data.Documento.Encabezado.Servicio.Origen.Value = "Origen"
		addenda.Data.Documento.Encabezado.Servicio.Destino.Value = "Destino"
		addenda.Data.Documento.Encabezado.Servicio.Razon.Value = "RazonServ"
		addenda.Data.Documento.Encabezado.Servicio.PeriodoDesde.Value = DateTime.Now
		addenda.Data.Documento.Encabezado.Servicio.PeriodoHasta.Value = DateTime.Now
		#End Region

		#Region "Vehiculo"
		addenda.Data.Documento.Encabezado.Vehiculo.Tipo.Value = "Tipo"
		addenda.Data.Documento.Encabezado.Vehiculo.Marca.Value = "Marca"
		addenda.Data.Documento.Encabezado.Vehiculo.Modelo.Value = "Modelo"
		addenda.Data.Documento.Encabezado.Vehiculo.Anio.Value = 2010
		addenda.Data.Documento.Encabezado.Vehiculo.Color.Value = "Color"
		addenda.Data.Documento.Encabezado.Vehiculo.NumeroChasis.Value = "NumeroChasis"
		addenda.Data.Documento.Encabezado.Vehiculo.NumeroSerie.Value = "NumeroSerie"
		addenda.Data.Documento.Encabezado.Vehiculo.NumeroMotor.Value = "NumeroMotor"
		addenda.Data.Documento.Encabezado.Vehiculo.Placa.Value = "Placa"
		#End Region

		#End Region

		#Region "Detalle"

		Dim detalle As ElectronicDocumentLibrary.Amis.Addenda.Detalle = addenda.Data.Documento.Detalles.Add()

		detalle.NumeroLinea.Value = 1

		Dim codigo As Codigo = detalle.Codigos.Add()
		codigo.Tipo.Value = "Tipo"
		codigo.Valor.Value = "Valor"

		detalle.IndExe.Value = 1
		detalle.IndLista.Value = "0"
		detalle.TpoLista.Value = "TpoLista"
		detalle.DescripcionIdioma.Value = "ES"
		detalle.Descripcion.Value = "Descripcion"
		detalle.Cantidad.Value = 1

		Dim item As SubQtyItem = detalle.SubQtyItems.Add()
		item.Codigo.Value = "Codigo"
		item.Cantidad.Value = 1

		detalle.FechaElaboracion.Value = DateTime.Now
		detalle.FechaVencimiento.Value = DateTime.Now
		detalle.UnidadMedida.Value = "UnidadMedida"
		detalle.PrecioBruto.Value = 1
		detalle.PrecioNeto.Value = 1

		detalle.OtraMoneda.Factor.Value = 1
		detalle.OtraMoneda.Moneda.Value = "MXN"
		detalle.OtraMoneda.Precio.Value = 1

		detalle.ProcentajeDescuento.Value = 1
		detalle.MontoDescuento.Value = 1

		Dim subDescuento As SubImporte = detalle.SubDescuentos.Add()
		subDescuento.Tipo.Value = "Tipo"
		subDescuento.Glosa.Value = "Glosa"
		subDescuento.Porcentaje.Value = 1
		subDescuento.Monto.Value = 1

		detalle.ProcentajeRecardo.Value = 1
		detalle.MontoRecardo.Value = 1

		Dim subRecargo As SubImporte = detalle.SubRecargos.Add()
		subRecargo.Tipo.Value = "Tipo"
		subRecargo.Glosa.Value = "Glosa"
		subRecargo.Porcentaje.Value = 1
		subRecargo.Monto.Value = 1

		impuesto = detalle.Impuestos.Add()
		impuesto.Tipo.Value = "IVA"
		impuesto.Tasa.Value = 1
		impuesto.Monto.Value = 1

		retencion = detalle.Retenciones.Add()
		retencion.Tipo.Value = "IVA"
		retencion.Tasa.Value = 1
		retencion.Monto.Value = 1

		detalle.MontoBruto.Value = 1
		detalle.MontoNeto.Value = 1
		detalle.MontoTotal.Value = 1

		Dim subMonto As SubMonto = detalle.SubMontos.Add()
		subMonto.Tipo.Value = "Tipo"
		subMonto.Monto.Value = 1
		subMonto.PorCiento.Value = 1

		detalle.NumeroCuentaPredial.Value = "NumeroCuentaPredial"
		detalle.TipoDocumentoReferencia.Value = "Tipo"
		detalle.SerieReferencia.Value = "Serie"
		detalle.FolioReferencia.Value = "FolioReferencia"

		Dim aduana As Aduana = detalle.Aduanas.Add()
		aduana.Gln.Value = "1234567890ABC"
		aduana.Nombre.Value = "Nombre"
		aduana.Ubicacion.Value = "Ubicacion"
		aduana.NumeroDocumento.Value = "NumeroDocumento"
		aduana.FechaDocumento.Value = DateTime.Now
		aduana.LugarEmbarque.Value = "LugarEmbarque"
		aduana.LugarDesembarque.Value = "LugarDesembarque"
		aduana.MedioTraslado.Value = "terrestre"
		aduana.Agente.Value = "Agente"
		aduana.Representante.Value = "Representante"

		Dim documentosReferencia As DocumentoReferencia = aduana.DocumentosReferencia.Add()
		documentosReferencia.Tipo.Value = "Tipo"
		documentosReferencia.Numero.Value = "Numero"
		documentosReferencia.Fecha.Value = DateTime.Now

		detalle.Poliza.Tipo.Value = "vida"
		detalle.Poliza.Numero.Value = "Numero"
		detalle.Poliza.Inc.Value = "Inc"
		detalle.Poliza.IncNumeroSerie.Value = "IncNumeroSerie"
		detalle.Poliza.TipoCliente.Value = "1"
		detalle.Poliza.NumeroReporte.Value = "NumeroReporte"
		detalle.Poliza.NumeroSint.Value = "NumeroSint"
		detalle.Poliza.NumeroExpediente.Value = "NumeroExpediente"
		detalle.Poliza.NombreContacto.Value = "NombreContacto"
		detalle.Poliza.CodigoContacto.Value = "CodigoContacto"
		detalle.Poliza.DireccionContacto.Value = "DireccionContacto"
		detalle.Poliza.NombreAsegurado.Value = "NombreAsegurado"
		detalle.Poliza.CodigoAsegurado.Value = "CodigoAsegurado"
		detalle.Poliza.DireccionAsegurado.Value = "DireccionAsegurado"
		detalle.Poliza.NombreAfectado.Value = "NombreAfectado"
		detalle.Poliza.CodigoAfectado.Value = "CodigoAfectado"
		detalle.Poliza.DireccionAfectado.Value = "DireccionAfectado"
		detalle.Poliza.VigenciaDesde.Value = DateTime.Now
		detalle.Poliza.VigenciaHasta.Value = DateTime.Now

		detalle.Servicio.Tipo.Value = "medico"
		detalle.Servicio.Numero.Value = "Numero"
		detalle.Servicio.NumeroExpediente.Value = "NumeroExpediente"
		detalle.Servicio.Mandante.Value = "Mandante"
		detalle.Servicio.Ejecutor.Value = "Ejecutor"
		detalle.Servicio.Frecuencia.Value = "semanal"
		detalle.Servicio.Duracion.Value = 30
		detalle.Servicio.Origen.Value = "Origen"
		detalle.Servicio.Destino.Value = "Destino"
		detalle.Servicio.Razon.Value = "Razon"
		detalle.Servicio.PeriodoDesde.Value = DateTime.Now
		detalle.Servicio.PeriodoHasta.Value = DateTime.Now

		detalle.Vehiculo.Tipo.Value = "Tipo"
		detalle.Vehiculo.Marca.Value = "Marca"
		detalle.Vehiculo.Modelo.Value = "Modelo"
		detalle.Vehiculo.Anio.Value = 2012
		detalle.Vehiculo.Color.Value = "Color"
		detalle.Vehiculo.NumeroChasis.Value = "NumeroChasis"
		detalle.Vehiculo.NumeroSerie.Value = "NumeroSerie"
		detalle.Vehiculo.NumeroMotor.Value = "NumeroMotor"
		detalle.Vehiculo.Placa.Value = "Placa"

		detalle.Local.Tipo.Value = "agencia"
		detalle.Local.Codigo.Value = "Codigo"
		detalle.Local.Nombre.Value = "Nombre"

		Dim seccion As Seccion = detalle.Local.Secciones.Add()
		seccion.Tipo.Value = "piso"
		seccion.Calificador.Value = "Calificador"
		seccion.Numero.Value = "Numero"

		detalle.Area.IdArea.Value = "001"
		detalle.Area.IdRevision.Value = "IdRevision"

		#End Region

		#Region "Descuento / Recargo global"

		Dim descuentoRecargoGlobal As DescuentoRecargoGlobal = addenda.Data.Documento.DescuentoRecargoGlobales.Add()
		descuentoRecargoGlobal.NumeroLinea.Value = 1
		descuentoRecargoGlobal.TipoMovimiento.Value = "D"
		descuentoRecargoGlobal.Codigo.Value = "Codigo"
		descuentoRecargoGlobal.Glosa.Value = "Glosa"
		descuentoRecargoGlobal.TipoValor.Value = "%"
		descuentoRecargoGlobal.Valor.Value = 1
		descuentoRecargoGlobal.IndExe.Value = 1

		#End Region

		#Region "Referencia"
		Dim referencia As Referencia = addenda.Data.Documento.Referencias.Add()
		referencia.NumeroLinea.Value = 1
		referencia.TipoDocumento.Value = "Tipo"
		referencia.Serie.Value = "Serie"
		referencia.Folio.Value = "Folio"
		referencia.Fecha.Value = DateTime.Now
		referencia.Codigo.Value = 1
		referencia.Razon.Value = "Razon"

		Dim subCodigo As SubCodigo = referencia.SubCodigos.Add()
		subCodigo.Tipo.Value = "Tipo"
		subCodigo.Folio.Value = "1"
		subCodigo.Fecha.Value = DateTime.Now

		Dim monto As MontoReferencia = referencia.Montos.Add()
		monto.Tipo.Value = "Tipo"
		monto.Porcentaje.Value = 1
		monto.Monto.Value = 1

		referencia.Proveedor.Identificador.Value = "1"
		referencia.Proveedor.Nombre.Value = "1"
		#End Region

		addenda.Data.Documento.TimeStamp.Value = DateTime.Now

		#End Region

		#Region "Personalizados"

		Dim campoString As CampoString = addenda.Data.Personalizados.CamposString.Add()
		campoString.Nombre.Value = "A"
		campoString.Campo.Value = "1"

		Dim campoNumero As CampoNumero = addenda.Data.Personalizados.CamposNumero.Add()
		campoNumero.Nombre.Value = "B"
		campoNumero.Campo.Value = 1

		Dim campoFecha As CampoFecha = addenda.Data.Personalizados.CamposFecha.Add()
		campoFecha.Nombre.Value = "C"
		campoFecha.Campo.Value = DateTime.Now

		Dim customDetalle As CustomDetalle = addenda.Data.Personalizados.CustomDetalles.Add()
		customDetalle.NumeroLinea.Value = 1
		customDetalle.Afn01.Value = "A"
		customDetalle.Afn02.Value = "B"
		customDetalle.Afn03.Value = "C"
		customDetalle.Afn04.Value = "D"
		customDetalle.Afn05.Value = "E"
		customDetalle.Afn06.Value = "F"
		customDetalle.Nue01.Value = 1
		customDetalle.Nue02.Value = 2
		customDetalle.Nue03.Value = 3
		customDetalle.Nue04.Value = 4
		customDetalle.Nue05.Value = 5
		customDetalle.Nue06.Value = 6
		customDetalle.Nud01.Value = 1.1
		customDetalle.Nud02.Value = 1.2
		customDetalle.Nud03.Value = 1.3
		customDetalle.Nud04.Value = 1.4
		customDetalle.Nud05.Value = 1.5
		customDetalle.Fec01.Value = DateTime.Now
		customDetalle.Fec02.Value = DateTime.Now
		#End Region

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Amis.xml", fileName)
	End Function

End Class