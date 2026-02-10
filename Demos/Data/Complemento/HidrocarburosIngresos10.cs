using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class HidrocarburosIngresos10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.HidrocarburosIngresos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroContrato.Value = "a";
      data.ContraprestacionPagadaOperador.Value = 0;
      data.Porcentaje.Value = 1;

      DocumentoRelacionado documentoRelacionado = data.DocumentosRelacionados.Add();
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "01";

      return Base.Save(electronicDocument, "HidrocarburosIngresos10.xml", out fileName);
    }

    public static bool Listas(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.HidrocarburosIngresos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroContrato.Value = "a";
      data.ContraprestacionPagadaOperador.Value = 0;
      data.Porcentaje.Value = 1;

      DocumentoRelacionado documentoRelacionado = data.DocumentosRelacionados.Add();
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "01";

      documentoRelacionado = data.DocumentosRelacionados.Add();
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "02";

      return Base.Save(electronicDocument, "HidrocarburosIngresos10_Listas.xml", out fileName);
    }

    public static bool Minimo(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.HidrocarburosIngresos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroContrato.Value = "a";
      data.ContraprestacionPagadaOperador.Value = 0;
      data.Porcentaje.Value = 1;

      DocumentoRelacionado documentoRelacionado = data.DocumentosRelacionados.Add();
      documentoRelacionado.FolioFiscalVinculado.Value = "00000000-0000-0000-0000-000000000000";
      documentoRelacionado.FechaFolioFiscalVinculado.Value = DateTime.Now.Date;
      documentoRelacionado.Mes.Value = "01";

      return Base.Save(electronicDocument, "HidrocarburosIngresos10_Minimo.xml", out fileName);
    }
  }
}