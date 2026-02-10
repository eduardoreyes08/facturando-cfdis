Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Inbursa.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Inbursa(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Inbursa = HyperSoft.ElectronicDocumentLibrary.Inbursa.Addenda.Inbursa.NewEntity()

		addenda.Data.ReferenciaReceptor.Siniestro.Emisor.Value = "22701"
		addenda.Data.ReferenciaReceptor.Siniestro.Numero.Value = "7000116"
		addenda.Data.ReferenciaReceptor.Siniestro.Afectado.Value = "A"

		addenda.Data.ReferenciaReceptor.Deducible.Importe.Value = 1
		addenda.Data.ReferenciaReceptor.Descuento.Importe.Value = 2
		addenda.Data.ReferenciaReceptor.TotalManoObra.Importe.Value = 3
		addenda.Data.ReferenciaReceptor.TotalRefacciones.Importe.Value = 4

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Inbursa.xml", fileName)
	End Function

End Class