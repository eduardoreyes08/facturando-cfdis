Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.AltosHornosMexico.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function AltosHornosMexico(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As AltosHornosMexico = HyperSoft.ElectronicDocumentLibrary.AltosHornosMexico.Addenda.AltosHornosMexico.NewEntity()

		addenda.Data.Version.Value = "1.0"

		addenda.Data.Documento.Tipo.Value = "1"
		addenda.Data.Documento.Clase.Value = "Clase"

		addenda.Data.Documento.Encabezado.NumeroSociedad.Value = "NumeroSociedad"
		addenda.Data.Documento.Encabezado.NumeroDivision.Value = "NumeroDivision"
		addenda.Data.Documento.Encabezado.NumeroProveedor.Value = "NumeroProveedor"
		addenda.Data.Documento.Encabezado.Correo.Value = "Correo"
		addenda.Data.Documento.Encabezado.Moneda.Value = "MXP"

		Dim pedido As ElectronicDocumentLibrary.AltosHornosMexico.Addenda.Pedido = addenda.Data.Documento.Detalle.Pedidos.Add()
		pedido.Numero.Value = 1

		pedido.Recepciones.Add().Texto.Value = "Texto1"
		pedido.Recepciones.Add().Texto.Value = "Texto2"
		addenda.Data.Documento.Detalle.Pedidos.Add().Numero.Value = 2

		addenda.Data.Documento.Detalle.HojaServicio.Numero.Value = 3

		addenda.Data.Documento.Detalle.Transporte.Numero.Value = 4

		addenda.Data.Documento.Detalle.CuentaxPagar.Numero.Value = 5
		addenda.Data.Documento.Detalle.CuentaxPagar.Ejercicio.Value = 6

		addenda.Data.Documento.Detalle.Liquidacion.FechaInicio.Value = DateTime.Now
		addenda.Data.Documento.Detalle.Liquidacion.FechaFin.Value = DateTime.Now

		addenda.Data.Documento.Anexos.Add().Texto.Value = "Texto3"
		addenda.Data.Documento.Anexos.Add().Texto.Value = "Texto4"

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_AltosHornosMexico.xml", fileName)
	End Function

End Class