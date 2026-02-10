using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class SectorFinanciero
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.SectorFinanciero);
      ElectronicDocumentLibrary.ConstanciaRetenciones.SectorFinanciero.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.SectorFinanciero.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.IdFideicomiso.Value = "IdFideicomiso";
      data.NombreFideicomiso.Value = "NombreFideicomiso";
      data.DescripcionFideicomiso.Value = "DescripcionFideicomiso";

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Sector_Financiero.xml", out fileName);
    }
  }
}
