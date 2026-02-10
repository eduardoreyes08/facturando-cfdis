using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Lamosa.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Lamosa(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Lamosa addenda = HyperSoft.ElectronicDocumentLibrary.Lamosa.Addenda.Lamosa.NewEntity();

      addenda.Data.TipoDocumento.Value = "Factura";

      addenda.Data.Emisor.NumeroRegistro.Value = "1";
      addenda.Data.Emisor.NumeroProveedor.Value = "2";

      addenda.Data.Receptor.NumeroRegistro.Value = "2";

      addenda.Data.Encabezado.NumeroProveedor.Value = "3";
      addenda.Data.Encabezado.OrdeCompra.Value = "4";
      addenda.Data.Encabezado.IdentificadorProceso.Value = "5";
      addenda.Data.Encabezado.SubTotal.Value = 10;
      addenda.Data.Encabezado.Iva.Value = 11;
      addenda.Data.Encabezado.IvaPorcentaje.Value = 12;
      addenda.Data.Encabezado.Total.Value = 13;
      addenda.Data.Encabezado.Moneda.Value = "MXN";
      addenda.Data.Encabezado.FormaPago.Value = "FormaPago";
      addenda.Data.Encabezado.CondicionPago.Value = "CondicionPago";
      addenda.Data.Encabezado.TipoDocumento.Value = "Factura";
      addenda.Data.Encabezado.PlantaEmite.Value = "PlantaEmite";
      addenda.Data.Encabezado.FolioNotaRecepcion.Value = "FolioNotaRecepcion";
      addenda.Data.Encabezado.Sociedad.Value = "Sociedad";


      ElectronicDocumentLibrary.Lamosa.Addenda.Cuerpo cuerpo = addenda.Data.Encabezado.Detalles.Add();
      cuerpo.Cantidad.Value = 2;
      cuerpo.UnidadMedida.Value = "ABC";
      cuerpo.Concepto.Value = "Concepto 1";
      cuerpo.PrecioUnitario.Value = 3;
      cuerpo.Importe.Value = 7;
      cuerpo.Linea.Value = 7;

      cuerpo = addenda.Data.Encabezado.Detalles.Add();
      cuerpo.Cantidad.Value = 2;
      cuerpo.UnidadMedida.Value = "ABC";
      cuerpo.Concepto.Value = "Concepto 1";
      cuerpo.PrecioUnitario.Value = 3;
      cuerpo.Importe.Value = 7;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Lamosa.xml", out fileName);
    }
  }
}