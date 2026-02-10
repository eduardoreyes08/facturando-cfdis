using HyperSoft.ElectronicDocumentLibrary.Contabilidad.Poliza;

namespace HyperSoft.Ejemplo.Information
{
  public static class PolizaContabilidad
  {
    public static string Show(PolizaContable data)
    {
      Utils.ShowTitle("POLIZAS");
      Utils.ShowField("Versión          ", data.Data.Version);
      Utils.ShowField("RFC              ", data.Data.Rfc);
      Utils.ShowField("Mes              ", data.Data.Mes);
      Utils.ShowField("Año              ", data.Data.Anio);
      Utils.ShowField("Tipo de solicitud", data.Data.TipoSolicitud);
      Utils.ShowField("Número de órden  ", data.Data.NumeroOrden);
      Utils.ShowField("Número de tramite", data.Data.NumeroTramite);
      Utils.ShowField("Sello            ", data.Data.Sello);
      Utils.ShowField("No de certificado", data.Data.NumeroCertificado);
      //ShowField("Certificado      ", polizaContable.Data.Certificado);

      for (int i = 0; i < data.Data.Polizas.Count; i++)
      {
        Poliza poliza = data.Data.Polizas[i];

        Utils.ShowTitle("POLIZA - " + (i + 1));
        Utils.ShowField("Número  ", poliza.Numero);
        Utils.ShowField("Fecha   ", poliza.Fecha);
        Utils.ShowField("Concepto", poliza.Concepto);

        for (int j = 0; j < poliza.Transacciones.Count; j++)
        {
          Transaccion transaccion = poliza.Transacciones[j];

          Utils.ShowTitle("TRANSACCION - " + (j + 1));
          Utils.ShowField("Número de la cuenta", transaccion.NumeroCuenta);
          Utils.ShowField("Nombre de la cuenta", transaccion.NombreCuenta);
          Utils.ShowField("Concepto           ", transaccion.Concepto);
          Utils.ShowField("Debe               ", transaccion.Debe);
          Utils.ShowField("Haber              ", transaccion.Haber);

          for (int k = 0; k < transaccion.ComprobantesNacional.Count; k++)
          {
            ComprobanteNacional nacional = transaccion.ComprobantesNacional[k];

            Utils.ShowTitle("COMPROBANTE NACIONAL - " + (k + 1));
            Utils.ShowField("Uuid          ", nacional.Uuid);
            Utils.ShowField("RFC           ", nacional.Rfc);
            Utils.ShowField("Monto total   ", nacional.MontoTotal);
            Utils.ShowField("Moneda        ", nacional.Moneda);
            Utils.ShowField("Tipo de cambio", nacional.TipoCambio);
          }

          for (int k = 0; k < transaccion.ComprobantesNacionalOtro.Count; k++)
          {
            ComprobanteNacionalOtro nacionalOtro = transaccion.ComprobantesNacionalOtro[k];

            Utils.ShowTitle("COMPROBANTE NACIONAL OTRO - " + (k + 1));
            Utils.ShowField("Serie         ", nacionalOtro.Serie);
            Utils.ShowField("Folio         ", nacionalOtro.Folio);
            Utils.ShowField("RFC           ", nacionalOtro.Rfc);
            Utils.ShowField("Monto total   ", nacionalOtro.MontoTotal);
            Utils.ShowField("Moneda        ", nacionalOtro.Moneda);
            Utils.ShowField("Tipo de cambio", nacionalOtro.TipoCambio);
          }

          for (int k = 0; k < transaccion.ComprobantesExtranjero.Count; k++)
          {
            ComprobanteExtranjero extranjero = transaccion.ComprobantesExtranjero[k];

            Utils.ShowTitle("COMPROBANTE EXTRANJERO - " + (k + 1));
            Utils.ShowField("Número de factura", extranjero.NumeroFactura);
            Utils.ShowField("Tax              ", extranjero.TaxId);
            Utils.ShowField("Monto total      ", extranjero.MontoTotal);
            Utils.ShowField("Moneda           ", extranjero.Moneda);
            Utils.ShowField("Tipo de cambio   ", extranjero.TipoCambio);
          }

          for (int k = 0; k < transaccion.Cheques.Count; k++)
          {
            Cheque cheque = transaccion.Cheques[k];

            Utils.ShowTitle("CHEQUE - " + (k + 1));
            Utils.ShowField("Número", cheque.Numero);
            Utils.ShowField("Banco emisor nacional  ", cheque.BancoEmisorNacional);
            Utils.ShowField("Banco emisor extranjero", cheque.BancoEmisorExtranjero);
            Utils.ShowField("Cuenta origen          ", cheque.CuentaOrigen);
            Utils.ShowField("Fecha                  ", cheque.Fecha);
            Utils.ShowField("Beneficiario           ", cheque.Beneficiario);
            Utils.ShowField("RFC                    ", cheque.Rfc);
            Utils.ShowField("Monto                  ", cheque.Monto);
            Utils.ShowField("Moneda                 ", cheque.Moneda);
            Utils.ShowField("Tipo de cambio         ", cheque.TipoCambio);
          }

          for (int k = 0; k < transaccion.Transferencias.Count; k++)
          {
            Transferencia transferencia = transaccion.Transferencias[k];

            Utils.ShowTitle("TRANSFERENCIA - " + (k + 1));
            Utils.ShowField("Cuenta origen           ", transferencia.CuentaOrigen);
            Utils.ShowField("Banco origen nacional   ", transferencia.BancoOrigenNacional);
            Utils.ShowField("Banco destino extranjero", transferencia.BancoDestinoExtranjero);
            Utils.ShowField("Cuenta destino          ", transferencia.CuentaDestino);
            Utils.ShowField("Banco destino nacional  ", transferencia.BancoDestinoNacional);
            Utils.ShowField("Banco destino extranjero", transferencia.BancoDestinoExtranjero);
            Utils.ShowField("Fecha                   ", transferencia.Fecha);
            Utils.ShowField("Beneficiario            ", transferencia.Beneficiario);
            Utils.ShowField("RFC                     ", transferencia.Rfc);
            Utils.ShowField("Monto                   ", transferencia.Monto);
            Utils.ShowField("Moneda                  ", transferencia.Moneda);
            Utils.ShowField("Tipo de cambio          ", transferencia.TipoCambio);
          }

          for (int k = 0; k < transaccion.OtrosMetodosPago.Count; k++)
          {
            OtroMetodoPago otroMetodoPago = transaccion.OtrosMetodosPago[k];

            Utils.ShowTitle("OTRO METODO DE PAGO - " + (k + 1));
            Utils.ShowField("Método de pago", otroMetodoPago.MetodoPago);
            Utils.ShowField("Fecha         ", otroMetodoPago.Fecha);
            Utils.ShowField("Beneficiario  ", otroMetodoPago.Beneficiario);
            Utils.ShowField("RFC           ", otroMetodoPago.Rfc);
            Utils.ShowField("Monto         ", otroMetodoPago.Monto);
            Utils.ShowField("Moneda        ", otroMetodoPago.Moneda);
            Utils.ShowField("Tipo de cambio", otroMetodoPago.TipoCambio);
          }
        }
      }

      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue(data.FingerPrint);

      return Utils.Finalization();
    }
  }
}