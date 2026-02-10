using System;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data
{
  public static class ConstanciaRetenciones10
  {
    public static void CargarDatosTimbrado(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "1.0";
      constanciaRetenciones.Data.Folio.Value = "1";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.Clave.Value = "12";
      constanciaRetenciones.Data.Descripcion.Value = "Servicios profesionales";
      // ***************************************************************************************


      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      //constanciaRetenciones.Data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAA010101AA1";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "Receptor nacional de prueba";
      //constanciaRetenciones.Data.Receptor.Nacional.Curp.Value = "UXBA000419HYNVRDA3";

      // Receptor - Extranjero
      //constanciaRetenciones.Data.Receptor.Extranjero.NumeroIdentificacionFiscal.Value = "1";
      //constanciaRetenciones.Data.Receptor.Extranjero.RazonSocial.Value = "Receptor extranjero de prueba";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 12;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = 2014;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;

      // Impuesto retenido 1
      ImpuestoRetenido impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
      impuestoRetenido.Base.Value = 16;
      impuestoRetenido.Impuesto.Value = "01";
      impuestoRetenido.MontoRetenido.Value = 160.00;
      impuestoRetenido.TipoPago.Value = "Pago provisional";
      // ***************************************************************************************

      // Impuesto retenido 2
      impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
      impuestoRetenido.Base.Value = 16;
      impuestoRetenido.Impuesto.Value = "02";
      impuestoRetenido.MontoRetenido.Value = 160.00;
      impuestoRetenido.TipoPago.Value = "Pago provisional";
      // ***************************************************************************************

      // Impuesto retenido 3
      impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
      impuestoRetenido.Base.Value = 16;
      impuestoRetenido.Impuesto.Value = "03";
      impuestoRetenido.MontoRetenido.Value = 160.00;
      impuestoRetenido.TipoPago.Value = "Pago provisional";
      // ***************************************************************************************
    }

    public static void CargarDatosCompleto(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "1.0";
      constanciaRetenciones.Data.Folio.Value = "1";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.Clave.Value = "12";
      constanciaRetenciones.Data.Descripcion.Value = "Servicios profesionales";
      // ***************************************************************************************


      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      constanciaRetenciones.Data.Emisor.Curp.Value = "OERR880127HDFTZB00";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAA010101AA1";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "Receptor nacional de prueba";
      constanciaRetenciones.Data.Receptor.Nacional.Curp.Value = "UXBA000419HYNVRDA3";

      // Receptor - Extranjero
      //constanciaRetenciones.Data.Receptor.Extranjero.NumeroIdentificacionFiscal.Value = "1";
      //constanciaRetenciones.Data.Receptor.Extranjero.RazonSocial.Value = "Receptor extranjero de prueba";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 12;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = 2014;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;

      // Impuesto retenido 1
      ImpuestoRetenido impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
      impuestoRetenido.Base.Value = 16;
      impuestoRetenido.Impuesto.Value = "01";
      impuestoRetenido.MontoRetenido.Value = 160.00;
      impuestoRetenido.TipoPago.Value = "Pago provisional";
      // ***************************************************************************************
    }

    public static void CargarDatosListas(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "1.0";
      constanciaRetenciones.Data.Folio.Value = "1";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.Clave.Value = "12";
      constanciaRetenciones.Data.Descripcion.Value = "Servicios profesionales";
      // ***************************************************************************************


      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      constanciaRetenciones.Data.Emisor.Curp.Value = "OERR880127HDFTZB00";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAA010101AA1";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "Receptor nacional de prueba";
      constanciaRetenciones.Data.Receptor.Nacional.Curp.Value = "UXBA000419HYNVRDA3";

      // Receptor - Extranjero
      //constanciaRetenciones.Data.Receptor.Extranjero.NumeroIdentificacionFiscal.Value = "1";
      //constanciaRetenciones.Data.Receptor.Extranjero.RazonSocial.Value = "Receptor extranjero de prueba";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 12;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = 2014;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;

      for (int i = 1; i <= 2; i++)
      {
        // Impuesto retenido 1
        ImpuestoRetenido impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
        impuestoRetenido.Base.Value = 16;
        impuestoRetenido.Impuesto.Value = "01";
        impuestoRetenido.MontoRetenido.Value = 160.00;
        impuestoRetenido.TipoPago.Value = "Pago provisional";
        // ***************************************************************************************  
      }
    }

    public static void CargarDatosMinimo(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "1.0";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.Clave.Value = "12";
      // ***************************************************************************************


      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";      
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAA010101AA1";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 12;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = 2014;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;
    }
  }
}
