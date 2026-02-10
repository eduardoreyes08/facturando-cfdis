using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class CartaPorte10
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO CARTA PORTE");
      Utils.ShowField("Versión                ", data.Version);
      Utils.ShowField("TransporteInternacional", data.TransporteInternacional);
      Utils.ShowField("EntradaSalidaMercancia ", data.EntradaSalidaMercancia);
      Utils.ShowField("ViaEntradaSalida       ", data.ViaEntradaSalida);
      Utils.ShowField("TotalDistanciaRecorrida", data.TotalDistanciaRecorrida);

      ShowUbicacion(data);
      ShowMercancias(data.Mercancias);
      ShowFiguraTransporte(data.FiguraTransporte);
    }

    private static void ShowUbicacion(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data data)
    {
      if (data.Ubicaciones.Count == 0)
        return;

      for (int i = 0; i < data.Ubicaciones.Count; i++)
      {
        Ubicacion ubicacion = data.Ubicaciones[0];

        string title = $"CARTA PORTE - UBICACION - {i + 1}";

        Utils.ShowTitle(title);
        Utils.ShowField("TipoEstacion      ", ubicacion.TipoEstacion);
        Utils.ShowField("DistanciaRecorrida", ubicacion.DistanciaRecorrida);

        Utils.ShowTitle($"{title} - ORIGEN");
        Utils.ShowField("Id               ", ubicacion.Origen.Id);
        Utils.ShowField("RfcRemitente     ", ubicacion.Origen.RfcRemitente);
        Utils.ShowField("NombreRemitente  ", ubicacion.Origen.NombreRemitente);
        Utils.ShowField("IdTtributario    ", ubicacion.Origen.IdTtributario);
        Utils.ShowField("ResidenciaFiscal ", ubicacion.Origen.ResidenciaFiscal);
        Utils.ShowField("NumeroEstacion   ", ubicacion.Origen.NumeroEstacion);
        Utils.ShowField("NombreEstacion   ", ubicacion.Origen.NombreEstacion);
        Utils.ShowField("NavegacionTrafico", ubicacion.Origen.NavegacionTrafico);
        Utils.ShowField("FechaHoraSalida  ", ubicacion.Origen.FechaHoraSalida);


        Utils.ShowTitle($"{title} - DESTINO");
        Utils.ShowField("Id                ", ubicacion.Destino.Id);
        Utils.ShowField("RfcDestinatario   ", ubicacion.Destino.RfcDestinatario);
        Utils.ShowField("NombreDestinatario", ubicacion.Destino.NombreDestinatario);
        Utils.ShowField("IdTtributario     ", ubicacion.Destino.IdTtributario);
        Utils.ShowField("ResidenciaFiscal  ", ubicacion.Destino.ResidenciaFiscal);
        Utils.ShowField("NumeroEstacion    ", ubicacion.Destino.NumeroEstacion);
        Utils.ShowField("NombreEstacion    ", ubicacion.Destino.NombreEstacion);
        Utils.ShowField("NavegacionTrafico ", ubicacion.Destino.NavegacionTrafico);
        Utils.ShowField("FechaHoraLlegada  ", ubicacion.Destino.FechaHoraLlegada);

        Utils.ShowTitle($"{title} - DOMICILIO");
        ShowDomicilio(ubicacion.Domicilio);
      }
    }

    private static void ShowMercancias(Mercancias data)
    {
      Utils.ShowTitle("CARTA PORTE - MERCANCIAS");
      Utils.ShowField("PesoBrutoTotal       ", data.PesoBrutoTotal);
      Utils.ShowField("UnidadPeso           ", data.UnidadPeso);
      Utils.ShowField("PesoNetoTotal        ", data.PesoNetoTotal);
      Utils.ShowField("NumeroTotalMercancias", data.NumeroTotalMercancias);
      Utils.ShowField("CargoPorTasacion     ", data.CargoPorTasacion);

      ShowMercancia(data.Mercancia);
      ShowAutoTransporteFederal(data.AutoTransporteFederal);
      ShowTransporteMaritimo(data.TransporteMaritimo);
      ShowTransporteAereo(data.TransporteAereo);
      ShowTransporteFerroviario(data.TransporteFerroviario);
    }

    private static void ShowMercancia(MercanciaList mercancia)
    {
      for (int i = 0; i < mercancia.Count; i++)
      {
        string title = $"CARTA PORTE - MERCANCIA {i + 1}";

        Mercancia data = mercancia[i];

        Utils.ShowTitle(title);
        Utils.ShowField("BienesTransportado    ", data.BienesTransportado);
        Utils.ShowField("ClaveStcc             ", data.ClaveStcc);
        Utils.ShowField("Descripcion           ", data.Descripcion);
        Utils.ShowField("Cantidad              ", data.Cantidad);
        Utils.ShowField("ClaveUnidad           ", data.ClaveUnidad);
        Utils.ShowField("Unidad                ", data.Unidad);
        Utils.ShowField("Dimensiones           ", data.Dimensiones);
        Utils.ShowField("MaterialPeligroso     ", data.MaterialPeligroso);
        Utils.ShowField("ClaveMaterialPeligroso", data.ClaveMaterialPeligroso);
        Utils.ShowField("Embalaje              ", data.Embalaje);
        Utils.ShowField("DescripcionEmbalaje   ", data.DescripcionEmbalaje);
        Utils.ShowField("PesoEnKilogramos      ", data.PesoEnKilogramos);
        Utils.ShowField("ValorMercancia        ", data.ValorMercancia);
        Utils.ShowField("Moneda                ", data.Moneda);
        Utils.ShowField("FraccionArancelaria   ", data.FraccionArancelaria);
        Utils.ShowField("UuidComercioExterior  ", data.UuidComercioExterior);


        for (int j = 0; j < data.CantidadTransporta.Count; j++)
        {
          Utils.ShowTitle($"{title} - CANTIDAD TRANSPORTA {j + 1}");
          Utils.ShowField("Cantidad       ", data.CantidadTransporta[j].Cantidad);
          Utils.ShowField("IdOrigen       ", data.CantidadTransporta[j].IdOrigen);
          Utils.ShowField("IdDestino      ", data.CantidadTransporta[j].IdDestino);
          Utils.ShowField("ClaveTransporte", data.CantidadTransporta[j].ClaveTransporte);
        }

        Utils.ShowTitle($"{title} - DETALLE");
        Utils.ShowField("UnidadPeso  ", data.DetalleMercancia.UnidadPeso);
        Utils.ShowField("PesoBruto   ", data.DetalleMercancia.PesoBruto);
        Utils.ShowField("PesoNeto    ", data.DetalleMercancia.PesoNeto);
        Utils.ShowField("PesoTara    ", data.DetalleMercancia.PesoTara);
        Utils.ShowField("NumeroPiezas", data.DetalleMercancia.NumeroPiezas);
      }
    }

    private static void ShowAutoTransporteFederal(AutotransporteFederal data)
    {
      string title = "CARTA PORTE - AUTO TRANSPORTE FEDERAL";

      Utils.ShowTitle(title);
      Utils.ShowField("PermisoSct        ", data.PermisoSct);
      Utils.ShowField("NumeroPermisoSct  ", data.NumeroPermisoSct);
      Utils.ShowField("NombreAseguradora ", data.NombreAseguradora);
      Utils.ShowField("NumeroPolizaSeguro", data.NumeroPolizaSeguro);

      Utils.ShowTitle($"{title} - IDENTIFICACION VEHICULAR");
      Utils.ShowField("AnioModelo     ", data.IdentificacionVehicular.AnioModelo);
      Utils.ShowField("ConfigVehicular", data.IdentificacionVehicular.ConfigVehicular);
      Utils.ShowField("Placa          ", data.IdentificacionVehicular.Placa);

      for (int i = 0; i < data.Remolques.Count; i++)
      {
        Utils.ShowTitle($"{title} - REMOLQUE {i + 1}");
        Utils.ShowField("Placa  ", data.Remolques[i].Placa);
        Utils.ShowField("SubTipo", data.Remolques[i].SubTipo);
      }
    }

    private static void ShowTransporteMaritimo(TransporteMaritimo data)
    {
      const string Title = "CARTA PORTE - TRANSPORTE MARITIMO";

      Utils.ShowTitle(Title);
      Utils.ShowField("PermisoSct                   ", data.PermisoSct);
      Utils.ShowField("NumeroPermisoSct             ", data.NumeroPermisoSct);
      Utils.ShowField("NombreAseguradora            ", data.NombreAseguradora);
      Utils.ShowField("NumeroPolizaSeguro           ", data.NumeroPolizaSeguro);
      Utils.ShowField("TipoEmbarcacion              ", data.TipoEmbarcacion);
      Utils.ShowField("Matricula                    ", data.Matricula);
      Utils.ShowField("NumeroOmi                    ", data.NumeroOmi);
      Utils.ShowField("AnioEmbarcacion              ", data.AnioEmbarcacion);
      Utils.ShowField("NombreEmbarcacion            ", data.NombreEmbarcacion);
      Utils.ShowField("NacionalidadEmbarcacion      ", data.NacionalidadEmbarcacion);
      Utils.ShowField("UnidadesArqueoBruto          ", data.UnidadesArqueoBruto);
      Utils.ShowField("TipoCarga                    ", data.TipoCarga);
      Utils.ShowField("NumeroCertificadoItc         ", data.NumeroCertificadoItc);
      Utils.ShowField("Eslora                       ", data.Eslora);
      Utils.ShowField("Manga                        ", data.Manga);
      Utils.ShowField("Calado                       ", data.Calado);
      Utils.ShowField("LineaNaviera                 ", data.LineaNaviera);
      Utils.ShowField("NombreAgenteNaviero          ", data.NombreAgenteNaviero);
      Utils.ShowField("NumeroAutorizacionNaviero    ", data.NumeroAutorizacionNaviero);
      Utils.ShowField("NumeroViaje                  ", data.NumeroViaje);
      Utils.ShowField("NumeroConocimientoEmbarcacion", data.NumeroConocimientoEmbarcacion);

      for (int i = 0; i < data.Contenedores.Count; i++)
      {
        Utils.ShowTitle($"{Title} - CONTENEDOR {i + 1}");
        Utils.ShowField("MatriculaContenedor", data.Contenedores[i].MatriculaContenedor);
        Utils.ShowField("TipoContenedor     ", data.Contenedores[i].TipoContenedor);
        Utils.ShowField("NumeroPrecinto     ", data.Contenedores[i].NumeroPrecinto);
      }
    }

    private static void ShowTransporteAereo(TransporteAereo data)
    {
      Utils.ShowTitle("CARTA PORTE - TRANSPORTE AEREO");
      Utils.ShowField("PermisoSct                   ", data.PermisoSct);
      Utils.ShowField("NumeroPermisoSct             ", data.NumeroPermisoSct);
      Utils.ShowField("MatriculaAeronave            ", data.MatriculaAeronave);
      Utils.ShowField("NombreAseguradora            ", data.NombreAseguradora);
      Utils.ShowField("NumeroPolizaSeguro           ", data.NumeroPolizaSeguro);
      Utils.ShowField("NumeroGuia                   ", data.NumeroGuia);
      Utils.ShowField("LugarContrato                ", data.LugarContrato);
      Utils.ShowField("RfcTransportista             ", data.RfcTransportista);
      Utils.ShowField("CodigoTransportista          ", data.CodigoTransportista);
      Utils.ShowField("IdTributarioTransportista    ", data.IdTributarioTransportista);
      Utils.ShowField("ResidenciaFiscalTransportista", data.ResidenciaFiscalTransportista);
      Utils.ShowField("NombreTransportista          ", data.NombreTransportista);
      Utils.ShowField("RfcEmbarcador                ", data.RfcEmbarcador);
      Utils.ShowField("IdTributarioEmbarcador       ", data.IdTributarioEmbarcador);
      Utils.ShowField("ResidenciaFiscalEmbarcador   ", data.ResidenciaFiscalEmbarcador);
      Utils.ShowField("NombreEmbarcador             ", data.NombreEmbarcador);
    }

    private static void ShowTransporteFerroviario(TransporteFerroviario data)
    {
      const string Title = "CARTA PORTE - TRANSPORTE FERROVIARIO";

      Utils.ShowTitle(Title);
      Utils.ShowField("TipoServicio      ", data.TipoServicio);
      Utils.ShowField("NombreAseguradora ", data.NombreAseguradora);
      Utils.ShowField("NumeroPolizaSeguro", data.NumeroPolizaSeguro);
      Utils.ShowField("Concesionario     ", data.Concesionario);

      for (int i = 0; i < data.DerechosPaso.Count; i++)
      {
        Utils.ShowTitle($"{Title} - DERECHO DE PASO {i + 1}");
        Utils.ShowField("KilometrajePagado", data.DerechosPaso[i].KilometrajePagado);
        Utils.ShowField("TipoDerecho      ", data.DerechosPaso[i].TipoDerecho);
      }

      for (int i = 0; i < data.Carros.Count; i++)
      {
        string subTitle = $"{Title} - CARRO {i + 1}";
        Carro carro = data.Carros[i];
        Utils.ShowTitle(subTitle);
        Utils.ShowField("Tipo          ", carro.Tipo);
        Utils.ShowField("Matricula     ", carro.Matricula);
        Utils.ShowField("Guia          ", carro.Guia);
        Utils.ShowField("ToneladasNetas", carro.ToneladasNetas);

        for (int j = 0; j < carro.Contenedores.Count; j++)
        {
          Utils.ShowTitle($"{subTitle} - CONTENEDOR {j + 1}");
          Utils.ShowField("PesoNetoMercancia  ", carro.Contenedores[j].PesoNetoMercancia);
          Utils.ShowField("PesoContenedorVacio", carro.Contenedores[j].PesoContenedorVacio);
          Utils.ShowField("TipoContenedor     ", carro.Contenedores[j].TipoContenedor);
        }
      }
    }

    private static void ShowFiguraTransporte(FiguraTransporte data)
    {
      const string Title = "CARTA PORTE - FIGURA TRANSPORTE";

      Utils.ShowTitle(Title);
      Utils.ShowField("ClaveTransporte", data.ClaveTransporte);

      for (int i = 0; i < data.Operadores.Count; i++)
      {
        for (int j = 0; j < data.Operadores[i].Operador.Count; j++)
        {
          string subTitle = $"{Title} - OPERADOR {j + 1}";

          Operador operador = data.Operadores[i].Operador[j];
          Utils.ShowTitle(subTitle);
          Utils.ShowField("Rfc             ", operador.Rfc);
          Utils.ShowField("NumeroLicencia  ", operador.NumeroLicencia);
          Utils.ShowField("Nombre          ", operador.Nombre);
          Utils.ShowField("IdTtributario   ", operador.IdTtributario);
          Utils.ShowField("ResidenciaFiscal", operador.ResidenciaFiscal);

          Utils.ShowTitle($"{subTitle} - DOMICILIO");
          ShowDomicilio(operador.Domicilio);
        }
      }

      for (int i = 0; i < data.Propietarios.Count; i++)
      {
        string subTitle = $"{Title} - PROPIETARIO {i + 1}";

        Utils.ShowTitle(subTitle);

        Propietario propietario = data.Propietarios[i];
        Utils.ShowField("Rfc             ", propietario.Rfc);
        Utils.ShowField("Nombre          ", propietario.Nombre);
        Utils.ShowField("IdTtributario   ", propietario.IdTtributario);
        Utils.ShowField("ResidenciaFiscal", propietario.ResidenciaFiscal);

        Utils.ShowTitle($"{subTitle} - DOMICILIO");
        ShowDomicilio(propietario.Domicilio);
      }

      for (int i = 0; i < data.Arrendatarios.Count; i++)
      {
        string subTitle = $"{Title} - ARRENDATARIO {i + 1}";

        Utils.ShowTitle(subTitle);

        Arrendatario arrendatario = data.Arrendatarios[i];
        Utils.ShowField("Rfc             ", arrendatario.Rfc);
        Utils.ShowField("Nombre          ", arrendatario.Nombre);
        Utils.ShowField("IdTtributario   ", arrendatario.IdTtributario);
        Utils.ShowField("ResidenciaFiscal", arrendatario.ResidenciaFiscal);

        Utils.ShowTitle($"{subTitle} - DOMICILIO");
        ShowDomicilio(arrendatario.Domicilio);
      }

      for (int i = 0; i < data.Notificados.Count; i++)
      {
        string subTitle = $"{Title} - NOTIFICADO {i + 1}";

        Utils.ShowTitle(subTitle);

        Notificado notificado = data.Notificados[i];
        Utils.ShowField("Rfc             ", notificado.Rfc);
        Utils.ShowField("Nombre          ", notificado.Nombre);
        Utils.ShowField("IdTtributario   ", notificado.IdTtributario);
        Utils.ShowField("ResidenciaFiscal", notificado.ResidenciaFiscal);

        Utils.ShowTitle($"{subTitle} - DOMICILIO");
        ShowDomicilio(notificado.Domicilio);
      }
    }

    private static void ShowDomicilio(Domicilio data)
    {
      Utils.ShowField("Calle         ", data.Calle);
      Utils.ShowField("NumeroExterior", data.NumeroExterior);
      Utils.ShowField("NumeroInterior", data.NumeroInterior);
      Utils.ShowField("Colonia       ", data.Colonia);
      Utils.ShowField("Localidad     ", data.Localidad);
      Utils.ShowField("Referencia    ", data.Referencia);
      Utils.ShowField("Municipio     ", data.Municipio);
      Utils.ShowField("Estado        ", data.Estado);
      Utils.ShowField("Pais          ", data.Pais);
      Utils.ShowField("CodigoPostal  ", data.CodigoPostal);
    }
  }
}