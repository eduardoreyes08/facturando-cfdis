Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.WalMart.Addenda

Partial Friend NotInheritable Class Adenda

  Friend Shared Function WalMart(ByRef fileName As String) As Boolean
    'En este método se cargan los datos de la factura.
    Cfdi40.CargarDatosCompleto(electronicDocument)

    Dim addenda As WalMart = New HyperSoft.ElectronicDocumentLibrary.WalMart.Addenda.WalMart().Initialization()

#Region "ENCABEZADO"

    ' Definición de los datos correspondientes al sobre del documento
    ' Referencia del emisor del comprobante
    addenda.Data.Envelope.ReferenciaEmisor.Value = "EDIID"
    ' Referencia del receptor (Walmart)
    addenda.Data.Envelope.ReferenciaReceptor.Value = "925485MX00"
    ' Fecha del CFDI
    addenda.Data.Envelope.FechaHoraCfdi.Value = DateTime.Now
    ' Número de control
    addenda.Data.Envelope.NumeroControl.Value = 3945

    ' Definición de los datos correspondientes al encabezado de la addenda
    ' Número de referencia del mensaje
    addenda.Data.Header.NumeroReferencia.Value = "1"
    ' Tipo de mensaje (INVOIC = Factura)
    addenda.Data.Header.TipoMensaje.Value = "INVOIC"
    ' Versión del mensaje (01B)
    addenda.Data.Header.VersionMensaje.Value = "01B"
    ' Número de control de la versión del mensaje (AMC002 = AMECE)
    addenda.Data.Header.CodigoControl.Value = "AMC002"

    ' Definición de los datos correspondientes al inicio del mensaje
    ' Tipo de documento (380 = factura)
    addenda.Data.Header.TipoDocumento.Value = "380"
    ' Folio de la factura
    addenda.Data.Header.FolioDocumento.Value = "092761"
    ' Código del mensaje (9 = original)
    addenda.Data.Header.CodigoMensaje.Value = 9

    ' Definición de los datos correspondientes a la fecha y hora del documento
    ' Fecha de la factura
    addenda.Data.Header.FechaDocumento.Value = DateTime.Now
    ' Formato de la fecha (204 = AAAMMDDHHMMSS)
    addenda.Data.Header.FormatoFechaDocumento.Value = 204

    ' Definición del importe con letra e idioma
    ' Importe con letra del total de la factura
    addenda.Data.Header.ImporteLetra.Value = "OCHO MIL OCHOCIENTOS TREINTA Y DOS PESOS 00/100 M.N."
    ' Idioma usado (ES = Español)
    addenda.Data.Header.Idioma.Value = "ES"

    For i As Integer = 0 To 2
      Dim ordenCompra As New HyperSoft.ElectronicDocumentLibrary.WalMart.OrdenCompra()
      ' Número de orden de compra
      ordenCompra.Numero.Value = "9250113699" + (i + 1)
      ' Fecha de la orden de compra
      ordenCompra.Fecha.Value = DateTime.Now.AddDays(-7)
      ' Formato de la fecha
      ordenCompra.FormatoFecha.Value = 102
      addenda.Data.Header.OrdenCompra.Add(ordenCompra)
    Next

    For i As Integer = 0 To 2
      ' Folio de entrega
      Dim item As New HyperSoft.ElectronicDocumentLibrary.WalMart.ReciboMercancia()
      item.Folio.Value = "Folio_Mercancía_" + (i + 1).ToString()
      addenda.Data.Header.ReciboMercancia.Add(item)
    Next

    ' Definición de la serie de la factura
    addenda.Data.Header.SerieFactura.Value = "ABC"

    ' Definición del número de aprobación de hacienda
    addenda.Data.Header.NumeroAprobacion.Value = "0001"

    ' Definición del nombre y domicilio del comprador
    ' Número de localización
    addenda.Data.Header.Comprador.NumeroLocalizacionGlobal.Value = "7507003100001"
    ' Código (9 = EAN)
    addenda.Data.Header.Comprador.Codigo.Value = 9
    ' Nombre o razón social
    addenda.Data.Header.Comprador.RazonSocial.Value = "NUEVA WAL MART DE MEXICO S DE RL DE CV"
    ' Calle y número
    addenda.Data.Header.Comprador.Calle.Value = "NEXTENGO NO 78"
    ' Colonia
    addenda.Data.Header.Comprador.Colonia.Value = "SANTA CRUZ ACAYUCAN"
    ' Alcaldía
    addenda.Data.Header.Comprador.Alcaldia.Value = "AZCAPOTZALCO"
    ' Estado
    addenda.Data.Header.Comprador.Estado.Value = "DF"
    ' Código postal
    addenda.Data.Header.Comprador.CodigoPostal.Value = "02770"

    ' Definición del RFC del comprador
    addenda.Data.Header.RfcReceptor.Value = "NWM9709244W4"

    ' Definición de la referencia IEPS
    addenda.Data.Header.IdentificadoIeps.Value = "01015401319335"

    ' Definición del nombre y domicilio del proveedor
    ' Número de localización
    addenda.Data.Header.Proveedor.NumeroLocalizacionGlobal.Value = "NumeroLocalizacionGlobal"
    ' Código (9 = EAN)
    addenda.Data.Header.Proveedor.Codigo.Value = 9
    ' Nombre o razón social
    addenda.Data.Header.Proveedor.RazonSocial.Value = "Razón social proveedorñÑ"
    ' Calle y número
    addenda.Data.Header.Proveedor.Calle.Value = "Calle y número proveedor"
    ' Colonia
    addenda.Data.Header.Proveedor.Colonia.Value = "Colonia proveedor"
    ' Alcaldía
    addenda.Data.Header.Proveedor.Alcaldia.Value = "Alcaldía proveedor"
    ' Estado
    addenda.Data.Header.Proveedor.Estado.Value = "Estado proveedor"
    ' Código postal
    addenda.Data.Header.Proveedor.CodigoPostal.Value = "Código postal proveedor"

    ' Definición del RFC del proveedor
    addenda.Data.Header.RfcProveedor.Value = "RfcEmisor"

    ' Definición del número de proveedor asignado por Walmart
    addenda.Data.Header.NumeroProveedor.Value = "185853950"

    ' Definición del nombre y domicilio de la sucursal del proveedor
    ' Número de localización
    addenda.Data.Header.SucursalProveedor.NumeroLocalizacionGlobal.Value = "NumeroLocalizacionGlobal"
    ' Código (9 = EAN)
    addenda.Data.Header.SucursalProveedor.Codigo.Value = 9
    ' Nombre o razón social
    addenda.Data.Header.SucursalProveedor.RazonSocial.Value = "Razón social sucursal del proveedorñÑ"
    ' Calle y número
    addenda.Data.Header.SucursalProveedor.Calle.Value = "Calle y número sucursal"
    ' Colonia
    addenda.Data.Header.SucursalProveedor.Colonia.Value = "Colonia sucursal"
    ' Alcaldía
    addenda.Data.Header.SucursalProveedor.Alcaldia.Value = "Alcaldía sucursal"
    ' Estado
    addenda.Data.Header.SucursalProveedor.Estado.Value = "Estado sucursal"
    ' Código postal
    addenda.Data.Header.SucursalProveedor.CodigoPostal.Value = "Código postal sucursal"

    ' Definición del nombre y domicilio del lugar de entrega
    ' Número de localización
    addenda.Data.Header.LugarEntrega.NumeroLocalizacionGlobal.Value = "NumeroLocalizacionGlobal"
    ' Código (9 = EAN)
    addenda.Data.Header.LugarEntrega.Codigo.Value = 9
    ' Nombre o razón social
    addenda.Data.Header.LugarEntrega.RazonSocial.Value = "Razón social lugar de entrega ñÑ"
    ' Calle y número
    addenda.Data.Header.LugarEntrega.Calle.Value = "Calle y número entrega"
    ' Colonia
    addenda.Data.Header.LugarEntrega.Colonia.Value = "Colonia entrega"
    ' Alcaldía
    addenda.Data.Header.LugarEntrega.Alcaldia.Value = "Alcaldía entrega"
    ' Estado
    addenda.Data.Header.LugarEntrega.Estado.Value = "Estado entrega"
    ' Código postal
    addenda.Data.Header.LugarEntrega.CodigoPostal.Value = "Código postal entrega"

    ' Definición de la moneda y tipo de cambio
    ' Moneda (MXN = pesos Mexicanos)
    addenda.Data.Header.Moneda.Value = "MXN"
    ' Tipo de cambio
    ' walMart.Data.Header.Moneda Falt el tipo de cambio

    '  Definición del término de pago (días de vencimiento)
    ' Tipo de término (1 = básico)
    addenda.Data.Header.CodigoTipoTermino.Value = 1
    ' Código de referencia (5 = fecha de la factura)
    addenda.Data.Header.CodigoReferencia.Value = 5
    ' Término (3 = después de la referencia
    addenda.Data.Header.Termino.Value = 3
    ' Código del periodo (D = días)
    addenda.Data.Header.CodigoPeriodo.Value = "D"
    ' Plazo del pago
    addenda.Data.Header.PlazoPago.Value = 15

#End Region

#Region "DETALLE"

    For i As Integer = 0 To 2
      Dim detail As New HyperSoft.ElectronicDocumentLibrary.WalMart.Detail()
      addenda.Data.Details.Add(detail)
      ' Número de línea
      detail.NumeroLinea.Value = 1
      ' Código de barras del producto
      detail.CodigoProducto.Value = "1234567890123"
      ' Identificador del código (SRV = EAN)
      detail.TipoCodigoIdentificacion.Value = "SRV"
      ' Código agencia responsable (9 = EAN)
      detail.CodigoAgenciaResponsable.Value = 9

      ' Definición del código del cliente
      ' Identificador
      detail.CodigoComprador.IdentificacionAdicional.Value = 1
      'Código del cliente
      detail.CodigoComprador.Identificador.Value = "CódigoCliente"
      ' Tipo de identificador (IN = comprador)
      detail.CodigoComprador.CodigoIdentificacion.Value = "IN"

      ' Definición del código del proveedor
      ' Identificador
      detail.CodigoProveedor.IdentificacionAdicional.Value = 1
      ' Código del proveedor
      detail.CodigoProveedor.Identificador.Value = "CódigoProveedor"
      ' Tipo de identificador (SA = proveedor)
      detail.CodigoProveedor.CodigoIdentificacion.Value = "SA"

      ' Definición del número de serie
      ' Identificador
      detail.Serie.IdentificacionAdicional.Value = 1
      ' Número de serie
      detail.Serie.Identificador.Value = "NúmeroSerie"
      ' Tipo de identificador (SN = número de serie)
      detail.Serie.CodigoIdentificacion.Value = "SN"

      ' Definición de la descripción del artículo y/o producto
      Dim descripcion As New HyperSoft.ElectronicDocumentLibrary.WalMart.Descripcion()
      ' Descripción
      descripcion.Texto.Value = "Descripción"
      ' Idioma de la descripción (ES = español)
      descripcion.Idioma.Value = "ES"
      detail.Descripciones.Add(descripcion)

      ' Definición de la cantidad de artículos y/o productos
      ' Tipo de cantidad (47 = cantidad facturada)
      detail.TipoCodigo.Value = 47
      ' Cantidad
      detail.Cantidad.Value = 10
      ' Código EA
      detail.Codigo.Value = "EA"

      ' Subtotal de la línea
      detail.Importe.Value = New Decimal(1000.23698)

      ' Precio unitario
      detail.Precio.Value = New Decimal(100.23698)

      For j As Integer = 0 To 2
        Dim impuesto As New HyperSoft.ElectronicDocumentLibrary.WalMart.Impuesto()
        detail.Impuestos.Add(impuesto)

        ' Identificador (7 = impuesto)
        impuesto.Identificador.Value = 7
        ' Tipo de impuesto (VAT = IVA)
        impuesto.Tipo.Value = "VAT"
        ' Tasa de impuesto
        impuesto.Tasa.Value = "16"
        ' Código (B = Trasladado)
        impuesto.Codigo.Value = "B"
        ' Importe del impuesto
        impuesto.Importe.Value = New Decimal(160.23698)
      Next

      For j As Integer = 0 To 2
        Dim pedimento As New HyperSoft.ElectronicDocumentLibrary.WalMart.Pedimento()
        detail.Pedimentos.Add(pedimento)

        ' GLN de la aduana
        pedimento.NumeroLocalizacionGlobal.Value = "7500963500012"
        ' Nombre de la aduana
        pedimento.NombreAduana.Value = "AduanaMX"
        ' Número de pedimento
        pedimento.NumeroPedimento.Value = "ADU12345"
        ' Fecha del pedimento
        pedimento.FechaPedimento.Value = DateTime.Now
        ' Formato de la fecha (102 = AAAAMMDD)
        pedimento.FormatoFecha.Value = 102
      Next
    Next

#End Region

#Region "RESUMEN"
    ' Definición del resumen de la addenda
    ' Total de líneas o partidas
    addenda.Data.Resume.TotalConceptos.Value = 2
    ' Total de la factura
    addenda.Data.Resume.Importe.Value = New Decimal(1160.23)
    ' Subtotal de la factura
    addenda.Data.Resume.SubTotal.Value = New Decimal(1000.23)
    ' Base de impuesto
    addenda.Data.Resume.BaseImpuestos.Value = New Decimal(1000.23)

    For i As Integer = 0 To 2
      Dim impuesto As New HyperSoft.ElectronicDocumentLibrary.WalMart.Impuesto()
      addenda.Data.[Resume].Impuestos.Add(impuesto)

      ' Identificador (7 = impuesto)
      impuesto.Identificador.Value = 7
      ' Tipo de impuesto (VAT = IVA)
      impuesto.Tipo.Value = "VAT"
      ' Tasa de impuesto
      impuesto.Tasa.Value = "16.00"
      ' Código (B = Trasladado)
      impuesto.Codigo.Value = "B"
      ' Importe del impuesto
      impuesto.Importe.Value = New Decimal(160.23698)
    Next

    ' Definición número de segmentos
    ' Número de referencia / control del mensaje
    addenda.Data.[Resume].NumeroReferencia.Value = "3945"


#End Region

    electronicDocument.Data.Addendas.Add(addenda)

    Return Save("Addenda_WALMART.xml", fileName)

  End Function
End Class