using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Aba.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Aba(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Aba addenda = HyperSoft.ElectronicDocumentLibrary.Aba.Addenda.Aba.NewEntity();

      addenda.Data.Encabezado.Area.Value = 1;
      addenda.Data.Encabezado.SubArea.Value = 2;

      addenda.Data.Detalle.OrdenCompra.Value = "OrdenCompra";
      addenda.Data.Detalle.Siniestro.Value = "Siniestro";
      addenda.Data.Detalle.BienAfectado.Value = 3;
      addenda.Data.Detalle.Mes.Value = 4;
      addenda.Data.Detalle.Anio.Value = 2014;
      addenda.Data.Detalle.CorreoElectronico.Value = "a@a.com";
      addenda.Data.Detalle.Referencia1.Value = "Referencia1";
      addenda.Data.Detalle.Referencia2.Value = "Referencia2";
      addenda.Data.Detalle.Referencia3.Value = "Referencia3";
      addenda.Data.Detalle.Referencia4.Value = "Referencia4";
      addenda.Data.Detalle.Referencia5.Value = "Referencia5";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Aba.xml", out fileName);
    }
  }
}