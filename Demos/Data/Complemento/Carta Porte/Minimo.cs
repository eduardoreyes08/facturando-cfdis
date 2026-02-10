using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento.CartaPorte
{
  // ReSharper disable RedundantNameQualifier
  public static class Minimo
  {
    public static void CargarDatos(ElectronicDocument electronicDocument)
    {
      Cfdi40.CargarDatosCompleto(electronicDocument);

      // Se agrega el complemento CARTA PORTE.
      electronicDocument.Data.Complementos.Add(ComplementoType.CartaPorte);
      HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "3.1";
      data.IdCcp.Value = "CCC00000-0000-0000-0000-000000000000";
      data.TransporteInternacional.Value = "Sí";

      FillUbicacion(data);
      FillMercancias(data.Mercancias);
    }

    private static void FillUbicacion(ElectronicDocumentLibrary.Complemento.CartaPorte.Data data)
    {
      Ubicacion ubicacion = data.Ubicaciones.Add();

      ubicacion.TipoUbicacion.Value = "Origen";
      ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
      ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;

      ubicacion = data.Ubicaciones.Add();

      ubicacion.TipoUbicacion.Value = "Destino";
      ubicacion.RfcRemitenteDestinatario.Value = "XEXX010101000";
      ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;
    }

    private static void FillMercancias(Mercancias data)
    {
      data.PesoBrutoTotal.Value = 3;
      data.UnidadPeso.Value = "Tu";
      data.NumeroTotalMercancias.Value = 1;

      FillMercancia(data.Mercancia);
    }

    private static void FillMercancia(MercanciaList data)
    {
      Mercancia mercancia = data.Add();
      mercancia.BienesTransportado.Value = "10101500";
      mercancia.Descripcion.Value = "Descripcion";
      mercancia.Cantidad.Value = 1;
      mercancia.ClaveUnidad.Value = "A34";
      mercancia.PesoEnKilogramos.Value = 3;
    }
  }
}