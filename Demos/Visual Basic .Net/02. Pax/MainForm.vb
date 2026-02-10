Imports System.Globalization
Imports HyperSoft.ElectronicDocumentLibrary.Base
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Pax
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.ElectronicDocumentLibrary.Pax.Timbrado.Resultado
Imports HyperSoft.Shared
Imports System.Text
Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones

Public Class MainForm

#Region "Constants"

  Private Const DataDirectory As String = "..\..\..\.."

#End Region

#Region "Vars"

' ReSharper disable InconsistentNaming
  Private pages As TabPage()

  Private _generationDirectory As String
  Private _manage As ElectronicManage
  Private _certificate As ElectronicCertificate
  Private _electronicDocument As ElectronicDocument
  Private _constanciaRetenciones As ConstanciaRetenciones
  Private _proveedor As Proveedor
  ' ReSharper restore InconsistentNaming


#End Region

#Region "Methods"

  Private Function TimbrarCfdi(ByRef fileName As String) As Boolean

    fileName = Path.Combine(_generationDirectory, "CFDI1.xml")

    Dim parameters As TimbrarParameters = New TimbrarParameters().Initialization()

    Try
      ' - En este método se cargan los datos de la FACTURA
      Cfdi40.CargarDatosTimbrado(Me._electronicDocument)
      fileName = Path.Combine(Me._generationDirectory, "CFDI40.xml")

      ' - En este método se cargan los datos de un RECIBO DE PAGO 2.0
      ' Data.Complemento.ReciboPago20.CargarDatosTimbrado(this.electronicDocument);
      ' fileName = Path.Combine(this.generationDirectory, "recibo_pago_20.xml");

      ' - En este método se cargan los datos de un RECIBO DE NÓMINA 1.2
      ' Data.Complemento.Nomina12.CargarDatosCfdi40Timbrado(this.electronicDocument);
      ' fileName = Path.Combine(this.generationDirectory, "recibo_nomina_12.xml");

      ' - En este método se cargan los datos de una CARTA PORTE 2.0
      ' Data.Complemento.CartaPorte.Timbrado.CargarDatos(this.electronicDocument);
      ' fileName = Path.Combine(this.generationDirectory, "carta_porte_20.xml");

      ContribuyentePax(Me._electronicDocument)


      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As Informacion = New Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.Usuario.Value = Me.txtUsuario.Text
      parameters.Password.Value = Me.txtPassword.Text
      parameters.Identificador.Value = Me.txtIdentificador.Text
      parameters.ElectronicDocument = _electronicDocument
      parameters.TipoDocumento = DocumentType.Factura
      parameters.TestMode = Me.chkPrueba.Checked
      parameters.Informacion = informacion

      ' Se envia a timbrar el documento
      Dim result As ProcessProviderResult = Me._proveedor.TimbrarCfdi(parameters)

      Chronometer.Instance.Stop()

      ' En este caso se verifica que el proceso fue correcto
      If result = ProcessProviderResult.Ok Then
        '
      End If

      ' Se le da formato a la información retornada por el PAC
      Dim resultadoTexto As String = FormatInformationTimbre(informacion, result, _electronicDocument.FingerPrintPac)

      ' Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Timbrado CFDI", resultadoTexto)

      If result <> ProcessProviderResult.Ok Then
        Return False
      End If

      ' Se guarda el documento, en este punto ya contiene los datos del timbre
      Dim options As SaveOptions = _electronicDocument.Manage.Save.Options
      _electronicDocument.Manage.Save.Options = SaveOptions.EncodeApostrophe
      Try
        _electronicDocument.SaveToFile(fileName)
      Catch
        Gui.ShowError(_electronicDocument.ErrorText)
        Return False
      Finally
        _electronicDocument.Manage.Save.Options = options
      End Try
      Return True
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Function

  Private Sub ContribuyentePax(electronicDocument As ElectronicDocument)
    electronicDocument.Data.Emisor.Rfc.Value = "AAA010101AAA"
    electronicDocument.Data.Emisor.Nombre.Value = "INDISTRIA ILUMINADORA DE ALMACENES SA DE CV"
    electronicDocument.Data.Emisor.RegimenFiscal.Value = "601"
  End Sub

  Private Function TimbrarConstanciaRetenciones(ByRef fileName As String) As Boolean

    fileName = Path.Combine(_generationDirectory, "Constancia_Retenciones_20.xml")

    Dim parameters As TimbrarConstanciaRetencionesParameters = New TimbrarConstanciaRetencionesParameters().Initialization()

    Try
      'En este método se cargan los datos de la factura.
      ConstanciaRetenciones20.CargarDatosTimbrado(Me._constanciaRetenciones)

      Me._constanciaRetenciones.Data.Emisor.Rfc.Value = "AAA010101AAA"
      Me._constanciaRetenciones.Data.Emisor.RazonSocial.Value = "INDISTRIA ILUMINADORA DE ALMACENES SA DE CV"
      Me._constanciaRetenciones.Data.Emisor.RegimenFiscal.Value = "601"

      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As Informacion = New Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.Usuario.Value = Me.txtUsuario.Text
      parameters.Password.Value = Me.txtPassword.Text
      parameters.Identificador.Value = Me.txtIdentificador.Text
      parameters.ConstanciaRetenciones = _constanciaRetenciones
      parameters.TipoConstancia = 1
      parameters.TestMode = Me.chkPrueba.Checked
      parameters.Informacion = informacion

      ' Se envia a timbrar el documento
      Dim result As ProcessProviderResult = Me._proveedor.TimbrarConstanciaRetenciones(parameters)

      Chronometer.Instance.Stop()

      ' En este caso se verifica que el proceso fue correcto
      If result = ProcessProviderResult.Ok Then
        '
      End If

      ' Se le da formato a la información retornada por el PAC
      Dim resultadoTexto As String = FormatInformationTimbre(informacion, result, _constanciaRetenciones.FingerPrintPac)

      ' Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Timbrado de una CONSTANCIA DE RETENCIONES", resultadoTexto)

      If result <> ProcessProviderResult.Ok Then
        Return False
      End If

      ' Se guarda el documento, en este punto ya contiene los datos del timbre
      Dim options As SaveOptions = _constanciaRetenciones.Manage.Save.Options
      _constanciaRetenciones.Manage.Save.Options = SaveOptions.EncodeApostrophe
      Try
        _constanciaRetenciones.SaveToFile(fileName)
      Catch
        Gui.ShowError(_constanciaRetenciones.ErrorText)
        Return False
      Finally
        _constanciaRetenciones.Manage.Save.Options = options
      End Try
      Return True
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Function

  Private Sub CancelarCfdi(constanciaRetenciones As Boolean)
    Dim parameters As CancelarParameters = New CancelarParameters().Initialization()
    Try
      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As Cancelar.Informacion = New Cancelar.Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.Usuario.Value = Me.txtUsuario.Text
      parameters.Password.Value = Me.txtPassword.Text
      parameters.Identificador.Value = Me.txtIdentificador.Text
      parameters.TestMode = Me.chkPrueba.Checked
      parameters.Informacion = informacion
      parameters.ConstanciaRetenciones = constanciaRetenciones

      parameters.RfcEmisor.Value = "AAA010101AAA"
      parameters.RfcReceptor.Add("AAA010101AAA")
      parameters.Uuid.Add("dbfd9f2f-1b75-4e07-a865-082d0dbc7712")
      parameters.Total.Add(New Decimal(10.77))
      parameters.Motivo.Add("02")

      ' En caso de no existir folio de sustitución, se tiene que agregar vacío
      parameters.FolioSustitucion.Add("")


      ' Se envia a cancelar el documento
      Dim result As ProcessProviderResult = Me._proveedor.CancelarCfdi(parameters)

      Chronometer.Instance.Stop()

      ' Se le da formato a la información retornada por el PAC
      Dim texto As String = FormatInformationCancelacion(informacion, result)

      ' Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Cancelar CFDI", texto)
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Sub

  Private Sub ObtenerFechaHora()
    ' Se crea el objeto que contiene la información retornada por el PAC
    Dim informacion As FechaHora.Informacion = New FechaHora.Informacion().Initialization()

    ' Se obtiene la hora y fecha que tiene el servidor de timbrado del PAC
    Dim result As ProcessProviderResult = Me._proveedor.FechaHora(informacion)

    Chronometer.Instance.Stop()

    ' Se le da formato a la información retornada por el PAC
    Dim texto As String = Me.FormatInformationFechaHora(informacion, result)

    ' Se muestra en pantalla el resultado del proceso
    ResultForm.ShowResult("Hora y Fecha del PAC", texto)
  End Sub

  Private Function FormatInformationTimbre(informacion As Informacion, providerResult As ProcessProviderResult, cadenaOriginal As String) As String
    Dim builder As New StringBuilder()

    If informacion.Timbre.IsAssigned Then
      builder.AppendLine(String.Empty)
      builder.AppendLine("INFORMACION DEL TIMBRE")
      builder.AppendLine("=================================================")
      builder.AppendLine("Versión                       : " + informacion.Timbre.Version.AsString())
      builder.AppendLine("UUID                          : " + informacion.Timbre.Uuid.AsString())
      builder.AppendLine("Fecha de timbrado             : " + informacion.Timbre.FechaTimbrado.AsString())
      builder.AppendLine("Sello del CFD                 : " + informacion.Timbre.SelloCfd.AsString())
      builder.AppendLine("Número de Certificado del SAT : " + informacion.Timbre.NumeroCertificadoSat.AsString())
      builder.AppendLine("Sello del SAT                 : " + informacion.Timbre.SelloSat.AsString())
      builder.AppendLine("Leyenda                       : " + informacion.Timbre.Leyenda.AsString())
      builder.AppendLine("RFC del PAC                   : " + informacion.Timbre.RfcProveedorCertificacion.AsString())
      builder.AppendLine()
      builder.AppendLine("CADENA ORIGINAL DEL COMPLEMENTO")
      builder.AppendLine("==============================================")
      builder.AppendLine("Cadena original    : " + cadenaOriginal)
    End If

    If Not informacion.Error.IsAssigned Then
      Return builder.ToString()
    End If

    FormatTypeError(builder, providerResult)

    builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    builder.AppendLine("=================================================")
    builder.AppendLine("Número      : " + informacion.Error.Numero.Value.ToString())
    builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return builder.ToString()
  End Function

  Private Shared Function FormatInformationCancelacion(informacion As Cancelar.Informacion, providerResult As ProcessProviderResult) As String
    Dim text As New StringBuilder()

    If informacion.Folios.Count > 0 Then
      text.AppendLine("FOLIOS")
      text.AppendLine("=================================================")

      Dim i As Integer = 0
      While i < informacion.Folios.Count
        text.AppendLine("UUID        : " + informacion.Folios(i).Uuid.Value)
        text.AppendLine("Status      : " + informacion.Folios(i).Status.Value.ToString())
        text.AppendLine("Descripción : " + informacion.Folios(i).Description.Value)
        text.AppendLine("Fecha       : " + informacion.Folios(i).Fecha.Value)

        If (informacion.Folios(i).Status.Value = 201) OrElse (informacion.Folios(i).Status.Value = 202) Then
          text.AppendLine("CANCELADO")
        End If

        text.AppendLine()
        i = i + 1
      End While
    End If


    If Not informacion.Error.IsAssigned Then
      Return text.ToString()
    End If

    FormatTypeError(text, providerResult)

    text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    text.AppendLine("=================================================")
    text.AppendLine("Número      : " + informacion.Error.Numero.Value.ToString())
    text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return text.ToString()
  End Function

  Private Function FormatInformationFechaHora(informacion As FechaHora.Informacion, providerResult As ProcessProviderResult) As String
    Dim builder As New StringBuilder()

    If informacion.FechaHora.IsAssigned Then
      builder.Append("Fecha y Hora en el PAC : ").AppendLine(informacion.FechaHora.Value.ToString(CultureInfo.CurrentCulture)).Append("Fecha y Hora actual    : ").AppendLine(DateTime.Now.ToString(CultureInfo.CurrentCulture)).Append("Diferencia             : ").Append(DateTime.Now - informacion.FechaHora.Value)
    End If

    If Not informacion.Error.IsAssigned Then
      Return builder.ToString()
    End If

    FormatTypeError(builder, providerResult)

    builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    builder.AppendLine("=================================================")
    builder.AppendLine("Número      : " + informacion.Error.Numero.Value.ToString())
    builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return builder.ToString()
  End Function

  Private Shared Sub FormatTypeError(text As StringBuilder, providerResult As ProcessProviderResult)
    If providerResult = ProcessProviderResult.Ok Then
      Return
    End If

    text.AppendLine()
    text.AppendLine()
    text.AppendLine("=================================================")
    Select Case providerResult
      Case ProcessProviderResult.ErrorInDocument
        text.AppendLine("EL ERROR SE PRESENTO AL GENERAR LOS PARAMETROS,")
        text.AppendLine("ANTES DE EJECUTAR LA OPERACION CON EL PAC.")
        Exit Select
      Case ProcessProviderResult.ErrorWithProvider
        text.AppendLine("EL ERROR FUE GENERADO POR EL PAC.")
        Exit Select
      Case Else
        Throw New ArgumentOutOfRangeException()
    End Select
    text.AppendLine("=================================================")
    text.AppendLine()
    text.AppendLine()
  End Sub

  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    ' Se crea el objeto que representa al PAC y para este ejemplo lo he configurado 
    ' con los parámetros de prueba de la conexión. Para mayor información acerca de 
    ' lo relación con el PAC póngase en contacto con el mismo.
    Me._proveedor = New Proveedor().Initialization()

    ' Instanciamos la clase TManageElectronicDocument
    Me._manage = New ElectronicManage().Initialization()


    ' NOTA
    '  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
    '  . Para que se realice una validación FULL, debes activar las siguientes líneas
    '  . Si deseas conocer más al respecto:
    '       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
    'this.manage.Save.Options |= SaveOptions.ValidateWithSchema;
    'this.manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;


    ' Se cargan a memoria el archivo de autoridades certificadoras de prueba
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    Me._manage.CertificateAuthorityList.UseForTest()

    ' Con esta línea evitamos usar el archivo CSD.txt que emite el SAT
    Me._manage.Save.Options -= SaveOptions.ValidateCertificateWithCrl

    ' Esta línea es requerida para el ambiente de pruebas porque se esta usando el RFC AAA010101AAA
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    Me._manage.Save.Options -= SaveOptions.ValidateCertificateSubject



    'Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
    'la llave privada y el password de la misma.
    Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
    Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
    Dim password As String = "12345678a"
    Me._certificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

    ' Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
    ' y administrar TODOS los recursos que serán usados en el proceso
    Me._manage.Save.AssignCertificate(Me._certificate)

    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación de la FACTURA ELECTRONICA (CFDI)
    ' y se le pasa el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me._electronicDocument = New ElectronicDocument().Initialization()
    Me._electronicDocument.AssignManage(Me._manage)


    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación de la CONSTANCIA DE RETENCIONES Y PAGOS
    ' y se le pasa el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me._constanciaRetenciones = New ConstanciaRetenciones().Initialization()
    Me._constanciaRetenciones.AssignManage(Me._manage)


    ' Directorio donde van a ser almacenado los XML generados
    Me._generationDirectory = Utils.CreateDirectory()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "PAX FACTURACION"

    ' -- Código para uso interno de este ejemplo
    ReDim pages(5)
    pages(0) = tshTimbrado
    pages(1) = tshConstanciaRetenciones
    pages(2) = tshCancelacion
    pages(3) = tshFechaHora
    pages(4) = tshParameters

    ' -- Código para uso interno de este ejemplo
    Me.pgcInformacion.SuspendLayout()
    While Me.pgcInformacion.TabPages.Count > 0
      Me.pgcInformacion.TabPages.RemoveAt(0)
    End While
    Me.pgcInformacion.ResumeLayout()

    ' -- Código para uso interno de este ejemplo
    Me.cmbOperacion.SelectedIndex = 0

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Me.btnTimbrado, Me.btnHelp, Me.btnAbout, Me.btnClose)

    ' -- Código para uso interno de este ejemplo
    Me.txtIdentificador.Text = "q+Nu2Fxq03aPR9bu1VHnz7oRv0e5VlOLK9zICF+pBl+HmvSIg67JVuSthuF4aBsB"
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
      Select Case cmbOperacion.SelectedIndex
        ' Timbrar un documento
        Case 0
          generatedfile = Me.TimbrarCfdi(fileName)
          Exit Select

        ' Timbrar un constancia de retenciones y pagos
        Case 1
          generatedfile = Me.TimbrarConstanciaRetenciones(fileName)
          Exit Select

          ' Cancelar un documento
        Case 2
          Me.CancelarCfdi(False)
          Exit Select

          ' Obtener la fecha y hora del PAC
        Case 3
          Me.ObtenerFechaHora()
          Exit Select

        Case Else
          Throw New ArgumentOutOfRangeException()
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
  Private Sub cmbOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperacion.SelectedIndexChanged

    pgcInformacion.SuspendLayout()
    Try
      If pgcInformacion.TabPages.Count > 0 Then
        pgcInformacion.TabPages.RemoveAt(0)
      End If

      pgcInformacion.TabPages.Add(pages(cmbOperacion.SelectedIndex))
      btnExecute.Enabled = cmbOperacion.SelectedIndex <> (cmbOperacion.Items.Count - 1)
    Finally
      pgcInformacion.ResumeLayout()
    End Try

  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    Me._electronicDocument.UnAssignManage()

    Me._constanciaRetenciones.UnAssignManage()

    Me._manage.Save.UnAssignCertificate()

    If (Me._certificate Is Nothing) = False Then
      Me._certificate.Dispose()
    End If

  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    IntegrationForm.ShowForm()

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.TimerLicenciaEnabled()

    ' -- Código para uso interno de este ejemplo
    Me.lblVersion.Text = String.Format("E.D.L. - {0} / PAX - {1}", ElectronicDocument.Version(), Proveedor.Version())
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

'
' NOTAS:
' =====================================================================================================================
' * 
' * 1. Identificadores para cada RFC
' *       - AAA010101AAA - q+Nu2Fxq03aPR9bu1VHnz7oRv0e5VlOLK9zICF+pBl+HmvSIg67JVuSthuF4aBsB
' *       - MAR980114GQA - JSp8dGI8S81IAcLSSRBDfpESrnOikLfthTuQJqcRn71Sy6M5sZCP5QggHOdeAQPO
' *       - EKU9003173C9 - Jy/3vfPl4aEDpoyBGfpIqw8sexI73fK5hpJd1p/KbWeeQ68WASiJewneYYgcYajQ
' *       - MAG041126GT8 - VAml2+AUMIw6U3SXObIrrMdEsDOmRck2+054sx9BoZXwiaA7upjCNSyxyGtwFC9E
' *       - LAN8507268IA - XQr6Y3u2jitOYrsWWI4JJDy4Ei5PUrhY/qqN6gWmYohxtRIj0hy8Q6Lx/hiXJNPA
' *       - VOC990129I26 - 29GS04IxbuRIEzD83k6rUrMD9zKIJKQjAcXJWkNKoR51VHjCHVWh2cIJfnvheaDy
' *       - URU070122S28 - ZQFtPxPsvC7+1sf6IUzBCpALSQWas2lsVusvGirokmzwm5Ch1kDAq+veVtlbB4wG
' *       - ULC051129GC0 - Vr4YnQGEqGhmTSTEta7vZoWIJBSQSWfs9NBdC48SBHUl5GhyJ9k5vHeAj/CICk9n
' *       - TME960709LR2 - V9f1Xr9XtW4eQcL9rO7TGkDLXwmcZOd/e/L1/T5xwU52+GPS6VOXYQY29+NZCNuN
' *       - TCM970625MB1 - QGrB1xMtB9j2rYCrFYbCKkZ/J3URNx0yeHvSPpEzWal+ycM6EZ79MfdTZ3IwyCjV
' *       - SUL010720JN8 - RDWbnDax6eEjXWlNHIXf7URv3glfK3hVNX1S3t3Z3XSajItI5wFN6BaX4P2AUfCZ
' *       - PZA000413788 - Rwi+QyMy4ZPtP7ajHvvpXMGahz9Gc5PO+MfHlHHhPwa8kYT1Zzms2Vz8ii2BQdDV
' *       - MSE061107IA8 - q61bPjrkgkvi5Jh4otjmizO8QUfA8tLNprvt7yEsotKcXImreO8eVndI34En0IOs
' *       - IIA040805DZ4 - otaX4e5Qrn/p0eK0vL14WnuikIwpYSTR/sWK1g/UlGokqWXSTbGqJE41jV97//9Y
' *       
' *====================================================================================================================
' 