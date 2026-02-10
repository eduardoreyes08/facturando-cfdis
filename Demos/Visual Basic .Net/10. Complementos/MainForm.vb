Imports System.ComponentModel
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Shared
Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Data.Complemento
Imports HyperSoft.Ejemplo.Utilerias

Public Class MainForm

#Region "Constants"
  Private Const SourceDirectory As String = "..\..\.."
  Private Const DataDirectory As String = "..\..\..\.."
#End Region

#Region "Vars"

  Private _message As String
  Private _generationDirectory As String
  Private _electronicDocument As ElectronicDocument


#End Region

#Region "Methods"

  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    Dim applicationDirectory As String = Application.StartupPath + SourceDirectory

    ' Instanciamos la clase TManageElectronicDocument
    Dim manage As ElectronicManage = New ElectronicManage().Initialization()

    '  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
    '  . Para que se realice una validación FULL, debes activar las siguientes líneas
    '  . Si deseas conocer más al respecto:
    '       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
    'manage.Save.Options |= SaveOptions.ValidateWithSchema;
    'manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;

    ' Se cargan a memoria el archivo de autoridades certificadoras de prueba
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    manage.CertificateAuthorityList.UseForTest()

    ' Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
    ' la llave privada y el password de la misma.
    Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
    Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
    Dim password As String = "12345678a"
    Dim certificate as ElectronicCertificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

    ' Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
    ' y administrar TODOS los recursos que serán usados en el proceso
    manage.Save.AssignCertificate(certificate)

    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación y se le pasa
    ' el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me._electronicDocument = New ElectronicDocument().Initialization()
    Me._electronicDocument.AssignManage(manage)

    ' Se crea el directorio donde van a ser almacenado los CFDI generados, esto no tiene que ver con la librería,
    ' solo es para mantener ordenados los archivos generados.
    Me._generationDirectory = Path.Combine(applicationDirectory, "Generados")
    If Directory.Exists(Me._generationDirectory) = False Then
      Try
        Directory.CreateDirectory(Me._generationDirectory)
      Catch
        Gui.ShowError(String.Format("No se pudo crear el directorio donde se van a almacenar los CFDI's.{0}{0}{1}", Environment.NewLine, Me._generationDirectory))
        Application.[Exit]()
      End Try
    End If

    Data.Complemento.Base.SetConfiguration(Me._generationDirectory)

    Me.lblTime.Text = String.Empty
    Me.lblVersion.Text = "E.D.L. - " + ElectronicDocument.Version()
    Gui.MessageBoxCaption = "Complementos"
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Complementos"

    ' -- Código para uso interno de este ejemplo
    Me._message = Me.redtText.Text
    Me.cmbComplemento.SelectedIndex = 4

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Me.btnTimbrado, Me.btnHelp, Me.btnAbout, Me.btnClose)
  End Sub

#End Region

#Region "Events"

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

    ' = Configuramos la interfaz del ejemplo ===========================
    Me.lblTime.Text = String.Empty
    Application.DoEvents()
    Chronometer.Instance.StartWithCursor()
    '===================================================================

    Dim generatedfile As Boolean = False

    Dim fileName As String = String.Empty
    Try
      Select Case Me.cmbComplemento.SelectedIndex
        Case 1
          generatedfile = Aerolineas10.Create(_electronicDocument, fileName)
          Exit Select

        Case 2
          generatedfile = CertificadoDestruccion10.Create(_electronicDocument, fileName)
          Exit Select

        Case 3
          generatedfile = RegistroFiscal10.Create(_electronicDocument, fileName)
          Exit Select

        Case 4
          generatedfile = ComercioExterior20.Completo(_electronicDocument, fileName)
          Exit Select

        Case 5
          generatedfile = ConsumoCombustibles11.Create(_electronicDocument, fileName)
          Exit Select

        Case 6
          generatedfile = SectorDeVentasAlDetalle131.Create(_electronicDocument, fileName)
          Exit Select

        Case 7
          generatedfile = Divisas10.Create(_electronicDocument, fileName)
          Exit Select

        Case 8
          generatedfile = Donatarias11.Create(_electronicDocument, fileName)
          Exit Select

        Case 9
          generatedfile = EstadoDeCuentaDeCombustible12.Create(_electronicDocument, fileName)
          Exit Select

        Case 10
          generatedfile = HidrocarburosGastos10.Create(_electronicDocument, fileName)
          Exit Select

        Case 11
          generatedfile = HidrocarburosIngresos10.Create(_electronicDocument, fileName)
          Exit Select

        Case 12
          generatedfile = ImpuestosLocales10.Create(_electronicDocument, fileName)
          Exit Select

        Case 13
          generatedfile = Ine11.Create(_electronicDocument, fileName)
          Exit Select

        Case 14
          generatedfile = LeyendasFiscales10.Create(_electronicDocument, fileName)
          Exit Select

        Case 15
          generatedfile = NotariosPublicos10.Create(_electronicDocument, fileName)
          Exit Select

        Case 16
          generatedfile = ObrasArtesAntiguedades10.Create(_electronicDocument, fileName)
          Exit Select

        Case 17
          generatedfile = PagoEnEspecie10.Create(_electronicDocument, fileName)
          Exit Select

        Case 18
          generatedfile = PersonaFisicaIntegranteCoordinado10.Create(_electronicDocument, fileName)
          Exit Select        

        Case 19
          generatedfile = RenovacionSustitucionVehiculos10.Create(_electronicDocument, fileName)
          Exit Select

        Case 20
          generatedfile = ServicioParcialConstruccion10.Create(_electronicDocument, fileName)
          Exit Select

        Case 21
          generatedfile = TuristaPasajeroExtranjero10.Create(_electronicDocument, fileName)
          Exit Select

        Case 22
          generatedfile = ValesDespensa10.Create(_electronicDocument, fileName)
          Exit Select

        Case 23
          generatedfile = VehiculoUsado10.Create(_electronicDocument, fileName)
          Exit Select

        Case 25
          generatedfile = InstitucionesEducativas10.Create(_electronicDocument, fileName)
          Exit Select

        Case 26
          generatedfile = VentaVehiculos11.Create(_electronicDocument, fileName)
          Exit Select
        Case Else

          Throw New InvalidEnumArgumentException()
      End Select
    Finally
      lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()

      If generatedfile AndAlso Gui.ShowQuestion("El documento fue generado con éxito." & vbLf & vbLf & "Desea visualizarlo ?") Then
        Process.Start(fileName)
      End If
    End Try

  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub cmbComplemento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComplemento.SelectedIndexChanged
    If (Me.cmbComplemento.SelectedIndex = 0) OrElse (Me.cmbComplemento.SelectedIndex = 24) Then
      Me.cmbComplemento.SelectedIndex += 1
    End If

    Dim texto As String = Me.cmbComplemento.Text.Trim().Trim("-"c).Trim()
    Me.redtText.Text = String.Format(Me._message, texto.ToUpperInvariant())

  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    IntegrationForm.ShowForm()

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.TimerLicenciaEnabled()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    ' -- Código para uso interno de este ejemplo
    Utilerias.License.CargarLicencia()

    ' -- Código para uso interno de este ejemplo
    Me.ConfigurateControls()

    ' -- Muestra como crear los objetos requeridos para este ejemplos
    Me.CreateObjects()
  End Sub

#End Region

End Class