using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace HyperSoft.Ejemplo.StatusCfdi
{
  internal sealed class SslValidator
  {
    #region Vars

    private RemoteCertificateValidationCallback orgCallback;
    private bool expect100Continue;
    private SecurityProtocolType securityProtocol;

    #endregion

    #region Methods

    internal void OverrideValidation()
    {
      this.expect100Continue = ServicePointManager.Expect100Continue;
      this.orgCallback = ServicePointManager.ServerCertificateValidationCallback;
      this.securityProtocol = ServicePointManager.SecurityProtocol;

      ServicePointManager.ServerCertificateValidationCallback = this.OnValidateCertificate;
      ServicePointManager.Expect100Continue = true;

      try
      {
        const SecurityProtocolType Tls11 = (SecurityProtocolType)768;
        const SecurityProtocolType Tls12 = (SecurityProtocolType)3072;

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | Tls11 | Tls12;
      }
      catch (Exception)
      {
        // 
      }
    }

    internal void RestoreValidation()
    {
      ServicePointManager.SecurityProtocol = this.securityProtocol;
      ServicePointManager.ServerCertificateValidationCallback = this.orgCallback;
      ServicePointManager.Expect100Continue = this.expect100Continue;
    }

    private bool OnValidateCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
      return true;
    }

    #endregion
  }
}
