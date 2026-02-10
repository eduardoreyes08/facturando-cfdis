using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.ConstanciaRetenciones;

namespace HyperSoft.Ejemplo.Data.Complemento.Constancias
{
  public static class PagosAExtranjeros
  {
    public static bool Create(ConstanciaRetenciones constanciaRetenciones, out string fileName)
    {
      //En este método se cargan los datos de la constancia.
      ConstanciaRetenciones20.CargarDatosTimbrado(constanciaRetenciones);

      constanciaRetenciones.Data.Complementos.Add(ComplementoConstanciaRetencionesType.PagosExtranjeros);
      ElectronicDocumentLibrary.ConstanciaRetenciones.PagosExtranjeros.Data data = (ElectronicDocumentLibrary.ConstanciaRetenciones.PagosExtranjeros.Data)constanciaRetenciones.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.EsBeneficiario.Value = "SI";

      data.NoBeneficiario.PaisResidencia.Value = "MX";
      data.NoBeneficiario.ConceptoPago.Value = 1;
      data.NoBeneficiario.DescripcionConcepto.Value = "DescripcionConcepto";

      data.Beneficiario.Rfc.Value = "AAAA010101AAA";
      data.Beneficiario.Curp.Value = "AAAA010101HCMLNS09";
      data.Beneficiario.RazonSocial.Value = "RazonSocial";
      data.Beneficiario.ConceptoPago.Value = 1;
      data.Beneficiario.DescripcionConcepto.Value = "DescripcionConcepto";

      return Base.Save(constanciaRetenciones, "Constancia_Retenciones_Pagos_A_Extranjeros.xml", out fileName);
    }
  }
}