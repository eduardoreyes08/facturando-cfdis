using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class Ine11
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.Ine);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Ine.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Ine.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.1";
      data.TipoProceso.Value = "Precampaña";
      data.TipoComite.Value = "Directivo Estatal";
      //data.IdContabilidad.Value = 1;

      HyperSoft.ElectronicDocumentLibrary.Complemento.Ine.Entidad entidad = data.Entidad.Add();
      entidad.ClaveEntidad.Value = "ZAC";
      entidad.Ambito.Value = "Local";

      HyperSoft.ElectronicDocumentLibrary.Complemento.Ine.Contabilidad contabilidad = entidad.Contabilidad.Add();
      contabilidad.IdContabilidad.Value = 2;

      contabilidad = entidad.Contabilidad.Add();
      contabilidad.IdContabilidad.Value = 3;

      entidad = data.Entidad.Add();
      entidad.ClaveEntidad.Value = "DIF";
      entidad.Ambito.Value = "Federal";

      contabilidad = entidad.Contabilidad.Add();
      contabilidad.IdContabilidad.Value = 4;

      return Base.Save(electronicDocument, "Ine11.xml", out fileName);
    }
  }
}