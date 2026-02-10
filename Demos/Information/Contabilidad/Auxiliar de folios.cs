using HyperSoft.ElectronicDocumentLibrary.Contabilidad.AuxiliarFolios;

namespace HyperSoft.Ejemplo.Information
{
  public static class Folios
  {
    public static string Show(AuxiliarFolios auxiliarFolios)
    {
      Utils.ShowTitle("AUXILIAR DE FOLIOS");
      Utils.ShowField("Versión          ", auxiliarFolios.Data.Version);
      Utils.ShowField("RFC              ", auxiliarFolios.Data.Rfc);
      Utils.ShowField("Mes              ", auxiliarFolios.Data.Mes);
      Utils.ShowField("Año              ", auxiliarFolios.Data.Anio);
      Utils.ShowField("Tipo de solicitud", auxiliarFolios.Data.TipoSolicitud);
      Utils.ShowField("Número de orden  ", auxiliarFolios.Data.NumeroOrden);
      Utils.ShowField("Número de tramite", auxiliarFolios.Data.NumeroTramite);
      Utils.ShowField("Sello            ", auxiliarFolios.Data.Sello);
      Utils.ShowField("No de certificado", auxiliarFolios.Data.NumeroCertificado);
      //ShowField("Certificado      ", auxiliarFolios.Data.Certificado);

      for (int i = 0; i < auxiliarFolios.Data.Detalles.Count; i++)
      {
        Detalle detalle = auxiliarFolios.Data.Detalles[i];

        Utils.ShowTitle("DETALLE - " + (i + 1));
        Utils.ShowField("Número", detalle.Numero);
        Utils.ShowField("Fecha ", detalle.Fecha);

        for (int j = 0; j < detalle.ComprobantesNacional.Count; j++)
        {
          ComprobanteNacional nacional = detalle.ComprobantesNacional[j];

          Utils.ShowTitle("COMPROBANTE NACIONAL - " + (j + 1));
          Utils.ShowField("UUID          ", nacional.Uuid);
          Utils.ShowField("Monto total   ", nacional.MontoTotal);
          Utils.ShowField("RFC           ", nacional.Rfc);
          Utils.ShowField("Método de pago", nacional.MetodoPago);
          Utils.ShowField("Moneda        ", nacional.Moneda);
          Utils.ShowField("Tipo de cambio", nacional.TipoCambio);
        }

        for (int j = 0; j < detalle.ComprobantesNacionalOtro.Count; j++)
        {
          ComprobanteNacionalOtro nacionalOtro = detalle.ComprobantesNacionalOtro[j];

          Utils.ShowTitle("COMPROBANTE NACIONAL OTRO - " + (j + 1));
          Utils.ShowField("Serie         ", nacionalOtro.Serie);
          Utils.ShowField("Folio         ", nacionalOtro.Folio);
          Utils.ShowField("Monto total   ", nacionalOtro.MontoTotal);
          Utils.ShowField("RFC           ", nacionalOtro.Rfc);
          Utils.ShowField("Método de pago", nacionalOtro.MetodoPago);
          Utils.ShowField("Moneda        ", nacionalOtro.Moneda);
          Utils.ShowField("Tipo de cambio", nacionalOtro.TipoCambio);
        }

        for (int j = 0; j < detalle.ComprobantesExtranjero.Count; j++)
        {
          ComprobanteExtranjero extranjero = detalle.ComprobantesExtranjero[j];

          Utils.ShowTitle("COMPROBANTE EXTRANJERO - " + (j + 1));
          Utils.ShowField("Número de factura", extranjero.NumeroFactura);
          Utils.ShowField("Tax ID           ", extranjero.TaxId);
          Utils.ShowField("Monto total      ", extranjero.MontoTotal);
          Utils.ShowField("Método de pago   ", extranjero.MetodoPago);
          Utils.ShowField("Moneda           ", extranjero.Moneda);
          Utils.ShowField("Tipo de cambio   ", extranjero.TipoCambio);
        }
      }

      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue(auxiliarFolios.FingerPrint);

      return Utils.Finalization();
    }
  }
}