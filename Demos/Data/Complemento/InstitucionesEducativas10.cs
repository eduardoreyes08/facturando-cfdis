using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class InstitucionesEducativas10
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

      concepto.Complementos.Add(ComplementoConceptoType.InstitucionesEducativas);
      ElectronicDocumentLibrary.Complemento.InstitucionesEducativas.Data data = (ElectronicDocumentLibrary.Complemento.InstitucionesEducativas.Data)concepto.Complementos.Last();

      data.Version.Value = "1.0";
      data.NombreAlumno.Value = "A";
      data.Curp.Value = "UXBA000419HYNVRDA3";
      data.NivelEducativo.Value = "Profesional técnico";
      data.AutorizacionRvoe.Value = "B";
      data.RfcPago.Value = "XXXX010101XX1";

      return Base.Save(electronicDocument, "InstitucionesEducativas10.xml", out fileName);
    }

    public static void CargarDatosTimbrado(ElectronicDocument electronicDocument)
    {
      Base.Comprobante(electronicDocument.Data);
      Base.Emisor(electronicDocument.Data.Emisor);
      Base.Receptor(electronicDocument.Data.Receptor);

      // Concepto ****************************************************************************
      Concepto concepto = electronicDocument.Data.Conceptos.Add();
      concepto.ClaveProductoServicio.Value = "01010101";
      concepto.Cantidad.Value = 1;
      concepto.ClaveUnidad.Value = "E48";
      concepto.Descripcion.Value = "Colegiatura";
      concepto.ValorUnitario.Value = 1000;
      concepto.Importe.Value = 1000;
      concepto.ObjetoImpuesto.Value = "01";
      // *************************************************************************************

      // Complemento IEDU ********************************************************************
      concepto.Complementos.Add(ComplementoConceptoType.InstitucionesEducativas);
      ElectronicDocumentLibrary.Complemento.InstitucionesEducativas.Data data = (ElectronicDocumentLibrary.Complemento.InstitucionesEducativas.Data)concepto.Complementos.Last();

      data.Version.Value = "1.0";
      data.NombreAlumno.Value = "A";
      data.Curp.Value = "UXBA000419HYNVRDA3";
      data.NivelEducativo.Value = "Profesional técnico";
      data.AutorizacionRvoe.Value = "B";
      data.RfcPago.Value = "XXXX010101XX1";
      // *************************************************************************************
    }
  }
}