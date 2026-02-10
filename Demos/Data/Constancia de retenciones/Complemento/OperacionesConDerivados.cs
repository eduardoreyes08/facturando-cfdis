using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class OperacionesConDerivados
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.OperacionesConDerivados);
      ElectronicDocumentLibrary.ConstanciaRetenciones.OperacionesConDerivados.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.OperacionesConDerivados.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.MontoGanancia.Value = 10000;
      data.MontoPerdida.Value = 500;

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Operaciones_Con_Derivados.xml", out fileName);
    }
  }
}
