using System;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data
{
  public static class ConstanciaRetenciones20
  {
    public static void CargarDatosTimbrado(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "2.0";
      constanciaRetenciones.Data.Folio.Value = "1";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.LugarExpedicion.Value = "07300";
      constanciaRetenciones.Data.Clave.Value = "12";
      constanciaRetenciones.Data.Descripcion.Value = "Servicios profesionales";
      // ***************************************************************************************

      // CFDI Relacionado ********************************************************************
      constanciaRetenciones.Data.CfdiRelacionado.TipoRelacion.Value = "04";
      constanciaRetenciones.Data.CfdiRelacionado.Uuid.Value = "421CD8B3-0BA4-96C7-9F0B-C308CF391195";
      // ***************************************************************************************

      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      constanciaRetenciones.Data.Emisor.RegimenFiscal.Value = "601";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAD770905441";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "DARIO ALVAREZ ARANDA";
      constanciaRetenciones.Data.Receptor.Nacional.Curp.Value = "UXBA000419HYNVRDA3";
      constanciaRetenciones.Data.Receptor.Nacional.DomicilioFiscal.Value = "07300";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesInicial.Integers = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Integers = 2;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = DateTime.Now.Year;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;
      
      // Impuesto retenido 1
      ImpuestoRetenido impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
      impuestoRetenido.Base.Value = 16;
      impuestoRetenido.Impuesto.Value = "001";
      impuestoRetenido.MontoRetenido.Value = 160.00;
      impuestoRetenido.TipoPago.Value = "04";
      // ***************************************************************************************
    }

    public static void CargarDatosCompleto(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "2.0";
      constanciaRetenciones.Data.Folio.Value = "1";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.LugarExpedicion.Value = "07300";
      constanciaRetenciones.Data.Clave.Value = "12";
      constanciaRetenciones.Data.Descripcion.Value = "Servicios profesionales";
      // ***************************************************************************************

      // CFDI Relacionado ********************************************************************
      constanciaRetenciones.Data.CfdiRelacionado.TipoRelacion.Value = "04";
      constanciaRetenciones.Data.CfdiRelacionado.Uuid.Value = "421CD8B3-0BA4-96C7-9F0B-C308CF391195";
      // ***************************************************************************************

      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      constanciaRetenciones.Data.Emisor.RegimenFiscal.Value = "601";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAD770905441";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "DARIO ALVAREZ ARANDA";
      constanciaRetenciones.Data.Receptor.Nacional.Curp.Value = "UXBA000419HYNVRDA3";
      constanciaRetenciones.Data.Receptor.Nacional.DomicilioFiscal.Value = "07300";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesInicial.Integers = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Integers = 2;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = DateTime.Now.Year;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;
      constanciaRetenciones.Data.Totales.UtilidadBimestral.Value = 160;
      constanciaRetenciones.Data.Totales.IsrCorrespondiente.Value = 160;

      // Impuesto retenido 1
      ImpuestoRetenido impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
      impuestoRetenido.Base.Value = 16;
      impuestoRetenido.Impuesto.Value = "001";
      impuestoRetenido.MontoRetenido.Value = 160.00;
      impuestoRetenido.TipoPago.Value = "01";
      // ***************************************************************************************
    }

    public static void CargarDatosListas(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "2.0";
      constanciaRetenciones.Data.Folio.Value = "1";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.LugarExpedicion.Value = "07300";
      constanciaRetenciones.Data.Clave.Value = "12";
      constanciaRetenciones.Data.Descripcion.Value = "Servicios profesionales";
      // ***************************************************************************************

      // CFDI Relacionado ********************************************************************
      constanciaRetenciones.Data.CfdiRelacionado.TipoRelacion.Value = "04";
      constanciaRetenciones.Data.CfdiRelacionado.Uuid.Value = "421CD8B3-0BA4-96C7-9F0B-C308CF391195";
      // ***************************************************************************************

      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      constanciaRetenciones.Data.Emisor.RegimenFiscal.Value = "601";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAD770905441";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "DARIO ALVAREZ ARANDA";
      constanciaRetenciones.Data.Receptor.Nacional.Curp.Value = "UXBA000419HYNVRDA3";
      constanciaRetenciones.Data.Receptor.Nacional.DomicilioFiscal.Value = "07300";

      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesInicial.Integers = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Integers = 2;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = DateTime.Now.Year;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;
      constanciaRetenciones.Data.Totales.UtilidadBimestral.Value = 160;
      constanciaRetenciones.Data.Totales.IsrCorrespondiente.Value = 160;

      // Impuesto retenido
      for (int i = 1; i <= 2; i++)
      {
        ImpuestoRetenido impuestoRetenido = constanciaRetenciones.Data.Totales.ImpuestosRetenidos.Add();
        impuestoRetenido.Base.Value = 16;
        impuestoRetenido.Impuesto.Value = "001";
        impuestoRetenido.MontoRetenido.Value = 160.00;
        impuestoRetenido.TipoPago.Value = "01";
      }
      // ***************************************************************************************
    }

    public static void CargarDatosMinimo(ConstanciaRetenciones constanciaRetenciones)
    {
      constanciaRetenciones.Data.Clear();

      // Datos del comprobante ****************************************************************
      constanciaRetenciones.Data.Version.Value = "2.0";
      constanciaRetenciones.Data.FechaExpedicion.Value = DateTime.Now;
      constanciaRetenciones.Data.LugarExpedicion.Value = "07300";
      constanciaRetenciones.Data.Clave.Value = "12";
      // ***************************************************************************************

      // Datos del emisor ********************************************************************
      constanciaRetenciones.Data.Emisor.Rfc.Value = "EKU9003173C9";
      constanciaRetenciones.Data.Emisor.RazonSocial.Value = "ESCUELA KEMPER URGATE SA DE CV";
      constanciaRetenciones.Data.Emisor.RegimenFiscal.Value = "601";
      // ***************************************************************************************


      // Datos del Receptor ********************************************************************
      constanciaRetenciones.Data.Receptor.Nacionalidad.Value = "Nacional";

      // Receptor - Nacional
      constanciaRetenciones.Data.Receptor.Nacional.Rfc.Value = "AAAD770905441";
      constanciaRetenciones.Data.Receptor.Nacional.RazonSocial.Value = "DARIO ALVAREZ ARANDA";
      constanciaRetenciones.Data.Receptor.Nacional.DomicilioFiscal.Value = "07300";
      // ***************************************************************************************


      // Periodo *******************************************************************************
      constanciaRetenciones.Data.Periodo.MesInicial.Value = 1;
      constanciaRetenciones.Data.Periodo.MesInicial.Integers = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Value = 2;
      constanciaRetenciones.Data.Periodo.MesFinal.Integers = 2;
      constanciaRetenciones.Data.Periodo.Ejercicio.Value = DateTime.Now.Year;
      // ***************************************************************************************


      // Totales *******************************************************************************
      constanciaRetenciones.Data.Totales.MontoOperacion.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoGravado.Value = 1000.00;
      constanciaRetenciones.Data.Totales.MontoExento.Value = 0.00;
      constanciaRetenciones.Data.Totales.MontoRetenido.Value = 160.00;
      // ***************************************************************************************
    }
  }
}