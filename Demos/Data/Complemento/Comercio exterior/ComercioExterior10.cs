using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  internal static class ComercioExterior10
  {
    internal static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TipoOperacion.Value = "A";
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

      data.Receptor.NumeroRegistroTributario.Value = "aaaaaa";
      data.Receptor.Curp.Value = "UXBA000419HYNVRDA3";

      data.Destinatario.NumeroRegistroTributario.Value = "aaaaaa";
      data.Destinatario.Nombre.Value = "a";
      data.Destinatario.Curp.Value = "UXBA000419HYNVRDA3";
      data.Destinatario.Rfc.Value = "AAA010101AAA";

      data.Destinatario.Domicilio.Calle.Value = "a";
      data.Destinatario.Domicilio.Pais.Value = "AFG";
      data.Destinatario.Domicilio.Colonia.Value = "a";
      data.Destinatario.Domicilio.Municipio.Value = "a";
      data.Destinatario.Domicilio.Referencia.Value = "a";
      data.Destinatario.Domicilio.Estado.Value = "a";
      data.Destinatario.Domicilio.NumeroExterior.Value = "a";
      data.Destinatario.Domicilio.Localidad.Value = "a";
      data.Destinatario.Domicilio.NumeroInterior.Value = "a";
      data.Destinatario.Domicilio.CodigoPostal.Value = "a";

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "a";
      mercancia.ValorUnitarioAduana.Value = 0;
      mercancia.UnidadAduana.Value = "1";
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
      mercancia.UnidadAduana.Value = "1";
      mercancia.CantidadAduana.Value = 1;
      mercancia.ValorDolares.Value = 1;

      return Base.Save(electronicDocument, "ComercioExterior10.xml", out fileName);
    }
  }
}