Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Landsteiner.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Landsteiner(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Landsteiner = HyperSoft.ElectronicDocumentLibrary.Landsteiner.Addenda.Landsteiner.NewEntity()

		addenda.Data.CodigoSociedad.Value = "CodigoSociedad"
		addenda.Data.NombreSociedad.Value = "NombreSociedad"
		addenda.Data.CodigoProveedor.Value = "CodigoProveedor"
		addenda.Data.NombreProveedor.Value = "NombreProveedor"
		addenda.Data.OrdenCompra.Value = "OrdenCompra"
		addenda.Data.NotaEntrega.Value = "NotaEntrega"
		addenda.Data.CondicionesPago.Value = "CondicionesPago"
		addenda.Data.TipoMoneda.Value = 1
		addenda.Data.Moneda.Value = "Moneda"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Landsteiner.xml", fileName)
	End Function

End Class