using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  internal static class EstadoDeCuentaDeCombustible10
  {
    internal static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.EstadoDeCuentaCombustible);
      HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaDeCombustible.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaDeCombustible.Data)electronicDocument.Data.Complementos.Last();

      // Se cargan los datos
      data.Version.Value = "1.0";
      data.TipoOperacion.Value = "Tarjeta";
      data.NumeroCuenta.Value = "64674-001";
      data.SubTotal.Value = 932.6;
      data.Total.Value = 1081.816;

      // Se agregan los Movimientos o Conceptos cubiertos por estado de cuenta de combustible
      //Concepto 1
      ElectronicDocumentLibrary.Complemento.EstadoDeCuentaDeCombustible.Concepto concepto1 = data.Conceptos.Add();
      concepto1.Identificador.Value = "121365";
      concepto1.Fecha.Value = DateTime.Now;
      concepto1.Rfc.Value = "XXXX010101XX1";
      concepto1.ClaveEstacion.Value = "0000108054";
      concepto1.Cantidad.Value = 100;
      concepto1.NombreCombustible.Value = "Magna";
      concepto1.FolioOperacion.Value = "2001010";
      concepto1.ValorUnitario.Value = 6.33;
      concepto1.Importe.Value = 633;

      // Se agrega un impuesto trasladado
      Traslado traslado1 = concepto1.Traslados.Add();
      traslado1.Tipo.Value = "IVA";
      traslado1.Tasa.Value = 16;
      traslado1.Importe.Value = 101.28;

      //Concepto 2
      ElectronicDocumentLibrary.Complemento.EstadoDeCuentaDeCombustible.Concepto concepto2 = data.Conceptos.Add();
      concepto2.Identificador.Value = "121366";
      concepto2.Fecha.Value = DateTime.Now;
      concepto2.Rfc.Value = "XXXX010102XX1";
      concepto2.ClaveEstacion.Value = "0000108055";
      concepto2.Cantidad.Value = 40;
      concepto2.NombreCombustible.Value = "Premium";
      concepto2.FolioOperacion.Value = "2001010";
      concepto2.ValorUnitario.Value = 7.49;
      concepto2.Importe.Value = 299.6;

      // Se agrega un impuesto trasladado
      Traslado traslado2 = concepto2.Traslados.Add();
      traslado2.Tipo.Value = "IVA";
      traslado2.Tasa.Value = 16;
      traslado2.Importe.Value = 149.216;

      return Base.Save(electronicDocument, "EstadoDeCuentaDeCombustible10.xml", out fileName);
    }
  }
}