// ReSharper disable LocalizableElement
using System.IO;
using System;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Certificate;
using HyperSoft.ElectronicDocumentLibrary.Manage;
using HyperSoft.Ejemplo.Utilerias;
using HyperSoft.Shared;

namespace HyperSoft.Ejemplo.Certificado
{
  public partial class MainForm : Form
  {
    #region Business

    #region Constants

    private const string DataDirectory = "..\\..\\..\\..";

    #endregion

    #region Methods

    private void Sample1()
    {
      try
      {
        string cerFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.cer");
        string keyFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.key");
        string password = "12345678a";
        ElectronicCertificate certificate = new ElectronicCertificate().Load(cerFile, keyFile, password);

        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";

        this.ShowInformation(certificate);
      }
      catch (Exception ex)
      {
        Gui.ShowError(ex.Message);
      }
    }

    private void Sample2()
    {
      try
      {
        ElectronicCertificate certificate = new ElectronicCertificate();

        string fileName = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\aaa010101aaa__csd_01.pfx");
        string password = "12345678a";
        certificate.Load(fileName, string.Empty, password);

        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";

        this.ShowInformation(certificate);
      }
      catch (Exception ex)
      {
        Gui.ShowError(ex.Message);
      }
    }

    private void Sample3()
    {
      Gui.ShowMessage(string.Format("A continuación se va a ejecutar el proceso de validación del certificado.{0}{0}Si  existiera un error se mostraría un mensaje.", Environment.NewLine));

      CertificateAuthorityList certificateAuthorityList = new CertificateAuthorityList().Initialization();
      
      // *** ELIMINAR ESTA LÍNEA EN EL AMBIENTE DE PRODUCCION *** 
      certificateAuthorityList.UseForTest();

      try
      {
        string errorText;
        string cerFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.cer");
        string keyFile = Path.Combine(DataDirectory, "Archivos\\Certificados para firmar\\EKU9003173C9.key");
        string password = "12345678a";
        ElectronicCertificate certificate = new ElectronicCertificate().Load(cerFile, keyFile, password);

        if (certificate.IsValidToSign(
             "EKU9003173C9",
             certificateAuthorityList,              
             out errorText) == false)
          throw new Exception(errorText);

        this.lblTime.Text = $"Tiempo : {Chronometer.Instance.AsInteger:0,0} milisegundos";
      }
      catch (Exception ex)
      {
        Gui.ShowError(ex.Message);
      }
    }

    private void ShowInformation(ElectronicCertificate certificate)
    {
      string information = 
        "INFORMACION DEL CERTIFICADO" + Environment.NewLine +
        "Número de serie : " + certificate.Information.SerialNumber + Environment.NewLine +
        "Valido desde : " + $"{certificate.Information.ValidFrom:F}" + Environment.NewLine +
        "Valido hasta : " + $"{certificate.Information.ValidTo:F}" + Environment.NewLine +
        "Country : " + certificate.Information.Subject.Country + Environment.NewLine +
        "StateOrProvince : " + certificate.Information.Subject.StateOrProvince + Environment.NewLine +
        "Locality : " + certificate.Information.Subject.Locality + Environment.NewLine +
        "Organization : " + certificate.Information.Subject.Organization + Environment.NewLine +
        "Organization : " + certificate.Information.Subject.OrganizationUnit + Environment.NewLine +
        "CommonName : " + certificate.Information.Subject.CommonName + Environment.NewLine +
        "EMailAddress : " + certificate.Information.Subject.EMailAddress;

      Gui.ShowMessage(information);
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void ConfigurateControls()
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      Gui.MessageBoxCaption = "Certificado";

      // -- Código para uso interno de este ejemplo
      this.pgcInformacion.SelectedIndex = 0;

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.Initialization(this.lblLicencia, this.lblVersion, this.lblTime);
      Utilerias.Gui.Shared.Buttons(this.btnTimbrado, this.btnHelp, this.btnAbout, this.btnClose);
      
    }

    #endregion

    #region Events

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void btnExecute_Click(object sender, EventArgs e)
    {
      // = Configuramos la interfaz del ejemplo ===========================
      this.lblTime.Text = string.Empty;
      Application.DoEvents();
      Chronometer.Instance.StartWithCursor();
      //===================================================================

      switch (this.pgcInformacion.SelectedIndex)
      {
        case 0:
          this.Sample1();
          break;
        case 1:
          this.Sample2();
          break;
        case 2:
          this.Sample3();
          break;
      }
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private void After_Show(object sender, EventArgs e)
    {
      // El código que verás a continuación solo es para este ejemplo, no tiene relacion directa con la librería
      IntegrationForm.ShowForm();

      // -- Código para uso interno de este ejemplo
      Utilerias.Gui.Shared.TimerLicenciaEnabled();
    }


    #endregion

    #endregion

    #region Factory

    public MainForm()
    {
      this.InitializeComponent();

      // -- Código para uso interno de este ejemplo
      License.CargarLicencia();

      // -- Código para uso interno de este ejemplo
      this.ConfigurateControls();

      // -- Código para uso interno de este ejemplo
      this.Shown += this.After_Show;
    }

    #endregion
  }
}
// ReSharper restore LocalizableElement