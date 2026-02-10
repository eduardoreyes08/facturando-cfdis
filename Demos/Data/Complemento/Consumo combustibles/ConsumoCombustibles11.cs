using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ConsumoCombustibles11
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ConsumoCombustibles);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.1";
      data.TipoOperacion.Value = "monedero electrónico";
      data.NumeroCuenta.Value = "123456789";
      data.SubTotal.Value = 460.56;
      data.Total.Value = 723.96;

      ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Concepto concepto = data.Conceptos.Add();
      concepto.Identificador.Value = "123456789";
      concepto.Fecha.Value = DateTime.Now;
      concepto.Rfc.Value = "AAA010101AAA";
      concepto.ClaveEstacion.Value = "ES34567890";
      concepto.TipoCombustible.Value = 1;
      concepto.Cantidad.Decimals = 3;
      concepto.Cantidad.Value = 10.50;
      concepto.NombreCombustible.Value = "Gasolina MAGNA";
      concepto.FolioOperacion.Value = "123";
      concepto.ValorUnitario.Value = 12.50;
      concepto.Importe.Value = 131.25;

      ElectronicDocumentLibrary.Complemento.ConsumoCombustibles.Determinado determinado = concepto.Determinados.Add();
      determinado.Impuesto.Value = "IVA";
      determinado.Importe.Value = 52.68;
      determinado.TasaCuota.Value = 16;

      determinado = concepto.Determinados.Add();
      determinado.Impuesto.Value = "IEPS";
      determinado.Importe.Value = 52.68;
      determinado.TasaCuota.Value = 16;

      determinado = concepto.Determinados.Add();
      determinado.Impuesto.Value = "IVA";
      determinado.Importe.Value = 52.68;
      determinado.TasaCuota.Value = 16;

      concepto = data.Conceptos.Add();
      concepto.Identificador.Value = "987456321";
      concepto.Fecha.Value = DateTime.Now;
      concepto.Rfc.Value = "AAA010101AAA";
      concepto.ClaveEstacion.Value = "ES12345678";
      concepto.TipoCombustible.Value = 1;
      concepto.Cantidad.Decimals = 3;
      concepto.Cantidad.Value = 25.10;
      concepto.NombreCombustible.Value = "Gasolina PREMIUM";
      concepto.FolioOperacion.Value = "456";
      concepto.ValorUnitario.Value = 13.12;
      concepto.Importe.Value = 329.31;

      determinado = concepto.Determinados.Add();
      determinado.Impuesto.Value = "IEPS";
      determinado.Importe.Value = 52.68;
      determinado.TasaCuota.Value = 16;

      determinado = concepto.Determinados.Add();
      determinado.Impuesto.Value = "IVA";
      determinado.Importe.Value = 52.68;
      determinado.TasaCuota.Value = 16;


      return Base.Save(electronicDocument, "ConsumoCombustibles11.xml", out fileName);
    }
  }
}