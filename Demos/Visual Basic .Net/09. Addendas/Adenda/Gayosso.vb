Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Gayosso.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Gayosso(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Gayosso = New HyperSoft.ElectronicDocumentLibrary.Gayosso.Addenda.Gayosso()

		addenda.Data.NumeroProveedor.Value = "0100002360"
		addenda.Data.Pedido.Value = "4500040562"
		addenda.Data.NumeroRecepcionMercancia.Value = "5000074500"
		addenda.Data.ImporteTotalRecepcionMercancia.Value = 0.13
		addenda.Data.Descuento.Value = 0.0
		addenda.Data.Subtotal.Value = 0.13
		addenda.Data.TotalFactura.Value = 15

		'ElectronicDocumentLibrary.Gayosso.Addenda.Impuesto impuesto = gayosso.Data.ImpuestosTrasladados.Add();
		'impuesto.Tipo.Value = "IVA";
		'impuesto.Base.Value = 0.13;
		'impuesto.Tasa.Value = 16;
		'impuesto.Total.Value = 0.02;

		Dim impuesto As Impuesto = addenda.Data.ImpuestosRetenidos.Add()
		impuesto.Tipo.Value = "ISR"
		impuesto.Base.Value = 0.14
		impuesto.Tasa.Value = 17
		impuesto.Total.Value = 0.03

		impuesto = addenda.Data.ImpuestosRetenidos.Add()
		impuesto.Tipo.Value = "IVA"
		impuesto.Base.Value = 0.18
		impuesto.Tasa.Value = 19
		impuesto.Total.Value = 0.21

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Gayoso.xml", fileName)
	End Function

End Class