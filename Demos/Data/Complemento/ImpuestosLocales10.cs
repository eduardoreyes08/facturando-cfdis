using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales;
using HyperSoft.ElectronicDocumentLibrary.Document;
using Traslado = HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Traslado;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ImpuestosLocales10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ImpuestosLocales);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TotalRetenciones.Value = 256.75;
      data.TotalTraslados.Value = 256.75;

      // Se agregan los Movimientos o Conceptos de los impuestos locales retenidos
      //Concepto 1
      Retencion retencion1 = data.Retenciones.Add();
      retencion1.Impuesto.Value = "ISR";
      retencion1.Tasa.Value = 10.88;
      retencion1.Importe.Value = 247.23;

      //Concepto 2
      Retencion retencion2 = data.Retenciones.Add();
      retencion2.Impuesto.Value = "ISR";
      retencion2.Tasa.Value = 6.40;
      retencion2.Importe.Value = 9.52;

      // Se agregan los Movimientos o Conceptos de los impuestos locales de traslado
      //Concepto 1
      Traslado traslado1 = data.Traslados.Add();
      traslado1.Impuesto.Value = "IVA";
      traslado1.Tasa.Value = 16;
      traslado1.Importe.Value = 102;

      //Concepto 2
      Traslado traslado2 = data.Traslados.Add();
      traslado2.Impuesto.Value = "IVA";
      traslado2.Tasa.Value = 16;
      traslado2.Importe.Value = 154.75;


      return Base.Save(electronicDocument, "ImpuestosLocales10.xml", out fileName);
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
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "Concepto";
      concepto.ValorUnitario.Value = 1000;
      concepto.Importe.Value = 1000;
      concepto.ObjetoImpuesto.Value = "02";

      // Impuestos trasladados del concepto
      TrasladoConcepto trasladoConcepto = concepto.Impuestos.Traslados.Add();
      trasladoConcepto.Base.Value = 1000;
      trasladoConcepto.Impuesto.Value = "002";
      trasladoConcepto.TipoFactor.Value = "Tasa";
      trasladoConcepto.TasaCuota.Value = 0.160000;
      trasladoConcepto.Importe.Value = 160.00;

      // Impuestos retenidos del concepto
      RetencionConcepto retencionConcepto = concepto.Impuestos.Retenciones.Add();
      retencionConcepto.Base.Value = 1000;
      retencionConcepto.Impuesto.Value = "001";
      retencionConcepto.TipoFactor.Value = "Tasa";
      retencionConcepto.TasaCuota.Value = 0.160000;
      retencionConcepto.Importe.Value = 160;
      // *************************************************************************************

      // Impuestos trasladados ***************************************************************
      ElectronicDocumentLibrary.Document.Traslado traslado = electronicDocument.Data.Impuestos.Traslados.Add();
      traslado.Base.Value = 1000;
      traslado.Tipo.Value = "002";
      traslado.TipoFactor.Value = "Tasa";
      traslado.TasaCuota.Value = 0.160000;
      traslado.Importe.Value = 160.00;

      electronicDocument.Data.Impuestos.TotalTraslados.Value = 160.00;
      // *************************************************************************************

      // Impuestos retenidos *****************************************************************
      HyperSoft.ElectronicDocumentLibrary.Document.Impuesto retencion = electronicDocument.Data.Impuestos.Retenciones.Add();
      retencion.Tipo.Value = "001";
      retencion.Importe.Value = 160;

      electronicDocument.Data.Impuestos.TotalRetenciones.Value = 160;
      // *************************************************************************************

      // Complemento Impuesto Locales ********************************************************
      electronicDocument.Data.Complementos.Add(ComplementoType.ImpuestosLocales);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TotalRetenciones.Value = 256.75;
      data.TotalTraslados.Value = 256.75;

      // Se agregan los Movimientos o Conceptos de los impuestos locales retenidos
      HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Retencion retencionLocal = data.Retenciones.Add();
      retencionLocal.Impuesto.Value = "ISR";
      retencionLocal.Tasa.Value = 10.88;
      retencionLocal.Importe.Value = 247.23;

      retencionLocal = data.Retenciones.Add();
      retencionLocal.Impuesto.Value = "ISR";
      retencionLocal.Tasa.Value = 6.40;
      retencionLocal.Importe.Value = 9.52;

      // Se agregan los Movimientos o Conceptos de los impuestos locales de traslado      
      HyperSoft.ElectronicDocumentLibrary.Complemento.ImpuestosLocales.Traslado trasladoLocal = data.Traslados.Add();
      trasladoLocal.Impuesto.Value = "IVA";
      trasladoLocal.Tasa.Value = 16;
      trasladoLocal.Importe.Value = 102;

      trasladoLocal = data.Traslados.Add();
      trasladoLocal.Impuesto.Value = "IVA";
      trasladoLocal.Tasa.Value = 16;
      trasladoLocal.Importe.Value = 154.75;
      // *************************************************************************************
    }
  }
}