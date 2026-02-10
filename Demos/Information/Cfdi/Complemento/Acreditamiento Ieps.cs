using HyperSoft.Base;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class AcreditamientoIeps
  {
    internal static void Show(int concepto, ObjectBase value)
    {
      HyperSoft.ElectronicDocumentLibrary.Complemento.AcreditamientoIeps.Data data =
        (HyperSoft.ElectronicDocumentLibrary.Complemento.AcreditamientoIeps.Data) value;

      Utils.ShowTitle($"CONCEPTO {concepto} / COMPLEMENTO ACREDITAMIENTO DEL IEPS");
      Utils.ShowField("Versión                             ", data.Version);
      Utils.ShowField("Terminal de Almacenamiento y Reparto", data.Tar);
    }
  }
}
