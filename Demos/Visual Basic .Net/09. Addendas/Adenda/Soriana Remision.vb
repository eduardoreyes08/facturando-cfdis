Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Soriana.Remision.Addenda

Friend NotInheritable Partial Class Adenda

  Friend Shared Function SorianaRemision(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As CargaRemision = CargaRemision.NewEntity()

		Dim remision As Remision = addenda.Data.Remisiones.Add()
		remision.Id.Value = "1"
		remision.RowOrder.Value = "0"
		remision.Proveedor.Value = 1
		remision.NumeroRemision.Value = "AAAA-99999999999"
		remision.Consecutivo.Value = "0"
		remision.FechaRemision.Value = DateTime.Now
		remision.Tienda.Value = 1
		remision.TipoMoneda.Value = 1
		remision.TipoBulto.Value = 1
		remision.EntregaMercancia.Value = "EntregaMercancía"
		remision.CumpleRequisitosFiscales = True
		remision.CantidadBultos.Value = 1
		remision.SubTotal.Value = 2
		remision.Ieps.Value = 3
		remision.Iva.Value = 4
		remision.OtrosImpuestos.Value = 5
		remision.Total.Value = 6
		remision.CantidadPedidos.Value = 7
		remision.FechaEntregaMercancia.Value = DateTime.Now
		remision.Cita.Value = "B"
		remision.FolioNotaEntrada.Value = "A"

		Dim pedimento As Pedimento = addenda.Data.Pedimentos.Add()
		pedimento.Id.Value = "1"
		pedimento.RowOrder.Value = "0"
		pedimento.Proveedor.Value = 1
		pedimento.Remision.Value = "AAAA-99999999999"
		pedimento.NumeroPedimento.Value = 1
		pedimento.Aduana.Value = 1
		pedimento.AgenteAduanal.Value = 1
		pedimento.TipoPedimento.Value = ""
		pedimento.FechaPedimento.Value = DateTime.Now
		pedimento.FechaReciboLaredo.Value = DateTime.Now
		pedimento.FechaEmbarque.Value = DateTime.Now

		Dim pedido As Pedido = addenda.Data.Pedidos.Add()
		pedido.Id.Value = "1"
		pedido.RowOrder.Value = "0"
		pedido.Proveedor.Value = 1
		pedido.Remision.Value = "AAAA-99999999999"
		pedido.FolioPedido.Value = 1
		pedido.Tienda.Value = 2
		pedido.CantidadArticulos.Value = 3
		pedido.PedidoEmitidoProveedor.Value = "ABC"

		Dim articulo As Articulo = addenda.Data.Articulos.Add()
		articulo.Id.Value = "1"
		articulo.RowOrder.Value = "0"
		articulo.Proveedor.Value = 1
		articulo.Remision.Value = "AAAA-99999999999"
		articulo.FolioPedido.Value = 1
		articulo.Tienda.Value = 2
		articulo.Codigo.Value = 3
		articulo.CantidadUnidadCompra.Value = 4
		articulo.CostoNetoUnidadCompra.Value = 5
		articulo.PorcentajeIeps.Value = 6
		articulo.PorcentajeIva.Value = 7


		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_Soriana_Remision.xml", fileName)
	End Function

End Class