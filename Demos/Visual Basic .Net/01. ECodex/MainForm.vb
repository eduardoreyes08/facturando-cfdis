Imports System.Globalization
Imports HyperSoft.ElectronicDocumentLibrary.Base
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.ECodex
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Shared
Imports System.Text
Imports System.IO
Imports HyperSoft.Ejemplo.Data
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.Ejemplo.Utilerias.Gui
Imports HyperSoft.ElectronicDocumentLibrary
Imports HyperSoft.ElectronicDocumentLibrary.Cancelacion
Imports HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones
Imports HyperSoft.ElectronicDocumentLibrary.RecieptCancel
Imports Informacion = HyperSoft.ElectronicDocumentLibrary.ECodex.Timbre.Informacion

Public Class MainForm

#Region "Constants"

  Private Const DataDirectory As String = "..\..\..\.."

  Private Const UseOwnTokenDefinition As Boolean = True
  Private Const SetDateTimeServerDefinition As Boolean = True

#End Region

#Region "Vars"

  Private _pages As TabPage()

  ' ReSharper disable InconsistentNaming
  Private generationDirectory As String
  Private manage As ElectronicManage
  Private certificate As ElectronicCertificate
  Private electronicDocument As ElectronicDocument
  Private constanciaRetenciones As ConstanciaRetenciones
  Private proveedor As Proveedor
  ' ReSharper restore InconsistentNaming

  Private _dateTimeServer As DateTime = DateTime.MinValue
  Private _dateLastToken As DateTime = DateTime.Now
#End Region

#Region "Methods"

  Private Function TimbrarCfdi(ByRef fileName As String) As Boolean
    fileName = Path.Combine(Me.generationDirectory, "CFDI40.xml")


    Dim parameters As TimbrarParameters = New TimbrarParameters().Initialization()
    Try
      'En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosTimbrado(Me.electronicDocument)
      fileName = Path.Combine(Me.generationDirectory, "CFDI40.xml")

      ' - En este método se cargan los datos de un RECIBO DE PAGO 2.0
      ' Data.Complemento.ReciboPago20.CargarDatosTimbrado(Me.electronicDocument)
      ' fileName = Path.Combine(Me.generationDirectory, "recibo_pago_20.xml")

      ' - En este método se cargan los datos de un RECIBO DE NÓMINA 1.2
      ' Data.Complemento.Nomina12.CargarDatosCfdi40Timbrado(Me.electronicDocument)
      ' fileName = Path.Combine(Me.generationDirectory, "recibo_nomina_12.xml")

      ' - En este método se cargan los datos de una CARTA PORTE 2.0
      ' Data.Complemento.CartaPorte.Timbrado.CargarDatos(Me.electronicDocument)
      ' fileName = Path.Combine(Me.generationDirectory, "carta_porte_20.xml")


      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As Informacion = New Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.ElectronicDocument = electronicDocument
      parameters.Informacion = informacion
      parameters.Rfc.Value = Me.electronicDocument.Data.Emisor.Rfc.Value
      parameters.IdTransaccion.Value = Long.MaxValue
      parameters.TestMode = Timbrado.IsTestMode()
      parameters.Enviroment = Timbrado.Enviroment()
      parameters.UseHttps = Me.chkUseHttps.Checked

      ' Se envia a timbrar el documento
      Dim result As ProcessProviderResult = Me.proveedor.GenerarTimbre(parameters)

      Chronometer.Instance.Stop()

      ' Se le da formato a la información retornada por el PAC
      Dim resultadoTexto As String = FormatInformationTimbre(parameters.IdTransaccion.Value, informacion, result, electronicDocument.FingerPrintPac)

      ResultForm.ShowResult("Timbrado CFDI", resultadoTexto)
      If result <> ProcessProviderResult.Ok Then
        Return False
      End If

      ' Se guarda el documento, en este punto ya contiene los datos del timbre
      Dim options As SaveOptions = electronicDocument.Manage.Save.Options
      electronicDocument.Manage.Save.Options = SaveOptions.EncodeApostrophe
      Try
        electronicDocument.SaveToFile(fileName)
      Catch
        Gui.ShowError(electronicDocument.ErrorText)
        Return False
      Finally
        electronicDocument.Manage.Save.Options = options
      End Try
      Return True
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Function

  Private Function TimbrarConstanciaRetenciones(ByRef fileName As String) As Boolean
    fileName = Path.Combine(generationDirectory, "Constancia_Retenciones_20.xml")

    Dim parameters As TimbrarConstanciaRetencionesParameters = New TimbrarConstanciaRetencionesParameters().Initialization()
    Try
      ' En este método se cargan los datos de la factura.
      ConstanciaRetenciones20.CargarDatosTimbrado(Me.constanciaRetenciones)

      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As Informacion = New Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.ConstanciaRetenciones = constanciaRetenciones
      parameters.Informacion = informacion
      parameters.Rfc.Value = Me.constanciaRetenciones.Data.Emisor.Rfc.Value
      parameters.IdTransaccion.Value = Long.MaxValue
      parameters.TestMode = Timbrado.IsTestMode()
      parameters.Enviroment = Timbrado.Enviroment()
      parameters.UseHttps = Me.chkUseHttps.Checked

      ' Se envia a timbrar el documento
      Dim result As ProcessProviderResult = Me.proveedor.GenerarTimbreConstanciaRetenciones(parameters)

      Chronometer.Instance.Stop()

      ' Se le da formato a la información retornada por el PAC
      Dim resultadoTexto As String = FormatInformationTimbre(parameters.IdTransaccion.Value, informacion, result, constanciaRetenciones.FingerPrintPac)

      ResultForm.ShowResult("Timbrado de una CONSTANCIA DE RETENCIONES", resultadoTexto)
      If result <> ProcessProviderResult.Ok Then
        Return False
      End If

      ' Se guarda el documento, en este punto ya contiene los datos del timbre
      Dim options As SaveOptions = constanciaRetenciones.Manage.Save.Options
      constanciaRetenciones.Manage.Save.Options = SaveOptions.EncodeApostrophe
      Try
        constanciaRetenciones.SaveToFile(fileName)
      Catch
        Gui.ShowError(constanciaRetenciones.ErrorText)
        Return False
      Finally
        constanciaRetenciones.Manage.Save.Options = options
      End Try

      Return True
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Function

  Private Sub SolicitudCancelacionCfdi()

    Dim cancelCfdi As CancelCfdi = New CancelCfdi().Initialization()
    cancelCfdi.AssignManage(Me.manage)

    cancelCfdi.Data.TipoDocumento = DocumentType.Cfdi
    cancelCfdi.Data.RfcEmisor.Value = Me.txtRfcEmisorCancelacion.Text
    cancelCfdi.Data.Fecha.Value = DateTime.Now

    Dim folio As Folio = cancelCfdi.Data.Folios.Add()
    folio.Uuid.Value = Me.txtUuidCancelacion.Text
    folio.Motivo.Value = Me.txtMotivoCancelacion.Text

    If String.IsNullOrEmpty(Me.txtUuidSustitucionCancelacion.Text) = False Then
      folio.FolioSustitucion.Value = Me.txtUuidSustitucionCancelacion.Text
    End If

    Dim parameters As CancelarMotivoParameters = New CancelarMotivoParameters().Initialization()

    Try
      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As InformacionCancelarMotivo = New InformacionCancelarMotivo().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.CancelCfdi = cancelCfdi
      parameters.Informacion = informacion
      parameters.TestMode = Timbrado.IsTestMode()
      parameters.IdTransaccion = Guid.NewGuid().ToString()
      parameters.FullErrorDescription = True
      parameters.OtroPac = Me.chkOtroPac.Checked

      ' Se envia a cancelar el documento 
      Dim result As ProcessProviderResult = Me.proveedor.CancelarCfdi(parameters)

      Chronometer.Instance.[Stop]()

      ' Se le da formato a la información retornada por el PAC
      Dim texto As String = Me.FormatInformationCancelarCfdi(parameters.IdTransaccion, informacion, result)

      ' Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Cancelar CFDI", texto)
    Finally
      cancelCfdi.UnAssignManage()
    End Try
  End Sub

  Private Sub AcuseSolicitudCancelacion()


    Dim parameters As AcuseCancelacionMotivoParameters = New AcuseCancelacionMotivoParameters().Initialization()
    Try
      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As AcuseCancelacion.Informacion = New AcuseCancelacion.Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.Informacion = informacion
      parameters.TestMode = Timbrado.IsTestMode()
      parameters.RfcEmisor = Me.txtRfcEmisorAcuse.Text
      parameters.Uuid = Me.txtUuidAcuse.Text
      parameters.IdTransaccion = Guid.NewGuid().ToString()
      parameters.FullErrorDescription = True

      ' Se envia a cancelar el documento
      Dim result As ProcessProviderResult = Me.proveedor.AcuseCancelacion(parameters)

      Chronometer.Instance.[Stop]()

      ' Se le da formato a la información retornada por el PAC
      Dim texto As String = Me.FormatInformationAcuseCancelacion(parameters.IdTransaccion, informacion, result)

      ResultForm.ShowResult("Acuse de cancelación", texto)
    Finally
      Chronometer.Instance.[Stop]()
    End Try
  End Sub

  Private Sub ObtenerFechaHora()
    ' Se crea el objeto que contiene la información retornada por el PAC
    Dim informacion As FechaHora.Informacion = New FechaHora.Informacion().Initialization()

    ' Se obtiene la hora y fecha que tiene el servidor de timbrado del PAC
    Dim result As ProcessProviderResult = Me.proveedor.FechaHora(informacion)

    Chronometer.Instance.Stop()

    ' Se le da formato a la información retornada por el PAC
    Dim texto As String = Me.FormatInformationFechaHora(informacion, result)

    ' Se muestra en pantalla el resultado del proceso
    ResultForm.ShowResult("Hora y Fecha del PAC", texto)
  End Sub

  Private Sub DescargarXml()
    Dim parameters As ObtenerCfdiParameters = New ObtenerCfdiParameters().Initialization()
    Try
      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As ObtenerCfdi.Informacion = New ObtenerCfdi.Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.Informacion = informacion
      parameters.Rfc.Value = txtRfcEmisorDescarga.Text
      parameters.Uuid.Value = txtUuidDescarga.Text
      parameters.Uuid.Value = txtUuidDescarga.Text
      parameters.IdTransaccion.Value = Long.MaxValue
      parameters.TestMode = Timbrado.IsTestMode()
      parameters.Enviroment = Timbrado.Enviroment()
      parameters.UseHttps = Me.chkUseHttps.Checked

      ' Se envia a timbrar el documento
      Dim result As ProcessProviderResult = Me.proveedor.ObtenerCfdi(parameters)

      Chronometer.Instance.Stop()

      ' Se le da formato a la información retornada por el PAC
      Dim texto As String = FormatInformationObtenerCfdi(parameters.IdTransaccion.Value, informacion, result)

      ' Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Obtener CFDI", texto)
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Sub

  Private Sub EstadoCuentaCliente()
    Dim parameters As EstadoClienteParameters = New EstadoClienteParameters().Initialization()
    Try
      ' Se crea el objeto que contiene la información retornada por el PAC
      Dim informacion As EstadoCliente.Informacion = New EstadoCliente.Informacion().Initialization()

      ' Se asigna los parámetros a usar durante el proceso
      parameters.Informacion = informacion
      parameters.Rfc.Value = txtRfcEmpresa.Text
      parameters.IdTransaccion.Value = Long.MaxValue
      parameters.TestMode = Timbrado.IsTestMode()
      parameters.Enviroment = Timbrado.Enviroment()
      parameters.UseHttps = Me.chkUseHttps.Checked

      ' Se envia a timbrar el documento
      Dim result As ProcessProviderResult = Me.proveedor.EstadoCliente(parameters)

      Chronometer.Instance.Stop()

      ' Se le da formato a la información retornada por el PAC
      Dim texto As String = FormatInformationEstadoCliente(parameters.IdTransaccion.Value, informacion, result)

      ' Se muestra en pantalla el resultado del proceso
      ResultForm.ShowResult("Obtener aviso", texto)
    Finally
      parameters.Dispose()
      Chronometer.Instance.Stop()
    End Try
  End Sub

  Private Function FormatInformationTimbre(idTransaccion As Int64, informacion As Informacion, providerResult As ProcessProviderResult, cadenaOriginal As String) As String
    Dim builder As New StringBuilder()

    If informacion.DownloadedByHash Then
      builder.AppendLine("==================================================")
      builder.AppendLine("***      COMPROBANTE PREVIAMENTE GENERADO      ***")
      builder.AppendLine("==================================================")
      builder.AppendLine(String.Empty)
      builder.AppendLine(String.Empty)
    End If


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

    If idTransaccion <> 0 Then
      builder.AppendLine(String.Empty)
      builder.AppendLine("INFORMACION DE LA TRANSACCION")
      builder.AppendLine("=================================================")
      builder.AppendLine("Número de transacción         : " + idTransaccion.ToString())
    End If

    If Not informacion.Error.IsAssigned Then
      Return builder.ToString()
    End If

    FormatTypeError(builder, providerResult)

    builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    builder.AppendLine("=================================================")
    builder.AppendLine("Numero      : " + informacion.Error.Numero.AsString())
    builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return builder.ToString()
  End Function

  Private Shared Function FormatInformationEstadoCfdi(idTransaccion As Int64, informacion As EstadoCfdi.Informacion, providerResult As ProcessProviderResult) As String
    Dim text As New StringBuilder()

    If informacion.Estado.Codigo.IsAssigned Then
      text.AppendLine(String.Empty)
      text.AppendLine("INFORMACION")
      text.AppendLine("=================================================")
      text.AppendLine("Código       : " + informacion.Estado.Codigo.AsString())
      text.AppendLine("Descripci+on : " + informacion.Estado.Descripcion.Value)
    End If

    If idTransaccion <> 0 Then
      text.AppendLine(String.Empty)
      text.AppendLine("INFORMACION DE LA TRANSACCION")
      text.AppendLine("=================================================")
      text.AppendLine("Número de transacción         : " + idTransaccion.ToString())
    End If

    If Not informacion.Error.IsAssigned Then
      Return text.ToString()
    End If

    FormatTypeError(text, providerResult)

    text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    text.AppendLine("=================================================")
    text.AppendLine("Numero      : " + informacion.Error.Numero.AsString())
    text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return text.ToString()
  End Function

  Private Shared Function FormatInformationObtenerCfdi(idTransaccion As Int64, informacion As ObtenerCfdi.Informacion, providerResult As ProcessProviderResult) As String
    Dim text As New StringBuilder()

    If informacion.Xml.IsAssigned Then
      text.AppendLine(String.Empty)
      text.AppendLine("INFORMACION")
      text.AppendLine("=================================================")
      text.AppendLine("Xml : " + informacion.Xml.Value)
    End If

    If idTransaccion <> 0 Then
      text.AppendLine(String.Empty)
      text.AppendLine("INFORMACION DE LA TRANSACCION")
      text.AppendLine("=================================================")
      text.AppendLine("Número de transacción         : " + idTransaccion.ToString())
    End If

    If Not informacion.Error.IsAssigned Then
      Return text.ToString()
    End If

    FormatTypeError(text, providerResult)

    text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    text.AppendLine("=================================================")
    text.AppendLine("Numero      : " + informacion.Error.Numero.AsString())
    text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return text.ToString()
  End Function

  Private Shared Function FormatInformationEstadoCliente(idTransaccion As Int64, informacion As EstadoCliente.Informacion, providerResult As ProcessProviderResult) As String
    Dim text As New StringBuilder()

    If informacion.EstadoCliente.IsAssigned Then

      text.AppendLine(String.Empty)
      text.AppendLine("INFORMACION")
      text.AppendLine("=================================================")
      text.AppendLine("Código       : " + informacion.EstadoCliente.Codigo.Value)
      text.AppendLine("Descripción  : " + informacion.EstadoCliente.Descripcion.Value)
      text.AppendLine("Fecha inicio : " + informacion.EstadoCliente.FechaInicio.AsString())
      text.AppendLine("Fecha fin : " + informacion.EstadoCliente.FechaFin.AsString())
      text.AppendLine("Timbres asignados : " + informacion.EstadoCliente.TimbresAsignados.Value.ToString())
      text.AppendLine("Timbres disponibles : " + informacion.EstadoCliente.TimbresDisponibles.Value.ToString())
      For Each certificado As String In informacion.EstadoCliente.Certificados
        text.AppendLine("Certificado : " + certificado)
      Next
    End If

    If idTransaccion <> 0 Then
      text.AppendLine(String.Empty)
      text.AppendLine("INFORMACION DE LA TRANSACCION")
      text.AppendLine("=================================================")
      text.AppendLine("Número de transacción         : " + idTransaccion.ToString())
    End If

    If Not informacion.Error.IsAssigned Then
      Return text.ToString()
    End If

    FormatTypeError(text, providerResult)

    text.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    text.AppendLine("=================================================")
    text.AppendLine("Número      : " + informacion.Error.Numero.AsString())
    text.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return text.ToString()
  End Function

  Private Function FormatInformationAcuseCancelacion(idTransaccion As String, informacion As AcuseCancelacion.Informacion, providerResult As ProcessProviderResult) As String
    Dim builder As New StringBuilder()

    ' Se lee la informacion del acuse

    If informacion.Error.IsAssigned = False Then
      Try
        Dim recieptCancel As RecieptCancel = New RecieptCancel().Initialization()
        recieptCancel.LoadFromString(informacion.Acuse.Value)

        builder.AppendLine(String.Empty)
        builder.AppendLine("RESULTADO")
        builder.AppendLine("=================================================")
        builder.AppendLine("RFC : " + recieptCancel.Data.RfcEmisor.Value)
        builder.AppendLine("Fecha de cancelación : " + recieptCancel.Data.Fecha.AsString())

        Dim i As Integer = 0
        While i < recieptCancel.Data.Documentos.Count
          builder.AppendLine()
          builder.AppendLine("UUID : " + recieptCancel.Data.Documentos(i).Uuid.Value)
          builder.AppendLine("Status : " + recieptCancel.Data.Documentos(i).Status.Value)
          builder.AppendLine("Status description : " + recieptCancel.Data.Documentos(i).StatusDescription.Value)
          i = i + 1
        End While

        builder.AppendLine()
        builder.AppendLine("Status : " + informacion.Status.Value)
        builder.AppendLine("XML : " + recieptCancel.Data.Xml.Value)
      Catch generatedExceptionName As Exception
        builder.AppendLine("RESULTADO")
        builder.AppendLine("=================================================")
        builder.AppendLine("Mensaje retornado : " + informacion.Acuse.Value)
      End Try

      builder.AppendLine()
    End If

    If String.IsNullOrEmpty(idTransaccion) = False Then
      builder.AppendLine()
      builder.AppendLine("INFORMACION DE LA TRANSACCION")
      builder.AppendLine("=================================================")
      builder.AppendLine("Id de la transacción : " + idTransaccion)
    End If

    If informacion.Error.IsAssigned = False Then
      Return builder.ToString()
    End If

    FormatTypeError(builder, providerResult)

    builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    builder.AppendLine("=================================================")
    builder.AppendLine("Número      : " + informacion.Error.Numero.AsString)
    builder.AppendLine("Código      : " + informacion.Error.Codigo.Value)
    builder.AppendLine("Mensaje     : " + informacion.Error.Mensaje.Value)
    builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return builder.ToString()
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
    builder.AppendLine("Número      : " + informacion.Error.Numero.AsString())
    builder.AppendLine("Descripción : " + informacion.Error.Descripcion.Value)

    Return builder.ToString()
  End Function

  Private Function FormatInformationCancelarCfdi(idTransaccion As String, informacion As InformacionCancelarMotivo, providerResult As ProcessProviderResult) As String

    Dim builder As New StringBuilder()

    If String.IsNullOrEmpty(informacion.Uuid) = False Then
      builder.AppendLine(String.Empty)
      builder.AppendLine("RESULTADO")
      builder.AppendLine("=================================================")
      builder.AppendLine("Código: {informacion.Codigo}")
      builder.AppendLine("Fecha : {informacion.Fecha}")
      builder.AppendLine("UUID  : {informacion.Uuid}")
      builder.AppendLine()
    End If

    If String.IsNullOrEmpty(idTransaccion) = False Then
      builder.AppendLine()
      builder.AppendLine("INFORMACION DE LA TRANSACCION")
      builder.AppendLine("=================================================")
      builder.AppendLine("Id de la transacción : " + idTransaccion)
    End If

    If informacion.[Error].IsAssigned = False Then
      Return builder.ToString()
    End If

    FormatTypeError(builder, providerResult)

    builder.AppendLine("ERROR QUE SE GENERO EN EL PROCESO")
    builder.AppendLine("=================================================")
    builder.AppendLine("Número      : " + informacion.Error.Numero.AsString())
    builder.AppendLine("Código      : " + informacion.Error.Codigo.Value)
    builder.AppendLine("Mensaje     : " + informacion.Error.Mensaje.Value)
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

  '****************************************************************************************************************************************************************************
  ' NOTA:
  ' 
  ' El uso de este método solo es importante cuando se tiene una aplicación web o un servicio web ya que permite reducir el tiempo de timbrado en aproximadamente 500 ms.
  ' 
  ' Para el correcto funcionamiento de esta propiedad se requiere que la hora del servidor o computadora sea menor a la del PAC.
  ' 
  ' Para el integrar esta funcionalifuncionalidad da debe:
  '
  '   1. Declarar dos constantes en la parte superior de este formulario
  '
  '      const bool UseOwnTokenDefinition = true;
  '      const bool SetDateTimeServerDefinition = true;
  '
  '   2. Declarar dos variables en la parte superior de este formulario
  '
  '      private DateTime dateTimeServer = DateTime.MinValue;
  '      private DateTime dateLastToken = DateTime.Now;
  '
  '   3. Usar este código antes de realizar cualquier operación con el PAC (timbrar, cancelar, etc)
  '
  '      this.UseOwnToken(parameters, UseOwnTokenDefinition, SetDateTimeServerDefinition);
  '
  '
  ' Si desea hace uso de este método póngase en contacto con nosotros para darle todo el detalle del mismo.
  '****************************************************************************************************************************************************************************

  'Private Sub UseOwnToken(parameters As BaseParameters, useOwnToken__1 As Boolean, setDateTimeServer As Boolean)

  '  parameters.OwnToken = useOwnToken__1

  '  If (useOwnToken__1 = False) OrElse (setDateTimeServer = False) Then
  '    Return
  '  End If

  '  If Me.dateTimeServer = DateTime.MinValue Then
  '    Dim informacion As ElectronicDocumentLibrary.ECodex.FechaHora.Informacion = New ElectronicDocumentLibrary.ECodex.FechaHora.Informacion().Initialization()
  '    Dim result As ProcessProviderResult = Me._proveedor.FechaHora(informacion)
  '    If result = ProcessProviderResult.Ok Then
  '      Me.dateTimeServer = informacion.FechaHora.Value
  '    Else
  '      parameters.OwnToken = False
  '      Return
  '    End If

  '    Me.dateLastToken = DateTime.Now
  '  Else
  '    Dim tiempoTranscurrido As Integer = (DateTime.Now - Me.dateLastToken).Minutes

  '    If tiempoTranscurrido > 8 Then
  '      Me.dateTimeServer = Me.dateTimeServer.AddMinutes(8)
  '    End If
  '  End If

  '  parameters.DateTimeServer = Me.dateTimeServer
  'End Sub

  Private Sub UseOwnToken(parameters As BaseParameters, useOwnToken1 As Boolean, setDateTimeServer As Boolean)
    parameters.OwnToken = useOwnToken1

    If (useOwnToken1 = False) OrElse (setDateTimeServer = False) Then
      Return
    End If

    If Me._dateTimeServer = DateTime.MinValue Then
      Dim informacion As FechaHora.Informacion = New FechaHora.Informacion().Initialization()
      Dim result As ProcessProviderResult = Me.proveedor.FechaHora(informacion)
      If result = ProcessProviderResult.Ok Then
        Me._dateTimeServer = informacion.FechaHora.Value
      Else
        parameters.OwnToken = False
        Return
      End If

      Me._dateLastToken = DateTime.Now
    Else
      Dim tiempoTranscurrido As Integer = (DateTime.Now - Me._dateLastToken).Minutes

      If tiempoTranscurrido > 8 Then
        Me._dateTimeServer = Me._dateTimeServer.AddMinutes(8)
      End If
    End If

    parameters.DateTimeServer = Me._dateTimeServer
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
    Me.proveedor = New Proveedor().Initialization()

    ' Instanciamos la clase TManageElectronicDocument
    Me.manage = New ElectronicManage().Initialization()

    '  . EDL, a partir de la versión 2017.06.02, por defecto realiza una validación LITE del CFDI 3.3 contra el schema
    '  . Para que se realice una validación FULL, debes activar las siguientes líneas
    '  . Si deseas conocer más al respecto:
    '       www.facturando.mx/blog/index.php/2017/06/01/edl-validacion-de-un-cfdi-3-3/
    'this.manage.Save.Options |= SaveOptions.ValidateWithSchema;
    'this.manage.Save.Options -= SaveOptions.ValidateWithSchemaLite;


    ' Se cargan a memoria el archivo de autoridades certificadoras de prueba
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    Me.manage.CertificateAuthorityList.UseForTest()

    'Se crea la clase que va a ser usada en el proceso de firmado, se le pasa el certificado,
    'la llave privada y el password de la misma.
    Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
    Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
    Dim password As String = "12345678a"
    Me.certificate = New ElectronicCertificate().Load(cerFile, keyFile, password)


    ' Asignamos el certificado al objeto Manage, esta ultima, es la encargada de contener
    ' y administrar TODOS los recursos que serán usados en el proceso
    Me.manage.Save.AssignCertificate(Me.certificate)


    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación de la FACTURA ELECTRONICA (CFDI)
    ' y se le pasa el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me.electronicDocument = New ElectronicDocument().Initialization()
    Me.electronicDocument.AssignManage(Me.manage)


    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de generación de la CONSTANCIA DE RETENCIONES Y PAGOS
    ' y se le pasa el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me.constanciaRetenciones = New ConstanciaRetenciones().Initialization()
    Me.constanciaRetenciones.AssignManage(Me.manage)

    ' Directorio donde van a ser almacenado los XML generados
    Me.generationDirectory = Utils.CreateDirectory()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "ECODEX"

    ' -- Código para uso interno de este ejemplo
    ReDim _pages(8)
    _pages(0) = tshTimbrado
    _pages(1) = tshSolicitudCancelacion
    _pages(2) = tshAcuseSolicitudCancelacion
    _pages(3) = tshDescargarXml
    _pages(4) = tshConstanciaRetenciones
    _pages(5) = tshFechaHora
    _pages(6) = tshEstadoCuenta
    _pages(7) = tshParametros

    ' -- Código para uso interno de este ejemplo
    Me.pgcInformacion.SuspendLayout()
    While Me.pgcInformacion.TabPages.Count > 0
      Me.pgcInformacion.TabPages.RemoveAt(0)
    End While
    Me.pgcInformacion.ResumeLayout()

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Me.btnTimbrado, Me.btnHelp, Me.btnAbout, Me.btnClose)

    ' -- Código para uso interno de este ejemplo
    Dim rfcs As Control() = {Me.txtRfcEmisorCancelacion, Me.txtRfcEmisorDescarga, Me.txtRfcEmisorAcuse, Me.txtRfcEmpresa}

    Timbrado.Initialization(rfcs, Me.cbbEnviroment, Me.lblVersion)

    ' -- Código para uso interno de este ejemplo
    Me.cbbOperacion.SelectedIndex = 0
    
    ' -- Código para uso interno de este ejemplo
    Me.cbbEnviroment.SelectedIndex = 0
    Me.chkUseHttps.Checked = True
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
      Select Case cbbOperacion.SelectedIndex
        ' Timbrar un documento
        Case 0
          generatedfile = Me.TimbrarCfdi(fileName)
          Exit Select

          ' Cancelar un documento
        Case 1
          Me.SolicitudCancelacionCfdi()
          Exit Select

          ' Obtener la fecha y hora del PAC
        Case 2
          Me.AcuseSolicitudCancelacion()
          Exit Select

          ' Descargar un CFDI previamente generado
        Case 3
          Me.DescargarXml()
          Exit Select

        ' Timbrar una constancia de retenciones
        Case 4
          generatedfile = Me.TimbrarConstanciaRetenciones(fileName)
          Exit Select

          ' Obtener la fecha y hora del PAC
        Case 5
          Me.ObtenerFechaHora()
          Exit Select

          ' Obtener el estado de cuenta de un RFC
        Case 6
          Me.EstadoCuentaCliente()
          Exit Select

        Case Else
          Throw New ArgumentOutOfRangeException()
      End Select
    Finally
      lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      If generatedfile AndAlso Gui.ShowQuestion("El documento fue generado con éxito." & vbLf & vbLf & "Desea visualizarlo ?") Then
        Process.Start(fileName)
      End If
    End Try
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub cmbOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbOperacion.SelectedIndexChanged

    pgcInformacion.SuspendLayout()
    Try
      If pgcInformacion.TabPages.Count > 0 Then
        pgcInformacion.TabPages.RemoveAt(0)
      End If

      pgcInformacion.TabPages.Add(_pages(cbbOperacion.SelectedIndex))
      btnExecute.Enabled = cbbOperacion.SelectedIndex <> (cbbOperacion.Items.Count - 1)
    Finally
      pgcInformacion.ResumeLayout()
    End Try
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Me.electronicDocument.UnAssignManage()

    Me.constanciaRetenciones.UnAssignManage()

    Me.manage.Save.UnAssignCertificate()

    If (Me.certificate Is Nothing) = False Then
      Me.certificate.Dispose()
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