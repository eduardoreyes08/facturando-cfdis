using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class ComercioExterior20
  {
    public static void Timbrado(ElectronicDocument electronicDocument)
    {
      //En este método se cargan los datos de la factura.
      CargarDatosCfdi(electronicDocument.Data);

      // Se agrega el complemento COMERCIO EXTERIOR.
      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "2.0";
      data.ClavePedimento.Value = "A1";
      data.CertificadoOrigen.Value = 1;
      data.NumeroCertificadoOrigen.Value = "A569874-35";
      data.Incoterm.Value = "FCA";
      data.Observaciones.Value = "Observaciones";
      data.TipoCambioUsd.Value = 17.295700;
      data.TipoCambioUsd.Decimals = 6;
      data.TotalUsd.Value = 100.00;

      data.Emisor.Domicilio.Calle.Value = "Hidalgo";
      data.Emisor.Domicilio.Pais.Value = "MEX";
      data.Emisor.Domicilio.Colonia.Value = "0919";
      data.Emisor.Domicilio.Municipio.Value = "015";
      data.Emisor.Domicilio.Referencia.Value = "Referencia";
      data.Emisor.Domicilio.Estado.Value = "CMX";
      data.Emisor.Domicilio.NumeroExterior.Value = "18";
      data.Emisor.Domicilio.Localidad.Value = "06";
      data.Emisor.Domicilio.NumeroInterior.Value = "3";
      data.Emisor.Domicilio.CodigoPostal.Value = "06500";

      data.Receptor.Domicilio.Calle.Value = "Allende";
      data.Receptor.Domicilio.Pais.Value = "MEX";
      data.Receptor.Domicilio.Colonia.Value = "0919";
      data.Receptor.Domicilio.Municipio.Value = "015";
      data.Receptor.Domicilio.Referencia.Value = "Referencia";
      data.Receptor.Domicilio.Estado.Value = "CMX";
      data.Receptor.Domicilio.NumeroExterior.Value = "18";
      data.Receptor.Domicilio.Localidad.Value = "06";
      data.Receptor.Domicilio.NumeroInterior.Value = "3";
      data.Receptor.Domicilio.CodigoPostal.Value = "06500";

      Destinatario destinatario = data.Destinatarios.Add();
      destinatario.Nombre.Value = "Destinatario 1";

      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Domicilio domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Morelos";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0919";
      domicilio.Municipio.Value = "015";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "CMX";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "06";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "06500";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Juárez";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0919";
      domicilio.Municipio.Value = "015";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "CMX";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "06";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "06500";

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "0101299999";
      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorUnitarioAduana.Value = 100;
      mercancia.UnidadAduana.Value = "06";
      mercancia.CantidadAduana.Value = 1;
      mercancia.ValorDolares.Value = 100.00;

      DescripcionEspecifica descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A54";
      descripcionEspecifica.NumeroSerie.Value = "TA-1045";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";
    }

    public static bool Completo(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      // Se agrega el complemento COMERCIO EXTERIOR.
      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "2.0";
      data.MotivoTraslado.Value = "01";
      data.ClavePedimento.Value = "A1";
      data.CertificadoOrigen.Value = 1;
      data.NumeroCertificadoOrigen.Value = "A569874-35";
      data.NumeroExportadorConfiable.Value = "A569874-35";
      data.Incoterm.Value = "FCA";
      data.Observaciones.Value = "Observaciones";
      data.TipoCambioUsd.Value = 1;
      data.TotalUsd.Value = 2;

      data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Emisor.Domicilio.Calle.Value = "Hidalgo";
      data.Emisor.Domicilio.Pais.Value = "MEX";
      data.Emisor.Domicilio.Colonia.Value = "0001";
      data.Emisor.Domicilio.Municipio.Value = "001";
      data.Emisor.Domicilio.Referencia.Value = "Referencia";
      data.Emisor.Domicilio.Estado.Value = "AGU";
      data.Emisor.Domicilio.NumeroExterior.Value = "18";
      data.Emisor.Domicilio.Localidad.Value = "01";
      data.Emisor.Domicilio.NumeroInterior.Value = "3";
      data.Emisor.Domicilio.CodigoPostal.Value = "01000";

      Propietario propietario = data.Propietarios.Add();
      propietario.NumeroRegistroTributario.Value = "1321554";
      propietario.ResidenciaFiscal.Value = "USA";

      data.Receptor.NumeroRegistroTributario.Value = "756985236";
      data.Receptor.Domicilio.Calle.Value = "Allende";
      data.Receptor.Domicilio.Pais.Value = "MEX";
      data.Receptor.Domicilio.Colonia.Value = "0001";
      data.Receptor.Domicilio.Municipio.Value = "001";
      data.Receptor.Domicilio.Referencia.Value = "Referencia";
      data.Receptor.Domicilio.Estado.Value = "AGU";
      data.Receptor.Domicilio.NumeroExterior.Value = "18";
      data.Receptor.Domicilio.Localidad.Value = "01";
      data.Receptor.Domicilio.NumeroInterior.Value = "3";
      data.Receptor.Domicilio.CodigoPostal.Value = "01000";

      Destinatario destinatario = data.Destinatarios.Add();
      destinatario.NumeroRegistroTributario.Value = "756985237";
      destinatario.Nombre.Value = "Destinatario 1";

      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Domicilio domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Morelos";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Juárez";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      destinatario = data.Destinatarios.Add();
      destinatario.NumeroRegistroTributario.Value = "756985238";
      destinatario.Nombre.Value = "Destinatario 2";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Morelos";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Juárez";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Madero";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorUnitarioAduana.Value = 7896.26;
      mercancia.UnidadAduana.Value = "01";
      mercancia.CantidadAduana.Value = 5465.051;
      mercancia.ValorDolares.Value = 1;

      DescripcionEspecifica descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A54";
      descripcionEspecifica.NumeroSerie.Value = "TA-1045";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";

      descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A65";
      descripcionEspecifica.NumeroSerie.Value = "TA-1065";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";

      mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorUnitarioAduana.Value = 7896.26;
      mercancia.UnidadAduana.Value = "01";
      mercancia.CantidadAduana.Value = 5465.051;
      mercancia.ValorDolares.Value = 1;

      return Base.Save(electronicDocument, "ComercioExterior20_Completo.xml", out fileName);
    }

    public static bool Minimo(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      // Se agrega el complemento COMERCIO EXTERIOR.
      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "2.0";
      data.ClavePedimento.Value = "A1";
      data.CertificadoOrigen.Value = 1;
      data.TipoCambioUsd.Value = 1;
      data.TotalUsd.Value = 2;

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorDolares.Value = 1;

      return Base.Save(electronicDocument, "ComercioExterior20_Minimo.xml", out fileName);
    }

    public static bool MinimoAtributos(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      // Se agrega el complemento COMERCIO EXTERIOR.
      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "2.0";
      data.ClavePedimento.Value = "A1";
      data.CertificadoOrigen.Value = 1;
      data.TipoCambioUsd.Value = 1;
      data.TotalUsd.Value = 2;

      data.Emisor.Domicilio.Calle.Value = "Hidalgo";
      data.Emisor.Domicilio.Pais.Value = "MEX";
      data.Emisor.Domicilio.Estado.Value = "AGU";
      data.Emisor.Domicilio.CodigoPostal.Value = "01000";

      Propietario propietario = data.Propietarios.Add();
      propietario.NumeroRegistroTributario.Value = "1321554";
      propietario.ResidenciaFiscal.Value = "USA";

      data.Receptor.Domicilio.Calle.Value = "Allende";
      data.Receptor.Domicilio.Pais.Value = "MEX";
      data.Receptor.Domicilio.Estado.Value = "AGU";
      data.Receptor.Domicilio.CodigoPostal.Value = "01000";

      Destinatario destinatario = data.Destinatarios.Add();

      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Domicilio domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Morelos";
      domicilio.Pais.Value = "MEX";
      domicilio.Estado.Value = "AGU";
      domicilio.CodigoPostal.Value = "01000";

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorDolares.Value = 1;

      DescripcionEspecifica descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.Marca.Value = "Samsung";

      return Base.Save(electronicDocument, "ComercioExterior20_Minimo_Atributos.xml", out fileName);
    }

    public static bool Listas(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      // Se agrega el complemento COMERCIO EXTERIOR.
      electronicDocument.Data.Complementos.Add(ComplementoType.ComercioExterior);
      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "2.0";
      data.MotivoTraslado.Value = "01";
      data.ClavePedimento.Value = "A1";
      data.CertificadoOrigen.Value = 1;
      data.NumeroCertificadoOrigen.Value = "A569874-35";
      data.NumeroExportadorConfiable.Value = "A569874-35";
      data.Incoterm.Value = "FCA";
      data.Observaciones.Value = "Observaciones";
      data.TipoCambioUsd.Value = 1;
      data.TotalUsd.Value = 2;

      data.Emisor.Curp.Value = "UXBA000419HYNVRDA3";
      data.Emisor.Domicilio.Calle.Value = "Hidalgo";
      data.Emisor.Domicilio.Pais.Value = "MEX";
      data.Emisor.Domicilio.Colonia.Value = "0001";
      data.Emisor.Domicilio.Municipio.Value = "001";
      data.Emisor.Domicilio.Referencia.Value = "Referencia";
      data.Emisor.Domicilio.Estado.Value = "AGU";
      data.Emisor.Domicilio.NumeroExterior.Value = "18";
      data.Emisor.Domicilio.Localidad.Value = "01";
      data.Emisor.Domicilio.NumeroInterior.Value = "3";
      data.Emisor.Domicilio.CodigoPostal.Value = "01000";

      Propietario propietario = data.Propietarios.Add();
      propietario.NumeroRegistroTributario.Value = "1321554";
      propietario.ResidenciaFiscal.Value = "USA";

      propietario = data.Propietarios.Add();
      propietario.NumeroRegistroTributario.Value = "1321554";
      propietario.ResidenciaFiscal.Value = "USA";

      data.Receptor.NumeroRegistroTributario.Value = "756985236";
      data.Receptor.Domicilio.Calle.Value = "Allende";
      data.Receptor.Domicilio.Pais.Value = "MEX";
      data.Receptor.Domicilio.Colonia.Value = "0001";
      data.Receptor.Domicilio.Municipio.Value = "001";
      data.Receptor.Domicilio.Referencia.Value = "Referencia";
      data.Receptor.Domicilio.Estado.Value = "AGU";
      data.Receptor.Domicilio.NumeroExterior.Value = "18";
      data.Receptor.Domicilio.Localidad.Value = "01";
      data.Receptor.Domicilio.NumeroInterior.Value = "3";
      data.Receptor.Domicilio.CodigoPostal.Value = "01000";

      Destinatario destinatario = data.Destinatarios.Add();
      destinatario.NumeroRegistroTributario.Value = "756985237";
      destinatario.Nombre.Value = "Destinatario 1";

      HyperSoft.ElectronicDocumentLibrary.Complemento.ComercioExterior.Domicilio domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Morelos";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Juárez";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      destinatario = data.Destinatarios.Add();
      destinatario.NumeroRegistroTributario.Value = "756985238";
      destinatario.Nombre.Value = "Destinatario 2";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Morelos";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Juárez";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      domicilio = destinatario.Domicilios.Add();
      domicilio.Calle.Value = "Madero";
      domicilio.Pais.Value = "MEX";
      domicilio.Colonia.Value = "0001";
      domicilio.Municipio.Value = "001";
      domicilio.Referencia.Value = "Referencia";
      domicilio.Estado.Value = "AGU";
      domicilio.NumeroExterior.Value = "18";
      domicilio.Localidad.Value = "01";
      domicilio.NumeroInterior.Value = "3";
      domicilio.CodigoPostal.Value = "01000";

      Mercancia mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorUnitarioAduana.Value = 7896.26;
      mercancia.UnidadAduana.Value = "01";
      mercancia.CantidadAduana.Value = 5465.051;
      mercancia.ValorDolares.Value = 1;

      DescripcionEspecifica descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A54";
      descripcionEspecifica.NumeroSerie.Value = "TA-1045";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";

      descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A65";
      descripcionEspecifica.NumeroSerie.Value = "TA-1065";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";

      mercancia = data.Mercancias.Add();

      mercancia.FraccionArancelaria.Value = "01011001";
      mercancia.NumeroIdentificacion.Value = "1968";
      mercancia.ValorUnitarioAduana.Value = 7896.26;
      mercancia.UnidadAduana.Value = "01";
      mercancia.CantidadAduana.Value = 5465.051;
      mercancia.ValorDolares.Value = 1;

      descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A54";
      descripcionEspecifica.NumeroSerie.Value = "TA-1045";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";

      descripcionEspecifica = mercancia.DescripcionesEspecificas.Add();
      descripcionEspecifica.SubModelo.Value = "A65";
      descripcionEspecifica.NumeroSerie.Value = "TA-1065";
      descripcionEspecifica.Modelo.Value = "Galaxy";
      descripcionEspecifica.Marca.Value = "Samsung";

      return Base.Save(electronicDocument, "ComercioExterior20_Listas.xml", out fileName);
    }

    private static void CargarDatosCfdi(ElectronicDocumentLibrary.Document.Data data)
    {
      data.Clear();

      // Datos del comprobante ***************************************************************
      data.Version.Value = "4.0";
      data.Serie.Value = "CFDI40";
      data.Folio.Value = "CCE20";
      data.Fecha.Value = DateTime.Now;
      data.FormaPago.Value = "01";
      data.MetodoPago.Value = "PUE";
      data.Moneda.Value = "USD";
      data.LugarExpedicion.Value = "89400";
      data.SubTotal.Value = 100;
      data.TipoComprobante.Value = "I";
      data.TipoCambioMx.Value = 17.295700;
      data.TipoCambioMx.Decimals = 6;
      data.Total.Value = 116.00;
      data.Exportacion.Value = "02";
      // *************************************************************************************

      // Información de los comprobantes fiscales relacionados *******************************
      Relacionados relacionados = data.CfdiRelacionadosExt.Add();
      relacionados.CfdiRelacionados.TipoRelacion.Value = "01";
      relacionados.CfdiRelacionados.Add().Uuid.Value = "A39DA66B-52CA-49E3-879B-5C05185B0EF7";
      // *************************************************************************************

      // Datos del emisor ********************************************************************
      data.Emisor.Rfc.Value = "EKU9003173C9";
      data.Emisor.Nombre.Value = "ESCUELA KEMPER URGATE SA DE CV";
      data.Emisor.RegimenFiscal.Value = "601";
      // *************************************************************************************

      // Datos del Receptor ******************************************************************
      data.Receptor.Rfc.Value = "AAAD770905441";
      data.Receptor.Nombre.Value = "DARIO ALVAREZ ARANDA";
      data.Receptor.RegimenFiscalReceptor.Value = "612";
      data.Receptor.UsoCfdi.Value = "G03";
      data.Receptor.DomicilioFiscalReceptor.Value = "07300";
      // *************************************************************************************

      // Concepto ****************************************************************************
      Concepto concepto = data.Conceptos.Add();
      concepto.Cantidad.Value = 1;
      concepto.ClaveProductoServicio.Value = "78101500";
      concepto.ClaveUnidad.Value = "H87";
      concepto.Descripcion.Value = "ACERO";
      concepto.Importe.Value = 100;
      concepto.NumeroIdentificacion.Value = "1968";
      concepto.ObjetoImpuesto.Value = "02";
      concepto.Unidad.Value = "Pieza";
      concepto.ValorUnitario.Value = 100;

      // Impuestos trasladados del concepto
      TrasladoConcepto trasladoConcepto = concepto.Impuestos.Traslados.Add();
      trasladoConcepto.Base.Value = 100;
      trasladoConcepto.Importe.Value = 16.00;
      trasladoConcepto.Impuesto.Value = "002";
      trasladoConcepto.TipoFactor.Value = "Tasa";
      trasladoConcepto.TasaCuota.Value = 0.160000;

      // Impuestos trasladados ***************************************************************
      Traslado traslado = data.Impuestos.Traslados.Add();
      traslado.Base.Value = 100;
      traslado.Importe.Value = 16.00;
      traslado.Tipo.Value = "002";
      traslado.TipoFactor.Value = "Tasa";
      traslado.TasaCuota.Value = 0.160000;

      data.Impuestos.TotalTraslados.Value = 16.00;
      data.Impuestos.TotalRetenciones.Value = 0;
      // *************************************************************************************
    }
  }
}