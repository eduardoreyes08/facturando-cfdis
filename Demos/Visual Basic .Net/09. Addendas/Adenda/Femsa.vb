Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Femsa.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Femsa(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Femsa = HyperSoft.ElectronicDocumentLibrary.Femsa.Addenda.Femsa.NewEntity()

		addenda.Data.Version.Value = "Version"
		addenda.Data.ClaseDocumento.Value = "ClaseDocumento"
		addenda.Data.Sociedad.Value = "Sociedad"
		addenda.Data.NumeroProveedor.Value = "NumeroProveedor"
		addenda.Data.NumeroPedido.Value = "NumeroPedido"
		addenda.Data.NumeroSocioSap.Value = "NumeroSocioSap"
		addenda.Data.Moneda.Value = "Moneda"
		addenda.Data.NumeroEntradaSap.Value = "NumeroEntradaSap"
		addenda.Data.NumeroRemision.Value = "NumeroRemision"
		addenda.Data.Centro.Value = "Centro"
		addenda.Data.Retenciones1.Value = "Retenciones1"
		addenda.Data.Retenciones2.Value = "Retenciones2"
		addenda.Data.CorreoElectronico.Value = "CorreoElectronico"
		addenda.Data.PeriodoLiquidacion.Inicial.Value = DateTime.Now
		addenda.Data.PeriodoLiquidacion.Final.Value = DateTime.Now

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Femsa.xml", fileName)
	End Function

End Class