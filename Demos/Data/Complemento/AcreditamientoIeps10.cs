using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class AcreditamientoIeps10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Conceptos.Clear();
      Concepto concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.Cantidad.Value = 10;
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "DVD";
      concepto.ValorUnitario.Value = 120;
      concepto.Importe.Value = 1200;
      concepto.Descuento.Value = 360;
      concepto.ObjetoImpuesto.Value = "01";

      // Se agrega el complemento
      concepto.Complementos.Add(ComplementoConceptoType.AcreditamientoIeps);
      HyperSoft.ElectronicDocumentLibrary.Complemento.AcreditamientoIeps.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.AcreditamientoIeps.Data)concepto.Complementos.Last();

      data.Version.Value = "1.0";
      data.Tar.Value = "617";
      
      return Base.Save(electronicDocument, "AcreditamientoIeps.xml", out fileName);
    }
  }
}