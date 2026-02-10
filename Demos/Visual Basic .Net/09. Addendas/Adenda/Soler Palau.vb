Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.SolerPalau.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function SolerPalau(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As SolerPalau = HyperSoft.ElectronicDocumentLibrary.SolerPalau.Addenda.SolerPalau.NewEntity()

		addenda.Data.NumeroProveedor.Value = "NumeroProveedor"
		addenda.Data.OrdenCompra.Value = "OrdenCompra"
		addenda.Data.OrdenTipo.Value = "OrdenTipo"
		addenda.Data.Moneda.Value = "MXP"
		addenda.Data.TipoComprobante.Value = "FACTURA"

		Dim concepto As ElectronicDocumentLibrary.SolerPalau.Addenda.Concepto = addenda.Data.Conceptos.Add()
		concepto.Numero.Value = 1
		concepto.Cantidad.Value = 2
		concepto.NumeroIdentificacion.Value = "NumeroIdentificacion 1"
		concepto.ValorUnitario.Value = 3
		concepto.Importe.Value = 4

		concepto = addenda.Data.Conceptos.Add()
		concepto.Numero.Value = 2
		concepto.Cantidad.Value = 5
		concepto.NumeroIdentificacion.Value = "NumeroIdentificacion 2"
		concepto.ValorUnitario.Value = 6
		concepto.Importe.Value = 7

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_SOLERPALAU.xml", fileName)
	End Function

End Class