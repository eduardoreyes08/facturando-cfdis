using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.Nomina;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class Nomina12
  {
    public static void CargarDatosCfdi40Timbrado(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi40(electronicDocument.Data);

      electronicDocument.Data.Complementos.Add(ComplementoType.Nomina);
      ElectronicDocumentLibrary.Complemento.Nomina.Data data = (ElectronicDocumentLibrary.Complemento.Nomina.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.2";
      data.TipoNomina.Value = "O";
      data.FechaPago.Value = DateTime.Now;
      data.FechaInicialPago.Value = DateTime.Now;
      data.FechaFinalPago.Value = DateTime.Now.AddDays(15);
      data.NumeroDiasPagados.Value = 30;
      data.NumeroDiasPagados.Decimals = 3;
      data.TotalPercepciones.Value = 9100.00;
      data.TotalDeducciones.Value = 250;
      data.TotalOtrosPagos.Value = 200;

      #region EMISOR

      data.Emisor.RegistroPatronal.Value = "12345678901";
      //data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      
      #endregion

      #region RECEPTOR

      data.Receptor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Receptor.NumeroSeguridadSocial.Value = "12345678901";
      data.Receptor.FechaInicioRelacionLaboral.Value = DateTime.Now;
      data.Receptor.Antiguedad.Value = "P2W";
      data.Receptor.TipoContrato.Value = "01";
      data.Receptor.Sindicalizado.Value = "Sí";
      data.Receptor.TipoJornada.Value = "03";
      data.Receptor.TipoRegimen.Value = "02";
      data.Receptor.NumeroEmpleado.Value = "1968";
      data.Receptor.Departamento.Value = "Contabilidad";
      data.Receptor.Puesto.Value = "Auxiliar Contable";
      data.Receptor.RiesgoPuesto.Value = "1";
      data.Receptor.PeriodicidadPago.Value = "05";
      data.Receptor.Banco.Value = "021";
      data.Receptor.CuentaBancaria.Value = "2147483640";
      data.Receptor.SalarioBaseCotApor.Value = 300;
      data.Receptor.SalarioDiarioIntegrado.Value = 335;
      data.Receptor.ClaveEntidadFederativa.Value = "AGU";

      #endregion

      #region PERCEPCIONES

      data.Percepciones.TotalSueldos.Value = 9100;
      data.Percepciones.TotalGravado.Value = 9100;
      data.Percepciones.TotalExento.Value = 0;

      Percepcion percepcion = data.Percepciones.Add();
      percepcion.Clave.Value = "100";
      percepcion.Concepto.Value = "Sueldo";
      percepcion.Tipo.Value = "001";
      percepcion.ImporteExento.Value = 0;
      percepcion.ImporteGravado.Value = 9000;

      percepcion = data.Percepciones.Add();
      percepcion.Clave.Value = "110";
      percepcion.Concepto.Value = "Puntualidad";
      percepcion.Tipo.Value = "010";
      percepcion.ImporteExento.Value = 0;
      percepcion.ImporteGravado.Value = 100;

      #endregion

      #region DEDUCCIONES

      data.Deducciones.TotalOtrasDeducciones.Value = 100.00;
      data.Deducciones.TotalImpuestosRetenidos.Value = 150.00;

      Deduccion deduccion = data.Deducciones.Add();
      deduccion.Clave.Value = "201";
      deduccion.Tipo.Value = "001";
      deduccion.Concepto.Value = "IMSS";
      deduccion.Importe.Value = 100.00;

      deduccion = data.Deducciones.Add();
      deduccion.Clave.Value = "202";
      deduccion.Tipo.Value = "002";
      deduccion.Concepto.Value = "ISR";
      deduccion.Importe.Value = 150.00;

      #endregion

      #region OTROS PAGOS

      OtroPago otroPago = data.OtrosPagos.Add();
      otroPago.Clave.Value = "300";
      otroPago.Concepto.Value = "Viáticos";
      otroPago.Importe.Value = 100;
      otroPago.Tipo.Value = "003";

      otroPago = data.OtrosPagos.Add();
      otroPago.Clave.Value = "300";
      otroPago.Concepto.Value = "Viáticos";
      otroPago.Importe.Value = 100;
      otroPago.Tipo.Value = "003";

      otroPago = data.OtrosPagos.Add();
      otroPago.Clave.Value = "302";
      otroPago.Concepto.Value = "Subsidio";
      otroPago.Importe.Value = 0;
      otroPago.Tipo.Value = "002";

      otroPago.SubsidioAlEmpleo.SubsidioCausado.Value = 0;

      #endregion

      #region INCAPACIDADES

      Incapacidad incapacidad = data.Incapacidades.Add();
      incapacidad.TipoNomina.Value = "03";
      incapacidad.DiasIncapacidad.Value = 1;
      incapacidad.ImporteMonetario.Value = 300;

      incapacidad = data.Incapacidades.Add();
      incapacidad.TipoNomina.Value = "03";
      incapacidad.DiasIncapacidad.Value = 1;
      incapacidad.ImporteMonetario.Value = 300;

      #endregion
    }

    public static void CargarDatosCfdi33Timbrado(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi33(electronicDocument.Data);

      electronicDocument.Data.Complementos.Add(ComplementoType.Nomina);
      ElectronicDocumentLibrary.Complemento.Nomina.Data data = (ElectronicDocumentLibrary.Complemento.Nomina.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.2";
      data.TipoNomina.Value = "O";
      data.FechaPago.Value = DateTime.Now;
      data.FechaInicialPago.Value = DateTime.Now;
      data.FechaFinalPago.Value = DateTime.Now.AddDays(15);
      data.NumeroDiasPagados.Value = 30;
      data.NumeroDiasPagados.Decimals = 3;
      data.TotalPercepciones.Value = 9100.00;
      data.TotalDeducciones.Value = 250;
      data.TotalOtrosPagos.Value = 200;

      #region EMISOR

      data.Emisor.RegistroPatronal.Value = "12345678901";
      //data.Emisor.RfcPatronOrigen.Value = "AAA010101AAA";
      //data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";

      #endregion

      #region RECEPTOR

      data.Receptor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Receptor.NumeroSeguridadSocial.Value = "12345678901";
      data.Receptor.FechaInicioRelacionLaboral.Value = DateTime.Now;
      data.Receptor.Antiguedad.Value = "P2W";
      data.Receptor.TipoContrato.Value = "01";
      data.Receptor.Sindicalizado.Value = "Sí";
      data.Receptor.TipoJornada.Value = "03";
      data.Receptor.TipoRegimen.Value = "02";
      data.Receptor.NumeroEmpleado.Value = "1968";
      data.Receptor.Departamento.Value = "Contabilidad";
      data.Receptor.Puesto.Value = "Auxiliar Contable";
      data.Receptor.RiesgoPuesto.Value = "1";
      data.Receptor.PeriodicidadPago.Value = "05";
      data.Receptor.Banco.Value = "021";
      data.Receptor.CuentaBancaria.Value = "2147483640";
      data.Receptor.SalarioBaseCotApor.Value = 300;
      data.Receptor.SalarioDiarioIntegrado.Value = 335;
      data.Receptor.ClaveEntidadFederativa.Value = "DIF";

      SubContratacion subContratacion = data.Receptor.SubContrataciones.Add();
      subContratacion.RfcLabora.Value = "AAAD770905441";
      subContratacion.PorcentajeTiempo.Value = 100.000;

      #endregion

      #region PERCEPCIONES

      data.Percepciones.TotalSueldos.Value = 9100;
      data.Percepciones.TotalGravado.Value = 9100;
      data.Percepciones.TotalExento.Value = 0;

      Percepcion percepcion = data.Percepciones.Add();
      percepcion.Clave.Value = "100";
      percepcion.Concepto.Value = "Sueldo";
      percepcion.Tipo.Value = "001";
      percepcion.ImporteExento.Value = 0;
      percepcion.ImporteGravado.Value = 9000;

      percepcion = data.Percepciones.Add();
      percepcion.Clave.Value = "110";
      percepcion.Concepto.Value = "Puntualidad";
      percepcion.Tipo.Value = "010";
      percepcion.ImporteExento.Value = 0;
      percepcion.ImporteGravado.Value = 100;

      #endregion

      #region DEDUCCIONES

      data.Deducciones.TotalOtrasDeducciones.Value = 100.00;
      data.Deducciones.TotalImpuestosRetenidos.Value = 150.00;

      Deduccion deduccion = data.Deducciones.Add();
      deduccion.Clave.Value = "201";
      deduccion.Tipo.Value = "001";
      deduccion.Concepto.Value = "IMSS";
      deduccion.Importe.Value = 100.00;

      deduccion = data.Deducciones.Add();
      deduccion.Clave.Value = "202";
      deduccion.Tipo.Value = "002";
      deduccion.Concepto.Value = "ISR";
      deduccion.Importe.Value = 150.00;

      #endregion

      #region OTROS PAGOS

      OtroPago otroPago = data.OtrosPagos.Add();
      otroPago.Clave.Value = "300";
      otroPago.Concepto.Value = "Viáticos";
      otroPago.Importe.Value = 100;
      otroPago.Tipo.Value = "003";

      otroPago = data.OtrosPagos.Add();
      otroPago.Clave.Value = "300";
      otroPago.Concepto.Value = "Viáticos";
      otroPago.Importe.Value = 100;
      otroPago.Tipo.Value = "003";

      otroPago = data.OtrosPagos.Add();
      otroPago.Clave.Value = "302";
      otroPago.Concepto.Value = "Subsidio";
      otroPago.Importe.Value = 0;
      otroPago.Tipo.Value = "002";

      otroPago.SubsidioAlEmpleo.SubsidioCausado.Value = 0;

      #endregion

      #region INCAPACIDADES

      Incapacidad incapacidad = data.Incapacidades.Add();
      incapacidad.TipoNomina.Value = "03";
      incapacidad.DiasIncapacidad.Value = 1;
      incapacidad.ImporteMonetario.Value = 300;

      incapacidad = data.Incapacidades.Add();
      incapacidad.TipoNomina.Value = "03";
      incapacidad.DiasIncapacidad.Value = 1;
      incapacidad.ImporteMonetario.Value = 300;

      #endregion
    }

    public static void CargarDatosCompleto(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi40(electronicDocument.Data);

      electronicDocument.Data.Complementos.Add(ComplementoType.Nomina);
      ElectronicDocumentLibrary.Complemento.Nomina.Data data = (ElectronicDocumentLibrary.Complemento.Nomina.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.2";
      data.TipoNomina.Value = "O";
      data.FechaPago.Value = DateTime.Now;
      data.FechaInicialPago.Value = DateTime.Now;
      data.FechaFinalPago.Value = DateTime.Now.AddDays(15);
      data.NumeroDiasPagados.Value = 30;
      data.NumeroDiasPagados.Decimals = 3;
      data.TotalPercepciones.Value = 9100.00;
      data.TotalDeducciones.Value = 250;
      data.TotalOtrosPagos.Value = 200;

      #region EMISOR

      data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Emisor.RegistroPatronal.Value = "12345678901";
      data.Emisor.RfcPatronOrigen.Value = "AAA010101AAA";

      data.Emisor.EntidadSncf.OrigenRecurso.Value = "IP";
      data.Emisor.EntidadSncf.MontoRecursoPropio.Value = 1;

      #endregion

      #region RECEPTOR

      data.Receptor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Receptor.NumeroSeguridadSocial.Value = "12345678901";
      data.Receptor.FechaInicioRelacionLaboral.Value = DateTime.Now;
      data.Receptor.Antiguedad.Value = "P2W";
      data.Receptor.TipoContrato.Value = "01";
      data.Receptor.Sindicalizado.Value = "Sí";
      data.Receptor.TipoJornada.Value = "03";
      data.Receptor.TipoRegimen.Value = "02";
      data.Receptor.NumeroEmpleado.Value = "1968";
      data.Receptor.Departamento.Value = "Contabilidad";
      data.Receptor.Puesto.Value = "Auxiliar Contable";
      data.Receptor.RiesgoPuesto.Value = "1";
      data.Receptor.PeriodicidadPago.Value = "05";
      data.Receptor.Banco.Value = "021";
      data.Receptor.CuentaBancaria.Value = "2147483640";
      data.Receptor.SalarioBaseCotApor.Value = 300;
      data.Receptor.SalarioDiarioIntegrado.Value = 335;
      data.Receptor.ClaveEntidadFederativa.Value = "AGU";

      SubContratacion subcontratacion = data.Receptor.SubContrataciones.Add();
      subcontratacion.RfcLabora.Value = "AAA010101AAA";
      subcontratacion.PorcentajeTiempo.Value = 100;

      #endregion

      #region PERCEPCIONES

      data.Percepciones.TotalSueldos.Value = 9100;
      data.Percepciones.TotalSeparacionIndemnizacion.Value = 100;
      data.Percepciones.TotalJubilacionPensionRetiro.Value = 100;
      data.Percepciones.TotalGravado.Value = 9100;
      data.Percepciones.TotalExento.Value = 0;

      Percepcion percepcion = data.Percepciones.Add();
      percepcion.Tipo.Value = "001";
      percepcion.Clave.Value = "100";
      percepcion.Concepto.Value = "Sueldo";
      percepcion.ImporteGravado.Value = 9000;
      percepcion.ImporteExento.Value = 0;

      percepcion.AccionesTitulos.ValorMercado.Value = 0.000001;
      percepcion.AccionesTitulos.PrecioAlOtorgarse.Value = 0.000001;

      HorasExtra horasExtra = percepcion.HorasExtras.Add();
      horasExtra.Dias.Value = 1;
      horasExtra.Tipo.Value = "03";
      horasExtra.Horas.Value = 3;
      horasExtra.ImportePagado.Value = 112.50;

      data.Percepciones.JubilacionPensionRetiro.TotalUnaExhibicion.Value = 50;
      data.Percepciones.JubilacionPensionRetiro.TotalParcialidad.Value = 50;
      data.Percepciones.JubilacionPensionRetiro.MontoDiario.Value = 20;
      data.Percepciones.JubilacionPensionRetiro.IngresoAcumulable.Value = 50;
      data.Percepciones.JubilacionPensionRetiro.IngresoNoAcumulable.Value = 100;

      data.Percepciones.SeparacionIndemnizacion.TotalPagado.Value = 300;
      data.Percepciones.SeparacionIndemnizacion.NumeroAniosServicio.Value = 1;
      data.Percepciones.SeparacionIndemnizacion.UltimoSueldoMensualOrdinario.Value = 300;
      data.Percepciones.SeparacionIndemnizacion.IngresoAcumulable.Value = 50;
      data.Percepciones.SeparacionIndemnizacion.IngresoNoAcumulable.Value = 100;

      #endregion

      #region DEDUCCIONES

      data.Deducciones.TotalOtrasDeducciones.Value = 100.00;
      data.Deducciones.TotalImpuestosRetenidos.Value = 150.00;

      Deduccion deduccion = data.Deducciones.Add();
      deduccion.Tipo.Value = "001";
      deduccion.Clave.Value = "201";
      deduccion.Concepto.Value = "IMSS";
      deduccion.Importe.Value = 100.00;

      #endregion

      #region OTROS PAGOS

      OtroPago otroPago = data.OtrosPagos.Add();
      otroPago.Tipo.Value = "003";
      otroPago.Clave.Value = "300";
      otroPago.Concepto.Value = "Viáticos";
      otroPago.Importe.Value = 100;

      otroPago.SubsidioAlEmpleo.SubsidioCausado.Value = 0;

      otroPago.CompensacionSaldosAFavor.SaldoAFavor.Value = 32;
      otroPago.CompensacionSaldosAFavor.Anio.Value = 2016;
      otroPago.CompensacionSaldosAFavor.RemanenteSaldoFavor.Value = 31;

      #endregion

      #region INCAPACIDADES

      Incapacidad incapacidad = data.Incapacidades.Add();
      incapacidad.DiasIncapacidad.Value = 1;
      incapacidad.TipoNomina.Value = "03";
      incapacidad.ImporteMonetario.Value = 300;

      #endregion
    }

    public static void CargarDatosListas(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi40(electronicDocument.Data);

      electronicDocument.Data.Complementos.Add(ComplementoType.Nomina);
      ElectronicDocumentLibrary.Complemento.Nomina.Data data = (ElectronicDocumentLibrary.Complemento.Nomina.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.2";
      data.TipoNomina.Value = "O";
      data.FechaPago.Value = DateTime.Now;
      data.FechaInicialPago.Value = DateTime.Now;
      data.FechaFinalPago.Value = DateTime.Now.AddDays(15);
      data.NumeroDiasPagados.Value = 30;
      data.NumeroDiasPagados.Decimals = 3;
      data.TotalPercepciones.Value = 9100.00;
      data.TotalDeducciones.Value = 250;
      data.TotalOtrosPagos.Value = 200;

      #region EMISOR

      data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Emisor.RegistroPatronal.Value = "12345678901";
      data.Emisor.RfcPatronOrigen.Value = "AAA010101AAA";
      data.Emisor.EntidadSncf.OrigenRecurso.Value = "IP";
      data.Emisor.EntidadSncf.MontoRecursoPropio.Value = 1;

      #endregion
      
      #region RECEPTOR

      data.Receptor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Receptor.NumeroSeguridadSocial.Value = "12345678901";
      data.Receptor.FechaInicioRelacionLaboral.Value = DateTime.Now;
      data.Receptor.Antiguedad.Value = "P2W";
      data.Receptor.TipoContrato.Value = "01";
      data.Receptor.Sindicalizado.Value = "Sí";
      data.Receptor.TipoJornada.Value = "03";
      data.Receptor.TipoRegimen.Value = "02";
      data.Receptor.NumeroEmpleado.Value = "1968";
      data.Receptor.Departamento.Value = "Contabilidad";
      data.Receptor.Puesto.Value = "Auxiliar Contable";
      data.Receptor.RiesgoPuesto.Value = "1";
      data.Receptor.PeriodicidadPago.Value = "05";
      data.Receptor.Banco.Value = "021";
      data.Receptor.CuentaBancaria.Value = "2147483640";
      data.Receptor.SalarioBaseCotApor.Value = 300;
      data.Receptor.SalarioDiarioIntegrado.Value = 335;
      data.Receptor.ClaveEntidadFederativa.Value = "AGU";

      for (int i = 1; i <= 2; i++)
      {
        SubContratacion subcontratacion = data.Receptor.SubContrataciones.Add();
        subcontratacion.RfcLabora.Value = "AAA010101AAA";
        subcontratacion.PorcentajeTiempo.Value = 100;
      }

      #endregion

      #region PERCEPCIONES

      data.Percepciones.TotalSueldos.Value = 9100;
      data.Percepciones.TotalSeparacionIndemnizacion.Value = 100;
      data.Percepciones.TotalJubilacionPensionRetiro.Value = 100;
      data.Percepciones.TotalGravado.Value = 9100;
      data.Percepciones.TotalExento.Value = 0;

      for (int i = 1; i <= 3; i++)
      {
        Percepcion percepcion = data.Percepciones.Add();
        percepcion.Tipo.Value = "001";
        percepcion.Clave.Value = "100";
        percepcion.Concepto.Value = "Sueldo";
        percepcion.ImporteGravado.Value = 9000;
        percepcion.ImporteExento.Value = 0;

        percepcion.AccionesTitulos.ValorMercado.Value = 0.000001;
        percepcion.AccionesTitulos.PrecioAlOtorgarse.Value = 0.000001;

        for (int j = 1; j <= 4; j++)
        {
          HorasExtra horasExtra = percepcion.HorasExtras.Add();
          horasExtra.Dias.Value = 1;
          horasExtra.Tipo.Value = "03";
          horasExtra.Horas.Value = 3;
          horasExtra.ImportePagado.Value = 112.50;
        }


        data.Percepciones.JubilacionPensionRetiro.TotalUnaExhibicion.Value = 50;
        data.Percepciones.JubilacionPensionRetiro.TotalParcialidad.Value = 50;
        data.Percepciones.JubilacionPensionRetiro.MontoDiario.Value = 20;
        data.Percepciones.JubilacionPensionRetiro.IngresoAcumulable.Value = 50;
        data.Percepciones.JubilacionPensionRetiro.IngresoNoAcumulable.Value = 100;

        data.Percepciones.SeparacionIndemnizacion.TotalPagado.Value = 300;
        data.Percepciones.SeparacionIndemnizacion.NumeroAniosServicio.Value = 1;
        data.Percepciones.SeparacionIndemnizacion.UltimoSueldoMensualOrdinario.Value = 300;
        data.Percepciones.SeparacionIndemnizacion.IngresoAcumulable.Value = 50;
        data.Percepciones.SeparacionIndemnizacion.IngresoNoAcumulable.Value = 100;
      }

      #endregion

      #region DEDUCCIONES

      data.Deducciones.TotalOtrasDeducciones.Value = 100.00;
      data.Deducciones.TotalImpuestosRetenidos.Value = 150.00;

      for (int i = 1; i <= 5; i++)
      {
        Deduccion deduccion = data.Deducciones.Add();
        deduccion.Tipo.Value = "001";
        deduccion.Clave.Value = "201";
        deduccion.Concepto.Value = "IMSS";
        deduccion.Importe.Value = 100.00;
      }

      #endregion

      #region OTROS PAGOS

      for (int i = 1; i <= 6; i++)
      {
        OtroPago otroPago = data.OtrosPagos.Add();
        otroPago.Tipo.Value = "003";
        otroPago.Clave.Value = "300";
        otroPago.Concepto.Value = "Viáticos";
        otroPago.Importe.Value = 100;

        otroPago.SubsidioAlEmpleo.SubsidioCausado.Value = 0;

        otroPago.CompensacionSaldosAFavor.SaldoAFavor.Value = 32;
        otroPago.CompensacionSaldosAFavor.Anio.Value = 2016;
        otroPago.CompensacionSaldosAFavor.RemanenteSaldoFavor.Value = 31;
      }

      #endregion

      #region INCAPACIDADES

      for (int i = 1; i <= 7; i++)
      {
        Incapacidad incapacidad = data.Incapacidades.Add();
        incapacidad.DiasIncapacidad.Value = 1;
        incapacidad.TipoNomina.Value = "03";
        incapacidad.ImporteMonetario.Value = 300;
      }
      
      #endregion
    }

    public static void CargarDatosMinimo(ElectronicDocument electronicDocument)
    {
      CargarDatosCfdi40(electronicDocument.Data);

      electronicDocument.Data.Complementos.Add(ComplementoType.Nomina);
      ElectronicDocumentLibrary.Complemento.Nomina.Data data = (ElectronicDocumentLibrary.Complemento.Nomina.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.2";
      data.TipoNomina.Value = "O";
      data.FechaPago.Value = DateTime.Now;
      data.FechaInicialPago.Value = DateTime.Now;
      data.FechaFinalPago.Value = DateTime.Now.AddDays(15);
      data.NumeroDiasPagados.Value = 30;
      data.NumeroDiasPagados.Decimals = 3;

      data.Receptor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Receptor.TipoContrato.Value = "01";
      data.Receptor.TipoRegimen.Value = "02";
      data.Receptor.NumeroEmpleado.Value = "1968";
      data.Receptor.PeriodicidadPago.Value = "05";
      data.Receptor.ClaveEntidadFederativa.Value = "AGU";
    }

    private static void CargarDatosCfdi40(ElectronicDocumentLibrary.Document.Data data)
    {
      data.Clear();

      // Datos del comprobante ****************************************************************
      data.Version.Value = "4.0";
      data.Serie.Value = "CFDI";
      data.Folio.Value = "40";
      data.Fecha.Value = DateTime.Now;
      data.SubTotal.Value = 9300.00;
      data.Descuento.Value = 250.00;
      data.Total.Value = 9050.00;
      data.MetodoPago.Value = "PUE";
      data.TipoComprobante.Value = "N";
      data.Exportacion.Value = "01";
      data.Moneda.Value = "MXN";
      data.LugarExpedicion.Value = "01000";
      // ***************************************************************************************

      Base.Emisor(data.Emisor);
      Base.Receptor(data.Receptor);

      data.Receptor.RegimenFiscalReceptor.Value = "605";
      data.Receptor.UsoCfdi.Value = "CN01";


      // Concepto  ************************************************************************
      Concepto concepto = data.Conceptos.Add();

      concepto.ClaveProductoServicio.Value = "84111505";
      concepto.Cantidad.Value = 1;
      concepto.Cantidad.Decimals = 0;
      concepto.Cantidad.Dot = false;
      concepto.ClaveUnidad.Value = "ACT";
      concepto.Descripcion.Value = "Pago de nómina";
      concepto.ValorUnitario.Value = 9300.00;
      concepto.Importe.Value = 9300.00;
      concepto.Descuento.Value = 250;
      concepto.ObjetoImpuesto.Value = "01";
    }

    private static void CargarDatosCfdi33(ElectronicDocumentLibrary.Document.Data data)
    {
      data.Clear();

      // Datos del comprobante ****************************************************************
      data.Version.Value = "3.3";
      data.Serie.Value = "C";
      data.Folio.Value = "2000";
      data.Fecha.Value = DateTime.Now;
      data.FormaPago.Value = "99";
      data.SubTotal.Value = 9300.00;
      data.Descuento.Value = 250.00;
      data.Total.Value = 9050.00;
      data.MetodoPago.Value = "PUE";
      data.TipoComprobante.Value = "N";
      data.Moneda.Value = "MXN";
      data.LugarExpedicion.Value = "01000";
      // ***************************************************************************************

      Base.Emisor(data.Emisor);

      // Datos del Receptor ********************************************************************
      data.Receptor.Rfc.Value = "AAAD770905441";
      data.Receptor.Nombre.Value = "Empleado de prueba";
      data.Receptor.UsoCfdi.Value = "P01";
      // ***************************************************************************************

      // Concepto  *****************************************************************************
      Concepto concepto = data.Conceptos.Add();

      concepto.ClaveProductoServicio.Value = "84111505";
      concepto.Cantidad.Value = 1;
      concepto.Cantidad.Decimals = 0;
      concepto.Cantidad.Dot = false;
      concepto.ClaveUnidad.Value = "ACT";
      concepto.Descripcion.Value = "Pago de nómina";
      concepto.ValorUnitario.Value = 9300.00;
      concepto.Importe.Value = 9300.00;
      concepto.Descuento.Value = 250;
    }
  }
}
