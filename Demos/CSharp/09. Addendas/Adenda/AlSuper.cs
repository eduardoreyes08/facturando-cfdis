using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.AlSuper.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool AlSuper(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      AlSuper addenda = HyperSoft.ElectronicDocumentLibrary.AlSuper.Addenda.AlSuper.NewEntity();

      addenda.Data.Version.Value = "1.0";
      addenda.Data.OrdenCompra.Value = 1;
      addenda.Data.Remision.Value = "Remision";
      addenda.Data.TipoCambio.Value = 2;
      addenda.Data.Sucursal.Value = "Sucursal";
      addenda.Data.TipoMoneda.Value = "TipoMoneda";
      addenda.Data.Cita.Value = 3;
      addenda.Data.FechaCita.Value = DateTime.Now;
      addenda.Data.TipoBulto.Value = "TipoBulto";
      addenda.Data.ValorFlete.Value = 4;
      addenda.Data.CorreoElectronico.Value = "prueba@prueba.com";

      ElectronicDocumentLibrary.AlSuper.Addenda.Concepto concepto = addenda.Data.Conceptos.Add();
      concepto.Numero.Value = 1;
      concepto.CodigoBarras.Value = "CodigoBarras 1";
      concepto.FactorEmpaque.Value = 2;
      concepto.EmpaqueIngreso.Value = 4;
      concepto.CostoPagar.Value = 5;
      concepto.ValorIeps.Value = 6;
      concepto.ValorIva.Value = 7;

      concepto = addenda.Data.Conceptos.Add();
      concepto.Numero.Value = 8;
      concepto.CodigoBarras.Value = "CodigoBarras 2";
      concepto.FactorEmpaque.Value = 9;
      concepto.EmpaqueIngreso.Value = 10;
      concepto.CostoPagar.Value = 11;
      concepto.ValorIeps.Value = 12;
      concepto.ValorIva.Value = 13;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_AlSuper.xml", out fileName);
    }
  }
}