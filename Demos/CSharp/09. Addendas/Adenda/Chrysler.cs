using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Chrysler.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Chrysler(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Chrysler addenda = new HyperSoft.ElectronicDocumentLibrary.Chrysler.Addenda.Chrysler();

      addenda.Data.TipoDocumentoFiscal.Value = "TipoDocumentoFiscal";
      addenda.Data.TipoDocumento.Value = "PPY";
      addenda.Data.Version.Value = electronicDocument.Data.Version.Value;
      addenda.Data.Fecha.Value = electronicDocument.Data.Fecha.Value;
      addenda.Data.Serie.Value = electronicDocument.Data.Serie.Value;
      addenda.Data.FolioFiscal.Value = electronicDocument.Data.Folio.Value;
      addenda.Data.Uuid.Value = "9CA9E5F8-AE67-4494-9511-3A4079865B4B";
      addenda.Data.MontoTotal.Value = electronicDocument.Data.Total.Value;
      addenda.Data.ReferenciaProveedor.Value = "ReferenciaProveedor";

      Cancelacion cancelacion = addenda.Data.Cancelaciones.Add();
      cancelacion.CancelaSustituye.Value = "CancelaSustituye";

      addenda.Data.Moneda.TipoCambio.Value = 1;
      addenda.Data.Moneda.TipoMoneda.Value = "TipoMoneda";

      addenda.Data.Proveedor.Codigo.Value = "Codigo";
      addenda.Data.Proveedor.Nombre.Value = "Nombre";
      addenda.Data.Proveedor.Sufijo.Value = "Sufijo";

      addenda.Data.Destino.Codigo.Value = "Codigo";
      addenda.Data.Destino.Nombre.Value = "Nombre";
      addenda.Data.Destino.Sufijo.Value = "Sufijo";

      addenda.Data.Proyecto.ChargeUnit.Value = "ChargeUnit";
      addenda.Data.Proyecto.Numero.Value = "Numero";
      addenda.Data.Proyecto.NumeroTrabajo.Value = "NumeroTrabajo";

      Nota nota = addenda.Data.Notas.Add();
      nota.Texto.Value = "Texto";

      CargoCredito cargo = addenda.Data.CargosCreditos.Add();
      cargo.Consecutivo.Value = "Consecutivo";
      cargo.Factura.Value = "Factura";
      cargo.MontoLinea.Value = 1;
      cargo.Referencia.Value = "Referencia";

      OtroCargo otrosCargo = addenda.Data.OtrosCargos.Add();
      otrosCargo.Codigo.Value = "Codigo";
      otrosCargo.Monto.Value = 1;

      Parte parte = addenda.Data.Partes.Add();
      parte.Cantidad.Value = 1;
      parte.FechaRecibo.Value = DateTime.Now;
      parte.MontoLinea.Value = 1;
      parte.Numero.Value = "Numero";
      parte.PrecioUnitario.Value = 1;

      otrosCargo = parte.OtrosCargos.Add();
      otrosCargo.Codigo.Value = "Codigo2";
      otrosCargo.Monto.Value = 2;

      otrosCargo = parte.OtrosCargos.Add();
      otrosCargo.Codigo.Value = "Codigo3";
      otrosCargo.Monto.Value = 3;

      parte.Referencia.Ammendment.Value = "Ammendment";
      parte.Referencia.OrdenCompra.Value = "OrdenCompra";
      parte.Referencia.ReleaseRequisicion.Value = "ReleaseRequisicion";

      parte.UnidadMedida.Value = "UnidadMedida";

      parte.Notas.Add().Texto.Value = "Texto";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Chrysler.xml", out fileName);
    }
  }
}