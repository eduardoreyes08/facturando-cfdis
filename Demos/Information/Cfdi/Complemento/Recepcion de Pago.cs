using HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class RecepcionPago
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO RECIBO DE PAGO");
      Utils.ShowField("Versión               ", data.Version);

      Utils.ShowTitle("TOTALES");
      Utils.ShowField("Total retenciones IVA          ", data.Totales.TotalRetencionesIva);
      Utils.ShowField("Total retenciones ISR          ", data.Totales.TotalRetencionesIsr);
      Utils.ShowField("Total retenciones IEPS         ", data.Totales.TotalRetencionesIeps);
      Utils.ShowField("Total traslados base IVA 16    ", data.Totales.TotalTrasladosBaseIva16);
      Utils.ShowField("Total traslados impuesto IVA 16", data.Totales.TotalTrasladosImpuestoIva16);
      Utils.ShowField("Total traslados base IVA 8     ", data.Totales.TotalTrasladosBaseIva8);
      Utils.ShowField("Total traslados impuesto IVA 8 ", data.Totales.TotalTrasladosImpuestoIva8);
      Utils.ShowField("Total traslados base IVA 0     ", data.Totales.TotalTrasladosBaseIva0);
      Utils.ShowField("Total traslados impuesto IVA 0 ", data.Totales.TotalTrasladosImpuestoIva0);
      Utils.ShowField("Total traslados base IVA exento", data.Totales.TotalTrasladosBaseIvaExento);
      Utils.ShowField("Monto total de pagos           ", data.Totales.MontoTotalPagos);
      
      if (data.Pagos.IsAssigned == false)
        return;

      for (int i = 0; i < data.Pagos.Count; i++)
      {
        Pago pago = data.Pagos[i];

        string title = $"PAGO - {i + 1}";

        Utils.ShowTitle(title);
        Utils.ShowField("Fecha de pago                       ", pago.FechaPago);
        Utils.ShowField("Forma de pago                       ", pago.FormaPago);
        Utils.ShowField("Moneda                              ", pago.Moneda);
        Utils.ShowField("Tipo de cambio                      ", pago.TipoCambio);
        Utils.ShowField("Monto                               ", pago.Monto);
        Utils.ShowField("Número de la operación              ", pago.NumeroOperacion);
        Utils.ShowField("RFC emisor cuenta ordenante         ", pago.RfcEmisorCuentaOrdenante);
        Utils.ShowField("Nombre del banco ordenante extrajero", pago.NombreBancoOrdenanteExtrajero);
        Utils.ShowField("Cuenta del ordenante                ", pago.CuentaOrdenante);
        Utils.ShowField("Rfc del emisor cuenta beneficiario  ", pago.RfcEmisorCuentaBeneficiario);
        Utils.ShowField("Cuenta del beneficiario             ", pago.CuentaBeneficiario);
        Utils.ShowField("Tipo de cadena de pago              ", pago.TipoCadenaPago);
        Utils.ShowField("Certificado de pago                 ", pago.CertificadoPago);
        Utils.ShowField("Cadena original de pago             ", pago.CadenaOriginalPago);
        Utils.ShowField("Sello de pago                       ", pago.SelloPago);

        for (int j = 0; j < pago.DocumentosRelacionados.Count; j++)
        {
          DocumentoRelacionado documento = pago.DocumentosRelacionados[j];

          title = $"{title} / DOCUMENTOS - {j + 1}";
          Utils.ShowTitle(title);
          Utils.ShowField("IdDocumento           ", documento.IdDocumento);
          Utils.ShowField("Serie                 ", documento.Serie);
          Utils.ShowField("Folio                 ", documento.Folio);
          Utils.ShowField("Moneda                ", documento.Moneda);
          Utils.ShowField("Tipo de cambio        ", documento.TipoCambio);
          Utils.ShowField("Equivalencia          ", documento.Equivalencia);
          Utils.ShowField("Número de parcialidad ", documento.NumeroParcialidad);
          Utils.ShowField("Importe saldo anterior", documento.ImporteSaldoAnterior);
          Utils.ShowField("Importe pagado        ", documento.ImportePagado);
          Utils.ShowField("Importe saldo insoluto", documento.ImporteSaldoInsoluto);
          Utils.ShowField("Objeto de impuesto    ", documento.ObjetoImpuesto);
          Utils.ShowField("Metodo de pago        ", documento.MetodoPago);

          for (int k = 0; k < documento.Impuestos.Retenciones.Count; k++)
          {
            Utils.ShowTitle($"{title} / RETENCIONES - {k + 1}");

            Utils.ShowField("Base          ", documento.Impuestos.Retenciones[k].Base);
            Utils.ShowField("Impuesto      ", documento.Impuestos.Retenciones[k].Impuesto);
            Utils.ShowField("Tipo de factor", documento.Impuestos.Retenciones[k].TipoFactor);
            Utils.ShowField("Tasa o cuota  ", documento.Impuestos.Retenciones[k].TasaCuota);
            Utils.ShowField("Importe       ", documento.Impuestos.Retenciones[k].Importe);
          }

          for (int k = 0; k < documento.Impuestos.Traslados.Count; k++)
          {
            Utils.ShowTitle($"{title} / TRASLADOS - {k + 1}");

            Utils.ShowField("Base          ", documento.Impuestos.Traslados[k].Base);
            Utils.ShowField("Impuesto      ", documento.Impuestos.Traslados[k].Impuesto);
            Utils.ShowField("Tipo de factor", documento.Impuestos.Traslados[k].TipoFactor);
            Utils.ShowField("Tasa o cuota  ", documento.Impuestos.Traslados[k].TasaCuota);
            Utils.ShowField("Importe       ", documento.Impuestos.Traslados[k].Importe);
          }
        }

        if (pago.Impuestos.IsAssigned == false)
          continue;

        for (int j = 0; j < pago.Impuestos.Count; j++)
        {
          Impuesto impuesto = pago.Impuestos[j];
          Utils.ShowTitle($"PAGO - {i + 1} / IMPUESTOS - {j + 1}");

          Utils.ShowField("Total impuestos retenidos  ", impuesto.TotalImpuestosRetenidos);
          Utils.ShowField("Total impuestos trasladados", impuesto.TotalImpuestosTrasladados);

          for (int k = 0; k < impuesto.Retenciones.Count; k++)
          {
            Utils.ShowTitle($"PAGO - {i + 1} / IMPUESTOS - {j + 1} /  RETENCIONES - {k + 1}");

            Utils.ShowField("Impuesto", impuesto.Retenciones[k].Impuesto);
            Utils.ShowField("Importe ", impuesto.Retenciones[k].Importe);
          }

          for (int k = 0; k < impuesto.Traslados.Count; k++)
          {
            Utils.ShowTitle($"PAGO - {i + 1} / IMPUESTOS - {j + 1} /  TRASLADOS - {k + 1}");

            Utils.ShowField("Base          ", impuesto.Traslados[k].Base);
            Utils.ShowField("Impuesto      ", impuesto.Traslados[k].Impuesto);
            Utils.ShowField("Tipo de factor", impuesto.Traslados[k].TipoFactor);
            Utils.ShowField("Tasa o cuota  ", impuesto.Traslados[k].TasaCuota);
            Utils.ShowField("Importe       ", impuesto.Traslados[k].Importe);
          }
        }
      }
    }
  }
}