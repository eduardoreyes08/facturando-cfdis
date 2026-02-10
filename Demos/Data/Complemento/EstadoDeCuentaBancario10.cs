using System;
using HyperSoft.ElectronicDocumentLibrary.Base;
using HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaBancario;
using HyperSoft.ElectronicDocumentLibrary.Document;

namespace HyperSoft.Ejemplo.Data.Complemento
{
  public static class EstadoDeCuentaBancario10
  {
    public static bool Create(ElectronicDocument electronicDocument, out string fileName)
    {
      //En este método se cargan los datos de la factura.
      Cfdi40.CargarDatosCompleto(electronicDocument);

      electronicDocument.Data.Complementos.Add(ComplementoType.EstadoDeCuentaBancario);
      HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaBancario.Data data = (HyperSoft.ElectronicDocumentLibrary.Complemento.EstadoDeCuentaBancario.Data)electronicDocument.Data.Complementos.Last();

      data.Version.Value = "1.0";
      data.NumeroCuenta.Value = 123456789;
      data.NombreCliente.Value = "Emisor Prueba";
      data.Periodo.Value = "Segundo";
      data.Sucursal.Value = "138";

      // Se agregan los Movimientos o Conceptos cubiertos por estado de cuenta bancario que NO cuentan con RFC
      MovimientoNormal normal = data.Movimientos.Normales.Add();
      normal.Fecha.Value = DateTime.Now;
      normal.Referencia.Value = "1032";
      normal.Descripcion.Value = "Disco duro de 500 GB";
      normal.Importe.Value = 1000;
      normal.Moneda.Value = "Pesos";
      normal.SaldoInicial.Value = 28000;
      normal.SaldoAlCorte.Value = 27000;

      // Se agregan los Movimientos o Conceptos cubiertos por estado de cuenta bancario que cuentan con RFC
      MovimientoFiscal fiscal = data.Movimientos.Fiscales.Add();
      fiscal.Fecha.Value = DateTime.Now;
      fiscal.Referencia.Value = "552";
      fiscal.Descripcion.Value = "Procesador AMD";
      fiscal.RfcEnajenante.Value = "XXXX010101XX1";
      fiscal.Importe.Value = 2000;
      fiscal.Moneda.Value = "Pesos";
      fiscal.SaldoInicial.Value = 55000;
      fiscal.SaldoAlCorte.Value = 54000;

      return Base.Save(electronicDocument, "EstadoDeCuentaBancario10.xml", out fileName);
    }
  }
}