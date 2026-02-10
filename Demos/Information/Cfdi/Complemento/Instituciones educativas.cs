using HyperSoft.Base;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class InstitucionesEducativas
  {
    internal static void Show(int concepto, ObjectBase value)
    {
      HyperSoft.ElectronicDocumentLibrary.Complemento.InstitucionesEducativas.Data data =
        (HyperSoft.ElectronicDocumentLibrary.Complemento.InstitucionesEducativas.Data) value;

      Utils.ShowTitle($"CONCEPTO {concepto} / COMPLEMENTO INSTITUCIONES EDUCATIVAS");
      Utils.ShowField("Versión          ", data.Version);
      Utils.ShowField("Nombre de alumno ", data.NombreAlumno);
      Utils.ShowField("CURP             ", data.Curp);
      Utils.ShowField("Nivel educativo  ", data.NivelEducativo);
      Utils.ShowField("Autorización RVOE", data.AutorizacionRvoe);
      Utils.ShowField("RFC de pago      ", data.RfcPago);      
    }
  }
}
