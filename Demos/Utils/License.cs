using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.Base;

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable RedundantNameQualifier


namespace HyperSoft.Ejemplo.Utilerias
{
  public static class License
  {
    #region Vars

    public static readonly string LicenseCfdiData;
    public static readonly string LicenseDirectory;

    #endregion

    #region Methods

    /// <summary>
    /// Método usado para cargar la licencia usada en este ejemplo
    /// </summary>
    public static void CargarLicencia()
    {
      // Cargamos la licencia de EDL usando un hilo, 
      // para evitar que se congele la pantalla mientras se lee la licencia.
      //
      // Con esta licencia podrás realizar las consultas (RFC, CURP, Listas negras, etc)
      Thread threadEdd = new Thread(LeerLicenciaEdl) { Priority = ThreadPriority.Highest };
      threadEdd.Start();
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    public static bool CheckLicense()
    {
      // Verificamos si se ha cargado la licencia de CFDI DATA
      // Si deseas conocer todos los detalles acerca del manejo de la licencia, te invitamos a revisar el demo LICENCIA
      if (HyperSoft.ElectronicDocumentLibrary.Activaction.ActivationStatus == ActivationStatusType.EvaluationExpired)
      {
        string message = string.Format(
          "Estimado usuario:{0}{0}" +
          "Para el correcto funcionamiento de este ejemplo, es necesario cargar{0}" +
          "la licencia que activa la librería E.D.L., si no cuentas con una,{0}" +
          "por favor, ponte en contacto con nosotros a los siguientes teléfonos:{0}{0}" +
          "    - (+52) 55.53.89.76.55{0}" +
          "    - (+52) 55.60.01.63.69{0}{0}" +
          "Si cuentas con una, deberás copiarla a este directorio:{0}{1}{0}{0}" +
          "Atte.{0}" +
          "Facturando",
          Environment.NewLine, License.LicenseDirectory);

        HyperSoft.Shared.Gui.ShowError(message);
        return false;
      }

      ActivationStatusType sdfsdf = HyperSoft.ElectronicDocumentLibrary.Activaction.ActivationStatus;

      // Verificamos si se la licencia cargada esta activa
      // Si deseas conocer todos los detalles acerca del manejo de la licencia, te invitamos a revisar el demo LICENCIA
      if (HyperSoft.ElectronicDocumentLibrary.Activaction.ActivationStatus != ActivationStatusType.Licensed)
      {
        LicenciaForm.ShowData();
        return false;
      }

      return true;
    }

    /// <summary>
    /// Método para uso interno de este ejemplo
    /// </summary>
    private static void LeerLicenciaEdl()
    {
      if (System.IO.File.Exists(LicenseCfdiData) == false)
        return;

      using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(LicenseCfdiData)))
        HyperSoft.ElectronicDocumentLibrary.Activaction.LoadActivationFile(stream);
    }

    #endregion

    #region Factory

    static License()
    {
      LicenseDirectory = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "..\\..\\..\\..\\Licencias"));

      if (Directory.Exists(LicenseDirectory) == false)
        Directory.CreateDirectory(LicenseDirectory);

      string[] files = Directory.GetFiles(LicenseDirectory, "*.license");
      if (files.Length == 0)
        files = new[] { "license.license" };


      LicenseCfdiData = Path.Combine(LicenseDirectory, files[0]);
    }

    #endregion
  }
}
