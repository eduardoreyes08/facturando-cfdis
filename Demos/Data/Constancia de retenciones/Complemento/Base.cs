using System;
using System.IO;
using System.Windows.Forms;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class Base
  {
    #region Vars

    private static string directorioSalida;

    #endregion

    #region Methods

    public static void SetConfiguration(string directorio)
    {
      directorioSalida = directorio;
    }

    internal static bool Save(ConstanciaRetenciones constanciaRetenciones, string fileName, out string fullFileName)
    {
      string errorMessage;
      fullFileName = Path.Combine(directorioSalida, fileName);

      if (System.IO.File.Exists(fullFileName))
        HyperSoft.Shared.File.Instance.DeleteFile(fullFileName, out errorMessage);


      using (MemoryStream stream = new MemoryStream())
      {
        // Se ejecuta el proceso de generación
        if (constanciaRetenciones.SaveToStream(stream) == false)
        {
          errorMessage = string.Format("Se generó un error al crear el XML.{0}{0}ERROR{0}{1}", Environment.NewLine, constanciaRetenciones.ErrorText);
          MessageBox.Show(errorMessage, "Complementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }

        try
        {
          System.IO.File.WriteAllBytes(fullFileName, stream.ToArray());
          return true;
        }
        catch (Exception e)
        {
          errorMessage = string.Format("Se generó un error al guardar el archivo XML.{0}{0}ARCHIVO{0}{1}{0}{0}ERROR{0}{2}", Environment.NewLine, fullFileName, e.Message);
          MessageBox.Show(errorMessage, "Complementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
      }
    }
    
    #endregion
  }
}
