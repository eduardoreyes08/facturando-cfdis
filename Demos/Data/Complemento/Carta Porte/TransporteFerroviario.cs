using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;
using HyperSoft.ElectronicDocumentLibrary.Document;

// ReSharper disable RedundantNameQualifier

namespace HyperSoft.Ejemplo.Data.Complemento.CartaPorte
{
  public static class TransporteFerroviario
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
      data.TotalDistanciaRecorrida.Value = 1000;
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

      for (int i = 0; i < 5; i++)
      {

        ubicacion = data.Add();

        ubicacion.TipoUbicacion.Value = "Destino";
        ubicacion.IdUbicacion.Value = "DE00010" + i;
        ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
        ubicacion.NombreRemitenteDestinatario.Value = "Juan Fernandez";
        ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;
        ubicacion.TipoEstacion.Value = "01";
        ubicacion.DistanciaRecorrida.Value = 200;

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
      FillTransporteFerroviario(data.TransporteFerroviario);
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

    private static void FillTransporteFerroviario(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteFerroviario data)
    {
      // Registro de la información que permita la identificación del carro o contenedor
      // en el que se transportan los bienes o mercancías vía férrea.
      data.TipoServicio.Value = "TS02";
      data.TipoTrafico.Value = "TT03";
      data.NombreAseguradora.Value = "Qualitas";
      data.NumeroPolizaSeguro.Value = "854891554";

      DerechoPaso derechoPaso = data.DerechosPaso.Add();
      derechoPaso.TipoDerecho.Value = "CDP002";
      derechoPaso.KilometrajePagado.Value = 1000;

      Carro carro = data.Carros.Add();
      carro.Tipo.Value = "TC05";
      carro.Matricula.Value = "ENK-2514";
      carro.Guia.Value = "854891554";
      carro.ToneladasNetas.Value = 3;

      ContenedorCarro contenedor = carro.Contenedores.Add();
      contenedor.TipoContenedor.Value = "TC01";
      contenedor.PesoContenedorVacio.Value = new decimal(.5);
      contenedor.PesoNetoMercancia.Value = 3000;
    }
  }
}