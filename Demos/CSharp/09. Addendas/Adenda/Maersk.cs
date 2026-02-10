using System;
using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Maersk;
using HyperSoft.ElectronicDocumentLibrary.Maersk.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Maersk(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Maersk addenda = new Maersk();

      Informacion informacion = addenda.Data.Addendas.Add();

      informacion.Retencion.Value = "Retencion";
      informacion.Brand.Value = "Brand";
      informacion.Vendor.Value = "Vendor";
      informacion.Buque.Value = "Buque";
      informacion.Viaje.Value = "Viaje";
      informacion.FechaZarpe.Value = DateTime.Now;
      informacion.FechaAtraque.Value = DateTime.Now;
      informacion.OrdenCompra.Value = "OrdenCompra";
      informacion.OrdenTrabajo.Value = "OrdenTrabajo";
      informacion.PoLine.Value = "PoLine";
      informacion.Cantidad.Value = 1;
      informacion.ValorUnitario.Value = 2;
      informacion.Requisition.Value = DateTime.Now;
      informacion.ContainerNumber.Value = "ContainerNumber";
      informacion.MaterialDescription.Value = "MaterialDescription";
      informacion.MaterialNumber.Value = "MaterialNumber";
      informacion.OrderValue.Value = 3;
      informacion.PorcentajeIva.Value = 4;
      informacion.IvaImporte.Value = 5;
      informacion.ImporteRetencion.Value = 6;
      informacion.SemanaFacturar.Value = "SemanaFacturar";
      informacion.Comentartios.Value = "Comentartios";

      informacion = addenda.Data.Addendas.Add();
      informacion.Retencion.Value = "Retencion";
      informacion.Brand.Value = "Brand";
      informacion.Vendor.Value = "Vendor";
      informacion.Buque.Value = "Buque";
      informacion.Viaje.Value = "Viaje";
      informacion.FechaZarpe.Value = DateTime.Now;
      informacion.FechaAtraque.Value = DateTime.Now;
      informacion.OrdenCompra.Value = "OrdenCompra";
      informacion.OrdenTrabajo.Value = "OrdenTrabajo";
      informacion.PoLine.Value = "PoLine";
      informacion.Cantidad.Value = 1;
      informacion.ValorUnitario.Value = 2;
      informacion.Requisition.Value = DateTime.Now;
      informacion.ContainerNumber.Value = "ContainerNumber";
      informacion.MaterialDescription.Value = "MaterialDescription";
      informacion.MaterialNumber.Value = "MaterialNumber";
      informacion.OrderValue.Value = 3;
      informacion.PorcentajeIva.Value = 4;
      informacion.IvaImporte.Value = 5;
      informacion.ImporteRetencion.Value = 6;
      informacion.SemanaFacturar.Value = "SemanaFacturar";
      informacion.Comentartios.Value = "Comentartios";

      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_Maersk.xml", out fileName);
    }
  }
}