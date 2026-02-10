using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Ferro;
using HyperSoft.ElectronicDocumentLibrary.FerroMexicana.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool FerroMexicana(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      FerroMexicana addenda = HyperSoft.ElectronicDocumentLibrary.FerroMexicana.Addenda.FerroMexicana.NewEntity();

      addenda.Data.NumeroProveedor.Texto.Value = "0000";

      addenda.Data.Documento.NumeroDocumento.Value = "0000000000";
      addenda.Data.Documento.FechaDocumento.Value = DateTime.Now;
      addenda.Data.Documento.Tipo.Value = "OC";

      Concepto concepto = addenda.Data.Conceptos.Add();
      concepto.Posicion.Value = "10000";
      concepto.NumeroParte.Value = "0000000000";
      concepto.Cantidad.Value = 1;
      concepto.Descripcion.Value = "Descripcion";
      concepto.PrecioUnitario.Value = 1;
      concepto.Importe.Value = 1;

      concepto = addenda.Data.Conceptos.Add();
      concepto.Posicion.Value = "20000";
      concepto.Cantidad.Value = 2;
      concepto.Descripcion.Value = "Descripcion - 2";
      concepto.PrecioUnitario.Value = 2;
      concepto.Importe.Value = 2;

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_FerroMexicana.xml", out fileName);
    }
  }
}