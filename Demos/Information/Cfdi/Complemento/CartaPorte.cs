namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class CartaPorte
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data data)
    {
      if (data.Version.Value == "1.0")
        CartaPorte10.Show(data);
      else if (data.Version.Value == "2.0")
        CartaPorte20.Show(data);
      else if (data.Version.Value == "3.0")
        CartaPorte30.Show(data);
      else if (data.Version.Value == "3.1")
        CartaPorte31.Show(data);
    }
  }
}