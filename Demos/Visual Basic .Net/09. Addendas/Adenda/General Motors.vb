Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.GeneralMotors.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function GeneralMotors(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As GeneralMotors = New HyperSoft.ElectronicDocumentLibrary.GeneralMotors.Addenda.GeneralMotors()

		addenda.Data.Header.NumeroRemision.Value = "0"
		addenda.Data.Header.FechaRecibo.Value = DateTime.Now
		addenda.Data.Header.FolioInterno.Value = "0"
		addenda.Data.Header.Moneda.Value = 1

		Dim item As Item = addenda.Data.Header.Items.Add()
		item.OrdenCompra.Value = "0"
		item.NumeroParte.Value = "0"
		item.Material.Value = 1
		item.Cantidad.Value = 2
		item.PrecioUnitario.Value = 1
		item.Descripcion.Value = "a"

		item = addenda.Data.Header.Items.Add()
		item.OrdenCompra.Value = "11"
		item.NumeroParte.Value = "11"
		item.Material.Value = 12
		item.Cantidad.Value = 23
		item.PrecioUnitario.Value = 14
		item.Descripcion.Value = "b"


		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_GeneralMotors.xml", fileName)
	End Function

End Class