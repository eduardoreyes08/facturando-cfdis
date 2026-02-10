using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.TresM.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool TresM(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      TresM addenda = new TresM().Initialization();

      addenda.Data.TipoDocumento.Value = "APP";
      addenda.Data.TipoDocumentoFiscal.Value = "a";
      addenda.Data.Version.Value = "1.0";
      addenda.Data.Serie.Value = "MD";
      addenda.Data.FolioFiscal.Value = "a";
      addenda.Data.Fecha.Value = DateTime.Now;
      addenda.Data.MontoTotal.Value = 1;
      addenda.Data.MontoSubTotal.Value = 2;
      addenda.Data.ReferenciaProveedor.Value = "a";

      Cancelacion cancelacion = addenda.Data.Cancelaciones.Add();
      cancelacion.CancelaSustituye.Value = "a";
      cancelacion.TipoCancelacion.Value = "a";
      cancelacion.ConceptoCancelacion.Value = "a";

      cancelacion = addenda.Data.Cancelaciones.Add();
      cancelacion.CancelaSustituye.Value = "b";
      cancelacion.TipoCancelacion.Value = "b";
      cancelacion.ConceptoCancelacion.Value = "b";

      addenda.Data.Moneda.TipoCambio.Value = 1;
      addenda.Data.Moneda.TipoMoneda.Value = "a";

      addenda.Data.Proveedor.Codigo.Value = "aa";
      addenda.Data.Proveedor.Nombre.Value = "a";

      addenda.Data.Destino.Codigo.Value = "aa";
      addenda.Data.Destino.Nombre.Value = "a";

      addenda.Data.Notas.Add().Texto.Value = "b";
      addenda.Data.Notas.Add().Texto.Value = "c";

      OtroCargo otroscargo = addenda.Data.OtrosCargos.Add();
      otroscargo.Codigo.Value = "12";
      otroscargo.Monto.Value = 1.12;

      otroscargo = addenda.Data.OtrosCargos.Add();
      otroscargo.Codigo.Value = "12";
      otroscargo.Monto.Value = 1.13;

      Parte parte = addenda.Data.Partes.Add();
      parte.Cantidad.Value = 1.1234;
      parte.Codigo.Value = "16";
      parte.FechaRecibo.Value = DateTime.Now;
      parte.Descripcion.Value = "a";
      parte.Monto.Value = 1.12;
      parte.PrecioUnitario.Value = 1.12;
      parte.MontoLinea.Value = 1.12;
      parte.Stock.Value = "a";
      parte.UnidadMedida.Value = "a";
      parte.OrdenCompra.Value = "a";

      parte.Notas.Add().Texto.Value = "1";
      parte.Notas.Add().Texto.Value = "2";


      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_3M.xml", out fileName);
    }
  }
}