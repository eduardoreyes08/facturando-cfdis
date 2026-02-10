using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;
using HyperSoft.ElectronicDocumentLibrary.Document;

// ReSharper disable RedundantNameQualifier
namespace HyperSoft.Ejemplo.Data.Complemento.CartaPorte
{
  public static class Completo
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
      data.EntradaSalidaMercancia.Value = "Entrada";
      data.PaisOrigenDestino.Value = "USA";
      data.ViaEntradaSalida.Value = "01";
      data.TotalDistanciaRecorrida.Value = 1000;
      data.RegistroIstmo.Value = "Sí";
      data.UbicacionPoloOrigen.Value = "01";
      data.UbicacionPoloDestino.Value = "02";

      FillRegimenesAduaneros(data.RegimenesAduaneros);
      FillUbicacion(data.Ubicaciones);
      FillMercancias(data.Mercancias);
      FillFiguraTransporte(data.FiguraTransporte);
    }

    private static void FillRegimenesAduaneros(RegimenesAduaneros data)
    {
      data.Add().RegimenAduanero.Value = "IMD";
    }

    private static void FillUbicacion(UbicacionList data)
    {
      Ubicacion ubicacion = data.Add();

      ubicacion.TipoUbicacion.Value = "Origen";
      ubicacion.IdUbicacion.Value = "OR000123";
      ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
      ubicacion.NombreRemitenteDestinatario.Value = "Juan Fernandez";
      ubicacion.IdTributario.Value = "IdTributario";
      ubicacion.ResidenciaFiscal.Value = "MEX";
      ubicacion.NumeroEstacion.Value = "PM001";
      ubicacion.NombreEstacion.Value = "NombreEstacionO";
      ubicacion.NavegacionTrafico.Value = "Altura";
      ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;
      ubicacion.TipoEstacion.Value = "01";
      ubicacion.DistanciaRecorrida.Value = 1;

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
      ubicacion.IdUbicacion.Value = "DE000123";
      ubicacion.RfcRemitenteDestinatario.Value = "TUCA2107035N9";
      ubicacion.NombreRemitenteDestinatario.Value = "Juan Fernandez";
      ubicacion.IdTributario.Value = "IdTributario";
      ubicacion.ResidenciaFiscal.Value = "MEX";
      ubicacion.NumeroEstacion.Value = "PM001";
      ubicacion.NombreEstacion.Value = "NombreEstacionD";
      ubicacion.NavegacionTrafico.Value = "Altura";
      ubicacion.FechaHoraSalidaLlegada.Value = DateTime.Now;
      ubicacion.TipoEstacion.Value = "01";
      ubicacion.DistanciaRecorrida.Value = 1;

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
      data.PesoBrutoTotal.Value = 3;
      data.UnidadPeso.Value = "Tu";
      data.PesoNetoTotal.Value = 3;
      data.NumeroTotalMercancias.Value = 1;
      data.CargoPorTasacion.Value = 1;
      data.LogisticaInversaRecoleccionDevolucion.Value = "Sí";

      FillMercancia(data.Mercancia);
      FillAutoTransporte(data.AutoTransporteFederal);
      FillTransporteMaritimo(data.TransporteMaritimo);
      FillTransporteAereo(data.TransporteAereo);
      FillTransporteFerroviario(data.TransporteFerroviario);
    }

    private static void FillMercancia(MercanciaList data)
    {
      Mercancia mercancia = data.Add();

      mercancia.BienesTransportado.Value = "10101500";
      mercancia.ClaveStcc.Value = "010132";
      mercancia.Descripcion.Value = "Descripcion";
      mercancia.Cantidad.Value = 1;
      mercancia.ClaveUnidad.Value = "A34";
      mercancia.Unidad.Value = "Pieza";
      mercancia.Dimensiones.Value = "10/10/10cm";
      mercancia.MaterialPeligroso.Value = "No";
      mercancia.ClaveMaterialPeligroso.Value = "M0001";
      mercancia.Embalaje.Value = "1A1";
      mercancia.DescripcionEmbalaje.Value = "DescripcionEmbalaje";
      mercancia.SectorCofepris.Value = "01";
      mercancia.NombreIngredienteActivo.Value = "Nombre";
      mercancia.NombreQuimico.Value = "Nombre químico";
      mercancia.DenominacionGenericaProducto.Value = "Denominación genérica";
      mercancia.DenominacionDistintivaProducto.Value = "Denominación distintiva";
      mercancia.Fabricante.Value = "Fabricante";
      mercancia.FechaCaducidad.Value = DateTime.Now;
      mercancia.LoteMedicamento.Value = "Lote";
      mercancia.FormaFarmaceutica.Value = "01";
      mercancia.CondicionesEspecialesTransporte.Value = "01";
      mercancia.RegistroSanitarioFolioAutorizacion.Value = "123456789012345";
      mercancia.PermisoImportacion.Value = "123456";
      mercancia.FolioImportacionVucem.Value = "1234567890123456789012345";
      mercancia.NumeroCas.Value = "123456789012345";
      mercancia.RazonSocialEmpresaImportadora.Value = "Nombre importadora";
      mercancia.NumeroRegistroSanitarioPlagasCofepris.Value = "Número registro sanitario Cofepris";
      mercancia.DatosFabricante.Value = "Datos fabricante";
      mercancia.DatosFormulador.Value = "Datos formulador";
      mercancia.DatosMaquilador.Value = "Datos maquilador";
      mercancia.UsoAutorizado.Value = "Uso autorizado";
      mercancia.PesoEnKilogramos.Value = 3;
      mercancia.ValorMercancia.Value = 1;
      mercancia.Moneda.Value = "MXN";
      mercancia.FraccionArancelaria.Value = "0101210100";
      mercancia.UuidComercioExterior.Value = "74E2925B-5000-408D-8A9E-3A86BB0DFE18";
      mercancia.TipoMateria.Value = "01";
      mercancia.DescripcionMateria.Value = "Descripción materia";

      FillDocumentacionAduanera(mercancia.DocumentacionAduanera);
      FillGuiasIdentificacion(mercancia.GuiasIdentificacion);
      FillCantidadTransporta(mercancia.CantidadTransporta);
      FillDetalleMercancia(mercancia.DetalleMercancia);
    }

    private static void FillDocumentacionAduanera(DocumentacionAduaneraList data)
    {
      DocumentacionAduanera documentacionAduanera = data.Add();
      documentacionAduanera.TipoDocumento.Value = "01";
      documentacionAduanera.NumeroPedimento.Value = "21  24  1772  3000244";
      documentacionAduanera.IdentificadorDocumentoAduanero.Value = "Identificador";
      documentacionAduanera.RfcImportador.Value = "AAA010101AAA";
    }

    private static void FillGuiasIdentificacion(GuiasIdentificacion data)
    {
      GuiaIdentificacion guia = data.Add();
      guia.Numero.Value = "1548528485";
      guia.Descripcion.Value = "Guia 1";
      guia.Peso.Value = 3;
    }

    private static void FillCantidadTransporta(CantidadTransportaList data)
    {
      CantidadTransporta cantidadTransporta = data.Add();
      cantidadTransporta.Cantidad.Value = 1;
      cantidadTransporta.IdOrigen.Value = "OR000000";
      cantidadTransporta.IdDestino.Value = "DE000000";
      cantidadTransporta.ClaveTransporte.Value = "05";
    }

    private static void FillDetalleMercancia(DetalleMercancia data)
    {
      data.UnidadPeso.Value = "X1A";
      data.PesoBruto.Value = 1;
      data.PesoNeto.Value = 1;
      data.PesoTara.Value = 1;
      data.NumeroPiezas.Value = 1;
    }

    private static void FillAutoTransporte(AutotransporteFederal data)
    {
      data.PermisoSct.Value = "TPAF01";
      data.NumeroPermisoSct.Value = "156425154";

      data.IdentificacionVehicular.ConfigVehicular.Value = "C2R2";
      data.IdentificacionVehicular.PesoBrutoVehicular.Value = 100;
      data.IdentificacionVehicular.Placa.Value = "EVM2233";
      data.IdentificacionVehicular.AnioModelo.Value = 2020;

      data.Seguros.AseguradoraResponsabilidadCivil.Value = "Qualitas";
      data.Seguros.PolizaResponsabilidadCivil.Value = "33-1051452";
      data.Seguros.AseguradoraMedioAmbiente.Value = "Banorte";
      data.Seguros.PolizaMedeioAmbiente.Value = "854891554";
      data.Seguros.AseguradoraCarga.Value = "GNP";
      data.Seguros.PolizaCarga.Value = "8485755548418";
      data.Seguros.PrimaSeguro.Value = 500000;

      Remolque remolque = data.Remolques.Add();
      remolque.SubTipo.Value = "CTR004";
      remolque.Placa.Value = "ABC5458";

      remolque = data.Remolques.Add();
      remolque.SubTipo.Value = "CTR003";
      remolque.Placa.Value = "ABT5459";
    }

    private static void FillTransporteMaritimo(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteMaritimo data)
    {
      data.PermisoSct.Value = "TPAF01";
      data.NumeroPermisoSct.Value = "845847858";
      data.NombreAseguradora.Value = "Qualitas";
      data.NumeroPolizaSeguro.Value = "854891554";
      data.TipoEmbarcacion.Value = "B03";
      data.Matricula.Value = "E584785";
      data.NumeroOmi.Value = "IMO5448589";
      data.AnioEmbarcacion.Value = 2020;
      data.NombreEmbarcacion.Value = "Zoa";
      data.NacionalidadEmbarcacion.Value = "MEX";
      data.UnidadesArqueoBruto.Value = 35;
      data.TipoCarga.Value = "CGC";
      //data.NumeroCertificadoItc.Value = "585544855";
      data.Eslora.Value = 20;
      data.Manga.Value = 20;
      data.Calado.Value = 20;
      data.Puntal.Value = 10;
      data.LineaNaviera.Value = "1315548554";
      data.NombreAgenteNaviero.Value = "ExpressNav";
      data.NumeroAutorizacionNaviero.Value = "SCT418/020/2016";
      data.NumeroViaje.Value = "1.00";
      data.NumeroConocimientoEmbarcacion.Value = "30.00";
      data.PermisoTemporalNavegacion.Value = "1234567890123456789";

      FillContenedor(data);
    }

    private static void FillContenedor(ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteMaritimo data)
    {
      Contenedor contenedor = data.Contenedores.Add();
      contenedor.TipoContenedor.Value = "CM002";
      contenedor.MatriculaContenedor.Value = "15145878584";
      contenedor.NumeroPrecinto.Value = "15485";
      contenedor.IdCcpRelacionado.Value = "CCC00000-0000-0000-0000-000000000000";
      contenedor.PlacaVmccp.Value = "A1234";
      contenedor.FechaCertificacionCcp.Value = DateTime.Now;

      RemolqueCcp remolqueCcp = contenedor.RemolquesCcp.Add();
      remolqueCcp.SubTipoRemolqueCcp.Value = "CTR001";
      remolqueCcp.PlacaCcp.Value = "A1234";
    }

    private static void FillTransporteAereo(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteAereo data)
    {
      data.PermisoSct.Value = "TPAF01";
      data.NumeroPermisoSct.Value = "10000002";
      data.MatriculaAeronave.Value = "515425";
      data.NombreAseguradora.Value = "Qualitas";
      data.NumeroPolizaSeguro.Value = "854891554";
      data.NumeroGuia.Value = "5145878585985";
      data.LugarContrato.Value = "México ESC";
      data.CodigoTransportista.Value = "CA003";
      data.RfcEmbarcador.Value = "TCM970625MB1";
      data.IdTributarioEmbarcador.Value = "IdTtributario";
      data.ResidenciaFiscalEmbarcador.Value = "MEX";
      data.NombreEmbarcador.Value = "Rai Nta";
    }

    private static void FillTransporteFerroviario(HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte.TransporteFerroviario data)
    {
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
      contenedor.PesoNetoMercancia.Value = 3;
    }

    private static void FillFiguraTransporte(FiguraTransporte data)
    {
      FillTiposFigura(data.TiposFigura);
    }

    private static void FillTiposFigura(TiposFigura data)
    {
      TipoFigura tipoFigura = data.Add();
      tipoFigura.Tipo.Value = "01";
      tipoFigura.Rfc.Value = "TUCA2107035N9";
      tipoFigura.NumeroLicencia.Value = "15245125485";
      tipoFigura.Nombre.Value = "Carlos Perez";
      tipoFigura.IdTtributario.Value = "IdTtributario";
      tipoFigura.ResidenciaFiscal.Value = "MEX";

      ParteTransporte parte = tipoFigura.PartesTransporte.Add();
      parte.Parte.Value = "PT01";

      tipoFigura.Domicilio.Calle.Value = "Segunda";
      tipoFigura.Domicilio.NumeroExterior.Value = "1";
      tipoFigura.Domicilio.NumeroInterior.Value = "B";
      tipoFigura.Domicilio.Colonia.Value = "0001";
      tipoFigura.Domicilio.Localidad.Value = "01";
      tipoFigura.Domicilio.Referencia.Value = "Interior";
      tipoFigura.Domicilio.Municipio.Value = "001";
      tipoFigura.Domicilio.Estado.Value = "CO";
      tipoFigura.Domicilio.Pais.Value = "USA";
      tipoFigura.Domicilio.CodigoPostal.Value = "20000";
    }
  }
}