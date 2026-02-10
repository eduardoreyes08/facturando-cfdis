using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HyperSoft.Ejemplo.Utilerias
{
  public static class Utils
  {
    public static string CreateDirectory()
    {
      string applicationDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));

      string directory = Path.Combine(applicationDirectory, "Generados");
      if (Directory.Exists(directory))
        return directory;

      try
      {
        Directory.CreateDirectory(directory);

        return directory;
      }
      catch (Exception)
      {
        throw new Exception(string.Format("No se pudo crear el directorio donde se van a almacenar los archivos XML.{0}{0}{1}", Environment.NewLine, directory));                
      }      
    }

    public static void ShowVersion(bool ecodex = false, bool pax = false)
    {
      Application.OpenForms[0].Enabled = false;
      try
      {
        using (new HyperSoft.Shared.WaitCursor())
        {
          StringBuilder sb = new StringBuilder();

          sb.AppendLine(Assembly.BaseInfo());
          sb.AppendLine(Assembly.EdlInfo());
          sb.AppendLine(Assembly.SharedInfo());
          sb.AppendLine(Assembly.BarCodeInfo());
          sb.AppendLine(Assembly.ResourceInfo());

          if (ecodex)
            sb.AppendLine(Assembly.EcodexInfo());

          if (pax)
            sb.AppendLine(Assembly.PaxInfo());

          VersionsForm.ShowData(sb.ToString());
        }
      }
      finally
      {
        Application.OpenForms[0].Enabled = true;
      }      
    }

    public static bool SelectFile(ref string fileName)
    {
      string initialDirectory = string.IsNullOrWhiteSpace(fileName)
        ? string.Empty
        : Path.GetDirectoryName(fileName);

      if (string.IsNullOrWhiteSpace(initialDirectory))
        initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

      OpenFileDialog dialog = new OpenFileDialog
      {
        InitialDirectory = initialDirectory,
        Filter = @"Archivo XML (*.xml)|*.xml",
        FilterIndex = 0,
        RestoreDirectory = true
      };

      if (dialog.ShowDialog() != DialogResult.OK)
        return false;

      fileName = dialog.FileName;
      return true;
    }
  }
}
