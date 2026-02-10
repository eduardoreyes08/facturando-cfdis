namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class InteresesHipotecarios
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.InteresesHipotecarios.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO INTERESES HIPOTECARIOS");
      Utils.ShowField("Version                                      ", data.Version);
      Utils.ShowField("CreditoInstitucionFinanciera                 ", data.CreditoInstitucionFinanciera);
      Utils.ShowField("SaldoInsoluto                                ", data.SaldoInsoluto);
      Utils.ShowField("ProporcionDeducibleCredito                   ", data.ProporcionDeducibleCredito);
      Utils.ShowField("MontoTotalInteresesNominalesDevengatos       ", data.MontoTotalInteresesNominalesDevengatos);
      Utils.ShowField("MontoTotalInteresesNominalesDevengatosPagados", data.MontoTotalInteresesNominalesDevengatosPagados);
      Utils.ShowField("MontoTotalInteresesRealPagadoDeducible       ", data.MontoTotalInteresesRealPagadoDeducible);
      Utils.ShowField("NumeroContrato                               ", data.NumeroContrato);      
    }
  }
}