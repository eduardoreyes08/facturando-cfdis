Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Base
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.ElectronicDocumentLibrary.Document
Imports HyperSoft.ElectronicDocumentLibrary.Manage
Imports HyperSoft.Shared

Public Class MainForm

#Region "Constants"

  Private Const DataDirectory As String = "..\..\..\.."
  Private Const StatusText As String = "E.D.L. - {0} / {2} - {1}"

#End Region

#Region "Vars"

  Private _generationDirectory As String
  Private _electronicDocument As ElectronicDocument
  Private _addendas As Dictionary(Of String, Data)

#End Region

#Region "Methods"

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

    'Se crea la clase que va a ser usada en el proceso de firmado.
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
    Gui.MessageBoxCaption = "Addendas"

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
    ' -- Código para uso interno de este ejemplo
    If License.CheckLicense() = False Then
      Return
    End If

    ' = Configuramos la interfaz del ejemplo ===========================
    Me.lblTime.Text = String.Empty
    Application.DoEvents()
    Chronometer.Instance.StartWithCursor()
    '===================================================================

    Dim generatedfile As Boolean = False

    Dim fileName As String = String.Empty

    Dim data As Data
    Me._addendas.TryGetValue(DirectCast(Me.cmbTipo.SelectedItem, String), data)
    If data Is Nothing Then
      Return
    End If

    Try
      generatedfile = data.Metodo(fileName)
    Finally
      Me.lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()

      If generatedfile AndAlso Gui.ShowQuestion(String.Format("El CFDI fue generado con éxito.{0}{0}¿Desea visualizarlo ?", Environment.NewLine)) Then
        Process.Start(Path.GetFullPath(fileName))
      End If
    End Try

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
  Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
    Dim data As Data
    Me._addendas.TryGetValue(DirectCast(Me.cmbTipo.SelectedItem, String), data)

    If String.IsNullOrWhiteSpace(data.Version) Then
      data.Version = Adenda.GetAddendaVersion(Me.cmbTipo.SelectedIndex)
    End If

    Me.lblVersion.Text = String.Format(StatusText, ElectronicDocument.Version(), data.Version, Me.cmbTipo.Text.ToUpper())
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnXmlAddenda_Click(sender As Object, e As EventArgs) Handles btnXmlAddenda.Click
    ' -- Código para uso interno de este ejemplo
    If License.CheckLicense() = False Then
      Return
    End If

    Dim fileName As String = Path.Combine(DataDirectory, "archivos\XML de ejemplos\3.2\CFDI1.xml")

    Dim info As New FileInfo(fileName)

    Gui.ShowMessage(String.Format("Este ejemplo muestra como se puede agregar una adenda a un XML{0}" + "previamente generado, para este caso hemos usado la adenda de{0}" + "ADO, pero se puede usar con cualquiera.{0}{0}" + "Archivo:{1}", Environment.NewLine, info.FullName))

    ' Antes de cargar el XML al que le vamos a agregar la adenda, deshabilitamos la validacion del PAC.
    ' *** ESTAS LÍNEA DE CODIGO DEBE SER ELIMINADA EN UN AMBIENTE DE PRODUCCIÓN ***
    Dim options As System.Xml.Linq.LoadOptions = Me._electronicDocument.Manage.Load.Options
    Me._electronicDocument.Manage.Load.Options -= LoadOptions.ValidateStamp
    Try
      'Cargamos el XML y en caso de existir un error lo mostramos
      If Me._electronicDocument.LoadFromFile(fileName) = False Then
        Gui.ShowError(String.Format("Se generó el siguiente error al leer el CFDI.{0}{0}{1}", Environment.NewLine, Me._electronicDocument.ErrorText))
        Return
      End If


      If Adenda.Ado(fileName) = False Then
        Gui.ShowError(String.Format("Se generó el siguiente error al crear el archivo XML.{0}{0}{1}", Environment.NewLine, Me._electronicDocument.ErrorText))
        Return
      End If

      If Gui.ShowQuestion(String.Format("El documento fue generado con éxito.{0}{0}Desea visualizarlo ?", Environment.NewLine)) Then
        Process.Start(Path.GetFullPath(fileName))
      End If
    Finally
      Me._electronicDocument.Manage.Load.Options = options
    End Try
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    IntegrationForm.ShowForm()

    Adenda.SetConfiguration(Me._generationDirectory, Me._electronicDocument)

    ' -- Código para uso interno de este ejemplo
    Utilerias.Gui.Shared.TimerLicenciaEnabled()

#Region "Addendas"

    _addendas = New Dictionary(Of String, Data)
    _addendas.Add("Aba Seguros", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Aba)})
    _addendas.Add("Ado", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Ado)})
    _addendas.Add("AlSuper", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.AlSuper)})
    _addendas.Add("Altos Hornos de México", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.AltosHornosMexico)})
    _addendas.Add("Aluprint", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Aluprint)})
    _addendas.Add("Amece", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Amece)})
    _addendas.Add("Asociación mexicana de instituciones de seguros AMIS", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Amis)})
    _addendas.Add("Asoforma - ASONIOSCOC", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Asofarma)})
    _addendas.Add("Axxa - Autos", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.AxxaAutos)})
    _addendas.Add("Axxa - Gastos médicos", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.AxxaGastosMedicos)})
    _addendas.Add("BBVA", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Bbva)})
    _addendas.Add("Bexel", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Bexel)})
    _addendas.Add("BrudiFarma", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.BrudiFarma)})
    _addendas.Add("Capa de Ozono", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.CapaOzono)})
    _addendas.Add("Chrysler", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Chrysler)})
    _addendas.Add("Comex", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Comex)})
    _addendas.Add("Continental Tire", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.ContinentalTire)})
    _addendas.Add("Coppel - Ropa", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.CoppelRopa)})
    _addendas.Add("Corporate Travel Services", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.CorporateTravelServices)})
    _addendas.Add("Disney", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Disney)})
    _addendas.Add("Elektra", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Elektra)})
    _addendas.Add("Emerson", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Emerson)})
    _addendas.Add("EmSur", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.EmSur)})
    _addendas.Add("Envases universales de México", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.EnvasesUniversalesdeMexico)})
    _addendas.Add("Femsa", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Femsa)})
    _addendas.Add("Ferro Mexicana", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.FerroMexicana)})
    _addendas.Add("Fuller", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Fuller)})
    _addendas.Add("Gayosso", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Gayosso)})
    _addendas.Add("General Motors", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.GeneralMotors)})
    _addendas.Add("Gomsa", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Gomsa)})
    _addendas.Add("Grupo Modelo", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.GrupoModelo)})
    _addendas.Add("Heb", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Heb)})
    _addendas.Add("Inbursa", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Inbursa)})
    _addendas.Add("IT Smart Business", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.ItSmartBusiness)})
    _addendas.Add("Iusacell", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Iusacell)})
    _addendas.Add("KUEHNE + NAGEL", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Kuehne)})
    _addendas.Add("Lamosa", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Lamosa)})
    _addendas.Add("Landsteiner", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Landsteiner)})
    _addendas.Add("Loreal", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Loreal)})
    _addendas.Add("Lowes", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Lowes)})
    _addendas.Add("Mabe", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Mabe)})
    _addendas.Add("Maerks", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Maersk)})
    _addendas.Add("MultiPack", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.MultiPack)})
    _addendas.Add("Oxxo", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Oxxo)})
    _addendas.Add("Pemex - Exploración", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.PemexExploracion)})
    _addendas.Add("Pemex - Refinación", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.PemexRefinacion)})
    _addendas.Add("Pepsico", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Pepsico)})
    _addendas.Add("Pilgrims", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Pilgrims)})
    _addendas.Add("Prolec", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Prolec)})
    _addendas.Add("Sanmina", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Sanmina)})
    _addendas.Add("Santander", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Santander)})
    _addendas.Add("Sector primario", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.SectorPrimario)})
    _addendas.Add("Seven Eleven", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.SevenEleven)})
    _addendas.Add("Soler & Palau", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.SolerPalau)})
    _addendas.Add("Soriana - Remision", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.SorianaRemision)})
    _addendas.Add("Soriana - Servicio", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.SorianaServicio)})
    _addendas.Add("Tiendas Neto", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.TiendasNeto)})
    _addendas.Add("Transportes Castores", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.TransportesCastores)})
    _addendas.Add("Tres M", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.TresM)})
    _addendas.Add("Tv Azteca", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.TvAzteca)})
    _addendas.Add("Viscofan", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Viscofan)})
    _addendas.Add("Volkswagen", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.Volkswagen)})
    _addendas.Add("WalMart", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.WalMart)})
    _addendas.Add("ZF México", New Data() With {.Metodo = New Ejecutar(AddressOf Adenda.ZfMexico)})

    Dim texto As String() = New String(Me._addendas.Count - 1) {}
    Me._addendas.Keys.CopyTo(texto, 0)
    Me.cmbTipo.Items.Clear()
    Me.cmbTipo.Items.AddRange(texto)
#End Region

    ' -- Código para uso interno de este ejemplo
    Me.cmbTipo.SelectedIndex = 0
  End Sub

#End Region

End Class