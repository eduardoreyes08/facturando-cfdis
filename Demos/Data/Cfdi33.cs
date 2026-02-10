using System;
using HyperSoft.ElectronicDocumentLibrary.Document;
using Impuesto = HyperSoft.ElectronicDocumentLibrary.Document.Impuesto;
using Traslado = HyperSoft.ElectronicDocumentLibrary.Document.Traslado;

#pragma warning disable 618

namespace HyperSoft.Ejemplo.Data
{
  public static class Cfdi33
  {
    /// <summary>
    /// Este ejemplo se llenando los datos requeridos para timbrar un CFDI 3.3
    /// </summary>
    /// <param name="electronicDocument"></param>
    public static void CargarDatosTimbrado(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Clear();

      // Datos del comprobante ***************************************************************
      electronicDocument.Data.Version.Value = "3.3";
      electronicDocument.Data.Serie.Value = "C";
      electronicDocument.Data.Folio.Value = "3000";
      electronicDocument.Data.Fecha.Value = DateTime.Now;
      electronicDocument.Data.FormaPago.Value = "01";
      electronicDocument.Data.CondicionesPago.Value = "Contado";
      electronicDocument.Data.SubTotal.Value = 7200.00;
      electronicDocument.Data.Descuento.Value = 360.00;
      electronicDocument.Data.Moneda.Value = "MXN";
      electronicDocument.Data.Total.Value = 7934.40;
      electronicDocument.Data.TipoComprobante.Value = "I";
      electronicDocument.Data.MetodoPago.Value = "PUE";
      electronicDocument.Data.LugarExpedicion.Value = "01000";
      // *************************************************************************************

      // Datos del emisor ********************************************************************
      electronicDocument.Data.Emisor.Rfc.Value = "EKU9003173C9";
      electronicDocument.Data.Emisor.Nombre.Value = "ESCUELA KEMPER URGATE SA DE CV";
      electronicDocument.Data.Emisor.RegimenFiscal.Value = "601";
      // *************************************************************************************

      // Datos del Receptor ******************************************************************
      electronicDocument.Data.Receptor.Rfc.Value = "AAAD770905441";
      electronicDocument.Data.Receptor.Nombre.Value = "DARIO ALVAREZ ARANDA";
      electronicDocument.Data.Receptor.UsoCfdi.Value = "G01";
      // *************************************************************************************

      // Concepto No 1 ***********************************************************************
      Concepto concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.Cantidad.Value = 10;
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "DVD";
      concepto.ValorUnitario.Value = 120;
      concepto.Importe.Value = 1200;
      concepto.Descuento.Value = 360;

      //// Impuestos trasladados del concepto
      TrasladoConcepto trasladoConcepto = concepto.Impuestos.Traslados.Add();
      trasladoConcepto.Base.Value = 840;
      trasladoConcepto.Impuesto.Value = "002";
      trasladoConcepto.TipoFactor.Value = "Tasa";
      trasladoConcepto.TasaCuota.Value = 0.160000;
      trasladoConcepto.Importe.Value = 134.4;

      // Concepto No 2 ***********************************************************************
      concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.Cantidad.Value = 1;
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "Computadora armada";
      concepto.ValorUnitario.Value = 3000;
      concepto.Importe.Value = 3000;

      //// Impuestos trasladados del concepto
      trasladoConcepto = concepto.Impuestos.Traslados.Add();
      trasladoConcepto.Base.Value = 3000;
      trasladoConcepto.Impuesto.Value = "002";
      trasladoConcepto.TipoFactor.Value = "Tasa";
      trasladoConcepto.TasaCuota.Value = 0.160000;
      trasladoConcepto.Importe.Value = 480;
      // *************************************************************************************

      // Concepto No 3 ***********************************************************************
      concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.Cantidad.Value = 1;
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "Monitor de 19 \" marca AOC";
      concepto.ValorUnitario.Value = 3000;
      concepto.Importe.Value = 3000;

      //// Impuestos trasladados del concepto
      trasladoConcepto = concepto.Impuestos.Traslados.Add();
      trasladoConcepto.Base.Value = 3000;
      trasladoConcepto.Impuesto.Value = "002";
      trasladoConcepto.TipoFactor.Value = "Tasa";
      trasladoConcepto.TasaCuota.Value = 0.160000;
      trasladoConcepto.Importe.Value = 480;
      // *************************************************************************************

      // Impuestos trasladados ***************************************************************
      Traslado traslado = electronicDocument.Data.Impuestos.Traslados.Add();
      traslado.Tipo.Value = "002";
      traslado.TipoFactor.Value = "Tasa";
      traslado.TasaCuota.Value = 0.160000;
      traslado.Importe.Value = 1094.4;

      electronicDocument.Data.Impuestos.TotalTraslados.Value = 1094.4;
      // *************************************************************************************
    }

    /// <summary>
    /// Este ejemplo muestra como usar todas las clases y propiedades para el CFDI 3.3
    /// </summary>
    /// <param name="electronicDocument"></param>
    public static void CargarDatosCompleto(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Clear();

      // Datos del comprobante ***************************************************************
      electronicDocument.Data.Version.Value = "3.3";
      electronicDocument.Data.Serie.Value = "C";
      electronicDocument.Data.Folio.Value = "3000";
      electronicDocument.Data.Fecha.Value = DateTime.Now;
      electronicDocument.Data.FormaPago.Value = "01";
      electronicDocument.Data.CondicionesPago.Value = "Contado";
      electronicDocument.Data.SubTotal.Value = 7200.00;
      electronicDocument.Data.Descuento.Value = 360.00;
      electronicDocument.Data.Moneda.Value = "MXN";

      electronicDocument.Data.TipoCambioMx.Value = 1.00;
      electronicDocument.Data.TipoCambioMx.Decimals = 0;
      electronicDocument.Data.TipoCambioMx.Dot = false;

      electronicDocument.Data.Total.Value = 7934.40;
      electronicDocument.Data.TipoComprobante.Value = "I";
      electronicDocument.Data.MetodoPago.Value = "PUE";
      electronicDocument.Data.LugarExpedicion.Value = "01000";
      electronicDocument.Data.Confirmacion.Value = "ECVH1";
      // *************************************************************************************

      // Información de los comprobantes fiscales relacionados *******************************
      electronicDocument.Data.CfdiRelacionados.TipoRelacion.Value = "01";
      CfdiRelacionado cfdiRelacionado = electronicDocument.Data.CfdiRelacionados.Add();
      cfdiRelacionado.Uuid.Value = "3BBDC347-3925-4792-B592-5151C773258B";
      // *************************************************************************************

      // Datos del emisor ********************************************************************
      electronicDocument.Data.Emisor.Rfc.Value = "EKU9003173C9";
      electronicDocument.Data.Emisor.Nombre.Value = "ESCUELA KEMPER URGATE SA DE CV";
      electronicDocument.Data.Emisor.RegimenFiscal.Value = "601";
      // *************************************************************************************

      // Datos del Receptor ******************************************************************
      electronicDocument.Data.Receptor.Rfc.Value = "AAAD770905441";
      electronicDocument.Data.Receptor.Nombre.Value = "DARIO ALVAREZ ARANDA";
      electronicDocument.Data.Receptor.ResinciaFiscal.Value = "USA";
      electronicDocument.Data.Receptor.NumeroRegistroIdTributario.Value = "121585958";
      electronicDocument.Data.Receptor.UsoCfdi.Value = "G01";
      // *************************************************************************************

      // Concepto ****************************************************************************
      Concepto concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.NumeroIdentificacion.Value = "UT421510";
      concepto.Cantidad.Value = 10;
      concepto.ClaveUnidad.Value = "H87";
      concepto.Unidad.Value = "Pieza";
      concepto.Descripcion.Value = "DVD";
      concepto.ValorUnitario.Value = 120;
      concepto.Importe.Value = 1200;
      concepto.Descuento.Value = 360;

      //// Impuestos trasladados del concepto
      TrasladoConcepto trasladoConcepto = concepto.Impuestos.Traslados.Add();
      trasladoConcepto.Base.Value = 840;
      trasladoConcepto.Impuesto.Value = "002";
      trasladoConcepto.TipoFactor.Value = "Tasa";
      trasladoConcepto.TasaCuota.Value = 0.160000;
      trasladoConcepto.Importe.Value = 134.4;

      //// Impuestos retenidos del concepto
      RetencionConcepto retencionConcepto = concepto.Impuestos.Retenciones.Add();
      retencionConcepto.Base.Value = 1200;
      retencionConcepto.Impuesto.Value = "001";
      retencionConcepto.TipoFactor.Value = "Tasa";
      retencionConcepto.TasaCuota.Value = 0.160000;
      retencionConcepto.Importe.Value = 192;

      //// Información aduanera del concepto
      Importacion importacion = concepto.InformacionAduanera.Add();
      importacion.Numero.Value = "10  47  3807  8003832";

      //// Cuenta predial del concepto
      concepto.CuentaPredial.Numero.Value = "15956011002";

      //// Partes del concepto
      Partida partida = concepto.Partes.Add();
      partida.ClaveProductoServicio.Value = "01010101";
      partida.NumeroIdentificacion.Value = "7501030283645";
      partida.Cantidad.Value = 10;
      partida.Unidad.Value = "Piezas";
      partida.Descripcion.Value = "Descripción de la parte";
      partida.ValorUnitario.Value = 100;
      partida.Importe.Value = 1000;

      ////// Información aduanera de la parte del concepto
      importacion = partida.InformacionAduanera.Add();
      importacion.Numero.Value = "10  47  3807  8003832";
      // *************************************************************************************

      // Impuestos trasladados ***************************************************************
      Traslado traslado = electronicDocument.Data.Impuestos.Traslados.Add();
      traslado.Tipo.Value = "002";
      traslado.TipoFactor.Value = "Tasa";
      traslado.TasaCuota.Value = 0.160000;
      traslado.Importe.Value = 1094.4;

      electronicDocument.Data.Impuestos.TotalTraslados.Value = 1094.4;
      // *************************************************************************************

      // Impuestos retenidos *****************************************************************
      Impuesto retencion = electronicDocument.Data.Impuestos.Retenciones.Add();
      retencion.Tipo.Value = "001";
      retencion.Importe.Value = 0;

      electronicDocument.Data.Impuestos.TotalRetenciones.Value = 0;
      // *************************************************************************************
    }

    public static void CargarDatosListas(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Clear();

      // Datos del comprobante ***************************************************************
      electronicDocument.Data.Version.Value = "3.3";
      electronicDocument.Data.Serie.Value = "C";
      electronicDocument.Data.Folio.Value = "3000";
      electronicDocument.Data.Fecha.Value = DateTime.Now;
      electronicDocument.Data.FormaPago.Value = "01";
      electronicDocument.Data.CondicionesPago.Value = "Contado";
      electronicDocument.Data.SubTotal.Value = 7200.00;
      electronicDocument.Data.Descuento.Value = 360.00;
      electronicDocument.Data.Moneda.Value = "MXN";

      electronicDocument.Data.TipoCambioMx.Value = 1.00;
      electronicDocument.Data.TipoCambioMx.Decimals = 0;
      electronicDocument.Data.TipoCambioMx.Dot = false;

      electronicDocument.Data.Total.Value = 7934.40;
      electronicDocument.Data.TipoComprobante.Value = "I";
      electronicDocument.Data.MetodoPago.Value = "PUE";
      electronicDocument.Data.LugarExpedicion.Value = "01000";
      electronicDocument.Data.Confirmacion.Value = "ECVH1";
      // *************************************************************************************

      // Información de los comprobantes fiscales relacionados *******************************
      electronicDocument.Data.CfdiRelacionados.TipoRelacion.Value = "01";
      for (int i = 1; i <= 2; i++)
      {
        CfdiRelacionado cfdiRelacionado = electronicDocument.Data.CfdiRelacionados.Add();
        cfdiRelacionado.Uuid.Value = "3BBDC347-3925-4792-B592-5151C773258B";
      }

      // *************************************************************************************

      // Datos del emisor ********************************************************************
      electronicDocument.Data.Emisor.Rfc.Value = "EKU9003173C9";
      electronicDocument.Data.Emisor.Nombre.Value = "ESCUELA KEMPER URGATE SA DE CV";
      electronicDocument.Data.Emisor.RegimenFiscal.Value = "601";
      // *************************************************************************************

      // Datos del Receptor ******************************************************************
      electronicDocument.Data.Receptor.Rfc.Value = "AAAD770905441";
      electronicDocument.Data.Receptor.Nombre.Value = "DARIO ALVAREZ ARANDA";
      electronicDocument.Data.Receptor.ResinciaFiscal.Value = "USA";
      electronicDocument.Data.Receptor.NumeroRegistroIdTributario.Value = "121585958";
      electronicDocument.Data.Receptor.UsoCfdi.Value = "G01";
      // *************************************************************************************

      // Conceptos ***************************************************************************
      for (int i = 1; i <= 3; i++)
      {
        Concepto concepto = electronicDocument.Data.Conceptos.Add();
        concepto.ClaveProductoServicio.Value = "01010101";
        concepto.NumeroIdentificacion.Value = "UT42151" + i;
        concepto.Cantidad.Value = 10;
        concepto.ClaveUnidad.Value = "H87";
        concepto.Unidad.Value = "Pieza";
        concepto.Descripcion.Value = "DVD";
        concepto.ValorUnitario.Value = 120;
        concepto.Importe.Value = 1200;
        concepto.Descuento.Value = 360;

        //// Impuestos trasladados del concepto
        for (int j = 1; j <= 4; j++)
        {
          TrasladoConcepto trasladoConcepto = concepto.Impuestos.Traslados.Add();
          trasladoConcepto.Base.Value = 840 + j;
          trasladoConcepto.Impuesto.Value = "002";
          trasladoConcepto.TipoFactor.Value = "Tasa";
          trasladoConcepto.TasaCuota.Value = 0.160000;
          trasladoConcepto.Importe.Value = 134.4;
        }

        for (int j = 1; j <= 5; j++)
        {
          //// Impuestos retenidos del concepto
          RetencionConcepto retencionConcepto = concepto.Impuestos.Retenciones.Add();
          retencionConcepto.Base.Value = 1200 + j;
          retencionConcepto.Impuesto.Value = "001";
          retencionConcepto.TipoFactor.Value = "Tasa";
          retencionConcepto.TasaCuota.Value = 0.160000;
          retencionConcepto.Importe.Value = 192;
        }

        for (int j = 1; j <= 6; j++)
        {
          //// Información aduanera del concepto
          Importacion importacion = concepto.InformacionAduanera.Add();
          importacion.Numero.Value = "10  47  3807  800383" + j;
        }
          

        //// Cuenta predial del concepto
        concepto.CuentaPredial.Numero.Value = "15956011002";

        //// Partes del concepto
        for (int j = 1; j <= 7; j++)
        {
          Partida partida = concepto.Partes.Add();
          partida.ClaveProductoServicio.Value = "01010101";
          partida.NumeroIdentificacion.Value = "750103028364" + j;
          partida.Cantidad.Value = 10;
          partida.Unidad.Value = "Piezas";
          partida.Descripcion.Value = "Descripción de la parte";
          partida.ValorUnitario.Value = 100;
          partida.Importe.Value = 1000;

          ////// Información aduanera de la parte del concepto
          for (int k = 1; k <= 8; k++)
          {
            Importacion importacion = partida.InformacionAduanera.Add();
            importacion.Numero.Value = "10  47  3807  800383" + k;
          }
        }
      }
      // *************************************************************************************

      // Impuestos trasladados ***************************************************************
      for (int i = 1; i <= 9; i++)
      {
        Traslado traslado = electronicDocument.Data.Impuestos.Traslados.Add();
        traslado.Tipo.Value = "002";
        traslado.TipoFactor.Value = "Tasa";
        traslado.TasaCuota.Value = 0.160000;
        traslado.Importe.Value = 1094.4 + i;
      }

      electronicDocument.Data.Impuestos.TotalTraslados.Value = 1094.4;
      // *************************************************************************************

      // Impuestos retenidos *****************************************************************
      for (int i = 1; i <= 10; i++)
      {
        Impuesto retencion = electronicDocument.Data.Impuestos.Retenciones.Add();
        retencion.Tipo.Value = "001";
        retencion.Importe.Value = 0 + i;
      }
        
      electronicDocument.Data.Impuestos.TotalRetenciones.Value = 0;
      // *************************************************************************************
    }

    public static void CargarDatosMinimo(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Clear();

      // Datos del comprobante ***************************************************************
      electronicDocument.Data.Version.Value = "3.3";
      electronicDocument.Data.Fecha.Value = DateTime.Now;
      electronicDocument.Data.SubTotal.Value = 7200.00;
      electronicDocument.Data.Moneda.Value = "MXN";
      electronicDocument.Data.Total.Value = 7934.40;
      electronicDocument.Data.TipoComprobante.Value = "I";
      electronicDocument.Data.LugarExpedicion.Value = "01000";

      electronicDocument.Data.SubTotal.Decimals = 0;
      electronicDocument.Data.SubTotal.Value = 0;
      electronicDocument.Data.SubTotal.Dot = false;
      // *************************************************************************************

      // Datos del emisor ********************************************************************
      electronicDocument.Data.Emisor.Rfc.Value = "EKU9003173C9";
      electronicDocument.Data.Emisor.RegimenFiscal.Value = "601";
      // *************************************************************************************

      // Datos del Receptor ******************************************************************
      electronicDocument.Data.Receptor.Rfc.Value = "AAAD770905441";
      electronicDocument.Data.Receptor.UsoCfdi.Value = "G01";
      // *************************************************************************************

      // Concepto ****************************************************************************
      Concepto concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.Cantidad.Value = 10;
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "DVD";
      concepto.ValorUnitario.Value = 120;
      concepto.Importe.Value = 1200;
      // *************************************************************************************
    }
  }
}
