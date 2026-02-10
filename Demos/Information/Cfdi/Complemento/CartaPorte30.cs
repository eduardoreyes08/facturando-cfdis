using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;

namespace HyperSoft.Ejemplo.Information.Complemento
{
  internal static class CartaPorte30
  {
    internal static void Show(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.Data data)
    {
      Utils.ShowTitle("COMPLEMENTO CARTA PORTE");
      Utils.ShowField("Version                ", data.Version);
      Utils.ShowField("IdCcp                  ", data.IdCcp);
      Utils.ShowField("TransporteInternacional", data.TransporteInternacional);
      Utils.ShowField("RegimenAduanero        ", data.RegimenAduanero);
      Utils.ShowField("EntradaSalidaMercancia ", data.EntradaSalidaMercancia);
      Utils.ShowField("PaisOrigenDestino      ", data.PaisOrigenDestino);
      Utils.ShowField("ViaEntradaSalida       ", data.ViaEntradaSalida);
      Utils.ShowField("TotalDistanciaRecorrida", data.TotalDistanciaRecorrida);
      Utils.ShowField("RegistroIstmo          ", data.RegistroIstmo);
      Utils.ShowField("UbicacionPoloOrigen    ", data.UbicacionPoloOrigen);
      Utils.ShowField("UbicacionPoloDestino   ", data.UbicacionPoloDestino);

      Ubicacion(data.Ubicaciones);
      Mercancias(data.Mercancias);
      FiguraTransporte(data.FiguraTransporte);
    }

    private static void Ubicacion(UbicacionList data)
    {
      if (data.Count == 0)
        return;

      for (int i = 0; i < data.Count; i++)
      {
        Ubicacion ubicacion = data[i];

        string title = $"CARTA PORTE - UBICACION - {i + 1}";

        Utils.ShowTitle(title);
        Utils.ShowField("TipoUbicacion              ", ubicacion.TipoUbicacion);
        Utils.ShowField("IdUbicacion                ", ubicacion.IdUbicacion);
        Utils.ShowField("RfcRemitenteDestinatario   ", ubicacion.RfcRemitenteDestinatario);
        Utils.ShowField("NombreRemitenteDestinatario", ubicacion.NombreRemitenteDestinatario);
        Utils.ShowField("IdTributario               ", ubicacion.IdTributario);
        Utils.ShowField("ResidenciaFiscal           ", ubicacion.ResidenciaFiscal);
        Utils.ShowField("NumeroEstacion             ", ubicacion.NumeroEstacion);
        Utils.ShowField("NombreEstacion             ", ubicacion.NombreEstacion);
        Utils.ShowField("NavegacionTrafico          ", ubicacion.NavegacionTrafico);
        Utils.ShowField("FechaHoraSalidaLlegada     ", ubicacion.FechaHoraSalidaLlegada);
        Utils.ShowField("TipoEstacion               ", ubicacion.TipoEstacion);
        Utils.ShowField("DistanciaRecorrida         ", ubicacion.DistanciaRecorrida);

        Utils.ShowTitle($"{title} - DOMICILIO");
        Domicilio(ubicacion.Domicilio);
      }
    }

    private static void Mercancias(Mercancias data)
    {
      Utils.ShowTitle("CARTA PORTE - MERCANCIAS");
      Utils.ShowField("PesoBrutoTotal                       ", data.PesoBrutoTotal);
      Utils.ShowField("UnidadPeso                           ", data.UnidadPeso);
      Utils.ShowField("PesoNetoTotal                        ", data.PesoNetoTotal);
      Utils.ShowField("NumeroTotalMercancias                ", data.NumeroTotalMercancias);
      Utils.ShowField("CargoPorTasacion                     ", data.CargoPorTasacion);
      Utils.ShowField("LogisticaInversaRecoleccionDevolucion", data.LogisticaInversaRecoleccionDevolucion);

      Mercancia(data.Mercancia);
      AutoTransporteFederal(data.AutoTransporteFederal);
      TransporteMaritimo(data.TransporteMaritimo);
      TransporteAereo(data.TransporteAereo);
      TransporteFerroviario(data.TransporteFerroviario);
    }

    private static void Mercancia(MercanciaList mercancia)
    {
      for (int i = 0; i < mercancia.Count; i++)
      {
        string title = $"CARTA PORTE - MERCANCIA {i + 1}";
         
        Mercancia data = mercancia[i];

        Utils.ShowTitle(title);
        Utils.ShowField("BienesTransportado                   ", data.BienesTransportado);
        Utils.ShowField("ClaveStcc                            ", data.ClaveStcc);
        Utils.ShowField("Descripcion                          ", data.Descripcion);
        Utils.ShowField("Cantidad                             ", data.Cantidad);
        Utils.ShowField("ClaveUnidad                          ", data.ClaveUnidad);
        Utils.ShowField("Unidad                               ", data.Unidad);
        Utils.ShowField("Dimensiones                          ", data.Dimensiones);
        Utils.ShowField("MaterialPeligroso                    ", data.MaterialPeligroso);
        Utils.ShowField("ClaveMaterialPeligroso               ", data.ClaveMaterialPeligroso);
        Utils.ShowField("Embalaje                             ", data.Embalaje);
        Utils.ShowField("DescripcionEmbalaje                  ", data.DescripcionEmbalaje);
        Utils.ShowField("SectorCofepris                       ", data.SectorCofepris);
        Utils.ShowField("NombreIngredienteActivo              ", data.NombreIngredienteActivo);
        Utils.ShowField("NombreQuimico                        ", data.NombreQuimico);
        Utils.ShowField("DenominacionGenericaProducto         ", data.DenominacionGenericaProducto);
        Utils.ShowField("DenominacionDistintivaProducto       ", data.DenominacionDistintivaProducto);
        Utils.ShowField("Fabricante                           ", data.Fabricante);
        Utils.ShowField("FechaCaducidad                       ", data.FechaCaducidad);
        Utils.ShowField("LoteMedicamento                      ", data.LoteMedicamento);
        Utils.ShowField("FormaFarmaceutica                    ", data.FormaFarmaceutica);
        Utils.ShowField("CondicionesEspecialesTransporte      ", data.CondicionesEspecialesTransporte);
        Utils.ShowField("RegistroSanitarioFolioAutorizacion   ", data.RegistroSanitarioFolioAutorizacion);
        Utils.ShowField("PermisoImportacion                   ", data.PermisoImportacion);
        Utils.ShowField("FolioImportacionVucem                ", data.FolioImportacionVucem);
        Utils.ShowField("NumeroCas                            ", data.NumeroCas);
        Utils.ShowField("RazonSocialEmpresaImportadora        ", data.RazonSocialEmpresaImportadora);
        Utils.ShowField("NumeroRegistroSanitarioPlagasCofepris", data.NumeroRegistroSanitarioPlagasCofepris);
        Utils.ShowField("DatosFabricante                      ", data.DatosFabricante);
        Utils.ShowField("DatosFormulador                      ", data.DatosFormulador);
        Utils.ShowField("DatosMaquilador                      ", data.DatosMaquilador);
        Utils.ShowField("UsoAutorizado                        ", data.UsoAutorizado);
        Utils.ShowField("PesoEnKilogramos                     ", data.PesoEnKilogramos);
        Utils.ShowField("ValorMercancia                       ", data.ValorMercancia);
        Utils.ShowField("Moneda                               ", data.Moneda);
        Utils.ShowField("FraccionArancelaria                  ", data.FraccionArancelaria);
        Utils.ShowField("UuidComercioExterior                 ", data.UuidComercioExterior);
        Utils.ShowField("TipoMateria                          ", data.TipoMateria);
        Utils.ShowField("DescripcionMateria                   ", data.DescripcionMateria);


        for (int j = 0; j < data.DocumentacionAduanera.Count; j++)
        {
          Utils.ShowTitle($"{title} - DOCUMENTACION ADUANERA {j + 1}");
          Utils.ShowField("TipoDocumento                 ", data.DocumentacionAduanera[j].TipoDocumento);
          Utils.ShowField("NumeroPedimento               ", data.DocumentacionAduanera[j].NumeroPedimento);
          Utils.ShowField("IdentificadorDocumentoAduanero", data.DocumentacionAduanera[j].IdentificadorDocumentoAduanero);
          Utils.ShowField("RfcImportador                 ", data.DocumentacionAduanera[j].RfcImportador);
        }

        for (int j = 0; j < data.GuiasIdentificacion.Count; j++)
        {
          Utils.ShowTitle($"{title} - GUIAS IDENTIFICACION {j + 1}");
          Utils.ShowField("Numero     ", data.GuiasIdentificacion[j].Numero);
          Utils.ShowField("Descripcion", data.GuiasIdentificacion[j].Descripcion);
          Utils.ShowField("Peso       ", data.GuiasIdentificacion[j].Peso);          
        }

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

    private static void AutoTransporteFederal(AutotransporteFederal data)
    {
      string title = "CARTA PORTE - AUTO TRANSPORTE FEDERAL";

      Utils.ShowTitle(title);
      Utils.ShowField("PermisoSct        ", data.PermisoSct);
      Utils.ShowField("NumeroPermisoSct  ", data.NumeroPermisoSct);
      
      Utils.ShowTitle($"{title} - IDENTIFICACION VEHICULAR");
      Utils.ShowField("ConfigVehicular   ", data.IdentificacionVehicular.ConfigVehicular);
      Utils.ShowField("PesoBrutoVehicular", data.IdentificacionVehicular.PesoBrutoVehicular);
      Utils.ShowField("Placa             ", data.IdentificacionVehicular.Placa);
      Utils.ShowField("AnioModelo        ", data.IdentificacionVehicular.AnioModelo);

      Utils.ShowTitle($"{title} - SEGUROS");
      Utils.ShowField("AseguradoraResponsabilidadCivil", data.Seguros.AseguradoraResponsabilidadCivil);
      Utils.ShowField("PolizaResponsabilidadCivil     ", data.Seguros.PolizaResponsabilidadCivil);
      Utils.ShowField("AseguradoraMedioAmbiente       ", data.Seguros.AseguradoraMedioAmbiente);
      Utils.ShowField("PolizaMedeioAmbiente           ", data.Seguros.PolizaMedeioAmbiente);
      Utils.ShowField("AseguradoraCarga               ", data.Seguros.AseguradoraCarga);
      Utils.ShowField("PolizaCarga                    ", data.Seguros.PolizaCarga);
      Utils.ShowField("PrimaSeguro                    ", data.Seguros.PrimaSeguro);
      
      for (int i = 0; i < data.Remolques.Count; i++)
      {
        Utils.ShowTitle($"{title} - REMOLQUE {i + 1}");
        Utils.ShowField("SubTipo", data.Remolques[i].SubTipo);
        Utils.ShowField("Placa  ", data.Remolques[i].Placa);        
      }
    }

    private static void TransporteMaritimo(TransporteMaritimo data)
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
      Utils.ShowField("Eslora                       ", data.Eslora);
      Utils.ShowField("Manga                        ", data.Manga);
      Utils.ShowField("Calado                       ", data.Calado);
      Utils.ShowField("Puntal                       ", data.Puntal);
      Utils.ShowField("LineaNaviera                 ", data.LineaNaviera);
      Utils.ShowField("NombreAgenteNaviero          ", data.NombreAgenteNaviero);
      Utils.ShowField("NumeroAutorizacionNaviero    ", data.NumeroAutorizacionNaviero);
      Utils.ShowField("NumeroViaje                  ", data.NumeroViaje);
      Utils.ShowField("NumeroConocimientoEmbarcacion", data.NumeroConocimientoEmbarcacion);
      Utils.ShowField("PermisoTemporalNavegacion    ", data.PermisoTemporalNavegacion);

      for (int i = 0; i < data.Contenedores.Count; i++)
      {
        Utils.ShowTitle($"{Title} - CONTENEDOR {i + 1}");
        Utils.ShowField("TipoContenedor       ", data.Contenedores[i].TipoContenedor);
        Utils.ShowField("MatriculaContenedor  ", data.Contenedores[i].MatriculaContenedor);
        Utils.ShowField("NumeroPrecinto       ", data.Contenedores[i].NumeroPrecinto);
        Utils.ShowField("IdCcpRelacionado     ", data.Contenedores[i].IdCcpRelacionado);
        Utils.ShowField("PlacaVmccp           ", data.Contenedores[i].PlacaVmccp);
        Utils.ShowField("FechaCertificacionCcp", data.Contenedores[i].FechaCertificacionCcp);
      }

      for (int i = 0; i < data.RemolquesCcp.Count; i++)
      {
        Utils.ShowTitle($"{Title} - REMOLQUE CCP {i + 1}");
        Utils.ShowField("SubTipoRemolqueCcp", data.RemolquesCcp[i].SubTipoRemolqueCcp);
        Utils.ShowField("PlacaCcp          ", data.RemolquesCcp[i].PlacaCcp);        
      }
    }

    private static void TransporteAereo(TransporteAereo data)
    {
      Utils.ShowTitle("CARTA PORTE - TRANSPORTE AEREO");
      Utils.ShowField("PermisoSct                ", data.PermisoSct);
      Utils.ShowField("NumeroPermisoSct          ", data.NumeroPermisoSct);
      Utils.ShowField("MatriculaAeronave         ", data.MatriculaAeronave);
      Utils.ShowField("NombreAseguradora         ", data.NombreAseguradora);
      Utils.ShowField("NumeroPolizaSeguro        ", data.NumeroPolizaSeguro);
      Utils.ShowField("NumeroGuia                ", data.NumeroGuia);
      Utils.ShowField("LugarContrato             ", data.LugarContrato);
      Utils.ShowField("CodigoTransportista       ", data.CodigoTransportista);
      Utils.ShowField("RfcEmbarcador             ", data.RfcEmbarcador);
      Utils.ShowField("IdTributarioEmbarcador    ", data.IdTributarioEmbarcador);
      Utils.ShowField("ResidenciaFiscalEmbarcador", data.ResidenciaFiscalEmbarcador);
      Utils.ShowField("NombreEmbarcador          ", data.NombreEmbarcador);
    }

    private static void TransporteFerroviario(TransporteFerroviario data)
    {
      const string Title = "CARTA PORTE - TRANSPORTE FERROVIARIO";

      Utils.ShowTitle(Title);
      Utils.ShowField("TipoServicio      ", data.TipoServicio);
      Utils.ShowField("TipoTrafico       ", data.TipoTrafico);
      Utils.ShowField("NombreAseguradora ", data.NombreAseguradora);
      Utils.ShowField("NumeroPolizaSeguro", data.NumeroPolizaSeguro);

      for (int i = 0; i < data.DerechosPaso.Count; i++)
      {
        Utils.ShowTitle($"{Title} - DERECHO DE PASO {i + 1}");
        Utils.ShowField("TipoDerecho      ", data.DerechosPaso[i].TipoDerecho);
        Utils.ShowField("KilometrajePagado", data.DerechosPaso[i].KilometrajePagado);        
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
          Utils.ShowField("TipoContenedor     ", carro.Contenedores[j].TipoContenedor);
          Utils.ShowField("PesoContenedorVacio", carro.Contenedores[j].PesoContenedorVacio);
          Utils.ShowField("PesoNetoMercancia  ", carro.Contenedores[j].PesoNetoMercancia);
        }
      }
    }

    private static void FiguraTransporte(FiguraTransporte data)
    {
      const string Title = "CARTA PORTE - FIGURA TRANSPORTE";

      for (int i = 0; i < data.TiposFigura.Count; i++)
      {
        string subTitle = $"{Title} - TIPOSFIGURA {i + 1}";
        Utils.ShowTitle(subTitle);

        TipoFigura tipoFigura = data.TiposFigura[i];
        Utils.ShowField("Tipo            ", tipoFigura.Tipo);
        Utils.ShowField("Rfc             ", tipoFigura.Rfc);
        Utils.ShowField("NumeroLicencia  ", tipoFigura.NumeroLicencia);
        Utils.ShowField("Nombre          ", tipoFigura.Nombre);
        Utils.ShowField("IdTtributario   ", tipoFigura.IdTtributario);
        Utils.ShowField("ResidenciaFiscal", tipoFigura.ResidenciaFiscal);

        for (int j = 0; j < tipoFigura.PartesTransporte.Count; j++)
        {
          string subTitle2 = $"{subTitle} - PARTESTRANSPORTE {j + 1}";

          Utils.ShowTitle(subTitle2);
          Utils.ShowField("Parte", tipoFigura.PartesTransporte[j].Parte);
        }

        Utils.ShowTitle($"{subTitle} - DOMICILIO");
        Domicilio(tipoFigura.Domicilio);
      }
    }

    private static void Domicilio(Domicilio data)
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