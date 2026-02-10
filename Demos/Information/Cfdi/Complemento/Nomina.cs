using System;
using HyperSoft.ElectronicDocumentLibrary.Complemento.Nomina;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class Nomina
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.Nomina.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO NOMINA");
      Utils.ShowField("Versión                         ", data.Version);
      Utils.ShowField("Número de registro patronal     ", data.RegistroPatronal);
      Utils.ShowField("Número de empleado              ", data.NumeroEmpleado);
      Utils.ShowField("CURP                            ", data.Curp);
      Utils.ShowField("Tipo de régimen                 ", data.TipoRegimen);
      Utils.ShowField("Número de seguridad social      ", data.NumeroSeguridadSocial);
      Utils.ShowField("Fecha de pago                   ", data.FechaPago);
      Utils.ShowField("Fecha inicial de pago           ", data.FechaInicialPago);
      Utils.ShowField("Fecha final de pago             ", data.FechaFinalPago);
      Utils.ShowField("Número de días pagados          ", data.NumeroDiasPagados);
      Utils.ShowField("Departamento                    ", data.Departamento);
      Utils.ShowField("CLABE                           ", data.Clabe);
      Utils.ShowField("Banco                           ", data.Banco);
      Utils.ShowField("Fecha inicio de relación laboral", data.FechaInicioRelacionLaboral);
      Utils.ShowField("Antigüedad                      ", data.Antiguedad);
      Utils.ShowField("Puesto                          ", data.Puesto);
      Utils.ShowField("Tipo de contrato                ", data.TipoContrato);
      Utils.ShowField("Tipo de jornada                 ", data.TipoJornada);
      Utils.ShowField("Peridiocidad de pago            ", data.PeriodicidadPago);
      Utils.ShowField("Salario base de cotización      ", data.SalarioBaseCotizacionAportacion);
      Utils.ShowField("Riesgo del puesto               ", data.RiesgoPuesto);
      Utils.ShowField("Salario diário integrado        ", data.SalarioDiarioIntegrado);
      Utils.ShowField("Total de percepciones           ", data.TotalPercepciones);
      Utils.ShowField("Total de deducciones            ", data.TotalDeducciones);
      Utils.ShowField("Total de otros pagos            ", data.TotalOtrosPagos);
      

      if (data.Emisor.IsAssigned)
      {
        Utils.ShowTitle("NOMINA / EMISOR");
        Utils.ShowField("CURP             ", data.Emisor.Curp);
        Utils.ShowField("Registro patronal", data.Emisor.RegistroPatronal);
        Utils.ShowField("RFC patrón origen", data.Emisor.RfcPatronOrigen);

        if (data.Emisor.EntidadSncf.IsAssigned)
        {
          Utils.ShowTitle("NOMINA / EMISOR / ENTIDAD SNCF");
          Utils.ShowField("Origen del recurso      ", data.Emisor.EntidadSncf.OrigenRecurso);
          Utils.ShowField("Monto del recurso propio", data.Emisor.EntidadSncf.MontoRecursoPropio);
        }
      }

      if (data.Receptor.IsAssigned)
      {
        Utils.ShowTitle("NOMINA / RECEPTOR");
        Utils.ShowField("CURP                            ", data.Receptor.Curp);
        Utils.ShowField("Número de seguridad social      ", data.Receptor.NumeroSeguridadSocial);
        Utils.ShowField("Fecha inicio de relación laboral", data.Receptor.FechaInicioRelacionLaboral);
        Utils.ShowField("Antigüedad                      ", data.Receptor.Antiguedad);
        Utils.ShowField("Tipo de contrato                ", data.Receptor.TipoContrato);
        Utils.ShowField("Sindicalizado                   ", data.Receptor.Sindicalizado);
        Utils.ShowField("Tipo de jornada                 ", data.Receptor.TipoJornada);
        Utils.ShowField("Tipo de régimen                 ", data.Receptor.TipoRegimen);
        Utils.ShowField("Número de empleado              ", data.Receptor.NumeroEmpleado);
        Utils.ShowField("Departamento                    ", data.Receptor.Departamento);
        Utils.ShowField("Puesto                          ", data.Receptor.Puesto);
        Utils.ShowField("Riesgo del puesto               ", data.Receptor.RiesgoPuesto);
        Utils.ShowField("Peridiocidad de pago            ", data.Receptor.PeriodicidadPago);
        Utils.ShowField("Banco                           ", data.Receptor.Banco);
        Utils.ShowField("Cuenta bancaria                 ", data.Receptor.CuentaBancaria);
        Utils.ShowField("Salario base de cotización      ", data.Receptor.SalarioBaseCotApor);        
        Utils.ShowField("Salario diário integrado        ", data.Receptor.SalarioDiarioIntegrado);
        Utils.ShowField("Clave entidad federativa        ", data.Receptor.ClaveEntidadFederativa);

        for (int i = 0; i < data.Receptor.SubContrataciones.Count; i++)
        {
          Utils.ShowTitle($"NOMINA / RECEPTOR / SUBCONTRATACION {i + 1}");
          Utils.ShowField("RFC donde labora    ", data.Receptor.SubContrataciones[0].RfcLabora);
          Utils.ShowField("Porcentaje de tiempo", data.Receptor.SubContrataciones[0].PorcentajeTiempo);
        }
      }

      #region Percepciones

      if (data.Percepciones.IsAssigned)
      {
        Utils.ShowTitle("NOMINA / PERCEPCIONES");
        Utils.ShowField("Total de sueldos                      ", data.Percepciones.TotalSueldos);
        Utils.ShowField("Total por separación o indemnización  ", data.Percepciones.TotalSeparacionIndemnizacion);
        Utils.ShowField("Total por jubilación, pension o retiro", data.Percepciones.TotalJubilacionPensionRetiro);
        Utils.ShowField("Total gravado                         ", data.Percepciones.TotalGravado);
        Utils.ShowField("Total exento                          ", data.Percepciones.TotalExento);

        for (int i = 0; i < data.Percepciones.Count; i++)
        {
          Utils.ShowTitle("NOMINA / PERCEPCION - " + (i + 1));
          Utils.ShowField("Tipo           ", data.Percepciones[i].Tipo);
          Utils.ShowField("Clave          ", data.Percepciones[i].Clave);
          Utils.ShowField("Concepto       ", data.Percepciones[i].Concepto);
          Utils.ShowField("Importe gravado", data.Percepciones[i].ImporteGravado);
          Utils.ShowField("Importe exento ", data.Percepciones[i].ImporteExento);
        }
      }

      #endregion

      #region Deducciones

      if (data.Deducciones.IsAssigned)
      {
        Utils.ShowTitle("NOMINA / DEDUCCIONES");
        Utils.ShowField("Total de otras deducciones  ", data.Deducciones.TotalOtrasDeducciones);
        Utils.ShowField("Total de impuestos retenidos", data.Deducciones.TotalImpuestosRetenidos);
        Utils.ShowField("Total gravado               ", data.Deducciones.TotalGravado);
        Utils.ShowField("Total exento                ", data.Deducciones.TotalExento);

        for (int i = 0; i < data.Deducciones.Count; i++)
        {
          Utils.ShowTitle("NOMINA / DEDUCCION - " + (i + 1));
          Utils.ShowField("Tipo           ", data.Deducciones[i].Tipo);
          Utils.ShowField("Clave          ", data.Deducciones[i].Clave);
          Utils.ShowField("Concepto       ", data.Deducciones[i].Concepto);
          Utils.ShowField("Importe gravado", data.Deducciones[i].ImporteGravado);
          Utils.ShowField("Importe exento ", data.Deducciones[i].ImporteExento);
          Utils.ShowField("Importe        ", data.Deducciones[i].Importe);
        }
      }

      #endregion

      #region OtrosPagos

      for (int i = 0; i < data.OtrosPagos.Count; i++)
      {
        OtroPago otroPago = data.OtrosPagos[i];

        string title = $"NOMINA / OTRO PAGO {i + 1}";
        Utils.ShowTitle(title);
        Utils.ShowField("Tipo    ", otroPago.Tipo);
        Utils.ShowField("Clave   ", otroPago.Clave);
        Utils.ShowField("Concepto", otroPago.Concepto);
        Utils.ShowField("Importe ", otroPago.Importe);

        if (otroPago.SubsidioAlEmpleo.IsAssigned)
        {
          Utils.ShowTitle($"{title} / SUBSIDIO AL EMPLEO");
          Utils.ShowField("Subsidio causado", otroPago.SubsidioAlEmpleo.SubsidioCausado);
        }

        if (otroPago.CompensacionSaldosAFavor.IsAssigned)
        {
          Utils.ShowTitle($"{title} / COMPENSACION DE SALDOS A FAVOR");
          Utils.ShowField("Saldo a favor              ", otroPago.CompensacionSaldosAFavor.SaldoAFavor);
          Utils.ShowField("Año                        ", otroPago.CompensacionSaldosAFavor.Anio);
          Utils.ShowField("Remanente del saldo a favor", otroPago.CompensacionSaldosAFavor.RemanenteSaldoFavor);
        }
      }

      #endregion

      #region Incapacidades

      for (int i = 0; i < data.Incapacidades.Count; i++)
      {
        Utils.ShowTitle("NOMINA / INCAPACIDAD - " + (i + 1));

        if (data.Incapacidades[i].Dias.IsAssigned)
          Utils.ShowField("Días incapacidad ", data.Incapacidades[i].Dias);
        else
          Utils.ShowField("Días incapacidad ", data.Incapacidades[i].DiasIncapacidad);

        if (data.Incapacidades[i].Tipo.IsAssigned)
          Utils.ShowField("Tipo incapacidad ", data.Incapacidades[i].Tipo);
        else
          Utils.ShowField("Tipo incapacidad ", data.Incapacidades[i].TipoNomina);

        Utils.ShowField("Descuento        ", data.Incapacidades[i].Descuento);
        Utils.ShowField("Importe monetario", data.Incapacidades[i].ImporteMonetario);
      }

      #endregion

      #region HorasExtras

      for (int i = 0; i < data.HorasExtras.Count; i++)
      {
        Utils.ShowTitle("NOMINA / HORASEXTRAS - " + (i + 1));
        Utils.ShowField("Días   ", data.HorasExtras[i].Dias);
        Utils.ShowField("Tipo   ", data.HorasExtras[i].Tipo);
        Utils.ShowField("Horas  ", data.HorasExtras[i].Horas);
        Utils.ShowField("Importe", data.HorasExtras[i].ImportePagado);
      }

      #endregion
    }
  }
}