using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;
using HyperSoft.ElectronicDocumentLibrary.Document;

// ReSharper disable RedundantNameQualifier

namespace HyperSoft.Ejemplo.Data.Complemento.CartaPorte
{
  public static class TransporteMaritimo
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
      //Se registran las distintas ubicaciones que sirven para reflejar el domicilio del origen y/o destino
      // que tienen los bienes o mercancías que se trasladan por distintos medios de transporte.
      Ubicacion ubicacion = data.Add();

      ubicacion.TipoUbicacion.Value = "Origen";
      ubicacion.IdUbicacion.Value = "OR000123";
      ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
      ubicacion.NombreRemitenteDestinatario.Value = "Juan Fernandez";
      ubicacion.NavegacionTrafico.Value = "Altura";
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
      ubicacion.NavegacionTrafico.Value = "Altura";
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
      FillTransporteMaritimo(data.TransporteMaritimo);
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
      FillDetalleMercancia(mercancia.DetalleMercancia);
    }

    private static void FillCantidadTransporta(CantidadTransportaList data)
    {
      CantidadTransporta cantidadTransporta = data.Add();
      cantidadTransporta.Cantidad.Value = 1;
      cantidadTransporta.IdOrigen.Value = "OR000123";
      cantidadTransporta.IdDestino.Value = "DE000100";
    }

    private static void FillDetalleMercancia(DetalleMercancia data)
    {
      data.UnidadPeso.Value = "X1A";
      data.PesoBruto.Value = 3;
      data.PesoNeto.Value = 3;
      data.PesoTara.Value = 1;
      data.NumeroPiezas.Value = 1;
    }

    private static void FillTransporteMaritimo(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteMaritimo data)
    {
      // Registro de la información que permita la identificación de la embarcación
      // por medio del cual se transportan los bienes o mercancías, vía marítima.
      data.PermisoSct.Value = "TPAF01";
      data.NumeroPermisoSct.Value = "845847858";
      data.NombreAseguradora.Value = "Qualitas";
      data.NumeroPolizaSeguro.Value = "854891554";
      data.TipoEmbarcacion.Value = "B03";
      data.Matricula.Value = "E584785";
      data.NumeroOmi.Value = "IMO5448589";
      data.AnioEmbarcacion.Value = 2020;
      data.NombreEmbarcacion.Value = "Zoa";
      data.NacionalidadEmbarcacion.Value = "USA";
      data.UnidadesArqueoBruto.Value = 35;
      data.TipoCarga.Value = "CGC";
      data.Eslora.Value = 20;
      data.Manga.Value = 20;
      data.Calado.Value = 20;
      data.Puntal.Value = 10;
      data.LineaNaviera.Value = "1315548554";
      data.NombreAgenteNaviero.Value = "ExpressNav";
      data.NumeroAutorizacionNaviero.Value = "SCT418/049/2019";
      data.NumeroViaje.Value = "1.00";
      data.NumeroConocimientoEmbarcacion.Value = "30.00";
      data.PermisoTemporalNavegacion.Value = "1234567890123456789";

      Contenedor contenedor = data.Contenedores.Add();
      contenedor.TipoContenedor.Value = "CM011";
      contenedor.IdCcpRelacionado.Value = "CCC00000-0000-0000-0000-000000000000";
      contenedor.PlacaVmccp.Value = "A1234";
      contenedor.FechaCertificacionCcp.Value = DateTime.Now;

      RemolqueCcp remolqueCcp = data.RemolquesCcp.Add();
      remolqueCcp.SubTipoRemolqueCcp.Value = "CTR001";
      remolqueCcp.PlacaCcp.Value = "A1234";
    }
  }
}