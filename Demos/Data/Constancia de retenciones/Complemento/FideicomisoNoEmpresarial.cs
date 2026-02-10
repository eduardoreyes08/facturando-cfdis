using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class FideicomisoNoEmpresarial
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.FideicomisoNoEmpresarial);
      ElectronicDocumentLibrary.ConstanciaRetenciones.FideicomisoNoEmpresarial.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.FideicomisoNoEmpresarial.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";

      data.IngresosEntradas.MontoTotal.Value = 500;
      data.IngresosEntradas.ParteProporcional.Value = 200;
      data.IngresosEntradas.Proporcion.Value = 300;
      data.IngresosEntradas.IntegracionIngresos.Concepto.Value = "Entradas";

      data.DeduccionesSalidas.MontoTotal.Value = 400;
      data.DeduccionesSalidas.ParteProporcional.Value = 250;
      data.DeduccionesSalidas.Proporcion.Value = 150;
      data.DeduccionesSalidas.IntegracionEngresos.Conceptos.Value = "Salidas";

      data.Retenciones.Monto.Value = 450;
      data.Retenciones.Descripcion.Value = "Retenciones";

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Fideicomiso_No_Empresarial.xml", out fileName);
    }
  }
}