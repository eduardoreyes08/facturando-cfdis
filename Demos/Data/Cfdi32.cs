using System;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data
{
  public static class Cfdi32
  {
    public static void CargarDatos(ElectronicDocument electronicDocument)
    {
      electronicDocument.Data.Clear();

      // Datos del comprobante ****************************************************************
      electronicDocument.Data.Version.Value = "3.2";
      electronicDocument.Data.Serie.Value = "C";
      electronicDocument.Data.Folio.Value = "2000";
      electronicDocument.Data.Fecha.Value = DateTime.Now;
      electronicDocument.Data.FormaPago.Value = "Pago en una sola exhibicion";
      electronicDocument.Data.CondicionesPago.Value = "Parcialidades";
      electronicDocument.Data.SubTotal.Value = 7200;
      electronicDocument.Data.Descuento.Value = 360;
      electronicDocument.Data.MotivoDescuento.Value = "5% de descuento por pago en efectivo";
      electronicDocument.Data.Total.Value = 7934.4;
      electronicDocument.Data.MetodoPago.Value = "01";
      electronicDocument.Data.TipoComprobante.Value = "ingreso";

      electronicDocument.Data.Moneda.Value = "Dolares";
      electronicDocument.Data.TipoCambio.Value = "13.5";
      electronicDocument.Data.LugarExpedicion.Value = "Mexico, Distrito Federal";
      electronicDocument.Data.NumeroCuentaPago.Value = "1234";
      electronicDocument.Data.FolioFiscalOriginal.Value = "12";
      electronicDocument.Data.SerieFolioFiscalOriginal.Value = "A";
      electronicDocument.Data.FechaFolioFiscalOriginal.Value = new DateTime(2011, 11, 10);
      electronicDocument.Data.MontoFolioFiscalOriginal.Value = 1000;
      // ***************************************************************************************


      // Datos del emisor ********************************************************************
      electronicDocument.Data.Emisor.Rfc.Value = "EKU9003173C9";
      electronicDocument.Data.Emisor.Nombre.Value = "ESCUELA KEMPER URGATE SA DE CV";

      //// Domicilio fiscal del emisor
      electronicDocument.Data.Emisor.Domicilio.Calle.Value = "Tamaulipas";
      electronicDocument.Data.Emisor.Domicilio.NumeroExterior.Value = "125";
      electronicDocument.Data.Emisor.Domicilio.NumeroInterior.Value = "1";
      electronicDocument.Data.Emisor.Domicilio.Colonia.Value = "Roma";
      electronicDocument.Data.Emisor.Domicilio.Localidad.Value = "México";
      electronicDocument.Data.Emisor.Domicilio.Referencia.Value = "Entre León y Manzanillo";

      electronicDocument.Data.Emisor.Domicilio.Municipio.Value = "Cuauhtémoc";
      electronicDocument.Data.Emisor.Domicilio.Estado.Value = "Distrito Federal";
      electronicDocument.Data.Emisor.Domicilio.Pais.Value = "México";
      electronicDocument.Data.Emisor.Domicilio.CodigoPostal.Value = "35143";

      // Lugar donde se expidio el documento
      electronicDocument.Data.Emisor.ExpedidoEn.Calle.Value = "Acapulco";
      electronicDocument.Data.Emisor.ExpedidoEn.NumeroExterior.Value = "651";
      electronicDocument.Data.Emisor.ExpedidoEn.NumeroInterior.Value = "1";
      electronicDocument.Data.Emisor.ExpedidoEn.Colonia.Value = "Roma";
      electronicDocument.Data.Emisor.ExpedidoEn.Localidad.Value = "México";
      electronicDocument.Data.Emisor.ExpedidoEn.Municipio.Value = "Cuauhtémoc";
      electronicDocument.Data.Emisor.ExpedidoEn.Estado.Value = "Distrito Federal";
      electronicDocument.Data.Emisor.ExpedidoEn.Pais.Value = "México";
      electronicDocument.Data.Emisor.ExpedidoEn.CodigoPostal.Value = "35135";

      // Regimen fiscal
      RegimenFiscal regimenFiscal = electronicDocument.Data.Emisor.Regimenes.Add();
      regimenFiscal.Regimen.Value = "Por honorarios";
      // ***************************************************************************************

      // Datos del Receptor ********************************************************************
      electronicDocument.Data.Receptor.Rfc.Value = "VOC990129I26";
      electronicDocument.Data.Receptor.Nombre.Value = "Receptor de prueba";

      // Domicilio fiscal del emisor
      electronicDocument.Data.Receptor.Domicilio.Calle.Value = "Heriberto Frias";
      electronicDocument.Data.Receptor.Domicilio.NumeroExterior.Value = "513";
      electronicDocument.Data.Receptor.Domicilio.Colonia.Value = "Narvarte";
      electronicDocument.Data.Receptor.Domicilio.Localidad.Value = "MEXICO";
      electronicDocument.Data.Receptor.Domicilio.Referencia.Value = "Entre Morena y Esperanza";
      electronicDocument.Data.Receptor.Domicilio.Municipio.Value = "Benito Juárez";
      electronicDocument.Data.Receptor.Domicilio.Estado.Value = "DISTRITO FEDERAL";
      electronicDocument.Data.Receptor.Domicilio.Pais.Value = "MEXICO";
      electronicDocument.Data.Receptor.Domicilio.CodigoPostal.Value = "12345";
      // ***************************************************************************************

      // Concepto  No 1 ************************************************************************
      Concepto concepto = electronicDocument.Data.Conceptos.Add();
      concepto.Cantidad.Value = 10;
      concepto.Unidad.Value = "Caja";
      concepto.Descripcion.Value = "Caja de DVD";
      concepto.ValorUnitario.Value = 120;
      concepto.Importe.Value = 1200;

      // ***** Se agregan 2 informaciones aduaneras
      Importacion importacion = concepto.InformacionAduanera.Add();
      importacion.Numero.Value = "AABBCC";
      importacion.Fecha.Value = DateTime.Now;
      importacion.Aduana.Value = "Tijuana";

      importacion = concepto.InformacionAduanera.Add();
      importacion.Numero.Value = "ZZZYYYWWW";
      importacion.Fecha.Value = DateTime.Now;
      importacion.Aduana.Value = "Baja California";

      // Concepto  No 2 ************************************************************************
      concepto = electronicDocument.Data.Conceptos.Add();
      concepto.Cantidad.Value = 1;
      concepto.Unidad.Value = "Pieza";
      concepto.Descripcion.Value = "Computadora armada";
      concepto.ValorUnitario.Value = 3000;
      concepto.Importe.Value = 3000;

      // ***** Se agregan 2 partes
      // ***** Parte 1
      Partida partida = concepto.Partes.Add();
      partida.Cantidad.Value = 1;
      partida.Descripcion.Value = "Disco duro de 500 GB";
      partida.Importe.Value = 1000;
      partida.NumeroIdentificacion.Value = "SAD665874DCSD6CX";

      importacion = partida.InformacionAduanera.Add();
      importacion.Numero.Value = "ASDRFSF345FDF";
      importacion.Fecha.Value = DateTime.Now;
      importacion.Aduana.Value = "Baja California";

      // ***** Parte 2
      partida = concepto.Partes.Add();
      partida.Cantidad.Value = 1;
      partida.Descripcion.Value = "Procesador AMD";
      partida.Importe.Value = 2000;
      partida.NumeroIdentificacion.Value = "SDFSDFC321641ERW2E3R315XV";

      // Concepto  No 3 ************************************************************************
      concepto = electronicDocument.Data.Conceptos.Add();
      concepto.Cantidad.Value = 1;
      concepto.Unidad.Value = "Pieza";
      concepto.Descripcion.Value = "Monitor de 19 \" marca AOC";
      concepto.NumeroIdentificacion.Value = "AX546461XASASD";
      concepto.ValorUnitario.Value = 3000;
      concepto.Importe.Value = 3000;

      // Impuestos trasladados ************************************************************************
      Traslado traslado = electronicDocument.Data.Impuestos.Traslados.Add();
      traslado.Tasa.Value = 16;
      traslado.Tipo.Value = "IVA";
      traslado.Importe.Value = 1094.4;

      electronicDocument.Data.Impuestos.TotalTraslados.Value = 1094.4;

      //// Impuestos retenidos **************************************************************************
      //Impuesto retencion = electronicDocument.Data.Impuestos.Retenciones.Add();
      //retencion.Importe.Value = 125.36;
      //retencion.Tipo.Value = "ISR";

      //electronicDocument.Data.Impuestos.TotalRetenciones.Value = 125.36;
    }
  }
}
