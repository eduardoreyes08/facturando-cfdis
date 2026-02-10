using System.Text;
using HyperSoft.Base;

namespace HyperSoft.Ejemplo.Information
{
  internal static class Utils
  {
    #region Constants

    const string Message = "Este ejemplo no ha sido implementado en su totalidad." +
                        "Si lo requieres, envianos un correo y con gusto lo implementaremos.";


    #endregion

    #region Vars

    private static readonly StringBuilder sb;

    #endregion

    #region Methods

    internal static void ShowTitle(string text)
    {
      sb.AppendLine();
      sb.AppendLine();
      sb.AppendLine(text);
      sb.AppendLine("==========================================================================================");
    }

    internal static void ShowMessage()
    {
      sb.AppendLine(Message);
    }

    internal static void ShowField(string tagName, FieldBase field)
    {
      if (field.IsAssigned)
        ShowValue(tagName, field.AsString());
    }

    internal static void ShowValue(string value)
    {
      sb.AppendLine(value);
    }

    internal static void ShowValue(string tagName, string value)
    {
      sb.AppendLine($"{tagName} : {value}");
    }

    public static string Finalization()
    {
      string result = sb.ToString().Trim();

      sb.Length = 0;
      sb.Capacity = 0;

      return result;
    }

    #endregion

    #region Factory

    static Utils()
    {
      sb = new StringBuilder();
    }

    #endregion
  }
}
