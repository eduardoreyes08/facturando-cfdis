Imports System.IO
Imports System.Media
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarCuentas
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.Balanza
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.CatalogoCuentas
Imports HyperSoft.ElectronicDocumentLibrary.Base
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones
Imports HyperSoft.Shared
Imports HyperSoft.ElectronicDocumentLibrary.Contabilidad.Poliza

Public Class MainForm

#Region "Constants"

  Private Const DataDirectory As String = "..\..\..\.."

#End Region

#Region "Vars"

  Private _manage As ElectronicManage
  Private _electronicDocument As ElectronicDocument

#End Region

#Region "Methods"

  Private Sub ValidarComprobante(fileName As String)
    If Me._electronicDocument.LoadFromFile(fileName) = False Then
      Gui.ShowError(Me._electronicDocument.ErrorText)
      Return
    End If

    Me.mmoInformation.Text = Information.Cfdi.Show(Me._electronicDocument)
  End Sub

  Private Sub ValidarCatalogoCuentas(fileName As String)
    Dim catalogoCuentas As CatalogoCuentas = New CatalogoCuentas().Initialization()
    catalogoCuentas.AssignManage(Me._manage)

    Try
      If catalogoCuentas.LoadFromFile(fileName) = False Then
        Gui.ShowError(catalogoCuentas.ErrorText)
        Return
      End If

      Me.mmoInformation.Text = Information.Catalogo.Show(catalogoCuentas)
    Finally
      catalogoCuentas.UnAssignManage()
    End Try
  End Sub

  Private Sub ValidarBalanza(fileName As String)
    Dim balanza As Balanza = New Balanza().Initialization()
    balanza.AssignManage(Me._manage)

    Try
      If balanza.LoadFromFile(fileName) = False Then
        Gui.ShowError(balanza.ErrorText)
        Return
      End If

      Me.mmoInformation.Text = Information.BalanzaComprobacion.Show(balanza)
    Finally
      balanza.UnAssignManage()
    End Try
  End Sub

  Private Sub ValidarPoliza(fileName As String)
    Dim polizaContable As PolizaContable = New PolizaContable().Initialization()
    polizaContable.AssignManage(Me._manage)

    Try
      If polizaContable.LoadFromFile(fileName) = False Then
        Gui.ShowError(polizaContable.ErrorText)
        Return
      End If

      Me.mmoInformation.Text = Information.PolizaContabilidad.Show(polizaContable)
    Finally
      polizaContable.UnAssignManage()
    End Try
  End Sub

  Private Sub ValidarAuxiliarCuentas(fileName As String)
    Dim auxiliarCuentas As AuxiliarCuentas = New AuxiliarCuentas().Initialization()
    auxiliarCuentas.AssignManage(Me._manage)

    Try
      If auxiliarCuentas.LoadFromFile(fileName) = False Then
        Gui.ShowError(auxiliarCuentas.ErrorText)
        Return
      End If

      Me.mmoInformation.Text = Information.Auxiliar.Show(auxiliarCuentas)
    Finally
      auxiliarCuentas.UnAssignManage()
    End Try
  End Sub

  Private Sub ValidarAuxiliarFolios(fileName As String)
    Dim auxiliarFolios As AuxiliarFolios = New AuxiliarFolios().Initialization()
    auxiliarFolios.AssignManage(Me._manage)

    Try
      If auxiliarFolios.LoadFromFile(fileName) = False Then
        Gui.ShowError(auxiliarFolios.ErrorText)
        Return
      End If

      Me.mmoInformation.Text = Information.Folios.Show(auxiliarFolios)
    Finally
      auxiliarFolios.UnAssignManage()
    End Try
  End Sub

  Private Sub ValidarConstanciaRetenciones(fileName As String)
    Dim retenciones As ConstanciaRetenciones = New ConstanciaRetenciones().Initialization()
    retenciones.AssignManage(Me._manage)

    Try
      If retenciones.LoadFromFile(fileName) = False Then
        Gui.ShowError(retenciones.ErrorText)
        Return
      End If

      Me.mmoInformation.Text = Information.Constancia.Show(retenciones)
    Finally
      retenciones.UnAssignManage()
    End Try
  End Sub


  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    ' Instanciamos la clase TManageElectronicDocument, si quieren saber para qué sirve
    ' pueden leer el documento que se encuentra en la carpeta Documentación.
    Me._manage = New ElectronicManage().Initialization()

    ' Debido a que se validar CFDI de pruebas se elimina la validación contra del timbre.
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    Me._manage.Load.Options -= LoadOptions.ValidateStamp

    ' Se cargan a memoria el archivo de autoridades certificadoras de prueba
    ' *** ESTE LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    Me._manage.CertificateAuthorityList.UseForTest()

    ' Se instancia la clase que es la encarga de llevar a cabo el proceso de validación y se le pasa
    ' el objeto que tiene todos los recursos necesarios para llevar a cabo dicho proceso.
    Me._electronicDocument = New ElectronicDocument().Initialization()
    Me._electronicDocument.AssignManage(Me._manage)
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Validación"

    ' -- Código para uso interno de este ejemplo
    Me.tbcOpciones.SelectedIndex = 0

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.Initialization(Me.lblLicencia, Me.lblVersion, Me.lblTime)
    Utilerias.Gui.Shared.Buttons(Nothing, Me.btnHelp, Me.btnAbout, Me.btnClose)

    ' -- Código para uso interno de este ejemplo
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\1.0\ejemplo1.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\2.2\ejemplo1.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\3.2\CFDI1.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\3.3\CFDI33.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\4.0\CFDI40.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Nomina\ReciboNomina12.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Recibo de pago\ReciboPago10.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Recibo de pago\ReciboPago20.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Complementos\ImpuestosLocales10.xml")))
    Me.cbbCfdi.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Addenda\Addenda_Ado.xml")))
    Me.cbbCfdi.SelectedIndex = 4

    ' -- Código para uso interno de este ejemplo
    Me.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Contabilidad electrónica\catalogo.xml")))
    Me.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Contabilidad electrónica\balanza.xml")))
    Me.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Contabilidad electrónica\poliza.xml")))
    Me.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Contabilidad electrónica\Auxiliar_Cuentas.xml")))
    Me.cbbContabilidad.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Contabilidad electrónica\Auxiliar_Folios.xml")))
    Me.cbbContabilidad.SelectedIndex = 0
    Me.cbbContabilidadTipo.SelectedIndex = 0

    ' -- Código para uso interno de este ejemplo
    Me.cbbConstanciaRetenciones.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Constancia de retenciones\Constancia_Retenciones_20.xml")))
    Me.cbbConstanciaRetenciones.Items.Add(Path.GetFullPath(Path.Combine(DataDirectory, "archivos\XML de ejemplos\Constancia de retenciones\Constancia_Retenciones_Plataformas_Tecnologicas.xml")))
    Me.cbbConstanciaRetenciones.SelectedIndex = 0
  End Sub
#End Region

#Region "Events"

  Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
    ' = Configuramos la interfaz del ejemplo ===========================
    Me.lblTime.Text = String.Empty
    Application.DoEvents()
    Chronometer.Instance.StartWithCursor()
    '===================================================================

    Me.mmoInformation.Text = ""

    Try
      ' Por default se hacen todas las validaciones, si quisiera quitar alguna,
      ' por ejemplo que no se valide que el folio haya sido autoridado por el SAT,
      ' se puede hacer esto:
      ' manage.Save.Options -= SaveOptions.ValidateWithFoliosAutorizados; 
      ' A continuacion se muestran todas las opciones
      '     ValidateWithSchema,
      '     ValidateInformation,
      '     ValidateWithFoliosAutorizados,
      '     ValidateSignature,
      '     ValidateCertificateWithCa,
      '     ValidateCertificateWithCrl,
      '     AddCertificateToCel

      ' Se ejecuta el proceso de validación        
      Select Case Me.tbcOpciones.SelectedIndex
        Case 0
          ' CFD: Validar un comprobante de la versión 1.0
          Me.ValidarComprobante(Me.cbbCfdi.Text.Trim())
          Exit Select

        Case 1
          Select Case Me.cbbContabilidadTipo.SelectedIndex
            ' CONTABILIDAD ELECTRÓNICA : Validar el catálogo de cuentas contables
            Case 0
              Me.ValidarCatalogoCuentas(Me.cbbContabilidad.Text.Trim())
              Exit Select

            ' CONTABILIDAD ELECTRÓNICA : Validar la balanza de comprobación
            Case 1
              Me.ValidarBalanza(Me.cbbContabilidad.Text.Trim())
              Exit Select

            ' CONTABILIDAD ELECTRÓNICA : Validar las pólizas
            Case 2
              Me.ValidarPoliza(Me.cbbContabilidad.Text.Trim())
              Exit Select

            ' CONTABILIDAD ELECTRÓNICA : Validar el auxiliar de cuentas
            Case 3
              Me.ValidarAuxiliarCuentas(Me.cbbContabilidad.Text.Trim())
              Exit Select

           ' CONTABILIDAD ELECTRÓNICA : Validar el auxiliar de folios
            Case 4
              Me.ValidarAuxiliarFolios(Me.cbbContabilidad.Text.Trim())
              Exit Select
          End Select
          Exit Select

        Case 2
          ' CFD: Validar un comprobante de la versión 1.0
          Me.ValidarConstanciaRetenciones(Me.cbbConstanciaRetenciones.Text.Trim())
          Exit Select
      End Select
    Finally
      lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()
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

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
    Dim control As ComboBox
    If Me.tbcOpciones.SelectedIndex = 0 Then
      control = Me.cbbCfdi
    ElseIf Me.tbcOpciones.SelectedIndex = 1 Then
      control = Me.cbbContabilidad
    ElseIf Me.tbcOpciones.SelectedIndex = 2 Then
      control = Me.cbbConstanciaRetenciones
    Else
      Throw New ArgumentException()
    End If

    Dim fileName As String = control.Text

    If Utils.SelectFile(fileName) = False Then
      Return
    End If

    control.Text = fileName
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub cbbContabilidadTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbContabilidadTipo.SelectedIndexChanged
    Me.cbbContabilidad.Text = Me.cbbContabilidad.Items(Me.cbbContabilidadTipo.SelectedIndex).ToString()
  End Sub

#End Region

End Class