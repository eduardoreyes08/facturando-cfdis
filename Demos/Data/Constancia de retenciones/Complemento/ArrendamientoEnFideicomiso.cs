using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class ArrendamientoEnFideicomiso
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.ArrendamientoFideicomiso);
      ElectronicDocumentLibrary.ConstanciaRetenciones.ArrendamientoFideicomiso.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.ArrendamientoFideicomiso.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.ImportePago.Value = 1000.00;
      data.ImporteRendimiento.Value = 1200.00;
      data.ImporteDeducciones.Value = 100.00;
      data.MontoTotalRetencion.Value = 100.00;
      data.MontoFibras.Value = 0.00;
      data.MontoOtrosConceptos.Value = 100.00;
      data.DescripcionMontoOtrosConceptos.Value = "Descripción";

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Arrendamiento_en_Fideicomiso.xml", out fileName);
    }
  }
}
