namespace HyperSoft.Ejemplo.Information.Complemento.Retenciones
{
  internal static class PagosExtranjeros
  {
    internal static void Show(ElectronicDocumentLibrary.ConstanciaRetenciones.PagosExtranjeros.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO PAGOS A EXTRANJEROS");
      Utils.ShowField("Version       ", data.Version);
      Utils.ShowField("EsBeneficiario", data.EsBeneficiario);

      Utils.ShowTitle("COMPLEMENTO PAGOS A EXTRANJEROS - NO BENEFICIARIO");
      Utils.ShowField("PaisResidencia     ", data.NoBeneficiario.PaisResidencia);
      Utils.ShowField("ConceptoPago       ", data.NoBeneficiario.ConceptoPago);
      Utils.ShowField("DescripcionConcepto", data.NoBeneficiario.DescripcionConcepto);


      Utils.ShowTitle("COMPLEMENTO PAGOS A EXTRANJEROS - BENEFICIARIO");
      Utils.ShowField("Rfc                ", data.Beneficiario.Rfc);
      Utils.ShowField("Curp               ", data.Beneficiario.Curp);
      Utils.ShowField("RazonSocial        ", data.Beneficiario.RazonSocial);
      Utils.ShowField("ConceptoPago       ", data.Beneficiario.ConceptoPago);
      Utils.ShowField("DescripcionConcepto", data.Beneficiario.DescripcionConcepto);      
    }
  }
}