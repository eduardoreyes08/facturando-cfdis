using System;
using HyperSoft.Ejemplo.Information.Complemento;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Information
{
  public static class Constancia
  {
    public static string Show(ConstanciaRetenciones retenciones)
    {
      Utils.ShowTitle("CONSTANCIA DE RETENCIONES");
      Utils.ShowField("Versión            ", retenciones.Data.Version);
      Utils.ShowField("Folio              ", retenciones.Data.Folio);
      Utils.ShowField("Sello              ", retenciones.Data.Sello);
      Utils.ShowField("No de certificado  ", retenciones.Data.NumeroCertificado);
      Utils.ShowField("Fecha de expedición", retenciones.Data.FechaExpedicion);
      Utils.ShowField("Lugar de expedición", retenciones.Data.LugarExpedicion);
      Utils.ShowField("Clave              ", retenciones.Data.Clave);
      Utils.ShowField("Descripción        ", retenciones.Data.Descripcion);
      //Utils.ShowField("Certificado        ", retenciones.Data.Certificado);

      if (retenciones.Data.CfdiRelacionado.IsAssigned)
      {
        Utils.ShowTitle("CFDI Relacionado");
        Utils.ShowField("Tipo de relación", retenciones.Data.CfdiRelacionado.TipoRelacion);
        Utils.ShowField("UUID            ", retenciones.Data.CfdiRelacionado.Uuid);
      }

      Utils.ShowTitle("EMISOR");
      Utils.ShowField("RFC           ", retenciones.Data.Emisor.Rfc);
      Utils.ShowField("Razón social  ", retenciones.Data.Emisor.RazonSocial);
      Utils.ShowField("CURP          ", retenciones.Data.Emisor.Curp);
      Utils.ShowField("Régimen fiscal", retenciones.Data.Emisor.RegimenFiscal);

      Utils.ShowTitle("RECEPTOR");
      Utils.ShowField("Nacionalidad", retenciones.Data.Receptor.Nacionalidad);

      if (retenciones.Data.Receptor.Nacional.IsAssigned)
      {
        Utils.ShowTitle("RECEPTOR - NACIONAL");
        Utils.ShowField("RFC             ", retenciones.Data.Receptor.Nacional.Rfc);
        Utils.ShowField("Razón social    ", retenciones.Data.Receptor.Nacional.RazonSocial);
        Utils.ShowField("CURP            ", retenciones.Data.Receptor.Nacional.Curp);
        Utils.ShowField("Domicilio fiscal", retenciones.Data.Receptor.Nacional.DomicilioFiscal);
      }

      if (retenciones.Data.Receptor.Extranjero.IsAssigned)
      {
        Utils.ShowTitle("RECEPTOR - EXTRANJERO");
        Utils.ShowField("No. identificación", retenciones.Data.Receptor.Extranjero.NumeroIdentificacionFiscal);
        Utils.ShowField("Razón social      ", retenciones.Data.Receptor.Extranjero.RazonSocial);
      }

      Utils.ShowTitle("PERIODO");
      Utils.ShowField("Mes inicial", retenciones.Data.Periodo.MesInicial);
      Utils.ShowField("Mes final  ", retenciones.Data.Periodo.MesFinal);
      Utils.ShowField("Ejercicio  ", retenciones.Data.Periodo.Ejercicio);

      Utils.ShowTitle("TOTALES");
      Utils.ShowField("Monto de operación ", retenciones.Data.Totales.MontoOperacion);
      Utils.ShowField("Monto gravado      ", retenciones.Data.Totales.MontoGravado);
      Utils.ShowField("Monto exento       ", retenciones.Data.Totales.MontoExento);
      Utils.ShowField("Monto retenido     ", retenciones.Data.Totales.MontoRetenido);
      Utils.ShowField("Utilidad bimestral ", retenciones.Data.Totales.UtilidadBimestral);
      Utils.ShowField("ISR Correspondiente", retenciones.Data.Totales.IsrCorrespondiente);

      for (int i = 0; i < retenciones.Data.Totales.ImpuestosRetenidos.Count; i++)
      {
        Utils.ShowTitle("TOTALES - IMPUESTO RETENIDO - " + (i + 1));
        Utils.ShowField("Base          ", retenciones.Data.Totales.ImpuestosRetenidos[i].Base);
        Utils.ShowField("Impuesto      ", retenciones.Data.Totales.ImpuestosRetenidos[i].Impuesto);
        Utils.ShowField("Monto retenido", retenciones.Data.Totales.ImpuestosRetenidos[i].MontoRetenido);
        Utils.ShowField("Tipo de pago  ", retenciones.Data.Totales.ImpuestosRetenidos[i].TipoPago);
      }

      //*********************************************************************************************
      for (int i = 0; i < retenciones.Data.Complementos.Count; i++)
      {
        switch (retenciones.Data.Complementos.Type(i))
        {
          case ComplementoConstanciaRetencionesType.TimbreFiscalDigital:
            TimbreFiscalDigital.Show((ElectronicDocumentLibrary.Complemento.TimbreFiscalDigital.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.PlataformasTecnologicas:
            Complemento.Retenciones.PlataformasTecnologicas.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.PlataformasTecnologicas.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.Intereses:
            Complemento.Retenciones.Intereses.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.Intereses.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.ArrendamientoFideicomiso:
            Complemento.Retenciones.ArrendamientoEnFideicomiso.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.ArrendamientoFideicomiso.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.Dividendos:
            Complemento.Retenciones.Dividendos.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.Dividendos.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.EnajenacionAcciones:
            Complemento.Retenciones.EnajenacionAcciones.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.EnajenacionAcciones.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.FideicomisoNoEmpresarial:
            Complemento.Retenciones.FideicomisoNoEmpresarial.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.FideicomisoNoEmpresarial.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.InteresesHipotecarios:
            Complemento.Retenciones.InteresesHipotecarios.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.InteresesHipotecarios.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.OperacionesConDerivados:
            Complemento.Retenciones.OperacionesConDerivados.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.OperacionesConDerivados.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.PagosExtranjeros:
            Complemento.Retenciones.PagosExtranjeros.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.PagosExtranjeros.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.PlanesRetiro:
            Complemento.Retenciones.PlanesRetiro.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.PlanesRetiro.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.Premios:
            Complemento.Retenciones.Premios.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.Premios.Data)retenciones.Data.Complementos.Data(i));
            break;

          case ComplementoConstanciaRetencionesType.SectorFinanciero:
            Complemento.Retenciones.SectorFinanciero.Show((ElectronicDocumentLibrary.ConstanciaRetenciones.SectorFinanciero.Data)retenciones.Data.Complementos.Data(i));
            break;

          default:
            throw new ArgumentOutOfRangeException();
        }
      }

      //*********************************************************************************************
      Utils.ShowTitle("INFORMACION DEL CERTIFICADO USADO EN LA GENERACION DE LA CONSTANCIA");
      Utils.ShowValue("Número de serie ", retenciones.Manage.Load.Certificate.Information.SerialNumber);
      Utils.ShowValue("Valido desde    ", retenciones.Manage.Load.Certificate.Information.ValidFrom.ToString("dd/MM/yyyy"));
      Utils.ShowValue("Valido hasta    ", retenciones.Manage.Load.Certificate.Information.ValidTo.ToString("dd/MM/yyyy"));
      Utils.ShowValue("Id              ", retenciones.Manage.Load.Certificate.Information.Subject.Id);
      Utils.ShowValue("Country         ", retenciones.Manage.Load.Certificate.Information.Subject.Country);
      Utils.ShowValue("StateOrProvince ", retenciones.Manage.Load.Certificate.Information.Subject.StateOrProvince);
      Utils.ShowValue("Locality        ", retenciones.Manage.Load.Certificate.Information.Subject.Locality);
      Utils.ShowValue("Organization    ", retenciones.Manage.Load.Certificate.Information.Subject.Organization);
      Utils.ShowValue("Organization Uni", retenciones.Manage.Load.Certificate.Information.Subject.OrganizationUnit);
      Utils.ShowValue("CommonName      ", retenciones.Manage.Load.Certificate.Information.Subject.CommonName);
      Utils.ShowValue("EMailAddress    ", retenciones.Manage.Load.Certificate.Information.Subject.EMailAddress);

      //*********************************************************************************************
      Utils.ShowTitle("CADENA ORIGINAL");
      Utils.ShowValue("Cadena original    ", retenciones.FingerPrint);
      Utils.ShowValue("Digestion          ", retenciones.Diggest(DiggestType.FingerPrint));
      Utils.ShowValue("Cadena original PAC", retenciones.FingerPrintPac);
      Utils.ShowValue("Digestion          ", retenciones.Diggest(DiggestType.FingerPrintPac));

      return Utils.Finalization();
    }
  }
}