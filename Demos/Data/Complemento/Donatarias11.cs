using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class Donatarias11
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.Donatarias);
      HyperSoft.ElectronicDocumentLibrary.Complemento.Donatarias.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.Donatarias.Data)electronicDocument.Data.Complementos.Last();

      data.NumeroAutorizacion.Value = "12434";
      data.FechaAutorizacion.Value = DateTime.Now;
      data.Version.Value = "1.1";
      data.Leyenda.Value = "Leyenda de prueba";

      return Base.Save(electronicDocument, "Donatarias11.xml", out fileName);
    }
  }
}