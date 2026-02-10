using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class EnajenacionAcciones
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      // Se agrega el complemento interes.
      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.EnajenacionAcciones);
      ElectronicDocumentLibrary.ConstanciaRetenciones.EnajenacionAcciones.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.EnajenacionAcciones.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.ContratoIntermediacion.Value = "ContratoIntermediacion";
      data.Ganancia.Value = 1000;
      data.Perdida.Value = 2000;

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Enajenacion_de_Acciones.xml", out fileName);
    }
  }
}
