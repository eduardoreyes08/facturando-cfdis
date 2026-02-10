using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;
using HyperSoft.ElectronicDocumentLibrary.Document;

// ReSharper disable RedundantNameQualifier

namespace HyperSoft.Ejemplo.Data.Complemento.CartaPorte
{
  public static class TransporteAereo
  {
   public static void Timbrado(ElectronicDocument electronicDocument)
    {
      Cfdi40.CargarDatosTimbrado(electronicDocument);

      // Se agrega el complemento CARTA PORTE.
      electronicDocument.Data.Complementos.Add(ComplementoType.CartaPorte);
      HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "3.1";
      data.IdCcp.Value = "CCC00000-0000-0000-0000-000000000000";
      data.TransporteInternacional.Value = "No";
      data.RegistroIstmo.Value = "Sí";
      data.UbicacionPoloOrigen.Value = "01";
      data.UbicacionPoloDestino.Value = "02";

      FillUbicacion(data.Ubicaciones);
      FillMercancias(data.Mercancias);
    }

    private static void FillUbicacion(UbicacionList data)
    {
      Ubicacion ubicacion = data.Add();

      ubicacion.TipoUbicacion.Value = "Origen";
      ubicacion.IdUbicacion.Value = "OR000123";
      ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
      ubicacion.NombreRemitenteDestinatario.Value = "Juan Fernandez";
      ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;
      ubicacion.TipoEstacion.Value = "01";

      ubicacion.Domicilio.Calle.Value = "Primera";
      ubicacion.Domicilio.NumeroExterior.Value = "1";
      ubicacion.Domicilio.NumeroInterior.Value = "A";
      ubicacion.Domicilio.Colonia.Value = "0001";
      ubicacion.Domicilio.Localidad.Value = "01";
      ubicacion.Domicilio.Referencia.Value = "Interior";
      ubicacion.Domicilio.Municipio.Value = "001";
      ubicacion.Domicilio.Estado.Value = "AGU";
      ubicacion.Domicilio.Pais.Value = "MEX";
      ubicacion.Domicilio.CodigoPostal.Value = "20000";

      ubicacion = data.Add();

      ubicacion.TipoUbicacion.Value = "Destino";
      ubicacion.IdUbicacion.Value = "DE000100";
      ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
      ubicacion.NombreRemitenteDestinatario.Value = "Juan Fernandez";
      ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;
      ubicacion.TipoEstacion.Value = "01";

      ubicacion.Domicilio.Calle.Value = "Segunda";
      ubicacion.Domicilio.NumeroExterior.Value = "2";
      ubicacion.Domicilio.NumeroInterior.Value = "B";
      ubicacion.Domicilio.Colonia.Value = "0001";
      ubicacion.Domicilio.Localidad.Value = "01";
      ubicacion.Domicilio.Referencia.Value = "Interior";
      ubicacion.Domicilio.Municipio.Value = "001";
      ubicacion.Domicilio.Estado.Value = "CO";
      ubicacion.Domicilio.Pais.Value = "USA";
      ubicacion.Domicilio.CodigoPostal.Value = "20000";
    }

    private static void FillMercancias(Mercancias data)
    {
      // Registro de la información de los bienes o mercancías que se trasladan en los distintos
      // medios de transporte.
      data.PesoBrutoTotal.Value = 3;
      data.UnidadPeso.Value = "Tu";
      data.PesoNetoTotal.Value = 3;
      data.NumeroTotalMercancias.Value = 1;
      data.CargoPorTasacion.Value = 1;

      FillMercancia(data.Mercancia);
      FillTransporteAereo(data.TransporteAereo);
    }

    private static void FillMercancia(MercanciaList data)
    {
      // Registro de la información de los bienes o mercancías que se trasladan en los distintos
      // medios de transporte.
      Mercancia mercancia = data.Add();
      mercancia.BienesTransportado.Value = "10101500";
      mercancia.ClaveStcc.Value = "010132";
      mercancia.Descripcion.Value = "Descripcion";
      mercancia.Cantidad.Value = 1;
      mercancia.ClaveUnidad.Value = "A34";
      mercancia.Unidad.Value = "Pieza";
      mercancia.Dimensiones.Value = "10/10/10cm";
      mercancia.PesoEnKilogramos.Value = 3;
      mercancia.ValorMercancia.Value = 1;
      mercancia.Moneda.Value = "MXN";
      mercancia.UuidComercioExterior.Value = "74E2925B-5000-408D-8A9E-3A86BB0DFE18";

      FillCantidadTransporta(mercancia.CantidadTransporta);
    }

    private static void FillCantidadTransporta(CantidadTransportaList data)
    {
      CantidadTransporta cantidadTransporta = data.Add();
      cantidadTransporta.Cantidad.Value = 1;
      cantidadTransporta.IdOrigen.Value = "OR000123";
      cantidadTransporta.IdDestino.Value = "DE000100";
    }

    private static void FillTransporteAereo(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteAereo data)
    {
      // Registro de la información que permita la identificación del transporte aéreo
      // por medio del cual se trasladan los bienes o mercancías.
      data.PermisoSct.Value = "TPAF01";
      data.NumeroPermisoSct.Value = "10000002";
      data.MatriculaAeronave.Value = "515425";
      data.NombreAseguradora.Value = "Qualitas";
      data.NumeroPolizaSeguro.Value = "854891554";
      data.NumeroGuia.Value = "5145878585985";
      data.LugarContrato.Value = "México ESC";
      data.CodigoTransportista.Value = "CA003";
      data.RfcEmbarcador.Value = "AAAD770905441";
      data.ResidenciaFiscalEmbarcador.Value = "MEX";
      data.NombreEmbarcador.Value = "Rai Nta";
    }
  }
}