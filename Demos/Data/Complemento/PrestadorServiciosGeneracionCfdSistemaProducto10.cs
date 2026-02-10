using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class PrestadorServiciosGeneracionCfdSistemaProducto10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.PrestadorServiciosGeneracionCfdSistemaProducto);
      HyperSoft.ElectronicDocumentLibrary.Complemento.PrestadorServiciosGeneracionCfdSistemaProducto.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.PrestadorServiciosGeneracionCfdSistemaProducto.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.Nombre.Value = "Nombre";
      data.Rfc.Value = "YYYY010101YY1";
      data.NumeroCertificado.Value = "01010101010101010101";
      data.FechaPublicacion.Value = DateTime.Now;
      data.NumeroAutorizacion.Value = "ZZZZ";
      data.Sello.Value = "ASASASAS";

      return Base.Save(electronicDocument, "PrestadorServiciosGeneracionCfdSistemaProducto.xml", out fileName);
    }
  }
}