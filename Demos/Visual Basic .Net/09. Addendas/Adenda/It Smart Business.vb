Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Itsb.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function ItSmartBusiness(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As ItSmartBusiness = New HyperSoft.ElectronicDocumentLibrary.Itsb.Addenda.ItSmartBusiness()

		addenda.Data.Itsb.Version.Value = "1.1"
		addenda.Data.Itsb.OrdenCompra.Value = "PO-0000000117"


		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_ItSmartBusiness.xml", fileName)
	End Function

End Class