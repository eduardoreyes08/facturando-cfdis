using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  internal static class EmisionPorCuentaDeTerceros10
  {
    internal static bool Create(ElectronicDocument electronicDocument, out string fileName)
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

      // Se agrega el complemento Emision por cuenta de terceros
      concepto.Complementos.Add(ComplementoConceptoType.EmisionPorCuentaDeTerceros);
      ElectronicDocumentLibrary.Complemento.EmisionPorCuentaDeTerceros.Data data = (ElectronicDocumentLibrary.Complemento.EmisionPorCuentaDeTerceros.Data)concepto.Complementos.Last();

      data.Version.Value = "1.0";
      data.Rfc.Value = "XXXX010101XX1";
      data.Nombre.Value = "A";

      data.InformacionFiscalTercero.Calle.Value = "A";
      data.InformacionFiscalTercero.NumeroExterior.Value = "B";
      data.InformacionFiscalTercero.NumeroInterior.Value = "C";
      data.InformacionFiscalTercero.Colonia.Value = "D";
      data.InformacionFiscalTercero.Localidad.Value = "E";
      data.InformacionFiscalTercero.Referencia.Value = "F";
      data.InformacionFiscalTercero.Municipio.Value = "G";
      data.InformacionFiscalTercero.Estado.Value = "H";
      data.InformacionFiscalTercero.Pais.Value = "I";
      data.InformacionFiscalTercero.CodigoPostal.Value = "44444";

      #region Información aduanera
      //dataEmisionPorCuentaDeTerceros.InformacionFiscalTercero.InformacionAduanera.Numero.Value = "A";
      //dataEmisionPorCuentaDeTerceros.InformacionFiscalTercero.InformacionAduanera.Fecha.Value = DateTime.Now;
      //dataEmisionPorCuentaDeTerceros.InformacionFiscalTercero.InformacionAduanera.Aduana.Value = "B"; 
      #endregion

      #region Partes
      //EmisionPorCuentaDeTerceros.Partida parte = dataEmisionPorCuentaDeTerceros.InformacionFiscalTercero.Partes.Add();
      //parte.Cantidad.Value = 1;
      //parte.Unidad.Value = "A";
      //parte.NumeroIdentificacion.Value = "B";
      //parte.Descripcion.Value = "C";
      //parte.ValorUnitario.Value = 2;
      //parte.Importe.Value = 2;

      //EmisionPorCuentaDeTerceros.Importacion aduanera = parte.InformacionAduanera.Add();
      //aduanera.Numero.Value = "A";
      //aduanera.Fecha.Value = DateTime.Now;
      //aduanera.Aduana.Value = "B";  
      #endregion

      data.InformacionFiscalTercero.CuentaPredial.Numero.Value = "K";


      return Base.Save(electronicDocument, "EmisionPorCuentaDeTerceros10.xml", out fileName);
    }
  }
}