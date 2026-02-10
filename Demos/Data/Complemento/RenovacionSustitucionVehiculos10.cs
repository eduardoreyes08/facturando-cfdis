using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class RenovacionSustitucionVehiculos10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.RenovacionSustitucionVehiculos);
      HyperSoft.ElectronicDocumentLibrary.Complemento.RenovacionSustitucionVehiculos.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.RenovacionSustitucionVehiculos.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.TipoDecreto.Value = "01";

      data.DecretoRenovacion.VehiculoEnajenado.Value = "01";

      HyperSoft.ElectronicDocumentLibrary.Complemento.RenovacionSustitucionVehiculos.Renovacion.VehiculoUsado vehiculoUsado = data.DecretoRenovacion.VehiculoUsado.Add();
      vehiculoUsado.Precio.Value = 100000;
      vehiculoUsado.TipoVehiculo.Value = "01";
      vehiculoUsado.Marca.Value = "Kenworth";
      vehiculoUsado.TipoClase.Value = "Tractocamión";
      vehiculoUsado.Anio.Value = 2014;
      vehiculoUsado.Modelo.Value = "T680";
      vehiculoUsado.Niv.Value = "1234567890";
      vehiculoUsado.NumeroSerie.Value = "9BKDLB9X9WF00009";
      vehiculoUsado.NumeroPlacas.Value = "999BP9";
      vehiculoUsado.NumeroMotor.Value = "GTS99999";
      vehiculoUsado.NumeroFolioTarjetaCirculacion.Value = "00106059734";
      vehiculoUsado.NumeroPedimentoImportacion.Value = "ASDRFSF345FDF";
      vehiculoUsado.Aduana.Value = "Tijuana";
      vehiculoUsado.FechaRegularizacion.Value = DateTime.Now;
      vehiculoUsado.FolioFiscal.Value = "9087478A-4D34-4F59-B5B8-FA4540456727";

      vehiculoUsado = data.DecretoRenovacion.VehiculoUsado.Add();
      vehiculoUsado.Precio.Value = 100000;
      vehiculoUsado.TipoVehiculo.Value = "01";
      vehiculoUsado.Marca.Value = "Kenworth";
      vehiculoUsado.TipoClase.Value = "Tractocamión";
      vehiculoUsado.Anio.Value = 2015;
      vehiculoUsado.Modelo.Value = "T680";
      vehiculoUsado.Niv.Value = "1234567890";
      vehiculoUsado.NumeroSerie.Value = "2BKDLB2X2WF00002";
      vehiculoUsado.NumeroPlacas.Value = "222BP2";
      vehiculoUsado.NumeroMotor.Value = "GTS22222";
      vehiculoUsado.NumeroFolioTarjetaCirculacion.Value = "00106059732";
      vehiculoUsado.NumeroPedimentoImportacion.Value = "ASDRFSF245FQR";
      vehiculoUsado.Aduana.Value = "Tijuana";
      vehiculoUsado.FechaRegularizacion.Value = DateTime.Now;
      vehiculoUsado.FolioFiscal.Value = "9087578A-5D35-5F59-B5B8-FA5550556727";

      data.DecretoRenovacion.VehiculoNuevo.Anio.Value = 2016;
      data.DecretoRenovacion.VehiculoNuevo.Modelo.Value = "T1000";
      data.DecretoRenovacion.VehiculoNuevo.NumeroPlacas.Value = "777BP7";
      data.DecretoRenovacion.VehiculoNuevo.Rfc.Value = "AAA010101AAA";


      data.DecretoSustitucion.VehiculoEnajenado.Value = "01";

      data.DecretoSustitucion.VehiculoUsado.Precio.Value = 80000;
      data.DecretoSustitucion.VehiculoUsado.TipoVehiculo.Value = "01";
      data.DecretoSustitucion.VehiculoUsado.Marca.Value = "Kenworth";
      data.DecretoSustitucion.VehiculoUsado.TipoClase.Value = "Tractocamión";
      data.DecretoSustitucion.VehiculoUsado.Anio.Value = 2010;
      data.DecretoSustitucion.VehiculoUsado.Modelo.Value = "T1100";
      data.DecretoSustitucion.VehiculoUsado.Niv.Value = "1234567890";
      data.DecretoSustitucion.VehiculoUsado.NumeroSerie.Value = "1BKDLB1X1WF00001";
      data.DecretoSustitucion.VehiculoUsado.NumeroPlacas.Value = "111BP1";
      data.DecretoSustitucion.VehiculoUsado.NumeroMotor.Value = "GTS12345";
      data.DecretoSustitucion.VehiculoUsado.NumeroFolioTarjetaCirculacion.Value = "00106049731";
      data.DecretoSustitucion.VehiculoUsado.NumeroFolioAvisoIntencion.Value = "00123456789";
      data.DecretoSustitucion.VehiculoUsado.NumeroPedimentoImportacion.Value = "ASDRFSF123FMX";
      data.DecretoSustitucion.VehiculoUsado.Aduana.Value = "Tijuana";
      data.DecretoSustitucion.VehiculoUsado.FechaRegularizacion.Value = DateTime.Now;
      data.DecretoSustitucion.VehiculoUsado.FolioFiscal.Value = "9187478A-4D34-4F59-B5B8-FA4541456123";

      data.DecretoSustitucion.VehiculoNuevo.Anio.Value = 2016;
      data.DecretoSustitucion.VehiculoNuevo.Modelo.Value = "T1200";
      data.DecretoSustitucion.VehiculoNuevo.NumeroPlacas.Value = "123BP0";
      data.DecretoSustitucion.VehiculoNuevo.Rfc.Value = "AAA010101AAA";

      return Base.Save(electronicDocument, "RenovacionSustitucionVehiculos.xml", out fileName);
    }
  }
}