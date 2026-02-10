using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class Dividendos
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.Dividendos);
      ElectronicDocumentLibrary.ConstanciaRetenciones.Dividendos.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.Dividendos.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";

      data.DividendosUtilidades.ClaveTipoDividendo.Value = "01";
      data.DividendosUtilidades.MontoIsrMexico.Value = 100;
      data.DividendosUtilidades.MontoIsrExtranjero.Value = 200;
      data.DividendosUtilidades.MontoRetencionExtranjero.Value = 200;
      data.DividendosUtilidades.TipoSociedad.Value = "Sociedad Extranjera";
      data.DividendosUtilidades.MontoIsrNacional.Value = 100;
      data.DividendosUtilidades.MontoDividendoNacional.Value = 200;
      data.DividendosUtilidades.MontoDividendoExtranjero.Value = 400;

      data.Remanente.Proporcion.Value = 7;

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Dividendos.xml", out fileName);
    }
  }
}
