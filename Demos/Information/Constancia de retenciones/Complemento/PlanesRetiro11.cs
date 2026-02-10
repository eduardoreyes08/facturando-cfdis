namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class PlanesRetiro11
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.PlanesRetiro.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO PLANES DE RETIRO");
      Utils.ShowField("Version                           ", data.Version);
      Utils.ShowField("SistemaFinanciero                 ", data.SistemaFinanciero);
      Utils.ShowField("MontoTotalAportaciones            ", data.MontoTotalAportaciones);
      Utils.ShowField("MontoInteresesReales              ", data.MontoInteresesReales);
      Utils.ShowField("HuboRetirosAnioAnteriorPermanencia", data.HuboRetirosAnioAnteriorPermanencia);
      Utils.ShowField("MontoTotalRetiro                  ", data.MontoTotalRetiro);
      Utils.ShowField("MontoTotalExentoRetiro            ", data.MontoTotalExentoRetiro);
      Utils.ShowField("MontoTotalExedente                ", data.MontoTotalExedente);
      Utils.ShowField("HuboRetirosAnioInmediatoAnterior  ", data.HuboRetirosAnioInmediatoAnterior);
      Utils.ShowField("MontTotalRetirado                 ", data.MontTotalRetirado);      
      Utils.ShowField("NumeroReferencia                  ", data.NumeroReferencia);

      for (int i = 0; i < data.AportacionesDepositos.Count; i++)
      {
        Utils.ShowTitle("PLANES DE RETIRO / APORTACIONESDEPOSITOS - " + (i + 1));
        Utils.ShowField("Tipo         ", data.AportacionesDepositos[i].Tipo);
        Utils.ShowField("Monto        ", data.AportacionesDepositos[i].Monto);
        Utils.ShowField("RfcFiduciaria", data.AportacionesDepositos[i].RfcFiduciaria);        
      }
    }
  }
}