Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Santander.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Santander(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Santander = HyperSoft.ElectronicDocumentLibrary.Santander.Addenda.Santander.NewEntity()

		' Elemento para Información de Pago.
		Dim informacionPago As ElectronicDocumentLibrary.Santander.Addenda.InformacionPago = addenda.Data.InformacionPagos.Add()
		informacionPago.NumeroProveedor.Value = "rNrYW7ZzlMD10ay5p"
		informacionPago.OrdenCompra.Value = "123"
		informacionPago.PosicionCompra.Value = "1"
		informacionPago.NombreBeneficiario.Value = "Beneficiario"
		informacionPago.InstitucionReceptora.Value = "receptora"
		informacionPago.NumeroCuenta.Value = "12703906421917280"
		informacionPago.CuentaContable.Value = "09813046567320564"
		informacionPago.ClaveDeposito.Value = "22771405225257715481"
		informacionPago.CorreoElectronico.Value = "correo@test.com"
		informacionPago.CodigoMoneda.Value = "MXP"
		informacionPago.Concepto.Value = "Concepto 1"

		' Elemento para Información de Pago.
		informacionPago = addenda.Data.InformacionPagos.Add()
		informacionPago.NumeroProveedor.Value = "stWQ0fWV1S"
		informacionPago.OrdenCompra.Value = "456"
		informacionPago.PosicionCompra.Value = "2"
		informacionPago.NombreBeneficiario.Value = "Beneficiario 2"
		informacionPago.InstitucionReceptora.Value = "instituc"
		informacionPago.NumeroCuenta.Value = "14111100971205458"
		informacionPago.CuentaContable.Value = "60796211832544406"
		informacionPago.ClaveDeposito.Value = "96298951626127568194"
		informacionPago.CorreoElectronico.Value = "rpeues@correo.com"
		informacionPago.CodigoMoneda.Value = "ARS"
		informacionPago.Concepto.Value = "Concepto 2"

		' Elemento para Información de Emisión.
		addenda.Data.InformacionEmision.CodigoCliente.Value = "CodigoCliente"
		addenda.Data.InformacionEmision.Contrato.Value = "Contrato"
		addenda.Data.InformacionEmision.Periodo.Value = "Periodo"
		addenda.Data.InformacionEmision.CentroCostos.Value = "CentroCostos"
		addenda.Data.InformacionEmision.FolioInterno.Value = "FolioInterno"
		addenda.Data.InformacionEmision.ClaveSantander.Value = "ClaveSantander"

		Dim informacionFactoraje As InformacionFactoraje = addenda.Data.InformacionEmision.Factoraje.Add()
		informacionFactoraje.DeudorProveedor.Value = "DeudorProveedor 1"
		informacionFactoraje.TipoDocumento.Value = "TipoDocumento 1"
		informacionFactoraje.NumeroDocumento.Value = "NumeroDocumento 1"
		informacionFactoraje.FechaVencimiento.Value = DateTime.Now
		informacionFactoraje.Plazo.Value = 1
		informacionFactoraje.ValorNominal.Value = 2
		informacionFactoraje.Aforo.Value = 3
		informacionFactoraje.PrecioBase.Value = 4
		informacionFactoraje.TasaDescuento.Value = 5
		informacionFactoraje.PrecioFactoraje.Value = 6
		informacionFactoraje.ImporteDescuento.Value = 7

		informacionFactoraje = addenda.Data.InformacionEmision.Factoraje.Add()
		informacionFactoraje.DeudorProveedor.Value = "DeudorProveedor 2"
		informacionFactoraje.TipoDocumento.Value = "TipoDocumento 2"
		informacionFactoraje.NumeroDocumento.Value = "NumeroDocumento 2"
		informacionFactoraje.FechaVencimiento.Value = DateTime.Now.AddYears(1)
		informacionFactoraje.Plazo.Value = 11
		informacionFactoraje.ValorNominal.Value = 12
		informacionFactoraje.Aforo.Value = 13
		informacionFactoraje.PrecioBase.Value = 14
		informacionFactoraje.TasaDescuento.Value = 15
		informacionFactoraje.PrecioFactoraje.Value = 16
		informacionFactoraje.ImporteDescuento.Value = 17

		' Tipo para Información de Inmuebles.
		addenda.Data.Inmuebles.FechaVencimiento.Value = DateTime.Now
		addenda.Data.Inmuebles.NumeroContrato.Value = "NumeroContrato"

		' Estructura para la información de los campos de Basilea.
		addenda.Data.Basilea.NumeroContrato.Value = "NumeroContrato"
		addenda.Data.Basilea.OrigenGasto.Value = "OrigenGasto"
		addenda.Data.Basilea.TipoGasto.Value = "TipoGasto"

		' Elementos para representar Campos Adicionales no considerados en la Addenda Santander V1.
		Dim campoAdicional As CampoAdicional = addenda.Data.CamposAdicionales.Add()
		campoAdicional.Campo.Value = "Campo 1"
		campoAdicional.Valor.Value = "Valor 1"

		campoAdicional = addenda.Data.CamposAdicionales.Add()
		campoAdicional.Campo.Value = "Campo 2"
		campoAdicional.Valor.Value = "Valor 2"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Santander.xml", fileName)
	End Function

End Class