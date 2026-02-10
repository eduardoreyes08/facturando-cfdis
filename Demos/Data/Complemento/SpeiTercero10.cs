using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class SpeiTercero10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.SpeiTercero);
      HyperSoft.ElectronicDocumentLibrary.Complemento.SpeiTercero.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.SpeiTercero.Data)electronicDocument.Data.Complementos.Last();

      //data.Version.Value = "1.0";

      data.Tercero.FechaOperacion.Value = DateTime.Now;
      data.Tercero.Hora.Value = DateTime.Now;
      data.Tercero.Clave.Value = 12345;
      data.Tercero.Sello.Value = "ZXCVBNMM";
      data.Tercero.NumeroCertificado.Value = "1234567890";
      data.Tercero.CadenaCda.Value = "123abc";

      data.Tercero.Ordenante.BancoEmisor.Value = "ABC";
      data.Tercero.Ordenante.Nombre.Value = "DEF";
      data.Tercero.Ordenante.TipoCuenta.Value = 12;
      data.Tercero.Ordenante.Cuenta.Value = "1234567890";
      data.Tercero.Ordenante.Rfc.Value = "AAA010101AAA";

      data.Tercero.Beneficiario.BancoReceptor.Value = "ZAW";
      data.Tercero.Beneficiario.Nombre.Value = "PLK";
      data.Tercero.Beneficiario.TipoCuenta.Value = 12;
      data.Tercero.Beneficiario.Cuenta.Value = "1234567890";
      data.Tercero.Beneficiario.Rfc.Value = "BBB010101BBB";
      data.Tercero.Beneficiario.Concepto.Value = "Concepto";
      data.Tercero.Beneficiario.Iva.Value = 12.3;
      data.Tercero.Beneficiario.MontoPago.Value = 321.36;

      return Base.Save(electronicDocument, "SpeiTercero.xml", out fileName);
    }
  }
}