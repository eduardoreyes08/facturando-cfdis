using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class InteresesHipotecarios
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.InteresesHipotecarios);
      ElectronicDocumentLibrary.ConstanciaRetenciones.InteresesHipotecarios.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.InteresesHipotecarios.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.CreditoInstitucionFinanciera.Value = "SI";
      data.SaldoInsoluto.Value = 10000;
      data.ProporcionDeducibleCredito.Value = 200;
      data.MontoTotalInteresesNominalesDevengatos.Value = 450;
      data.MontoTotalInteresesNominalesDevengatosPagados.Value = 400;
      data.MontoTotalInteresesRealPagadoDeducible.Value = 200;
      data.NumeroContrato.Value = "NumeroContrato";

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Intereses_Hipotecarios.xml", out fileName);
    }
  }
}