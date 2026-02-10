using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.CartaPorte;
using HyperSoft.ElectronicDocumentLibrary.Document;

// ReSharper disable RedundantNameQualifier

namespace HyperSoft.Ejemplo.Data.Complemento.CartaPorte
{
  public static class Autotransporte
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
      FillFiguraTransporte(data.FiguraTransporte);
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
//      ubicacion.TipoEstacion.Value = "01";

      // Registro de la información del domicilio de origen y/o destino de los bienes o mercancías
      // que se trasladan en los distintos medios de transporte.
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
//      ubicacion.TipoEstacion.Value = "01";
      ubicacion.DistanciaRecorrida.Value = 1000;

      // Registro de la información del domicilio de origen y/o destino de los bienes o mercancías
      // que se trasladan en los distintos medios de transporte.
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
      data.LogisticaInversaRecoleccionDevolucion.Value = "Sí";

      FillMercancia(data.Mercancia);
      FillAutoTransporte(data.AutoTransporteFederal);
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

    private static void FillDocumentacionAduanera(DocumentacionAduaneraList data)
    {
      DocumentacionAduanera documentacionAduanera = data.Add();
      documentacionAduanera.TipoDocumento.Value = "01";
      documentacionAduanera.NumeroPedimento.Value = "21  24  1772  3000244";
      documentacionAduanera.RfcImportador.Value = "AAAD770905441";
    }

    private static void FillCantidadTransporta(CantidadTransportaList data)
    {
      CantidadTransporta cantidadTransporta = data.Add();
      cantidadTransporta.Cantidad.Value = 1;
      cantidadTransporta.IdOrigen.Value = "OR000123";
      cantidadTransporta.IdDestino.Value = "DE000100";
    }

    private static void FillAutoTransporte(AutotransporteFederal data)
    {
      // Registro de la información que permita la identificación del autotransporte de carga federal,
      // por medio del cual se transportan los bienes o mercancías, que transitan a través de las carreteras federales del territorio nacional.
      data.PermisoSct.Value = "TPAF01";
      data.NumeroPermisoSct.Value = "156425154";

      data.IdentificacionVehicular.ConfigVehicular.Value = "C2R2";
      data.IdentificacionVehicular.PesoBrutoVehicular.Value = 100;
      data.IdentificacionVehicular.Placa.Value = "EVM2233";
      data.IdentificacionVehicular.AnioModelo.Value = 2020;

      data.Seguros.AseguradoraResponsabilidadCivil.Value = "Qualitas";
      data.Seguros.PolizaResponsabilidadCivil.Value = "33-1051452";
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

    private static void FillFiguraTransporte(FiguraTransporte data)
    {
      // Para indicar los datos de la figura del transporte que interviene en el traslado de los bienes o mercancías,
      // cuando el dueño del medio de transporte es diferente del emisor del comprobante con el complemento carta porte.

      FillTiposFigura(data.TiposFigura);
    }

    private static void FillTiposFigura(TiposFigura data)
    {
      TipoFigura tipoFigura = data.Add();
      tipoFigura.Tipo.Value = "01";
      tipoFigura.Rfc.Value = "AAAD770905441";
      tipoFigura.NumeroLicencia.Value = "15245125485";
      tipoFigura.Nombre.Value = "Carlos Perez";

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
