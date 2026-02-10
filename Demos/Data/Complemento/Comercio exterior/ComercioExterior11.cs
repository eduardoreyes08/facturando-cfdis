using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ComercioExterior11
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      // Se agrega el complemento COMERCIO EXTERIOR.
      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.1";
      data.MotivoTraslado.Value = "01";
      data.TipoOperacion.Value = "2";
      data.ClavePedimento.Value = "A1";
      data.CertificadoOrigen.Value = 0;
      data.NumeroCertificadoOrigen.Value = "aaaaaa";
      data.NumeroExportadorConfiable.Value = "a";
      data.Incoterm.Value = "CFR";
      data.SubDivision.Value = 0;
      data.Observaciones.Value = "a";
      data.TipoCambioUsd.Value = 1;
      data.TotalUsd.Value = 2;

      data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Emisor.Domicilio.Calle.Value = "a";
      data.Emisor.Domicilio.Pais.Value = "AFG";
      data.Emisor.Domicilio.Colonia.Value = "0001";
      data.Emisor.Domicilio.Municipio.Value = "001";
      data.Emisor.Domicilio.Referencia.Value = "a";
      data.Emisor.Domicilio.Estado.Value = "AGU";
      data.Emisor.Domicilio.NumeroExterior.Value = "a";
      data.Emisor.Domicilio.Localidad.Value = "01";
      data.Emisor.Domicilio.NumeroInterior.Value = "a";
      data.Emisor.Domicilio.CodigoPostal.Value = "01000";

      data.Receptor.NumeroRegistroTributario.Value = "aaaaaa";
      data.Receptor.Domicilio.Calle.Value = "a";
      data.Receptor.Domicilio.Pais.Value = "AFG";
      data.Receptor.Domicilio.Colonia.Value = "0001";
      data.Receptor.Domicilio.Municipio.Value = "001";
      data.Receptor.Domicilio.Referencia.Value = "a";
      data.Receptor.Domicilio.Estado.Value = "AGU";
      data.Receptor.Domicilio.NumeroExterior.Value = "a";
      data.Receptor.Domicilio.Localidad.Value = "01";
      data.Receptor.Domicilio.NumeroInterior.Value = "a";
      data.Receptor.Domicilio.CodigoPostal.Value = "01000";

      Destinatario destinatario = data.Destinatarios.Add();
      destinatario.NumeroRegistroTributario.Value = "aaaaaa";
      destinatario.Rfc.Value = "AAA010101AAA";

      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Domicilio domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "a";
      domicilio.Pais.Value = "AFG";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "a";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "a";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "a";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "a";
      domicilio.Pais.Value = "AFG";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "a";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "a";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "a";
      domicilio.CodigoPostal.Value = "01000";

      destinatario = data.Destinatarios.Add();
      destinatario.NumeroRegistroTributario.Value = "aaaaaa";
      destinatario.Rfc.Value = "AAA010101AAA";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "a";
      domicilio.Pais.Value = "AFG";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "a";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "a";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "a";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "a";
      domicilio.Pais.Value = "AFG";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "a";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "a";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "a";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "a";
      domicilio.Pais.Value = "AFG";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "a";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "a";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "a";
      domicilio.CodigoPostal.Value = "01000";

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "a";
      mercancia.ValorUnitarioAduana.Value = 0;
      mercancia.UnidadAduana.Value = "01";
      mercancia.CantidadAduana.Value = 1;
      mercancia.ValorDolares.Value = 1;

      DescripcionEspecifica descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "a";
      descripcionEspecifica.NumeroSerie.Value = "a";
      descripcionEspecifica.Modelo.Value = "a";
      descripcionEspecifica.Marca.Value = "a";

      descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "b";
      descripcionEspecifica.NumeroSerie.Value = "b";
      descripcionEspecifica.Modelo.Value = "b";
      descripcionEspecifica.Marca.Value = "b";

      mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "a";
      mercancia.ValorUnitarioAduana.Value = 0;
      mercancia.UnidadAduana.Value = "01";
      mercancia.CantidadAduana.Value = 1;
      mercancia.ValorDolares.Value = 1;

      return Base.Save(electronicDocument, "ComercioExterior11.xml", out fileName);
    }
  }
}