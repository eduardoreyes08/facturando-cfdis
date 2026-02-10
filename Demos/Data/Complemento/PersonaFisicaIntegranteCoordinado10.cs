using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class PersonaFisicaIntegranteCoordinado10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.PersonaFisicaIntegranteCoordinado);
      HyperSoft.ElectronicDocumentLibrary.Complemento.PersonaFisicaIntegranteCoordinado.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.PersonaFisicaIntegranteCoordinado.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.ClaveVehicular.Value = "A";
      data.Placa.Value = "B";
      data.Rfc.Value = "XXXX010101XX1";

      return Base.Save(electronicDocument, "PersonaFisicaIntegranteCoordinado.xml", out fileName);
    }
  }
}