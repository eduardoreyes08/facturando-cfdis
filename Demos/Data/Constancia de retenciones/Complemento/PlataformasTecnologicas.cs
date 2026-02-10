using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones.PlataformasTecnologicas;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class PlataformasTecnologicas
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.PlataformasTecnologicas);
      ElectronicDocumentLibrary.ConstanciaRetenciones.PlataformasTecnologicas.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.PlataformasTecnologicas.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.Periodicidad.Value = "01";
      data.NumeroServicio.Value = "1";
      data.MontoTotalServicioSinIva.Value = 0;
      data.TotalIvaTrasladado.Value = 0;
      data.TotalIvaRetenido.Value = 0;
      data.TotalIsrRetenido.Value = 0;
      data.DiferenciaIvaEntregadoPrestadorServicio.Value = 0;
      data.MontoTotalPorUsoPlataforma.Value = 0;
      data.MontoTotalContribucionGubernamental.Value = 0;

      DetalleServicio detalle = data.DetallesServicio.Add();
      detalle.FormaPagoServicio.Value = "01";
      detalle.TipoServicio.Value = "01";
      detalle.SubTipoServicio.Value = "01";
      detalle.RfcTerceroAutorizado.Value = "XAXX010101000";
      detalle.FechaServicio.Value = DateTime.Now;
      detalle.PrecioServicioSinIva.Value = 0;

      detalle.ImpuestosTrasladadosServicio.Base.Value = new decimal(0.000001);
      detalle.ImpuestosTrasladadosServicio.Base.Decimals= 6;
      detalle.ImpuestosTrasladadosServicio.Impuesto.Value = "01";
      detalle.ImpuestosTrasladadosServicio.TipoFactor.Value = "Tasa";
      detalle.ImpuestosTrasladadosServicio.TasaCuota.Value = new decimal(0.160000);
      detalle.ImpuestosTrasladadosServicio.Importe.Value = 0;

      detalle.ContribucionGubernamental.EntidadDondePagaContribucion.Value = "01";
      detalle.ContribucionGubernamental.ImporteContribucion.Value = 0;

      detalle.ComisionServicio.Base.Value = new decimal(0.000001);
      detalle.ComisionServicio.Base.Decimals = 6;
      detalle.ComisionServicio.Porcentaje.Value = new decimal(0.001);
      detalle.ComisionServicio.Porcentaje.Decimals = 3;
      detalle.ComisionServicio.Importe.Value = 0;

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Plataformas_Tecnologicas.xml", out fileName);
    }
  }
}
