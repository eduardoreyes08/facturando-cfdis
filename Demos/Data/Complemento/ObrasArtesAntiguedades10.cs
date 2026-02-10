using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ObrasArtesAntiguedades10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ObrasArteAntiguedades);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ObrasArteAntiguedades.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ObrasArteAntiguedades.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TipoBien.Value = "01";
      data.OtrosTipoBien.Value = "a";
      data.TituloAdquirido.Value = "01";
      data.OtrosTituloAdquirido.Value = "a";
      data.Subtotal.Value = 1;
      data.Iva.Value = 1;
      data.FechaAdquisicion.Value = DateTime.Now.Date;
      data.CaracteristicasDeObraoPieza.Value = "01";

      return Base.Save(electronicDocument, "ObrasArteAntiguedades10.xml", out fileName);
    }

    public static bool Minimo(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ObrasArteAntiguedades);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ObrasArteAntiguedades.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ObrasArteAntiguedades.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TipoBien.Value = "01";
      data.TituloAdquirido.Value = "01";
      data.FechaAdquisicion.Value = DateTime.Now.Date;
      data.CaracteristicasDeObraoPieza.Value = "01";

      return Base.Save(electronicDocument, "ObrasArteAntiguedades10_Minimo.xml", out fileName);
    }
  }
}