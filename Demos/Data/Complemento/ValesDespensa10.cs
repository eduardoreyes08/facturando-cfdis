using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ValesDespensa10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ValesDespensa);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ValesDespensa.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ValesDespensa.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TipoOperacion.Value = "monedero electrónico";
      data.RegistroPatronal.Value = "Y6813217103";
      data.NumeroCuenta.Value = "1234567890";
      data.Total.Value = 12345.36;

      ElectronicDocumentLibrary.Complemento.ValesDespensa.Concepto concepto = data.Conceptos.Add();
      concepto.Identificador.Value = "9876543210";
      concepto.Fecha.Value = DateTime.Now;
      concepto.Rfc.Value = "AAA010101AAA";
      concepto.Curp.Value = "UXBA000419HYNVRDA3";
      concepto.Nombre.Value = "ABCD";
      concepto.NumeroSeguridadSocial.Value = "1234567890";
      concepto.Importe.Value = 100.23;

      concepto = data.Conceptos.Add();
      concepto.Identificador.Value = "12345";
      concepto.Fecha.Value = DateTime.Now;
      concepto.Rfc.Value = "AAA010101AAA";
      concepto.Curp.Value = "UXBA000419HYNVRDA3";
      concepto.Nombre.Value = "POIUYTR";
      concepto.NumeroSeguridadSocial.Value = "65412369";
      concepto.Importe.Value = 200;

      return Base.Save(electronicDocument, "ValesDespensa.xml", out fileName);
    }
  }
}