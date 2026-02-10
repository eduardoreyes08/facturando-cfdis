Imports System.IO
Imports HyperSoft.Ejemplo.Utilerias
Imports HyperSoft.ElectronicDocumentLibrary.Certificate
Imports HyperSoft.Shared
Imports HyperSoft.ElectronicDocumentLibrary.Manage

Public Class MainForm

#Region "Constants"

  Const DataDirectory As String = "..\..\..\.."

#End Region

#Region "Methods"

  Private Sub Sample1()
    Try
      Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
      Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
      Dim password As String = "12345678a"
      Dim certificate as ElectronicCertificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

      ShowInformation(certificate)
    Catch ex As Exception
      Gui.ShowError(ex.Message)
    End Try
  End Sub

  Private Sub Sample2()
    Try
      Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\aaa010101aaa__csd_01.pfx")
      Dim keyFile As String = ""
      Dim password As String = "12345678a"
      Dim certificate as ElectronicCertificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

      ShowInformation(certificate)
    Catch ex As Exception
      Gui.ShowError(ex.Message)
    End Try
  End Sub

  Private Sub Sample3()
    Gui.ShowMessage("A continuación se va a ejecutar el proceso de validación del certificado." & vbLf & vbLf & "Si  existiera un error se mostraría un mensaje.")

    Dim certificateAuthorityList As CertificateAuthorityList = New CertificateAuthorityList().Initialization()

    ' *** ELIMINAR ESTA LÍNEA EN EL AMBIENTE DE PRODUCCION *** 
    certificateAuthorityList.UseForTest()

    Try
      Dim errorText As String

      Dim cerFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.cer")
      Dim keyFile As String = Path.Combine(DataDirectory, "Archivos\Certificados para firmar\EKU9003173C9.key")
      Dim password As String = "12345678a"
      Dim certificate as ElectronicCertificate = New ElectronicCertificate().Load(cerFile, keyFile, password)

      If Not certificate.IsValidToSign("EKU9003173C9", certificateAuthorityList, errorText) Then
        Throw New Exception(errorText)
      End If
    Catch ex As Exception
      Gui.ShowError(ex.Message)
    End Try
  End Sub

  Private Sub ShowInformation(certificate As ElectronicCertificate)
    Dim information As String = "INFORMACION DEL CERTIFICADO" + vbCr & vbLf + "Número de serie : " + certificate.Information.SerialNumber + vbCr & vbLf + "Valido desde : " + String.Format("{0:F}", certificate.Information.ValidFrom) + vbCr & vbLf + "Valido hasta : " + String.Format("{0:F}", certificate.Information.ValidTo) + vbCr & vbLf + "Country : " + certificate.Information.Subject.Country + vbCr & vbLf + "StateOrProvince : " + certificate.Information.Subject.StateOrProvince + vbCr & vbLf + "Locality : " + certificate.Information.Subject.Locality + vbCr & vbLf + "Organization : " + certificate.Information.Subject.Organization + vbCr & vbLf + "Organization : " + certificate.Information.Subject.OrganizationUnit + vbCr & vbLf + "CommonName : " + certificate.Information.Subject.CommonName + vbCr & vbLf + "EMailAddress : " + certificate.Information.Subject.EMailAddress

    Gui.ShowMessage(information)
  End Sub

  ''' <summary>
  ''' Método para uso interno de este ejemplo
  ''' </summary>
  Private Sub ConfigurateControls()
    ' El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
    Gui.MessageBoxCaption = "Certificado"

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

    Select Case pgcInformacion.SelectedIndex
      Case 0
        Sample1()
        Exit Select
      Case 1
        Sample2()
        Exit Select
      Case 2
        Sample3()
        Exit Select
    End Select

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

    pgcInformacion.SelectedIndex = 0
  End Sub

#End Region

End Class