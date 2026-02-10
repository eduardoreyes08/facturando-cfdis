using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Femsa.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Femsa(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Femsa addenda = HyperSoft.ElectronicDocumentLibrary.Femsa.Addenda.Femsa.NewEntity();

      addenda.Data.Version.Value = "Version";
      addenda.Data.ClaseDocumento.Value = "ClaseDocumento";
      addenda.Data.Sociedad.Value = "Sociedad";
      addenda.Data.NumeroProveedor.Value = "NumeroProveedor";
      addenda.Data.NumeroPedido.Value = "NumeroPedido";
      addenda.Data.NumeroSocioSap.Value = "NumeroSocioSap";
      addenda.Data.Moneda.Value = "Moneda";
      addenda.Data.NumeroEntradaSap.Value = "NumeroEntradaSap";
      addenda.Data.NumeroRemision.Value = "NumeroRemision";
      addenda.Data.Centro.Value = "Centro";
      addenda.Data.Retenciones1.Value = "Retenciones1";
      addenda.Data.Retenciones2.Value = "Retenciones2";
      addenda.Data.CorreoElectronico.Value = "CorreoElectronico";
      addenda.Data.PeriodoLiquidacion.Inicial.Value = DateTime.Now;
      addenda.Data.PeriodoLiquidacion.Final.Value = DateTime.Now;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Femsa.xml", out fileName);
    }
  }
}