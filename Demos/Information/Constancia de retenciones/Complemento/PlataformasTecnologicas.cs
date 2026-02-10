namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class PlataformasTecnologicas
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.PlataformasTecnologicas.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO PLATAFORMAS TECNOLOGICAS");
      Utils.ShowField("Version                                ", data.Version);
      Utils.ShowField("Periodicidad                           ", data.Periodicidad);
      Utils.ShowField("NumeroServicio                         ", data.NumeroServicio);
      Utils.ShowField("MontoTotalServicioSinIva               ", data.MontoTotalServicioSinIva);
      Utils.ShowField("TotalIvaTrasladado                     ", data.TotalIvaTrasladado);
      Utils.ShowField("TotalIvaRetenido                       ", data.TotalIvaRetenido);
      Utils.ShowField("TotalIsrRetenido                       ", data.TotalIsrRetenido);
      Utils.ShowField("DiferenciaIvaEntregadoPrestadorServicio", data.DiferenciaIvaEntregadoPrestadorServicio);
      Utils.ShowField("MontoTotalPorUsoPlataforma             ", data.MontoTotalPorUsoPlataforma);
      Utils.ShowField("MontoTotalContribucionGubernamental    ", data.MontoTotalContribucionGubernamental);

      for (int i = 0; i < data.DetallesServicio.Count; i++)
      {
        string detalleTitle = $" - DETALLE {i + 1:N0}";

        ElectronicDocumentLibrary.ConstanciaRetenciones.PlataformasTecnologicas.DetalleServicio detalle = data.DetallesServicio[i];
        Utils.ShowTitle($"COMPLEMENTO PLATAFORMAS TECNOLOGICAS {detalleTitle}");
        Utils.ShowField("FormaPagoServicio     ", detalle.FormaPagoServicio);
        Utils.ShowField("TipoServicio          ", detalle.TipoServicio);
        Utils.ShowField("SubTipoServicio       ", detalle.SubTipoServicio);
        Utils.ShowField("RfcTerceroAutorizado  ", detalle.RfcTerceroAutorizado);
        Utils.ShowField("FechaServicio         ", detalle.FechaServicio);
        Utils.ShowField("PrecioServicioSinIva  ", detalle.PrecioServicioSinIva);

        if (detalle.ImpuestosTrasladadosServicio.IsAssigned)
        {
          Utils.ShowTitle($"COMPLEMENTO PLATAFORMAS TECNOLOGICAS {detalleTitle} - IMPUESTOS TRASLADADOS DEL SERVICIO");
          Utils.ShowField("Base      ", detalle.ImpuestosTrasladadosServicio.Base);
          Utils.ShowField("Impuesto  ", detalle.ImpuestosTrasladadosServicio.Impuesto);
          Utils.ShowField("TipoFactor", detalle.ImpuestosTrasladadosServicio.TipoFactor);
          Utils.ShowField("TasaCuota ", detalle.ImpuestosTrasladadosServicio.TasaCuota);
          Utils.ShowField("Importe   ", detalle.ImpuestosTrasladadosServicio.Importe);
        }

        if (detalle.ContribucionGubernamental.IsAssigned)
        {
          Utils.ShowTitle($"COMPLEMENTO PLATAFORMAS TECNOLOGICAS {detalleTitle} - CONTRIBUCION GUBERNAMENTAL");
          Utils.ShowField("EntidadDondePagaContribucion", detalle.ContribucionGubernamental.EntidadDondePagaContribucion);
          Utils.ShowField("ImporteContribucion         ", detalle.ContribucionGubernamental.ImporteContribucion);
        }

        if (detalle.ComisionServicio.IsAssigned)
        {
          Utils.ShowTitle($"COMPLEMENTO PLATAFORMAS TECNOLOGICAS {detalleTitle} - COMISION SERVICIO");
          Utils.ShowField("Base      ", detalle.ComisionServicio.Base);
          Utils.ShowField("Porcentaje", detalle.ComisionServicio.Porcentaje);
          Utils.ShowField("Importe   ", detalle.ComisionServicio.Importe);
        }
      }
    }
  }
}