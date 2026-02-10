Imports System
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates

Friend NotInheritable Class SslValidator
	#Region "Vars"

	Private _orgCallback As RemoteCertificateValidationCallback
	Private _expect100Continue As Boolean
	Private _securityProtocol As SecurityProtocolType

	#End Region

	#Region "Methods"

	Friend Sub OverrideValidation()
		Me._expect100Continue = ServicePointManager.Expect100Continue
		Me._orgCallback = ServicePointManager.ServerCertificateValidationCallback
		Me._securityProtocol = ServicePointManager.SecurityProtocol

		'ServicePointManager.ServerCertificateValidationCallback = Me.OnValidateCertificate
		ServicePointManager.Expect100Continue = True

		Try
			Const tls11 As SecurityProtocolType = DirectCast(768, SecurityProtocolType)
			Const tls12 As SecurityProtocolType = DirectCast(3072, SecurityProtocolType)

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 Or SecurityProtocolType.Tls Or Tls11 Or Tls12
				
		Catch generatedExceptionName As Exception
		End Try
	End Sub

	Friend Sub RestoreValidation()
		ServicePointManager.SecurityProtocol = Me._securityProtocol
		ServicePointManager.ServerCertificateValidationCallback = Me._orgCallback
		ServicePointManager.Expect100Continue = Me._expect100Continue
	End Sub

  'Private Function OnValidateCertificate(sender As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) As Boolean
  '  Return True
  'End Function

#End Region
End Class