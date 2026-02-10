using HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class HidrocarburosIngresos
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.Hidrocarburos.Ingresos.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO HIDROCARBUROS - INGRESOS");
      Utils.ShowField("Versión                       ", data.Version);
      Utils.ShowField("NumeroContrato                ", data.NumeroContrato);
      Utils.ShowField("ContraprestacionPagadaOperador", data.ContraprestacionPagadaOperador);
      Utils.ShowField("Porcentaje                    ", data.Porcentaje);

      for (int i = 0; i < data.DocumentosRelacionados.Count; i++)
      {
        string title = $"HIDROCARBUROS - INGRESOS / DOCUMENTO RELACIONADO - {i + 1}";
        Utils.ShowTitle(title);

        DocumentoRelacionado documentoRelacionado = data.DocumentosRelacionados[i];
        Utils.ShowField("FolioFiscalVinculado     ", documentoRelacionado.FolioFiscalVinculado);
        Utils.ShowField("FechaFolioFiscalVinculado", documentoRelacionado.FechaFolioFiscalVinculado);
        Utils.ShowField("Mes                      ", documentoRelacionado.Mes);
      }
    }
  }
}