Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Viscofan.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Viscofan(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Viscofan = New Viscofan().Initialization()

		addenda.Data.OrdenCompra.Value = 1
		addenda.Data.NumeroAcreedor.Value = 2
		addenda.Data.PlantaEntrega.Value = "3"
		addenda.Data.NumeroLineaArticulo.Value = "4"
		addenda.Data.CorreoElectronico.Value = "5"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_VISCOFAN.xml", fileName)
	End Function

End Class