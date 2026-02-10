namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class FideicomisoNoEmpresarial
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.FideicomisoNoEmpresarial.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO FIDEICOMISO NO EMPRESARIAL");
      Utils.ShowField("Version", data.Version);

      Utils.ShowTitle("COMPLEMENTO FIDEICOMISO NO EMPRESARIAL - INGRESOSENTRADAS");
      Utils.ShowField("MontoTotal       ", data.IngresosEntradas.MontoTotal);
      Utils.ShowField("ParteProporcional", data.IngresosEntradas.ParteProporcional);
      Utils.ShowField("Proporcion       ", data.IngresosEntradas.Proporcion);
      Utils.ShowField("Concepto         ", data.IngresosEntradas.IntegracionIngresos.Concepto);

      Utils.ShowTitle("COMPLEMENTO FIDEICOMISO NO EMPRESARIAL - DEDUCCIONESSALIDAS");
      Utils.ShowField("MontoTotal       ", data.DeduccionesSalidas.MontoTotal);
      Utils.ShowField("ParteProporcional", data.DeduccionesSalidas.ParteProporcional);
      Utils.ShowField("Proporcion       ", data.DeduccionesSalidas.Proporcion);
      Utils.ShowField("Concepto         ", data.DeduccionesSalidas.IntegracionEngresos.Conceptos);

      Utils.ShowTitle("COMPLEMENTO FIDEICOMISO NO EMPRESARIAL - RETENCIONES");
      Utils.ShowField("Monto      ", data.Retenciones.Monto);
      Utils.ShowField("Descripcion", data.Retenciones.Descripcion);
    }
  }
}