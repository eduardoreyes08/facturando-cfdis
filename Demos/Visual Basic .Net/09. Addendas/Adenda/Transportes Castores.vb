Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.TransportesCastores.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function TransportesCastores(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As TransportesCastores = HyperSoft.ElectronicDocumentLibrary.TransportesCastores.Addenda.TransportesCastores.NewEntity()

		addenda.Data.ImporteEntregado.Value = 1
		addenda.Data.NumeroProveedor.Value = "NumeroProveedor"
		addenda.Data.Produccion = False

		Dim vale As Vale = addenda.Data.Vales.Add()
		vale.Numero.Value = "Numero"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_TransportesCastores.xml", fileName)
	End Function

End Class