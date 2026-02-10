Imports HyperSoft.ElectronicDocumentLibrary.BarCode
Imports System.IO
Imports System.Media
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.Shared

Public Class MainForm

#Region "Vars"

  Private _barCode As BarCode
  Private _fileFormat As ImageFormat

#End Region

#Region "Methods"

  Private Sub SampleCfdi33()
    Using stream As New MemoryStream()
      Me._barCode.GenerateCfdi(Me.edtRFCEmisor.Text, Me.edtRFCReceptor.Text, Decimal.Parse(Me.edtTotal.Text), Me.edtUuid.Text, Me.edtSello.Text, stream)
      Me.lblImageSize.Text = "Tamaño: " + [Shared].File.Instance.FormatByteSize(stream.Length)
      Me.picBarCode.Image = Image.FromStream(stream)
    End Using
  End Sub

  Private Sub SampleConstancia()
    Using stream As New MemoryStream()
      Me._barCode.GenerateConstancia(Me.edtEmisorConstancia.Text, Me.edtReceptorConstancia.Text, Decimal.Parse(Me.edtTotalConstancia.Text), Me.edtUuidConstancia.Text, Me.edtSello.Text, stream)
      Me.lblImageSize.Text = "Tamaño: " + [Shared].File.Instance.FormatByteSize(stream.Length)
      Me.picBarCode.Image = Image.FromStream(stream)
    End Using
  End Sub

  Private Sub SampleCartaPorte()
    Using stream As New MemoryStream()
      Me._barCode.GenerateCartaPorte(Me.edtUuidCartaPorte.Text, Me.dteFechaOrigen.Value, Me.dteFechaTimbrado.Value, stream)
      Me.lblImageSize.Text = "Tamaño: " + [Shared].File.Instance.FormatByteSize(stream.Length)
      Me.picBarCode.Image = Image.FromStream(stream)
    End Using
  End Sub

  Private Function CalculateTextCfdi33() As String
    Return Me._barCode.CalculateCfdi(Me.edtRFCEmisor.Text, Me.edtRFCReceptor.Text, Decimal.Parse(Me.edtTotal.Text), Me.edtUuid.Text, Me.edtSello.Text)
  End Function

  Private Function CalculateTextConstancia() As String
    Return Me._barCode.CalculateConstancia(Me.edtEmisorConstancia.Text, Me.edtReceptorConstancia.Text, Decimal.Parse(Me.edtTotalConstancia.Text), Me.edtUuidConstancia.Text, Me.edtSelloConstancia.Text)
  End Function

  Private Function CalculateTextCartaPorte() As String
    Return Me._barCode.CalculateCartaPorte(Me.edtUuidCartaPorte.Text, Me.dteFechaOrigen.Value, Me.dteFechaTimbrado.Value)
  End Function

  Private Sub SampleCfdi32()
    Using stream As New MemoryStream()
      Me._barCode.GenerateCfdi(Me.edtRFCEmisor.Text, Me.edtRFCReceptor.Text, Decimal.Parse(Me.edtTotal.Text), Me.edtUuid.Text, stream)
      Me.lblImageSize.Text = "Tamaño: " + [Shared].File.Instance.FormatByteSize(stream.Length)
      Me.picBarCode.Image = Image.FromStream(stream)
    End Using
  End Sub

  Private Sub SampleConstancia10()
    Using stream As New MemoryStream()
      Me._barCode.GenerateConstancia(Me.edtEmisorConstancia.Text, Me.edtReceptorConstancia.Text, Decimal.Parse(Me.edtTotalConstancia.Text), Me.edtUuidConstancia.Text, stream)
      Me.lblImageSize.Text = "Tamaño: " + [Shared].File.Instance.FormatByteSize(stream.Length)
      Me.picBarCode.Image = Image.FromStream(stream)
    End Using
  End Sub

  Private Function CalculateTextConstancia10() As String
    Return BarCode.CalculateTextConstancia(Me.edtEmisorConstancia.Text, Me.edtReceptorConstancia.Text, Decimal.Parse(Me.edtTotalConstancia.Text), Me.edtUuidConstancia.Text)
  End Function

  ''' <summary>
  ''' Método que muestra como crear los objetos a usar en este ejemplos
  ''' </summary>
  Private Sub CreateObjects()
    ' Se configuran algunas opciones de la librería
    Configuration.Library()

    Me._barCode = New BarCode().Initialization()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Código de barras bidimensional"

    ' -- Código para uso interno de este ejemplo
    Me.picBarCode.SizeMode = PictureBoxSizeMode.CenterImage

    ' -- Código para uso interno de este ejemplo
    Me.cbxFormato.Items.Add(ImageFormat.Bmp.ToString().ToUpper())
    Me.cbxFormato.Items.Add(ImageFormat.Jpg.ToString().ToUpper())
    Me.cbxFormato.Items.Add(ImageFormat.Png.ToString().ToUpper())
    Me.cbxFormato.SelectedIndex = 2
    Me.pgcInformacion.SelectedIndex = 0
    Me.cbxFormato.Text = "4"
    Me.btnExecute.Focus()

    ' -- Código para uso interno de este ejemplo
    Me._fileFormat = DirectCast(Me.cbxFormato.SelectedIndex, ImageFormat)

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

    Try
      Select Case Me.pgcInformacion.SelectedIndex
        Case 0
          Me.SampleCfdi33()
          Exit Select

        Case 1
          Me.SampleConstancia()
          Exit Select

        Case 2
          Me.SampleCartaPorte()
          Exit Select

        Case Else
          Throw New ArgumentOutOfRangeException()
      End Select
    Finally
      Me.lblTime.Text = String.Format("Tiempo : {0:0,0} milisegundos", Chronometer.Instance.AsInteger)
      SystemSounds.Asterisk.Play()
    End Try


  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnConfigurar_Click(sender As Object, e As EventArgs) Handles btnConfigurar.Click
    Me._fileFormat = DirectCast(Me.cbxFormato.SelectedIndex, ImageFormat)
    BarCode.SetConfiguration(Integer.Parse(Me.edtTamano.Text), Me._fileFormat, True)
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
    'Calculamos la candena contenida en el código de barras bidimensional
    Dim data As String
    Select Case Me.pgcInformacion.SelectedIndex
      Case 0
        data = Me.CalculateTextCfdi33()
        Exit Select

      Case 1
        data = Me.CalculateTextConstancia()
        Exit Select

      Case 2
        data = Me.CalculateTextCartaPorte()
        Exit Select

      Case Else
        Throw New ArgumentOutOfRangeException()
    End Select

    Gui.ShowMessage(data)
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


    cbxFormato.Items.Add(ImageFormat.Bmp.ToString().ToUpper())
    cbxFormato.Items.Add(ImageFormat.Jpg.ToString().ToUpper())
    cbxFormato.Items.Add(ImageFormat.Png.ToString().ToUpper())
    cbxFormato.SelectedIndex = 2
    pgcInformacion.SelectedIndex = 0
    cbxFormato.Text = "4"
    btnExecute.Focus()

    _fileFormat = DirectCast(cbxFormato.SelectedIndex, ImageFormat)
  End Sub

#End Region

End Class