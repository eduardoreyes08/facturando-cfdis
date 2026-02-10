Imports System
Imports System.IO
Imports System.Windows.Forms
Imports HyperSoft.ElectronicDocumentLibrary.Axxa.Addenda.Autos
Imports HyperSoft.ElectronicDocumentLibrary.Axxa.Addenda.GastosMedicos
Imports HyperSoft.ElectronicDocumentLibrary.Coppel.Addenda
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.EnvasesUniversalesMexico.Addenda
Imports HyperSoft.ElectronicDocumentLibrary.Soriana.Remision.Addenda
Imports HyperSoft.ElectronicDocumentLibrary.Soriana.Servicio.Addenda
Imports HyperSoft.Shared


Friend NotInheritable Partial Class Adenda
	#Region "Vars"

	Private Shared directorioSalida As String
	Private Shared electronicDocument As ElectronicDocument

	#End Region

	#Region "Methods"

	Friend Shared Sub SetConfiguration(directorio As String, electronic As ElectronicDocument)
		directorioSalida = directorio
		electronicDocument = electronic
	End Sub

	Private Shared Function Save(fileName As String, ByRef fullFileName As String) As Boolean
		Dim errorMessage As String
		fullFileName = Path.Combine(directorioSalida, fileName)

		If System.IO.File.Exists(fullFileName) Then
			[Shared].File.Instance.DeleteFile(fullFileName, errorMessage)
		End If


		Using stream As New MemoryStream()
			' Se ejecuta el proceso de generación
			If electronicDocument.SaveToStream(stream) = False Then
				errorMessage = String.Format("Se generó un error al crear el XML.{0}{0}ERROR{0}{1}", Environment.NewLine, electronicDocument.ErrorText)
				MessageBox.Show(errorMessage, "Adenda", MessageBoxButtons.OK, MessageBoxIcon.[Error])
				Return False
			End If

			Try
				System.IO.File.WriteAllBytes(fullFileName, stream.ToArray())
				Return True
			Catch e As Exception
				errorMessage = String.Format("Se generó un error al guardar el archivo XML.{0}{0}ARCHIVO{0}{1}{0}{0}ERROR{0}{2}", Environment.NewLine, fullFileName, e.Message)
				MessageBox.Show(errorMessage, "Adenda", MessageBoxButtons.OK, MessageBoxIcon.[Error])
				Return False
			End Try
		End Using
	End Function

	Friend Shared Function GetAddendaVersion(index As Integer) As String
	Using New WaitCursor()
		Select Case index
			Case 0
          Return ElectronicDocumentLibrary.Aba.Addenda.Aba.Version()
			Case 1
				Return ElectronicDocumentLibrary.Ado.Addenda.Ado.Version()
			Case 2
				Return ElectronicDocumentLibrary.AlSuper.Addenda.AlSuper.Version()
			Case 3
				Return ElectronicDocumentLibrary.AltosHornosMexico.Addenda.AltosHornosMexico.Version()
			Case 4
				Return ElectronicDocumentLibrary.Aluprint.Addenda.Aluprint.Version()
			Case 5
				Return ElectronicDocumentLibrary.Amece.Addenda.Amece.Version()
			Case 6
				Return ElectronicDocumentLibrary.Amis.Addenda.Amis.Version()
			Case 7
				Return ElectronicDocumentLibrary.Asofarma.Asonioscoc.Addenda.Asonioscoc.Version()
			Case 8
				Return Autos.Version()
			Case 9
				Return GastosMedicos.Version()
			Case 10
				Return ElectronicDocumentLibrary.Bbva.Addenda.Bbva.Version
			Case 11
				Return ElectronicDocumentLibrary.Bexel.Addenda.Bexel.Version()
			Case 12
				Return ElectronicDocumentLibrary.BrudiFarma.Addenda.BrudiFarma.Version()
			Case 13
				Return ElectronicDocumentLibrary.CapaOzono.Addenda.CapaOzono.Version()
			Case 14
				Return ElectronicDocumentLibrary.Chrysler.Addenda.Chrysler.Version()
			Case 15
				Return ElectronicDocumentLibrary.Comex.Addenda.Comex.Version()
			Case 16
				Return ElectronicDocumentLibrary.ContinentalTire.Addenda.ContinentalTire.Version()
			Case 17
				Return Coppel.Version()
			Case 18
				Return ElectronicDocumentLibrary.CorporateTravelServices.Addenda.CorporateTravelServices.Version()
			Case 19
				Return ElectronicDocumentLibrary.Disney.Addenda.Disney.Version()
			Case 20
				Return ElectronicDocumentLibrary.Elektra.Addenda.Elektra.Version()
			Case 21
				Return ElectronicDocumentLibrary.Emerson.Addenda.Emerson.Version()
			Case 22
				Return ElectronicDocumentLibrary.Emsur.Addenda.EmSur.Version()
			Case 23
				Return EnvasesUniversalesMexico.Version()
			Case 24
				Return ElectronicDocumentLibrary.Femsa.Addenda.Femsa.Version()
			Case 25
				Return ElectronicDocumentLibrary.FerroMexicana.Addenda.FerroMexicana.Version()
			Case 26
				Return ElectronicDocumentLibrary.Fuller.Addenda.Fuller.Version()
			Case 27
				Return ElectronicDocumentLibrary.Gayosso.Addenda.Gayosso.Version()
			Case 28
				Return ElectronicDocumentLibrary.GeneralMotors.Addenda.GeneralMotors.Version()
			Case 29
				Return ElectronicDocumentLibrary.Gomsa.Addenda.Gomsa.Version
			Case 30
				Return ElectronicDocumentLibrary.GrupoModelo.Addenda.GrupoModelo.Version()
			Case 31
				Return ElectronicDocumentLibrary.Heb.Addenda.Heb.Version()
			Case 32
				Return ElectronicDocumentLibrary.Inbursa.Addenda.Inbursa.Version()
			Case 33
				Return ElectronicDocumentLibrary.Itsb.Addenda.ItSmartBusiness.Version()
			Case 34
				Return ElectronicDocumentLibrary.Iusacell.Addenda.Iusacell.Version()
			Case 35
				Return ElectronicDocumentLibrary.Kuehne.Addenda.Kuehne.Version()
			Case 36
				Return ElectronicDocumentLibrary.Lamosa.Addenda.Lamosa.Version()
			Case 37
				Return ElectronicDocumentLibrary.Landsteiner.Addenda.Landsteiner.Version()
			Case 38
				Return ElectronicDocumentLibrary.Loreal.Addenda.Loreal.Version()
			Case 39
				Return ElectronicDocumentLibrary.Lowes.Addenda.Lowes.Version()
			Case 40
				Return ElectronicDocumentLibrary.Mabe.Addenda.Mabe.Version()
			Case 41
				Return ElectronicDocumentLibrary.Maersk.Addenda.Maersk.Version()
			Case 42
				Return ElectronicDocumentLibrary.MultiPack.Addenda.MultiPack.Version()
			Case 43
				Return ElectronicDocumentLibrary.Oxxo.Addenda.Oxxo.Version()
			Case 44
				Return ElectronicDocumentLibrary.Pemex.Addenda.PemexExploracion.Version()
			Case 45
				Return ElectronicDocumentLibrary.Pemex.Addenda.PemexExploracion.Version()
			Case 46
				Return ElectronicDocumentLibrary.Pepsico.Addenda.Pepsico.Version()
			Case 47
				Return ElectronicDocumentLibrary.Pilgrims.Addenda.Pilgrims.Version()
			Case 48
				Return ElectronicDocumentLibrary.Prolec.Addenda.Prolec.Version()
			Case 49
				Return ElectronicDocumentLibrary.Sanmina.Addenda.Sanmina.Version()
			Case 50
				Return ElectronicDocumentLibrary.Santander.Addenda.Santander.Version()
			Case 51
				Return ElectronicDocumentLibrary.SectorPrimario.Addenda.SectorPrimario.Version()
			Case 52
				Return ElectronicDocumentLibrary.SevenEleven.Addenda.SevenEleven.Version()
			Case 53
				Return ElectronicDocumentLibrary.SolerPalau.Addenda.SolerPalau.Version()
			Case 54
				Return CargaRemision.Version()
			Case 55
				Return Servicio.Version()
			Case 56
				Return ElectronicDocumentLibrary.TiendasNeto.Addenda.TiendasNeto.Version()
			Case 57
				Return ElectronicDocumentLibrary.TransportesCastores.Addenda.TransportesCastores.Version()
			Case 58
				Return ElectronicDocumentLibrary.TresM.Addenda.TresM.Version
			Case 59
				Return ElectronicDocumentLibrary.TvAzteca.Addenda.TvAzteca.Version()
			Case 60
				Return ElectronicDocumentLibrary.Viscofan.Addenda.Viscofan.Version
			Case 61
				Return ElectronicDocumentLibrary.Volkswagen.Addenda.Volkswagen.Version()
			Case 62
				Return ElectronicDocumentLibrary.WalMart.Addenda.WalMart.Version
			Case 63
				Return ElectronicDocumentLibrary.ZfMexico.Addenda.ZfMexico.Version()
		End Select

		Return String.Empty
	End Using
End Function

  #End Region
End Class