Imports System.IO
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Base

Public Class MainForm

#Region "Methods"

  ''' <summary>
  ''' Método que muestra como cargar la licencia de la librería
  ''' </summary>
  Private Sub CargarLicencia()

    If File.Exists(License.LicenseCfdiData) = False Then
      Const message As String = "Estimado usuario:{0}{0}No es posible cargar la licencia porque no existe el archivo.{0}{0}{0}{1}{0}{0}{0}Si tiene una licencia, por favor, copiela a esa carpeta.{0}{0}"
      [Shared].Gui.ShowError(String.Format(message, Environment.NewLine, License.LicenseCfdiData))
      Return
    End If

    ' Con este código se carga la licencia
    Using stream As New MemoryStream(File.ReadAllBytes(License.LicenseCfdiData))
      ElectronicDocumentLibrary.Activaction.LoadActivationFile(stream)
    End Using

    [Shared].Gui.ShowMessage(String.Format("Estimado usuario:{0}{0}" + "Se ha cargado la licencia de E.D.L., te recomendamos verificar su STATUS." + "{0}{0}" + "Archivo:{0}" + "{1}{0}{0}" + "Atte.{0}" + "FACTURANDO", Environment.NewLine, License.LicenseCfdiData))    
  End Sub

  ''' <summary>
  ''' Método que muestra como obtener el status de la licencia previamente cargada
  ''' 
  ''' Si el status es diferente a LICENSED no podrás hacer uso de la librería.
  ''' </summary>
  Private Sub StatusLicencia()
    Dim description As String = LicenciaForm.StatusToText(ElectronicDocumentLibrary.Activaction.ActivationStatus)

    Dim message As String = String.Format("Este es el estatus de la licencia previamente cargada.{0}{0}{1}", Environment.NewLine, description)

    If ElectronicDocumentLibrary.Activaction.ActivationStatus = ActivationStatusType.Licensed Then
      [Shared].Gui.ShowMessage(message)
    Else
      [Shared].Gui.ShowError(message)
    End If
  End Sub

  ''' <summary>
  ''' Método que muestra como extraer los datos contenidos en la licencia
  ''' 
  ''' Un dato que te podría se de gran utilidad, es la fecha de vencimiento.
  ''' </summary>
  Private Sub DatosLicencia()
    LicenciaForm.ShowData()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' -- Código para uso interno de este ejemplo
    [Shared].Gui.MessageBoxCaption = "Licencia - CFDI DATA"

    ' -- Código para uso interno de este ejemplo
    Gui.Shared.Initialization(Nothing, Me.lblVersion, Me.lblTime)
    Gui.Shared.Buttons(Nothing, Nothing, Nothing, Me.btnClose, Me.btnPuertos)
  End Sub

#End Region

#Region "Events"

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnCargarLicencia_Click(sender As Object, e As EventArgs) Handles btnCargarLicencia.Click
    Me.CargarLicencia()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnStatusLicencia_Click(sender As Object, e As EventArgs) Handles btnStatusLicencia.Click
    Me.StatusLicencia()
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub btnDatosLicencia_Click(sender As Object, e As EventArgs) Handles btnDatosLicencia.Click
    Me.DatosLicencia()
  End Sub

  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' -- Código para uso interno de este ejemplo
    Me.ConfigurateControls()
  End Sub

#End Region

End Class