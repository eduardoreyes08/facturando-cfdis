Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Gomsa.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Gomsa(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Gomsa = New Gomsa().Initialization()

		addenda.Data.Referencia.Value = "1"
		addenda.Data.Pedimento.Value = "2"
		addenda.Data.Patente.Value = "3"
		addenda.Data.GuiaContenedor.Value = "4"
		addenda.Data.Aduana.Value = "5"

		Dim i As Integer = 0
		While i < 2
			Dim concepto As Concepto = addenda.Data.Conceptos.Add()
			concepto.Descripcion.Value = "A"
			concepto.GuiaContenedor.Value = "B"
			i = i + 1
		End While

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_GOMSA.xml", fileName)
	End Function

End Class