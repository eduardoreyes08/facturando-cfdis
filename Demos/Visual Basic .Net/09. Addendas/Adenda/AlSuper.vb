Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.AlSuper.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function AlSuper(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As AlSuper = HyperSoft.ElectronicDocumentLibrary.AlSuper.Addenda.AlSuper.NewEntity()

		addenda.Data.Version.Value = "1.0"
		addenda.Data.OrdenCompra.Value = 1
		addenda.Data.Remision.Value = "Remision"
		addenda.Data.TipoCambio.Value = 2
		addenda.Data.Sucursal.Value = "Sucursal"
		addenda.Data.TipoMoneda.Value = "TipoMoneda"
		addenda.Data.Cita.Value = 3
		addenda.Data.FechaCita.Value = DateTime.Now
		addenda.Data.TipoBulto.Value = "TipoBulto"
		addenda.Data.ValorFlete.Value = 4
		addenda.Data.CorreoElectronico.Value = "prueba@prueba.com"

		Dim concepto As ElectronicDocumentLibrary.AlSuper.Addenda.Concepto = addenda.Data.Conceptos.Add()
		concepto.Numero.Value = 1
		concepto.CodigoBarras.Value = "CodigoBarras 1"
		concepto.FactorEmpaque.Value = 2
		concepto.EmpaqueIngreso.Value = 4
		concepto.CostoPagar.Value = 5
		concepto.ValorIeps.Value = 6
		concepto.ValorIva.Value = 7

		concepto = addenda.Data.Conceptos.Add()
		concepto.Numero.Value = 8
		concepto.CodigoBarras.Value = "CodigoBarras 2"
		concepto.FactorEmpaque.Value = 9
		concepto.EmpaqueIngreso.Value = 10
		concepto.CostoPagar.Value = 11
		concepto.ValorIeps.Value = 12
		concepto.ValorIva.Value = 13

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_AlSuper.xml", fileName)
	End Function

End Class