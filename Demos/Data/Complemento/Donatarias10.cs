using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  internal static class Donatarias10
  {
    internal static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.Donatarias);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Donatarias.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Donatarias.Data)electronicDocument.Data.Complementos.Last();

      data.NumeroAutorizacion.Value = "12434";
      data.FechaAutorizacion.Value = DateTime.Now;
      data.Version.Value = "1.0";
      data.Leyenda.Value = "Este comprobante ampara un donativo, el cual será destinado por la " +
                                                "donataria a los fines propios de su objeto social. En el caso de que " +
                                                "los bienes donados hayan sido deducidos previamente para los efectos " +
                                                "del impuesto sobre la renta, este donativo no es deducible. La reproducción " +
                                                "no autorizada de este comprobante constituye un delito en los " +
                                                "términos de las disposiciones fiscales.";

      return Base.Save(electronicDocument, "Donatarias10.xml", out fileName);
    }
  }
}