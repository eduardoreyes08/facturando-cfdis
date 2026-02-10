Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Aba.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function Aba(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Aba = HyperSoft.ElectronicDocumentLibrary.Aba.Addenda.Aba.NewEntity()

		addenda.Data.Encabezado.Area.Value = 1
		addenda.Data.Encabezado.SubArea.Value = 2

		addenda.Data.Detalle.OrdenCompra.Value = "OrdenCompra"
		addenda.Data.Detalle.Siniestro.Value = "Siniestro"
		addenda.Data.Detalle.BienAfectado.Value = 3
		addenda.Data.Detalle.Mes.Value = 4
		addenda.Data.Detalle.Anio.Value = 2014
		addenda.Data.Detalle.CorreoElectronico.Value = "a@a.com"
		addenda.Data.Detalle.Referencia1.Value = "Referencia1"
		addenda.Data.Detalle.Referencia2.Value = "Referencia2"
		addenda.Data.Detalle.Referencia3.Value = "Referencia3"
		addenda.Data.Detalle.Referencia4.Value = "Referencia4"
		addenda.Data.Detalle.Referencia5.Value = "Referencia5"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Aba.xml", fileName)
	End Function
End Class