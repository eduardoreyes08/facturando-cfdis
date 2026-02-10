namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class ComercioExterior
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data)
    {
      if (data.Version.Value == "1.0")
        ComercioExterior10.Show(data);
      else if (data.Version.Value == "1.1")
        ComercioExterior11.Show(data);
      else if (data.Version.Value == "2.0")
        ComercioExterior20.Show(data);
    }
  }
}