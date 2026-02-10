using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class HidrocarburosGastos10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.HidrocarburosGastos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroContrato.Value = "a";
      data.AreaContractual.Value = "a";

      Erogacion erogacion = data.Erogaciones.Add();
      erogacion.Tipo.Value = "Costo";
      erogacion.Porcentaje.Value = 1;
      erogacion.Montocu.Value = 0;

      #region Documentos relacionados

      DocumentoRelacionado documentoRelacionado = erogacion.DocumentosRelacionados.Add();
      documentoRelacionado.OrigenErogacion.Value = "Nacional";
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.RfcProveedor.Value = "AAA010101AAA";
      documentoRelacionado.MontoTotalIva.Value = 1;
      documentoRelacionado.MontoRetencionIsr.Value = 1;
      documentoRelacionado.MontoRetencionIva.Value = 1;
      documentoRelacionado.MontoRetencionOtrosImpuestos.Value = 1;
      documentoRelacionado.NumeroPedimentoVinculado.Value = "00  00  0000  0000000";
      documentoRelacionado.ClavePedimentoVinculado.Value = "A1";
      documentoRelacionado.ClavePagoPedimentoVinculado.Value = "00";
      documentoRelacionado.MontoIvaPedimento.Value = 1;
      documentoRelacionado.OtrosImpuestosPagadosPedimento.Value = 1;
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "01";
      documentoRelacionado.MontoTotalErogaciones.Value = 1;

      #endregion

      #region Actividades

      Actividad actividad = erogacion.Actividades.Add();
      actividad.Relacionada.Value = "01";

      SubActividad subActividad = actividad.SubActividades.Add();
      subActividad.Relacionada.Value = "001";

      subActividad.Tareas.Add().Relacionada.Value = "0001";
      subActividad.Tareas.Add().Relacionada.Value = "0001";

      #endregion

      #region Centros de costos

      CentroCosto centroCosto = erogacion.CentrosCostos.Add();
      centroCosto.Campo.Value = "a";

      Yacimiento yacimiento = centroCosto.Yacimientos.Add();
      yacimiento.CentroCostos.Value = "a";

      yacimiento.Pozos.Add().CentroCostos.Value = "a";
      yacimiento.Pozos.Add().CentroCostos.Value = "b";

      #endregion

      return Base.Save(electronicDocument, "HidrocarburosGastos10.xml", out fileName);
    }

    public static bool Listas(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.HidrocarburosGastos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroContrato.Value = "a";
      data.AreaContractual.Value = "a";

      Erogacion erogacion = data.Erogaciones.Add();
      erogacion.Tipo.Value = "Costo";
      erogacion.Porcentaje.Value = 1;
      erogacion.Montocu.Value = 0;

      #region Documentos relacionados1

      DocumentoRelacionado documentoRelacionado = erogacion.DocumentosRelacionados.Add();
      documentoRelacionado.OrigenErogacion.Value = "Nacional";
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.RfcProveedor.Value = "AAA010101AAA";
      documentoRelacionado.MontoTotalIva.Value = 1;
      documentoRelacionado.MontoRetencionIsr.Value = 1;
      documentoRelacionado.MontoRetencionIva.Value = 1;
      documentoRelacionado.MontoRetencionOtrosImpuestos.Value = 1;
      documentoRelacionado.NumeroPedimentoVinculado.Value = "00  00  0000  0000000";
      documentoRelacionado.ClavePedimentoVinculado.Value = "A1";
      documentoRelacionado.ClavePagoPedimentoVinculado.Value = "00";
      documentoRelacionado.MontoIvaPedimento.Value = 1;
      documentoRelacionado.OtrosImpuestosPagadosPedimento.Value = 1;
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "01";
      documentoRelacionado.MontoTotalErogaciones.Value = 1;

      #endregion

      #region Actividades1

      Actividad actividad = erogacion.Actividades.Add();
      actividad.Relacionada.Value = "01";

      SubActividad subActividad = actividad.SubActividades.Add();
      subActividad.Relacionada.Value = "001";

      subActividad.Tareas.Add().Relacionada.Value = "0001";
      subActividad.Tareas.Add().Relacionada.Value = "0001";

      #endregion

      #region Centros de costos1

      CentroCosto centroCosto = erogacion.CentrosCostos.Add();
      centroCosto.Campo.Value = "Centro de costos A";

      Yacimiento yacimiento = centroCosto.Yacimientos.Add();
      yacimiento.CentroCostos.Value = "Yacimiento A";

      yacimiento.Pozos.Add().CentroCostos.Value = "Pozo A1";
      yacimiento.Pozos.Add().CentroCostos.Value = "Pozo A2";

            #endregion

      erogacion = data.Erogaciones.Add();
      erogacion.Tipo.Value = "Costo";
      erogacion.Porcentaje.Value = 2;
      erogacion.Montocu.Value = 0;

      #region Documentos relacionados2

      documentoRelacionado = erogacion.DocumentosRelacionados.Add();
      documentoRelacionado.OrigenErogacion.Value = "Nacional";
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.RfcProveedor.Value = "AAA010101AAA";
      documentoRelacionado.MontoTotalIva.Value = 1;
      documentoRelacionado.MontoRetencionIsr.Value = 1;
      documentoRelacionado.MontoRetencionIva.Value = 1;
      documentoRelacionado.MontoRetencionOtrosImpuestos.Value = 1;
      documentoRelacionado.NumeroPedimentoVinculado.Value = "00  00  0000  0000000";
      documentoRelacionado.ClavePedimentoVinculado.Value = "A1";
      documentoRelacionado.ClavePagoPedimentoVinculado.Value = "00";
      documentoRelacionado.MontoIvaPedimento.Value = 1;
      documentoRelacionado.OtrosImpuestosPagadosPedimento.Value = 1;
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "01";
      documentoRelacionado.MontoTotalErogaciones.Value = 1;

      documentoRelacionado = erogacion.DocumentosRelacionados.Add();
      documentoRelacionado.OrigenErogacion.Value = "Extranjero";
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.RfcProveedor.Value = "AAA010101AAA";
      documentoRelacionado.MontoTotalIva.Value = 2;
      documentoRelacionado.MontoRetencionIsr.Value = 2;
      documentoRelacionado.MontoRetencionIva.Value = 2;
      documentoRelacionado.MontoRetencionOtrosImpuestos.Value = 2;
      documentoRelacionado.NumeroPedimentoVinculado.Value = "00  00  0000  0000000";
      documentoRelacionado.ClavePedimentoVinculado.Value = "A1";
      documentoRelacionado.ClavePagoPedimentoVinculado.Value = "00";
      documentoRelacionado.MontoIvaPedimento.Value = 2;
      documentoRelacionado.OtrosImpuestosPagadosPedimento.Value = 2;
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "02";
      documentoRelacionado.MontoTotalErogaciones.Value = 2;

      #endregion

      #region Actividades2

      actividad = erogacion.Actividades.Add();
      actividad.Relacionada.Value = "01";

      subActividad = actividad.SubActividades.Add();
      subActividad.Relacionada.Value = "001";

      subActividad.Tareas.Add().Relacionada.Value = "0001";
      subActividad.Tareas.Add().Relacionada.Value = "0001";

      actividad = erogacion.Actividades.Add();
      actividad.Relacionada.Value = "02";

      subActividad = actividad.SubActividades.Add();
      subActividad.Relacionada.Value = "002";

      subActividad.Tareas.Add().Relacionada.Value = "0002";
      subActividad.Tareas.Add().Relacionada.Value = "0002";

      #endregion

      #region Centros de costos2

      centroCosto = erogacion.CentrosCostos.Add();
      centroCosto.Campo.Value = "Centro de costos A";

      yacimiento = centroCosto.Yacimientos.Add();
      yacimiento.CentroCostos.Value = "Yacimiento A";

      yacimiento.Pozos.Add().CentroCostos.Value = "Pozo A1";
      yacimiento.Pozos.Add().CentroCostos.Value = "Pozo A2";

      centroCosto = erogacion.CentrosCostos.Add();
      centroCosto.Campo.Value = "Centro de costos B";

      yacimiento = centroCosto.Yacimientos.Add();
      yacimiento.CentroCostos.Value = "Yacimiento B";

      yacimiento.Pozos.Add().CentroCostos.Value = "Pozo B1";
      yacimiento.Pozos.Add().CentroCostos.Value = "Pozo B2";

      #endregion

      return Base.Save(electronicDocument, "HidrocarburosGastos10_Listas.xml", out fileName);
    }

    public static bool Minimo(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.HidrocarburosGastos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Gastos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroContrato.Value = "a";

      Erogacion erogacion = data.Erogaciones.Add();
      erogacion.Tipo.Value = "Costo";
      erogacion.Porcentaje.Value = 1;
      erogacion.Montocu.Value = 0;

      #region Documentos relacionados

      DocumentoRelacionado documentoRelacionado = erogacion.DocumentosRelacionados.Add();
      documentoRelacionado.OrigenErogacion.Value = "Nacional";
      documentoRelacionado.Mes.Value = "01";
      documentoRelacionado.MontoTotalErogaciones.Value = 1;

      #endregion

      return Base.Save(electronicDocument, "HidrocarburosGastos10_Minimo.xml", out fileName);
    }
  }
}