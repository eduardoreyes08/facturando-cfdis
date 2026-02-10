Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Shared

Public Class MainForm

#Region "Constants"
  Private Const DataDirectory As String = "..\..\..\.."
#End Region

#Region "Vars"
  Private _generationDirectory As String
  Private _electronicDocument As ElectronicDocument
#End Region

#Region "Methods"

  Private Function Cfdi33(ByRef fileName As String) As Boolean
    fileName = Path.Combine(Me._generationDirectory, "CFDI33.xml")

    'En este método se cargan los datos de la factura.
    Data.Cfdi33.CargarDatosCompleto(Me._electronicDocument)

    ' Por default estan activas todas las opciones, si quisiera quitar alguna, que no se validara
    ' el vencimiento o revocación del certificado con el que se va a firma,
    ' se podria hacer esto:
    ' manage.Save.Options -= SaveOptions.ValidateWithFoliosAutorizados; //manage.Save.Options - [ValidateWithFA]
    ' A continuacion se muestran todas las opciones
    '    ValidateWithSchema,
    '    ValidateInformation,
    '    ValidateWithFoliosAutorizados,
    '    ValidateCertificateWithCA,
    '    ValidateCertificateWithCRL,
    '    AddCertificate,
    '    Sign;

    ' Se ejecuta el proceso de generación
    If Me._electronicDocument.SaveToFile(fileName) = False Then
      Gui.ShowError(Me._electronicDocument.ErrorText)
      Return False
    End If

    ' Para conocer como timbrar el CFDI 4.0, por favor, revisa el ejemplo PAC ECODEX

    Return True
  End Function

  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    ' Instanciamos la clase TManageElectronicDocument
    Dim manage As ElectronicManage = New ElectronicManage().Initialization()

    ' NOTA
    '  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
    '  . Para que se realice una validación FULL, debes activar las siguientes líneas
    '  . Si deseas conocer más al respecto:
    '       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
    'this.manage.Save.Options |= SaveOptions.ValidateWithSchema;
    'this.manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;

    ' Se cargan a memoria el archivo de autoridades certificadoras de prueba
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    manage.CertificateAuthorityList.UseForTest()

    'Se crea la clase que va a ser usada en el proceso de firmado
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

    ' Directorio donde van a ser almacenado los XML generados
    Me._generationDirectory = Utils.CreateDirectory()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "CFDI 3.3"

    ' -- Código para uso interno de este ejemplo
    Me.pgcInformacion.SelectedIndex = 0

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
    Dim fileName As String = Nothing
    Try
      Select Case Me.pgcInformacion.SelectedIndex
        Case 0
          generatedfile = Me.Cfdi33(fileName)
          Exit Select
        Case Else

          Throw New ArgumentOutOfRangeException()
      End Select
    Finally
      Me.lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()

      If generatedfile AndAlso Gui.ShowQuestion(String.Format("El CFDI fue generado con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)) Then
        Process.Start(fileName)
      End If
    End Try
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
    License.CargarLicencia()

    ' -- Código para uso interno de este ejemplo
    Me.ConfigurateControls()

    ' -- Muestra como crear los objetos requeridos para este ejemplos
    Me.CreateObjects()
  End Sub

#End Region

End Class