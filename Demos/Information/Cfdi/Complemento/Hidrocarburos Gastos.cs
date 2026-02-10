using HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class HidrocarburosGastos
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO HIDROCARBUROS - GASTOS");
      Utils.ShowField("Versión        ", data.Version);
      Utils.ShowField("NumeroContrato ", data.NumeroContrato);
      Utils.ShowField("AreaContractual", data.AreaContractual);
      
      for (int i = 0; i < data.Erogaciones.Count; i++)
      {
        string title = $"HIDROCARBUROS - GASTOS / EROGACION - {i + 1}";
        Utils.ShowTitle(title);

        Erogacion erogacion = data.Erogaciones[i];
        Utils.ShowField("Tipo      ", erogacion.Tipo);
        Utils.ShowField("Porcentaje", erogacion.Porcentaje);
        Utils.ShowField("Montocu   ", erogacion.Montocu);

        ShowDocumentosRelacionados(erogacion.DocumentosRelacionados, title);

        ShowActividades(erogacion.Actividades, title);

        ShowCentrosCostos(erogacion.CentrosCostos, title);
      }
    }

    private static void ShowDocumentosRelacionados(DocumentosRelacionados data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        Utils.ShowTitle($"{baseTitle} / DOCUMENTO RELACIONADO - {i+1}");

        DocumentoRelacionado documentoRelacionado = data[i];
        Utils.ShowField("OrigenErogacion               ", documentoRelacionado.OrigenErogacion);
        Utils.ShowField("FolioFiscalVinculado          ", documentoRelacionado.FolioFiscalVinculado);
        Utils.ShowField("RfcProveedor                  ", documentoRelacionado.RfcProveedor);
        Utils.ShowField("MontoTotalIva                 ", documentoRelacionado.MontoTotalIva);
        Utils.ShowField("MontoRetencionIsr             ", documentoRelacionado.MontoRetencionIsr);
        Utils.ShowField("MontoRetencionIva             ", documentoRelacionado.MontoRetencionIva);
        Utils.ShowField("MontoRetencionOtrosImpuestos  ", documentoRelacionado.MontoRetencionOtrosImpuestos);
        Utils.ShowField("NumeroPedimentoVinculado      ", documentoRelacionado.NumeroPedimentoVinculado);
        Utils.ShowField("ClavePedimentoVinculado       ", documentoRelacionado.ClavePedimentoVinculado);
        Utils.ShowField("ClavePagoPedimentoVinculado   ", documentoRelacionado.ClavePagoPedimentoVinculado);
        Utils.ShowField("MontoIvaPedimento             ", documentoRelacionado.MontoIvaPedimento);
        Utils.ShowField("OtrosImpuestosPagadosPedimento", documentoRelacionado.OtrosImpuestosPagadosPedimento);
        Utils.ShowField("FechaFolioFiscalVinculado     ", documentoRelacionado.FechaFolioFiscalVinculado);
        Utils.ShowField("Mes                           ", documentoRelacionado.Mes);
        Utils.ShowField("MontoTotalErogaciones         ", documentoRelacionado.MontoTotalErogaciones);
      }
    }

    private static void ShowActividades(Actividades data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"{baseTitle} / ACTIVIDAD - {i + 1}";
        Utils.ShowTitle(title);

        Actividad actividad = data[i];
        Utils.ShowField("Relacionada", actividad.Relacionada);

        ShowSubActividades(actividad.SubActividades, title);
      }
    }

    private static void ShowSubActividades(SubActividades data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"{baseTitle} / SUBACTIVIDAD - {i + 1}";
        Utils.ShowTitle(title);

        SubActividad subActividad = data[i];
        Utils.ShowField("Relacionada", subActividad.Relacionada);

        ShowTareas(subActividad.Tareas, title);
      }
    }

    private static void ShowTareas(Tareas data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"{baseTitle} / TAREAS - {i + 1}";
        Utils.ShowTitle(title);

        Utils.ShowField("Relacionada", data[i].Relacionada);        
      }
    }

    private static void ShowCentrosCostos(CentrosCostos data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"{baseTitle} / CENTRO COSTO - {i + 1}";
        Utils.ShowTitle(title);

        CentroCosto centroCosto = data[i];
        Utils.ShowField("Campo", centroCosto.Campo);

        ShowYacimientos(centroCosto.Yacimientos, title);
      }
    }

    private static void ShowYacimientos(Yacimientos data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"{baseTitle} / YACIMIENTO - {i + 1}";
        Utils.ShowTitle(title);

        Yacimiento yacimiento = data[i];
        Utils.ShowField("CentroCostos", yacimiento.CentroCostos);

        ShowPozos(yacimiento.Pozos, title);
      }
    }

    private static void ShowPozos(Pozos data, string baseTitle)
    {
      for (int i = 0; i < data.Count; i++)
      {
        string title = $"{baseTitle} / POZO - {i + 1}";
        Utils.ShowTitle(title);

        Utils.ShowField("CentroCostos", data[i].CentroCostos);
      }
    }
  }
}