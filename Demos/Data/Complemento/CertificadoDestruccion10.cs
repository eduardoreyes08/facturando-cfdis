using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class CertificadoDestruccion10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.CertificadoDestruccion);
      HyperSoft.ElectronicDocumentLibrary.Complemento.CertificadoDestruccion.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.CertificadoDestruccion.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.Serie.Value = "SERIE A";
      data.NumeroFolioDestruccionVehiculo.Value = "FolioDestruccion";

      data.VehiculoDestruido.Marca.Value = "Marca";
      data.VehiculoDestruido.TipoClase.Value = "TipoClase";
      data.VehiculoDestruido.Anio.Value = 2001;
      data.VehiculoDestruido.Modelo.Value = "Modelo";
      data.VehiculoDestruido.Niv.Value = "Niv";
      data.VehiculoDestruido.NumeroSerie.Value = "NumeroSerie";
      data.VehiculoDestruido.NumeroPlacas.Value = "Placas";
      data.VehiculoDestruido.NumeroMotor.Value = "NumeroMotor";
      data.VehiculoDestruido.NumeroFolioTarjetaCirculacion.Value = "FolioTarjeta";

      data.InformacionAduanera.Aduana.Value = "Aduana";
      data.InformacionAduanera.Fecha.Value = DateTime.Now;
      data.InformacionAduanera.Numero.Value = "Numero";

      return Base.Save(electronicDocument, "CertificadoDestruccion.xml", out fileName);
    }
  }
}