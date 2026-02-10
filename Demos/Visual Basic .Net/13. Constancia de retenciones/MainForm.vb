Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Shared


Public Class MainForm

#Region "Constants"

  Private Const DataDirectory As String = "..\..\..\.."

#End Region

#Region "Vars"

  Private _generationDirectory As String
  Private _constanciaRetenciones As ElectronicDocumentLibrary.ConstanciaRetenciones.ConstanciaRetenciones
  Private _message As String

#End Region

#Region "Methods"

  Private Function ConstanciaRetenciones(ByRef fileName As String) As Boolean
    'En este método se cargan los datos de la constancia.
    ConstanciaRetenciones20.CargarDatosCompleto(Me._constanciaRetenciones)

    ' Se ejecuta el proceso de generación
    fileName = Path.Combine(Me._generationDirectory, "Constancia_Retenciones_20.xml")
    If Me._constanciaRetenciones.SaveToFile(fileName) = False Then
      Gui.ShowError(Me._constanciaRetenciones.ErrorText)
      Return False
    End If

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
    Me._constanciaRetenciones = New ElectronicDocumentLibrary.ConstanciaRetenciones.ConstanciaRetenciones().Initialization()
    Me._constanciaRetenciones.AssignManage(manage)

    ' Directorio donde van a ser almacenado los XML generados
    Me._generationDirectory = Utils.CreateDirectory()
    Data.Complemento.Constancias.Base.SetConfiguration(Me._generationDirectory)
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Constancia de retenciones 2.0"

    ' -- Código para uso interno de este ejemplo
    Me.pgcDocumento.SuspendLayout()
    While Me.pgcDocumento.TabPages.Count > 0
      Me.pgcDocumento.TabPages.RemoveAt(0)
    End While
    Me.pgcDocumento.ResumeLayout()

    Me._message = Me.redtComplemento.Text
    Me.cmbTipo.SelectedIndex = 0

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

    Dim generatedfile = False

    Dim fileName As String = String.Empty
    Try
      Select Case Me.cmbTipo.SelectedIndex
        Case 0
          generatedfile = Me.ConstanciaRetenciones(fileName)
          Exit Select

        Case 1
          generatedfile = Complemento.Constancias.ArrendamientoEnFideicomiso.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 2
          generatedfile = Complemento.Constancias.Dividendos.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 3
          generatedfile = Complemento.Constancias.EnajenacionAcciones.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 4
          generatedfile = Complemento.Constancias.FideicomisoNoEmpresarial.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 5
          generatedfile = Complemento.Constancias.Intereses.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 6
          generatedfile = Complemento.Constancias.InteresesHipotecarios.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 7
          generatedfile = Complemento.Constancias.OperacionesConDerivados.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 8
          generatedfile = Complemento.Constancias.PagosAExtranjeros.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 9
          generatedfile = Complemento.Constancias.PlanesRetiro.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 10
          generatedfile = Complemento.Constancias.PlataformasTecnologicas.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 11
          generatedfile = Complemento.Constancias.Premios.Create(Me._constanciaRetenciones, fileName)
          Exit Select

        Case 12
          generatedfile = Complemento.Constancias.SectorFinanciero.Create(Me._constanciaRetenciones, fileName)
          Exit Select
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
  Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
    pgcDocumento.SuspendLayout()
    Try
      If pgcDocumento.TabPages.Count > 0 Then
        pgcDocumento.TabPages.RemoveAt(0)
      End If

      If Me.cmbTipo.SelectedIndex = 0 Then
        pgcDocumento.TabPages.Add(Me.tshConstancia)
        Return
      End If

      pgcDocumento.TabPages.Add(Me.tshComplemento)
      Dim text1 As String = Me.cmbTipo.Text.Trim().Trim("-").Trim()
      Me.redtComplemento.Text = String.Format(Me._message, text1.ToUpperInvariant())
    Finally
      pgcDocumento.ResumeLayout()
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