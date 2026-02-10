Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.ElectronicDocumentLibrary.Bbva.Addenda

Friend NotInheritable Partial Class Adenda
	
	Friend Shared Function Bbva(ByRef fileName As String) As Boolean
		'En este método se cargan los datos de la factura.
		Cfdi40.CargarDatosCompleto(electronicDocument)

		Dim addenda As Bbva = New Bbva().Initialization()

		addenda.Data.Version.Value = "1"
		addenda.Data.Tipo.Value = "2"
		addenda.Data.Proveedor.Value = "3"
		addenda.Data.Siniestro.Value = "4"
		addenda.Data.SubTotal.Value = 5
		addenda.Data.Iva.Value = 6
		addenda.Data.IvaRetenido.Value = 7
		addenda.Data.IseRetenido.Value = 8
		addenda.Data.ImpuestoCedular.Value = 9
		addenda.Data.Total.Value = 10
		addenda.Data.Retencion.Value = 11
		addenda.Data.OrdenPago.Value = "12"

		addenda.Data.Cristales.Deducible.Value = 13
		addenda.Data.Cristales.CodigoNags.Value = "14"

		Dim i As Integer = 0
		While i < 2
			Dim servicio As HonorarioServicio = addenda.Data.Honorarios.Servicios.Add()
			servicio.OrdenPagoHonorarios.Value = 1
			servicio.Costo.Value = 2
			i = i + 1
		End While

    i = 0
		While i < 3
			Dim servicio As GruaServicio = addenda.Data.Gruas.Servicios.Add()
			servicio.NumeroServicio.Value = 1
			servicio.Costo.Value = 2
			i = i + 1
		End While

    i = 0
		While i < 4
			Dim servicio As AsistenciaServicio = addenda.Data.Asistencia.Servicios.Add()
			servicio.NumeroServicio.Value = 1
			servicio.Costo.Value = 2
			i = i + 1
		End While

		addenda.Data.Reparaciones.NumeroValuacionInicial.Value = "15"
		addenda.Data.Reparaciones.Costo.Value = 16

    i = 0
		While i < 2
			Dim vale As ValeRefacciones = addenda.Data.Reparaciones.ValesRefacciones.Add()
			vale.Numero.Value = "1"
			vale.Costo.Value = 2
			i = i + 1
		End While

		i = 0
		While i < 3
			Dim vale As ValeComplemento = addenda.Data.Reparaciones.ValesComplemento.Add()
			vale.Numero.Value = "1"
			vale.Costo.Value = 2
			i = i + 1
		End While

		addenda.Data.GastosMedicos.PaseMedico.Value = "17"
		addenda.Data.GastosMedicos.Costo.Value = 18

		electronicDocument.Data.Addendas.Add(addenda)

		Return Save("Addenda_BBVA.xml", fileName)
	End Function
End Class