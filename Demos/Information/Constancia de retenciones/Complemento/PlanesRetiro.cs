namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class PlanesRetiro
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones.PlanesRetiro.Data data)
    {
      if (data.Version.Value == "1.0")
        PlanesRetiro10.Show(data);
      else if (data.Version.Value == "1.1")
        PlanesRetiro11.Show(data);      
    }
  }
}
