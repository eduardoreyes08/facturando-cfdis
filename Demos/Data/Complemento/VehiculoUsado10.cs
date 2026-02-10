using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class VehiculoUsado10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.VehiculoUsado);
      HyperSoft.ElectronicDocumentLibrary.Complemento.VehiculoUsado.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.VehiculoUsado.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.MontoAdquisicion.Value = 1;
      data.MontoEnajenacion.Value = 2;
      data.ClaveVehicular.Value = "A";
      data.Marca.Value = "B";
      data.Tipo.Value = "C";
      data.Modelo.Value = "2005";
      data.NumeroMotor.Value = "E";
      data.NumeroSerie.Value = "F";
      data.Niv.Value = "G";
      data.Valor.Value = 3;

      // Se agrega la información aduadera
      //Concepto 1
      ElectronicDocumentLibrary.Complemento.VehiculoUsado.Importacion importacion = data.InformacionAduanera.Add();
      importacion.Numero.Value = "12345679";
      importacion.Fecha.Value = DateTime.Now;
      importacion.Aduana.Value = "Aduana";

      return Base.Save(electronicDocument, "VehiculoUsado.xml", out fileName);
    }
  }
}