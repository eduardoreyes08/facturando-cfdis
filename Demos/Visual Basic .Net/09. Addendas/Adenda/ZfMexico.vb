Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.ZfMexico.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function ZfMexico(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As ZfMexico = HyperSoft.ElectronicDocumentLibrary.ZfMexico.Addenda.ZfMexico.NewEntity()

		addenda.Data.Version.Value = "1.0"
		addenda.Data.Moneda.Value = "MXN"
		addenda.Data.IdFactura.Value = "12345abcde"

		Dim concepto As ElectronicDocumentLibrary.ZfMexico.Addenda.Concepto = addenda.Data.Conceptos.Add()
		concepto.NumeroPosicion.Value = 1
		concepto.NumeroOrdenCompra.Value = 2
		concepto.Cantidad.Value = 3
		concepto.ValorUnitario.Value = 4
		concepto.Importe.Value = 5

		concepto = addenda.Data.Conceptos.Add()
		concepto.NumeroPosicion.Value = 7
		concepto.NumeroOrdenCompra.Value = 8
		concepto.Cantidad.Value = 9
		concepto.ValorUnitario.Value = 10
		concepto.Importe.Value = 11

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_ZfMexico.xml", fileName)
	End Function

End Class