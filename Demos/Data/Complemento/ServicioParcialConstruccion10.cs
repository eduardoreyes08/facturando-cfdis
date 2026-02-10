using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ServicioParcialConstruccion10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ServicioParcialConstruccion);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ServicioParcialConstruccion.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ServicioParcialConstruccion.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroPermiso.Value = "NumeroPermiso";

      data.Inmueble.Calle.Value = "Calle";
      data.Inmueble.NumeroExterior.Value = "NumeroExterior";
      data.Inmueble.NumeroInterior.Value = "NumeroInterior";
      data.Inmueble.Colonia.Value = "Colonia";
      data.Inmueble.Localidad.Value = "Localidad";
      data.Inmueble.Referencia.Value = "Referencia";
      data.Inmueble.Municipio.Value = "Municipio";
      data.Inmueble.Estado.Value = "01";
      data.Inmueble.CodigoPostal.Value = 12345;

      return Base.Save(electronicDocument, "ServicioParcialConstruccion.xml", out fileName);
    }
  }
}