using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class TuristaPasajeroExtranjero10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.TuristaPasajeroExtranjero);
      HyperSoft.ElectronicDocumentLibrary.Complemento.TuristaPasajeroExtranjero.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.TuristaPasajeroExtranjero.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.FechaTransito.Value = DateTime.Now;
      data.TipoTransito.Value = "Arribo";

      data.DatosTransito.Via.Value = "Aérea";
      data.DatosTransito.TipoId.Value = "A";
      data.DatosTransito.NumeroId.Value = "B";
      data.DatosTransito.Nacionalidad.Value = "C";
      data.DatosTransito.EmpresaTransporte.Value = "D";
      data.DatosTransito.IdTransporte.Value = "E";

      return Base.Save(electronicDocument, "TuristaPasajeroExtranjero.xml", out fileName);
    }
  }
}