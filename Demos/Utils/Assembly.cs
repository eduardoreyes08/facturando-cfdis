using System;
using System.Threading;

namespace HyperSoft.Ejemplo.Utilerias
{
  internal static class Assembly
  {
    internal static string SharedInfo()
    {
      string text = Pad("HyperSoft.Shared");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.Shared.Base64)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    internal static string BaseInfo()
    {
      string text = Pad("HyperSoft.Base");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.Base.FieldBase)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    internal static string EdlInfo()
    {
      string text = Pad("HyperSoft.ElectronicDocumentLibrary");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.ElectronicDocumentLibrary.Proxy)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    internal static string BarCodeInfo()
    {
      string text = Pad("HyperSoft.BarCodeLibrary");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.BarCodeLibrary.BarCode)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    internal static string ResourceInfo()
    {
      string text = Pad("HyperSoft.Resource");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.Resource.Rfc)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    internal static string EcodexInfo()
    {
      string text = Pad("HyperSoft.ElectronicDocumentLibrary.ECodex");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.ElectronicDocumentLibrary.ECodex.Proveedor)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    internal static string PaxInfo()
    {
      string text = Pad("HyperSoft.ElectronicDocumentLibrary.Pax");
      try
      {
        Version version = System.Reflection.Assembly.GetAssembly(typeof(HyperSoft.ElectronicDocumentLibrary.Pax.Proveedor)).GetName().Version;
        text += $"{version.Major:0000}.{version.Minor:00}.{version.Build:00}.{version.Revision}";
      }
      catch (Exception)
      {
        //
      }

      return text;
    }

    private static string Pad(string text)
    {
      return $" {text.PadRight(45, ' ')}";
    }
  }
}
