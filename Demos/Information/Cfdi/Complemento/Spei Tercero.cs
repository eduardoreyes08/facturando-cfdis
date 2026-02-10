namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class SpeiTercero
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.SpeiTercero.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO SPEI TERCERO");
      Utils.ShowField("Versión    ", data.Version);

      Utils.ShowTitle("COMPLEMENTO SPEI TERCERO / TERCERO");
      Utils.ShowField("Fecha de operación   ", data.Tercero.FechaOperacion);
      Utils.ShowField("Hora                 ", data.Tercero.Hora);
      Utils.ShowField("Clave                ", data.Tercero.Clave);
      Utils.ShowField("Sello                ", data.Tercero.Sello);
      Utils.ShowField("Número de certificado", data.Tercero.NumeroCertificado);
      Utils.ShowField("Cadena CDA           ", data.Tercero.CadenaCda);

      Utils.ShowTitle("COMPLEMENTO SPEI TERCERO / ORDENANTE");
      Utils.ShowField("Banco emisor  ", data.Tercero.Ordenante.BancoEmisor);
      Utils.ShowField("Nombre        ", data.Tercero.Ordenante.Nombre);
      Utils.ShowField("Tipo de cuenta", data.Tercero.Ordenante.TipoCuenta);
      Utils.ShowField("Cuenta        ", data.Tercero.Ordenante.Cuenta);
      Utils.ShowField("RFC           ", data.Tercero.Ordenante.Rfc);

      Utils.ShowTitle("COMPLEMENTO SPEI TERCERO / BENEFICIARIO");
      Utils.ShowField("Banco receptor", data.Tercero.Beneficiario.BancoReceptor);
      Utils.ShowField("Nombre        ", data.Tercero.Beneficiario.Nombre);
      Utils.ShowField("Tipo de cuenta", data.Tercero.Beneficiario.TipoCuenta);
      Utils.ShowField("Concepto      ", data.Tercero.Beneficiario.Concepto);
      Utils.ShowField("RFC           ", data.Tercero.Beneficiario.Rfc);
      Utils.ShowField("Concepto      ", data.Tercero.Beneficiario.Concepto);
      Utils.ShowField("IVA           ", data.Tercero.Beneficiario.Iva);
      Utils.ShowField("Monto de pago ", data.Tercero.Beneficiario.MontoPago);

    }
  }
}