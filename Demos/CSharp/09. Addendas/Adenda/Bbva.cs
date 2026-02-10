using HyperSoft.Ejemplo.Data;
using HyperSoft.ElectronicDocumentLibrary.Bbva.Addenda;

namespace HyperSoft.Ejemplo.Adendas
{
  internal static partial class Adenda
  {
    internal static bool Bbva(out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      Bbva addenda = new Bbva().Initialization();

      addenda.Data.Version.Value = "1";
      addenda.Data.Tipo.Value = "2";
      addenda.Data.Proveedor.Value = "3";
      addenda.Data.Siniestro.Value = "4";
      addenda.Data.SubTotal.Value = 5;
      addenda.Data.Iva.Value = 6;
      addenda.Data.IvaRetenido.Value = 7;
      addenda.Data.IseRetenido.Value = 8;
      addenda.Data.ImpuestoCedular.Value = 9;
      addenda.Data.Total.Value = 10;
      addenda.Data.Retencion.Value = 11;
      addenda.Data.OrdenPago.Value = "12";

      addenda.Data.Cristales.Deducible.Value = 13;
      addenda.Data.Cristales.CodigoNags.Value = "14";

      for (int i = 0; i < 2; i++)
      {
        HonorarioServicio servicio = addenda.Data.Honorarios.Servicios.Add();
        servicio.OrdenPagoHonorarios.Value = 1;
        servicio.Costo.Value = 2;
      }

      for (int i = 0; i < 3; i++)
      {
        GruaServicio servicio = addenda.Data.Gruas.Servicios.Add();
        servicio.NumeroServicio.Value = 1;
        servicio.Costo.Value = 2;
      }

      for (int i = 0; i < 4; i++)
      {
        AsistenciaServicio servicio = addenda.Data.Asistencia.Servicios.Add();
        servicio.NumeroServicio.Value = 1;
        servicio.Costo.Value = 2;
      }

      addenda.Data.Reparaciones.NumeroValuacionInicial.Value = "15";
      addenda.Data.Reparaciones.Costo.Value = 16;
      for (int i = 0; i < 2; i++)
      {
        ValeRefacciones vale = addenda.Data.Reparaciones.ValesRefacciones.Add();
        vale.Numero.Value = "1";
        vale.Costo.Value = 2;
      }

      for (int i = 0; i < 3; i++)
      {
        ValeComplemento vale = addenda.Data.Reparaciones.ValesComplemento.Add();
        vale.Numero.Value = "1";
        vale.Costo.Value = 2;
      }

      addenda.Data.GastosMedicos.PaseMedico.Value = "17";
      addenda.Data.GastosMedicos.Costo.Value = 18;
      
      electronicDocument.Data.Addendas.Add(addenda);

      return Save("Addenda_BBVA.xml", out fileName);
    }
  }
}