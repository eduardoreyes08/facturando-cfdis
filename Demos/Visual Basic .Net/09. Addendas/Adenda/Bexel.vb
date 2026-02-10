Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Bexel.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Bexel(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Bexel = HyperSoft.ElectronicDocumentLibrary.Bexel.Addenda.Bexel.NewEntity()

		addenda.Data.Version.Value = "1.0"
		addenda.Data.InformacionPago.LugarEntrega.Value = "Planta Guadalajara"
		addenda.Data.InformacionPago.NumeroRecepcion.Value = "REC1234567"
		addenda.Data.InformacionPago.OrdenCompra.Value = "OC1234567"
		addenda.Data.InformacionPago.CorreoElectronico.Value = "contacto1@proveedor.com; contacto2@proveedor.com"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Bexel.xml", fileName)
	End Function

End Class