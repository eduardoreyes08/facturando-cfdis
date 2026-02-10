using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ReciboPago10
  {
    /// <summary>
    /// Este ejemplo carga los datos para el timbrado para un recibo de pago 1.0
    /// </summary>
    /// <param name="electronicDocument"></param>
    public static void CargarDatosTimbrado(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi33(electronicDocument.Data);

      // Se agrega el complemento RECIBO DE PAGO
      electronicDocument.Data.Complementos.Add(ComplementoType.RecepcionPago);
      HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      Pago pago = data.Pagos.Add();

      pago.FechaPago.Value = DateTime.Now;
      pago.FormaPago.Value = "01";
      pago.Moneda.Value = "MXN";
      pago.Monto.Value = 100;
      pago.NumeroOperacion.Value = "01";
      pago.NombreBancoOrdenanteExtrajero.Value = "Banco";
      
      DocumentoRelacionado documentoRelacionado = pago.DocumentosRelacionados.Add();
      documentoRelacionado.IdDocumento.Value = "708d3743-1a32-4ddc-9f70-4cd1c301623e";
      documentoRelacionado.Serie.Value = "SERIE";
      documentoRelacionado.Folio.Value = "1";
      documentoRelacionado.Moneda.Value = "MXN";
      documentoRelacionado.MetodoPago.Value = "PPD";
      documentoRelacionado.NumeroParcialidad.Value = 1;
      documentoRelacionado.ImporteSaldoAnterior.Value = 100;
      documentoRelacionado.ImportePagado.Value = 50;
      documentoRelacionado.ImporteSaldoInsoluto.Value = 50;

      documentoRelacionado = pago.DocumentosRelacionados.Add();
      documentoRelacionado.IdDocumento.Value = "708d3743-1a32-4ddc-9f70-4cd1c301623d";
      documentoRelacionado.Serie.Value = "SERIE";
      documentoRelacionado.Folio.Value = "2";
      documentoRelacionado.Moneda.Value = "MXN";
      documentoRelacionado.MetodoPago.Value = "PPD";
      documentoRelacionado.NumeroParcialidad.Value = 1;
      documentoRelacionado.ImporteSaldoAnterior.Value = 100;
      documentoRelacionado.ImportePagado.Value = 50;
      documentoRelacionado.ImporteSaldoInsoluto.Value = 50;
    }

    /// <summary>
    /// Este ejemplo muestra como usar todas las clases y propiedades para el RECIBO DE PAGO 2.0
    /// </summary>
    /// <param name="electronicDocument"></param>
    public static void CargarDatosCompleto(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi33(electronicDocument.Data);

      // Se agrega el complemento RECIBO DE PAGO
      electronicDocument.Data.Complementos.Add(ComplementoType.RecepcionPago);
      HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      Pago pago = data.Pagos.Add();

      pago.FechaPago.Value = DateTime.Now;
      pago.FormaPago.Value = "01";
      pago.Moneda.Value = "MXN";
      pago.TipoCambio.Value = 20.000000;
      pago.Monto.Value = 100;
      pago.NumeroOperacion.Value = "01";
      pago.RfcEmisorCuentaOrdenante.Value = "AAA010101AAA";
      pago.NombreBancoOrdenanteExtrajero.Value = "Banco ordenante";
      pago.CuentaOrdenante.Value = "1234567890";
      pago.RfcEmisorCuentaBeneficiario.Value = "AAA010101AAA";
      pago.CuentaBeneficiario.Value = "1234567890";
      pago.TipoCadenaPago.Value = "01";
      pago.CertificadoPago.Value = "UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi";
      pago.CadenaOriginalPago.Value = "X";
      pago.SelloPago.Value = "UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi";

      DocumentoRelacionado documentoRelacionado = pago.DocumentosRelacionados.Add();
      documentoRelacionado.IdDocumento.Value = "708d3743-1a32-4ddc-9f70-4cd1c301623e";
      documentoRelacionado.Serie.Value = "SERIE";
      documentoRelacionado.Folio.Value = "1";
      documentoRelacionado.Moneda.Value = "MXN";
      documentoRelacionado.TipoCambio.Value = 0.000001;
      documentoRelacionado.MetodoPago.Value = "PPD";
      documentoRelacionado.NumeroParcialidad.Value = 1;
      documentoRelacionado.ImporteSaldoAnterior.Value = 100;
      documentoRelacionado.ImportePagado.Value = 50;
      documentoRelacionado.ImporteSaldoInsoluto.Value = 50;

      // IMPUESTOS DEBE EXISTIR CUANDO SE TRATE DE UN ANTICIPO
      HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Impuesto impuesto = pago.Impuestos.Add();
      impuesto.TotalImpuestosTrasladados.Value = 16;
      impuesto.TotalImpuestosRetenidos.Value = 0;

      HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Traslado trasladoComplemento = impuesto.Traslados.Add();
      trasladoComplemento.Impuesto.Value = "002";
      trasladoComplemento.TipoFactor.Value = "Tasa";
      trasladoComplemento.TasaCuota.Value = 0.160000;
      trasladoComplemento.Importe.Value = 16;

      Retencion retenidoComplemento = impuesto.Retenciones.Add();
      retenidoComplemento.Impuesto.Value = "002";
      retenidoComplemento.Importe.Value = 0;
    }

    public static void CargarDatosListas(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi33(electronicDocument.Data);

      // Se agrega el complemento RECIBO DE PAGO
      electronicDocument.Data.Complementos.Add(ComplementoType.RecepcionPago);
      HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";

      for (int i = 1; i <= 2; i++)
      {
        Pago pago = data.Pagos.Add();
        pago.FechaPago.Value = DateTime.Now;
        pago.FormaPago.Value = "01";
        pago.Moneda.Value = "MXN";
        pago.TipoCambio.Value = 20.000000;
        pago.Monto.Value = 100;
        pago.NumeroOperacion.Value = "01";
        pago.RfcEmisorCuentaOrdenante.Value = "AAA010101AAA";
        pago.NombreBancoOrdenanteExtrajero.Value = "Banco ordenante";
        pago.CuentaOrdenante.Value = "1234567890";
        pago.RfcEmisorCuentaBeneficiario.Value = "AAA010101AAA";
        pago.CuentaBeneficiario.Value = "1234567890";
        pago.TipoCadenaPago.Value = "01";
        pago.CertificadoPago.Value = "UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi";
        pago.CadenaOriginalPago.Value = "X";
        pago.SelloPago.Value = "UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi";

        for (int j = 1; j <= 3; j++)
        {
          DocumentoRelacionado documentoRelacionado = pago.DocumentosRelacionados.Add();
          documentoRelacionado.IdDocumento.Value = "708d3743-1a32-4ddc-9f70-4cd1c301623e";
          documentoRelacionado.Serie.Value = "SERIE";
          documentoRelacionado.Folio.Value = "1";
          documentoRelacionado.Moneda.Value = "MXN";
          documentoRelacionado.TipoCambio.Value = 0.000001;
          documentoRelacionado.MetodoPago.Value = "PPD";
          documentoRelacionado.NumeroParcialidad.Value = 1;
          documentoRelacionado.ImporteSaldoAnterior.Value = 100;
          documentoRelacionado.ImportePagado.Value = 50;
          documentoRelacionado.ImporteSaldoInsoluto.Value = 50;
        }

        for (int j = 1; j <= 4; j++)
        {
          HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Impuesto impuesto = pago.Impuestos.Add();
          impuesto.TotalImpuestosTrasladados.Value = 16;
          impuesto.TotalImpuestosRetenidos.Value = 0;

          for (int k = 1; k <= 5; k++)
          {
            HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Traslado trasladoComplemento = impuesto.Traslados.Add();
            trasladoComplemento.Impuesto.Value = "002";
            trasladoComplemento.TipoFactor.Value = "Tasa";
            trasladoComplemento.TasaCuota.Value = 0.160000;
            trasladoComplemento.Importe.Value = 16;
          }

          for (int k = 1; k <= 6; k++)
          {
            Retencion retenidoComplemento = impuesto.Retenciones.Add();
            retenidoComplemento.Impuesto.Value = "002";
            retenidoComplemento.Importe.Value = 0;
          }
        }
      }
    }

    public static void CargarDatosMinimo(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi33(electronicDocument.Data);

      // Se agrega el complemento RECIBO DE PAGO
      electronicDocument.Data.Complementos.Add(ComplementoType.RecepcionPago);
      HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.RecepcionPago.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";

      Pago pago = data.Pagos.Add();
      pago.FechaPago.Value = DateTime.Now;
      pago.FormaPago.Value = "01";
      pago.Moneda.Value = "MXN";
      pago.Monto.Value = 100;

      DocumentoRelacionado documentoRelacionado = pago.DocumentosRelacionados.Add();
      documentoRelacionado.IdDocumento.Value = "708d3743-1a32-4ddc-9f70-4cd1c301623e";
      documentoRelacionado.Moneda.Value = "MXN";
      documentoRelacionado.MetodoPago.Value = "PPD";
      documentoRelacionado.NumeroParcialidad.Value = 1;
      documentoRelacionado.ImporteSaldoAnterior.Value = 100;
      documentoRelacionado.ImportePagado.Value = 50;
      documentoRelacionado.ImporteSaldoInsoluto.Value = 50;
    }

    private static void CargarDatosCfdi33(ElectronicDocumentLibrary.Document.Data data)
    {
      data.Clear();

      // Datos del comprobante ***************************************************************
      data.Version.Value = "3.3";
      data.Serie.Value = "RP";
      data.Folio.Value = "1";
      data.Fecha.Value = DateTime.Now;
      data.SubTotal.Value = 0;
      data.SubTotal.Decimals = 0;
      data.SubTotal.Dot = false;
      data.Moneda.Value = "XXX";
      data.Total.Value = 0;
      data.Total.Decimals = 0;
      data.Total.Dot = false;
      data.TipoComprobante.Value = "P";
      data.LugarExpedicion.Value = "01000";
      // *************************************************************************************

      Base.Emisor(data.Emisor);

      // Datos del Receptor ******************************************************************
      data.Receptor.Rfc.Value = "AAA010101AAA";
      data.Receptor.Nombre.Value = "Receptor de prueba";
      data.Receptor.UsoCfdi.Value = "P01";
      // *************************************************************************************

      // Concepto ****************************************************************************
      Concepto concepto = data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "84111506";
      concepto.Cantidad.Value = 1;
      concepto.Cantidad.Decimals = 0;
      concepto.Cantidad.Dot = false;
      concepto.ClaveUnidad.Value = "ACT";
      concepto.Descripcion.Value = "Pago";
      concepto.ValorUnitario.Value = 0;
      concepto.ValorUnitario.Decimals = 0;
      concepto.ValorUnitario.Dot = false;
      concepto.Importe.Value = 0;
      concepto.Importe.Decimals = 0;
      concepto.Importe.Dot = false;
      // *************************************************************************************
    }
  }
}