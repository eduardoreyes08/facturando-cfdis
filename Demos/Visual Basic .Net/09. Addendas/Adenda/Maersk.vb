Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Maersk
Imports HyperSoft.ElectronicDocumentLibrary.Maersk.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Maersk(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As New Maersk()

		Dim informacion As Informacion = addenda.Data.Addendas.Add()

		informacion.Retencion.Value = "Retencion"
		informacion.Brand.Value = "Brand"
		informacion.Vendor.Value = "Vendor"
		informacion.Buque.Value = "Buque"
		informacion.Viaje.Value = "Viaje"
		informacion.FechaZarpe.Value = DateTime.Now
		informacion.FechaAtraque.Value = DateTime.Now
		informacion.OrdenCompra.Value = "OrdenCompra"
		informacion.OrdenTrabajo.Value = "OrdenTrabajo"
		informacion.PoLine.Value = "PoLine"
		informacion.Cantidad.Value = 1
		informacion.ValorUnitario.Value = 2
		informacion.Requisition.Value = DateTime.Now
		informacion.ContainerNumber.Value = "ContainerNumber"
		informacion.MaterialDescription.Value = "MaterialDescription"
		informacion.MaterialNumber.Value = "MaterialNumber"
		informacion.OrderValue.Value = 3
		informacion.PorcentajeIva.Value = 4
		informacion.IvaImporte.Value = 5
		informacion.ImporteRetencion.Value = 6
		informacion.SemanaFacturar.Value = "SemanaFacturar"
		informacion.Comentartios.Value = "Comentartios"

		informacion = addenda.Data.Addendas.Add()
		informacion.Retencion.Value = "Retencion"
		informacion.Brand.Value = "Brand"
		informacion.Vendor.Value = "Vendor"
		informacion.Buque.Value = "Buque"
		informacion.Viaje.Value = "Viaje"
		informacion.FechaZarpe.Value = DateTime.Now
		informacion.FechaAtraque.Value = DateTime.Now
		informacion.OrdenCompra.Value = "OrdenCompra"
		informacion.OrdenTrabajo.Value = "OrdenTrabajo"
		informacion.PoLine.Value = "PoLine"
		informacion.Cantidad.Value = 1
		informacion.ValorUnitario.Value = 2
		informacion.Requisition.Value = DateTime.Now
		informacion.ContainerNumber.Value = "ContainerNumber"
		informacion.MaterialDescription.Value = "MaterialDescription"
		informacion.MaterialNumber.Value = "MaterialNumber"
		informacion.OrderValue.Value = 3
		informacion.PorcentajeIva.Value = 4
		informacion.IvaImporte.Value = 5
		informacion.ImporteRetencion.Value = 6
		informacion.SemanaFacturar.Value = "SemanaFacturar"
		informacion.Comentartios.Value = "Comentartios"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Maersk.xml", fileName)
	End Function

End Class