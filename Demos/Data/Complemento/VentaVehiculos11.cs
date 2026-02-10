using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class VentaVehiculos11
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);
      
      Concepto concepto = electronicDocument.Data.Conceptos[0];
      
      // Se agrega el complemento Venta Vehiculos
      concepto.Complementos.Add(ComplementoConceptoType.VentaVehiculos);
      ElectronicDocumentLibrary.Complemento.VentaVehiculos.Data data = (ElectronicDocumentLibrary.Complemento.VentaVehiculos.Data)concepto.Complementos.Last();

      data.Version.Value = "1.1";
      data.ClaveVehicular.Value = "A";
      data.Niv.Value = "a";

      #region Información aduanera
      ElectronicDocumentLibrary.Complemento.VentaVehiculos.Importacion informacionAduanera = data.InformacionAduanera.Add();
      informacionAduanera.Numero.Value = "1";
      informacionAduanera.Fecha.Value = DateTime.Now;
      informacionAduanera.Aduana.Value = "A";

      informacionAduanera = data.InformacionAduanera.Add();
      informacionAduanera.Numero.Value = "2";
      informacionAduanera.Fecha.Value = DateTime.Now;
      informacionAduanera.Aduana.Value = "B";
      #endregion

      #region Parte
      //VentaVehiculos.Partida parte = dataVentaVehiculos.Partes.Add();
      //parte.Cantidad.Value = 1;
      //parte.Unidad.Value = "A";
      //parte.NumeroIdentificacion.Value = "B";
      //parte.Descripcion.Value = "C";
      //parte.ValorUnitario.Value = 2;
      //parte.Importe.Value = 3;

      //parte = dataVentaVehiculos.Partes.Add();
      //parte.Cantidad.Value = 4;
      //parte.Unidad.Value = "D";
      //parte.NumeroIdentificacion.Value = "E";
      //parte.Descripcion.Value = "F";
      //parte.ValorUnitario.Value = 5;
      //parte.Importe.Value = 6;

      //informacionAduanera = parte.InformacionAduanera.Add();
      //informacionAduanera.Numero.Value = "3";
      //informacionAduanera.Fecha.Value = DateTime.Now;
      //informacionAduanera.Aduana.Value = "C"; 
      #endregion

      return Base.Save(electronicDocument, "VentaVehiculos11.xml", out fileName);
    }
  }
}