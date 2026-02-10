using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Information
{
  public static class Cfdi
  {
    public static string Show(ElectronicDocument electronicDocument)
    {
      #region DOCUMENTO

      Utils.ShowTitle("DOCUMENTO");
      Utils.ShowField("Versión              ", electronicDocument.Data.Version);
      Utils.ShowField("Serie                ", electronicDocument.Data.Serie);
      Utils.ShowField("Sello                ", electronicDocument.Data.Sello);
      Utils.ShowField("Número de aprobacion ", electronicDocument.Data.NumeroAprobacion);
      Utils.ShowField("Año de aprobacion    ", electronicDocument.Data.AnioAprobacion);
      Utils.ShowField("Forma de pago        ", electronicDocument.Data.FormaPago);
      Utils.ShowField("Folio                ", electronicDocument.Data.Folio);
      Utils.ShowField("Fecha                ", electronicDocument.Data.Fecha);
      Utils.ShowField("Número de certificado", electronicDocument.Data.NumeroCertificado);
      Utils.ShowField("Descuento            ", electronicDocument.Data.Descuento);
      Utils.ShowField("Motivo de descuento  ", electronicDocument.Data.MotivoDescuento);
      Utils.ShowField("Metodo de pago       ", electronicDocument.Data.MetodoPago);
      Utils.ShowField("Condiciones de pago  ", electronicDocument.Data.CondicionesPago);
      Utils.ShowField("Tipo de omprobante   ", electronicDocument.Data.TipoComprobante);
      Utils.ShowField("SubTotal             ", electronicDocument.Data.SubTotal);
      Utils.ShowField("Total                ", electronicDocument.Data.Total);
      Utils.ShowField("Moneda               ", electronicDocument.Data.Moneda);
      Utils.ShowField("Tipo de cambio       ", electronicDocument.Data.TipoCambio);
      Utils.ShowField("Tipo de cambio       ", electronicDocument.Data.TipoCambioMx);
      Utils.ShowField("Lugar de expedición  ", electronicDocument.Data.LugarExpedicion);
      Utils.ShowField("Confirmación         ", electronicDocument.Data.Confirmacion);
      Utils.ShowField("Exportación          ", electronicDocument.Data.Exportacion);
      //Utils.ShowField("Certificado          ", electronicDocument.Data.Certificado);
      #endregion

      #region INFORMACIÓN GLOBAL

      if (electronicDocument.Data.InformacionGlobal.IsAssigned)
      {
        Utils.ShowTitle("INFORMACION GLOBAL");
        Utils.ShowField("Periodicidad", electronicDocument.Data.InformacionGlobal.Periodicidad);
        Utils.ShowField("Meses       ", electronicDocument.Data.InformacionGlobal.Meses);
        Utils.ShowField("Anio        ", electronicDocument.Data.InformacionGlobal.Anio);
      }

      #endregion

      #region CFDI RELACIONADOS

      #region Este código es para el CFDI 3.3

      if (electronicDocument.Data.CfdiRelacionados.IsAssigned)
      {
        Utils.ShowTitle("CFDI RELACIONADOS");
        Utils.ShowField("Tipo de relación", electronicDocument.Data.CfdiRelacionados.TipoRelacion);

        for (int i = 0; i < electronicDocument.Data.CfdiRelacionados.Count; i++)
        {
          Utils.ShowTitle("CFDI - " + (i + 1));
          Utils.ShowField("UUID", electronicDocument.Data.CfdiRelacionados[i].Uuid);
        }
      }

      #endregion

      #region Este código es para el CFDI 4.0

      if (electronicDocument.Data.CfdiRelacionadosExt.IsAssigned)
      {
        for (int i = 0; i < electronicDocument.Data.CfdiRelacionadosExt.Count; i++)
        {
          Relacionados relacionados = electronicDocument.Data.CfdiRelacionadosExt[i];

          Utils.ShowTitle($"CFDI RELACIONADOS - {i + 1}");
          Utils.ShowField("Tipo de relación", relacionados.CfdiRelacionados.TipoRelacion);

          for (int j = 0; j < relacionados.CfdiRelacionados.Count; j++)
            Utils.ShowField($"UUID - {j + 1}        ", relacionados.CfdiRelacionados[j].Uuid);
        }
      }

      #endregion

      #endregion

      #region EMISOR

      Utils.ShowTitle("EMISOR");
      Utils.ShowField("RFC             ", electronicDocument.Data.Emisor.Rfc);
      Utils.ShowField("Nombre          ", electronicDocument.Data.Emisor.Nombre);
      Utils.ShowField("Régimen fiscal  ", electronicDocument.Data.Emisor.RegimenFiscal);
      Utils.ShowField("FacAtrAdquirente", electronicDocument.Data.Emisor.FacAtrAdquirente);

      if (electronicDocument.Data.Emisor.Domicilio.IsAssigned)
      {
        Utils.ShowTitle("DOMICILIO FISCAL");
        Utils.ShowField("Calle          ", electronicDocument.Data.Emisor.Domicilio.Calle);
        Utils.ShowField("Número exterior", electronicDocument.Data.Emisor.Domicilio.NumeroExterior);
        Utils.ShowField("Número interior", electronicDocument.Data.Emisor.Domicilio.NumeroInterior);
        Utils.ShowField("Colonia        ", electronicDocument.Data.Emisor.Domicilio.Colonia);
        Utils.ShowField("Localidad      ", electronicDocument.Data.Emisor.Domicilio.Localidad);
        Utils.ShowField("Referencia     ", electronicDocument.Data.Emisor.Domicilio.Referencia);
        Utils.ShowField("Municipio      ", electronicDocument.Data.Emisor.Domicilio.Municipio);
        Utils.ShowField("Estado         ", electronicDocument.Data.Emisor.Domicilio.Estado);
        Utils.ShowField("Pais           ", electronicDocument.Data.Emisor.Domicilio.Pais);
        Utils.ShowField("Código postal  ", electronicDocument.Data.Emisor.Domicilio.CodigoPostal);
      }

      if (electronicDocument.Data.Emisor.ExpedidoEn.IsAssigned)
      {
        Utils.ShowTitle("EXPEDIDO EN");
        Utils.ShowField("Calle          ", electronicDocument.Data.Emisor.ExpedidoEn.Calle);
        Utils.ShowField("Número exterior", electronicDocument.Data.Emisor.ExpedidoEn.NumeroExterior);
        Utils.ShowField("Número interior", electronicDocument.Data.Emisor.ExpedidoEn.NumeroInterior);
        Utils.ShowField("Colonia        ", electronicDocument.Data.Emisor.ExpedidoEn.Colonia);
        Utils.ShowField("Localidad      ", electronicDocument.Data.Emisor.ExpedidoEn.Localidad);
        Utils.ShowField("Referencia     ", electronicDocument.Data.Emisor.ExpedidoEn.Referencia);
        Utils.ShowField("Municipio      ", electronicDocument.Data.Emisor.ExpedidoEn.Municipio);
        Utils.ShowField("Estado         ", electronicDocument.Data.Emisor.ExpedidoEn.Estado);
        Utils.ShowField("Pais           ", electronicDocument.Data.Emisor.ExpedidoEn.Pais);
        Utils.ShowField("Código postal  ", electronicDocument.Data.Emisor.ExpedidoEn.CodigoPostal);
      }

      #endregion

      #region RECEPTOR

      Utils.ShowTitle("RECEPTOR");
      Utils.ShowField("RFC              ", electronicDocument.Data.Receptor.Rfc);
      Utils.ShowField("Nombre           ", electronicDocument.Data.Receptor.Nombre);
      Utils.ShowField("Residencia fiscal", electronicDocument.Data.Receptor.ResinciaFiscal);
      Utils.ShowField("Id tributario    ", electronicDocument.Data.Receptor.NumeroRegistroIdTributario);
      Utils.ShowField("Regimen fiscal   ", electronicDocument.Data.Receptor.RegimenFiscalReceptor);
      Utils.ShowField("Uso del CFDI     ", electronicDocument.Data.Receptor.UsoCfdi);
      Utils.ShowField("Domiclio         ", electronicDocument.Data.Receptor.DomicilioFiscalReceptor);

      if (electronicDocument.Data.Receptor.Domicilio.IsAssigned)
      {
        Utils.ShowTitle("DOMICILIO FISCAL");
        Utils.ShowField("Calle          ", electronicDocument.Data.Receptor.Domicilio.Calle);
        Utils.ShowField("Número exterior", electronicDocument.Data.Receptor.Domicilio.NumeroExterior);
        Utils.ShowField("Número interior", electronicDocument.Data.Receptor.Domicilio.NumeroInterior);
        Utils.ShowField("Colonia        ", electronicDocument.Data.Receptor.Domicilio.Colonia);
        Utils.ShowField("Localidad      ", electronicDocument.Data.Receptor.Domicilio.Localidad);
        Utils.ShowField("Referencia     ", electronicDocument.Data.Receptor.Domicilio.Referencia);
        Utils.ShowField("Municipio      ", electronicDocument.Data.Receptor.Domicilio.Municipio);
        Utils.ShowField("Estado         ", electronicDocument.Data.Receptor.Domicilio.Estado);
        Utils.ShowField("Pais           ", electronicDocument.Data.Receptor.Domicilio.Pais);
        Utils.ShowField("Código postal  ", electronicDocument.Data.Receptor.Domicilio.CodigoPostal);
      }

      #endregion

      #region CONCEPTOS

      for (int i = 0; i < electronicDocument.Data.Conceptos.Count; i++)
      {
        Concepto concepto = electronicDocument.Data.Conceptos[i];

        string title = $"CONCEPTO - {i + 1}";

        Utils.ShowTitle(title);
        Utils.ShowField("Clave del producto-servicio", concepto.ClaveProductoServicio);
        Utils.ShowField("Numero de identificación   ", concepto.NumeroIdentificacion);
        Utils.ShowField("Cantidad                   ", concepto.Cantidad);
        Utils.ShowField("Clave de la unidad         ", concepto.ClaveUnidad);
        Utils.ShowField("Unidad                     ", concepto.Unidad);
        Utils.ShowField("Descripción                ", concepto.Descripcion);
        Utils.ShowField("Valor unitario             ", concepto.ValorUnitario);
        Utils.ShowField("Importe                    ", concepto.Importe);
        Utils.ShowField("Descuento                  ", concepto.Descuento);
        Utils.ShowField("Objeto de impuesto         ", concepto.ObjetoImpuesto);

        for (int j = 0; j < concepto.Impuestos.Traslados.Count; j++)
        {
          Utils.ShowTitle($"{title} / IMP. TRASLADADO - {j + 1}");
          Utils.ShowField("Base        ", concepto.Impuestos.Traslados[j].Base);
          Utils.ShowField("Impuesto    ", concepto.Impuestos.Traslados[j].Impuesto);
          Utils.ShowField("Tipo factor ", concepto.Impuestos.Traslados[j].TipoFactor);
          Utils.ShowField("Tasa o cuota", concepto.Impuestos.Traslados[j].TasaCuota);
          Utils.ShowField("Importe     ", concepto.Impuestos.Traslados[j].Importe);
        }

        for (int j = 0; j < concepto.Impuestos.Retenciones.Count; j++)
        {
          Utils.ShowTitle($"{title} / IMP. RETENCION - {j + 1}");
          Utils.ShowField("Base        ", concepto.Impuestos.Retenciones[j].Base);
          Utils.ShowField("Impuesto    ", concepto.Impuestos.Retenciones[j].Impuesto);
          Utils.ShowField("Tipo factor ", concepto.Impuestos.Retenciones[j].TipoFactor);
          Utils.ShowField("Tasa o cuota", concepto.Impuestos.Retenciones[j].TasaCuota);
          Utils.ShowField("Importe     ", concepto.Impuestos.Retenciones[j].Importe);
        }

        if (concepto.ACuentaTerceros.IsAssigned)
        {
          Utils.ShowTitle($"{title} / A CUENTA DE TERCEROS");
          Utils.ShowField("Rfc      ", concepto.ACuentaTerceros.Rfc);
          Utils.ShowField("Nombre   ", concepto.ACuentaTerceros.Nombre);
          Utils.ShowField("Regimen  ", concepto.ACuentaTerceros.RegimenFiscal);
          Utils.ShowField("Domicilio", concepto.ACuentaTerceros.DomicilioFiscal);
        }

        for (int j = 0; j < concepto.InformacionAduanera.Count; j++)
        {
          Utils.ShowTitle($"{title} / INFORMACION ADUANERA - {j + 1}");
          Utils.ShowField("Número", concepto.InformacionAduanera[j].Numero);
          Utils.ShowField("Fecha ", concepto.InformacionAduanera[j].Fecha);
          Utils.ShowField("Aduana", concepto.InformacionAduanera[j].Aduana);
        }

        #region CUENTA PREDIAL

        // Código para el CFDI 4.0
        for (int j = 0; j < concepto.CuentasPrediales.Count; j++)
        {
          Utils.ShowTitle($"{title} / CUENTA PREDIAL - {j + 1}");
          Utils.ShowField("Número     ", concepto.CuentasPrediales[j].Numero);
        }

        // Código para el CFDI 3.3
        if (concepto.CuentaPredial.IsAssigned)
        {
          Utils.ShowTitle($"{title} / CUENTA PREDIAL");
          Utils.ShowField("Base        ", concepto.CuentaPredial.Numero);
        }

        #endregion

        for (int j = 0; j < concepto.Partes.Count; j++)
        {
          Partida parte = concepto.Partes[j];

          title = $"{title} / PARTE - {j + 1}";
          Utils.ShowTitle(title);
          Utils.ShowField("Clave del producto-servicio", parte.ClaveProductoServicio);
          Utils.ShowField("Numero de identificación   ", parte.NumeroIdentificacion);
          Utils.ShowField("Cantidad                   ", parte.Cantidad);
          Utils.ShowField("Unidad                     ", parte.Unidad);
          Utils.ShowField("Descripción                ", parte.Descripcion);
          Utils.ShowField("Valor unitario             ", parte.ValorUnitario);
          Utils.ShowField("Importe                    ", parte.Importe);

          for (int k = 0; k < parte.InformacionAduanera.Count; k++)
          {
            Utils.ShowTitle($"{title} / INFORMACION ADUANERA - {k + 1}");
            Utils.ShowField("Numero", parte.InformacionAduanera[k].Numero);
            Utils.ShowField("Fecha ", parte.InformacionAduanera[k].Fecha);
            Utils.ShowField("Aduana", parte.InformacionAduanera[k].Aduana);
          }
        }

        for (int j = 0; j < concepto.Complementos.Count; j++)
        {
          switch (concepto.Complementos.Type(i))
          {
            case ComplementoConceptoType.EmisionPorCuentaDeTerceros:
              Complemento.EmisionPorCuentaDeTerceros.Show(j + 1, concepto.Complementos.Data(j));
              break;
            case ComplementoConceptoType.InstitucionesEducativas:
              Complemento.InstitucionesEducativas.Show(j + 1, concepto.Complementos.Data(j));
              break;
            case ComplementoConceptoType.VentaVehiculos:
              Complemento.VentaVehiculos.Show(j + 1, concepto.Complementos.Data(j));
              break;
            case ComplementoConceptoType.AcreditamientoIeps:
              Complemento.AcreditamientoIeps.Show(j + 1, concepto.Complementos.Data(j));
              break;
            default:
              throw new ArgumentOutOfRangeException();
          }
        }
      }

      #endregion

      for (int i = 0; i < electronicDocument.Data.Impuestos.Retenciones.Count; i++)
      {
        Utils.ShowTitle($"RETENCIONES - {i + 1}");
        Utils.ShowField("Tipo   ", electronicDocument.Data.Impuestos.Retenciones[i].Tipo);
        Utils.ShowField("Importe", electronicDocument.Data.Impuestos.Retenciones[i].Importe);
      }

      for (int i = 0; i < electronicDocument.Data.Impuestos.Traslados.Count; i++)
      {
        Utils.ShowTitle($"TRASLADOS - {i + 1}");
        Utils.ShowField("Base       ", electronicDocument.Data.Impuestos.Traslados[i].Base);
        Utils.ShowField("Tipo       ", electronicDocument.Data.Impuestos.Traslados[i].Tipo);
        Utils.ShowField("Tipo Factor", electronicDocument.Data.Impuestos.Traslados[i].TipoFactor);
        Utils.ShowField("Importe    ", electronicDocument.Data.Impuestos.Traslados[i].Importe);
        Utils.ShowField("Tasa       ", electronicDocument.Data.Impuestos.Traslados[i].Tasa);
        Utils.ShowField("Tasa cuota ", electronicDocument.Data.Impuestos.Traslados[i].TasaCuota);
      }

      if (electronicDocument.Data.Impuestos.TotalRetenciones.IsAssigned || electronicDocument.Data.Impuestos.TotalTraslados.IsAssigned)
      {
        Utils.ShowTitle("IMPUESTOS");
        if (electronicDocument.Data.Impuestos.TotalRetenciones.IsAssigned)
          Utils.ShowField("Total retenciones", electronicDocument.Data.Impuestos.TotalRetenciones);
        if (electronicDocument.Data.Impuestos.TotalTraslados.IsAssigned)
          Utils.ShowField("Total traslados", electronicDocument.Data.Impuestos.TotalTraslados);
      }

      //*********************************************************************************************
      Utils.ShowTitle("COMPLEMENTOS");
      for (int i = 0; i < electronicDocument.Data.Complementos.Count; i++)
      {
        switch (electronicDocument.Data.Complementos.Type(i))
        {
          case ComplementoType.TimbreFiscalDigital:
            Complemento.TimbreFiscalDigital.Show((ElectronicDocumentLibrary.Complemento.TimbreFiscalDigital.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.Nomina:
            Complemento.Nomina.Show((ElectronicDocumentLibrary.Complemento.Nomina.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.RecepcionPago:
            Complemento.RecepcionPago.Show((ElectronicDocumentLibrary.Complemento.RecepcionPago.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.ImpuestosLocales:
            Complemento.ImpuestosLocales.Show((ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.Divisas:
            Complemento.Divisas.Show((ElectronicDocumentLibrary.Complemento.Divisas.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.Donatarias:
            Complemento.Donatarias.Show((ElectronicDocumentLibrary.Complemento.Donatarias.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.EstadoDeCuentaBancario:
            Complemento.EstadoDeCuentaBancario.Show((ElectronicDocumentLibrary.Complemento.EstadoDeCuentaBancario.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.EstadoDeCuentaCombustible:
            Complemento.EstadoDeCuentaDeCombustible.Show((ElectronicDocumentLibrary.Complemento.EstadoDeCuentaDeCombustible.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.PrestadoresDeServiciosDeCfd:
            Complemento.PrestadoresDeServiciosDeCfd.Show((ElectronicDocumentLibrary.Complemento.PrestadoresDeServiciosDeCFD.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.SectorDeVentasAlDetalle:
            Complemento.Detallista.Show((ElectronicDocumentLibrary.Complemento.SectorDeVentasAlDetalle.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.Aerolineas:
            Complemento.Aerolinea.Show((ElectronicDocumentLibrary.Complemento.Aerolineas.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.RegistroFiscal:
            Complemento.RegistroFiscal.Show((ElectronicDocumentLibrary.Complemento.RegistroFiscal.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.ConsumoCombustibles:
            Complemento.ConsumoCombustibles.Show((ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.NotariosPublicos:
            Complemento.NotariosPublicos.Show((ElectronicDocumentLibrary.Complemento.NotariosPublicos.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.PagoEspecie:
            Complemento.PagoEspecie.Show((ElectronicDocumentLibrary.Complemento.PagoEspecie.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.SpeiTercero:
            Complemento.SpeiTercero.Show((ElectronicDocumentLibrary.Complemento.SpeiTercero.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.ValesDespensa:
            Complemento.ValesDespensa.Show((ElectronicDocumentLibrary.Complemento.ValesDespensa.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.CartaPorte:
            Complemento.CartaPorte.Show((ElectronicDocumentLibrary.Complemento.CartaPorte.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.ComercioExterior:
            Complemento.ComercioExterior.Show((ElectronicDocumentLibrary.Complemento.ComercioExterior.Data) electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.HidrocarburosGastos:
            Complemento.HidrocarburosGastos.Show((ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data)electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.HidrocarburosIngresos:
            Complemento.HidrocarburosIngresos.Show((ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data)electronicDocument.Data.Complementos.Data(i));
            break;

          case ComplementoType.ObrasArteAntiguedades:
            Complemento.ObrasArteAntiguedades.Show((ElectronicDocumentLibrary.Complemento.ObrasArteAntiguedades.Data)electronicDocument.Data.Complementos.Data(i));
            break;
        }
      }

      //*********************************************************************************************
      Utils.ShowTitle("INFORMACION DEL CERTIFICADO USADO EN LA GENERACION DEL CFD");
      Utils.ShowValue("Número de serie ", electronicDocument.Manage.Load.Certificate.Information.SerialNumber);
      Utils.ShowValue("Valido desde    ", electronicDocument.Manage.Load.Certificate.Information.ValidFrom.ToString("dd/MM/yyyy"));
      Utils.ShowValue("Valido hasta    ", electronicDocument.Manage.Load.Certificate.Information.ValidTo.ToString("dd/MM/yyyy"));
      Utils.ShowValue("Id              ", electronicDocument.Manage.Load.Certificate.Information.Subject.Id);
      Utils.ShowValue("Country         ", electronicDocument.Manage.Load.Certificate.Information.Subject.Country);
      Utils.ShowValue("StateOrProvince ", electronicDocument.Manage.Load.Certificate.Information.Subject.StateOrProvince);
      Utils.ShowValue("Locality        ", electronicDocument.Manage.Load.Certificate.Information.Subject.Locality);
      Utils.ShowValue("Organization    ", electronicDocument.Manage.Load.Certificate.Information.Subject.Organization);
      Utils.ShowValue("Organization Uni", electronicDocument.Manage.Load.Certificate.Information.Subject.OrganizationUnit);
      Utils.ShowValue("CommonName      ", electronicDocument.Manage.Load.Certificate.Information.Subject.CommonName);
      Utils.ShowValue("EMailAddress    ", electronicDocument.Manage.Load.Certificate.Information.Subject.EMailAddress);

      //*********************************************************************************************
      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue("Cadena original    ", electronicDocument.FingerPrint);
      Utils.ShowValue("Digestion          ", electronicDocument.Diggest(DiggestType.FingerPrint));
      Utils.ShowValue("Cadena original PAC", electronicDocument.FingerPrintPac);
      Utils.ShowValue("Digestion          ", electronicDocument.Diggest(DiggestType.FingerPrintPac));

      return Utils.Finalization();
    }
  }
}
