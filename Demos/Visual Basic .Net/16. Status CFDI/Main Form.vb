Imports System.Media
Imports System.Text
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Base
Imports HyperSoft.ElectronicDocumentLibrary.StatusCfdi
Imports HyperSoft.Shared

Public Class MainForm

#Region "Vars"

  Private _statusCfdi As ElectronicDocumentLibrary.StatusCfdi.StatusCfdi
  Private _sslValidator As SslValidator

#End Region

#Region "Methods"

  ''' <summary>
  ''' Método que permite consultar el STATUS de un CFDI en el SAT
  ''' </summary>
  Private Sub Consultar()
    ' Creamos el objeto de parametros y lo llenamos
    Dim parameters As New Parameters()
    parameters.RfcEmisor = Me.edtRfcEmisor.Text.Trim()
    parameters.RfcReceptor = Me.edtRfcReceptor.Text.Trim()
    parameters.Uuid = Me.edtUuid.Text.Trim()
    parameters.Total = Decimal.Parse(Me.edtTotal.Text.Trim())

    ' Con este parámetro evitamos que se validen los datos antes
    ' de hacer la consulta ante el SAT.
    ' Si estas seguro que la información es correcta, puedes aplicarlo
    'parameters.ValidBeforeExecute = false;

    Me._sslValidator.OverrideValidation()
    Dim result As ProcessProviderResult
    Dim information As ElectronicDocumentLibrary.StatusCfdi.Information
    Try
      ' Ejecutamos la consulta
      result = Me._statusCfdi.Execute(parameters, information)
    Finally
      Me._sslValidator.RestoreValidation()
    End Try


    Chronometer.Instance.[Stop]()

    ' Si todo es correcto mostramos el resultado
    If result = ProcessProviderResult.Ok Then
      Me.redtResult.Text = Me.ShowResult(information)
    Else
      ' Si se generó un error se muestra en pantalla
      Me.redtResult.Text = Me.ShowError(result, information.[Error])
    End If
  End Sub

  ''' <summary>
  ''' Método usado para mostrar el resultado de la consulta
  ''' </summary>
  ''' <param name="information"></param>
  ''' <returns></returns>
  Private Function ShowResult(information As ElectronicDocumentLibrary.StatusCfdi.Information) As String
    Dim sb As New StringBuilder()

    sb.AppendLine()
    sb.AppendLine("RESULTADO")
    sb.AppendLine("=================================================")

    Select Case information.Status
      Case SatStatusType.UnKnow
        sb.AppendLine("Status                : ")
        Exit Select
      Case SatStatusType.Active
        sb.AppendLine("Status                : Vigente")
        Exit Select
      Case SatStatusType.Canceled
        sb.AppendLine("Status                : Cancelado")
        Exit Select
      Case Else
        Throw New ArgumentOutOfRangeException()
    End Select

    Select Case information.FormaCancelacion
      Case FormaCancelacionType.UnKnow
        sb.AppendLine("Forma de cancelación  : ")
        Exit Select
      Case FormaCancelacionType.NoCancelable
        sb.AppendLine("Forma de cancelación  : No cancelable")
        Exit Select
      Case FormaCancelacionType.CancelableSinAceptacion
        sb.AppendLine("Forma de cancelación  : Cancelable sin aceptación")
        Exit Select
      Case FormaCancelacionType.CancelableConAceptacion
        sb.AppendLine("Forma de cancelación  : Cancelable con aceptación")
        Exit Select
      Case Else
        Throw New ArgumentOutOfRangeException()
    End Select


    Select Case information.StatusCancelacion
      Case StatusCancelacionType.UnKnow
        sb.AppendLine("Status de cancelación : ")
        Exit Select
      Case StatusCancelacionType.EnProceso
        sb.AppendLine("Status de cancelación : En proceso")
        Exit Select
      Case StatusCancelacionType.SolicitudRechazada
        sb.AppendLine("Status de cancelación : La solicitud fue rechazada")
        Exit Select
      Case StatusCancelacionType.CanceladoPlazoVencido
        sb.AppendLine("Status de cancelación : Cancelado por plazo vencido")
        Exit Select
      Case StatusCancelacionType.CanceladoConAceptacion
        sb.AppendLine("Status de cancelación : Cancelado con aceptación")
        Exit Select
      Case StatusCancelacionType.CanceladoSinAceptacion
        sb.AppendLine("Status de cancelación : Cancelado sin aceptación")
        Exit Select
      Case Else
        Throw New ArgumentOutOfRangeException()
    End Select

    Return sb.ToString()
  End Function

  ''' <summary>
  ''' Método usado para mostrar el error que se generó durante la consulta al SAT
  ''' </summary>
  ''' <param name="providerResult"></param>
  ''' <param name="error"></param>
  ''' <returns></returns>
  Private Function ShowError(providerResult As ProcessProviderResult, [error] As InformacionError) As String
    Dim sb As New StringBuilder()

    sb.AppendLine()
    sb.AppendLine("SE GENERO UN ERROR EN LA CONSULTA")
    sb.AppendLine("=================================================")

    Select Case providerResult
      Case ProcessProviderResult.ErrorInDocument
        sb.AppendLine("EL ERROR SE PRESENTO EN LOS PARAMETROS, ANTES DE CONSULTAR AL SAT")
        Exit Select
      Case ProcessProviderResult.ErrorWithProvider
        sb.AppendLine("EL ERROR FUE GENERADO POR EL SAT.")
        Exit Select
      Case ProcessProviderResult.ErrorInConnectionWithProvider
        sb.AppendLine("EL ERROR SE PRESENTO AL CONTACTAR EL SERVIDOR DEL SAT.")
        Exit Select
      Case Else
        Throw New ArgumentOutOfRangeException()
    End Select

    sb.AppendLine().AppendLine()
    sb.AppendLine("Códgio      : " + [error].Codigo)
    sb.AppendLine("Descripción : " + [error].Descripcion)

    If providerResult = ProcessProviderResult.ErrorWithProvider Then
      sb.AppendLine().AppendLine().AppendLine().AppendLine("-=-")
      sb.AppendLine("Cuando el CFDI no existe, el SAT puede regresar 2 tipos de errores:")
      sb.AppendLine("601 - La expresión impresa proporcionada no es válida.")
      sb.AppendLine("602 - Comprobante no encontrado.")
    End If

    Return sb.ToString()
  End Function

  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    Me._statusCfdi = New ElectronicDocumentLibrary.StatusCfdi.StatusCfdi()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' -- Código para uso interno de este ejemplo
    Gui.MessageBoxCaption = "Status de un CFDI en el SAT"

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Nothing, Me.btnHelp, Me.btnAbout, Me.btnClose)
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

    Try
      Me.Consultar()
    Finally
      Me.lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()
    End Try

  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me._sslValidator = New SslValidator()

    ' -- Código para uso interno de este ejemplo
    License.CargarLicencia()

    ' -- Código para uso interno de este ejemplo
    Me.ConfigurateControls()

    ' -- Muestra como crear los objetos requeridos para este ejemplos
    Me.CreateObjects()

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

#End Region

End Class