Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Shared
Imports System.IO
Imports HyperSoft.Ejemplo.Utilerias

Public Class MainForm

#Region "Constants"

  Private Const DataDirectory As String = "..\..\..\.."

#End Region

#Region "Vars"

  ' ReSharper disable InconsistentNaming
  Private generationDirectory As String
  Private electronicDocument As ElectronicDocument
  ' ReSharper restore InconsistentNaming

#End Region

#Region "Methods"

  Private Function GenerarTimbrar(ByRef fileName As String) As Boolean
    
    ' -= Ejemplo para AUTOTRANSPORTE
    fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_Autotransporte.xml")
    Data.Complemento.CartaPorte.Autotransporte.Timbrado(Me.electronicDocument)

    ' -= Ejemplo para TRANSPORTE AEREO
    'fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_TransporteAereo.xml")
    'Data.Complemento.CartaPorte.TransporteAereo.Timbrado(Me.electronicDocument)

    ' -= Ejemplo para TRANSPORTE FERROVIARIO
    'fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_TransporteFerroviario.xml")
    'Data.Complemento.CartaPorte.TransporteFerroviario.Timbrado(Me.electronicDocument)

    ' -= Ejemplo para TRANSPORTE MARITIMO
    'fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_TransporteMaritimo.xml")
    'Data.Complemento.CartaPorte.TransporteMaritimo.Timbrado(Me.electronicDocument)


    ' Se timbra la CARTA PORTE por medio de ECODEX
    If ECodex.Timbrar(Me.electronicDocument) = False Then
      Return False
    End If

    ' Se timbra la CARTA PORTE por medio de PAX
    'If Pax.Timbrar(Me.electronicDocument) = False Then
    '  Return False
    'End If
    
    Chronometer.Instance.[Stop]()

    ' Se guarda el documento, en este punto ya contiene los datos del timbre y la nomina
    If Me.electronicDocument.SaveToFile(fileName) = False Then
      Gui.ShowMessage(Me.electronicDocument.ErrorText)
      Return False
    End If

    Return True
  End Function

  Private Function GenerarXml(ByRef fileName As String) As Boolean

    ' -= Ejemplo que muestra como llenar TODOS los datos de una carta porte 3.1
    fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_Completo.xml")
    Data.Complemento.CartaPorte.Completo.CargarDatos(Me.electronicDocument)

    ' -= Ejemplo que muestra como llenar los datos MINIMOS de una carta porte 3.1
    'fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_Minimo.xml")
    'Data.Complemento.CartaPorte.Minimo.CargarDatos(Me.electronicDocument)

    ' -= Ejemplo que muestra como llenar los datos LISTAS de una carta porte 3.1
    'fileName = Path.Combine(Me.generationDirectory, "CartaPorte31_Listas.xml")
    'Data.Complemento.CartaPorte.Listas.CargarDatos(Me.electronicDocument)


    ' Se guarda el XML
    If Me.electronicDocument.SaveToFile(fileName) = False Then
      Gui.ShowMessage(Me.electronicDocument.ErrorText)
      Return False
    End If

    Chronometer.Instance.[Stop]()

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
    '  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del XML contra el schema
    '  . Para que se realice una validación FULL, debes activar las siguientes líneas
    '  . Si deseas conocer más al respecto:
    '       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
    'manage.Save.Options |= SaveOptions.ValidateWithSchema;
    'manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;


    ' Se cargan a memoria el archivo de autoridades certificadoras de prueba
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    manage.CertificateAuthorityList.UseForTest()


    'Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
    'la llave privada y el password de la misma.
    Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
    Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
    Dim password As String = "12345678a"
    Dim certificate as ElectronicCertificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

    ' Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
    ' y administrar TODOS los recursos que serán usados en el proceso
    manage.Save.AssignCertificate(certificate)

    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación y se le pasa
    ' el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me.electronicDocument = New ElectronicDocument().Initialization()
    Me.electronicDocument.AssignManage(manage)

    ' Directorio donde van a ser almacenado los XML generados
    Me.generationDirectory = Utils.CreateDirectory()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Carta Porte 3.1"

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Me.btnTimbrado, Me.btnHelp, Me.btnAbout, Me.btnClose)


    ' -- Código para uso interno de este ejemplo
    Dim description As String() = {My.Resources.Timbrar, My.Resources.GenerarXml}
    Utilerias.Gui.Shared.Description(Me.redtDescripcion, description, Me.cmbOperacion)

    ' -- Código para uso interno de este ejemplo
    Me.lblVersion.Text = ECodex.Version()

    ' -- Código para uso interno de este ejemplo
    Me.cmbOperacion.SelectedIndex = 0
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
      Select Case Me.cmbOperacion.SelectedIndex
        ' Se genera la carta porte y se timbra
        Case 0
          generatedfile = Me.GenerarTimbrar(fileName)
          Exit Select

        Case 1
          generatedfile = Me.GenerarXml(fileName)
          Exit Select

        Case Else
          Throw New ArgumentOutOfRangeException()
      End Select
    Finally
      Me.lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      If generatedfile AndAlso Gui.ShowQuestion(String.Format("La CARTA PORTE fue generada con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)) Then
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
  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
    ' -- Código para uso interno de este ejemplo
    License.CargarLicencia()

    ' -- Código para uso interno de este ejemplo
    Me.ConfigurateControls()

    ' -- Muestra como crear los objetos requeridos para este ejemplos
    Me.CreateObjects()
  End Sub

#End Region

End Class