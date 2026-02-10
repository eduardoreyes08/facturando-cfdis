Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.SectorPrimario.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function SectorPrimario(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As SectorPrimario = HyperSoft.ElectronicDocumentLibrary.SectorPrimario.Addenda.SectorPrimario.NewEntity()

		addenda.Data.Adquiriente.CertificateFile.Value = "ABC"
		addenda.Data.Adquiriente.KeyFile.Value = "DEF"
		addenda.Data.Adquiriente.Password.Value = "12345678a"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_SectorPrimario.xml", fileName)
	End Function

End Class